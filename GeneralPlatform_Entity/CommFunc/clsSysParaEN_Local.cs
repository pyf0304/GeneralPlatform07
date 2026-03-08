using System;
using System.Text;
using System.Collections;
using com.taishsoft.commdbforxml;
using com.taishsoft.common;

namespace GeneralPlatform.Entity
{
	/// <summary>
	/// clsSysPara 的摘要说明。
	/// </summary>
	public class clsSysParaEN_Local
    {
        public static clsLog objLog = null;// new clsLog();

        public static string CurrPrjId = "0001";
        public static string strCompanyName = "";//该统一平台的使用单位
        public static string strXMLFolder = @"~\XML\";
		public static string strXMLFileName = "";	//用于定义SQL存储过程的XML文件名称。
        public static string UpLoadFilesWebFolder = @"~/UpLoadFiles/";
        public static string UploadWebFolder
        {
            get
            {
                return UpLoadFilesWebFolder;
            }
        }

        public static string strTempXMLFileName = "";
        /// <summary>
        /// 用于定义SQL存储过程的XML文件名称
        /// </summary>
        public static string strXmlSpParaFileName;	//用于定义SQL存储过程的XML文件名称。
        
        //Xml数据源
        public static string strXmlDataSourceFileName = "";
        public static clsSpecSQLforXml objSpecSqlForXml = null;
        public static bool bolIsUseXmlDataSource = false;
        ///连接串名称
        public static string strConnectStrName = "";
        public static bool bolIsUseConnectStrName = false;

		public static string ConfigFileName;
		//临时文件目录FOR WEB
		public static string TempWebFolder = @"~\TempFiles\";
		public static string TempFileFolder;	//临时文件物理目录
		public static string FileSvrFileName;
		public static string strBasicDesc = "基层信息";
		public static string ErrorPage = "~/Webform/ErrorMsg.aspx";
		public static string SuccessPage = "~/Webform/success.aspx";
		public static string strExamYear;	//当前考核年
		public static string strCurrEngagePeriodId;	//当前聘期Id
		public static string strCurrEngagePeriodName;	//当前聘期名称
		public static ArrayList arrCurrEngagePeriodYear;	//当前聘期年列表


        //<!-- 用户类型有：高校（University)、中小学(MiddleSchool)、医院(Hospital)、企业(Enterprise) -->
        //<add key="UserType" value="Hospital"/>
        public static string strUserType = "University";

        public clsSysParaEN_Local()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
	}
}
