using System.Configuration;
using System.IO;
using System.Threading;

public class ListTextException
{
    /// <summary>
    /// Load file JSON 
    /// </summary>
    public static ListTextException Load()
    {
        string suffix = string.Empty;

        switch (Thread.CurrentThread.CurrentUICulture.Name.ToLower())
        {
            case "en-us":
                suffix = "en";
                break;
            default:
                suffix = "en";
                break;
        }

        string path = Path.Combine(ConfigurationManager.AppSettings["PathExceptionTextConfigurations"], string.Format("TextException.{0}.json", suffix));
        string jsonContent = File.ReadAllText(path);
        return Newtonsoft.Json.JsonConvert.DeserializeObject<ListTextException>(jsonContent);
    }

    /// <summary>
    /// 
    /// </summary>
    public Listofexception[] ListOfException { get; set; }
}

public class Listofexception
{
    /// <summary>
    /// Key of the message exception
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Message to exception
    /// </summary>
    public string value { get; set; }
}

