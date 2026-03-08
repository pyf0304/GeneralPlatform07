using com.taishsoft.common;
using CommFunc4WebForm;
using GeneralPlatform.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using com.taishsoft.web;
using MSWeb.Webform;
using com.taishsoft.web.treeview;

using System.Reflection;
using com.taishsoft.util;

namespace GeneralPlatform.web.treeview
{
    /// <summary>
    /// 树模式
    /// </summary>
    public enum TreeModel
    {
        NULL,

        /// <summary>
        /// 学院--年级
        /// </summary>
        COLLEGE_GRADE,	//学院--年级


        /// <summary>
        /// 学院--用户
        /// </summary>
        COLLEGE_USER,	                    //学院--用户
        /// <summary>
        /// 年级--学院--专业
        /// </summary>
        GRADEBASE_COLLEGE_MAJOR,                //年级--学院--专业


        /// <summary>
        /// 年级--学院--专业二专
        /// </summary>
        GRADE_COLLEGE_MAJORSECMAJOR,        //年级--学院--专业二专

        /// <summary>
        /// 年级--专业4教学计划
        /// </summary>
        GRADEBASE_MAJOR4JxTheahingPlan,	//年级--专业4教学计划

        /// <summary>
        /// 权限类型
        /// </summary>
        RIGHTTYPE,				            //权限类型
        /// <summary>
        /// 权限类型--权限
        /// </summary>
        RIGHTTYPE_RIGHT,				    //权限类型--权限
        /// <summary>
        /// 角色
        /// </summary>
        QXUSERROLE,                             //角色

        /// <summary>
        /// 角色
        /// </summary>
        vQxUserRoles,                             //角色     
         
                                                  /// <summary>
                                                  /// 用户
                                                  /// </summary>
        QxUsers,                             //用户


        /// <summary>
        /// 部门-用户
        /// </summary>
        QxDepartmentInfo_QxUsers,                             //部门-用户

        /// <summary>
        /// 用户组-用户
        /// </summary>
        QxUserGroups_QxUsers,                             //用户组-用户


        /// <summary>
        /// 角色，带用户数
        /// </summary>
        vQxUserRolesByUserNum,                              //角色，带用户数

                                                            /// <summary>
                                                            /// 角色，带菜单数
                                                            /// </summary>
        vQxRolesByMenuNum,                              //角色，带菜单数

        /// <summary>
        /// 角色，带权限数
        /// </summary>
        vQxUserRolesByPotenceNum,                              //角色，带权限数

        /// <summary>
        /// 部门，带用户数
        /// </summary>
        vQxDepartmentInfoByUserNum,                              //部门，带用户数
        /// <summary>
        /// 菜单上、下层
        /// </summary>
        QxPrjMenuUp_Sub,                              //菜单上、下层

        /// <summary>
        /// 菜单上、下层、第三层
        /// </summary>
        QxPrjMenuUp_Sub_Leaf,                              //菜单上、下层、第三层

        
        /// <summary>
        /// 菜单集-菜单上、下层
        /// </summary>
        QxPrjMenuSet_QxPrjMenuUp_Sub,                              //菜单集-菜单上、下层

        /// <summary>
        /// 角色-用户
        /// </summary>
        ROLE_USER,				            //角色-用户
        /// <summary>
        /// 学校
        /// </summary>
        SCHOOL,
        /// <summary>
        /// 学校-学院
        /// </summary>
        SCHOOL_COLLEGE,                //学校-学院

        /// <summary>
        /// 学校-课程-年级-批次-成绩统计模式
        /// </summary>
        SCHOOL_COURSE_GRADE_EXAMBATCH_CJSTATAMODE,         //学校-成绩统计模式

        /// <summary>
        /// 学校-课程-年级-成绩统计模式-批次
        /// </summary>
        SCHOOL_COURSE_GRADE_CJSTATAMODE_EXAMBATCH,         //学校-课程-年级-成绩统计模式-批次

        /// <summary>
        /// 学校-年级-成绩统计模式-课程-批次
        /// </summary>
        Project_UserRole,         //项目-用户角色


        ///// <summary>
        ///// 学校-学院-年级
        ///// </summary>
        //SCHOOL_COLLEGE_GRADE,			//学校-学院-年级
        /// <summary>
        /// 学校-学院-年级-专业
        /// </summary>
        SCHOOL_GRADEBASE_MAJOR,			//学校-年级-专业
      
        /// <summary>
        /// 学校-学院-专业-年级
        /// </summary>
        SCHOOL_COLLEGE_MAJOR_GRADE,			//学校-学院-专业-年级
        /// <summary>
        /// 学校-年级
        /// </summary>
        SCHOOL_GRADE,  //学校-年级
        /// <summary>
        /// 学校+年级(入学)
        /// </summary>
        SCHOOL_GRADEBASE,  //学校-年级(入学)
        /// <summary>
        /// 学校-年级+年级(入学)
        /// </summary>
        SCHOOL_GRADE__GRADEBASE,  //学校-年级+年级(入学)
        
        /// <summary>
        /// XLS数据导入表
        /// </summary>
        XLSDATAIMPORTTAB        //XLS数据导入表

    };
    //public enum TreeNodeType
    //{
    //    NULL,       //不能确定的结点类型
    //    SCHOOL,     //学校
    //    COLLEGE,    //学院
    //    MAJOR,      //专业
    //    SUBJECTDIRECTION,		//学科方向
    //    EXAMBATCH,      //考试批次
    //    EXAMSTATSBATCH, //考试统计批次
    //    GRADE,      //年级
    //    GRADEBASE,      //年级(入学)
    //    MAJORGRADE, //专业年级
    //    COURSE, //课程
    //    COURSETYPE, //课程类型
    //    CJSTATSMODE, //成绩统计方式
    //    CURREDUCLASS,   //当前教学班
    //    BUILD,      //教学楼
    //    ROLE,   		//角色
    //    USER,	    	//用户
    //    RIGHTTYPE,	    	//权限类型
    //    RIGHT,	    	//权限
    //    AUSER           //用户

