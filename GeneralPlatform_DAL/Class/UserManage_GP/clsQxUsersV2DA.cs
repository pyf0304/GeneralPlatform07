
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersV2DA
 表名:QxUsersV2(00140110)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:01:19
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
 /// 用户V2(QxUsersV2)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxUsersV2DA : clsCommBase4DA
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
 return clsQxUsersV2EN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxUsersV2EN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUsersV2EN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxUsersV2EN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxUsersV2EN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
 strSQL = "Select * from QxUsersV2 where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxUsersV2");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxUsersV2_SelectByCond",values, "QxUsersV2");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUsersV2 where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxUsersV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUsersV2 a where {0} And a.id not in (Select Top {2} id From QxUsersV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUsersV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUsersV2 a where {0} And a.id not in (Select Top {2} id From QxUsersV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUsersV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUsersV2 a where {0} And a.id not in (Select Top {2} id From QxUsersV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUsersV2");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxUsersV2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTable_QxUsersV2)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsersV2 where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsersV2 where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUsersV2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUsersV2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUsersV2.* from QxUsersV2 Left Join {1} on {2} where {3} and QxUsersV2.id not in (Select top {5} QxUsersV2.id from QxUsersV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsersV2 where {1} and id not in (Select top {2} id from QxUsersV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsersV2 where {1} and id not in (Select top {3} id from QxUsersV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUsersV2.* from QxUsersV2 Left Join {1} on {2} where {3} and QxUsersV2.id not in (Select top {5} QxUsersV2.id from QxUsersV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsersV2 where {1} and id not in (Select top {2} id from QxUsersV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsersV2 where {1} and id not in (Select top {3} id from QxUsersV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUsersV2.* from QxUsersV2 Left Join {1} on {2} where {3} and QxUsersV2.id not in (Select top {5} QxUsersV2.id from QxUsersV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsersV2 where {1} and id not in (Select top {2} id from QxUsersV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsersV2 where {1} and id not in (Select top {3} id from QxUsersV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUsersV2 a where {0} And a.id not in (Select Top {2} id From QxUsersV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUsersV2 a where {0} And a.id not in (Select Top {2} id From QxUsersV2 Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUsersV2 a where {0} And a.id not in (Select Top {2} id From QxUsersV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUsersV2 a where {0} And a.id not in (Select Top {2} id From QxUsersV2 Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersV2DA: GetQxUsersV2ByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUsersV2_SelectByCond",values);
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
public List<clsQxUsersV2EN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxUsersV2DA:GetObjLst)", objException.Message));
}
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = TransNullToInt(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = TransNullToInt(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = TransNullToBool(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUsersV2DA: GetObjLst)", objException.Message));
}
objQxUsersV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUsersV2EN);
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
public List<clsQxUsersV2EN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxUsersV2DA:GetObjLstByTabName)", objException.Message));
}
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = TransNullToInt(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = TransNullToInt(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = TransNullToBool(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUsersV2DA: GetObjLst)", objException.Message));
}
objQxUsersV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUsersV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxUsersV2EN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxUsersV2DA:GetObjLstBySP)", objException.Message));
}
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUsersV2_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = TransNullToInt(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = TransNullToInt(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = TransNullToBool(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxUsersV2DA: GetObjLstBySP)", objException.Message));
}
objQxUsersV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUsersV2EN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUsersV2(ref clsQxUsersV2EN objQxUsersV2EN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where id = " + ""+ objQxUsersV2EN.id+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxUsersV2EN.CreateTime = objDT.Rows[0][conQxUsersV2.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersV2EN.updateTime = objDT.Rows[0][conQxUsersV2.updateTime].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersV2EN.id = TransNullToInt(objDT.Rows[0][conQxUsersV2.id].ToString().Trim()); //id(字段类型:int,字段长度:4,是否可空:False)
 objQxUsersV2EN.DepartmentIdInt = TransNullToInt(objDT.Rows[0][conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id(字段类型:int,字段长度:4,是否可空:False)
 objQxUsersV2EN.name = objDT.Rows[0][conQxUsersV2.name].ToString().Trim(); //姓名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsersV2EN.UserName = objDT.Rows[0][conQxUsersV2.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsersV2EN.Password = objDT.Rows[0][conQxUsersV2.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersV2EN.psalt = objDT.Rows[0][conQxUsersV2.psalt].ToString().Trim(); //密码盐值(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersV2EN.nickName = objDT.Rows[0][conQxUsersV2.nickName].ToString().Trim(); //呢称(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersV2EN.headImg = objDT.Rows[0][conQxUsersV2.headImg].ToString().Trim(); //头像(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersV2EN.Email = objDT.Rows[0][conQxUsersV2.Email].ToString().Trim(); //邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersV2EN.phone = objDT.Rows[0][conQxUsersV2.phone].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objQxUsersV2EN.remark = objDT.Rows[0][conQxUsersV2.remark].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxUsersV2EN.status = TransNullToInt(objDT.Rows[0][conQxUsersV2.status].ToString().Trim()); //用户状态Id(字段类型:int,字段长度:4,是否可空:False)
 objQxUsersV2EN.OpenId = objDT.Rows[0][conQxUsersV2.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objQxUsersV2EN.UpdUser = objDT.Rows[0][conQxUsersV2.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersV2EN.IsArchive = TransNullToBool(objDT.Rows[0][conQxUsersV2.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsersV2EN.IdentityId = objDT.Rows[0][conQxUsersV2.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objQxUsersV2EN.StuTeacherId = objDT.Rows[0][conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersV2EN.EffitiveBeginDate = objDT.Rows[0][conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersV2EN.EffitiveEndDate = objDT.Rows[0][conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersV2EN.UserId = objDT.Rows[0][conQxUsersV2.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUsersV2EN.EffectiveDate = objDT.Rows[0][conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期(字段类型:varchar,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxUsersV2DA: GetQxUsersV2)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intid">表关键字</param>
 /// <returns>表对象</returns>
public clsQxUsersV2EN GetObjByid(int intid)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where id = " + ""+ intid+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
 objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id(字段类型:int,字段长度:4,是否可空:False)
 objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id(字段类型:int,字段长度:4,是否可空:False)
 objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id(字段类型:int,字段长度:4,是否可空:False)
 objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期(字段类型:varchar,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxUsersV2DA: GetObjByid)", objException.Message));
}
return objQxUsersV2EN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxUsersV2_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUsersV2OneBySP(clsQxUsersV2EN objQxUsersV2EN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxUsersV2EN.id
};
 objDT = objSQL.ExecSpReturnDT("QxUsersV2_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxUsersV2EN.CreateTime = objDT.Rows[0][conQxUsersV2.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersV2EN.updateTime = objDT.Rows[0][conQxUsersV2.updateTime].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersV2EN.id = TransNullToInt(objDT.Rows[0][conQxUsersV2.id].ToString().Trim()); //id(字段类型:int,字段长度:4,是否可空:False)
 objQxUsersV2EN.DepartmentIdInt = TransNullToInt(objDT.Rows[0][conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id(字段类型:int,字段长度:4,是否可空:False)
 objQxUsersV2EN.name = objDT.Rows[0][conQxUsersV2.name].ToString().Trim(); //姓名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsersV2EN.UserName = objDT.Rows[0][conQxUsersV2.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsersV2EN.Password = objDT.Rows[0][conQxUsersV2.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersV2EN.psalt = objDT.Rows[0][conQxUsersV2.psalt].ToString().Trim(); //密码盐值(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersV2EN.nickName = objDT.Rows[0][conQxUsersV2.nickName].ToString().Trim(); //呢称(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersV2EN.headImg = objDT.Rows[0][conQxUsersV2.headImg].ToString().Trim(); //头像(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersV2EN.Email = objDT.Rows[0][conQxUsersV2.Email].ToString().Trim(); //邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersV2EN.phone = objDT.Rows[0][conQxUsersV2.phone].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objQxUsersV2EN.remark = objDT.Rows[0][conQxUsersV2.remark].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxUsersV2EN.status = TransNullToInt(objDT.Rows[0][conQxUsersV2.status].ToString().Trim()); //用户状态Id(字段类型:int,字段长度:4,是否可空:False)
 objQxUsersV2EN.OpenId = objDT.Rows[0][conQxUsersV2.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objQxUsersV2EN.UpdUser = objDT.Rows[0][conQxUsersV2.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersV2EN.IsArchive = TransNullToBool(objDT.Rows[0][conQxUsersV2.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsersV2EN.IdentityId = objDT.Rows[0][conQxUsersV2.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objQxUsersV2EN.StuTeacherId = objDT.Rows[0][conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersV2EN.EffitiveBeginDate = objDT.Rows[0][conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersV2EN.EffitiveEndDate = objDT.Rows[0][conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersV2EN.UserId = objDT.Rows[0][conQxUsersV2.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUsersV2EN.EffectiveDate = objDT.Rows[0][conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期(字段类型:varchar,字段长度:8,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUsersV2EN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxUsersV2DA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN()
{
CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(), //建立时间
updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(), //修改时间
id = TransNullToInt(objRow[conQxUsersV2.id].ToString().Trim()), //id
DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()), //部门Id
name = objRow[conQxUsersV2.name].ToString().Trim(), //姓名
UserName = objRow[conQxUsersV2.UserName].ToString().Trim(), //用户名
Password = objRow[conQxUsersV2.Password].ToString().Trim(), //口令
psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(), //密码盐值
nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(), //呢称
headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(), //头像
Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(), //邮箱
phone = objRow[conQxUsersV2.phone].ToString().Trim(), //电话号码
remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(), //备注
status = TransNullToInt(objRow[conQxUsersV2.status].ToString().Trim()), //用户状态Id
OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(), //微信openid
UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(), //修改用户
IsArchive = TransNullToBool(objRow[conQxUsersV2.IsArchive].ToString().Trim()), //是否存档
IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(), //身份编号
StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(), //学工号
EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(), //有效结束日期
UserId = objRow[conQxUsersV2.UserId].ToString().Trim(), //用户ID
EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim() //有效日期
};
objQxUsersV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsersV2EN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxUsersV2DA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUsersV2EN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxUsersV2DA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUsersV2_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN()
{
CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(), //建立时间
updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(), //修改时间
id = TransNullToInt(objRow[conQxUsersV2.id].ToString().Trim()), //id
DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()), //部门Id
name = objRow[conQxUsersV2.name].ToString().Trim(), //姓名
UserName = objRow[conQxUsersV2.UserName].ToString().Trim(), //用户名
Password = objRow[conQxUsersV2.Password].ToString().Trim(), //口令
psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(), //密码盐值
nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(), //呢称
headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(), //头像
Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(), //邮箱
phone = objRow[conQxUsersV2.phone].ToString().Trim(), //电话号码
remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(), //备注
status = TransNullToInt(objRow[conQxUsersV2.status].ToString().Trim()), //用户状态Id
OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(), //微信openid
UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(), //修改用户
IsArchive = TransNullToBool(objRow[conQxUsersV2.IsArchive].ToString().Trim()), //是否存档
IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(), //身份编号
StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(), //学工号
EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(), //有效结束日期
UserId = objRow[conQxUsersV2.UserId].ToString().Trim(), //用户ID
EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim() //有效日期
};
objQxUsersV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsersV2EN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxUsersV2EN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = TransNullToInt(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = TransNullToInt(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = TransNullToBool(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxUsersV2DA: GetObjByDataRowQxUsersV2)", objException.Message));
}
objQxUsersV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsersV2EN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxUsersV2EN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = TransNullToInt(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = TransNullToInt(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = TransNullToBool(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxUsersV2DA: GetObjByDataRow)", objException.Message));
}
objQxUsersV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsersV2EN;
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
objSQL = clsQxUsersV2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUsersV2EN._CurrTabName, conQxUsersV2.id, 4, "");
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
objSQL = clsQxUsersV2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUsersV2EN._CurrTabName, conQxUsersV2.id, 4, strPrefix);
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
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select id from QxUsersV2 where " + strCondition;
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
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select id from QxUsersV2 where " + strCondition;
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
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(int intid)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUsersV2", "id = " + ""+ intid+""))
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
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(int intid)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
intid,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxUsersV2_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxUsersV2DA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUsersV2", strCondition))
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
objSQL = clsQxUsersV2DA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxUsersV2");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxUsersV2EN objQxUsersV2EN)
 {
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsersV2EN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUsersV2");
objRow = objDS.Tables["QxUsersV2"].NewRow();
 if (objQxUsersV2EN.CreateTime !=  "")
 {
objRow[conQxUsersV2.CreateTime] = objQxUsersV2EN.CreateTime; //建立时间
 }
 if (objQxUsersV2EN.updateTime !=  "")
 {
objRow[conQxUsersV2.updateTime] = objQxUsersV2EN.updateTime; //修改时间
 }
objRow[conQxUsersV2.DepartmentIdInt] = objQxUsersV2EN.DepartmentIdInt; //部门Id
objRow[conQxUsersV2.name] = objQxUsersV2EN.name; //姓名
objRow[conQxUsersV2.UserName] = objQxUsersV2EN.UserName; //用户名
objRow[conQxUsersV2.Password] = objQxUsersV2EN.Password; //口令
 if (objQxUsersV2EN.psalt !=  "")
 {
objRow[conQxUsersV2.psalt] = objQxUsersV2EN.psalt; //密码盐值
 }
 if (objQxUsersV2EN.nickName !=  "")
 {
objRow[conQxUsersV2.nickName] = objQxUsersV2EN.nickName; //呢称
 }
 if (objQxUsersV2EN.headImg !=  "")
 {
objRow[conQxUsersV2.headImg] = objQxUsersV2EN.headImg; //头像
 }
 if (objQxUsersV2EN.Email !=  "")
 {
objRow[conQxUsersV2.Email] = objQxUsersV2EN.Email; //邮箱
 }
objRow[conQxUsersV2.phone] = objQxUsersV2EN.phone; //电话号码
 if (objQxUsersV2EN.remark !=  "")
 {
objRow[conQxUsersV2.remark] = objQxUsersV2EN.remark; //备注
 }
objRow[conQxUsersV2.status] = objQxUsersV2EN.status; //用户状态Id
 if (objQxUsersV2EN.OpenId !=  "")
 {
objRow[conQxUsersV2.OpenId] = objQxUsersV2EN.OpenId; //微信openid
 }
 if (objQxUsersV2EN.UpdUser !=  "")
 {
objRow[conQxUsersV2.UpdUser] = objQxUsersV2EN.UpdUser; //修改用户
 }
objRow[conQxUsersV2.IsArchive] = objQxUsersV2EN.IsArchive; //是否存档
 if (objQxUsersV2EN.IdentityId !=  "")
 {
objRow[conQxUsersV2.IdentityId] = objQxUsersV2EN.IdentityId; //身份编号
 }
 if (objQxUsersV2EN.StuTeacherId !=  "")
 {
objRow[conQxUsersV2.StuTeacherId] = objQxUsersV2EN.StuTeacherId; //学工号
 }
 if (objQxUsersV2EN.EffitiveBeginDate !=  "")
 {
objRow[conQxUsersV2.EffitiveBeginDate] = objQxUsersV2EN.EffitiveBeginDate; //有效开始日期
 }
 if (objQxUsersV2EN.EffitiveEndDate !=  "")
 {
objRow[conQxUsersV2.EffitiveEndDate] = objQxUsersV2EN.EffitiveEndDate; //有效结束日期
 }
objRow[conQxUsersV2.UserId] = objQxUsersV2EN.UserId; //用户ID
 if (objQxUsersV2EN.EffectiveDate !=  "")
 {
objRow[conQxUsersV2.EffectiveDate] = objQxUsersV2EN.EffectiveDate; //有效日期
 }
objDS.Tables[clsQxUsersV2EN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxUsersV2EN._CurrTabName);
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
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUsersV2EN objQxUsersV2EN)
{
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsersV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUsersV2EN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.CreateTime);
 var strCreateTime = objQxUsersV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objQxUsersV2EN.updateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.updateTime);
 var strupdateTime = objQxUsersV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdateTime + "'");
 }
 
 
 if (objQxUsersV2EN.DepartmentIdInt !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.DepartmentIdInt);
 arrValueListForInsert.Add(objQxUsersV2EN.DepartmentIdInt.ToString());
 }
 
 if (objQxUsersV2EN.name !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.name);
 var strname = objQxUsersV2EN.name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strname + "'");
 }
 
 if (objQxUsersV2EN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UserName);
 var strUserName = objQxUsersV2EN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsersV2EN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.Password);
 var strPassword = objQxUsersV2EN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsersV2EN.psalt !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.psalt);
 var strpsalt = objQxUsersV2EN.psalt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strpsalt + "'");
 }
 
 if (objQxUsersV2EN.nickName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.nickName);
 var strnickName = objQxUsersV2EN.nickName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strnickName + "'");
 }
 
 if (objQxUsersV2EN.headImg !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.headImg);
 var strheadImg = objQxUsersV2EN.headImg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strheadImg + "'");
 }
 
 if (objQxUsersV2EN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.Email);
 var strEmail = objQxUsersV2EN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objQxUsersV2EN.phone !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.phone);
 var strphone = objQxUsersV2EN.phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strphone + "'");
 }
 
 if (objQxUsersV2EN.remark !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.remark);
 var strremark = objQxUsersV2EN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsersV2.status);
 arrValueListForInsert.Add(objQxUsersV2EN.status.ToString());
 
 if (objQxUsersV2EN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.OpenId);
 var strOpenId = objQxUsersV2EN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsersV2EN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UpdUser);
 var strUpdUser = objQxUsersV2EN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsersV2.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsersV2EN.IsArchive  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersV2EN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.IdentityId);
 var strIdentityId = objQxUsersV2EN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 if (objQxUsersV2EN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.StuTeacherId);
 var strStuTeacherId = objQxUsersV2EN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsersV2EN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsersV2EN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsersV2EN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsersV2EN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsersV2EN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UserId);
 var strUserId = objQxUsersV2EN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsersV2EN.EffectiveDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffectiveDate);
 var strEffectiveDate = objQxUsersV2EN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffectiveDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsersV2");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUsersV2EN objQxUsersV2EN)
{
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsersV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUsersV2EN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.CreateTime);
 var strCreateTime = objQxUsersV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objQxUsersV2EN.updateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.updateTime);
 var strupdateTime = objQxUsersV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdateTime + "'");
 }
 
 
 if (objQxUsersV2EN.DepartmentIdInt !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.DepartmentIdInt);
 arrValueListForInsert.Add(objQxUsersV2EN.DepartmentIdInt.ToString());
 }
 
 if (objQxUsersV2EN.name !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.name);
 var strname = objQxUsersV2EN.name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strname + "'");
 }
 
 if (objQxUsersV2EN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UserName);
 var strUserName = objQxUsersV2EN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsersV2EN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.Password);
 var strPassword = objQxUsersV2EN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsersV2EN.psalt !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.psalt);
 var strpsalt = objQxUsersV2EN.psalt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strpsalt + "'");
 }
 
 if (objQxUsersV2EN.nickName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.nickName);
 var strnickName = objQxUsersV2EN.nickName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strnickName + "'");
 }
 
 if (objQxUsersV2EN.headImg !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.headImg);
 var strheadImg = objQxUsersV2EN.headImg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strheadImg + "'");
 }
 
 if (objQxUsersV2EN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.Email);
 var strEmail = objQxUsersV2EN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objQxUsersV2EN.phone !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.phone);
 var strphone = objQxUsersV2EN.phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strphone + "'");
 }
 
 if (objQxUsersV2EN.remark !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.remark);
 var strremark = objQxUsersV2EN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsersV2.status);
 arrValueListForInsert.Add(objQxUsersV2EN.status.ToString());
 
 if (objQxUsersV2EN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.OpenId);
 var strOpenId = objQxUsersV2EN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsersV2EN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UpdUser);
 var strUpdUser = objQxUsersV2EN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsersV2.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsersV2EN.IsArchive  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersV2EN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.IdentityId);
 var strIdentityId = objQxUsersV2EN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 if (objQxUsersV2EN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.StuTeacherId);
 var strStuTeacherId = objQxUsersV2EN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsersV2EN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsersV2EN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsersV2EN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsersV2EN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsersV2EN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UserId);
 var strUserId = objQxUsersV2EN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsersV2EN.EffectiveDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffectiveDate);
 var strEffectiveDate = objQxUsersV2EN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffectiveDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsersV2");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUsersV2EN objQxUsersV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsersV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUsersV2EN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.CreateTime);
 var strCreateTime = objQxUsersV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objQxUsersV2EN.updateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.updateTime);
 var strupdateTime = objQxUsersV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdateTime + "'");
 }
 
 
 if (objQxUsersV2EN.DepartmentIdInt !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.DepartmentIdInt);
 arrValueListForInsert.Add(objQxUsersV2EN.DepartmentIdInt.ToString());
 }
 
 if (objQxUsersV2EN.name !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.name);
 var strname = objQxUsersV2EN.name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strname + "'");
 }
 
 if (objQxUsersV2EN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UserName);
 var strUserName = objQxUsersV2EN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsersV2EN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.Password);
 var strPassword = objQxUsersV2EN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsersV2EN.psalt !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.psalt);
 var strpsalt = objQxUsersV2EN.psalt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strpsalt + "'");
 }
 
 if (objQxUsersV2EN.nickName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.nickName);
 var strnickName = objQxUsersV2EN.nickName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strnickName + "'");
 }
 
 if (objQxUsersV2EN.headImg !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.headImg);
 var strheadImg = objQxUsersV2EN.headImg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strheadImg + "'");
 }
 
 if (objQxUsersV2EN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.Email);
 var strEmail = objQxUsersV2EN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objQxUsersV2EN.phone !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.phone);
 var strphone = objQxUsersV2EN.phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strphone + "'");
 }
 
 if (objQxUsersV2EN.remark !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.remark);
 var strremark = objQxUsersV2EN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsersV2.status);
 arrValueListForInsert.Add(objQxUsersV2EN.status.ToString());
 
 if (objQxUsersV2EN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.OpenId);
 var strOpenId = objQxUsersV2EN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsersV2EN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UpdUser);
 var strUpdUser = objQxUsersV2EN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsersV2.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsersV2EN.IsArchive  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersV2EN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.IdentityId);
 var strIdentityId = objQxUsersV2EN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 if (objQxUsersV2EN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.StuTeacherId);
 var strStuTeacherId = objQxUsersV2EN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsersV2EN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsersV2EN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsersV2EN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsersV2EN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsersV2EN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UserId);
 var strUserId = objQxUsersV2EN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsersV2EN.EffectiveDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffectiveDate);
 var strEffectiveDate = objQxUsersV2EN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffectiveDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsersV2");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUsersV2EN objQxUsersV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsersV2EN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUsersV2EN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.CreateTime);
 var strCreateTime = objQxUsersV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objQxUsersV2EN.updateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.updateTime);
 var strupdateTime = objQxUsersV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdateTime + "'");
 }
 
 
 if (objQxUsersV2EN.DepartmentIdInt !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.DepartmentIdInt);
 arrValueListForInsert.Add(objQxUsersV2EN.DepartmentIdInt.ToString());
 }
 
 if (objQxUsersV2EN.name !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.name);
 var strname = objQxUsersV2EN.name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strname + "'");
 }
 
 if (objQxUsersV2EN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UserName);
 var strUserName = objQxUsersV2EN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsersV2EN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.Password);
 var strPassword = objQxUsersV2EN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsersV2EN.psalt !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.psalt);
 var strpsalt = objQxUsersV2EN.psalt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strpsalt + "'");
 }
 
 if (objQxUsersV2EN.nickName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.nickName);
 var strnickName = objQxUsersV2EN.nickName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strnickName + "'");
 }
 
 if (objQxUsersV2EN.headImg !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.headImg);
 var strheadImg = objQxUsersV2EN.headImg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strheadImg + "'");
 }
 
 if (objQxUsersV2EN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.Email);
 var strEmail = objQxUsersV2EN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objQxUsersV2EN.phone !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.phone);
 var strphone = objQxUsersV2EN.phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strphone + "'");
 }
 
 if (objQxUsersV2EN.remark !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.remark);
 var strremark = objQxUsersV2EN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsersV2.status);
 arrValueListForInsert.Add(objQxUsersV2EN.status.ToString());
 
 if (objQxUsersV2EN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.OpenId);
 var strOpenId = objQxUsersV2EN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsersV2EN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UpdUser);
 var strUpdUser = objQxUsersV2EN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsersV2.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsersV2EN.IsArchive  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersV2EN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.IdentityId);
 var strIdentityId = objQxUsersV2EN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 if (objQxUsersV2EN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.StuTeacherId);
 var strStuTeacherId = objQxUsersV2EN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsersV2EN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsersV2EN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsersV2EN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsersV2EN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsersV2EN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.UserId);
 var strUserId = objQxUsersV2EN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsersV2EN.EffectiveDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsersV2.EffectiveDate);
 var strEffectiveDate = objQxUsersV2EN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffectiveDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsersV2");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxUsersV2BySP(clsQxUsersV2EN objQxUsersV2EN)
{
//通过存储过程来
//直接使用
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUsersV2EN.CreateTime,
 objQxUsersV2EN.updateTime,
 objQxUsersV2EN.DepartmentIdInt,
 objQxUsersV2EN.name,
 objQxUsersV2EN.UserName,
 objQxUsersV2EN.Password,
 objQxUsersV2EN.psalt,
 objQxUsersV2EN.nickName,
 objQxUsersV2EN.headImg,
 objQxUsersV2EN.Email,
 objQxUsersV2EN.phone,
 objQxUsersV2EN.remark,
 objQxUsersV2EN.status,
 objQxUsersV2EN.OpenId,
 objQxUsersV2EN.UpdUser,
 objQxUsersV2EN.IsArchive,
 objQxUsersV2EN.IdentityId,
 objQxUsersV2EN.StuTeacherId,
 objQxUsersV2EN.EffitiveBeginDate,
 objQxUsersV2EN.EffitiveEndDate,
 objQxUsersV2EN.UserId,
objQxUsersV2EN.EffectiveDate
};
 objSQL.ExecSP("QxUsersV2_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxUsersV2s(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where id = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUsersV2");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
