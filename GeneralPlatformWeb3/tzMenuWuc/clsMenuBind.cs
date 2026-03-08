using com.taishsoft.comm_db_obj;
using com.taishsoft.web.menu;


using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;

namespace GeneralPlatform.web.menu
{
    public partial class clsMenuBind
    {
        private Menu mobjTv;

        private DataTable mobjLevel1Dt;

        private DataTable mobjLevel2Dt;

        private string mstrLevel1NameField = "";

        private string mstrLevel1ValueField = "";

        private string mstrLevel2NameField = "";

        private string mstrLevel2ValueField = "";

        private string mstrLevel1IDFieldInLevel2DataSource;

        private int mintExpandLevel = 1;

        private bool mbolLevel1HasCheckBox = true;

        private bool mbolLevel2HasCheckBox = true;

        private string mstrRootTitle = "以下是详细信息列表：";

        public Menu objTreeView
        {
            get
            {
                return this.mobjTv;

            }
            set
            {
                if (value != null)
                {
                    this.mobjTv = value;
                }

            }
        }

        public int ExpandLevel
        {
            get
            {
                return this.mintExpandLevel;
            }
            set
            {
                if (value >= 0)
                {
                    this.mintExpandLevel = value;
                }
            }
        }

        public bool Level1CheckBox
        {
            get
            {
                return this.mbolLevel1HasCheckBox;
            }
            set
            {

                this.mbolLevel1HasCheckBox = value;

            }
        }

        public bool Level2CheckBox
        {
            get
            {
                return this.mbolLevel2HasCheckBox;
            }
            set
            {

                this.mbolLevel2HasCheckBox = value;

            }
        }

        public string RootTitle
        {
            get
            {
                return this.mstrRootTitle;
            }
            set
            {
                if (value != null)
                {
                    this.mstrRootTitle = value;
                }
            }
        }

        public DataTable Level1DataSource
        {
            get
            {
                return this.mobjLevel1Dt;
            }
            set
            {
                if (value != null)
                {
                    this.mobjLevel1Dt = value;
                }
            }
        }

        public DataTable Level2DataSource
        {
            get
            {
                return this.mobjLevel2Dt;
            }
            set
            {
                if (value != null)
                {
                    this.mobjLevel2Dt = value;
                }
            }
        }

        public string Level1NameField
        {
            get
            {

                return this.mstrLevel1NameField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel1NameField = value;
                }

            }
        }