    //};

    public delegate void AfterSelect_Tz(object sender, clsEventArgs4TreeView e);


    [Serializable]
    public class TreeNodeData
    {
        private string mstrErrMsg = "";

        private string mstrId_School = "";
        private string mstrId_College = "";
        private string mstrDepartmentId = "";

        private string mstrMenuIdUp = "";
        private string mstrMenuIdSub = "";
        private string mstrMenuIdLeaf = "";

        private string mstrId_Major = "";
        private string mstrId_MajorGrade = "";
        private string mstrRoleId = "";
        private string mstrGroupId = "";

        private string mstrPotenceTypeId = "";

        private string mstrPotenceId = "";
        private string mstrUserId = "";

        private string mstrQxPrjId = "";
        private string mstrMenuSetId = "";
        private string mstrId_AdminCls = "";
        private string mstrId_CrsType = "";
        private string mstrid_CrsTypeAdminType = "";
        private string mstrid_StudentType = "";
        private string mstrId_UniZone = "";
        private string mstrId_Build = "";
        private string mstrid_TpTemplet = "";
        private string mstrid_TpXxTemplet = "";     //选修课模式ID
        private string mstrid_EduClsCollect = "";   //教学班集合ID
        private string mstrid_xkEduCls = "";    //选课教学班ID
        private string mstrid_EduClass = "";    //选课教学班ID
        private string mstrid_TeachPlanSeries = ""; //教学计划课程系列ID
        private string mstrid_SeriesGroup = "";	//教学计划系列组ID
        private string mstrid_GroupReqMode = "";	//教学计划系列组模式ID
        private string mstrid_Role = "";	//角色ID
        private string mstrid_User = "";	//用户ID
        private string mstrid_RightType = "";	//权限类型ID
        private string mstrid_Right = "";	//权限ID
        private string mstrid_PKaoExamGroup = "";//排考考试组流水号
        private string mstrCollegeCondition = "";   //学院条件串
        /// <summary>
        /// 学院条件串
        /// </summary>
        public string CollegeCondition
        {
            get { return mstrCollegeCondition; }
            set { clsSysPara4TreeView.strCollegeCondition = value; }
        }


        protected string mstrid_Tab;            //XLS导入表ID

        protected string mstrid_PkScheGroup;        //排课组ID
        protected string mstrid_TeachingPlan;

        /// <summary>
        /// 教学计划流水号
        /// </summary>
        public string id_TeachingPlan
        {
            get
            {
                return mstrid_TeachingPlan;
            }
            set
            {
                if (value == "")
                {
                    mstrid_TeachingPlan = value;
                }
                else
                {
                    mstrid_TeachingPlan = value;
                }
            }
        }

     
        /// <summary>
        /// 学校流水号
        /// </summary>
        public string Id_School
        {
            get
            {
                return mstrId_School;
            }
            set
            {
                 mstrId_School = value;
            }
        }
        /// <summary>
        /// 学院流水号
        /// </summary>
        public string Id_College
        {
            get
            {
                return mstrId_College;
            }
            set
            {
                clsSysPara4TreeView.strId_College = value;
            }
        }
        /// <summary>
        /// 部门Id
        /// </summary>
        public string DepartmentId
        {
            get
            {
                return mstrDepartmentId;
            }
            set
            {
                mstrDepartmentId = value;
            }
        }

        /// <summary>
        /// 专业流水号
        /// </summary>
        public string Id_Major
        {
            get
            {
                return mstrId_Major;
            }
            set
            {
                mstrId_Major = value;
            }
        }
        /// <summary>
        /// 顶层菜单Id
        /// </summary>
        public string MenuIdUp
        {
            get
            {
                return mstrMenuIdUp;
            }
            set
            {
                mstrMenuIdUp = value;
            }
        }

        /// <summary>
        /// 顶层菜单Id
        /// </summary>
        public string MenuIdLeaf
        {
            get
            {
                return mstrMenuIdLeaf;
            }
            set
            {
                mstrMenuIdLeaf = value;
            }
        }
        /// <summary>
        ///子菜单Id
        /// </summary>
        public string MenuIdSub
        {
            get
            {
                return mstrMenuIdSub;
            }
            set
            {
                mstrMenuIdSub = value;
            }
        }
        /// <summary>
        /// 角色Id
        /// </summary>
        public string RoleId
        {
            get
            {
                return mstrRoleId;
            }
            set
            {
                mstrRoleId = value;
            }
        }

        /// <summary>
        /// 组Id
        /// </summary>
        public string GroupId
        {
            get
            {
                return mstrGroupId;
            }
            set
            {
                mstrGroupId = value;
            }
        }
        /// <summary>
        /// 	考试统计批次ID
        /// </summary>
        public string PotenceTypeId
        {
            get
            {
                return mstrPotenceTypeId;
            }
            set
            {
                mstrPotenceTypeId = value;
            }
        }
        /// <summary>
        /// 课程流水号Id
        /// </summary>
        public string PotenceId
        {
            get
            {
                return mstrPotenceId;
            }
            set
            {
                mstrPotenceId = value;
            }
        }

        /// <summary>
        /// 统计方式Id
        /// </summary>
        public string UserId
        {
            get
            {
                return mstrUserId;
            }
            set
            {
                mstrUserId = value;
            }
        }
        /// <summary>
        /// 工程Id
        /// </summary>
        public string QxPrjId
        {
            get
            {
                return mstrQxPrjId;
            }
            set
            {
                mstrQxPrjId = value;
            }
        }
        /// <summary>
        /// 菜单集Id
        /// </summary>
        public string MenuSetId
        {
            get
            {
                return mstrMenuSetId;
            }
            set
            {
                mstrMenuSetId = value;
            }
        }
        /// <summary>
        /// 专业年级流水号
        /// </summary>
        public string Id_MajorGrade
        {
            get
            {
                return mstrId_MajorGrade;
            }
            set
            {
                mstrId_MajorGrade = value;
            }
        }

