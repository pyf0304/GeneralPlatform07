
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFuncModuleDAEx
表名:FuncModule(00140104)
生成代码版本:2020.05.27.2
生成日期:2020/05/28 01:06:15
生成者:
生成服务器IP:192.168.1.10
工程名称:统一平台
工程ID:0014
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:系统管理
模块英文名:SysManage
框架-层名:数据处理扩展层(DALExCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commexception;
using com.taishsoft.commdb;

using GeneralPlatform.Entity;

namespace GeneralPlatform.DAL
{

    /// <summary>
    /// 构造函数
    /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
    /// </summary>
    public class clsFuncModuleDAEx : clsFuncModuleDA
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lstKey"></param>
        /// <returns></returns>
        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" FuncModuleId in ({0})", strKeyList);
            List<clsFuncModuleEN> arrFuncModuleLst = GetObjLst(sbCondition.ToString());
            foreach (clsFuncModuleEN objFuncModule in arrFuncModuleLst)
            {

                objFuncModule.OrderNum = objFuncModule.OrderNum - 10000;

                UpdateBySql2(objFuncModule);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" FuncModuleId in ({0})", strKeyList);
            List<clsFuncModuleEN> arrFuncModuleLst = GetObjLst(sbCondition.ToString());
            foreach (clsFuncModuleEN objFuncModule in arrFuncModuleLst)
            {

                objFuncModule.OrderNum = objFuncModule.OrderNum + 10000;

                UpdateBySql2(objFuncModule);
            }
            return true;
        }


        public bool ReOrder()
        {
            string strCondition2 = string.Format(" 1=1 order by OrderNum");

            List<clsFuncModuleEN> arrFuncModuleObjList = new clsFuncModuleDA().GetObjLst(strCondition2);
            int intIndex = 1;
            foreach (clsFuncModuleEN objFuncModule in arrFuncModuleObjList)
            {
                objFuncModule.OrderNum = intIndex;
                //objFuncModule.id_Stu
                this.UpdateBySql2(objFuncModule);
                intIndex++;
            }
            return true;
        }



        public bool AdjustSequenceNumber(string strDirect, string strFuncModuleId)
        {
            //操作步骤：
            //1、获取当前所选中的关键字FuncModuleId。
            //2、根据关键字FuncModuleId来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字FuncModuleId
            //5、把当前关键字FuncModuleId的序号加(减)1
            //6、把下一个序号的关键字FuncModuleId减(加)1
            //7、重新显示DATAGRID
            //

            int intDisplayOrder;    //当前记录的序号
            int intPrevDisplayOrder, intNextDisplayOrder;   //上下两条记录的序号
                                                            //			string strFuncModuleId;
            string strPrevFuncModuleId = "";    //上一条序号的关键字FuncModuleId
            string strNextFuncModuleId = "";    //下一条序号的关键字FuncModuleId
            int intTabRecNum;       //当前表中字段的记录数

            //int intScrTermSeq = 0;
            //string strCurrid_Stu;
            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsFuncModuleEN objFuncModule =  GetObjByFuncModuleId(strFuncModuleId);

            intDisplayOrder = objFuncModule.OrderNum;
            intPrevDisplayOrder = intDisplayOrder - 1;
            intNextDisplayOrder = intDisplayOrder + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            string strCondition2 = string.Format(" 1=1 ");
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("FuncModule", strCondition2);    //获取当前{表ID}的记录数
            if (strDirect == "UP")
            {
                if (intDisplayOrder <= 1)
                {
                    throw new Exception("已经是第一条记录，不能再上移!");
                }
            }
            else if (strDirect == "DOWN")
            {
                if (intDisplayOrder >= intTabRecNum)    //如果当前序号大于表记录数
                {
                    throw new Exception("已经是最后一条记录，不能再下移!");
                }
            }
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。

            //4、获取下(上)一个序号字段的关键字FuncModuleId
            if (strDirect == "UP")
            {
                strCondition.AppendFormat(" 1=1 and OrderNum = {0}",
                    intDisplayOrder - 1);
                strPrevFuncModuleId = this.GetFirstID(strCondition.ToString());

                if (strPrevFuncModuleId == "")
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat(" 1=1 and OrderNum = {0}", intDisplayOrder + 1);
                strNextFuncModuleId = this.GetFirstID(strCondition.ToString());

                if (strNextFuncModuleId == "")
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            //5、把当前关键字FuncModuleId的序号加(减)1
            //6、把下一个序号的关键字FuncModuleId减(加)1
            if (strDirect == "UP")
            {
                clsGeneralTab2.funSetFldValue("FuncModule", "OrderNum", intDisplayOrder - 1, "FuncModuleId = " + strFuncModuleId);
                clsGeneralTab2.funSetFldValue("FuncModule", "OrderNum", intPrevDisplayOrder + 1, "FuncModuleId = " + strPrevFuncModuleId);
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("FuncModule", "OrderNum", intDisplayOrder + 1, "FuncModuleId = " + strFuncModuleId);
                clsGeneralTab2.funSetFldValue("FuncModule", "OrderNum", intNextDisplayOrder - 1, "FuncModuleId = " + strNextFuncModuleId);
            }
            //7、重新显示DATAGRID
            return true;
        }

    }

}