int intid = TransNullToInt(oRow[conQxUsersV2.id].ToString().Trim());
if (IsExist(intid))
{
 string strResult = "关键字变量值为:" + string.Format("id = {0}", intid) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxUsersV2EN._CurrTabName ].NewRow();
objRow[conQxUsersV2.CreateTime] = oRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objRow[conQxUsersV2.updateTime] = oRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objRow[conQxUsersV2.DepartmentIdInt] = oRow[conQxUsersV2.DepartmentIdInt].ToString().Trim(); //部门Id
objRow[conQxUsersV2.name] = oRow[conQxUsersV2.name].ToString().Trim(); //姓名
objRow[conQxUsersV2.UserName] = oRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objRow[conQxUsersV2.Password] = oRow[conQxUsersV2.Password].ToString().Trim(); //口令
objRow[conQxUsersV2.psalt] = oRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objRow[conQxUsersV2.nickName] = oRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objRow[conQxUsersV2.headImg] = oRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objRow[conQxUsersV2.Email] = oRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objRow[conQxUsersV2.phone] = oRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objRow[conQxUsersV2.remark] = oRow[conQxUsersV2.remark].ToString().Trim(); //备注
objRow[conQxUsersV2.status] = oRow[conQxUsersV2.status].ToString().Trim(); //用户状态Id
objRow[conQxUsersV2.OpenId] = oRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objRow[conQxUsersV2.UpdUser] = oRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objRow[conQxUsersV2.IsArchive] = oRow[conQxUsersV2.IsArchive].ToString().Trim(); //是否存档
objRow[conQxUsersV2.IdentityId] = oRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objRow[conQxUsersV2.StuTeacherId] = oRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objRow[conQxUsersV2.EffitiveBeginDate] = oRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objRow[conQxUsersV2.EffitiveEndDate] = oRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objRow[conQxUsersV2.UserId] = oRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objRow[conQxUsersV2.EffectiveDate] = oRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
 objDS.Tables[clsQxUsersV2EN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxUsersV2EN._CurrTabName);
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
 /// <param name = "objQxUsersV2EN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxUsersV2EN objQxUsersV2EN)
{
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersV2EN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
strSQL = "Select * from QxUsersV2 where id = " + ""+ objQxUsersV2EN.id+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxUsersV2EN._CurrTabName);
if (objDS.Tables[clsQxUsersV2EN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:id = " + ""+ objQxUsersV2EN.id+"");
return false;
}
objRow = objDS.Tables[clsQxUsersV2EN._CurrTabName].Rows[0];
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.CreateTime))
 {
objRow[conQxUsersV2.CreateTime] = objQxUsersV2EN.CreateTime; //建立时间
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.updateTime))
 {
objRow[conQxUsersV2.updateTime] = objQxUsersV2EN.updateTime; //修改时间
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.DepartmentIdInt))
 {
objRow[conQxUsersV2.DepartmentIdInt] = objQxUsersV2EN.DepartmentIdInt; //部门Id
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.name))
 {
objRow[conQxUsersV2.name] = objQxUsersV2EN.name; //姓名
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UserName))
 {
objRow[conQxUsersV2.UserName] = objQxUsersV2EN.UserName; //用户名
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.Password))
 {
objRow[conQxUsersV2.Password] = objQxUsersV2EN.Password; //口令
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.psalt))
 {
objRow[conQxUsersV2.psalt] = objQxUsersV2EN.psalt; //密码盐值
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.nickName))
 {
objRow[conQxUsersV2.nickName] = objQxUsersV2EN.nickName; //呢称
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.headImg))
 {
objRow[conQxUsersV2.headImg] = objQxUsersV2EN.headImg; //头像
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.Email))
 {
objRow[conQxUsersV2.Email] = objQxUsersV2EN.Email; //邮箱
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.phone))
 {
objRow[conQxUsersV2.phone] = objQxUsersV2EN.phone; //电话号码
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.remark))
 {
objRow[conQxUsersV2.remark] = objQxUsersV2EN.remark; //备注
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.status))
 {
objRow[conQxUsersV2.status] = objQxUsersV2EN.status; //用户状态Id
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.OpenId))
 {
objRow[conQxUsersV2.OpenId] = objQxUsersV2EN.OpenId; //微信openid
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UpdUser))
 {
objRow[conQxUsersV2.UpdUser] = objQxUsersV2EN.UpdUser; //修改用户
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.IsArchive))
 {
objRow[conQxUsersV2.IsArchive] = objQxUsersV2EN.IsArchive; //是否存档
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.IdentityId))
 {
objRow[conQxUsersV2.IdentityId] = objQxUsersV2EN.IdentityId; //身份编号
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.StuTeacherId))
 {
objRow[conQxUsersV2.StuTeacherId] = objQxUsersV2EN.StuTeacherId; //学工号
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffitiveBeginDate))
 {
objRow[conQxUsersV2.EffitiveBeginDate] = objQxUsersV2EN.EffitiveBeginDate; //有效开始日期
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffitiveEndDate))
 {
objRow[conQxUsersV2.EffitiveEndDate] = objQxUsersV2EN.EffitiveEndDate; //有效结束日期
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UserId))
 {
objRow[conQxUsersV2.UserId] = objQxUsersV2EN.UserId; //用户ID
 }
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffectiveDate))
 {
objRow[conQxUsersV2.EffectiveDate] = objQxUsersV2EN.EffectiveDate; //有效日期
 }