        /// <summary>
        /// 行政班流水号
        /// </summary>
        public string Id_AdminCls
        {
            get
            {
                return mstrId_AdminCls;
            }
            set
            {
                mstrId_AdminCls = value;
            }
        }

        /// <summary>
        /// 课程类型流水号
        /// </summary>
        public string Id_CrsType
        {
            get
            {
                return mstrId_CrsType;
            }
            set
            {
                mstrId_CrsType = value;
            }
        }

        /// <summary>
        /// 课程类型管理类型流水号
        /// </summary>
        public string Id_CrsTypeAdminType
        {
            get
            {
                return mstrid_CrsTypeAdminType;
            }
            set
            {
                mstrid_CrsTypeAdminType = value;
            }
        }

        /// <summary>
        /// 学生类型流水号
        /// </summary>
        public string Id_StudentType
        {
            get
            {
                return mstrid_StudentType;
            }
            set
            {
                mstrid_StudentType = value;
            }
        }

        /// <summary>
        /// 校区流水号
        /// </summary>
        public string Id_UniZone
        {
            get
            {
                return mstrId_UniZone;
            }
            set
            {
                mstrId_UniZone = value;
            }
        }

        /// <summary>
        /// 教学楼流水号
        /// </summary>
        public string Id_Build
        {
            get
            {
                return mstrId_Build;
            }
            set
            {
                mstrId_Build = value;
            }
        }
        /// <summary>
        /// 教学计划模板流水号
        /// </summary>
		public string Id_TpTemplet
        {
            get
            {
                return mstrid_TpTemplet;
            }
            set
            {
                mstrid_TpTemplet = value;
            }
        }

        /// <summary>
        /// 教学计划。。。模板流水号
        /// </summary>
        public string Id_TpXxTemplet
        {
            get
            {
                return mstrid_TpXxTemplet;
            }
            set
            {
                mstrid_TpXxTemplet = value;
            }
        }
        /// <summary>
        /// 教学班集合流水号
        /// </summary>
		public string Id_EduClsCollect  //教学班集合ID
        {
            get
            {
                return mstrid_EduClsCollect;
            }
            set
            {
                mstrid_EduClsCollect = value;
            }
        }

        /// <summary>
        /// 选课教学班流水号
        /// </summary>
        public string Id_xkEduCls   //选课教学班ID
        {
            get
            {
                return mstrid_xkEduCls;
            }
            set
            {
                mstrid_xkEduCls = value;
            }
        }

        /// <summary>
        /// 教学班流水号
        /// </summary>
        public string Id_EduClass   //当前教学班ID
        {
            get
            {
                return mstrid_EduClass;
            }
            set
            {
                mstrid_EduClass = value;
            }
        }

        /// <summary>
        /// 排课组流水号
        /// </summary>
        public string Id_PkScheGroup    //选课教学班ID
        {
            get
            {
                return mstrid_PkScheGroup;
            }
            set
            {
                mstrid_PkScheGroup = value;
            }
        }

        /// <summary>
        /// Xls表ID
        /// </summary>
        public string Id_XlsTab //Xls表ID
        {
            get
            {
                return mstrid_Tab;
            }
            set
            {
                mstrid_Tab = value;
            }
        }

        /// <summary>
        /// 教学计划系列流水号
        /// </summary>
        public string id_TeachPlanSeries
        {
            get
            {
                return mstrid_TeachPlanSeries;
            }
            set
            {
                if (value == "")
                {
                    mstrid_TeachPlanSeries = value;
                }
                else
                {
                    mstrid_TeachPlanSeries = value;
                }
            }
        }

        /// <summary>
        /// 系列分组流水号
        /// </summary>
        public string Id_SeriesGroup
        {
            get
            {
                return mstrid_SeriesGroup;
            }
            set
            {
                mstrid_SeriesGroup = value;
            }
        }

        /// <summary>
        /// 分组需求模式
        /// </summary>
		public string Id_GroupReqMode
        {
            get
            {
                return mstrid_GroupReqMode;
            }
            set
            {
                mstrid_GroupReqMode = value;
            }
        }
        /// <summary>
        /// 角色流水号
        /// </summary>
        public string Id_Role
        {
            get
            {
                return mstrid_Role;
            }
            set
            {
                mstrid_Role = value;
            }
        }
        /// <summary>
        /// 用户流水号
        /// </summary>
        public string Id_User
        {
            get
            {
                return mstrid_User;
            }
            set
            {
                mstrid_User = value;
            }
        }
        /// <summary>
        /// 权限类型流水号
        /// </summary>
        public string Id_RightType
        {
            get
            {
                return mstrid_RightType;
            }
            set
            {
                mstrid_RightType = value;
            }
        }
        /// <summary>
        /// 权限流水号
        /// </summary>
        public string Id_Right
        {
            get
            {
                return mstrid_Right;
            }
            set
            {
                mstrid_Right = value;
            }
        }
        /// <summary>
        /// 排考考试组流水号
        /// </summary>
        public string Id_PKaoExamGroup
        {
            get
            {
                return mstrid_PKaoExamGroup;
            }
            set
            {
                mstrid_PKaoExamGroup = value;
            }
        }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrMsg
        {
            get
            {
                return mstrErrMsg;
            }
            set
            {
                mstrErrMsg = value;
            }
        }

        private string mstrSS;
      
        public string SS
        {
            get
            {
                return mstrSS;
            }

            set
            {
                mstrSS = value;
            }
        }
        private int mintTT;

        public int TT
        {
            get
            {
                return mintTT;
            }

            set
            {
                mintTT = value;
            }
        }

