
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxFuncModule_AgcDA
 表名:QxFuncModule_Agc(00140101)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:28:05
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程管理(PrjManage_GP)
 框架-层名:数据处理层(CS)(DALCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using GeneralPlatform.Entity;

namespace GeneralPlatform.DAL
{
 /// <summary>
 /// 功能模块_Agc(QxFuncModule_Agc)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxFuncModule_AgcDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clsQxFuncModule_AgcEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsQxFuncModule_AgcEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxFuncModule_AgcEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsQxFuncModule_AgcEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxFuncModule_AgcEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFuncModuleAgcId)
{
strFuncModuleAgcId = strFuncModuleAgcId.Replace("'", "''");
if (strFuncModuleAgcId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:QxFuncModule_Agc中,检查关键字,长度不正确!(clsQxFuncModule_AgcDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncModuleAgcId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxFuncModule_Agc中,关键字不能为空 或 null!(clsQxFuncModule_AgcDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncModuleAgcId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxFuncModule_AgcDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strFuncModuleAgcId)
{
strFuncModuleAgcId = strFuncModuleAgcId.Replace("'", "''");
if (strFuncModuleAgcId.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:QxFuncModule_Agc中,检查关键字,长度不正确!(简化版)(clsQxFuncModule_AgcDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncModuleAgcId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxFuncModule_Agc中,关键字不能为空 或 null!(clsQxFuncModule_AgcDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncModuleAgcId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxFuncModule_AgcDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCond_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 strSQL = "Select * from QxFuncModule_Agc where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxFuncModule_Agc");
 return objDS;
}

 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查,用存储过程来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondBySP_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByCondBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxFuncModule_Agc_SelectByCond",values, "QxFuncModule_Agc");
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表的顶部数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSet_Top(int intTopSize, string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxFuncModule_Agc where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxFuncModule_Agc");
 return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxFuncModule_Agc a where {0} And a.FuncModuleAgcId not in (Select Top {2} FuncModuleAgcId From QxFuncModule_Agc Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxFuncModule_Agc");
return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxFuncModule_Agc a where {0} And a.FuncModuleAgcId not in (Select Top {2} FuncModuleAgcId From QxFuncModule_Agc Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxFuncModule_Agc");
return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns>返回满足条件一定范围的DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum, intMinNum));
 }
try
{
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataSet)ByRange", objException.Message));
}
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxFuncModule_Agc a where {0} And a.FuncModuleAgcId not in (Select Top {2} FuncModuleAgcId From QxFuncModule_Agc Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxFuncModule_Agc");
return objDS;
}

 #endregion 获取数据表的DataSet

 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxFuncModule_Agc(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTable_QxFuncModule_Agc)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule_Agc where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule_Agc where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxFuncModule_Agc where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxFuncModule_Agc where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} QxFuncModule_Agc.* from QxFuncModule_Agc Left Join {1} on {2} where {3} and QxFuncModule_Agc.FuncModuleAgcId not in (Select top {5} QxFuncModule_Agc.FuncModuleAgcId from QxFuncModule_Agc Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule_Agc where {1} and FuncModuleAgcId not in (Select top {2} FuncModuleAgcId from QxFuncModule_Agc where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule_Agc where {1} and FuncModuleAgcId not in (Select top {3} FuncModuleAgcId from QxFuncModule_Agc where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} QxFuncModule_Agc.* from QxFuncModule_Agc Left Join {1} on {2} where {3} and QxFuncModule_Agc.FuncModuleAgcId not in (Select top {5} QxFuncModule_Agc.FuncModuleAgcId from QxFuncModule_Agc Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule_Agc where {1} and FuncModuleAgcId not in (Select top {2} FuncModuleAgcId from QxFuncModule_Agc where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule_Agc where {1} and FuncModuleAgcId not in (Select top {3} FuncModuleAgcId from QxFuncModule_Agc where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} QxFuncModule_Agc.* from QxFuncModule_Agc Left Join {1} on {2} where {3} and QxFuncModule_Agc.FuncModuleAgcId not in (Select top {5} QxFuncModule_Agc.FuncModuleAgcId from QxFuncModule_Agc Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule_Agc where {1} and FuncModuleAgcId not in (Select top {2} FuncModuleAgcId from QxFuncModule_Agc where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule_Agc where {1} and FuncModuleAgcId not in (Select top {3} FuncModuleAgcId from QxFuncModule_Agc where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxFuncModule_Agc a where {0} And a.FuncModuleAgcId not in (Select Top {2} FuncModuleAgcId From QxFuncModule_Agc Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxFuncModule_Agc a where {0} And a.FuncModuleAgcId not in (Select Top {2} FuncModuleAgcId From QxFuncModule_Agc Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, List<string> lstExclude)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxFuncModule_Agc a where {0} And a.FuncModuleAgcId not in (Select Top {2} FuncModuleAgcId From QxFuncModule_Agc Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxFuncModule_Agc a where {0} And a.FuncModuleAgcId not in (Select Top {2} FuncModuleAgcId From QxFuncModule_Agc Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, bool bolIsCheckSQLAttack)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_AgcByRange)", intMaxNum, intMinNum));
 }
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableBySP_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByCondBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxFuncModule_Agc_SelectByCond",values);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxFuncModule_AgcEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA:GetObjLst)", objException.Message));
}
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = TransNullToInt(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxFuncModule_AgcDA: GetObjLst)", objException.Message));
}
objQxFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsQxFuncModule_AgcEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = TransNullToInt(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxFuncModule_AgcDA: GetObjLst)", objException.Message));
}
objQxFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxFuncModule_AgcEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA:GetObjLstBySP)", objException.Message));
}
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxFuncModule_Agc_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = TransNullToInt(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxFuncModule_AgcDA: GetObjLstBySP)", objException.Message));
}
objQxFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxFuncModule_AgcEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxFuncModule_Agc(ref clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where FuncModuleAgcId = " + "'"+ objQxFuncModule_AgcEN.FuncModuleAgcId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxFuncModule_AgcEN.FuncModuleAgcId = objDT.Rows[0][conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objQxFuncModule_AgcEN.FuncModuleName = objDT.Rows[0][conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModule_AgcEN.FuncModuleEnName = objDT.Rows[0][conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModule_AgcEN.FuncModuleNameSim = objDT.Rows[0][conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModule_AgcEN.QxPrjId = objDT.Rows[0][conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModule_AgcEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxFuncModule_AgcEN.UseStateId = objDT.Rows[0][conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModule_AgcEN.UpdUser = objDT.Rows[0][conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:18,是否可空:True)
 objQxFuncModule_AgcEN.UpdDate = objDT.Rows[0][conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxFuncModule_AgcEN.Memo = objDT.Rows[0][conQxFuncModule_Agc.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxFuncModule_AgcEN.SynchDate = objDT.Rows[0][conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:14,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxFuncModule_AgcDA: GetQxFuncModule_Agc)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxFuncModule_AgcEN GetObjByFuncModuleAgcId(string strFuncModuleAgcId)
{
CheckPrimaryKey(strFuncModuleAgcId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where FuncModuleAgcId = " + "'"+ strFuncModuleAgcId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
 objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:18,是否可空:True)
 objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:14,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxFuncModule_AgcDA: GetObjByFuncModuleAgcId)", objException.Message));
}
return objQxFuncModule_AgcEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxFuncModule_Agc_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxFuncModule_AgcOneBySP(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxFuncModule_AgcEN.FuncModuleAgcId
};
 objDT = objSQL.ExecSpReturnDT("QxFuncModule_Agc_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxFuncModule_AgcEN.FuncModuleAgcId = objDT.Rows[0][conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objQxFuncModule_AgcEN.FuncModuleName = objDT.Rows[0][conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModule_AgcEN.FuncModuleEnName = objDT.Rows[0][conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModule_AgcEN.FuncModuleNameSim = objDT.Rows[0][conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModule_AgcEN.QxPrjId = objDT.Rows[0][conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModule_AgcEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxFuncModule_AgcEN.UseStateId = objDT.Rows[0][conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModule_AgcEN.UpdUser = objDT.Rows[0][conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:18,是否可空:True)
 objQxFuncModule_AgcEN.UpdDate = objDT.Rows[0][conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxFuncModule_AgcEN.Memo = objDT.Rows[0][conQxFuncModule_Agc.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxFuncModule_AgcEN.SynchDate = objDT.Rows[0][conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:14,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxFuncModule_AgcEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN()
{
FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(), //模块名
FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(), //模块英文名
FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(), //模块名_Sim
QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(), //项目Id
OrderNum = TransNullToInt(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()), //排序号
UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(), //UseStateId
UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(), //修改用户
UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(), //备注
SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim() //同步日期
};
objQxFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxFuncModule_AgcEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxFuncModule_AgcDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxFuncModule_AgcEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxFuncModule_Agc_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN()
{
FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(), //模块名
FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(), //模块英文名
FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(), //模块名_Sim
QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(), //项目Id
OrderNum = TransNullToInt(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()), //排序号
UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(), //UseStateId
UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(), //修改用户
UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(), //备注
SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim() //同步日期
};
objQxFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxFuncModule_AgcEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxFuncModule_AgcEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = TransNullToInt(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxFuncModule_AgcDA: GetObjByDataRowQxFuncModule_Agc)", objException.Message));
}
objQxFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxFuncModule_AgcEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxFuncModule_AgcEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = TransNullToInt(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxFuncModule_AgcDA: GetObjByDataRow)", objException.Message));
}
objQxFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxFuncModule_AgcEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxFuncModule_AgcEN._CurrTabName, conQxFuncModule_Agc.FuncModuleAgcId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxFuncModule_AgcEN._CurrTabName, conQxFuncModule_Agc.FuncModuleAgcId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncModuleAgcId from QxFuncModule_Agc where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncModuleAgcId from QxFuncModule_Agc where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFuncModuleAgcId)
{
CheckPrimaryKey(strFuncModuleAgcId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxFuncModule_Agc", "FuncModuleAgcId = " + "'"+ strFuncModuleAgcId+"'"))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录, 用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistBySP)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strFuncModuleAgcId)
{
CheckPrimaryKey(strFuncModuleAgcId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strFuncModuleAgcId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxFuncModule_Agc_IsExist", values);
if (arrReturn[0].ToString()  ==  "1")
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxFuncModule_Agc", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxFuncModule_Agc");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
 {
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModule_AgcEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxFuncModule_AgcEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxFuncModule_Agc");
objRow = objDS.Tables["QxFuncModule_Agc"].NewRow();
objRow[conQxFuncModule_Agc.FuncModuleAgcId] = objQxFuncModule_AgcEN.FuncModuleAgcId; //功能模块Id
objRow[conQxFuncModule_Agc.FuncModuleName] = objQxFuncModule_AgcEN.FuncModuleName; //模块名
 if (objQxFuncModule_AgcEN.FuncModuleEnName !=  "")
 {
objRow[conQxFuncModule_Agc.FuncModuleEnName] = objQxFuncModule_AgcEN.FuncModuleEnName; //模块英文名
 }
 if (objQxFuncModule_AgcEN.FuncModuleNameSim !=  "")
 {
objRow[conQxFuncModule_Agc.FuncModuleNameSim] = objQxFuncModule_AgcEN.FuncModuleNameSim; //模块名_Sim
 }
objRow[conQxFuncModule_Agc.QxPrjId] = objQxFuncModule_AgcEN.QxPrjId; //项目Id
objRow[conQxFuncModule_Agc.OrderNum] = objQxFuncModule_AgcEN.OrderNum; //排序号
objRow[conQxFuncModule_Agc.UseStateId] = objQxFuncModule_AgcEN.UseStateId; //UseStateId
 if (objQxFuncModule_AgcEN.UpdUser !=  "")
 {
objRow[conQxFuncModule_Agc.UpdUser] = objQxFuncModule_AgcEN.UpdUser; //修改用户
 }
 if (objQxFuncModule_AgcEN.UpdDate !=  "")
 {
objRow[conQxFuncModule_Agc.UpdDate] = objQxFuncModule_AgcEN.UpdDate; //修改日期
 }
 if (objQxFuncModule_AgcEN.Memo !=  "")
 {
objRow[conQxFuncModule_Agc.Memo] = objQxFuncModule_AgcEN.Memo; //备注
 }
 if (objQxFuncModule_AgcEN.SynchDate !=  "")
 {
objRow[conQxFuncModule_Agc.SynchDate] = objQxFuncModule_AgcEN.SynchDate; //同步日期
 }
objDS.Tables[clsQxFuncModule_AgcEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxFuncModule_AgcEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModule_AgcEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxFuncModule_AgcEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxFuncModule_AgcEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleAgcId);
 var strFuncModuleAgcId = objQxFuncModule_AgcEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleName);
 var strFuncModuleName = objQxFuncModule_AgcEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleEnName);
 var strFuncModuleEnName = objQxFuncModule_AgcEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleNameSim);
 var strFuncModuleNameSim = objQxFuncModule_AgcEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objQxFuncModule_AgcEN.QxPrjId  ==  "")
 {
 objQxFuncModule_AgcEN.QxPrjId = null;
 }
 if (objQxFuncModule_AgcEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.QxPrjId);
 var strQxPrjId = objQxFuncModule_AgcEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conQxFuncModule_Agc.OrderNum);
 arrValueListForInsert.Add(objQxFuncModule_AgcEN.OrderNum.ToString());
 
 if (objQxFuncModule_AgcEN.UseStateId  ==  "")
 {
 objQxFuncModule_AgcEN.UseStateId = null;
 }
 if (objQxFuncModule_AgcEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UseStateId);
 var strUseStateId = objQxFuncModule_AgcEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objQxFuncModule_AgcEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UpdUser);
 var strUpdUser = objQxFuncModule_AgcEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxFuncModule_AgcEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UpdDate);
 var strUpdDate = objQxFuncModule_AgcEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxFuncModule_AgcEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.Memo);
 var strMemo = objQxFuncModule_AgcEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxFuncModule_AgcEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.SynchDate);
 var strSynchDate = objQxFuncModule_AgcEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxFuncModule_Agc");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModule_AgcEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxFuncModule_AgcEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxFuncModule_AgcEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleAgcId);
 var strFuncModuleAgcId = objQxFuncModule_AgcEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleName);
 var strFuncModuleName = objQxFuncModule_AgcEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleEnName);
 var strFuncModuleEnName = objQxFuncModule_AgcEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleNameSim);
 var strFuncModuleNameSim = objQxFuncModule_AgcEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objQxFuncModule_AgcEN.QxPrjId  ==  "")
 {
 objQxFuncModule_AgcEN.QxPrjId = null;
 }
 if (objQxFuncModule_AgcEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.QxPrjId);
 var strQxPrjId = objQxFuncModule_AgcEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conQxFuncModule_Agc.OrderNum);
 arrValueListForInsert.Add(objQxFuncModule_AgcEN.OrderNum.ToString());
 
 if (objQxFuncModule_AgcEN.UseStateId  ==  "")
 {
 objQxFuncModule_AgcEN.UseStateId = null;
 }
 if (objQxFuncModule_AgcEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UseStateId);
 var strUseStateId = objQxFuncModule_AgcEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objQxFuncModule_AgcEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UpdUser);
 var strUpdUser = objQxFuncModule_AgcEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxFuncModule_AgcEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UpdDate);
 var strUpdDate = objQxFuncModule_AgcEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxFuncModule_AgcEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.Memo);
 var strMemo = objQxFuncModule_AgcEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxFuncModule_AgcEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.SynchDate);
 var strSynchDate = objQxFuncModule_AgcEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxFuncModule_Agc");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxFuncModule_AgcEN.FuncModuleAgcId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModule_AgcEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxFuncModule_AgcEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxFuncModule_AgcEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleAgcId);
 var strFuncModuleAgcId = objQxFuncModule_AgcEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleName);
 var strFuncModuleName = objQxFuncModule_AgcEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleEnName);
 var strFuncModuleEnName = objQxFuncModule_AgcEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleNameSim);
 var strFuncModuleNameSim = objQxFuncModule_AgcEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objQxFuncModule_AgcEN.QxPrjId  ==  "")
 {
 objQxFuncModule_AgcEN.QxPrjId = null;
 }
 if (objQxFuncModule_AgcEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.QxPrjId);
 var strQxPrjId = objQxFuncModule_AgcEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conQxFuncModule_Agc.OrderNum);
 arrValueListForInsert.Add(objQxFuncModule_AgcEN.OrderNum.ToString());
 
 if (objQxFuncModule_AgcEN.UseStateId  ==  "")
 {
 objQxFuncModule_AgcEN.UseStateId = null;
 }
 if (objQxFuncModule_AgcEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UseStateId);
 var strUseStateId = objQxFuncModule_AgcEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objQxFuncModule_AgcEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UpdUser);
 var strUpdUser = objQxFuncModule_AgcEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxFuncModule_AgcEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UpdDate);
 var strUpdDate = objQxFuncModule_AgcEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxFuncModule_AgcEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.Memo);
 var strMemo = objQxFuncModule_AgcEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxFuncModule_AgcEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.SynchDate);
 var strSynchDate = objQxFuncModule_AgcEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxFuncModule_Agc");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objQxFuncModule_AgcEN.FuncModuleAgcId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModule_AgcEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxFuncModule_AgcEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxFuncModule_AgcEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleAgcId);
 var strFuncModuleAgcId = objQxFuncModule_AgcEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleName);
 var strFuncModuleName = objQxFuncModule_AgcEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleEnName);
 var strFuncModuleEnName = objQxFuncModule_AgcEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 if (objQxFuncModule_AgcEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.FuncModuleNameSim);
 var strFuncModuleNameSim = objQxFuncModule_AgcEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objQxFuncModule_AgcEN.QxPrjId  ==  "")
 {
 objQxFuncModule_AgcEN.QxPrjId = null;
 }
 if (objQxFuncModule_AgcEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.QxPrjId);
 var strQxPrjId = objQxFuncModule_AgcEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conQxFuncModule_Agc.OrderNum);
 arrValueListForInsert.Add(objQxFuncModule_AgcEN.OrderNum.ToString());
 
 if (objQxFuncModule_AgcEN.UseStateId  ==  "")
 {
 objQxFuncModule_AgcEN.UseStateId = null;
 }
 if (objQxFuncModule_AgcEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UseStateId);
 var strUseStateId = objQxFuncModule_AgcEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objQxFuncModule_AgcEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UpdUser);
 var strUpdUser = objQxFuncModule_AgcEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxFuncModule_AgcEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.UpdDate);
 var strUpdDate = objQxFuncModule_AgcEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxFuncModule_AgcEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.Memo);
 var strMemo = objQxFuncModule_AgcEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxFuncModule_AgcEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule_Agc.SynchDate);
 var strSynchDate = objQxFuncModule_AgcEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxFuncModule_Agc");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxFuncModule_AgcBySP(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
