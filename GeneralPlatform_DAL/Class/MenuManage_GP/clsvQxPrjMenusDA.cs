
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenusDA
 表名:vQxPrjMenus(00140046)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:33:14
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
 /// v工程菜单(vQxPrjMenus)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxPrjMenusDA : clsCommBase4DA
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
 return clsvQxPrjMenusEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxPrjMenusEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjMenusEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxPrjMenusEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxPrjMenusEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vQxPrjMenus中,检查关键字,长度不正确!(clsvQxPrjMenusDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMenuId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxPrjMenus中,关键字不能为空 或 null!(clsvQxPrjMenusDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxPrjMenusDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception("(errid:Data000004)在表:vQxPrjMenus中,检查关键字,长度不正确!(简化版)(clsvQxPrjMenusDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMenuId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:vQxPrjMenus中,关键字不能为空 或 null!(clsvQxPrjMenusDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsvQxPrjMenusDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
 strSQL = "Select * from vQxPrjMenus where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxPrjMenus_SelectByCond",values, "vQxPrjMenus");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From vQxPrjMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From vQxPrjMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From vQxPrjMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxPrjMenus(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTable_vQxPrjMenus)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjMenus.* from vQxPrjMenus Left Join {1} on {2} where {3} and vQxPrjMenus.MenuId not in (Select top {5} vQxPrjMenus.MenuId from vQxPrjMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus where {1} and MenuId not in (Select top {2} MenuId from vQxPrjMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus where {1} and MenuId not in (Select top {3} MenuId from vQxPrjMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjMenus.* from vQxPrjMenus Left Join {1} on {2} where {3} and vQxPrjMenus.MenuId not in (Select top {5} vQxPrjMenus.MenuId from vQxPrjMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus where {1} and MenuId not in (Select top {2} MenuId from vQxPrjMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus where {1} and MenuId not in (Select top {3} MenuId from vQxPrjMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjMenus.* from vQxPrjMenus Left Join {1} on {2} where {3} and vQxPrjMenus.MenuId not in (Select top {5} vQxPrjMenus.MenuId from vQxPrjMenus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus where {1} and MenuId not in (Select top {2} MenuId from vQxPrjMenus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus where {1} and MenuId not in (Select top {3} MenuId from vQxPrjMenus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From vQxPrjMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From vQxPrjMenus Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From vQxPrjMenus Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus a where {0} And a.MenuId not in (Select Top {2} MenuId From vQxPrjMenus Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenusDA: GetvQxPrjMenusByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_SelectByCond",values);
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
public List<clsvQxPrjMenusEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA:GetObjLst)", objException.Message));
}
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = TransNullToBool(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjMenusDA: GetObjLst)", objException.Message));
}
objvQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjMenusEN);
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
public List<clsvQxPrjMenusEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = TransNullToBool(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjMenusDA: GetObjLst)", objException.Message));
}
objvQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxPrjMenusEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = TransNullToBool(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjMenusDA: GetObjLstBySP)", objException.Message));
}
objvQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjMenusEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjMenus(ref clsvQxPrjMenusEN objvQxPrjMenusEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus where MenuId = " + "'"+ objvQxPrjMenusEN.MenuId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxPrjMenusEN.MenuId = objDT.Rows[0][convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenusEN.MenuName = objDT.Rows[0][convQxPrjMenus.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenusEN.QxPrjId = objDT.Rows[0][convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenusEN.PrjName = objDT.Rows[0][convQxPrjMenus.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenusEN.UpMenuId = objDT.Rows[0][convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenusEN.LinkFile = objDT.Rows[0][convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxPrjMenusEN.qsParameters = objDT.Rows[0][convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjMenusEN.TabId = objDT.Rows[0][convQxPrjMenus.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenusEN.TabName = objDT.Rows[0][convQxPrjMenus.TabName].ToString().Trim(); //TabName(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxPrjMenusEN.ImgFile = objDT.Rows[0][convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxPrjMenusEN.RoleId = objDT.Rows[0][convQxPrjMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenusEN.RoleName = objDT.Rows[0][convQxPrjMenus.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenusEN.OrderNum = TransNullToInt(objDT.Rows[0][convQxPrjMenus.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenusEN.IsLeafNode = TransNullToBool(objDT.Rows[0][convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenusEN.MenuSetId = objDT.Rows[0][convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenusEN.MenuSetName = objDT.Rows[0][convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenusEN.MenuTitle = objDT.Rows[0][convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenusEN.PageDispModeId = objDT.Rows[0][convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxPrjMenusEN.PageDispModeName = objDT.Rows[0][convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenusEN.InUse = TransNullToBool(objDT.Rows[0][convQxPrjMenus.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenusEN.MenuControlName = objDT.Rows[0][convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvQxPrjMenusEN.ApplicationTypeName = objDT.Rows[0][convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenusEN.UpdDate = objDT.Rows[0][convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenusEN.UpdUserId = objDT.Rows[0][convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenusEN.Memo = objDT.Rows[0][convQxPrjMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjMenusEN.UpMenuName = objDT.Rows[0][convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjMenusEN.SubMenusNum = TransNullToInt(objDT.Rows[0][convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenusEN.RoleNum = TransNullToInt(objDT.Rows[0][convQxPrjMenus.RoleNum].ToString().Trim()); //角色数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxPrjMenusDA: GetvQxPrjMenus)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxPrjMenusEN GetObjByMenuId(string strMenuId)
{
CheckPrimaryKey(strMenuId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus where MenuId = " + "'"+ strMenuId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
 objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxPrjMenusDA: GetObjByMenuId)", objException.Message));
}
return objvQxPrjMenusEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxPrjMenus_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjMenusOneBySP(clsvQxPrjMenusEN objvQxPrjMenusEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxPrjMenusEN.MenuId
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxPrjMenusEN.MenuId = objDT.Rows[0][convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenusEN.MenuName = objDT.Rows[0][convQxPrjMenus.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenusEN.QxPrjId = objDT.Rows[0][convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenusEN.PrjName = objDT.Rows[0][convQxPrjMenus.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenusEN.UpMenuId = objDT.Rows[0][convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenusEN.LinkFile = objDT.Rows[0][convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxPrjMenusEN.qsParameters = objDT.Rows[0][convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjMenusEN.TabId = objDT.Rows[0][convQxPrjMenus.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenusEN.TabName = objDT.Rows[0][convQxPrjMenus.TabName].ToString().Trim(); //TabName(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxPrjMenusEN.ImgFile = objDT.Rows[0][convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxPrjMenusEN.RoleId = objDT.Rows[0][convQxPrjMenus.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenusEN.RoleName = objDT.Rows[0][convQxPrjMenus.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenusEN.OrderNum = TransNullToInt(objDT.Rows[0][convQxPrjMenus.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenusEN.IsLeafNode = TransNullToBool(objDT.Rows[0][convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenusEN.MenuSetId = objDT.Rows[0][convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenusEN.MenuSetName = objDT.Rows[0][convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenusEN.MenuTitle = objDT.Rows[0][convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenusEN.PageDispModeId = objDT.Rows[0][convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxPrjMenusEN.PageDispModeName = objDT.Rows[0][convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenusEN.InUse = TransNullToBool(objDT.Rows[0][convQxPrjMenus.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenusEN.MenuControlName = objDT.Rows[0][convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvQxPrjMenusEN.ApplicationTypeName = objDT.Rows[0][convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenusEN.UpdDate = objDT.Rows[0][convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenusEN.UpdUserId = objDT.Rows[0][convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenusEN.Memo = objDT.Rows[0][convQxPrjMenus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjMenusEN.UpMenuName = objDT.Rows[0][convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjMenusEN.SubMenusNum = TransNullToInt(objDT.Rows[0][convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenusEN.RoleNum = TransNullToInt(objDT.Rows[0][convQxPrjMenus.RoleNum].ToString().Trim()); //角色数(字段类型:int,字段长度:4,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjMenusEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN()
{
MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(), //菜单Id
MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(), //菜单名
QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(), //工程名
UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(), //qs参数
TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(), //表ID
TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(), //TabName
ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(), //图像文件
RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(), //角色Id
RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(), //角色名称
OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(), //菜单集Id
MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(), //菜单集名称
MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(), //页面显示模式Id
PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(), //页面显示模式名称
InUse = TransNullToBool(objRow[convQxPrjMenus.InUse].ToString().Trim()), //是否在用
MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(), //MenuControlName
ApplicationTypeId = TransNullToInt(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(), //备注
UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(), //上级菜单名
SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()), //子菜单数
RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.RoleNum].ToString().Trim()) //角色数
};
objvQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenusEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxPrjMenusDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjMenusEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN()
{
MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(), //菜单Id
MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(), //菜单名
QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(), //工程名
UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(), //qs参数
TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(), //表ID
TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(), //TabName
ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(), //图像文件
RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(), //角色Id
RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(), //角色名称
OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(), //菜单集Id
MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(), //菜单集名称
MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(), //页面显示模式Id
PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(), //页面显示模式名称
InUse = TransNullToBool(objRow[convQxPrjMenus.InUse].ToString().Trim()), //是否在用
MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(), //MenuControlName
ApplicationTypeId = TransNullToInt(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(), //备注
UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(), //上级菜单名
SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()), //子菜单数
RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.RoleNum].ToString().Trim()) //角色数
};
objvQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenusEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxPrjMenusEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = TransNullToBool(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxPrjMenusDA: GetObjByDataRowvQxPrjMenus)", objException.Message));
}
objvQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenusEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxPrjMenusEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = TransNullToBool(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = TransNullToInt(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxPrjMenusDA: GetObjByDataRow)", objException.Message));
}
objvQxPrjMenusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenusEN;
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
objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjMenusEN._CurrTabName, convQxPrjMenus.MenuId, 8, "");
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
objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjMenusEN._CurrTabName, convQxPrjMenus.MenuId, 8, strPrefix);
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
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MenuId from vQxPrjMenus where " + strCondition;
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
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MenuId from vQxPrjMenus where " + strCondition;
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
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjMenus", "MenuId = " + "'"+ strMenuId+"'"))
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
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strMenuId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxPrjMenus_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxPrjMenusDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjMenus", strCondition))
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
objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxPrjMenus");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxPrjMenusENS">源对象</param>
 /// <param name = "objvQxPrjMenusENT">目标对象</param>
public void CopyTo(clsvQxPrjMenusEN objvQxPrjMenusENS, clsvQxPrjMenusEN objvQxPrjMenusENT)
{
objvQxPrjMenusENT.MenuId = objvQxPrjMenusENS.MenuId; //菜单Id
objvQxPrjMenusENT.MenuName = objvQxPrjMenusENS.MenuName; //菜单名
objvQxPrjMenusENT.QxPrjId = objvQxPrjMenusENS.QxPrjId; //项目Id
objvQxPrjMenusENT.PrjName = objvQxPrjMenusENS.PrjName; //工程名
objvQxPrjMenusENT.UpMenuId = objvQxPrjMenusENS.UpMenuId; //上级菜单Id
objvQxPrjMenusENT.LinkFile = objvQxPrjMenusENS.LinkFile; //链接文件
objvQxPrjMenusENT.qsParameters = objvQxPrjMenusENS.qsParameters; //qs参数
objvQxPrjMenusENT.TabId = objvQxPrjMenusENS.TabId; //表ID
objvQxPrjMenusENT.TabName = objvQxPrjMenusENS.TabName; //TabName
objvQxPrjMenusENT.ImgFile = objvQxPrjMenusENS.ImgFile; //图像文件
objvQxPrjMenusENT.RoleId = objvQxPrjMenusENS.RoleId; //角色Id
objvQxPrjMenusENT.RoleName = objvQxPrjMenusENS.RoleName; //角色名称
objvQxPrjMenusENT.OrderNum = objvQxPrjMenusENS.OrderNum; //排序号
objvQxPrjMenusENT.IsLeafNode = objvQxPrjMenusENS.IsLeafNode; //是否叶子
objvQxPrjMenusENT.MenuSetId = objvQxPrjMenusENS.MenuSetId; //菜单集Id
objvQxPrjMenusENT.MenuSetName = objvQxPrjMenusENS.MenuSetName; //菜单集名称
objvQxPrjMenusENT.MenuTitle = objvQxPrjMenusENS.MenuTitle; //菜单标题
objvQxPrjMenusENT.PageDispModeId = objvQxPrjMenusENS.PageDispModeId; //页面显示模式Id
objvQxPrjMenusENT.PageDispModeName = objvQxPrjMenusENS.PageDispModeName; //页面显示模式名称
objvQxPrjMenusENT.InUse = objvQxPrjMenusENS.InUse; //是否在用
objvQxPrjMenusENT.MenuControlName = objvQxPrjMenusENS.MenuControlName; //MenuControlName
objvQxPrjMenusENT.ApplicationTypeId = objvQxPrjMenusENS.ApplicationTypeId; //应用程序类型ID
objvQxPrjMenusENT.ApplicationTypeName = objvQxPrjMenusENS.ApplicationTypeName; //应用程序类型名称
objvQxPrjMenusENT.UpdDate = objvQxPrjMenusENS.UpdDate; //修改日期
objvQxPrjMenusENT.UpdUserId = objvQxPrjMenusENS.UpdUserId; //修改用户Id
objvQxPrjMenusENT.Memo = objvQxPrjMenusENS.Memo; //备注
objvQxPrjMenusENT.UpMenuName = objvQxPrjMenusENS.UpMenuName; //上级菜单名
objvQxPrjMenusENT.SubMenusNum = objvQxPrjMenusENS.SubMenusNum; //子菜单数
objvQxPrjMenusENT.RoleNum = objvQxPrjMenusENS.RoleNum; //角色数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxPrjMenusEN objvQxPrjMenusEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.MenuId, 8, convQxPrjMenus.MenuId);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.MenuName, 50, convQxPrjMenus.MenuName);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.QxPrjId, 4, convQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.PrjName, 30, convQxPrjMenus.PrjName);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.UpMenuId, 8, convQxPrjMenus.UpMenuId);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.LinkFile, 500, convQxPrjMenus.LinkFile);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.qsParameters, 200, convQxPrjMenus.qsParameters);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.TabId, 8, convQxPrjMenus.TabId);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.TabName, 100, convQxPrjMenus.TabName);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.ImgFile, 300, convQxPrjMenus.ImgFile);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.RoleId, 8, convQxPrjMenus.RoleId);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.RoleName, 50, convQxPrjMenus.RoleName);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.MenuSetId, 4, convQxPrjMenus.MenuSetId);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.MenuSetName, 50, convQxPrjMenus.MenuSetName);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.MenuTitle, 50, convQxPrjMenus.MenuTitle);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.PageDispModeId, 2, convQxPrjMenus.PageDispModeId);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.PageDispModeName, 50, convQxPrjMenus.PageDispModeName);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.MenuControlName, 100, convQxPrjMenus.MenuControlName);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.ApplicationTypeName, 30, convQxPrjMenus.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.UpdDate, 20, convQxPrjMenus.UpdDate);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.UpdUserId, 20, convQxPrjMenus.UpdUserId);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.Memo, 1000, convQxPrjMenus.Memo);
clsCheckSql.CheckFieldLen(objvQxPrjMenusEN.UpMenuName, 30, convQxPrjMenus.UpMenuName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.MenuId, convQxPrjMenus.MenuId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.MenuName, convQxPrjMenus.MenuName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.QxPrjId, convQxPrjMenus.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.PrjName, convQxPrjMenus.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.UpMenuId, convQxPrjMenus.UpMenuId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.LinkFile, convQxPrjMenus.LinkFile);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.qsParameters, convQxPrjMenus.qsParameters);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.TabId, convQxPrjMenus.TabId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.TabName, convQxPrjMenus.TabName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.ImgFile, convQxPrjMenus.ImgFile);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.RoleId, convQxPrjMenus.RoleId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.RoleName, convQxPrjMenus.RoleName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.MenuSetId, convQxPrjMenus.MenuSetId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.MenuSetName, convQxPrjMenus.MenuSetName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.MenuTitle, convQxPrjMenus.MenuTitle);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.PageDispModeId, convQxPrjMenus.PageDispModeId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.PageDispModeName, convQxPrjMenus.PageDispModeName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.MenuControlName, convQxPrjMenus.MenuControlName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.ApplicationTypeName, convQxPrjMenus.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.UpdDate, convQxPrjMenus.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.UpdUserId, convQxPrjMenus.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.Memo, convQxPrjMenus.Memo);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenusEN.UpMenuName, convQxPrjMenus.UpMenuName);
//检查外键字段长度
 objvQxPrjMenusEN._IsCheckProperty = true;
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
string strSQL = "select MenuId, MenuName from vQxPrjMenus ";
 clsSpecSQLforSql mySql = clsvQxPrjMenusDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjMenusEN._CurrTabName);
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
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjMenusEN._CurrTabName, strCondition);
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
 objSQL = clsvQxPrjMenusDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}