        private float mfltMyFloat;

        public float MyFloat
        {
            get
            {
                return mfltMyFloat;
            }

            set
            {
                mfltMyFloat = value;
            }
        }

        private double mdblMyDouble;

        public double MyDouble
        {
            get
            {
                return mdblMyDouble;
            }

            set
            {
                mdblMyDouble = value;
            }
        }
        private bool mbolMyBool;

        public bool MyBool
        {
            get
            {
                return mbolMyBool;
            }

            set
            {
                mbolMyBool = value;
            }
        }
    }

    /// <summary>
    /// myTreeView 的摘要说明。
    /// </summary>
    public partial class wucTreeView : clsTreeView4WucBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        private string mstrQxPrjId = "";
        private string mstrMenuSetId = "";
        /// <summary>
        /// 工程Id
        /// </summary>
        public string QxPrjId
        {
            get
            {
                return mstrQxPrjId;
            }
            set
            {
                mstrQxPrjId = value;
            }
        }
        /// <summary>
        /// 菜单集Id
        /// </summary>
        public string MenuSetId
        {
            get
            {
                return mstrMenuSetId;
            }
            set
            {
                mstrMenuSetId = value;
            }
        }

        /// <summary>
        /// 菜单Id
        /// </summary>
        public string MenuId { get;            set;        }
        /// <summary>
        /// 上一次选中的结点文本
        /// </summary>
        protected TreeNodeData vsNodeData
        {
            get
            {
                TreeNodeData sNodeData;
                sNodeData = (TreeNodeData)ViewState["NodeData"];
                if (sNodeData == null)
                {
                    sNodeData = null;
                }
                return sNodeData;
            }
            set
            {
                TreeNodeData sNodeData = value;
                ViewState.Add("NodeData", sNodeData);
            }
        }
       // private TreeNodeData mobjNodeData = new TreeNodeData();

        //		private string strCond4Bindlv_XzAdminCls = " 1=1 ";
        private TreeNode TnSelected;
      
        private List<clsTreeModelMenu> arrTreeModelObjList = new List<clsTreeModelMenu>();
        private List<clsTreeNodeTypeMenu> arrTreeNodeTypeObjList = new List<clsTreeNodeTypeMenu>();
        private bool mbolIsAutoSelSubNode = false;	//是否自动选择下级子结点
        private bool mbolIsShowEmptyNode = true;//是否显示空的子结点
        private bool mbolIsShowContextMenu;			//是否显示快捷菜单
        private bool mbolIsShowUniversityCourse = true;//是否显示校级课程
        /// <summary>
        /// 是否显示校级课程
        /// </summary>
        public bool IsShowUniversityCourse
        {
            get { return clsSysPara4TreeView.bolIsShowUniversityCourse; }
            set { clsSysPara4TreeView.bolIsShowUniversityCourse = value; }
        }

        /// <summary>
        /// 是否不显示已经毕业的年级
        /// </summary>
        public bool IsNotShowGradeWithoutGraduate
        {
            get { return clsSysPara4TreeView.bolIsNotShowGradeWithoutGraduate; }
            set { clsSysPara4TreeView.bolIsNotShowGradeWithoutGraduate = value; }
        }


        //		private bool mbolIsAddCollegeCodeInTree = false;//是树中是否加学院代码
        //private string mstrNodeType;
        public TreeModel tmTreeModel;
        //private System.Windows.Forms.ContextMenu contextMenu1;
        //private System.Windows.Forms.MenuItem miTreeModelGroup;

        ///// <summary>
        ///// 定义delegate对象类型，它有两个参数，第一个参数是事件发送者对象，第二个参数是事件参数类对象
        ///// 声明一个:发生在单击登录之后的事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //public delegate void OnClickLogin(object sender, clsEventArgs4TreeView e);
        ///// <summary>
        ///// 用event关键字定义事件对象，它同时也是一个delegate对象:
        /////       发生在单击登录之后的事件
        ///// </summary>
        //public event OnClickLogin myClickLogin;

        //定义各种事件

        public event AfterSelect_Tz afterSelect_Tz;

        public delegate void AfterCheck_Tz(object sender, clsEventArgs4TreeView e);
        public event AfterCheck_Tz afterCheck_Tz;

        public delegate void MenuItemRightClick(string strMenuName);
        public event MenuItemRightClick menuItemRightClick;

        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

        public wucTreeView()
        {
    
        }
      
        /// <summary>
        /// 是否有学院条件
        /// </summary>
        public bool IsHaveClgCondition
        {
            get
            {
                return clsSysPara4TreeView.bolIsHaveClgCondition;
            }
            set
            {
                clsSysPara4TreeView.bolIsHaveClgCondition = value;
            }
        }
        /// <summary>
        /// 是否在结点前面添加学院代码
        /// </summary>
        public bool IsAddCollegeCode
        {
            get
            {
                return clsSysPara4TreeView.bolIsAddCollegeCode;
            }
            set
            {
                clsSysPara4TreeView.bolIsAddCollegeCode = value;
            }
        }
        /// <summary>
        /// 是否显示空结点，可以通过此属性来是否显示没有下级结点的结点
        /// </summary>
        public bool IsShowEmptyNode
        {
            get
            {
                return clsSysPara4TreeView.bolIsShowEmptyNode;
            }
            set
            {
                clsSysPara4TreeView.bolIsShowEmptyNode = value;
            }
        }
       
       //是否自动选择下级节点
        public bool IsAutoSelSubNode
        {
            set
            {
                mbolIsAutoSelSubNode = value;
                if (mbolIsAutoSelSubNode == true)
                {
                    //treeView1.CheckBoxes = true;
                }
            }
            get
            {
                return mbolIsAutoSelSubNode;
            }
        }
        //是否显示快捷菜单
        public bool IsShowContextMenu
        {
            set
            {
                mbolIsShowContextMenu = value;
            }
            get
            {
                return mbolIsShowContextMenu;
            }
        }

       
        //public bool CheckBoxes
        //{
        //    get
        //    {
        //        return treeView1.CheckBoxes;
        //    }
        //    set
        //    {
        //        treeView1.CheckBoxes = value;
        //    }
        //}

