using System;
using System.Data;
using System.Text;
using System.Collections;
using SpecData;
using System.Configuration;
using System.Web.UI.WebControls;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;


namespace GeneralPlatform.BusinessLogic
{
    /// <summary>
    /// clsQxUserGroup_Functions 的摘要说明。
    /// </summary>
    public class clsQxUserGroup_Functions
    {
        //private string mstrPrjId = "";

        //public string QxPrjId
        //{
        //    get
        //    {
        //        return mstrPrjId;
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            //mintErrNo = 1;
        //        }
        //        else
        //        {
        //            mstrPrjId = value;
        //        }
        //    }
        //}

        ////public clsQxUserGroup_Functions()
        ////{
        ////    //
        ////    // TODO: 在此处添加构造函数逻辑
        ////    //
        ////    this.SetInit();
        ////}
        //public clsQxUserGroup_Functions(string strPrjId)
        //{
        //    //
        //    // TODO: 在此处添加构造函数逻辑
        //    //

        //    this.mstrPrjId = strPrjId;
        //    this.SetInit();

        //}

        //private void SetInit()
        //{
        //    if (this.mstrPrjId.Trim() == "")
        //    {
        //        this.mstrPrjId = ConfigurationSettings.AppSettings[clsQxProjectsEN.con_QxPrjId];
        //    }
        //}


        public bool Set_SingleUser_SingleGroup(string UserId, string GroupId, string strPrjId)
        {
            if (clsQxUserGroupRelationBL.IsExistRecord(string.Format(" userid='{0}' and groupid='{1}'", UserId, GroupId)))
            {
                return true;
            }
            else if (clsQxUsersBL.IsExist(UserId))
            {
                clsQxUserGroupRelationEN objUserGroupRelationEN = new clsQxUserGroupRelationEN();
                objUserGroupRelationEN.UserId = UserId;
                objUserGroupRelationEN.GroupId = GroupId;
                //objUserGroupRelationEN.Memo=Memo;
                objUserGroupRelationEN.QxPrjId = strPrjId;
                if (clsQxUserGroupRelationBL.AddNewRecordBySql2(objUserGroupRelationEN))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }

        public int Set_MultiUsers_SingleGroup(ArrayList arrUserId, string GroupId, string strPrjId)
        {
            if (arrUserId.Count == 0)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach (object objUserId in arrUserId)
                {

                    if (!clsQxUserGroupRelationBL.IsExistRecord(" userid='" + objUserId.ToString() + "' and groupid='" + GroupId + "'") && clsQxUsersBL.IsExist(objUserId.ToString()))
                    {

                        clsQxUserGroupRelationEN objUserGroupRelationEN = new clsQxUserGroupRelationEN();
                        objUserGroupRelationEN.UserId = objUserId.ToString();
                        objUserGroupRelationEN.GroupId = GroupId;
                        //objUserGroupRelationEN.Memo=Memo;
                        objUserGroupRelationEN.QxPrjId = strPrjId;
                        if (clsQxUserGroupRelationBL.AddNewRecordBySql2(objUserGroupRelationEN))
                        {
                            sum += 1;
                        }



                    }


                }
                return sum;
            }

        }

        public static int Set_SingleUser_MultiGroups(string UserId, ArrayList arrGroupId, string strPrjId)
        {
            if (arrGroupId.Count == 0 || !clsQxUsersBL.IsExist(UserId))
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach (object objGroupId in arrGroupId)
                {

                    if (!clsQxUserGroupRelationBL.IsExistRecord(string.Format(" userid='{0}' and groupid='{1}'", UserId, objGroupId.ToString())))
                    {
                        clsQxUserGroupRelationEN objUserGroupRelationEN = new clsQxUserGroupRelationEN();
                        objUserGroupRelationEN.UserId = UserId;
                        objUserGroupRelationEN.GroupId = objGroupId.ToString();
                        //objUserGroupRelationEN.Memo=Memo;
                        objUserGroupRelationEN.QxPrjId = strPrjId;
                        if (clsQxUserGroupRelationBL.AddNewRecordBySql2(objUserGroupRelationEN))
                        {
                            sum += 1;
                        }
                    }


                }
                return sum;
            }

        }


