using YamlDotNet.Serialization;

namespace DataImporter.Config
{
    public class Config
    {
        public Application application { get; set; }

      

    }

    public class Application
    {
        public string name { get; set; }
        public string environment { get; set; }
        public List<string> provider { get; set; }
    }

    public class ConfigHelper
    {
        public Config GetConfig()
        {
            var configPath = "C:\\Users\\Berkant AYAR\\source\\repos\\MyWorkSpace\\DataImporter\\Config\\Config.yaml";
            string yamlContent = File.ReadAllText(configPath);
            var deserializer = new DeserializerBuilder().Build();
            var config = deserializer.Deserialize<Config>(yamlContent);
            return config;
        }
    }
}
