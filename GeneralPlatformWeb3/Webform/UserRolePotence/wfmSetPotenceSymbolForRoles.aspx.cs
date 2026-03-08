using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
//using System.Configuration;
using GeneralPlatform;
using CommFunc4WebForm;
using com.taishsoft.common;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.web.treeview;
using GeneralPlatform.BusinessLogicEx;
using System.Collections.Generic;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmSetPotenceSymbolForRoles 的摘要说明。
    /// </summary>
    public partial class wfmSetPotenceSymbolForRoles : System.Web.UI.Page
    {

        private const string ViewId = "00010406";
        private string level;

        private void Page_Load(object sender, System.EventArgs e)
        {
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

            //获取当前用户的权限等级编号
            level = new MenuAndPotence().Get_PotenceLevel(ViewId);

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)
            {
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

                        this.ddlPrj.Enabled = false;

                        break;

                    case "4":

                        Response.Redirect("../error.aspx");

                        break;


                    default:
                        Response.Redirect("../error.aspx");
                        break;
                }

                this.Table2.Visible = false;
                clsQxProjectsBL.BindDdl_QxPrjIdCache(this.ddlPrj);
                this.ddlPrj.SelectedValue = getUserPrjId;
                //wucTreeView1.QxPrjId = getUserPrjId;
                //wucTreeView1.tmTreeModel = web.treeview.TreeModel.vQxUserRolesByPotenceNum;
                //wucTreeView1.BindTv();

                ShowPotences();//显示本工程中所的权限

                ShowUserTree("按角色显示全部用户");

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
            this.rblDispFashion.SelectedIndexChanged += new System.EventHandler(this.rblDispFashion_SelectedIndexChanged);
            this.ddlPrj.SelectedIndexChanged += new System.EventHandler(this.ddlPrj_SelectedIndexChanged);
            this.chkAutoDispUserGroupPotences.CheckedChanged += new System.EventHandler(this.chkAutoDispUserGroupPotences_CheckedChanged);
            this.btnSavePotences.Click += new System.EventHandler(this.btnSavePotences_Click);
            this.Load += new System.EventHandler(this.Page_Load);

        }
        #endregion



        protected void btnManPotences_Click(object sender, System.EventArgs e)
        {
            ShowPotences();
        }
        private void ShowPotences()
        {
            //string strPrjId = ConfigurationSettings.AppSettings[conQxProjects.QxPrjId];
            string strPrjId = this.ddlPrj.SelectedValue;
            
            clsQxPotenceTypeEN objPotenceType;
            clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol;

            List<clsvQxPotenceTypeEN> arrQxPotenceTypeObjLst = null;
            List<clsvQxPrjPotenceEN> arrQxPrjPotenceObjLst = null;
            List<clsQxRelaOfPotenceAndSymbolEN> arrQxRelaOfPotenceAndSymbolObjLst = null;

            
            StringBuilder strCondition;

            

            TreeNode tnRoot, tnPotenceFL, tnPotence, tnPotenceSymbol;

            tvPotences.Nodes.Clear();
            tnRoot = new TreeNode();
            tnRoot.Value = "root,root";
            tnRoot.Text = "用户的权限: ";
            tnRoot.ShowCheckBox = false;
            tvPotences.Nodes.Add(tnRoot);

            objPotenceType = new clsQxPotenceTypeEN();
            strCondition = new StringBuilder();
            strCondition.AppendFormat("{1} = '{0}' and {2}='1'",
                strPrjId, conQxPotenceType.QxPrjId, conQxPotenceType.IsVisible);
            arrQxPotenceTypeObjLst = clsvQxPotenceTypeBL.GetObjLst(strCondition.ToString());
            arrQxPrjPotenceObjLst = clsvQxPrjPotenceBL.GetObjLst(strCondition.ToString());
            strCondition = new StringBuilder();
            strCondition.AppendFormat("{1} = '{0}' ",
                strPrjId, conQxPotenceType.QxPrjId);

            arrQxRelaOfPotenceAndSymbolObjLst = clsQxRelaOfPotenceAndSymbolBL.GetObjLst(strCondition.ToString());
            foreach (clsvQxPotenceTypeEN objvQxPotenceType in arrQxPotenceTypeObjLst)
            {

                tnPotenceFL = new TreeNode();
                tnPotenceFL.Value = "PotenceFL," + objvQxPotenceType.PotenceTypeId;	//分类码
                tnPotenceFL.Text = objvQxPotenceType.PotenceTypeName;    //分类名称
                tnPotenceFL.ShowCheckBox = false;
                tnRoot.ChildNodes.Add(tnPotenceFL);


                foreach (clsvQxPrjPotenceEN objvQxPrjPotence in arrQxPrjPotenceObjLst)
                {
                    if (objvQxPrjPotence.PotenceTypeId != objvQxPotenceType.PotenceTypeId) continue;
                    tnPotence = new TreeNode();
                    tnPotence.Value = "PotenceName," + objvQxPrjPotence.PotenceId;
                    tnPotence.Text = objvQxPrjPotence.PotenceName;
                    tnPotence.ShowCheckBox = false;
                    tnPotenceFL.ChildNodes.Add(tnPotence);

                    objRelaOfPotenceAndSymbol = new clsQxRelaOfPotenceAndSymbolEN();
                    
                    foreach (clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbol in arrQxRelaOfPotenceAndSymbolObjLst)
                    {
                        if (objQxRelaOfPotenceAndSymbol.PotenceId != objvQxPrjPotence.PotenceId) continue;
                        tnPotenceSymbol = new TreeNode();
                        tnPotenceSymbol.Value = "Symbol," + objQxRelaOfPotenceAndSymbol.RelaMid;

                        tnPotenceSymbol.Text = objQxRelaOfPotenceAndSymbol.SymbolName;
                        tnPotenceSymbol.ShowCheckBox = true;
                        tnPotence.ChildNodes.Add(tnPotenceSymbol);
                    }
                    if (tnPotence.ChildNodes.Count == 0)
                    {
                        tnPotenceFL.ChildNodes.Remove(tnPotence);
                    }
                }
                if (tnPotenceFL.ChildNodes.Count == 0)
                {
                    tnRoot.ChildNodes.Remove(tnPotenceFL);
                }
            }
        }

        private void CheckSubNode(TreeNode tnTemp, bool bolIsChecked)
        {
            tnTemp.Checked = bolIsChecked;
            if (tnTemp.ChildNodes.Count > 0)
            {
                foreach (TreeNode tn in tnTemp.ChildNodes)
                {
                    CheckSubNode(tn, bolIsChecked);
                }
            }
        }
        private void getCheckedNodeName(TreeNode tnTemp, ArrayList arrLst)
        {
            if (tnTemp.Checked == true && clsCommForWebForm.getNodeType_S(tnTemp) == "Symbol")
            {
                arrLst.Add(clsCommForWebForm.getNodeID_S(tnTemp));
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                getCheckedNodeName(tn, arrLst);
            }
        }
        //private void getCheckedUserGroupNode(ArrayList arrLst)
        //{
        //          string strNodeType = clsCommForWebForm.getNodeType_S(tnTemp);
        //          if (tnTemp.Checked == true && (strNodeType == "User" || strNodeType == "Group"))
        //	{
        //		arrLst.Add(tnTemp);
        //	}
        //	else
        //	{
        //		foreach(TreeNode tn in tnTemp.ChildNodes)
        //		{
        //			getCheckedUserGroupNode(tn, arrLst);
        //		}
        //	}
        //}

        /// <summary>
        /// 功能：获取已选择的权限结点名称
        /// </summary>
        private ArrayList getCheckedPotencesNode()
        {
            ArrayList arrLst = new ArrayList();
            getCheckedNodeName(tvPotences.Nodes[0], arrLst);
            return arrLst;
        }
        ///// <summary>
        ///// 功能：获取已选择的用户、组结点
        ///// </summary>
        //private ArrayList getCheckedUserGroupNode()
        //{
        //	ArrayList arrLst = new ArrayList();
        //	getCheckedUserGroupNode(tvUsers.Nodes[0], arrLst);
        //	return arrLst;
        //}

        protected void btnDispUserTree_Click(object sender, System.EventArgs e)
        {
            //显示用户树
            ShowUserTree("显示全部用户");
        }
        /// <summary>
        /// 显示用户树
        /// </summary>
        private void ShowUserTree(string strDispFashion)
        {
            //			string strPrjId = ConfigurationSettings.AppSettings[conQxProjects.QxPrjId];
            string strPrjId = this.ddlPrj.SelectedValue;

            clsQxUsersEN objUsersEN = null;
            clsQxUserGroupsEN objUserGroups = null;
            clsQxRolesEN objUserRoles = null;
            clsQxDepartmentInfoEN objDepartments = null;
            //			clsQxUserGroupRelationEN objUserGroupRelation = null;
            DataTable objDtUsers, objDtDepartments, objDtUserGroups, objDtUserRoles;
            DataRow objRow, objRow2;
            StringBuilder strSQL = new StringBuilder();
            StringBuilder strCondition = null;
            int iRow, jRow;
            //tvUsers.Nodes.Clear();
            TreeNode tnRoot, tnGroup, tnUser, tnDepartment, tnRole;
            //			System.Data.DataTable objDT;
            switch (strDispFashion)
            {
                case "显示全部用户":
                    wucTreeView1.QxPrjId = getUserPrjId;
                    wucTreeView1.tmTreeModel = web.treeview.TreeModel.QxUsers;
                    wucTreeView1.BindTv();
                    break;
                case "按组显示全部用户":
                    wucTreeView1.QxPrjId = getUserPrjId;
                    wucTreeView1.tmTreeModel = web.treeview.TreeModel.QxUserGroups_QxUsers;
                    wucTreeView1.BindTv();

                    break;

                case "按角色显示全部用户":

                    wucTreeView1.QxPrjId = getUserPrjId;
                    wucTreeView1.tmTreeModel = web.treeview.TreeModel.vQxUserRolesByPotenceNum;
                    wucTreeView1.BindTv();
                    break;

                case "按部门显示全部用户":

                    wucTreeView1.QxPrjId = getUserPrjId;
                    wucTreeView1.tmTreeModel = web.treeview.TreeModel.QxDepartmentInfo_QxUsers;
                    wucTreeView1.BindTv();

                    break;
                default:
                    break;
            }
        }

        private void rblDispFashion_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (rblDispFashion.Items[0].Selected == true)       //显示全部用户
            {
                ShowUserTree("显示全部用户");
            }
            else if (rblDispFashion.Items[1].Selected == true)      //按组显示全部用户
            {
                ShowUserTree("按组显示全部用户");
            }
            else if (rblDispFashion.Items[2].Selected == true)      //按部门显示全部用户
            {
                ShowUserTree("按部门显示全部用户");
            }
            else if (rblDispFashion.Items[3].Selected == true)      //按角色显示全部用户
            {
                ShowUserTree("按角色显示全部用户");
            }
        }

        private void ShowPotenceForSingleUser(string strUserId)
        {
            clsQxUserGroupPotenceEN objUserGroupPotence = new clsQxUserGroupPotenceEN();
            DataTable objDT = clsQxUserGroupPotenceBL.GetDataTable_QxUserGroupPotence("UserId = '" + strUserId + "'");
            ArrayList arrLst = new ArrayList();
            string strPotence;
            for (int iRow = 0; iRow < objDT.Rows.Count; iRow++)
            {
                strPotence = objDT.Rows[iRow]["PotenceId"].ToString();
                arrLst.Add(strPotence);
            }
            SetCheckedForUserGroupPotence(tvPotences.Nodes[0], arrLst);
        }
        private void ShowPotenceForSingleGroup(string strGroupId)
        {
            clsQxUserGroupPotenceEN objUserGroupPotence = new clsQxUserGroupPotenceEN();
            DataTable objDT = clsQxUserGroupPotenceBL.GetDataTable_QxUserGroupPotence("GroupId = '" + strGroupId + "'");
            ArrayList arrLst = new ArrayList();
            string strPotence;
            for (int iRow = 0; iRow < objDT.Rows.Count; iRow++)
            {
                strPotence = objDT.Rows[iRow]["PotenceId"].ToString();
                arrLst.Add(strPotence);
            }
            SetCheckedForUserGroupPotence(tvPotences.Nodes[0], arrLst);

        }
        private void ShowPotenceForSingleRole(string strRoleId)  //20050630修改
        {
            clsQxUserGroupPotenceEN objUserGroupPotence = new clsQxUserGroupPotenceEN();
            DataTable objDT = clsQxUserGroupPotenceBL.GetDataTable_QxUserGroupPotence("RoleId = '" + strRoleId + "'");
            ArrayList arrLst = new ArrayList();
            string strPotence;
            for (int iRow = 0; iRow < objDT.Rows.Count; iRow++)
            {
                strPotence = objDT.Rows[iRow]["RelaMid"].ToString();
                arrLst.Add(strPotence);
            }

            SetCheckedForUserGroupPotence(tvPotences.Nodes[0], arrLst);

        }
        private void SetCheckedForUserGroupPotence(TreeNode tnTemp, ArrayList arrLst)
        {
            string strNodeType = clsCommForWebForm.getNodeType_S(tnTemp);
            string strNodeID = clsCommForWebForm.getNodeID_S(tnTemp);

            if (strNodeType == "Symbol")
            {
                if (arrLst.Contains(strNodeID))
                {
                    tnTemp.Checked = true;
                }
                else
                {
                    tnTemp.Checked = false;
                }
            }
            else
            {
                foreach (TreeNode tn in tnTemp.ChildNodes)
                {
                    SetCheckedForUserGroupPotence(tn, arrLst);
                }
            }
        }

        protected void btnSavePotences_Click(object sender, System.EventArgs e)
        {
            string strUserId, strGroupId, strRoleId;
            string strPotenceId, strRelaMidOfPotenceAndSymbol;
            //1、获取被选的用户或组
            //TreeNode tnSelectedNode = tvUsers.SelectedNode;
            //if (tnSelectedNode == null)
            //{
            //    clsCommonJsFunc.Alert(this, "请选择单用户/单组");
            //    return;
            //}
            string strNodeType = wucTreeView1.CurrNodeType;

            //TreeNode tnUserGroup = tvUsers.SelectedNode;
            if (strNodeType != clsQxUsersEN._CurrTabName
                && strNodeType != "Group"
                && strNodeType != clsvQxUserRolesByPotenceNumEN._CurrTabName)
            {
                lblMsg.Text = "请选择单用户/单组";
                return;
            }

            ArrayList arrCheckedPotence = getCheckedPotencesNode();

            //			string strPrjId = ConfigurationSettings.AppSettings[conQxProjects.QxPrjId];
            string strPrjId = this.ddlPrj.SelectedValue;


            switch (strNodeType)
            {
                case clsQxUsersEN._CurrTabName: //如果选择的节点为用户
                    {
                        string strKeyId = wucTreeView1.NodeData.UserId;
                        strUserId = strKeyId;
                        //获取该用户组的所有权限
                        string strCondition = string.Format("{0} = '{1}' and UserId = '{2}'",
                            conQxUserGroupPotence.QxPrjId, getUserPrjId, strUserId);
                        DataTable dtUserPotences = clsQxUserGroupPotenceBL.GetDataTable_QxUserGroupPotence(strCondition);
                        ArrayList arrUserOldPotence = new ArrayList();

                        foreach (DataRow objRow in dtUserPotences.Rows)
                        {
                            strPotenceId = objRow["UserId"].ToString();
                            arrUserOldPotence.Add(strPotenceId);
                        }
                        ArrayList arrNewPotence = clsAggregate.TwoAggrDiff(arrCheckedPotence, arrUserOldPotence);
                        ArrayList arrNeedDelPotence = clsAggregate.TwoAggrDiff(arrUserOldPotence, arrCheckedPotence);
                        clsQxUserGroupPotenceBLEx.UserDelSomePotence(strPrjId, strUserId, arrNeedDelPotence);
                        clsQxUserGroupPotenceBLEx.UserAddPotences(strPrjId, strUserId, arrNewPotence);
                        lblMsg.Text = "请看右边的<" + clsQxUsersBL.GetUserNameByUserIdCache(strUserId) + ">用户权限!";
                        string strMsg = string.Format("删除了：{0}个权限，新添加了：{1}个权限。",
                            arrNewPotence.Count, arrNeedDelPotence.Count);
                        clsCommonJsFunc.Alert(this, strMsg);
                    }
                    break;
                case "Group": //如果选择的节点为用户
                    {
                        string strKeyId = wucTreeView1.NodeData.GroupId;
                        strGroupId = strKeyId;

                        //获取该用户组的所有权限
                        string strCondition = string.Format("{0} = '{1}' and GroupId = '{2}'",
                            conQxUserGroupPotence.QxPrjId, getUserPrjId, strGroupId);
                        DataTable dtGroupPotences = clsQxUserGroupPotenceBL.GetDataTable_QxUserGroupPotence(strCondition);
                        ArrayList arrGroupOldPotence = new ArrayList();

                        foreach (DataRow objRow in dtGroupPotences.Rows)
                        {
                            strPotenceId = objRow["PotenceId"].ToString();
                            arrGroupOldPotence.Add(strPotenceId);
                        }
                        ArrayList arrNewPotence = clsAggregate.TwoAggrDiff(arrCheckedPotence, arrGroupOldPotence);
                        ArrayList arrNeedDelPotence = clsAggregate.TwoAggrDiff(arrGroupOldPotence, arrCheckedPotence);
                        clsQxUserGroupPotenceBLEx.GroupDelSomePotence(strPrjId, strGroupId, arrNeedDelPotence);
                        clsQxUserGroupPotenceBLEx.GroupAddPotences(strPrjId, strGroupId, arrNewPotence);
                        lblMsg.Text = "请看右边的<" + clsQxUserGroupsBL.GetGroupNameByGroupIdCache(strGroupId) + ">组权限!";
                        string strMsg = string.Format("删除了：{0}个权限，新添加了：{1}个权限。",
                            arrNewPotence.Count, arrNeedDelPotence.Count);
                        clsCommonJsFunc.Alert(this, strMsg);
                    }
                    break;
                case clsvQxUserRolesByPotenceNumEN._CurrTabName: //如果选择的节点为用户
                    {
                        string strKeyId = wucTreeView1.NodeData.RoleId;
                        if (vsTreeNodeType == clsvQxUserRolesByPotenceNumEN._CurrTabName && string.IsNullOrEmpty(strKeyId) == true)
                        {
                            strKeyId = vsKeyId;
                        }
                        strRoleId = strKeyId;
                        //获取该角色的所有权限
                        string strCondition = string.Format("{0} = '{1}' and RoleId = '{2}'",
                            conQxUserGroupPotence.QxPrjId, getUserPrjId, strRoleId);
                        DataTable dtRolePotences = clsQxUserGroupPotenceBL.GetDataTable_QxUserGroupPotence(strCondition);
                        ArrayList arrRoleOldPotence = new ArrayList();

                        foreach (DataRow objRow in dtRolePotences.Rows)
                        {
                            strRelaMidOfPotenceAndSymbol = objRow["RelaMid"].ToString();
                            arrRoleOldPotence.Add(strRelaMidOfPotenceAndSymbol);
                        }
                        ArrayList arrNewPotence = clsAggregate.TwoAggrDiff(arrCheckedPotence, arrRoleOldPotence);
                        ArrayList arrNeedDelPotence = clsAggregate.TwoAggrDiff(arrRoleOldPotence, arrCheckedPotence);
                        clsQxUserGroupPotenceBLEx.RoleDelSomePotenceSymbol(strPrjId, strRoleId, arrNeedDelPotence);
                        clsQxUserGroupPotenceBLEx.RoleAddPotenceSymbol(strPrjId, strRoleId, arrNewPotence);
                        clsQxRoleMenusBLEx.EditQxRoleMenusByPotence(strPrjId, strRoleId, clsCommonSession.UserId);
                        lblMsg.Text = "请看右边的<" + clsQxRolesBL.GetRoleNameByRoleIdCache(strRoleId) + ">组权限!";
                        string strMsg = string.Format("删除了：{0}个权限，新添加了：{1}个权限。",
                            arrNeedDelPotence.Count, arrNewPotence.Count);
                        clsCommonJsFunc.Alert(this, strMsg);
                    }
                    break;

            }
        }

        protected void lbBrowUserGroupPotence_Click(object sender, System.EventArgs e)
        {
            //TreeNode tnUserGroup = tvUsers.SelectedNode;
            //ShowUserGroupPotences(tnUserGroup);

        }
        private void ShowUserGroupPotences(string strKeyId, string strNodeType, string strNodeText)
        {
            //string strNodeType = clsCommForWebForm.getNodeType_S(tnUserGroup);
            //string strNodeID = clsCommForWebForm.getNodeID_S(tnUserGroup);

            if (strNodeType != clsQxUsersEN._CurrTabName && strNodeType != "Group" && strNodeType != clsvQxUserRolesByPotenceNumEN._CurrTabName)
            {
                lblMsg.Text = "请选择单用户/单组";
                return;
            }

            if (strNodeType == clsQxUsersEN._CurrTabName) //如果选择的节点为用户
            {
                ShowPotenceForSingleUser(strKeyId);
                lblMsg.Text = "请看右边的<" + strNodeText + ">用户权限!";
                return;
            }
            if (strNodeType == "Group") //如果选择的节点为用户
            {
                ShowPotenceForSingleGroup(strKeyId);
                lblMsg.Text = "请看右边的<" + strNodeText + ">组权限!";
                return;
            }

            if (strNodeType == clsvQxUserRolesByPotenceNumEN._CurrTabName) //如果选择的节点为用户
            {
                ShowPotenceForSingleRole(strKeyId);   //20050630修改
                lblMsg.Text = "请看右边的<" + strNodeText + ">角色权限!";
                return;
            }

        }

        private void chkAutoDispUserGroupPotences_CheckedChanged(object sender, System.EventArgs e)
        {
            //if (chkAutoDispUserGroupPotences.Checked == true)
            //{
            //    //tvUsers.AutoPostBack = true;
            //    tvUsers.SelectedNodeChanged += new EventHandler(tvUsers_SelectedNodeChanged);
            //}
            //else
            //{
            //    //tvUsers.AutoPostBack = false;
            //    tvUsers.SelectedNodeChanged -= new EventHandler(tvUsers_SelectedNodeChanged);
            //}
        }

        protected void ddlPrj_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ShowPotences();//显示本工程中所的权限
            ShowUserTree("按角色显示全部用户");
        }
        protected void tvPotences_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {
            TreeNode tnClass = e.Node;
            bool bolIsChecked;
            bolIsChecked = tnClass.Checked;
            CheckSubNode(tnClass, bolIsChecked);

        }
        protected void tvUsers_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {
            TreeNode tnClass = e.Node;
            bool bolIsChecked;
            bolIsChecked = tnClass.Checked;
            CheckSubNode(tnClass, bolIsChecked);
        }

        protected void wucTreeView1_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strNodeText = e.NodeText;
            vsKeyId = strKeyId;
            vsTreeNodeType = strTypeName;
            wucTreeView1.SelectNodeEx(strKeyId);
            ShowUserGroupPotences(strKeyId, strTypeName, strNodeText);
            //vsDepartmentId = strRoleId;


            //throw new NotImplementedException();
        }
        protected void tvUsers_SelectedNodeChanged(object sender, EventArgs e)
        {
            //TreeNode tnUserGroup = tvUsers.SelectedNode;
            //ShowUserGroupPotences(tnUserGroup);		
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
        protected string vsTreeNodeType
        {
            get
            {
                string sTreeNodeType;
                sTreeNodeType = (string)ViewState["TreeNodeType"];
                if (sTreeNodeType == null)
                {
                    sTreeNodeType = "";
                }
                return sTreeNodeType;
            }
            set
            {
                string sTreeNodeType = value;
                ViewState.Add("TreeNodeType", sTreeNodeType);
            }
        }


        protected string vsKeyId
        {
            get
            {
                string sKeyId;
                sKeyId = (string)ViewState["KeyId"];
                if (sKeyId == null)
                {
                    sKeyId = "";
                }
                return sKeyId;
            }
            set
            {
                string sKeyId = value;
                ViewState.Add("KeyId", sKeyId);
            }
        }
    }
}
