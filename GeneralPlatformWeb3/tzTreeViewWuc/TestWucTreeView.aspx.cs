using com.taishsoft.web.treeview;
using CommFunc4WebForm;
using GeneralPlatform.Entity;
using GeneralPlatform.web.treeview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MSWeb.Webform
{
    public partial class TestWucTreeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //   BindTv_QxUsers();

                // BindTv_QxPrjMenuUp_Sub();
                BindTv_QxPrjMenuUp_Sub_Leaf();
                //  mnuTopMenu.Items.Add(objMI);
            }

        }
        private void BindTv_QxUsers()
        {
            wucTreeView1.tmTreeModel = TreeModel.QxUsers;
            wucTreeView1.BindTv();
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }
        private void BindTv_QxPrjMenuUp_Sub()
        {
            wucTreeView1.tmTreeModel = TreeModel.QxPrjMenuUp_Sub;
            wucTreeView1.QxPrjId = "0062";
            wucTreeView1.BindTv();
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }
        private void BindTv_QxPrjMenuUp_Sub_Leaf()
        {
            wucTreeView1.tmTreeModel = TreeModel.QxPrjMenuUp_Sub_Leaf;
            wucTreeView1.QxPrjId = "0062";
            wucTreeView1.BindTv();
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }
        private void BindTv_QxPrjMenuSet_QxPrjMenuUp_Sub()
        {
            wucTreeView1.tmTreeModel = TreeModel.QxPrjMenuSet_QxPrjMenuUp_Sub;
            wucTreeView1.QxPrjId = "0062";
            wucTreeView1.ShowCheckBox = true;
            wucTreeView1.BindTv();
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }
        protected void wucTreeView1_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strKeyId);

            //throw new NotImplementedException();
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

        protected void wucTreeView1_afterSelect_Tz1()
        {

        }

        protected void btnSelectNode_Click(object sender, EventArgs e)
        {
            string strKeyId = txtKeyId2.Text;
            wucTreeView1.SelectNodeEx(strKeyId);
        }

        protected void btnExpandNode_Click(object sender, EventArgs e)
        {
            string strKeyId = txtKeyId_Sel.Text;
            wucTreeView1.Expand(strKeyId);
        }

        protected void btnTestStruct_Click(object sender, EventArgs e)
        {
            TreeNodeData objNodeData = new TreeNodeData();
            objNodeData.SS = "111";
            objNodeData.TT = 222;
            //objNodeData = new NodeData();
            StringBuilder sbMsg = new StringBuilder();
            Type type = typeof(TreeNodeData);
            FieldInfo[] fileds = type.GetFields();
            foreach (FieldInfo f in fileds)
            {
                sbMsg.AppendFormat("{0}:{1}", f.Name, f.Name);
                Console.WriteLine(f.Name);//id name
            }
            Object strTT = wucTreeView1.GetPropertyValue(objNodeData, "TT");

            wucTreeView1.InitPropertyValue4Obj(objNodeData);
            lblMsg.Text = string.Format("SS:{0}, TT:{1}", objNodeData.SS, strTT);
        }
        //public string GetVal(object obj, string name)
        //{
        //    Type type = obj.GetType();
        //    PropertyInfo[] pros = type.GetProperties();
        //    foreach (PropertyInfo p in pros)
        //    {
        //        Console.WriteLine(p.GetValue(obj, null));
        //    }
        //    PropertyInfo objP = type.GetProperty(name);
        //    return objP.GetValue(obj, null).ToString();
        //}

        protected void btnGetPropNameLst_Click(object sender, EventArgs e)
        {
            TreeNodeData objNodeData = new TreeNodeData();
            objNodeData.SS = "111";
            objNodeData.TT = 222;
            //objNodeData = new NodeData();
            StringBuilder sbMsg = new StringBuilder();
            Type type = typeof(TreeNodeData);
            FieldInfo[] fileds = type.GetFields();
            foreach (FieldInfo f in fileds)
            {
                sbMsg.AppendFormat("{0}:{1}", f.Name, f.Name);
                Console.WriteLine(f.Name);//id name
            }
            List<string> arrPropName = wucTreeView1.GetPropertyNameLst4Obj(objNodeData);
            ListBox1.Items.Clear();
            foreach (string strPropName in arrPropName)
            {
                ListBox1.Items.Add(strPropName);
            }

        }

        protected void btnGetAllPropNameValue_Click(object sender, EventArgs e)
        {
            TreeNodeData objNodeData = new TreeNodeData();
            objNodeData.SS = "111";
            objNodeData.TT = 222;
            //objNodeData = new NodeData();
            StringBuilder sbMsg = new StringBuilder();
            Type type = typeof(TreeNodeData);
            FieldInfo[] fileds = type.GetFields();
            foreach (FieldInfo f in fileds)
            {
                sbMsg.AppendFormat("{0}:{1}", f.Name, f.Name);
                Console.WriteLine(f.Name);//id name
            }
            List<string> arrPropName = wucTreeView1.GetPropertyNameLst4Obj(objNodeData);
            ListBox1.Items.Clear();
            foreach (string strPropName in arrPropName)
            {
                Object objValue = wucTreeView1.GetPropertyValue(objNodeData, strPropName);
                string strMsg = string.Format("Key:{0}, Value:{1}", strPropName, objValue);
                ListBox1.Items.Add(strMsg);
            }

        }

        protected void btnGetAllCheckedNodeValueLst_Click(object sender, EventArgs e)
        {
            List<string> arrCheckedValue = wucTreeView1.GetCheckedNodeKeyIdLst();
            ListBox1.Items.Clear();
            foreach (string strValue in arrCheckedValue)
            {
                //Object objValue = wucTreeView1.GetPropertyValue(objNodeData, strPropName);
                //string strMsg = string.Format("Key:{0}, Value:{1}", strPropName, objValue);
                ListBox1.Items.Add(strValue);
            }
        }

        protected void btnBindTv_Click(object sender, EventArgs e)
        {
            BindTv_QxPrjMenuUp_Sub();
        }

        protected void btnGetCurrNodeValuePath_Click(object sender, EventArgs e)
        {
            string strValuePath = wucTreeView1.GetCurrPathNodeKeyId();
            List<string> arrValuePath = wucTreeView1.GetCurrPathNodeKeyIdLst();
            List<string> arrNodeTypePath = wucTreeView1.GetCurrPathNodeTypeLst();
            ListBox1.Items.Clear();
            ListBox1.Items.Add(strValuePath);
            int intLen = arrValuePath.Count;
            for (int i = 0; i<intLen; i++)
            {
                string strValue = arrValuePath[i];
                
                string strNodeType = arrNodeTypePath[i];
                string strMsg = string.Format("NodeType:{0}, Value:{1}", strNodeType, strValue);
                ListBox1.Items.Add(strMsg);       
            }
        }

        protected void btnGetAllCheckedPathNodeValueLst_Click(object sender, EventArgs e)
        {
            List<string> arrCheckedValue = wucTreeView1.GetCheckedPathNodeKeyIdLst();
            ListBox1.Items.Clear();
            foreach (string strValue in arrCheckedValue)
            {
                //Object objValue = wucTreeView1.GetPropertyValue(objNodeData, strPropName);
                //string strMsg = string.Format("Key:{0}, Value:{1}", strPropName, objValue);
                ListBox1.Items.Add(strValue);
            }
        }

        protected void btnGetCurrNodeRelaValue_Click(object sender, EventArgs e)
        {
            string strMenuIdSub = wucTreeView1.NodeData.MenuIdSub;
            string strMenuIdUp = wucTreeView1.NodeData.MenuIdUp;
            string strMenuIdLeaf = wucTreeView1.NodeData.MenuIdLeaf;
            string strMsg = string.Format("当前结点类型:{0}, 顶:{1}， 子:{2}, 叶:{3}",
                wucTreeView1.CurrNodeType,
                strMenuIdUp, strMenuIdSub, strMenuIdLeaf);
            lblMsg2.Text = strMsg;

        }
    }
}