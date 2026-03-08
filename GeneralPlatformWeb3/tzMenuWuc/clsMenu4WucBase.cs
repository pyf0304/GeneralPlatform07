using com.taishsoft.common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace com.taishsoft.web.menu
{
    public class clsMenu4WucBase : System.Web.UI.UserControl
    {
        public virtual Menu objCurrMenu
        {
            get;
        }
        /// <summary>
        /// 获取给定结点的关键字
        /// </summary>
        /// <param name="objMI">给定结点</param>
        /// <returns>关键字</returns>
        public static string GetCurrKey(MenuItem objMI)
        {
            string strKeyId = "";
            string strTag = objMI.Value.ToString();
            string[] strArr = strTag.Split(',');
            strKeyId = strArr[1];
            return strKeyId;
        }
        /// <summary>
        /// 获取给定结点中第I个关键字
        /// </summary>
        /// <param name="objMI">给定结点</param>
        /// <param name="intIndex">关键字的序号</param>
        /// <returns>关键字</returns>
		public static string GetCurrKey(MenuItem objMI, int intIndex)
        {
            string strKeyId = "";
            string strTag = objMI.Value.ToString();
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

        public static string GetCurrKeyTypeName(MenuItem objMI)
        {
            string strTabName = "";
            string strTag = objMI.Value.ToString();
            string[] strArr = strTag.Split(',');
            if (strArr[0] != "Root")
            {
                strTabName = strArr[0];
            }

            return strTabName;
        }
        public string GetCurrKeyTypeName()
        {
            string strTabName = "";
            string strTag = objCurrMenu.SelectedItem.Value.ToString();
            string[] strArr = strTag.Split(',');
            strTabName = strArr[0];
            return strTabName;
        }
        public string GetNodeType(MenuItem objMenuItem, int intIndex)
        {

            string strTypeName = "";
            string strTag = objMenuItem.Value.ToString();
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
            //        return MenuItemType.SCHOOL;

            //    case clsXzSchoolEN.CurrTabName_S://)//学校
            //        return MenuItemType.SCHOOL;

            //    case clsQxUserRolesEN.CurrTabName_S://)//学校
            //        return MenuItemType.CJSTATSMODE;

            //    case "College":////学院

            //        return MenuItemType.COLLEGE;
            //    case clsvQxPrjMenus_SubEN.CurrTabName_S://年级(入学)

            //        return MenuItemType.GRADEBASE;
            //    case clsvQxPrjMenus_UpEN.CurrTabName_S://年级
            //        return MenuItemType.GRADE;
            //    case clsQxUsersEN.CurrTabName_S://考试批次
            //        return MenuItemType.EXAMBATCH;

            //    case "Major"://专业
            //        return MenuItemType.MAJOR;

            //    case clsSubjectDirectionEN.CurrTabName_S://学科方向
            //        return MenuItemType.SUBJECTDIRECTION;

            //    case "MajorGrade"://专业年级
            //        return MenuItemType.MAJORGRADE;
            //    case clsXzAdminClsEN.CurrTabName_S://行政班
            //        return MenuItemType.ADMINCLS;
            //    case clsQxPrjPotenceTypeEN.CurrTabName_S://课程类型

            //        return MenuItemType.COURSETYPE;
            //    case clsQxPrjPotenceEN.CurrTabName_S://课程
            //        return MenuItemType.COURSE;

            //    case "CourseTypeAdminType"://课程类型

            //        return MenuItemType.COURSETYPEADMINTYPE;
            //    case "StudentType": //学生类型
            //        return MenuItemType.STUDENTTYPE;
            //    case "PKaoExamGroup":   //排考考试组

            //        return MenuItemType.PKAOEXAMGROUP;
            //    case "UniZone"://校区

            //        return MenuItemType.UNIZONE;
            //    case "Build"://教学楼

            //        return MenuItemType.BUILD;
            //    case "TeachPlanTemplete"://教学计划模板

            //        return MenuItemType.TEACHPLANPlanTEMPLETE;
            //    case "JxTpXxTemplet"://教学计划选修课模板

            //        return MenuItemType.JXTPXXTEMPLETE;
            //    case clsxkCollectOfClassEN.CurrTabName_S://教学班信息

            //        return MenuItemType.COLLECT;
            //    case "CurrEduCls"://当前教学班

            //        return MenuItemType.CURREDUCLASS;
            //    case clsxkEduClsEN.CurrTabName_S://选课教学班

            //        return MenuItemType.XKEDUCLASS;
            //    case "JxTeachPlanSeries"://教学计划课程系列

            //        return MenuItemType.JXTEACHPLANSERIES;
            //    case "JxSeriesGroup"://教学计划系列组

            //        return MenuItemType.JXSERIESGROUP;
            //    case "JxSerGroupReqMode"://教学计划系列组模式

            //        return MenuItemType.JXSERGROUPREQMODE;
            //    case "JxTeachingPlan"://教学计划

            //        return MenuItemType.TEACHINGPLAN;
            //    case clsPk2ScheGroupEN.CurrTabName_S://教学计划

            //        return MenuItemType.PKSCHEGROUP;
            //    case "XlsImportTab"://教学计划

            //        return MenuItemType.XLSIMPORTTAB;
            //    case "Role":         //角色

            //        return MenuItemType.ROLE;
            //    case "User":        //角色

            //        return MenuItemType.USER;
            //    case "RightType":         //角色

            //        return MenuItemType.RIGHTTYPE;
            //    case "Right":         //角色

            //        return MenuItemType.RIGHT;
            //    case "Pk2AdminCls":         //角色

            //        return MenuItemType.ADMINCLS;
            //    case clsQxPotenceTypeEN.CurrTabName_S:         //角色

            //        return MenuItemType.ADMINCLS;
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
            //        return MenuItemType.SCHOOL;

            //    case clsXzSchoolEN.CurrTabName_S://)//学校
            //        return MenuItemType.SCHOOL;

            //    case clsQxUserRolesEN.CurrTabName_S://)//学校
            //        return MenuItemType.CJSTATSMODE;

            //    case "College":////学院

            //        return MenuItemType.COLLEGE;
            //    case clsvQxPrjMenus_SubEN.CurrTabName_S://年级(入学)

            //        return MenuItemType.GRADEBASE;
            //    case clsvQxPrjMenus_UpEN.CurrTabName_S://年级
            //        return MenuItemType.GRADE;
            //    case clsQxUsersEN.CurrTabName_S://考试批次
            //        return MenuItemType.EXAMBATCH;

            //    case "Major"://专业
            //        return MenuItemType.MAJOR;

            //    case clsSubjectDirectionEN.CurrTabName_S://学科方向
            //        return MenuItemType.SUBJECTDIRECTION;

            //    case "MajorGrade"://专业年级
            //        return MenuItemType.MAJORGRADE;
            //    case clsXzAdminClsEN.CurrTabName_S://行政班
            //        return MenuItemType.ADMINCLS;
            //    case clsQxPrjPotenceTypeEN.CurrTabName_S://课程类型

            //        return MenuItemType.COURSETYPE;
            //    case clsQxPrjPotenceEN.CurrTabName_S://课程
            //        return MenuItemType.COURSE;

            //    case "CourseTypeAdminType"://课程类型

            //        return MenuItemType.COURSETYPEADMINTYPE;
            //    case "StudentType": //学生类型
            //        return MenuItemType.STUDENTTYPE;
            //    case "PKaoExamGroup":   //排考考试组

            //        return MenuItemType.PKAOEXAMGROUP;
            //    case "UniZone"://校区

            //        return MenuItemType.UNIZONE;
            //    case "Build"://教学楼

            //        return MenuItemType.BUILD;
            //    case "TeachPlanTemplete"://教学计划模板

            //        return MenuItemType.TEACHPLANPlanTEMPLETE;
            //    case "JxTpXxTemplet"://教学计划选修课模板

            //        return MenuItemType.JXTPXXTEMPLETE;
            //    case clsxkCollectOfClassEN.CurrTabName_S://教学班信息

            //        return MenuItemType.COLLECT;
            //    case "CurrEduCls"://当前教学班

            //        return MenuItemType.CURREDUCLASS;
            //    case clsxkEduClsEN.CurrTabName_S://选课教学班

            //        return MenuItemType.XKEDUCLASS;
            //    case "JxTeachPlanSeries"://教学计划课程系列

            //        return MenuItemType.JXTEACHPLANSERIES;
            //    case "JxSeriesGroup"://教学计划系列组

            //        return MenuItemType.JXSERIESGROUP;
            //    case "JxSerGroupReqMode"://教学计划系列组模式

            //        return MenuItemType.JXSERGROUPREQMODE;
            //    case "JxTeachingPlan"://教学计划

            //        return MenuItemType.TEACHINGPLAN;
            //    case clsPk2ScheGroupEN.CurrTabName_S://教学计划

            //        return MenuItemType.PKSCHEGROUP;
            //    case "XlsImportTab"://教学计划

            //        return MenuItemType.XLSIMPORTTAB;
            //    case "Role":         //角色

            //        return MenuItemType.ROLE;
            //    case "User":        //角色

            //        return MenuItemType.USER;
            //    case "RightType":         //角色

            //        return MenuItemType.RIGHTTYPE;
            //    case "Right":         //角色

            //        return MenuItemType.RIGHT;
            //    case "Pk2AdminCls":         //角色

            //        return MenuItemType.ADMINCLS;
            //    case clsQxPotenceTypeEN.CurrTabName_S:         //角色

            //        return MenuItemType.ADMINCLS;
            //    default:
            //        string strMsg = string.Format("树结点数据类型名:{1}在Switch中没有处理，请检查!({0})",
            //                clsStackTrace.GetCurrClassFunction(), strTypeName);
            //        throw new Exception(strMsg);
            //}
        }
        public string GetNodeTypeString(MenuItem objMenuItem, int intIndex)
        {

            string strTypeName = "";
            string strTag = objMenuItem.Value.ToString();
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

        public string GetNodeKeyId(MenuItem objMI)
        {
            string strTag = objMI.Value.ToString();
            string[] strArr = strTag.Split(',');
            string strTypeName = strArr[0];
            string strKeyId = "";
            //			int intLoopTimes;
            //			if (strArr.Length<=2)
            //			{
            //				intLoopTimes = 1;
            //			}
            //			else
            //			{
            //				intLoopTimes = 2;
            //			}
            //			
            strKeyId = strArr[1];
            return strKeyId;
        }


        ///// <summary>
        ///// 获取已经复选结点的关键字列表
        ///// </summary>
        ///// <param name="tntTemp">结点类型</param>
        ///// <returns>复选的关键字列表</returns>
        //public List<string> GetCheckedId(string strNeedNodeType)
        //{
        //    List<string> arrAllCheckedNodeList = new List<string>();
        //    foreach (MenuItem tnNode in objCurrMenu.Items)
        //    {
        //        GetCheckedNodeId(tnNode, arrAllCheckedNodeList, strNeedNodeType);
        //    }
        //    return arrAllCheckedNodeList;
        //}
        ///// <summary>
        ///// 获取已经复选结点的关键字列表
        ///// </summary>
        ///// <param name="tntTemp">结点类型</param>
        ///// <returns>复选的关键字列表</returns>
        //public List<MenuItem> GetCheckedMenuItem(string strNeedNodeType)
        //{
        //    List<MenuItem> arrAllCheckedNodeList = new List<MenuItem>();
        //    foreach (MenuItem tnNode in objCurrMenu.Items)
        //    {
        //        GetCheckedMenuItem(tnNode, arrAllCheckedNodeList, strNeedNodeType);
        //    }
        //    return arrAllCheckedNodeList;
        //}
  //      /// <summary>
  //      /// 获取已经复选的叶子结点的关键字列表
  //      /// </summary>
  //      /// <param name="tntTemp">结点类型</param>
  //      /// <returns>复选的关键字列表</returns>
		//public List<string> GetCheckedIdForLeafNode(string strNeedNodeType)
  //      {
  //          List<string> arrAllCheckedNodeList = new List<string>();
  //          foreach (MenuItem tnNode in objCurrMenu.Items)
  //          {
  //              GetCheckedNodeIdForLeaf(tnNode, arrAllCheckedNodeList, strNeedNodeType);
  //          }
  //          return arrAllCheckedNodeList;
  //      }

        //private void GetCheckedNodeId(MenuItem tnTemp, List<string> arrLst, 
        //    string strNeedNodeType)
        //{
        //    string strNodeType = GetNodeTypeString(tnTemp, 1);
        //    string strNodeKeyId = GetCurrKey(tnTemp);

        //    if (tnTemp.Checked == true && tnTemp.Checked == true 
        //        && strNodeType == strNeedNodeType)
        //    {
        //        arrLst.Add(strNodeKeyId);
        //    }
        //    foreach (MenuItem tn in tnTemp.ChildItems)
        //    {
        //        GetCheckedNodeId(tn, arrLst, strNeedNodeType);
        //    }
        //}

        //private void GetCheckedMenuItem(MenuItem tnTemp, List<MenuItem> arrLst, 
        //    string strNeedNodeType)
        //{
        //    string strNodeType = GetNodeTypeString(tnTemp, 1);

        //    if (tnTemp.Checked == true && tnTemp.Checked == true 
        //        && strNodeType == strNeedNodeType)
        //    {
        //        arrLst.Add(tnTemp);
        //    }
        //    foreach (MenuItem tn in tnTemp.ChildItems)
        //    {
        //        GetCheckedMenuItem(tn, arrLst, strNeedNodeType);
        //    }
        //}
        //private void GetCheckedNodeIdForLeaf(MenuItem tnTemp, List<string> arrLst, 
        //    string strNeedNodeType)
        //{
        //    string strNodeType1 = GetNodeTypeString(tnTemp, 1);
        //    string strNodeType2 = GetNodeTypeString(tnTemp, 2);
        //    string strNodeKeyId1 = GetCurrKey(tnTemp);
        //    string strNodeKeyId2;
        //    if (string.IsNullOrEmpty( strNodeType2 )== true)
        //    {
        //        if (tnTemp.Checked == true && tnTemp.Checked == true 
        //            && strNodeType1 == strNeedNodeType)
        //        {
        //            arrLst.Add(strNodeKeyId1);
        //        }
        //        foreach (MenuItem tn in tnTemp.ChildItems)
        //        {
        //            GetCheckedNodeIdForLeaf(tn, arrLst, strNeedNodeType);
        //        }
        //    }
        //    else
        //    {
        //        strNodeKeyId2 = GetCurrKey(tnTemp, 2);
        //        if (tnTemp.Checked == true && tnTemp.Checked == true && strNodeType1 == strNeedNodeType)
        //        {
        //            arrLst.Add(strNodeKeyId1);
        //        }
        //        else if (tnTemp.Checked == true && tnTemp.Checked == true && strNodeType2 == strNeedNodeType)
        //        {
        //            arrLst.Add(strNodeKeyId2);
        //        }
        //        foreach (MenuItem tn in tnTemp.ChildItems)
        //        {
        //            GetCheckedNodeIdForLeaf(tn, arrLst, strNeedNodeType);
        //        }
        //    }
        //}
        /// <summary>
        /// 根据结点类型和关键字值得到相应的结点
        /// </summary>
        /// <param name="tnRoot">起始结点</param>
        /// <param name="tntNeedNodeType">结点类型</param>
        /// <param name="strKeyId"></param>结点关键字值
        /// <returns></returns>
        public MenuItem GetNodeByTypeAndKeyInTV(Menu objMenu,  
            string strNeedNodeType, string strKeyId)
        {
            foreach (MenuItem tnRoot in objMenu.Items)
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
                    foreach (MenuItem tn in tnRoot.ChildItems)
                    {
                        MenuItem tnTemp = GetNodeByTypeAndKeyId(tn, strNeedNodeType, strKeyId);
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
                    foreach (MenuItem tn in tnRoot.ChildItems)
                    {
                        MenuItem tnTemp = GetNodeByTypeAndKeyId(tn, strNeedNodeType, strKeyId);
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
        public MenuItem GetNodeByTypeAndKeyId(MenuItem tnRoot, 
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
                foreach (MenuItem tn in tnRoot.ChildItems)
                {
                    MenuItem tnTemp = GetNodeByTypeAndKeyId(tn, strNeedNodeType, strKeyId);
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
                foreach (MenuItem tn in tnRoot.ChildItems)
                {
                    MenuItem tnTemp = GetNodeByTypeAndKeyId(tn, strNeedNodeType, strKeyId);
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

            MenuItem tnNode = GetNodeByTypeAndKeyInTV(objCurrMenu, strNodeType, strKeyId);
            if (tnNode != null)
            {
                tnNode.Selected = true;
                return true;
            }
            return false;
        }
  //      /// <summary>
  //      /// 获取被选结点的文本
  //      /// </summary>
  //      /// <param name="tntTemp"></param>
  //      /// <returns></returns>
		//public List<string> GetCheckedNodeText(string strNeedNodeType)
  //      {
  //          List<string> arrAllCheckedNodeList = new List<string>();
  //          foreach (MenuItem tnNode in objCurrMenu.Items)
  //          {
  //              GetCheckedNodeText(tnNode, arrAllCheckedNodeList, strNeedNodeType);
  //          }
  //          return arrAllCheckedNodeList;
  //      }
        //private void GetCheckedNodeText(MenuItem tnTemp, List<string> arrLst, 
        //    string strNeedNodeType)
        //{
        //    string strNodeType = GetNodeTypeString(tnTemp, 1);
        //    //			string strNodeKeyId = GetCurrKey(tnTemp);
        //    if (tnTemp.ShowCheckBox == true && tnTemp.Checked == true
        //        && strNodeType == strNeedNodeType)
        //    {
        //        arrLst.Add(tnTemp.Text);
        //    }
        //    foreach (MenuItem tn in tnTemp.ChildItems)
        //    {
        //        GetCheckedNodeText(tn, arrLst, strNeedNodeType);
        //    }
        //}
        //public void SetNodeChecked(MenuItem tnNode, string strNeedNodeType, string strKeyId)
        //{
        //    string strNodeType = GetNodeTypeString(tnNode, 1);
        //    string strNodeId = GetCurrKey(tnNode);
        //    if (strNodeType == strNeedNodeType && strNodeId == strKeyId)
        //    {
        //        tnNode.Checked = true;
        //    }
        //    else
        //    {
        //        for (int i = 0; i < tnNode.ChildItems.Count; i++)
        //        {
        //            SetNodeChecked(tnNode.ChildItems[i], strNeedNodeType, strKeyId);
        //        }
        //    }
        //}

    }
}