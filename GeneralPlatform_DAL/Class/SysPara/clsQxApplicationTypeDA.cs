
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxApplicationTypeDA
 表名:QxApplicationType(00140088)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:26:27
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统参数(SysPara)
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
 /// 应用程序类型(QxApplicationType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxApplicationTypeDA : clsCommBase4DA
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
 return clsQxApplicationTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxApplicationTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxApplicationTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxApplicationTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxApplicationTypeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
 strSQL = "Select * from QxApplicationType where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxApplicationType");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxApplicationType_SelectByCond",values, "QxApplicationType");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxApplicationType where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxApplicationType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxApplicationType a where {0} And a.ApplicationTypeId not in (Select Top {2} ApplicationTypeId From QxApplicationType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxApplicationType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxApplicationType a where {0} And a.ApplicationTypeId not in (Select Top {2} ApplicationTypeId From QxApplicationType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxApplicationType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxApplicationType a where {0} And a.ApplicationTypeId not in (Select Top {2} ApplicationTypeId From QxApplicationType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxApplicationType");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxApplicationType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTable_QxApplicationType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxApplicationType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxApplicationType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxApplicationType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxApplicationType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxApplicationType.* from QxApplicationType Left Join {1} on {2} where {3} and QxApplicationType.ApplicationTypeId not in (Select top {5} QxApplicationType.ApplicationTypeId from QxApplicationType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxApplicationType where {1} and ApplicationTypeId not in (Select top {2} ApplicationTypeId from QxApplicationType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxApplicationType where {1} and ApplicationTypeId not in (Select top {3} ApplicationTypeId from QxApplicationType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxApplicationType.* from QxApplicationType Left Join {1} on {2} where {3} and QxApplicationType.ApplicationTypeId not in (Select top {5} QxApplicationType.ApplicationTypeId from QxApplicationType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxApplicationType where {1} and ApplicationTypeId not in (Select top {2} ApplicationTypeId from QxApplicationType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxApplicationType where {1} and ApplicationTypeId not in (Select top {3} ApplicationTypeId from QxApplicationType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxApplicationType.* from QxApplicationType Left Join {1} on {2} where {3} and QxApplicationType.ApplicationTypeId not in (Select top {5} QxApplicationType.ApplicationTypeId from QxApplicationType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxApplicationType where {1} and ApplicationTypeId not in (Select top {2} ApplicationTypeId from QxApplicationType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxApplicationType where {1} and ApplicationTypeId not in (Select top {3} ApplicationTypeId from QxApplicationType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxApplicationType a where {0} And a.ApplicationTypeId not in (Select Top {2} ApplicationTypeId From QxApplicationType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxApplicationType a where {0} And a.ApplicationTypeId not in (Select Top {2} ApplicationTypeId From QxApplicationType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxApplicationType a where {0} And a.ApplicationTypeId not in (Select Top {2} ApplicationTypeId From QxApplicationType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxApplicationType a where {0} And a.ApplicationTypeId not in (Select Top {2} ApplicationTypeId From QxApplicationType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxApplicationTypeDA: GetQxApplicationTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxApplicationType_SelectByCond",values);
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
public List<clsQxApplicationTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA:GetObjLst)", objException.Message));
}
List<clsQxApplicationTypeEN> arrObjLst = new List<clsQxApplicationTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN();
try
{
objQxApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[conQxApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxApplicationTypeEN.ApplicationTypeName = objRow[conQxApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objQxApplicationTypeEN.ApplicationTypeENName = objRow[conQxApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objQxApplicationTypeEN.ProgLangTypeId = objRow[conQxApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objQxApplicationTypeEN.ProgLangTypeId2 = objRow[conQxApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objQxApplicationTypeEN.ProgLangTypeId3 = objRow[conQxApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objQxApplicationTypeEN.ProgLangTypeId4 = objRow[conQxApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objQxApplicationTypeEN.ProgLangTypeId5 = objRow[conQxApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objQxApplicationTypeEN.IsVisible = TransNullToBool(objRow[conQxApplicationType.IsVisible].ToString().Trim()); //是否显示
objQxApplicationTypeEN.OrderNum = TransNullToInt(objRow[conQxApplicationType.OrderNum].ToString().Trim()); //排序号
objQxApplicationTypeEN.Memo = objRow[conQxApplicationType.Memo] == DBNull.Value ? null : objRow[conQxApplicationType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxApplicationTypeDA: GetObjLst)", objException.Message));
}
objQxApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxApplicationTypeEN);
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
public List<clsQxApplicationTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxApplicationTypeEN> arrObjLst = new List<clsQxApplicationTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN();
try
{
objQxApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[conQxApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxApplicationTypeEN.ApplicationTypeName = objRow[conQxApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objQxApplicationTypeEN.ApplicationTypeENName = objRow[conQxApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objQxApplicationTypeEN.ProgLangTypeId = objRow[conQxApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objQxApplicationTypeEN.ProgLangTypeId2 = objRow[conQxApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objQxApplicationTypeEN.ProgLangTypeId3 = objRow[conQxApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objQxApplicationTypeEN.ProgLangTypeId4 = objRow[conQxApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objQxApplicationTypeEN.ProgLangTypeId5 = objRow[conQxApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objQxApplicationTypeEN.IsVisible = TransNullToBool(objRow[conQxApplicationType.IsVisible].ToString().Trim()); //是否显示
objQxApplicationTypeEN.OrderNum = TransNullToInt(objRow[conQxApplicationType.OrderNum].ToString().Trim()); //排序号
objQxApplicationTypeEN.Memo = objRow[conQxApplicationType.Memo] == DBNull.Value ? null : objRow[conQxApplicationType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxApplicationTypeDA: GetObjLst)", objException.Message));
}
objQxApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxApplicationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxApplicationTypeEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA:GetObjLstBySP)", objException.Message));
}
List<clsQxApplicationTypeEN> arrObjLst = new List<clsQxApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxApplicationType_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN();
try
{
objQxApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[conQxApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxApplicationTypeEN.ApplicationTypeName = objRow[conQxApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objQxApplicationTypeEN.ApplicationTypeENName = objRow[conQxApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objQxApplicationTypeEN.ProgLangTypeId = objRow[conQxApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objQxApplicationTypeEN.ProgLangTypeId2 = objRow[conQxApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objQxApplicationTypeEN.ProgLangTypeId3 = objRow[conQxApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objQxApplicationTypeEN.ProgLangTypeId4 = objRow[conQxApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objQxApplicationTypeEN.ProgLangTypeId5 = objRow[conQxApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objQxApplicationTypeEN.IsVisible = TransNullToBool(objRow[conQxApplicationType.IsVisible].ToString().Trim()); //是否显示
objQxApplicationTypeEN.OrderNum = TransNullToInt(objRow[conQxApplicationType.OrderNum].ToString().Trim()); //排序号
objQxApplicationTypeEN.Memo = objRow[conQxApplicationType.Memo] == DBNull.Value ? null : objRow[conQxApplicationType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxApplicationTypeDA: GetObjLstBySP)", objException.Message));
}
objQxApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxApplicationTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxApplicationType(ref clsQxApplicationTypeEN objQxApplicationTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where ApplicationTypeId = " + ""+ objQxApplicationTypeEN.ApplicationTypeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxApplicationTypeEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conQxApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objQxApplicationTypeEN.ApplicationTypeName = objDT.Rows[0][conQxApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objQxApplicationTypeEN.ApplicationTypeENName = objDT.Rows[0][conQxApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxApplicationTypeEN.ProgLangTypeId = objDT.Rows[0][conQxApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objQxApplicationTypeEN.ProgLangTypeId2 = objDT.Rows[0][conQxApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.ProgLangTypeId3 = objDT.Rows[0][conQxApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.ProgLangTypeId4 = objDT.Rows[0][conQxApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.ProgLangTypeId5 = objDT.Rows[0][conQxApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.IsVisible = TransNullToBool(objDT.Rows[0][conQxApplicationType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objQxApplicationTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxApplicationType.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxApplicationTypeEN.Memo = objDT.Rows[0][conQxApplicationType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxApplicationTypeDA: GetQxApplicationType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intApplicationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxApplicationTypeEN GetObjByApplicationTypeId(int intApplicationTypeId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where ApplicationTypeId = " + ""+ intApplicationTypeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN();
try
{
 objQxApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conQxApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objQxApplicationTypeEN.ApplicationTypeName = objRow[conQxApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objQxApplicationTypeEN.ApplicationTypeENName = objRow[conQxApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxApplicationTypeEN.ProgLangTypeId = objRow[conQxApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objQxApplicationTypeEN.ProgLangTypeId2 = objRow[conQxApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.ProgLangTypeId3 = objRow[conQxApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.ProgLangTypeId4 = objRow[conQxApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.ProgLangTypeId5 = objRow[conQxApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxApplicationType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objQxApplicationTypeEN.OrderNum = Int32.Parse(objRow[conQxApplicationType.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxApplicationTypeEN.Memo = objRow[conQxApplicationType.Memo] == DBNull.Value ? null : objRow[conQxApplicationType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxApplicationTypeDA: GetObjByApplicationTypeId)", objException.Message));
}
return objQxApplicationTypeEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxApplicationType_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxApplicationTypeOneBySP(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxApplicationTypeEN.ApplicationTypeId
};
 objDT = objSQL.ExecSpReturnDT("QxApplicationType_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxApplicationTypeEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conQxApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objQxApplicationTypeEN.ApplicationTypeName = objDT.Rows[0][conQxApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objQxApplicationTypeEN.ApplicationTypeENName = objDT.Rows[0][conQxApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxApplicationTypeEN.ProgLangTypeId = objDT.Rows[0][conQxApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objQxApplicationTypeEN.ProgLangTypeId2 = objDT.Rows[0][conQxApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.ProgLangTypeId3 = objDT.Rows[0][conQxApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.ProgLangTypeId4 = objDT.Rows[0][conQxApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.ProgLangTypeId5 = objDT.Rows[0][conQxApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5(字段类型:char,字段长度:2,是否可空:True)
 objQxApplicationTypeEN.IsVisible = TransNullToBool(objDT.Rows[0][conQxApplicationType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objQxApplicationTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxApplicationType.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxApplicationTypeEN.Memo = objDT.Rows[0][conQxApplicationType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxApplicationTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN()
{
ApplicationTypeId = TransNullToInt(objRow[conQxApplicationType.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[conQxApplicationType.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeENName = objRow[conQxApplicationType.ApplicationTypeENName].ToString().Trim(), //应用类型英文名
ProgLangTypeId = objRow[conQxApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeId2 = objRow[conQxApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId2].ToString().Trim(), //编程语言类型Id2
ProgLangTypeId3 = objRow[conQxApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId3].ToString().Trim(), //编程语言类型Id3
ProgLangTypeId4 = objRow[conQxApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId4].ToString().Trim(), //编程语言类型Id4
ProgLangTypeId5 = objRow[conQxApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId5].ToString().Trim(), //编程语言类型Id5
IsVisible = TransNullToBool(objRow[conQxApplicationType.IsVisible].ToString().Trim()), //是否显示
OrderNum = TransNullToInt(objRow[conQxApplicationType.OrderNum].ToString().Trim()), //排序号
Memo = objRow[conQxApplicationType.Memo] == DBNull.Value ? null : objRow[conQxApplicationType.Memo].ToString().Trim() //备注
};
objQxApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxApplicationTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxApplicationTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxApplicationTypeEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxApplicationType_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN()
{
ApplicationTypeId = TransNullToInt(objRow[conQxApplicationType.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[conQxApplicationType.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeENName = objRow[conQxApplicationType.ApplicationTypeENName].ToString().Trim(), //应用类型英文名
ProgLangTypeId = objRow[conQxApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeId2 = objRow[conQxApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId2].ToString().Trim(), //编程语言类型Id2
ProgLangTypeId3 = objRow[conQxApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId3].ToString().Trim(), //编程语言类型Id3
ProgLangTypeId4 = objRow[conQxApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId4].ToString().Trim(), //编程语言类型Id4
ProgLangTypeId5 = objRow[conQxApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId5].ToString().Trim(), //编程语言类型Id5
IsVisible = TransNullToBool(objRow[conQxApplicationType.IsVisible].ToString().Trim()), //是否显示
OrderNum = TransNullToInt(objRow[conQxApplicationType.OrderNum].ToString().Trim()), //排序号
Memo = objRow[conQxApplicationType.Memo] == DBNull.Value ? null : objRow[conQxApplicationType.Memo].ToString().Trim() //备注
};
objQxApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxApplicationTypeEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxApplicationTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN();
try
{
objQxApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[conQxApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxApplicationTypeEN.ApplicationTypeName = objRow[conQxApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objQxApplicationTypeEN.ApplicationTypeENName = objRow[conQxApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objQxApplicationTypeEN.ProgLangTypeId = objRow[conQxApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objQxApplicationTypeEN.ProgLangTypeId2 = objRow[conQxApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objQxApplicationTypeEN.ProgLangTypeId3 = objRow[conQxApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objQxApplicationTypeEN.ProgLangTypeId4 = objRow[conQxApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objQxApplicationTypeEN.ProgLangTypeId5 = objRow[conQxApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objQxApplicationTypeEN.IsVisible = TransNullToBool(objRow[conQxApplicationType.IsVisible].ToString().Trim()); //是否显示
objQxApplicationTypeEN.OrderNum = TransNullToInt(objRow[conQxApplicationType.OrderNum].ToString().Trim()); //排序号
objQxApplicationTypeEN.Memo = objRow[conQxApplicationType.Memo] == DBNull.Value ? null : objRow[conQxApplicationType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxApplicationTypeDA: GetObjByDataRowQxApplicationType)", objException.Message));
}
objQxApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxApplicationTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxApplicationTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN();
try
{
objQxApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[conQxApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxApplicationTypeEN.ApplicationTypeName = objRow[conQxApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objQxApplicationTypeEN.ApplicationTypeENName = objRow[conQxApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objQxApplicationTypeEN.ProgLangTypeId = objRow[conQxApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objQxApplicationTypeEN.ProgLangTypeId2 = objRow[conQxApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objQxApplicationTypeEN.ProgLangTypeId3 = objRow[conQxApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objQxApplicationTypeEN.ProgLangTypeId4 = objRow[conQxApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objQxApplicationTypeEN.ProgLangTypeId5 = objRow[conQxApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conQxApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objQxApplicationTypeEN.IsVisible = TransNullToBool(objRow[conQxApplicationType.IsVisible].ToString().Trim()); //是否显示
objQxApplicationTypeEN.OrderNum = TransNullToInt(objRow[conQxApplicationType.OrderNum].ToString().Trim()); //排序号
objQxApplicationTypeEN.Memo = objRow[conQxApplicationType.Memo] == DBNull.Value ? null : objRow[conQxApplicationType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxApplicationTypeDA: GetObjByDataRow)", objException.Message));
}
objQxApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxApplicationTypeEN;
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
objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxApplicationTypeEN._CurrTabName, conQxApplicationType.ApplicationTypeId, 4, "");
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
objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxApplicationTypeEN._CurrTabName, conQxApplicationType.ApplicationTypeId, 4, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public int GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ApplicationTypeId from QxApplicationType where " + strCondition;
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
return int.Parse(strKeyValue);
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
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ApplicationTypeId from QxApplicationType where " + strCondition;
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
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(int intApplicationTypeId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxApplicationType", "ApplicationTypeId = " + ""+ intApplicationTypeId+""))
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
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(int intApplicationTypeId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
intApplicationTypeId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxApplicationType_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxApplicationType", strCondition))
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
objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxApplicationType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxApplicationTypeEN objQxApplicationTypeEN)
 {
 if (objQxApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxApplicationTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxApplicationType");
objRow = objDS.Tables["QxApplicationType"].NewRow();
objRow[conQxApplicationType.ApplicationTypeName] = objQxApplicationTypeEN.ApplicationTypeName; //应用程序类型名称
objRow[conQxApplicationType.ApplicationTypeENName] = objQxApplicationTypeEN.ApplicationTypeENName; //应用类型英文名
 if (objQxApplicationTypeEN.ProgLangTypeId !=  "")
 {
objRow[conQxApplicationType.ProgLangTypeId] = objQxApplicationTypeEN.ProgLangTypeId; //编程语言类型Id
 }
 if (objQxApplicationTypeEN.ProgLangTypeId2 !=  "")
 {
objRow[conQxApplicationType.ProgLangTypeId2] = objQxApplicationTypeEN.ProgLangTypeId2; //编程语言类型Id2
 }
 if (objQxApplicationTypeEN.ProgLangTypeId3 !=  "")
 {
objRow[conQxApplicationType.ProgLangTypeId3] = objQxApplicationTypeEN.ProgLangTypeId3; //编程语言类型Id3
 }
 if (objQxApplicationTypeEN.ProgLangTypeId4 !=  "")
 {
objRow[conQxApplicationType.ProgLangTypeId4] = objQxApplicationTypeEN.ProgLangTypeId4; //编程语言类型Id4
 }
 if (objQxApplicationTypeEN.ProgLangTypeId5 !=  "")
 {
objRow[conQxApplicationType.ProgLangTypeId5] = objQxApplicationTypeEN.ProgLangTypeId5; //编程语言类型Id5
 }
objRow[conQxApplicationType.IsVisible] = objQxApplicationTypeEN.IsVisible; //是否显示
objRow[conQxApplicationType.OrderNum] = objQxApplicationTypeEN.OrderNum; //排序号
 if (objQxApplicationTypeEN.Memo !=  "")
 {
objRow[conQxApplicationType.Memo] = objQxApplicationTypeEN.Memo; //备注
 }
objDS.Tables[clsQxApplicationTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxApplicationTypeEN._CurrTabName);
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
 /// <param name = "objQxApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
 if (objQxApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxApplicationTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxApplicationTypeEN.ApplicationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ApplicationTypeName);
 var strApplicationTypeName = objQxApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeName + "'");
 }
 
 if (objQxApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ApplicationTypeENName);
 var strApplicationTypeENName = objQxApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeENName + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId);
 var strProgLangTypeId = objQxApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId2);
 var strProgLangTypeId2 = objQxApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId2 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId3);
 var strProgLangTypeId3 = objQxApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId3 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId4);
 var strProgLangTypeId4 = objQxApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId4 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId5);
 var strProgLangTypeId5 = objQxApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId5 + "'");
 }
 
 arrFieldListForInsert.Add(conQxApplicationType.IsVisible);
 arrValueListForInsert.Add("'" + (objQxApplicationTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxApplicationType.OrderNum);
 arrValueListForInsert.Add(objQxApplicationTypeEN.OrderNum.ToString());
 
 if (objQxApplicationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.Memo);
 var strMemo = objQxApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxApplicationType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
 if (objQxApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxApplicationTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxApplicationTypeEN.ApplicationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ApplicationTypeName);
 var strApplicationTypeName = objQxApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeName + "'");
 }
 
 if (objQxApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ApplicationTypeENName);
 var strApplicationTypeENName = objQxApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeENName + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId);
 var strProgLangTypeId = objQxApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId2);
 var strProgLangTypeId2 = objQxApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId2 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId3);
 var strProgLangTypeId3 = objQxApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId3 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId4);
 var strProgLangTypeId4 = objQxApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId4 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId5);
 var strProgLangTypeId5 = objQxApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId5 + "'");
 }
 
 arrFieldListForInsert.Add(conQxApplicationType.IsVisible);
 arrValueListForInsert.Add("'" + (objQxApplicationTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxApplicationType.OrderNum);
 arrValueListForInsert.Add(objQxApplicationTypeEN.OrderNum.ToString());
 
 if (objQxApplicationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.Memo);
 var strMemo = objQxApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxApplicationType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxApplicationTypeEN objQxApplicationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxApplicationTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxApplicationTypeEN.ApplicationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ApplicationTypeName);
 var strApplicationTypeName = objQxApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeName + "'");
 }
 
 if (objQxApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ApplicationTypeENName);
 var strApplicationTypeENName = objQxApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeENName + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId);
 var strProgLangTypeId = objQxApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId2);
 var strProgLangTypeId2 = objQxApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId2 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId3);
 var strProgLangTypeId3 = objQxApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId3 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId4);
 var strProgLangTypeId4 = objQxApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId4 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId5);
 var strProgLangTypeId5 = objQxApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId5 + "'");
 }
 
 arrFieldListForInsert.Add(conQxApplicationType.IsVisible);
 arrValueListForInsert.Add("'" + (objQxApplicationTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxApplicationType.OrderNum);
 arrValueListForInsert.Add(objQxApplicationTypeEN.OrderNum.ToString());
 
 if (objQxApplicationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.Memo);
 var strMemo = objQxApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxApplicationType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxApplicationTypeEN objQxApplicationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQxApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxApplicationTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxApplicationTypeEN.ApplicationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ApplicationTypeName);
 var strApplicationTypeName = objQxApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeName + "'");
 }
 
 if (objQxApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ApplicationTypeENName);
 var strApplicationTypeENName = objQxApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeENName + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId);
 var strProgLangTypeId = objQxApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId2);
 var strProgLangTypeId2 = objQxApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId2 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId3);
 var strProgLangTypeId3 = objQxApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId3 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId4);
 var strProgLangTypeId4 = objQxApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId4 + "'");
 }
 
 if (objQxApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.ProgLangTypeId5);
 var strProgLangTypeId5 = objQxApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId5 + "'");
 }
 
 arrFieldListForInsert.Add(conQxApplicationType.IsVisible);
 arrValueListForInsert.Add("'" + (objQxApplicationTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxApplicationType.OrderNum);
 arrValueListForInsert.Add(objQxApplicationTypeEN.OrderNum.ToString());
 
 if (objQxApplicationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxApplicationType.Memo);
 var strMemo = objQxApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxApplicationType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxApplicationTypeBySP(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxApplicationTypeEN.ApplicationTypeName,
 objQxApplicationTypeEN.ApplicationTypeENName,
 objQxApplicationTypeEN.ProgLangTypeId,
 objQxApplicationTypeEN.ProgLangTypeId2,
 objQxApplicationTypeEN.ProgLangTypeId3,
 objQxApplicationTypeEN.ProgLangTypeId4,
 objQxApplicationTypeEN.ProgLangTypeId5,
 objQxApplicationTypeEN.IsVisible,
 objQxApplicationTypeEN.OrderNum,
objQxApplicationTypeEN.Memo
};
 objSQL.ExecSP("QxApplicationType_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxApplicationTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where ApplicationTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxApplicationType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
int intApplicationTypeId = TransNullToInt(oRow[conQxApplicationType.ApplicationTypeId].ToString().Trim());
if (IsExist(intApplicationTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("ApplicationTypeId = {0}", intApplicationTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxApplicationTypeEN._CurrTabName ].NewRow();
objRow[conQxApplicationType.ApplicationTypeName] = oRow[conQxApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objRow[conQxApplicationType.ApplicationTypeENName] = oRow[conQxApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objRow[conQxApplicationType.ProgLangTypeId] = oRow[conQxApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objRow[conQxApplicationType.ProgLangTypeId2] = oRow[conQxApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objRow[conQxApplicationType.ProgLangTypeId3] = oRow[conQxApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objRow[conQxApplicationType.ProgLangTypeId4] = oRow[conQxApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objRow[conQxApplicationType.ProgLangTypeId5] = oRow[conQxApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objRow[conQxApplicationType.IsVisible] = oRow[conQxApplicationType.IsVisible].ToString().Trim(); //是否显示
objRow[conQxApplicationType.OrderNum] = oRow[conQxApplicationType.OrderNum].ToString().Trim(); //排序号
objRow[conQxApplicationType.Memo] = oRow[conQxApplicationType.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxApplicationTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxApplicationTypeEN._CurrTabName);
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
 /// <param name = "objQxApplicationTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
 if (objQxApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxApplicationTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from QxApplicationType where ApplicationTypeId = " + ""+ objQxApplicationTypeEN.ApplicationTypeId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxApplicationTypeEN._CurrTabName);
if (objDS.Tables[clsQxApplicationTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ApplicationTypeId = " + ""+ objQxApplicationTypeEN.ApplicationTypeId+"");
return false;
}
objRow = objDS.Tables[clsQxApplicationTypeEN._CurrTabName].Rows[0];
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ApplicationTypeName))
 {
objRow[conQxApplicationType.ApplicationTypeName] = objQxApplicationTypeEN.ApplicationTypeName; //应用程序类型名称
 }
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ApplicationTypeENName))
 {
objRow[conQxApplicationType.ApplicationTypeENName] = objQxApplicationTypeEN.ApplicationTypeENName; //应用类型英文名
 }
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId))
 {
objRow[conQxApplicationType.ProgLangTypeId] = objQxApplicationTypeEN.ProgLangTypeId; //编程语言类型Id
 }
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId2))
 {
objRow[conQxApplicationType.ProgLangTypeId2] = objQxApplicationTypeEN.ProgLangTypeId2; //编程语言类型Id2
 }
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId3))
 {
objRow[conQxApplicationType.ProgLangTypeId3] = objQxApplicationTypeEN.ProgLangTypeId3; //编程语言类型Id3
 }
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId4))
 {
objRow[conQxApplicationType.ProgLangTypeId4] = objQxApplicationTypeEN.ProgLangTypeId4; //编程语言类型Id4
 }
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId5))
 {
objRow[conQxApplicationType.ProgLangTypeId5] = objQxApplicationTypeEN.ProgLangTypeId5; //编程语言类型Id5
 }
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.IsVisible))
 {
objRow[conQxApplicationType.IsVisible] = objQxApplicationTypeEN.IsVisible; //是否显示
 }
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.OrderNum))
 {
objRow[conQxApplicationType.OrderNum] = objQxApplicationTypeEN.OrderNum; //排序号
 }
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.Memo))
 {
objRow[conQxApplicationType.Memo] = objQxApplicationTypeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxApplicationTypeEN._CurrTabName);
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
public bool UpdateBySP(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
 if (objQxApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxApplicationTypeEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxApplicationTypeEN.ApplicationTypeId,
 objQxApplicationTypeEN.ApplicationTypeName,
 objQxApplicationTypeEN.ApplicationTypeENName,
 objQxApplicationTypeEN.ProgLangTypeId,
 objQxApplicationTypeEN.ProgLangTypeId2,
 objQxApplicationTypeEN.ProgLangTypeId3,
 objQxApplicationTypeEN.ProgLangTypeId4,
 objQxApplicationTypeEN.ProgLangTypeId5,
 objQxApplicationTypeEN.IsVisible,
 objQxApplicationTypeEN.OrderNum,
 objQxApplicationTypeEN.Memo
};
 objSQL.ExecSP("QxApplicationType_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
 if (objQxApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxApplicationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxApplicationType Set ");
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ApplicationTypeName))
 {
 if (objQxApplicationTypeEN.ApplicationTypeName !=  null)
 {
 var strApplicationTypeName = objQxApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplicationTypeName, conQxApplicationType.ApplicationTypeName); //应用程序类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ApplicationTypeName); //应用程序类型名称
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ApplicationTypeENName))
 {
 if (objQxApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 var strApplicationTypeENName = objQxApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplicationTypeENName, conQxApplicationType.ApplicationTypeENName); //应用类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ApplicationTypeENName); //应用类型英文名
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objQxApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conQxApplicationType.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId2))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 var strProgLangTypeId2 = objQxApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId2, conQxApplicationType.ProgLangTypeId2); //编程语言类型Id2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ProgLangTypeId2); //编程语言类型Id2
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId3))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 var strProgLangTypeId3 = objQxApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId3, conQxApplicationType.ProgLangTypeId3); //编程语言类型Id3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ProgLangTypeId3); //编程语言类型Id3
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId4))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 var strProgLangTypeId4 = objQxApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId4, conQxApplicationType.ProgLangTypeId4); //编程语言类型Id4
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ProgLangTypeId4); //编程语言类型Id4
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId5))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 var strProgLangTypeId5 = objQxApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId5, conQxApplicationType.ProgLangTypeId5); //编程语言类型Id5
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ProgLangTypeId5); //编程语言类型Id5
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxApplicationTypeEN.IsVisible == true?"1":"0", conQxApplicationType.IsVisible); //是否显示
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxApplicationTypeEN.OrderNum, conQxApplicationType.OrderNum); //排序号
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.Memo))
 {
 if (objQxApplicationTypeEN.Memo !=  null)
 {
 var strMemo = objQxApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxApplicationType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ApplicationTypeId = {0}", objQxApplicationTypeEN.ApplicationTypeId); 
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
 /// <param name = "objQxApplicationTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxApplicationTypeEN objQxApplicationTypeEN, string strCondition)
{
 if (objQxApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxApplicationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxApplicationType Set ");
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ApplicationTypeName))
 {
 if (objQxApplicationTypeEN.ApplicationTypeName !=  null)
 {
 var strApplicationTypeName = objQxApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplicationTypeName = '{0}',", strApplicationTypeName); //应用程序类型名称
 }
 else
 {
 sbSQL.Append(" ApplicationTypeName = null,"); //应用程序类型名称
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ApplicationTypeENName))
 {
 if (objQxApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 var strApplicationTypeENName = objQxApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplicationTypeENName = '{0}',", strApplicationTypeENName); //应用类型英文名
 }
 else
 {
 sbSQL.Append(" ApplicationTypeENName = null,"); //应用类型英文名
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objQxApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId2))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 var strProgLangTypeId2 = objQxApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId2 = '{0}',", strProgLangTypeId2); //编程语言类型Id2
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId2 = null,"); //编程语言类型Id2
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId3))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 var strProgLangTypeId3 = objQxApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId3 = '{0}',", strProgLangTypeId3); //编程语言类型Id3
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId3 = null,"); //编程语言类型Id3
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId4))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 var strProgLangTypeId4 = objQxApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId4 = '{0}',", strProgLangTypeId4); //编程语言类型Id4
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId4 = null,"); //编程语言类型Id4
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId5))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 var strProgLangTypeId5 = objQxApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId5 = '{0}',", strProgLangTypeId5); //编程语言类型Id5
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId5 = null,"); //编程语言类型Id5
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objQxApplicationTypeEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxApplicationTypeEN.OrderNum); //排序号
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.Memo))
 {
 if (objQxApplicationTypeEN.Memo !=  null)
 {
 var strMemo = objQxApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxApplicationTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxApplicationTypeEN objQxApplicationTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxApplicationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxApplicationType Set ");
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ApplicationTypeName))
 {
 if (objQxApplicationTypeEN.ApplicationTypeName !=  null)
 {
 var strApplicationTypeName = objQxApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplicationTypeName = '{0}',", strApplicationTypeName); //应用程序类型名称
 }
 else
 {
 sbSQL.Append(" ApplicationTypeName = null,"); //应用程序类型名称
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ApplicationTypeENName))
 {
 if (objQxApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 var strApplicationTypeENName = objQxApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplicationTypeENName = '{0}',", strApplicationTypeENName); //应用类型英文名
 }
 else
 {
 sbSQL.Append(" ApplicationTypeENName = null,"); //应用类型英文名
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objQxApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId2))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 var strProgLangTypeId2 = objQxApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId2 = '{0}',", strProgLangTypeId2); //编程语言类型Id2
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId2 = null,"); //编程语言类型Id2
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId3))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 var strProgLangTypeId3 = objQxApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId3 = '{0}',", strProgLangTypeId3); //编程语言类型Id3
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId3 = null,"); //编程语言类型Id3
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId4))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 var strProgLangTypeId4 = objQxApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId4 = '{0}',", strProgLangTypeId4); //编程语言类型Id4
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId4 = null,"); //编程语言类型Id4
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId5))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 var strProgLangTypeId5 = objQxApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId5 = '{0}',", strProgLangTypeId5); //编程语言类型Id5
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId5 = null,"); //编程语言类型Id5
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objQxApplicationTypeEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxApplicationTypeEN.OrderNum); //排序号
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.Memo))
 {
 if (objQxApplicationTypeEN.Memo !=  null)
 {
 var strMemo = objQxApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxApplicationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxApplicationTypeEN objQxApplicationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQxApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxApplicationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxApplicationType Set ");
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ApplicationTypeName))
 {
 if (objQxApplicationTypeEN.ApplicationTypeName !=  null)
 {
 var strApplicationTypeName = objQxApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplicationTypeName, conQxApplicationType.ApplicationTypeName); //应用程序类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ApplicationTypeName); //应用程序类型名称
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ApplicationTypeENName))
 {
 if (objQxApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 var strApplicationTypeENName = objQxApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplicationTypeENName, conQxApplicationType.ApplicationTypeENName); //应用类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ApplicationTypeENName); //应用类型英文名
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objQxApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conQxApplicationType.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId2))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 var strProgLangTypeId2 = objQxApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId2, conQxApplicationType.ProgLangTypeId2); //编程语言类型Id2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ProgLangTypeId2); //编程语言类型Id2
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId3))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 var strProgLangTypeId3 = objQxApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId3, conQxApplicationType.ProgLangTypeId3); //编程语言类型Id3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ProgLangTypeId3); //编程语言类型Id3
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId4))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 var strProgLangTypeId4 = objQxApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId4, conQxApplicationType.ProgLangTypeId4); //编程语言类型Id4
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ProgLangTypeId4); //编程语言类型Id4
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.ProgLangTypeId5))
 {
 if (objQxApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 var strProgLangTypeId5 = objQxApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId5, conQxApplicationType.ProgLangTypeId5); //编程语言类型Id5
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.ProgLangTypeId5); //编程语言类型Id5
 }
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxApplicationTypeEN.IsVisible == true?"1":"0", conQxApplicationType.IsVisible); //是否显示
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxApplicationTypeEN.OrderNum, conQxApplicationType.OrderNum); //排序号
 }
 
 if (objQxApplicationTypeEN.IsUpdated(conQxApplicationType.Memo))
 {
 if (objQxApplicationTypeEN.Memo !=  null)
 {
 var strMemo = objQxApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxApplicationType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxApplicationType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ApplicationTypeId = {0}", objQxApplicationTypeEN.ApplicationTypeId); 
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
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intApplicationTypeId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 intApplicationTypeId,
};
 objSQL.ExecSP("QxApplicationType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(int intApplicationTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
//删除QxApplicationType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxApplicationType where ApplicationTypeId = " + ""+ intApplicationTypeId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxApplicationType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
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
//删除QxApplicationType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxApplicationType where ApplicationTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(int intApplicationTypeId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
//删除QxApplicationType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxApplicationType where ApplicationTypeId = " + ""+ intApplicationTypeId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxApplicationType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: DelQxApplicationType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxApplicationType where " + strCondition ;
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
public bool DelQxApplicationTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxApplicationTypeDA: DelQxApplicationTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxApplicationType where " + strCondition ;
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
 /// <param name = "objQxApplicationTypeENS">源对象</param>
 /// <param name = "objQxApplicationTypeENT">目标对象</param>
public void CopyTo(clsQxApplicationTypeEN objQxApplicationTypeENS, clsQxApplicationTypeEN objQxApplicationTypeENT)
{
objQxApplicationTypeENT.ApplicationTypeId = objQxApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objQxApplicationTypeENT.ApplicationTypeName = objQxApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objQxApplicationTypeENT.ApplicationTypeENName = objQxApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objQxApplicationTypeENT.ProgLangTypeId = objQxApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objQxApplicationTypeENT.ProgLangTypeId2 = objQxApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objQxApplicationTypeENT.ProgLangTypeId3 = objQxApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objQxApplicationTypeENT.ProgLangTypeId4 = objQxApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objQxApplicationTypeENT.ProgLangTypeId5 = objQxApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objQxApplicationTypeENT.IsVisible = objQxApplicationTypeENS.IsVisible; //是否显示
objQxApplicationTypeENT.OrderNum = objQxApplicationTypeENS.OrderNum; //排序号
objQxApplicationTypeENT.Memo = objQxApplicationTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxApplicationTypeEN.ApplicationTypeName, conQxApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldNotNull(objQxApplicationTypeEN.ApplicationTypeENName, conQxApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldNotNull(objQxApplicationTypeEN.OrderNum, conQxApplicationType.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ApplicationTypeName, 30, conQxApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ApplicationTypeENName, 30, conQxApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId, 2, conQxApplicationType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId2, 2, conQxApplicationType.ProgLangTypeId2);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId3, 2, conQxApplicationType.ProgLangTypeId3);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId4, 2, conQxApplicationType.ProgLangTypeId4);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId5, 2, conQxApplicationType.ProgLangTypeId5);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.Memo, 1000, conQxApplicationType.Memo);
//检查字段外键固定长度
 objQxApplicationTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ApplicationTypeName, 30, conQxApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ApplicationTypeENName, 30, conQxApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId, 2, conQxApplicationType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId2, 2, conQxApplicationType.ProgLangTypeId2);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId3, 2, conQxApplicationType.ProgLangTypeId3);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId4, 2, conQxApplicationType.ProgLangTypeId4);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId5, 2, conQxApplicationType.ProgLangTypeId5);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.Memo, 1000, conQxApplicationType.Memo);
