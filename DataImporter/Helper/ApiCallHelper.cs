using Newtonsoft.Json;

namespace DataImporter.Helper
{
    public class ApiCallHelper
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<T> GetAsync<T>(string apiUrl)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(responseBody);
                }
                else
                {
                    Console.WriteLine($"API Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return default(T);
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
                return default(T);
            }
        }
    }
}