        /// <summary>
        /// 当前结点的类型
        /// </summary>
        //public string NodeType
        //{
        //    get
        //    {
        //        return mstrNodeType;
        //    }
        //}

        //private void myTreeView_Resize(object sender, System.EventArgs e)
        //{
        //    treeView1.Left = 0;
        //    treeView1.Top = 0;
        //    treeView1.Width = this.Width;
        //    treeView1.Height = this.Height;
        //}
        public override TreeView objCurrTreeView
        {
            get
            {
                return treeView1;
            }
        }
        private void myTreeView_Load(object sender, System.EventArgs e)
        {

        }
        public void BindTv()
        {
            switch (tmTreeModel)
            {
                //学校
                case TreeModel.SCHOOL:
                    clsTreeViewBindDoubleTable.Bindtv_School(this);
                    break;
                //学校-学院
                case TreeModel.SCHOOL_COLLEGE:
                    clsTreeViewBindDoubleTable.Bindtv_College(this);
                    //treeView1.Nodes[0].Expand();
                    break;

                //角色
                case TreeModel.QXUSERROLE:
                case TreeModel.vQxUserRoles:
                    clsTreeViewBindDoubleTable.Bindtv_QxUserRoles(this, QxPrjId);
                    //					treeView1.Nodes[0].Expand();
                    break;

                case TreeModel.QxUsers:
                    clsTreeViewBindDoubleTable.Bindtv_QxUsers(this, QxPrjId);
                    //					treeView1.Nodes[0].Expand();
                    break;


                case TreeModel.QxDepartmentInfo_QxUsers:
                    clsTreeViewBindDoubleTable.Bindtv_QxDepartmentInfo_QxUsers(this, QxPrjId);
                    //					treeView1.Nodes[0].Expand();
                    break;


                case TreeModel.QxUserGroups_QxUsers:
                    clsTreeViewBindDoubleTable.Bindtv_QxUserGroups_QxUsers(this, QxPrjId);
                    //					treeView1.Nodes[0].Expand();
                    break;


                //角色
                case TreeModel.vQxUserRolesByUserNum:
                    clsTreeViewBindDoubleTable.Bindtv_vQxUserRolesByUserNum(this, QxPrjId);
                    //					treeView1.Nodes[0].Expand();
                    break;
                case TreeModel.vQxRolesByMenuNum:
                    clsTreeViewBindDoubleTable.Bindtv_vQxRolesByMenuNum(this, QxPrjId);
                    break;
                case TreeModel.vQxUserRolesByPotenceNum:
                    clsTreeViewBindDoubleTable.Bindtv_vQxUserRolesByPotenceNum(this, QxPrjId);
                    break;
                case TreeModel.vQxDepartmentInfoByUserNum:
                    clsTreeViewBindDoubleTable.Bindtv_vQxDepartmentInfoByUserNum(this);
                    //					treeView1.Nodes[0].Expand();
                    break;
                case TreeModel.QxPrjMenuUp_Sub:
                    clsTreeViewBindDoubleTable.Bindtv_QxPrjMenuUp_Sub(this, QxPrjId, MenuSetId);
                    //					treeView1.Nodes[0].Expand();
                    break;
                case TreeModel.QxPrjMenuUp_Sub_Leaf:
                    clsTreeViewBindDoubleTable.Bindtv_QxPrjMenuUp_Sub_Leaf(this, QxPrjId, MenuSetId);
                    //					treeView1.Nodes[0].Expand();
                    break;

                    
                case TreeModel.QxPrjMenuSet_QxPrjMenuUp_Sub:
                    clsTreeViewBindDoubleTable.Bindtv_QxPrjMenuSet_QxPrjMenuUp_Sub(this, QxPrjId, MenuSetId);
                    break;
                //角色-用户
                case TreeModel.ROLE_USER:
                    clsTreeViewBindDoubleTable.Bindtv_Role_User(this);
                    //					treeView1.Nodes[0].Expand();
                    break;
                //权限类型
                case TreeModel.RIGHTTYPE:
                    clsTreeViewBindDoubleTable.Bindtv_QxRightType(this);
                    //					treeView1.Nodes[0].Expand();
                    break;
                //权限类型--权限
                case TreeModel.RIGHTTYPE_RIGHT:
                    clsTreeViewBindDoubleTable.Bindtv_QxRightType_Right(this);
                    //					treeView1.Nodes[0].Expand();
                    break;
                //权限类型--权限
                case TreeModel.Project_UserRole:
                    clsTreeViewBindDoubleTable.Bindtv_Project_UserRoles(this);
                    //					treeView1.Nodes[0].Expand();
                    break;

                default:
                    string strMsg = string.Format("本树模式:[{0}]没有相应的绑定程序，请问该控件设计者!({1})", tmTreeModel, clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this.Page, strMsg);
                    break;

            }
        }





        //private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        //{
        //    if (this.TnSelected == null)
        //    {
        //        this.TnSelected = this.treeView1.SelectedNode;
        //        this.TnSelected.ForeColor = System.Drawing.Color.Blue;
        //    }
        //    else
        //    {
        //        this.TnSelected.ForeColor = System.Drawing.Color.Black;
        //        this.TnSelected = this.treeView1.SelectedNode;
        //        this.TnSelected.ForeColor = System.Drawing.Color.Blue;
        //    }
        //    mstrId_School = "";
        //    mstrId_Major = "";
        //    mstrMenuIdUp = "";

