using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;



using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using GeneralPlatform.Webform;

/// <summary>
/// 完成公共的Web底层，没有特殊功能
/// </summary>
public abstract class CommWebBase : System.Web.UI.Page
{
   
    /// <summary>
    /// 系统所在的学校
    /// </summary>
    public string School
    {
        get
        {
            return clsMyConfig.spSchool;
        }
    }

    /// <summary>
    /// 系统所在的学校
    /// </summary>
    public bool IsVisitor
    {
        get
        {
            if (clsCommonSession.UserId == "visitor")
                return true;
            return false;
        }
    }

    public string isVisiablePlan
    {
        get
        {
            if (ViewState["plan"] != null)
            {
                if (String.CompareOrdinal(ViewState["plan"].ToString(), "1") == 0)
                {
                    return "1";
                }
            }
            return "0";
        }
        set
        {
            ViewState["plan"] = value;
        }
    }
 
    private int hasVisit
    {
        get
        {
            if (ViewState["hasVisit"] != null)
            {
                return Convert.ToInt32(ViewState["hasVisit"].ToString());
            }
            return 0;
        }
        set
        {
            ViewState["hasVisit"] = value;
        }
    }
    /// <summary>
    /// 当前操作用户的Id_User,如果是教师就返回Id_Teacher,如果是学生就返回Id_StudentInfo。
    /// </summary>
    protected string vsUserId
    {
        get
        {
            string sUserId;
            sUserId = (string)ViewState["UserId"];
            if (sUserId == null)
            {
                sUserId = "";
            }
            return sUserId;
        }
        set
        {
            string sUserId = value;
            ViewState.Add("UserId", sUserId);
        }
    }


    /// <summary>
    /// 案例名称。
    /// </summary>
    protected string vsCaseName
    {
        get
        {
            string sCaseName;
            sCaseName = (string)ViewState["CaseName"];
            if (sCaseName == null)
            {
                sCaseName = "";
            }
            return sCaseName;
        }
        set
        {
            string sCaseName = value;
            ViewState.Add("CaseName", sCaseName);
        }
    }

    /// <summary>
    /// 案例拥有者Id。
    /// </summary>
    protected string vsOwnerId
    {
        get
        {
            string sOwnerId;
            sOwnerId = (string)ViewState["OwnerId"];
            if (sOwnerId == null)
            {
                sOwnerId = "";
            }
            return sOwnerId;
        }
        set
        {
            string sOwnerId = value;
            ViewState.Add("OwnerId", sOwnerId);
        }
    }
    /// <summary>
    /// 当前记录案例日志-Mid。
    /// </summary>
    protected string vsLogMid
    {
        get
        {
            string sLogMid;
            sLogMid = (string)ViewState["LogMid"];
            if (sLogMid == null)
            {
                sLogMid = "";
            }
            return sLogMid;
        }
        set
        {
            string sLogMid = value;
            ViewState.Add("LogMid", sLogMid);
        }
    }


    #region 参数





    #region 课例ID
    /// <summary>
    /// 课例ID
    /// </summary>
    public string vsId_Case
    {
        get
        {
            if (ViewState["Id_Case"] != null)
            {
                return ViewState["Id_Case"].ToString().Trim();
            }
            return "";

        }
        set
        {
            ViewState["Id_Case"] = value;
        }
    }
    #endregion

   


    #endregion
   

    /// <summary>
    /// 当前操作：添加(Add)、修改(Update)、删除(Delete)、查询(Query)等。
    /// </summary>
    protected string vsCurrOperate
    {
        get
        {
            string sCurrOperate;
            sCurrOperate = (string)ViewState["CurrOperate"];
            if (sCurrOperate == null)
            {
                sCurrOperate = "";
            }
            return sCurrOperate;
        }
        set
        {
            string sCurrOperate = value;
            ViewState.Add("CurrOperate", sCurrOperate);
        }
    }
 
   
    #region 与教学资源库相关
    /// <summary>
    /// 专业Id。例如：“0051”等
    ///         根据专业Id,可以获取相关的学院
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsCollegeId
    {
        get
        {
            if (Request.QueryString["CollegeId"] != null)
            {
                return Request.QueryString["CollegeId"].ToString().Trim();
            }
            return "";
        }
    }
    /// <summary>
    /// 专业Id。例如：“0051”等
    ///         根据专业Id,可以获取相关的学院
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsMajorId
    {
        get
        {
            if (Request.QueryString["MajorId"] != null)
            {
                return Request.QueryString["MajorId"].ToString().Trim();
            }
            return "";
        }
    }


    /// <summary>
    /// 当前操作的教师流水号
    /// </summary>
    protected string vsId_Teacher
    {
        get
        {
            string sId_Teacher;
            sId_Teacher = (string)ViewState["Id_Teacher"];
            if (sId_Teacher == null)
            {
                sId_Teacher = "";
            }
            return sId_Teacher;
        }
        set
        {
            string sId_Teacher = value;
            ViewState.Add("Id_Teacher", sId_Teacher);
        }
    }

    /// <summary>
    /// 学生Id
    /// 作者：潘以锋
    /// 建立日期：2016-07-15
    /// </summary>
    public string qsStuId
    {
        get
        {
            if (Request.QueryString["StuId"] != null)
            {
                return Request.QueryString["StuId"].ToString().Trim();
            }
            return "";
        }
    }

