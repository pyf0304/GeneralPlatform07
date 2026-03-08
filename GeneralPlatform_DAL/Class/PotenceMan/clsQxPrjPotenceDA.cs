
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjPotenceDA
 表名:QxPrjPotence(00140005)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:14:47
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
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
 /// 工程权限(QxPrjPotence)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxPrjPotenceDA : clsCommBase4DA
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
 return clsQxPrjPotenceEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxPrjPotenceEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjPotenceEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxPrjPotenceEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxPrjPotenceEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPotenceId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPotenceId)
{
strPotenceId = strPotenceId.Replace("'", "''");
if (strPotenceId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:QxPrjPotence中,检查关键字,长度不正确!(clsQxPrjPotenceDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPotenceId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxPrjPotence中,关键字不能为空 或 null!(clsQxPrjPotenceDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPotenceId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxPrjPotenceDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strPotenceId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strPotenceId)
{
strPotenceId = strPotenceId.Replace("'", "''");
if (strPotenceId.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:QxPrjPotence中,检查关键字,长度不正确!(简化版)(clsQxPrjPotenceDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPotenceId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxPrjPotence中,关键字不能为空 或 null!(clsQxPrjPotenceDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPotenceId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxPrjPotenceDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
 strSQL = "Select * from QxPrjPotence where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxPrjPotence");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxPrjPotence_SelectByCond",values, "QxPrjPotence");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjPotence where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjPotence");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjPotence a where {0} And a.PotenceId not in (Select Top {2} PotenceId From QxPrjPotence Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjPotence");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjPotence a where {0} And a.PotenceId not in (Select Top {2} PotenceId From QxPrjPotence Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjPotence");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjPotence a where {0} And a.PotenceId not in (Select Top {2} PotenceId From QxPrjPotence Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjPotence");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxPrjPotence(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTable_QxPrjPotence)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotence where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotence where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjPotence where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjPotence where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjPotence.* from QxPrjPotence Left Join {1} on {2} where {3} and QxPrjPotence.PotenceId not in (Select top {5} QxPrjPotence.PotenceId from QxPrjPotence Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotence where {1} and PotenceId not in (Select top {2} PotenceId from QxPrjPotence where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotence where {1} and PotenceId not in (Select top {3} PotenceId from QxPrjPotence where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjPotence.* from QxPrjPotence Left Join {1} on {2} where {3} and QxPrjPotence.PotenceId not in (Select top {5} QxPrjPotence.PotenceId from QxPrjPotence Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotence where {1} and PotenceId not in (Select top {2} PotenceId from QxPrjPotence where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotence where {1} and PotenceId not in (Select top {3} PotenceId from QxPrjPotence where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjPotence.* from QxPrjPotence Left Join {1} on {2} where {3} and QxPrjPotence.PotenceId not in (Select top {5} QxPrjPotence.PotenceId from QxPrjPotence Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotence where {1} and PotenceId not in (Select top {2} PotenceId from QxPrjPotence where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotence where {1} and PotenceId not in (Select top {3} PotenceId from QxPrjPotence where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjPotence a where {0} And a.PotenceId not in (Select Top {2} PotenceId From QxPrjPotence Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjPotence a where {0} And a.PotenceId not in (Select Top {2} PotenceId From QxPrjPotence Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjPotence a where {0} And a.PotenceId not in (Select Top {2} PotenceId From QxPrjPotence Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjPotence a where {0} And a.PotenceId not in (Select Top {2} PotenceId From QxPrjPotence Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceDA: GetQxPrjPotenceByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjPotence_SelectByCond",values);
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
public List<clsQxPrjPotenceEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA:GetObjLst)", objException.Message));
}
List<clsQxPrjPotenceEN> arrObjLst = new List<clsQxPrjPotenceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN();
try
{
objQxPrjPotenceEN.PotenceId = objRow[conQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objQxPrjPotenceEN.PotenceName = objRow[conQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceEN.QxPrjId = objRow[conQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceEN.FuncModuleId = objRow[conQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceEN.PotenceTypeId = objRow[conQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceEN.MenuId = objRow[conQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceEN.MenuId4Win = objRow[conQxPrjPotence.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceEN.UpdDate = objRow[conQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceEN.UpdUserId = objRow[conQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceEN.Memo = objRow[conQxPrjPotence.Memo] == DBNull.Value ? null : objRow[conQxPrjPotence.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjPotenceDA: GetObjLst)", objException.Message));
}
objQxPrjPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjPotenceEN);
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
public List<clsQxPrjPotenceEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxPrjPotenceEN> arrObjLst = new List<clsQxPrjPotenceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN();
try
{
objQxPrjPotenceEN.PotenceId = objRow[conQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objQxPrjPotenceEN.PotenceName = objRow[conQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceEN.QxPrjId = objRow[conQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceEN.FuncModuleId = objRow[conQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceEN.PotenceTypeId = objRow[conQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceEN.MenuId = objRow[conQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceEN.MenuId4Win = objRow[conQxPrjPotence.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceEN.UpdDate = objRow[conQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceEN.UpdUserId = objRow[conQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceEN.Memo = objRow[conQxPrjPotence.Memo] == DBNull.Value ? null : objRow[conQxPrjPotence.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjPotenceDA: GetObjLst)", objException.Message));
}
objQxPrjPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxPrjPotenceEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA:GetObjLstBySP)", objException.Message));
}
List<clsQxPrjPotenceEN> arrObjLst = new List<clsQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjPotence_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN();
try
{
objQxPrjPotenceEN.PotenceId = objRow[conQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objQxPrjPotenceEN.PotenceName = objRow[conQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceEN.QxPrjId = objRow[conQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceEN.FuncModuleId = objRow[conQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceEN.PotenceTypeId = objRow[conQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceEN.MenuId = objRow[conQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceEN.MenuId4Win = objRow[conQxPrjPotence.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceEN.UpdDate = objRow[conQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceEN.UpdUserId = objRow[conQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceEN.Memo = objRow[conQxPrjPotence.Memo] == DBNull.Value ? null : objRow[conQxPrjPotence.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjPotenceDA: GetObjLstBySP)", objException.Message));
}
objQxPrjPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjPotenceEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjPotence(ref clsQxPrjPotenceEN objQxPrjPotenceEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where PotenceId = " + "'"+ objQxPrjPotenceEN.PotenceId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxPrjPotenceEN.PotenceId = objDT.Rows[0][conQxPrjPotence.PotenceId].ToString().Trim(); //权限ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjPotenceEN.PotenceName = objDT.Rows[0][conQxPrjPotence.PotenceName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objQxPrjPotenceEN.QxPrjId = objDT.Rows[0][conQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceEN.FuncModuleId = objDT.Rows[0][conQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceEN.PotenceTypeId = objDT.Rows[0][conQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPrjPotenceEN.MenuId = objDT.Rows[0][conQxPrjPotence.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjPotenceEN.MenuId4Win = objDT.Rows[0][conQxPrjPotence.MenuId4Win].ToString().Trim(); //菜单Id4Win(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjPotenceEN.UpdDate = objDT.Rows[0][conQxPrjPotence.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceEN.UpdUserId = objDT.Rows[0][conQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceEN.Memo = objDT.Rows[0][conQxPrjPotence.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxPrjPotenceDA: GetQxPrjPotence)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPotenceId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxPrjPotenceEN GetObjByPotenceId(string strPotenceId)
{
CheckPrimaryKey(strPotenceId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where PotenceId = " + "'"+ strPotenceId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN();
try
{
 objQxPrjPotenceEN.PotenceId = objRow[conQxPrjPotence.PotenceId].ToString().Trim(); //权限ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjPotenceEN.PotenceName = objRow[conQxPrjPotence.PotenceName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objQxPrjPotenceEN.QxPrjId = objRow[conQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceEN.FuncModuleId = objRow[conQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceEN.PotenceTypeId = objRow[conQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPrjPotenceEN.MenuId = objRow[conQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjPotenceEN.MenuId4Win = objRow[conQxPrjPotence.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId4Win].ToString().Trim(); //菜单Id4Win(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjPotenceEN.UpdDate = objRow[conQxPrjPotence.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceEN.UpdUserId = objRow[conQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceEN.Memo = objRow[conQxPrjPotence.Memo] == DBNull.Value ? null : objRow[conQxPrjPotence.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxPrjPotenceDA: GetObjByPotenceId)", objException.Message));
}
return objQxPrjPotenceEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxPrjPotence_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjPotenceOneBySP(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxPrjPotenceEN.PotenceId
};
 objDT = objSQL.ExecSpReturnDT("QxPrjPotence_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxPrjPotenceEN.PotenceId = objDT.Rows[0][conQxPrjPotence.PotenceId].ToString().Trim(); //权限ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjPotenceEN.PotenceName = objDT.Rows[0][conQxPrjPotence.PotenceName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objQxPrjPotenceEN.QxPrjId = objDT.Rows[0][conQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceEN.FuncModuleId = objDT.Rows[0][conQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceEN.PotenceTypeId = objDT.Rows[0][conQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPrjPotenceEN.MenuId = objDT.Rows[0][conQxPrjPotence.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjPotenceEN.MenuId4Win = objDT.Rows[0][conQxPrjPotence.MenuId4Win].ToString().Trim(); //菜单Id4Win(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjPotenceEN.UpdDate = objDT.Rows[0][conQxPrjPotence.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceEN.UpdUserId = objDT.Rows[0][conQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceEN.Memo = objDT.Rows[0][conQxPrjPotence.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjPotenceEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN()
{
PotenceId = objRow[conQxPrjPotence.PotenceId].ToString().Trim(), //权限ID
PotenceName = objRow[conQxPrjPotence.PotenceName].ToString().Trim(), //权限名称
QxPrjId = objRow[conQxPrjPotence.QxPrjId].ToString().Trim(), //项目Id
FuncModuleId = objRow[conQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotence.FuncModuleId].ToString().Trim(), //模块Id
PotenceTypeId = objRow[conQxPrjPotence.PotenceTypeId].ToString().Trim(), //权限类型Id
MenuId = objRow[conQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId].ToString().Trim(), //菜单Id
MenuId4Win = objRow[conQxPrjPotence.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId4Win].ToString().Trim(), //菜单Id4Win
UpdDate = objRow[conQxPrjPotence.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxPrjPotence.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPrjPotence.Memo] == DBNull.Value ? null : objRow[conQxPrjPotence.Memo].ToString().Trim() //备注
};
objQxPrjPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjPotenceEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxPrjPotenceDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjPotenceEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjPotence_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN()
{
PotenceId = objRow[conQxPrjPotence.PotenceId].ToString().Trim(), //权限ID
PotenceName = objRow[conQxPrjPotence.PotenceName].ToString().Trim(), //权限名称
QxPrjId = objRow[conQxPrjPotence.QxPrjId].ToString().Trim(), //项目Id
FuncModuleId = objRow[conQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotence.FuncModuleId].ToString().Trim(), //模块Id
PotenceTypeId = objRow[conQxPrjPotence.PotenceTypeId].ToString().Trim(), //权限类型Id
MenuId = objRow[conQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId].ToString().Trim(), //菜单Id
MenuId4Win = objRow[conQxPrjPotence.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId4Win].ToString().Trim(), //菜单Id4Win
UpdDate = objRow[conQxPrjPotence.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxPrjPotence.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPrjPotence.Memo] == DBNull.Value ? null : objRow[conQxPrjPotence.Memo].ToString().Trim() //备注
};
objQxPrjPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjPotenceEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxPrjPotenceEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN();
try
{
objQxPrjPotenceEN.PotenceId = objRow[conQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objQxPrjPotenceEN.PotenceName = objRow[conQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceEN.QxPrjId = objRow[conQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceEN.FuncModuleId = objRow[conQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceEN.PotenceTypeId = objRow[conQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceEN.MenuId = objRow[conQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceEN.MenuId4Win = objRow[conQxPrjPotence.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceEN.UpdDate = objRow[conQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceEN.UpdUserId = objRow[conQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceEN.Memo = objRow[conQxPrjPotence.Memo] == DBNull.Value ? null : objRow[conQxPrjPotence.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxPrjPotenceDA: GetObjByDataRowQxPrjPotence)", objException.Message));
}
objQxPrjPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjPotenceEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxPrjPotenceEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN();
try
{
objQxPrjPotenceEN.PotenceId = objRow[conQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objQxPrjPotenceEN.PotenceName = objRow[conQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceEN.QxPrjId = objRow[conQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceEN.FuncModuleId = objRow[conQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceEN.PotenceTypeId = objRow[conQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceEN.MenuId = objRow[conQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceEN.MenuId4Win = objRow[conQxPrjPotence.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotence.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceEN.UpdDate = objRow[conQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceEN.UpdUserId = objRow[conQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceEN.Memo = objRow[conQxPrjPotence.Memo] == DBNull.Value ? null : objRow[conQxPrjPotence.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxPrjPotenceDA: GetObjByDataRow)", objException.Message));
}
objQxPrjPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjPotenceEN;
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
objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjPotenceEN._CurrTabName, conQxPrjPotence.PotenceId, 8, "");
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
objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjPotenceEN._CurrTabName, conQxPrjPotence.PotenceId, 8, strPrefix);
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
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PotenceId from QxPrjPotence where " + strCondition;
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
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PotenceId from QxPrjPotence where " + strCondition;
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
 /// <param name = "strPotenceId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPotenceId)
{
CheckPrimaryKey(strPotenceId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjPotence", "PotenceId = " + "'"+ strPotenceId+"'"))
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
 /// <param name = "strPotenceId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strPotenceId)
{
CheckPrimaryKey(strPotenceId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strPotenceId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxPrjPotence_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjPotence", strCondition))
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
objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxPrjPotence");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxPrjPotenceEN objQxPrjPotenceEN)
 {
 objQxPrjPotenceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjPotenceEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjPotence");
objRow = objDS.Tables["QxPrjPotence"].NewRow();
objRow[conQxPrjPotence.PotenceId] = objQxPrjPotenceEN.PotenceId; //权限ID
objRow[conQxPrjPotence.PotenceName] = objQxPrjPotenceEN.PotenceName; //权限名称
objRow[conQxPrjPotence.QxPrjId] = objQxPrjPotenceEN.QxPrjId; //项目Id
 if (objQxPrjPotenceEN.FuncModuleId !=  "")
 {
objRow[conQxPrjPotence.FuncModuleId] = objQxPrjPotenceEN.FuncModuleId; //模块Id
 }
objRow[conQxPrjPotence.PotenceTypeId] = objQxPrjPotenceEN.PotenceTypeId; //权限类型Id
 if (objQxPrjPotenceEN.MenuId !=  "")
 {
objRow[conQxPrjPotence.MenuId] = objQxPrjPotenceEN.MenuId; //菜单Id
 }
 if (objQxPrjPotenceEN.MenuId4Win !=  "")
 {
objRow[conQxPrjPotence.MenuId4Win] = objQxPrjPotenceEN.MenuId4Win; //菜单Id4Win
 }
objRow[conQxPrjPotence.UpdDate] = objQxPrjPotenceEN.UpdDate; //修改日期
objRow[conQxPrjPotence.UpdUserId] = objQxPrjPotenceEN.UpdUserId; //修改用户Id
 if (objQxPrjPotenceEN.Memo !=  "")
 {
objRow[conQxPrjPotence.Memo] = objQxPrjPotenceEN.Memo; //备注
 }
objDS.Tables[clsQxPrjPotenceEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxPrjPotenceEN._CurrTabName);
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
 /// <param name = "objQxPrjPotenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
 objQxPrjPotenceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjPotenceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjPotenceEN.PotenceId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.PotenceId);
 var strPotenceId = objQxPrjPotenceEN.PotenceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceId + "'");
 }
 
 if (objQxPrjPotenceEN.PotenceName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.PotenceName);
 var strPotenceName = objQxPrjPotenceEN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceName + "'");
 }
 
 if (objQxPrjPotenceEN.QxPrjId  ==  "")
 {
 objQxPrjPotenceEN.QxPrjId = null;
 }
 if (objQxPrjPotenceEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.QxPrjId);
 var strQxPrjId = objQxPrjPotenceEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjPotenceEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.FuncModuleId);
 var strFuncModuleId = objQxPrjPotenceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxPrjPotenceEN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceEN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceEN.PotenceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.PotenceTypeId);
 var strPotenceTypeId = objQxPrjPotenceEN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeId + "'");
 }
 
 if (objQxPrjPotenceEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.MenuId);
 var strMenuId = objQxPrjPotenceEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPrjPotenceEN.MenuId4Win !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.MenuId4Win);
 var strMenuId4Win = objQxPrjPotenceEN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId4Win + "'");
 }
 
 if (objQxPrjPotenceEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.UpdDate);
 var strUpdDate = objQxPrjPotenceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjPotenceEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.UpdUserId);
 var strUpdUserId = objQxPrjPotenceEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjPotenceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.Memo);
 var strMemo = objQxPrjPotenceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjPotence");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
 objQxPrjPotenceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjPotenceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjPotenceEN.PotenceId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.PotenceId);
 var strPotenceId = objQxPrjPotenceEN.PotenceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceId + "'");
 }
 
 if (objQxPrjPotenceEN.PotenceName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.PotenceName);
 var strPotenceName = objQxPrjPotenceEN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceName + "'");
 }
 
 if (objQxPrjPotenceEN.QxPrjId  ==  "")
 {
 objQxPrjPotenceEN.QxPrjId = null;
 }
 if (objQxPrjPotenceEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.QxPrjId);
 var strQxPrjId = objQxPrjPotenceEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjPotenceEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.FuncModuleId);
 var strFuncModuleId = objQxPrjPotenceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxPrjPotenceEN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceEN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceEN.PotenceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.PotenceTypeId);
 var strPotenceTypeId = objQxPrjPotenceEN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeId + "'");
 }
 
 if (objQxPrjPotenceEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.MenuId);
 var strMenuId = objQxPrjPotenceEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPrjPotenceEN.MenuId4Win !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.MenuId4Win);
 var strMenuId4Win = objQxPrjPotenceEN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId4Win + "'");
 }
 
 if (objQxPrjPotenceEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.UpdDate);
 var strUpdDate = objQxPrjPotenceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjPotenceEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.UpdUserId);
 var strUpdUserId = objQxPrjPotenceEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjPotenceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.Memo);
 var strMemo = objQxPrjPotenceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjPotence");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxPrjPotenceEN.PotenceId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjPotenceEN objQxPrjPotenceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjPotenceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjPotenceEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjPotenceEN.PotenceId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.PotenceId);
 var strPotenceId = objQxPrjPotenceEN.PotenceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceId + "'");
 }
 
 if (objQxPrjPotenceEN.PotenceName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.PotenceName);
 var strPotenceName = objQxPrjPotenceEN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceName + "'");
 }
 
 if (objQxPrjPotenceEN.QxPrjId  ==  "")
 {
 objQxPrjPotenceEN.QxPrjId = null;
 }
 if (objQxPrjPotenceEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.QxPrjId);
 var strQxPrjId = objQxPrjPotenceEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjPotenceEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.FuncModuleId);
 var strFuncModuleId = objQxPrjPotenceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxPrjPotenceEN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceEN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceEN.PotenceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.PotenceTypeId);
 var strPotenceTypeId = objQxPrjPotenceEN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeId + "'");
 }
 
 if (objQxPrjPotenceEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.MenuId);
 var strMenuId = objQxPrjPotenceEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPrjPotenceEN.MenuId4Win !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.MenuId4Win);
 var strMenuId4Win = objQxPrjPotenceEN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId4Win + "'");
 }
 
 if (objQxPrjPotenceEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.UpdDate);
 var strUpdDate = objQxPrjPotenceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjPotenceEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.UpdUserId);
 var strUpdUserId = objQxPrjPotenceEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjPotenceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotence.Memo);
 var strMemo = objQxPrjPotenceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjPotence");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxPrjPotenceBySP(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
//通过存储过程来
//直接使用
 objQxPrjPotenceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjPotenceEN.PotenceId,
 objQxPrjPotenceEN.PotenceName,
 objQxPrjPotenceEN.QxPrjId,
 objQxPrjPotenceEN.FuncModuleId,
 objQxPrjPotenceEN.PotenceTypeId,
 objQxPrjPotenceEN.MenuId,
 objQxPrjPotenceEN.MenuId4Win,
 objQxPrjPotenceEN.UpdDate,
 objQxPrjPotenceEN.UpdUserId,
objQxPrjPotenceEN.Memo
};
 objSQL.ExecSP("QxPrjPotence_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxPrjPotences(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where PotenceId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjPotence");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPotenceId = oRow[conQxPrjPotence.PotenceId].ToString().Trim();
if (IsExist(strPotenceId))
{
 string strResult = "关键字变量值为:" + string.Format("PotenceId = {0}", strPotenceId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxPrjPotenceEN._CurrTabName ].NewRow();
objRow[conQxPrjPotence.PotenceId] = oRow[conQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objRow[conQxPrjPotence.PotenceName] = oRow[conQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objRow[conQxPrjPotence.QxPrjId] = oRow[conQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxPrjPotence.FuncModuleId] = oRow[conQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objRow[conQxPrjPotence.PotenceTypeId] = oRow[conQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objRow[conQxPrjPotence.MenuId] = oRow[conQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objRow[conQxPrjPotence.MenuId4Win] = oRow[conQxPrjPotence.MenuId4Win].ToString().Trim(); //菜单Id4Win
objRow[conQxPrjPotence.UpdDate] = oRow[conQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objRow[conQxPrjPotence.UpdUserId] = oRow[conQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conQxPrjPotence.Memo] = oRow[conQxPrjPotence.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxPrjPotenceEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxPrjPotenceEN._CurrTabName);
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
 /// <param name = "objQxPrjPotenceEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
 objQxPrjPotenceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotence where PotenceId = " + "'"+ objQxPrjPotenceEN.PotenceId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxPrjPotenceEN._CurrTabName);
if (objDS.Tables[clsQxPrjPotenceEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PotenceId = " + "'"+ objQxPrjPotenceEN.PotenceId+"'");
return false;
}
objRow = objDS.Tables[clsQxPrjPotenceEN._CurrTabName].Rows[0];
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.PotenceId))
 {
objRow[conQxPrjPotence.PotenceId] = objQxPrjPotenceEN.PotenceId; //权限ID
 }
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.PotenceName))
 {
objRow[conQxPrjPotence.PotenceName] = objQxPrjPotenceEN.PotenceName; //权限名称
 }
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.QxPrjId))
 {
objRow[conQxPrjPotence.QxPrjId] = objQxPrjPotenceEN.QxPrjId; //项目Id
 }
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.FuncModuleId))
 {
objRow[conQxPrjPotence.FuncModuleId] = objQxPrjPotenceEN.FuncModuleId; //模块Id
 }
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.PotenceTypeId))
 {
objRow[conQxPrjPotence.PotenceTypeId] = objQxPrjPotenceEN.PotenceTypeId; //权限类型Id
 }
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.MenuId))
 {
objRow[conQxPrjPotence.MenuId] = objQxPrjPotenceEN.MenuId; //菜单Id
 }
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.MenuId4Win))
 {
objRow[conQxPrjPotence.MenuId4Win] = objQxPrjPotenceEN.MenuId4Win; //菜单Id4Win
 }
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.UpdDate))
 {
objRow[conQxPrjPotence.UpdDate] = objQxPrjPotenceEN.UpdDate; //修改日期
 }
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.UpdUserId))
 {
objRow[conQxPrjPotence.UpdUserId] = objQxPrjPotenceEN.UpdUserId; //修改用户Id
 }
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.Memo))
 {
objRow[conQxPrjPotence.Memo] = objQxPrjPotenceEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxPrjPotenceEN._CurrTabName);
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
public bool UpdateBySP(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
 objQxPrjPotenceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjPotenceEN.PotenceId,
 objQxPrjPotenceEN.PotenceName,
 objQxPrjPotenceEN.QxPrjId,
 objQxPrjPotenceEN.FuncModuleId,
 objQxPrjPotenceEN.PotenceTypeId,
 objQxPrjPotenceEN.MenuId,
 objQxPrjPotenceEN.MenuId4Win,
 objQxPrjPotenceEN.UpdDate,
 objQxPrjPotenceEN.UpdUserId,
 objQxPrjPotenceEN.Memo
};
 objSQL.ExecSP("QxPrjPotence_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
 objQxPrjPotenceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxPrjPotence Set ");
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.PotenceName))
 {
 if (objQxPrjPotenceEN.PotenceName !=  null)
 {
 var strPotenceName = objQxPrjPotenceEN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceName, conQxPrjPotence.PotenceName); //权限名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.PotenceName); //权限名称
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.QxPrjId))
 {
 if (objQxPrjPotenceEN.QxPrjId  ==  "")
 {
 objQxPrjPotenceEN.QxPrjId = null;
 }
 if (objQxPrjPotenceEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjPotenceEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjPotence.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.FuncModuleId))
 {
 if (objQxPrjPotenceEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPrjPotenceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conQxPrjPotence.FuncModuleId); //模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.FuncModuleId); //模块Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.PotenceTypeId))
 {
 if (objQxPrjPotenceEN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceEN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceEN.PotenceTypeId !=  null)
 {
 var strPotenceTypeId = objQxPrjPotenceEN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceTypeId, conQxPrjPotence.PotenceTypeId); //权限类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.PotenceTypeId); //权限类型Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.MenuId))
 {
 if (objQxPrjPotenceEN.MenuId !=  null)
 {
 var strMenuId = objQxPrjPotenceEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId, conQxPrjPotence.MenuId); //菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.MenuId); //菜单Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.MenuId4Win))
 {
 if (objQxPrjPotenceEN.MenuId4Win !=  null)
 {
 var strMenuId4Win = objQxPrjPotenceEN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId4Win, conQxPrjPotence.MenuId4Win); //菜单Id4Win
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.MenuId4Win); //菜单Id4Win
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.UpdDate))
 {
 if (objQxPrjPotenceEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjPotenceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjPotence.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.UpdUserId))
 {
 if (objQxPrjPotenceEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjPotenceEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjPotence.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.Memo))
 {
 if (objQxPrjPotenceEN.Memo !=  null)
 {
 var strMemo = objQxPrjPotenceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjPotence.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PotenceId = '{0}'", objQxPrjPotenceEN.PotenceId); 
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
 /// <param name = "objQxPrjPotenceEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxPrjPotenceEN objQxPrjPotenceEN, string strCondition)
{
 objQxPrjPotenceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjPotence Set ");
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.PotenceName))
 {
 if (objQxPrjPotenceEN.PotenceName !=  null)
 {
 var strPotenceName = objQxPrjPotenceEN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceName = '{0}',", strPotenceName); //权限名称
 }
 else
 {
 sbSQL.Append(" PotenceName = null,"); //权限名称
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.QxPrjId))
 {
 if (objQxPrjPotenceEN.QxPrjId  ==  "")
 {
 objQxPrjPotenceEN.QxPrjId = null;
 }
 if (objQxPrjPotenceEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjPotenceEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.FuncModuleId))
 {
 if (objQxPrjPotenceEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPrjPotenceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //模块Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.PotenceTypeId))
 {
 if (objQxPrjPotenceEN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceEN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceEN.PotenceTypeId !=  null)
 {
 var strPotenceTypeId = objQxPrjPotenceEN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceTypeId = '{0}',", strPotenceTypeId); //权限类型Id
 }
 else
 {
 sbSQL.Append(" PotenceTypeId = null,"); //权限类型Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.MenuId))
 {
 if (objQxPrjPotenceEN.MenuId !=  null)
 {
 var strMenuId = objQxPrjPotenceEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId = '{0}',", strMenuId); //菜单Id
 }
 else
 {
 sbSQL.Append(" MenuId = null,"); //菜单Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.MenuId4Win))
 {
 if (objQxPrjPotenceEN.MenuId4Win !=  null)
 {
 var strMenuId4Win = objQxPrjPotenceEN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId4Win = '{0}',", strMenuId4Win); //菜单Id4Win
 }
 else
 {
 sbSQL.Append(" MenuId4Win = null,"); //菜单Id4Win
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.UpdDate))
 {
 if (objQxPrjPotenceEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjPotenceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.UpdUserId))
 {
 if (objQxPrjPotenceEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjPotenceEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.Memo))
 {
 if (objQxPrjPotenceEN.Memo !=  null)
 {
 var strMemo = objQxPrjPotenceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objQxPrjPotenceEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxPrjPotenceEN objQxPrjPotenceEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxPrjPotenceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjPotence Set ");
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.PotenceName))
 {
 if (objQxPrjPotenceEN.PotenceName !=  null)
 {
 var strPotenceName = objQxPrjPotenceEN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceName = '{0}',", strPotenceName); //权限名称
 }
 else
 {
 sbSQL.Append(" PotenceName = null,"); //权限名称
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.QxPrjId))
 {
 if (objQxPrjPotenceEN.QxPrjId  ==  "")
 {
 objQxPrjPotenceEN.QxPrjId = null;
 }
 if (objQxPrjPotenceEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjPotenceEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.FuncModuleId))
 {
 if (objQxPrjPotenceEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPrjPotenceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //模块Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.PotenceTypeId))
 {
 if (objQxPrjPotenceEN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceEN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceEN.PotenceTypeId !=  null)
 {
 var strPotenceTypeId = objQxPrjPotenceEN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceTypeId = '{0}',", strPotenceTypeId); //权限类型Id
 }
 else
 {
 sbSQL.Append(" PotenceTypeId = null,"); //权限类型Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.MenuId))
 {
 if (objQxPrjPotenceEN.MenuId !=  null)
 {
 var strMenuId = objQxPrjPotenceEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId = '{0}',", strMenuId); //菜单Id
 }
 else
 {
 sbSQL.Append(" MenuId = null,"); //菜单Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.MenuId4Win))
 {
 if (objQxPrjPotenceEN.MenuId4Win !=  null)
 {
 var strMenuId4Win = objQxPrjPotenceEN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId4Win = '{0}',", strMenuId4Win); //菜单Id4Win
 }
 else
 {
 sbSQL.Append(" MenuId4Win = null,"); //菜单Id4Win
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.UpdDate))
 {
 if (objQxPrjPotenceEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjPotenceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.UpdUserId))
 {
 if (objQxPrjPotenceEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjPotenceEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.Memo))
 {
 if (objQxPrjPotenceEN.Memo !=  null)
 {
 var strMemo = objQxPrjPotenceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objQxPrjPotenceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjPotenceEN objQxPrjPotenceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjPotenceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjPotence Set ");
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.PotenceName))
 {
 if (objQxPrjPotenceEN.PotenceName !=  null)
 {
 var strPotenceName = objQxPrjPotenceEN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceName, conQxPrjPotence.PotenceName); //权限名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.PotenceName); //权限名称
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.QxPrjId))
 {
 if (objQxPrjPotenceEN.QxPrjId  ==  "")
 {
 objQxPrjPotenceEN.QxPrjId = null;
 }
 if (objQxPrjPotenceEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjPotenceEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjPotence.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.FuncModuleId))
 {
 if (objQxPrjPotenceEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPrjPotenceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conQxPrjPotence.FuncModuleId); //模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.FuncModuleId); //模块Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.PotenceTypeId))
 {
 if (objQxPrjPotenceEN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceEN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceEN.PotenceTypeId !=  null)
 {
 var strPotenceTypeId = objQxPrjPotenceEN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceTypeId, conQxPrjPotence.PotenceTypeId); //权限类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.PotenceTypeId); //权限类型Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.MenuId))
 {
 if (objQxPrjPotenceEN.MenuId !=  null)
 {
 var strMenuId = objQxPrjPotenceEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId, conQxPrjPotence.MenuId); //菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.MenuId); //菜单Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.MenuId4Win))
 {
 if (objQxPrjPotenceEN.MenuId4Win !=  null)
 {
 var strMenuId4Win = objQxPrjPotenceEN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId4Win, conQxPrjPotence.MenuId4Win); //菜单Id4Win
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.MenuId4Win); //菜单Id4Win
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.UpdDate))
 {
 if (objQxPrjPotenceEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjPotenceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjPotence.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.UpdUserId))
 {
 if (objQxPrjPotenceEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjPotenceEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjPotence.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjPotenceEN.IsUpdated(conQxPrjPotence.Memo))
 {
 if (objQxPrjPotenceEN.Memo !=  null)
 {
 var strMemo = objQxPrjPotenceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjPotence.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotence.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PotenceId = '{0}'", objQxPrjPotenceEN.PotenceId); 
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
 /// <param name = "strPotenceId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPotenceId) 
{
CheckPrimaryKey(strPotenceId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPotenceId,
};
 objSQL.ExecSP("QxPrjPotence_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPotenceId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPotenceId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPotenceId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
//删除QxPrjPotence本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjPotence where PotenceId = " + "'"+ strPotenceId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxPrjPotence(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
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
//删除QxPrjPotence本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjPotence where PotenceId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPotenceId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPotenceId) 
{
CheckPrimaryKey(strPotenceId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
//删除QxPrjPotence本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjPotence where PotenceId = " + "'"+ strPotenceId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxPrjPotence(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: DelQxPrjPotence)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjPotence where " + strCondition ;
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
public bool DelQxPrjPotenceWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxPrjPotenceDA: DelQxPrjPotenceWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjPotence where " + strCondition ;
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
 /// <param name = "objQxPrjPotenceENS">源对象</param>
 /// <param name = "objQxPrjPotenceENT">目标对象</param>
public void CopyTo(clsQxPrjPotenceEN objQxPrjPotenceENS, clsQxPrjPotenceEN objQxPrjPotenceENT)
{
objQxPrjPotenceENT.PotenceId = objQxPrjPotenceENS.PotenceId; //权限ID
objQxPrjPotenceENT.PotenceName = objQxPrjPotenceENS.PotenceName; //权限名称
objQxPrjPotenceENT.QxPrjId = objQxPrjPotenceENS.QxPrjId; //项目Id
objQxPrjPotenceENT.FuncModuleId = objQxPrjPotenceENS.FuncModuleId; //模块Id
objQxPrjPotenceENT.PotenceTypeId = objQxPrjPotenceENS.PotenceTypeId; //权限类型Id
objQxPrjPotenceENT.MenuId = objQxPrjPotenceENS.MenuId; //菜单Id
objQxPrjPotenceENT.MenuId4Win = objQxPrjPotenceENS.MenuId4Win; //菜单Id4Win
objQxPrjPotenceENT.UpdDate = objQxPrjPotenceENS.UpdDate; //修改日期
objQxPrjPotenceENT.UpdUserId = objQxPrjPotenceENS.UpdUserId; //修改用户Id
objQxPrjPotenceENT.Memo = objQxPrjPotenceENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxPrjPotenceEN.PotenceName, conQxPrjPotence.PotenceName);
clsCheckSql.CheckFieldNotNull(objQxPrjPotenceEN.QxPrjId, conQxPrjPotence.QxPrjId);
clsCheckSql.CheckFieldNotNull(objQxPrjPotenceEN.PotenceTypeId, conQxPrjPotence.PotenceTypeId);
clsCheckSql.CheckFieldNotNull(objQxPrjPotenceEN.UpdDate, conQxPrjPotence.UpdDate);
clsCheckSql.CheckFieldNotNull(objQxPrjPotenceEN.UpdUserId, conQxPrjPotence.UpdUserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.PotenceId, 8, conQxPrjPotence.PotenceId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.PotenceName, 200, conQxPrjPotence.PotenceName);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.QxPrjId, 4, conQxPrjPotence.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.FuncModuleId, 4, conQxPrjPotence.FuncModuleId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.PotenceTypeId, 6, conQxPrjPotence.PotenceTypeId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.MenuId, 8, conQxPrjPotence.MenuId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.MenuId4Win, 8, conQxPrjPotence.MenuId4Win);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.UpdDate, 20, conQxPrjPotence.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.UpdUserId, 20, conQxPrjPotence.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.Memo, 1000, conQxPrjPotence.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceEN.QxPrjId, 4, conQxPrjPotence.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceEN.PotenceTypeId, 6, conQxPrjPotence.PotenceTypeId);
 objQxPrjPotenceEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.PotenceName, 200, conQxPrjPotence.PotenceName);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.QxPrjId, 4, conQxPrjPotence.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.FuncModuleId, 4, conQxPrjPotence.FuncModuleId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.PotenceTypeId, 6, conQxPrjPotence.PotenceTypeId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.MenuId, 8, conQxPrjPotence.MenuId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.MenuId4Win, 8, conQxPrjPotence.MenuId4Win);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.UpdDate, 20, conQxPrjPotence.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.UpdUserId, 20, conQxPrjPotence.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.Memo, 1000, conQxPrjPotence.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceEN.QxPrjId, 4, conQxPrjPotence.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceEN.PotenceTypeId, 6, conQxPrjPotence.PotenceTypeId);
 objQxPrjPotenceEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.PotenceId, 8, conQxPrjPotence.PotenceId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.PotenceName, 200, conQxPrjPotence.PotenceName);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.QxPrjId, 4, conQxPrjPotence.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.FuncModuleId, 4, conQxPrjPotence.FuncModuleId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.PotenceTypeId, 6, conQxPrjPotence.PotenceTypeId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.MenuId, 8, conQxPrjPotence.MenuId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.MenuId4Win, 8, conQxPrjPotence.MenuId4Win);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.UpdDate, 20, conQxPrjPotence.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.UpdUserId, 20, conQxPrjPotence.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceEN.Memo, 1000, conQxPrjPotence.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceEN.PotenceId, conQxPrjPotence.PotenceId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceEN.PotenceName, conQxPrjPotence.PotenceName);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceEN.QxPrjId, conQxPrjPotence.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceEN.FuncModuleId, conQxPrjPotence.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceEN.PotenceTypeId, conQxPrjPotence.PotenceTypeId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceEN.MenuId, conQxPrjPotence.MenuId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceEN.MenuId4Win, conQxPrjPotence.MenuId4Win);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceEN.UpdDate, conQxPrjPotence.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceEN.UpdUserId, conQxPrjPotence.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceEN.Memo, conQxPrjPotence.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceEN.QxPrjId, 4, conQxPrjPotence.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceEN.PotenceTypeId, 6, conQxPrjPotence.PotenceTypeId);
 objQxPrjPotenceEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPotenceId()
{
//获取某学院所有专业信息
string strSQL = "select PotenceId, PotenceName from QxPrjPotence ";
 clsSpecSQLforSql mySql = clsQxPrjPotenceDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxPrjPotence(工程权限),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PotenceTypeId = '{0}'", objQxPrjPotenceEN.PotenceTypeId);
 sbCondition.AppendFormat(" and PotenceName = '{0}'", objQxPrjPotenceEN.PotenceName);
return sbCondition.ToString();
}

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
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjPotenceEN._CurrTabName);
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
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjPotenceEN._CurrTabName, strCondition);
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
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjPotenceDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}