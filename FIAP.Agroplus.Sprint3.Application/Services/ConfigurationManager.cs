using Microsoft.Extensions.Configuration;

namespace FIAP.Agroplus.Sprint3.Application.Services;

public class ConfigurationManager
{

    private readonly IConfiguration _configuration;

    private ConfigurationManager(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    private static ConfigurationManager _instance;
    
    public static ConfigurationManager GetInstance(IConfiguration configuration)
    {
        if (_instance == null)
        {
            _instance = new ConfigurationManager(configuration);
        }
        return _instance;
    }

    public string GetSetting(string key)
    {
        return _configuration[key];
    }
}