        public static bool Set_MultiUsers_MultiGroups(ArrayList arrUserId, ArrayList arrGroupId, string strPrjId)
        {
            if (arrGroupId.Count == 0 || arrUserId.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (object objUserId in arrUserId)
                {
                    foreach (object objGroupId in arrGroupId)
                    {

                        if (!clsQxUserGroupRelationBL.IsExistRecord(string.Format(" userid='{0}' and groupid='{1}'", objUserId.ToString(), objGroupId.ToString())) && clsQxUsersBL.IsExist(objUserId.ToString()))
                        {
                            clsQxUserGroupRelationEN objUserGroupRelationEN = new clsQxUserGroupRelationEN();
                            objUserGroupRelationEN.UserId = objUserId.ToString();
                            objUserGroupRelationEN.GroupId = objGroupId.ToString();
                            //objUserGroupRelationEN.Memo=Memo;
                            objUserGroupRelationEN.QxPrjId = strPrjId;
                            if (!clsQxUserGroupRelationBL.AddNewRecordBySql2(objUserGroupRelationEN))
                            {
                                return false;
                            }

                        }

                    }
                }
                return true;
            }

        }

        public bool Del_SingleUser_SingleGroup(string UserId, string GroupId)
        {
            if (clsQxUserGroupRelationBL.IsExistRecord(string.Format(" userid='{0}' and groupid='{1}'", UserId, GroupId)) && clsQxUsersBL.IsExist(UserId))
            {
                if (clsQxUserGroupRelationBL.DelQxUserGroupRelationsByCond(string.Format(" userid='{0}' and groupid='{1}'", UserId, GroupId)) > 0)
                {
                    return true;
                }




            }
            return false;

        }