        public string Level1ValueField
        {
            get
            {

                return this.mstrLevel1ValueField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel1ValueField = value;
                }

            }
        }

        public string Level2NameField
        {
            get
            {

                return this.mstrLevel2NameField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel2NameField = value;
                }

            }
        }

        public string Level2ValueField
        {
            get
            {

                return this.mstrLevel2ValueField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel2ValueField = value;
                }

            }
        }

        public string Level1IDFieldInLevel2DataSource
        {
            get
            {

                return this.mstrLevel1IDFieldInLevel2DataSource;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel1IDFieldInLevel2DataSource = value;
                }

            }
        }


        public clsMenuBind()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public clsMenuBind(Menu objTreeView)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjTv = objTreeView;

        }

        public clsMenuBind(Menu objTreeView, DataTable Level1DataSource, DataTable Level2DataSource)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjTv = objTreeView;
            this.mobjLevel1Dt = Level1DataSource;
            this.mobjLevel2Dt = Level2DataSource;

        }


        public clsMenuBind(Menu objTreeView,
            DataTable Level1DataSource, DataTable Level2DataSource,
            string Level1NameField, string Level1ValueField, string Level2NameField, string Level2ValueField, string Level1IDFieldInLevel2DataSource)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjTv = objTreeView;
            this.mobjLevel1Dt = Level1DataSource;
            this.mobjLevel2Dt = Level2DataSource;
            this.mstrLevel1NameField = Level1NameField;
            this.mstrLevel1ValueField = Level1ValueField;
            this.mstrLevel2NameField = Level2NameField;
            this.mstrLevel2ValueField = Level2ValueField;
            this.mstrLevel1IDFieldInLevel2DataSource = Level1IDFieldInLevel2DataSource;
        }

        public void DataBind()
        {
            this.BindTreeView(this.mobjTv, this.mobjLevel1Dt, this.mobjLevel2Dt, this.mstrLevel1NameField, this.mstrLevel1ValueField, this.mstrLevel2NameField, this.mstrLevel2ValueField, this.mstrLevel1IDFieldInLevel2DataSource);
            this.mobjTv.StaticDisplayLevels = 2;
        }


        private void BindTreeView(Menu pobjTreeView,
            DataTable pLevel1DataSource, DataTable pLevel2DataSource,
            string pLevel1NameField, string pLevel1ValueField, string pLevel2NameField, string pLevel2ValueField, string pLevel1IDFieldInLevel2DataSource)
        {
            if (pobjTreeView != null
                && pLevel1DataSource != null && pLevel2DataSource != null
                && pLevel1NameField != "" && pLevel1ValueField != "" && pLevel2NameField != "" && pLevel2ValueField != "" && pLevel1IDFieldInLevel2DataSource != "")
            {



                DataTable objLevel1DataTable, objLevel2DataTable;
                MenuItem tnRoot, tnLevel1, tnLevel2;

                pobjTreeView.Items.Clear();

                tnRoot = new MenuItem();
                tnRoot.Value = "Root,0000";
                tnRoot.Text = this.mstrRootTitle;
                //mobjTv.CheckBoxes = false;

                pobjTreeView.Items.Add(tnRoot);


                objLevel1DataTable = pLevel1DataSource;
                objLevel2DataTable = pLevel2DataSource;



                foreach (DataRow Level1Dr in objLevel1DataTable.Rows)
                {
                    string strLevel1Id = Level1Dr[pLevel1ValueField].ToString();
                    string strLevel1Name = Level1Dr[pLevel1NameField].ToString();

                    tnLevel1 = new MenuItem();
                    tnLevel1.Value = "Level1," + strLevel1Id;
                    tnLevel1.Text = strLevel1Name;
                    tnRoot.ChildItems.Add(tnLevel1);

                    DataRow[] DrRows = objLevel2DataTable.Select(string.Format(" {0} = '{1}'", pLevel1IDFieldInLevel2DataSource, strLevel1Id));

                    foreach (DataRow Level2Dr in DrRows)
                    {
                        string strLevel2Id = Level2Dr[pLevel2ValueField].ToString();
                        string strLevel2Name = Level2Dr[pLevel2NameField].ToString();

                        tnLevel2 = new MenuItem();
                        tnLevel2.Value = "Level2," + strLevel2Id;
                        tnLevel2.Text = strLevel2Name;
                        tnLevel1.ChildItems.Add(tnLevel2);

                    }

                }

            }

        }


        public static string GetCurrKeyTypeName(Menu objTreeView)
        {
            string strTabName = "";
            string strTag = objTreeView.SelectedItem.Value.ToString();
            string[] strArr = strTag.Split(',');
            strTabName = strArr[0];
            return strTabName;
        }
        public static string GetCurrKeyTypeName(MenuItem objTN)
        {
            string strTabName = "";
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            if (strArr[0] != "Root")
            {
                strTabName = strArr[0];
            }

            return strTabName;
        }
        public static string GetCurrKey(Menu objTreeView)
        {
            string strKeyId = "";
            string strTag = objTreeView.SelectedItem.Value.ToString();
            string[] strArr = strTag.Split(',');
            strKeyId = strArr[1];
            return strKeyId;
        }
        /// <summary>
        /// 获取当前结点的关键字
        /// </summary>
        /// <param name="objTN"></param>
        /// <returns></returns>
		public static string GetCurrKey(MenuItem objTN)
        {
            string strKeyId = "";
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            strKeyId = strArr[1];
            return strKeyId;
        }


        public static void BindMnu_QxDepartmentInfo(Menu objMenu)
        {
            string strCondition_XzSchool = string.Format("{0}='1'  order by {1}", conXzSchool.IsCurrentUse, conXzSchool.SchoolId);
            List<clsXzSchoolEN> arrXzSchoolObjList = clsXzSchoolBL.GetObjLst(strCondition_XzSchool);

            List<clsQxDepartmentInfoEN> arrCollegeObjList = null;
            if (clsSysPara4Menu.bolIsHaveClgCondition == true)
            {
                if (string.IsNullOrEmpty(clsSysPara4Menu.strCollegeCondition) == false)
                {
                    arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(clsSysPara4Menu.strCollegeCondition + " and IdCollege !='0000'  order by CollegeID");
                }
                else
                {
                    arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege ='" + clsSysPara4Menu.strId_College + "' and IdCollege !='0000'  order by CollegeID");
                }
            }
            else
            {
                arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege !='0000' order by CollegeID");
            }

            //			List<clsQxDepartmentInfoEN> arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege !='0000' order by CollegeID");

            MenuItem tnRoot = new MenuItem();
            MenuItem tnCollege = null;      //,tnMajor = null,tnGrade = null,tnRange = null;
            MenuItem tnXzSchool = null;

            objMenu.Items.Clear();


            foreach (clsQxDepartmentInfoEN objQxDepartmentInfo in arrCollegeObjList)  //QxDepartmentInfo
            {
                tnCollege = getMenuItemByTabObj(objQxDepartmentInfo);
                tnXzSchool.ChildItems.Add(tnCollege);
            }


            //			objMenu.StaticDisplayLevels=2;
            objMenu.Items[0].Selected = true;
            objMenu.Items[0].Selected = true;
        }

        public static void BindMnu_PrjMenuUp_Sub(Menu objMenu, string strQxPrjId, string strMenuSetId, string strCurrNodeId)
        {
            //System.Data.DataTable objDTUpMenu, objDTSubMenu;
            List<clsvQxPrjMenus_UpEN> arrUpMenuObjList = null;
            List<clsvQxPrjMenus_SubEN> arrSubMenuObjList = null;

            clsQxPrjMenusBLEx objPrjMenuEx = new clsQxPrjMenusBLEx();
            StringBuilder strCondition = new StringBuilder();
            StringBuilder strCondition2 = new StringBuilder();

            StringBuilder strHtml = new StringBuilder();        //需要插入的HTML代码

            StringBuilder strMenuSubItem = new StringBuilder();
            string strMenuId, strUpMenuId, strSubMenuId;
            string strUpMenuName, strSubMenuName, strLinkFile, strUpImgFile, strSubImgFile;

            //1、获取主菜单项
            if (string.IsNullOrEmpty(strMenuSetId) == false)
            {
              
                strCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}' order by OrderNum ",
                    strQxPrjId, strMenuSetId);
                strCondition2.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}' order by OrderNum",
                    strQxPrjId, strMenuSetId);
            }
            else
            {
                strCondition.AppendFormat(" QxPrjId = '{0}' order by OrderNum ",
                    strQxPrjId);
                strCondition2.AppendFormat(" QxPrjId = '{0}' order by OrderNum",
                    strQxPrjId);
            }

            arrUpMenuObjList = clsvQxPrjMenus_UpBL.GetObjLst(strCondition.ToString());
            //2、获取相应子菜单项
            arrSubMenuObjList = clsvQxPrjMenus_SubBL.GetObjLst(strCondition2.ToString());

            //			string strPrjId = ConfigurationSettings.AppSettings[conQxProjects.QxPrjId];

            MenuItem tnRoot, tnUpMenuItem, tnSubMenuItem, tnLeafNode;
            //if (new clsCommonSession().CurrNodeId == "")
            //{
            //    new clsCommonSession().CurrNodeId = "root";
            //}
            objMenu.Items.Clear();
            tnRoot = new MenuItem();
            tnRoot.Value = "root,root";
            tnRoot.Text = "项目菜单结构: ";
            //tnRoot.ShowCheckBox = true;
            objMenu.Items.Add(tnRoot);

            foreach (clsvQxPrjMenus_UpEN objPrjMenu_Up in arrUpMenuObjList)
            {
                strMenuId = objPrjMenu_Up.MenuIdUp;   //获取主菜单项ID
                                                    //  strUpMenuName = objPrjMenu_Up.MenuName + objPrjMenu_Up.MenuId + (objPrjMenu_Up.IsLeafNode ? "(叶子)" : ""); //获取主菜单项NAME
                strUpMenuName = string.Format("{0}{1}{2}{3}({4})",
                    objPrjMenu_Up.MenuName,
                    objPrjMenu_Up.MenuIdUp,
                     (objPrjMenu_Up.IsLeafNode ? "(叶子)" : ""),
                     (objPrjMenu_Up.InUse ? "" : "(未用)"),
                     objPrjMenu_Up.OrderNum); //获取主菜单项NAME

                strUpImgFile = objPrjMenu_Up.ImgFile;

                tnUpMenuItem = new MenuItem();
                tnUpMenuItem.Value = "UpMenu," + strMenuId; //分类码

                tnUpMenuItem.Text = strUpMenuName;  //分类名称
                if (strUpImgFile.Length > 0)
                {
                    tnUpMenuItem.ImageUrl = "../" + strUpImgFile;
                }

                //tnUpMenuItem.ShowCheckBox = true;
                tnRoot.ChildItems.Add(tnUpMenuItem);

                foreach (clsvQxPrjMenus_SubEN objPrjMenu_Sub in arrSubMenuObjList)
                {
                    strUpMenuId = objPrjMenu_Sub.UpMenuId;

                    if (strMenuId == strUpMenuId)
                    {
                        strSubMenuId = objPrjMenu_Sub.MenuIdSub;	//获取主菜单项ID
                        // strSubMenuName = objPrjMenu_Sub.MenuName + objPrjMenu_Sub.MenuId + (objPrjMenu_Sub.IsLeafNode ? "(叶子)" : ""); //获取主菜单项NAME
                        strSubMenuName = string.Format("{0}{1}{2}{3}({4})",
                            objPrjMenu_Sub.MenuName,
                             objPrjMenu_Sub.MenuIdSub,
                             (objPrjMenu_Sub.IsLeafNode ? "(叶子)" : ""),
                               (objPrjMenu_Sub.InUse ? "" : "(未用)"),
                             objPrjMenu_Sub.OrderNum); //获取主菜单项NAME
                        strSubImgFile = objPrjMenu_Sub.ImgFile;
                        strLinkFile = objPrjMenu_Sub.LinkFile;

                        tnSubMenuItem = new MenuItem();
                        tnSubMenuItem.Value = "SubMenu," + strSubMenuId;

                        tnSubMenuItem.Text = strSubMenuName;
                        if (strSubImgFile.Length > 0)
                        {
                            tnSubMenuItem.ImageUrl = "../" + strSubImgFile;
                        }
                        //tnSubMenuItem.ShowCheckBox = true;
                        tnUpMenuItem.ChildItems.Add(tnSubMenuItem);
                        foreach (clsvQxPrjMenus_SubEN objPrjMenu_Sub2 in arrSubMenuObjList)
                        {
                            if (objPrjMenu_Sub2.UpMenuId == objPrjMenu_Sub.MenuIdSub)
                            {
                                tnLeafNode = new MenuItem();
                                tnLeafNode.Value = "LeafNode," + objPrjMenu_Sub2.MenuIdSub;

                                tnLeafNode.Text = objPrjMenu_Sub2.MenuName + objPrjMenu_Sub2.MenuIdSub + (objPrjMenu_Sub2.IsLeafNode ? "(叶子)" : "");
                                if (objPrjMenu_Sub2.ImgFile.Length > 0)
                                {
                                    tnLeafNode.ImageUrl = "../" + objPrjMenu_Sub2.ImgFile;
                                }
                                //tnLeafNode.ShowCheckBox = true;
                                tnSubMenuItem.ChildItems.Add(tnLeafNode);
                            }
                        }

                    }
                }
            }
            //if (string.IsNullOrEmpty(strCurrNodeId) == true) return;
            //if (strCurrNodeId != "root")
            //{
            //    Stack objStack = new Stack();
            //    MenuItem tnCurrNode = clsMenu4WucBase.GetMenuItemByKeyInTV(objMenu, strCurrNodeId);
            //    if (tnCurrNode == null) return;
            //    MenuItem tnTemp = tnCurrNode;
            //    objStack.Push(tnCurrNode);
            //    while (true)
            //    {
            //        MenuItem tnParentCurrNode = tnTemp.Parent;
            //        string strParentNodeId = clsCommForWebForm.getNodeID_S(tnParentCurrNode);
            //        if (strParentNodeId != "root")
            //        {
            //            objStack.Push(tnParentCurrNode);
            //        }
            //        else
            //        {
            //            break;
            //        }
            //        tnTemp = tnParentCurrNode;
            //    }
            //    objMenu.Nodes[0].Expand();
            //    tnTemp = objStack.Pop() as MenuItem;
            //    while (objStack.Count > 0)
            //    {
            //        tnTemp.Expand();
            //        tnTemp = objStack.Pop() as MenuItem;
            //    }
            //    //MenuItem tnParentCurrNode = tnCurrNode.Parent;  // clsCommForWebForm.GetParentNodeFromTreeViewByID(objMenu.Nodes[0], strCurrNodeId);
            //    //tnParentCurrNode.Expand();

            //    tnCurrNode.Select();
            //    tnCurrNode.ExpandAll();
            //}
            //else
            //{
            //    objMenu.ExpandDepth = 1;
            //}
        }


        private static MenuItem getMenuItemByTabObj(clsEntityBase2 objTabObj)
        {
            if (string.IsNullOrEmpty(objTabObj._KeyId) == true)
            {
                string strMsg = string.Format("在绑定树的过程中，表对象({0})的关键字为空！", objTabObj._TabName_Curr);
                throw new Exception(strMsg);
            }
            MenuItem objTN = new MenuItem();
            objTN.Value = string.Format("{0},{1}",
                    objTabObj._TabName_Curr,
                    objTabObj._KeyId);
            objTN.Text = objTabObj._NameValue;
            return objTN;
        }

        //绑定角色
        public static void BindMnu_Role(Menu objMenu)
        {
            //            List<clsQxDepartmentInfoEN> arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege !='0000' order by CollegeID");
            List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(" 1=1 order by RoleName");

            MenuItem tnRoot = new MenuItem();
            //			MenuItem tnRole = null;
            //			MenuItem tnMajor = null;
            //			MenuItem tnGrade = null;
            //			MenuItem tnRange = null;
            MenuItem tnRole = null;

            objMenu.Items.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objMenu.Items.Add(tnRoot);

            foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList)  //QxDepartmentInfo
            {
                tnRole = new MenuItem();
                tnRole.Value = "Role," + objQxUserRoles.RoleId;
                tnRole.Text = objQxUserRoles.RoleName;
                objMenu.Items.Add(tnRole);

            }


            objMenu.StaticDisplayLevels = 2;
            objMenu.Items[0].Selected = true;
        }
        //绑定角色--用户
        public static void BindMnu_Role_User(Menu objMenu)
        {
            //            ArrayList arrUserObjList = clsQxUsers().GetQxUsersObjList(" id_User !='0000' order by UserID");
            List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(" 1=1 order by RoleName");
            List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelObjList = clsvQxUserRoleRelationBL.GetObjLst(" 1=1 order by UserID");

            //MenuItem tnRoot = new MenuItem();
            MenuItem tnUser = null;
            //			MenuItem tnMajor = null;
            //			MenuItem tnGrade = null;
            //			MenuItem tnRange = null;
            MenuItem tnRole = null;

            objMenu.Items.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objMenu.Items.Add(tnRoot);

            foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList)  //QxUsers
            {
                tnRole = new MenuItem();
                tnRole.Value = "Role," + objQxUserRoles.RoleId;
                tnRole.Text = objQxUserRoles.RoleName;
                objMenu.Items.Add(tnRole);
                foreach (clsvQxUserRoleRelationEN objvQxUserRoleRel in arrvQxUserRoleRelObjList)
                {
                    if (objvQxUserRoleRel.RoleId == objQxUserRoles.RoleId)
                    {
                        tnUser = new MenuItem();
                        tnUser.Value = "User," + objvQxUserRoleRel.UserId;
                        tnUser.Text = objvQxUserRoleRel.UserId + "(" + objvQxUserRoleRel.UserName + ")";
                        tnRole.ChildItems.Add(tnUser);
                    }
                }
            }


            //objMenu.StaticDisplayLevels=2;
            objMenu.Items[0].Selected = true;
        }

        //绑定权限类型
        public static void BindMnu_QxRightType(Menu objMenu)
        {
            //            List<clsQxDepartmentInfoEN> arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege !='0000' order by CollegeID");
            List<clsvQxPotenceTypeEN> arrvQxRightTypeObjList = clsvQxPotenceTypeBL.GetObjLst(" 1=1 order by PotenceTypeName");

            MenuItem tnRoot = new MenuItem();
            //			MenuItem tnRightType = null;
            //			MenuItem tnMajor = null;
            //			MenuItem tnGrade = null;
            //			MenuItem tnRange = null;
            MenuItem tnRightType = null;

            objMenu.Items.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objMenu.Items.Add(tnRoot);

            foreach (clsvQxPotenceTypeEN objvQxRightType in arrvQxRightTypeObjList)  //QxDepartmentInfo
            {
                tnRightType = new MenuItem();
                tnRightType.Value = "RightType," + objvQxRightType.PotenceTypeId;
                tnRightType.Text = objvQxRightType.PotenceTypeName;
                objMenu.Items.Add(tnRightType);

            }


            objMenu.StaticDisplayLevels = 2;
            objMenu.Items[0].Selected = true;
        }

        //绑定权限类型
        public static void BindMnu_XzSchool(Menu objMenu)
        {
            //            List<clsQxDepartmentInfoEN> arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege !='0000' order by CollegeID");
            List<clsXzSchoolEN> arrXzSchoolObjList = clsXzSchoolBL.GetObjLst(string.Format(" 1=1 order by {0}", conXzSchool.SchoolId));

            MenuItem tnRoot = new MenuItem();
            //			MenuItem tnXzSchool = null;
            //			MenuItem tnMajor = null;
            //			MenuItem tnGrade = null;
            //			MenuItem tnRange = null;
            MenuItem tnXzSchool = null;

            objMenu.Items.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objMenu.Items.Add(tnRoot);

            foreach (clsXzSchoolEN objXzSchool in arrXzSchoolObjList)  //QxDepartmentInfo
            {
                tnXzSchool = getMenuItemByTabObj(objXzSchool);
           
                objMenu.Items.Add(tnXzSchool);

            }


            objMenu.StaticDisplayLevels = 2;
            objMenu.Items[0].Selected = true;
        }


        //绑定权限类型--权限
        public static void BindMnu_QxRightType_Right(Menu objMenu)
        {
            //List<clsQxDepartmentInfoEN> arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege !='0000' order by CollegeID");
            List<clsvQxPotenceTypeEN> arrvQxRightTypeObjList = clsvQxPotenceTypeBL.GetObjLst(" 1=1 order by PotenceTypeName");
            List<clsQxPrjPotenceEN> arrQxRightObjList = clsQxPrjPotenceBL.GetObjLst(" 1=1 order by PotenceName");

            //MenuItem tnRoot = new MenuItem();
            MenuItem tnRight = null;
            //			MenuItem tnRightType = null;
            //			MenuItem tnMajor = null;
            //			MenuItem tnGrade = null;
            //			MenuItem tnRange = null;
            MenuItem tnRightType = null;

            objMenu.Items.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objMenu.Items.Add(tnRoot);

            foreach (clsvQxPotenceTypeEN objvQxRightType in arrvQxRightTypeObjList)  //QxDepartmentInfo
            {
                tnRightType = new MenuItem();
                tnRightType.Value = "RightType," + objvQxRightType.PotenceTypeId;
                tnRightType.Text = objvQxRightType.PotenceTypeName;
                objMenu.Items.Add(tnRightType);
                foreach (clsQxPrjPotenceEN objQxRight in arrQxRightObjList)
                {
                    if (objQxRight.PotenceTypeId == objvQxRightType.PotenceTypeId)
                    {
                        tnRight = new MenuItem();
                        tnRight.Value = "Right," + objQxRight.PotenceId;
                        tnRight.Text = objQxRight.PotenceName;
                        tnRightType.ChildItems.Add(tnRight);
                    }
                }
            }


            objMenu.StaticDisplayLevels = 2;
            objMenu.Items[0].Selected = true;
        }

        //绑定校区--教学楼
        public static void BindMnu_Project_QxUserRoles(Menu objMenu)
        {
            List<clsQxProjectsEN> arrQxProjectsObjList = clsQxProjectsBL.GetObjLst(" id_UniZone <> '0000' order by UniZoneID");
            List<clsQxRolesEN> arrQxUserRolesingObjList = clsQxRolesBL.GetObjLst(" 1=1 order by QxUserRolesID");

            MenuItem tnRoot = new MenuItem();
            //			MenuItem tnUniZone = null;
            //			MenuItem tnMajor = null;
            //			MenuItem tnGrade = null;
            //			MenuItem tnRange = null;
            MenuItem tnUniZone = null;
            MenuItem tnQxUserRoles = null;

            objMenu.Items.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "上海师范大学";
            objMenu.Items.Add(tnRoot);

            foreach (clsQxProjectsEN objQxProjects in arrQxProjectsObjList)  //QxDepartmentInfo
            {
                tnUniZone = getMenuItemByTabObj(objQxProjects);

                tnRoot.ChildItems.Add(tnUniZone);
                foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesingObjList)
                {
                    if (objQxUserRoles.QxPrjId == objQxProjects.QxPrjId)
                    {
                        tnQxUserRoles = getMenuItemByTabObj(objQxProjects);
                        tnUniZone.ChildItems.Add(tnQxUserRoles);
                    }
                }

                //			objMenu.StaticDisplayLevels=2;
                objMenu.Items[0].Selected = true;
            }

        }

    }
}