        //    mstrMenuIdSub = "";
        //    mstrQxPrjId = "";
        //    mstrId_MajorGrade = "";
        //    mstrId_AdminCls = "";
        //    mstrId_CrsType = "";
        //    mstrid_CrsTypeAdminType = "";
        //    mstrId_UniZone = "";
        //    mstrid_StudentType = "";
        //    mstrid_PKaoExamGroup = "";
        //    mstrId_Build = "";
        //    mstrid_TpTemplet = "";
        //    mstrid_TeachPlanSeries = "";
        //    mstrid_SeriesGroup = "";    //教学计划系列组ID
        //    mstrid_GroupReqMode = "";   //教学计划系列组模式ID
        //    mstrId_College = "";
        //    mstrid_EduClsCollect = "";  //教学班集合ID
        //    mstrid_xkEduCls = "";   //选课教学班ID
        //    mstrid_EduClass = "";   //当前教学班ID
        //    mstrid_TeachingPlan = "";   //教学计划ID
        //    mstrid_PkScheGroup = "";    //教学计划ID
        //    mstrid_TpXxTemplet = "";        //选修课模式ID
        //    mstrUserId = "";
        //    mstrPotenceTypeId = "";


        //    string strTypeName = GetCurrKeyTypeName((TreeView)sender);
        //    //获取被选结点类型
        //    TreeNode tnTemp = ((TreeView)sender).SelectedNode;
        //    mstrNodeType = GetNodeType(tnTemp, 1);
        //    //获取各层的结点值
        //    GetNodeValue4AllLier(tnTemp);

        //    if (afterSelect_Tz != null)
        //    {
        //        afterSelect_Tz(sender, e);
        //    }


        //}

        //  private void treeView1_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
        //  {
        //      if (mbolIsAutoSelSubNode == true)
        //      {
        //          if (e.Action != TreeViewAction.Unknown)
        //          {
        //              if (e.Node.Nodes.Count > 0)
        //              {
        //                  /* Calls the CheckAllChildNodes method, passing in the current 
        //Checked value of the TreeNode whose checked state changed. */
        //                  clsTreeViewBindDoubleTable.CheckAllChildNodes(e.Node, e.Node.Checked);
        //              }
        //          }
        //      }
        //      if (afterCheck_Tz != null)
        //      {
        //          afterCheck_Tz(sender, e);
        //      }
        //  }

        //
        private void menuItemSwitchMenu_Click(object sender, System.EventArgs e)
        {
            MenuItem objMenuItem = (MenuItem)sender;
            if (objMenuItem.Text == "专业-年级模式")
            {
                tmTreeModel = TreeModel.SCHOOL_COLLEGE_MAJOR_GRADE;
                BindTv();
            }
            //else if (objMenuItem.Text == "年级-专业模式")
            //{
            //	tmTreeModel = TreeModel.SCHOOL_COLLEGE_GRADE_MAJOR;		
            //	BindTv();
            //}
            else
            {
                TreeModel tmTemp = getTreeModel(objMenuItem.Text);
                if (tmTemp != TreeModel.NULL)
                {
                    tmTreeModel = tmTemp;
                    BindTv();
                }
            }
            if (menuItemRightClick != null)
            {
                menuItemRightClick(objMenuItem.Text);
            }
        }
        private TreeModel getTreeModel(string strMenuName)
        {
            foreach (clsTreeModelMenu objTreeModelMenu in arrTreeModelObjList)
            {
                if (strMenuName == objTreeModelMenu.TreeModelMenuName)
                {
                    return objTreeModelMenu.tmTreeModel;
                }
            }
            return TreeModel.NULL;
        }
        private void MenuOnClick()
        {

        }
        //private void treeView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    //			TreeView tnRightClick = ((TreeView)sender).SelectedNode;
        //    //			node=treeView1.GetNodeAt(e.X,e.Y);

        //    TreeNode tnRightClick = treeView1.GetNodeAt(e.X, e.Y);
        //    if (tnRightClick == null)
        //    {
        //        return;
        //    }
        //    treeView1.SelectedNode = tnRightClick;
        //    //			TreeNode tnRightClick = ((TreeView)sender).SelectedNode;
        //    TreeNodeType tntRightClick = GetNodeType(tnRightClick, 1);
        //    if (e.Button == MouseButtons.Right) //如果单击右键，就弹击菜单
        //    {

