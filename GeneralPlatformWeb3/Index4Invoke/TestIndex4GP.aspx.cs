using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;



public partial class TestIndex4GP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //string strid = ""; //"1000000000shnuneusoft";
        //string strmudol = "";//"ky_kyxt";
        string strurl = "Index_quick.aspx?userid=t01&key=0a3597ba2700b5abe3ec0d0ba2c2b9c1";
        Response.Redirect(strurl);
    }


    //public string RoleID
    //{
    //    get
    //    {
    //        //if (!String.IsNullOrEmpty(getUserId))
    //        //{
    //        //    if (string.IsNullOrEmpty(clsCommonSession.RoleId) == true)
    //        //    {
    //        //        clsCommonSession.RoleId = clsQxUserEx.GetQxRoleList(getUserId);
    //        //    }
    //        //    return clsCommonSession.RoleId;
    //        //}
    //        return "";
    //    }
    //}


    protected void lbTest_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=TestTheme&UserPrjId=0150&CaseId=00000003&QuestionnaireSetId=0012&MajorMenuId=00000008&QuestionnaireSetId=Light_gray&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbQuestionnaire_Disp_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=Questionnaire-Disp&UserPrjId=0150&PrjId=&QuestionnaireSetId=0012&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbQuestionnaire_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=Questionnaire-Edit&UserPrjId=0150&PrjId=&QuestionnaireSetId=0012&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }


    protected void lbUserMan_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=UserMan&UserPrjId=0150&PrjId=00000007&QuestionnaireSetId=0012&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lblbQxPrjUserRelation_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=QxPrjUserRelation-Edit&UserPrjId=0150&PrjId=00000007&QuestionnaireSetId=0012&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbOnelbQxPrjUserRelation_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=OneQxPrjUserRelation-Edit&UserPrjId=0150&PrjId=&CourseExamPaperId=00000005&QuestionnaireSetId=0012&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbOneExamPaperTopic2_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=OneExamPaperTopic2-Edit&UserPrjId=0150&PrjId=&CourseExamPaperId=00000005&QuestionnaireSetId=0012&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbOneExamPaperTopic_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=OneExamPaperTopic-Edit&UserPrjId=0150&PrjId=00000007&CourseExamPaperId=00000005&QuestionnaireSetId=0012&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }
    protected void lbQuestionnaireByCourseExamPaperId_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=QuestionnaireByCourseExamPaperId-Edit&UserPrjId=0150&PrjId=00000007&CourseExamPaperId=00000006&QuestionnaireSetId=0012&MajorMenuId=00000008&ButtonType=2";
        Response.Redirect(strLinkPageName);
    }

    protected void lbDoingExercises_1Q_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&UserPrjId=0150&PrjId={2}&CourseExamPaperId={3}&QuestionnaireSetId=0012&MajorMenuId=00000008&QuestionId={4}",
              "0310276",
            "DoingExercises-1Q",
            "00000014",
            "00000040",
            "00000163");
        //"0310276",
        //"DoingExercises-1Q",
        //"00000014",
        //"00000029",
        //"00000043");
        Response.Redirect(strLinkPageName);
    }

    protected void lbDoingExercises_1Paper_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&UserPrjId=0150&PrjId=00000007&CourseExamPaperId=00000005&QuestionnaireSetId=0012&MajorMenuId=00000008",
            "00701",
            "DoingExercises-1Paper");
        Response.Redirect(strLinkPageName);
    }

    protected void lbCurrEduCls_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=CurrEduCls-Edit&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbCurrEduClsStu_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=CurrEduClsStu-Edit&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbCurrEduClsTeacher_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=CurrEduClsTeacher-Edit&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbKnowledge_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=Knowledge-Edit&PrjId=00000005&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbExamLibKnowledge_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=ExamLibKnowledge-Edit&PrjId=00000005&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbQuestionnaireByCourse_LowEdit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=QuestionnaireByCourse-LowEdit&UserPrjId=0150&PrjId=00000005&QuestionnaireSetId=0012&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbPaperReferExamLib_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=PaperReferExamLib&UserPrjId=0150&PrjId=00000007&CourseExamPaperId=00000005&QuestionnaireSetId=0012&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbKnowledgeExamLib_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=KnowledgeExamLib-Edit&PrjId=00000005&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbSetRoleMenu_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=SetRoleMenu&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbFinishWork_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName=PotenceSymbolMan&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
            "0310276");
        Response.Redirect(strLinkPageName);
    }

    protected void lbMenuSet_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=MenuSet-Edit&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbKnowledge_Disp_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=Knowledge-Disp&PrjId=00000005&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbPotenceTypeMan_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName=PotenceTypeMan&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
          "00701");
        Response.Redirect(strLinkPageName);
    }

    protected void lbPotenceMan_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName=PotenceMan&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
        "00701");
        Response.Redirect(strLinkPageName);
    }

    protected void lbSetPotence4Role_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName=SetPotence4Role&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
       "00701");
        Response.Redirect(strLinkPageName);
    }

    protected void lbSetFieldVisibility_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
            "00701",
            "SetFieldVisibility");
        Response.Redirect(strLinkPageName);
    }
    /// <summary>
    /// PotenceSymbolMan 权限标志管理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbPotenceSymbolMan_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
            "00701",
            "PotenceSymbolMan");
        Response.Redirect(strLinkPageName);
    }

    protected void lbQueryPotenceTypeMan_Teacher_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
              "00701",
              "QueryPotenceTypeMan-Teacher");
        Response.Redirect(strLinkPageName);
    }

    protected void lbQueryFinishWork_Student_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
            "0310276",
              "QueryFinishWork-Student");
        Response.Redirect(strLinkPageName);
    }

    protected void lbQueryFinishWork_Teacher_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
             "00701",
             "QueryFinishWork-Teacher");
        Response.Redirect(strLinkPageName);
    }


    protected void lbKnowledge_Disp_Student_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
             "0310276",
             "Knowledge-Disp-Student");
        Response.Redirect(strLinkPageName);
    }

    protected void lbKnowledge_Disp_Teacher_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
             "00701",
             "Knowledge-Disp-Teacher");
        Response.Redirect(strLinkPageName);
    }

    protected void lbUser_Disp_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&UserPrjId=0150&PrjId=00000007&QuestionnaireSetId=0012&MajorMenuId=00000008",
            "00701",
            "User-Disp");
        Response.Redirect(strLinkPageName);
    }

  

    protected void lbCurrEduCls_Disp_Teacher_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
            "00701",
          "CurrEduCls-Disp-Teacher");
        Response.Redirect(strLinkPageName);
    }

    protected void lbCurrEduClsStu_Edit_Teacher_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
            "t1",
            "CurrEduClsStu-Edit-Teacher");
        Response.Redirect(strLinkPageName);
    }
    /// <summary>
    /// UserRoleMan 用户角色管理 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbUserRoleMan_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
     "00701",
     "UserRoleMan");
        Response.Redirect(strLinkPageName);
    }
    /// <summary>
    /// SetRole4User 为用户设置角色
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbSetRole4User_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
            "00701",
            "SetRole4User");
        Response.Redirect(strLinkPageName);
    }

    protected void lbSetRole4User_Teacher_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
            "t1",
            "SetRole4User-Teacher");
        Response.Redirect(strLinkPageName);
    }
    /// <summary>
    /// KnowledgeLearn-Student 知识点学习情况-学生
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbKnowledgeLearn_Student_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
         "0310276",
         "KnowledgeLearn-Student");
        Response.Redirect(strLinkPageName);
    }
    /// <summary>
    /// KnowledgeLearn-Teacher 知识点学习情况-教师
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbKnowledgeLearn_Teacher_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId={2}&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
       "t1",
       "KnowledgeLearn-Teacher",
       "00000005");
        Response.Redirect(strLinkPageName);
    }

    protected void lbQuestionType_Edit_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
             "t1",
              "QuestionType-Edit");
        Response.Redirect(strLinkPageName);
    }

    protected void lbSetUsers4Role_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=00000007&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
           "00701",
            "SetUsers4Role");
        Response.Redirect(strLinkPageName);
    }
    /// <summary>
    /// DepartmentMan 部门管理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbDepartmentMan_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=00000007&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
           "00701",
            "DepartmentMan");
        Response.Redirect(strLinkPageName);
    }
    /// <summary>
    /// KnowledgeLearn-Detail-Student 知识点学习情况-详细-学生
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbKnowledgeLearn_Detail_Student_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
        "0310276",
        "KnowledgeLearn-Detail-Student");
        Response.Redirect(strLinkPageName);
    }

    /// <summary>
    /// KnowledgeLearn-Detail-Teacher 知识点学习情况-详细-教师

    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbKnowledgeLearn_Detail_Teacher_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId={2}&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
              "t1",
              "KnowledgeLearn-Detail-Teacher",
              "00000005");
        Response.Redirect(strLinkPageName);
    }


    protected void lbSetDefaultPapersBigTopic_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
         "00701",
         "SetDefaultPapersBigTopic");
        Response.Redirect(strLinkPageName);
    }



    protected void lbQueryWorkTotal_Teacher_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
            "00701",
            "QueryWorkTotal-Teacher");
        Response.Redirect(strLinkPageName);
    }

    protected void lbQueryWorkTotal_Student_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
            "0310276",
            "QueryWorkTotal-Student");
        Response.Redirect(strLinkPageName);
    }
    /// <summary>
    /// MenuSet 菜单设置
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbMenuSet_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&PrjId=&UserPrjId=0150&CollegeId=00000007&MajorMenuId=00000008",
           "00701",
           "MenuSet");
        Response.Redirect(strLinkPageName);
    }
    /// <summary>
    /// User_SchoolMan 用户管理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbUser_SchoolMan_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=User_SchoolMan&UserPrjId=0150&PrjId=00000007&QuestionnaireSetId=0012&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }
    /// <summary>
    /// User_School-Disp 用户查看
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbUser_School_Disp_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&UserPrjId=0150&PrjId=00000007&QuestionnaireSetId=0012&MajorMenuId=00000008",
          "00701",
          "User_School-Disp");
        Response.Redirect(strLinkPageName);
    }

    protected void lbUserMan_All_Click(object sender, EventArgs e)
    {
        string strLinkPageName = "~/Webform/JumpPage.aspx?UserId=00701&FunctionName=UserMan_All&UserPrjId=0150&PrjId=00000007&QuestionnaireSetId=0012&MajorMenuId=00000008";
        Response.Redirect(strLinkPageName);
    }

    protected void lbUser_Disp_All_Click(object sender, EventArgs e)
    {
        string strLinkPageName = string.Format("~/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&UserPrjId=0150&PrjId=00000007&QuestionnaireSetId=0012&MajorMenuId=00000008",
            "00701",
            "User-Disp_All");
        Response.Redirect(strLinkPageName);
    }
}