//public static void BindMnuCourse_Grade_QxUsers_QxUserRoles(Menu objMenu)
//{
//    string strCondition_XzSchool = string.Format("{0}='1'  order by {1}", conXzSchool.IsCurrentUse, conXzSchool.SchoolId);
//    List<clsXzSchoolEN> arrXzSchoolObjList = clsXzSchoolBL.GetObjLst(strCondition_XzSchool);
//    List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(" 1=1 ");
//    List<clsQxPrjPotenceEN> arrCourseObjList = clsQxPrjPotenceBL.GetObjLst(" id_Course<>'00000000'");
//    List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjList = clsvQxPrjMenus_UpBL.GetObjLst(" 1=1 ");
//    List<clsQxUsersEN> arrQxUsersObjList = clsQxUsersBL.GetObjLst(" 1=1 ");

//    MenuItem tnRoot = new MenuItem();
//    MenuItem tnQxUserRoles = null, tnvQxPrjMenus_Up = null, tnQxUsers = null; //,tnRange = null;
//    MenuItem tnXzSchool = null;
//    MenuItem tnCourse = null;

//    objMenu.Items.Clear();

//    //tnRoot.Value = "Root,0000";
//    //tnRoot.Text = "上海师范大学";
//    //objMenu.Items.Add(tnRoot);
//    foreach (clsXzSchoolEN objXzSchool in arrXzSchoolObjList) //XzXzSchool
//    {
//        tnXzSchool = new MenuItem();
//        tnXzSchool.Value = string.Format("{0},{1}",
//            clsXzSchoolEN._CurrTabName, objXzSchool.IdSchool);
//        tnXzSchool.Text = objXzSchool.SchoolName;
//        objMenu.Items.Add(tnXzSchool);
//        foreach (clsQxPrjPotenceEN objQxPrjPotence in arrCourseObjList) //XzMajor
//        {
//            tnCourse = new MenuItem();
//            tnCourse.Value = string.Format("{0},{1}",
//                clsQxPrjPotenceEN._CurrTabName, objQxPrjPotence.id_Course);
//            tnCourse.Text = objQxPrjPotence.CourseName;
//            tnXzSchool.ChildItems.Add(tnCourse);
//            foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_Up in arrvQxPrjMenus_UpObjList) //XzXzSchool
//            {
//                tnvQxPrjMenus_Up = new MenuItem();
//                tnvQxPrjMenus_Up.Value = string.Format("{0},{1}",
//                    clsvQxPrjMenus_UpEN._CurrTabName,
//                    objvQxPrjMenus_Up.id_Grade);
//                tnvQxPrjMenus_Up.Text = objvQxPrjMenus_Up.GradeName;
//                tnCourse.ChildItems.Add(tnvQxPrjMenus_Up);
//                foreach (clsQxUsersEN objQxUsers in arrQxUsersObjList) //XzMajor
//                {
//                    if (objQxUsers.id_Grade != objvQxPrjMenus_Up.id_Grade
//                        || objQxUsers.id_Course != objQxPrjPotence.id_Course) continue;
//                    tnQxUsers = new MenuItem();
//                    tnQxUsers.Value = string.Format("{0},{1}",
//                        clsQxUsersEN._CurrTabName,
//                        objQxUsers.UserId);
//                    tnQxUsers.Text = string.Format("{0}{1}",
//                        objQxUsers.ExamDate, clsCjScoreKindBL.GetScoreKindNameByid_ScoreKind_Cache(objQxUsers.id_ScoreKind));
//                    tnvQxPrjMenus_Up.ChildItems.Add(tnQxUsers);
//                    foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList)  //QxUserRoles
//                    {
//                        tnQxUserRoles = new MenuItem();
//                        tnQxUserRoles.Value = string.Format("{0},{1}",
//                           clsQxRolesEN._CurrTabName,
//                           objQxUserRoles.RoleId);
//                        tnQxUserRoles.Text = objQxUserRoles.StatsModeName;
//                        tnQxUsers.ChildItems.Add(tnQxUserRoles);
//                    }//foreach (clsQxRolesEN
//                }//foreach (clsQxUsersEN
//                if (tnvQxPrjMenus_Up.ChildItems.Count == 0)
//                {
//                    tnCourse.ChildItems.Remove(tnvQxPrjMenus_Up);
//                }
//            }
//        }
//    }

