
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjMenusDA
 表名:QxPrjMenus(00140004)
 * 版本:2024.08.23.1(服务器:WIN-SRV103-116)
 日期:2024/08/29 09:31:51
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
 /// 工程菜单(QxPrjMenus)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxPrjMenusDA : clsCommBase4DA
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
 return clsQxPrjMenusEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxPrjMenusEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjMenusEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxPrjMenusEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxPrjMenusEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strMenuId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strMenuId)
{
strMenuId = strMenuId.Replace("'", "''");
if (strMenuId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:QxPrjMenus中,检查关键字,长度不正确!(clsQxPrjMenusDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMenuId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxPrjMenus中,关键字不能为空 或 null!(clsQxPrjMenusDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxPrjMenusDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strMenuId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strMenuId)
{
strMenuId = strMenuId.Replace("'", "''");
if (strMenuId.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:QxPrjMenus中,检查关键字,长度不正确!(简化版)(clsQxPrjMenusDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMenuId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxPrjMenus中,关键字不能为空 或 null!(clsQxPrjMenusDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxPrjMenusDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
 strSQL = "Select * from QxPrjMenus where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxPrjMenus");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxPrjMenus_SelectByCond",values, "QxPrjMenus");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjMenus where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From QxPrjMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From QxPrjMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From QxPrjMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjMenus");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxPrjMenus(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTable_QxPrjMenus)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenus where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenus where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjMenus where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjMenus where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjMenus.* from QxPrjMenus Left Join {1} on {2} where {3} and QxPrjMenus.MenuId not in (Select top {5} QxPrjMenus.MenuId from QxPrjMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenus where {1} and MenuId not in (Select top {2} MenuId from QxPrjMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenus where {1} and MenuId not in (Select top {3} MenuId from QxPrjMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjMenus.* from QxPrjMenus Left Join {1} on {2} where {3} and QxPrjMenus.MenuId not in (Select top {5} QxPrjMenus.MenuId from QxPrjMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenus where {1} and MenuId not in (Select top {2} MenuId from QxPrjMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenus where {1} and MenuId not in (Select top {3} MenuId from QxPrjMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjMenus.* from QxPrjMenus Left Join {1} on {2} where {3} and QxPrjMenus.MenuId not in (Select top {5} QxPrjMenus.MenuId from QxPrjMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenus where {1} and MenuId not in (Select top {2} MenuId from QxPrjMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenus where {1} and MenuId not in (Select top {3} MenuId from QxPrjMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From QxPrjMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From QxPrjMenus Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From QxPrjMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From QxPrjMenus Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusDA: GetQxPrjMenusByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjMenus_SelectByCond",values);
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
public List<clsQxPrjMenusEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxPrjMenusDA:GetObjLst)", objException.Message));
}
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = TransNullToInt(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = TransNullToBool(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = TransNullToBool(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjMenusDA: GetObjLst)", objException.Message));
}
objQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjMenusEN);
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
public List<clsQxPrjMenusEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxPrjMenusDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = TransNullToInt(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = TransNullToBool(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = TransNullToBool(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjMenusDA: GetObjLst)", objException.Message));
}
objQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxPrjMenusEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxPrjMenusDA:GetObjLstBySP)", objException.Message));
}
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjMenus_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = TransNullToInt(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = TransNullToBool(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = TransNullToBool(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjMenusDA: GetObjLstBySP)", objException.Message));
}
objQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjMenusEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjMenus(ref clsQxPrjMenusEN objQxPrjMenusEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where MenuId = " + "'"+ objQxPrjMenusEN.MenuId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxPrjMenusEN.MenuId = objDT.Rows[0][conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjMenusEN.MenuName = objDT.Rows[0][conQxPrjMenus.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjMenusEN.QxPrjId = objDT.Rows[0][conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjMenusEN.UpMenuId = objDT.Rows[0][conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjMenusEN.LinkFile = objDT.Rows[0][conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusEN.qsParameters = objDT.Rows[0][conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objQxPrjMenusEN.TabId = objDT.Rows[0][conQxPrjMenus.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjMenusEN.ImgFile = objDT.Rows[0][conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxPrjMenusEN.RoleId = objDT.Rows[0][conQxPrjMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjMenusEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxPrjMenus.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusEN.IsLeafNode = TransNullToBool(objDT.Rows[0][conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusEN.MenuTitle = objDT.Rows[0][conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjMenusEN.PageDispModeId = objDT.Rows[0][conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objQxPrjMenusEN.InUse = TransNullToBool(objDT.Rows[0][conQxPrjMenus.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusEN.MenuControlName = objDT.Rows[0][conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名(字段类型:varchar,字段长度:100,是否可空:True)
 objQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusEN.UpdDate = objDT.Rows[0][conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusEN.UpdUserId = objDT.Rows[0][conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusEN.Memo = objDT.Rows[0][conQxPrjMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxPrjMenusDA: GetQxPrjMenus)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxPrjMenusEN GetObjByMenuId(string strMenuId)
{
CheckPrimaryKey(strMenuId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where MenuId = " + "'"+ strMenuId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
 objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名(字段类型:varchar,字段长度:100,是否可空:True)
 objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxPrjMenusDA: GetObjByMenuId)", objException.Message));
}
return objQxPrjMenusEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxPrjMenus_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjMenusOneBySP(clsQxPrjMenusEN objQxPrjMenusEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxPrjMenusEN.MenuId
};
 objDT = objSQL.ExecSpReturnDT("QxPrjMenus_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxPrjMenusEN.MenuId = objDT.Rows[0][conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjMenusEN.MenuName = objDT.Rows[0][conQxPrjMenus.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjMenusEN.QxPrjId = objDT.Rows[0][conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjMenusEN.UpMenuId = objDT.Rows[0][conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjMenusEN.LinkFile = objDT.Rows[0][conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusEN.qsParameters = objDT.Rows[0][conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objQxPrjMenusEN.TabId = objDT.Rows[0][conQxPrjMenus.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjMenusEN.ImgFile = objDT.Rows[0][conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxPrjMenusEN.RoleId = objDT.Rows[0][conQxPrjMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjMenusEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxPrjMenus.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusEN.IsLeafNode = TransNullToBool(objDT.Rows[0][conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusEN.MenuTitle = objDT.Rows[0][conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjMenusEN.PageDispModeId = objDT.Rows[0][conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objQxPrjMenusEN.InUse = TransNullToBool(objDT.Rows[0][conQxPrjMenus.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusEN.MenuControlName = objDT.Rows[0][conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名(字段类型:varchar,字段长度:100,是否可空:True)
 objQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusEN.UpdDate = objDT.Rows[0][conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusEN.UpdUserId = objDT.Rows[0][conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusEN.Memo = objDT.Rows[0][conQxPrjMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjMenusEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN()
{
MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(), //菜单Id
MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(), //菜单名
QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(), //项目Id
UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(), //qs参数
TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(), //表ID
ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(), //图像文件
RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(), //角色Id
OrderNum = TransNullToInt(objRow[conQxPrjMenus.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()), //是否叶子
MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(), //页面显示模式Id
InUse = TransNullToBool(objRow[conQxPrjMenus.InUse].ToString().Trim()), //是否在用
MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(), //菜单控件名
ApplicationTypeId = TransNullToInt(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()), //应用程序类型Id
UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim() //备注
};
objQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjMenusEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxPrjMenusDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjMenusEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxPrjMenusDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjMenus_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN()
{
MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(), //菜单Id
MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(), //菜单名
QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(), //项目Id
UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(), //qs参数
TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(), //表ID
ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(), //图像文件
RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(), //角色Id
OrderNum = TransNullToInt(objRow[conQxPrjMenus.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()), //是否叶子
MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(), //页面显示模式Id
InUse = TransNullToBool(objRow[conQxPrjMenus.InUse].ToString().Trim()), //是否在用
MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(), //菜单控件名
ApplicationTypeId = TransNullToInt(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()), //应用程序类型Id
UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim() //备注
};
objQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjMenusEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxPrjMenusEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = TransNullToInt(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = TransNullToBool(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = TransNullToBool(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxPrjMenusDA: GetObjByDataRowQxPrjMenus)", objException.Message));
}
objQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjMenusEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxPrjMenusEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = TransNullToInt(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = TransNullToBool(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = TransNullToBool(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxPrjMenusDA: GetObjByDataRow)", objException.Message));
}
objQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjMenusEN;
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
objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjMenusEN._CurrTabName, conQxPrjMenus.MenuId, 8, "");
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
objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjMenusEN._CurrTabName, conQxPrjMenus.MenuId, 8, strPrefix);
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
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MenuId from QxPrjMenus where " + strCondition;
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
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MenuId from QxPrjMenus where " + strCondition;
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
 /// <param name = "strMenuId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strMenuId)
{
CheckPrimaryKey(strMenuId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjMenus", "MenuId = " + "'"+ strMenuId+"'"))
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
 /// <param name = "strMenuId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strMenuId)
{
CheckPrimaryKey(strMenuId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strMenuId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxPrjMenus_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxPrjMenusDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjMenus", strCondition))
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
objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxPrjMenus");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxPrjMenusEN objQxPrjMenusEN)
 {
 objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjMenusEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjMenus");
objRow = objDS.Tables["QxPrjMenus"].NewRow();
objRow[conQxPrjMenus.MenuId] = objQxPrjMenusEN.MenuId; //菜单Id
objRow[conQxPrjMenus.MenuName] = objQxPrjMenusEN.MenuName; //菜单名
objRow[conQxPrjMenus.QxPrjId] = objQxPrjMenusEN.QxPrjId; //项目Id
objRow[conQxPrjMenus.UpMenuId] = objQxPrjMenusEN.UpMenuId; //上级菜单Id
 if (objQxPrjMenusEN.LinkFile !=  "")
 {
objRow[conQxPrjMenus.LinkFile] = objQxPrjMenusEN.LinkFile; //链接文件
 }
 if (objQxPrjMenusEN.qsParameters !=  "")
 {
objRow[conQxPrjMenus.qsParameters] = objQxPrjMenusEN.qsParameters; //qs参数
 }
 if (objQxPrjMenusEN.TabId !=  "")
 {
objRow[conQxPrjMenus.TabId] = objQxPrjMenusEN.TabId; //表ID
 }
 if (objQxPrjMenusEN.ImgFile !=  "")
 {
objRow[conQxPrjMenus.ImgFile] = objQxPrjMenusEN.ImgFile; //图像文件
 }
 if (objQxPrjMenusEN.RoleId !=  "")
 {
objRow[conQxPrjMenus.RoleId] = objQxPrjMenusEN.RoleId; //角色Id
 }
objRow[conQxPrjMenus.OrderNum] = objQxPrjMenusEN.OrderNum; //排序号
objRow[conQxPrjMenus.IsLeafNode] = objQxPrjMenusEN.IsLeafNode; //是否叶子
 if (objQxPrjMenusEN.MenuTitle !=  "")
 {
objRow[conQxPrjMenus.MenuTitle] = objQxPrjMenusEN.MenuTitle; //菜单标题
 }
 if (objQxPrjMenusEN.PageDispModeId !=  "")
 {
objRow[conQxPrjMenus.PageDispModeId] = objQxPrjMenusEN.PageDispModeId; //页面显示模式Id
 }
objRow[conQxPrjMenus.InUse] = objQxPrjMenusEN.InUse; //是否在用
 if (objQxPrjMenusEN.MenuControlName !=  "")
 {
objRow[conQxPrjMenus.MenuControlName] = objQxPrjMenusEN.MenuControlName; //菜单控件名
 }
objRow[conQxPrjMenus.ApplicationTypeId] = objQxPrjMenusEN.ApplicationTypeId; //应用程序类型Id
 if (objQxPrjMenusEN.UpdDate !=  "")
 {
objRow[conQxPrjMenus.UpdDate] = objQxPrjMenusEN.UpdDate; //修改日期
 }
 if (objQxPrjMenusEN.UpdUserId !=  "")
 {
objRow[conQxPrjMenus.UpdUserId] = objQxPrjMenusEN.UpdUserId; //修改用户Id
 }
 if (objQxPrjMenusEN.Memo !=  "")
 {
objRow[conQxPrjMenus.Memo] = objQxPrjMenusEN.Memo; //备注
 }
objDS.Tables[clsQxPrjMenusEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxPrjMenusEN._CurrTabName);
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
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjMenusEN objQxPrjMenusEN)
{
 objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjMenusEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjMenusEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuId);
 var strMenuId = objQxPrjMenusEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPrjMenusEN.MenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuName);
 var strMenuName = objQxPrjMenusEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuName + "'");
 }
 
 if (objQxPrjMenusEN.QxPrjId  ==  "")
 {
 objQxPrjMenusEN.QxPrjId = null;
 }
 if (objQxPrjMenusEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.QxPrjId);
 var strQxPrjId = objQxPrjMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjMenusEN.UpMenuId  ==  "")
 {
 objQxPrjMenusEN.UpMenuId = null;
 }
 if (objQxPrjMenusEN.UpMenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.UpMenuId);
 var strUpMenuId = objQxPrjMenusEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpMenuId + "'");
 }
 
 if (objQxPrjMenusEN.LinkFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.LinkFile);
 var strLinkFile = objQxPrjMenusEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkFile + "'");
 }
 
 if (objQxPrjMenusEN.qsParameters !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.qsParameters);
 var strqsParameters = objQxPrjMenusEN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strqsParameters + "'");
 }
 
 if (objQxPrjMenusEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.TabId);
 var strTabId = objQxPrjMenusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objQxPrjMenusEN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.ImgFile);
 var strImgFile = objQxPrjMenusEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 if (objQxPrjMenusEN.RoleId  ==  "")
 {
 objQxPrjMenusEN.RoleId = null;
 }
 if (objQxPrjMenusEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.RoleId);
 var strRoleId = objQxPrjMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenus.OrderNum);
 arrValueListForInsert.Add(objQxPrjMenusEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conQxPrjMenus.IsLeafNode);
 arrValueListForInsert.Add("'" + (objQxPrjMenusEN.IsLeafNode  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusEN.MenuTitle !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuTitle);
 var strMenuTitle = objQxPrjMenusEN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuTitle + "'");
 }
 
 if (objQxPrjMenusEN.PageDispModeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.PageDispModeId);
 var strPageDispModeId = objQxPrjMenusEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageDispModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenus.InUse);
 arrValueListForInsert.Add("'" + (objQxPrjMenusEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusEN.MenuControlName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuControlName);
 var strMenuControlName = objQxPrjMenusEN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuControlName + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenus.ApplicationTypeId);
 arrValueListForInsert.Add(objQxPrjMenusEN.ApplicationTypeId.ToString());
 
 if (objQxPrjMenusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.UpdDate);
 var strUpdDate = objQxPrjMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjMenusEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.UpdUserId);
 var strUpdUserId = objQxPrjMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjMenusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.Memo);
 var strMemo = objQxPrjMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjMenus");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxPrjMenusEN objQxPrjMenusEN)
{
 objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjMenusEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjMenusEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuId);
 var strMenuId = objQxPrjMenusEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPrjMenusEN.MenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuName);
 var strMenuName = objQxPrjMenusEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuName + "'");
 }
 
 if (objQxPrjMenusEN.QxPrjId  ==  "")
 {
 objQxPrjMenusEN.QxPrjId = null;
 }
 if (objQxPrjMenusEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.QxPrjId);
 var strQxPrjId = objQxPrjMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjMenusEN.UpMenuId  ==  "")
 {
 objQxPrjMenusEN.UpMenuId = null;
 }
 if (objQxPrjMenusEN.UpMenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.UpMenuId);
 var strUpMenuId = objQxPrjMenusEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpMenuId + "'");
 }
 
 if (objQxPrjMenusEN.LinkFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.LinkFile);
 var strLinkFile = objQxPrjMenusEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkFile + "'");
 }
 
 if (objQxPrjMenusEN.qsParameters !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.qsParameters);
 var strqsParameters = objQxPrjMenusEN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strqsParameters + "'");
 }
 
 if (objQxPrjMenusEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.TabId);
 var strTabId = objQxPrjMenusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objQxPrjMenusEN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.ImgFile);
 var strImgFile = objQxPrjMenusEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 if (objQxPrjMenusEN.RoleId  ==  "")
 {
 objQxPrjMenusEN.RoleId = null;
 }
 if (objQxPrjMenusEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.RoleId);
 var strRoleId = objQxPrjMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenus.OrderNum);
 arrValueListForInsert.Add(objQxPrjMenusEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conQxPrjMenus.IsLeafNode);
 arrValueListForInsert.Add("'" + (objQxPrjMenusEN.IsLeafNode  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusEN.MenuTitle !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuTitle);
 var strMenuTitle = objQxPrjMenusEN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuTitle + "'");
 }
 
 if (objQxPrjMenusEN.PageDispModeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.PageDispModeId);
 var strPageDispModeId = objQxPrjMenusEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageDispModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenus.InUse);
 arrValueListForInsert.Add("'" + (objQxPrjMenusEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusEN.MenuControlName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuControlName);
 var strMenuControlName = objQxPrjMenusEN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuControlName + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenus.ApplicationTypeId);
 arrValueListForInsert.Add(objQxPrjMenusEN.ApplicationTypeId.ToString());
 
 if (objQxPrjMenusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.UpdDate);
 var strUpdDate = objQxPrjMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjMenusEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.UpdUserId);
 var strUpdUserId = objQxPrjMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjMenusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.Memo);
 var strMemo = objQxPrjMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjMenus");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxPrjMenusEN.MenuId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjMenusEN objQxPrjMenusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjMenusEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjMenusEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuId);
 var strMenuId = objQxPrjMenusEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxPrjMenusEN.MenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuName);
 var strMenuName = objQxPrjMenusEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuName + "'");
 }
 
 if (objQxPrjMenusEN.QxPrjId  ==  "")
 {
 objQxPrjMenusEN.QxPrjId = null;
 }
 if (objQxPrjMenusEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.QxPrjId);
 var strQxPrjId = objQxPrjMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjMenusEN.UpMenuId  ==  "")
 {
 objQxPrjMenusEN.UpMenuId = null;
 }
 if (objQxPrjMenusEN.UpMenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.UpMenuId);
 var strUpMenuId = objQxPrjMenusEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpMenuId + "'");
 }
 
 if (objQxPrjMenusEN.LinkFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.LinkFile);
 var strLinkFile = objQxPrjMenusEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkFile + "'");
 }
 
 if (objQxPrjMenusEN.qsParameters !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.qsParameters);
 var strqsParameters = objQxPrjMenusEN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strqsParameters + "'");
 }
 
 if (objQxPrjMenusEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.TabId);
 var strTabId = objQxPrjMenusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objQxPrjMenusEN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.ImgFile);
 var strImgFile = objQxPrjMenusEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 if (objQxPrjMenusEN.RoleId  ==  "")
 {
 objQxPrjMenusEN.RoleId = null;
 }
 if (objQxPrjMenusEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.RoleId);
 var strRoleId = objQxPrjMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenus.OrderNum);
 arrValueListForInsert.Add(objQxPrjMenusEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conQxPrjMenus.IsLeafNode);
 arrValueListForInsert.Add("'" + (objQxPrjMenusEN.IsLeafNode  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusEN.MenuTitle !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuTitle);
 var strMenuTitle = objQxPrjMenusEN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuTitle + "'");
 }
 
 if (objQxPrjMenusEN.PageDispModeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.PageDispModeId);
 var strPageDispModeId = objQxPrjMenusEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageDispModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenus.InUse);
 arrValueListForInsert.Add("'" + (objQxPrjMenusEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusEN.MenuControlName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.MenuControlName);
 var strMenuControlName = objQxPrjMenusEN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuControlName + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenus.ApplicationTypeId);
 arrValueListForInsert.Add(objQxPrjMenusEN.ApplicationTypeId.ToString());
 
 if (objQxPrjMenusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.UpdDate);
 var strUpdDate = objQxPrjMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjMenusEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.UpdUserId);
 var strUpdUserId = objQxPrjMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjMenusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenus.Memo);
 var strMemo = objQxPrjMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjMenus");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxPrjMenusBySP(clsQxPrjMenusEN objQxPrjMenusEN)
{
//通过存储过程来
//直接使用
 objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjMenusEN.MenuId,
 objQxPrjMenusEN.MenuName,
 objQxPrjMenusEN.QxPrjId,
 objQxPrjMenusEN.UpMenuId,
 objQxPrjMenusEN.LinkFile,
 objQxPrjMenusEN.qsParameters,
 objQxPrjMenusEN.TabId,
 objQxPrjMenusEN.ImgFile,
 objQxPrjMenusEN.RoleId,
 objQxPrjMenusEN.OrderNum,
 objQxPrjMenusEN.IsLeafNode,
 objQxPrjMenusEN.MenuTitle,
 objQxPrjMenusEN.PageDispModeId,
 objQxPrjMenusEN.InUse,
 objQxPrjMenusEN.MenuControlName,
 objQxPrjMenusEN.ApplicationTypeId,
 objQxPrjMenusEN.UpdDate,
 objQxPrjMenusEN.UpdUserId,
objQxPrjMenusEN.Memo
};
 objSQL.ExecSP("QxPrjMenus_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxPrjMenuss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where MenuId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjMenus");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strMenuId = oRow[conQxPrjMenus.MenuId].ToString().Trim();
