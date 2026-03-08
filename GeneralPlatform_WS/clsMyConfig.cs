using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using GeneralPlatform.BusinessLogic;

/// <summary>
/// clsMyConfig 的摘要说明
/// </summary>
public class clsMyConfig
{
    public static string strWebConfigPath = @"~\ConnStr\";

    public clsMyConfig()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public static long lngMaxFileSize
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);
            
            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName); 
            string strMaxFileSize = appSettings.Settings["lngMaxFileSize"].Value;
            return long.Parse(strMaxFileSize);
        }
    }
    public static string strWebFileDir
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strWebFileDir = appSettings.Settings["strWebFileDir"].Value;
            return strWebFileDir;
        }
    }
    public static string CurrPrjId
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strCurrPrjId = appSettings.Settings["CurrPrjId"].Value;
            return strCurrPrjId;
        }
    }
    /// <summary>
    /// 当前的IP地址和端口，用于用户统一平台
    /// </summary>
    public static string CurrIPAddressAndPort
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strCurrIPAddressAndPort = appSettings.Settings["CurrIPAddressAndPort"].Value;
            return strCurrIPAddressAndPort;
        }
    }
    /// <summary>
    /// 当前的虚拟目录，用于用户统一平台
    /// </summary>
    public static string CurrPrx
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strCurrPrx = appSettings.Settings["CurrPrx"].Value;
            return strCurrPrx;
        }
    }
    public static string strUploadFileDir
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strUploadFileDir = appSettings.Settings["strUploadFileDir"].Value;
            return strUploadFileDir;
        }
    }
    public static string strDownloadFileDir
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strDownloadFileDir = appSettings.Settings["strDownloadFileDir"].Value;
            return strDownloadFileDir;
        }
    }
    public static  string SiteName
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["sitename"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["sitename"].ToString();
            }
            else
            {
                return "上海师范大学";
            }
        }
    }
    /// <summary>
    /// 学校名称
    /// </summary>
    public static string spSchool
    {
        get
        {
            //string strLoginMode = clsTSysParaBLEx.GetCurrSchool();
            //return strLoginMode;
            if (System.Configuration.ConfigurationManager.AppSettings["School"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["School"].ToString();
            }
            else
            {
                return "SHNU";
            }
        }
    }
 
    /// <summary>
    /// 样例Xls文件名，用于复制生成XLS用，用于ODBC的Excel导出
    /// </summary>
    public static string SamXlsFileName
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string SamXlsFileName = appSettings.Settings["SamXlsFileName"].Value;
            return SamXlsFileName;
        }
    }



    /// <summary>
    /// 当前的虚拟目录，用于用户统一平台LogDir4Debug
    /// </summary>
    public static bool IsDebug4PubDatabase
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["IsDebug4PubDatabase"] != null)
            {
                return bool.Parse(System.Configuration.ConfigurationManager.AppSettings["IsDebug4PubDatabase"].ToString());
            }
            else
            {
                return false;
            }

        }
    }

    /// <summary>
    /// Debug的日志目录，用于用户统一平台
    /// </summary>
    public static string LogDir4Debug
    {
        get
        {
            if (System.Configuration.ConfigurationManager.AppSettings["LogDir4Debug"] != null)
            {
                return System.Configuration.ConfigurationManager.AppSettings["LogDir4Debug"].ToString();
            }
            else
            {
                return "";
            }

        }
    }
}