//    //			objMenu.StaticDisplayLevels=2;
//    try
//    {
//        objMenu.Items[0].Selected=true;
//    }
//    catch (Exception objException)
//    {
//        throw objException;

//    }
//}
//public static void BindMnuCourse_Grade_QxUserRoles_QxUsers(Menu objMenu)
//{
//    string strCondition_XzSchool = string.Format("{0}='1'  order by {1}", conXzSchool.IsCurrentUse, conXzSchool.SchoolId);
//    List<clsXzSchoolEN> arrXzSchoolObjList = clsXzSchoolBL.GetObjLst(strCondition_XzSchool);
//    List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(" 1=1 ");
//    List<clsQxPrjPotenceEN> arrCourseObjList = clsQxPrjPotenceBL.GetObjLst(" id_Course<>'00000000'");
//    List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjList = clsvQxPrjMenus_UpBL.GetObjLst(" 1=1 ");
//    List<clsQxUsersEN> arrQxUsersObjList = clsQxUsersBL.GetObjLst(" 1=1 ");
//    List<clsQxPotenceTypeEN> arrQxPotenceTypeObjList = clsQxPotenceTypeBL.GetObjLst(" 1=1 ");

//    MenuItem tnRoot = new MenuItem();
//    MenuItem tnQxUserRoles = null, tnvQxPrjMenus_Up = null, tnQxUsers = null; //,tnRange = null;
//    MenuItem tnXzSchool = null;
//    MenuItem tnCourse = null;
//    MenuItem tnQxPotenceType = null;
//    objMenu.Items.Clear();

