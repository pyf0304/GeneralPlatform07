
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxFuncModuleDA
 表名:QxFuncModule(00140086)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:27:29
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
 /// 功能模块(QxFuncModule)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxFuncModuleDA : clsCommBase4DA
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
 return clsQxFuncModuleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxFuncModuleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxFuncModuleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxFuncModuleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxFuncModuleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFuncModuleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFuncModuleId)
{
strFuncModuleId = strFuncModuleId.Replace("'", "''");
if (strFuncModuleId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:QxFuncModule中,检查关键字,长度不正确!(clsQxFuncModuleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncModuleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxFuncModule中,关键字不能为空 或 null!(clsQxFuncModuleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncModuleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxFuncModuleDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strFuncModuleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strFuncModuleId)
{
strFuncModuleId = strFuncModuleId.Replace("'", "''");
if (strFuncModuleId.Length > 4 + 4)
{
throw new Exception("(errid:Data000004)在表:QxFuncModule中,检查关键字,长度不正确!(简化版)(clsQxFuncModuleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncModuleId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxFuncModule中,关键字不能为空 或 null!(clsQxFuncModuleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncModuleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxFuncModuleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
 strSQL = "Select * from QxFuncModule where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxFuncModule");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxFuncModule_SelectByCond",values, "QxFuncModule");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxFuncModule where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxFuncModule");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxFuncModule a where {0} And a.FuncModuleId not in (Select Top {2} FuncModuleId From QxFuncModule Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxFuncModule");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxFuncModule a where {0} And a.FuncModuleId not in (Select Top {2} FuncModuleId From QxFuncModule Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxFuncModule");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxFuncModule a where {0} And a.FuncModuleId not in (Select Top {2} FuncModuleId From QxFuncModule Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxFuncModule");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxFuncModule(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTable_QxFuncModule)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxFuncModule where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxFuncModule where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxFuncModule.* from QxFuncModule Left Join {1} on {2} where {3} and QxFuncModule.FuncModuleId not in (Select top {5} QxFuncModule.FuncModuleId from QxFuncModule Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule where {1} and FuncModuleId not in (Select top {2} FuncModuleId from QxFuncModule where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule where {1} and FuncModuleId not in (Select top {3} FuncModuleId from QxFuncModule where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxFuncModule.* from QxFuncModule Left Join {1} on {2} where {3} and QxFuncModule.FuncModuleId not in (Select top {5} QxFuncModule.FuncModuleId from QxFuncModule Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule where {1} and FuncModuleId not in (Select top {2} FuncModuleId from QxFuncModule where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule where {1} and FuncModuleId not in (Select top {3} FuncModuleId from QxFuncModule where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxFuncModule.* from QxFuncModule Left Join {1} on {2} where {3} and QxFuncModule.FuncModuleId not in (Select top {5} QxFuncModule.FuncModuleId from QxFuncModule Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule where {1} and FuncModuleId not in (Select top {2} FuncModuleId from QxFuncModule where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxFuncModule where {1} and FuncModuleId not in (Select top {3} FuncModuleId from QxFuncModule where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxFuncModule a where {0} And a.FuncModuleId not in (Select Top {2} FuncModuleId From QxFuncModule Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxFuncModule a where {0} And a.FuncModuleId not in (Select Top {2} FuncModuleId From QxFuncModule Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxFuncModule a where {0} And a.FuncModuleId not in (Select Top {2} FuncModuleId From QxFuncModule Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxFuncModule a where {0} And a.FuncModuleId not in (Select Top {2} FuncModuleId From QxFuncModule Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxFuncModuleDA: GetQxFuncModuleByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxFuncModule_SelectByCond",values);
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
public List<clsQxFuncModuleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxFuncModuleDA:GetObjLst)", objException.Message));
}
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = TransNullToInt(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = TransNullToBool(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxFuncModuleDA: GetObjLst)", objException.Message));
}
objQxFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxFuncModuleEN);
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
public List<clsQxFuncModuleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxFuncModuleDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = TransNullToInt(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = TransNullToBool(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxFuncModuleDA: GetObjLst)", objException.Message));
}
objQxFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxFuncModuleEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxFuncModuleDA:GetObjLstBySP)", objException.Message));
}
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxFuncModule_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = TransNullToInt(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = TransNullToBool(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxFuncModuleDA: GetObjLstBySP)", objException.Message));
}
objQxFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxFuncModuleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxFuncModule(ref clsQxFuncModuleEN objQxFuncModuleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where FuncModuleId = " + "'"+ objQxFuncModuleEN.FuncModuleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxFuncModuleEN.FuncModuleId = objDT.Rows[0][conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModuleEN.FuncModuleName = objDT.Rows[0][conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModuleEN.FuncModuleNameSim = objDT.Rows[0][conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModuleEN.FuncModuleEnName = objDT.Rows[0][conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModuleEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxFuncModule.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxFuncModuleEN.InUse = TransNullToBool(objDT.Rows[0][conQxFuncModule.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxFuncModuleEN.QxPrjId = objDT.Rows[0][conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModuleEN.UpdDate = objDT.Rows[0][conQxFuncModule.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxFuncModuleEN.UpdUser = objDT.Rows[0][conQxFuncModule.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxFuncModuleDA: GetQxFuncModule)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxFuncModuleEN GetObjByFuncModuleId(string strFuncModuleId)
{
CheckPrimaryKey(strFuncModuleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where FuncModuleId = " + "'"+ strFuncModuleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
 objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxFuncModuleDA: GetObjByFuncModuleId)", objException.Message));
}
return objQxFuncModuleEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxFuncModule_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxFuncModuleOneBySP(clsQxFuncModuleEN objQxFuncModuleEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxFuncModuleEN.FuncModuleId
};
 objDT = objSQL.ExecSpReturnDT("QxFuncModule_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxFuncModuleEN.FuncModuleId = objDT.Rows[0][conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModuleEN.FuncModuleName = objDT.Rows[0][conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModuleEN.FuncModuleNameSim = objDT.Rows[0][conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModuleEN.FuncModuleEnName = objDT.Rows[0][conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objQxFuncModuleEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxFuncModule.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxFuncModuleEN.InUse = TransNullToBool(objDT.Rows[0][conQxFuncModule.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxFuncModuleEN.QxPrjId = objDT.Rows[0][conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxFuncModuleEN.UpdDate = objDT.Rows[0][conQxFuncModule.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxFuncModuleEN.UpdUser = objDT.Rows[0][conQxFuncModule.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:18,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxFuncModuleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN()
{
FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(), //模块Id
FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(), //模块名
FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(), //模块名_Sim
FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(), //模块英文名
OrderNum = TransNullToInt(objRow[conQxFuncModule.OrderNum].ToString().Trim()), //排序号
InUse = TransNullToBool(objRow[conQxFuncModule.InUse].ToString().Trim()), //是否在用
QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(), //项目Id
UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim() //修改用户
};
objQxFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxFuncModuleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxFuncModuleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxFuncModuleEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxFuncModuleDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxFuncModule_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN()
{
FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(), //模块Id
FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(), //模块名
FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(), //模块名_Sim
FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(), //模块英文名
OrderNum = TransNullToInt(objRow[conQxFuncModule.OrderNum].ToString().Trim()), //排序号
InUse = TransNullToBool(objRow[conQxFuncModule.InUse].ToString().Trim()), //是否在用
QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(), //项目Id
UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim() //修改用户
};
objQxFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxFuncModuleEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxFuncModuleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = TransNullToInt(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = TransNullToBool(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxFuncModuleDA: GetObjByDataRowQxFuncModule)", objException.Message));
}
objQxFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxFuncModuleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxFuncModuleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = TransNullToInt(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = TransNullToBool(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxFuncModuleDA: GetObjByDataRow)", objException.Message));
}
objQxFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxFuncModuleEN;
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
objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxFuncModuleEN._CurrTabName, conQxFuncModule.FuncModuleId, 4, "");
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
objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxFuncModuleEN._CurrTabName, conQxFuncModule.FuncModuleId, 4, strPrefix);
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
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncModuleId from QxFuncModule where " + strCondition;
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
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncModuleId from QxFuncModule where " + strCondition;
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFuncModuleId)
{
CheckPrimaryKey(strFuncModuleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxFuncModule", "FuncModuleId = " + "'"+ strFuncModuleId+"'"))
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strFuncModuleId)
{
CheckPrimaryKey(strFuncModuleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strFuncModuleId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxFuncModule_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxFuncModuleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxFuncModule", strCondition))
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
objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxFuncModule");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxFuncModuleEN objQxFuncModuleEN)
 {
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxFuncModuleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxFuncModule");
objRow = objDS.Tables["QxFuncModule"].NewRow();
objRow[conQxFuncModule.FuncModuleId] = objQxFuncModuleEN.FuncModuleId; //模块Id
objRow[conQxFuncModule.FuncModuleName] = objQxFuncModuleEN.FuncModuleName; //模块名
 if (objQxFuncModuleEN.FuncModuleNameSim !=  "")
 {
objRow[conQxFuncModule.FuncModuleNameSim] = objQxFuncModuleEN.FuncModuleNameSim; //模块名_Sim
 }
 if (objQxFuncModuleEN.FuncModuleEnName !=  "")
 {
objRow[conQxFuncModule.FuncModuleEnName] = objQxFuncModuleEN.FuncModuleEnName; //模块英文名
 }
objRow[conQxFuncModule.OrderNum] = objQxFuncModuleEN.OrderNum; //排序号
objRow[conQxFuncModule.InUse] = objQxFuncModuleEN.InUse; //是否在用
objRow[conQxFuncModule.QxPrjId] = objQxFuncModuleEN.QxPrjId; //项目Id
 if (objQxFuncModuleEN.UpdDate !=  "")
 {
objRow[conQxFuncModule.UpdDate] = objQxFuncModuleEN.UpdDate; //修改日期
 }
 if (objQxFuncModuleEN.UpdUser !=  "")
 {
objRow[conQxFuncModule.UpdUser] = objQxFuncModuleEN.UpdUser; //修改用户
 }
objDS.Tables[clsQxFuncModuleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxFuncModuleEN._CurrTabName);
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
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxFuncModuleEN objQxFuncModuleEN)
{
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxFuncModuleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxFuncModuleEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleId);
 var strFuncModuleId = objQxFuncModuleEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleName);
 var strFuncModuleName = objQxFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleNameSim);
 var strFuncModuleNameSim = objQxFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleEnName);
 var strFuncModuleEnName = objQxFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 arrFieldListForInsert.Add(conQxFuncModule.OrderNum);
 arrValueListForInsert.Add(objQxFuncModuleEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conQxFuncModule.InUse);
 arrValueListForInsert.Add("'" + (objQxFuncModuleEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxFuncModuleEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.QxPrjId);
 var strQxPrjId = objQxFuncModuleEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxFuncModuleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.UpdDate);
 var strUpdDate = objQxFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxFuncModuleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.UpdUser);
 var strUpdUser = objQxFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxFuncModule");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxFuncModuleEN objQxFuncModuleEN)
{
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxFuncModuleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxFuncModuleEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleId);
 var strFuncModuleId = objQxFuncModuleEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleName);
 var strFuncModuleName = objQxFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleNameSim);
 var strFuncModuleNameSim = objQxFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleEnName);
 var strFuncModuleEnName = objQxFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 arrFieldListForInsert.Add(conQxFuncModule.OrderNum);
 arrValueListForInsert.Add(objQxFuncModuleEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conQxFuncModule.InUse);
 arrValueListForInsert.Add("'" + (objQxFuncModuleEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxFuncModuleEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.QxPrjId);
 var strQxPrjId = objQxFuncModuleEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxFuncModuleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.UpdDate);
 var strUpdDate = objQxFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxFuncModuleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.UpdUser);
 var strUpdUser = objQxFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxFuncModule");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxFuncModuleEN.FuncModuleId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxFuncModuleEN objQxFuncModuleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxFuncModuleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxFuncModuleEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleId);
 var strFuncModuleId = objQxFuncModuleEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleName);
 var strFuncModuleName = objQxFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleNameSim);
 var strFuncModuleNameSim = objQxFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleEnName);
 var strFuncModuleEnName = objQxFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 arrFieldListForInsert.Add(conQxFuncModule.OrderNum);
 arrValueListForInsert.Add(objQxFuncModuleEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conQxFuncModule.InUse);
 arrValueListForInsert.Add("'" + (objQxFuncModuleEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxFuncModuleEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.QxPrjId);
 var strQxPrjId = objQxFuncModuleEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxFuncModuleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.UpdDate);
 var strUpdDate = objQxFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxFuncModuleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.UpdUser);
 var strUpdUser = objQxFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxFuncModule");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objQxFuncModuleEN.FuncModuleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxFuncModuleEN objQxFuncModuleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxFuncModuleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxFuncModuleEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleId);
 var strFuncModuleId = objQxFuncModuleEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleName);
 var strFuncModuleName = objQxFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleNameSim);
 var strFuncModuleNameSim = objQxFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objQxFuncModuleEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.FuncModuleEnName);
 var strFuncModuleEnName = objQxFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 arrFieldListForInsert.Add(conQxFuncModule.OrderNum);
 arrValueListForInsert.Add(objQxFuncModuleEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conQxFuncModule.InUse);
 arrValueListForInsert.Add("'" + (objQxFuncModuleEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxFuncModuleEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.QxPrjId);
 var strQxPrjId = objQxFuncModuleEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxFuncModuleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.UpdDate);
 var strUpdDate = objQxFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxFuncModuleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxFuncModule.UpdUser);
 var strUpdUser = objQxFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxFuncModule");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxFuncModuleBySP(clsQxFuncModuleEN objQxFuncModuleEN)
{
//通过存储过程来
//直接使用
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxFuncModuleEN.FuncModuleId,
 objQxFuncModuleEN.FuncModuleName,
 objQxFuncModuleEN.FuncModuleNameSim,
 objQxFuncModuleEN.FuncModuleEnName,
 objQxFuncModuleEN.OrderNum,
 objQxFuncModuleEN.InUse,
 objQxFuncModuleEN.QxPrjId,
 objQxFuncModuleEN.UpdDate,
objQxFuncModuleEN.UpdUser
};
 objSQL.ExecSP("QxFuncModule_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxFuncModules(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where FuncModuleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxFuncModule");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFuncModuleId = oRow[conQxFuncModule.FuncModuleId].ToString().Trim();