    /// <summary>
    /// 学生Id
    /// 作者：潘以锋
    /// 建立日期：2016-07-15
    /// </summary>
    public string qsId_Stu
    {
        get
        {
            if (Request.QueryString["Id_Stu"] != null)
            {
                return Request.QueryString["Id_Stu"].ToString().Trim();
            }
            return "";
        }
    }
    /// <summary>
    /// 学生Id（用于记录用户自己选择的学生Id)
    /// </summary>
    protected string vsStuId
    {
        get
        {
            string sStuId;
            sStuId = (string)ViewState["StuId"];
            if (sStuId == null)
            {
                sStuId = "";
            }
            return sStuId;
        }
        set
        {
            string sStuId = value;
            ViewState.Add("StuId", sStuId);
        }
    }
  


    /// <summary>
    /// 课程Id（用于记录用户自己选择的课程Id)
    /// </summary>
    protected string vsPrjId
    {
        get
        {
            string sPrjId;
            sPrjId = (string)ViewState["PrjId"];
            if (sPrjId == null)
            {
                sPrjId = "";
            }
            return sPrjId;
        }
        set
        {
            string sPrjId = value;
            ViewState.Add("PrjId", sPrjId);
        }
    }
    /// <summary>
    /// 课程Id。例如：“00510023”等
    ///         
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsPrjId
    {
        get
        {
            if (Request.QueryString["PrjId"] != null)
            {
                return Request.QueryString["PrjId"].ToString().Trim();
            }
            return "";
        }
    }

    /// <summary>
    /// 是否返回前台显示。例如：“True”表示需要返回前台等
    ///         
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsIsReturnDispPage
    {
        get
        {
            if (Request.QueryString["IsReturnDispPage"] != null)
            {
                return Request.QueryString["IsReturnDispPage"].ToString().Trim();
            }
            return "";
        }
    }


    /// <summary>
    /// 专业Id。例如：“0051”等
    ///         根据专业Id,可以获取相关的学院
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsThemeName
    {
        get
        {
            if (Request.QueryString["ThemeName"] != null)
            {
                return Request.QueryString["ThemeName"].ToString().Trim();
            }
            return "";
        }
    }

    /// <summary>
    /// 专业Id。例如：“0051”等
    ///         根据专业Id,可以获取相关的学院
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsMajorMenuId
    {
        get
        {
            if (Request.QueryString["MajorMenuId"] != null)
            {
                return Request.QueryString["MajorMenuId"].ToString().Trim();
            }
            return "";
        }
    }
    #endregion


    /// <summary>
    /// 根据传递参数和选择参数决定的课程Id
    /// 功能：如果选择参数不为空，就返回选择参数课程Id，
    ///       否则就返回传递参数课程Id
    /// </summary>
    protected string getUserId
    {
        get
        {
            if (string.IsNullOrEmpty(clsCommonSession.UserId4get) == false) return clsCommonSession.UserId4get;
            if (string.IsNullOrEmpty(qsUserId) == false) return qsUserId;
            return "";
        }
        set
        {
            clsCommonSession.UserId4get = value;
        }
    }
    /// <summary>
    /// 用户Id。例如：“pyf”, "lyl"等
    ///         
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    private string qsUserId
    {
        get
        {
            if (Request.QueryString["UserId"] != null)
            {
                return Request.QueryString["UserId"].ToString().Trim();
            }
            return "";
        }
    }

    /// <summary>
    /// 用户Id。例如：“pyf”, "lyl"等
    ///         
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    protected string qsUserId_Public
    {
        get
        {
            if (Request.QueryString["UserId"] != null)
            {
                return Request.QueryString["UserId"].ToString().Trim();
            }
            return "";
        }
    }
    /// <summary>
    /// 功能名称。例如：“视频资源库-显示”、“视频资源库-后台编辑”、“教学案例资源库-显示”、“教学案例资源库-后台编辑”等
    ///         根据不同的功能名称，可能调用不同的页面
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsFunctionName
    {
        get
        {
            if (Request.QueryString["FunctionName"] != null)
            {
                return Request.QueryString["FunctionName"].ToString().Trim();
            }
            return "";
        }
    }

    /// <summary>
    /// 试卷习题Id。例如：“00000005”等
    ///         
    /// 作者：潘以锋
    /// 建立日期：2015-1-28
    /// </summary>
    public string qsCourseExamPaperId
    {
        get
        {
            if (Request.QueryString["CourseExamPaperId"] != null)
            {
                return Request.QueryString["CourseExamPaperId"].ToString().Trim();
            }
            return "";
        }
    }
    /// <summary>
    /// 题目Id
    ///        
    /// 作者：潘以锋
    /// 建立日期：2015-02-03
    /// </summary>
    public string qsQuestionId
    {
        get
        {
            if (Request.QueryString["QuestionId"] != null)
            {
                return Request.QueryString["QuestionId"].ToString().Trim();
            }
            return "";
        }
    }
    /// <summary>
    /// 锚点
    /// </summary>
    protected string qsAnchor
    {
        get
        {
            string strAnchor = Request.QueryString["Anchor"] ?? "".ToString();
            if ((strAnchor != null) && (strAnchor != ""))
            {
                return strAnchor;//Request.QueryString["id"] ?? "";
            }
            else
            {
                return "";
            }
        }
    }
    protected string qsQuestionnaireBatchId
    {
        get
        {
            string strQuestionnaireBatchId = Request.QueryString["BatchId"] ?? "".ToString();
            if ((strQuestionnaireBatchId != null) && (strQuestionnaireBatchId != ""))
            {
                return strQuestionnaireBatchId;//Request.QueryString["id"] ?? "";
            }
            else
            {
                return "";
            }
        }
    }
    /// <summary>
    /// 操作方式
    ///      包括：Edit、Copy等
    /// </summary>
    protected string qsOperate
    {
        get
        {
            string strOperate = Request.QueryString["Operate"] ?? "".ToString();
            if ((strOperate != null) && (strOperate != ""))
            {
                return strOperate;//Request.QueryString["id"] ?? "";
            }
            else
            {
                return "";
            }
        }
    }
}