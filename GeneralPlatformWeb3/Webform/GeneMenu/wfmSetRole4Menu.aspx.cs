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
using com.taishsoft.web.treeview;

using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.web.treeview;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmSetMenu4Roles 的摘要说明。
    /// </summary>
    public partial class wfmSetRole4Menu : System.Web.UI.Page
    {

        private const string ViewId = "00010201";
        private string level;
        /// <summary>
        /// 当前树中所选择角色
        /// </summary>
        protected string vsRoleId
        {
            get
            {
                string sRoleId;
                sRoleId = (string)ViewState["RoleId"];
                if (sRoleId == null)
                {
                    sRoleId = "";
                }
                return sRoleId;
            }
            set
            {
                string sRoleId = value;
                ViewState.Add("RoleId", sRoleId);
            }
        }
        private void Page_Load(object sender, System.EventArgs e)
        {
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

            //获取当前用户的权限等级编号
            level = new MenuAndPotence().Get_PotenceLevel(ViewId);
            //this.tvRoles.Attributes.Add("onclick", "postBackByObject()");

            // 在此处放置用户代码以初始化页面
            if (!Page.IsPostBack)
            {
                CacheHelper.Remove(conQxPrjMenus._CurrTabName);

                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (level)
                {
                    case "0":

                        //Response.Redirect("../error.aspx");
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
                string strRoleIds = clsCommonSession.RoleId;
                string strUserPrjId = getUserPrjId;
                clsQxPrjMenuSetBLEx.BindDdl_MenuSetIdEx(ddlPrjMenuSet, strUserPrjId);
                string strDefaultMenuSetId = clsQxPrjMenuSetBLEx.GetDefaultMenuSetIdByPrjId(strUserPrjId);
                if (string.IsNullOrEmpty(strDefaultMenuSetId) == false)
                {
                    ddlPrjMenuSet.SelectedValue = strDefaultMenuSetId;
                }

                BindTv_vQxRolesByMenuNum();
                //ShowRolesTree();
                //ShowMenuTree();

                BindTv_QxPrjMenuUp_Sub();
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



        //private void ShowRolesTree()
        //{
        //    DataTable objDtRoles;
        //    TreeNode tnRoot, tnRoles;
        //    int iRow;
        //    DataRow objRow;

        //    clsQxRolesEN objRoles = new clsQxRolesEN();
        //    objDtRoles = clsQxRolesBL.GetDataTable_QxRoles(" QxPrjId = '" + this.ddlPrj.SelectedValue + "'");
        //    tnRoot = new TreeNode();
        //    tnRoot.Value = "root,root";
        //    tnRoot.Text = "所有角色";
        //    //			tnRoot.CheckBox=true;
        //    tvRoles.Nodes.Add(tnRoot);
        //    for (iRow = 0; iRow < objDtRoles.Rows.Count; iRow++)
        //    {
        //        objRow = objDtRoles.Rows[iRow];
        //        tnRoles = new TreeNode();
        //        tnRoles.Value = "Roles," + objRow["RoleId"].ToString();
        //        tnRoles.Text = objRow["RoleName"].ToString();
        //        //				tnRoles.CheckBox = true;
        //        tnRoot.ChildNodes.Add(tnRoles);
        //    }

        //    string strCurrNodeId = new clsCommonSession().CurrRoleNodeId;
        //    if (strCurrNodeId != "root")
        //    {
        //        Stack objStack = new Stack();
        //        TreeNode tnCurrNode = clsCommForWebForm.GetNodeFromTreeViewByID(tvRoles.Nodes[0], strCurrNodeId);
        //        if (tnCurrNode == null) return;
        //        TreeNode tnTemp = tnCurrNode;
        //        objStack.Push(tnCurrNode);
        //        while (true)
        //        {
        //            TreeNode tnParentCurrNode = tnTemp.Parent;
        //            string strParentNodeId = clsCommForWebForm.getNodeID_S(tnParentCurrNode);
        //            if (strParentNodeId != "root")
        //            {
        //                objStack.Push(tnParentCurrNode);
        //            }
        //            else
        //            {
        //                break;
        //            }
        //            tnTemp = tnParentCurrNode;
        //        }
        //        tvRoles.Nodes[0].Expand();
        //        tnTemp = objStack.Pop() as TreeNode;
        //        while (objStack.Count > 0)
        //        {
        //            tnTemp.Expand();
        //            tnTemp = objStack.Pop() as TreeNode;
        //        }
        //        //TreeNode tnParentCurrNode = tnCurrNode.Parent;  // clsCommForWebForm.GetParentNodeFromTreeViewByID(tvQxPrjMenus.Nodes[0], strCurrNodeId);
        //        //tnParentCurrNode.Expand();

        //        tnCurrNode.Select();
        //        tnCurrNode.ExpandAll();
        //    }
        //    else
        //    {
        //        tvRoles.ExpandDepth = 1;
        //    }

        //}


        private void BindTv_vQxRolesByMenuNum()
        {
            //1、获取主菜单项
            if (ddlPrjMenuSet.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个合适的菜单集！");
                return;
            }
            string strPrjMenuSetId = ddlPrjMenuSet.SelectedValue;
            string strPrjId = this.ddlPrj.SelectedValue;
            wucTreeView_Role.tmTreeModel = TreeModel.vQxRolesByMenuNum;
            try
            {

                wucTreeView_Role.ShowCheckBox = true;
                wucTreeView_Role.QxPrjId = strPrjId;
                wucTreeView_Role.MenuSetId = strPrjMenuSetId;
                wucTreeView_Role.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView_Menu.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            //string strKeyId = vsKeyId;
            //string strTypeName = vsTreeNodeType;
            ////wucTreeView1.CollapseAll();
            //wucTreeView1.SelectNodeEx(strTypeName, strKeyId);
            //vsCMClassId = "";
            //vsApplicationTypeId = "";
            //vsCodeTypeId = "";
        }


        private void BindTv_QxPrjMenuUp_Sub()
        {
            //1、获取主菜单项
            if (ddlPrjMenuSet.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个合适的菜单集！");
                return;
            }
            string strPrjMenuSetId = ddlPrjMenuSet.SelectedValue;
            string strPrjId = this.ddlPrj.SelectedValue;
            wucTreeView_Menu.tmTreeModel = TreeModel.QxPrjMenuUp_Sub;
            try
            {
                wucTreeView_Menu.QxPrjId = strPrjId;
                wucTreeView_Menu.MenuSetId = strPrjMenuSetId;
                wucTreeView_Menu.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView_Menu.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            //string strKeyId = vsKeyId;
            //string strTypeName = vsTreeNodeType;
            ////wucTreeView1.CollapseAll();
            //wucTreeView1.SelectNodeEx(strTypeName, strKeyId);
            //vsCMClassId = "";
            //vsApplicationTypeId = "";
            //vsCodeTypeId = "";
        }

        //        private void ShowMenuTree()
        //        {
        //            //System.Data.DataTable objDTUpMenu, objDTSubMenu;
        //            List<clsQxPrjMenusEN> arrPrjMenuObjList = null;
        //            //ArrayList arrSubMenuObjList = null;

        //            clsQxPrjMenusBLEx objPrjMenuEx = new clsQxPrjMenusBLEx();
        //            StringBuilder strCondition = new StringBuilder();

        //            string strMenuId, strUpMenuId, strSubMenuId;
        //            string strUpMenuName, strSubMenuName, strLinkFile, strUpImgFile, strSubImgFile;

        //            //1、获取主菜单项
        //            if (ddlPrjMenuSet.SelectedIndex <= 0)
        //            {
        //                clsCommonJsFunc.Alert(this, "请选择一个合适的菜单集！");
        //                return;
        //            }
        //            string strPrjMenuSetId = ddlPrjMenuSet.SelectedValue;
        //            strCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}' And MenuId not in (Select MenuId from vQxRoleMenus where RoleId='{2}' And UpMenuId<>'00000000' ) order by OrderNum ",
        //                this.ddlPrj.SelectedValue,
        //                strPrjMenuSetId,
        //                vsRoleId,
        //                constvQxRoleMenus.IsLeafNode);
        //            //strCondition2.AppendFormat("UpMenuId <> '00000000' and QxPrjId = '{0}' And MenuSetId='{1}' order by OrderNum", this.ddlPrj.SelectedValue, strPrjMenuSetId);

        //            arrPrjMenuObjList = clsQxPrjMenusBL.GetObjLst(strCondition.ToString());


        //            //			string strPrjId = ConfigurationSettings.AppSettings[conQxProjects.QxPrjId];

        //            TreeNode tnRoot, tnUpMenuItem, tnSubMenuItem, tnLeafNode;
        //            if (new clsCommonSession().CurrNodeId == "")
        //            {
        //                new clsCommonSession().CurrNodeId = "root";
        //            }
        //            tvQxPrjMenus.Nodes.Clear();
        //            tnRoot = new TreeNode();
        //            tnRoot.Value = "root,root";
        //            tnRoot.Text = "项目菜单: ";
        //            tnRoot.ShowCheckBox = true;
        //            tvQxPrjMenus.Nodes.Add(tnRoot);

        //            foreach (clsQxPrjMenusEN objPrjMenu_Up in arrPrjMenuObjList)
        //            {
        //                if (objPrjMenu_Up.UpMenuId != "00000000") continue;
        //                strMenuId = objPrjMenu_Up.MenuId;	//获取主菜单项ID
        ////                strUpMenuName = objPrjMenu_Up.MenuName + objPrjMenu_Up.MenuId + (objPrjMenu_Up.IsLeafNode ? "(叶子)" : ""); //获取主菜单项NAME

        //                strUpMenuName = string.Format("{0}{1}{2}{3}({4})",
        //                     objPrjMenu_Up.MenuName,
        //                     objPrjMenu_Up.MenuId,
        //                      (objPrjMenu_Up.IsLeafNode ? "(叶子)" : ""),
        //                      (objPrjMenu_Up.InUse ? "" : "(未用)"),
        //                      objPrjMenu_Up.OrderNum); //获取主菜单项NAME

        //                strUpImgFile = objPrjMenu_Up.ImgFile;

        //                tnUpMenuItem = new TreeNode();
        //                tnUpMenuItem.Value = "UpMenu," + strMenuId;	//分类码

        //                tnUpMenuItem.Text = strUpMenuName;	//分类名称
        //                if (strUpImgFile.Length > 0)
        //                {
        //                    tnUpMenuItem.ImageUrl = "../" + strUpImgFile;
        //                }

        //                tnUpMenuItem.ShowCheckBox = true;
        //                tnRoot.ChildNodes.Add(tnUpMenuItem);

        //                foreach (clsQxPrjMenusEN objPrjMenu_Sub in arrPrjMenuObjList)
        //                {
        //                    if (objPrjMenu_Sub.UpMenuId == "00000000") continue;

        //                    strUpMenuId = objPrjMenu_Sub.UpMenuId;

        //                    if (strMenuId == strUpMenuId)
        //                    {
        //                        strSubMenuId = objPrjMenu_Sub.MenuId;	//获取主菜单项ID
        ////                        strSubMenuName = objPrjMenu_Sub.MenuName + objPrjMenu_Sub.MenuId + (objPrjMenu_Sub.IsLeafNode ? "(叶子)" : ""); //获取主菜单项NAME
        //                        strSubMenuName = string.Format("{0}{1}{2}{3}({4})",
        //                    objPrjMenu_Sub.MenuName,
        //                    objPrjMenu_Sub.MenuId,
        //                     (objPrjMenu_Sub.IsLeafNode ? "(叶子)" : ""),
        //                     (objPrjMenu_Sub.InUse ? "" : "(未用)"),
        //                     objPrjMenu_Sub.OrderNum); //获取主菜单项NAME

        //                        strSubImgFile = objPrjMenu_Sub.ImgFile;
        //                        strLinkFile = objPrjMenu_Sub.LinkFile;

        //                        tnSubMenuItem = new TreeNode();
        //                        tnSubMenuItem.Value = "SubMenu," + strSubMenuId;

        //                        tnSubMenuItem.Text = strSubMenuName;
        //                        if (strSubImgFile.Length > 0)
        //                        {
        //                            tnSubMenuItem.ImageUrl = "../" + strSubImgFile;
        //                        }
        //                        tnSubMenuItem.ShowCheckBox = true;
        //                        tnUpMenuItem.ChildNodes.Add(tnSubMenuItem);
        //                        foreach (clsQxPrjMenusEN objPrjMenu_Sub2 in arrPrjMenuObjList)
        //                        {
        //                            if (objPrjMenu_Sub2.UpMenuId == objPrjMenu_Sub.MenuId)
        //                            {
        //                                tnLeafNode = new TreeNode();
        //                                tnLeafNode.Value = "LeafNode," + objPrjMenu_Sub2.MenuId;

        //                                tnLeafNode.Text = objPrjMenu_Sub2.MenuName + objPrjMenu_Sub2.MenuId + (objPrjMenu_Sub2.IsLeafNode ? "(叶子)" : "");
        //                                if (objPrjMenu_Sub2.ImgFile.Length > 0)
        //                                {
        //                                    tnLeafNode.ImageUrl = "../" + objPrjMenu_Sub2.ImgFile;
        //                                }
        //                                tnLeafNode.ShowCheckBox = true;
        //                                tnSubMenuItem.ChildNodes.Add(tnLeafNode);
        //                            }
        //                        }

        //                    }
        //                }
        //            }

        //            string strCurrNodeId = new clsCommonSession().CurrNodeId;
        //            if (strCurrNodeId != "root")
        //            {
        //                Stack objStack = new Stack();
        //                TreeNode tnCurrNode = clsCommForWebForm.GetNodeFromTreeViewByID(tvQxPrjMenus.Nodes[0], strCurrNodeId);
        //                if (tnCurrNode == null) return;
        //                TreeNode tnTemp = tnCurrNode;
        //                objStack.Push(tnCurrNode);
        //                while (true)
        //                {
        //                    TreeNode tnParentCurrNode = tnTemp.Parent;
        //                    string strParentNodeId = clsCommForWebForm.getNodeID_S(tnParentCurrNode);
        //                    if (strParentNodeId != "root")
        //                    {
        //                        objStack.Push(tnParentCurrNode);
        //                    }
        //                    else
        //                    {
        //                        break;
        //                    }
        //                    tnTemp = tnParentCurrNode;
        //                }
        //                tvQxPrjMenus.Nodes[0].Expand();
        //                tnTemp = objStack.Pop() as TreeNode;
        //                while (objStack.Count > 0)
        //                {
        //                    tnTemp.Expand();
        //                    tnTemp = objStack.Pop() as TreeNode;
        //                }
        //                //TreeNode tnParentCurrNode = tnCurrNode.Parent;  // clsCommForWebForm.GetParentNodeFromTreeViewByID(tvQxPrjMenus.Nodes[0], strCurrNodeId);
        //                //tnParentCurrNode.Expand();

        //                tnCurrNode.Select();
        //                tnCurrNode.ExpandAll();
        //            }
        //            else
        //            {
        //                tvQxPrjMenus.ExpandDepth = 1;
        //            }
        //            tvQxPrjMenus.Nodes[0].Expand();
        //            bool bolIsFirst = true;
        //            foreach (TreeNode tnTemp in tvQxPrjMenus.Nodes[0].ChildNodes)
        //            {
        //                if (bolIsFirst == true)
        //                {
        //                    bolIsFirst = false;
        //                    tnTemp.Expand();
        //                }
        //                else
        //                {
        //                    tnTemp.Collapse();
        //                }
        //            }
        //        }



        private void ShowMenuTreeWithRoleId(string strRoleId)
        {
            List<clsvQxRoleMenusEN> arrRoleMenuObjList = null;
            //ArrayList arrSubMenuObjList = null;

            //System.Data.DataTable objDTUpMenu, objDTSubMenu;
            clsQxPrjMenusBLEx objPrjMenuEx = new clsQxPrjMenusBLEx();
            StringBuilder strCondition = new StringBuilder();
            StringBuilder strCondition2 = new StringBuilder();

            StringBuilder strHtml = new StringBuilder();		//需要插入的HTML代码

            StringBuilder strMenuSubItem = new StringBuilder();
            string strMenuId, strUpMenuId, strUpMenuId4Leaf, strSubMenuId, strLeafMenuId;
            string strUpMenuName, strSubMenuName, strLeafMenuName, strLinkFile, strUpImgFile, strSubImgFile, strLeafImgFile;

            //1、获取主菜单项
            if (ddlPrjMenuSet.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个合适的菜单集！");
                return;
            }
            string strPrjMenuSetId = ddlPrjMenuSet.SelectedValue;
            strCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}' And RoleId='{2}' Order by OrderNum",
                this.ddlPrj.SelectedValue, strPrjMenuSetId, strRoleId);
            //strCondition2.AppendFormat("UpMenuId <> '00000000' and QxPrjMenus.QxPrjId = '{0}' And MenuSetId='{1}' ", this.ddlPrj.SelectedValue, strPrjMenuSetId);


            arrRoleMenuObjList = clsvQxRoleMenusBL.GetObjLst(strCondition.ToString());
            //2、获取相应子菜单项
            //objDTSubMenu = objPrjMenuEx.GetTableExWithRoleId(strCondition2.ToString(), "OrderNum", RoleId, this.ddlPrj.SelectedValue);

            //			string strPrjId = ConfigurationSettings.AppSettings[conQxProjects.QxPrjId];

            TreeNode tnRoot, tnUpMenuItem, tnSubMenuItem, tnLeafMenuItem;

            tvQxRoleMenus4Sel.Nodes.Clear();
            tnRoot = new TreeNode();
            tnRoot.Value = "root,root";
            tnRoot.Text = "角色菜单: ";
            //			tnRoot.CheckBox=true;
            tvQxRoleMenus4Sel.Nodes.Add(tnRoot);

            foreach (clsvQxRoleMenusEN objPrjMenu_Up in arrRoleMenuObjList)
            {
                if (objPrjMenu_Up.UpMenuId != "00000000") continue;
                strMenuId = objPrjMenu_Up.MenuId;   //获取主菜单项ID
                                                    //                strUpMenuName = objPrjMenu_Up.MenuName; //获取主菜单项NAME

                strUpMenuName = string.Format("{0}{1}{2}{3}({4})",
                     objPrjMenu_Up.MenuName,
                     objPrjMenu_Up.MenuId,
                      (objPrjMenu_Up.IsLeafNode ? "(叶子)" : ""),
                      (objPrjMenu_Up.InUse ? "" : "(未用)"),
                      objPrjMenu_Up.OrderNum); //获取主菜单项NAME


                strUpImgFile = objPrjMenu_Up.ImgFile;

                tnUpMenuItem = new TreeNode();
                tnUpMenuItem.Value = "UpMenu," + strMenuId;	//分类码

                tnUpMenuItem.Text = strUpMenuName;	//分类名称
                tnUpMenuItem.ShowCheckBox = true;
                //if (objPrjMenu_Up.RoleMenuId.Length == 0)
                //{

                //}
                //else
                //{
                //    tnUpMenuItem.Checked = true;
                //}



                tnRoot.ChildNodes.Add(tnUpMenuItem);

                foreach (clsvQxRoleMenusEN objRoleMenu_Sub in arrRoleMenuObjList)
                {
                    strUpMenuId = objRoleMenu_Sub.UpMenuId;

                    if (strMenuId == strUpMenuId)
                    {
                        strSubMenuId = objRoleMenu_Sub.MenuId;	//获取主菜单项ID
                        strSubMenuName = objRoleMenu_Sub.MenuName; //获取主菜单项NAME
                        strSubMenuName = string.Format("{0}{1}{2}{3}",
                  objRoleMenu_Sub.MenuName,
                  objRoleMenu_Sub.MenuId,
                   (objRoleMenu_Sub.IsLeafNode ? "(叶子)" : ""),
                   (objRoleMenu_Sub.InUse ? "" : "(未用)")); //获取主菜单项NAME

                        strSubImgFile = objRoleMenu_Sub.ImgFile;
                        strLinkFile = objRoleMenu_Sub.LinkFile;

                        tnSubMenuItem = new TreeNode();
                        tnSubMenuItem.Value = "SubMenu," + strSubMenuId; ;

                        tnSubMenuItem.Text = strSubMenuName;
                        tnSubMenuItem.ShowCheckBox = true;
                        //if (SubMenuRow["RoleMenuId"].ToString().Length == 0)
                        //{

                        //}
                        //else
                        //{
                        //    tnSubMenuItem.Checked = true;
                        //}
                        tnUpMenuItem.ChildNodes.Add(tnSubMenuItem);
                        foreach (clsvQxRoleMenusEN objRoleMenu_Leaf in arrRoleMenuObjList)
                        {
                            strUpMenuId4Leaf = objRoleMenu_Leaf.UpMenuId;

                            if (strSubMenuId != strUpMenuId4Leaf) continue;
                            strLeafMenuId = objRoleMenu_Leaf.MenuId;	//获取主菜单项ID
                            strLeafMenuName = objRoleMenu_Leaf.MenuName; //获取主菜单项NAME
                            strLeafImgFile = objRoleMenu_Leaf.ImgFile;
                            //strLinkFile = objRoleMenu_Leaf.LinkFile"].ToString();

                            tnLeafMenuItem = new TreeNode();
                            tnLeafMenuItem.Value = "LeafNode," + strLeafMenuId; ;

                            tnLeafMenuItem.Text = strLeafMenuName;
                            tnLeafMenuItem.ShowCheckBox = true;
                            //if (objRoleMenu_Leaf.RoleMenuId"].ToString().Length == 0)
                            //{

                            //}
                            //else
                            //{
                            //    tnLeafMenuItem.Checked = true;
                            //}
                            tnSubMenuItem.ChildNodes.Add(tnLeafMenuItem);
                        }
                    }
                }
            }
            tvQxRoleMenus4Sel.Nodes[0].Expand();
            bool bolIsFirst = true;
            foreach (TreeNode tnTemp in tvQxRoleMenus4Sel.Nodes[0].ChildNodes)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    tnTemp.Expand();
                }
                else
                {
                    tnTemp.Collapse();
                }
            }
        }

        protected void btnSaveMenues_Click(object sender, System.EventArgs e)
        {
            //1 先做一次循环遍历,让子菜单打钩,但是根菜单没有打钩的根菜单都打好钩
            //2 检查有没有角色被选中
            //3 把所有打钩的菜单编号都放进一个ArryList
            //4 把ArryList中的菜单编号写进RoleMenues表中

            //foreach (TreeNode tnboot in tvQxPrjMenus.Nodes) //1 先做一次循环遍历,让子菜单打钩,但是根菜单没有打钩的根菜单都打好钩
            //{
            //    foreach (TreeNode tnUpMenuItem in tnboot.ChildNodes)
            //    {
            //        foreach (TreeNode tnSubMenuItem in tnUpMenuItem.ChildNodes)
            //        {
            //            if (tnSubMenuItem.Checked)
            //            {
            //                tnUpMenuItem.Checked = true;
            //                break;
            //            }
            //        }
            //    }
            //}

            string strRoleId = vsRoleId;
            string strMenuId;


            List<string> arrCheckedMenus = getCheckedMenusNode(); //3 把所有打钩的菜单编号都放进一个ArryList
            //获取库中原来的角色菜单
            clsQxRoleMenusBLEx objQxRoleMenusEx = new clsQxRoleMenusBLEx();
            StringBuilder sbCondition = new StringBuilder();

            if (ddlPrjMenuSet.SelectedIndex > 0)
            {
                string strPrjMenuSetId = ddlPrjMenuSet.SelectedValue;
                sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuId in (Select MenuId From QxPrjMenus where  MenuSetId='{1}') And RoleId = '{2}'",
                    this.ddlPrj.SelectedValue, strPrjMenuSetId, strRoleId);
            }
            else
            {
                sbCondition.AppendFormat("QxPrjId = '{0}'  And RoleId = '{1}' ", this.ddlPrj.SelectedValue, strRoleId);
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
            //getCheckedMenusName(tvQxPrjMenus.Nodes[0], arrLst);
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


        private List<string> getCheckedQxRoleMenusNode()
        {
            List<string> arrLst = new List<string>();
            getCheckedMenusName(tvQxRoleMenus4Sel.Nodes[0], arrLst);
            return arrLst;
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            string strRoleId;

            string strNodeType = wucTreeView_Role.CurrNodeType;
            if (strNodeType != "Roles")
            {
                Label1.Text = "请选择角色!";
                return;
            }
            else
            {
                strRoleId = wucTreeView_Role.NodeData.RoleId;
            }

            ShowMenuTreeWithRoleId(strRoleId);
        }

        protected void ddlPrj_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            //this.tvQxPrjMenus.Nodes.Clear();

            wucTreeView_Role.BindTv();

            //ShowMenuTree();

        }

        protected void wucTreeView_Menu_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strRoleId = e.KeyId;
            vsRoleId = strRoleId;
            string strTypeName = e.NodeType;
            wucTreeView_Menu.SelectNodeEx(strRoleId);

            new clsCommonSession().CurrRoleNodeId = strRoleId;
            vsRoleId = strRoleId;
            string strNodeType = e.NodeType;
            if (strNodeType != clsvQxRolesByMenuNumEN._CurrTabName)
            {
                Label1.Text = "请选择角色!";
                return;
            }
            //ShowMenuTree();
            ShowMenuTreeWithRoleId(strRoleId);

        }


        protected void wucTreeView_Role_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strRoleId = e.KeyId;
            vsRoleId = strRoleId;
            string strTypeName = e.NodeType;
            wucTreeView_Role.SelectNodeEx(strRoleId);

            new clsCommonSession().CurrRoleNodeId = strRoleId;
            vsRoleId = strRoleId;
            string strNodeType = e.NodeType;
            if (strNodeType != clsvQxRolesByMenuNumEN._CurrTabName)
            {
                Label1.Text = "请选择角色!";
                return;
            }
            //ShowMenuTree();
            ShowMenuTreeWithRoleId(strRoleId);

        }
        //protected void tvRoles_SelectedNodeChanged(object sender, EventArgs e)
        //{
        //    string strCurrNodeId = clsCommForWebForm.getNodeID_S(tvRoles.SelectedNode);
        //    new clsCommonSession().CurrRoleNodeId = strCurrNodeId;

        //    string strRoleId;
        //    TreeNode tnRole = tvRoles.SelectedNode;
        //    string strNodeType = clsCommForWebForm.getNodeType_S(tnRole);
        //    if (strNodeType != "Roles")
        //    {
        //        Label1.Text = "请选择角色!";
        //        return;
        //    }
        //    else
        //    {
        //        strRoleId = clsCommForWebForm.getNodeID_S(tnRole);
        //        vsRoleId = strRoleId;
        //    }
        //    ShowMenuTree();
        //    ShowMenuTreeWithRoleId(strRoleId);
        //}

        //protected void tvQxPrjMenus_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        //{
        //    //Label1.Text = "tvQxPrjMenus_TreeNodeCheckChanged";
        // //Label1.Text =   e.Node.Text;
        //}
        protected void ddlPrjMenuSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindTv_QxPrjMenuUp_Sub();
            string strRoleId;

            string strNodeType = wucTreeView_Role.CurrNodeType;
            if (strNodeType != clsvQxUserRolesByUserNumEN._CurrTabName)
            {
                Label1.Text = "请选择角色!";
                return;
            }
            else
            {
                strRoleId = wucTreeView_Role.NodeData.RoleId;
            }

            ShowMenuTreeWithRoleId(strRoleId);
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            //1、获取主菜单项
            if (ddlPrjMenuSet.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个合适的菜单集！");
                return;
            }
            BindTv_QxPrjMenuUp_Sub();
            string strRoleId;
            string strNodeType = wucTreeView_Role.CurrNodeType;
            if (strNodeType != "Roles")
            {
                Label1.Text = "请选择角色!";
                return;
            }
            else
            {
                strRoleId = wucTreeView_Role.NodeData.RoleId;
            }

            ShowMenuTreeWithRoleId(strRoleId);

        }

        protected void tvQxPrjMenus_SelectedNodeChanged(object sender, EventArgs e)
        {
            //string strCurrNodeId = clsCommForWebForm.getNodeID_S(tvQxPrjMenus.SelectedNode);

            //TreeNode tnSelectNode = tvQxPrjMenus.SelectedNode;
            //foreach (TreeNode tnTemp in tnSelectNode.Parent.ChildNodes)
            //{
            //    if (tnTemp == tnSelectNode)
            //    {
            //        tnTemp.Expand();
            //    }
            //    else
            //    {
            //        tnTemp.Collapse();
            //    }
            //}

        }

        protected void tvQxRoleMenus4Sel_SelectedNodeChanged(object sender, EventArgs e)
        {
            string strCurrNodeId = clsCommForWebForm.getNodeID_S(tvQxRoleMenus4Sel.SelectedNode);
            //new clsCommonSession().CurrNodeId = strCurrNodeId;
            TreeNode tnSelectNode = tvQxRoleMenus4Sel.SelectedNode;
            foreach (TreeNode tnTemp in tnSelectNode.Parent.ChildNodes)
            {
                if (tnTemp == tnSelectNode)
                {
                    tnTemp.Expand();
                }
                else
                {
                    tnTemp.Collapse();
                }
            }

        }

        protected void btnAddRoleMenu_Click(object sender, EventArgs e)
        {
            if (ddlPrjMenuSet.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个合适的菜单集！");
                return;
            }
            string strPrjMenuSetId = ddlPrjMenuSet.SelectedValue;
            //foreach (TreeNode tnboot in tvQxPrjMenus.Nodes) //1 先做一次循环遍历,让子菜单打钩,但是根菜单没有打钩的根菜单都打好钩
            //{
            //    foreach (TreeNode tnUpMenuItem in tnboot.ChildNodes)
            //    {
            //        foreach (TreeNode tnSubMenuItem in tnUpMenuItem.ChildNodes)
            //        {
            //            if (tnSubMenuItem.Checked)
            //            {
            //                tnUpMenuItem.Checked = true;
            //                break;
            //            }
            //        }
            //    }//foreach
            //}//foreach
            string strMenuId = wucTreeView_Menu.NodeData.MenuIdSub;
            List<string> arrRoleId = wucTreeView_Role.GetCheckedNodeKeyIdLst(); //3 把所有打钩的菜单编号都放进一个ArryList
            //获取库中原来的角色菜单
            clsQxRoleMenusBLEx objQxRoleMenusEx = new clsQxRoleMenusBLEx();
            StringBuilder sbCondition = new StringBuilder();

            if (ddlPrjMenuSet.SelectedIndex > 0)
            {

                sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuId in (Select MenuId From QxPrjMenus where  MenuSetId='{1}') And RoleId = '{2}'",
                    this.ddlPrj.SelectedValue, strPrjMenuSetId, vsRoleId);
            }


            //增加新的
            try
            {
                clsQxRoleMenusBLEx.RoleAddRoles4Menu(this.ddlPrj.SelectedValue, vsRoleId, arrRoleId, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            //foreach(string strMenuId in arrCheckedMenus)
            //{
            //    clsQxPrjMenusEN objPrjMenuEN = clsQxPrjMenusBL.GetQxPrjMenusObjByMenuId_Cache(strMenuId);
            //    if (objPrjMenuEN == null)
            //    {

            //        return;
            //    }
            //}
            //ShowMenuTree();
            ShowMenuTreeWithRoleId(vsRoleId);
            clsCommonJsFunc.Alert(this, "添加角色菜单成功!");

        }

        protected void btnDelQxRoleMenu_Click(object sender, EventArgs e)
        {
            if (ddlPrjMenuSet.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个合适的菜单集！");
                return;
            }
            string strPrjMenuSetId = ddlPrjMenuSet.SelectedValue;

            List<string> arrCheckedMenus = getCheckedQxRoleMenusNode(); //3 把所有打钩的菜单编号都放进一个ArryList
            //获取库中原来的角色菜单
            clsQxRoleMenusBLEx objQxRoleMenusEx = new clsQxRoleMenusBLEx();
            StringBuilder sbCondition = new StringBuilder();


            foreach (string strMenuId in arrCheckedMenus)
            {
                //删除
                clsQxRoleMenusBLEx.RoleDelMenu(this.ddlPrj.SelectedValue, vsRoleId, strMenuId);
            }

            //ShowMenuTree();
            ShowMenuTreeWithRoleId(vsRoleId);
            clsCommonJsFunc.Alert(this, "移动角色菜单成功!");

        }
        /// <summary>
        /// 根据传递参数和选择参数决定的课程Id
        /// 功能：如果选择参数不为空，就返回选择参数课程Id，
        ///       否则就返回传递参数课程Id
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

        protected void btnDelRoleMenu_Click(object sender, EventArgs e)
        {
            if (ddlPrjMenuSet.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个合适的菜单集！");
                return;
            }
            string strPrjMenuSetId = ddlPrjMenuSet.SelectedValue;

            List<string> arrCheckedMenus = getCheckedRoleMenusNode(); //3 把所有打钩的菜单编号都放进一个ArryList
                                                                      //获取库中原来的角色菜单

            StringBuilder sbCondition = new StringBuilder();


            foreach (string strMenuId in arrCheckedMenus)
            {
                //删除
                clsQxRoleMenusBLEx.RoleDelMenu(this.ddlPrj.SelectedValue, vsRoleId, strMenuId);
            }

            BindTv_QxPrjMenuUp_Sub();
            ShowMenuTreeWithRoleId(vsRoleId);
            clsCommonJsFunc.Alert(this, "移动角色菜单成功!");

        }

        private List<string> getCheckedRoleMenusNode()
        {
            List<string> arrLst = new List<string>();
            getCheckedMenusName(tvQxRoleMenus4Sel.Nodes[0], arrLst);
            return arrLst;
        }
    }
}
