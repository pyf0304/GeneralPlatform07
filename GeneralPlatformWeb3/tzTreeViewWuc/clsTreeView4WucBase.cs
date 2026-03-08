using com.taishsoft.common;
using com.taishsoft.util;
using MSWeb.Webform.ATest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace com.taishsoft.web.treeview
{
    public class clsTreeView4WucBase : System.Web.UI.UserControl
    {
        public virtual TreeView objCurrTreeView
        {
            get;
        }
        /// <summary>
        /// 获取给定结点的关键字
        /// </summary>
        /// <param name="objTN">给定结点</param>
        /// <returns>关键字</returns>
        public static string GetCurrKey(TreeNode objTN)
        {
            string strKeyId = "";
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            strKeyId = strArr[1];
            return strKeyId;
        }
        /// <summary>
        /// 获取给定结点中第I个关键字
        /// </summary>
        /// <param name="objTN">给定结点</param>
        /// <param name="intIndex">关键字的序号</param>
        /// <returns>关键字</returns>
		public static string GetCurrKey(TreeNode objTN, int intIndex)
        {
            string strKeyId = "";
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            if (intIndex == 2)
            {
                if (strArr.Length <= 2)
                {
                    return "";
                }
                strKeyId = strArr[3];
            }
            else
            {
                strKeyId = strArr[1];
            }
            return strKeyId;
        }
        /// <summary>
        /// 获取树中当前结点的关键字
        /// </summary>
        /// <param name="objTreeView">给定树</param>
        /// <returns>当前结点的关键字</returns>
        public static string GetCurrKey(TreeView objTreeView)
        {
            string strKeyId = "";
            string strTag = objTreeView.SelectedNode.Value.ToString();
            string[] strArr = strTag.Split(',');
            strKeyId = strArr[1];
            return strKeyId;
        }

        public static string GetCurrKeyTypeName(TreeNode objTN)
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
        public string GetNodeType(TreeNode objTreeNode, int intIndex)
        {

            string strTypeName = "";
            string strTag = objTreeNode.Value.ToString();
            string[] strArr = strTag.Split(',');
            if (intIndex == 2)
            {
                if (strArr.Length <= 2)
                {
                    return "";
                }
                strTypeName = strArr[2];
            }
            else
            {
                strTypeName = strArr[0];
            }
            //T myEnumType = clsEnumHelper.ToEnum(strTypeName, defaultValue);
            //return myEnumType;
            return strTypeName;
            //switch (strTypeName)
            //{
            //    case "Root"://学校
            //        return TreeNodeType.SCHOOL;

            //    case clsXzSchoolEN.CurrTabName_S://)//学校
            //        return TreeNodeType.SCHOOL;

            //    case clsQxUserRolesEN.CurrTabName_S://)//学校
            //        return TreeNodeType.CJSTATSMODE;

            //    case "College":////学院

            //        return TreeNodeType.COLLEGE;
            //    case clsvQxPrjMenus_SubEN.CurrTabName_S://年级(入学)

            //        return TreeNodeType.GRADEBASE;
            //    case clsvQxPrjMenus_UpEN.CurrTabName_S://年级
            //        return TreeNodeType.GRADE;
            //    case clsQxUsersEN.CurrTabName_S://考试批次
            //        return TreeNodeType.EXAMBATCH;

            //    case "Major"://专业
            //        return TreeNodeType.MAJOR;

            //    case clsSubjectDirectionEN.CurrTabName_S://学科方向
            //        return TreeNodeType.SUBJECTDIRECTION;

            //    case "MajorGrade"://专业年级
            //        return TreeNodeType.MAJORGRADE;
            //    case clsXzAdminClsEN.CurrTabName_S://行政班
            //        return TreeNodeType.ADMINCLS;
            //    case clsQxPrjPotenceTypeEN.CurrTabName_S://课程类型

            //        return TreeNodeType.COURSETYPE;
            //    case clsQxPrjPotenceEN.CurrTabName_S://课程
            //        return TreeNodeType.COURSE;

            //    case "CourseTypeAdminType"://课程类型

            //        return TreeNodeType.COURSETYPEADMINTYPE;
            //    case "StudentType": //学生类型
            //        return TreeNodeType.STUDENTTYPE;
            //    case "PKaoExamGroup":   //排考考试组

            //        return TreeNodeType.PKAOEXAMGROUP;
            //    case "UniZone"://校区

            //        return TreeNodeType.UNIZONE;
            //    case "Build"://教学楼

            //        return TreeNodeType.BUILD;
            //    case "TeachPlanTemplete"://教学计划模板

            //        return TreeNodeType.TEACHPLANPlanTEMPLETE;
            //    case "JxTpXxTemplet"://教学计划选修课模板

            //        return TreeNodeType.JXTPXXTEMPLETE;
            //    case clsxkCollectOfClassEN.CurrTabName_S://教学班信息

            //        return TreeNodeType.COLLECT;
            //    case "CurrEduCls"://当前教学班

            //        return TreeNodeType.CURREDUCLASS;
            //    case clsxkEduClsEN.CurrTabName_S://选课教学班

            //        return TreeNodeType.XKEDUCLASS;
            //    case "JxTeachPlanSeries"://教学计划课程系列

            //        return TreeNodeType.JXTEACHPLANSERIES;
            //    case "JxSeriesGroup"://教学计划系列组

            //        return TreeNodeType.JXSERIESGROUP;
            //    case "JxSerGroupReqMode"://教学计划系列组模式

            //        return TreeNodeType.JXSERGROUPREQMODE;
            //    case "JxTeachingPlan"://教学计划

            //        return TreeNodeType.TEACHINGPLAN;
            //    case clsPk2ScheGroupEN.CurrTabName_S://教学计划

            //        return TreeNodeType.PKSCHEGROUP;
            //    case "XlsImportTab"://教学计划

            //        return TreeNodeType.XLSIMPORTTAB;
            //    case "Role":         //角色

            //        return TreeNodeType.ROLE;
            //    case "User":        //角色

            //        return TreeNodeType.USER;
            //    case "RightType":         //角色

            //        return TreeNodeType.RIGHTTYPE;
            //    case "Right":         //角色

            //        return TreeNodeType.RIGHT;
            //    case "Pk2AdminCls":         //角色

            //        return TreeNodeType.ADMINCLS;
            //    case clsQxPotenceTypeEN.CurrTabName_S:         //角色

            //        return TreeNodeType.ADMINCLS;
            //    default:
            //        string strMsg = string.Format("树结点数据类型名:{1}在Switch中没有处理，请检查!({0})",
            //                clsStackTrace.GetCurrClassFunction(), strTypeName);
            //        throw new Exception(strMsg);
            //}
        }

        public T GetNodeType<T>(string strTypeName, T defaultValue = default(T))
        {
            if (string.IsNullOrEmpty(strTypeName) == true)
                return defaultValue;
            T myEnumType = clsEnumHelper.ToEnum(strTypeName, defaultValue);
            return myEnumType;
            //switch (strTypeName)
            //{
            //    case "Root"://学校
            //        return TreeNodeType.SCHOOL;

            //    case clsXzSchoolEN.CurrTabName_S://)//学校
            //        return TreeNodeType.SCHOOL;

            //    case clsQxUserRolesEN.CurrTabName_S://)//学校
            //        return TreeNodeType.CJSTATSMODE;

            //    case "College":////学院

            //        return TreeNodeType.COLLEGE;
            //    case clsvQxPrjMenus_SubEN.CurrTabName_S://年级(入学)

            //        return TreeNodeType.GRADEBASE;
            //    case clsvQxPrjMenus_UpEN.CurrTabName_S://年级
            //        return TreeNodeType.GRADE;
            //    case clsQxUsersEN.CurrTabName_S://考试批次
            //        return TreeNodeType.EXAMBATCH;

            //    case "Major"://专业
            //        return TreeNodeType.MAJOR;

            //    case clsSubjectDirectionEN.CurrTabName_S://学科方向
            //        return TreeNodeType.SUBJECTDIRECTION;

            //    case "MajorGrade"://专业年级
            //        return TreeNodeType.MAJORGRADE;
            //    case clsXzAdminClsEN.CurrTabName_S://行政班
            //        return TreeNodeType.ADMINCLS;
            //    case clsQxPrjPotenceTypeEN.CurrTabName_S://课程类型

            //        return TreeNodeType.COURSETYPE;
            //    case clsQxPrjPotenceEN.CurrTabName_S://课程
            //        return TreeNodeType.COURSE;

            //    case "CourseTypeAdminType"://课程类型

            //        return TreeNodeType.COURSETYPEADMINTYPE;
            //    case "StudentType": //学生类型
            //        return TreeNodeType.STUDENTTYPE;
            //    case "PKaoExamGroup":   //排考考试组

            //        return TreeNodeType.PKAOEXAMGROUP;
            //    case "UniZone"://校区

            //        return TreeNodeType.UNIZONE;
            //    case "Build"://教学楼

            //        return TreeNodeType.BUILD;
            //    case "TeachPlanTemplete"://教学计划模板

            //        return TreeNodeType.TEACHPLANPlanTEMPLETE;
            //    case "JxTpXxTemplet"://教学计划选修课模板

            //        return TreeNodeType.JXTPXXTEMPLETE;
            //    case clsxkCollectOfClassEN.CurrTabName_S://教学班信息

            //        return TreeNodeType.COLLECT;
            //    case "CurrEduCls"://当前教学班

            //        return TreeNodeType.CURREDUCLASS;
            //    case clsxkEduClsEN.CurrTabName_S://选课教学班

            //        return TreeNodeType.XKEDUCLASS;
            //    case "JxTeachPlanSeries"://教学计划课程系列

            //        return TreeNodeType.JXTEACHPLANSERIES;
            //    case "JxSeriesGroup"://教学计划系列组

            //        return TreeNodeType.JXSERIESGROUP;
            //    case "JxSerGroupReqMode"://教学计划系列组模式

            //        return TreeNodeType.JXSERGROUPREQMODE;
            //    case "JxTeachingPlan"://教学计划

            //        return TreeNodeType.TEACHINGPLAN;
            //    case clsPk2ScheGroupEN.CurrTabName_S://教学计划

            //        return TreeNodeType.PKSCHEGROUP;
            //    case "XlsImportTab"://教学计划

            //        return TreeNodeType.XLSIMPORTTAB;
            //    case "Role":         //角色

            //        return TreeNodeType.ROLE;
            //    case "User":        //角色

            //        return TreeNodeType.USER;
            //    case "RightType":         //角色

            //        return TreeNodeType.RIGHTTYPE;
            //    case "Right":         //角色

            //        return TreeNodeType.RIGHT;
            //    case "Pk2AdminCls":         //角色

            //        return TreeNodeType.ADMINCLS;
            //    case clsQxPotenceTypeEN.CurrTabName_S:         //角色

            //        return TreeNodeType.ADMINCLS;
            //    default:
            //        string strMsg = string.Format("树结点数据类型名:{1}在Switch中没有处理，请检查!({0})",
            //                clsStackTrace.GetCurrClassFunction(), strTypeName);
            //        throw new Exception(strMsg);
            //}
        }
        public string GetNodeTypeString(TreeNode objTreeNode, int intIndex)
        {

            string strTypeName = "";
            string strTag = objTreeNode.Value.ToString();
            string[] strArr = strTag.Split(',');
            if (intIndex == 2)
            {
                if (strArr.Length <= 2)
                {
                    return "";
                }
                strTypeName = strArr[2];
            }
            else
            {
                strTypeName = strArr[0];
            }
            return strTypeName;
        }

     
        /// <summary>
        /// 获取已经复选结点的关键字列表
        /// </summary>
        /// <param name="tntTemp">结点类型</param>
        /// <returns>复选的关键字列表</returns>
        public List<string> GetCheckedId(string strNeedNodeType)
        {
            List<string> arrAllCheckedNodeList = new List<string>();
            foreach (TreeNode tnNode in objCurrTreeView.Nodes)
            {
                GetCheckedNodeId(tnNode, arrAllCheckedNodeList, strNeedNodeType);
            }
            return arrAllCheckedNodeList;
        }
        /// <summary>
        /// 获取已经复选结点的关键字列表
        /// </summary>
        /// <param name="tntTemp">结点类型</param>
        /// <returns>复选的关键字列表</returns>
        public List<TreeNode> GetCheckedTreeNode(string strNeedNodeType)
        {
            List<TreeNode> arrAllCheckedNodeList = new List<TreeNode>();
            foreach (TreeNode tnNode in objCurrTreeView.Nodes)
            {
                GetCheckedTreeNode(tnNode, arrAllCheckedNodeList, strNeedNodeType);
            }
            return arrAllCheckedNodeList;
        }
        /// <summary>
        /// 获取已经复选的叶子结点的关键字列表
        /// </summary>
        /// <param name="tntTemp">结点类型</param>
        /// <returns>复选的关键字列表</returns>
		public List<string> GetCheckedIdForLeafNode(string strNeedNodeType)
        {
            List<string> arrAllCheckedNodeList = new List<string>();
            foreach (TreeNode tnNode in objCurrTreeView.Nodes)
            {
                GetCheckedNodeIdForLeaf(tnNode, arrAllCheckedNodeList, strNeedNodeType);
            }
            return arrAllCheckedNodeList;
        }

        private void GetCheckedNodeId(TreeNode tnTemp, List<string> arrLst, 
            string strNeedNodeType)
        {
            string strNodeType = GetNodeTypeString(tnTemp, 1);
            string strNodeKeyId = GetCurrKey(tnTemp);

            if (tnTemp.Checked == true && tnTemp.Checked == true 
                && strNodeType == strNeedNodeType)
            {
                arrLst.Add(strNodeKeyId);
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                GetCheckedNodeId(tn, arrLst, strNeedNodeType);
            }
        }

        private void GetCheckedTreeNode(TreeNode tnTemp, List<TreeNode> arrLst, 
            string strNeedNodeType)
        {
            string strNodeType = GetNodeTypeString(tnTemp, 1);

            if (tnTemp.Checked == true && tnTemp.Checked == true 
                && strNodeType == strNeedNodeType)
            {
                arrLst.Add(tnTemp);
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                GetCheckedTreeNode(tn, arrLst, strNeedNodeType);
            }
        }
        private void GetCheckedNodeIdForLeaf(TreeNode tnTemp, List<string> arrLst, 
            string strNeedNodeType)
        {
            string strNodeType1 = GetNodeTypeString(tnTemp, 1);
            string strNodeType2 = GetNodeTypeString(tnTemp, 2);
            string strNodeKeyId1 = GetCurrKey(tnTemp);
            string strNodeKeyId2;
            if (string.IsNullOrEmpty( strNodeType2 )== true)
            {
                if (tnTemp.Checked == true && tnTemp.Checked == true 
                    && strNodeType1 == strNeedNodeType)
                {
                    arrLst.Add(strNodeKeyId1);
                }
                foreach (TreeNode tn in tnTemp.ChildNodes)
                {
                    GetCheckedNodeIdForLeaf(tn, arrLst, strNeedNodeType);
                }
            }
            else
            {
                strNodeKeyId2 = GetCurrKey(tnTemp, 2);
                if (tnTemp.Checked == true && tnTemp.Checked == true && strNodeType1 == strNeedNodeType)
                {
                    arrLst.Add(strNodeKeyId1);
                }
                else if (tnTemp.Checked == true && tnTemp.Checked == true && strNodeType2 == strNeedNodeType)
                {
                    arrLst.Add(strNodeKeyId2);
                }
                foreach (TreeNode tn in tnTemp.ChildNodes)
                {
                    GetCheckedNodeIdForLeaf(tn, arrLst, strNeedNodeType);
                }
            }
        }
        /// <summary>
        /// 根据结点类型和关键字值得到相应的结点
        /// </summary>
        /// <param name="tnRoot">起始结点</param>
        /// <param name="tntNeedNodeType">结点类型</param>
        /// <param name="strKeyId"></param>结点关键字值
        /// <returns></returns>
        public TreeNode GetNodeByTypeAndKeyInTV(TreeView objTV,  
            string strNeedNodeType, string strKeyId)
        {
            foreach (TreeNode tnRoot in objTV.Nodes)
            {
                string strNodeType1 = GetNodeTypeString(tnRoot, 1);
                string strNodeType2 = GetNodeTypeString(tnRoot, 2);
                string strNodeKeyId1 = GetCurrKey(tnRoot);
                string strNodeKeyId2;
                //一个结点可能存放两个类型和两个关键字值ID，如果第二个为空，就只能看第一个
                if (string.IsNullOrEmpty( strNodeType2) == true)
                {
                    if (strNodeType1 == strNeedNodeType && strNodeKeyId1 == strKeyId)
                    {
                        return tnRoot;
                    }
                    foreach (TreeNode tn in tnRoot.ChildNodes)
                    {
                        TreeNode tnTemp = GetNodeByTypeAndKeyId(tn, strNeedNodeType, strKeyId);
                        if (tnTemp != null)
                        {
                            return tnTemp;
                        }
                    }
                }
                else
                {
                    if (strNodeType1 == strNeedNodeType && strNodeKeyId1 == strKeyId)
                    {
                        return tnRoot;
                    }
                    //获取第二个关键字值ID
                    strNodeKeyId2 = GetCurrKey(tnRoot, 2);
                    if (strNodeType2 == strNeedNodeType && strNodeKeyId2 == strKeyId)
                    {
                        return tnRoot;
                    }
                    foreach (TreeNode tn in tnRoot.ChildNodes)
                    {
                        TreeNode tnTemp = GetNodeByTypeAndKeyId(tn, strNeedNodeType, strKeyId);
                        if (tnTemp != null)
                        {
                            return tnTemp;
                        }
                    }
                }
            }
            return null;//没有找到相应的结点
        }

        /// <summary>
        /// 根据结点类型和关键字值得到相应的结点
        /// </summary>
        /// <param name="tnRoot">起始结点</param>
        /// <param name="tntNeedNodeType">结点类型</param>
        /// <param name="strKeyId"></param>结点关键字值
        /// <returns></returns>
        public TreeNode GetNodeByTypeAndKeyId(TreeNode tnRoot, 
            string strNeedNodeType, string strKeyId)
        {
            string strNodeType1 = GetNodeTypeString(tnRoot, 1);
            string strNodeType2 = GetNodeTypeString(tnRoot, 2);
            string strNodeKeyId1 = GetCurrKey(tnRoot);
            string strNodeKeyId2;
            //一个结点可能存放两个类型和两个关键字值ID，如果第二个为空，就只能看第一个
            if (string.IsNullOrEmpty( strNodeType2 )== true)
            {
                if (strNodeType1 == strNeedNodeType && strNodeKeyId1 == strKeyId)
                {
                    return tnRoot;
                }
                foreach (TreeNode tn in tnRoot.ChildNodes)
                {
                    TreeNode tnTemp = GetNodeByTypeAndKeyId(tn, strNeedNodeType, strKeyId);
                    if (tnTemp != null)
                    {
                        return tnTemp;
                    }
                }
            }
            else
            {
                if (strNodeType1 == strNeedNodeType 
                    && strNodeKeyId1 == strKeyId)
                {
                    return tnRoot;
                }
                //获取第二个关键字值ID
                strNodeKeyId2 = GetCurrKey(tnRoot, 2);
                if (strNodeType2 == strNeedNodeType && strNodeKeyId2 == strKeyId)
                {
                    return tnRoot;
                }
                foreach (TreeNode tn in tnRoot.ChildNodes)
                {
                    TreeNode tnTemp = GetNodeByTypeAndKeyId(tn, strNeedNodeType, strKeyId);
                    if (tnTemp != null)
                    {
                        return tnTemp;
                    }
                }
            }
            return null;//没有找到相应的结点
        }
            public bool SelectNode( string strNodeType, string strKeyId)
        {
            if (string.IsNullOrEmpty(strNodeType) == true
                || string.IsNullOrEmpty(strKeyId) == true)
            {
                return false;
            }

            TreeNode tnNode = GetNodeByTypeAndKeyInTV(objCurrTreeView, strNodeType, strKeyId);
            if (tnNode != null)
            {
                tnNode.Select();
                return true;
            }
            return false;
        }
        /// <summary>
        /// 获取被选结点的文本
        /// </summary>
        /// <param name="tntTemp"></param>
        /// <returns></returns>
		public List<string> GetCheckedNodeText(string strNeedNodeType)
        {
            List<string> arrAllCheckedNodeList = new List<string>();
            foreach (TreeNode tnNode in objCurrTreeView.Nodes)
            {
                GetCheckedNodeText(tnNode, arrAllCheckedNodeList, strNeedNodeType);
            }
            return arrAllCheckedNodeList;
        }
        private void GetCheckedNodeText(TreeNode tnTemp, List<string> arrLst, 
            string strNeedNodeType)
        {
            string strNodeType = GetNodeTypeString(tnTemp, 1);
            //			string strNodeKeyId = GetCurrKey(tnTemp);
            if (tnTemp.ShowCheckBox == true && tnTemp.Checked == true
                && strNodeType == strNeedNodeType)
            {
                arrLst.Add(tnTemp.Text);
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                GetCheckedNodeText(tn, arrLst, strNeedNodeType);
            }
        }
        public void SetNodeChecked(TreeNode tnNode, string strNeedNodeType, string strKeyId)
        {
            string strNodeType = GetNodeTypeString(tnNode, 1);
            string strNodeId = GetCurrKey(tnNode);
            if (strNodeType == strNeedNodeType && strNodeId == strKeyId)
            {
                tnNode.Checked = true;
            }
            else
            {
                for (int i = 0; i < tnNode.ChildNodes.Count; i++)
                {
                    SetNodeChecked(tnNode.ChildNodes[i], strNeedNodeType, strKeyId);
                }
            }
        }

      
      
         public void ExpandAll()
        {
            objCurrTreeView.ExpandAll();
        }
        public void ExpandLevel1()
        {
            if (objCurrTreeView.Nodes.Count > 0)
            {
                objCurrTreeView.Nodes[0].Expand();
                objCurrTreeView.Nodes[0].Select();
            }
        }
        public void ExpandLevel2()
        {
            if (objCurrTreeView.Nodes.Count > 0)
            {
                if (objCurrTreeView.Nodes[0].ChildNodes.Count > 0)
                {
                    int intNodeCount = objCurrTreeView.Nodes[0].ChildNodes.Count;
                    for (int i = intNodeCount - 1; i >= 0; i--)
                    {
                        TreeNode objTN = objCurrTreeView.Nodes[0].ChildNodes[i];
                        objTN.Expand();
                    }
                }
                objCurrTreeView.Nodes[0].Select();

            }

        }
        public void Expand(int intLevel)
        {
            if (intLevel == 1)
            {
                ExpandLevel1();
            }
            else if (intLevel >= 2)
            {
                ExpandLevel2();
            }
        }
        public string GetNodeKeyId(TreeNode objTN)
        {
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            string strTypeName = strArr[0];
            string strKeyId = "";
           	
            strKeyId = strArr[1];
            return strKeyId;
        }
        public string GetCurrKeyTypeName()
        {
            string strTabName = "";
            string strTag = objCurrTreeView.SelectedNode.Value.ToString();
            string[] strArr = strTag.Split(',');
            strTabName = strArr[0];
            return strTabName;
        }
    }
}