//通过存储过程来
//直接使用
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxFuncModule_AgcEN.FuncModuleAgcId,
 objQxFuncModule_AgcEN.FuncModuleName,
 objQxFuncModule_AgcEN.FuncModuleEnName,
 objQxFuncModule_AgcEN.FuncModuleNameSim,
 objQxFuncModule_AgcEN.QxPrjId,
 objQxFuncModule_AgcEN.OrderNum,
 objQxFuncModule_AgcEN.UseStateId,
 objQxFuncModule_AgcEN.UpdUser,
 objQxFuncModule_AgcEN.UpdDate,
 objQxFuncModule_AgcEN.Memo,
objQxFuncModule_AgcEN.SynchDate
};
 objSQL.ExecSP("QxFuncModule_Agc_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxFuncModule_Agcs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where FuncModuleAgcId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxFuncModule_Agc");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFuncModuleAgcId = oRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim();
if (IsExist(strFuncModuleAgcId))
{
 string strResult = "关键字变量值为:" + string.Format("FuncModuleAgcId = {0}", strFuncModuleAgcId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxFuncModule_AgcEN._CurrTabName ].NewRow();
objRow[conQxFuncModule_Agc.FuncModuleAgcId] = oRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objRow[conQxFuncModule_Agc.FuncModuleName] = oRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objRow[conQxFuncModule_Agc.FuncModuleEnName] = oRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objRow[conQxFuncModule_Agc.FuncModuleNameSim] = oRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objRow[conQxFuncModule_Agc.QxPrjId] = oRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxFuncModule_Agc.OrderNum] = oRow[conQxFuncModule_Agc.OrderNum].ToString().Trim(); //排序号
objRow[conQxFuncModule_Agc.UseStateId] = oRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objRow[conQxFuncModule_Agc.UpdUser] = oRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objRow[conQxFuncModule_Agc.UpdDate] = oRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objRow[conQxFuncModule_Agc.Memo] = oRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objRow[conQxFuncModule_Agc.SynchDate] = oRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
 objDS.Tables[clsQxFuncModule_AgcEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxFuncModule_AgcEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModule_AgcEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModule_AgcEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule_Agc where FuncModuleAgcId = " + "'"+ objQxFuncModule_AgcEN.FuncModuleAgcId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxFuncModule_AgcEN._CurrTabName);
if (objDS.Tables[clsQxFuncModule_AgcEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FuncModuleAgcId = " + "'"+ objQxFuncModule_AgcEN.FuncModuleAgcId+"'");
return false;
}
objRow = objDS.Tables[clsQxFuncModule_AgcEN._CurrTabName].Rows[0];
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleAgcId))
 {
objRow[conQxFuncModule_Agc.FuncModuleAgcId] = objQxFuncModule_AgcEN.FuncModuleAgcId; //功能模块Id
 }
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleName))
 {
objRow[conQxFuncModule_Agc.FuncModuleName] = objQxFuncModule_AgcEN.FuncModuleName; //模块名
 }
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleEnName))
 {
objRow[conQxFuncModule_Agc.FuncModuleEnName] = objQxFuncModule_AgcEN.FuncModuleEnName; //模块英文名
 }
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleNameSim))
 {
objRow[conQxFuncModule_Agc.FuncModuleNameSim] = objQxFuncModule_AgcEN.FuncModuleNameSim; //模块名_Sim
 }
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.QxPrjId))
 {
objRow[conQxFuncModule_Agc.QxPrjId] = objQxFuncModule_AgcEN.QxPrjId; //项目Id
 }
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.OrderNum))
 {
objRow[conQxFuncModule_Agc.OrderNum] = objQxFuncModule_AgcEN.OrderNum; //排序号
 }
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UseStateId))
 {
objRow[conQxFuncModule_Agc.UseStateId] = objQxFuncModule_AgcEN.UseStateId; //UseStateId
 }
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UpdUser))
 {
objRow[conQxFuncModule_Agc.UpdUser] = objQxFuncModule_AgcEN.UpdUser; //修改用户
 }
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UpdDate))
 {
objRow[conQxFuncModule_Agc.UpdDate] = objQxFuncModule_AgcEN.UpdDate; //修改日期
 }
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.Memo))
 {
objRow[conQxFuncModule_Agc.Memo] = objQxFuncModule_AgcEN.Memo; //备注
 }
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.SynchDate))
 {
objRow[conQxFuncModule_Agc.SynchDate] = objQxFuncModule_AgcEN.SynchDate; //同步日期
 }
