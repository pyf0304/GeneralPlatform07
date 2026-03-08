
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRoleMenusDA
 表名:vQxRoleMenus(00140034)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:47:16
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
 /// v角色菜单(vQxRoleMenus)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxRoleMenusDA : clsCommBase4DA
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
 return clsvQxRoleMenusEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxRoleMenusEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxRoleMenusEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxRoleMenusEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxRoleMenusEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
 strSQL = "Select * from vQxRoleMenus where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxRoleMenus");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxRoleMenus_SelectByCond",values, "vQxRoleMenus");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxRoleMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxRoleMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxRoleMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxRoleMenus");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxRoleMenus(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTable_vQxRoleMenus)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxRoleMenus.* from vQxRoleMenus Left Join {1} on {2} where {3} and vQxRoleMenus.mId not in (Select top {5} vQxRoleMenus.mId from vQxRoleMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus where {1} and mId not in (Select top {2} mId from vQxRoleMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus where {1} and mId not in (Select top {3} mId from vQxRoleMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxRoleMenus.* from vQxRoleMenus Left Join {1} on {2} where {3} and vQxRoleMenus.mId not in (Select top {5} vQxRoleMenus.mId from vQxRoleMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus where {1} and mId not in (Select top {2} mId from vQxRoleMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus where {1} and mId not in (Select top {3} mId from vQxRoleMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxRoleMenus.* from vQxRoleMenus Left Join {1} on {2} where {3} and vQxRoleMenus.mId not in (Select top {5} vQxRoleMenus.mId from vQxRoleMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus where {1} and mId not in (Select top {2} mId from vQxRoleMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus where {1} and mId not in (Select top {3} mId from vQxRoleMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxRoleMenus a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenusDA: GetvQxRoleMenusByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxRoleMenus_SelectByCond",values);
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
public List<clsvQxRoleMenusEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA:GetObjLst)", objException.Message));
}
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = TransNullToInt(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = TransNullToBool(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = TransNullToBool(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = TransNullToBool(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxRoleMenusDA: GetObjLst)", objException.Message));
}
objvQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxRoleMenusEN);
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
public List<clsvQxRoleMenusEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = TransNullToInt(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = TransNullToBool(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = TransNullToBool(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = TransNullToBool(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxRoleMenusDA: GetObjLst)", objException.Message));
}
objvQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxRoleMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxRoleMenusEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxRoleMenus_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = TransNullToInt(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = TransNullToBool(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = TransNullToBool(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = TransNullToBool(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxRoleMenusDA: GetObjLstBySP)", objException.Message));
}
objvQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxRoleMenusEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxRoleMenus(ref clsvQxRoleMenusEN objvQxRoleMenusEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus where mId = " + ""+ objvQxRoleMenusEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxRoleMenusEN.mId = TransNullToInt(objDT.Rows[0][convQxRoleMenus.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxRoleMenusEN.RoleId = objDT.Rows[0][convQxRoleMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenusEN.RoleName = objDT.Rows[0][convQxRoleMenus.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRoleMenusEN.QxPrjId = objDT.Rows[0][convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenusEN.MenuId = objDT.Rows[0][convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxRoleMenusEN.MenuName = objDT.Rows[0][convQxRoleMenus.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRoleMenusEN.PrjName = objDT.Rows[0][convQxRoleMenus.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxRoleMenusEN.UpMenuId = objDT.Rows[0][convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenusEN.LinkFile = objDT.Rows[0][convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxRoleMenusEN.qsParameters = objDT.Rows[0][convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxRoleMenusEN.ImgFile = objDT.Rows[0][convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxRoleMenusEN.OrderNum = TransNullToInt(objDT.Rows[0][convQxRoleMenus.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxRoleMenusEN.IsLeafNode = TransNullToBool(objDT.Rows[0][convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenusEN.MenuSetId = objDT.Rows[0][convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenusEN.MenuSetName = objDT.Rows[0][convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenusEN.MenuTitle = objDT.Rows[0][convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenusEN.PageDispModeId = objDT.Rows[0][convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxRoleMenusEN.PageDispModeName = objDT.Rows[0][convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenusEN.InUse = TransNullToBool(objDT.Rows[0][convQxRoleMenus.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenusEN.UpMenuName = objDT.Rows[0][convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxRoleMenusEN.RoleNum = TransNullToInt(objDT.Rows[0][convQxRoleMenus.RoleNum].ToString().Trim()); //角色数(字段类型:int,字段长度:4,是否可空:True)
 objvQxRoleMenusEN.IsDisp = TransNullToBool(objDT.Rows[0][convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objvQxRoleMenusEN.UpdDate = objDT.Rows[0][convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxRoleMenusEN.UpdUserId = objDT.Rows[0][convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxRoleMenusEN.Memo = objDT.Rows[0][convQxRoleMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxRoleMenusDA: GetvQxRoleMenus)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxRoleMenusEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
 objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数(字段类型:int,字段长度:4,是否可空:True)
 objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxRoleMenusDA: GetObjBymId)", objException.Message));
}
return objvQxRoleMenusEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxRoleMenus_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxRoleMenusOneBySP(clsvQxRoleMenusEN objvQxRoleMenusEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxRoleMenusEN.mId
};
 objDT = objSQL.ExecSpReturnDT("vQxRoleMenus_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxRoleMenusEN.mId = TransNullToInt(objDT.Rows[0][convQxRoleMenus.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxRoleMenusEN.RoleId = objDT.Rows[0][convQxRoleMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenusEN.RoleName = objDT.Rows[0][convQxRoleMenus.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRoleMenusEN.QxPrjId = objDT.Rows[0][convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenusEN.MenuId = objDT.Rows[0][convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxRoleMenusEN.MenuName = objDT.Rows[0][convQxRoleMenus.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRoleMenusEN.PrjName = objDT.Rows[0][convQxRoleMenus.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxRoleMenusEN.UpMenuId = objDT.Rows[0][convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenusEN.LinkFile = objDT.Rows[0][convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxRoleMenusEN.qsParameters = objDT.Rows[0][convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxRoleMenusEN.ImgFile = objDT.Rows[0][convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxRoleMenusEN.OrderNum = TransNullToInt(objDT.Rows[0][convQxRoleMenus.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxRoleMenusEN.IsLeafNode = TransNullToBool(objDT.Rows[0][convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenusEN.MenuSetId = objDT.Rows[0][convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenusEN.MenuSetName = objDT.Rows[0][convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenusEN.MenuTitle = objDT.Rows[0][convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenusEN.PageDispModeId = objDT.Rows[0][convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxRoleMenusEN.PageDispModeName = objDT.Rows[0][convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenusEN.InUse = TransNullToBool(objDT.Rows[0][convQxRoleMenus.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenusEN.UpMenuName = objDT.Rows[0][convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxRoleMenusEN.RoleNum = TransNullToInt(objDT.Rows[0][convQxRoleMenus.RoleNum].ToString().Trim()); //角色数(字段类型:int,字段长度:4,是否可空:True)
 objvQxRoleMenusEN.IsDisp = TransNullToBool(objDT.Rows[0][convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objvQxRoleMenusEN.UpdDate = objDT.Rows[0][convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxRoleMenusEN.UpdUserId = objDT.Rows[0][convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxRoleMenusEN.Memo = objDT.Rows[0][convQxRoleMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxRoleMenusEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN()
{
mId = TransNullToInt(objRow[convQxRoleMenus.mId].ToString().Trim()), //流水号
RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(), //角色Id
RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(), //角色名称
QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(), //项目Id
MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(), //菜单Id
MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(), //菜单名
PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(), //工程名
UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(), //qs参数
ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(), //图像文件
OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(), //菜单集Id
MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(), //菜单集名称
MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(), //页面显示模式Id
PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(), //页面显示模式名称
InUse = TransNullToBool(objRow[convQxRoleMenus.InUse].ToString().Trim()), //是否在用
UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(), //上级菜单名
RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.RoleNum].ToString().Trim()), //角色数
IsDisp = TransNullToBool(objRow[convQxRoleMenus.IsDisp].ToString().Trim()), //是否显示
UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim() //备注
};
objvQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRoleMenusEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxRoleMenusDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxRoleMenusEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxRoleMenus_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN()
{
mId = TransNullToInt(objRow[convQxRoleMenus.mId].ToString().Trim()), //流水号
RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(), //角色Id
RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(), //角色名称
QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(), //项目Id
MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(), //菜单Id
MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(), //菜单名
PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(), //工程名
UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(), //qs参数
ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(), //图像文件
OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(), //菜单集Id
MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(), //菜单集名称
MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(), //页面显示模式Id
PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(), //页面显示模式名称
InUse = TransNullToBool(objRow[convQxRoleMenus.InUse].ToString().Trim()), //是否在用
UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(), //上级菜单名
RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.RoleNum].ToString().Trim()), //角色数
IsDisp = TransNullToBool(objRow[convQxRoleMenus.IsDisp].ToString().Trim()), //是否显示
UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim() //备注
};
objvQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRoleMenusEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxRoleMenusEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = TransNullToInt(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = TransNullToBool(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = TransNullToBool(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = TransNullToBool(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxRoleMenusDA: GetObjByDataRowvQxRoleMenus)", objException.Message));
}
objvQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRoleMenusEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxRoleMenusEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = TransNullToInt(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = TransNullToBool(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = TransNullToBool(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = TransNullToBool(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxRoleMenusDA: GetObjByDataRow)", objException.Message));
}
objvQxRoleMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRoleMenusEN;
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
objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxRoleMenusEN._CurrTabName, convQxRoleMenus.mId, 8, "");
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
objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxRoleMenusEN._CurrTabName, convQxRoleMenus.mId, 8, strPrefix);
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
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vQxRoleMenus where " + strCondition;
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
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vQxRoleMenus where " + strCondition;
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
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxRoleMenus", "mId = " + ""+ lngmId+""))
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
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxRoleMenus_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxRoleMenusDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxRoleMenus", strCondition))
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
objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxRoleMenus");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxRoleMenusENS">源对象</param>
 /// <param name = "objvQxRoleMenusENT">目标对象</param>
public void CopyTo(clsvQxRoleMenusEN objvQxRoleMenusENS, clsvQxRoleMenusEN objvQxRoleMenusENT)
{
objvQxRoleMenusENT.mId = objvQxRoleMenusENS.mId; //流水号
objvQxRoleMenusENT.RoleId = objvQxRoleMenusENS.RoleId; //角色Id
objvQxRoleMenusENT.RoleName = objvQxRoleMenusENS.RoleName; //角色名称
objvQxRoleMenusENT.QxPrjId = objvQxRoleMenusENS.QxPrjId; //项目Id
objvQxRoleMenusENT.MenuId = objvQxRoleMenusENS.MenuId; //菜单Id
objvQxRoleMenusENT.MenuName = objvQxRoleMenusENS.MenuName; //菜单名
objvQxRoleMenusENT.PrjName = objvQxRoleMenusENS.PrjName; //工程名
objvQxRoleMenusENT.UpMenuId = objvQxRoleMenusENS.UpMenuId; //上级菜单Id
objvQxRoleMenusENT.LinkFile = objvQxRoleMenusENS.LinkFile; //链接文件
objvQxRoleMenusENT.qsParameters = objvQxRoleMenusENS.qsParameters; //qs参数
objvQxRoleMenusENT.ImgFile = objvQxRoleMenusENS.ImgFile; //图像文件
objvQxRoleMenusENT.OrderNum = objvQxRoleMenusENS.OrderNum; //排序号
objvQxRoleMenusENT.IsLeafNode = objvQxRoleMenusENS.IsLeafNode; //是否叶子
objvQxRoleMenusENT.MenuSetId = objvQxRoleMenusENS.MenuSetId; //菜单集Id
objvQxRoleMenusENT.MenuSetName = objvQxRoleMenusENS.MenuSetName; //菜单集名称
objvQxRoleMenusENT.MenuTitle = objvQxRoleMenusENS.MenuTitle; //菜单标题
objvQxRoleMenusENT.PageDispModeId = objvQxRoleMenusENS.PageDispModeId; //页面显示模式Id
objvQxRoleMenusENT.PageDispModeName = objvQxRoleMenusENS.PageDispModeName; //页面显示模式名称
objvQxRoleMenusENT.InUse = objvQxRoleMenusENS.InUse; //是否在用
objvQxRoleMenusENT.UpMenuName = objvQxRoleMenusENS.UpMenuName; //上级菜单名
objvQxRoleMenusENT.RoleNum = objvQxRoleMenusENS.RoleNum; //角色数
objvQxRoleMenusENT.IsDisp = objvQxRoleMenusENS.IsDisp; //是否显示
objvQxRoleMenusENT.UpdDate = objvQxRoleMenusENS.UpdDate; //修改日期
objvQxRoleMenusENT.UpdUserId = objvQxRoleMenusENS.UpdUserId; //修改用户Id
objvQxRoleMenusENT.Memo = objvQxRoleMenusENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxRoleMenusEN objvQxRoleMenusEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.RoleId, 8, convQxRoleMenus.RoleId);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.RoleName, 50, convQxRoleMenus.RoleName);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.QxPrjId, 4, convQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.MenuId, 8, convQxRoleMenus.MenuId);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.MenuName, 50, convQxRoleMenus.MenuName);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.PrjName, 30, convQxRoleMenus.PrjName);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.UpMenuId, 8, convQxRoleMenus.UpMenuId);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.LinkFile, 500, convQxRoleMenus.LinkFile);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.qsParameters, 200, convQxRoleMenus.qsParameters);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.ImgFile, 300, convQxRoleMenus.ImgFile);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.MenuSetId, 4, convQxRoleMenus.MenuSetId);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.MenuSetName, 50, convQxRoleMenus.MenuSetName);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.MenuTitle, 50, convQxRoleMenus.MenuTitle);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.PageDispModeId, 2, convQxRoleMenus.PageDispModeId);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.PageDispModeName, 50, convQxRoleMenus.PageDispModeName);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.UpMenuName, 30, convQxRoleMenus.UpMenuName);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.UpdDate, 20, convQxRoleMenus.UpdDate);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.UpdUserId, 20, convQxRoleMenus.UpdUserId);
clsCheckSql.CheckFieldLen(objvQxRoleMenusEN.Memo, 1000, convQxRoleMenus.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.RoleId, convQxRoleMenus.RoleId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.RoleName, convQxRoleMenus.RoleName);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.QxPrjId, convQxRoleMenus.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.MenuId, convQxRoleMenus.MenuId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.MenuName, convQxRoleMenus.MenuName);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.PrjName, convQxRoleMenus.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.UpMenuId, convQxRoleMenus.UpMenuId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.LinkFile, convQxRoleMenus.LinkFile);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.qsParameters, convQxRoleMenus.qsParameters);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.ImgFile, convQxRoleMenus.ImgFile);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.MenuSetId, convQxRoleMenus.MenuSetId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.MenuSetName, convQxRoleMenus.MenuSetName);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.MenuTitle, convQxRoleMenus.MenuTitle);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.PageDispModeId, convQxRoleMenus.PageDispModeId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.PageDispModeName, convQxRoleMenus.PageDispModeName);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.UpMenuName, convQxRoleMenus.UpMenuName);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.UpdDate, convQxRoleMenus.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.UpdUserId, convQxRoleMenus.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenusEN.Memo, convQxRoleMenus.Memo);
//检查外键字段长度
 objvQxRoleMenusEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

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
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
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
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
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
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxRoleMenusEN._CurrTabName);
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
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxRoleMenusEN._CurrTabName, strCondition);
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
 objSQL = clsvQxRoleMenusDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}