if (IsExist(strFuncModuleId))
{
 string strResult = "关键字变量值为:" + string.Format("FuncModuleId = {0}", strFuncModuleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxFuncModuleEN._CurrTabName ].NewRow();
objRow[conQxFuncModule.FuncModuleId] = oRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objRow[conQxFuncModule.FuncModuleName] = oRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objRow[conQxFuncModule.FuncModuleNameSim] = oRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objRow[conQxFuncModule.FuncModuleEnName] = oRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objRow[conQxFuncModule.OrderNum] = oRow[conQxFuncModule.OrderNum].ToString().Trim(); //排序号
objRow[conQxFuncModule.InUse] = oRow[conQxFuncModule.InUse].ToString().Trim(); //是否在用
objRow[conQxFuncModule.QxPrjId] = oRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxFuncModule.UpdDate] = oRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objRow[conQxFuncModule.UpdUser] = oRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
 objDS.Tables[clsQxFuncModuleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxFuncModuleEN._CurrTabName);
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
 /// <param name = "objQxFuncModuleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxFuncModuleEN objQxFuncModuleEN)
{
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModuleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from QxFuncModule where FuncModuleId = " + "'"+ objQxFuncModuleEN.FuncModuleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxFuncModuleEN._CurrTabName);
if (objDS.Tables[clsQxFuncModuleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FuncModuleId = " + "'"+ objQxFuncModuleEN.FuncModuleId+"'");
return false;
}
objRow = objDS.Tables[clsQxFuncModuleEN._CurrTabName].Rows[0];
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleId))
 {
objRow[conQxFuncModule.FuncModuleId] = objQxFuncModuleEN.FuncModuleId; //模块Id
 }
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleName))
 {
objRow[conQxFuncModule.FuncModuleName] = objQxFuncModuleEN.FuncModuleName; //模块名
 }
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleNameSim))
 {
objRow[conQxFuncModule.FuncModuleNameSim] = objQxFuncModuleEN.FuncModuleNameSim; //模块名_Sim
 }
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleEnName))
 {
objRow[conQxFuncModule.FuncModuleEnName] = objQxFuncModuleEN.FuncModuleEnName; //模块英文名
 }
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.OrderNum))
 {
objRow[conQxFuncModule.OrderNum] = objQxFuncModuleEN.OrderNum; //排序号
 }
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.InUse))
 {
objRow[conQxFuncModule.InUse] = objQxFuncModuleEN.InUse; //是否在用
 }
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.QxPrjId))
 {
objRow[conQxFuncModule.QxPrjId] = objQxFuncModuleEN.QxPrjId; //项目Id
 }
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.UpdDate))
 {
objRow[conQxFuncModule.UpdDate] = objQxFuncModuleEN.UpdDate; //修改日期
 }
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.UpdUser))
 {
objRow[conQxFuncModule.UpdUser] = objQxFuncModuleEN.UpdUser; //修改用户
 }
