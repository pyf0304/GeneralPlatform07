
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRolesDA
 表名:QxRoles(00140014)
 * 版本:2024.08.23.1(服务器:WIN-SRV103-116)
 日期:2024/08/29 09:32:10
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
 /// 角色(QxRoles)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxRolesDA : clsCommBase4DA
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
 return clsQxRolesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxRolesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxRolesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxRolesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxRolesEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strRoleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strRoleId)
{
strRoleId = strRoleId.Replace("'", "''");
if (strRoleId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:QxRoles中,检查关键字,长度不正确!(clsQxRolesDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRoleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxRoles中,关键字不能为空 或 null!(clsQxRolesDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRoleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxRolesDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strRoleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strRoleId)
{
strRoleId = strRoleId.Replace("'", "''");
if (strRoleId.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:QxRoles中,检查关键字,长度不正确!(简化版)(clsQxRolesDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRoleId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxRoles中,关键字不能为空 或 null!(clsQxRolesDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRoleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxRolesDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
 strSQL = "Select * from QxRoles where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxRoles");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxRoles_SelectByCond",values, "QxRoles");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRoles where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxRoles");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRoles a where {0} And a.RoleId not in (Select Top {2} RoleId From QxRoles Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRoles");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRoles a where {0} And a.RoleId not in (Select Top {2} RoleId From QxRoles Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRoles");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRoles a where {0} And a.RoleId not in (Select Top {2} RoleId From QxRoles Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRoles");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxRoles(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTable_QxRoles)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoles where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoles where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRoles where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRoles where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRoles.* from QxRoles Left Join {1} on {2} where {3} and QxRoles.RoleId not in (Select top {5} QxRoles.RoleId from QxRoles Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoles where {1} and RoleId not in (Select top {2} RoleId from QxRoles where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoles where {1} and RoleId not in (Select top {3} RoleId from QxRoles where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRoles.* from QxRoles Left Join {1} on {2} where {3} and QxRoles.RoleId not in (Select top {5} QxRoles.RoleId from QxRoles Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoles where {1} and RoleId not in (Select top {2} RoleId from QxRoles where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoles where {1} and RoleId not in (Select top {3} RoleId from QxRoles where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRoles.* from QxRoles Left Join {1} on {2} where {3} and QxRoles.RoleId not in (Select top {5} QxRoles.RoleId from QxRoles Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoles where {1} and RoleId not in (Select top {2} RoleId from QxRoles where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoles where {1} and RoleId not in (Select top {3} RoleId from QxRoles where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxRoles a where {0} And a.RoleId not in (Select Top {2} RoleId From QxRoles Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxRoles a where {0} And a.RoleId not in (Select Top {2} RoleId From QxRoles Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxRoles a where {0} And a.RoleId not in (Select Top {2} RoleId From QxRoles Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxRoles a where {0} And a.RoleId not in (Select Top {2} RoleId From QxRoles Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRolesDA: GetQxRolesByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxRolesDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRoles_SelectByCond",values);
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
public List<clsQxRolesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxRolesDA:GetObjLst)", objException.Message));
}
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名称
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //项目Id
objQxRolesEN.IsInUse = TransNullToBool(objRow[conQxRoles.IsInUse].ToString().Trim()); //是否在使用
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxRolesDA: GetObjLst)", objException.Message));
}
objQxRolesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRolesEN);
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
public List<clsQxRolesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxRolesDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名称
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //项目Id
objQxRolesEN.IsInUse = TransNullToBool(objRow[conQxRoles.IsInUse].ToString().Trim()); //是否在使用
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxRolesDA: GetObjLst)", objException.Message));
}
objQxRolesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRolesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxRolesEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxRolesDA:GetObjLstBySP)", objException.Message));
}
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRoles_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名称
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //项目Id
objQxRolesEN.IsInUse = TransNullToBool(objRow[conQxRoles.IsInUse].ToString().Trim()); //是否在使用
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxRolesDA: GetObjLstBySP)", objException.Message));
}
objQxRolesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRolesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxRolesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxRoles(ref clsQxRolesEN objQxRolesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where RoleId = " + "'"+ objQxRolesEN.RoleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxRolesEN.RoleId = objDT.Rows[0][conQxRoles.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRolesEN.RoleName = objDT.Rows[0][conQxRoles.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objQxRolesEN.RoleENName = objDT.Rows[0][conQxRoles.RoleENName].ToString().Trim(); //角色英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objQxRolesEN.RoleIndex = TransNullToInt(objDT.Rows[0][conQxRoles.RoleIndex].ToString().Trim()); //角色序号(字段类型:int,字段长度:4,是否可空:True)
 objQxRolesEN.UserType = objDT.Rows[0][conQxRoles.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objQxRolesEN.QxPrjId = objDT.Rows[0][conQxRoles.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRolesEN.IsInUse = TransNullToBool(objDT.Rows[0][conQxRoles.IsInUse].ToString().Trim()); //是否在使用(字段类型:bit,字段长度:1,是否可空:True)
 objQxRolesEN.UpdDate = objDT.Rows[0][conQxRoles.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRolesEN.UpdUserId = objDT.Rows[0][conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRolesEN.Memo = objDT.Rows[0][conQxRoles.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxRolesDA: GetQxRoles)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxRolesEN GetObjByRoleId(string strRoleId)
{
CheckPrimaryKey(strRoleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where RoleId = " + "'"+ strRoleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
 objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号(字段类型:int,字段长度:4,是否可空:True)
 objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[conQxRoles.IsInUse].ToString().Trim()); //是否在使用(字段类型:bit,字段长度:1,是否可空:True)
 objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxRolesDA: GetObjByRoleId)", objException.Message));
}
return objQxRolesEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxRoles_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxRolesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxRolesOneBySP(clsQxRolesEN objQxRolesEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxRolesEN.RoleId
};
 objDT = objSQL.ExecSpReturnDT("QxRoles_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxRolesEN.RoleId = objDT.Rows[0][conQxRoles.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRolesEN.RoleName = objDT.Rows[0][conQxRoles.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objQxRolesEN.RoleENName = objDT.Rows[0][conQxRoles.RoleENName].ToString().Trim(); //角色英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objQxRolesEN.RoleIndex = TransNullToInt(objDT.Rows[0][conQxRoles.RoleIndex].ToString().Trim()); //角色序号(字段类型:int,字段长度:4,是否可空:True)
 objQxRolesEN.UserType = objDT.Rows[0][conQxRoles.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objQxRolesEN.QxPrjId = objDT.Rows[0][conQxRoles.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRolesEN.IsInUse = TransNullToBool(objDT.Rows[0][conQxRoles.IsInUse].ToString().Trim()); //是否在使用(字段类型:bit,字段长度:1,是否可空:True)
 objQxRolesEN.UpdDate = objDT.Rows[0][conQxRoles.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRolesEN.UpdUserId = objDT.Rows[0][conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRolesEN.Memo = objDT.Rows[0][conQxRoles.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxRolesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxRolesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN()
{
RoleId = objRow[conQxRoles.RoleId].ToString().Trim(), //角色Id
RoleName = objRow[conQxRoles.RoleName].ToString().Trim(), //角色名称
RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(), //角色英文名
RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxRoles.RoleIndex].ToString().Trim()), //角色序号
UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(), //用户类型
QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(), //项目Id
IsInUse = TransNullToBool(objRow[conQxRoles.IsInUse].ToString().Trim()), //是否在使用
UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim() //备注
};
objQxRolesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRolesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxRolesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxRolesEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxRolesDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRoles_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN()
{
RoleId = objRow[conQxRoles.RoleId].ToString().Trim(), //角色Id
RoleName = objRow[conQxRoles.RoleName].ToString().Trim(), //角色名称
RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(), //角色英文名
RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxRoles.RoleIndex].ToString().Trim()), //角色序号
UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(), //用户类型
QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(), //项目Id
IsInUse = TransNullToBool(objRow[conQxRoles.IsInUse].ToString().Trim()), //是否在使用
UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim() //备注
};
objQxRolesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRolesEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxRolesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名称
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //项目Id
objQxRolesEN.IsInUse = TransNullToBool(objRow[conQxRoles.IsInUse].ToString().Trim()); //是否在使用
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxRolesDA: GetObjByDataRowQxRoles)", objException.Message));
}
objQxRolesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRolesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxRolesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名称
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //项目Id
objQxRolesEN.IsInUse = TransNullToBool(objRow[conQxRoles.IsInUse].ToString().Trim()); //是否在使用
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxRolesDA: GetObjByDataRow)", objException.Message));
}
objQxRolesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRolesEN;
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
objSQL = clsQxRolesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxRolesEN._CurrTabName, conQxRoles.RoleId, 8, "");
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
objSQL = clsQxRolesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxRolesEN._CurrTabName, conQxRoles.RoleId, 8, strPrefix);
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
 objSQL = clsQxRolesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RoleId from QxRoles where " + strCondition;
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
 objSQL = clsQxRolesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RoleId from QxRoles where " + strCondition;
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
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strRoleId)
{
CheckPrimaryKey(strRoleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxRoles", "RoleId = " + "'"+ strRoleId+"'"))
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
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strRoleId)
{
CheckPrimaryKey(strRoleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strRoleId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxRoles_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxRolesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxRoles", strCondition))
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
objSQL = clsQxRolesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxRoles");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxRolesEN objQxRolesEN)
 {
 objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRolesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRolesEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxRoles");
objRow = objDS.Tables["QxRoles"].NewRow();
objRow[conQxRoles.RoleId] = objQxRolesEN.RoleId; //角色Id
objRow[conQxRoles.RoleName] = objQxRolesEN.RoleName; //角色名称
 if (objQxRolesEN.RoleENName !=  "")
 {
objRow[conQxRoles.RoleENName] = objQxRolesEN.RoleENName; //角色英文名
 }
objRow[conQxRoles.RoleIndex] = objQxRolesEN.RoleIndex; //角色序号
 if (objQxRolesEN.UserType !=  "")
 {
objRow[conQxRoles.UserType] = objQxRolesEN.UserType; //用户类型
 }
objRow[conQxRoles.QxPrjId] = objQxRolesEN.QxPrjId; //项目Id
objRow[conQxRoles.IsInUse] = objQxRolesEN.IsInUse; //是否在使用
 if (objQxRolesEN.UpdDate !=  "")
 {
objRow[conQxRoles.UpdDate] = objQxRolesEN.UpdDate; //修改日期
 }
 if (objQxRolesEN.UpdUserId !=  "")
 {
objRow[conQxRoles.UpdUserId] = objQxRolesEN.UpdUserId; //修改用户Id
 }
 if (objQxRolesEN.Memo !=  "")
 {
objRow[conQxRoles.Memo] = objQxRolesEN.Memo; //备注
 }
objDS.Tables[clsQxRolesEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxRolesEN._CurrTabName);
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
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxRolesEN objQxRolesEN)
{
 objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRolesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRolesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxRolesEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleId);
 var strRoleId = objQxRolesEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQxRolesEN.RoleName !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleName);
 var strRoleName = objQxRolesEN.RoleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleName + "'");
 }
 
 if (objQxRolesEN.RoleENName !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleENName);
 var strRoleENName = objQxRolesEN.RoleENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleENName + "'");
 }
 
 if (objQxRolesEN.RoleIndex !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleIndex);
 arrValueListForInsert.Add(objQxRolesEN.RoleIndex.ToString());
 }
 
 if (objQxRolesEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.UserType);
 var strUserType = objQxRolesEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objQxRolesEN.QxPrjId  ==  "")
 {
 objQxRolesEN.QxPrjId = null;
 }
 if (objQxRolesEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.QxPrjId);
 var strQxPrjId = objQxRolesEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conQxRoles.IsInUse);
 arrValueListForInsert.Add("'" + (objQxRolesEN.IsInUse  ==  false ? "0" : "1") + "'");
 
 if (objQxRolesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.UpdDate);
 var strUpdDate = objQxRolesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRolesEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.UpdUserId);
 var strUpdUserId = objQxRolesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxRolesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.Memo);
 var strMemo = objQxRolesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRoles");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxRolesEN objQxRolesEN)
{
 objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRolesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRolesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxRolesEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleId);
 var strRoleId = objQxRolesEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQxRolesEN.RoleName !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleName);
 var strRoleName = objQxRolesEN.RoleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleName + "'");
 }
 
 if (objQxRolesEN.RoleENName !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleENName);
 var strRoleENName = objQxRolesEN.RoleENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleENName + "'");
 }
 
 if (objQxRolesEN.RoleIndex !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleIndex);
 arrValueListForInsert.Add(objQxRolesEN.RoleIndex.ToString());
 }
 
 if (objQxRolesEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.UserType);
 var strUserType = objQxRolesEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objQxRolesEN.QxPrjId  ==  "")
 {
 objQxRolesEN.QxPrjId = null;
 }
 if (objQxRolesEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.QxPrjId);
 var strQxPrjId = objQxRolesEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conQxRoles.IsInUse);
 arrValueListForInsert.Add("'" + (objQxRolesEN.IsInUse  ==  false ? "0" : "1") + "'");
 
 if (objQxRolesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.UpdDate);
 var strUpdDate = objQxRolesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRolesEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.UpdUserId);
 var strUpdUserId = objQxRolesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxRolesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.Memo);
 var strMemo = objQxRolesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRoles");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxRolesEN.RoleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxRolesEN objQxRolesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRolesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRolesEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxRolesEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleId);
 var strRoleId = objQxRolesEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQxRolesEN.RoleName !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleName);
 var strRoleName = objQxRolesEN.RoleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleName + "'");
 }
 
 if (objQxRolesEN.RoleENName !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleENName);
 var strRoleENName = objQxRolesEN.RoleENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleENName + "'");
 }
 
 if (objQxRolesEN.RoleIndex !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.RoleIndex);
 arrValueListForInsert.Add(objQxRolesEN.RoleIndex.ToString());
 }
 
 if (objQxRolesEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.UserType);
 var strUserType = objQxRolesEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objQxRolesEN.QxPrjId  ==  "")
 {
 objQxRolesEN.QxPrjId = null;
 }
 if (objQxRolesEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.QxPrjId);
 var strQxPrjId = objQxRolesEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conQxRoles.IsInUse);
 arrValueListForInsert.Add("'" + (objQxRolesEN.IsInUse  ==  false ? "0" : "1") + "'");
 
 if (objQxRolesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.UpdDate);
 var strUpdDate = objQxRolesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRolesEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.UpdUserId);
 var strUpdUserId = objQxRolesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxRolesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRoles.Memo);
 var strMemo = objQxRolesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRoles");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxRolesEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxRolesBySP(clsQxRolesEN objQxRolesEN)
{
//通过存储过程来
//直接使用
 objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxRolesEN.RoleId,
 objQxRolesEN.RoleName,
 objQxRolesEN.RoleENName,
 objQxRolesEN.RoleIndex,
 objQxRolesEN.UserType,
 objQxRolesEN.QxPrjId,
 objQxRolesEN.IsInUse,
 objQxRolesEN.UpdDate,
 objQxRolesEN.UpdUserId,
objQxRolesEN.Memo
};
 objSQL.ExecSP("QxRoles_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxRoless(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where RoleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxRoles");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strRoleId = oRow[conQxRoles.RoleId].ToString().Trim();