if (IsExist(strMenuId))
{
 string strResult = "关键字变量值为:" + string.Format("MenuId = {0}", strMenuId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxPrjMenusEN._CurrTabName ].NewRow();
objRow[conQxPrjMenus.MenuId] = oRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objRow[conQxPrjMenus.MenuName] = oRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objRow[conQxPrjMenus.QxPrjId] = oRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxPrjMenus.UpMenuId] = oRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objRow[conQxPrjMenus.LinkFile] = oRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objRow[conQxPrjMenus.qsParameters] = oRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objRow[conQxPrjMenus.TabId] = oRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objRow[conQxPrjMenus.ImgFile] = oRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objRow[conQxPrjMenus.RoleId] = oRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objRow[conQxPrjMenus.OrderNum] = oRow[conQxPrjMenus.OrderNum].ToString().Trim(); //排序号
objRow[conQxPrjMenus.IsLeafNode] = oRow[conQxPrjMenus.IsLeafNode].ToString().Trim(); //是否叶子
objRow[conQxPrjMenus.MenuTitle] = oRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objRow[conQxPrjMenus.PageDispModeId] = oRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objRow[conQxPrjMenus.InUse] = oRow[conQxPrjMenus.InUse].ToString().Trim(); //是否在用
objRow[conQxPrjMenus.MenuControlName] = oRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objRow[conQxPrjMenus.ApplicationTypeId] = oRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim(); //应用程序类型Id
objRow[conQxPrjMenus.UpdDate] = oRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objRow[conQxPrjMenus.UpdUserId] = oRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conQxPrjMenus.Memo] = oRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxPrjMenusEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxPrjMenusEN._CurrTabName);
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
 /// <param name = "objQxPrjMenusEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxPrjMenusEN objQxPrjMenusEN)
{
 objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenus where MenuId = " + "'"+ objQxPrjMenusEN.MenuId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxPrjMenusEN._CurrTabName);
if (objDS.Tables[clsQxPrjMenusEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:MenuId = " + "'"+ objQxPrjMenusEN.MenuId+"'");
return false;
}
objRow = objDS.Tables[clsQxPrjMenusEN._CurrTabName].Rows[0];
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuId))
 {
objRow[conQxPrjMenus.MenuId] = objQxPrjMenusEN.MenuId; //菜单Id
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuName))
 {
objRow[conQxPrjMenus.MenuName] = objQxPrjMenusEN.MenuName; //菜单名
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.QxPrjId))
 {
objRow[conQxPrjMenus.QxPrjId] = objQxPrjMenusEN.QxPrjId; //项目Id
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpMenuId))
 {
objRow[conQxPrjMenus.UpMenuId] = objQxPrjMenusEN.UpMenuId; //上级菜单Id
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.LinkFile))
 {
objRow[conQxPrjMenus.LinkFile] = objQxPrjMenusEN.LinkFile; //链接文件
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.qsParameters))
 {
objRow[conQxPrjMenus.qsParameters] = objQxPrjMenusEN.qsParameters; //qs参数
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.TabId))
 {
objRow[conQxPrjMenus.TabId] = objQxPrjMenusEN.TabId; //表ID
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.ImgFile))
 {
objRow[conQxPrjMenus.ImgFile] = objQxPrjMenusEN.ImgFile; //图像文件
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.RoleId))
 {
objRow[conQxPrjMenus.RoleId] = objQxPrjMenusEN.RoleId; //角色Id
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.OrderNum))
 {
objRow[conQxPrjMenus.OrderNum] = objQxPrjMenusEN.OrderNum; //排序号
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.IsLeafNode))
 {
objRow[conQxPrjMenus.IsLeafNode] = objQxPrjMenusEN.IsLeafNode; //是否叶子
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuTitle))
 {
objRow[conQxPrjMenus.MenuTitle] = objQxPrjMenusEN.MenuTitle; //菜单标题
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.PageDispModeId))
 {
objRow[conQxPrjMenus.PageDispModeId] = objQxPrjMenusEN.PageDispModeId; //页面显示模式Id
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.InUse))
 {
objRow[conQxPrjMenus.InUse] = objQxPrjMenusEN.InUse; //是否在用
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuControlName))
 {
objRow[conQxPrjMenus.MenuControlName] = objQxPrjMenusEN.MenuControlName; //菜单控件名
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.ApplicationTypeId))
 {
objRow[conQxPrjMenus.ApplicationTypeId] = objQxPrjMenusEN.ApplicationTypeId; //应用程序类型Id
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpdDate))
 {
objRow[conQxPrjMenus.UpdDate] = objQxPrjMenusEN.UpdDate; //修改日期
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpdUserId))
 {
objRow[conQxPrjMenus.UpdUserId] = objQxPrjMenusEN.UpdUserId; //修改用户Id
 }
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.Memo))
 {
objRow[conQxPrjMenus.Memo] = objQxPrjMenusEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxPrjMenusEN._CurrTabName);
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
public bool UpdateBySP(clsQxPrjMenusEN objQxPrjMenusEN)
{
 objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjMenusEN.MenuId,
 objQxPrjMenusEN.MenuName,
 objQxPrjMenusEN.QxPrjId,
 objQxPrjMenusEN.UpMenuId,
 objQxPrjMenusEN.LinkFile,
 objQxPrjMenusEN.qsParameters,
 objQxPrjMenusEN.TabId,
 objQxPrjMenusEN.ImgFile,
 objQxPrjMenusEN.RoleId,
 objQxPrjMenusEN.OrderNum,
 objQxPrjMenusEN.IsLeafNode,
 objQxPrjMenusEN.MenuTitle,
 objQxPrjMenusEN.PageDispModeId,
 objQxPrjMenusEN.InUse,
 objQxPrjMenusEN.MenuControlName,
 objQxPrjMenusEN.ApplicationTypeId,
 objQxPrjMenusEN.UpdDate,
 objQxPrjMenusEN.UpdUserId,
 objQxPrjMenusEN.Memo
};
 objSQL.ExecSP("QxPrjMenus_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjMenusEN objQxPrjMenusEN)
{
 objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxPrjMenus Set ");
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuName))
 {
 if (objQxPrjMenusEN.MenuName !=  null)
 {
 var strMenuName = objQxPrjMenusEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuName, conQxPrjMenus.MenuName); //菜单名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.MenuName); //菜单名
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.QxPrjId))
 {
 if (objQxPrjMenusEN.QxPrjId  ==  "")
 {
 objQxPrjMenusEN.QxPrjId = null;
 }
 if (objQxPrjMenusEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjMenus.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpMenuId))
 {
 if (objQxPrjMenusEN.UpMenuId  ==  "")
 {
 objQxPrjMenusEN.UpMenuId = null;
 }
 if (objQxPrjMenusEN.UpMenuId !=  null)
 {
 var strUpMenuId = objQxPrjMenusEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpMenuId, conQxPrjMenus.UpMenuId); //上级菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.UpMenuId); //上级菜单Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.LinkFile))
 {
 if (objQxPrjMenusEN.LinkFile !=  null)
 {
 var strLinkFile = objQxPrjMenusEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkFile, conQxPrjMenus.LinkFile); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.LinkFile); //链接文件
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.qsParameters))
 {
 if (objQxPrjMenusEN.qsParameters !=  null)
 {
 var strqsParameters = objQxPrjMenusEN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strqsParameters, conQxPrjMenus.qsParameters); //qs参数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.qsParameters); //qs参数
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.TabId))
 {
 if (objQxPrjMenusEN.TabId !=  null)
 {
 var strTabId = objQxPrjMenusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conQxPrjMenus.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.TabId); //表ID
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.ImgFile))
 {
 if (objQxPrjMenusEN.ImgFile !=  null)
 {
 var strImgFile = objQxPrjMenusEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImgFile, conQxPrjMenus.ImgFile); //图像文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.ImgFile); //图像文件
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.RoleId))
 {
 if (objQxPrjMenusEN.RoleId  ==  "")
 {
 objQxPrjMenusEN.RoleId = null;
 }
 if (objQxPrjMenusEN.RoleId !=  null)
 {
 var strRoleId = objQxPrjMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQxPrjMenus.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.RoleId); //角色Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusEN.OrderNum, conQxPrjMenus.OrderNum); //排序号
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.IsLeafNode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusEN.IsLeafNode == true?"1":"0", conQxPrjMenus.IsLeafNode); //是否叶子
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuTitle))
 {
 if (objQxPrjMenusEN.MenuTitle !=  null)
 {
 var strMenuTitle = objQxPrjMenusEN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuTitle, conQxPrjMenus.MenuTitle); //菜单标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.MenuTitle); //菜单标题
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.PageDispModeId))
 {
 if (objQxPrjMenusEN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objQxPrjMenusEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageDispModeId, conQxPrjMenus.PageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.PageDispModeId); //页面显示模式Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusEN.InUse == true?"1":"0", conQxPrjMenus.InUse); //是否在用
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuControlName))
 {
 if (objQxPrjMenusEN.MenuControlName !=  null)
 {
 var strMenuControlName = objQxPrjMenusEN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuControlName, conQxPrjMenus.MenuControlName); //菜单控件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.MenuControlName); //菜单控件名
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusEN.ApplicationTypeId, conQxPrjMenus.ApplicationTypeId); //应用程序类型Id
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpdDate))
 {
 if (objQxPrjMenusEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjMenus.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpdUserId))
 {
 if (objQxPrjMenusEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjMenus.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.Memo))
 {
 if (objQxPrjMenusEN.Memo !=  null)
 {
 var strMemo = objQxPrjMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjMenus.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MenuId = '{0}'", objQxPrjMenusEN.MenuId); 
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
 /// <param name = "objQxPrjMenusEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxPrjMenusEN objQxPrjMenusEN, string strCondition)
{
 objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjMenus Set ");
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuName))
 {
 if (objQxPrjMenusEN.MenuName !=  null)
 {
 var strMenuName = objQxPrjMenusEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuName = '{0}',", strMenuName); //菜单名
 }
 else
 {
 sbSQL.Append(" MenuName = null,"); //菜单名
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.QxPrjId))
 {
 if (objQxPrjMenusEN.QxPrjId  ==  "")
 {
 objQxPrjMenusEN.QxPrjId = null;
 }
 if (objQxPrjMenusEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpMenuId))
 {
 if (objQxPrjMenusEN.UpMenuId  ==  "")
 {
 objQxPrjMenusEN.UpMenuId = null;
 }
 if (objQxPrjMenusEN.UpMenuId !=  null)
 {
 var strUpMenuId = objQxPrjMenusEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpMenuId = '{0}',", strUpMenuId); //上级菜单Id
 }
 else
 {
 sbSQL.Append(" UpMenuId = null,"); //上级菜单Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.LinkFile))
 {
 if (objQxPrjMenusEN.LinkFile !=  null)
 {
 var strLinkFile = objQxPrjMenusEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkFile = '{0}',", strLinkFile); //链接文件
 }
 else
 {
 sbSQL.Append(" LinkFile = null,"); //链接文件
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.qsParameters))
 {
 if (objQxPrjMenusEN.qsParameters !=  null)
 {
 var strqsParameters = objQxPrjMenusEN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" qsParameters = '{0}',", strqsParameters); //qs参数
 }
 else
 {
 sbSQL.Append(" qsParameters = null,"); //qs参数
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.TabId))
 {
 if (objQxPrjMenusEN.TabId !=  null)
 {
 var strTabId = objQxPrjMenusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.ImgFile))
 {
 if (objQxPrjMenusEN.ImgFile !=  null)
 {
 var strImgFile = objQxPrjMenusEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImgFile = '{0}',", strImgFile); //图像文件
 }
 else
 {
 sbSQL.Append(" ImgFile = null,"); //图像文件
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.RoleId))
 {
 if (objQxPrjMenusEN.RoleId  ==  "")
 {
 objQxPrjMenusEN.RoleId = null;
 }
 if (objQxPrjMenusEN.RoleId !=  null)
 {
 var strRoleId = objQxPrjMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxPrjMenusEN.OrderNum); //排序号
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.IsLeafNode))
 {
 sbSQL.AppendFormat(" IsLeafNode = '{0}',", objQxPrjMenusEN.IsLeafNode == true?"1":"0"); //是否叶子
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuTitle))
 {
 if (objQxPrjMenusEN.MenuTitle !=  null)
 {
 var strMenuTitle = objQxPrjMenusEN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuTitle = '{0}',", strMenuTitle); //菜单标题
 }
 else
 {
 sbSQL.Append(" MenuTitle = null,"); //菜单标题
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.PageDispModeId))
 {
 if (objQxPrjMenusEN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objQxPrjMenusEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageDispModeId = '{0}',", strPageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.Append(" PageDispModeId = null,"); //页面显示模式Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxPrjMenusEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuControlName))
 {
 if (objQxPrjMenusEN.MenuControlName !=  null)
 {
 var strMenuControlName = objQxPrjMenusEN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuControlName = '{0}',", strMenuControlName); //菜单控件名
 }
 else
 {
 sbSQL.Append(" MenuControlName = null,"); //菜单控件名
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objQxPrjMenusEN.ApplicationTypeId); //应用程序类型Id
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpdDate))
 {
 if (objQxPrjMenusEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpdUserId))
 {
 if (objQxPrjMenusEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.Memo))
 {
 if (objQxPrjMenusEN.Memo !=  null)
 {
 var strMemo = objQxPrjMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxPrjMenusEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxPrjMenusEN objQxPrjMenusEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjMenus Set ");
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuName))
 {
 if (objQxPrjMenusEN.MenuName !=  null)
 {
 var strMenuName = objQxPrjMenusEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuName = '{0}',", strMenuName); //菜单名
 }
 else
 {
 sbSQL.Append(" MenuName = null,"); //菜单名
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.QxPrjId))
 {
 if (objQxPrjMenusEN.QxPrjId  ==  "")
 {
 objQxPrjMenusEN.QxPrjId = null;
 }
 if (objQxPrjMenusEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpMenuId))
 {
 if (objQxPrjMenusEN.UpMenuId  ==  "")
 {
 objQxPrjMenusEN.UpMenuId = null;
 }
 if (objQxPrjMenusEN.UpMenuId !=  null)
 {
 var strUpMenuId = objQxPrjMenusEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpMenuId = '{0}',", strUpMenuId); //上级菜单Id
 }
 else
 {
 sbSQL.Append(" UpMenuId = null,"); //上级菜单Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.LinkFile))
 {
 if (objQxPrjMenusEN.LinkFile !=  null)
 {
 var strLinkFile = objQxPrjMenusEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkFile = '{0}',", strLinkFile); //链接文件
 }
 else
 {
 sbSQL.Append(" LinkFile = null,"); //链接文件
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.qsParameters))
 {
 if (objQxPrjMenusEN.qsParameters !=  null)
 {
 var strqsParameters = objQxPrjMenusEN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" qsParameters = '{0}',", strqsParameters); //qs参数
 }
 else
 {
 sbSQL.Append(" qsParameters = null,"); //qs参数
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.TabId))
 {
 if (objQxPrjMenusEN.TabId !=  null)
 {
 var strTabId = objQxPrjMenusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.ImgFile))
 {
 if (objQxPrjMenusEN.ImgFile !=  null)
 {
 var strImgFile = objQxPrjMenusEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImgFile = '{0}',", strImgFile); //图像文件
 }
 else
 {
 sbSQL.Append(" ImgFile = null,"); //图像文件
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.RoleId))
 {
 if (objQxPrjMenusEN.RoleId  ==  "")
 {
 objQxPrjMenusEN.RoleId = null;
 }
 if (objQxPrjMenusEN.RoleId !=  null)
 {
 var strRoleId = objQxPrjMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxPrjMenusEN.OrderNum); //排序号
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.IsLeafNode))
 {
 sbSQL.AppendFormat(" IsLeafNode = '{0}',", objQxPrjMenusEN.IsLeafNode == true?"1":"0"); //是否叶子
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuTitle))
 {
 if (objQxPrjMenusEN.MenuTitle !=  null)
 {
 var strMenuTitle = objQxPrjMenusEN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuTitle = '{0}',", strMenuTitle); //菜单标题
 }
 else
 {
 sbSQL.Append(" MenuTitle = null,"); //菜单标题
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.PageDispModeId))
 {
 if (objQxPrjMenusEN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objQxPrjMenusEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageDispModeId = '{0}',", strPageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.Append(" PageDispModeId = null,"); //页面显示模式Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxPrjMenusEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuControlName))
 {
 if (objQxPrjMenusEN.MenuControlName !=  null)
 {
 var strMenuControlName = objQxPrjMenusEN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuControlName = '{0}',", strMenuControlName); //菜单控件名
 }
 else
 {
 sbSQL.Append(" MenuControlName = null,"); //菜单控件名
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objQxPrjMenusEN.ApplicationTypeId); //应用程序类型Id
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpdDate))
 {
 if (objQxPrjMenusEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpdUserId))
 {
 if (objQxPrjMenusEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.Memo))
 {
 if (objQxPrjMenusEN.Memo !=  null)
 {
 var strMemo = objQxPrjMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjMenusEN objQxPrjMenusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjMenus Set ");
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuName))
 {
 if (objQxPrjMenusEN.MenuName !=  null)
 {
 var strMenuName = objQxPrjMenusEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuName, conQxPrjMenus.MenuName); //菜单名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.MenuName); //菜单名
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.QxPrjId))
 {
 if (objQxPrjMenusEN.QxPrjId  ==  "")
 {
 objQxPrjMenusEN.QxPrjId = null;
 }
 if (objQxPrjMenusEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjMenusEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjMenus.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpMenuId))
 {
 if (objQxPrjMenusEN.UpMenuId  ==  "")
 {
 objQxPrjMenusEN.UpMenuId = null;
 }
 if (objQxPrjMenusEN.UpMenuId !=  null)
 {
 var strUpMenuId = objQxPrjMenusEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpMenuId, conQxPrjMenus.UpMenuId); //上级菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.UpMenuId); //上级菜单Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.LinkFile))
 {
 if (objQxPrjMenusEN.LinkFile !=  null)
 {
 var strLinkFile = objQxPrjMenusEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkFile, conQxPrjMenus.LinkFile); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.LinkFile); //链接文件
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.qsParameters))
 {
 if (objQxPrjMenusEN.qsParameters !=  null)
 {
 var strqsParameters = objQxPrjMenusEN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strqsParameters, conQxPrjMenus.qsParameters); //qs参数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.qsParameters); //qs参数
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.TabId))
 {
 if (objQxPrjMenusEN.TabId !=  null)
 {
 var strTabId = objQxPrjMenusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conQxPrjMenus.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.TabId); //表ID
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.ImgFile))
 {
 if (objQxPrjMenusEN.ImgFile !=  null)
 {
 var strImgFile = objQxPrjMenusEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImgFile, conQxPrjMenus.ImgFile); //图像文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.ImgFile); //图像文件
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.RoleId))
 {
 if (objQxPrjMenusEN.RoleId  ==  "")
 {
 objQxPrjMenusEN.RoleId = null;
 }
 if (objQxPrjMenusEN.RoleId !=  null)
 {
 var strRoleId = objQxPrjMenusEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQxPrjMenus.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.RoleId); //角色Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusEN.OrderNum, conQxPrjMenus.OrderNum); //排序号
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.IsLeafNode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusEN.IsLeafNode == true?"1":"0", conQxPrjMenus.IsLeafNode); //是否叶子
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuTitle))
 {
 if (objQxPrjMenusEN.MenuTitle !=  null)
 {
 var strMenuTitle = objQxPrjMenusEN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuTitle, conQxPrjMenus.MenuTitle); //菜单标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.MenuTitle); //菜单标题
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.PageDispModeId))
 {
 if (objQxPrjMenusEN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objQxPrjMenusEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageDispModeId, conQxPrjMenus.PageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.PageDispModeId); //页面显示模式Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusEN.InUse == true?"1":"0", conQxPrjMenus.InUse); //是否在用
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.MenuControlName))
 {
 if (objQxPrjMenusEN.MenuControlName !=  null)
 {
 var strMenuControlName = objQxPrjMenusEN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuControlName, conQxPrjMenus.MenuControlName); //菜单控件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.MenuControlName); //菜单控件名
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusEN.ApplicationTypeId, conQxPrjMenus.ApplicationTypeId); //应用程序类型Id
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpdDate))
 {
 if (objQxPrjMenusEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjMenusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjMenus.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.UpdUserId))
 {
 if (objQxPrjMenusEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjMenusEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjMenus.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjMenusEN.IsUpdated(conQxPrjMenus.Memo))
 {
 if (objQxPrjMenusEN.Memo !=  null)
 {
 var strMemo = objQxPrjMenusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjMenus.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenus.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MenuId = '{0}'", objQxPrjMenusEN.MenuId); 
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
 /// <param name = "strMenuId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strMenuId) 
{
CheckPrimaryKey(strMenuId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strMenuId,
};
 objSQL.ExecSP("QxPrjMenus_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strMenuId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strMenuId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strMenuId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
//删除QxPrjMenus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjMenus where MenuId = " + "'"+ strMenuId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxPrjMenus(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
//删除QxPrjMenus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjMenus where MenuId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strMenuId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strMenuId) 
{
CheckPrimaryKey(strMenuId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
//删除QxPrjMenus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjMenus where MenuId = " + "'"+ strMenuId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxPrjMenus(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: DelQxPrjMenus)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjMenus where " + strCondition ;
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
public bool DelQxPrjMenusWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxPrjMenusDA: DelQxPrjMenusWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjMenus where " + strCondition ;
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
 /// <param name = "objQxPrjMenusENS">源对象</param>
 /// <param name = "objQxPrjMenusENT">目标对象</param>
public void CopyTo(clsQxPrjMenusEN objQxPrjMenusENS, clsQxPrjMenusEN objQxPrjMenusENT)
{
objQxPrjMenusENT.MenuId = objQxPrjMenusENS.MenuId; //菜单Id
objQxPrjMenusENT.MenuName = objQxPrjMenusENS.MenuName; //菜单名
objQxPrjMenusENT.QxPrjId = objQxPrjMenusENS.QxPrjId; //项目Id
objQxPrjMenusENT.UpMenuId = objQxPrjMenusENS.UpMenuId; //上级菜单Id
objQxPrjMenusENT.LinkFile = objQxPrjMenusENS.LinkFile; //链接文件
objQxPrjMenusENT.qsParameters = objQxPrjMenusENS.qsParameters; //qs参数
objQxPrjMenusENT.TabId = objQxPrjMenusENS.TabId; //表ID
objQxPrjMenusENT.ImgFile = objQxPrjMenusENS.ImgFile; //图像文件
objQxPrjMenusENT.RoleId = objQxPrjMenusENS.RoleId; //角色Id
objQxPrjMenusENT.OrderNum = objQxPrjMenusENS.OrderNum; //排序号
objQxPrjMenusENT.IsLeafNode = objQxPrjMenusENS.IsLeafNode; //是否叶子
objQxPrjMenusENT.MenuTitle = objQxPrjMenusENS.MenuTitle; //菜单标题
objQxPrjMenusENT.PageDispModeId = objQxPrjMenusENS.PageDispModeId; //页面显示模式Id
objQxPrjMenusENT.InUse = objQxPrjMenusENS.InUse; //是否在用
objQxPrjMenusENT.MenuControlName = objQxPrjMenusENS.MenuControlName; //菜单控件名
objQxPrjMenusENT.ApplicationTypeId = objQxPrjMenusENS.ApplicationTypeId; //应用程序类型Id
objQxPrjMenusENT.UpdDate = objQxPrjMenusENS.UpdDate; //修改日期
objQxPrjMenusENT.UpdUserId = objQxPrjMenusENS.UpdUserId; //修改用户Id
objQxPrjMenusENT.Memo = objQxPrjMenusENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjMenusEN objQxPrjMenusEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxPrjMenusEN.MenuName, conQxPrjMenus.MenuName);
clsCheckSql.CheckFieldNotNull(objQxPrjMenusEN.QxPrjId, conQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldNotNull(objQxPrjMenusEN.UpMenuId, conQxPrjMenus.UpMenuId);
clsCheckSql.CheckFieldNotNull(objQxPrjMenusEN.OrderNum, conQxPrjMenus.OrderNum);
clsCheckSql.CheckFieldNotNull(objQxPrjMenusEN.IsLeafNode, conQxPrjMenus.IsLeafNode);
clsCheckSql.CheckFieldNotNull(objQxPrjMenusEN.ApplicationTypeId, conQxPrjMenus.ApplicationTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.MenuId, 8, conQxPrjMenus.MenuId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.MenuName, 50, conQxPrjMenus.MenuName);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.QxPrjId, 4, conQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.UpMenuId, 8, conQxPrjMenus.UpMenuId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.LinkFile, 500, conQxPrjMenus.LinkFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.qsParameters, 200, conQxPrjMenus.qsParameters);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.TabId, 8, conQxPrjMenus.TabId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.ImgFile, 300, conQxPrjMenus.ImgFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.RoleId, 8, conQxPrjMenus.RoleId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.MenuTitle, 50, conQxPrjMenus.MenuTitle);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.PageDispModeId, 2, conQxPrjMenus.PageDispModeId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.MenuControlName, 100, conQxPrjMenus.MenuControlName);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.UpdDate, 20, conQxPrjMenus.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.UpdUserId, 20, conQxPrjMenus.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.Memo, 1000, conQxPrjMenus.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusEN.QxPrjId, 4, conQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusEN.UpMenuId, 8, conQxPrjMenus.UpMenuId);
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusEN.RoleId, 8, conQxPrjMenus.RoleId);
 objQxPrjMenusEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxPrjMenusEN objQxPrjMenusEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.MenuName, 50, conQxPrjMenus.MenuName);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.QxPrjId, 4, conQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.UpMenuId, 8, conQxPrjMenus.UpMenuId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.LinkFile, 500, conQxPrjMenus.LinkFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.qsParameters, 200, conQxPrjMenus.qsParameters);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.TabId, 8, conQxPrjMenus.TabId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.ImgFile, 300, conQxPrjMenus.ImgFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.RoleId, 8, conQxPrjMenus.RoleId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.MenuTitle, 50, conQxPrjMenus.MenuTitle);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.PageDispModeId, 2, conQxPrjMenus.PageDispModeId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.MenuControlName, 100, conQxPrjMenus.MenuControlName);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.UpdDate, 20, conQxPrjMenus.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.UpdUserId, 20, conQxPrjMenus.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.Memo, 1000, conQxPrjMenus.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusEN.QxPrjId, 4, conQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusEN.UpMenuId, 8, conQxPrjMenus.UpMenuId);
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusEN.RoleId, 8, conQxPrjMenus.RoleId);
 objQxPrjMenusEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxPrjMenusEN objQxPrjMenusEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.MenuId, 8, conQxPrjMenus.MenuId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.MenuName, 50, conQxPrjMenus.MenuName);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.QxPrjId, 4, conQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.UpMenuId, 8, conQxPrjMenus.UpMenuId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.LinkFile, 500, conQxPrjMenus.LinkFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.qsParameters, 200, conQxPrjMenus.qsParameters);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.TabId, 8, conQxPrjMenus.TabId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.ImgFile, 300, conQxPrjMenus.ImgFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.RoleId, 8, conQxPrjMenus.RoleId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.MenuTitle, 50, conQxPrjMenus.MenuTitle);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.PageDispModeId, 2, conQxPrjMenus.PageDispModeId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.MenuControlName, 100, conQxPrjMenus.MenuControlName);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.UpdDate, 20, conQxPrjMenus.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.UpdUserId, 20, conQxPrjMenus.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjMenusEN.Memo, 1000, conQxPrjMenus.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.MenuId, conQxPrjMenus.MenuId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.MenuName, conQxPrjMenus.MenuName);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.QxPrjId, conQxPrjMenus.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.UpMenuId, conQxPrjMenus.UpMenuId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.LinkFile, conQxPrjMenus.LinkFile);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.qsParameters, conQxPrjMenus.qsParameters);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.TabId, conQxPrjMenus.TabId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.ImgFile, conQxPrjMenus.ImgFile);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.RoleId, conQxPrjMenus.RoleId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.MenuTitle, conQxPrjMenus.MenuTitle);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.PageDispModeId, conQxPrjMenus.PageDispModeId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.MenuControlName, conQxPrjMenus.MenuControlName);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.UpdDate, conQxPrjMenus.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.UpdUserId, conQxPrjMenus.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusEN.Memo, conQxPrjMenus.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusEN.QxPrjId, 4, conQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusEN.UpMenuId, 8, conQxPrjMenus.UpMenuId);
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusEN.RoleId, 8, conQxPrjMenus.RoleId);
 objQxPrjMenusEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetMenuId()
{
//获取某学院所有专业信息
string strSQL = "select MenuId, MenuName from QxPrjMenus ";
 clsSpecSQLforSql mySql = clsQxPrjMenusDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxPrjMenus(工程菜单),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxPrjMenusEN objQxPrjMenusEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusEN.MenuName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusEN.QxPrjId);
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
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjMenusEN._CurrTabName);
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
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjMenusEN._CurrTabName, strCondition);
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
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}