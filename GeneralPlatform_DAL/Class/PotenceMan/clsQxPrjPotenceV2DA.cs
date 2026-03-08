
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjPotenceV2DA
 表名:QxPrjPotenceV2(00140115)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:30:56
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
 /// 工程权限V2(QxPrjPotenceV2)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxPrjPotenceV2DA : clsCommBase4DA
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
 return clsQxPrjPotenceV2EN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxPrjPotenceV2EN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjPotenceV2EN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxPrjPotenceV2EN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxPrjPotenceV2EN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
 strSQL = "Select * from QxPrjPotenceV2 where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxPrjPotenceV2");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxPrjPotenceV2_SelectByCond",values, "QxPrjPotenceV2");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjPotenceV2 where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjPotenceV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjPotenceV2 a where {0} And a.PId not in (Select Top {2} PId From QxPrjPotenceV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjPotenceV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjPotenceV2 a where {0} And a.PId not in (Select Top {2} PId From QxPrjPotenceV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjPotenceV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjPotenceV2 a where {0} And a.PId not in (Select Top {2} PId From QxPrjPotenceV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjPotenceV2");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxPrjPotenceV2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTable_QxPrjPotenceV2)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotenceV2 where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotenceV2 where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjPotenceV2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjPotenceV2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjPotenceV2.* from QxPrjPotenceV2 Left Join {1} on {2} where {3} and QxPrjPotenceV2.PId not in (Select top {5} QxPrjPotenceV2.PId from QxPrjPotenceV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotenceV2 where {1} and PId not in (Select top {2} PId from QxPrjPotenceV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotenceV2 where {1} and PId not in (Select top {3} PId from QxPrjPotenceV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjPotenceV2.* from QxPrjPotenceV2 Left Join {1} on {2} where {3} and QxPrjPotenceV2.PId not in (Select top {5} QxPrjPotenceV2.PId from QxPrjPotenceV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotenceV2 where {1} and PId not in (Select top {2} PId from QxPrjPotenceV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotenceV2 where {1} and PId not in (Select top {3} PId from QxPrjPotenceV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjPotenceV2.* from QxPrjPotenceV2 Left Join {1} on {2} where {3} and QxPrjPotenceV2.PId not in (Select top {5} QxPrjPotenceV2.PId from QxPrjPotenceV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotenceV2 where {1} and PId not in (Select top {2} PId from QxPrjPotenceV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjPotenceV2 where {1} and PId not in (Select top {3} PId from QxPrjPotenceV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjPotenceV2 a where {0} And a.PId not in (Select Top {2} PId From QxPrjPotenceV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjPotenceV2 a where {0} And a.PId not in (Select Top {2} PId From QxPrjPotenceV2 Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjPotenceV2 a where {0} And a.PId not in (Select Top {2} PId From QxPrjPotenceV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjPotenceV2 a where {0} And a.PId not in (Select Top {2} PId From QxPrjPotenceV2 Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2ByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjPotenceV2_SelectByCond",values);
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
public List<clsQxPrjPotenceV2EN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA:GetObjLst)", objException.Message));
}
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = TransNullToInt(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjPotenceV2DA: GetObjLst)", objException.Message));
}
objQxPrjPotenceV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjPotenceV2EN);
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
public List<clsQxPrjPotenceV2EN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA:GetObjLstByTabName)", objException.Message));
}
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = TransNullToInt(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjPotenceV2DA: GetObjLst)", objException.Message));
}
objQxPrjPotenceV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjPotenceV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxPrjPotenceV2EN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA:GetObjLstBySP)", objException.Message));
}
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjPotenceV2_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = TransNullToInt(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjPotenceV2DA: GetObjLstBySP)", objException.Message));
}
objQxPrjPotenceV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjPotenceV2EN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjPotenceV2(ref clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where PId = " + ""+ objQxPrjPotenceV2EN.PId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxPrjPotenceV2EN.PId = TransNullToInt(objDT.Rows[0][conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjPotenceV2EN.PotenceName = objDT.Rows[0][conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objQxPrjPotenceV2EN.QxPrjId = objDT.Rows[0][conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceV2EN.FuncModuleId = objDT.Rows[0][conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceV2EN.PotenceTypeId = objDT.Rows[0][conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPrjPotenceV2EN.MenuId = objDT.Rows[0][conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjPotenceV2EN.MenuId4Win = objDT.Rows[0][conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjPotenceV2EN.UpdDate = objDT.Rows[0][conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceV2EN.UpdUserId = objDT.Rows[0][conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceV2EN.Memo = objDT.Rows[0][conQxPrjPotenceV2.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxPrjPotenceV2DA: GetQxPrjPotenceV2)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intPId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxPrjPotenceV2EN GetObjByPId(int intPId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where PId = " + ""+ intPId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
 objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxPrjPotenceV2DA: GetObjByPId)", objException.Message));
}
return objQxPrjPotenceV2EN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxPrjPotenceV2_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjPotenceV2OneBySP(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxPrjPotenceV2EN.PId
};
 objDT = objSQL.ExecSpReturnDT("QxPrjPotenceV2_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxPrjPotenceV2EN.PId = TransNullToInt(objDT.Rows[0][conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjPotenceV2EN.PotenceName = objDT.Rows[0][conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objQxPrjPotenceV2EN.QxPrjId = objDT.Rows[0][conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceV2EN.FuncModuleId = objDT.Rows[0][conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjPotenceV2EN.PotenceTypeId = objDT.Rows[0][conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPrjPotenceV2EN.MenuId = objDT.Rows[0][conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjPotenceV2EN.MenuId4Win = objDT.Rows[0][conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjPotenceV2EN.UpdDate = objDT.Rows[0][conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceV2EN.UpdUserId = objDT.Rows[0][conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjPotenceV2EN.Memo = objDT.Rows[0][conQxPrjPotenceV2.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjPotenceV2EN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN()
{
PId = TransNullToInt(objRow[conQxPrjPotenceV2.PId].ToString().Trim()), //菜单Id
PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(), //权限名称
QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(), //项目Id
FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(), //模块Id
PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(), //权限类型Id
MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(), //菜单Id
MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(), //菜单Id4Win
UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim() //备注
};
objQxPrjPotenceV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjPotenceV2EN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxPrjPotenceV2DA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjPotenceV2EN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjPotenceV2_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN()
{
PId = TransNullToInt(objRow[conQxPrjPotenceV2.PId].ToString().Trim()), //菜单Id
PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(), //权限名称
QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(), //项目Id
FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(), //模块Id
PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(), //权限类型Id
MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(), //菜单Id
MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(), //菜单Id4Win
UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim() //备注
};
objQxPrjPotenceV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjPotenceV2EN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxPrjPotenceV2EN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = TransNullToInt(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxPrjPotenceV2DA: GetObjByDataRowQxPrjPotenceV2)", objException.Message));
}
objQxPrjPotenceV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjPotenceV2EN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxPrjPotenceV2EN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = TransNullToInt(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxPrjPotenceV2DA: GetObjByDataRow)", objException.Message));
}
objQxPrjPotenceV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjPotenceV2EN;
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
objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjPotenceV2EN._CurrTabName, conQxPrjPotenceV2.PId, 4, "");
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
objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjPotenceV2EN._CurrTabName, conQxPrjPotenceV2.PId, 4, strPrefix);
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
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PId from QxPrjPotenceV2 where " + strCondition;
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
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PId from QxPrjPotenceV2 where " + strCondition;
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
 /// <param name = "intPId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(int intPId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjPotenceV2", "PId = " + ""+ intPId+""))
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
 /// <param name = "intPId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(int intPId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