if (IsExist(strRoleId))
{
 string strResult = "关键字变量值为:" + string.Format("RoleId = {0}", strRoleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxRolesEN._CurrTabName ].NewRow();
objRow[conQxRoles.RoleId] = oRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objRow[conQxRoles.RoleName] = oRow[conQxRoles.RoleName].ToString().Trim(); //角色名称
objRow[conQxRoles.RoleENName] = oRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objRow[conQxRoles.RoleIndex] = oRow[conQxRoles.RoleIndex].ToString().Trim(); //角色序号
objRow[conQxRoles.UserType] = oRow[conQxRoles.UserType].ToString().Trim(); //用户类型
objRow[conQxRoles.QxPrjId] = oRow[conQxRoles.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxRoles.IsInUse] = oRow[conQxRoles.IsInUse].ToString().Trim(); //是否在使用
objRow[conQxRoles.UpdDate] = oRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objRow[conQxRoles.UpdUserId] = oRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conQxRoles.Memo] = oRow[conQxRoles.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxRolesEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxRolesEN._CurrTabName);
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
 /// <param name = "objQxRolesEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxRolesEN objQxRolesEN)
{
 objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRolesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRolesEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
strSQL = "Select * from QxRoles where RoleId = " + "'"+ objQxRolesEN.RoleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxRolesEN._CurrTabName);
if (objDS.Tables[clsQxRolesEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:RoleId = " + "'"+ objQxRolesEN.RoleId+"'");
return false;
}
objRow = objDS.Tables[clsQxRolesEN._CurrTabName].Rows[0];
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleId))
 {
objRow[conQxRoles.RoleId] = objQxRolesEN.RoleId; //角色Id
 }
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleName))
 {
objRow[conQxRoles.RoleName] = objQxRolesEN.RoleName; //角色名称
 }
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleENName))
 {
objRow[conQxRoles.RoleENName] = objQxRolesEN.RoleENName; //角色英文名
 }
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleIndex))
 {
objRow[conQxRoles.RoleIndex] = objQxRolesEN.RoleIndex; //角色序号
 }
 if (objQxRolesEN.IsUpdated(conQxRoles.UserType))
 {
objRow[conQxRoles.UserType] = objQxRolesEN.UserType; //用户类型
 }
 if (objQxRolesEN.IsUpdated(conQxRoles.QxPrjId))
 {
objRow[conQxRoles.QxPrjId] = objQxRolesEN.QxPrjId; //项目Id
 }
 if (objQxRolesEN.IsUpdated(conQxRoles.IsInUse))
 {
objRow[conQxRoles.IsInUse] = objQxRolesEN.IsInUse; //是否在使用
 }
 if (objQxRolesEN.IsUpdated(conQxRoles.UpdDate))
 {
objRow[conQxRoles.UpdDate] = objQxRolesEN.UpdDate; //修改日期
 }
 if (objQxRolesEN.IsUpdated(conQxRoles.UpdUserId))
 {
objRow[conQxRoles.UpdUserId] = objQxRolesEN.UpdUserId; //修改用户Id
 }
 if (objQxRolesEN.IsUpdated(conQxRoles.Memo))
 {
objRow[conQxRoles.Memo] = objQxRolesEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxRolesEN._CurrTabName);
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
public bool UpdateBySP(clsQxRolesEN objQxRolesEN)
{
 objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRolesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRolesEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxRolesEN.RoleId,
 objQxRolesEN.RoleName,
 objQxRolesEN.RoleENName,
 objQxRolesEN.RoleIndex,
 objQxRolesEN.UserType,
 objQxRolesEN.QxPrjId,
 objQxRolesEN.IsInUse,
 objQxRolesEN.UpdDate,
 objQxRolesEN.UpdUserId,
 objQxRolesEN.Memo
};
 objSQL.ExecSP("QxRoles_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxRolesEN objQxRolesEN)
{
 objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRolesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRolesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxRoles Set ");
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleName))
 {
 if (objQxRolesEN.RoleName !=  null)
 {
 var strRoleName = objQxRolesEN.RoleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleName, conQxRoles.RoleName); //角色名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.RoleName); //角色名称
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleENName))
 {
 if (objQxRolesEN.RoleENName !=  null)
 {
 var strRoleENName = objQxRolesEN.RoleENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleENName, conQxRoles.RoleENName); //角色英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.RoleENName); //角色英文名
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleIndex))
 {
 if (objQxRolesEN.RoleIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxRolesEN.RoleIndex, conQxRoles.RoleIndex); //角色序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.RoleIndex); //角色序号
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UserType))
 {
 if (objQxRolesEN.UserType !=  null)
 {
 var strUserType = objQxRolesEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserType, conQxRoles.UserType); //用户类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.UserType); //用户类型
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.QxPrjId))
 {
 if (objQxRolesEN.QxPrjId  ==  "")
 {
 objQxRolesEN.QxPrjId = null;
 }
 if (objQxRolesEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRolesEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxRoles.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.QxPrjId); //项目Id
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.IsInUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxRolesEN.IsInUse == true?"1":"0", conQxRoles.IsInUse); //是否在使用
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UpdDate))
 {
 if (objQxRolesEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRolesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxRoles.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.UpdDate); //修改日期
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UpdUserId))
 {
 if (objQxRolesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRolesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxRoles.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.Memo))
 {
 if (objQxRolesEN.Memo !=  null)
 {
 var strMemo = objQxRolesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxRoles.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RoleId = '{0}'", objQxRolesEN.RoleId); 
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
 /// <param name = "objQxRolesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxRolesEN objQxRolesEN, string strCondition)
{
 objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRolesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRolesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRoles Set ");
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleName))
 {
 if (objQxRolesEN.RoleName !=  null)
 {
 var strRoleName = objQxRolesEN.RoleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleName = '{0}',", strRoleName); //角色名称
 }
 else
 {
 sbSQL.Append(" RoleName = null,"); //角色名称
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleENName))
 {
 if (objQxRolesEN.RoleENName !=  null)
 {
 var strRoleENName = objQxRolesEN.RoleENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleENName = '{0}',", strRoleENName); //角色英文名
 }
 else
 {
 sbSQL.Append(" RoleENName = null,"); //角色英文名
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleIndex))
 {
 if (objQxRolesEN.RoleIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxRolesEN.RoleIndex, conQxRoles.RoleIndex); //角色序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.RoleIndex); //角色序号
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UserType))
 {
 if (objQxRolesEN.UserType !=  null)
 {
 var strUserType = objQxRolesEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserType = '{0}',", strUserType); //用户类型
 }
 else
 {
 sbSQL.Append(" UserType = null,"); //用户类型
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.QxPrjId))
 {
 if (objQxRolesEN.QxPrjId  ==  "")
 {
 objQxRolesEN.QxPrjId = null;
 }
 if (objQxRolesEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRolesEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.IsInUse))
 {
 sbSQL.AppendFormat(" IsInUse = '{0}',", objQxRolesEN.IsInUse == true?"1":"0"); //是否在使用
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UpdDate))
 {
 if (objQxRolesEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRolesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UpdUserId))
 {
 if (objQxRolesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRolesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.Memo))
 {
 if (objQxRolesEN.Memo !=  null)
 {
 var strMemo = objQxRolesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxRolesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxRolesEN objQxRolesEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRolesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRolesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRoles Set ");
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleName))
 {
 if (objQxRolesEN.RoleName !=  null)
 {
 var strRoleName = objQxRolesEN.RoleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleName = '{0}',", strRoleName); //角色名称
 }
 else
 {
 sbSQL.Append(" RoleName = null,"); //角色名称
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleENName))
 {
 if (objQxRolesEN.RoleENName !=  null)
 {
 var strRoleENName = objQxRolesEN.RoleENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleENName = '{0}',", strRoleENName); //角色英文名
 }
 else
 {
 sbSQL.Append(" RoleENName = null,"); //角色英文名
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleIndex))
 {
 if (objQxRolesEN.RoleIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxRolesEN.RoleIndex, conQxRoles.RoleIndex); //角色序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.RoleIndex); //角色序号
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UserType))
 {
 if (objQxRolesEN.UserType !=  null)
 {
 var strUserType = objQxRolesEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserType = '{0}',", strUserType); //用户类型
 }
 else
 {
 sbSQL.Append(" UserType = null,"); //用户类型
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.QxPrjId))
 {
 if (objQxRolesEN.QxPrjId  ==  "")
 {
 objQxRolesEN.QxPrjId = null;
 }
 if (objQxRolesEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRolesEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.IsInUse))
 {
 sbSQL.AppendFormat(" IsInUse = '{0}',", objQxRolesEN.IsInUse == true?"1":"0"); //是否在使用
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UpdDate))
 {
 if (objQxRolesEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRolesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UpdUserId))
 {
 if (objQxRolesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRolesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.Memo))
 {
 if (objQxRolesEN.Memo !=  null)
 {
 var strMemo = objQxRolesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxRolesEN objQxRolesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRolesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRolesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRoles Set ");
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleName))
 {
 if (objQxRolesEN.RoleName !=  null)
 {
 var strRoleName = objQxRolesEN.RoleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleName, conQxRoles.RoleName); //角色名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.RoleName); //角色名称
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleENName))
 {
 if (objQxRolesEN.RoleENName !=  null)
 {
 var strRoleENName = objQxRolesEN.RoleENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleENName, conQxRoles.RoleENName); //角色英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.RoleENName); //角色英文名
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.RoleIndex))
 {
 if (objQxRolesEN.RoleIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxRolesEN.RoleIndex, conQxRoles.RoleIndex); //角色序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.RoleIndex); //角色序号
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UserType))
 {
 if (objQxRolesEN.UserType !=  null)
 {
 var strUserType = objQxRolesEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserType, conQxRoles.UserType); //用户类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.UserType); //用户类型
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.QxPrjId))
 {
 if (objQxRolesEN.QxPrjId  ==  "")
 {
 objQxRolesEN.QxPrjId = null;
 }
 if (objQxRolesEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRolesEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxRoles.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.QxPrjId); //项目Id
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.IsInUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxRolesEN.IsInUse == true?"1":"0", conQxRoles.IsInUse); //是否在使用
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UpdDate))
 {
 if (objQxRolesEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRolesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxRoles.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.UpdDate); //修改日期
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.UpdUserId))
 {
 if (objQxRolesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxRolesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxRoles.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxRolesEN.IsUpdated(conQxRoles.Memo))
 {
 if (objQxRolesEN.Memo !=  null)
 {
 var strMemo = objQxRolesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxRoles.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoles.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RoleId = '{0}'", objQxRolesEN.RoleId); 
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
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strRoleId) 
{
CheckPrimaryKey(strRoleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strRoleId,
};
 objSQL.ExecSP("QxRoles_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strRoleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strRoleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
//删除QxRoles本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRoles where RoleId = " + "'"+ strRoleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxRoles(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
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
//删除QxRoles本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRoles where RoleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strRoleId) 
{
CheckPrimaryKey(strRoleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
//删除QxRoles本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRoles where RoleId = " + "'"+ strRoleId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxRoles(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxRolesDA: DelQxRoles)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxRoles where " + strCondition ;
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
public bool DelQxRolesWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxRolesDA: DelQxRolesWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRolesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxRoles where " + strCondition ;
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
 /// <param name = "objQxRolesENS">源对象</param>
 /// <param name = "objQxRolesENT">目标对象</param>
public void CopyTo(clsQxRolesEN objQxRolesENS, clsQxRolesEN objQxRolesENT)
{
objQxRolesENT.RoleId = objQxRolesENS.RoleId; //角色Id
objQxRolesENT.RoleName = objQxRolesENS.RoleName; //角色名称
objQxRolesENT.RoleENName = objQxRolesENS.RoleENName; //角色英文名
objQxRolesENT.RoleIndex = objQxRolesENS.RoleIndex; //角色序号
objQxRolesENT.UserType = objQxRolesENS.UserType; //用户类型
objQxRolesENT.QxPrjId = objQxRolesENS.QxPrjId; //项目Id
objQxRolesENT.IsInUse = objQxRolesENS.IsInUse; //是否在使用
objQxRolesENT.UpdDate = objQxRolesENS.UpdDate; //修改日期
objQxRolesENT.UpdUserId = objQxRolesENS.UpdUserId; //修改用户Id
objQxRolesENT.Memo = objQxRolesENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxRolesEN objQxRolesEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxRolesEN.RoleName, conQxRoles.RoleName);
clsCheckSql.CheckFieldNotNull(objQxRolesEN.QxPrjId, conQxRoles.QxPrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRolesEN.RoleId, 8, conQxRoles.RoleId);
clsCheckSql.CheckFieldLen(objQxRolesEN.RoleName, 50, conQxRoles.RoleName);
clsCheckSql.CheckFieldLen(objQxRolesEN.RoleENName, 50, conQxRoles.RoleENName);
clsCheckSql.CheckFieldLen(objQxRolesEN.UserType, 50, conQxRoles.UserType);
clsCheckSql.CheckFieldLen(objQxRolesEN.QxPrjId, 4, conQxRoles.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRolesEN.UpdDate, 20, conQxRoles.UpdDate);
clsCheckSql.CheckFieldLen(objQxRolesEN.UpdUserId, 20, conQxRoles.UpdUserId);
clsCheckSql.CheckFieldLen(objQxRolesEN.Memo, 1000, conQxRoles.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxRolesEN.QxPrjId, 4, conQxRoles.QxPrjId);
 objQxRolesEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxRolesEN objQxRolesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRolesEN.RoleName, 50, conQxRoles.RoleName);
clsCheckSql.CheckFieldLen(objQxRolesEN.RoleENName, 50, conQxRoles.RoleENName);
clsCheckSql.CheckFieldLen(objQxRolesEN.UserType, 50, conQxRoles.UserType);
clsCheckSql.CheckFieldLen(objQxRolesEN.QxPrjId, 4, conQxRoles.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRolesEN.UpdDate, 20, conQxRoles.UpdDate);
clsCheckSql.CheckFieldLen(objQxRolesEN.UpdUserId, 20, conQxRoles.UpdUserId);
clsCheckSql.CheckFieldLen(objQxRolesEN.Memo, 1000, conQxRoles.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxRolesEN.QxPrjId, 4, conQxRoles.QxPrjId);
 objQxRolesEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxRolesEN objQxRolesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRolesEN.RoleId, 8, conQxRoles.RoleId);
clsCheckSql.CheckFieldLen(objQxRolesEN.RoleName, 50, conQxRoles.RoleName);
clsCheckSql.CheckFieldLen(objQxRolesEN.RoleENName, 50, conQxRoles.RoleENName);
clsCheckSql.CheckFieldLen(objQxRolesEN.UserType, 50, conQxRoles.UserType);
clsCheckSql.CheckFieldLen(objQxRolesEN.QxPrjId, 4, conQxRoles.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRolesEN.UpdDate, 20, conQxRoles.UpdDate);
clsCheckSql.CheckFieldLen(objQxRolesEN.UpdUserId, 20, conQxRoles.UpdUserId);
clsCheckSql.CheckFieldLen(objQxRolesEN.Memo, 1000, conQxRoles.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxRolesEN.RoleId, conQxRoles.RoleId);
clsCheckSql.CheckSqlInjection4Field(objQxRolesEN.RoleName, conQxRoles.RoleName);
clsCheckSql.CheckSqlInjection4Field(objQxRolesEN.RoleENName, conQxRoles.RoleENName);
clsCheckSql.CheckSqlInjection4Field(objQxRolesEN.UserType, conQxRoles.UserType);
clsCheckSql.CheckSqlInjection4Field(objQxRolesEN.QxPrjId, conQxRoles.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxRolesEN.UpdDate, conQxRoles.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxRolesEN.UpdUserId, conQxRoles.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objQxRolesEN.Memo, conQxRoles.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxRolesEN.QxPrjId, 4, conQxRoles.QxPrjId);
 objQxRolesEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetRoleId()
{
//获取某学院所有专业信息
string strSQL = "select RoleId, RoleName from QxRoles ";
 clsSpecSQLforSql mySql = clsQxRolesDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxRoles(角色),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxRolesEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxRolesEN objQxRolesEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RoleName = '{0}'", objQxRolesEN.RoleName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxRolesEN.QxPrjId);
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
 objSQL = clsQxRolesDA.GetSpecSQLObj();
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
 objSQL = clsQxRolesDA.GetSpecSQLObj();
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
 objSQL = clsQxRolesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxRolesEN._CurrTabName);
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
 objSQL = clsQxRolesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxRolesEN._CurrTabName, strCondition);
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
 objSQL = clsQxRolesDA.GetSpecSQLObj();
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
 objSQL = clsQxRolesDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}