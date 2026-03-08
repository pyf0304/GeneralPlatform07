using com.taishsoft.comm_db_obj;


using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

using System.Text;

namespace GeneralPlatform.web.treeview
{
    public partial class clsTreeViewBindDoubleTable
    {
        private TreeView mobjTv;

        private DataTable mobjLevel1Dt;

        private DataTable mobjLevel2Dt;

        private string mstrLevel1NameField = "";

        private string mstrLevel1ValueField = "";

        private string mstrLevel2NameField = "";

        private string mstrLevel2ValueField = "";

        private string mstrLevel1IDFieldInLevel2DataSource;

        private int mintExpandLevel = 1;

        private bool mbolLevel1HasCheckBox = true;

        private bool mbolLevel2HasCheckBox = true;

        private string mstrRootTitle = "以下是详细信息列表：";

        public TreeView objTreeView
        {
            get
            {
                return this.mobjTv;

            }
            set
            {
                if (value != null)
                {
                    this.mobjTv = value;
                }

            }
        }

        //绑定权限类型
        public static void Bindtv_QxRightType(wucTreeView objWucTV)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            //            List<clsQxDepartmentInfoEN> arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege !='0000' order by CollegeID");
            List<clsvQxPotenceTypeEN> arrvQxRightTypeObjList = clsvQxPotenceTypeBL.GetObjLst(" 1=1 order by PotenceTypeName");

            TreeNode tnRoot = new TreeNode();

            TreeNode tnRightType = null;

            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            foreach (clsvQxPotenceTypeEN objvQxRightType in arrvQxRightTypeObjList)  //QxDepartmentInfo
            {
                tnRightType = getTreeNodeByTabObj(objvQxRightType, objWucTV, 1);
                objTV.Nodes.Add(tnRightType);
            }
            objTV.ExpandAll();
            objTV.Nodes[0].Select();
        }

        /// <summary>
        /// 绑定学校
        /// </summary>
        /// <param name="objTV"></param>
        public static void Bindtv_School(wucTreeView objWucTV)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            string strCondition_XzSchool = string.Format("{0}='1'  order by {1}", conXzSchool.IsCurrentUse, conXzSchool.SchoolId);
            List<clsXzSchoolEN> arrXzSchoolObjList = clsXzSchoolBL.GetObjLst(strCondition_XzSchool);

            //List<clsSubjectDirectionEN> arrSubjectDirectionObjList = clsSubjectDirectionBL.GetSubjectDirectionObjList(" 1=1");
            //List<clsXzSchoolBaseEN> arrXzSchoolBaseObjList = clsXzSchoolBaseBL.GetXzSchoolBaseObjList(" id_GradeBase != '0000' order by MenuIdSub");


            TreeNode tnRoot = new TreeNode();
            TreeNode tnXzSchool = null, tnXzAdminCls = null; //,tnRange = null;
                                                             //TreeNode  tnSubjectDirection = null,                                                                  //			TreeNode tnBuilding = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "上海师范大学第二附属中学";
            objTV.Nodes.Add(tnRoot);

            foreach (clsXzSchoolEN objXzSchool in arrXzSchoolObjList) //XzSubjectDirection
            {
                tnXzSchool = getTreeNodeByTabObj(objXzSchool, objWucTV, 1);
                tnRoot.ChildNodes.Add(tnXzSchool);
            }