intPId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxPrjPotenceV2_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjPotenceV2", strCondition))
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
objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxPrjPotenceV2");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
 {
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjPotenceV2EN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjPotenceV2");
objRow = objDS.Tables["QxPrjPotenceV2"].NewRow();
objRow[conQxPrjPotenceV2.PotenceName] = objQxPrjPotenceV2EN.PotenceName; //权限名称
objRow[conQxPrjPotenceV2.QxPrjId] = objQxPrjPotenceV2EN.QxPrjId; //项目Id
 if (objQxPrjPotenceV2EN.FuncModuleId !=  "")
 {
objRow[conQxPrjPotenceV2.FuncModuleId] = objQxPrjPotenceV2EN.FuncModuleId; //模块Id
 }
 if (objQxPrjPotenceV2EN.PotenceTypeId !=  "")
 {
objRow[conQxPrjPotenceV2.PotenceTypeId] = objQxPrjPotenceV2EN.PotenceTypeId; //权限类型Id
 }
 if (objQxPrjPotenceV2EN.MenuId !=  "")
 {
objRow[conQxPrjPotenceV2.MenuId] = objQxPrjPotenceV2EN.MenuId; //菜单Id
 }
 if (objQxPrjPotenceV2EN.MenuId4Win !=  "")
 {
objRow[conQxPrjPotenceV2.MenuId4Win] = objQxPrjPotenceV2EN.MenuId4Win; //菜单Id4Win
 }
 if (objQxPrjPotenceV2EN.UpdDate !=  "")
 {
objRow[conQxPrjPotenceV2.UpdDate] = objQxPrjPotenceV2EN.UpdDate; //修改日期
 }
 if (objQxPrjPotenceV2EN.UpdUserId !=  "")
 {
objRow[conQxPrjPotenceV2.UpdUserId] = objQxPrjPotenceV2EN.UpdUserId; //修改用户Id
 }
 if (objQxPrjPotenceV2EN.Memo !=  "")
 {
objRow[conQxPrjPotenceV2.Memo] = objQxPrjPotenceV2EN.Memo; //备注
 }
objDS.Tables[clsQxPrjPotenceV2EN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxPrjPotenceV2EN._CurrTabName);
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
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjPotenceV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxPrjPotenceV2EN.PotenceName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.PotenceName);
 var strPotenceName = objQxPrjPotenceV2EN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceName + "'");
 }
 
 if (objQxPrjPotenceV2EN.QxPrjId  ==  "")
 {
 objQxPrjPotenceV2EN.QxPrjId = null;
 }
 if (objQxPrjPotenceV2EN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.QxPrjId);
 var strQxPrjId = objQxPrjPotenceV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjPotenceV2EN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.FuncModuleId);
 var strFuncModuleId = objQxPrjPotenceV2EN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxPrjPotenceV2EN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceV2EN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceV2EN.PotenceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.PotenceTypeId);
 var strPotenceTypeId = objQxPrjPotenceV2EN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeId + "'");
 }
 
 if (objQxPrjPotenceV2EN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.MenuId);
 var strMenuId = objQxPrjPotenceV2EN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPrjPotenceV2EN.MenuId4Win !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.MenuId4Win);
 var strMenuId4Win = objQxPrjPotenceV2EN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId4Win + "'");
 }
 
 if (objQxPrjPotenceV2EN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.UpdDate);
 var strUpdDate = objQxPrjPotenceV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjPotenceV2EN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.UpdUserId);
 var strUpdUserId = objQxPrjPotenceV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjPotenceV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.Memo);
 var strMemo = objQxPrjPotenceV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjPotenceV2");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjPotenceV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxPrjPotenceV2EN.PotenceName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.PotenceName);
 var strPotenceName = objQxPrjPotenceV2EN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceName + "'");
 }
 
 if (objQxPrjPotenceV2EN.QxPrjId  ==  "")
 {
 objQxPrjPotenceV2EN.QxPrjId = null;
 }
 if (objQxPrjPotenceV2EN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.QxPrjId);
 var strQxPrjId = objQxPrjPotenceV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjPotenceV2EN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.FuncModuleId);
 var strFuncModuleId = objQxPrjPotenceV2EN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxPrjPotenceV2EN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceV2EN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceV2EN.PotenceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.PotenceTypeId);
 var strPotenceTypeId = objQxPrjPotenceV2EN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeId + "'");
 }
 
 if (objQxPrjPotenceV2EN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.MenuId);
 var strMenuId = objQxPrjPotenceV2EN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPrjPotenceV2EN.MenuId4Win !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.MenuId4Win);
 var strMenuId4Win = objQxPrjPotenceV2EN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId4Win + "'");
 }
 
 if (objQxPrjPotenceV2EN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.UpdDate);
 var strUpdDate = objQxPrjPotenceV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjPotenceV2EN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.UpdUserId);
 var strUpdUserId = objQxPrjPotenceV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjPotenceV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.Memo);
 var strMemo = objQxPrjPotenceV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjPotenceV2");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjPotenceV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxPrjPotenceV2EN.PotenceName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.PotenceName);
 var strPotenceName = objQxPrjPotenceV2EN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceName + "'");
 }
 
 if (objQxPrjPotenceV2EN.QxPrjId  ==  "")
 {
 objQxPrjPotenceV2EN.QxPrjId = null;
 }
 if (objQxPrjPotenceV2EN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.QxPrjId);
 var strQxPrjId = objQxPrjPotenceV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjPotenceV2EN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.FuncModuleId);
 var strFuncModuleId = objQxPrjPotenceV2EN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxPrjPotenceV2EN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceV2EN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceV2EN.PotenceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.PotenceTypeId);
 var strPotenceTypeId = objQxPrjPotenceV2EN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeId + "'");
 }
 
 if (objQxPrjPotenceV2EN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.MenuId);
 var strMenuId = objQxPrjPotenceV2EN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPrjPotenceV2EN.MenuId4Win !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.MenuId4Win);
 var strMenuId4Win = objQxPrjPotenceV2EN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId4Win + "'");
 }
 
 if (objQxPrjPotenceV2EN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.UpdDate);
 var strUpdDate = objQxPrjPotenceV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjPotenceV2EN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.UpdUserId);
 var strUpdUserId = objQxPrjPotenceV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjPotenceV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.Memo);
 var strMemo = objQxPrjPotenceV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjPotenceV2");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjPotenceV2EN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxPrjPotenceV2EN.PotenceName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.PotenceName);
 var strPotenceName = objQxPrjPotenceV2EN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceName + "'");
 }
 
 if (objQxPrjPotenceV2EN.QxPrjId  ==  "")
 {
 objQxPrjPotenceV2EN.QxPrjId = null;
 }
 if (objQxPrjPotenceV2EN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.QxPrjId);
 var strQxPrjId = objQxPrjPotenceV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjPotenceV2EN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.FuncModuleId);
 var strFuncModuleId = objQxPrjPotenceV2EN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objQxPrjPotenceV2EN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceV2EN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceV2EN.PotenceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.PotenceTypeId);
 var strPotenceTypeId = objQxPrjPotenceV2EN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPotenceTypeId + "'");
 }
 
 if (objQxPrjPotenceV2EN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.MenuId);
 var strMenuId = objQxPrjPotenceV2EN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPrjPotenceV2EN.MenuId4Win !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.MenuId4Win);
 var strMenuId4Win = objQxPrjPotenceV2EN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId4Win + "'");
 }
 
 if (objQxPrjPotenceV2EN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.UpdDate);
 var strUpdDate = objQxPrjPotenceV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjPotenceV2EN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.UpdUserId);
 var strUpdUserId = objQxPrjPotenceV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjPotenceV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjPotenceV2.Memo);
 var strMemo = objQxPrjPotenceV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjPotenceV2");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxPrjPotenceV2BySP(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