//    //tnRoot.Value = "Root,0000";
//    //tnRoot.Text = "上海师范大学";
//    //objMenu.Items.Add(tnRoot);
//    foreach (clsXzSchoolEN objXzSchool in arrXzSchoolObjList) //XzXzSchool
//    {
//        tnXzSchool = new MenuItem();
//        tnXzSchool.Value = string.Format("{0},{1}",
//            clsXzSchoolEN._CurrTabName, objXzSchool.IdSchool);
//        tnXzSchool.Text = objXzSchool.SchoolName;
//        objMenu.Items.Add(tnXzSchool);
//        foreach (clsQxPrjPotenceEN objQxPrjPotence in arrCourseObjList) //XzMajor
//        {
//            tnCourse = new MenuItem();
//            tnCourse.Value = string.Format("{0},{1}",
//                clsQxPrjPotenceEN._CurrTabName, objQxPrjPotence.id_Course);
//            tnCourse.Text = objQxPrjPotence.CourseName;
//            tnXzSchool.ChildItems.Add(tnCourse);
//            foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_Up in arrvQxPrjMenus_UpObjList) //XzXzSchool
//            {
//                tnvQxPrjMenus_Up = new MenuItem();
//                tnvQxPrjMenus_Up.Value = string.Format("{0},{1}",
//                    clsvQxPrjMenus_UpEN._CurrTabName,
//                    objvQxPrjMenus_Up.id_Grade);
//                tnvQxPrjMenus_Up.Text = objvQxPrjMenus_Up.GradeName;
//                tnCourse.ChildItems.Add(tnvQxPrjMenus_Up);
//                foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList)  //QxUserRoles
//                {
//                    tnQxUserRoles = new MenuItem();
//                    tnQxUserRoles.Value = string.Format("{0},{1}",
//                       clsQxRolesEN._CurrTabName,
//                       objQxUserRoles.RoleId);
//                    tnQxUserRoles.Text = objQxUserRoles.StatsModeName;
//                    tnvQxPrjMenus_Up.ChildItems.Add(tnQxUserRoles);
//                    if (objQxUserRoles.RoleId == enumQxUserRoles.GradeQxUsersStatsistics_04)
//                    {
//                        foreach (clsQxPotenceTypeEN objQxPotenceType in arrQxPotenceTypeObjList) //XzMajor
//                        {
//                            if (objQxPotenceType.id_Grade != objvQxPrjMenus_Up.id_Grade
//                                || objQxPotenceType.IdSchool != objXzSchool.IdSchool) continue;
//                            tnQxPotenceType = new MenuItem();
//                            tnQxPotenceType.Value = string.Format("{0},{1}",
//                                clsQxPotenceTypeEN._CurrTabName,
//                                objQxPotenceType.PotenceTypeId);
//                            tnQxPotenceType.Text = objQxPotenceType.QxPotenceTypeName.Replace(objvQxPrjMenus_Up.GradeName, "");
//                            tnQxUserRoles.ChildItems.Add(tnQxPotenceType);

