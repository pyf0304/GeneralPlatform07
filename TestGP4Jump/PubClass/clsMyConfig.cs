using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

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
    public static string spUserPrjId
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strUserPrjId = appSettings.Settings["UserPrjId"].Value;
            return strUserPrjId;
        }
    }
    public static string spSPJumpWebSite
    {
        get
        {
            System.Configuration.Configuration rootWebConfig =
System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

            AppSettingsSection appSettings =
    rootWebConfig.AppSettings as AppSettingsSection;
            Console.WriteLine("Section name: {0}",
                   appSettings.SectionInformation.SectionName);
            string strSPJumpWebSite = appSettings.Settings["SPJumpWebSite"].Value;
            return strSPJumpWebSite;
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


}