try
{
objDA.Update(objDS, clsQxFuncModule_AgcEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过存储过程(StoreProcedure)来修改记录
 /// /// 缺点:1、不能支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySP)
 /// </summary>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySP(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModule_AgcEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModule_AgcEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxFuncModule_AgcEN.FuncModuleAgcId,
 objQxFuncModule_AgcEN.FuncModuleName,
 objQxFuncModule_AgcEN.FuncModuleEnName,
 objQxFuncModule_AgcEN.FuncModuleNameSim,
 objQxFuncModule_AgcEN.QxPrjId,
 objQxFuncModule_AgcEN.OrderNum,
 objQxFuncModule_AgcEN.UseStateId,
 objQxFuncModule_AgcEN.UpdUser,
 objQxFuncModule_AgcEN.UpdDate,
 objQxFuncModule_AgcEN.Memo,
 objQxFuncModule_AgcEN.SynchDate
};
 objSQL.ExecSP("QxFuncModule_Agc_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModule_AgcEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModule_AgcEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxFuncModule_Agc Set ");
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleName))
 {
 if (objQxFuncModule_AgcEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objQxFuncModule_AgcEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleName, conQxFuncModule_Agc.FuncModuleName); //模块名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.FuncModuleName); //模块名
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleEnName))
 {
 if (objQxFuncModule_AgcEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objQxFuncModule_AgcEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleEnName, conQxFuncModule_Agc.FuncModuleEnName); //模块英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.FuncModuleEnName); //模块英文名
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleNameSim))
 {
 if (objQxFuncModule_AgcEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objQxFuncModule_AgcEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleNameSim, conQxFuncModule_Agc.FuncModuleNameSim); //模块名_Sim
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.FuncModuleNameSim); //模块名_Sim
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.QxPrjId))
 {
 if (objQxFuncModule_AgcEN.QxPrjId  ==  "")
 {
 objQxFuncModule_AgcEN.QxPrjId = null;
 }
 if (objQxFuncModule_AgcEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxFuncModule_AgcEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxFuncModule_Agc.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.QxPrjId); //项目Id
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxFuncModule_AgcEN.OrderNum, conQxFuncModule_Agc.OrderNum); //排序号
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UseStateId))
 {
 if (objQxFuncModule_AgcEN.UseStateId  ==  "")
 {
 objQxFuncModule_AgcEN.UseStateId = null;
 }
 if (objQxFuncModule_AgcEN.UseStateId !=  null)
 {
 var strUseStateId = objQxFuncModule_AgcEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseStateId, conQxFuncModule_Agc.UseStateId); //UseStateId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.UseStateId); //UseStateId
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UpdUser))
 {
 if (objQxFuncModule_AgcEN.UpdUser !=  null)
 {
 var strUpdUser = objQxFuncModule_AgcEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxFuncModule_Agc.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.UpdUser); //修改用户
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UpdDate))
 {
 if (objQxFuncModule_AgcEN.UpdDate !=  null)
 {
 var strUpdDate = objQxFuncModule_AgcEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxFuncModule_Agc.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.UpdDate); //修改日期
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.Memo))
 {
 if (objQxFuncModule_AgcEN.Memo !=  null)
 {
 var strMemo = objQxFuncModule_AgcEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxFuncModule_Agc.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.Memo); //备注
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.SynchDate))
 {
 if (objQxFuncModule_AgcEN.SynchDate !=  null)
 {
 var strSynchDate = objQxFuncModule_AgcEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchDate, conQxFuncModule_Agc.SynchDate); //同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.SynchDate); //同步日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncModuleAgcId = '{0}'", objQxFuncModule_AgcEN.FuncModuleAgcId); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strCondition)
{
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModule_AgcEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModule_AgcEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxFuncModule_Agc Set ");
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleName))
 {
 if (objQxFuncModule_AgcEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objQxFuncModule_AgcEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleName = '{0}',", strFuncModuleName); //模块名
 }
 else
 {
 sbSQL.Append(" FuncModuleName = null,"); //模块名
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleEnName))
 {
 if (objQxFuncModule_AgcEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objQxFuncModule_AgcEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleEnName = '{0}',", strFuncModuleEnName); //模块英文名
 }
 else
 {
 sbSQL.Append(" FuncModuleEnName = null,"); //模块英文名
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleNameSim))
 {
 if (objQxFuncModule_AgcEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objQxFuncModule_AgcEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleNameSim = '{0}',", strFuncModuleNameSim); //模块名_Sim
 }
 else
 {
 sbSQL.Append(" FuncModuleNameSim = null,"); //模块名_Sim
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.QxPrjId))
 {
 if (objQxFuncModule_AgcEN.QxPrjId  ==  "")
 {
 objQxFuncModule_AgcEN.QxPrjId = null;
 }
 if (objQxFuncModule_AgcEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxFuncModule_AgcEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxFuncModule_AgcEN.OrderNum); //排序号
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UseStateId))
 {
 if (objQxFuncModule_AgcEN.UseStateId  ==  "")
 {
 objQxFuncModule_AgcEN.UseStateId = null;
 }
 if (objQxFuncModule_AgcEN.UseStateId !=  null)
 {
 var strUseStateId = objQxFuncModule_AgcEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseStateId = '{0}',", strUseStateId); //UseStateId
 }
 else
 {
 sbSQL.Append(" UseStateId = null,"); //UseStateId
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UpdUser))
 {
 if (objQxFuncModule_AgcEN.UpdUser !=  null)
 {
 var strUpdUser = objQxFuncModule_AgcEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UpdDate))
 {
 if (objQxFuncModule_AgcEN.UpdDate !=  null)
 {
 var strUpdDate = objQxFuncModule_AgcEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.Memo))
 {
 if (objQxFuncModule_AgcEN.Memo !=  null)
 {
 var strMemo = objQxFuncModule_AgcEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.SynchDate))
 {
 if (objQxFuncModule_AgcEN.SynchDate !=  null)
 {
 var strSynchDate = objQxFuncModule_AgcEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchDate = '{0}',", strSynchDate); //同步日期
 }
 else
 {
 sbSQL.Append(" SynchDate = null,"); //同步日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModule_AgcEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModule_AgcEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxFuncModule_Agc Set ");
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleName))
 {
 if (objQxFuncModule_AgcEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objQxFuncModule_AgcEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleName = '{0}',", strFuncModuleName); //模块名
 }
 else
 {
 sbSQL.Append(" FuncModuleName = null,"); //模块名
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleEnName))
 {
 if (objQxFuncModule_AgcEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objQxFuncModule_AgcEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleEnName = '{0}',", strFuncModuleEnName); //模块英文名
 }
 else
 {
 sbSQL.Append(" FuncModuleEnName = null,"); //模块英文名
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleNameSim))
 {
 if (objQxFuncModule_AgcEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objQxFuncModule_AgcEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleNameSim = '{0}',", strFuncModuleNameSim); //模块名_Sim
 }
 else
 {
 sbSQL.Append(" FuncModuleNameSim = null,"); //模块名_Sim
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.QxPrjId))
 {
 if (objQxFuncModule_AgcEN.QxPrjId  ==  "")
 {
 objQxFuncModule_AgcEN.QxPrjId = null;
 }
 if (objQxFuncModule_AgcEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxFuncModule_AgcEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxFuncModule_AgcEN.OrderNum); //排序号
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UseStateId))
 {
 if (objQxFuncModule_AgcEN.UseStateId  ==  "")
 {
 objQxFuncModule_AgcEN.UseStateId = null;
 }
 if (objQxFuncModule_AgcEN.UseStateId !=  null)
 {
 var strUseStateId = objQxFuncModule_AgcEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseStateId = '{0}',", strUseStateId); //UseStateId
 }
 else
 {
 sbSQL.Append(" UseStateId = null,"); //UseStateId
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UpdUser))
 {
 if (objQxFuncModule_AgcEN.UpdUser !=  null)
 {
 var strUpdUser = objQxFuncModule_AgcEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UpdDate))
 {
 if (objQxFuncModule_AgcEN.UpdDate !=  null)
 {
 var strUpdDate = objQxFuncModule_AgcEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.Memo))
 {
 if (objQxFuncModule_AgcEN.Memo !=  null)
 {
 var strMemo = objQxFuncModule_AgcEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.SynchDate))
 {
 if (objQxFuncModule_AgcEN.SynchDate !=  null)
 {
 var strSynchDate = objQxFuncModule_AgcEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchDate = '{0}',", strSynchDate); //同步日期
 }
 else
 {
 sbSQL.Append(" SynchDate = null,"); //同步日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModule_AgcEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModule_AgcEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxFuncModule_Agc Set ");
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleName))
 {
 if (objQxFuncModule_AgcEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objQxFuncModule_AgcEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleName, conQxFuncModule_Agc.FuncModuleName); //模块名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.FuncModuleName); //模块名
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleEnName))
 {
 if (objQxFuncModule_AgcEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objQxFuncModule_AgcEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleEnName, conQxFuncModule_Agc.FuncModuleEnName); //模块英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.FuncModuleEnName); //模块英文名
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.FuncModuleNameSim))
 {
 if (objQxFuncModule_AgcEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objQxFuncModule_AgcEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleNameSim, conQxFuncModule_Agc.FuncModuleNameSim); //模块名_Sim
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.FuncModuleNameSim); //模块名_Sim
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.QxPrjId))
 {
 if (objQxFuncModule_AgcEN.QxPrjId  ==  "")
 {
 objQxFuncModule_AgcEN.QxPrjId = null;
 }
 if (objQxFuncModule_AgcEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxFuncModule_AgcEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxFuncModule_Agc.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.QxPrjId); //项目Id
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxFuncModule_AgcEN.OrderNum, conQxFuncModule_Agc.OrderNum); //排序号
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UseStateId))
 {
 if (objQxFuncModule_AgcEN.UseStateId  ==  "")
 {
 objQxFuncModule_AgcEN.UseStateId = null;
 }
 if (objQxFuncModule_AgcEN.UseStateId !=  null)
 {
 var strUseStateId = objQxFuncModule_AgcEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseStateId, conQxFuncModule_Agc.UseStateId); //UseStateId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.UseStateId); //UseStateId
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UpdUser))
 {
 if (objQxFuncModule_AgcEN.UpdUser !=  null)
 {
 var strUpdUser = objQxFuncModule_AgcEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxFuncModule_Agc.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.UpdUser); //修改用户
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.UpdDate))
 {
 if (objQxFuncModule_AgcEN.UpdDate !=  null)
 {
 var strUpdDate = objQxFuncModule_AgcEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxFuncModule_Agc.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.UpdDate); //修改日期
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.Memo))
 {
 if (objQxFuncModule_AgcEN.Memo !=  null)
 {
 var strMemo = objQxFuncModule_AgcEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxFuncModule_Agc.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.Memo); //备注
 }
 }
 
 if (objQxFuncModule_AgcEN.IsUpdated(conQxFuncModule_Agc.SynchDate))
 {
 if (objQxFuncModule_AgcEN.SynchDate !=  null)
 {
 var strSynchDate = objQxFuncModule_AgcEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchDate, conQxFuncModule_Agc.SynchDate); //同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule_Agc.SynchDate); //同步日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncModuleAgcId = '{0}'", objQxFuncModule_AgcEN.FuncModuleAgcId); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFuncModuleAgcId) 
{
CheckPrimaryKey(strFuncModuleAgcId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFuncModuleAgcId,
};
 objSQL.ExecSP("QxFuncModule_Agc_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFuncModuleAgcId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFuncModuleAgcId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
//删除QxFuncModule_Agc本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxFuncModule_Agc where FuncModuleAgcId = " + "'"+ strFuncModuleAgcId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxFuncModule_Agc(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除QxFuncModule_Agc本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxFuncModule_Agc where FuncModuleAgcId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFuncModuleAgcId) 
{
CheckPrimaryKey(strFuncModuleAgcId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
//删除QxFuncModule_Agc本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxFuncModule_Agc where FuncModuleAgcId = " + "'"+ strFuncModuleAgcId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxFuncModule_Agc(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: DelQxFuncModule_Agc)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxFuncModule_Agc where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelQxFuncModule_AgcWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcDA: DelQxFuncModule_AgcWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxFuncModule_Agc where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcENS">源对象</param>
 /// <param name = "objQxFuncModule_AgcENT">目标对象</param>
public void CopyTo(clsQxFuncModule_AgcEN objQxFuncModule_AgcENS, clsQxFuncModule_AgcEN objQxFuncModule_AgcENT)
{
objQxFuncModule_AgcENT.FuncModuleAgcId = objQxFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objQxFuncModule_AgcENT.FuncModuleName = objQxFuncModule_AgcENS.FuncModuleName; //模块名
objQxFuncModule_AgcENT.FuncModuleEnName = objQxFuncModule_AgcENS.FuncModuleEnName; //模块英文名
objQxFuncModule_AgcENT.FuncModuleNameSim = objQxFuncModule_AgcENS.FuncModuleNameSim; //模块名_Sim
objQxFuncModule_AgcENT.QxPrjId = objQxFuncModule_AgcENS.QxPrjId; //项目Id
objQxFuncModule_AgcENT.OrderNum = objQxFuncModule_AgcENS.OrderNum; //排序号
objQxFuncModule_AgcENT.UseStateId = objQxFuncModule_AgcENS.UseStateId; //UseStateId
objQxFuncModule_AgcENT.UpdUser = objQxFuncModule_AgcENS.UpdUser; //修改用户
objQxFuncModule_AgcENT.UpdDate = objQxFuncModule_AgcENS.UpdDate; //修改日期
objQxFuncModule_AgcENT.Memo = objQxFuncModule_AgcENS.Memo; //备注
objQxFuncModule_AgcENT.SynchDate = objQxFuncModule_AgcENS.SynchDate; //同步日期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxFuncModule_AgcEN.FuncModuleName, conQxFuncModule_Agc.FuncModuleName);
clsCheckSql.CheckFieldNotNull(objQxFuncModule_AgcEN.QxPrjId, conQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckFieldNotNull(objQxFuncModule_AgcEN.OrderNum, conQxFuncModule_Agc.OrderNum);
clsCheckSql.CheckFieldNotNull(objQxFuncModule_AgcEN.UseStateId, conQxFuncModule_Agc.UseStateId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.FuncModuleAgcId, 8, conQxFuncModule_Agc.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.FuncModuleName, 30, conQxFuncModule_Agc.FuncModuleName);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.FuncModuleEnName, 30, conQxFuncModule_Agc.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.FuncModuleNameSim, 30, conQxFuncModule_Agc.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.QxPrjId, 4, conQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.UseStateId, 4, conQxFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.UpdUser, 18, conQxFuncModule_Agc.UpdUser);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.UpdDate, 20, conQxFuncModule_Agc.UpdDate);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.Memo, 1000, conQxFuncModule_Agc.Memo);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.SynchDate, 14, conQxFuncModule_Agc.SynchDate);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxFuncModule_AgcEN.QxPrjId, 4, conQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxFuncModule_AgcEN.UseStateId, 4, conQxFuncModule_Agc.UseStateId);
 objQxFuncModule_AgcEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.FuncModuleName, 30, conQxFuncModule_Agc.FuncModuleName);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.FuncModuleEnName, 30, conQxFuncModule_Agc.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.FuncModuleNameSim, 30, conQxFuncModule_Agc.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.QxPrjId, 4, conQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.UseStateId, 4, conQxFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.UpdUser, 18, conQxFuncModule_Agc.UpdUser);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.UpdDate, 20, conQxFuncModule_Agc.UpdDate);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.Memo, 1000, conQxFuncModule_Agc.Memo);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.SynchDate, 14, conQxFuncModule_Agc.SynchDate);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxFuncModule_AgcEN.QxPrjId, 4, conQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxFuncModule_AgcEN.UseStateId, 4, conQxFuncModule_Agc.UseStateId);
 objQxFuncModule_AgcEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.FuncModuleAgcId, 8, conQxFuncModule_Agc.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.FuncModuleName, 30, conQxFuncModule_Agc.FuncModuleName);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.FuncModuleEnName, 30, conQxFuncModule_Agc.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.FuncModuleNameSim, 30, conQxFuncModule_Agc.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.QxPrjId, 4, conQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.UseStateId, 4, conQxFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.UpdUser, 18, conQxFuncModule_Agc.UpdUser);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.UpdDate, 20, conQxFuncModule_Agc.UpdDate);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.Memo, 1000, conQxFuncModule_Agc.Memo);
