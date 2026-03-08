
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRoleMenusDA
 表名:QxRoleMenus(00140007)
 * 版本:2024.08.23.1(服务器:WIN-SRV103-116)
 日期:2024/08/29 09:32:50
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:菜单管理(MenuManage_GP)
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
 /// 角色菜单(QxRoleMenus)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxRoleMenusDA : clsCommBase4DA
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
 return clsQxRoleMenusEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxRoleMenusEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxRoleMenusEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxRoleMenusEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxRoleMenusEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
 strSQL = "Select * from QxRoleMenus where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxRoleMenus");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxRoleMenus_SelectByCond",values, "QxRoleMenus");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRoleMenus where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxRoleMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From QxRoleMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRoleMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From QxRoleMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRoleMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From QxRoleMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRoleMenus");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxRoleMenus(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTable_QxRoleMenus)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoleMenus where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoleMenus where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRoleMenus where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRoleMenus where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRoleMenus.* from QxRoleMenus Left Join {1} on {2} where {3} and QxRoleMenus.mId not in (Select top {5} QxRoleMenus.mId from QxRoleMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoleMenus where {1} and mId not in (Select top {2} mId from QxRoleMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoleMenus where {1} and mId not in (Select top {3} mId from QxRoleMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRoleMenus.* from QxRoleMenus Left Join {1} on {2} where {3} and QxRoleMenus.mId not in (Select top {5} QxRoleMenus.mId from QxRoleMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoleMenus where {1} and mId not in (Select top {2} mId from QxRoleMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoleMenus where {1} and mId not in (Select top {3} mId from QxRoleMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRoleMenus.* from QxRoleMenus Left Join {1} on {2} where {3} and QxRoleMenus.mId not in (Select top {5} QxRoleMenus.mId from QxRoleMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoleMenus where {1} and mId not in (Select top {2} mId from QxRoleMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoleMenus where {1} and mId not in (Select top {3} mId from QxRoleMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From QxRoleMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From QxRoleMenus Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From QxRoleMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From QxRoleMenus Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleMenusDA: GetQxRoleMenusByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRoleMenus_SelectByCond",values);
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
public List<clsQxRoleMenusEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxRoleMenusDA:GetObjLst)", objException.Message));
}
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = TransNullToInt(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = TransNullToBool(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxRoleMenusDA: GetObjLst)", objException.Message));
}
objQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRoleMenusEN);
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
public List<clsQxRoleMenusEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxRoleMenusDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = TransNullToInt(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = TransNullToBool(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxRoleMenusDA: GetObjLst)", objException.Message));
}
objQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRoleMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxRoleMenusEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxRoleMenusDA:GetObjLstBySP)", objException.Message));
}
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRoleMenus_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = TransNullToInt(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = TransNullToBool(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxRoleMenusDA: GetObjLstBySP)", objException.Message));
}
objQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRoleMenusEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxRoleMenus(ref clsQxRoleMenusEN objQxRoleMenusEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where mId = " + ""+ objQxRoleMenusEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxRoleMenusEN.mId = TransNullToInt(objDT.Rows[0][conQxRoleMenus.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxRoleMenusEN.RoleId = objDT.Rows[0][conQxRoleMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRoleMenusEN.QxPrjId = objDT.Rows[0][conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRoleMenusEN.CmPrjId = objDT.Rows[0][conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id(字段类型:char,字段长度:6,是否可空:False)
 objQxRoleMenusEN.MenuSetId = objDT.Rows[0][conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRoleMenusEN.MenuId = objDT.Rows[0][conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxRoleMenusEN.IsDisp = TransNullToBool(objDT.Rows[0][conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objQxRoleMenusEN.UpdDate = objDT.Rows[0][conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRoleMenusEN.UpdUserId = objDT.Rows[0][conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRoleMenusEN.Memo = objDT.Rows[0][conQxRoleMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxRoleMenusDA: GetQxRoleMenus)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxRoleMenusEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
 objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id(字段类型:char,字段长度:6,是否可空:False)
 objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxRoleMenusDA: GetObjBymId)", objException.Message));
}
return objQxRoleMenusEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxRoleMenus_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxRoleMenusOneBySP(clsQxRoleMenusEN objQxRoleMenusEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxRoleMenusEN.mId
};
 objDT = objSQL.ExecSpReturnDT("QxRoleMenus_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxRoleMenusEN.mId = TransNullToInt(objDT.Rows[0][conQxRoleMenus.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxRoleMenusEN.RoleId = objDT.Rows[0][conQxRoleMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRoleMenusEN.QxPrjId = objDT.Rows[0][conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRoleMenusEN.CmPrjId = objDT.Rows[0][conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id(字段类型:char,字段长度:6,是否可空:False)
 objQxRoleMenusEN.MenuSetId = objDT.Rows[0][conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRoleMenusEN.MenuId = objDT.Rows[0][conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxRoleMenusEN.IsDisp = TransNullToBool(objDT.Rows[0][conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objQxRoleMenusEN.UpdDate = objDT.Rows[0][conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRoleMenusEN.UpdUserId = objDT.Rows[0][conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRoleMenusEN.Memo = objDT.Rows[0][conQxRoleMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxRoleMenusEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN()
{
mId = TransNullToInt(objRow[conQxRoleMenus.mId].ToString().Trim()), //流水号
RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(), //角色Id
QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(), //项目Id
CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(), //Cm项目Id
MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(), //菜单集Id
MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(), //菜单Id
IsDisp = TransNullToBool(objRow[conQxRoleMenus.IsDisp].ToString().Trim()), //是否显示
UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim() //备注
};
objQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRoleMenusEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxRoleMenusDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxRoleMenusEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxRoleMenusDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRoleMenus_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN()
{
mId = TransNullToInt(objRow[conQxRoleMenus.mId].ToString().Trim()), //流水号
RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(), //角色Id
QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(), //项目Id
CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(), //Cm项目Id
MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(), //菜单集Id
MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(), //菜单Id
IsDisp = TransNullToBool(objRow[conQxRoleMenus.IsDisp].ToString().Trim()), //是否显示
UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim() //备注
};
objQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRoleMenusEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxRoleMenusEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = TransNullToInt(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = TransNullToBool(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxRoleMenusDA: GetObjByDataRowQxRoleMenus)", objException.Message));
}
objQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRoleMenusEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxRoleMenusEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = TransNullToInt(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = TransNullToBool(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxRoleMenusDA: GetObjByDataRow)", objException.Message));
}
objQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRoleMenusEN;
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
objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxRoleMenusEN._CurrTabName, conQxRoleMenus.mId, 8, "");
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
objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxRoleMenusEN._CurrTabName, conQxRoleMenus.mId, 8, strPrefix);
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
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from QxRoleMenus where " + strCondition;
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
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from QxRoleMenus where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxRoleMenus", "mId = " + ""+ lngmId+""))
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxRoleMenus_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxRoleMenusDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxRoleMenus", strCondition))
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
objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxRoleMenus");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxRoleMenusEN objQxRoleMenusEN)
 {
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleMenusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRoleMenusEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxRoleMenus");
objRow = objDS.Tables["QxRoleMenus"].NewRow();
objRow[conQxRoleMenus.RoleId] = objQxRoleMenusEN.RoleId; //角色Id
objRow[conQxRoleMenus.QxPrjId] = objQxRoleMenusEN.QxPrjId; //项目Id
 if (objQxRoleMenusEN.CmPrjId !=  "")
 {
objRow[conQxRoleMenus.CmPrjId] = objQxRoleMenusEN.CmPrjId; //Cm项目Id
 }
objRow[conQxRoleMenus.MenuSetId] = objQxRoleMenusEN.MenuSetId; //菜单集Id
objRow[conQxRoleMenus.MenuId] = objQxRoleMenusEN.MenuId; //菜单Id
objRow[conQxRoleMenus.IsDisp] = objQxRoleMenusEN.IsDisp; //是否显示
objRow[conQxRoleMenus.UpdDate] = objQxRoleMenusEN.UpdDate; //修改日期
objRow[conQxRoleMenus.UpdUserId] = objQxRoleMenusEN.UpdUserId; //修改用户Id
 if (objQxRoleMenusEN.Memo !=  "")
 {
objRow[conQxRoleMenus.Memo] = objQxRoleMenusEN.Memo; //备注
 }
objDS.Tables[clsQxRoleMenusEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxRoleMenusEN._CurrTabName);
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
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxRoleMenusEN objQxRoleMenusEN)
{
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleMenusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRoleMenusEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRoleMenusEN.RoleId  ==  "")
 {
 objQxRoleMenusEN.RoleId = null;
 }
 if (objQxRoleMenusEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.RoleId);
 var strRoleId = objQxRoleMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQxRoleMenusEN.QxPrjId  ==  "")
 {
 objQxRoleMenusEN.QxPrjId = null;
 }
 if (objQxRoleMenusEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.QxPrjId);
 var strQxPrjId = objQxRoleMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRoleMenusEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.CmPrjId);
 var strCmPrjId = objQxRoleMenusEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objQxRoleMenusEN.MenuSetId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.MenuSetId);
 var strMenuSetId = objQxRoleMenusEN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuSetId + "'");
 }
 
 if (objQxRoleMenusEN.MenuId  ==  "")
 {
 objQxRoleMenusEN.MenuId = null;
 }
 if (objQxRoleMenusEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.MenuId);
 var strMenuId = objQxRoleMenusEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 arrFieldListForInsert.Add(conQxRoleMenus.IsDisp);
 arrValueListForInsert.Add("'" + (objQxRoleMenusEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objQxRoleMenusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.UpdDate);
 var strUpdDate = objQxRoleMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRoleMenusEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.UpdUserId);
 var strUpdUserId = objQxRoleMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxRoleMenusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.Memo);
 var strMemo = objQxRoleMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRoleMenus");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxRoleMenusEN objQxRoleMenusEN)
{
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleMenusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRoleMenusEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRoleMenusEN.RoleId  ==  "")
 {
 objQxRoleMenusEN.RoleId = null;
 }
 if (objQxRoleMenusEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.RoleId);
 var strRoleId = objQxRoleMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQxRoleMenusEN.QxPrjId  ==  "")
 {
 objQxRoleMenusEN.QxPrjId = null;
 }
 if (objQxRoleMenusEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.QxPrjId);
 var strQxPrjId = objQxRoleMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRoleMenusEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.CmPrjId);
 var strCmPrjId = objQxRoleMenusEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objQxRoleMenusEN.MenuSetId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.MenuSetId);
 var strMenuSetId = objQxRoleMenusEN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuSetId + "'");
 }
 
 if (objQxRoleMenusEN.MenuId  ==  "")
 {
 objQxRoleMenusEN.MenuId = null;
 }
 if (objQxRoleMenusEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.MenuId);
 var strMenuId = objQxRoleMenusEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 arrFieldListForInsert.Add(conQxRoleMenus.IsDisp);
 arrValueListForInsert.Add("'" + (objQxRoleMenusEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objQxRoleMenusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.UpdDate);
 var strUpdDate = objQxRoleMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRoleMenusEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.UpdUserId);
 var strUpdUserId = objQxRoleMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxRoleMenusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.Memo);
 var strMemo = objQxRoleMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRoleMenus");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxRoleMenusEN objQxRoleMenusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleMenusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRoleMenusEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRoleMenusEN.RoleId  ==  "")
 {
 objQxRoleMenusEN.RoleId = null;
 }
 if (objQxRoleMenusEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.RoleId);
 var strRoleId = objQxRoleMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQxRoleMenusEN.QxPrjId  ==  "")
 {
 objQxRoleMenusEN.QxPrjId = null;
 }
 if (objQxRoleMenusEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.QxPrjId);
 var strQxPrjId = objQxRoleMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRoleMenusEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.CmPrjId);
 var strCmPrjId = objQxRoleMenusEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objQxRoleMenusEN.MenuSetId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.MenuSetId);
 var strMenuSetId = objQxRoleMenusEN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuSetId + "'");
 }
 
 if (objQxRoleMenusEN.MenuId  ==  "")
 {
 objQxRoleMenusEN.MenuId = null;
 }
 if (objQxRoleMenusEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.MenuId);
 var strMenuId = objQxRoleMenusEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 arrFieldListForInsert.Add(conQxRoleMenus.IsDisp);
 arrValueListForInsert.Add("'" + (objQxRoleMenusEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objQxRoleMenusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.UpdDate);
 var strUpdDate = objQxRoleMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRoleMenusEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.UpdUserId);
 var strUpdUserId = objQxRoleMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxRoleMenusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.Memo);
 var strMemo = objQxRoleMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRoleMenus");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxRoleMenusEN objQxRoleMenusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleMenusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRoleMenusEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRoleMenusEN.RoleId  ==  "")
 {
 objQxRoleMenusEN.RoleId = null;
 }
 if (objQxRoleMenusEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.RoleId);
 var strRoleId = objQxRoleMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQxRoleMenusEN.QxPrjId  ==  "")
 {
 objQxRoleMenusEN.QxPrjId = null;
 }
 if (objQxRoleMenusEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.QxPrjId);
 var strQxPrjId = objQxRoleMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRoleMenusEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.CmPrjId);
 var strCmPrjId = objQxRoleMenusEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objQxRoleMenusEN.MenuSetId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.MenuSetId);
 var strMenuSetId = objQxRoleMenusEN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuSetId + "'");
 }
 
 if (objQxRoleMenusEN.MenuId  ==  "")
 {
 objQxRoleMenusEN.MenuId = null;
 }
 if (objQxRoleMenusEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.MenuId);
 var strMenuId = objQxRoleMenusEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 arrFieldListForInsert.Add(conQxRoleMenus.IsDisp);
 arrValueListForInsert.Add("'" + (objQxRoleMenusEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objQxRoleMenusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.UpdDate);
 var strUpdDate = objQxRoleMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRoleMenusEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.UpdUserId);
 var strUpdUserId = objQxRoleMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxRoleMenusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleMenus.Memo);
 var strMemo = objQxRoleMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRoleMenus");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxRoleMenusBySP(clsQxRoleMenusEN objQxRoleMenusEN)
{
//通过存储过程来
//直接使用
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxRoleMenusEN.RoleId,
 objQxRoleMenusEN.QxPrjId,
 objQxRoleMenusEN.CmPrjId,
 objQxRoleMenusEN.MenuSetId,
 objQxRoleMenusEN.MenuId,
 objQxRoleMenusEN.IsDisp,
 objQxRoleMenusEN.UpdDate,
 objQxRoleMenusEN.UpdUserId,
objQxRoleMenusEN.Memo
};
 objSQL.ExecSP("QxRoleMenus_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxRoleMenuss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxRoleMenus");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxRoleMenusEN._CurrTabName ].NewRow();
