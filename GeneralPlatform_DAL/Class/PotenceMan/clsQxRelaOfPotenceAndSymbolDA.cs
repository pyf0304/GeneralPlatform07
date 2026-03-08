
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRelaOfPotenceAndSymbolDA
 表名:QxRelaOfPotenceAndSymbol(00140020)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:45:00
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
 /// 权限编程标志关系(QxRelaOfPotenceAndSymbol)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxRelaOfPotenceAndSymbolDA : clsCommBase4DA
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
 return clsQxRelaOfPotenceAndSymbolEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxRelaOfPotenceAndSymbolEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxRelaOfPotenceAndSymbolEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxRelaOfPotenceAndSymbolEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxRelaOfPotenceAndSymbolEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
 strSQL = "Select * from QxRelaOfPotenceAndSymbol where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxRelaOfPotenceAndSymbol");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxRelaOfPotenceAndSymbol_SelectByCond",values, "QxRelaOfPotenceAndSymbol");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRelaOfPotenceAndSymbol where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxRelaOfPotenceAndSymbol");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRelaOfPotenceAndSymbol a where {0} And a.RelaMid not in (Select Top {2} RelaMid From QxRelaOfPotenceAndSymbol Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRelaOfPotenceAndSymbol");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRelaOfPotenceAndSymbol a where {0} And a.RelaMid not in (Select Top {2} RelaMid From QxRelaOfPotenceAndSymbol Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRelaOfPotenceAndSymbol");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRelaOfPotenceAndSymbol a where {0} And a.RelaMid not in (Select Top {2} RelaMid From QxRelaOfPotenceAndSymbol Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRelaOfPotenceAndSymbol");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxRelaOfPotenceAndSymbol(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTable_QxRelaOfPotenceAndSymbol)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRelaOfPotenceAndSymbol where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRelaOfPotenceAndSymbol where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRelaOfPotenceAndSymbol where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRelaOfPotenceAndSymbol where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRelaOfPotenceAndSymbol.* from QxRelaOfPotenceAndSymbol Left Join {1} on {2} where {3} and QxRelaOfPotenceAndSymbol.RelaMid not in (Select top {5} QxRelaOfPotenceAndSymbol.RelaMid from QxRelaOfPotenceAndSymbol Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRelaOfPotenceAndSymbol where {1} and RelaMid not in (Select top {2} RelaMid from QxRelaOfPotenceAndSymbol where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRelaOfPotenceAndSymbol where {1} and RelaMid not in (Select top {3} RelaMid from QxRelaOfPotenceAndSymbol where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRelaOfPotenceAndSymbol.* from QxRelaOfPotenceAndSymbol Left Join {1} on {2} where {3} and QxRelaOfPotenceAndSymbol.RelaMid not in (Select top {5} QxRelaOfPotenceAndSymbol.RelaMid from QxRelaOfPotenceAndSymbol Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRelaOfPotenceAndSymbol where {1} and RelaMid not in (Select top {2} RelaMid from QxRelaOfPotenceAndSymbol where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRelaOfPotenceAndSymbol where {1} and RelaMid not in (Select top {3} RelaMid from QxRelaOfPotenceAndSymbol where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRelaOfPotenceAndSymbol.* from QxRelaOfPotenceAndSymbol Left Join {1} on {2} where {3} and QxRelaOfPotenceAndSymbol.RelaMid not in (Select top {5} QxRelaOfPotenceAndSymbol.RelaMid from QxRelaOfPotenceAndSymbol Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRelaOfPotenceAndSymbol where {1} and RelaMid not in (Select top {2} RelaMid from QxRelaOfPotenceAndSymbol where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRelaOfPotenceAndSymbol where {1} and RelaMid not in (Select top {3} RelaMid from QxRelaOfPotenceAndSymbol where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxRelaOfPotenceAndSymbol a where {0} And a.RelaMid not in (Select Top {2} RelaMid From QxRelaOfPotenceAndSymbol Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxRelaOfPotenceAndSymbol a where {0} And a.RelaMid not in (Select Top {2} RelaMid From QxRelaOfPotenceAndSymbol Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxRelaOfPotenceAndSymbol a where {0} And a.RelaMid not in (Select Top {2} RelaMid From QxRelaOfPotenceAndSymbol Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxRelaOfPotenceAndSymbol a where {0} And a.RelaMid not in (Select Top {2} RelaMid From QxRelaOfPotenceAndSymbol Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbolByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRelaOfPotenceAndSymbol_SelectByCond",values);
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
public List<clsQxRelaOfPotenceAndSymbolEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA:GetObjLst)", objException.Message));
}
List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsQxRelaOfPotenceAndSymbolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = new clsQxRelaOfPotenceAndSymbolEN();
try
{
objQxRelaOfPotenceAndSymbolEN.RelaMid = TransNullToInt(objRow[conQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[conQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[conQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objQxRelaOfPotenceAndSymbolEN.Memo = objRow[conQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[conQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[conQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[conQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetObjLst)", objException.Message));
}
objQxRelaOfPotenceAndSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRelaOfPotenceAndSymbolEN);
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
public List<clsQxRelaOfPotenceAndSymbolEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsQxRelaOfPotenceAndSymbolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = new clsQxRelaOfPotenceAndSymbolEN();
try
{
objQxRelaOfPotenceAndSymbolEN.RelaMid = TransNullToInt(objRow[conQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[conQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[conQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objQxRelaOfPotenceAndSymbolEN.Memo = objRow[conQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[conQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[conQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[conQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetObjLst)", objException.Message));
}
objQxRelaOfPotenceAndSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRelaOfPotenceAndSymbolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxRelaOfPotenceAndSymbolEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA:GetObjLstBySP)", objException.Message));
}
List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRelaOfPotenceAndSymbol_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = new clsQxRelaOfPotenceAndSymbolEN();
try
{
objQxRelaOfPotenceAndSymbolEN.RelaMid = TransNullToInt(objRow[conQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[conQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[conQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objQxRelaOfPotenceAndSymbolEN.Memo = objRow[conQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[conQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[conQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[conQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetObjLstBySP)", objException.Message));
}
objQxRelaOfPotenceAndSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRelaOfPotenceAndSymbolEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxRelaOfPotenceAndSymbol(ref clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where RelaMid = " + ""+ objQxRelaOfPotenceAndSymbolEN.RelaMid+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxRelaOfPotenceAndSymbolEN.RelaMid = TransNullToInt(objDT.Rows[0][conQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.PotenceId = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID(字段类型:char,字段长度:8,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.SymbolName = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称(字段类型:varchar,字段长度:200,是否可空:True)
 objQxRelaOfPotenceAndSymbolEN.Memo = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxRelaOfPotenceAndSymbolEN.QxPrjId = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.UpdDate = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.UpdUserId = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetQxRelaOfPotenceAndSymbol)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRelaMid">表关键字</param>
 /// <returns>表对象</returns>
public clsQxRelaOfPotenceAndSymbolEN GetObjByRelaMid(long lngRelaMid)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where RelaMid = " + ""+ lngRelaMid+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = new clsQxRelaOfPotenceAndSymbolEN();
try
{
 objQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[conQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[conQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID(字段类型:char,字段长度:8,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[conQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称(字段类型:varchar,字段长度:200,是否可空:True)
 objQxRelaOfPotenceAndSymbolEN.Memo = objRow[conQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[conQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[conQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[conQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetObjByRelaMid)", objException.Message));
}
return objQxRelaOfPotenceAndSymbolEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxRelaOfPotenceAndSymbol_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxRelaOfPotenceAndSymbolOneBySP(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxRelaOfPotenceAndSymbolEN.RelaMid
};
 objDT = objSQL.ExecSpReturnDT("QxRelaOfPotenceAndSymbol_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxRelaOfPotenceAndSymbolEN.RelaMid = TransNullToInt(objDT.Rows[0][conQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.PotenceId = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID(字段类型:char,字段长度:8,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.SymbolName = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称(字段类型:varchar,字段长度:200,是否可空:True)
 objQxRelaOfPotenceAndSymbolEN.Memo = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxRelaOfPotenceAndSymbolEN.QxPrjId = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.UpdDate = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRelaOfPotenceAndSymbolEN.UpdUserId = objDT.Rows[0][conQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxRelaOfPotenceAndSymbolEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = new clsQxRelaOfPotenceAndSymbolEN()
{
RelaMid = TransNullToInt(objRow[conQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()), //流水号
PotenceId = objRow[conQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(), //权限ID
SymbolForProgramme = objRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(), //编程标志
SymbolName = objRow[conQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(), //标志名称
Memo = objRow[conQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(), //备注
QxPrjId = objRow[conQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(), //项目Id
UpdDate = objRow[conQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim() //修改用户Id
};
objQxRelaOfPotenceAndSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRelaOfPotenceAndSymbolEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxRelaOfPotenceAndSymbolEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRelaOfPotenceAndSymbol_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = new clsQxRelaOfPotenceAndSymbolEN()
{
RelaMid = TransNullToInt(objRow[conQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()), //流水号
PotenceId = objRow[conQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(), //权限ID
SymbolForProgramme = objRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(), //编程标志
SymbolName = objRow[conQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(), //标志名称
Memo = objRow[conQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(), //备注
QxPrjId = objRow[conQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(), //项目Id
UpdDate = objRow[conQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim() //修改用户Id
};
objQxRelaOfPotenceAndSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRelaOfPotenceAndSymbolEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxRelaOfPotenceAndSymbolEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = new clsQxRelaOfPotenceAndSymbolEN();
try
{
objQxRelaOfPotenceAndSymbolEN.RelaMid = TransNullToInt(objRow[conQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[conQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[conQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objQxRelaOfPotenceAndSymbolEN.Memo = objRow[conQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[conQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[conQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[conQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetObjByDataRowQxRelaOfPotenceAndSymbol)", objException.Message));
}
objQxRelaOfPotenceAndSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRelaOfPotenceAndSymbolEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxRelaOfPotenceAndSymbolEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = new clsQxRelaOfPotenceAndSymbolEN();
try
{
objQxRelaOfPotenceAndSymbolEN.RelaMid = TransNullToInt(objRow[conQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[conQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[conQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objQxRelaOfPotenceAndSymbolEN.Memo = objRow[conQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[conQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[conQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[conQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[conQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: GetObjByDataRow)", objException.Message));
}
objQxRelaOfPotenceAndSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRelaOfPotenceAndSymbolEN;
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
objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxRelaOfPotenceAndSymbolEN._CurrTabName, conQxRelaOfPotenceAndSymbol.RelaMid, 8, "");
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
objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxRelaOfPotenceAndSymbolEN._CurrTabName, conQxRelaOfPotenceAndSymbol.RelaMid, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RelaMid from QxRelaOfPotenceAndSymbol where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RelaMid from QxRelaOfPotenceAndSymbol where " + strCondition;
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
 /// <param name = "lngRelaMid">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngRelaMid)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxRelaOfPotenceAndSymbol", "RelaMid = " + ""+ lngRelaMid+""))
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
 /// <param name = "lngRelaMid">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngRelaMid)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngRelaMid,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxRelaOfPotenceAndSymbol_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxRelaOfPotenceAndSymbol", strCondition))
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
objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxRelaOfPotenceAndSymbol");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
 {
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRelaOfPotenceAndSymbolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRelaOfPotenceAndSymbolEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxRelaOfPotenceAndSymbol");
objRow = objDS.Tables["QxRelaOfPotenceAndSymbol"].NewRow();
objRow[conQxRelaOfPotenceAndSymbol.PotenceId] = objQxRelaOfPotenceAndSymbolEN.PotenceId; //权限ID
objRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme] = objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme; //编程标志
 if (objQxRelaOfPotenceAndSymbolEN.SymbolName !=  "")
 {
objRow[conQxRelaOfPotenceAndSymbol.SymbolName] = objQxRelaOfPotenceAndSymbolEN.SymbolName; //标志名称
 }
 if (objQxRelaOfPotenceAndSymbolEN.Memo !=  "")
 {
objRow[conQxRelaOfPotenceAndSymbol.Memo] = objQxRelaOfPotenceAndSymbolEN.Memo; //备注
 }
objRow[conQxRelaOfPotenceAndSymbol.QxPrjId] = objQxRelaOfPotenceAndSymbolEN.QxPrjId; //项目Id
objRow[conQxRelaOfPotenceAndSymbol.UpdDate] = objQxRelaOfPotenceAndSymbolEN.UpdDate; //修改日期
objRow[conQxRelaOfPotenceAndSymbol.UpdUserId] = objQxRelaOfPotenceAndSymbolEN.UpdUserId; //修改用户Id
objDS.Tables[clsQxRelaOfPotenceAndSymbolEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxRelaOfPotenceAndSymbolEN._CurrTabName);
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
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRelaOfPotenceAndSymbolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRelaOfPotenceAndSymbolEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.PotenceId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.PotenceId);
 var strPotenceId = objQxRelaOfPotenceAndSymbolEN.PotenceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceId + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.SymbolForProgramme);
 var strSymbolForProgramme = objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolForProgramme + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.SymbolName);
 var strSymbolName = objQxRelaOfPotenceAndSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.Memo);
 var strMemo = objQxRelaOfPotenceAndSymbolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.QxPrjId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.QxPrjId);
 var strQxPrjId = objQxRelaOfPotenceAndSymbolEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.UpdDate);
 var strUpdDate = objQxRelaOfPotenceAndSymbolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.UpdUserId);
 var strUpdUserId = objQxRelaOfPotenceAndSymbolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRelaOfPotenceAndSymbol");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRelaOfPotenceAndSymbolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRelaOfPotenceAndSymbolEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.PotenceId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.PotenceId);
 var strPotenceId = objQxRelaOfPotenceAndSymbolEN.PotenceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceId + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.SymbolForProgramme);
 var strSymbolForProgramme = objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolForProgramme + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.SymbolName);
 var strSymbolName = objQxRelaOfPotenceAndSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.Memo);
 var strMemo = objQxRelaOfPotenceAndSymbolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.QxPrjId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.QxPrjId);
 var strQxPrjId = objQxRelaOfPotenceAndSymbolEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.UpdDate);
 var strUpdDate = objQxRelaOfPotenceAndSymbolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.UpdUserId);
 var strUpdUserId = objQxRelaOfPotenceAndSymbolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRelaOfPotenceAndSymbol");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRelaOfPotenceAndSymbolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRelaOfPotenceAndSymbolEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.PotenceId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.PotenceId);
 var strPotenceId = objQxRelaOfPotenceAndSymbolEN.PotenceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceId + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.SymbolForProgramme);
 var strSymbolForProgramme = objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolForProgramme + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.SymbolName);
 var strSymbolName = objQxRelaOfPotenceAndSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.Memo);
 var strMemo = objQxRelaOfPotenceAndSymbolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.QxPrjId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.QxPrjId);
 var strQxPrjId = objQxRelaOfPotenceAndSymbolEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.UpdDate);
 var strUpdDate = objQxRelaOfPotenceAndSymbolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.UpdUserId);
 var strUpdUserId = objQxRelaOfPotenceAndSymbolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRelaOfPotenceAndSymbol");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRelaOfPotenceAndSymbolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRelaOfPotenceAndSymbolEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.PotenceId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.PotenceId);
 var strPotenceId = objQxRelaOfPotenceAndSymbolEN.PotenceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceId + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.SymbolForProgramme);
 var strSymbolForProgramme = objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolForProgramme + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.SymbolName);
 var strSymbolName = objQxRelaOfPotenceAndSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.Memo);
 var strMemo = objQxRelaOfPotenceAndSymbolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.QxPrjId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.QxPrjId);
 var strQxPrjId = objQxRelaOfPotenceAndSymbolEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.UpdDate);
 var strUpdDate = objQxRelaOfPotenceAndSymbolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxRelaOfPotenceAndSymbol.UpdUserId);
 var strUpdUserId = objQxRelaOfPotenceAndSymbolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRelaOfPotenceAndSymbol");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxRelaOfPotenceAndSymbolBySP(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
//通过存储过程来
//直接使用
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxRelaOfPotenceAndSymbolEN.PotenceId,
 objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme,
 objQxRelaOfPotenceAndSymbolEN.SymbolName,
 objQxRelaOfPotenceAndSymbolEN.Memo,
 objQxRelaOfPotenceAndSymbolEN.QxPrjId,
 objQxRelaOfPotenceAndSymbolEN.UpdDate,
objQxRelaOfPotenceAndSymbolEN.UpdUserId
};
 objSQL.ExecSP("QxRelaOfPotenceAndSymbol_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxRelaOfPotenceAndSymbols(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where RelaMid = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxRelaOfPotenceAndSymbol");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxRelaOfPotenceAndSymbolEN._CurrTabName ].NewRow();
objRow[conQxRelaOfPotenceAndSymbol.PotenceId] = oRow[conQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme] = oRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objRow[conQxRelaOfPotenceAndSymbol.SymbolName] = oRow[conQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objRow[conQxRelaOfPotenceAndSymbol.Memo] = oRow[conQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objRow[conQxRelaOfPotenceAndSymbol.QxPrjId] = oRow[conQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxRelaOfPotenceAndSymbol.UpdDate] = oRow[conQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objRow[conQxRelaOfPotenceAndSymbol.UpdUserId] = oRow[conQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
 objDS.Tables[clsQxRelaOfPotenceAndSymbolEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxRelaOfPotenceAndSymbolEN._CurrTabName);
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
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRelaOfPotenceAndSymbolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRelaOfPotenceAndSymbolEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
strSQL = "Select * from QxRelaOfPotenceAndSymbol where RelaMid = " + ""+ objQxRelaOfPotenceAndSymbolEN.RelaMid+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxRelaOfPotenceAndSymbolEN._CurrTabName);
if (objDS.Tables[clsQxRelaOfPotenceAndSymbolEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:RelaMid = " + ""+ objQxRelaOfPotenceAndSymbolEN.RelaMid+"");
return false;
}
objRow = objDS.Tables[clsQxRelaOfPotenceAndSymbolEN._CurrTabName].Rows[0];
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.PotenceId))
 {
objRow[conQxRelaOfPotenceAndSymbol.PotenceId] = objQxRelaOfPotenceAndSymbolEN.PotenceId; //权限ID
 }
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolForProgramme))
 {
objRow[conQxRelaOfPotenceAndSymbol.SymbolForProgramme] = objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme; //编程标志
 }
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolName))
 {
objRow[conQxRelaOfPotenceAndSymbol.SymbolName] = objQxRelaOfPotenceAndSymbolEN.SymbolName; //标志名称
 }
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.Memo))
 {
objRow[conQxRelaOfPotenceAndSymbol.Memo] = objQxRelaOfPotenceAndSymbolEN.Memo; //备注
 }
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.QxPrjId))
 {
objRow[conQxRelaOfPotenceAndSymbol.QxPrjId] = objQxRelaOfPotenceAndSymbolEN.QxPrjId; //项目Id
 }
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdDate))
 {
objRow[conQxRelaOfPotenceAndSymbol.UpdDate] = objQxRelaOfPotenceAndSymbolEN.UpdDate; //修改日期
 }
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdUserId))
 {
objRow[conQxRelaOfPotenceAndSymbol.UpdUserId] = objQxRelaOfPotenceAndSymbolEN.UpdUserId; //修改用户Id
 }
try
{
objDA.Update(objDS, clsQxRelaOfPotenceAndSymbolEN._CurrTabName);
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
public bool UpdateBySP(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRelaOfPotenceAndSymbolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRelaOfPotenceAndSymbolEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxRelaOfPotenceAndSymbolEN.RelaMid,
 objQxRelaOfPotenceAndSymbolEN.PotenceId,
 objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme,
 objQxRelaOfPotenceAndSymbolEN.SymbolName,
 objQxRelaOfPotenceAndSymbolEN.Memo,
 objQxRelaOfPotenceAndSymbolEN.QxPrjId,
 objQxRelaOfPotenceAndSymbolEN.UpdDate,
 objQxRelaOfPotenceAndSymbolEN.UpdUserId
};
 objSQL.ExecSP("QxRelaOfPotenceAndSymbol_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRelaOfPotenceAndSymbolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRelaOfPotenceAndSymbolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxRelaOfPotenceAndSymbol Set ");
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.PotenceId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.PotenceId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId !=  null)
 {
 var strPotenceId = objQxRelaOfPotenceAndSymbolEN.PotenceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceId, conQxRelaOfPotenceAndSymbol.PotenceId); //权限ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.PotenceId); //权限ID
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolForProgramme))
 {
 if (objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme !=  null)
 {
 var strSymbolForProgramme = objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolForProgramme, conQxRelaOfPotenceAndSymbol.SymbolForProgramme); //编程标志
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.SymbolForProgramme); //编程标志
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolName))
 {
 if (objQxRelaOfPotenceAndSymbolEN.SymbolName !=  null)
 {
 var strSymbolName = objQxRelaOfPotenceAndSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolName, conQxRelaOfPotenceAndSymbol.SymbolName); //标志名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.SymbolName); //标志名称
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.Memo))
 {
 if (objQxRelaOfPotenceAndSymbolEN.Memo !=  null)
 {
 var strMemo = objQxRelaOfPotenceAndSymbolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxRelaOfPotenceAndSymbol.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.Memo); //备注
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.QxPrjId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.QxPrjId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRelaOfPotenceAndSymbolEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxRelaOfPotenceAndSymbol.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.QxPrjId); //项目Id
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdDate))
 {
 if (objQxRelaOfPotenceAndSymbolEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRelaOfPotenceAndSymbolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxRelaOfPotenceAndSymbol.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.UpdDate); //修改日期
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdUserId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRelaOfPotenceAndSymbolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxRelaOfPotenceAndSymbol.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.UpdUserId); //修改用户Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RelaMid = {0}", objQxRelaOfPotenceAndSymbolEN.RelaMid); 
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
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strCondition)
{
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRelaOfPotenceAndSymbolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRelaOfPotenceAndSymbolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRelaOfPotenceAndSymbol Set ");
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.PotenceId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.PotenceId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId !=  null)
 {
 var strPotenceId = objQxRelaOfPotenceAndSymbolEN.PotenceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceId = '{0}',", strPotenceId); //权限ID
 }
 else
 {
 sbSQL.Append(" PotenceId = null,"); //权限ID
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolForProgramme))
 {
 if (objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme !=  null)
 {
 var strSymbolForProgramme = objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolForProgramme = '{0}',", strSymbolForProgramme); //编程标志
 }
 else
 {
 sbSQL.Append(" SymbolForProgramme = null,"); //编程标志
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolName))
 {
 if (objQxRelaOfPotenceAndSymbolEN.SymbolName !=  null)
 {
 var strSymbolName = objQxRelaOfPotenceAndSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolName = '{0}',", strSymbolName); //标志名称
 }
 else
 {
 sbSQL.Append(" SymbolName = null,"); //标志名称
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.Memo))
 {
 if (objQxRelaOfPotenceAndSymbolEN.Memo !=  null)
 {
 var strMemo = objQxRelaOfPotenceAndSymbolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.QxPrjId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.QxPrjId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRelaOfPotenceAndSymbolEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdDate))
 {
 if (objQxRelaOfPotenceAndSymbolEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRelaOfPotenceAndSymbolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdUserId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRelaOfPotenceAndSymbolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
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
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRelaOfPotenceAndSymbolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRelaOfPotenceAndSymbolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRelaOfPotenceAndSymbol Set ");
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.PotenceId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.PotenceId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId !=  null)
 {
 var strPotenceId = objQxRelaOfPotenceAndSymbolEN.PotenceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceId = '{0}',", strPotenceId); //权限ID
 }
 else
 {
 sbSQL.Append(" PotenceId = null,"); //权限ID
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolForProgramme))
 {
 if (objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme !=  null)
 {
 var strSymbolForProgramme = objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolForProgramme = '{0}',", strSymbolForProgramme); //编程标志
 }
 else
 {
 sbSQL.Append(" SymbolForProgramme = null,"); //编程标志
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolName))
 {
 if (objQxRelaOfPotenceAndSymbolEN.SymbolName !=  null)
 {
 var strSymbolName = objQxRelaOfPotenceAndSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolName = '{0}',", strSymbolName); //标志名称
 }
 else
 {
 sbSQL.Append(" SymbolName = null,"); //标志名称
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.Memo))
 {
 if (objQxRelaOfPotenceAndSymbolEN.Memo !=  null)
 {
 var strMemo = objQxRelaOfPotenceAndSymbolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.QxPrjId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.QxPrjId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRelaOfPotenceAndSymbolEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdDate))
 {
 if (objQxRelaOfPotenceAndSymbolEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRelaOfPotenceAndSymbolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdUserId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRelaOfPotenceAndSymbolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
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
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxRelaOfPotenceAndSymbolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRelaOfPotenceAndSymbolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRelaOfPotenceAndSymbolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRelaOfPotenceAndSymbol Set ");
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.PotenceId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.PotenceId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.PotenceId !=  null)
 {
 var strPotenceId = objQxRelaOfPotenceAndSymbolEN.PotenceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceId, conQxRelaOfPotenceAndSymbol.PotenceId); //权限ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.PotenceId); //权限ID
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolForProgramme))
 {
 if (objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme !=  null)
 {
 var strSymbolForProgramme = objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolForProgramme, conQxRelaOfPotenceAndSymbol.SymbolForProgramme); //编程标志
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.SymbolForProgramme); //编程标志
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolName))
 {
 if (objQxRelaOfPotenceAndSymbolEN.SymbolName !=  null)
 {
 var strSymbolName = objQxRelaOfPotenceAndSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolName, conQxRelaOfPotenceAndSymbol.SymbolName); //标志名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.SymbolName); //标志名称
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.Memo))
 {
 if (objQxRelaOfPotenceAndSymbolEN.Memo !=  null)
 {
 var strMemo = objQxRelaOfPotenceAndSymbolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxRelaOfPotenceAndSymbol.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.Memo); //备注
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.QxPrjId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId  ==  "")
 {
 objQxRelaOfPotenceAndSymbolEN.QxPrjId = null;
 }
 if (objQxRelaOfPotenceAndSymbolEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRelaOfPotenceAndSymbolEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxRelaOfPotenceAndSymbol.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.QxPrjId); //项目Id
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdDate))
 {
 if (objQxRelaOfPotenceAndSymbolEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRelaOfPotenceAndSymbolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxRelaOfPotenceAndSymbol.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.UpdDate); //修改日期
 }
 }
 
 if (objQxRelaOfPotenceAndSymbolEN.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdUserId))
 {
 if (objQxRelaOfPotenceAndSymbolEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRelaOfPotenceAndSymbolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxRelaOfPotenceAndSymbol.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRelaOfPotenceAndSymbol.UpdUserId); //修改用户Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RelaMid = {0}", objQxRelaOfPotenceAndSymbolEN.RelaMid); 
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
 /// <param name = "lngRelaMid">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngRelaMid) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngRelaMid,
};
 objSQL.ExecSP("QxRelaOfPotenceAndSymbol_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngRelaMid">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngRelaMid, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
//删除QxRelaOfPotenceAndSymbol本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRelaOfPotenceAndSymbol where RelaMid = " + ""+ lngRelaMid+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxRelaOfPotenceAndSymbol(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除QxRelaOfPotenceAndSymbol本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRelaOfPotenceAndSymbol where RelaMid in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngRelaMid">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngRelaMid) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
//删除QxRelaOfPotenceAndSymbol本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRelaOfPotenceAndSymbol where RelaMid = " + ""+ lngRelaMid+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxRelaOfPotenceAndSymbol(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: DelQxRelaOfPotenceAndSymbol)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxRelaOfPotenceAndSymbol where " + strCondition ;
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
public bool DelQxRelaOfPotenceAndSymbolWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxRelaOfPotenceAndSymbolDA: DelQxRelaOfPotenceAndSymbolWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxRelaOfPotenceAndSymbol where " + strCondition ;
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
 /// <param name = "objQxRelaOfPotenceAndSymbolENS">源对象</param>
 /// <param name = "objQxRelaOfPotenceAndSymbolENT">目标对象</param>
public void CopyTo(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolENS, clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolENT)
{
objQxRelaOfPotenceAndSymbolENT.RelaMid = objQxRelaOfPotenceAndSymbolENS.RelaMid; //流水号
objQxRelaOfPotenceAndSymbolENT.PotenceId = objQxRelaOfPotenceAndSymbolENS.PotenceId; //权限ID
objQxRelaOfPotenceAndSymbolENT.SymbolForProgramme = objQxRelaOfPotenceAndSymbolENS.SymbolForProgramme; //编程标志
objQxRelaOfPotenceAndSymbolENT.SymbolName = objQxRelaOfPotenceAndSymbolENS.SymbolName; //标志名称
objQxRelaOfPotenceAndSymbolENT.Memo = objQxRelaOfPotenceAndSymbolENS.Memo; //备注
objQxRelaOfPotenceAndSymbolENT.QxPrjId = objQxRelaOfPotenceAndSymbolENS.QxPrjId; //项目Id
objQxRelaOfPotenceAndSymbolENT.UpdDate = objQxRelaOfPotenceAndSymbolENS.UpdDate; //修改日期
objQxRelaOfPotenceAndSymbolENT.UpdUserId = objQxRelaOfPotenceAndSymbolENS.UpdUserId; //修改用户Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxRelaOfPotenceAndSymbolEN.PotenceId, conQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckFieldNotNull(objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme, conQxRelaOfPotenceAndSymbol.SymbolForProgramme);
clsCheckSql.CheckFieldNotNull(objQxRelaOfPotenceAndSymbolEN.QxPrjId, conQxRelaOfPotenceAndSymbol.QxPrjId);
clsCheckSql.CheckFieldNotNull(objQxRelaOfPotenceAndSymbolEN.UpdDate, conQxRelaOfPotenceAndSymbol.UpdDate);
clsCheckSql.CheckFieldNotNull(objQxRelaOfPotenceAndSymbolEN.UpdUserId, conQxRelaOfPotenceAndSymbol.UpdUserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.PotenceId, 8, conQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme, 20, conQxRelaOfPotenceAndSymbol.SymbolForProgramme);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.SymbolName, 200, conQxRelaOfPotenceAndSymbol.SymbolName);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.Memo, 1000, conQxRelaOfPotenceAndSymbol.Memo);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.QxPrjId, 4, conQxRelaOfPotenceAndSymbol.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.UpdDate, 20, conQxRelaOfPotenceAndSymbol.UpdDate);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.UpdUserId, 20, conQxRelaOfPotenceAndSymbol.UpdUserId);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxRelaOfPotenceAndSymbolEN.PotenceId, 8, conQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckFieldForeignKey(objQxRelaOfPotenceAndSymbolEN.QxPrjId, 4, conQxRelaOfPotenceAndSymbol.QxPrjId);
 objQxRelaOfPotenceAndSymbolEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.PotenceId, 8, conQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme, 20, conQxRelaOfPotenceAndSymbol.SymbolForProgramme);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.SymbolName, 200, conQxRelaOfPotenceAndSymbol.SymbolName);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.Memo, 1000, conQxRelaOfPotenceAndSymbol.Memo);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.QxPrjId, 4, conQxRelaOfPotenceAndSymbol.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.UpdDate, 20, conQxRelaOfPotenceAndSymbol.UpdDate);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.UpdUserId, 20, conQxRelaOfPotenceAndSymbol.UpdUserId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxRelaOfPotenceAndSymbolEN.PotenceId, 8, conQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckFieldForeignKey(objQxRelaOfPotenceAndSymbolEN.QxPrjId, 4, conQxRelaOfPotenceAndSymbol.QxPrjId);
 objQxRelaOfPotenceAndSymbolEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.PotenceId, 8, conQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme, 20, conQxRelaOfPotenceAndSymbol.SymbolForProgramme);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.SymbolName, 200, conQxRelaOfPotenceAndSymbol.SymbolName);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.Memo, 1000, conQxRelaOfPotenceAndSymbol.Memo);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.QxPrjId, 4, conQxRelaOfPotenceAndSymbol.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.UpdDate, 20, conQxRelaOfPotenceAndSymbol.UpdDate);
