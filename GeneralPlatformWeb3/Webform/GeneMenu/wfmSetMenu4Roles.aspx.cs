using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;
using System.Text;
using GeneralPlatform;
using CommFunc4WebForm;
using com.taishsoft.common;
using GeneralPlatform.BusinessLogic;
using System.Collections.Generic;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmSetMenu4Roles 的摘要说明。
    /// </summary>
    public partial class wfmSetMenu4Roles : System.Web.UI.Page
    {

        private const string ViewId = "00010201";
        private string level;

        private void Page_Load(object sender, System.EventArgs e)
        {
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

            //获取当前用户的权限等级编号
            level = new MenuAndPotence().Get_PotenceLevel(ViewId);
            this.tvRoles.Attributes.Add("onclick", "postBackByObject()");

            // 在此处放置用户代码以初始化页面
            if (!Page.IsPostBack)
            {
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (level)
                {
                    case "0":

                        Response.Redirect("../error.aspx");
                        break;
                    case "1":



                        break;
                    case "2":

                        this.ddlPrj.Enabled = false;

                        break;
                    case "3":

                        Response.Redirect("../error.aspx");

                        break;

                    case "4":

                        Response.Redirect("../error.aspx");

                        break;


                    default:
                        Response.Redirect("../error.aspx");
                        break;
                }

                clsQxProjectsBL.BindDdl_QxPrjIdCache(this.ddlPrj);
                this.ddlPrj.SelectedValue = getUserPrjId;
                string strUserPrjId = getUserPrjId;
                clsQxPrjMenuSetBLEx.BindDdl_MenuSetIdEx(ddlPrjMenuSet, strUserPrjId);
                string strDefaultMenuSetId = clsQxPrjMenuSetBLEx.GetDefaultMenuSetIdByPrjId(strUserPrjId);
                if (string.IsNullOrEmpty(strDefaultMenuSetId) == false)
                {
                    ddlPrjMenuSet.SelectedValue = strDefaultMenuSetId;
                }
                ShowRolesTree();
                ShowMenuTree();
            }
        }

        #region Web 窗体设计器生成的代码
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ddlPrj.SelectedIndexChanged += new System.EventHandler(this.ddlPrj_SelectedIndexChanged);
            this.Load += new System.EventHandler(this.Page_Load);

        }
        #endregion



        private void ShowRolesTree()
        {
            DataTable objDtRoles;
            TreeNode tnRoot, tnRoles;
            int iRow;
            DataRow objRow;

            clsQxRolesEN objRoles = new clsQxRolesEN();
            string strCondition = string.Format(" {0} = '{1}'",
                  conQxRoles.QxPrjId, this.ddlPrj.SelectedValue);
            objDtRoles = clsQxRolesBL.GetDataTable_QxRoles(strCondition);
            tnRoot = new TreeNode();
            tnRoot.Value = "root,root";
            tnRoot.Text = "所有角色";
            //			tnRoot.CheckBox=true;
            tvRoles.Nodes.Add(tnRoot);
            for (iRow = 0; iRow < objDtRoles.Rows.Count; iRow++)
            {
                objRow = objDtRoles.Rows[iRow];
                tnRoles = new TreeNode();
                tnRoles.Value = "Roles," + objRow["RoleId"].ToString();
                tnRoles.Text = objRow["RoleName"].ToString();
                //				tnRoles.CheckBox = true;
                tnRoot.ChildNodes.Add(tnRoles);
            }

            string strCurrNodeId = new clsCommonSession().CurrRoleNodeId;
            if (strCurrNodeId != "root")
            {
                Stack objStack = new Stack();
                TreeNode tnCurrNode = clsCommForWebForm.GetNodeFromTreeViewByID(tvRoles.Nodes[0], strCurrNodeId);
                if (tnCurrNode == null) return;
                TreeNode tnTemp = tnCurrNode;
                objStack.Push(tnCurrNode);
                while (true)
                {
                    TreeNode tnParentCurrNode = tnTemp.Parent;
                    string strParentNodeId = clsCommForWebForm.getNodeID_S(tnParentCurrNode);
                    if (strParentNodeId != "root")
                    {
                        objStack.Push(tnParentCurrNode);
                    }
                    else
                    {
                        break;
                    }
                    tnTemp = tnParentCurrNode;
                }
                tvRoles.Nodes[0].Expand();
                tnTemp = objStack.Pop() as TreeNode;
                while (objStack.Count > 0)
                {
                    tnTemp.Expand();
                    tnTemp = objStack.Pop() as TreeNode;
                }
                //TreeNode tnParentCurrNode = tnCurrNode.Parent;  // clsCommForWebForm.GetParentNodeFromTreeViewByID(tvQxPrjMenus.Nodes[0], strCurrNodeId);
                //tnParentCurrNode.Expand();

                tnCurrNode.Select();
                tnCurrNode.ExpandAll();
            }
            else
            {
                tvRoles.ExpandDepth = 1;
            }

        }

        private void ShowMenuTree()
        {
            //System.Data.DataTable objDTUpMenu, objDTSubMenu;
            List<clsQxPrjMenusEN> arrUpMenuObjList = null;
            List<clsQxPrjMenusEN> arrSubMenuObjList = null;

            clsQxPrjMenusBLEx objPrjMenuEx = new clsQxPrjMenusBLEx();
            StringBuilder strCondition = new StringBuilder();
            StringBuilder strCondition2 = new StringBuilder();

            StringBuilder strHtml = new StringBuilder();		//需要插入的HTML代码

            StringBuilder strMenuSubItem = new StringBuilder();
            string strMenuId, strUpMenuId, strSubMenuId;
            string strUpMenuName, strSubMenuName, strLinkFile, strUpImgFile, strSubImgFile;

            //1、获取主菜单项
            if (ddlPrjMenuSet.SelectedIndex > 0)
            {
                string strPrjMenuSetId = ddlPrjMenuSet.SelectedValue;
                strCondition.AppendFormat("UpMenuId = '00000000' and {2} = '{0}' And MenuSetId='{1}' order by OrderNum ",
                    this.ddlPrj.SelectedValue, strPrjMenuSetId,
                    conQxPrjMenus.QxPrjId);
                strCondition2.AppendFormat("UpMenuId <> '00000000' and {2} = '{0}' And MenuSetId='{1}' order by OrderNum", 
                    this.ddlPrj.SelectedValue, strPrjMenuSetId,                    
                    conQxPrjMenus.QxPrjId);
            }
            else
            {
                strCondition.AppendFormat("UpMenuId = '00000000' and {1} = '{0}' order by OrderNum ", 
                    this.ddlPrj.SelectedValue,
                    conQxPrjMenus.QxPrjId);
                strCondition2.AppendFormat("UpMenuId <> '00000000' and {1} = '{0}' order by OrderNum", 
                    this.ddlPrj.SelectedValue,
                    conQxPrjMenus.QxPrjId);
            }
            arrUpMenuObjList = clsQxPrjMenusBL.GetObjLst(strCondition.ToString());
            //2、获取相应子菜单项
            arrSubMenuObjList = clsQxPrjMenusBL.GetObjLst(strCondition2.ToString());

            //			string strPrjId = ConfigurationSettings.AppSettings[conQxProjects.QxPrjId];

            TreeNode tnRoot, tnUpMenuItem, tnSubMenuItem, tnLeafNode;
            if (new clsCommonSession().CurrNodeId == "")
            {
                new clsCommonSession().CurrNodeId = "root";
            }
            tvQxPrjMenus.Nodes.Clear();
            tnRoot = new TreeNode();
            tnRoot.Value = "root,root";
            tnRoot.Text = "项目菜单结构: ";
            tnRoot.ShowCheckBox = true;
            tvQxPrjMenus.Nodes.Add(tnRoot);

            foreach (clsQxPrjMenusEN objPrjMenu_Up in arrUpMenuObjList)
            {
                strMenuId = objPrjMenu_Up.MenuId;	//获取主菜单项ID
                strUpMenuName = objPrjMenu_Up.MenuName + objPrjMenu_Up.MenuId; //获取主菜单项NAME
                strUpImgFile = objPrjMenu_Up.ImgFile;

                tnUpMenuItem = new TreeNode();
                tnUpMenuItem.Value = "UpMenu," + strMenuId;	//分类码

                tnUpMenuItem.Text = strUpMenuName;	//分类名称
                if (strUpImgFile.Length > 0)
                {
                    tnUpMenuItem.ImageUrl = "../" + strUpImgFile;
                }

                tnUpMenuItem.ShowCheckBox = true;
                tnRoot.ChildNodes.Add(tnUpMenuItem);

                foreach (clsQxPrjMenusEN objPrjMenu_Sub in arrSubMenuObjList)
                {
                    strUpMenuId = objPrjMenu_Sub.UpMenuId;

                    if (strMenuId == strUpMenuId)
                    {
                        strSubMenuId = objPrjMenu_Sub.MenuId;	//获取主菜单项ID
                        strSubMenuName = objPrjMenu_Sub.MenuName + objPrjMenu_Sub.MenuId + (objPrjMenu_Sub.IsLeafNode ? "(叶子)" : ""); //获取主菜单项NAME
                        strSubImgFile = objPrjMenu_Sub.ImgFile;
                        strLinkFile = objPrjMenu_Sub.LinkFile;

                        tnSubMenuItem = new TreeNode();
                        tnSubMenuItem.Value = "SubMenu," + strSubMenuId;

                        tnSubMenuItem.Text = strSubMenuName;
                        if (strSubImgFile.Length > 0)
                        {
                            tnSubMenuItem.ImageUrl = "../" + strSubImgFile;
                        }
                        tnSubMenuItem.ShowCheckBox = true;
                        tnUpMenuItem.ChildNodes.Add(tnSubMenuItem);
                        foreach (clsQxPrjMenusEN objPrjMenu_Sub2 in arrSubMenuObjList)
                        {
                            if (objPrjMenu_Sub2.UpMenuId == objPrjMenu_Sub.MenuId)
                            {
                                tnLeafNode = new TreeNode();
                                tnLeafNode.Value = "LeafNode," + objPrjMenu_Sub2.MenuId;

                                tnLeafNode.Text = objPrjMenu_Sub2.MenuName + objPrjMenu_Sub2.MenuId + (objPrjMenu_Sub2.IsLeafNode ? "(叶子)" : "");
                                if (objPrjMenu_Sub2.ImgFile.Length > 0)
                                {
                                    tnLeafNode.ImageUrl = "../" + objPrjMenu_Sub2.ImgFile;
                                }
                                tnLeafNode.ShowCheckBox = true;
                                tnSubMenuItem.ChildNodes.Add(tnLeafNode);
                            }
                        }

                    }
                }
            }

            string strCurrNodeId = new clsCommonSession().CurrNodeId;
            if (strCurrNodeId != "root")
            {
                Stack objStack = new Stack();
                TreeNode tnCurrNode = clsCommForWebForm.GetNodeFromTreeViewByID(tvQxPrjMenus.Nodes[0], strCurrNodeId);
                TreeNode tnTemp = tnCurrNode;
                objStack.Push(tnCurrNode);
                while (true)
                {
                    TreeNode tnParentCurrNode = tnTemp.Parent;
                    string strParentNodeId = clsCommForWebForm.getNodeID_S(tnParentCurrNode);
                    if (strParentNodeId != "root")
                    {
                        objStack.Push(tnParentCurrNode);
                    }
                    else
                    {
                        break;
                    }
                    tnTemp = tnParentCurrNode;
                    if (tnTemp == null) break;
                }
                tvQxPrjMenus.Nodes[0].Expand();
                tnTemp = objStack.Pop() as TreeNode;
                while (objStack.Count > 0)
                {
                    tnTemp.Expand();
                    tnTemp = objStack.Pop() as TreeNode;
                }
                //TreeNode tnParentCurrNode = tnCurrNode.Parent;  // clsCommForWebForm.GetParentNodeFromTreeViewByID(tvQxPrjMenus.Nodes[0], strCurrNodeId);
                //tnParentCurrNode.Expand();

                tnCurrNode.Select();
                tnCurrNode.ExpandAll();
            }
            else
            {
                tvQxPrjMenus.ExpandDepth = 1;
            }
        }


        private void ShowMenuTreeWithRoleId(string RoleId)
        {
            //ArrayList arrUpMenuObjList = null;
            //ArrayList arrSubMenuObjList = null;

            System.Data.DataTable objDTUpMenu, objDTSubMenu;
            clsQxPrjMenusBLEx objPrjMenuEx = new clsQxPrjMenusBLEx();
            StringBuilder strCondition = new StringBuilder();
            StringBuilder strCondition2 = new StringBuilder();

            StringBuilder strHtml = new StringBuilder();		//需要插入的HTML代码

            StringBuilder strMenuSubItem = new StringBuilder();
            string strMenuId, strUpMenuId, strUpMenuId4Leaf, strSubMenuId, strLeafMenuId;
            string strUpMenuName, strSubMenuName, strLeafMenuName, strLinkFile, strUpImgFile, strSubImgFile, strLeafImgFile;

            //1、获取主菜单项
            if (ddlPrjMenuSet.SelectedIndex > 0)
            {
                string strPrjMenuSetId = ddlPrjMenuSet.SelectedValue;
                strCondition.AppendFormat("UpMenuId = '00000000' and QxPrjMenus.QxPrjId = '{0}' And MenuSetId='{1}' ", this.ddlPrj.SelectedValue, strPrjMenuSetId);
                strCondition2.AppendFormat("UpMenuId <> '00000000' and QxPrjMenus.QxPrjId = '{0}' And MenuSetId='{1}' ", this.ddlPrj.SelectedValue, strPrjMenuSetId);
            }
            else
            {
                strCondition.AppendFormat("UpMenuId = '00000000' and QxPrjMenus.QxPrjId = '{0}' ", this.ddlPrj.SelectedValue);
                strCondition2.AppendFormat("UpMenuId <> '00000000' and QxPrjMenus.QxPrjId = '{0}' ", this.ddlPrj.SelectedValue);
            }
 
            objDTUpMenu = objPrjMenuEx.GetTableExWithRoleId(strCondition.ToString(), "OrderNum", RoleId, this.ddlPrj.SelectedValue);
            //2、获取相应子菜单项
            objDTSubMenu = objPrjMenuEx.GetTableExWithRoleId(strCondition2.ToString(), "OrderNum", RoleId, this.ddlPrj.SelectedValue);

            //			string strPrjId = ConfigurationSettings.AppSettings[conQxProjects.QxPrjId];

            TreeNode tnRoot, tnUpMenuItem, tnSubMenuItem, tnLeafMenuItem;

            tvQxPrjMenus.Nodes.Clear();
            tnRoot = new TreeNode();
            tnRoot.Value = "root,root";
            tnRoot.Text = "项目菜单结构: ";
            //			tnRoot.CheckBox=true;
            tvQxPrjMenus.Nodes.Add(tnRoot);

            foreach (DataRow UpMenuRow in objDTUpMenu.Rows)
            {
                strMenuId = UpMenuRow["MenuId"].ToString();	//获取主菜单项ID
                strUpMenuName = UpMenuRow["MenuName"].ToString(); //获取主菜单项NAME
                strUpImgFile = UpMenuRow["ImgFile"].ToString();

                tnUpMenuItem = new TreeNode();
                tnUpMenuItem.Value = "UpMenu," + strMenuId;	//分类码

                tnUpMenuItem.Text = strUpMenuName;	//分类名称
                tnUpMenuItem.ShowCheckBox = true;
                if (UpMenuRow["RoleMenuId"].ToString().Length == 0)
                {

                }
                else
                {
                    tnUpMenuItem.Checked = true;
                }



                tnRoot.ChildNodes.Add(tnUpMenuItem);

                foreach (DataRow SubMenuRow in objDTSubMenu.Rows)
                {
                    strUpMenuId = SubMenuRow["UpMenuId"].ToString();

                    if (strMenuId == strUpMenuId)
                    {
                        strSubMenuId = SubMenuRow["MenuId"].ToString();	//获取主菜单项ID
                        strSubMenuName = SubMenuRow["MenuName"].ToString(); //获取主菜单项NAME
                        strSubImgFile = SubMenuRow["ImgFile"].ToString();
                        strLinkFile = SubMenuRow["LinkFile"].ToString();

                        tnSubMenuItem = new TreeNode();
                        tnSubMenuItem.Value = "SubMenu," + strSubMenuId; ;

                        tnSubMenuItem.Text = strSubMenuName;
                        tnSubMenuItem.ShowCheckBox = true;
                        if (SubMenuRow["RoleMenuId"].ToString().Length == 0)
                        {

                        }
                        else
                        {
                            tnSubMenuItem.Checked = true;
                        }


                        tnUpMenuItem.ChildNodes.Add(tnSubMenuItem);

                        foreach (DataRow LeafMenuRow in objDTSubMenu.Rows)
                        {
                            strUpMenuId4Leaf = LeafMenuRow["UpMenuId"].ToString();

                            if (strSubMenuId != strUpMenuId4Leaf) continue;
                            strLeafMenuId = LeafMenuRow["MenuId"].ToString();	//获取主菜单项ID
                            strLeafMenuName = LeafMenuRow["MenuName"].ToString(); //获取主菜单项NAME
                            strLeafImgFile = LeafMenuRow["ImgFile"].ToString();
                            //strLinkFile = LeafMenuRow["LinkFile"].ToString();

                            tnLeafMenuItem = new TreeNode();
                            tnLeafMenuItem.Value = "LeafNode," + strLeafMenuId; ;

                            tnLeafMenuItem.Text = strLeafMenuName;
                            tnLeafMenuItem.ShowCheckBox = true;
                            if (LeafMenuRow["RoleMenuId"].ToString().Length == 0)
                            {

                            }
                            else
                            {
                                tnLeafMenuItem.Checked = true;
                            }
                            tnSubMenuItem.ChildNodes.Add(tnLeafMenuItem);
                        }
                    }
                }
            }
            tvQxPrjMenus.ExpandAll();
        }

        protected void btnSaveMenues_Click(object sender, System.EventArgs e)
        {
            //1 先做一次循环遍历,让子菜单打钩,但是根菜单没有打钩的根菜单都打好钩
            //2 检查有没有角色被选中
            //3 把所有打钩的菜单编号都放进一个ArryList
            //4 把ArryList中的菜单编号写进RoleMenues表中

            foreach (TreeNode tnboot in tvQxPrjMenus.Nodes) //1 先做一次循环遍历,让子菜单打钩,但是根菜单没有打钩的根菜单都打好钩
            {
                foreach (TreeNode tnUpMenuItem in tnboot.ChildNodes)
                {
                    foreach (TreeNode tnSubMenuItem in tnUpMenuItem.ChildNodes)
                    {
                        if (tnSubMenuItem.Checked)
                        {
                            tnUpMenuItem.Checked = true;
                            break;
                        }
                    }

                }

            }

            string strRoleId;
            string strMenuId;
            TreeNode tnRole = tvRoles.SelectedNode;
            string strNodeType = clsCommForWebForm.getNodeType_S(tvRoles.SelectedNode);
            if (strNodeType != "Roles")
            {
                Label1.Text = "请选择角色!";
                return;
            }
            else
            {
                strRoleId = clsCommForWebForm.getNodeID_S(tnRole);
            }

            List<string> arrCheckedMenus = getCheckedMenusNode(); //3 把所有打钩的菜单编号都放进一个ArryList
            //获取库中原来的角色菜单
            //clsQxRoleMenusBLEx objQxRoleMenusEx = new clsQxRoleMenusBLEx();
            StringBuilder sbCondition = new StringBuilder();
          
            if (ddlPrjMenuSet.SelectedIndex > 0)
            {
                string strPrjMenuSetId = ddlPrjMenuSet.SelectedValue;
                sbCondition.AppendFormat(" {3} = '{0}' And MenuId in (Select MenuId From QxPrjMenus where  MenuSetId='{1}') And RoleId = '{2}'",
                    this.ddlPrj.SelectedValue, strPrjMenuSetId, strRoleId,                    
                    conQxPrjMenus.QxPrjId);
            }
            else
            {
                sbCondition.AppendFormat("{2} = '{0}'  And RoleId = '{1}' ", 
                    this.ddlPrj.SelectedValue, strRoleId,
                    conQxPrjMenus.QxPrjId);
            }
            DataTable objDT_Old = clsQxRoleMenusBL.GetDataTable_QxRoleMenus(sbCondition.ToString());
            List<string> arrRoleMenu_Old = new List<string>();

            foreach (DataRow objRow in objDT_Old.Rows)
            {
                strMenuId = objRow["MenuId"].ToString();
                arrRoleMenu_Old.Add(strMenuId);
            }
            //找出修改后有，而原来没有，差集就为需要新增的菜单项
            List<string> arrNewMenu = clsAggregate.TwoAggrDiff(arrCheckedMenus, arrRoleMenu_Old);	//需要新增的菜单项
            //找出原来有，而现在没有，差集就为需要删除的菜单项
            List<string> arrMenuNeedDel = clsAggregate.TwoAggrDiff(arrRoleMenu_Old, arrCheckedMenus);//需要删除的菜单项
            //			objQxRoleMenusEx.GetTable.GetQxRoleMenus
            //			objQxRoleMenusEx.RoleDelAllPotence(CurrPrjId,strRoleId);
            //增加新的
            try
            {
                clsQxRoleMenusBLEx.RoleAddMenus(this.ddlPrj.SelectedValue, strRoleId, arrNewMenu, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            //删除老的
            foreach (object objDelMenu in arrMenuNeedDel)
            {
                clsQxRoleMenusBLEx.RoleDelMenu(this.ddlPrj.SelectedValue, strRoleId, objDelMenu.ToString());
            }
            Label1.Text = "设置成功!";
        }

        private List<string> getCheckedMenusNode()
        {
            List<string> arrLst = new List<string>();
            getCheckedMenusName(tvQxPrjMenus.Nodes[0], arrLst);
            return arrLst;
        }


        private void getCheckedMenusName(TreeNode tnTemp, List<string> arrLst)
        {
            string strKeyId = clsCommForWebForm.getNodeID_S(tnTemp);
            if (tnTemp.Checked == true)
            {
                arrLst.Add(strKeyId);
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                getCheckedMenusName(tn, arrLst);
            }
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            string strRoleId;
            TreeNode tnRole = tvRoles.SelectedNode;
            string strNodeType = clsCommForWebForm.getNodeType_S(tnRole);
            if (strNodeType != "Roles")
            {
                Label1.Text = "请选择角色!";
                return;
            }
            else
            {
                strRoleId = clsCommForWebForm.getNodeID_S(tnRole);
            }

            ShowMenuTreeWithRoleId(strRoleId);
        }

        protected void ddlPrj_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            this.tvQxPrjMenus.Nodes.Clear();
            this.tvRoles.Nodes.Clear();
            ShowRolesTree();
            ShowMenuTree();

        }
        protected void tvRoles_SelectedNodeChanged(object sender, EventArgs e)
        {
            string strCurrNodeId = clsCommForWebForm.getNodeID_S(tvRoles.SelectedNode);
            new clsCommonSession().CurrRoleNodeId = strCurrNodeId;

            string strRoleId;
            TreeNode tnRole = tvRoles.SelectedNode;
            string strNodeType = clsCommForWebForm.getNodeType_S(tnRole);
            if (strNodeType != "Roles")
            {
                Label1.Text = "请选择角色!";
                return;
            }
            else
            {
                strRoleId = clsCommForWebForm.getNodeID_S(tnRole);
            }

            ShowMenuTreeWithRoleId(strRoleId);
        }

        //protected void tvQxPrjMenus_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        //{
        //    //Label1.Text = "tvQxPrjMenus_TreeNodeCheckChanged";
        // //Label1.Text =   e.Node.Text;
        //}
        protected void ddlPrjMenuSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMenuTree();
              string strRoleId;
            TreeNode tnRole = tvRoles.SelectedNode;
            if (tnRole == null) return;
            string strNodeType = clsCommForWebForm.getNodeType_S(tnRole);
            if (strNodeType != "Roles")
            {
                Label1.Text = "请选择角色!";
                return;
            }
            else
            {
                strRoleId = clsCommForWebForm.getNodeID_S(tnRole);
            }

            ShowMenuTreeWithRoleId(strRoleId);
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

        /// <summary>
        /// 用户选择的工程Id。例如：“0150”等
        /// 作者：潘以锋
        /// 建立日期：2016-07-01
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
    }
}
