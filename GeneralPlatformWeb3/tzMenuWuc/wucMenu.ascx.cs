using com.taishsoft.common;
using com.taishsoft.web;
using com.taishsoft.web.menu;
using CommFunc4WebForm;

using GeneralPlatform.Entity;
using MSWeb.Webform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GeneralPlatform.web.menu
{
    /// <summary>
    /// 树模式
    /// </summary>
    public enum MenuModel
    {
        NULL,
        /// <summary>
        /// 课程类型
		/// </summary>
        COURSETYPE,
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
        ROLE,				                //角色
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
        SCHOOL_GRADE_CJSTATAMODE_COURSE_EXAMBATCH,         //学校-课程-年级-成绩统计模式-批次

        /// <summary>
        /// 年级-课程-批次
        /// </summary>
        GRADE_COURSE_EXAMBATCH,         //年级-课程-批次

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

    public delegate void AfterSelect_Tz(object sender, clsEventArgs4Menu e);
    /// <summary>
    /// myTreeView 的摘要说明。
    /// </summary>
    public partial class wucMenu : clsMenu4WucBase
    {
        public override Menu objCurrMenu
        {
            get
            {
                return tzMenu1;
            }
        }



        //		private string strCond4Bindlv_XzAdminCls = " 1=1 ";
        private MenuItem TnSelected;
        private string mstrErrMsg = "";
        private string mstrId_School = "";
        private string mstrId_College = "";
        private string mstrMenuIdUp = "";

        private string mstrId_Major = "";
        private string mstrId_MajorGrade = "";
        private string mstrMenuIdSub = "";

        private string mstrRoleId = "";
        private string mstrPotenceTypeId = "";

        private string mstrPotenceId = "";
        private string mstrUserId = "";

        private string mstrQxPrjId = "";

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
            set { clsSysPara4Menu.strCollegeCondition = value; }
        }


        protected string mstrid_Tab;            //XLS导入表ID

        protected string mstrid_PkScheGroup;        //排课组ID
        protected string mstrid_TeachingPlan;

        private List<clsMenuModelMenu> arrMenuModelObjList = new List<clsMenuModelMenu>();
        private List<clsMenuItemTypeMenu> arrTreeNodeTypeObjList = new List<clsMenuItemTypeMenu>();
        private bool mbolIsAutoSelSubNode = false;	//是否自动选择下级子结点
        private bool mbolIsShowEmptyNode = true;//是否显示空的子结点
        private bool mbolIsShowContextMenu;			//是否显示快捷菜单
        private bool mbolIsShowUniversityCourse = true;//是否显示校级课程
        /// <summary>
        /// 是否显示校级课程
        /// </summary>
        public bool IsShowUniversityCourse
        {
            get { return clsSysPara4Menu.bolIsShowUniversityCourse; }
            set { clsSysPara4Menu.bolIsShowUniversityCourse = value; }
        }

        /// <summary>
        /// 是否不显示已经毕业的年级
        /// </summary>
        public bool IsNotShowGradeWithoutGraduate
        {
            get { return clsSysPara4Menu.bolIsNotShowGradeWithoutGraduate; }
            set { clsSysPara4Menu.bolIsNotShowGradeWithoutGraduate = value; }
        }


        //		private bool mbolIsAddCollegeCodeInTree = false;//是树中是否加学院代码
        private string mstrNodeType;
        public MenuModel tmMenuModel;
        //private System.Windows.Forms.ContextMenu contextMenu1;
        //private System.Windows.Forms.MenuItem miMenuModelGroup;

        ///// <summary>
        ///// 定义delegate对象类型，它有两个参数，第一个参数是事件发送者对象，第二个参数是事件参数类对象
        ///// 声明一个:发生在单击登录之后的事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //public delegate void OnClickLogin(object sender, clsEventArgs4Menu e);
        ///// <summary>
        ///// 用event关键字定义事件对象，它同时也是一个delegate对象:
        /////       发生在单击登录之后的事件
        ///// </summary>
        //public event OnClickLogin myClickLogin;

        //定义各种事件

        public event AfterSelect_Tz afterSelect_Tz;

        public delegate void MenuItemRightClick(string strMenuName);
        public event MenuItemRightClick menuItemRightClick;

        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

        public wucMenu()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();
            // TODO: 在 InitializeComponent 调用后添加任何初始化

        }



        #region 组件设计器生成的代码
        /// <summary> 
        /// 设计器支持所需的方法 - 不要使用代码编辑器 
        /// 修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            //this.tzMenu1 = new System.Windows.Forms.Menu();
            //this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            //this.miMenuModelGroup = new System.Windows.Forms.MenuItem();
            //this.SuspendLayout();
            // 
            // tzMenu1
            // 
            //this.tzMenu1.ImageIndex = -1;
            //this.tzMenu1.Location = new System.Drawing.Point(0, 8);
            //this.tzMenu1.Name = "tzMenu1";
            //this.tzMenu1.SelectedImageIndex = -1;
            //this.tzMenu1.Size = new System.Drawing.Size(176, 208);
            //this.tzMenu1.TabIndex = 0;
            //this.tzMenu1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            //this.tzMenu1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            //this.tzMenu1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenu1
            // 
            //this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            //                                                                             this.miMenuModelGroup});
            //// 
            // miMenuModelGroup
            // 
            //this.miMenuModelGroup.Index = 0;
            //this.miMenuModelGroup.Text = "排序方式";
            //// 
            //// myTreeView
            //// 
            //this.Controls.Add(this.tzMenu1);
            //this.Name = "myTreeView";
            //this.Size = new System.Drawing.Size(184, 232);
            //this.Resize += new System.EventHandler(this.myTreeView_Resize);
            //this.Load += new System.EventHandler(this.myTreeView_Load);
            //this.ResumeLayout(false);

        }
        #endregion
        /// <summary>
        /// 菜单的静态部分中显示的层数
        /// </summary>
        public int StaticDisplayLevels
        {
            get
            {
                return tzMenu1.StaticDisplayLevels;
            }
            set
            {
                tzMenu1.StaticDisplayLevels = value;

            }
        }

        public string CssClass
        {
            get
            {
                return tzMenu1.CssClass;
            }
            set
            {
                tzMenu1.CssClass = value;
            }
        }

        /// <summary>
        /// 是否有学院条件
        /// </summary>
        public bool IsHaveClgCondition
        {
            get
            {
                return clsSysPara4Menu.bolIsHaveClgCondition;
            }
            set
            {
                clsSysPara4Menu.bolIsHaveClgCondition = value;
            }
        }
        /// <summary>
        /// 是否在结点前面添加学院代码
        /// </summary>
        public bool IsAddCollegeCode
        {
            get
            {
                return clsSysPara4Menu.bolIsAddCollegeCode;
            }
            set
            {
                clsSysPara4Menu.bolIsAddCollegeCode = value;
            }
        }
        /// <summary>
        /// 是否显示空结点，可以通过此属性来是否显示没有下级结点的结点
        /// </summary>
        public bool IsShowEmptyNode
        {
            get
            {
                return clsSysPara4Menu.bolIsShowEmptyNode;
            }
            set
            {
                clsSysPara4Menu.bolIsShowEmptyNode = value;
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
                clsSysPara4Menu.strId_College = value;
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
        }
        /// <summary>
        /// 学科方向流水号
        /// </summary>
        public string MenuIdUp
        {
            get
            {
                return mstrMenuIdUp;
            }
        }
        /// <summary>
        /// 年级流水号
        /// </summary>
        public string MenuIdSub
        {
            get
            {
                return mstrMenuIdSub;
            }
        }
        /// <summary>
        /// 统计方式Id
        /// </summary>
        public string RoleId
        {
            get
            {
                return mstrRoleId;
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
        }
        /// <summary>
        /// 年级流水号
        /// </summary>
        public string QxPrjId
        {
            get
            {
                return mstrQxPrjId;
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
        }

        /// <summary>
        /// 课程类型流水号
        /// </summary>
        public string PotenceIdType
        {
            get
            {
                return mstrId_CrsType;
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
        }
        //是否自动选择下级节点
        public bool IsAutoSelSubNode
        {
            set
            {
                mbolIsAutoSelSubNode = value;
                if (mbolIsAutoSelSubNode == true)
                {
                    //tzMenu1.CheckBoxes = true;
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
        //public bool CheckBoxes
        //{
        //    get
        //    {
        //        return tzMenu1.CheckBoxes;
        //    }
        //    set
        //    {
        //        tzMenu1.CheckBoxes = value;
        //    }
        //}

        /// <summary>
        /// 当前结点的类型
        /// </summary>
        public string NodeType
        {
            get
            {
                return mstrNodeType;
            }
        }

        //private void myTreeView_Resize(object sender, System.EventArgs e)
        //{
        //    tzMenu1.Left = 0;
        //    tzMenu1.Top = 0;
        //    tzMenu1.Width = this.Width;
        //    tzMenu1.Height = this.Height;
        //}

        private void myTreeView_Load(object sender, System.EventArgs e)
        {

        }
        public void BindTv()
        {
            switch (tmMenuModel)
            {
                //学校
                case MenuModel.SCHOOL:
                    clsMenuBind.BindMnu_XzSchool(tzMenu1);
                    break;
                //学校-学院
                case MenuModel.SCHOOL_COLLEGE:
                    clsMenuBind.BindMnu_QxDepartmentInfo(tzMenu1);
                    //tzMenu1.StaticDisplayLevels=2;
                    break;


                //课程类型-教学计划系列
                //权限类型
                case MenuModel.RIGHTTYPE:
                    clsMenuBind.BindMnu_QxRightType(tzMenu1);
                    //					tzMenu1.StaticDisplayLevels=2;
                    break;
                //权限类型--权限
                case MenuModel.RIGHTTYPE_RIGHT:
                    clsMenuBind.BindMnu_QxRightType_Right(tzMenu1);
                    //					tzMenu1.StaticDisplayLevels=2;
                    break;

                default:
                    string strMsg = string.Format("本树模式:[{0}]没有相应的绑定程序，请问该控件设计者!({1})",
                        tmMenuModel, clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this.Page, strMsg);
                    break;

            }
        }

        private void menuItemSwitchMenu_Click(object sender, System.EventArgs e)
        {
            MenuItem objMenuItem = (MenuItem)sender;
            if (objMenuItem.Text == "专业-年级模式")
            {
                tmMenuModel = MenuModel.SCHOOL_COLLEGE_MAJOR_GRADE;
                BindTv();
            }
            //else if (objMenuItem.Text == "年级-专业模式")
            //{
            //	tmMenuModel = MenuModel.SCHOOL_COLLEGE_GRADE_MAJOR;		
            //	BindTv();
            //}
            else
            {
                MenuModel tmTemp = getMenuModel(objMenuItem.Text);
                if (tmTemp != MenuModel.NULL)
                {
                    tmMenuModel = tmTemp;
                    BindTv();
                }
            }
            if (menuItemRightClick != null)
            {
                menuItemRightClick(objMenuItem.Text);
            }
        }
        private MenuModel getMenuModel(string strMenuName)
        {
            foreach (clsMenuModelMenu objMenuModelMenu in arrMenuModelObjList)
            {
                if (strMenuName == objMenuModelMenu.MenuModelName)
                {
                    return objMenuModelMenu.tmMenuModel;
                }
            }
            return MenuModel.NULL;
        }
        private void MenuOnClick()
        {

        }
        //private void treeView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    //			Menu tnRightClick = ((Menu)sender).SelectedItem;
        //    //			node=tzMenu1.GetNodeAt(e.X,e.Y);

        //    MenuItem tnRightClick = tzMenu1.GetNodeAt(e.X, e.Y);
        //    if (tnRightClick == null)
        //    {
        //        return;
        //    }
        //    tzMenu1.SelectedItem = tnRightClick;
        //    //			MenuItem tnRightClick = ((Menu)sender).SelectedItem;
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
        //            contextMenu1.Show(tzMenu1, new Point(e.X, e.Y));
        //        }
        //    }
        //}
        private string getTreeNodeTypeByMenuName(string strMenuName)
        {
            foreach (clsMenuItemTypeMenu objTreeNodeTypeMenu in arrTreeNodeTypeObjList)
            {
                if (objTreeNodeTypeMenu.MenuName == strMenuName)
                {
                    return objTreeNodeTypeMenu.strMenuItemType;
                }
            }
            return "";
        }

        public void AddMenuModelContextMenu(string strMenuName, MenuModel tmTemp)
        {
            clsMenuModelMenu objMenuModelMenu = new clsMenuModelMenu();
            objMenuModelMenu.MenuModelName = strMenuName;
            objMenuModelMenu.tmMenuModel = tmTemp;
            arrMenuModelObjList.Add(objMenuModelMenu);
            MenuItem objMenuItem = new MenuItem();
            objMenuItem.Text = strMenuName;
            //objMenuItem.Click += new EventHandler(menuItemSwitchMenu_Click);
            //miMenuModelGroup.MenuItems.Add(objMenuItem);
        }
        public void AddTreeNodeTypeContextMenu(string strMenuName, string strNeedNodeType)
        {
            clsMenuItemTypeMenu objTreeNodeTypeMenu = new clsMenuItemTypeMenu();
            objTreeNodeTypeMenu.MenuName = strMenuName;
            objTreeNodeTypeMenu.strMenuItemType = strNeedNodeType;
            arrTreeNodeTypeObjList.Add(objTreeNodeTypeMenu);
            MenuItem objMenuItem = new MenuItem();
            objMenuItem.Text = strMenuName;
            //objMenuItem.Click += new EventHandler(menuItemSwitchMenu_Click);
            //contextMenu1.MenuItems.Add(objMenuItem);
        }
        public void AddContextMenu(string strMenuName)
        {
            MenuItem objMenuItem = new MenuItem();
            objMenuItem.Text = strMenuName;
            //objMenuItem.Click += new EventHandler(menuItemSwitchMenu_Click);
            //contextMenu1.MenuItems.Add(objMenuItem);
        }
        public void ClearContextMenu()
        {
            //contextMenu1.MenuItems.Clear();
        }
        private void GetNodeValue4AllLier(MenuItem objTN)
        {
            MenuItem tnTemp = objTN;
            while (tnTemp != null)
            {
                GetNodeValue(tnTemp);   //获取本结点的值；
                tnTemp = tnTemp.Parent;
            }
        }
        private void GetNodeValue(MenuItem objTN)
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

                        mstrId_School = strArr[2 * i + 1];
                        break;
                    case clsXzSchoolEN._CurrTabName: //学校

                        mstrId_School = strArr[2 * i + 1];
                        break;
                    case "College"://学院

                        mstrId_College = strArr[2 * i + 1];
                        break;
                    case clsvQxPrjMenus_UpEN._CurrTabName: //学科方向
                        mstrMenuIdUp = strArr[2 * i + 1];
                        break;
                    case clsvQxPrjMenus_SubEN._CurrTabName: //年级

                        mstrMenuIdSub = strArr[2 * i + 1];
                        break;

                    case clsQxRolesEN._CurrTabName: //成绩统计方式

                        mstrRoleId = strArr[2 * i + 1];
                        break;
                    case clsQxPotenceTypeEN._CurrTabName: //考试统计批次

                        mstrPotenceTypeId = strArr[2 * i + 1];
                        break;
                    case clsQxPrjPotenceEN._CurrTabName: //课程

                        mstrPotenceId = strArr[2 * i + 1];
                        break;
                    case clsQxUsersEN._CurrTabName: //考试批次

                        mstrUserId = strArr[2 * i + 1];
                        break;

                    //    case  clsXzAdminClsEN._CurrTabName: //行政班

                    //    mstrId_AdminCls = strArr[2 * i + 1];
                    //        break;
                    //    case  clsQxPrjPotenceTypeEN._CurrTabName: //课程类型

                    //    mstrId_CrsType = strArr[2 * i + 1];
                    //        break;
                    //case  clsxkCollectOfClassEN._CurrTabName: //教学班集合

                    //    mstrid_EduClsCollect = strArr[2 * i + 1];
                    //        break;
                    //    case  clsxkEduClsEN._CurrTabName: //教学班

                    //    mstrid_xkEduCls = strArr[2 * i + 1];
                    //        break;
                    //    case  clsPk2ScheGroupEN._CurrTabName: //排课组

                    //    mstrid_PkScheGroup = strArr[2 * i + 1];
                    //        break;
                    default:

                        mstrErrMsg = "不能确定的结点类型";       //不能确定的结点类型
                        break;
                }
            }
        }

        private void GetMenuItemObj(MenuItem objTN, clsMenuItemObj objMenuItemObj)
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

                        mstrId_School = strArr[2 * i + 1];
                        objMenuItemObj["Id_School"] = mstrId_School;
                        break;
                 
                    case clsvQxPrjMenus_SubEN._CurrTabName:  //年级                
                        mstrMenuIdSub = strArr[2 * i + 1];
                        objMenuItemObj["MenuIdSub"] = mstrMenuIdSub;
                        break;
                    case clsvQxPrjMenus_UpEN._CurrTabName:  //年级

                        mstrMenuIdUp = strArr[2 * i + 1];
                        objMenuItemObj[convQxPrjMenus_Up.MenuIdUp] = mstrMenuIdUp;
                        break;
                    case clsQxRolesEN._CurrTabName:  //成绩统计方式

                        mstrRoleId = strArr[2 * i + 1];
                        objMenuItemObj[conQxRoles.RoleId] = mstrRoleId;
                        break;
                    case clsQxPotenceTypeEN._CurrTabName:  //考试统计批次

                        mstrPotenceTypeId = strArr[2 * i + 1];
                        objMenuItemObj[conQxPotenceType.PotenceTypeId] = mstrPotenceTypeId;
                        break;
                    case clsQxPrjPotenceEN._CurrTabName:  //课程

                        mstrPotenceId = strArr[2 * i + 1];
                        objMenuItemObj[conQxPrjPotence.PotenceId] = mstrPotenceId;
                        break;
                    case clsQxUsersEN._CurrTabName:  //考试批次

                        mstrUserId = strArr[2 * i + 1];
                        objMenuItemObj[conQxUsers.UserId] = mstrUserId;
                    //    break;
                    //case clsSubjectDirectionEN._CurrTabName:  //学科方向

                    //    mstrMenuIdUp = strArr[2 * i + 1];
                    //    objMenuItemObj[clsSubjectDirection.MenuIdUp] = mstrMenuIdUp;
                    //    break;
                    //case clsQxPrjPotenceTypeEN._CurrTabName:  //课程类型

                    //    mstrId_CrsType = strArr[2 * i + 1];
                    //    objMenuItemObj["Id_CrsType"] = mstrId_CrsType;
                    //    break;
                    //case clsxkCollectOfClassEN._CurrTabName:  //教学班集合

                    //    mstrid_EduClsCollect = strArr[2 * i + 1];
                    //    objMenuItemObj["Id_EduClsCollect"] = mstrid_EduClsCollect;
                    //    break;
                  
                    //case clsxkEduClsEN._CurrTabName:  //选课教学班

                    //    mstrid_xkEduCls = strArr[2 * i + 1];
                    //    objMenuItemObj["Id_xkEduCls"] = mstrid_xkEduCls;
                    //    break;
                
                    //case clsPk2ScheGroupEN._CurrTabName:  //排课组
                    //    mstrid_PkScheGroup = strArr[2 * i + 1];
                    //    objMenuItemObj["Id_PkScheGroup"] = mstrid_PkScheGroup;
                    //    break;
                    //default:

                        mstrErrMsg = "不能确定的结点类型";       //不能确定的结点类型
                        break;
                }
            }
        }
        private void GetMenuItemObj4AllLier(MenuItem objTN, clsMenuItemObj objMenuItemObj)
        {
            MenuItem tnTemp = objTN;
            while (tnTemp != null)
            {
                GetMenuItemObj(tnTemp, objMenuItemObj); //获取本结点的值；
                tnTemp = tnTemp.Parent;
            }
        }


        protected string vsLastSelectedKeyId
        {
            get
            {
                string sLastSelectedKeyId;
                sLastSelectedKeyId = (string)ViewState["LastSelectedKeyId"];
                if (sLastSelectedKeyId == null)
                {
                    sLastSelectedKeyId = "";
                }
                return sLastSelectedKeyId;
            }
            set
            {
                string sLastSelectedKeyId = value;
                ViewState.Add("LastSelectedKeyId", sLastSelectedKeyId);
            }
        }
        protected string vsLastSelectedNodeType
        {
            get
            {
                string sLastSelectedNodeType;
                sLastSelectedNodeType = (string)ViewState["LastSelectedNodeType"];
                if (sLastSelectedNodeType == null)
                {
                    sLastSelectedNodeType = "";
                }
                return sLastSelectedNodeType;
            }
            set
            {
                string sLastSelectedNodeType = value;
                ViewState.Add("LastSelectedNodeType", sLastSelectedNodeType);
            }
        }
        protected string vsSelectedText
        {
            get
            {
                string sSelectedText;
                sSelectedText = (string)ViewState["SelectedText"];
                if (sSelectedText == null)
                {
                    sSelectedText = "";
                }
                return sSelectedText;
            }
            set
            {
                string sSelectedText = value;
                ViewState.Add("SelectedText", sSelectedText);
            }
        }
        public bool SelectNode(string strNeedNodeType, string strKeyId)
        {
            if (string.IsNullOrEmpty(strNeedNodeType) == true
                || strKeyId == "")
            {
                return false;
            }

            MenuItem tnNode = GetMenuItemByTypeAndKeyInTV(objCurrMenu, strNeedNodeType, strKeyId);
            if (tnNode != null)
            {

                //T tntNeedNodeType1 = GetNodeTypeString(vsLastSelectedNodeType);
                if (string.IsNullOrEmpty(vsLastSelectedNodeType) != true)
                {
                    MenuItem tnLastSelectNode = GetMenuItemByTypeAndKeyInTV(objCurrMenu, vsLastSelectedNodeType, vsLastSelectedKeyId);
                    if (tnLastSelectNode != null)
                    {
                        tnLastSelectNode.Text = vsSelectedText;
                    }
                }
                vsSelectedText = tnNode.Text;
                vsLastSelectedNodeType = GetMenuItemTypeString(tnNode, 3);
                vsLastSelectedKeyId = GetMenuItemKeyId(tnNode);
                tnNode.Text = string.Format("<span class='selectedNode'>{0}</span>", tnNode.Text);
                tnNode.Selectable = true;
                return true;
            }
            return false;
        }

        protected void tzMenu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (this.TnSelected == null)
            {
                this.TnSelected = this.tzMenu1.SelectedItem;

                //this.TnSelected.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                //this.TnSelected.ForeColor = System.Drawing.Color.Black;
                this.TnSelected = this.tzMenu1.SelectedItem;
                //this.TnSelected.ForeColor = System.Drawing.Color.Blue;
            }
            mstrId_School = "";
            mstrId_Major = "";
            mstrMenuIdUp = "";

            mstrMenuIdSub = "";
            mstrQxPrjId = "";
            mstrId_MajorGrade = "";
            mstrId_AdminCls = "";
            mstrId_CrsType = "";
            mstrid_CrsTypeAdminType = "";
            mstrId_UniZone = "";
            mstrid_StudentType = "";
            mstrid_PKaoExamGroup = "";
            mstrId_Build = "";
            mstrid_TpTemplet = "";
            mstrid_TeachPlanSeries = "";
            mstrid_SeriesGroup = "";    //教学计划系列组ID
            mstrid_GroupReqMode = "";   //教学计划系列组模式ID
            mstrId_College = "";
            mstrid_EduClsCollect = "";  //教学班集合ID
            mstrid_xkEduCls = "";   //选课教学班ID
            mstrid_EduClass = "";   //当前教学班ID
            mstrid_TeachingPlan = "";   //教学计划ID
            mstrid_PkScheGroup = "";    //教学计划ID

            mstrUserId = "";
            mstrPotenceTypeId = "";


            string strTypeName = GetCurrKeyTypeName();
            //获取被选结点类型
            MenuItem tnTemp = ((Menu)sender).SelectedItem;
            mstrNodeType = GetMenuItemType(tnTemp, 1);
            string strKeyId = GetMenuItemKeyId(tnTemp);
            //获取各层的结点值
            GetNodeValue4AllLier(tnTemp);

            if (afterSelect_Tz != null)
            {
                clsEventArgs4Menu objEventArgs4Menu = new clsEventArgs4Menu();
                objEventArgs4Menu.KeyId = strKeyId;
                objEventArgs4Menu.MenuItemType = strTypeName;
                afterSelect_Tz(sender, objEventArgs4Menu);
            }

        }
    }
}