//通过存储过程来
//直接使用
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjPotenceV2EN.PotenceName,
 objQxPrjPotenceV2EN.QxPrjId,
 objQxPrjPotenceV2EN.FuncModuleId,
 objQxPrjPotenceV2EN.PotenceTypeId,
 objQxPrjPotenceV2EN.MenuId,
 objQxPrjPotenceV2EN.MenuId4Win,
 objQxPrjPotenceV2EN.UpdDate,
 objQxPrjPotenceV2EN.UpdUserId,
objQxPrjPotenceV2EN.Memo
};
 objSQL.ExecSP("QxPrjPotenceV2_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxPrjPotenceV2s(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where PId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjPotenceV2");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxPrjPotenceV2EN._CurrTabName ].NewRow();
objRow[conQxPrjPotenceV2.PotenceName] = oRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objRow[conQxPrjPotenceV2.QxPrjId] = oRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxPrjPotenceV2.FuncModuleId] = oRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objRow[conQxPrjPotenceV2.PotenceTypeId] = oRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objRow[conQxPrjPotenceV2.MenuId] = oRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objRow[conQxPrjPotenceV2.MenuId4Win] = oRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objRow[conQxPrjPotenceV2.UpdDate] = oRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objRow[conQxPrjPotenceV2.UpdUserId] = oRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conQxPrjPotenceV2.Memo] = oRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxPrjPotenceV2EN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxPrjPotenceV2EN._CurrTabName);
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
 /// <param name = "objQxPrjPotenceV2EN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceV2EN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjPotenceV2 where PId = " + ""+ objQxPrjPotenceV2EN.PId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxPrjPotenceV2EN._CurrTabName);
