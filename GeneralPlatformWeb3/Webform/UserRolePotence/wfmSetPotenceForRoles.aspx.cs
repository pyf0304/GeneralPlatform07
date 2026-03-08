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
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmSetPotenceSymbolForRoles 的摘要说明。
	/// </summary>
	public partial class wfmSetPotenceForRoles : System.Web.UI.Page
	{

		private const string ViewId="00010406";
		private string level;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			//获取当前用户的权限等级编号
			level=new MenuAndPotence().Get_PotenceLevel(ViewId);

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

						this.ddlPrj.Enabled =false;
						
						break;
					case "3":

						this.ddlPrj.Enabled =false;

						break;

					case "4":

						Response.Redirect("../error.aspx");

						break;


					default:
						Response.Redirect("../error.aspx");
						break;
				}

				this.Table2.Visible=false;
                clsQxProjectsBL.BindDdl_QxPrjIdCache(this.ddlPrj);
				this.ddlPrj.SelectedValue = getUserPrjId;
				
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

			clsQxPrjPotenceEN objPrjPotence ;
			clsQxPotenceTypeEN objPotenceType ;

			DataTable objDtPrjPotence, objDtPotenceType ;

			DataRow objRow, objRow2 ,objRow3;

			StringBuilder strCondition ;

			int iRow, jRow ,kRow;
			
			
			TreeNode tnRoot, tnPotenceFL, tnPotence;

			tvPotences.Nodes.Clear();
			tnRoot=new TreeNode();
            tnRoot.Value = "root,root";
			tnRoot.Text = "用户的权限: ";
			tnRoot.ShowCheckBox=false;
			tvPotences.Nodes.Add(tnRoot);

			objPotenceType = new clsQxPotenceTypeEN();
			strCondition = new StringBuilder();
			strCondition.AppendFormat("{1} = '{0}'", strPrjId, conQxPotenceType.QxPrjId);
			objDtPotenceType= clsQxPotenceTypeBL.GetDataTable_QxPotenceType(strCondition.ToString());

			for (iRow=0 ; iRow<objDtPotenceType.Rows.Count; iRow++)
			{
				objRow = objDtPotenceType.Rows[iRow];
				tnPotenceFL=new TreeNode();
                tnPotenceFL.Value = "PotenceFL," + objRow["PotenceTypeId"].ToString();	//分类码
                tnPotenceFL.Text = objRow["PotenceTypeName"].ToString();	//分类名称
				tnPotenceFL.ShowCheckBox=false;
				tnRoot.ChildNodes.Add(tnPotenceFL);
				
				objPrjPotence = new clsQxPrjPotenceEN();
				strCondition = new StringBuilder();
				strCondition.AppendFormat("{2} = '{0}' and PotenceTypeId = '{1}'", 
                    strPrjId,
                   clsCommForWebForm.getNodeID_S(tnPotenceFL),
                   conQxPrjPotence.QxPrjId);
				objDtPrjPotence= clsQxPrjPotenceBL.GetDataTable_QxPrjPotence(strCondition.ToString());
				
				
				if(objDtPrjPotence.Rows.Count==0)              //20050630修改
				{
                    //tnPotenceFL.Remove();
				}
				else
				{			
					for (jRow=0 ; jRow<objDtPrjPotence.Rows.Count; jRow++)
					{
						objRow2 = objDtPrjPotence.Rows[jRow];
						tnPotence=new TreeNode();
                        tnPotence.Value = "PotenceName," + objRow2["PotenceId"].ToString();
						tnPotence.Text=objRow2["PotenceName"].ToString();
						tnPotence.ShowCheckBox=true;
						tnPotenceFL.ChildNodes.Add(tnPotence);
					}
				}
				
			}					
		}

		private void CheckSubNode(TreeNode tnTemp, bool bolIsChecked)
		{
			tnTemp.Checked = bolIsChecked;
			if (tnTemp.ChildNodes.Count>0)
			{
				foreach(TreeNode tn in tnTemp.ChildNodes)
				{
					CheckSubNode(tn, bolIsChecked);
				}
			}
		}
		private void getCheckedNodeName(TreeNode tnTemp, ArrayList arrLst)
		{
            if (tnTemp.Checked == true && clsCommForWebForm.getNodeType_S(tnTemp) == "PotenceName")
			{
				arrLst.Add(clsCommForWebForm.getNodeID_S(tnTemp));
			}
			foreach(TreeNode tn in tnTemp.ChildNodes)
			{
				getCheckedNodeName(tn, arrLst);
			}
		}
		private void getCheckedUserGroupNode(TreeNode tnTemp, ArrayList arrLst)
		{
            string strNodeType = clsCommForWebForm.getNodeType_S(tnTemp);
            if (tnTemp.Checked == true && (strNodeType == "User" || strNodeType == "Group"))
			{
				arrLst.Add(tnTemp);
			}
			else
			{
				foreach(TreeNode tn in tnTemp.ChildNodes)
				{
					getCheckedUserGroupNode(tn, arrLst);
				}
			}
		}
	
		/// <summary>
		/// 功能：获取已选择的权限结点名称
		/// </summary>
		private ArrayList getCheckedPotencesNode()
		{
			ArrayList arrLst = new ArrayList();
			getCheckedNodeName(tvPotences.Nodes[0], arrLst);
			return arrLst;
		}
		/// <summary>
		/// 功能：获取已选择的用户、组结点
		/// </summary>
		private ArrayList getCheckedUserGroupNode()
		{
			ArrayList arrLst = new ArrayList();
			getCheckedUserGroupNode(tvUsers.Nodes[0], arrLst);
			return arrLst;
		}

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
			tvUsers.Nodes.Clear();
			TreeNode tnRoot, tnGroup, tnUser, tnDepartment, tnRole;
			//			System.Data.DataTable objDT;
			switch (strDispFashion)
			{
				case "显示全部用户":
				{
					objUsersEN = new clsQxUsersEN();
					objDtUsers= clsQxUsersBL.GetDataTable_QxUsers("1=1");
					tnRoot=new TreeNode();
                    tnRoot.Value = "root,root";
					tnRoot.Text = "所有用户: ";
					//					tnRoot.CheckBox=true;
					tvUsers.Nodes.Add(tnRoot);
					for (iRow=0 ; iRow<objDtUsers.Rows.Count; iRow++)
					{
						objRow = objDtUsers.Rows[iRow];
						tnUser=new TreeNode();
                        tnUser.Value = "User," + objRow["UserId"].ToString();
						
						tnUser.Text=objRow["UserName"].ToString();
						//						tnUser.CheckBox=true;
						tnRoot.ChildNodes.Add(tnUser);
					}
					break;
				}
				case "按组显示全部用户":
				{
					tnRoot=new TreeNode();
					tnRoot.Value="root,root";
					tnRoot.Text = "按组显示全部用户: ";
					//					tnRoot.CheckBox=true;
					tvUsers.Nodes.Add(tnRoot);
					objUserGroups = new clsQxUserGroupsEN();
					strCondition = new StringBuilder();
					strCondition.AppendFormat("{1} = '{0}'", strPrjId, conQxUserGroups.QxPrjId);
                    objDtUserGroups = clsQxUserGroupsBL.GetDataTable_QxUserGroups(strCondition.ToString());
					for (iRow=0 ; iRow<objDtUserGroups.Rows.Count; iRow++)
					{
						objRow = objDtUserGroups.Rows[iRow];
						tnGroup=new TreeNode();
                        tnGroup.Value = "Group," + objRow["GroupId"].ToString();
                        tnGroup.Text = objRow["ZM"].ToString();
						//						tnGroup.CheckBox=true;
						tnRoot.ChildNodes.Add(tnGroup);
						strSQL = new StringBuilder();
						strSQL.Append("SELECT dbo.UserGroupRelation.UserId, dbo.UserGroupRelation.GroupId, ");
						strSQL.Append(" dbo.Users.XM ");
						strSQL.Append(" FROM dbo.UserGroupRelation LEFT OUTER JOIN ");
						strSQL.Append(" dbo.Users ON dbo.UserGroupRelation.UserId = dbo.Users.UserId ");
						strSQL.AppendFormat(" where GroupId='{0}' ", clsCommForWebForm.getNodeID_S(tnGroup));
						objDtUsers= clsQxUserGroupRelationBL.GetDataTable_QxUserGroupRelation(strSQL.ToString());
						for (jRow=0 ; jRow<objDtUsers.Rows.Count; jRow++)
						{
							objRow2 = objDtUsers.Rows[jRow];
							tnUser=new TreeNode();
                            tnUser.Value = "User," + objRow2["UserId"].ToString();
							
							tnUser.Text=objRow2["XM"].ToString();
							//							tnUser.CheckBox=true;
							tnGroup.ChildNodes.Add(tnUser);
						}
					}					
					break;
				}
				case "按角色显示全部用户":
				{
					tnRoot=new TreeNode();
					tnRoot.Value="root,root";
					tnRoot.Text = "按角色显示全部用户: ";
					//					tnRoot.CheckBox=true;
					tvUsers.Nodes.Add(tnRoot);
					objUserRoles = new clsQxRolesEN();
					strCondition = new StringBuilder();
					strCondition.AppendFormat("{1} = '{0}'", strPrjId, conQxRoles.QxPrjId);
                    objDtUserRoles = clsQxRolesBL.GetDataTable_QxRoles(strCondition.ToString());
					for (iRow=0 ; iRow<objDtUserRoles.Rows.Count; iRow++)
					{
						objRow = objDtUserRoles.Rows[iRow];
						tnRole=new TreeNode();
                        tnRole.Value = "RoleName," + objRow["RoleId"].ToString();
						
						tnRole.Text=objRow["RoleName"].ToString();
						//						tnRole.CheckBox=true;
						tnRoot.ChildNodes.Add(tnRole);
						strSQL = new StringBuilder();
						//						strSQL.Append("SELECT dbo.UserGroupRelation.UserId, dbo.UserGroupRelation.GroupId, ");
						//						strSQL.Append(" dbo.Users.XM ");
						//						strSQL.Append(" FROM dbo.UserGroupRelation LEFT OUTER JOIN ");
						//						strSQL.Append(" dbo.Users ON dbo.UserGroupRelation.UserId = dbo.Users.UserId ");
						//						strSQL.AppendFormat(" where GroupId='{0}' ", tnRole.ID);
						//						objDtUsers= clsQxUserGroupRelationBL.GetDataTable(strSQL.ToString());
						//						for (jRow=0 ; jRow<objDtUsers.Rows.Count; jRow++)
						//						{
						//							objRow2 = objDtUsers.Rows[jRow];
						//							tnUser=new TreeNode();
						//							tnUser.Type = "User";
						//							tnUser.ID=objRow2["UserId"].ToString();
						//							tnUser.Text=objRow2["XM"].ToString();
						//							//							tnUser.CheckBox=true;
						//							tnRole.Nodes.Add(tnUser);
						//						}
					}					
					break;
				}
				case "按部门显示全部用户":
				{
					objDepartments = new clsQxDepartmentInfoEN();
					objDtDepartments= clsQxDepartmentInfoBL.GetDataTable_QxDepartmentInfo("1=1");
					tnRoot=new TreeNode();
					tnRoot.Value = "root,root";
					tnRoot.Text = "按部门显示全部用户: ";
					//					tnRoot.CheckBox=true;
					tvUsers.Nodes.Add(tnRoot);
					for (iRow=0 ; iRow<objDtDepartments.Rows.Count; iRow++)
					{
						objRow = objDtDepartments.Rows[iRow];
						tnDepartment=new TreeNode();
                        tnDepartment.Value = "Department," + objRow["DepartmentId"].ToString();
						tnDepartment.Text=objRow["DepartmentName"].ToString();
						//						tnDepartment.CheckBox=true;
						tnRoot.ChildNodes.Add(tnDepartment);
						objUsersEN = new clsQxUsersEN();
						objDtUsers= clsQxUsersBL.GetDataTable_QxUsers("DepartmentId = '" + clsCommForWebForm.getNodeID_S(tnDepartment) + "'");
						for (jRow=0 ; jRow<objDtUsers.Rows.Count; jRow++)
						{
							objRow2 = objDtUsers.Rows[jRow];
							tnUser=new TreeNode();
                            tnUser.Value = "User," + objRow2["UserId"].ToString();
							
							tnUser.Text=objRow2["XM"].ToString();
							//							tnUser.CheckBox=true;
							tnDepartment.ChildNodes.Add(tnUser);
						}
					}

					break;
				}
			}
		}

		private void rblDispFashion_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (rblDispFashion.Items[0].Selected ==true)		//显示全部用户
			{
				ShowUserTree("显示全部用户");
			}
			else if (rblDispFashion.Items[1].Selected ==true)		//按组显示全部用户
			{
				ShowUserTree("按组显示全部用户");
			}
			else if (rblDispFashion.Items[2].Selected ==true)		//按部门显示全部用户
			{
				ShowUserTree("按部门显示全部用户");
			}
			else if (rblDispFashion.Items[3].Selected ==true)		//按角色显示全部用户
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
			for (int iRow=0; iRow<objDT.Rows.Count; iRow++)
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
			for (int iRow=0; iRow<objDT.Rows.Count; iRow++)
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
			for (int iRow=0; iRow<objDT.Rows.Count; iRow++)
			{
                strPotence = objDT.Rows[iRow]["PotenceId"].ToString();
				arrLst.Add(strPotence);
			}
			
			SetCheckedForUserGroupPotence(tvPotences.Nodes[0], arrLst);

		}
		private void SetCheckedForUserGroupPotence(TreeNode tnTemp, ArrayList arrLst)
		{
            string strNodeType = clsCommForWebForm.getNodeType_S(tnTemp);
            string strNodeID = clsCommForWebForm.getNodeID_S(tnTemp);

            if (strNodeType == "PotenceName")
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
				foreach(TreeNode tn in tnTemp.ChildNodes)
				{
					SetCheckedForUserGroupPotence(tn, arrLst);
				}
			}
		}

		protected void btnSavePotences_Click(object sender, System.EventArgs e)
		{
			string strUserId, strGroupId, strRoleId;
			string strPotenceId;
			//1、获取被选的用户或组
            TreeNode tnSelectedNode = tvUsers.SelectedNode;
            string strNodeType = clsCommForWebForm.getNodeType_S(tnSelectedNode);
            string strKeyId = clsCommForWebForm.getNodeID_S(tnSelectedNode);
            TreeNode tnUserGroup = tvUsers.SelectedNode;
            if (strNodeType != "User" && strNodeType != "Group" && strNodeType != "RoleName")
			{
				lblMsg.Text = "请选择单用户/单组";
				return ;
			}

			ArrayList arrCheckedPotence = getCheckedPotencesNode();

			//			string strPrjId = ConfigurationSettings.AppSettings[conQxProjects.QxPrjId];
			string strPrjId = this.ddlPrj.SelectedValue;

            if (strNodeType == "User") //如果选择的节点为用户
			{
                strUserId = strKeyId;
                //获取该用户组的所有权限
                string strCondition = string.Format("{0} = '{1}' and UserId = '{2}'",
                    conQxUserGroupPotence.QxPrjId,
                    getUserPrjId,
                    strUserId);
                DataTable dtUserPotences = clsQxUserGroupPotenceBL.GetDataTable_QxUserGroupPotence(strCondition);
				ArrayList arrUserOldPotence = new ArrayList();
				
				foreach( DataRow objRow in dtUserPotences.Rows)
				{
					strPotenceId = objRow["UserId"].ToString();
					arrUserOldPotence.Add(strPotenceId);
				}
				ArrayList arrNewPotence = clsAggregate.TwoAggrDiff(arrCheckedPotence, arrUserOldPotence);
				ArrayList arrNeedDelPotence = clsAggregate.TwoAggrDiff(arrUserOldPotence, arrCheckedPotence);
                clsQxUserGroupPotenceBLEx.UserDelSomePotence(strPrjId, strUserId, arrNeedDelPotence);
                clsQxUserGroupPotenceBLEx.UserAddPotences(strPrjId, strUserId, arrNewPotence);
				lblMsg.Text = "请看右边的<" + tnUserGroup.Text + ">用户权限!";
				return ;
			}
            if (strNodeType == "Group") //如果选择的节点为用户
			{
                strGroupId = strKeyId;

                //获取该用户组的所有权限
                string strCondition = string.Format("{0} = '{1}' and GroupId = '{2}'",
                    conQxUserGroupPotence.QxPrjId, getUserPrjId, strGroupId);
                DataTable dtGroupPotences = clsQxUserGroupPotenceBL.GetDataTable_QxUserGroupPotence(strCondition);
				ArrayList arrGroupOldPotence = new ArrayList();
				
				foreach( DataRow objRow in dtGroupPotences.Rows)
				{
					strPotenceId = objRow["PotenceId"].ToString();
					arrGroupOldPotence.Add(strPotenceId);
				}
				ArrayList arrNewPotence = clsAggregate.TwoAggrDiff(arrCheckedPotence, arrGroupOldPotence);
				ArrayList arrNeedDelPotence = clsAggregate.TwoAggrDiff(arrGroupOldPotence, arrCheckedPotence);
                clsQxUserGroupPotenceBLEx.GroupDelSomePotence(strPrjId, strGroupId, arrNeedDelPotence);
                clsQxUserGroupPotenceBLEx.GroupAddPotences(strPrjId, strGroupId, arrNewPotence);
				lblMsg.Text = "请看右边的<" + tnUserGroup.Text + ">组权限!";
				return ;
			}
            if (strNodeType == "RoleName") //如果选择的节点为用户角色
			{
                strRoleId = strKeyId;
                //获取该角色的所有权限
                string strCOndition = string.Format("{0} = '{1}' and RoleId = '{2}'",
                    conQxUserGroupPotence.QxPrjId, getUserPrjId, strRoleId);
                DataTable dtRolePotences = clsQxUserGroupPotenceBL.GetDataTable_QxUserGroupPotence(strCOndition);
				ArrayList arrRoleOldPotence = new ArrayList();
              
				foreach( DataRow objRow in dtRolePotences.Rows)
				{
                    strPotenceId = objRow["PotenceId"].ToString();
                    arrRoleOldPotence.Add(strPotenceId);
				}
				ArrayList arrNewPotence = clsAggregate.TwoAggrDiff(arrCheckedPotence, arrRoleOldPotence);
				ArrayList arrNeedDelPotence = clsAggregate.TwoAggrDiff(arrRoleOldPotence, arrCheckedPotence);
                clsQxUserGroupPotenceBLEx.RoleDelSomePotence(strPrjId, strRoleId, arrNeedDelPotence);
                clsQxUserGroupPotenceBLEx.RoleAddPotences(strPrjId, strRoleId, arrNewPotence);
                clsQxRoleMenusBLEx.EditQxRoleMenusByPotence(strPrjId, strRoleId, clsCommonSession.UserId);

                lblMsg.Text = "请看右边的<" + tnUserGroup.Text + ">组权限!";
				return ;
			}
		}

		protected void lbBrowUserGroupPotence_Click(object sender, System.EventArgs e)
		{
			TreeNode tnUserGroup = tvUsers.SelectedNode;
			ShowUserGroupPotences(tnUserGroup);
		
		}
		private void ShowUserGroupPotences(TreeNode tnUserGroup)
		{
            string strNodeType = clsCommForWebForm.getNodeType_S(tnUserGroup);
            string strNodeID = clsCommForWebForm.getNodeID_S(tnUserGroup);

            if (strNodeType != "User" && strNodeType != "Group" && strNodeType != "RoleName")
			{
				lblMsg.Text = "请选择单用户/单组";
				return ;
			}

            if (strNodeType == "User") //如果选择的节点为用户
			{
                ShowPotenceForSingleUser(strNodeID);
				lblMsg.Text = "请看右边的<" + tnUserGroup.Text + ">用户权限!";
				return ;
			}
            if (strNodeType == "Group") //如果选择的节点为用户
			{
                ShowPotenceForSingleGroup(strNodeID);
				lblMsg.Text = "请看右边的<" + tnUserGroup.Text + ">组权限!";
				return ;
			}

            if (strNodeType == "RoleName") //如果选择的节点为用户
			{
                ShowPotenceForSingleRole(strNodeID);   //20050630修改
				lblMsg.Text = "请看右边的<" + tnUserGroup.Text + ">角色权限!";
				return ;
			}
		
		}
		
		private void chkAutoDispUserGroupPotences_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkAutoDispUserGroupPotences.Checked == true)
			{
                //tvUsers.AutoPostBack = true;
				tvUsers.SelectedNodeChanged +=new EventHandler(tvUsers_SelectedNodeChanged);
			}
			else
			{
                //tvUsers.AutoPostBack = false;
				tvUsers.SelectedNodeChanged -= new EventHandler(tvUsers_SelectedNodeChanged);
			}
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
        protected void tvUsers_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode tnUserGroup = tvUsers.SelectedNode;
            ShowUserGroupPotences(tnUserGroup);		
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