//检查外键字段长度
 objQxApplicationTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ApplicationTypeName, 30, conQxApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ApplicationTypeENName, 30, conQxApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId, 2, conQxApplicationType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId2, 2, conQxApplicationType.ProgLangTypeId2);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId3, 2, conQxApplicationType.ProgLangTypeId3);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId4, 2, conQxApplicationType.ProgLangTypeId4);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.ProgLangTypeId5, 2, conQxApplicationType.ProgLangTypeId5);
clsCheckSql.CheckFieldLen(objQxApplicationTypeEN.Memo, 1000, conQxApplicationType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxApplicationTypeEN.ApplicationTypeName, conQxApplicationType.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objQxApplicationTypeEN.ApplicationTypeENName, conQxApplicationType.ApplicationTypeENName);
clsCheckSql.CheckSqlInjection4Field(objQxApplicationTypeEN.ProgLangTypeId, conQxApplicationType.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objQxApplicationTypeEN.ProgLangTypeId2, conQxApplicationType.ProgLangTypeId2);
clsCheckSql.CheckSqlInjection4Field(objQxApplicationTypeEN.ProgLangTypeId3, conQxApplicationType.ProgLangTypeId3);
clsCheckSql.CheckSqlInjection4Field(objQxApplicationTypeEN.ProgLangTypeId4, conQxApplicationType.ProgLangTypeId4);
clsCheckSql.CheckSqlInjection4Field(objQxApplicationTypeEN.ProgLangTypeId5, conQxApplicationType.ProgLangTypeId5);
clsCheckSql.CheckSqlInjection4Field(objQxApplicationTypeEN.Memo, conQxApplicationType.Memo);
//检查外键字段长度
 objQxApplicationTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetApplicationTypeId()
{
//获取某学院所有专业信息
string strSQL = "select ApplicationTypeId, ApplicationTypeName from QxApplicationType ";
 clsSpecSQLforSql mySql = clsQxApplicationTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxApplicationType(应用程序类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeName = '{0}'", objQxApplicationTypeEN.ApplicationTypeName);
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
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
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
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
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
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxApplicationTypeEN._CurrTabName);
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
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxApplicationTypeEN._CurrTabName, strCondition);
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
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
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
 objSQL = clsQxApplicationTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}