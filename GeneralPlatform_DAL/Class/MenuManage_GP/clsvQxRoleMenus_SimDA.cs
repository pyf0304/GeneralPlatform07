
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRoleMenus_SimDA
 表名:vQxRoleMenus_Sim(00140073)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:35:04
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
 /// v角色菜单_Sim(vQxRoleMenus_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxRoleMenus_SimDA : clsCommBase4DA
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
 return clsvQxRoleMenus_SimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxRoleMenus_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxRoleMenus_SimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxRoleMenus_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxRoleMenus_SimEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
 strSQL = "Select * from vQxRoleMenus_Sim where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxRoleMenus_Sim");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxRoleMenus_Sim_SelectByCond",values, "vQxRoleMenus_Sim");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus_Sim where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxRoleMenus_Sim");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxRoleMenus_Sim a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus_Sim Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxRoleMenus_Sim");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxRoleMenus_Sim a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus_Sim Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxRoleMenus_Sim");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxRoleMenus_Sim a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus_Sim Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxRoleMenus_Sim");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxRoleMenus_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTable_vQxRoleMenus_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxRoleMenus_Sim.* from vQxRoleMenus_Sim Left Join {1} on {2} where {3} and vQxRoleMenus_Sim.mId not in (Select top {5} vQxRoleMenus_Sim.mId from vQxRoleMenus_Sim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus_Sim where {1} and mId not in (Select top {2} mId from vQxRoleMenus_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus_Sim where {1} and mId not in (Select top {3} mId from vQxRoleMenus_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxRoleMenus_Sim.* from vQxRoleMenus_Sim Left Join {1} on {2} where {3} and vQxRoleMenus_Sim.mId not in (Select top {5} vQxRoleMenus_Sim.mId from vQxRoleMenus_Sim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus_Sim where {1} and mId not in (Select top {2} mId from vQxRoleMenus_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus_Sim where {1} and mId not in (Select top {3} mId from vQxRoleMenus_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxRoleMenus_Sim.* from vQxRoleMenus_Sim Left Join {1} on {2} where {3} and vQxRoleMenus_Sim.mId not in (Select top {5} vQxRoleMenus_Sim.mId from vQxRoleMenus_Sim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus_Sim where {1} and mId not in (Select top {2} mId from vQxRoleMenus_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRoleMenus_Sim where {1} and mId not in (Select top {3} mId from vQxRoleMenus_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxRoleMenus_Sim a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus_Sim Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxRoleMenus_Sim a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus_Sim Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxRoleMenus_Sim a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus_Sim Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxRoleMenus_Sim a where {0} And a.mId not in (Select Top {2} mId From vQxRoleMenus_Sim Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_SimByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxRoleMenus_Sim_SelectByCond",values);
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
public List<clsvQxRoleMenus_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA:GetObjLst)", objException.Message));
}
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = TransNullToInt(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = TransNullToBool(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = TransNullToBool(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxRoleMenus_SimDA: GetObjLst)", objException.Message));
}
objvQxRoleMenus_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxRoleMenus_SimEN);
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
public List<clsvQxRoleMenus_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = TransNullToInt(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = TransNullToBool(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = TransNullToBool(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxRoleMenus_SimDA: GetObjLst)", objException.Message));
}
objvQxRoleMenus_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxRoleMenus_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxRoleMenus_SimEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxRoleMenus_Sim_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = TransNullToInt(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = TransNullToBool(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = TransNullToBool(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxRoleMenus_SimDA: GetObjLstBySP)", objException.Message));
}
objvQxRoleMenus_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxRoleMenus_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxRoleMenus_Sim(ref clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus_Sim where mId = " + ""+ objvQxRoleMenus_SimEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxRoleMenus_SimEN.mId = TransNullToInt(objDT.Rows[0][convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxRoleMenus_SimEN.RoleId = objDT.Rows[0][convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenus_SimEN.QxPrjId = objDT.Rows[0][convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenus_SimEN.MenuId = objDT.Rows[0][convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxRoleMenus_SimEN.MenuName = objDT.Rows[0][convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRoleMenus_SimEN.UpMenuId = objDT.Rows[0][convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenus_SimEN.LinkFile = objDT.Rows[0][convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxRoleMenus_SimEN.qsParameters = objDT.Rows[0][convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxRoleMenus_SimEN.ImgFile = objDT.Rows[0][convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxRoleMenus_SimEN.OrderNum = TransNullToInt(objDT.Rows[0][convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxRoleMenus_SimEN.IsLeafNode = TransNullToBool(objDT.Rows[0][convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenus_SimEN.MenuSetId = objDT.Rows[0][convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenus_SimEN.MenuTitle = objDT.Rows[0][convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenus_SimEN.PageDispModeId = objDT.Rows[0][convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxRoleMenus_SimEN.InUse = TransNullToBool(objDT.Rows[0][convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenus_SimEN.UpMenuName = objDT.Rows[0][convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxRoleMenus_SimDA: GetvQxRoleMenus_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxRoleMenus_SimEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus_Sim where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
 objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxRoleMenus_SimDA: GetObjBymId)", objException.Message));
}
return objvQxRoleMenus_SimEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxRoleMenus_Sim_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxRoleMenus_SimOneBySP(clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxRoleMenus_SimEN.mId
};
 objDT = objSQL.ExecSpReturnDT("vQxRoleMenus_Sim_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxRoleMenus_SimEN.mId = TransNullToInt(objDT.Rows[0][convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxRoleMenus_SimEN.RoleId = objDT.Rows[0][convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenus_SimEN.QxPrjId = objDT.Rows[0][convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenus_SimEN.MenuId = objDT.Rows[0][convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxRoleMenus_SimEN.MenuName = objDT.Rows[0][convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRoleMenus_SimEN.UpMenuId = objDT.Rows[0][convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxRoleMenus_SimEN.LinkFile = objDT.Rows[0][convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxRoleMenus_SimEN.qsParameters = objDT.Rows[0][convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxRoleMenus_SimEN.ImgFile = objDT.Rows[0][convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxRoleMenus_SimEN.OrderNum = TransNullToInt(objDT.Rows[0][convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxRoleMenus_SimEN.IsLeafNode = TransNullToBool(objDT.Rows[0][convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenus_SimEN.MenuSetId = objDT.Rows[0][convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxRoleMenus_SimEN.MenuTitle = objDT.Rows[0][convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxRoleMenus_SimEN.PageDispModeId = objDT.Rows[0][convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxRoleMenus_SimEN.InUse = TransNullToBool(objDT.Rows[0][convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxRoleMenus_SimEN.UpMenuName = objDT.Rows[0][convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名(字段类型:varchar,字段长度:30,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxRoleMenus_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQxRoleMenus_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN()
{
mId = TransNullToInt(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()), //流水号
RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(), //角色Id
QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(), //项目Id
MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(), //菜单Id
MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(), //菜单名
UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(), //qs参数
ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(), //图像文件
OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(), //菜单集Id
MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(), //页面显示模式Id
InUse = TransNullToBool(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()), //是否在用
UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim() //上级菜单名
};
objvQxRoleMenus_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRoleMenus_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxRoleMenus_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxRoleMenus_SimEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxRoleMenus_Sim_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN()
{
mId = TransNullToInt(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()), //流水号
RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(), //角色Id
QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(), //项目Id
MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(), //菜单Id
MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(), //菜单名
UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(), //qs参数
ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(), //图像文件
OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(), //菜单集Id
MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(), //页面显示模式Id
InUse = TransNullToBool(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()), //是否在用
UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim() //上级菜单名
};
objvQxRoleMenus_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRoleMenus_SimEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxRoleMenus_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = TransNullToInt(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = TransNullToBool(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = TransNullToBool(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxRoleMenus_SimDA: GetObjByDataRowvQxRoleMenus_Sim)", objException.Message));
}
objvQxRoleMenus_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRoleMenus_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxRoleMenus_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = TransNullToInt(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = TransNullToBool(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = TransNullToBool(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxRoleMenus_SimDA: GetObjByDataRow)", objException.Message));
}
objvQxRoleMenus_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRoleMenus_SimEN;
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
objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxRoleMenus_SimEN._CurrTabName, convQxRoleMenus_Sim.mId, 8, "");
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
objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxRoleMenus_SimEN._CurrTabName, convQxRoleMenus_Sim.mId, 8, strPrefix);
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
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vQxRoleMenus_Sim where " + strCondition;
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
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vQxRoleMenus_Sim where " + strCondition;
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
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxRoleMenus_Sim", "mId = " + ""+ lngmId+""))
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
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxRoleMenus_Sim_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxRoleMenus_Sim", strCondition))
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
objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxRoleMenus_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimENS">源对象</param>
 /// <param name = "objvQxRoleMenus_SimENT">目标对象</param>
public void CopyTo(clsvQxRoleMenus_SimEN objvQxRoleMenus_SimENS, clsvQxRoleMenus_SimEN objvQxRoleMenus_SimENT)
{
objvQxRoleMenus_SimENT.mId = objvQxRoleMenus_SimENS.mId; //流水号
objvQxRoleMenus_SimENT.RoleId = objvQxRoleMenus_SimENS.RoleId; //角色Id
objvQxRoleMenus_SimENT.QxPrjId = objvQxRoleMenus_SimENS.QxPrjId; //项目Id
objvQxRoleMenus_SimENT.MenuId = objvQxRoleMenus_SimENS.MenuId; //菜单Id
objvQxRoleMenus_SimENT.MenuName = objvQxRoleMenus_SimENS.MenuName; //菜单名
objvQxRoleMenus_SimENT.UpMenuId = objvQxRoleMenus_SimENS.UpMenuId; //上级菜单Id
objvQxRoleMenus_SimENT.LinkFile = objvQxRoleMenus_SimENS.LinkFile; //链接文件
objvQxRoleMenus_SimENT.qsParameters = objvQxRoleMenus_SimENS.qsParameters; //qs参数
objvQxRoleMenus_SimENT.ImgFile = objvQxRoleMenus_SimENS.ImgFile; //图像文件
objvQxRoleMenus_SimENT.OrderNum = objvQxRoleMenus_SimENS.OrderNum; //排序号
objvQxRoleMenus_SimENT.IsLeafNode = objvQxRoleMenus_SimENS.IsLeafNode; //是否叶子
objvQxRoleMenus_SimENT.MenuSetId = objvQxRoleMenus_SimENS.MenuSetId; //菜单集Id
objvQxRoleMenus_SimENT.MenuTitle = objvQxRoleMenus_SimENS.MenuTitle; //菜单标题
objvQxRoleMenus_SimENT.PageDispModeId = objvQxRoleMenus_SimENS.PageDispModeId; //页面显示模式Id
objvQxRoleMenus_SimENT.InUse = objvQxRoleMenus_SimENS.InUse; //是否在用
objvQxRoleMenus_SimENT.UpMenuName = objvQxRoleMenus_SimENS.UpMenuName; //上级菜单名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.RoleId, 8, convQxRoleMenus_Sim.RoleId);
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.QxPrjId, 4, convQxRoleMenus_Sim.QxPrjId);
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.MenuId, 8, convQxRoleMenus_Sim.MenuId);
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.MenuName, 50, convQxRoleMenus_Sim.MenuName);
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.UpMenuId, 8, convQxRoleMenus_Sim.UpMenuId);
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.LinkFile, 500, convQxRoleMenus_Sim.LinkFile);
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.qsParameters, 200, convQxRoleMenus_Sim.qsParameters);
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.ImgFile, 300, convQxRoleMenus_Sim.ImgFile);
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.MenuSetId, 4, convQxRoleMenus_Sim.MenuSetId);
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.MenuTitle, 50, convQxRoleMenus_Sim.MenuTitle);
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.PageDispModeId, 2, convQxRoleMenus_Sim.PageDispModeId);
clsCheckSql.CheckFieldLen(objvQxRoleMenus_SimEN.UpMenuName, 30, convQxRoleMenus_Sim.UpMenuName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.RoleId, convQxRoleMenus_Sim.RoleId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.QxPrjId, convQxRoleMenus_Sim.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.MenuId, convQxRoleMenus_Sim.MenuId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.MenuName, convQxRoleMenus_Sim.MenuName);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.UpMenuId, convQxRoleMenus_Sim.UpMenuId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.LinkFile, convQxRoleMenus_Sim.LinkFile);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.qsParameters, convQxRoleMenus_Sim.qsParameters);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.ImgFile, convQxRoleMenus_Sim.ImgFile);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.MenuSetId, convQxRoleMenus_Sim.MenuSetId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.MenuTitle, convQxRoleMenus_Sim.MenuTitle);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.PageDispModeId, convQxRoleMenus_Sim.PageDispModeId);
clsCheckSql.CheckSqlInjection4Field(objvQxRoleMenus_SimEN.UpMenuName, convQxRoleMenus_Sim.UpMenuName);
//检查外键字段长度
 objvQxRoleMenus_SimEN._IsCheckProperty = true;
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
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
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
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
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
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxRoleMenus_SimEN._CurrTabName);
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
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxRoleMenus_SimEN._CurrTabName, strCondition);
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
 objSQL = clsvQxRoleMenus_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}