
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucQxServer4SynchB
界面名:wfmQxServer4Synch_QUDI(00140027)
生成代码版本:2019.03.21.1
生成日期:2019/03/21 14:53:37
生成者:
工程名称:统一平台
工程ID:0014
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:Web用户控件后台代码(WebCtlControlCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
//生成与表相关的控件控制层代码
namespace GeneralPlatform.Webform
{
    using System;
    using System.Data;
    using System.Configuration;
    using System.Collections;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.common;
    using com.taishsoft.datetime;
    using com.taishsoft.commdb;
    
    using GeneralPlatform.Entity;
    using GeneralPlatform.BusinessLogic;

    /// <summary>
    ///		wucQxServer4SynchB 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucQxServer4SynchB : System.Web.UI.UserControl
    {
        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 服务器Id
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public string ServerId
        {
            get
            {
                return txtServerId.Text.Trim();
            }
            set
            {
                txtServerId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 服务器名
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public string ServerName
        {
            get
            {
                return txtServerName.Text.Trim();
            }
            set
            {
                txtServerName.Text = value.ToString();
            }
        }

        /// <summary>
        /// IP地址
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public string IpAddress
        {
            get
            {
                return txtIpAddress.Text.Trim();
            }
            set
            {
                txtIpAddress.Text = value.ToString();
            }
        }

        /// <summary>
        /// WApi地址
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public string WebApiAddress
        {
            get
            {
                return txtWebApiAddress.Text.Trim();
            }
            set
            {
                txtWebApiAddress.Text = value.ToString();
            }
        }
        /// <summary>
        /// 是否自己  
        /// </summary>
        public bool IsSelf
        {
            get
            {
                return chkIsSelf.Checked;
            }
            set
            {
                chkIsSelf.Checked = value;
            }
        }
        /// <summary>
        /// 是否在用
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public bool InUse
        {
            get
            {
                return chkInUse.Checked;
            }
            set
            {
                chkInUse.Checked = value;
            }
        }

        /// <summary>
        /// 修改日期
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public string UpdDate
        {
            get
            {
                return clsDateTime.getTodayDateTimeStr(0);
            }
        }

        /// <summary>
        /// 修改用户
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public string UpdUser
        {
            get
            {
                return clsCommonSession.UserId;
            }
        }

        /// <summary>
        /// 备注
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public string Memo
        {
            get
            {
                return txtMemo.Text.Trim();
            }
            set
            {
                txtMemo.Text = value.ToString();
            }
        }


        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtServerId.ReadOnly = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>	
        public void Clear()
        {
            txtServerId.Text = "";
            txtServerName.Text = "";
            txtIpAddress.Text = "";
            txtWebApiAddress.Text = "";
            chkInUse.Checked = false;
            
            txtMemo.Text = "";
        }
        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则:
        ///		1、首先校验类型:整型、浮点型、日期型等,
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值,即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            return true;
        }
        /// <summary>
        /// 设置该控件在插入状态下的缺省值
        /// 一般规则:
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public void SetDefaultValue()
        {
            txtServerId.Text = "";
            txtServerName.Text = "";
            txtIpAddress.Text = "";
            txtWebApiAddress.Text = "";
            chkInUse.Checked = false;
            
            txtMemo.Text = "";
        }
    }
}