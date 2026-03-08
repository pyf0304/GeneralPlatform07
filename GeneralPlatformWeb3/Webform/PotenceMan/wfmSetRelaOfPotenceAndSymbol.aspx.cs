///生成查询，修改，删除，添加记录的控制层代码

///生成控制层的控件变量名列表
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
using SpecData;
//using CommFunc4WebForm;
using GeneralPlatform;
using com.taishsoft.common;
using System.Text;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using CommFunc4WebForm;
using System.Collections.Generic;
using com.taishsoft.commdb;
using com.taishsoft.datetime;


using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmSetRelaOfPotenceAndSymbol 的摘要说明。
    /// </summary>
    public partial class wfmSetRelaOfPotenceAndSymbol : System.Web.UI.Page
    {

        ///生成有关的变量定义代码
        private const string ViewId4Potence = "00010404";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                vsViewName = "权限、标志关系维护";
                vsTabName = "vRelaOfPotenceAndSymbol";
                this.Table2.Visible = false;
                ///生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (strPotenceLevel)
                {
                    case "0":
                        //Response.Redirect("../error.aspx");
                        break;
                    case "1":

                        break;

                    case "2":

                        this.ddlPrjId_q.Enabled = false;
                        wucRelaOfPotenceAndSymbol1.SetPrj_NotEnable();

                        break;

                    case "3":
                        Response.Redirect("../error.aspx");
                        break;
                    case "4":
                        Response.Redirect("../error.aspx");
                        break;
                    case "9":
                        break;
                    default:
                        Response.Redirect("../error.aspx");
                        break;
                }

                //1、为下拉框设置数据源，绑定列表数据
                wucRelaOfPotenceAndSymbol1.SetDdl_QxPrjId();
                wucRelaOfPotenceAndSymbol1.QxPrjId = getUserPrjId;
                wucRelaOfPotenceAndSymbol1.SetDdl_PotenceTypeId(getUserPrjId);


                clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId_q);
                this.ddlPrjId_q.SelectedValue = getUserPrjId;
                clsQxPotenceTypeBLEx.BindDdl_PotenceTypeIdEx(ddlPotenceTypeId, getUserPrjId);

                //BindDdl_PotenceId(ddlPotenceId_q);
                //2、显示无条件的表内容在DATAGRID中
                BindDg_QxRelaOfPotenceAndSymbol();
                //3、设置表控件中字控件的ReadOnly属性，
                ///   使之只读，因为在修改功能中关键字是不能被修改的。
                ///   

                strSortRelaOfPotenceAndSymbolBy = "PotenceId Asc";


            }
        }
        /// <summary>
        /// 当前操作的界面功能名称
        /// </summary>
        protected string vsViewName
        {
            get
            {
                string sViewName;
                sViewName = (string)ViewState["ViewName"];
                if (sViewName == null)
                {
                    sViewName = "";
                }
                return sViewName;
            }
            set
            {
                string sViewName = value;
                ViewState.Add("ViewName", sViewName);
            }
        }
        /// <summary>
        /// 当前操作的导出表名称
        /// </summary>
        protected string vsTabName
        {
            get
            {
                string sTabName;
                sTabName = (string)ViewState["TabName"];
                if (sTabName == null)
                {
                    sTabName = "";
                }
                return sTabName;
            }
            set
            {
                string sTabName = value;
                ViewState.Add("TabName", sTabName);
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
            this.dgRelaOfPotenceAndSymbol.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgRelaOfPotenceAndSymbol_ItemCreated);
            this.dgRelaOfPotenceAndSymbol.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgRelaOfPotenceAndSymbol_ItemCommand);
            this.dgRelaOfPotenceAndSymbol.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgRelaOfPotenceAndSymbol_PageIndexChanged);
            this.dgRelaOfPotenceAndSymbol.SortCommand += new System.Web.UI.WebControls.DataGridSortCommandEventHandler(this.dgRelaOfPotenceAndSymbol_SortCommand);

        }
        #endregion



        ///生成权限等级的属性
        private string strPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    sPotenceLevel = new MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    //sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }


        ///生成登录用户的用户名Session
        private string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
            }
        }
        ///private clsQxUsersEN objUser
        ///{
        ///get
        ///{
        ///clsQxUsersEN pobjUser;
        ///pobjUser = (clsQxUsersEN)Session["objUser"];
        ///if (pobjUser==null) 
        ///{
        ///pobjUser = null;
        ///}
        ///return pobjUser;
        ///}
        ///set
        ///{
        ///clsQxUsersEN pobjUser = value;
        ///Session.Add("objUser", pobjUser);
        ///}
        ///}


        ///生成专门用于BINDDG中的跳页相关代码

        ///生成组合查询条件的代码
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineRelaOfPotenceAndSymbolCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.ddlPotenceTypeId.SelectedValue != "" && this.ddlPotenceTypeId.SelectedValue != "0")
            {
                strWhereCond += " And PotenceTypeId='" + this.ddlPotenceTypeId.SelectedValue + "'";
            }
            if (this.ddlPotenceId_q.SelectedValue != "" && this.ddlPotenceId_q.SelectedValue != "0")
            {
                strWhereCond += " And PotenceId='" + this.ddlPotenceId_q.SelectedValue + "'";
            }

            if (this.txtSymbolForProgramme_q.Text.Trim() != "")
            {
                strWhereCond += " And SymbolForProgramme like '%" + this.txtSymbolForProgramme_q.Text.Trim() + "%'";
            }
            if (this.txtSymbolName_q.Text.Trim() != "")
            {
                strWhereCond += " And SymbolName like '%" + this.txtSymbolName_q.Text.Trim() + "%'";
            }
            if (this.txtMemo_q.Text.Trim() != "")
            {
                strWhereCond += " And Memo like '%" + this.txtMemo_q.Text.Trim() + "%'";
            }
            if (this.ddlPrjId_q.SelectedValue != "" && this.ddlPrjId_q.SelectedValue != "0")
            {
                strWhereCond += " And QxPrjId='" + this.ddlPrjId_q.SelectedValue + "'";
            }
            if (this.txtRelaMid_q.Text.Trim() != "")
            {
                strWhereCond += " And RelaMid='" + this.txtRelaMid_q.Text.Trim() + "'";
            }
            return strWhereCond;
        }
        ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        private void BindDg_QxRelaOfPotenceAndSymbol()
        {
            //操作步骤：(共5步)
            //1、组合界面条件串；
            //2、根据条件串获取该表满足条件的DataTable；
            //3、判别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //4、设置DATAGRID的数据源(DataSource)；
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            ///	6、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。

            //1、组合界面条件串；
            string strWhereCond = CombineRelaOfPotenceAndSymbolCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsvQxRelaOfPotenceAndSymbolBL.GetDataTable(strWhereCond);
            //3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            ///		3.1 首先计算页数；
            ///		3.2 如果当前页大于页数就为最后一页
            int intPages = CalcPages(objDT.Rows.Count, this.dgRelaOfPotenceAndSymbol.PageSize);
            if (intPages == 0)
            {
                this.dgRelaOfPotenceAndSymbol.CurrentPageIndex = 0;
            }
            else if (this.dgRelaOfPotenceAndSymbol.CurrentPageIndex > intPages - 1)
            {
                this.dgRelaOfPotenceAndSymbol.CurrentPageIndex = intPages - 1;
            }
            //4、设置DATAGRID的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortRelaOfPotenceAndSymbolBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            this.dgRelaOfPotenceAndSymbol.DataSource = objDV;
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.dgRelaOfPotenceAndSymbol.DataBind();

            ///生成专门用于BINDDG中的跳页相关代码
            //当前记录数
            this.lblRelaOfPotenceAndSymbolRecCount.Text = objDT.Rows.Count.ToString();
            //当前页数
            this.lblRelaOfPotenceAndSymbolAllPages.Text = this.dgRelaOfPotenceAndSymbol.PageCount.ToString();
            //当前页序数
            this.lblRelaOfPotenceAndSymbolCurrentPage.Text = (this.dgRelaOfPotenceAndSymbol.CurrentPageIndex + 1).ToString();
            //当前即将跳到的页序数
            this.txtRelaOfPotenceAndSymbolJump2Page.Text = (this.dgRelaOfPotenceAndSymbol.CurrentPageIndex + 1).ToString();
            //如果当前页序数为0，则<前一页>按钮无效
            if (this.dgRelaOfPotenceAndSymbol.CurrentPageIndex == 0)
            {
                this.btnRelaOfPotenceAndSymbolPrevPage.Enabled = false;
            }
            else
            {
                this.btnRelaOfPotenceAndSymbolPrevPage.Enabled = true;
            }
            //如果当前页序数已为最后一页，则<前一页>按钮无效
            if (this.dgRelaOfPotenceAndSymbol.CurrentPageIndex == this.dgRelaOfPotenceAndSymbol.PageCount - 1)
            {
                this.btnRelaOfPotenceAndSymbolNextPage.Enabled = false;
            }
            else
            {
                this.btnRelaOfPotenceAndSymbolNextPage.Enabled = true;
            }
            //7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
            if (objDT.Rows.Count > 0)
            {
                this.tabRelaOfPotenceAndSymbolJumpPage.Visible = true;
            }
            else
            {
                this.tabRelaOfPotenceAndSymbolJumpPage.Visible = false;
            }
        }

        /// <summary>
        /// 功能：计算DataGrid的页数
        /// </summary>
        /// <param name="intRecCount">总共的记录数</param>
        /// <param name="intPageSize">每页的记录数</param>
        /// <returns>计算出来的页数</returns>
        private int CalcPages(int intRecCount, int intPageSize)
        {
            int intPages;
            intPages = intRecCount / intPageSize;
            if (intRecCount % intPageSize != 0) intPages++;
            return intPages;
        }

        /// <summary>
        /// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            ///把DATAGRID的当前页索引设置为0，即第1页。
            ///当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.dgRelaOfPotenceAndSymbol.CurrentPageIndex = 0;
            ///把表记录的内容显示在DATAGRID中
            BindDg_QxRelaOfPotenceAndSymbol();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void dgRelaOfPotenceAndSymbol_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.dgRelaOfPotenceAndSymbol.CurrentPageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindDg_QxRelaOfPotenceAndSymbol();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="lngRelaMid">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(long lngRelaMid)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngRelaMid == 0) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsQxRelaOfPotenceAndSymbolBL.IsExist(lngRelaMid) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + lngRelaMid + "的不存在!";
                Response.Write("<script>alert('" + ss + "')</script>");
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol = new clsQxRelaOfPotenceAndSymbolEN(lngRelaMid);
            //4、获取类对象的所有属性；
            clsQxRelaOfPotenceAndSymbolBL.GetQxRelaOfPotenceAndSymbol(ref objRelaOfPotenceAndSymbol);
            Session.Add("objRelaOfPotenceAndSymbol", objRelaOfPotenceAndSymbol);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromRelaOfPotenceAndSymbolClass(objRelaOfPotenceAndSymbol);
        }
        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjRelaOfPotenceAndSymbol">表实体类对象</param>
        private void GetDataFromRelaOfPotenceAndSymbolClass(clsQxRelaOfPotenceAndSymbolEN pobjRelaOfPotenceAndSymbol)
        {
            wucRelaOfPotenceAndSymbol1.PotenceId = pobjRelaOfPotenceAndSymbol.PotenceId;
            wucRelaOfPotenceAndSymbol1.SymbolForProgramme = pobjRelaOfPotenceAndSymbol.SymbolForProgramme;
            wucRelaOfPotenceAndSymbol1.SymbolName = pobjRelaOfPotenceAndSymbol.SymbolName;
            wucRelaOfPotenceAndSymbol1.Memo = pobjRelaOfPotenceAndSymbol.Memo;
            wucRelaOfPotenceAndSymbol1.QxPrjId = pobjRelaOfPotenceAndSymbol.QxPrjId;

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
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            string strCommandText;
            clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":

                    btnOKUpd.Text = "确认添加";
                    //wucRelaOfPotenceAndSymbol1.RelaMid = clsCommForWebForm.G1etMaxStrId("RelaOfPotenceAndSymbol","RelaMid", 8, "");
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
                    if (!wucRelaOfPotenceAndSymbol1.IsValid())
                    {
                        lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、定义对象并初始化对象
                    objRelaOfPotenceAndSymbol = new clsQxRelaOfPotenceAndSymbolEN();	//定义对象

                    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                    //					if (objRelaOfPotenceAndSymbol.IsExist())	//判断是否有相同的关键字
                    //					{
                    //						strMsg = "关键字字段已有相同的值";
                    //						Response.Write("<script>alert('" + strMsg + "')</script>");
                    //						return;
                    //					}
                    //4、把值从界面层传到逻辑层或数据实体层
                    PutDataToRelaOfPotenceAndSymbolClass(objRelaOfPotenceAndSymbol);		//把界面的值传到
                    //5、检查传进去的对象属性是否合法


                    try
                    {
                        clsQxRelaOfPotenceAndSymbolBL.CheckPropertyNew(objRelaOfPotenceAndSymbol);
                    }
                    catch (Exception objException)
                    {
                        Response.Write("<script>alert('" + strResult + "')</script>");
                        return;
                    }
                    //6、把数据实体层的数据存贮到数据库中
                    if (clsQxRelaOfPotenceAndSymbolBL.AddNewRecordBySql2(objRelaOfPotenceAndSymbol) == false)
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
                    BindDg_QxRelaOfPotenceAndSymbol();
                    wucRelaOfPotenceAndSymbol1.Clear();		//清空控件中内容
                    ///恢复<确认添加>变成<添加>
                    btnOKUpd.Text = "添加";
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
                    if (!wucRelaOfPotenceAndSymbol1.IsValid())
                    {
                        lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、把值从界面层传到逻辑层或数据实体层
                    objRelaOfPotenceAndSymbol = (clsQxRelaOfPotenceAndSymbolEN)Session["objRelaOfPotenceAndSymbol"];
                    PutDataToRelaOfPotenceAndSymbolClass(objRelaOfPotenceAndSymbol);		//把界面的值传到
                    //3、检查传进去的对象属性是否合法


                    try
                    {
                        clsQxRelaOfPotenceAndSymbolBL.CheckPropertyNew(objRelaOfPotenceAndSymbol);
                    }
                    catch (Exception objException)
                    {
                        Response.Write("<script>alert('" + strResult + "')</script>");
                        return;
                    }

                    //4、把数据实体层的数据修改同步到数据库中
                    if (clsQxRelaOfPotenceAndSymbolBL.UpdateBySql2(objRelaOfPotenceAndSymbol) == false)
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
                    BindDg_QxRelaOfPotenceAndSymbol();
                    wucRelaOfPotenceAndSymbol1.Clear();//添空控件中的内容
                    ///恢复<确认修改>变成<添加>
                    btnOKUpd.Text = "添加";
                    break;
            }
        }
        ///生成从界面层到逻辑层的数据传输函数代码
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjRelaOfPotenceAndSymbol">数据传输的目的类对象</param>
        private void PutDataToRelaOfPotenceAndSymbolClass(clsQxRelaOfPotenceAndSymbolEN pobjRelaOfPotenceAndSymbol)
        {
            pobjRelaOfPotenceAndSymbol.PotenceId = wucRelaOfPotenceAndSymbol1.PotenceId;
            pobjRelaOfPotenceAndSymbol.SymbolForProgramme = wucRelaOfPotenceAndSymbol1.SymbolForProgramme;
            pobjRelaOfPotenceAndSymbol.SymbolName = wucRelaOfPotenceAndSymbol1.SymbolName;
            pobjRelaOfPotenceAndSymbol.Memo = wucRelaOfPotenceAndSymbol1.Memo;
            pobjRelaOfPotenceAndSymbol.QxPrjId = wucRelaOfPotenceAndSymbol1.QxPrjId;
            pobjRelaOfPotenceAndSymbol.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            pobjRelaOfPotenceAndSymbol.UpdUserId = clsCommonSession.UserId;


        }

        private void dgRelaOfPotenceAndSymbol_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
                myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Item.ItemIndex + 1).ToString() + " 行吗？');");
            }
            int intIndex;
            if (strSortRelaOfPotenceAndSymbolBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.dgRelaOfPotenceAndSymbol.Columns.Count; i++)
                {
                    strSortEx = this.dgRelaOfPotenceAndSymbol.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortRelaOfPotenceAndSymbolBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortRelaOfPotenceAndSymbolBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序，而且为string型；
                        e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        private void dgRelaOfPotenceAndSymbol_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            long lngRelaMid;
            string strCommandName;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                lngRelaMid = long.Parse(e.Item.Cells[0].Text);
                switch (strCommandName)
                {
                    case "Delete":
                        clsQxRelaOfPotenceAndSymbolBL.DelRecord(lngRelaMid);
                        BindDg_QxRelaOfPotenceAndSymbol();
                        break;
                    // Add other cases here, if there are multiple ButtonColumns in 
                    // the DataGrid control.
                    case "Update":
                        //操作步骤：（总共2步）
                        //1、显示该关键字记录的内容在界面上；
                        //2、清空提示信息的内容,同时使<确定修改>按钮可用；

                        //1、显示该关键字记录的内容在界面上；
                        ShowData(lngRelaMid);
                        //2、清空提示信息的内容,同时使<确定修改>按钮可用；
                        btnOKUpd.Enabled = true;

                        btnOKUpd.Text = "确认修改";
                        lblMsg.Text = "";
                        break;

                    default:
                        // Do nothing.
                        break;
                }
            }
            if (e.Item.ItemType == ListItemType.Header)
            {
                System.Web.UI.WebControls.LinkButton lbSelAll;
                lbSelAll = (LinkButton)e.CommandSource;
                if (lbSelAll.CommandName != "lbSelAll")
                {
                    return;
                }
                if (lbSelAll.Text == "全选")
                {
                    clsCommForWebForm.Set_AllDgCkecked(dgRelaOfPotenceAndSymbol, true);
                    lbSelAll.Text = "不选";
                }
                else if (lbSelAll.Text == "不选")
                {
                    clsCommForWebForm.Set_AllDgCkecked(dgRelaOfPotenceAndSymbol, false);
                    lbSelAll.Text = "全选";
                }
            }
        }
        ///生成从界面层到逻辑层的数据传输函数代码
        public System.Data.DataTable GetPotenceId(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = "select PotenceId, PotenceName from PrjPotence where QxPrjId ='" + strPrjId + "'";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_PotenceId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPotenceId(this.ddlPrjId_q.SelectedValue);
            objDDL.DataValueField = "PotenceId";
            objDDL.DataTextField = "PotenceName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
     
        ///生成组合查询条件的代码
        private void dgRelaOfPotenceAndSymbol_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            ///判断是否是新的排序字段
            intIndex = strSortRelaOfPotenceAndSymbolBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortRelaOfPotenceAndSymbolBy = e.SortExpression + " Asc";
                BindDg_QxRelaOfPotenceAndSymbol();
                return;
            }
            ///检查原来是升序
            intIndex = strSortRelaOfPotenceAndSymbolBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortRelaOfPotenceAndSymbolBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortRelaOfPotenceAndSymbolBy = e.SortExpression + " Desc";
            }
            BindDg_QxRelaOfPotenceAndSymbol();
        }

        private string strSortRelaOfPotenceAndSymbolBy
        {
            get
            {
                string sSortRelaOfPotenceAndSymbolBy;
                sSortRelaOfPotenceAndSymbolBy = (string)ViewState["SortRelaOfPotenceAndSymbolBy"];
                if (sSortRelaOfPotenceAndSymbolBy == null)
                {
                    sSortRelaOfPotenceAndSymbolBy = "";
                }
                return sSortRelaOfPotenceAndSymbolBy;
            }
            set
            {
                string sSortRelaOfPotenceAndSymbolBy = value;
                ViewState.Add("SortRelaOfPotenceAndSymbolBy", sSortRelaOfPotenceAndSymbolBy);
            }
        }

        ///生成父对象的SESSION相关属性函数
        protected void btnRelaOfPotenceAndSymbolPrevPage_Click(object sender, System.EventArgs e)
        {
            this.dgRelaOfPotenceAndSymbol.CurrentPageIndex -= 1;
            this.BindDg_QxRelaOfPotenceAndSymbol();
        }

        protected void btnRelaOfPotenceAndSymbolNextPage_Click(object sender, System.EventArgs e)
        {
            this.dgRelaOfPotenceAndSymbol.CurrentPageIndex += 1;
            this.BindDg_QxRelaOfPotenceAndSymbol();
        }

        protected void btnRelaOfPotenceAndSymbolJumpPage_Click(object sender, System.EventArgs e)
        {
            if (this.txtRelaOfPotenceAndSymbolJump2Page.Text.Trim() != "" &&
                int.Parse(this.txtRelaOfPotenceAndSymbolJump2Page.Text) > 0 &&
                int.Parse(this.txtRelaOfPotenceAndSymbolJump2Page.Text) - 1 < this.dgRelaOfPotenceAndSymbol.PageCount)
            {
                this.dgRelaOfPotenceAndSymbol.CurrentPageIndex = int.Parse(this.txtRelaOfPotenceAndSymbolJump2Page.Text) - 1;
            }
            this.BindDg_QxRelaOfPotenceAndSymbol();
        }

        protected void ddlPrjId_q_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.BindDdl_PotenceId(this.ddlPotenceId_q);
        }

        protected void ddlPotenceTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPotenceTypeId.SelectedIndex > 0)
            {
                string strPotenceTypeId = ddlPotenceTypeId.SelectedValue.ToString();
                clsDropDownList.BindDdl_PotenceIdByType(ddlPotenceId_q, strPotenceTypeId);
            }

        }

        protected void btnSetExportExcel4User_Click(object sender, EventArgs e)
        {
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName='{0}'", vsViewName);
            sbCondition.AppendFormat(" And TabName='{0}'", vsTabName);
            sbCondition.AppendFormat(" And UserId='{0}'", clsCommonSession.UserId);
            string strIdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
            if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在系统中没有界面为'{0}'", vsViewName);
                sbMsg.AppendFormat("，表名='{0}'", vsTabName);
                sbMsg.AppendFormat("并且用户='{0}'的导出Excel用户设置，请与管理员联系！({1})", 
                    clsCommonSession.UserId,
                    clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                return;
            }

            StringBuilder sbScript = new StringBuilder();

            sbScript.Append("<script language='javascript'>");
            sbScript.Append("window.open('");
            sbScript.AppendFormat("../SystemSet/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users={0}", strIdExportExcel4Users);
            sbScript.Append("','_blank', 'left=50px,top=50px,status=no,width=920px,height=650px,scrollbars=yes'); </script>");

            Response.Write(sbScript.ToString());

        }

      

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //1、组合界面条件串；
            string strWhereCond = CombineRelaOfPotenceAndSymbolCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "QxRoleMenus信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convQxRelaOfPotenceAndSymbol.QxPrjId); arrCnName.Add("项目编号");
            arrColName.Add(convQxRelaOfPotenceAndSymbol.PrjName); arrCnName.Add("工程名");

            
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = vsViewName;
            objExportExcelSetENEx.TabName = vsTabName;
            objExportExcelSetENEx.ExportFileName = strFileName;
            objExportExcelSetENEx.UserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);
            objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4AgcCs;
            objExportExcelSetENEx.arrCnName = arrCnName;
            objExportExcelSetENEx.arrColName = arrColName;
            try
            {
                clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx, new clsTranslateFieldName());
                strFileName = objExportExcelSetENEx.ExportFileName;
                arrCnName = objExportExcelSetENEx.arrCnName;
                arrColName = objExportExcelSetENEx.arrColName;
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }

            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                ///	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvQxRelaOfPotenceAndSymbolBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);

            //strFolderName = clsSysParaEN.TempFileFolder;
            //strDownLoadFileName = strFolderName + strFileName;
            //try
            //{
            //    //2、根据条件串获取该表满足条件的DataTable；
            //    objDT = clsQxRoleMenusBL.GetDataTable_QxRoleMenusV(strWhereCond);
            //    GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            //}
            //catch (Exception objException)
            //{
            //    ErrMessage = objException.Message;
            //    BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            //    Response.Redirect(clsSysParaEN.ErrorPage);
            //}
            //clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }


        /// <summary>
        /// 错误信息的Session属性，该Session传递给显示出错页面，显示相应的错误内容。
        /// </summary>
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



        /// <summary>
        /// 返回链接串的Session属性，该Session用于告诉出错页面，哪一个页面是需要返回的页面。
        /// </summary>
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

        protected void btnExportExcel4Dg_Click(object sender, EventArgs e)
        {
    //导出Excel函数
            ExportExcel();
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

        protected void btnBatchSetSymbol_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromDg2(dgRelaOfPotenceAndSymbol, "chkCheckRec");
            if (lstKeyValues.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            if (string.IsNullOrEmpty(txtSymbolName.Text) == true)
            {
                lblMsg.Text = "请输入标志名!";
                txtSymbolName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSymbolForProgramme.Text) == true)
            {
                lblMsg.Text = "请输入标志!";
                txtSymbolForProgramme.Focus();
                return;
            }
            string strSymbolName = txtSymbolName.Text;
            string strSymbolForProgramme = txtSymbolForProgramme.Text;
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    long lngRelaMid = long.Parse(strKeys[0]);
                    clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN =
                    clsQxRelaOfPotenceAndSymbolBL.GetObjByRelaMid(lngRelaMid);
                    clsQxRelaOfPotenceAndSymbolEN pobjRelaOfPotenceAndSymbolEN = new clsQxRelaOfPotenceAndSymbolEN();
                    pobjRelaOfPotenceAndSymbolEN.PotenceId = objQxRelaOfPotenceAndSymbolEN.PotenceId;//    权限ID
                    pobjRelaOfPotenceAndSymbolEN.SymbolForProgramme = strSymbolForProgramme;//    编程标志
                    pobjRelaOfPotenceAndSymbolEN.SymbolName = strSymbolName;//    标志名称
                    pobjRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);//    修改日期
                    pobjRelaOfPotenceAndSymbolEN.UpdUserId = clsCommonSession.UserId;//    修改用户Id
                    pobjRelaOfPotenceAndSymbolEN.QxPrjId = getUserPrjId;//    项目Id
                    pobjRelaOfPotenceAndSymbolEN.Memo = "批量添加";//    备注
                    try
                    {
                        clsQxRelaOfPotenceAndSymbolBL.AddNewRecordBySql2(pobjRelaOfPotenceAndSymbolEN);
                    }
                    catch(Exception objException)
                    {

                    }
                }
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindDg_QxRelaOfPotenceAndSymbol();
        }
    }
}