clsCheckSql.CheckFieldLen(objQxFuncModule_AgcEN.SynchDate, 14, conQxFuncModule_Agc.SynchDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxFuncModule_AgcEN.FuncModuleAgcId, conQxFuncModule_Agc.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModule_AgcEN.FuncModuleName, conQxFuncModule_Agc.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModule_AgcEN.FuncModuleEnName, conQxFuncModule_Agc.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModule_AgcEN.FuncModuleNameSim, conQxFuncModule_Agc.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModule_AgcEN.QxPrjId, conQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModule_AgcEN.UseStateId, conQxFuncModule_Agc.UseStateId);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModule_AgcEN.UpdUser, conQxFuncModule_Agc.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModule_AgcEN.UpdDate, conQxFuncModule_Agc.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModule_AgcEN.Memo, conQxFuncModule_Agc.Memo);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModule_AgcEN.SynchDate, conQxFuncModule_Agc.SynchDate);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxFuncModule_AgcEN.QxPrjId, 4, conQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxFuncModule_AgcEN.UseStateId, 4, conQxFuncModule_Agc.UseStateId);
 objQxFuncModule_AgcEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFuncModuleAgcId()
{
//获取某学院所有专业信息
string strSQL = "select FuncModuleAgcId, FuncModuleName from QxFuncModule_Agc ";
 clsSpecSQLforSql mySql = clsQxFuncModule_AgcDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxFuncModule_AgcEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxFuncModule_AgcEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}