try
{
objDA.Update(objDS, clsQxFuncModuleEN._CurrTabName);
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
public bool UpdateBySP(clsQxFuncModuleEN objQxFuncModuleEN)
{
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModuleEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxFuncModuleEN.FuncModuleId,
 objQxFuncModuleEN.FuncModuleName,
 objQxFuncModuleEN.FuncModuleNameSim,
 objQxFuncModuleEN.FuncModuleEnName,
 objQxFuncModuleEN.OrderNum,
 objQxFuncModuleEN.InUse,
 objQxFuncModuleEN.QxPrjId,
 objQxFuncModuleEN.UpdDate,
 objQxFuncModuleEN.UpdUser
};
 objSQL.ExecSP("QxFuncModule_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxFuncModuleEN objQxFuncModuleEN)
{
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModuleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxFuncModule Set ");
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleName))
 {
 if (objQxFuncModuleEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objQxFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleName, conQxFuncModule.FuncModuleName); //模块名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.FuncModuleName); //模块名
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleNameSim))
 {
 if (objQxFuncModuleEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objQxFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleNameSim, conQxFuncModule.FuncModuleNameSim); //模块名_Sim
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.FuncModuleNameSim); //模块名_Sim
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleEnName))
 {
 if (objQxFuncModuleEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objQxFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleEnName, conQxFuncModule.FuncModuleEnName); //模块英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.FuncModuleEnName); //模块英文名
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxFuncModuleEN.OrderNum, conQxFuncModule.OrderNum); //排序号
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxFuncModuleEN.InUse == true?"1":"0", conQxFuncModule.InUse); //是否在用
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.QxPrjId))
 {
 if (objQxFuncModuleEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxFuncModuleEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxFuncModule.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.QxPrjId); //项目Id
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.UpdDate))
 {
 if (objQxFuncModuleEN.UpdDate !=  null)
 {
 var strUpdDate = objQxFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxFuncModule.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.UpdDate); //修改日期
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.UpdUser))
 {
 if (objQxFuncModuleEN.UpdUser !=  null)
 {
 var strUpdUser = objQxFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxFuncModule.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.UpdUser); //修改用户
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncModuleId = '{0}'", objQxFuncModuleEN.FuncModuleId); 
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
 /// <param name = "objQxFuncModuleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxFuncModuleEN objQxFuncModuleEN, string strCondition)
{
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModuleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxFuncModule Set ");
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleName))
 {
 if (objQxFuncModuleEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objQxFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleName = '{0}',", strFuncModuleName); //模块名
 }
 else
 {
 sbSQL.Append(" FuncModuleName = null,"); //模块名
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleNameSim))
 {
 if (objQxFuncModuleEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objQxFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleNameSim = '{0}',", strFuncModuleNameSim); //模块名_Sim
 }
 else
 {
 sbSQL.Append(" FuncModuleNameSim = null,"); //模块名_Sim
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleEnName))
 {
 if (objQxFuncModuleEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objQxFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleEnName = '{0}',", strFuncModuleEnName); //模块英文名
 }
 else
 {
 sbSQL.Append(" FuncModuleEnName = null,"); //模块英文名
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxFuncModuleEN.OrderNum); //排序号
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxFuncModuleEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.QxPrjId))
 {
 if (objQxFuncModuleEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxFuncModuleEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.UpdDate))
 {
 if (objQxFuncModuleEN.UpdDate !=  null)
 {
 var strUpdDate = objQxFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.UpdUser))
 {
 if (objQxFuncModuleEN.UpdUser !=  null)
 {
 var strUpdUser = objQxFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
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
 /// <param name = "objQxFuncModuleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxFuncModuleEN objQxFuncModuleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModuleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxFuncModule Set ");
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleName))
 {
 if (objQxFuncModuleEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objQxFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleName = '{0}',", strFuncModuleName); //模块名
 }
 else
 {
 sbSQL.Append(" FuncModuleName = null,"); //模块名
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleNameSim))
 {
 if (objQxFuncModuleEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objQxFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleNameSim = '{0}',", strFuncModuleNameSim); //模块名_Sim
 }
 else
 {
 sbSQL.Append(" FuncModuleNameSim = null,"); //模块名_Sim
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleEnName))
 {
 if (objQxFuncModuleEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objQxFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleEnName = '{0}',", strFuncModuleEnName); //模块英文名
 }
 else
 {
 sbSQL.Append(" FuncModuleEnName = null,"); //模块英文名
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxFuncModuleEN.OrderNum); //排序号
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxFuncModuleEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.QxPrjId))
 {
 if (objQxFuncModuleEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxFuncModuleEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.UpdDate))
 {
 if (objQxFuncModuleEN.UpdDate !=  null)
 {
 var strUpdDate = objQxFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.UpdUser))
 {
 if (objQxFuncModuleEN.UpdUser !=  null)
 {
 var strUpdUser = objQxFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
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
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxFuncModuleEN objQxFuncModuleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxFuncModuleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxFuncModule Set ");
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleName))
 {
 if (objQxFuncModuleEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objQxFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleName, conQxFuncModule.FuncModuleName); //模块名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.FuncModuleName); //模块名
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleNameSim))
 {
 if (objQxFuncModuleEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objQxFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleNameSim, conQxFuncModule.FuncModuleNameSim); //模块名_Sim
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.FuncModuleNameSim); //模块名_Sim
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.FuncModuleEnName))
 {
 if (objQxFuncModuleEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objQxFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleEnName, conQxFuncModule.FuncModuleEnName); //模块英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.FuncModuleEnName); //模块英文名
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxFuncModuleEN.OrderNum, conQxFuncModule.OrderNum); //排序号
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxFuncModuleEN.InUse == true?"1":"0", conQxFuncModule.InUse); //是否在用
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.QxPrjId))
 {
 if (objQxFuncModuleEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxFuncModuleEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxFuncModule.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.QxPrjId); //项目Id
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.UpdDate))
 {
 if (objQxFuncModuleEN.UpdDate !=  null)
 {
 var strUpdDate = objQxFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxFuncModule.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.UpdDate); //修改日期
 }
 }
 
 if (objQxFuncModuleEN.IsUpdated(conQxFuncModule.UpdUser))
 {
 if (objQxFuncModuleEN.UpdUser !=  null)
 {
 var strUpdUser = objQxFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxFuncModule.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxFuncModule.UpdUser); //修改用户
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncModuleId = '{0}'", objQxFuncModuleEN.FuncModuleId); 
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFuncModuleId) 
{
CheckPrimaryKey(strFuncModuleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFuncModuleId,
};
 objSQL.ExecSP("QxFuncModule_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFuncModuleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFuncModuleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
//删除QxFuncModule本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxFuncModule where FuncModuleId = " + "'"+ strFuncModuleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxFuncModule(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
//删除QxFuncModule本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxFuncModule where FuncModuleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFuncModuleId) 
{
CheckPrimaryKey(strFuncModuleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
//删除QxFuncModule本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxFuncModule where FuncModuleId = " + "'"+ strFuncModuleId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxFuncModule(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: DelQxFuncModule)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxFuncModule where " + strCondition ;
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
public bool DelQxFuncModuleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxFuncModuleDA: DelQxFuncModuleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxFuncModule where " + strCondition ;
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
 /// <param name = "objQxFuncModuleENS">源对象</param>
 /// <param name = "objQxFuncModuleENT">目标对象</param>
public void CopyTo(clsQxFuncModuleEN objQxFuncModuleENS, clsQxFuncModuleEN objQxFuncModuleENT)
{
objQxFuncModuleENT.FuncModuleId = objQxFuncModuleENS.FuncModuleId; //模块Id
objQxFuncModuleENT.FuncModuleName = objQxFuncModuleENS.FuncModuleName; //模块名
objQxFuncModuleENT.FuncModuleNameSim = objQxFuncModuleENS.FuncModuleNameSim; //模块名_Sim
objQxFuncModuleENT.FuncModuleEnName = objQxFuncModuleENS.FuncModuleEnName; //模块英文名
objQxFuncModuleENT.OrderNum = objQxFuncModuleENS.OrderNum; //排序号
objQxFuncModuleENT.InUse = objQxFuncModuleENS.InUse; //是否在用
objQxFuncModuleENT.QxPrjId = objQxFuncModuleENS.QxPrjId; //项目Id
objQxFuncModuleENT.UpdDate = objQxFuncModuleENS.UpdDate; //修改日期
objQxFuncModuleENT.UpdUser = objQxFuncModuleENS.UpdUser; //修改用户
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxFuncModuleEN objQxFuncModuleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxFuncModuleEN.FuncModuleName, conQxFuncModule.FuncModuleName);
clsCheckSql.CheckFieldNotNull(objQxFuncModuleEN.OrderNum, conQxFuncModule.OrderNum);
clsCheckSql.CheckFieldNotNull(objQxFuncModuleEN.QxPrjId, conQxFuncModule.QxPrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.FuncModuleId, 4, conQxFuncModule.FuncModuleId);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.FuncModuleName, 30, conQxFuncModule.FuncModuleName);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.FuncModuleNameSim, 30, conQxFuncModule.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.FuncModuleEnName, 30, conQxFuncModule.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.QxPrjId, 4, conQxFuncModule.QxPrjId);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.UpdDate, 20, conQxFuncModule.UpdDate);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.UpdUser, 18, conQxFuncModule.UpdUser);
//检查字段外键固定长度
 objQxFuncModuleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxFuncModuleEN objQxFuncModuleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.FuncModuleName, 30, conQxFuncModule.FuncModuleName);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.FuncModuleNameSim, 30, conQxFuncModule.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.FuncModuleEnName, 30, conQxFuncModule.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.QxPrjId, 4, conQxFuncModule.QxPrjId);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.UpdDate, 20, conQxFuncModule.UpdDate);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.UpdUser, 18, conQxFuncModule.UpdUser);
