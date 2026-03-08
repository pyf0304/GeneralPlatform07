using com.taishsoft.common;
using CommFunc4WebForm;


using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.Entity;
using GeneralPlatform.Webform;
using QuestionnaireWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuestionnaireWeb
{
    public partial class JumpPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsSysParaEN.strCompanyName = clsTSysParaBLEx.getCompanyName(clsMyConfig.spSchool);
            }
            CheckUserAndJumpPage();
        }
        private void CheckUserAndJumpPage()
        {
          
            string strMsg = "";
            //检查用户Id是否为合法
            if (string.IsNullOrEmpty(qsUserId) == true)
            {
                 strMsg = string.Format("用户不能为空！");
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //检查功能名称是否为空
            if (string.IsNullOrEmpty(qsFunctionName) == true)
            {
                 strMsg = string.Format("功能不能为空！");
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

            //获取用户Id的角色，如果角色为空，就警告退出
            getUserId = qsUserId;
            clsCommonSession.RoleId = clsQxUsersBLEx.GetRoleIdList(qsUserPrjId, getUserId);

            string strRoleId = clsCommonSession.RoleId;
            //通过计算获得
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                 strMsg = string.Format("用户：{0}的角色为空，无权处理相关功能！", qsUserId);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }


            string strCollegeId = "";
            if (string.IsNullOrEmpty(qsUserPrjId) == false)
            {
                clsQxProjectsEN objProjectsEN = clsQxProjectsBL.GetObjByQxPrjIdCache(qsUserPrjId);
                if (objProjectsEN == null)
                {
                    strMsg = string.Format("专业Id：{0}所代表的专业为空，请与管理员联系！({1})", 
                        qsUserPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    clsPubVar.objLog.WriteDebugLog("/ExamLib/webform/JumpPage.aspx?出错信息：" + strMsg);
                    //return;
                }
               
                getUserPrjId = qsUserPrjId;
            }
            else
            {
                strCollegeId = qsCollegeId;
            }
            string strCourseChapterId;
            //if (string.IsNullOrEmpty(qsCourseChapterId) == true)
            //{
            //    strCourseChapterId = "00000065";
            //}
            //else
            //{
            strCourseChapterId = qsCourseChapterId;
            //}
            string strQueryString = string.Format("FunctionName={7}&UserId={9}&PrjId={2}&CourseExamPaperId={5}&StuId={12}&Id_Stu={13}&QuestionId={8}&CourseChapterId={10}&PrevPageName={11}&QuestionnaireSetId={3}&MajorMenuId={4}&UserPrjId={1}&id_Projects={1}&CollegeId={0}&ButtonType={6}&Learner={14}&CourseKnowledgeId={15}",
                                strCollegeId, qsUserPrjId, qsPrjId, 
                                qsQuestionnaireSetId, qsMajorMenuId,
                                qsCourseExamPaperId, qsButtonType,
                                qsFunctionName, qsQuestionId,
                                getUserId,
                                strCourseChapterId,
                                qsPrevPageName,
                                qsStuId,
                                qsId_Stu,
                                qsLearner,
                                qsCourseKnowledgeId);
            clsPubVar.objLog.WriteDebugLog("/GP/webform/JumpPage.aspx?" + strQueryString);
            string strLinkPageName = "";
            //string strCondition = "";
            //long lngId_Case_Resource_Rel = 0;
            //string result = "";
            switch (qsFunctionName)
            {
               
                case "TestTheme":
                    strLinkPageName = string.Format("MP4TeachingResource/WebForm1.aspx?{0}",
                        strQueryString);

                    break;
                case "问卷集-显示":
                case "Questionnaire-Disp":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("Questionnaire-Disp", false, "", "", strQueryString, this);

                    break;

                case "Questionnaire-Edit":
                case "问卷集-编辑"://VideoResLib-Edit
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("Questionnaire-Edit", false, "", "", strQueryString, this);
                    break;

               
                case "QuestionnaireByCourseExamPaperId-Edit":
                case "试卷习题题库-编辑":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("QuestionnaireByCourseExamPaperId-Edit", false, "", "", strQueryString, this);
                    break;
                case "UserMan":
                case "用户管理":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("UserMan", false, "", "", strQueryString, this);
                    break;
                case "User-Disp"://User-Disp 用户查看 
                case "用户查看":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("User-Disp", false, "", "", strQueryString, this);
                    break;
                case "UserMan_All":
                case "所有用户管理":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("UserMan_All", false, "", "", strQueryString, this);
                    break;
                case "User-Disp_All"://User-Disp 用户查看 
                case "所有用户查看":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("User-Disp_All", false, "", "", strQueryString, this);
                    break;
                case "User_SchoolMan"://                User_SchoolMan 用户(学校)管理
                case "用户(学校)管理":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("User_SchoolMan", false, "", "", strQueryString, this);
                    break;
                case "User_School-Disp":////User_School-Disp 用户(学校)查看
                case "用户(学校)查看":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("User_School-Disp", false, "", "", strQueryString, this);
                    break;

                case "UserRoleMan"://UserRoleMan 用户角色管理 
                case "用户角色管理":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("UserRoleMan", false, "", "", strQueryString, this);
                    break;
                case "SetRole4User"://SetRole4User 为用户设置角色 
                case "为用户设置角色":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("SetRole4User", false, "", "", strQueryString, this);
                    break;
                case "SetRole4User-Teacher"://SetRole4User-Teacher 为用户设置角色-教师  
                case "为用户设置角色-教师":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("SetRole4User-Teacher", false, "", "", strQueryString, this);
                    break;

                case "SetUsers4Role"://SetUsers4Role 为角色配用户  
                case "为角色配用户":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("SetUsers4Role", false, "", "", strQueryString, this);
                    break;
                case "DepartmentMan"://DepartmentMan 部门管理  
                case "部门管理":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("DepartmentMan", false, "", "", strQueryString, this);
                    break;

                case "QxPrjUserRelation-Edit":
                case "工程用户关系-维护"://VideoResLib-Edit
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("QxPrjUserRelation-Edit", false, "", "", strQueryString, this);
                    break;
                case "PaperReferExamLib":
                case "试卷引用题目"://OneExamPaperTopic-Edit
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("PaperReferExamLib", false, "", "", strQueryString, this);
                    break;
                case "OneQxPrjUserRelation-Edit":
                case "单套工程用户关系-维护"://OneExamPaperTopic-Edit
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("OneQxPrjUserRelation-Edit", false, "", "", strQueryString, this);
                    break;
                case "OneExamPaperTopic2-Edit":
                case "单套试卷题目Topic"://OneExamPaperTopic-Edit
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("OneExamPaperTopic2-Edit", false, "", "", strQueryString, this);
                    break;
                case "OneExamPaperTopic-Edit":
                case "试卷题目可视化"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("OneExamPaperTopic-Edit", false, "", "", strQueryString, this);
                    break;
                case "DoingExercises-1Q":
                case "做题一道"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("DoingExercises-1Q", false, "", "", strQueryString, this);
                    break;
                case "DoingExercises-1Paper":
                case "做题一套":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("DoingExercises-1Paper", false, "", "", strQueryString, this);
                    break;
               
                case "CurrEduCls-Edit":
                case "教学班-编辑"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("CurrEduCls-Edit", false, "", "", strQueryString, this);
                    break;
                case "CurrEduCls-Disp-Teacher"://CurrEduCls-Disp-Teacher 教学班-显示-教师 
                case "教学班-显示-教师"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("CurrEduCls-Disp-Teacher", false, "", "", strQueryString, this);
                    break;
                case "CurrEduClsStu-Edit":
                case "教学班学生-编辑"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("CurrEduClsStu-Edit", false, "", "", strQueryString, this);
                    break;
                case "CurrEduClsStu-Edit-Teacher"://CurrEduClsStu-Edit-Teacher 教学班学生-编辑-教师 
                case "教学班学生-编辑-教师"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("CurrEduClsStu-Edit-Teacher", false, "", "", strQueryString, this);
                    break;
                case "CurrEduClsTeacher-Edit":
                case "教学班教师-编辑"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("CurrEduClsTeacher-Edit", false, "", "", strQueryString, this);
                    break;
                case "Knowledge-Edit":
                case "知识点-编辑"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("Knowledge-Edit", false, "", "", strQueryString, this);
                    break;
                case "Knowledge-Disp-Student"://Knowledge-Disp-Student 知识点-显示-学生 
                case "知识点-显示-学生"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("Knowledge-Disp-Student", false, "", "", strQueryString, this);
                    break;
                case "Knowledge-Disp-Teacher"://Knowledge-Disp-Teacher 知识点-显示-教师
                case "知识点-显示-教师"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("Knowledge-Disp-Teacher", false, "", "", strQueryString, this);
                    break;
                case "KnowledgeLearn-Student"://KnowledgeLearn-Student 知识点学习情况-学生
                case "知识点学习情况-学生"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("KnowledgeLearn-Student", false, "", "", strQueryString, this);
                    break;
                case "KnowledgeLearn-Teacher"://KnowledgeLearn-Teacher 知识点学习情况-教师
                case "知识点学习情况-教师"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("KnowledgeLearn-Teacher", false, "", "", strQueryString, this);
                    break;
                

                case "KnowledgeLearn-Detail-Student"://KnowledgeLearn-Detail-Student 知识点学习情况-详细-学生
                case "知识点学习情况-详细-学生"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("KnowledgeLearn-Detail-Student", false, "", "", strQueryString, this);
                    break;
                case "KnowledgeLearn-Detail-Teacher"://KnowledgeLearn-Detail-Teacher 知识点学习情况-详细-教师
                case "知识点学习情况-详细-教师"://
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("KnowledgeLearn-Detail-Teacher", false, "", "", strQueryString, this);
                    break;

                case "ExamLibKnowledge-Edit":
                case "题库知识点-编辑"://ExamLibKnowledge-Edit
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("ExamLibKnowledge-Edit", false, "", "", strQueryString, this);
                    break;
                case "KnowledgeExamLib-Edit":
                case "知识点题库-编辑"://ExamLibKnowledge-Edit
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("KnowledgeExamLib-Edit", false, "", "", strQueryString, this);
                    break;
                case "QuestionnaireByCourse-LowEdit":
                case "课程题库-一般编辑":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("QuestionnaireByCourse-LowEdit", false, "", "", strQueryString, this);
                    break;
                case "OneQxPrjUserRelation-Edit-List"://OneQxPrjUserRelation-Edit-List 单套工程用户关系-维护-列表
                case "单套工程用户关系-维护-列表":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("OneQxPrjUserRelation-Edit-List", false, "", "", strQueryString, this);
                    break;
                case "MenuSet":
                case "菜单设置":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("MenuSet", false, "", "", strQueryString, this);
                    break;
                case "SetRoleMenu":
                case "设置角色菜单":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("SetRoleMenu", false, "", "", strQueryString, this);
                    break;
                case "PotenceSymbolMan"://PotenceSymbolMan 权限标志管理
                case "权限标志管理":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("PotenceSymbolMan", false, "", "", strQueryString, this);
                    break;
                case "MenuSet-Edit":
                case "菜单集维护":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("MenuSet-Edit", false, "", "", strQueryString, this);
                    break;
                case "QueryFinishWork-Student":
                case "作业完成情况-学生":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("QueryFinishWork-Student", false, "", "", strQueryString, this);
                    break;
                case "QueryFinishWork-Teacher":
                case "作业完成情况-教师":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("QueryFinishWork-Teacher", false, "", "", strQueryString, this);
                    break;

                case "QueryWorkTotal-Student":
                case "作业情况汇总-学生":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("QueryWorkTotal-Student", false, "", "", strQueryString, this);
                    break;
                case "QueryWorkTotal-Teacher":
                case "作业情况汇总-教师":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("QueryWorkTotal-Teacher", false, "", "", strQueryString, this);
                    break;


                case "PotenceTypeMan":
                case "权限类型管理":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("PotenceTypeMan", false, "", "", strQueryString, this);
                    break;
                case "PotenceMan":
                case "权限管理":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("PotenceMan", false, "", "", strQueryString, this);
                    break;
                case "SetPotence4Role":
                case "为角色配权限":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("SetPotence4Role", false, "", "", strQueryString, this);
                    break;
             
              
                case "QueryPotenceTypeMan-Teacher":
                case "习题完成情况-教师":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("QueryPotenceTypeMan-Teacher", false, "", "", strQueryString, this);
                    break;
                case "SetFieldVisibility":
                case "设置字段可视性":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("SetFieldVisibility", false, "", "", strQueryString, this);
                    break;
                case "QuestionType-Edit"://QuestionType-Edit  题型-编辑
                case "题型-编辑":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("QuestionType-Edit", false, "", "", strQueryString, this);
                    break;
                case "SetDefaultPapersBigTopic":// SetDefaultPapersBigTopic 设置默认题型
                case "设置默认题型":
                    strLinkPageName = clsPubFun.GetLinkPageNameByFunctionName("SetDefaultPapersBigTopic", false, "", "", strQueryString, this);
                    break;
                default:
                     strMsg = string.Format("功能：{0}不正确，请与管理员联系！({1})", 
                         qsFunctionName,
                         clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
            }
            getUserId = qsUserId;
            Response.Redirect(strLinkPageName);
        }

        /// <summary>
        /// 项目名称。例如：“教学资源库”、教育高地等
        ///             根据不同的项目名称，可能设置不同的主题
        /// 作者：潘以锋
        /// 建立日期：2014-08-30
        /// </summary>
        public string qsPrjName
        {
            get
            {
                if (Request.QueryString["PrjName"] != null)
                {
                    return Request.QueryString["PrjName"].ToString().Trim();
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
        /// 专业Id。例如：“0051”等
        ///         根据专业Id，可以获取相关的学院
        /// 作者：潘以锋
        /// 建立日期：2014-08-30
        /// </summary>
        public string qsUserPrjId
        {
            get
            {
                if (Request.QueryString["UserPrjId"] != null)
                {
                    return Request.QueryString["UserPrjId"].ToString().Trim();
                }
                return "";
            }
        }

        /// <summary>
        /// 专业Id。例如：“0051”等
        ///         根据专业Id，可以获取相关的学院
        /// 作者：潘以锋
        /// 建立日期：2014-08-30
        /// </summary>
        public string qsQuestionnaireSetId
        {
            get
            {
                if (Request.QueryString["QuestionnaireSetId"] != null)
                {
                    return Request.QueryString["QuestionnaireSetId"].ToString().Trim();
                }
                return "";
            }
        }

        /// <summary>
        /// 专业Id。例如：“0051”等
        ///         根据专业Id，可以获取相关的学院
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
        /// <summary>
        /// 案例Id。例如：“00000051”等
        /// 作者：潘以锋
        /// 建立日期：2014-09-12
        /// </summary>
        public string qsCaseId
        {
            get
            {
                if (Request.QueryString["CaseId"] != null)
                {
                    return Request.QueryString["CaseId"].ToString().Trim();
                }
                return "";
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
        /// 学院Id。例如：“0023”等
        ///         
        /// 作者：潘以锋
        /// 建立日期：2015-03-08
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
        /// 用户Id。例如：“pyf”, "lyl"等
        ///         
        /// 作者：潘以锋
        /// 建立日期：2014-08-30
        /// </summary>
        public string qsUserId
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
        /// 课程章Id。例如：“00000065”等
        ///         
        /// 作者：潘以锋
        /// 建立日期：2015-3-8
        /// </summary>
        public string qsCourseChapterId
        {
            get
            {
                if (Request.QueryString["CourseChapterId"] != null)
                {
                    return Request.QueryString["CourseChapterId"].ToString().Trim();
                }
                return "";
            }
        }
        /// <summary>
        /// 按钮类型。例如：“1”，“2”等
        ///        
        /// 作者：潘以锋
        /// 建立日期：2015-01-29
        /// </summary>
        public string qsButtonType
        {
            get
            {
                if (Request.QueryString["ButtonType"] != null)
                {
                    return Request.QueryString["ButtonType"].ToString().Trim();
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
        /// 前一页面名称
        ///        
        /// 作者：潘以锋
        /// 建立日期：2015-03-16
        /// </summary>
        public string qsPrevPageName
        {
            get
            {
                if (Request.QueryString["PrevPageName"] != null)
                {
                    return Request.QueryString["PrevPageName"].ToString().Trim();
                }
                return "";
            }
        }
        /// <summary>
        /// 学生学号
        ///        
        /// 作者：潘以锋
        /// 建立日期：2015-05-03
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
        /// 学生流水号
        ///        
        /// 作者：潘以锋
        /// 建立日期：2015-05-04
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
        /// 知识点Id。例如：“00000005”等         
        /// 作者：潘以锋
        /// 建立日期：2015-6-22
        /// </summary>
        public string qsCourseKnowledgeId
        {
            get
            {
                if (Request.QueryString["CourseKnowledgeId"] != null)
                {
                    return Request.QueryString["CourseKnowledgeId"].ToString().Trim();
                }
                return "";
            }
        }
        /// <summary>
        /// 学习者Id，指学生等学习者。例如：“0310276”等         
        /// 作者：潘以锋
        /// 建立日期：2015-6-22
        /// </summary>
        public string qsLearner
        {
            get
            {
                if (Request.QueryString["Learner"] != null)
                {
                    return Request.QueryString["Learner"].ToString().Trim();
                }
                return "";
            }
        }

        /// <summary>
        /// 根据传递参数和选择参数决定的用户工程Id
        /// 功能：如果选择参数不为空，就返回选择参数用户工程Id，
        ///       否则就返回传递参数用户工程Id
        /// </summary>
        protected string getUserPrjId
        {
            get
            {
                if (string.IsNullOrEmpty(clsCommonSession.UserPrjId4get) == false) return clsCommonSession.UserPrjId4get;
                if (string.IsNullOrEmpty(qsUserPrjId) == false) return qsUserPrjId;
                return "";
            }
            set
            {
                clsCommonSession.UserPrjId4get = value;
            }
        }

        ///// <summary>
        ///// 用户选择的工程Id。例如：“0150”等
        ///// 作者：潘以锋
        ///// 建立日期：2016-07-01
        ///// </summary>
        //public string qsUserPrjId
        //{
        //    get
        //    {
        //        if (Request.QueryString["UserPrjId"] != null)
        //        {
        //            return Request.QueryString["UserPrjId"].ToString().Trim();
        //        }
        //        return "";
        //    }
        //}
    }
}