objRow[conQxRoleMenus.RoleId] = oRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objRow[conQxRoleMenus.QxPrjId] = oRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxRoleMenus.CmPrjId] = oRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objRow[conQxRoleMenus.MenuSetId] = oRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objRow[conQxRoleMenus.MenuId] = oRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objRow[conQxRoleMenus.IsDisp] = oRow[conQxRoleMenus.IsDisp].ToString().Trim(); //是否显示
objRow[conQxRoleMenus.UpdDate] = oRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objRow[conQxRoleMenus.UpdUserId] = oRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conQxRoleMenus.Memo] = oRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxRoleMenusEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxRoleMenusEN._CurrTabName);
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
 /// <param name = "objQxRoleMenusEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxRoleMenusEN objQxRoleMenusEN)
{
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleMenusEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleMenus where mId = " + ""+ objQxRoleMenusEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxRoleMenusEN._CurrTabName);
if (objDS.Tables[clsQxRoleMenusEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objQxRoleMenusEN.mId+"");
return false;
}
objRow = objDS.Tables[clsQxRoleMenusEN._CurrTabName].Rows[0];
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.RoleId))
 {
objRow[conQxRoleMenus.RoleId] = objQxRoleMenusEN.RoleId; //角色Id
 }
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.QxPrjId))
 {
objRow[conQxRoleMenus.QxPrjId] = objQxRoleMenusEN.QxPrjId; //项目Id
 }
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.CmPrjId))
 {
objRow[conQxRoleMenus.CmPrjId] = objQxRoleMenusEN.CmPrjId; //Cm项目Id
 }
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.MenuSetId))
 {
objRow[conQxRoleMenus.MenuSetId] = objQxRoleMenusEN.MenuSetId; //菜单集Id
 }
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.MenuId))
 {
objRow[conQxRoleMenus.MenuId] = objQxRoleMenusEN.MenuId; //菜单Id
 }
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.IsDisp))
 {
objRow[conQxRoleMenus.IsDisp] = objQxRoleMenusEN.IsDisp; //是否显示
 }
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.UpdDate))
 {
objRow[conQxRoleMenus.UpdDate] = objQxRoleMenusEN.UpdDate; //修改日期
 }
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.UpdUserId))
 {
objRow[conQxRoleMenus.UpdUserId] = objQxRoleMenusEN.UpdUserId; //修改用户Id
 }
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.Memo))
 {
objRow[conQxRoleMenus.Memo] = objQxRoleMenusEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxRoleMenusEN._CurrTabName);
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
public bool UpdateBySP(clsQxRoleMenusEN objQxRoleMenusEN)
{
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleMenusEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxRoleMenusEN.mId,
 objQxRoleMenusEN.RoleId,
 objQxRoleMenusEN.QxPrjId,
 objQxRoleMenusEN.CmPrjId,
 objQxRoleMenusEN.MenuSetId,
 objQxRoleMenusEN.MenuId,
 objQxRoleMenusEN.IsDisp,
 objQxRoleMenusEN.UpdDate,
 objQxRoleMenusEN.UpdUserId,
 objQxRoleMenusEN.Memo
};
 objSQL.ExecSP("QxRoleMenus_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxRoleMenusEN objQxRoleMenusEN)
{
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleMenusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxRoleMenus Set ");
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.RoleId))
 {
 if (objQxRoleMenusEN.RoleId  ==  "")
 {
 objQxRoleMenusEN.RoleId = null;
 }
 if (objQxRoleMenusEN.RoleId !=  null)
 {
 var strRoleId = objQxRoleMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQxRoleMenus.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.RoleId); //角色Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.QxPrjId))
 {
 if (objQxRoleMenusEN.QxPrjId  ==  "")
 {
 objQxRoleMenusEN.QxPrjId = null;
 }
 if (objQxRoleMenusEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRoleMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxRoleMenus.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.QxPrjId); //项目Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.CmPrjId))
 {
 if (objQxRoleMenusEN.CmPrjId !=  null)
 {
 var strCmPrjId = objQxRoleMenusEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmPrjId, conQxRoleMenus.CmPrjId); //Cm项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.CmPrjId); //Cm项目Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.MenuSetId))
 {
 if (objQxRoleMenusEN.MenuSetId !=  null)
 {
 var strMenuSetId = objQxRoleMenusEN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuSetId, conQxRoleMenus.MenuSetId); //菜单集Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.MenuSetId); //菜单集Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.MenuId))
 {
 if (objQxRoleMenusEN.MenuId  ==  "")
 {
 objQxRoleMenusEN.MenuId = null;
 }
 if (objQxRoleMenusEN.MenuId !=  null)
 {
 var strMenuId = objQxRoleMenusEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId, conQxRoleMenus.MenuId); //菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.MenuId); //菜单Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.IsDisp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxRoleMenusEN.IsDisp == true?"1":"0", conQxRoleMenus.IsDisp); //是否显示
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.UpdDate))
 {
 if (objQxRoleMenusEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRoleMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxRoleMenus.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.UpdDate); //修改日期
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.UpdUserId))
 {
 if (objQxRoleMenusEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRoleMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxRoleMenus.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.Memo))
 {
 if (objQxRoleMenusEN.Memo !=  null)
 {
 var strMemo = objQxRoleMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxRoleMenus.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxRoleMenusEN.mId); 
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
 /// <param name = "objQxRoleMenusEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxRoleMenusEN objQxRoleMenusEN, string strCondition)
{
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleMenusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRoleMenus Set ");
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.RoleId))
 {
 if (objQxRoleMenusEN.RoleId  ==  "")
 {
 objQxRoleMenusEN.RoleId = null;
 }
 if (objQxRoleMenusEN.RoleId !=  null)
 {
 var strRoleId = objQxRoleMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.QxPrjId))
 {
 if (objQxRoleMenusEN.QxPrjId  ==  "")
 {
 objQxRoleMenusEN.QxPrjId = null;
 }
 if (objQxRoleMenusEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRoleMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.CmPrjId))
 {
 if (objQxRoleMenusEN.CmPrjId !=  null)
 {
 var strCmPrjId = objQxRoleMenusEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjId = '{0}',", strCmPrjId); //Cm项目Id
 }
 else
 {
 sbSQL.Append(" CmPrjId = null,"); //Cm项目Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.MenuSetId))
 {
 if (objQxRoleMenusEN.MenuSetId !=  null)
 {
 var strMenuSetId = objQxRoleMenusEN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuSetId = '{0}',", strMenuSetId); //菜单集Id
 }
 else
 {
 sbSQL.Append(" MenuSetId = null,"); //菜单集Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.MenuId))
 {
 if (objQxRoleMenusEN.MenuId  ==  "")
 {
 objQxRoleMenusEN.MenuId = null;
 }
 if (objQxRoleMenusEN.MenuId !=  null)
 {
 var strMenuId = objQxRoleMenusEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId = '{0}',", strMenuId); //菜单Id
 }
 else
 {
 sbSQL.Append(" MenuId = null,"); //菜单Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.IsDisp))
 {
 sbSQL.AppendFormat(" IsDisp = '{0}',", objQxRoleMenusEN.IsDisp == true?"1":"0"); //是否显示
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.UpdDate))
 {
 if (objQxRoleMenusEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRoleMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.UpdUserId))
 {
 if (objQxRoleMenusEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRoleMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.Memo))
 {
 if (objQxRoleMenusEN.Memo !=  null)
 {
 var strMemo = objQxRoleMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxRoleMenusEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxRoleMenusEN objQxRoleMenusEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleMenusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRoleMenus Set ");
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.RoleId))
 {
 if (objQxRoleMenusEN.RoleId  ==  "")
 {
 objQxRoleMenusEN.RoleId = null;
 }
 if (objQxRoleMenusEN.RoleId !=  null)
 {
 var strRoleId = objQxRoleMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.QxPrjId))
 {
 if (objQxRoleMenusEN.QxPrjId  ==  "")
 {
 objQxRoleMenusEN.QxPrjId = null;
 }
 if (objQxRoleMenusEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRoleMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.CmPrjId))
 {
 if (objQxRoleMenusEN.CmPrjId !=  null)
 {
 var strCmPrjId = objQxRoleMenusEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjId = '{0}',", strCmPrjId); //Cm项目Id
 }
 else
 {
 sbSQL.Append(" CmPrjId = null,"); //Cm项目Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.MenuSetId))
 {
 if (objQxRoleMenusEN.MenuSetId !=  null)
 {
 var strMenuSetId = objQxRoleMenusEN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuSetId = '{0}',", strMenuSetId); //菜单集Id
 }
 else
 {
 sbSQL.Append(" MenuSetId = null,"); //菜单集Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.MenuId))
 {
 if (objQxRoleMenusEN.MenuId  ==  "")
 {
 objQxRoleMenusEN.MenuId = null;
 }
 if (objQxRoleMenusEN.MenuId !=  null)
 {
 var strMenuId = objQxRoleMenusEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId = '{0}',", strMenuId); //菜单Id
 }
 else
 {
 sbSQL.Append(" MenuId = null,"); //菜单Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.IsDisp))
 {
 sbSQL.AppendFormat(" IsDisp = '{0}',", objQxRoleMenusEN.IsDisp == true?"1":"0"); //是否显示
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.UpdDate))
 {
 if (objQxRoleMenusEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRoleMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.UpdUserId))
 {
 if (objQxRoleMenusEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRoleMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.Memo))
 {
 if (objQxRoleMenusEN.Memo !=  null)
 {
 var strMemo = objQxRoleMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxRoleMenusEN objQxRoleMenusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleMenusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRoleMenus Set ");
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.RoleId))
 {
 if (objQxRoleMenusEN.RoleId  ==  "")
 {
 objQxRoleMenusEN.RoleId = null;
 }
 if (objQxRoleMenusEN.RoleId !=  null)
 {
 var strRoleId = objQxRoleMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQxRoleMenus.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.RoleId); //角色Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.QxPrjId))
 {
 if (objQxRoleMenusEN.QxPrjId  ==  "")
 {
 objQxRoleMenusEN.QxPrjId = null;
 }
 if (objQxRoleMenusEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRoleMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxRoleMenus.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.QxPrjId); //项目Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.CmPrjId))
 {
 if (objQxRoleMenusEN.CmPrjId !=  null)
 {
 var strCmPrjId = objQxRoleMenusEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmPrjId, conQxRoleMenus.CmPrjId); //Cm项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.CmPrjId); //Cm项目Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.MenuSetId))
 {
 if (objQxRoleMenusEN.MenuSetId !=  null)
 {
 var strMenuSetId = objQxRoleMenusEN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuSetId, conQxRoleMenus.MenuSetId); //菜单集Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.MenuSetId); //菜单集Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.MenuId))
 {
 if (objQxRoleMenusEN.MenuId  ==  "")
 {
 objQxRoleMenusEN.MenuId = null;
 }
 if (objQxRoleMenusEN.MenuId !=  null)
 {
 var strMenuId = objQxRoleMenusEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId, conQxRoleMenus.MenuId); //菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.MenuId); //菜单Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.IsDisp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxRoleMenusEN.IsDisp == true?"1":"0", conQxRoleMenus.IsDisp); //是否显示
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.UpdDate))
 {
 if (objQxRoleMenusEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRoleMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxRoleMenus.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.UpdDate); //修改日期
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.UpdUserId))
 {
 if (objQxRoleMenusEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRoleMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxRoleMenus.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxRoleMenusEN.IsUpdated(conQxRoleMenus.Memo))
 {
 if (objQxRoleMenusEN.Memo !=  null)
 {
 var strMemo = objQxRoleMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxRoleMenus.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleMenus.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxRoleMenusEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("QxRoleMenus_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
//删除QxRoleMenus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRoleMenus where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxRoleMenus(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
//删除QxRoleMenus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRoleMenus where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
//删除QxRoleMenus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRoleMenus where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxRoleMenus(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: DelQxRoleMenus)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxRoleMenus where " + strCondition ;
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
public bool DelQxRoleMenusWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxRoleMenusDA: DelQxRoleMenusWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxRoleMenus where " + strCondition ;
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
 /// <param name = "objQxRoleMenusENS">源对象</param>
 /// <param name = "objQxRoleMenusENT">目标对象</param>
public void CopyTo(clsQxRoleMenusEN objQxRoleMenusENS, clsQxRoleMenusEN objQxRoleMenusENT)
{
objQxRoleMenusENT.mId = objQxRoleMenusENS.mId; //流水号
objQxRoleMenusENT.RoleId = objQxRoleMenusENS.RoleId; //角色Id
objQxRoleMenusENT.QxPrjId = objQxRoleMenusENS.QxPrjId; //项目Id
objQxRoleMenusENT.CmPrjId = objQxRoleMenusENS.CmPrjId; //Cm项目Id
objQxRoleMenusENT.MenuSetId = objQxRoleMenusENS.MenuSetId; //菜单集Id
objQxRoleMenusENT.MenuId = objQxRoleMenusENS.MenuId; //菜单Id
objQxRoleMenusENT.IsDisp = objQxRoleMenusENS.IsDisp; //是否显示
objQxRoleMenusENT.UpdDate = objQxRoleMenusENS.UpdDate; //修改日期
objQxRoleMenusENT.UpdUserId = objQxRoleMenusENS.UpdUserId; //修改用户Id
objQxRoleMenusENT.Memo = objQxRoleMenusENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxRoleMenusEN objQxRoleMenusEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxRoleMenusEN.RoleId, conQxRoleMenus.RoleId);
clsCheckSql.CheckFieldNotNull(objQxRoleMenusEN.QxPrjId, conQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldNotNull(objQxRoleMenusEN.MenuSetId, conQxRoleMenus.MenuSetId);
clsCheckSql.CheckFieldNotNull(objQxRoleMenusEN.MenuId, conQxRoleMenus.MenuId);
clsCheckSql.CheckFieldNotNull(objQxRoleMenusEN.UpdDate, conQxRoleMenus.UpdDate);
clsCheckSql.CheckFieldNotNull(objQxRoleMenusEN.UpdUserId, conQxRoleMenus.UpdUserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.RoleId, 8, conQxRoleMenus.RoleId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.QxPrjId, 4, conQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.CmPrjId, 6, conQxRoleMenus.CmPrjId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.MenuSetId, 4, conQxRoleMenus.MenuSetId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.MenuId, 8, conQxRoleMenus.MenuId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.UpdDate, 20, conQxRoleMenus.UpdDate);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.UpdUserId, 20, conQxRoleMenus.UpdUserId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.Memo, 1000, conQxRoleMenus.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxRoleMenusEN.RoleId, 8, conQxRoleMenus.RoleId);
clsCheckSql.CheckFieldForeignKey(objQxRoleMenusEN.QxPrjId, 4, conQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxRoleMenusEN.MenuId, 8, conQxRoleMenus.MenuId);
 objQxRoleMenusEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxRoleMenusEN objQxRoleMenusEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.RoleId, 8, conQxRoleMenus.RoleId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.QxPrjId, 4, conQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.CmPrjId, 6, conQxRoleMenus.CmPrjId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.MenuSetId, 4, conQxRoleMenus.MenuSetId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.MenuId, 8, conQxRoleMenus.MenuId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.UpdDate, 20, conQxRoleMenus.UpdDate);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.UpdUserId, 20, conQxRoleMenus.UpdUserId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.Memo, 1000, conQxRoleMenus.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxRoleMenusEN.RoleId, 8, conQxRoleMenus.RoleId);
clsCheckSql.CheckFieldForeignKey(objQxRoleMenusEN.QxPrjId, 4, conQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxRoleMenusEN.MenuId, 8, conQxRoleMenus.MenuId);
 objQxRoleMenusEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxRoleMenusEN objQxRoleMenusEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.RoleId, 8, conQxRoleMenus.RoleId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.QxPrjId, 4, conQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.CmPrjId, 6, conQxRoleMenus.CmPrjId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.MenuSetId, 4, conQxRoleMenus.MenuSetId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.MenuId, 8, conQxRoleMenus.MenuId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.UpdDate, 20, conQxRoleMenus.UpdDate);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.UpdUserId, 20, conQxRoleMenus.UpdUserId);
clsCheckSql.CheckFieldLen(objQxRoleMenusEN.Memo, 1000, conQxRoleMenus.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxRoleMenusEN.RoleId, conQxRoleMenus.RoleId);
clsCheckSql.CheckSqlInjection4Field(objQxRoleMenusEN.QxPrjId, conQxRoleMenus.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxRoleMenusEN.CmPrjId, conQxRoleMenus.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxRoleMenusEN.MenuSetId, conQxRoleMenus.MenuSetId);
clsCheckSql.CheckSqlInjection4Field(objQxRoleMenusEN.MenuId, conQxRoleMenus.MenuId);
clsCheckSql.CheckSqlInjection4Field(objQxRoleMenusEN.UpdDate, conQxRoleMenus.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxRoleMenusEN.UpdUserId, conQxRoleMenus.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objQxRoleMenusEN.Memo, conQxRoleMenus.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxRoleMenusEN.RoleId, 8, conQxRoleMenus.RoleId);
clsCheckSql.CheckFieldForeignKey(objQxRoleMenusEN.QxPrjId, 4, conQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxRoleMenusEN.MenuId, 8, conQxRoleMenus.MenuId);
 objQxRoleMenusEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxRoleMenus(角色菜单),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxRoleMenusEN objQxRoleMenusEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxRoleMenusEN.RoleId);
 if (objQxRoleMenusEN.CmPrjId == null)
{
 sbCondition.AppendFormat(" and CmPrjId is null");
}
else
{
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objQxRoleMenusEN.CmPrjId);
}
 sbCondition.AppendFormat(" and MenuSetId = '{0}'", objQxRoleMenusEN.MenuSetId);
 sbCondition.AppendFormat(" and MenuId = '{0}'", objQxRoleMenusEN.MenuId);
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
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxRoleMenusEN._CurrTabName);
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
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxRoleMenusEN._CurrTabName, strCondition);
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
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
 objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}