//                        }//foreach (clsQxPotenceTypeEN
//                    }
//                    else
//                    {
//                        foreach (clsQxUsersEN objQxUsers in arrQxUsersObjList) //XzMajor
//                        {
//                            if (objQxUsers.id_Grade != objvQxPrjMenus_Up.id_Grade
//                                || objQxUsers.id_Course != objQxPrjPotence.id_Course) continue;
//                            tnQxUsers = new MenuItem();
//                            tnQxUsers.Value = string.Format("{0},{1}",
//                                clsQxUsersEN._CurrTabName,
//                                objQxUsers.UserId);
//                            tnQxUsers.Text = string.Format("{0}{1}",
//                                objQxUsers.ExamDate, clsCjScoreKindBL.GetScoreKindNameByid_ScoreKind_Cache(objQxUsers.id_ScoreKind));
//                            tnQxUserRoles.ChildItems.Add(tnQxUsers);

//                        }//foreach (clsQxUsersEN
//                    }
//                }//foreach (clsQxRolesEN 
//                if (tnvQxPrjMenus_Up.ChildItems.Count == 0)
//                {
//                    tnCourse.ChildItems.Remove(tnvQxPrjMenus_Up);
//                }
//            }
//        }
//    }

//    //			objMenu.StaticDisplayLevels=2;
//    try
//    {
//        objMenu.Items[0].Selected=true;
//    }
//    catch (Exception objException)
//    {
//        throw objException;
//    }
//}

