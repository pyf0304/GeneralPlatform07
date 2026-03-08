using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeneralPlatform4WS;

using System.Collections;
using com.taishsoft.common;
using GeneralPlatform4WS.ServiceReferencevQxRoleMenusEx;
using GeneralPlatform4WS.ServiceReferenceQxRoleMenus;
using GeneralPlatform4WS.ServiceReferencevQxRoleMenus_Sim;
using com.taishsoft.datetime;
using GeneralPlatform4WS.ServiceReferenceQxDepartmentInfo;
using GeneralPlatform4WS.ServiceReferenceQxUserRoles;
using GeneralPlatform4WS.ServiceReferenceQxUsers;
using GeneralPlatform4WS.ServiceReferencevQxUsers;
using GeneralPlatform4WS.ServiceReferenceQxPrjUserRelation;

namespace TestGeneralPF_WS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 根据条件获取用户的DataTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable objDT = clsQxUserRolesWS.GetDataTable_QxUserRolesWs("1=1");
            //dataGridView1.DataSource = objDT;

            //DataTable objDT = clsQxUsersWSBak20141103.GetDataTable_QxUsersVWs("UserId='00701'");
            //dataGridView1.DataSource = objDT;

        }
        /// <summary>
        /// 根据用户ID获取角色ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> lstRoleId = clsQxUsersExWS.GetRoleIdLstByUserId("pyf", "0001");
            foreach (string strRoleId in lstRoleId)
            {
                listBox1.Items.Add(strRoleId);
            }

            //clsQxPrjPotence objPrjPotence = clsQxUsersExWS.GetQxPrjPotenceObjByPotenceName("0086", "lf", "文章审核");

            //clsvQxUsers objvUsers = clsvQxUsersWS.GetvUsersWs("pyf");

            //listBox1.Items.Add(objvUsers.UserName);
            //listBox1.Items.Add(objvUsers.IdentityDesc);
            //listBox1.Items.Add(objvUsers.DepartmentName);
            //listBox1.Items.Add(objvUsers.GradeBaseID);
            //listBox1.Items.Add(objvUsers.GradeBaseName);


        }
        /// <summary>
        /// 根据用户ID获取角色相关表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //DataTable objDT = clsQxUserRoleRelationWS.GetDataTableVWs("UserId='pyf'");
            //dataGridView1.DataSource = objDT;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> lst = clsSubjectRelationExWS.GetUserIdLstByLeader("jwc0");
            foreach (string ss in lst)
            {
                listBox1.Items.Add(ss);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ss = clsQxUsersExWS.GetEnterSchoolYearByUserId("1000000169");
            string ss1 = clsQxUsersExWS.GetEnterSchoolDateByUserId("1000000169");

            listBox1.Items.Add(ss);
            listBox1.Items.Add(ss1);

        }

        /// <summary>
        /// 根据用户ID获取用户对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {

            clsQxUsersEN objvUsers = new clsQxUsersEN();
            objvUsers.UserId = "pyf";
            clsQxUsersWS.GetQxUsersWs(ref objvUsers);
            listBox1.Items.Add(objvUsers.UserName);
            //listBox1.Items.Add(objvUsers.IdentityID);
            listBox1.Items.Add(objvUsers.DepartmentId);

        }
        /// <summary>
        /// 根据用户ID获取用户名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            string ss = clsQxUsersExWS.GetUserNameByUserId("qf");

            listBox1.Items.Add(ss);

        }
        /// <summary>
        /// 获取部门列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            List<clsQxDepartmentInfoEN> arr = clsQxDepartmentInfoWS.GetObjLst(" 1=1");
            foreach (clsQxDepartmentInfoEN obj in arr)
            {
                listBox1.Items.Add(obj.DepartmentName);
            }
        }
        /// <summary>
        /// 测试用户登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                bool bolIsSuccess = clsLoginWS.UserLogin("00701", "222222");
                MessageBox.Show(bolIsSuccess.ToString());
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
            //bool bolIsSuccess = clsLoginWS.UserLogin("pyf", "mm012345");
        }
        /// <summary>
        /// 测试添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            clsQxUsersEN objUsers = new clsQxUsersEN();
            objUsers.UserId = "99998";
            objUsers.UserName = "测试";
            objUsers.UserStateId = "01";
         
            objUsers.Password = "111111";
            objUsers.DepartmentId = "";
            objUsers.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objUsers.UpdUser = "Test";
            objUsers.Memo = "由教育高地导入到统一平台:";

            GeneralPlatform4WS.clsQxUsersExWS.AddNewUsers(objUsers, "0101", "01010004");
            GeneralPlatform4WS.clsQxUsersExWS.AddUserRoleRelation(objUsers.UserId, "01010003");

        }
        /// <summary>
        /// 测试添加角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            //测试添加角色
            try
            {
                clsQxUserRolesEN objUserRoles = new clsQxUserRolesEN();
                objUserRoles.RoleId = "01010033";
                objUserRoles.RoleName = "测试";
                objUserRoles.QxPrjId = "0101";
                objUserRoles.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objUserRoles.UpdUserId = "WebService";

                objUserRoles.Memo = "由OA系统导入到统一平台:";
                if (GeneralPlatform4WS.clsQxUserRolesWS.IsExistWs(objUserRoles.RoleId) == true)
                {
                    MessageBox.Show("已经存在该角色，不能再添加！");
                    return;
                }
                GeneralPlatform4WS.clsQxUserRolesWS.AddNewRecordBySql2Ws(objUserRoles);
                MessageBox.Show("添加角色成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat("QxPrjId='0001'");
            //List<clsQxUserRolesEN> arrUserRolesObjLst = null;
            //try
            //{
            //    arrUserRolesObjLst = clsQxUserRolesWS.GetQxUserRolesObjList(sbCondition.ToString());
            //}
            //catch (Exception objException)
            //{
            //    MessageBox.Show(objException.Message);
            //    return;
            //}
            //foreach (clsQxUserRolesEN objUserRoles in arrUserRolesObjLst)
            //{
            //    listBox1.Items.Add(objUserRoles.RoleName);
            //}
            //BindCbo_RoleId(cboUserRoles, arrUserRolesObjLst);
        }
        public void BindCbo_RoleId(System.Windows.Forms.ComboBox objComboBox, List<clsQxUserRolesEN> arrUserRolesObjLst)
        {
            //为数据源为表的下拉框设置内容
            clsQxUserRolesEN objUserRoles;
            //初始化一个对象列表
            ArrayList UserRolesList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”，为了方便用户，与WEB方式类似。
            objUserRoles = new clsQxUserRolesEN();
            objUserRoles.RoleId = "0";
            objUserRoles.RoleName = "请选择...";
            UserRolesList.Add(objUserRoles);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsQxUserRolesEN objUserRoles1 in arrUserRolesObjLst)
            {
                objUserRoles = new clsQxUserRolesEN();
                objUserRoles.RoleId = objUserRoles1.RoleId;
                objUserRoles.RoleName = objUserRoles1.RoleName;
                UserRolesList.Add(objUserRoles);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = UserRolesList;
            objComboBox.ValueMember = "RoleId";
            objComboBox.DisplayMember = "RoleName";
            objComboBox.SelectedIndex = 0;
        }

        private void cboUserRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strRoleId = "";
            if (cboUserRoles.SelectedIndex > 0)
            {
                strRoleId = cboUserRoles.SelectedValue.ToString();
                //StringBuilder sbCondition = new StringBuilder();
                //sbCondition.AppendFormat("PrjId='0072' and RoleId='{0}'", strRoleId);
                ////sbCondition.Append("PrjId='0072'");
                //ArrayList arrvQxRoleMenusObjLst = clsvQxRoleMenusWS.GetvQxRoleMenusObjList(sbCondition.ToString());
                //listBox1.Items.Clear();
                //foreach (clsvQxRoleMenus objvQxRoleMenus in arrvQxRoleMenusObjLst)
                //{
                //    listBox1.Items.Add(objvQxRoleMenus.MenuName);
                //}


                List<clsvQxRoleMenusEN> arrUpMenuObjLst = clsvQxRoleMenusWSEx.GetUpMenuObjList(strRoleId, "0072");
                List<clsvQxRoleMenusEN> arrSubMenuObjLst = clsvQxRoleMenusWSEx.GetSubMenuObjList(strRoleId, "0072");
                treeView1.Nodes.Clear();
                foreach (clsvQxRoleMenusEN objUpQxRoleMenus in arrUpMenuObjLst)
                {

                    TreeNode objUpTreeNode = new TreeNode();
                    objUpTreeNode.Text = objUpQxRoleMenus.MenuName;
                    objUpTreeNode.Tag = objUpQxRoleMenus.MenuId;
                    treeView1.Nodes.Add(objUpTreeNode);
                    foreach (clsvQxRoleMenusEN objSubQxRoleMenus in arrSubMenuObjLst)
                    {
                        if (objSubQxRoleMenus.UpMenuId == objUpQxRoleMenus.MenuId)
                        {
                            TreeNode objSubTreeNode = new TreeNode();
                            objSubTreeNode.Text = objSubQxRoleMenus.MenuName;
                            objSubTreeNode.Tag = objSubQxRoleMenus.MenuId;
                            objUpTreeNode.Nodes.Add(objSubTreeNode);
                        }

                    }
                }
                treeView1.ExpandAll();

            }

        }
        /// <summary>
        /// 根据部门ID获取该部门的二级管理员ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            string strDepartmentId = "112";
            string strUserId = clsQxUsersExWS.GetManager2IdByDepartmentId(strDepartmentId);
            MessageBox.Show(strUserId);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MenuAndPotence objMenuAndPotence = new MenuAndPotence();
            string strSS = objMenuAndPotence.Get_UserMenu4CurrentUser_ThreeLayer("00010001","pyf", "0001");
            textBox1.Text = strSS;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            List<string> lst = clsCommDBFunctionWS.funGetFldValue("QxUsers", "Username", "UserId='pyf'");
            foreach (string ss in lst)
            {
                listBox1.Items.Add(ss);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string strUserId = clsLoginWS.GetUserIdByLoginName("pyf");
            MessageBox.Show(strUserId.ToString());
        }

        private void button16_Click(object sender, EventArgs e)
        {

            List<clsvQxRoleMenusEN> arrPrjSubMenu = clsvQxRoleMenusWSEx.GetSubMenuObjList("00010001", "0001");
            foreach (clsvQxRoleMenusEN obj in arrPrjSubMenu)
            {
                listBox1.Items.Add(obj.MenuName + obj.PageDispModeId);
            }
        }

        private void btnLoginByPrjId_Click(object sender, EventArgs e)
        {
            bool bolIsSuccess = clsLoginWS.UserLogin("pyf", "mm012345", "0001");
            MessageBox.Show(bolIsSuccess.ToString());
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            try
            {
                //List<clsvQxRoleMenus_SimEN> arrPrjUpMenu = GeneralPlatform4WS.clsvQxRoleMenus_SimWS.GetUpMenuObjList("00620001", "0062");
                List<clsvQxRoleMenusEN> arrPrjUpMenu = clsvQxRoleMenusWSEx.GetUpMenuObjList("00010001", "0001");
                //List<clsvQxRoleMenus_SimEN> arrPrjUpMenu = GeneralPlatform4WS.clsvQxUsersWS.GetUpMenuObjList("00620001", "0062");
                MessageBox.Show(arrPrjUpMenu.Count.ToString());
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                List<clsQxRoleMenusEN> arrPrjUpMenu = GeneralPlatform4WS.clsQxRoleMenusWS.GetObjLst("1=1");
                MessageBox.Show(arrPrjUpMenu.Count.ToString());
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                List<clsvQxUsersEN> arrPrjUpMenu = GeneralPlatform4WS.clsvQxUsersWS.GetObjLst("userid like '00%'");
                MessageBox.Show(arrPrjUpMenu.Count.ToString());
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnPrjUserRelation_Click(object sender, EventArgs e)
        {
            try
            {
                //List<clsvQxRoleMenus_SimEN> arrPrjUpMenu = GeneralPlatform4WS.clsvQxRoleMenus_SimWS.GetUpMenuObjList("00620001", "0062");
                List<clsQxPrjUserRelationEN> arrQxPrjUserRelation = clsQxPrjUserRelationWS.GetObjLst("PrjId='0062'");
                //List<clsvQxRoleMenus_SimEN> arrPrjUpMenu = GeneralPlatform4WS.clsvQxUsersWS.GetUpMenuObjList("00620001", "0062");
                MessageBox.Show(arrQxPrjUserRelation.Count.ToString());
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
//                List<clsvQxRoleMenusEN> arrPrjSubMenu = clsvQxRoleMenusWSEx.GetUpMenuObjList("00620001", "0062", "0001");
                List<clsvQxRoleMenusEN> arrPrjSubMenu = clsvQxRoleMenusWSEx.GetUpMenuObjList("01990010", "0199", "0001");
                foreach (clsvQxRoleMenusEN obj in arrPrjSubMenu)
                {
                    listBox1.Items.Add(obj.MenuName + obj.PageDispModeId);
                }
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> arrRoleId = new List<string>();
                arrRoleId.Add("00620001");
                arrRoleId.Add("00620002");

                List<clsvQxRoleMenusEN> arrPrjSubMenu = clsvQxRoleMenusWSEx.GetUpMenuObjListByRoleIds(arrRoleId, "0062", "0001");
                foreach (clsvQxRoleMenusEN obj in arrPrjSubMenu)
                {
                    listBox1.Items.Add(obj.MenuName + obj.PageDispModeId);
                }
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string strReturnValue = "";
            string strResult = TestWS.HelloWorld2Ws("pyf", ref strReturnValue);
            int c = TestWS.myAddWs(2, 3);
            string strMsg = string.Format("strResult={0}|strReturnValue={1}|c={2}", strResult, strReturnValue, c);
            MessageBox.Show(strMsg);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                //                List<clsvQxRoleMenusEN> arrPrjSubMenu = clsvQxRoleMenusWSEx.GetUpMenuObjList("00620001", "0062", "0001");
                List<clsvQxRoleMenusEN> arrPrjSubMenu = clsvQxRoleMenusWSEx.GetUpMenuObjList("0199");
                foreach (clsvQxRoleMenusEN obj in arrPrjSubMenu)
                {
                    listBox1.Items.Add(obj.MenuName + obj.PageDispModeId);
                }
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetIdByMenuSetName_Click(object sender, EventArgs e)
        {
            try
            {
                //                List<clsvQxRoleMenusEN> arrPrjSubMenu = clsvQxRoleMenusWSEx.GetUpMenuObjList("00620001", "0062", "0001");
               string strMenuSetId = clsQxPrjMenuSetWSEx.GetFirstIDByMenuSetName("排课管理", "0199");
                MessageBox.Show(strMenuSetId);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }
    }
}