clsCheckSql.CheckFieldLen(objQxRelaOfPotenceAndSymbolEN.UpdUserId, 20, conQxRelaOfPotenceAndSymbol.UpdUserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxRelaOfPotenceAndSymbolEN.PotenceId, conQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckSqlInjection4Field(objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme, conQxRelaOfPotenceAndSymbol.SymbolForProgramme);
clsCheckSql.CheckSqlInjection4Field(objQxRelaOfPotenceAndSymbolEN.SymbolName, conQxRelaOfPotenceAndSymbol.SymbolName);
clsCheckSql.CheckSqlInjection4Field(objQxRelaOfPotenceAndSymbolEN.Memo, conQxRelaOfPotenceAndSymbol.Memo);
clsCheckSql.CheckSqlInjection4Field(objQxRelaOfPotenceAndSymbolEN.QxPrjId, conQxRelaOfPotenceAndSymbol.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxRelaOfPotenceAndSymbolEN.UpdDate, conQxRelaOfPotenceAndSymbol.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxRelaOfPotenceAndSymbolEN.UpdUserId, conQxRelaOfPotenceAndSymbol.UpdUserId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxRelaOfPotenceAndSymbolEN.PotenceId, 8, conQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckFieldForeignKey(objQxRelaOfPotenceAndSymbolEN.QxPrjId, 4, conQxRelaOfPotenceAndSymbol.QxPrjId);
 objQxRelaOfPotenceAndSymbolEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxRelaOfPotenceAndSymbol(权限编程标志关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PotenceId = '{0}'", objQxRelaOfPotenceAndSymbolEN.PotenceId);
 sbCondition.AppendFormat(" and SymbolForProgramme = '{0}'", objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme);
 if (objQxRelaOfPotenceAndSymbolEN.SymbolName == null)
{
 sbCondition.AppendFormat(" and SymbolName is null");
}
else
{
 sbCondition.AppendFormat(" and SymbolName = '{0}'", objQxRelaOfPotenceAndSymbolEN.SymbolName);
}
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
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
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
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
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
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxRelaOfPotenceAndSymbolEN._CurrTabName);
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
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxRelaOfPotenceAndSymbolEN._CurrTabName, strCondition);
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
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
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
 objSQL = clsQxRelaOfPotenceAndSymbolDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}