//检查外键字段长度
 objQxFuncModuleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxFuncModuleEN objQxFuncModuleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.FuncModuleId, 4, conQxFuncModule.FuncModuleId);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.FuncModuleName, 30, conQxFuncModule.FuncModuleName);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.FuncModuleNameSim, 30, conQxFuncModule.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.FuncModuleEnName, 30, conQxFuncModule.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.QxPrjId, 4, conQxFuncModule.QxPrjId);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.UpdDate, 20, conQxFuncModule.UpdDate);
clsCheckSql.CheckFieldLen(objQxFuncModuleEN.UpdUser, 18, conQxFuncModule.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxFuncModuleEN.FuncModuleId, conQxFuncModule.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModuleEN.FuncModuleName, conQxFuncModule.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModuleEN.FuncModuleNameSim, conQxFuncModule.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModuleEN.FuncModuleEnName, conQxFuncModule.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModuleEN.QxPrjId, conQxFuncModule.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModuleEN.UpdDate, conQxFuncModule.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxFuncModuleEN.UpdUser, conQxFuncModule.UpdUser);
//检查外键字段长度
 objQxFuncModuleEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFuncModuleId()
{
//获取某学院所有专业信息
string strSQL = "select FuncModuleId, FuncModuleName from QxFuncModule ";
 clsSpecSQLforSql mySql = clsQxFuncModuleDA.GetSpecSQLObj();
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
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxFuncModuleEN._CurrTabName);
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
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxFuncModuleEN._CurrTabName, strCondition);
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
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
 objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}