//public static void BindMnuGrade_QxUserRoles_Course_QxUsers(Menu objMenu)
//{
//    string strCondition_XzSchool = string.Format("{0}='1'  order by {1}", conXzSchool.IsCurrentUse, conXzSchool.SchoolId);
//    List<clsXzSchoolEN> arrXzSchoolObjList = clsXzSchoolBL.GetObjLst(strCondition_XzSchool);
//    List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(" 1=1 ");
//    List<clsQxPrjPotenceEN> arrCourseObjList = clsQxPrjPotenceBL.GetObjLst(" id_Course<>'00000000'");
//    List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjList = clsvQxPrjMenus_UpBL.GetObjLst(" 1=1 ");
//    List<clsQxUsersEN> arrQxUsersObjList = clsQxUsersBL.GetObjLst(" 1=1 ");
//    List<clsQxPotenceTypeEN> arrQxPotenceTypeObjList = clsQxPotenceTypeBL.GetObjLst(" 1=1 ");

//    MenuItem tnRoot = new MenuItem();
//    MenuItem tnQxUserRoles = null, tnvQxPrjMenus_Up = null, tnQxUsers = null; //,tnRange = null;
//    MenuItem tnXzSchool = null;
//    MenuItem tnCourse = null;
//    MenuItem tnQxPotenceType = null;
//    objMenu.Items.Clear();

//    //tnRoot.Value = "Root,0000";
//    //tnRoot.Text = "上海师范大学";
//    //objMenu.Items.Add(tnRoot);
//    foreach (clsXzSchoolEN objXzSchool in arrXzSchoolObjList) //XzXzSchool
//    {
//        tnXzSchool = new MenuItem();
//        tnXzSchool.Value = string.Format("{0},{1}",
//            clsXzSchoolEN._CurrTabName, objXzSchool.IdSchool);
//        tnXzSchool.Text = objXzSchool.SchoolName;
//        objMenu.Items.Add(tnXzSchool);
//        foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_Up in arrvQxPrjMenus_UpObjList) //XzXzSchool
//        {
//            tnvQxPrjMenus_Up = new MenuItem();
//            tnvQxPrjMenus_Up.Value = string.Format("{0},{1}",
//                clsvQxPrjMenus_UpEN._CurrTabName,
//                objvQxPrjMenus_Up.id_Grade);
//            tnvQxPrjMenus_Up.Text = objvQxPrjMenus_Up.GradeName;
//            tnXzSchool.ChildItems.Add(tnvQxPrjMenus_Up);

//            foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList)  //QxUserRoles
//            {
//                tnQxUserRoles = new MenuItem();
//                tnQxUserRoles.Value = string.Format("{0},{1}",
//                   clsQxRolesEN._CurrTabName,
//                   objQxUserRoles.RoleId);
//                tnQxUserRoles.Text = objQxUserRoles.StatsModeName;
//                tnvQxPrjMenus_Up.ChildItems.Add(tnQxUserRoles);
//                if (objQxUserRoles.RoleId == enumQxUserRoles.GradeQxUsersStatsistics_04)
//                {
//                    foreach (clsQxPotenceTypeEN objQxPotenceType in arrQxPotenceTypeObjList) //XzMajor
//                    {
//                        if (objQxPotenceType.id_Grade != objvQxPrjMenus_Up.id_Grade
//                            || objQxPotenceType.IdSchool != objXzSchool.IdSchool) continue;
//                        tnQxPotenceType = new MenuItem();
//                        tnQxPotenceType.Value = string.Format("{0},{1}",
//                            clsQxPotenceTypeEN._CurrTabName,
//                            objQxPotenceType.PotenceTypeId);
//                        tnQxPotenceType.Text = objQxPotenceType.QxPotenceTypeName.Replace(objvQxPrjMenus_Up.GradeName, "");
//                        tnQxUserRoles.ChildItems.Add(tnQxPotenceType);

//                    }//foreach (clsQxPotenceTypeEN
//                }
//                else
//                {
//                    foreach (clsQxPrjPotenceEN objQxPrjPotence in arrCourseObjList) //XzMajor
//                    {
//                        tnCourse = new MenuItem();
//                        tnCourse.Value = string.Format("{0},{1}",
//                            clsQxPrjPotenceEN._CurrTabName, objQxPrjPotence.id_Course);
//                        tnCourse.Text = objQxPrjPotence.CourseName;
//                        tnQxUserRoles.ChildItems.Add(tnCourse);