        public int Del_MultiUsers_SingleGroup(ArrayList arrUserId, string GroupId)
        {
            if (arrUserId.Count == 0)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach (object objUserId in arrUserId)
                {

                    if (clsQxUserGroupRelationBL.IsExistRecord(string.Format(" userid='{0}' and groupid='{1}'", objUserId.ToString(), GroupId)) && clsQxUsersBL.IsExist(objUserId.ToString()))
                    {
                        if (clsQxUserGroupRelationBL.DelQxUserGroupRelationsByCond(string.Format(" userid='{0}' and groupid='{1}'", objUserId.ToString(), GroupId)) > 0)
                        {
                            sum += 1;
                        }


                    }


                }
                return sum;
            }

        }

        public int Del_SingleUser_MultiGroups(string UserId, ArrayList arrGroupId)
        {
            if (arrGroupId.Count == 0 || !clsQxUsersBL.IsExist(UserId))
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach (object objGroupId in arrGroupId)
                {

                    if (clsQxUserGroupRelationBL.IsExistRecord(string.Format(" userid='{0}' and groupid='{1}'", UserId, objGroupId.ToString())))
                    {


                        if (clsQxUserGroupRelationBL.DelQxUserGroupRelationsByCond(string.Format(" userid='{0}' and groupid='{1}'", UserId, objGroupId.ToString())) > 0)
                        {
                            sum += 1;
                        }
                    }


                }
                return sum;
            }

        }


        public bool Del_MultiUsers_MultiGroups(ArrayList arrUserId, ArrayList arrGroupId)
        {
            if (arrGroupId.Count == 0 || arrUserId.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (object objUserId in arrUserId)
                {
                    foreach (object objGroupId in arrGroupId)
                    {

                        if (clsQxUserGroupRelationBL.IsExistRecord(string.Format(" userid='{0}' and groupid='{1}'", objUserId.ToString(), objGroupId.ToString())) && clsQxUsersBL.IsExist(objUserId.ToString()))
                        {


                            if (clsQxUserGroupRelationBL.DelQxUserGroupRelationsByCond(string.Format(" userid='{0}' and groupid='{1}'", objUserId.ToString(), objGroupId.ToString())) == 0)
                            {
                                return false;
                            }

                        }

                    }
                }
                return true;
            }

        }


        public ArrayList Get_CkbList_SelectedArr(CheckBoxList objCkbList)
        {
            ArrayList arr = new ArrayList();

            if (objCkbList.Items.Count == 0)
            {
                return arr;
            }
            else
            {
                foreach (ListItem li in objCkbList.Items)
                {
                    if (li.Selected)
                    {
                        arr.Add(li.Value);
                    }

                }
                return arr;

            }
        }
        public ArrayList Get_ListBox_SelectedArr(ListBox objLb)
        {
            ArrayList arr = new ArrayList();

            if (objLb.Items.Count == 0)
            {
                return arr;
            }
            else
            {
                foreach (ListItem li in objLb.Items)
                {
                    if (li.Selected)
                    {
                        arr.Add(li.Value);
                    }

                }
                return arr;

            }
        }

        public ArrayList Get_CkbList_UnSelectedArr(CheckBoxList objCkbList)
        {
            ArrayList arr = new ArrayList();

            if (objCkbList.Items.Count == 0)
            {
                return arr;
            }
            else
            {
                foreach (ListItem li in objCkbList.Items)
                {
                    if (!li.Selected)
                    {
                        arr.Add(li.Value);
                    }

                }
                return arr;

            }
        }

        public ArrayList Get_WhereCondArr(string whereCond)
        {
            ArrayList arr = new ArrayList();

            if (whereCond.Trim() == "")
            {
                return arr;
            }
            else
            {
                DataTable objDt;
                objDt = clsQxUsersBL.GetDataTable_QxUsers(whereCond);
                if (objDt.Rows.Count == 0)
                {
                    return arr;
                }
                else
                {
                    foreach (DataRow dr in objDt.Rows)
                    {
                        arr.Add(dr["UserId"]);
                    }
                    return arr;
                }

            }





        }

        public void Set_CkbList(CheckBoxList objCkbList, string UserId)
        {
            if (objCkbList.Items.Count == 0)
            {
                return;
            }
            else
            {

                foreach (ListItem li in objCkbList.Items)
                {
                    if (clsQxUserGroupRelationBL.IsExistRecord(string.Format(" userid='{0}' and groupid='{1}'", UserId, li.Value)))
                    {
                        li.Selected = true;
                    }
                    else
                    {
                        li.Selected = false;
                    }

                }
            }
        }

        public void Set_CkbList_AllChecked(CheckBoxList objCkbList)
        {
            if (objCkbList.Items.Count == 0)
            {
                return;
            }
            else
            {

                foreach (ListItem li in objCkbList.Items)
                {
                    li.Selected = true;


                }
            }
        }

        public void Set_CkbList_AllUnChecked(CheckBoxList objCkbList)
        {
            if (objCkbList.Items.Count == 0)
            {
                return;
            }
            else
            {

                foreach (ListItem li in objCkbList.Items)
                {
                    li.Selected = false;

                }
            }
        }

        public void BindCkbList_GroupId(CheckBoxList objCkbList, string strPrjId)
        {
            DataTable objDt = this.GetGroupId(strPrjId);
            objCkbList.DataSource = objDt;
            objCkbList.DataTextField = "ZM";
            objCkbList.DataValueField = "GroupId";
            objCkbList.DataBind();


        }


        public System.Data.DataTable GetGroupId(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = string.Format("select GroupId, GroupName from {0} where {1}= '" + strPrjId + "'",
                clsQxUserGroupsEN._CurrTabName,
                conQxUserGroups.QxPrjId);
            clsSpecSQL mySql = new clsSpecSQL();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }

        public System.Data.DataTable GetQxUsers(string Wherecon)
        {
            //获取某学院所有专业信息
            string strSQL = "select u.*,s.userstate userstatemc from Users u left join UserState s on(u.userstateid=s.userstateid) where" + Wherecon;
            clsSpecSQL mySql = new clsSpecSQL();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_GroupId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetGroupId(strPrjId);
            objDDL.DataValueField = "GroupId";
            objDDL.DataTextField = "GroupName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public System.Data.DataTable GetDepartMent()
        {
            //获取某学院所有专业信息
            string strSQL = "select * from Departments ";
            clsSpecSQL mySql = new clsSpecSQL();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_Department(DropDownList objDDL)
        {
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = this.GetDepartMent();
            objDDL.DataValueField = "DepartmentId";
            objDDL.DataTextField = "DepartmentName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;

        }
    

        public ArrayList Get_DgCheckedArr(System.Web.UI.WebControls.DataGrid objDg)
        {
            ArrayList arr = new ArrayList();
            if (objDg.Items.Count == 0)
            {
                return arr;
            }
            else
            {

                foreach (DataGridItem li in objDg.Items)
                {

                    CheckBox cb = (CheckBox)li.Cells[0].FindControl("Ckb1");
                    if (cb != null && cb.Checked)
                    {
                        arr.Add(li.Cells[1].Text);

                    }

                }



                return arr;
            }
        }

        public void Set_AllDgCkecked(DataGrid objDg, CheckBox objCkbAll)
        {
            if (objDg.Items.Count == 0)
            {
                return;
            }
            else
            {
                foreach (DataGridItem li in objDg.Items)
                {

                    CheckBox cb = (CheckBox)li.Cells[0].FindControl("Ckb1");
                    if (objCkbAll != null)
                    {
                        cb.Checked = objCkbAll.Checked;

                    }

                }


            }

        }
    }
}