if (objDS.Tables[clsQxPrjPotenceV2EN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PId = " + ""+ objQxPrjPotenceV2EN.PId+"");
return false;
}
objRow = objDS.Tables[clsQxPrjPotenceV2EN._CurrTabName].Rows[0];
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.PotenceName))
 {
objRow[conQxPrjPotenceV2.PotenceName] = objQxPrjPotenceV2EN.PotenceName; //权限名称
 }
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.QxPrjId))
 {
objRow[conQxPrjPotenceV2.QxPrjId] = objQxPrjPotenceV2EN.QxPrjId; //项目Id
 }
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.FuncModuleId))
 {
objRow[conQxPrjPotenceV2.FuncModuleId] = objQxPrjPotenceV2EN.FuncModuleId; //模块Id
 }
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.PotenceTypeId))
 {
objRow[conQxPrjPotenceV2.PotenceTypeId] = objQxPrjPotenceV2EN.PotenceTypeId; //权限类型Id
 }
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.MenuId))
 {
objRow[conQxPrjPotenceV2.MenuId] = objQxPrjPotenceV2EN.MenuId; //菜单Id
 }
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.MenuId4Win))
 {
objRow[conQxPrjPotenceV2.MenuId4Win] = objQxPrjPotenceV2EN.MenuId4Win; //菜单Id4Win
 }
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.UpdDate))
 {
objRow[conQxPrjPotenceV2.UpdDate] = objQxPrjPotenceV2EN.UpdDate; //修改日期
 }
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.UpdUserId))
 {
objRow[conQxPrjPotenceV2.UpdUserId] = objQxPrjPotenceV2EN.UpdUserId; //修改用户Id
 }
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.Memo))
 {
objRow[conQxPrjPotenceV2.Memo] = objQxPrjPotenceV2EN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxPrjPotenceV2EN._CurrTabName);
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
public bool UpdateBySP(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceV2EN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjPotenceV2EN.PId,
 objQxPrjPotenceV2EN.PotenceName,
 objQxPrjPotenceV2EN.QxPrjId,
 objQxPrjPotenceV2EN.FuncModuleId,
 objQxPrjPotenceV2EN.PotenceTypeId,
 objQxPrjPotenceV2EN.MenuId,
 objQxPrjPotenceV2EN.MenuId4Win,
 objQxPrjPotenceV2EN.UpdDate,
 objQxPrjPotenceV2EN.UpdUserId,
 objQxPrjPotenceV2EN.Memo
};
 objSQL.ExecSP("QxPrjPotenceV2_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxPrjPotenceV2 Set ");
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.PotenceName))
 {
 if (objQxPrjPotenceV2EN.PotenceName !=  null)
 {
 var strPotenceName = objQxPrjPotenceV2EN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceName, conQxPrjPotenceV2.PotenceName); //权限名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.PotenceName); //权限名称
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.QxPrjId))
 {
 if (objQxPrjPotenceV2EN.QxPrjId  ==  "")
 {
 objQxPrjPotenceV2EN.QxPrjId = null;
 }
 if (objQxPrjPotenceV2EN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjPotenceV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjPotenceV2.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.FuncModuleId))
 {
 if (objQxPrjPotenceV2EN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPrjPotenceV2EN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conQxPrjPotenceV2.FuncModuleId); //模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.FuncModuleId); //模块Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.PotenceTypeId))
 {
 if (objQxPrjPotenceV2EN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceV2EN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceV2EN.PotenceTypeId !=  null)
 {
 var strPotenceTypeId = objQxPrjPotenceV2EN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceTypeId, conQxPrjPotenceV2.PotenceTypeId); //权限类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.PotenceTypeId); //权限类型Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.MenuId))
 {
 if (objQxPrjPotenceV2EN.MenuId !=  null)
 {
 var strMenuId = objQxPrjPotenceV2EN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId, conQxPrjPotenceV2.MenuId); //菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.MenuId); //菜单Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.MenuId4Win))
 {
 if (objQxPrjPotenceV2EN.MenuId4Win !=  null)
 {
 var strMenuId4Win = objQxPrjPotenceV2EN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId4Win, conQxPrjPotenceV2.MenuId4Win); //菜单Id4Win
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.MenuId4Win); //菜单Id4Win
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.UpdDate))
 {
 if (objQxPrjPotenceV2EN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjPotenceV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjPotenceV2.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.UpdUserId))
 {
 if (objQxPrjPotenceV2EN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjPotenceV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjPotenceV2.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.Memo))
 {
 if (objQxPrjPotenceV2EN.Memo !=  null)
 {
 var strMemo = objQxPrjPotenceV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjPotenceV2.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PId = {0}", objQxPrjPotenceV2EN.PId); 
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
 /// <param name = "objQxPrjPotenceV2EN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strCondition)
{
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjPotenceV2 Set ");
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.PotenceName))
 {
 if (objQxPrjPotenceV2EN.PotenceName !=  null)
 {
 var strPotenceName = objQxPrjPotenceV2EN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceName = '{0}',", strPotenceName); //权限名称
 }
 else
 {
 sbSQL.Append(" PotenceName = null,"); //权限名称
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.QxPrjId))
 {
 if (objQxPrjPotenceV2EN.QxPrjId  ==  "")
 {
 objQxPrjPotenceV2EN.QxPrjId = null;
 }
 if (objQxPrjPotenceV2EN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjPotenceV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.FuncModuleId))
 {
 if (objQxPrjPotenceV2EN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPrjPotenceV2EN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //模块Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.PotenceTypeId))
 {
 if (objQxPrjPotenceV2EN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceV2EN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceV2EN.PotenceTypeId !=  null)
 {
 var strPotenceTypeId = objQxPrjPotenceV2EN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceTypeId = '{0}',", strPotenceTypeId); //权限类型Id
 }
 else
 {
 sbSQL.Append(" PotenceTypeId = null,"); //权限类型Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.MenuId))
 {
 if (objQxPrjPotenceV2EN.MenuId !=  null)
 {
 var strMenuId = objQxPrjPotenceV2EN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId = '{0}',", strMenuId); //菜单Id
 }
 else
 {
 sbSQL.Append(" MenuId = null,"); //菜单Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.MenuId4Win))
 {
 if (objQxPrjPotenceV2EN.MenuId4Win !=  null)
 {
 var strMenuId4Win = objQxPrjPotenceV2EN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId4Win = '{0}',", strMenuId4Win); //菜单Id4Win
 }
 else
 {
 sbSQL.Append(" MenuId4Win = null,"); //菜单Id4Win
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.UpdDate))
 {
 if (objQxPrjPotenceV2EN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjPotenceV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.UpdUserId))
 {
 if (objQxPrjPotenceV2EN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjPotenceV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.Memo))
 {
 if (objQxPrjPotenceV2EN.Memo !=  null)
 {
 var strMemo = objQxPrjPotenceV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxPrjPotenceV2EN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjPotenceV2 Set ");
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.PotenceName))
 {
 if (objQxPrjPotenceV2EN.PotenceName !=  null)
 {
 var strPotenceName = objQxPrjPotenceV2EN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceName = '{0}',", strPotenceName); //权限名称
 }
 else
 {
 sbSQL.Append(" PotenceName = null,"); //权限名称
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.QxPrjId))
 {
 if (objQxPrjPotenceV2EN.QxPrjId  ==  "")
 {
 objQxPrjPotenceV2EN.QxPrjId = null;
 }
 if (objQxPrjPotenceV2EN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjPotenceV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.FuncModuleId))
 {
 if (objQxPrjPotenceV2EN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPrjPotenceV2EN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //模块Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.PotenceTypeId))
 {
 if (objQxPrjPotenceV2EN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceV2EN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceV2EN.PotenceTypeId !=  null)
 {
 var strPotenceTypeId = objQxPrjPotenceV2EN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PotenceTypeId = '{0}',", strPotenceTypeId); //权限类型Id
 }
 else
 {
 sbSQL.Append(" PotenceTypeId = null,"); //权限类型Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.MenuId))
 {
 if (objQxPrjPotenceV2EN.MenuId !=  null)
 {
 var strMenuId = objQxPrjPotenceV2EN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId = '{0}',", strMenuId); //菜单Id
 }
 else
 {
 sbSQL.Append(" MenuId = null,"); //菜单Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.MenuId4Win))
 {
 if (objQxPrjPotenceV2EN.MenuId4Win !=  null)
 {
 var strMenuId4Win = objQxPrjPotenceV2EN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId4Win = '{0}',", strMenuId4Win); //菜单Id4Win
 }
 else
 {
 sbSQL.Append(" MenuId4Win = null,"); //菜单Id4Win
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.UpdDate))
 {
 if (objQxPrjPotenceV2EN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjPotenceV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.UpdUserId))
 {
 if (objQxPrjPotenceV2EN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjPotenceV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.Memo))
 {
 if (objQxPrjPotenceV2EN.Memo !=  null)
 {
 var strMemo = objQxPrjPotenceV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjPotenceV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjPotenceV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjPotenceV2 Set ");
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.PotenceName))
 {
 if (objQxPrjPotenceV2EN.PotenceName !=  null)
 {
 var strPotenceName = objQxPrjPotenceV2EN.PotenceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceName, conQxPrjPotenceV2.PotenceName); //权限名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.PotenceName); //权限名称
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.QxPrjId))
 {
 if (objQxPrjPotenceV2EN.QxPrjId  ==  "")
 {
 objQxPrjPotenceV2EN.QxPrjId = null;
 }
 if (objQxPrjPotenceV2EN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjPotenceV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjPotenceV2.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.FuncModuleId))
 {
 if (objQxPrjPotenceV2EN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objQxPrjPotenceV2EN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conQxPrjPotenceV2.FuncModuleId); //模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.FuncModuleId); //模块Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.PotenceTypeId))
 {
 if (objQxPrjPotenceV2EN.PotenceTypeId  ==  "")
 {
 objQxPrjPotenceV2EN.PotenceTypeId = null;
 }
 if (objQxPrjPotenceV2EN.PotenceTypeId !=  null)
 {
 var strPotenceTypeId = objQxPrjPotenceV2EN.PotenceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPotenceTypeId, conQxPrjPotenceV2.PotenceTypeId); //权限类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.PotenceTypeId); //权限类型Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.MenuId))
 {
 if (objQxPrjPotenceV2EN.MenuId !=  null)
 {
 var strMenuId = objQxPrjPotenceV2EN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId, conQxPrjPotenceV2.MenuId); //菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.MenuId); //菜单Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.MenuId4Win))
 {
 if (objQxPrjPotenceV2EN.MenuId4Win !=  null)
 {
 var strMenuId4Win = objQxPrjPotenceV2EN.MenuId4Win.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId4Win, conQxPrjPotenceV2.MenuId4Win); //菜单Id4Win
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.MenuId4Win); //菜单Id4Win
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.UpdDate))
 {
 if (objQxPrjPotenceV2EN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjPotenceV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjPotenceV2.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.UpdUserId))
 {
 if (objQxPrjPotenceV2EN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjPotenceV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjPotenceV2.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjPotenceV2EN.IsUpdated(conQxPrjPotenceV2.Memo))
 {
 if (objQxPrjPotenceV2EN.Memo !=  null)
 {
 var strMemo = objQxPrjPotenceV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjPotenceV2.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjPotenceV2.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PId = {0}", objQxPrjPotenceV2EN.PId); 
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
 /// <param name = "intPId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intPId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 intPId,
};
 objSQL.ExecSP("QxPrjPotenceV2_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "intPId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(int intPId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
//删除QxPrjPotenceV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjPotenceV2 where PId = " + ""+ intPId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxPrjPotenceV2(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
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
//删除QxPrjPotenceV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjPotenceV2 where PId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "intPId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(int intPId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
//删除QxPrjPotenceV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjPotenceV2 where PId = " + ""+ intPId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxPrjPotenceV2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: DelQxPrjPotenceV2)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjPotenceV2 where " + strCondition ;
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
public bool DelQxPrjPotenceV2WithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2DA: DelQxPrjPotenceV2WithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjPotenceV2 where " + strCondition ;
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
 /// <param name = "objQxPrjPotenceV2ENS">源对象</param>
 /// <param name = "objQxPrjPotenceV2ENT">目标对象</param>
public void CopyTo(clsQxPrjPotenceV2EN objQxPrjPotenceV2ENS, clsQxPrjPotenceV2EN objQxPrjPotenceV2ENT)
{
objQxPrjPotenceV2ENT.PId = objQxPrjPotenceV2ENS.PId; //菜单Id
objQxPrjPotenceV2ENT.PotenceName = objQxPrjPotenceV2ENS.PotenceName; //权限名称
objQxPrjPotenceV2ENT.QxPrjId = objQxPrjPotenceV2ENS.QxPrjId; //项目Id
objQxPrjPotenceV2ENT.FuncModuleId = objQxPrjPotenceV2ENS.FuncModuleId; //模块Id
objQxPrjPotenceV2ENT.PotenceTypeId = objQxPrjPotenceV2ENS.PotenceTypeId; //权限类型Id
objQxPrjPotenceV2ENT.MenuId = objQxPrjPotenceV2ENS.MenuId; //菜单Id
objQxPrjPotenceV2ENT.MenuId4Win = objQxPrjPotenceV2ENS.MenuId4Win; //菜单Id4Win
objQxPrjPotenceV2ENT.UpdDate = objQxPrjPotenceV2ENS.UpdDate; //修改日期
objQxPrjPotenceV2ENT.UpdUserId = objQxPrjPotenceV2ENS.UpdUserId; //修改用户Id
objQxPrjPotenceV2ENT.Memo = objQxPrjPotenceV2ENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxPrjPotenceV2EN.PotenceName, conQxPrjPotenceV2.PotenceName);
clsCheckSql.CheckFieldNotNull(objQxPrjPotenceV2EN.QxPrjId, conQxPrjPotenceV2.QxPrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.PotenceName, 200, conQxPrjPotenceV2.PotenceName);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.QxPrjId, 4, conQxPrjPotenceV2.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.FuncModuleId, 4, conQxPrjPotenceV2.FuncModuleId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.PotenceTypeId, 6, conQxPrjPotenceV2.PotenceTypeId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.MenuId, 8, conQxPrjPotenceV2.MenuId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.MenuId4Win, 8, conQxPrjPotenceV2.MenuId4Win);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.UpdDate, 20, conQxPrjPotenceV2.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.UpdUserId, 20, conQxPrjPotenceV2.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.Memo, 1000, conQxPrjPotenceV2.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceV2EN.QxPrjId, 4, conQxPrjPotenceV2.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceV2EN.PotenceTypeId, 6, conQxPrjPotenceV2.PotenceTypeId);
 objQxPrjPotenceV2EN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.PotenceName, 200, conQxPrjPotenceV2.PotenceName);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.QxPrjId, 4, conQxPrjPotenceV2.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.FuncModuleId, 4, conQxPrjPotenceV2.FuncModuleId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.PotenceTypeId, 6, conQxPrjPotenceV2.PotenceTypeId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.MenuId, 8, conQxPrjPotenceV2.MenuId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.MenuId4Win, 8, conQxPrjPotenceV2.MenuId4Win);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.UpdDate, 20, conQxPrjPotenceV2.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.UpdUserId, 20, conQxPrjPotenceV2.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.Memo, 1000, conQxPrjPotenceV2.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceV2EN.QxPrjId, 4, conQxPrjPotenceV2.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceV2EN.PotenceTypeId, 6, conQxPrjPotenceV2.PotenceTypeId);
 objQxPrjPotenceV2EN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.PotenceName, 200, conQxPrjPotenceV2.PotenceName);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.QxPrjId, 4, conQxPrjPotenceV2.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.FuncModuleId, 4, conQxPrjPotenceV2.FuncModuleId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.PotenceTypeId, 6, conQxPrjPotenceV2.PotenceTypeId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.MenuId, 8, conQxPrjPotenceV2.MenuId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.MenuId4Win, 8, conQxPrjPotenceV2.MenuId4Win);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.UpdDate, 20, conQxPrjPotenceV2.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.UpdUserId, 20, conQxPrjPotenceV2.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjPotenceV2EN.Memo, 1000, conQxPrjPotenceV2.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceV2EN.PotenceName, conQxPrjPotenceV2.PotenceName);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceV2EN.QxPrjId, conQxPrjPotenceV2.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceV2EN.FuncModuleId, conQxPrjPotenceV2.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceV2EN.PotenceTypeId, conQxPrjPotenceV2.PotenceTypeId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceV2EN.MenuId, conQxPrjPotenceV2.MenuId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceV2EN.MenuId4Win, conQxPrjPotenceV2.MenuId4Win);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceV2EN.UpdDate, conQxPrjPotenceV2.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceV2EN.UpdUserId, conQxPrjPotenceV2.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjPotenceV2EN.Memo, conQxPrjPotenceV2.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceV2EN.QxPrjId, 4, conQxPrjPotenceV2.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjPotenceV2EN.PotenceTypeId, 6, conQxPrjPotenceV2.PotenceTypeId);
 objQxPrjPotenceV2EN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPId()
{
//获取某学院所有专业信息
string strSQL = "select PId, PotenceName from QxPrjPotenceV2 ";
 clsSpecSQLforSql mySql = clsQxPrjPotenceV2DA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxPrjPotenceV2(工程权限V2),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PotenceName = '{0}'", objQxPrjPotenceV2EN.PotenceName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjPotenceV2EN.QxPrjId);
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
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
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
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
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
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjPotenceV2EN._CurrTabName);
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
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjPotenceV2EN._CurrTabName, strCondition);
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
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
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
 objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}