//                        foreach (clsQxUsersEN objQxUsers in arrQxUsersObjList) //XzMajor
//                        {
//                            if (objQxUsers.id_Grade != objvQxPrjMenus_Up.id_Grade
//                                || objQxUsers.id_Course != objQxPrjPotence.id_Course) continue;
//                            tnQxUsers = new MenuItem();
//                            tnQxUsers.Value = string.Format("{0},{1}",
//                                clsQxUsersEN._CurrTabName,
//                                objQxUsers.UserId);
//                            tnQxUsers.Text = string.Format("{0}{1}",
//                                objQxUsers.ExamDate, clsCjScoreKindBL.GetScoreKindNameByid_ScoreKind_Cache(objQxUsers.id_ScoreKind));
//                            tnCourse.ChildItems.Add(tnQxUsers);

//                        }//foreach (clsQxUsersEN
//                        if (tnCourse.ChildItems.Count == 0)
//                        {
//                            tnQxUserRoles.ChildItems.Remove(tnCourse);
//                        }
//                    }
//                }//foreach (clsQxRolesEN 
//                if (tnvQxPrjMenus_Up.ChildItems.Count == 0)
//                {
//                    tnCourse.ChildItems.Remove(tnvQxPrjMenus_Up);
//                }
//            }
//        }
//    }

//    //			objMenu.StaticDisplayLevels=2;
//    try
//    {
//        objMenu.Items[0].Selected=true;
//    }
//    catch (Exception objException)
//    {
//        throw objException;
//    }
//}
//public static void BindMnu_Grade_Course_QxUsers(Menu objMenu)
//{
//    string strCondition_XzSchool = string.Format("{0}='1'  order by {1}", conXzSchool.IsCurrentUse, conXzSchool.SchoolId);
//    //List<clsXzSchoolEN> arrXzSchoolObjList = clsXzSchoolBL.GetObjLst(strCondition_XzSchool);
//    //List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(" 1=1 ");
//    List<clsQxPrjPotenceEN> arrCourseObjList = clsQxPrjPotenceBL.GetObjLst(" id_Course<>'00000000'");
//    List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjList = clsvQxPrjMenus_UpBL.GetObjLst(" 1=1 ");
//    List<clsQxUsersEN> arrQxUsersObjList = clsQxUsersBL.GetObjLst(" 1=1 ");
//    //List<clsQxPotenceTypeEN> arrQxPotenceTypeObjList = clsQxPotenceTypeBL.GetObjLst(" 1=1 ");

//    MenuItem tnRoot = new MenuItem();
//    //MenuItem tnQxUserRoles = null;
//    MenuItem tnvQxPrjMenus_Up = null, tnQxUsers = null; //,tnRange = null;
//    //MenuItem tnXzSchool = null;
//    MenuItem tnCourse = null;
//    //MenuItem tnQxPotenceType = null;
//    objMenu.Items.Clear();
//    //objMenu.NodeStyle = "aa";
//    //tnRoot.Value = "Root,0000";
//    //tnRoot.Text = "上海师范大学";
//    //objMenu.Items.Add(tnRoot);
//    //foreach (clsXzSchoolEN objXzSchool in arrXzSchoolObjList) //XzXzSchool
//    //{
//    //    tnXzSchool = new MenuItem();
//    //    tnXzSchool.Value = string.Format("{0},{1}",
//    //        clsXzSchoolEN._CurrTabName, objXzSchool.IdSchool);
//    //    tnXzSchool.Text = objXzSchool.SchoolName;
//    //    objMenu.Items.Add(tnXzSchool);
//    foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_Up in arrvQxPrjMenus_UpObjList) //XzXzSchool
//    {
//        tnvQxPrjMenus_Up = getMenuItemByTabObj(objvQxPrjMenus_Up);

//        objMenu.Items.Add(tnvQxPrjMenus_Up);

//        //foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList)  //QxUserRoles
//        //{
//        //    tnQxUserRoles = new MenuItem();
//        //    tnQxUserRoles.Value = string.Format("{0},{1}",
//        //       clsQxRolesEN._CurrTabName,
//        //       objQxUserRoles.RoleId);
//        //    tnQxUserRoles.Text = objQxUserRoles.StatsModeName;
//        //    tnvQxPrjMenus_Up.ChildItems.Add(tnQxUserRoles);

//        foreach (clsQxPrjPotenceEN objQxPrjPotence in arrCourseObjList) //XzMajor
//        {

//            tnCourse = getMenuItemByTabObj(objQxPrjPotence);

//            tnvQxPrjMenus_Up.ChildItems.Add(tnCourse);

//            foreach (clsQxUsersEN objQxUsers in arrQxUsersObjList) //XzMajor
//            {
//                if (objQxUsers.id_Grade != objvQxPrjMenus_Up.id_Grade
//                    || objQxUsers.id_Course != objQxPrjPotence.id_Course) continue;

//                tnQxUsers = getMenuItemByTabObj(objQxUsers);


//                tnQxUsers.Text = string.Format("{0}{1}",
//                    objQxUsers.ExamDate, clsCjScoreKindBL.GetScoreKindNameByid_ScoreKind_Cache(objQxUsers.id_ScoreKind));
//                tnCourse.ChildItems.Add(tnQxUsers);

//            }//foreach (clsQxUsersEN
//            if (tnCourse.ChildItems.Count == 0)
//            {
//                tnvQxPrjMenus_Up.ChildItems.Remove(tnCourse);
//            }
//        }
//        if (tnvQxPrjMenus_Up.ChildItems.Count == 0)
//        {
//            tnCourse.ChildItems.Remove(tnvQxPrjMenus_Up);
//        }

//    }


//    //			objMenu.StaticDisplayLevels=2;
//    try
//    {
//        objMenu.Items[0].Selected=true;
//    }
//    catch (Exception objException)
//    {
//        throw objException;
//    }
//}