try
{
objDA.Update(objDS, clsQxUsersV2EN._CurrTabName);
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
public bool UpdateBySP(clsQxUsersV2EN objQxUsersV2EN)
{
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersV2EN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUsersV2EN.CreateTime,
 objQxUsersV2EN.updateTime,
 objQxUsersV2EN.id,
 objQxUsersV2EN.DepartmentIdInt,
 objQxUsersV2EN.name,
 objQxUsersV2EN.UserName,
 objQxUsersV2EN.Password,
 objQxUsersV2EN.psalt,
 objQxUsersV2EN.nickName,
 objQxUsersV2EN.headImg,
 objQxUsersV2EN.Email,
 objQxUsersV2EN.phone,
 objQxUsersV2EN.remark,
 objQxUsersV2EN.status,
 objQxUsersV2EN.OpenId,
 objQxUsersV2EN.UpdUser,
 objQxUsersV2EN.IsArchive,
 objQxUsersV2EN.IdentityId,
 objQxUsersV2EN.StuTeacherId,
 objQxUsersV2EN.EffitiveBeginDate,
 objQxUsersV2EN.EffitiveEndDate,
 objQxUsersV2EN.UserId,
 objQxUsersV2EN.EffectiveDate
};
 objSQL.ExecSP("QxUsersV2_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUsersV2EN objQxUsersV2EN)
{
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxUsersV2 Set ");
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.CreateTime))
 {
 if (objQxUsersV2EN.CreateTime !=  null)
 {
 var strCreateTime = objQxUsersV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateTime, conQxUsersV2.CreateTime); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.CreateTime); //建立时间
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.updateTime))
 {
 if (objQxUsersV2EN.updateTime !=  null)
 {
 var strupdateTime = objQxUsersV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strupdateTime, conQxUsersV2.updateTime); //修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.updateTime); //修改时间
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.DepartmentIdInt))
 {
 if (objQxUsersV2EN.DepartmentIdInt !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxUsersV2EN.DepartmentIdInt, conQxUsersV2.DepartmentIdInt); //部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.DepartmentIdInt); //部门Id
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.name))
 {
 if (objQxUsersV2EN.name !=  null)
 {
 var strname = objQxUsersV2EN.name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strname, conQxUsersV2.name); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.name); //姓名
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UserName))
 {
 if (objQxUsersV2EN.UserName !=  null)
 {
 var strUserName = objQxUsersV2EN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conQxUsersV2.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.UserName); //用户名
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.Password))
 {
 if (objQxUsersV2EN.Password !=  null)
 {
 var strPassword = objQxUsersV2EN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPassword, conQxUsersV2.Password); //口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.Password); //口令
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.psalt))
 {
 if (objQxUsersV2EN.psalt !=  null)
 {
 var strpsalt = objQxUsersV2EN.psalt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strpsalt, conQxUsersV2.psalt); //密码盐值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.psalt); //密码盐值
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.nickName))
 {
 if (objQxUsersV2EN.nickName !=  null)
 {
 var strnickName = objQxUsersV2EN.nickName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strnickName, conQxUsersV2.nickName); //呢称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.nickName); //呢称
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.headImg))
 {
 if (objQxUsersV2EN.headImg !=  null)
 {
 var strheadImg = objQxUsersV2EN.headImg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strheadImg, conQxUsersV2.headImg); //头像
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.headImg); //头像
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.Email))
 {
 if (objQxUsersV2EN.Email !=  null)
 {
 var strEmail = objQxUsersV2EN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conQxUsersV2.Email); //邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.Email); //邮箱
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.phone))
 {
 if (objQxUsersV2EN.phone !=  null)
 {
 var strphone = objQxUsersV2EN.phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strphone, conQxUsersV2.phone); //电话号码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.phone); //电话号码
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.remark))
 {
 if (objQxUsersV2EN.remark !=  null)
 {
 var strremark = objQxUsersV2EN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strremark, conQxUsersV2.remark); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.remark); //备注
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.status))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxUsersV2EN.status, conQxUsersV2.status); //用户状态Id
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.OpenId))
 {
 if (objQxUsersV2EN.OpenId !=  null)
 {
 var strOpenId = objQxUsersV2EN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpenId, conQxUsersV2.OpenId); //微信openid
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.OpenId); //微信openid
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UpdUser))
 {
 if (objQxUsersV2EN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsersV2EN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxUsersV2.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.UpdUser); //修改用户
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.IsArchive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsersV2EN.IsArchive == true?"1":"0", conQxUsersV2.IsArchive); //是否存档
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.IdentityId))
 {
 if (objQxUsersV2EN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsersV2EN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdentityId, conQxUsersV2.IdentityId); //身份编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.IdentityId); //身份编号
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.StuTeacherId))
 {
 if (objQxUsersV2EN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsersV2EN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuTeacherId, conQxUsersV2.StuTeacherId); //学工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.StuTeacherId); //学工号
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffitiveBeginDate))
 {
 if (objQxUsersV2EN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsersV2EN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveBeginDate, conQxUsersV2.EffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.EffitiveBeginDate); //有效开始日期
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffitiveEndDate))
 {
 if (objQxUsersV2EN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsersV2EN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveEndDate, conQxUsersV2.EffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.EffitiveEndDate); //有效结束日期
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UserId))
 {
 if (objQxUsersV2EN.UserId !=  null)
 {
 var strUserId = objQxUsersV2EN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUsersV2.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.UserId); //用户ID
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffectiveDate))
 {
 if (objQxUsersV2EN.EffectiveDate !=  null)
 {
 var strEffectiveDate = objQxUsersV2EN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffectiveDate, conQxUsersV2.EffectiveDate); //有效日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.EffectiveDate); //有效日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where id = {0}", objQxUsersV2EN.id); 
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
 /// <param name = "objQxUsersV2EN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxUsersV2EN objQxUsersV2EN, string strCondition)
{
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUsersV2 Set ");
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.CreateTime))
 {
 if (objQxUsersV2EN.CreateTime !=  null)
 {
 var strCreateTime = objQxUsersV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateTime = '{0}',", strCreateTime); //建立时间
 }
 else
 {
 sbSQL.Append(" CreateTime = null,"); //建立时间
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.updateTime))
 {
 if (objQxUsersV2EN.updateTime !=  null)
 {
 var strupdateTime = objQxUsersV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" updateTime = '{0}',", strupdateTime); //修改时间
 }
 else
 {
 sbSQL.Append(" updateTime = null,"); //修改时间
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.DepartmentIdInt))
 {
 if (objQxUsersV2EN.DepartmentIdInt !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxUsersV2EN.DepartmentIdInt, conQxUsersV2.DepartmentIdInt); //部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.DepartmentIdInt); //部门Id
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.name))
 {
 if (objQxUsersV2EN.name !=  null)
 {
 var strname = objQxUsersV2EN.name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" name = '{0}',", strname); //姓名
 }
 else
 {
 sbSQL.Append(" name = null,"); //姓名
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UserName))
 {
 if (objQxUsersV2EN.UserName !=  null)
 {
 var strUserName = objQxUsersV2EN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.Password))
 {
 if (objQxUsersV2EN.Password !=  null)
 {
 var strPassword = objQxUsersV2EN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", strPassword); //口令
 }
 else
 {
 sbSQL.Append(" Password = null,"); //口令
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.psalt))
 {
 if (objQxUsersV2EN.psalt !=  null)
 {
 var strpsalt = objQxUsersV2EN.psalt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" psalt = '{0}',", strpsalt); //密码盐值
 }
 else
 {
 sbSQL.Append(" psalt = null,"); //密码盐值
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.nickName))
 {
 if (objQxUsersV2EN.nickName !=  null)
 {
 var strnickName = objQxUsersV2EN.nickName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" nickName = '{0}',", strnickName); //呢称
 }
 else
 {
 sbSQL.Append(" nickName = null,"); //呢称
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.headImg))
 {
 if (objQxUsersV2EN.headImg !=  null)
 {
 var strheadImg = objQxUsersV2EN.headImg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" headImg = '{0}',", strheadImg); //头像
 }
 else
 {
 sbSQL.Append(" headImg = null,"); //头像
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.Email))
 {
 if (objQxUsersV2EN.Email !=  null)
 {
 var strEmail = objQxUsersV2EN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //邮箱
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.phone))
 {
 if (objQxUsersV2EN.phone !=  null)
 {
 var strphone = objQxUsersV2EN.phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" phone = '{0}',", strphone); //电话号码
 }
 else
 {
 sbSQL.Append(" phone = null,"); //电话号码
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.remark))
 {
 if (objQxUsersV2EN.remark !=  null)
 {
 var strremark = objQxUsersV2EN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" remark = '{0}',", strremark); //备注
 }
 else
 {
 sbSQL.Append(" remark = null,"); //备注
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.status))
 {
 sbSQL.AppendFormat(" status = {0},", objQxUsersV2EN.status); //用户状态Id
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.OpenId))
 {
 if (objQxUsersV2EN.OpenId !=  null)
 {
 var strOpenId = objQxUsersV2EN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpenId = '{0}',", strOpenId); //微信openid
 }
 else
 {
 sbSQL.Append(" OpenId = null,"); //微信openid
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UpdUser))
 {
 if (objQxUsersV2EN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsersV2EN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.IsArchive))
 {
 sbSQL.AppendFormat(" IsArchive = '{0}',", objQxUsersV2EN.IsArchive == true?"1":"0"); //是否存档
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.IdentityId))
 {
 if (objQxUsersV2EN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsersV2EN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdentityId = '{0}',", strIdentityId); //身份编号
 }
 else
 {
 sbSQL.Append(" IdentityId = null,"); //身份编号
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.StuTeacherId))
 {
 if (objQxUsersV2EN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsersV2EN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuTeacherId = '{0}',", strStuTeacherId); //学工号
 }
 else
 {
 sbSQL.Append(" StuTeacherId = null,"); //学工号
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffitiveBeginDate))
 {
 if (objQxUsersV2EN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsersV2EN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveBeginDate = '{0}',", strEffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.Append(" EffitiveBeginDate = null,"); //有效开始日期
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffitiveEndDate))
 {
 if (objQxUsersV2EN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsersV2EN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveEndDate = '{0}',", strEffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.Append(" EffitiveEndDate = null,"); //有效结束日期
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UserId))
 {
 if (objQxUsersV2EN.UserId !=  null)
 {
 var strUserId = objQxUsersV2EN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffectiveDate))
 {
 if (objQxUsersV2EN.EffectiveDate !=  null)
 {
 var strEffectiveDate = objQxUsersV2EN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffectiveDate = '{0}',", strEffectiveDate); //有效日期
 }
 else
 {
 sbSQL.Append(" EffectiveDate = null,"); //有效日期
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
 /// <param name = "objQxUsersV2EN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxUsersV2EN objQxUsersV2EN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUsersV2 Set ");
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.CreateTime))
 {
 if (objQxUsersV2EN.CreateTime !=  null)
 {
 var strCreateTime = objQxUsersV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateTime = '{0}',", strCreateTime); //建立时间
 }
 else
 {
 sbSQL.Append(" CreateTime = null,"); //建立时间
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.updateTime))
 {
 if (objQxUsersV2EN.updateTime !=  null)
 {
 var strupdateTime = objQxUsersV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" updateTime = '{0}',", strupdateTime); //修改时间
 }
 else
 {
 sbSQL.Append(" updateTime = null,"); //修改时间
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.DepartmentIdInt))
 {
 if (objQxUsersV2EN.DepartmentIdInt !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxUsersV2EN.DepartmentIdInt, conQxUsersV2.DepartmentIdInt); //部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.DepartmentIdInt); //部门Id
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.name))
 {
 if (objQxUsersV2EN.name !=  null)
 {
 var strname = objQxUsersV2EN.name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" name = '{0}',", strname); //姓名
 }
 else
 {
 sbSQL.Append(" name = null,"); //姓名
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UserName))
 {
 if (objQxUsersV2EN.UserName !=  null)
 {
 var strUserName = objQxUsersV2EN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.Password))
 {
 if (objQxUsersV2EN.Password !=  null)
 {
 var strPassword = objQxUsersV2EN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", strPassword); //口令
 }
 else
 {
 sbSQL.Append(" Password = null,"); //口令
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.psalt))
 {
 if (objQxUsersV2EN.psalt !=  null)
 {
 var strpsalt = objQxUsersV2EN.psalt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" psalt = '{0}',", strpsalt); //密码盐值
 }
 else
 {
 sbSQL.Append(" psalt = null,"); //密码盐值
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.nickName))
 {
 if (objQxUsersV2EN.nickName !=  null)
 {
 var strnickName = objQxUsersV2EN.nickName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" nickName = '{0}',", strnickName); //呢称
 }
 else
 {
 sbSQL.Append(" nickName = null,"); //呢称
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.headImg))
 {
 if (objQxUsersV2EN.headImg !=  null)
 {
 var strheadImg = objQxUsersV2EN.headImg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" headImg = '{0}',", strheadImg); //头像
 }
 else
 {
 sbSQL.Append(" headImg = null,"); //头像
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.Email))
 {
 if (objQxUsersV2EN.Email !=  null)
 {
 var strEmail = objQxUsersV2EN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //邮箱
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.phone))
 {
 if (objQxUsersV2EN.phone !=  null)
 {
 var strphone = objQxUsersV2EN.phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" phone = '{0}',", strphone); //电话号码
 }
 else
 {
 sbSQL.Append(" phone = null,"); //电话号码
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.remark))
 {
 if (objQxUsersV2EN.remark !=  null)
 {
 var strremark = objQxUsersV2EN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" remark = '{0}',", strremark); //备注
 }
 else
 {
 sbSQL.Append(" remark = null,"); //备注
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.status))
 {
 sbSQL.AppendFormat(" status = {0},", objQxUsersV2EN.status); //用户状态Id
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.OpenId))
 {
 if (objQxUsersV2EN.OpenId !=  null)
 {
 var strOpenId = objQxUsersV2EN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpenId = '{0}',", strOpenId); //微信openid
 }
 else
 {
 sbSQL.Append(" OpenId = null,"); //微信openid
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UpdUser))
 {
 if (objQxUsersV2EN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsersV2EN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.IsArchive))
 {
 sbSQL.AppendFormat(" IsArchive = '{0}',", objQxUsersV2EN.IsArchive == true?"1":"0"); //是否存档
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.IdentityId))
 {
 if (objQxUsersV2EN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsersV2EN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdentityId = '{0}',", strIdentityId); //身份编号
 }
 else
 {
 sbSQL.Append(" IdentityId = null,"); //身份编号
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.StuTeacherId))
 {
 if (objQxUsersV2EN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsersV2EN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuTeacherId = '{0}',", strStuTeacherId); //学工号
 }
 else
 {
 sbSQL.Append(" StuTeacherId = null,"); //学工号
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffitiveBeginDate))
 {
 if (objQxUsersV2EN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsersV2EN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveBeginDate = '{0}',", strEffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.Append(" EffitiveBeginDate = null,"); //有效开始日期
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffitiveEndDate))
 {
 if (objQxUsersV2EN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsersV2EN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveEndDate = '{0}',", strEffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.Append(" EffitiveEndDate = null,"); //有效结束日期
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UserId))
 {
 if (objQxUsersV2EN.UserId !=  null)
 {
 var strUserId = objQxUsersV2EN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffectiveDate))
 {
 if (objQxUsersV2EN.EffectiveDate !=  null)
 {
 var strEffectiveDate = objQxUsersV2EN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffectiveDate = '{0}',", strEffectiveDate); //有效日期
 }
 else
 {
 sbSQL.Append(" EffectiveDate = null,"); //有效日期
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
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUsersV2EN objQxUsersV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUsersV2 Set ");
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.CreateTime))
 {
 if (objQxUsersV2EN.CreateTime !=  null)
 {
 var strCreateTime = objQxUsersV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateTime, conQxUsersV2.CreateTime); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.CreateTime); //建立时间
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.updateTime))
 {
 if (objQxUsersV2EN.updateTime !=  null)
 {
 var strupdateTime = objQxUsersV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strupdateTime, conQxUsersV2.updateTime); //修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.updateTime); //修改时间
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.DepartmentIdInt))
 {
 if (objQxUsersV2EN.DepartmentIdInt !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxUsersV2EN.DepartmentIdInt, conQxUsersV2.DepartmentIdInt); //部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.DepartmentIdInt); //部门Id
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.name))
 {
 if (objQxUsersV2EN.name !=  null)
 {
 var strname = objQxUsersV2EN.name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strname, conQxUsersV2.name); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.name); //姓名
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UserName))
 {
 if (objQxUsersV2EN.UserName !=  null)
 {
 var strUserName = objQxUsersV2EN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conQxUsersV2.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.UserName); //用户名
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.Password))
 {
 if (objQxUsersV2EN.Password !=  null)
 {
 var strPassword = objQxUsersV2EN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPassword, conQxUsersV2.Password); //口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.Password); //口令
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.psalt))
 {
 if (objQxUsersV2EN.psalt !=  null)
 {
 var strpsalt = objQxUsersV2EN.psalt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strpsalt, conQxUsersV2.psalt); //密码盐值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.psalt); //密码盐值
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.nickName))
 {
 if (objQxUsersV2EN.nickName !=  null)
 {
 var strnickName = objQxUsersV2EN.nickName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strnickName, conQxUsersV2.nickName); //呢称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.nickName); //呢称
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.headImg))
 {
 if (objQxUsersV2EN.headImg !=  null)
 {
 var strheadImg = objQxUsersV2EN.headImg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strheadImg, conQxUsersV2.headImg); //头像
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.headImg); //头像
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.Email))
 {
 if (objQxUsersV2EN.Email !=  null)
 {
 var strEmail = objQxUsersV2EN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conQxUsersV2.Email); //邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.Email); //邮箱
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.phone))
 {
 if (objQxUsersV2EN.phone !=  null)
 {
 var strphone = objQxUsersV2EN.phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strphone, conQxUsersV2.phone); //电话号码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.phone); //电话号码
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.remark))
 {
 if (objQxUsersV2EN.remark !=  null)
 {
 var strremark = objQxUsersV2EN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strremark, conQxUsersV2.remark); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.remark); //备注
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.status))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxUsersV2EN.status, conQxUsersV2.status); //用户状态Id
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.OpenId))
 {
 if (objQxUsersV2EN.OpenId !=  null)
 {
 var strOpenId = objQxUsersV2EN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpenId, conQxUsersV2.OpenId); //微信openid
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.OpenId); //微信openid
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UpdUser))
 {
 if (objQxUsersV2EN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsersV2EN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxUsersV2.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.UpdUser); //修改用户
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.IsArchive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsersV2EN.IsArchive == true?"1":"0", conQxUsersV2.IsArchive); //是否存档
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.IdentityId))
 {
 if (objQxUsersV2EN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsersV2EN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdentityId, conQxUsersV2.IdentityId); //身份编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.IdentityId); //身份编号
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.StuTeacherId))
 {
 if (objQxUsersV2EN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsersV2EN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuTeacherId, conQxUsersV2.StuTeacherId); //学工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.StuTeacherId); //学工号
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffitiveBeginDate))
 {
 if (objQxUsersV2EN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsersV2EN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveBeginDate, conQxUsersV2.EffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.EffitiveBeginDate); //有效开始日期
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffitiveEndDate))
 {
 if (objQxUsersV2EN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsersV2EN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveEndDate, conQxUsersV2.EffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.EffitiveEndDate); //有效结束日期
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.UserId))
 {
 if (objQxUsersV2EN.UserId !=  null)
 {
 var strUserId = objQxUsersV2EN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUsersV2.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.UserId); //用户ID
 }
 }
 
 if (objQxUsersV2EN.IsUpdated(conQxUsersV2.EffectiveDate))
 {
 if (objQxUsersV2EN.EffectiveDate !=  null)
 {
 var strEffectiveDate = objQxUsersV2EN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffectiveDate, conQxUsersV2.EffectiveDate); //有效日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsersV2.EffectiveDate); //有效日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where id = {0}", objQxUsersV2EN.id); 
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
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intid) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 intid,
};
 objSQL.ExecSP("QxUsersV2_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "intid">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(int intid, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
//删除QxUsersV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUsersV2 where id = " + ""+ intid+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxUsersV2(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
//删除QxUsersV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUsersV2 where id in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(int intid) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
//删除QxUsersV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUsersV2 where id = " + ""+ intid+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxUsersV2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxUsersV2DA: DelQxUsersV2)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUsersV2 where " + strCondition ;
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
public bool DelQxUsersV2WithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxUsersV2DA: DelQxUsersV2WithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUsersV2 where " + strCondition ;
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
 /// <param name = "objQxUsersV2ENS">源对象</param>
 /// <param name = "objQxUsersV2ENT">目标对象</param>
public void CopyTo(clsQxUsersV2EN objQxUsersV2ENS, clsQxUsersV2EN objQxUsersV2ENT)
{
objQxUsersV2ENT.CreateTime = objQxUsersV2ENS.CreateTime; //建立时间
objQxUsersV2ENT.updateTime = objQxUsersV2ENS.updateTime; //修改时间
objQxUsersV2ENT.id = objQxUsersV2ENS.id; //id
objQxUsersV2ENT.DepartmentIdInt = objQxUsersV2ENS.DepartmentIdInt; //部门Id
objQxUsersV2ENT.name = objQxUsersV2ENS.name; //姓名
objQxUsersV2ENT.UserName = objQxUsersV2ENS.UserName; //用户名
objQxUsersV2ENT.Password = objQxUsersV2ENS.Password; //口令
objQxUsersV2ENT.psalt = objQxUsersV2ENS.psalt; //密码盐值
objQxUsersV2ENT.nickName = objQxUsersV2ENS.nickName; //呢称
objQxUsersV2ENT.headImg = objQxUsersV2ENS.headImg; //头像
objQxUsersV2ENT.Email = objQxUsersV2ENS.Email; //邮箱
objQxUsersV2ENT.phone = objQxUsersV2ENS.phone; //电话号码
objQxUsersV2ENT.remark = objQxUsersV2ENS.remark; //备注
objQxUsersV2ENT.status = objQxUsersV2ENS.status; //用户状态Id
objQxUsersV2ENT.OpenId = objQxUsersV2ENS.OpenId; //微信openid
objQxUsersV2ENT.UpdUser = objQxUsersV2ENS.UpdUser; //修改用户
objQxUsersV2ENT.IsArchive = objQxUsersV2ENS.IsArchive; //是否存档
objQxUsersV2ENT.IdentityId = objQxUsersV2ENS.IdentityId; //身份编号
objQxUsersV2ENT.StuTeacherId = objQxUsersV2ENS.StuTeacherId; //学工号
objQxUsersV2ENT.EffitiveBeginDate = objQxUsersV2ENS.EffitiveBeginDate; //有效开始日期
objQxUsersV2ENT.EffitiveEndDate = objQxUsersV2ENS.EffitiveEndDate; //有效结束日期
objQxUsersV2ENT.UserId = objQxUsersV2ENS.UserId; //用户ID
objQxUsersV2ENT.EffectiveDate = objQxUsersV2ENS.EffectiveDate; //有效日期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUsersV2EN objQxUsersV2EN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxUsersV2EN.name, conQxUsersV2.name);
clsCheckSql.CheckFieldNotNull(objQxUsersV2EN.UserName, conQxUsersV2.UserName);
clsCheckSql.CheckFieldNotNull(objQxUsersV2EN.Password, conQxUsersV2.Password);
clsCheckSql.CheckFieldNotNull(objQxUsersV2EN.phone, conQxUsersV2.phone);
clsCheckSql.CheckFieldNotNull(objQxUsersV2EN.status, conQxUsersV2.status);
clsCheckSql.CheckFieldNotNull(objQxUsersV2EN.UserId, conQxUsersV2.UserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUsersV2EN.CreateTime, 20, conQxUsersV2.CreateTime);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.updateTime, 20, conQxUsersV2.updateTime);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.name, 30, conQxUsersV2.name);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.UserName, 30, conQxUsersV2.UserName);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.Password, 20, conQxUsersV2.Password);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.psalt, 20, conQxUsersV2.psalt);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.nickName, 100, conQxUsersV2.nickName);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.headImg, 100, conQxUsersV2.headImg);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.Email, 100, conQxUsersV2.Email);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.phone, 15, conQxUsersV2.phone);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.remark, 1000, conQxUsersV2.remark);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.OpenId, 50, conQxUsersV2.OpenId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.UpdUser, 20, conQxUsersV2.UpdUser);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.IdentityId, 2, conQxUsersV2.IdentityId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.StuTeacherId, 20, conQxUsersV2.StuTeacherId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.EffitiveBeginDate, 14, conQxUsersV2.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.EffitiveEndDate, 14, conQxUsersV2.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.UserId, 18, conQxUsersV2.UserId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.EffectiveDate, 8, conQxUsersV2.EffectiveDate);
//检查字段外键固定长度
 objQxUsersV2EN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxUsersV2EN objQxUsersV2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUsersV2EN.CreateTime, 20, conQxUsersV2.CreateTime);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.updateTime, 20, conQxUsersV2.updateTime);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.name, 30, conQxUsersV2.name);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.UserName, 30, conQxUsersV2.UserName);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.Password, 20, conQxUsersV2.Password);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.psalt, 20, conQxUsersV2.psalt);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.nickName, 100, conQxUsersV2.nickName);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.headImg, 100, conQxUsersV2.headImg);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.Email, 100, conQxUsersV2.Email);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.phone, 15, conQxUsersV2.phone);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.remark, 1000, conQxUsersV2.remark);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.OpenId, 50, conQxUsersV2.OpenId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.UpdUser, 20, conQxUsersV2.UpdUser);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.IdentityId, 2, conQxUsersV2.IdentityId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.StuTeacherId, 20, conQxUsersV2.StuTeacherId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.EffitiveBeginDate, 14, conQxUsersV2.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.EffitiveEndDate, 14, conQxUsersV2.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.UserId, 18, conQxUsersV2.UserId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.EffectiveDate, 8, conQxUsersV2.EffectiveDate);