        //        if (mbolIsShowContextMenu == true)
        //        {
        //            foreach (MenuItem objMenuItem in contextMenu1.MenuItems)
        //            {
        //                string strMenuName = objMenuItem.Text;
        //                TreeNodeType tntTemp = getTreeNodeTypeByMenuName(strMenuName);
        //                if (tntTemp != TreeNodeType.NULL)
        //                {
        //                    if (tntTemp == tntRightClick)
        //                    {
        //                        objMenuItem.Visible = true;
        //                    }
        //                    else
        //                    {
        //                        objMenuItem.Visible = false;
        //                    }
        //                }
        //            }
        //            contextMenu1.Show(treeView1, new Point(e.X, e.Y));
        //        }
        //    }
        //}
        private string getTreeNodeTypeByMenuName(string strMenuName)
        {
            foreach (clsTreeNodeTypeMenu objTreeNodeTypeMenu in arrTreeNodeTypeObjList)
            {
                if (objTreeNodeTypeMenu.MenuName == strMenuName)
                {
                    return objTreeNodeTypeMenu.strTreeNodeType;
                }
            }
            return "";
        }
        public void SetNodeChecked(string strNeedNodeType, List<string> arrKeyId)
        {
            //string strNeedNodeType = clsEnumHelper.EnumToString(tntNeedNodeType);
            foreach (string strKeyId in arrKeyId)
            {
                SetNodeChecked(treeView1.Nodes[0], strNeedNodeType, strKeyId);
            }
        }
        public void AddTreeModelContextMenu(string strMenuName, TreeModel tmTemp)
        {
            clsTreeModelMenu objTreeModelMenu = new clsTreeModelMenu()
            {
                TreeModelMenuName = strMenuName,
                tmTreeModel = tmTemp
            };
            arrTreeModelObjList.Add(objTreeModelMenu);
            MenuItem objMenuItem = new MenuItem()
            {
             Text = strMenuName
            };
            //objMenuItem.Click += new EventHandler(menuItemSwitchMenu_Click);
            //miTreeModelGroup.MenuItems.Add(objMenuItem);
        }
        public void AddTreeNodeTypeContextMenu(string strMenuName, string strNeedNodeType)
        {
            clsTreeNodeTypeMenu objTreeNodeTypeMenu = new clsTreeNodeTypeMenu();
            objTreeNodeTypeMenu.MenuName = strMenuName;
            objTreeNodeTypeMenu.strTreeNodeType = strNeedNodeType;
            arrTreeNodeTypeObjList.Add(objTreeNodeTypeMenu);
            MenuItem objMenuItem = new MenuItem()
            {
             Text = strMenuName
            };
            //objMenuItem.Click += new EventHandler(menuItemSwitchMenu_Click);
            //contextMenu1.MenuItems.Add(objMenuItem);
        }
        public void AddContextMenu(string strMenuName)
        {
            MenuItem objMenuItem = new MenuItem()
            {
             Text = strMenuName
            };
            //objMenuItem.Click += new EventHandler(menuItemSwitchMenu_Click);
            //contextMenu1.MenuItems.Add(objMenuItem);
        }
        public void ClearContextMenu()
        {
            //contextMenu1.MenuItems.Clear();
        }
      
        protected override void GetNodeValue(TreeNode objTN)
        {
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            string strTypeName = strArr[0];
            int intLoopTimes;
            if (strArr.Length <= 2)
            {
                intLoopTimes = 1;
            }
            else
            {
                intLoopTimes = 2;
            }
            for (int i = 0; i < intLoopTimes; i++)
            {
                if (i == 1)
                {
                    strTypeName = strArr[2];
                }
                switch (strTypeName)
                {
                    case "Root"://学校

                        vsNodeData.Id_School = strArr[2 * i + 1];
                        break;
                    case clsXzSchoolEN._CurrTabName: //学校

                        vsNodeData.Id_School = strArr[2 * i + 1];
                        break;
                    case clsQxDepartmentInfoEN._CurrTabName://学院

                        vsNodeData.Id_College = strArr[2 * i + 1];
                        break;
                    case clsvQxDepartmentInfoByUserNumEN._CurrTabName://学院

                        vsNodeData.DepartmentId = strArr[2 * i + 1];
                        break;

                    case clsvQxPrjMenus_UpEN._CurrTabName: //年级

                        vsNodeData.MenuIdUp = strArr[2 * i + 1];
                        break;
                    case clsvQxPrjMenus_SubEN._CurrTabName: //年级

                        vsNodeData.MenuIdSub = strArr[2 * i + 1];
                        break;
                    case clsvQxPrjMenus_LeafEN._CurrTabName: //年级

                        vsNodeData.MenuIdLeaf = strArr[2 * i + 1];
                        break;
                    case clsQxProjectsEN._CurrTabName: //年级

                        vsNodeData.QxPrjId = strArr[2 * i + 1];
                        break;
                    case clsQxRolesEN._CurrTabName: //成绩统计方式

                        vsNodeData.RoleId = strArr[2 * i + 1];
                        break;
                    case clsQxUserGroupsEN._CurrTabName: //成绩统计方式

                        vsNodeData.GroupId = strArr[2 * i + 1];
                        break;
                    case clsQxUsersEN._CurrTabName: //考试统计批次

                        vsNodeData.PotenceTypeId = strArr[2 * i + 1];
                        break;
                    case clsQxPotenceTypeEN._CurrTabName: //课程

                        vsNodeData.PotenceId = strArr[2 * i + 1];
                        break;
                    case "RightType"://权限类型

                        vsNodeData.Id_RightType = strArr[2 * i + 1];
                        break;
                    case "Right"://权限

                        vsNodeData.Id_Right = strArr[2 * i + 1];
                        break;
                    default:

                        vsNodeData.ErrMsg = "不能确定的结点类型";       //不能确定的结点类型
                        break;
                }
            }
        }

