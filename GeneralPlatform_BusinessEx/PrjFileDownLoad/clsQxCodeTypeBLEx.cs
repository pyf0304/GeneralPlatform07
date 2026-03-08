using System;
using System.Collections.Generic;
using System.Text;
using GeneralPlatform.Entity;
using System.Data;
using System.Collections;
using GeneralPlatform.DAL;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.BusinessLogicEx
{
    public class clsQxCodeTypeBLEx : clsQxCodeTypeBL
    {
        public static void BindCbo_CodeTypeIdEx(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = new clsQxCodeTypeDA().GetQxCodeTypeId();
            clsQxCodeTypeEN objCodeTypeEN;
            //初始化一个对象列表
            ArrayList CodeTypeList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”，为了方便用户，与WEB方式类似。
            objCodeTypeEN = new clsQxCodeTypeEN();
            objCodeTypeEN.QxCodeTypeId = "0";
            objCodeTypeEN.CodeTypeName = "请选择...";
            CodeTypeList.Add(objCodeTypeEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objCodeTypeEN = new clsQxCodeTypeEN();
                objCodeTypeEN.QxCodeTypeId = objRow["QxCodeTypeId"].ToString();
                objCodeTypeEN.CodeTypeName = objRow["CodeTypeName"].ToString() + "(" + objRow["QxCodeTypeId"].ToString() + ")";
                CodeTypeList.Add(objCodeTypeEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = CodeTypeList;
            objComboBox.ValueMember = "QxCodeTypeId";
            objComboBox.DisplayMember = "CodeTypeName";
            objComboBox.SelectedIndex = 0;
        }

    }
}
