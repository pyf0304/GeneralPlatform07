///生成查询，修改，删除，添加记录的控制层代码
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
using SpecData;
using GeneralPlatform;

//using GeneMenu;	///专门用于生成菜单

using CommFunc4WebForm;
using com.taishsoft.commdb;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;

using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmQxPrjMenus_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmQxPrjMenus_EDITMenu : System.Web.UI.Page
	{

		private const string ViewId="00010202";
		private string level;
		

		private void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			//获取当前用户的权限等级编号
			level=new MenuAndPotence().Get_PotenceLevel(ViewId);	

			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
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

						this.ddlPrj.Enabled =false;
						this.wucQxPrjMenus1.Set_DdlPrjNotEnabled();
						
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
                string strUserPrjId = getUserPrjId;
                string strDefaultMenuSetId = clsQxPrjMenuSetBLEx.GetDefaultMenuSetIdByPrjId(strUserPrjId);
                clsQxProjectsBL.BindDdl_QxPrjIdCache(this.ddlPrj);
				this.ddlPrj.SelectedValue = getUserPrjId;
                if (clsCommonSession.RoleId != "0001")
                {
                    this.ddlPrj.Enabled = false;
                }
				//1、为下拉框设置数据源，绑定列表数据
				wucQxPrjMenus1.SetDdl_QxPrjId();
				wucQxPrjMenus1.QxPrjId = getUserPrjId;
                wucQxPrjMenus1.SetDdl_LevelMenuId(strDefaultMenuSetId);
				//2、显示无条件的表内容在DATAGRID中
				BindDg_QxPrjMenus();
				//3、设置表控件中字控件的ReadOnly属性，
				///   使之只读，因为在修改功能中关键字是不能被修改的。
				wucQxPrjMenus1.SetKeyReadOnly(true);
				ShowMenuTree();
			}
		}

		public string Get_DdlPrj()
		{
			return this.ddlPrj.SelectedValue;
		}

	


		private void ShowMenuTree()
		{
			System.Data.DataTable objDTUpMenu, objDTSubMenu;
			clsQxPrjMenusBLEx objPrjMenuEx = new clsQxPrjMenusBLEx();
			StringBuilder strCondition = new StringBuilder();
			
			StringBuilder strHtml=new StringBuilder();		//需要插入的HTML代码

			StringBuilder strMenuSubItem = new StringBuilder();
			string strMenuId, strUpMenuId, strSubMenuId;
			string strUpMenuName, strSubMenuName, strLinkFile, strUpImgFile, strSubImgFile;
			
			//1、获取主菜单项
			strCondition.AppendFormat("UpMenuId = '00000000' and {1} = '{0}' ",
                this.ddlPrj.SelectedValue, conQxPrjMenus.QxPrjId);
			objDTUpMenu = objPrjMenuEx.GetTableEx(strCondition.ToString(), "OrderNum");
			//2、获取相应子菜单项
			strCondition = new StringBuilder();
			strCondition.AppendFormat("UpMenuId <> '00000000' and {1} = '{0}' ", 
                this.ddlPrj.SelectedValue,
                conQxPrjMenus.QxPrjId);
            objDTSubMenu = objPrjMenuEx.GetTableEx(strCondition.ToString(), "OrderNum");

			//			string strPrjId = ConfigurationSettings.AppSettings[conQxProjects.QxPrjId];
	
			TreeNode tnRoot, tnUpMenuItem, tnSubMenuItem;

			tvQxPrjMenus.Nodes.Clear();
			tnRoot=new TreeNode();
            tnRoot.Value = "root,root";
			tnRoot.Text = "项目菜单结构: ";
			tnRoot.ShowCheckBox=true;
			tvQxPrjMenus.Nodes.Add(tnRoot);

			
			foreach ( DataRow UpMenuRow in objDTUpMenu.Rows)
			{
				strMenuId = UpMenuRow["MenuId"].ToString();	//获取主菜单项ID
				strUpMenuName = UpMenuRow["MenuName"].ToString(); //获取主菜单项NAME
				strUpImgFile = UpMenuRow["ImgFile"].ToString();

				tnUpMenuItem=new TreeNode();
                tnUpMenuItem.Value = "UpMenu," + strMenuId;	//分类码
				
				tnUpMenuItem.Text = strUpMenuName;	//分类名称
				if (strUpImgFile.Length>0)
				{
					tnUpMenuItem.ImageUrl ="../" + strUpImgFile;
				}
				
				tnUpMenuItem.ShowCheckBox=true;
				tnRoot.ChildNodes.Add(tnUpMenuItem);

				foreach ( DataRow SubMenuRow in objDTSubMenu.Rows)
				{
					strUpMenuId = SubMenuRow["UpMenuId"].ToString();

					if (strMenuId == strUpMenuId)
					{
						strSubMenuId = SubMenuRow["MenuId"].ToString();	//获取主菜单项ID
						strSubMenuName = SubMenuRow["MenuName"].ToString(); //获取主菜单项NAME
						strSubImgFile = SubMenuRow["ImgFile"].ToString();
						strLinkFile = SubMenuRow["LinkFile"].ToString();

						tnSubMenuItem=new TreeNode();
                        tnSubMenuItem.Value = "SubMenu," + strSubMenuId;
						
						tnSubMenuItem.Text=strSubMenuName;
						if (strSubImgFile.Length>0)
						{
							tnSubMenuItem.ImageUrl ="../" + strSubImgFile;
						}
						tnSubMenuItem.ShowCheckBox=true;
						tnUpMenuItem.ChildNodes.Add(tnSubMenuItem);
					}
				}
			}
            tvQxPrjMenus.ExpandAll();

		}
		
		///生成组合查询条件的代码
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineCondion()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and XM = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
//			if (this.txtMenuId_q.Text.Trim()!="")
//			{
//				strWhereCond += " and QxPrjMenus.MenuId='" + this.txtMenuId_q.Text.Trim()+"'";
//			}
//			if (this.txtMenuName_q.Text.Trim()!="")
//			{
//				strWhereCond += " and QxPrjMenus.MenuName='" + this.txtMenuName_q.Text.Trim()+"'";
//			}
//			if (this.ddlPrjId_q.SelectedValue!="" && this.ddlPrjId_q.SelectedValue!="0")
//			{
//				strWhereCond += " and QxPrjMenus.QxPrjId='" + this.ddlPrjId_q.SelectedValue+"'";
//			}
//			if (this.ddlUpMenuId_q.SelectedValue!="" && this.ddlUpMenuId_q.SelectedValue!="0")
//			{
//				strWhereCond += " and QxPrjMenus.UpMenuId='" + this.ddlUpMenuId_q.SelectedValue+"'";
//			}
//			if (this.txtLinkFile_q.Text.Trim()!="")
//			{
//				strWhereCond += " and QxPrjMenus.LinkFile like '%" + this.txtLinkFile_q.Text.Trim()+"%'";
//			}
//			if (this.txtImgFile_q.Text.Trim()!="")
//			{
//				strWhereCond += " and QxPrjMenus.ImgFile='" + this.txtImgFile_q.Text.Trim()+"'";
//			}
//			if (this.ddlRoleId_q.SelectedValue!="" && this.ddlRoleId_q.SelectedValue!="0")
//			{
//				strWhereCond += " and QxPrjMenus.RoleId='" + this.ddlRoleId_q.SelectedValue+"'";
//			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_QxPrjMenus()
		{
			//操作步骤：(共5步)
			//1、组合界面条件串；
			//2、根据条件串获取该表满足条件的DataTable；
			//3、设置DATAGRID的数据源(DataSource)；
			//4、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			//5、设置记录数的状态，
			///		在本界面中是把状态显示在控件txtRecCount中。

			//1、组合界面条件串；
			string strWhereCond = CombineCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvQxPrjMenusBL.GetDataTable(strWhereCond);
			//3、设置DATAGRID的数据源(DataSource)；
		}

		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strMenuId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string strMenuId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strMenuId == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsQxPrjMenusBL.IsExist(strMenuId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strMenuId + "的不存在!";
				Response.Write("<script>alert('" + ss + "')</script>");
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsQxPrjMenusEN objQxPrjMenus = new clsQxPrjMenusEN(strMenuId);
			//4、获取类对象的所有属性；
            clsQxPrjMenusBL.GetQxPrjMenus(ref objQxPrjMenus);
			Session.Add("objQxPrjMenus", objQxPrjMenus);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromQxPrjMenusClass(objQxPrjMenus);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjQxPrjMenus">表实体类对象</param>
		private void GetDataFromQxPrjMenusClass(clsQxPrjMenusEN pobjQxPrjMenus)
		{
			wucQxPrjMenus1.MenuId = pobjQxPrjMenus.MenuId;
			wucQxPrjMenus1.MenuName = pobjQxPrjMenus.MenuName;
			wucQxPrjMenus1.QxPrjId = pobjQxPrjMenus.QxPrjId;
			wucQxPrjMenus1.UpMenuId = pobjQxPrjMenus.UpMenuId;
			wucQxPrjMenus1.LinkFile = pobjQxPrjMenus.LinkFile;
			wucQxPrjMenus1.ImgFile = pobjQxPrjMenus.ImgFile;
			wucQxPrjMenus1.OrderNum = pobjQxPrjMenus.OrderNum;
		}
		/// <summary>
		/// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
		///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			string strCommandText;
			clsQxPrjMenusEN objQxPrjMenus;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					wucQxPrjMenus1.SetKeyReadOnly(false);
					//设置默认值
					wucQxPrjMenus1.SetDefaultValue();
					btnOKUpd.Text = "确认添加";
					break;				
				case "确认添加":
					//这是一个单表的插入的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					//操作步骤：
					//1、检查控件中输入数据类型是否正确
					//2、定义对象并初始化对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					//4、把值从界面层传到逻辑层或数据实体层
					//5、检查传进去的对象属性是否合法
					//6、把数据实体层的数据存贮到数据库中
					//7、把新添的记录内容显示在DATAGRID中
					//1、检查控件中输入数据类型是否正确
					if (!wucQxPrjMenus1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsQxPrjMenusEN objQxPrjMenus;	//定义对象
					objQxPrjMenus = new clsQxPrjMenusEN(wucQxPrjMenus1.MenuId);	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                    if (clsQxPrjMenusBL.IsExist(objQxPrjMenus.MenuId))	//判断是否有相同的关键字
					{
						strMsg = "关键字字段已有相同的值";
						Response.Write("<script>alert('" + strMsg + "')</script>");
						return;
					}
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToQxPrjMenusClass(objQxPrjMenus);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    try
                    {
                        clsQxPrjMenusBL.CheckPropertyNew(objQxPrjMenus);
                    }
                    catch (Exception objException)
                    {
                        Response.Write("<script>alert('" + objException.Message + "')</script>");
                        return;
                    }
					//6、把数据实体层的数据存贮到数据库中
                    if (clsQxPrjMenusBL.AddNewRecordBySql2(objQxPrjMenus) == false) 
					{
						strMsg = "添加不成功!";
						Response.Write("<script>alert('" + strMsg + "')</script>");
						lblMsg.Text = "添加记录不成功!";
					}
					else
					{
						strMsg = "添加记录成功!";
						Response.Write("<script>alert('" + strMsg + "')</script>");
						lblMsg.Text = "添加记录成功!";
					}
					//7、把新添的记录内容显示在DATAGRID中
					BindDg_QxPrjMenus();
					wucQxPrjMenus1.Clear();		//清空控件中内容
					///恢复<确认添加>变成<添加>
					btnOKUpd.Text = "添加";
					///8、重新显示菜单树
					ShowMenuTree();
                    tvQxPrjMenus.ExpandAll();
					break;
				case "确认修改":
					//这是一个单表的修改的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					//操作步骤：
					//1、检查控件中输入数据类型是否正确
					//2、把值从界面层传到逻辑层或数据实体层
					//3、检查传进去的对象属性是否合法
					//4、把数据实体层的数据存贮到数据库中
					//5、把修改后的内容显示在DATAGRID中
					//1、检查控件中输入数据类型是否正确
					if (!wucQxPrjMenus1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objQxPrjMenus  = (clsQxPrjMenusEN) Session["objQxPrjMenus"];
					PutDataToQxPrjMenusClass(objQxPrjMenus);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    try
                    {
                        clsQxPrjMenusBL.CheckPropertyNew(objQxPrjMenus);
                    }
                    catch (Exception objException)
                    {
                        Response.Write("<script>alert('" + objException.Message + "')</script>");
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
                    if (clsQxPrjMenusBL.UpdateBySql2(objQxPrjMenus) == false) 
					{
						strMsg = "修改记录不成功!";
						Response.Write("<script>alert('" + strMsg + "')</script>");
						lblMsg.Text = "修改记录不成功!";
					}
					else
					{
						strMsg = "修改记录成功!";
						Response.Write("<script>alert('" + strMsg + "')</script>");
						lblMsg.Text = "修改记录成功!";
					}
					//5、把修改后的内容显示在DATAGRID中
					BindDg_QxPrjMenus();
					wucQxPrjMenus1.Clear();//添空控件中的内容
					//6、恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					//7、重新显示菜单树
					ShowMenuTree();

					break;
			}
		}
		///生成从界面层到逻辑层的数据传输函数代码
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjQxPrjMenus">数据传输的目的类对象</param>
		private void PutDataToQxPrjMenusClass(clsQxPrjMenusEN pobjQxPrjMenus)
		{
			pobjQxPrjMenus.MenuId = wucQxPrjMenus1.MenuId;
			pobjQxPrjMenus.MenuName = wucQxPrjMenus1.MenuName;
			pobjQxPrjMenus.QxPrjId = wucQxPrjMenus1.QxPrjId;
			pobjQxPrjMenus.UpMenuId = wucQxPrjMenus1.UpMenuId;
			pobjQxPrjMenus.LinkFile = wucQxPrjMenus1.LinkFile;
			pobjQxPrjMenus.ImgFile = wucQxPrjMenus1.ImgFile;
			pobjQxPrjMenus.OrderNum = wucQxPrjMenus1.OrderNum;
		}

		private void dgQxPrjMenus_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				System.Web.UI.WebControls.LinkButton myDeleteButton;
				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
				myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Item.ItemIndex+1).ToString() + " 行吗？');");
			}
		}

		private void dgQxPrjMenus_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strMenuId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strMenuId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsQxPrjMenusBL.DelRecord(strMenuId);
						BindDg_QxPrjMenus();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(strMenuId);
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
						btnOKUpd.Enabled = true;
						wucQxPrjMenus1.SetKeyReadOnly(true);
						btnOKUpd.Text = "确认修改";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		
		public System.Data.DataTable GetUpMenuId()
		{
			//获取某学院所有专业信息
			string strSQL = "select MenuId, MenuName from QxPrjMenus ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_UpMenuId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetUpMenuId();
			objDDL.DataValueField="MenuId";
			objDDL.DataTextField="MenuName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetRoleId()
		{
			//获取某学院所有专业信息
			string strSQL = "select RoleId, RoleName from UserRole ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetRoleId();
			objDDL.DataValueField="RoleId";
			objDDL.DataTextField="RoleName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		/// <summary>
		/// 功能：添加顶层菜单
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void lbAddUpMenu_Click(object sender, System.EventArgs e)
		{
			//操作步骤：(在自定义的控件中)
			//1、清空输入的控件，使之变为可以输入的状态。
			//2、自动生成菜单号，通过获取表中的最大号码的下一个，号码为：工程号+4位菜单号
			//3、上级菜单的下拉框的值为0，即顶层菜单
			//4、工程号设置当前工程；
			//5、把<添加>按钮的标题设置为“确定添加”
			//6、设置菜单排序号
			///
			//1、清空输入的控件，使之变为可以输入的状态。
			wucQxPrjMenus1.SetDefaultValue();
			//2、自动生成菜单号，通过获取表中的最大号码的下一个，号码为：工程号+4位菜单号
			string strMenuId;
			strMenuId = clsQxPrjMenusBL.GetMaxStrIdByPrefix_S(this.ddlPrj.SelectedValue);
			wucQxPrjMenus1.MenuId = strMenuId;
			//3、上级菜单的下拉框的值为0，即顶层菜单
			wucQxPrjMenus1.UpMenuId = "00000000";
			//4、工程号设置当前工程；
			wucQxPrjMenus1.QxPrjId = this.ddlPrj.SelectedValue;
			//5、把<添加>按钮的标题设置为“确定添加”
			btnOKUpd.Text = "确认添加";
			//6、设置菜单排序号
			///
            wucQxPrjMenus1.OrderNum = (clsQxPrjMenusBLEx.getTopMenuCount(this.ddlPrj.SelectedValue) + 1) * 100;
		}

		protected void lbAddSubMenu_Click(object sender, System.EventArgs e)
		{
			//操作步骤：(在自定义的控件中)
			//1、检查是否选中顶层菜单项。
			//2、清空输入的控件，使之变为可以输入的状态。
			//3、自动生成菜单号，通过获取表中的最大号码的下一个，号码为：工程号+4位菜单号
			//4、上级菜单的下拉框的值为0，即顶层菜单
			//5、工程号设置当前工程；
			//6、把<添加>按钮的标题设置为“确定添加”
			///
			string strTopMenuId;

			//1、检查是否选中顶层菜单项。
			TreeNode tnSelectedNode = tvQxPrjMenus.SelectedNode;
            if (tnSelectedNode == null)
            {
                tnSelectedNode = clsCommForWebForm.getFirstCheckedNode(tvQxPrjMenus.Nodes[0]);
                if (tnSelectedNode == null)
                {
                    lblMsg_tv.Text = "请选择合适的结点!";
                    return;
                }
            }
            lblMsg_tv.Text = "";
            string strNodeType = clsCommForWebForm.getNodeType_S(tnSelectedNode);

            if (strNodeType != "UpMenu")
			{
				lblMsg.Text = "请选择正确的顶层菜单项!";
				return ;
			}
            strTopMenuId = clsCommForWebForm.getNodeID_S(tnSelectedNode);
			//2、清空输入的控件，使之变为可以输入的状态。
			wucQxPrjMenus1.SetDefaultValue();
			//3、自动生成菜单号，通过获取表中的最大号码的下一个，号码为：工程号+4位菜单号
			string strMenuId;
			strMenuId = clsQxPrjMenusBL.GetMaxStrIdByPrefix_S(this.ddlPrj.SelectedValue);
			wucQxPrjMenus1.MenuId = strMenuId;
            string strUserPrjId = ddlPrj.SelectedValue;
            string strDefaultMenuSetId = clsQxPrjMenuSetBLEx.GetDefaultMenuSetIdByPrjId(strUserPrjId);

			//4、上级菜单的下拉框的值为0，即顶层菜单
            wucQxPrjMenus1.SetDdl_LevelMenuId(strDefaultMenuSetId);
			wucQxPrjMenus1.UpMenuId = strTopMenuId;
			//5、工程号设置当前工程；
			wucQxPrjMenus1.QxPrjId = this.ddlPrj.SelectedValue;
			//6、把<添加>按钮的标题设置为“确定添加”
			btnOKUpd.Text = "确认添加";
			//7、设置菜单排序号
			///
			wucQxPrjMenus1.OrderNum = (new clsQxPrjMenusBLEx().getNewSubMenuOrderNum(this.ddlPrj.SelectedValue, strTopMenuId));
		}

		protected void lbDeleteMenu_Click(object sender, System.EventArgs e)
		{
			//操作步骤：(在自定义的控件中)
			//1、获取当前所选中的菜单项。
			//2、根据当前菜单结点的类型分别处理：
			///		2_1 如果是子菜单项，就直接删除
			///		2_2 如果是顶层菜单项，首先要判断是否有下级子菜单，
			///			如果没有就直接删除，
			///			如果有显示提示，必须先删除下级子菜单才能删除
			///		2_3 如果是根结点，就提示选择结点错误
			//3、提示：删除某结点成功
			//4、重新显示菜单树
			
			string strMenuId;
			string strNodeType = "";
            string strKeyId ;
			//1、获取当前所选中的菜单项。
			TreeNode tnSelectedNode = tvQxPrjMenus.SelectedNode;
            if (tnSelectedNode == null)
            {
                tnSelectedNode = clsCommForWebForm.getFirstCheckedNode(tvQxPrjMenus.Nodes[0]);
                if (tnSelectedNode == null)
                {
                    lblMsg_tv.Text = "请选择需要删除的结点!";
                    return;
                }   
            }
            lblMsg_tv.Text = "";
            strNodeType = clsCommForWebForm.getNodeType_S(tnSelectedNode);
            strKeyId = clsCommForWebForm.getNodeID_S(tnSelectedNode);
            
			//2、根据当前菜单结点的类型分别处理：
            switch (strNodeType)
			{
					///		2_3 如果是根结点，就提示选择结点错误
				case "root":
					lblMsg_tv.Text = "选择菜单结点错误，请选择正确的菜单项!";
					return ;
				case "UpMenu":
                    strMenuId = clsCommForWebForm.getNodeID_S(tnSelectedNode);               
					///		2_2 如果是顶层菜单项，首先要判断是否有下级子菜单，
                    if (clsQxPrjMenusBL.IsExistRecord("UpMenuId='" + strMenuId + "'"))
					{
						///			如果有显示提示，必须先删除下级子菜单才能删除
						lblMsg_tv.Text = "选择菜单结点错误，必须先删除下级子菜单才能删除!";
						return ;
					}
					else
					{
						///			如果没有就直接删除，
						clsQxPrjMenusBLEx.DelRecordForTopMenuEx(strMenuId);
					};
					break;
					///		2_1 如果是子菜单项，就直接删除
				case "SubMenu":
                    strMenuId = clsCommForWebForm.getNodeID_S(tnSelectedNode);
					if (clsQxPrjMenusBLEx.DelRecordForSubMenuEx(strMenuId)==false)
					{
						lblMsg_tv.Text = "删除" + tnSelectedNode.Text + "某结点不成功";
						return ;
					};
					break;

			}
			//3、提示：删除某结点成功
			lblMsg_tv.Text = "删除" + tnSelectedNode.Text + "某结点成功";
			//4、重新显示菜单树
			ShowMenuTree();
            tvQxPrjMenus.ExpandAll();
		}

		protected void lbUpdateMenu_Click(object sender, System.EventArgs e)
		{
			/////操作步骤：（总共2步）
			//1、显示该关键字记录的内容在界面上；
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；

			string strMenuId="";
			//1、获取当前所选中的菜单项。
            ///
            TreeNode tnSelectedNode = tvQxPrjMenus.SelectedNode;
            string strNodeType = clsCommForWebForm.getNodeType_S(tnSelectedNode);
            string strKeyId = clsCommForWebForm.getNodeID_S(tnSelectedNode);
            //2、根据当前菜单结点的类型分别处理：
            switch (strNodeType)
			{
					///		2_3 如果是根结点，就提示选择结点错误
				case "root":
					lblMsg.Text = "选择菜单结点错误，请选择正确的菜单项!";
					return ;
				case "UpMenu":
                    strMenuId = strKeyId;
					break;
				case "SubMenu":
                    strMenuId = strKeyId;
					break;

			}


			//1、显示该关键字记录的内容在界面上；
			ShowData(strMenuId);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			btnOKUpd.Enabled = true;
			wucQxPrjMenus1.SetKeyReadOnly(true);
			btnOKUpd.Text = "确认修改";
			lblMsg.Text = "";
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strMenuId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData2(string strMenuId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strMenuId == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsQxPrjMenusBL.IsExist(strMenuId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strMenuId + "的不存在!";
				Response.Write("<script>alert('" + ss + "')</script>");
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsQxPrjMenusEN objQxPrjMenus = new clsQxPrjMenusEN(strMenuId);
			//4、获取类对象的所有属性；
            clsQxPrjMenusBL.GetQxPrjMenus(ref objQxPrjMenus);
			Session.Add("objQxPrjMenus", objQxPrjMenus);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromQxPrjMenusClass(objQxPrjMenus);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjQxPrjMenus">表实体类对象</param>
		private void GetDataFromQxPrjMenusClass2(clsQxPrjMenusEN pobjQxPrjMenus)
		{
			wucQxPrjMenus1.MenuId = pobjQxPrjMenus.MenuId;
			wucQxPrjMenus1.MenuName = pobjQxPrjMenus.MenuName;
			wucQxPrjMenus1.QxPrjId = pobjQxPrjMenus.QxPrjId;
			wucQxPrjMenus1.UpMenuId = pobjQxPrjMenus.UpMenuId;
			wucQxPrjMenus1.LinkFile = pobjQxPrjMenus.LinkFile;
			wucQxPrjMenus1.ImgFile = pobjQxPrjMenus.ImgFile;
		}

		protected void ibUp_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			//操作步骤：
			//1、获取当前所选中的菜单项。
			//2、判断选择结点的类型
			//3、根据是顶层菜单或子菜单分别处理
			//3、如果是顶层菜单
			///		3.1、获取关键字
			///		3.2、调用类中上移序号一层
			//4、如果是子菜单
			///		4.1、获取关键字
			///		4.2、调用类中上移序号一层
			//5、重新显示树内容
			bool bolIsSuccess;
			string strMenuId="";
			//1、获取当前所选中的菜单项。
            ///

            TreeNode tnSelectedNode = tvQxPrjMenus.SelectedNode;
            TreeNode tnPrevNode = null;//前面一个结点
          
            if (tnSelectedNode == null)
            {
                tnSelectedNode = clsCommForWebForm.getFirstCheckedNode(tvQxPrjMenus.Nodes[0]);
                if (tnSelectedNode == null)
                {
                    lblMsg_tv.Text = "请选择合适的结点!";
                    return;
                }
            }
            tnPrevNode = clsCommForWebForm.getPrevNode(tnSelectedNode);
            if (tnPrevNode == null)
            {
                clsCommonJsFunc.Alert(this, "当前结点已经是第一个结点，不能再上移！");
                return ;
            }
            lblMsg_tv.Text = "";


            string strNodeType = clsCommForWebForm.getNodeType_S(tnSelectedNode);
            string strKeyId = clsCommForWebForm.getNodeID_S(tnSelectedNode);

            txtCurrNodeId.Value = strKeyId;
            try
            {
                //2、根据是顶层菜单或子菜单分别处理
                switch (strNodeType)
                {
                    ///		2_3 如果是根结点，就提示选择结点错误
                    case "root":
                        lblMsg.Text = "选择菜单结点错误，请选择正确的菜单项!";
                        return;
                    case "UpMenu":
                        //3、如果是顶层菜单
                        ///		3.1、获取关键字
                        strMenuId = strKeyId;
                        ///		3.2、调用类中下移序号一层
                        bolIsSuccess = (new clsQxPrjMenusBLEx().UpOrderByOneForTopMenu(this.ddlPrj.SelectedValue, strMenuId));
                        if (bolIsSuccess == true)
                        {
                            //						intNextStepIndex = intStepIndex + 1;
                        }
                        break;
                    case "SubMenu":
                        //4、如果是子菜单
                        ///		4.1、获取关键字
                        strMenuId = strKeyId;
                        ///		4.2、调用类中下移序号一层
                        bolIsSuccess = (new clsQxPrjMenusBLEx().UpOrderByOneForSubMenu(this.ddlPrj.SelectedValue, strMenuId));
                        if (bolIsSuccess == true)
                        {
                            //						intNextStepIndex = intStepIndex + 1;
                        }
                        break;
                }
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
			//5、重新显示树内容
            //ShowMenuTree();
            //tvQxPrjMenus.ExpandAll();
            //TreeNode tnTemp = clsCommForWebForm.GetNodeFromTreeViewByID(tvQxPrjMenus.Nodes[0], txtCurrNodeId.Value); 

            string strTemp = tnPrevNode.Value;
            tnPrevNode.Value = tnSelectedNode.Value;
            tnSelectedNode.Value = strTemp;

             strTemp = tnPrevNode.Text;
            tnPrevNode.Text = tnSelectedNode.Text;
            tnSelectedNode.Text = strTemp;

            tnPrevNode.Select();

		}

		protected void ibDown_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			//操作步骤：
			//1、获取当前所选中的菜单项。
			//2、判断选择结点的类型
			//3、根据是顶层菜单或子菜单分别处理
			//3、如果是顶层菜单
			///		3.1、获取关键字
			///		3.2、调用类中下移序号一层
			//4、如果是子菜单
			///		4.1、获取关键字
			///		4.2、调用类中下移序号一层
			//5、重新显示树内容
			bool bolIsSuccess;
			string strMenuId="";
			//1、获取当前所选中的菜单项。

            TreeNode tnSelectedNode = tvQxPrjMenus.SelectedNode;
            if (tnSelectedNode == null)
            {
                tnSelectedNode = clsCommForWebForm.getFirstCheckedNode(tvQxPrjMenus.Nodes[0]);
                if (tnSelectedNode == null)
                {
                    lblMsg_tv.Text = "请选择合适的结点!";
                    return;
                }
            }
            lblMsg_tv.Text = "";

            string strNodeType = clsCommForWebForm.getNodeType_S(tnSelectedNode);
            string strKeyId = clsCommForWebForm.getNodeID_S(tnSelectedNode);

            txtCurrNodeId.Value = strKeyId;
			//2、根据是顶层菜单或子菜单分别处理
            switch (strNodeType)
			{
					///		2_3 如果是根结点，就提示选择结点错误
				case "root":
					lblMsg.Text = "选择菜单结点错误，请选择正确的菜单项!";
					return ;
				case "UpMenu":
					//3、如果是顶层菜单
					///		3.1、获取关键字
                    strMenuId = strKeyId;
					///		3.2、调用类中下移序号一层
					bolIsSuccess =  (new clsQxPrjMenusBLEx().DownOrderByOneForTopMenu(this.ddlPrj.SelectedValue, strMenuId));
					if (bolIsSuccess == true)
					{		
//						intNextStepIndex = intStepIndex + 1;
					}
					break;
				case "SubMenu":
					//4、如果是子菜单
					///		4.1、获取关键字
                    strMenuId = strKeyId;
					///		4.2、调用类中下移序号一层
					bolIsSuccess =  (new clsQxPrjMenusBLEx().DownOrderByOneForSubMenu(this.ddlPrj.SelectedValue, strMenuId));
					if (bolIsSuccess == true)
					{		
//						intNextStepIndex = intStepIndex + 1;
					}
					break;
			}
			//5、重新显示树内容
			ShowMenuTree();
            tvQxPrjMenus.ExpandAll();
            TreeNode tnTemp = clsCommForWebForm.GetNodeFromTreeViewByID(tvQxPrjMenus.Nodes[0], txtCurrNodeId.Value);
            tnTemp.Select();
        }

		private void Button1_Click(object sender, System.EventArgs e)
		{
            TreeNode tnTemp = clsCommForWebForm.GetNodeFromTreeViewByID(tvQxPrjMenus.Nodes[0], txtCurrNodeId.Value);
            tnTemp.Select();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			TreeNode tnSelectedNode = tvQxPrjMenus.SelectedNode;
            txtCurrNodeId.Value = clsCommForWebForm.getNodeID_S(tnSelectedNode);
		}

		protected void ddlPrj_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
			//1、为下拉框设置数据源，绑定列表数据
			wucQxPrjMenus1.SetDdl_QxPrjId();
            string strUserPrjId = ddlPrj.SelectedValue;
            string strDefaultMenuSetId = clsQxPrjMenuSetBLEx.GetDefaultMenuSetIdByPrjId(strUserPrjId);

            wucQxPrjMenus1.SetDdl_LevelMenuId(strDefaultMenuSetId);
			wucQxPrjMenus1.QxPrjId = this.ddlPrj.SelectedValue;
            getUserPrjId = this.ddlPrj.SelectedValue;
			//2、显示无条件的表内容在DATAGRID中
			BindDg_QxPrjMenus();
			//3、设置表控件中字控件的ReadOnly属性，
			///   使之只读，因为在修改功能中关键字是不能被修改的。
			wucQxPrjMenus1.SetKeyReadOnly(true);
			ShowMenuTree();
		}

		protected void lbReNewOrderNum_Click(object sender, System.EventArgs e)
		{
			new clsSpecSQLforSql().ExecSql("EXEC ReNumberForPrjMenu '"+this.ddlPrj.SelectedValue+"'");
		}

        private ArrayList getCheckedMenusNode()
        {
            ArrayList arrLst = new ArrayList();
            getCheckedMenusName(tvQxPrjMenus.Nodes[0], arrLst);
            return arrLst;
        }
        private void getCheckedMenusName(TreeNode tnTemp, ArrayList arrLst)
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
        private string getFirstCheckedMenuId(TreeNode tnTemp)
        {
            string strKeyId = clsCommForWebForm.getNodeID_S(tnTemp);
            if (tnTemp.Checked == true)
            {
                return strKeyId;
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                strKeyId = getFirstCheckedMenuId(tn);
                if (string.IsNullOrEmpty(strKeyId) == false)
                {
                    return strKeyId;
                }
            }
            return "";
        }
        ///生成错误信息的Session属性
        protected string ErrMessage
        {
            get
            {
                string strErrMessage;
                strErrMessage = (string)Session["ErrMessage"];
                if (strErrMessage == null)
                {
                    strErrMessage = "";
                }
                return strErrMessage;
            }
            set
            {
                string strErrMessage = value;
                Session.Add("ErrMessage", strErrMessage);
            }
        }


        ///生成返回链接串的Session属性
        protected string BackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
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