        private void GetNodeObj(TreeNode objTN, clsNodeObj objNodeObj)
        {
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            string strTypeName = strArr[0];
            int intLoopTimes;
            if (strArr.Length <= 2)
            {
                intLoopTimes = 1;
            }
            else
            {
                intLoopTimes = 2;
            }
            for (int i = 0; i < intLoopTimes; i++)
            {
                if (i == 1)
                {
                    strTypeName = strArr[2];
                }
                switch (strTypeName)
                {
                    case "Root"://学校

                        vsNodeData.Id_School = strArr[2 * i + 1];
                        objNodeObj["Id_School"] = vsNodeData.Id_School;
                        break;
                    case clsQxDepartmentInfoEN._CurrTabName:  //学院             
                        vsNodeData.Id_College = strArr[2 * i + 1];
                        objNodeObj["Id_College"] = vsNodeData.Id_College;
                        break;
                    case clsvQxDepartmentInfoByUserNumEN._CurrTabName:  //学院             
                        vsNodeData.DepartmentId = strArr[2 * i + 1];
                        objNodeObj[convQxDepartmentInfoByUserNum.DepartmentId] = vsNodeData.DepartmentId;
                        break;
                  
                    case clsQxProjectsEN._CurrTabName:  //年级

                        vsNodeData.QxPrjId = strArr[2 * i + 1];
                        objNodeObj[conQxProjects.QxPrjId] = vsNodeData.QxPrjId;
                        break;
                    case clsQxRolesEN._CurrTabName:  //成绩统计方式

                        vsNodeData.RoleId = strArr[2 * i + 1];
                        objNodeObj[conQxRoles.RoleId] = vsNodeData.RoleId;
                        break;
                    case clsQxUserGroupsEN._CurrTabName:  //成绩统计方式

                        vsNodeData.GroupId = strArr[2 * i + 1];
                        objNodeObj[conQxUserGroups.GroupId] = vsNodeData.GroupId;
                        break;

                        
                    case clsQxPotenceTypeEN._CurrTabName:  //考试统计批次

                        vsNodeData.PotenceTypeId = strArr[2 * i + 1];
                        objNodeObj[conQxPotenceType.PotenceTypeId] = vsNodeData.PotenceTypeId;
                        break;
                    case clsQxPrjPotenceEN._CurrTabName:  //课程

                        vsNodeData.PotenceId = strArr[2 * i + 1];
                        objNodeObj[conQxPrjPotence.PotenceId] = vsNodeData.PotenceId;
                        break;
                    case clsQxUsersEN._CurrTabName:  //考试批次

                        vsNodeData.UserId = strArr[2 * i + 1];
                        objNodeObj[conQxUsers.UserId] = vsNodeData.UserId;
                        break;
                    case clsvQxPrjMenus_UpEN._CurrTabName:  //上层菜单

                        vsNodeData.MenuIdUp = strArr[2 * i + 1];
                        objNodeObj[convQxPrjMenus_Up.MenuIdUp] = vsNodeData.MenuIdUp;
                        break;
                    case clsvQxPrjMenus_SubEN._CurrTabName:  //上层菜单

                        vsNodeData.MenuIdSub = strArr[2 * i + 1];
                        objNodeObj[conQxUsers.UserId] = vsNodeData.MenuIdSub;
                        break;
                    case clsvQxPrjMenus_LeafEN._CurrTabName:  //年级                
                        vsNodeData.MenuIdLeaf = strArr[2 * i + 1];
                        objNodeObj[convQxPrjMenus_Leaf.MenuIdLeaf] = vsNodeData.MenuIdLeaf;
                        break;
                    //case clsSubjectDirectionEN._CurrTabName:  //学科方向

                    //    vsNodeData.MenuIdUp = strArr[2 * i + 1];
                    //    objNodeObj[clsSubjectDirection.MenuIdUp] = vsNodeData.MenuIdUp;
                    //    break;
                    default:

                        vsNodeData.ErrMsg = "不能确定的结点类型";       //不能确定的结点类型
                        break;
                }
            }
        }
      

        private void GetNodeObj4AllLier(TreeNode objTN, clsNodeObj objNodeObj)
        {
            TreeNode tnTemp = objTN;
            while (tnTemp != null)
            {
                GetNodeObj(tnTemp, objNodeObj); //获取本结点的值；
                tnTemp = tnTemp.Parent;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tnTemp"></param>
        /// <param name="arrLst"></param>
        /// <param name="tntNeedNodeType"></param>
        private void GetCheckedLeafNodeObj(TreeNode tnTemp, List<clsNodeObj> arrLst,
            string strNeedNodeType)
        {
            string strNodeType = GetNodeType(tnTemp, 1);
            //			string strNodeKeyId = GetCurrKey(tnTemp);
            if (tnTemp.ShowCheckBox == true && tnTemp.Checked == true
                && strNodeType == strNeedNodeType)
            {
                clsNodeObj objNodeObj = new clsNodeObj();
                GetNodeObj4AllLier(tnTemp, objNodeObj);
                arrLst.Add(objNodeObj);
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                GetCheckedLeafNodeObj(tn, arrLst, strNeedNodeType);
            }
        }

        protected void treeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            if (this.TnSelected == null)
            {
                this.TnSelected = this.treeView1.SelectedNode;

                //this.TnSelected.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                //this.TnSelected.ForeColor = System.Drawing.Color.Black;
                this.TnSelected = this.treeView1.SelectedNode;
                //this.TnSelected.ForeColor = System.Drawing.Color.Blue;
            }
            InitPropertyValue4Obj(NodeData);
           
            string strTypeName = GetCurrNodeType();
            //获取被选结点类型
            TreeNode tnTemp = ((TreeView)sender).SelectedNode;
            //mstrNodeType = GetNodeType(tnTemp, 1);
            string strKeyId = GetNodeKeyId(tnTemp);
            //获取各层的结点值
            GetNodeValue4AllLier(tnTemp);

            if (afterSelect_Tz != null)
            {
                clsEventArgs4TreeView objEventArgs4TreeView = new clsEventArgs4TreeView()
                {
                    KeyId = strKeyId,
                    NodeType = strTypeName,
                    NodeText = this.TnSelected.Text
                };
                afterSelect_Tz(sender, objEventArgs4TreeView);
            }

        }

        protected void treeView1_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {

        }

     
        /// <summary>
        /// 结点数据
        /// </summary>
        public TreeNodeData NodeData
        {
            get
            {
                TreeNodeData objNodeData = vsNodeData;
                if (objNodeData == null)
                {
                    objNodeData = new TreeNodeData();
                    vsNodeData = objNodeData;
                }
                return objNodeData;
            }

            set
            {
                vsNodeData = value;
            }
        }
        

        /// <summary>
        /// 获取被选的叶子结点
        /// </summary>
        /// <param name="tntTemp">结点类型</param>
        /// <returns></returns>
        public List<clsNodeObj> GetCheckedLeafNodeObjList(string strNeedNodeType)
        {
            List<clsNodeObj> arrAllCheckedLeafNodeList = new List<clsNodeObj>();
            foreach (TreeNode tnNode in objCurrTreeView.Nodes)
            {
                GetCheckedLeafNodeObj(tnNode, arrAllCheckedLeafNodeList, strNeedNodeType);
            }
            return arrAllCheckedLeafNodeList;
        }
    }
}

