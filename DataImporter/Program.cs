using System.Reflection;
using System.Xml.Linq;
using DataImporter.Config;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

#region URL

ConfigHelper configHelper = new ConfigHelper();

Config config = configHelper.GetConfig();

Console.WriteLine($"Name: {config.application.name}");
Console.WriteLine($"Environment: {config.application.environment}");
Console.WriteLine("Providers:");

#endregion


foreach (var provider in config.application.provider)
{
    Console.WriteLine($"  - {provider}");

    Dictionary<string, string> response = await SendHttpRequest(provider);
    if (response["contentType"].Contains("application/json"))
    {
        Root tasksData = ConvertToTaskModel(response["responseBody"]);
    } 
    if (response["contentType"].Contains("application/xml"))
    {
        Root tasksData = ConvertXmlToModel(response["responseBody"]);
    }

    List<Task> tasks = new List<Task>();

    // Yanıtı konsola yazdırma
    Console.WriteLine("Response:");
    Console.WriteLine(response);
    int x = 0;
}

async Task<Dictionary<string, string>> SendHttpRequest(string url)
{
    using (HttpClient httpClient = new HttpClient())
    {
        try
        {
            // GET isteği gönderme
            HttpResponseMessage response = await httpClient.GetAsync(url);

            // Yanıtın başarılı olup olmadığını kontrol etme
            response.EnsureSuccessStatusCode();

            // Yanıtı string olarak alma
            string responseBody = await response.Content.ReadAsStringAsync();
            string contentType = response.Content.Headers.ContentType.ToString();
            Dictionary<string, string> resultDictionary = new Dictionary<string, string>
            {
                { "responseBody", responseBody },
                { "contentType", contentType }
            };

            return resultDictionary;
        }
        catch (HttpRequestException ex)
        {
            // Hata durumunda hata mesajını konsola yazdırma
            Console.WriteLine($"Hata oluştu: {ex.Message}");
            return null;
        }
    }
}
static Root ConvertToTaskModel(string data)
{
    Root tasks = JsonConvert.DeserializeObject<Root>(data);

    return tasks;
}
static Root ConvertXmlToModel(string xmlData)
{
    string jsonData = JsonConvert.SerializeXNode(XDocument.Parse(xmlData));

    Root model = JsonConvert.DeserializeObject<Root>(jsonData);

    return model;
}
public class Root
{
    public List<Task> tasks { get; set; }
}

public class Task
{
    public string name { get; set; }
    public int duration { get; set; }
}

