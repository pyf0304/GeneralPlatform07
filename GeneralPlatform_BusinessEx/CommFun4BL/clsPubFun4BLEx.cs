
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralPlatform.BusinessLogicEx
{
    public class clsPubFun4BLEx
    {
        public static void SetCommFun4BL()
        {
            //clsPrjTabBL.objCommFun4BL = new clsCommFun4BL4PrjTab();
            //clsCodeTypeBL.objCommFun4BL = new clsCommFun4BL4CodeType();
            clsQxProjectsBL.objCommFun4BL = new clsCommFun4BL4QxProjects();
            clsQxPrjDataBaseBL.objCommFun4BL = new clsCommFun4BL4QxPrjDataBase();
            clsQxRolesBL.objCommFun4BL = new clsCommFun4BL4QxUserRoles();
            clsXzSchoolBL.objCommFun4BL = new clsCommFun4BL4XzSchool();
            clsQxDepartmentInfoBL.objCommFun4BL = new clsCommFun4BL4QxDepartmentInfo();
            clsQxServer4SynchBL.objCommFun4BL = new clsCommFun4BL4QxServer4Synch();
            clsTabStateBL.objCommFun4BL = new clsCommFun4BL4TabState();
            clsTabTypeBL.objCommFun4BL = new clsCommFun4BL4TabType();
            clsSQLDSTypeBL.objCommFun4BL = new clsCommFun4BL4SQLDSType();
            clsQxUsersBL.objCommFun4BL = new clsCommFun4BL4QxUsers();
            clsQxUserStateBL.objCommFun4BL = new clsCommFun4BL4QxUserState();
            clsTSysParaBL.objCommFun4BL = new clsCommFun4BL4TSysPara();
            clsQxRoleMenusBL.objCommFun4BL = new clsCommFun4BL4QxRoleMenus();
            clsQxPrjMenusBL.objCommFun4BL = new clsCommFun4BL4QxPrjMenus();
            clsQxPageDispModeBL.objCommFun4BL = new clsCommFun4BL4QxPageDispMode();
            clsQxPrjMenuSetBL.objCommFun4BL = new clsCommFun4BL4QxPrjMenuSet();
            clsQxApplicationTypeBL.objCommFun4BL = new clsCommFun4BL4QxApplicationType();
            clsQxPrjTabBL.objCommFun4BL = new clsCommFun4BL4QxPrjTab();
            clsQxUserRoleRelationBL.objCommFun4BL = new clsCommFun4BL4QxUserRoleRelation();
            clsQxUserIdentityBL.objCommFun4BL = new clsCommFun4BL4QxUserIdentity();
        }

    }
}