            //			objTV.ExpandAll();
            if (objTV.Nodes.Count > 0)
            {
                objTV.Nodes[0].Select();
            }
        }
        public static void Bindtv_Project_UserRoles(wucTreeView objWucTV)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            string strCondition_QxProjects = string.Format("1=1 order by {0}", conQxProjects.PrjName);
            List<clsQxProjectsEN> arrQxProjectsObjList = clsQxProjectsBL.GetObjLst(strCondition_QxProjects);
            List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(" 1=1 ");

            TreeNode tnRoot = new TreeNode();
            TreeNode tnQxUserRoles = null; //,tnRange = null;
            TreeNode tnQxProjects = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsQxProjectsEN objQxProjects in arrQxProjectsObjList) //XzQxProjects
            {
                tnQxProjects = getTreeNodeByTabObj(objQxProjects, objWucTV, 1);
                objTV.Nodes.Add(tnQxProjects);
                foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList) //XzQxProjects
                {
                    if (objQxUserRoles.QxPrjId == objQxProjects.QxPrjId)
                    {
                        tnQxUserRoles = getTreeNodeByTabObj(objQxUserRoles, objWucTV, 2);
                        tnQxProjects.ChildNodes.Add(tnQxUserRoles);
                    }
                }
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_QxPrjMenuSet_QxPrjMenuUp_Sub(wucTreeView objWucTV, string strQxPrjId, string strMenuSetId)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            StringBuilder sbCondition_MenuSet = new StringBuilder();
            sbCondition_MenuSet.AppendFormat("{0}='{1}' ",
                conQxPrjMenuSet.QxPrjId,
                strQxPrjId);

            sbCondition_MenuSet.AppendFormat(" order by {0} ",
               conQxPrjMenuSet.MenuSetName);
            List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjList = clsQxPrjMenuSetBL.GetObjLst(sbCondition_MenuSet.ToString());

            StringBuilder sbCondition_Up = new StringBuilder();
            sbCondition_Up.AppendFormat("{0}='{1}' ",
                convQxPrjMenus_Up.QxPrjId,
                strQxPrjId);
            if (string.IsNullOrEmpty(strMenuSetId) == false)
            {
                sbCondition_Up.AppendFormat(" And {0}='{1}' ",
                    convQxPrjMenus_Up.MenuSetId,
                    strMenuSetId);
            }
            sbCondition_Up.AppendFormat(" order by {0} ",
               convQxPrjMenus_Up.OrderNum);
            List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjList = clsvQxPrjMenus_UpBL.GetObjLst(sbCondition_Up.ToString());

            StringBuilder sbCondition_Sub = new StringBuilder();
            sbCondition_Sub.AppendFormat("{0}='{1}' ",
                convQxPrjMenus_Up.QxPrjId,
                strQxPrjId);
            if (string.IsNullOrEmpty(strMenuSetId) == false)
            {
                sbCondition_Up.AppendFormat(" And {0}='{1}' ",
                    convQxPrjMenus_Up.MenuSetId,
                    strMenuSetId);
            }
            sbCondition_Sub.AppendFormat(" order by {0} ",
               convQxPrjMenus_Up.OrderNum);
            List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjList = clsvQxPrjMenus_SubBL.GetObjLst(sbCondition_Sub.ToString());


            TreeNode tnRoot = new TreeNode();
            TreeNode tnvQxPrjMenus_Sub = null; //,tnRange = null;
            TreeNode tnvQxPrjMenus_Up = null;
            TreeNode tnQxPrjMenuSet = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "项目菜单列表";
            objTV.Nodes.Add(tnRoot);
           
            foreach (clsQxPrjMenuSetEN objQxPrjMenuSet in arrQxPrjMenuSetObjList) //XzvQxPrjMenus_Up
            {
                tnQxPrjMenuSet = getTreeNodeByTabObj(objQxPrjMenuSet, objWucTV, 1);
                tnRoot.ChildNodes.Add(tnQxPrjMenuSet);
                foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_Up in arrvQxPrjMenus_UpObjList) //XzvQxPrjMenus_Up
                {
                    if (objQxPrjMenuSet.MenuSetId != objvQxPrjMenus_Up.MenuSetId) continue;
                    tnvQxPrjMenus_Up = getTreeNodeByTabObj(objvQxPrjMenus_Up, objWucTV, 2);
                    tnvQxPrjMenus_Up.Text = string.Format("{0}{1}{2}({3})",
                                objvQxPrjMenus_Up.MenuName,
                                objvQxPrjMenus_Up.MenuIdUp,
                                (objvQxPrjMenus_Up.InUse ? "" : "(未用)"),
                                objvQxPrjMenus_Up.OrderNum);
                    tnRoot.ChildNodes.Add(tnvQxPrjMenus_Up);
                    tnQxPrjMenuSet.ChildNodes.Add(tnvQxPrjMenus_Up);
                    foreach (clsvQxPrjMenus_SubEN objvQxPrjMenus_Sub in arrvQxPrjMenus_SubObjList) //XzvQxPrjMenus_Up
                    {
                        if (objvQxPrjMenus_Sub.UpMenuId == objvQxPrjMenus_Up.MenuIdUp)
                        {
                            tnvQxPrjMenus_Sub = getTreeNodeByTabObj(objvQxPrjMenus_Sub, objWucTV,3);
                            tnvQxPrjMenus_Sub.Text = string.Format("{0}{1}{2}{3}({4})",
                       objvQxPrjMenus_Sub.MenuName,
                        objvQxPrjMenus_Sub.MenuIdSub,
                        (objvQxPrjMenus_Sub.IsLeafNode ? "(叶子)" : ""),
                          (objvQxPrjMenus_Sub.InUse ? "" : "(未用)"),
                        objvQxPrjMenus_Sub.OrderNum); //获取主菜单项NAME

                            tnvQxPrjMenus_Up.ChildNodes.Add(tnvQxPrjMenus_Sub);
                        }
                    }
                }
            }

            objTV.ExpandDepth = 1;
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_QxPrjMenuUp_Sub(wucTreeView objWucTV, string strQxPrjId, string strMenuSetId)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            StringBuilder sbCondition_Up = new StringBuilder();
            sbCondition_Up.AppendFormat("{0}='{1}' ",
                convQxPrjMenus_Up.QxPrjId,
                strQxPrjId);
            if (string.IsNullOrEmpty(strMenuSetId) == false)
            {
                sbCondition_Up.AppendFormat(" And {0}='{1}' ",
                    convQxPrjMenus_Up.MenuSetId,
                    strMenuSetId);
            }
            sbCondition_Up.AppendFormat(" order by {0} ",
               convQxPrjMenus_Up.OrderNum);
            List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjList = clsvQxPrjMenus_UpBL.GetObjLst(sbCondition_Up.ToString());

            StringBuilder sbCondition_Sub = new StringBuilder();
            sbCondition_Sub.AppendFormat("{0}='{1}' ",
                convQxPrjMenus_Up.QxPrjId,
                strQxPrjId);
            if (string.IsNullOrEmpty(strMenuSetId) == false)
            {
                sbCondition_Up.AppendFormat(" And {0}='{1}' ",
                    convQxPrjMenus_Up.MenuSetId,
                    strMenuSetId);
            }
            sbCondition_Sub.AppendFormat(" order by {0} ",
               convQxPrjMenus_Up.OrderNum);
            List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjList = clsvQxPrjMenus_SubBL.GetObjLst(sbCondition_Sub.ToString());


            TreeNode tnRoot = new TreeNode();
            TreeNode tnvQxPrjMenus_Sub = null; //,tnRange = null;
            TreeNode tnvQxPrjMenus_Up = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "项目菜单列表";
            objTV.Nodes.Add(tnRoot);
            foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_Up in arrvQxPrjMenus_UpObjList) //XzvQxPrjMenus_Up
            {
                tnvQxPrjMenus_Up = getTreeNodeByTabObj(objvQxPrjMenus_Up, objWucTV, 1);
                tnvQxPrjMenus_Up.Text = string.Format("{0}{1}{2}({3})", 
                    objvQxPrjMenus_Up.MenuName, 
                    objvQxPrjMenus_Up.MenuIdUp,
                     (objvQxPrjMenus_Up.InUse ? "" : "(未用)"),
                    objvQxPrjMenus_Up.OrderNum);
                tnRoot.ChildNodes.Add(tnvQxPrjMenus_Up);
                foreach (clsvQxPrjMenus_SubEN objvQxPrjMenus_Sub in arrvQxPrjMenus_SubObjList) //XzvQxPrjMenus_Up
                {
                    if (objvQxPrjMenus_Sub.UpMenuId == objvQxPrjMenus_Up.MenuIdUp)
                    {
                        tnvQxPrjMenus_Sub = getTreeNodeByTabObj(objvQxPrjMenus_Sub, objWucTV, 2);
                        //tnvQxPrjMenus_Sub.Text = string.Format("{0}{1}({2})", objvQxPrjMenus_Sub.MenuName, objvQxPrjMenus_Sub.MenuIdSub, objvQxPrjMenus_Sub.OrderNum);
                        tnvQxPrjMenus_Sub.Text = string.Format("{0}{1}{2}{3}({4})",
                         objvQxPrjMenus_Sub.MenuName,
                          objvQxPrjMenus_Sub.MenuIdSub,
                          (objvQxPrjMenus_Sub.IsLeafNode ? "(叶子)" : ""),
                            (objvQxPrjMenus_Sub.InUse ? "" : "(未用)"),
                          objvQxPrjMenus_Sub.OrderNum); //获取主菜单项NAME

                        tnvQxPrjMenus_Up.ChildNodes.Add(tnvQxPrjMenus_Sub);
                    }
                }
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_QxPrjMenuUp_Sub_Leaf(wucTreeView objWucTV, string strQxPrjId, string strMenuSetId)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            StringBuilder sbCondition_Up = new StringBuilder();
            sbCondition_Up.AppendFormat("{0}='{1}' ",
                convQxPrjMenus_Up.QxPrjId,
                strQxPrjId);
            if (string.IsNullOrEmpty(strMenuSetId) == false)
            {
                sbCondition_Up.AppendFormat(" And {0}='{1}' ",
                    convQxPrjMenus_Up.MenuSetId,
                    strMenuSetId);
            }
            sbCondition_Up.AppendFormat(" order by {0} ",
               convQxPrjMenus_Up.OrderNum);
            List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjList = clsvQxPrjMenus_UpBL.GetObjLst(sbCondition_Up.ToString());

            StringBuilder sbCondition_Sub = new StringBuilder();
            sbCondition_Sub.AppendFormat("{0}='{1}' ",
                convQxPrjMenus_Up.QxPrjId,
                strQxPrjId);
            if (string.IsNullOrEmpty(strMenuSetId) == false)
            {
                sbCondition_Up.AppendFormat(" And {0}='{1}' ",
                    convQxPrjMenus_Up.MenuSetId,
                    strMenuSetId);
            }
            sbCondition_Sub.AppendFormat(" order by {0} ",
               convQxPrjMenus_Up.OrderNum);
            List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjList = clsvQxPrjMenus_SubBL.GetObjLst(sbCondition_Sub.ToString());


            StringBuilder sbCondition_Leaf = new StringBuilder();
            sbCondition_Leaf.AppendFormat("{0}='{1}' ",
                convQxPrjMenus_Leaf.QxPrjId,
                strQxPrjId);
            if (string.IsNullOrEmpty(strMenuSetId) == false)
            {
                sbCondition_Up.AppendFormat(" And {0}='{1}' ",
                    convQxPrjMenus_Leaf.MenuSetId,
                    strMenuSetId);
            }
            sbCondition_Leaf.AppendFormat(" order by {0} ",
               convQxPrjMenus_Leaf.OrderNum);
            List<clsvQxPrjMenus_LeafEN> arrvQxPrjMenus_LeafObjList = clsvQxPrjMenus_LeafBL.GetObjLst(sbCondition_Leaf.ToString());


            TreeNode tnRoot = new TreeNode();
            TreeNode tnvQxPrjMenus_Sub = null; //,tnRange = null;
            TreeNode tnvQxPrjMenus_Leaf = null; //,tnRange = null;
            TreeNode tnvQxPrjMenus_Up = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "项目菜单列表";
            objTV.Nodes.Add(tnRoot);
            foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_Up in arrvQxPrjMenus_UpObjList) //XzvQxPrjMenus_Up
            {
                tnvQxPrjMenus_Up = getTreeNodeByTabObj(objvQxPrjMenus_Up, objWucTV, 1);
                tnvQxPrjMenus_Up.Text = string.Format("{0}{1}{2}({3})",
                            objvQxPrjMenus_Up.MenuName,
                            objvQxPrjMenus_Up.MenuIdUp,
                            (objvQxPrjMenus_Up.InUse ? "" : "(未用)"),
                            objvQxPrjMenus_Up.OrderNum);
                tnRoot.ChildNodes.Add(tnvQxPrjMenus_Up);
                tnRoot.ChildNodes.Add(tnvQxPrjMenus_Up);
                foreach (clsvQxPrjMenus_SubEN objvQxPrjMenus_Sub in arrvQxPrjMenus_SubObjList) //XzvQxPrjMenus_Up
                {
                    if (objvQxPrjMenus_Sub.UpMenuId != objvQxPrjMenus_Up.MenuIdUp) continue;
                        tnvQxPrjMenus_Sub = getTreeNodeByTabObj(objvQxPrjMenus_Sub, objWucTV, 2);
                        //tnvQxPrjMenus_Sub.Text = string.Format("{0}{1}({2})", objvQxPrjMenus_Sub.MenuName, objvQxPrjMenus_Sub.MenuIdSub, objvQxPrjMenus_Sub.OrderNum);
                        tnvQxPrjMenus_Sub.Text = string.Format("{0}{1}{2}{3}({4})",
                         objvQxPrjMenus_Sub.MenuName,
                          objvQxPrjMenus_Sub.MenuIdSub,
                          (objvQxPrjMenus_Sub.IsLeafNode ? "(叶子)" : ""),
                            (objvQxPrjMenus_Sub.InUse ? "" : "(未用)"),
                          objvQxPrjMenus_Sub.OrderNum); //获取主菜单项NAME

                        tnvQxPrjMenus_Up.ChildNodes.Add(tnvQxPrjMenus_Sub);
                    foreach (clsvQxPrjMenus_LeafEN objvQxPrjMenus_Leaf in arrvQxPrjMenus_LeafObjList) //XzvQxPrjMenus_Up
                    {
                        if (objvQxPrjMenus_Leaf.UpMenuId == objvQxPrjMenus_Sub.MenuIdSub) continue;
                        tnvQxPrjMenus_Leaf = getTreeNodeByTabObj(objvQxPrjMenus_Leaf, objWucTV, 2);
                        //tnvQxPrjMenus_Leaf.Text = string.Format("{0}{1}({2})", objvQxPrjMenus_Leaf.MenuName, objvQxPrjMenus_Leaf.MenuIdSub, objvQxPrjMenus_Leaf.OrderNum);
                        tnvQxPrjMenus_Leaf.Text = string.Format("{0}{1}{2}{3}({4})",
                             objvQxPrjMenus_Leaf.MenuName,
                              objvQxPrjMenus_Leaf.MenuIdLeaf,
                              (objvQxPrjMenus_Leaf.IsLeafNode ? "(叶子)" : ""),
                                (objvQxPrjMenus_Leaf.InUse ? "" : "(未用)"),
                              objvQxPrjMenus_Leaf.OrderNum); //获取主菜单项NAME

                        tnvQxPrjMenus_Sub.ChildNodes.Add(tnvQxPrjMenus_Leaf);
                    }
                }
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        //绑定角色--用户
        public static void Bindtv_Role_User(wucTreeView objWucTV)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            //            ArrayList arrUserObjList = clsQxUsers().GetQxUsersObjList(" id_User !='0000' order by UserID");
            List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(" 1=1 order by RoleName");
            List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelObjList = clsvQxUserRoleRelationBL.GetObjLst(" 1=1 order by UserID");

            //TreeNode tnRoot = new TreeNode();
            TreeNode tnUser = null;
            //			TreeNode tnMajor = null;
            //			TreeNode tnGrade = null;
            //			TreeNode tnRange = null;
            TreeNode tnRole = null;

            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList)  //QxUsers
            {
                tnRole = getTreeNodeByTabObj(objQxUserRoles, objWucTV, 1);

                objTV.Nodes.Add(tnRole);
                foreach (clsvQxUserRoleRelationEN objvQxUserRoleRel in arrvQxUserRoleRelObjList)
                {
                    if (objvQxUserRoleRel.RoleId == objQxUserRoles.RoleId)
                    {
                        clsQxUsersEN objQxUsers = clsQxUsersBL.GetObjByUserIdCache(objvQxUserRoleRel.UserId);
                        tnUser = getTreeNodeByTabObj(objQxUsers, objWucTV, 2);

                        tnUser.Text = objQxUsers.UserId + "(" + objQxUsers.UserName + ")";
                        tnRole.ChildNodes.Add(tnUser);
                    }
                }
            }


            //objTV.ExpandAll();
            objTV.Nodes[0].Select();
        }
        //绑定权限类型--权限
        public static void Bindtv_QxRightType_Right(wucTreeView objWucTV)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            //List<clsQxDepartmentInfoEN> arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege !='0000' order by CollegeID");
            List<clsvQxPotenceTypeEN> arrvQxRightTypeObjList = clsvQxPotenceTypeBL.GetObjLst(" 1=1 order by PotenceTypeName");
            List<clsQxPrjPotenceEN> arrQxRightObjList = clsQxPrjPotenceBL.GetObjLst(" 1=1 order by PotenceName");

            //TreeNode tnRoot = new TreeNode();
            TreeNode tnRight = null;
            //			TreeNode tnRightType = null;
            //			TreeNode tnMajor = null;
            //			TreeNode tnGrade = null;
            //			TreeNode tnRange = null;
            TreeNode tnRightType = null;

            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            foreach (clsvQxPotenceTypeEN objvQxRightType in arrvQxRightTypeObjList)  //QxDepartmentInfo
            {
                tnRightType = getTreeNodeByTabObj(objvQxRightType, objWucTV, 1);
                objTV.Nodes.Add(tnRightType);
                foreach (clsQxPrjPotenceEN objQxRight in arrQxRightObjList)
                {
                    if (objQxRight.PotenceTypeId == objvQxRightType.PotenceTypeId)
                    {
                        tnRight = getTreeNodeByTabObj(objQxRight, objWucTV, 2);

                        tnRightType.ChildNodes.Add(tnRight);
                    }
                }
            }


            objTV.ExpandAll();
            objTV.Nodes[0].Select();
        }

        public int ExpandLevel
        {
            get
            {
                return this.mintExpandLevel;
            }
            set
            {
                if (value >= 0)
                {
                    this.mintExpandLevel = value;
                }
            }
        }

        public bool Level1CheckBox
        {
            get
            {
                return this.mbolLevel1HasCheckBox;
            }
            set
            {

                this.mbolLevel1HasCheckBox = value;

            }
        }

        public bool Level2CheckBox
        {
            get
            {
                return this.mbolLevel2HasCheckBox;
            }
            set
            {

                this.mbolLevel2HasCheckBox = value;

            }
        }

        public string RootTitle
        {
            get
            {
                return this.mstrRootTitle;
            }
            set
            {
                if (value != null)
                {
                    this.mstrRootTitle = value;
                }
            }
        }

        public DataTable Level1DataSource
        {
            get
            {
                return this.mobjLevel1Dt;
            }
            set
            {
                if (value != null)
                {
                    this.mobjLevel1Dt = value;
                }
            }
        }

        public DataTable Level2DataSource
        {
            get
            {
                return this.mobjLevel2Dt;
            }
            set
            {
                if (value != null)
                {
                    this.mobjLevel2Dt = value;
                }
            }
        }

        public string Level1NameField
        {
            get
            {

                return this.mstrLevel1NameField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel1NameField = value;
                }

            }
        }

        public string Level1ValueField
        {
            get
            {

                return this.mstrLevel1ValueField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel1ValueField = value;
                }

            }
        }

        public string Level2NameField
        {
            get
            {

                return this.mstrLevel2NameField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel2NameField = value;
                }

            }
        }

        public string Level2ValueField
        {
            get
            {

                return this.mstrLevel2ValueField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel2ValueField = value;
                }

            }
        }

        public string Level1IDFieldInLevel2DataSource
        {
            get
            {

                return this.mstrLevel1IDFieldInLevel2DataSource;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel1IDFieldInLevel2DataSource = value;
                }

            }
        }

        public List<string> CheckedLevel1NodesIDArr
        {
            get
            {

                List<string> objArr = new List<string>();

                this.GetCheckedNodeId(this.mobjTv.Nodes[0], objArr, "Level1");

                return objArr;

            }
            set
            {
                if (value != null && value.Count > 0 && this.mobjTv != null)
                {
                    foreach (string TreeNodeId in value)
                    {
                        string ss = TreeNodeId;
                        this.CheckSubNodeById(mobjTv.Nodes[0], value, "Level1");
                    }
                }

            }
        }

        public List<string> CheckedLevel2NodesIDArr
        {
            get
            {

                List<string> objArr = new List<string>();

                this.GetCheckedNodeId(this.mobjTv.Nodes[0], objArr, "Level2");

                return objArr;

            }
            set
            {
                if (value != null && value.Count > 0 && this.mobjTv != null)
                {
                    foreach (string TreeNodeId in value)
                    {
                        string ss = TreeNodeId;
                        this.CheckSubNodeById(mobjTv.Nodes[0], value, "Level2");
                    }
                }
            }
        }

        public clsTreeViewBindDoubleTable()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public clsTreeViewBindDoubleTable(TreeView objTreeView)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjTv = objTreeView;

        }

        public clsTreeViewBindDoubleTable(TreeView objTreeView, DataTable Level1DataSource, DataTable Level2DataSource)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjTv = objTreeView;
            this.mobjLevel1Dt = Level1DataSource;
            this.mobjLevel2Dt = Level2DataSource;

        }


        public clsTreeViewBindDoubleTable(TreeView objTreeView,
            DataTable Level1DataSource, DataTable Level2DataSource,
            string Level1NameField, string Level1ValueField, string Level2NameField, string Level2ValueField, string Level1IDFieldInLevel2DataSource)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjTv = objTreeView;
            this.mobjLevel1Dt = Level1DataSource;
            this.mobjLevel2Dt = Level2DataSource;
            this.mstrLevel1NameField = Level1NameField;
            this.mstrLevel1ValueField = Level1ValueField;
            this.mstrLevel2NameField = Level2NameField;
            this.mstrLevel2ValueField = Level2ValueField;
            this.mstrLevel1IDFieldInLevel2DataSource = Level1IDFieldInLevel2DataSource;
        }

        public void DataBind()
        {
            this.BindTreeView(this.mobjTv, this.mobjLevel1Dt, this.mobjLevel2Dt, this.mstrLevel1NameField, this.mstrLevel1ValueField, this.mstrLevel2NameField, this.mstrLevel2ValueField, this.mstrLevel1IDFieldInLevel2DataSource);
            this.mobjTv.Nodes[0].Expand();
        }


        private void BindTreeView(TreeView pobjTreeView,
            DataTable pLevel1DataSource, DataTable pLevel2DataSource,
            string pLevel1NameField, string pLevel1ValueField, string pLevel2NameField, string pLevel2ValueField, string pLevel1IDFieldInLevel2DataSource)
        {
            if (pobjTreeView != null
                && pLevel1DataSource != null && pLevel2DataSource != null
                && pLevel1NameField != "" && pLevel1ValueField != "" && pLevel2NameField != "" && pLevel2ValueField != "" && pLevel1IDFieldInLevel2DataSource != "")
            {



                DataTable objLevel1DataTable, objLevel2DataTable;
                TreeNode tnRoot, tnLevel1, tnLevel2;

                pobjTreeView.Nodes.Clear();

                tnRoot = new TreeNode();
                tnRoot.Value = "Root,0000";
                tnRoot.Text = this.mstrRootTitle;
                //mobjTv.CheckBoxes = false;

                pobjTreeView.Nodes.Add(tnRoot);


                objLevel1DataTable = pLevel1DataSource;
                objLevel2DataTable = pLevel2DataSource;



                foreach (DataRow Level1Dr in objLevel1DataTable.Rows)
                {
                    string strLevel1Id = Level1Dr[pLevel1ValueField].ToString();
                    string strLevel1Name = Level1Dr[pLevel1NameField].ToString();

                    tnLevel1 = new TreeNode();
                    tnLevel1.Value = "Level1," + strLevel1Id;
                    tnLevel1.Text = strLevel1Name;
                    tnLevel1.ShowCheckBox = this.mbolLevel1HasCheckBox;
                    tnRoot.ChildNodes.Add(tnLevel1);

                    DataRow[] DrRows = objLevel2DataTable.Select(string.Format(" {0} = '{1}'", pLevel1IDFieldInLevel2DataSource, strLevel1Id));

                    foreach (DataRow Level2Dr in DrRows)
                    {
                        string strLevel2Id = Level2Dr[pLevel2ValueField].ToString();
                        string strLevel2Name = Level2Dr[pLevel2NameField].ToString();

                        tnLevel2 = new TreeNode();
                        tnLevel2.Value = "Level2," + strLevel2Id;
                        tnLevel2.Text = strLevel2Name;
                        tnLevel2.ShowCheckBox = this.mbolLevel2HasCheckBox;
                        tnLevel1.ChildNodes.Add(tnLevel2);

                    }

                }

            }

        }


        private void CheckSubNode(TreeNode tnTemp, bool bolIsChecked)
        {
            //if (mobjTv.CheckBoxes == true)
            //{
            //    tnTemp.Checked = bolIsChecked;
            //}
            tnTemp.Checked = bolIsChecked;
            if (tnTemp.ChildNodes.Count > 0)
            {
                foreach (TreeNode tn in tnTemp.ChildNodes)
                {
                    CheckSubNode(tn, bolIsChecked);
                }
            }
        }

        public static void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.ChildNodes)
            {
                node.Checked = nodeChecked;
                if (node.ChildNodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    clsTreeViewBindDoubleTable.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        public static string GetCurrKeyTypeName(TreeView objTreeView)
        {
            string strTabName = "";
            string strTag = objTreeView.SelectedNode.Value.ToString();
            string[] strArr = strTag.Split(',');
            strTabName = strArr[0];
            return strTabName;
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
        public static string GetCurrKey(TreeView objTreeView)
        {
            string strKeyId = "";
            string strTag = objTreeView.SelectedNode.Value.ToString();
            string[] strArr = strTag.Split(',');
            strKeyId = strArr[1];
            return strKeyId;
        }
        /// <summary>
        /// 获取当前结点的关键字
        /// </summary>
        /// <param name="objTN"></param>
        /// <returns></returns>
		public static string GetCurrKey(TreeNode objTN)
        {
            string strKeyId = "";
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            strKeyId = strArr[1];
            return strKeyId;
        }

        private void CheckSubNodeById(TreeNode tnTemp, List<string> TreeNodeIdArr, string TreeNodeType)
        {
            string strNodeType = GetCurrKeyTypeName(tnTemp);
            string strNodeKeyId = GetCurrKey(tnTemp);
            if (tnTemp.ShowCheckBox == true && strNodeType == TreeNodeType)
            {

                if (TreeNodeIdArr.Contains(strNodeKeyId))
                {
                    tnTemp.Checked = true;
                }
                else
                {
                    tnTemp.Checked = false;

                }
            }

            if (tnTemp.ChildNodes.Count > 0)
            {
                foreach (TreeNode tn in tnTemp.ChildNodes)
                {
                    CheckSubNodeById(tn, TreeNodeIdArr, TreeNodeType);
                }
            }

        }


        private void GetCheckedNodeId(TreeNode tnTemp, List<string> arrLst, string TreeNodeType)
        {
            string strNodeType = GetCurrKeyTypeName(tnTemp);
            string strNodeKeyId = GetCurrKey(tnTemp);

            if (tnTemp.Checked == true && tnTemp.Checked == true && strNodeType == TreeNodeType)
            {
                arrLst.Add(strNodeKeyId);
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                GetCheckedNodeId(tn, arrLst, TreeNodeType);
            }
        }

        private void GetCheckedNodeName(TreeNode tnTemp, List<string> arrLst, string TreeNodeType)
        {
            string strNodeType = GetCurrKeyTypeName(tnTemp);
            string strNodeKeyId = GetCurrKey(tnTemp);

            if (tnTemp.ShowCheckBox == true && tnTemp.Checked == true && strNodeType == TreeNodeType)
            {
                arrLst.Add(tnTemp.Text);
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                GetCheckedNodeName(tn, arrLst, TreeNodeType);
            }
        }

        public static void Bindtv_College(wucTreeView objWucTV)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            string strCondition_XzSchool = string.Format("{0}='1'  order by {1}", conXzSchool.IsCurrentUse, conXzSchool.SchoolId);
            List<clsXzSchoolEN> arrXzSchoolObjList = clsXzSchoolBL.GetObjLst(strCondition_XzSchool);

            List<clsQxDepartmentInfoEN> arrCollegeObjList = null;
            if (clsSysPara4TreeView.bolIsHaveClgCondition == true)
            {
                if (string.IsNullOrEmpty(clsSysPara4TreeView.strCollegeCondition) == false)
                {
                    arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(clsSysPara4TreeView.strCollegeCondition + " and IdCollege !='0000'  order by CollegeID");
                }
                else
                {
                    arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege ='" + clsSysPara4TreeView.strId_College + "' and IdCollege !='0000'  order by CollegeID");
                }
            }
            else
            {
                arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege !='0000' order by CollegeID");
            }

            //			List<clsQxDepartmentInfoEN> arrCollegeObjList = clsQxDepartmentInfoBL.GetObjLst(" IdCollege !='0000' order by CollegeID");

            TreeNode tnRoot = new TreeNode();
            TreeNode tnCollege = null;      //,tnMajor = null,tnGrade = null,tnRange = null;
            TreeNode tnXzSchool = null;

            objTV.Nodes.Clear();

            foreach (clsQxDepartmentInfoEN objQxDepartmentInfo in arrCollegeObjList)  //QxDepartmentInfo
            {

                tnCollege = getTreeNodeByTabObj(objQxDepartmentInfo, objWucTV, 1);
                tnXzSchool.ChildNodes.Add(tnCollege);
            }


            //			objTV.ExpandAll();
            objTV.Nodes[0].Select();
            objTV.Nodes[0].Select();
        }

        public static void Bindtv_vQxDepartmentInfoByUserNum(wucTreeView objWucTV)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            string strCondition = string.Format(" {0}='1' order by {1}",
                            convQxDepartmentInfoByUserNum.InUse,
                convQxDepartmentInfoByUserNum.OrderNum);

            List<clsvQxDepartmentInfoByUserNumEN> arrvQxDepartmentInfoByUserNumObjList = clsvQxDepartmentInfoByUserNumBL.GetObjLst(strCondition);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnvQxDepartmentInfoByUserNum = null, tnQxUsers = null; //,tnRange = null;
            objTV.Nodes.Clear();
            tnRoot.Value = "root,root";

            tnRoot.Text = "所有角色";
            //			tnRoot.CheckBox=true;
            objTV.Nodes.Add(tnRoot);

            //objTV.NodeStyle = "aa";
            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            foreach (clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNum in arrvQxDepartmentInfoByUserNumObjList) //XzXzSchool
            {
                tnvQxDepartmentInfoByUserNum = getTreeNodeByTabObj(objvQxDepartmentInfoByUserNum, objWucTV, 1);
                tnvQxDepartmentInfoByUserNum.Text = string.Format("{0}({1})",
                    objvQxDepartmentInfoByUserNum.DepartmentName,
                    objvQxDepartmentInfoByUserNum.UserNum);

                tnRoot.ChildNodes.Add(tnvQxDepartmentInfoByUserNum);
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_QxDepartmentInfo_QxUsers(wucTreeView objWucTV, string strQxPrjId)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            string strCondition = string.Format(" {0}='1' order by {1}",
                            conQxDepartmentInfo.InUse,
                conQxDepartmentInfo.OrderNum);

            List<clsQxDepartmentInfoEN> arrQxDepartmentInfoObjList = clsQxDepartmentInfoBL.GetObjLst(strCondition);

            string strCondition_Users = string.Format("{0} in (Select {0} From {1} Where {2}='{3}') order by {4}",
              conQxUsers.UserId,
              conQxPrjUserRelation._CurrTabName,
              conQxPrjUserRelation.QxPrjId, strQxPrjId,
              conQxUsers.UserName);

            List<clsQxUsersEN> arrQxUsersObjList = clsQxUsersBL.GetObjLst(strCondition);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnQxDepartmentInfo = null, tnQxUsers = null; //,tnRange = null;
            objTV.Nodes.Clear();
            tnRoot.Value = "root, root";

            tnRoot.Text = "所有部门";
            //			tnRoot.CheckBox=true;
            objTV.Nodes.Add(tnRoot);

            //objTV.NodeStyle = "aa";
            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            foreach (clsQxDepartmentInfoEN objQxDepartmentInfo in arrQxDepartmentInfoObjList) //XzXzSchool
            {
                tnQxDepartmentInfo = getTreeNodeByTabObj(objQxDepartmentInfo, objWucTV, 1);
                //tnQxDepartmentInfo.Text = string.Format("{0}({1})",
                //    objQxDepartmentInfo.DepartmentName,
                //    objQxDepartmentInfo.UserNum);

                tnRoot.ChildNodes.Add(tnQxDepartmentInfo);
                foreach (clsQxUsersEN objQxUsers in arrQxUsersObjList) //XzXzSchool
                {
                    if (objQxUsers.DepartmentId != objQxDepartmentInfo.DepartmentId) continue;
                    tnQxUsers = getTreeNodeByTabObj(objQxUsers, objWucTV, 2);
                    tnQxDepartmentInfo.ChildNodes.Add(tnQxUsers);
                }

            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_QxUserGroups_QxUsers(wucTreeView objWucTV, string strQxPrjId)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            string strCondition = string.Format(" {0}='{1}' order by {3}",
                            conQxUserGroups.QxPrjId, strQxPrjId,
                conQxUserGroups.GroupName);

            List<clsQxUserGroupsEN> arrQxUserGroupsObjList = clsQxUserGroupsBL.GetObjLst(strCondition);

            string strCondition_Users = string.Format("{0} in (Select {0} From {1} Where {2}='{3}') order by {4}",
              conQxUserGroupRelation.UserId,
              convQxPrjUserRelation._CurrTabName,
              convQxPrjUserRelation.QxPrjId, strQxPrjId,
              conQxUserGroupRelation.UserId);

            List<clsQxUserGroupRelationEN> arrQxUserGroupRelationObjList = clsQxUserGroupRelationBL.GetObjLst(strCondition);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnQxUserGroups = null, tnQxUsers = null; //,tnRange = null;
            objTV.Nodes.Clear();
            tnRoot.Value = "root, root";

            tnRoot.Text = "所有部门";
            //			tnRoot.CheckBox=true;
            objTV.Nodes.Add(tnRoot);

            //objTV.NodeStyle = "aa";
            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            foreach (clsQxUserGroupsEN objQxUserGroups in arrQxUserGroupsObjList) //XzXzSchool
            {
                tnQxUserGroups = getTreeNodeByTabObj(objQxUserGroups, objWucTV, 1);
                //tnQxUserGroups.Text = string.Format("{0}({1})",
                //    objQxUserGroups.DepartmentName,
                //    objQxUserGroups.UserNum);

                tnRoot.ChildNodes.Add(tnQxUserGroups);
                foreach (clsQxUserGroupRelationEN objQxUserGroupRelation in arrQxUserGroupRelationObjList) //XzXzSchool
                {
                    if (objQxUserGroupRelation.GroupId != objQxUserGroups.GroupId) continue;
                    clsQxUsersEN objQxUsers = clsQxUsersBL.GetObjByUserIdCache(objQxUserGroupRelation.UserId);
                    tnQxUsers = getTreeNodeByTabObj(objQxUsers, objWucTV, 2);
                    tnQxUserGroups.ChildNodes.Add(tnQxUsers);
                }

            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_QxUserRoles(wucTreeView objWucTV, string strQxPrjId)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            string strCondition = string.Format("{0}='{1}'  order by {2}",
                conQxRoles.QxPrjId, strQxPrjId,
                conQxRoles.RoleIndex);

            List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(strCondition);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnQxUserRoles = null, tnQxUsers = null; //,tnRange = null;
            objTV.Nodes.Clear();
            tnRoot.Value = "root,root";

            tnRoot.Text = "所有角色";
            //			tnRoot.CheckBox=true;
            objTV.Nodes.Add(tnRoot);

            //objTV.NodeStyle = "aa";
            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList) //XzXzSchool
            {
                tnQxUserRoles = getTreeNodeByTabObj(objQxUserRoles, objWucTV, 1);
                tnRoot.ChildNodes.Add(tnQxUserRoles);
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_QxUsers(wucTreeView objWucTV, string strQxPrjId)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2}='{3}') order by {4}",
                conQxUsers.UserId,
                conQxPrjUserRelation._CurrTabName,
                conQxPrjUserRelation.QxPrjId, strQxPrjId,
                conQxUsers.UserName);

            List<clsQxUsersEN> arrQxUsersObjList = clsQxUsersBL.GetObjLst(strCondition);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnQxUsers = null; //,tnRange = null;
            objTV.Nodes.Clear();
            tnRoot.Value = "root,root";

            tnRoot.Text = "所有用户";
            //			tnRoot.CheckBox=true;
            objTV.Nodes.Add(tnRoot);

            //objTV.NodeStyle = "aa";
            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            foreach (clsQxUsersEN objQxUsers in arrQxUsersObjList) //XzXzSchool
            {
                tnQxUsers = getTreeNodeByTabObj(objQxUsers, objWucTV, 1);
                tnRoot.ChildNodes.Add(tnQxUsers);
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_vQxUserRolesByUserNum(wucTreeView objWucTV, string strQxPrjId)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            string strCondition = string.Format("{0}='{1}' And {2}='1' order by {3}",
                convQxUserRolesByUserNum.QxPrjId, strQxPrjId,
                convQxUserRolesByUserNum.IsInUse,
                convQxUserRolesByUserNum.RoleIndex);

            List<clsvQxUserRolesByUserNumEN> arrvQxUserRolesByUserNumObjList = clsvQxUserRolesByUserNumBL.GetObjLst(strCondition);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnvQxUserRolesByUserNum = null, tnQxUsers = null; //,tnRange = null;
            objTV.Nodes.Clear();
            tnRoot.Value = "root,root";

            tnRoot.Text = "所有角色";
            //			tnRoot.CheckBox=true;
            objTV.Nodes.Add(tnRoot);

            //objTV.NodeStyle = "aa";
            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            foreach (clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNum in arrvQxUserRolesByUserNumObjList) //XzXzSchool
            {
                tnvQxUserRolesByUserNum = getTreeNodeByTabObj(objvQxUserRolesByUserNum, objWucTV, 1);
                tnvQxUserRolesByUserNum.Text = string.Format("{0}({1})", objvQxUserRolesByUserNum.RoleName, objvQxUserRolesByUserNum.UserNum);
                tnRoot.ChildNodes.Add(tnvQxUserRolesByUserNum);
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_vQxRolesByMenuNum(wucTreeView objWucTV, string strQxPrjId)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            string strCondition = string.Format("{0}='{1}' And {2}='1' order by {3}",
                convQxRolesByMenuNum.QxPrjId, strQxPrjId,
                convQxRolesByMenuNum.IsInUse,
                convQxRolesByMenuNum.RoleIndex);

            List<clsvQxRolesByMenuNumEN> arrvQxRolesByMenuNumObjList = clsvQxRolesByMenuNumBL.GetObjLst(strCondition);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnvQxRolesByMenuNum = null, tnQxUsers = null; //,tnRange = null;
            objTV.Nodes.Clear();
            tnRoot.Value = "root,root";

            tnRoot.Text = "所有角色";
            //			tnRoot.CheckBox=true;
            objTV.Nodes.Add(tnRoot);

            //objTV.NodeStyle = "aa";
            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            foreach (clsvQxRolesByMenuNumEN objvQxRolesByMenuNum in arrvQxRolesByMenuNumObjList) //XzXzSchool
            {
                tnvQxRolesByMenuNum = getTreeNodeByTabObj(objvQxRolesByMenuNum, objWucTV, 1);
                tnvQxRolesByMenuNum.Text = string.Format("{0}({1})", objvQxRolesByMenuNum.RoleName, objvQxRolesByMenuNum.MenuNum);
                tnRoot.ChildNodes.Add(tnvQxRolesByMenuNum);
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_vQxUserRolesByPotenceNum(wucTreeView objWucTV, string strQxPrjId)
        {
            TreeView objTV = objWucTV.objCurrTreeView;
            string strCondition = string.Format("{0}='{1}' And {2}='1' order by {3}",
                convQxUserRolesByPotenceNum.QxPrjId, strQxPrjId,
                convQxUserRolesByPotenceNum.IsInUse,
                convQxUserRolesByPotenceNum.RoleIndex);

            List<clsvQxUserRolesByPotenceNumEN> arrvQxUserRolesByPotenceNumObjList = clsvQxUserRolesByPotenceNumBL.GetObjLst(strCondition);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnvQxUserRolesByPotenceNum = null, tnQxUsers = null; //,tnRange = null;
            objTV.Nodes.Clear();
            tnRoot.Value = "root,root";

            tnRoot.Text = "所有角色";
            //			tnRoot.CheckBox=true;
            objTV.Nodes.Add(tnRoot);

            //objTV.NodeStyle = "aa";
            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            foreach (clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNum in arrvQxUserRolesByPotenceNumObjList) //XzXzSchool
            {
                tnvQxUserRolesByPotenceNum = getTreeNodeByTabObj(objvQxUserRolesByPotenceNum, objWucTV, 1);
                tnvQxUserRolesByPotenceNum.Text = string.Format("{0}({1})", objvQxUserRolesByPotenceNum.RoleName, objvQxUserRolesByPotenceNum.PotenceNum);
                tnRoot.ChildNodes.Add(tnvQxUserRolesByPotenceNum);
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        private static TreeNode getTreeNodeByTabObj(clsEntityBase2 objTabObj, wucTreeView objWucTV, int intLevel)
        {
            if (string.IsNullOrEmpty(objTabObj._KeyId) == true)
            {
                string strMsg = string.Format("在绑定树的过程中，表对象({0})的关键字为空！", objTabObj._TabName_Curr);
                throw new Exception(strMsg);
            }
            TreeNode objTN = new TreeNode();
            objTN.Value = string.Format("{0},{1}",
                    objTabObj._TabName_Curr,
                    objTabObj._KeyId);
            objTN.Text = objTabObj._NameValue;
            objTN.ShowCheckBox = objWucTV.ShowCheckBox;
            if (intLevel == 1)
            {
                objTN.ImageUrl = objWucTV.ImageUrl_L1;
            }
            if (intLevel == 2)
            {
                objTN.ImageUrl = objWucTV.ImageUrl_L2;
            }
            if (intLevel == 3)
            {
                objTN.ImageUrl = objWucTV.ImageUrl_L3;
            }
            return objTN;
        }


    }
}
//public static void Bindtv_Course_Grade_QxUsers_QxUserRoles(wucTreeView objWucTV)
//{
//TreeView objTV = objWucTV.objCurrTreeView;
//    string strCondition_XzSchool = string.Format("{0}='1'  order by {1}", conQxPrjTab.IsCurrentUse, conQxPrjTab.SchoolId);
//    List<clsXzSchoolEN> arrXzSchoolObjList = clsXzSchoolBL.GetObjLst(strCondition_XzSchool);
//    List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(" 1=1 ");
//    List<clsQxPrjPotenceEN> arrCourseObjList = clsQxPrjPotenceBL.GetObjLst(" id_Course<>'00000000'");
//    List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjList = clsvQxPrjMenus_UpBL.GetObjLst(" 1=1 ");
//    List<clsQxUsersEN> arrQxUsersObjList = clsQxUsersBL.GetObjLst(" 1=1 ");

//    TreeNode tnRoot = new TreeNode();
//    TreeNode tnQxUserRoles = null, tnvQxPrjMenus_Up = null, tnQxUsers = null; //,tnRange = null;
//    TreeNode tnXzSchool = null;
//    TreeNode tnCourse = null;

//    objTV.Nodes.Clear();

//    //tnRoot.Value = "Root,0000";
//    //tnRoot.Text = "上海师范大学";
//    //objTV.Nodes.Add(tnRoot);
//    foreach (clsXzSchoolEN objXzSchool in arrXzSchoolObjList) //XzXzSchool
//    {
//        tnXzSchool = new TreeNode();
//        tnXzSchool.Value = string.Format("{0},{1}",
//            clsXzSchoolEN._CurrTabName, objXzSchool.IdSchool);
//        tnXzSchool.Text = objXzSchool.SchoolName;
//        objTV.Nodes.Add(tnXzSchool);
//        foreach (clsQxPrjPotenceEN objQxPrjPotence in arrCourseObjList) //XzMajor
//        {
//            tnCourse = new TreeNode();
//            tnCourse.Value = string.Format("{0},{1}",
//                clsQxPrjPotenceEN._CurrTabName, objQxPrjPotence.id_Course);
//            tnCourse.Text = objQxPrjPotence.CourseName;
//            tnXzSchool.ChildNodes.Add(tnCourse);
//            foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_Up in arrvQxPrjMenus_UpObjList) //XzXzSchool
//            {
//                tnvQxPrjMenus_Up = new TreeNode();
//                tnvQxPrjMenus_Up.Value = string.Format("{0},{1}",
//                    clsvQxPrjMenus_UpEN._CurrTabName,
//                    objvQxPrjMenus_Up.id_Grade);
//                tnvQxPrjMenus_Up.Text = objvQxPrjMenus_Up.GradeName;
//                tnCourse.ChildNodes.Add(tnvQxPrjMenus_Up);
//                foreach (clsQxUsersEN objQxUsers in arrQxUsersObjList) //XzMajor
//                {
//                    if (objQxUsers.id_Grade != objvQxPrjMenus_Up.id_Grade
//                        || objQxUsers.id_Course != objQxPrjPotence.id_Course) continue;
//                    tnQxUsers = new TreeNode();
//                    tnQxUsers.Value = string.Format("{0},{1}",
//                        clsQxUsersEN._CurrTabName,
//                        objQxUsers.UserId);
//                    tnQxUsers.Text = string.Format("{0}{1}",
//                        objQxUsers.ExamDate, clsCjScoreKindBL.GetScoreKindNameByid_ScoreKind_Cache(objQxUsers.id_ScoreKind));
//                    tnvQxPrjMenus_Up.ChildNodes.Add(tnQxUsers);
//                    foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList)  //QxUserRoles
//                    {
//                        tnQxUserRoles = new TreeNode();
//                        tnQxUserRoles.Value = string.Format("{0},{1}",
//                           clsQxRolesEN._CurrTabName,
//                           objQxUserRoles.RoleId);
//                        tnQxUserRoles.Text = objQxUserRoles.StatsModeName;
//                        tnQxUsers.ChildNodes.Add(tnQxUserRoles);
//                    }//foreach (clsQxRolesEN
//                }//foreach (clsQxUsersEN
//                if (tnvQxPrjMenus_Up.ChildNodes.Count == 0)
//                {
//                    tnCourse.ChildNodes.Remove(tnvQxPrjMenus_Up);
//                }
//            }
//        }
//    }

//    //			objTV.ExpandAll();
//    try
//    {
//        objTV.Nodes[0].Select();
//    }
//    catch (Exception objException)
//    {
//        throw objException;

//    }
//}

//public static void Bindtv_Course_Grade_QxUserRoles_QxUsers(wucTreeView objWucTV)
//{
//TreeView objTV = objWucTV.objCurrTreeView;
//    string strCondition_XzSchool = string.Format("{0}='1'  order by {1}", conQxPrjTab.IsCurrentUse, conQxPrjTab.SchoolId);
//    List<clsXzSchoolEN> arrXzSchoolObjList = clsXzSchoolBL.GetObjLst(strCondition_XzSchool);
//    List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(" 1=1 ");
//    List<clsQxPrjPotenceEN> arrCourseObjList = clsQxPrjPotenceBL.GetObjLst(" id_Course<>'00000000'");
//    List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjList = clsvQxPrjMenus_UpBL.GetObjLst(" 1=1 ");
//    List<clsQxUsersEN> arrQxUsersObjList = clsQxUsersBL.GetObjLst(" 1=1 ");
//    List<clsQxPotenceTypeEN> arrQxPotenceTypeObjList = clsQxPotenceTypeBL.GetObjLst(" 1=1 ");

//    TreeNode tnRoot = new TreeNode();
//    TreeNode tnQxUserRoles = null, tnvQxPrjMenus_Up = null, tnQxUsers = null; //,tnRange = null;
//    TreeNode tnXzSchool = null;
//    TreeNode tnCourse = null;
//    TreeNode tnQxPotenceType = null;
//    objTV.Nodes.Clear();

//    //tnRoot.Value = "Root,0000";
//    //tnRoot.Text = "上海师范大学";
//    //objTV.Nodes.Add(tnRoot);
//    foreach (clsXzSchoolEN objXzSchool in arrXzSchoolObjList) //XzXzSchool
//    {
//        tnXzSchool = new TreeNode();
//        tnXzSchool.Value = string.Format("{0},{1}",
//            clsXzSchoolEN._CurrTabName, objXzSchool.IdSchool);
//        tnXzSchool.Text = objXzSchool.SchoolName;
//        objTV.Nodes.Add(tnXzSchool);
//        foreach (clsQxPrjPotenceEN objQxPrjPotence in arrCourseObjList) //XzMajor
//        {
//            tnCourse = new TreeNode();
//            tnCourse.Value = string.Format("{0},{1}",
//                clsQxPrjPotenceEN._CurrTabName, objQxPrjPotence.id_Course);
//            tnCourse.Text = objQxPrjPotence.CourseName;
//            tnXzSchool.ChildNodes.Add(tnCourse);
//            foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_Up in arrvQxPrjMenus_UpObjList) //XzXzSchool
//            {
//                tnvQxPrjMenus_Up = new TreeNode();
//                tnvQxPrjMenus_Up.Value = string.Format("{0},{1}",
//                    clsvQxPrjMenus_UpEN._CurrTabName,
//                    objvQxPrjMenus_Up.id_Grade);
//                tnvQxPrjMenus_Up.Text = objvQxPrjMenus_Up.GradeName;
//                tnCourse.ChildNodes.Add(tnvQxPrjMenus_Up);
//                foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList)  //QxUserRoles
//                {
//                    tnQxUserRoles = new TreeNode();
//                    tnQxUserRoles.Value = string.Format("{0},{1}",
//                       clsQxRolesEN._CurrTabName,
//                       objQxUserRoles.RoleId);
//                    tnQxUserRoles.Text = objQxUserRoles.StatsModeName;
//                    tnvQxPrjMenus_Up.ChildNodes.Add(tnQxUserRoles);
//                    if (objQxUserRoles.RoleId == enumQxUserRoles.GradeQxUsersStatsistics_04)
//                    {
//                        foreach (clsQxPotenceTypeEN objQxPotenceType in arrQxPotenceTypeObjList) //XzMajor
//                        {
//                            if (objQxPotenceType.id_Grade != objvQxPrjMenus_Up.id_Grade
//                                || objQxPotenceType.IdSchool != objXzSchool.IdSchool) continue;
//                            tnQxPotenceType = new TreeNode();
//                            tnQxPotenceType.Value = string.Format("{0},{1}",
//                                clsQxPotenceTypeEN._CurrTabName,
//                                objQxPotenceType.PotenceTypeId);
//                            tnQxPotenceType.Text = objQxPotenceType.QxPotenceTypeName.Replace(objvQxPrjMenus_Up.GradeName, "");
//                            tnQxUserRoles.ChildNodes.Add(tnQxPotenceType);

//                        }//foreach (clsQxPotenceTypeEN
//                    }
//                    else
//                    {
//                        foreach (clsQxUsersEN objQxUsers in arrQxUsersObjList) //XzMajor
//                        {
//                            if (objQxUsers.id_Grade != objvQxPrjMenus_Up.id_Grade
//                                || objQxUsers.id_Course != objQxPrjPotence.id_Course) continue;
//                            tnQxUsers = new TreeNode();
//                            tnQxUsers.Value = string.Format("{0},{1}",
//                                clsQxUsersEN._CurrTabName,
//                                objQxUsers.UserId);
//                            tnQxUsers.Text = string.Format("{0}{1}",
//                                objQxUsers.ExamDate, clsCjScoreKindBL.GetScoreKindNameByid_ScoreKind_Cache(objQxUsers.id_ScoreKind));
//                            tnQxUserRoles.ChildNodes.Add(tnQxUsers);

//                        }//foreach (clsQxUsersEN
//                    }
//                }//foreach (clsQxRolesEN 
//                if (tnvQxPrjMenus_Up.ChildNodes.Count == 0)
//                {
//                    tnCourse.ChildNodes.Remove(tnvQxPrjMenus_Up);
//                }
//            }
//        }
//    }

//    //			objTV.ExpandAll();
//    try
//    {
//        objTV.Nodes[0].Select();
//    }
//    catch (Exception objException)
//    {
//        throw objException;
//    }
//}

//public static void Bindtv_Grade_Course_QxUsers(wucTreeView objWucTV)
//{
//TreeView objTV = objWucTV.objCurrTreeView;
//    string strCondition_XzSchool = string.Format("{0}='1'  order by {1}", conQxPrjTab.IsCurrentUse, conQxPrjTab.SchoolId);
//    //List<clsXzSchoolEN> arrXzSchoolObjList = clsXzSchoolBL.GetObjLst(strCondition_XzSchool);
//    //List<clsQxRolesEN> arrQxUserRolesObjList = clsQxRolesBL.GetObjLst(" 1=1 ");
//    List<clsQxPrjPotenceEN> arrCourseObjList = clsQxPrjPotenceBL.GetObjLst(" id_Course<>'00000000'");
//    List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjList = clsvQxPrjMenus_UpBL.GetObjLst(" 1=1 ");
//    List<clsQxUsersEN> arrQxUsersObjList = clsQxUsersBL.GetObjLst(" 1=1 ");
//    //List<clsQxPotenceTypeEN> arrQxPotenceTypeObjList = clsQxPotenceTypeBL.GetObjLst(" 1=1 ");

//    TreeNode tnRoot = new TreeNode();
//    //TreeNode tnQxUserRoles = null;
//    TreeNode tnvQxPrjMenus_Up = null, tnQxUsers = null; //,tnRange = null;
//    //TreeNode tnXzSchool = null;
//    TreeNode tnCourse = null;
//    //TreeNode tnQxPotenceType = null;
//    objTV.Nodes.Clear();
//    //objTV.NodeStyle = "aa";
//    //tnRoot.Value = "Root,0000";
//    //tnRoot.Text = "上海师范大学";
//    //objTV.Nodes.Add(tnRoot);
//    //foreach (clsXzSchoolEN objXzSchool in arrXzSchoolObjList) //XzXzSchool
//    //{
//    //    tnXzSchool = new TreeNode();
//    //    tnXzSchool.Value = string.Format("{0},{1}",
//    //        clsXzSchoolEN._CurrTabName, objXzSchool.IdSchool);
//    //    tnXzSchool.Text = objXzSchool.SchoolName;
//    //    objTV.Nodes.Add(tnXzSchool);
//    foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_Up in arrvQxPrjMenus_UpObjList) //XzXzSchool
//    {
//        tnvQxPrjMenus_Up = getTreeNodeByTabObj(objvQxPrjMenus_Up);

//        objTV.Nodes.Add(tnvQxPrjMenus_Up);

//        //foreach (clsQxRolesEN objQxUserRoles in arrQxUserRolesObjList)  //QxUserRoles
//        //{
//        //    tnQxUserRoles = new TreeNode();
//        //    tnQxUserRoles.Value = string.Format("{0},{1}",
//        //       clsQxRolesEN._CurrTabName,
//        //       objQxUserRoles.RoleId);
//        //    tnQxUserRoles.Text = objQxUserRoles.StatsModeName;
//        //    tnvQxPrjMenus_Up.ChildNodes.Add(tnQxUserRoles);

//        foreach (clsQxPrjPotenceEN objQxPrjPotence in arrCourseObjList) //XzMajor
//        {

//            tnCourse = getTreeNodeByTabObj(objQxPrjPotence);

//            tnvQxPrjMenus_Up.ChildNodes.Add(tnCourse);

//            foreach (clsQxUsersEN objQxUsers in arrQxUsersObjList) //XzMajor
//            {
//                if (objQxUsers.id_Grade != objvQxPrjMenus_Up.id_Grade
//                    || objQxUsers.id_Course != objQxPrjPotence.id_Course) continue;

//                tnQxUsers = getTreeNodeByTabObj(objQxUsers);


//                tnQxUsers.Text = string.Format("{0}{1}",
//                    objQxUsers.ExamDate, clsCjScoreKindBL.GetScoreKindNameByid_ScoreKind_Cache(objQxUsers.id_ScoreKind));
//                tnCourse.ChildNodes.Add(tnQxUsers);

//            }//foreach (clsQxUsersEN
//            if (tnCourse.ChildNodes.Count == 0)
//            {
//                tnvQxPrjMenus_Up.ChildNodes.Remove(tnCourse);
//            }
//        }
//        if (tnvQxPrjMenus_Up.ChildNodes.Count == 0)
//        {
//            tnCourse.ChildNodes.Remove(tnvQxPrjMenus_Up);
//        }

//    }


//    //			objTV.ExpandAll();
//    try
//    {
//        objTV.Nodes[0].Select();
//    }
//    catch (Exception objException)
//    {
//        throw objException;
//    }
//}