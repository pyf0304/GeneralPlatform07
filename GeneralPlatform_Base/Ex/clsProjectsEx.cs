using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GeneralPlatform.Entity
{
    public class clsQxProjectsENEx : clsQxProjectsEN
    {

        public List<clsQxUserRolesEN> arrUserRolesobjLst = null;
        public List<clsQxPrjMenusEN> arrQxPrjMenusobjLst = null;
        public List<clsQxRoleMenusEN> arrQxRoleMenusobjLst = null;
        public List<clsQxUserGroupsEN> arrUserGroupsobjLst = null;
        public List<clsQxPotenceTypeEN> arrPotenceTypeobjLst = null;
        public List<clsQxPrjPotenceEN> arrPrjPotenceobjLst = null;
        public List<clsQxRelaOfPotenceAndSymbolEN> arrRelaOfPotenceAndSymbolobjLst = null;
        public List<clsQxUserGroupPotenceEN> arrUserGroupPotenceobjLst = null;
        //public ArrayList arrUserGroupPotenceobjLst = null;
        //public ArrayList arrUserGroupPotenceobjLst = null;
        //public ArrayList arrUserGroupPotenceobjLst = null;

        //源连接串
        private string mstrConnectStringS = "";

        public string ConnectStringS
        {
            get { return mstrConnectStringS; }
            set { mstrConnectStringS = value; }
        }

        public clsQxProjectsENEx()
            : base()
        {
        }
        public clsQxProjectsENEx(string strPrjId)
            : base(strPrjId)
        {

        }
    }
}
