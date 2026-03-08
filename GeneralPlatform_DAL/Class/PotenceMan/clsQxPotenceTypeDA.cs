
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPotenceTypeDA
 表名:QxPotenceType(00140003)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:15:05
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
 /// 权限类型(QxPotenceType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxPotenceTypeDA : clsCommBase4DA
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
 return clsQxPotenceTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxPotenceTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPotenceTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxPotenceTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxPotenceTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPotenceTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPotenceTypeId)
{
strPotenceTypeId = strPotenceTypeId.Replace("'", "''");
if (strPotenceTypeId.Length > 6)
{
throw new Exception("(errid:Data000001)在表:QxPotenceType中,检查关键字,长度不正确!(clsQxPotenceTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPotenceTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxPotenceType中,关键字不能为空 或 null!(clsQxPotenceTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPotenceTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxPotenceTypeDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strPotenceTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strPotenceTypeId)
{
strPotenceTypeId = strPotenceTypeId.Replace("'", "''");
if (strPotenceTypeId.Length > 6 + 4)
{
throw new Exception("(errid:Data000004)在表:QxPotenceType中,检查关键字,长度不正确!(简化版)(clsQxPotenceTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPotenceTypeId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxPotenceType中,关键字不能为空 或 null!(clsQxPotenceTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPotenceTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxPotenceTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
 strSQL = "Select * from QxPotenceType where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxPotenceType");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxPotenceType_SelectByCond",values, "QxPotenceType");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPotenceType where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxPotenceType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPotenceType a where {0} And a.PotenceTypeId not in (Select Top {2} PotenceTypeId From QxPotenceType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPotenceType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPotenceType a where {0} And a.PotenceTypeId not in (Select Top {2} PotenceTypeId From QxPotenceType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPotenceType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPotenceType a where {0} And a.PotenceTypeId not in (Select Top {2} PotenceTypeId From QxPotenceType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPotenceType");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxPotenceType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTable_QxPotenceType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPotenceType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPotenceType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPotenceType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPotenceType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPotenceType.* from QxPotenceType Left Join {1} on {2} where {3} and QxPotenceType.PotenceTypeId not in (Select top {5} QxPotenceType.PotenceTypeId from QxPotenceType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPotenceType where {1} and PotenceTypeId not in (Select top {2} PotenceTypeId from QxPotenceType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPotenceType where {1} and PotenceTypeId not in (Select top {3} PotenceTypeId from QxPotenceType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPotenceType.* from QxPotenceType Left Join {1} on {2} where {3} and QxPotenceType.PotenceTypeId not in (Select top {5} QxPotenceType.PotenceTypeId from QxPotenceType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPotenceType where {1} and PotenceTypeId not in (Select top {2} PotenceTypeId from QxPotenceType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPotenceType where {1} and PotenceTypeId not in (Select top {3} PotenceTypeId from QxPotenceType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPotenceType.* from QxPotenceType Left Join {1} on {2} where {3} and QxPotenceType.PotenceTypeId not in (Select top {5} QxPotenceType.PotenceTypeId from QxPotenceType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPotenceType where {1} and PotenceTypeId not in (Select top {2} PotenceTypeId from QxPotenceType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPotenceType where {1} and PotenceTypeId not in (Select top {3} PotenceTypeId from QxPotenceType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPotenceType a where {0} And a.PotenceTypeId not in (Select Top {2} PotenceTypeId From QxPotenceType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPotenceType a where {0} And a.PotenceTypeId not in (Select Top {2} PotenceTypeId From QxPotenceType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPotenceType a where {0} And a.PotenceTypeId not in (Select Top {2} PotenceTypeId From QxPotenceType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPotenceType a where {0} And a.PotenceTypeId not in (Select Top {2} PotenceTypeId From QxPotenceType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPotenceTypeDA: GetQxPotenceTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPotenceType_SelectByCond",values);
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
public List<clsQxPotenceTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA:GetObjLst)", objException.Message));
}
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = TransNullToBool(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPotenceTypeDA: GetObjLst)", objException.Message));
}
objQxPotenceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPotenceTypeEN);
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
public List<clsQxPotenceTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = TransNullToBool(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPotenceTypeDA: GetObjLst)", objException.Message));
}
objQxPotenceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPotenceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxPotenceTypeEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA:GetObjLstBySP)", objException.Message));
}
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPotenceType_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = TransNullToBool(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxPotenceTypeDA: GetObjLstBySP)", objException.Message));
}
objQxPotenceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPotenceTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPotenceType(ref clsQxPotenceTypeEN objQxPotenceTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where PotenceTypeId = " + "'"+ objQxPotenceTypeEN.PotenceTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxPotenceTypeEN.PotenceTypeId = objDT.Rows[0][conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPotenceTypeEN.PotenceTypeName = objDT.Rows[0][conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPotenceTypeEN.QxPrjId = objDT.Rows[0][conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPotenceTypeEN.FuncModuleId = objDT.Rows[0][conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPotenceTypeEN.MenuId = objDT.Rows[0][conQxPotenceType.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPotenceTypeEN.ViewId = objDT.Rows[0][conQxPotenceType.ViewId].ToString().Trim(); //界面编号(字段类型:char,字段长度:8,是否可空:True)
 objQxPotenceTypeEN.IsVisible = TransNullToBool(objDT.Rows[0][conQxPotenceType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objQxPotenceTypeEN.UpdDate = objDT.Rows[0][conQxPotenceType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPotenceTypeEN.UpdUserId = objDT.Rows[0][conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPotenceTypeEN.Memo = objDT.Rows[0][conQxPotenceType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxPotenceTypeDA: GetQxPotenceType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPotenceTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxPotenceTypeEN GetObjByPotenceTypeId(string strPotenceTypeId)
{
CheckPrimaryKey(strPotenceTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where PotenceTypeId = " + "'"+ strPotenceTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
 objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号(字段类型:char,字段长度:8,是否可空:True)
 objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxPotenceTypeDA: GetObjByPotenceTypeId)", objException.Message));
}
return objQxPotenceTypeEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxPotenceType_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPotenceTypeOneBySP(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxPotenceTypeEN.PotenceTypeId
};
 objDT = objSQL.ExecSpReturnDT("QxPotenceType_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxPotenceTypeEN.PotenceTypeId = objDT.Rows[0][conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPotenceTypeEN.PotenceTypeName = objDT.Rows[0][conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPotenceTypeEN.QxPrjId = objDT.Rows[0][conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPotenceTypeEN.FuncModuleId = objDT.Rows[0][conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPotenceTypeEN.MenuId = objDT.Rows[0][conQxPotenceType.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPotenceTypeEN.ViewId = objDT.Rows[0][conQxPotenceType.ViewId].ToString().Trim(); //界面编号(字段类型:char,字段长度:8,是否可空:True)
 objQxPotenceTypeEN.IsVisible = TransNullToBool(objDT.Rows[0][conQxPotenceType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objQxPotenceTypeEN.UpdDate = objDT.Rows[0][conQxPotenceType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPotenceTypeEN.UpdUserId = objDT.Rows[0][conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPotenceTypeEN.Memo = objDT.Rows[0][conQxPotenceType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPotenceTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN()
{
PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(), //权限类型Id
PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(), //权限类型名
QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(), //项目Id
FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(), //模块Id
MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(), //菜单Id
ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(), //界面编号
IsVisible = TransNullToBool(objRow[conQxPotenceType.IsVisible].ToString().Trim()), //是否显示
UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim() //备注
};
objQxPotenceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPotenceTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxPotenceTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPotenceTypeEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPotenceType_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN()
{
PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(), //权限类型Id
PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(), //权限类型名
QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(), //项目Id
FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(), //模块Id
MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(), //菜单Id
ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(), //界面编号
IsVisible = TransNullToBool(objRow[conQxPotenceType.IsVisible].ToString().Trim()), //是否显示
UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim() //备注
};
objQxPotenceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPotenceTypeEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxPotenceTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = TransNullToBool(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxPotenceTypeDA: GetObjByDataRowQxPotenceType)", objException.Message));
}
objQxPotenceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPotenceTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxPotenceTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = TransNullToBool(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxPotenceTypeDA: GetObjByDataRow)", objException.Message));
}
objQxPotenceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPotenceTypeEN;
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
objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPotenceTypeEN._CurrTabName, conQxPotenceType.PotenceTypeId, 6, "");
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
objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPotenceTypeEN._CurrTabName, conQxPotenceType.PotenceTypeId, 6, strPrefix);
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
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PotenceTypeId from QxPotenceType where " + strCondition;
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
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PotenceTypeId from QxPotenceType where " + strCondition;
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
 /// <param name = "strPotenceTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPotenceTypeId)
{
CheckPrimaryKey(strPotenceTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPotenceType", "PotenceTypeId = " + "'"+ strPotenceTypeId+"'"))
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
 /// <param name = "strPotenceTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strPotenceTypeId)
{
CheckPrimaryKey(strPotenceTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strPotenceTypeId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxPotenceType_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPotenceType", strCondition))
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
objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxPotenceType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxPotenceTypeEN objQxPotenceTypeEN)
 {
 objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPotenceTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPotenceTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPotenceType");
objRow = objDS.Tables["QxPotenceType"].NewRow();
objRow[conQxPotenceType.PotenceTypeId] = objQxPotenceTypeEN.PotenceTypeId; //权限类型Id
objRow[conQxPotenceType.PotenceTypeName] = objQxPotenceTypeEN.PotenceTypeName; //权限类型名
objRow[conQxPotenceType.QxPrjId] = objQxPotenceTypeEN.QxPrjId; //项目Id
 if (objQxPotenceTypeEN.FuncModuleId !=  "")
 {
objRow[conQxPotenceType.FuncModuleId] = objQxPotenceTypeEN.FuncModuleId; //模块Id
 }
 if (objQxPotenceTypeEN.MenuId !=  "")
 {
objRow[conQxPotenceType.MenuId] = objQxPotenceTypeEN.MenuId; //菜单Id
 }
 if (objQxPotenceTypeEN.ViewId !=  "")
 {
objRow[conQxPotenceType.ViewId] = objQxPotenceTypeEN.ViewId; //界面编号
 }
objRow[conQxPotenceType.IsVisible] = objQxPotenceTypeEN.IsVisible; //是否显示
objRow[conQxPotenceType.UpdDate] = objQxPotenceTypeEN.UpdDate; //修改日期
objRow[conQxPotenceType.UpdUserId] = objQxPotenceTypeEN.UpdUserId; //修改用户Id
 if (objQxPotenceTypeEN.Memo !=  "")
 {
objRow[conQxPotenceType.Memo] = objQxPotenceTypeEN.Memo; //备注
 }
objDS.Tables[clsQxPotenceTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxPotenceTypeEN._CurrTabName);
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
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPotenceTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPotenceTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPotenceTypeEN.PotenceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.PotenceTypeId);
 var strPotenceTypeId = objQxPotenceTypeEN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeId + "'");
 }
 
 if (objQxPotenceTypeEN.PotenceTypeName !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.PotenceTypeName);
 var strPotenceTypeName = objQxPotenceTypeEN.PotenceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeName + "'");
 }
 
 if (objQxPotenceTypeEN.QxPrjId  ==  "")
 {
 objQxPotenceTypeEN.QxPrjId = null;
 }
 if (objQxPotenceTypeEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.QxPrjId);
 var strQxPrjId = objQxPotenceTypeEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPotenceTypeEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.FuncModuleId);
 var strFuncModuleId = objQxPotenceTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxPotenceTypeEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.MenuId);
 var strMenuId = objQxPotenceTypeEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPotenceTypeEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.ViewId);
 var strViewId = objQxPotenceTypeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPotenceType.IsVisible);
 arrValueListForInsert.Add("'" + (objQxPotenceTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objQxPotenceTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.UpdDate);
 var strUpdDate = objQxPotenceTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPotenceTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.UpdUserId);
 var strUpdUserId = objQxPotenceTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPotenceTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.Memo);
 var strMemo = objQxPotenceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPotenceType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPotenceTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPotenceTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPotenceTypeEN.PotenceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.PotenceTypeId);
 var strPotenceTypeId = objQxPotenceTypeEN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeId + "'");
 }
 
 if (objQxPotenceTypeEN.PotenceTypeName !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.PotenceTypeName);
 var strPotenceTypeName = objQxPotenceTypeEN.PotenceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeName + "'");
 }
 
 if (objQxPotenceTypeEN.QxPrjId  ==  "")
 {
 objQxPotenceTypeEN.QxPrjId = null;
 }
 if (objQxPotenceTypeEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.QxPrjId);
 var strQxPrjId = objQxPotenceTypeEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPotenceTypeEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.FuncModuleId);
 var strFuncModuleId = objQxPotenceTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxPotenceTypeEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.MenuId);
 var strMenuId = objQxPotenceTypeEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPotenceTypeEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.ViewId);
 var strViewId = objQxPotenceTypeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPotenceType.IsVisible);
 arrValueListForInsert.Add("'" + (objQxPotenceTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objQxPotenceTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.UpdDate);
 var strUpdDate = objQxPotenceTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPotenceTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.UpdUserId);
 var strUpdUserId = objQxPotenceTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPotenceTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.Memo);
 var strMemo = objQxPotenceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPotenceType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxPotenceTypeEN.PotenceTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPotenceTypeEN objQxPotenceTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPotenceTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPotenceTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPotenceTypeEN.PotenceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.PotenceTypeId);
 var strPotenceTypeId = objQxPotenceTypeEN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeId + "'");
 }
 
 if (objQxPotenceTypeEN.PotenceTypeName !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.PotenceTypeName);
 var strPotenceTypeName = objQxPotenceTypeEN.PotenceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeName + "'");
 }
 
 if (objQxPotenceTypeEN.QxPrjId  ==  "")
 {
 objQxPotenceTypeEN.QxPrjId = null;
 }
 if (objQxPotenceTypeEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.QxPrjId);
 var strQxPrjId = objQxPotenceTypeEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPotenceTypeEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.FuncModuleId);
 var strFuncModuleId = objQxPotenceTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxPotenceTypeEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.MenuId);
 var strMenuId = objQxPotenceTypeEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPotenceTypeEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.ViewId);
 var strViewId = objQxPotenceTypeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPotenceType.IsVisible);
 arrValueListForInsert.Add("'" + (objQxPotenceTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objQxPotenceTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.UpdDate);
 var strUpdDate = objQxPotenceTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPotenceTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.UpdUserId);
 var strUpdUserId = objQxPotenceTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPotenceTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPotenceType.Memo);
 var strMemo = objQxPotenceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPotenceType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxPotenceTypeBySP(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
//通过存储过程来
//直接使用
 objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPotenceTypeEN.PotenceTypeId,
 objQxPotenceTypeEN.PotenceTypeName,
 objQxPotenceTypeEN.QxPrjId,
 objQxPotenceTypeEN.FuncModuleId,
 objQxPotenceTypeEN.MenuId,
 objQxPotenceTypeEN.ViewId,
 objQxPotenceTypeEN.IsVisible,
 objQxPotenceTypeEN.UpdDate,
 objQxPotenceTypeEN.UpdUserId,
objQxPotenceTypeEN.Memo
};
 objSQL.ExecSP("QxPotenceType_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxPotenceTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where PotenceTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPotenceType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPotenceTypeId = oRow[conQxPotenceType.PotenceTypeId].ToString().Trim();
if (IsExist(strPotenceTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("PotenceTypeId = {0}", strPotenceTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxPotenceTypeEN._CurrTabName ].NewRow();
objRow[conQxPotenceType.PotenceTypeId] = oRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objRow[conQxPotenceType.PotenceTypeName] = oRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objRow[conQxPotenceType.QxPrjId] = oRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxPotenceType.FuncModuleId] = oRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objRow[conQxPotenceType.MenuId] = oRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objRow[conQxPotenceType.ViewId] = oRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objRow[conQxPotenceType.IsVisible] = oRow[conQxPotenceType.IsVisible].ToString().Trim(); //是否显示
objRow[conQxPotenceType.UpdDate] = oRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objRow[conQxPotenceType.UpdUserId] = oRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conQxPotenceType.Memo] = oRow[conQxPotenceType.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxPotenceTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxPotenceTypeEN._CurrTabName);
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
 /// <param name = "objQxPotenceTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPotenceTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPotenceTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxPotenceType where PotenceTypeId = " + "'"+ objQxPotenceTypeEN.PotenceTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxPotenceTypeEN._CurrTabName);
if (objDS.Tables[clsQxPotenceTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PotenceTypeId = " + "'"+ objQxPotenceTypeEN.PotenceTypeId+"'");
return false;
}
objRow = objDS.Tables[clsQxPotenceTypeEN._CurrTabName].Rows[0];
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.PotenceTypeId))
 {
objRow[conQxPotenceType.PotenceTypeId] = objQxPotenceTypeEN.PotenceTypeId; //权限类型Id
 }
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.PotenceTypeName))
 {
objRow[conQxPotenceType.PotenceTypeName] = objQxPotenceTypeEN.PotenceTypeName; //权限类型名
 }
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.QxPrjId))
 {
objRow[conQxPotenceType.QxPrjId] = objQxPotenceTypeEN.QxPrjId; //项目Id
 }
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.FuncModuleId))
 {
objRow[conQxPotenceType.FuncModuleId] = objQxPotenceTypeEN.FuncModuleId; //模块Id
 }
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.MenuId))
 {
objRow[conQxPotenceType.MenuId] = objQxPotenceTypeEN.MenuId; //菜单Id
 }
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.ViewId))
 {
objRow[conQxPotenceType.ViewId] = objQxPotenceTypeEN.ViewId; //界面编号
 }
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.IsVisible))
 {
objRow[conQxPotenceType.IsVisible] = objQxPotenceTypeEN.IsVisible; //是否显示
 }
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.UpdDate))
 {
objRow[conQxPotenceType.UpdDate] = objQxPotenceTypeEN.UpdDate; //修改日期
 }
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.UpdUserId))
 {
objRow[conQxPotenceType.UpdUserId] = objQxPotenceTypeEN.UpdUserId; //修改用户Id
 }
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.Memo))
 {
objRow[conQxPotenceType.Memo] = objQxPotenceTypeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxPotenceTypeEN._CurrTabName);
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
public bool UpdateBySP(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPotenceTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPotenceTypeEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPotenceTypeEN.PotenceTypeId,
 objQxPotenceTypeEN.PotenceTypeName,
 objQxPotenceTypeEN.QxPrjId,
 objQxPotenceTypeEN.FuncModuleId,
 objQxPotenceTypeEN.MenuId,
 objQxPotenceTypeEN.ViewId,
 objQxPotenceTypeEN.IsVisible,
 objQxPotenceTypeEN.UpdDate,
 objQxPotenceTypeEN.UpdUserId,
 objQxPotenceTypeEN.Memo
};
 objSQL.ExecSP("QxPotenceType_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPotenceTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPotenceTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxPotenceType Set ");
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.PotenceTypeName))
 {
 if (objQxPotenceTypeEN.PotenceTypeName !=  null)
 {
 var strPotenceTypeName = objQxPotenceTypeEN.PotenceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceTypeName, conQxPotenceType.PotenceTypeName); //权限类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.PotenceTypeName); //权限类型名
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.QxPrjId))
 {
 if (objQxPotenceTypeEN.QxPrjId  ==  "")
 {
 objQxPotenceTypeEN.QxPrjId = null;
 }
 if (objQxPotenceTypeEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPotenceTypeEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPotenceType.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.QxPrjId); //项目Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.FuncModuleId))
 {
 if (objQxPotenceTypeEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPotenceTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conQxPotenceType.FuncModuleId); //模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.FuncModuleId); //模块Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.MenuId))
 {
 if (objQxPotenceTypeEN.MenuId !=  null)
 {
 var strMenuId = objQxPotenceTypeEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId, conQxPotenceType.MenuId); //菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.MenuId); //菜单Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.ViewId))
 {
 if (objQxPotenceTypeEN.ViewId !=  null)
 {
 var strViewId = objQxPotenceTypeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewId, conQxPotenceType.ViewId); //界面编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.ViewId); //界面编号
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPotenceTypeEN.IsVisible == true?"1":"0", conQxPotenceType.IsVisible); //是否显示
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.UpdDate))
 {
 if (objQxPotenceTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPotenceTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPotenceType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.UpdDate); //修改日期
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.UpdUserId))
 {
 if (objQxPotenceTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPotenceTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPotenceType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.Memo))
 {
 if (objQxPotenceTypeEN.Memo !=  null)
 {
 var strMemo = objQxPotenceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPotenceType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PotenceTypeId = '{0}'", objQxPotenceTypeEN.PotenceTypeId); 
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
 /// <param name = "objQxPotenceTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxPotenceTypeEN objQxPotenceTypeEN, string strCondition)
{
 objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPotenceTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPotenceTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPotenceType Set ");
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.PotenceTypeName))
 {
 if (objQxPotenceTypeEN.PotenceTypeName !=  null)
 {
 var strPotenceTypeName = objQxPotenceTypeEN.PotenceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceTypeName = '{0}',", strPotenceTypeName); //权限类型名
 }
 else
 {
 sbSQL.Append(" PotenceTypeName = null,"); //权限类型名
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.QxPrjId))
 {
 if (objQxPotenceTypeEN.QxPrjId  ==  "")
 {
 objQxPotenceTypeEN.QxPrjId = null;
 }
 if (objQxPotenceTypeEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPotenceTypeEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.FuncModuleId))
 {
 if (objQxPotenceTypeEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPotenceTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //模块Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.MenuId))
 {
 if (objQxPotenceTypeEN.MenuId !=  null)
 {
 var strMenuId = objQxPotenceTypeEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId = '{0}',", strMenuId); //菜单Id
 }
 else
 {
 sbSQL.Append(" MenuId = null,"); //菜单Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.ViewId))
 {
 if (objQxPotenceTypeEN.ViewId !=  null)
 {
 var strViewId = objQxPotenceTypeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", strViewId); //界面编号
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面编号
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objQxPotenceTypeEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.UpdDate))
 {
 if (objQxPotenceTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPotenceTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.UpdUserId))
 {
 if (objQxPotenceTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPotenceTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.Memo))
 {
 if (objQxPotenceTypeEN.Memo !=  null)
 {
 var strMemo = objQxPotenceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxPotenceTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxPotenceTypeEN objQxPotenceTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPotenceTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPotenceTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPotenceType Set ");
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.PotenceTypeName))
 {
 if (objQxPotenceTypeEN.PotenceTypeName !=  null)
 {
 var strPotenceTypeName = objQxPotenceTypeEN.PotenceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceTypeName = '{0}',", strPotenceTypeName); //权限类型名
 }
 else
 {
 sbSQL.Append(" PotenceTypeName = null,"); //权限类型名
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.QxPrjId))
 {
 if (objQxPotenceTypeEN.QxPrjId  ==  "")
 {
 objQxPotenceTypeEN.QxPrjId = null;
 }
 if (objQxPotenceTypeEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPotenceTypeEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.FuncModuleId))
 {
 if (objQxPotenceTypeEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPotenceTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //模块Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.MenuId))
 {
 if (objQxPotenceTypeEN.MenuId !=  null)
 {
 var strMenuId = objQxPotenceTypeEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId = '{0}',", strMenuId); //菜单Id
 }
 else
 {
 sbSQL.Append(" MenuId = null,"); //菜单Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.ViewId))
 {
 if (objQxPotenceTypeEN.ViewId !=  null)
 {
 var strViewId = objQxPotenceTypeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", strViewId); //界面编号
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面编号
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objQxPotenceTypeEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.UpdDate))
 {
 if (objQxPotenceTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPotenceTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.UpdUserId))
 {
 if (objQxPotenceTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPotenceTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.Memo))
 {
 if (objQxPotenceTypeEN.Memo !=  null)
 {
 var strMemo = objQxPotenceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPotenceTypeEN objQxPotenceTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPotenceTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPotenceTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPotenceType Set ");
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.PotenceTypeName))
 {
 if (objQxPotenceTypeEN.PotenceTypeName !=  null)
 {
 var strPotenceTypeName = objQxPotenceTypeEN.PotenceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceTypeName, conQxPotenceType.PotenceTypeName); //权限类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.PotenceTypeName); //权限类型名
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.QxPrjId))
 {
 if (objQxPotenceTypeEN.QxPrjId  ==  "")
 {
 objQxPotenceTypeEN.QxPrjId = null;
 }
 if (objQxPotenceTypeEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPotenceTypeEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPotenceType.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.QxPrjId); //项目Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.FuncModuleId))
 {
 if (objQxPotenceTypeEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPotenceTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conQxPotenceType.FuncModuleId); //模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.FuncModuleId); //模块Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.MenuId))
 {
 if (objQxPotenceTypeEN.MenuId !=  null)
 {
 var strMenuId = objQxPotenceTypeEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId, conQxPotenceType.MenuId); //菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.MenuId); //菜单Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.ViewId))
 {
 if (objQxPotenceTypeEN.ViewId !=  null)
 {
 var strViewId = objQxPotenceTypeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewId, conQxPotenceType.ViewId); //界面编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.ViewId); //界面编号
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPotenceTypeEN.IsVisible == true?"1":"0", conQxPotenceType.IsVisible); //是否显示
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.UpdDate))
 {
 if (objQxPotenceTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPotenceTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPotenceType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.UpdDate); //修改日期
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.UpdUserId))
 {
 if (objQxPotenceTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPotenceTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPotenceType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPotenceTypeEN.IsUpdated(conQxPotenceType.Memo))
 {
 if (objQxPotenceTypeEN.Memo !=  null)
 {
 var strMemo = objQxPotenceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPotenceType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPotenceType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PotenceTypeId = '{0}'", objQxPotenceTypeEN.PotenceTypeId); 
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
 /// <param name = "strPotenceTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPotenceTypeId) 
{
CheckPrimaryKey(strPotenceTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPotenceTypeId,
};
 objSQL.ExecSP("QxPotenceType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPotenceTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPotenceTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPotenceTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
//删除QxPotenceType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPotenceType where PotenceTypeId = " + "'"+ strPotenceTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxPotenceType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
//删除QxPotenceType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPotenceType where PotenceTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPotenceTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPotenceTypeId) 
{
CheckPrimaryKey(strPotenceTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
//删除QxPotenceType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPotenceType where PotenceTypeId = " + "'"+ strPotenceTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxPotenceType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: DelQxPotenceType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPotenceType where " + strCondition ;
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
public bool DelQxPotenceTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxPotenceTypeDA: DelQxPotenceTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPotenceType where " + strCondition ;
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
 /// <param name = "objQxPotenceTypeENS">源对象</param>
 /// <param name = "objQxPotenceTypeENT">目标对象</param>
public void CopyTo(clsQxPotenceTypeEN objQxPotenceTypeENS, clsQxPotenceTypeEN objQxPotenceTypeENT)
{
objQxPotenceTypeENT.PotenceTypeId = objQxPotenceTypeENS.PotenceTypeId; //权限类型Id
objQxPotenceTypeENT.PotenceTypeName = objQxPotenceTypeENS.PotenceTypeName; //权限类型名
objQxPotenceTypeENT.QxPrjId = objQxPotenceTypeENS.QxPrjId; //项目Id
objQxPotenceTypeENT.FuncModuleId = objQxPotenceTypeENS.FuncModuleId; //模块Id
objQxPotenceTypeENT.MenuId = objQxPotenceTypeENS.MenuId; //菜单Id
objQxPotenceTypeENT.ViewId = objQxPotenceTypeENS.ViewId; //界面编号
objQxPotenceTypeENT.IsVisible = objQxPotenceTypeENS.IsVisible; //是否显示
objQxPotenceTypeENT.UpdDate = objQxPotenceTypeENS.UpdDate; //修改日期
objQxPotenceTypeENT.UpdUserId = objQxPotenceTypeENS.UpdUserId; //修改用户Id
objQxPotenceTypeENT.Memo = objQxPotenceTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxPotenceTypeEN.PotenceTypeName, conQxPotenceType.PotenceTypeName);
clsCheckSql.CheckFieldNotNull(objQxPotenceTypeEN.QxPrjId, conQxPotenceType.QxPrjId);
clsCheckSql.CheckFieldNotNull(objQxPotenceTypeEN.UpdDate, conQxPotenceType.UpdDate);
clsCheckSql.CheckFieldNotNull(objQxPotenceTypeEN.UpdUserId, conQxPotenceType.UpdUserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.PotenceTypeId, 6, conQxPotenceType.PotenceTypeId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.PotenceTypeName, 50, conQxPotenceType.PotenceTypeName);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.QxPrjId, 4, conQxPotenceType.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.FuncModuleId, 4, conQxPotenceType.FuncModuleId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.MenuId, 8, conQxPotenceType.MenuId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.ViewId, 8, conQxPotenceType.ViewId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.UpdDate, 20, conQxPotenceType.UpdDate);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.UpdUserId, 20, conQxPotenceType.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.Memo, 1000, conQxPotenceType.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxPotenceTypeEN.QxPrjId, 4, conQxPotenceType.QxPrjId);
 objQxPotenceTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.PotenceTypeName, 50, conQxPotenceType.PotenceTypeName);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.QxPrjId, 4, conQxPotenceType.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.FuncModuleId, 4, conQxPotenceType.FuncModuleId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.MenuId, 8, conQxPotenceType.MenuId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.ViewId, 8, conQxPotenceType.ViewId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.UpdDate, 20, conQxPotenceType.UpdDate);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.UpdUserId, 20, conQxPotenceType.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.Memo, 1000, conQxPotenceType.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPotenceTypeEN.QxPrjId, 4, conQxPotenceType.QxPrjId);
 objQxPotenceTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.PotenceTypeId, 6, conQxPotenceType.PotenceTypeId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.PotenceTypeName, 50, conQxPotenceType.PotenceTypeName);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.QxPrjId, 4, conQxPotenceType.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.FuncModuleId, 4, conQxPotenceType.FuncModuleId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.MenuId, 8, conQxPotenceType.MenuId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.ViewId, 8, conQxPotenceType.ViewId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.UpdDate, 20, conQxPotenceType.UpdDate);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.UpdUserId, 20, conQxPotenceType.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPotenceTypeEN.Memo, 1000, conQxPotenceType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxPotenceTypeEN.PotenceTypeId, conQxPotenceType.PotenceTypeId);
clsCheckSql.CheckSqlInjection4Field(objQxPotenceTypeEN.PotenceTypeName, conQxPotenceType.PotenceTypeName);
clsCheckSql.CheckSqlInjection4Field(objQxPotenceTypeEN.QxPrjId, conQxPotenceType.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxPotenceTypeEN.FuncModuleId, conQxPotenceType.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objQxPotenceTypeEN.MenuId, conQxPotenceType.MenuId);
clsCheckSql.CheckSqlInjection4Field(objQxPotenceTypeEN.ViewId, conQxPotenceType.ViewId);
clsCheckSql.CheckSqlInjection4Field(objQxPotenceTypeEN.UpdDate, conQxPotenceType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxPotenceTypeEN.UpdUserId, conQxPotenceType.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objQxPotenceTypeEN.Memo, conQxPotenceType.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPotenceTypeEN.QxPrjId, 4, conQxPotenceType.QxPrjId);
 objQxPotenceTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPotenceTypeId()
{
//获取某学院所有专业信息
string strSQL = "select PotenceTypeId, PotenceTypeName from QxPotenceType ";
 clsSpecSQLforSql mySql = clsQxPotenceTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxPotenceType(权限类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PotenceTypeName = '{0}'", objQxPotenceTypeEN.PotenceTypeName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPotenceTypeEN.QxPrjId);
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
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPotenceTypeEN._CurrTabName);
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
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPotenceTypeEN._CurrTabName, strCondition);
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
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
 objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}