//检查外键字段长度
 objQxUsersV2EN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxUsersV2EN objQxUsersV2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUsersV2EN.CreateTime, 20, conQxUsersV2.CreateTime);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.updateTime, 20, conQxUsersV2.updateTime);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.name, 30, conQxUsersV2.name);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.UserName, 30, conQxUsersV2.UserName);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.Password, 20, conQxUsersV2.Password);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.psalt, 20, conQxUsersV2.psalt);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.nickName, 100, conQxUsersV2.nickName);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.headImg, 100, conQxUsersV2.headImg);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.Email, 100, conQxUsersV2.Email);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.phone, 15, conQxUsersV2.phone);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.remark, 1000, conQxUsersV2.remark);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.OpenId, 50, conQxUsersV2.OpenId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.UpdUser, 20, conQxUsersV2.UpdUser);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.IdentityId, 2, conQxUsersV2.IdentityId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.StuTeacherId, 20, conQxUsersV2.StuTeacherId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.EffitiveBeginDate, 14, conQxUsersV2.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.EffitiveEndDate, 14, conQxUsersV2.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.UserId, 18, conQxUsersV2.UserId);
clsCheckSql.CheckFieldLen(objQxUsersV2EN.EffectiveDate, 8, conQxUsersV2.EffectiveDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.CreateTime, conQxUsersV2.CreateTime);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.updateTime, conQxUsersV2.updateTime);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.name, conQxUsersV2.name);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.UserName, conQxUsersV2.UserName);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.Password, conQxUsersV2.Password);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.psalt, conQxUsersV2.psalt);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.nickName, conQxUsersV2.nickName);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.headImg, conQxUsersV2.headImg);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.Email, conQxUsersV2.Email);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.phone, conQxUsersV2.phone);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.remark, conQxUsersV2.remark);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.OpenId, conQxUsersV2.OpenId);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.UpdUser, conQxUsersV2.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.IdentityId, conQxUsersV2.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.StuTeacherId, conQxUsersV2.StuTeacherId);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.EffitiveBeginDate, conQxUsersV2.EffitiveBeginDate);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.EffitiveEndDate, conQxUsersV2.EffitiveEndDate);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.UserId, conQxUsersV2.UserId);
clsCheckSql.CheckSqlInjection4Field(objQxUsersV2EN.EffectiveDate, conQxUsersV2.EffectiveDate);
//检查外键字段长度
 objQxUsersV2EN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable Getid()
{
//获取某学院所有专业信息
string strSQL = "select id, UserName from QxUsersV2 ";
 clsSpecSQLforSql mySql = clsQxUsersV2DA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxUsersV2(用户V2),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUsersV2EN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxUsersV2EN objQxUsersV2EN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and name = '{0}'", objQxUsersV2EN.name);
 sbCondition.AppendFormat(" and phone = '{0}'", objQxUsersV2EN.phone);
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
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUsersV2EN._CurrTabName);
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
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUsersV2EN._CurrTabName, strCondition);
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
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
 objSQL = clsQxUsersV2DA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}