
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_UpDA
 表名:vQxPrjMenus_Up(00140080)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:34:11
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
 /// v顶层菜单(vQxPrjMenus_Up)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxPrjMenus_UpDA : clsCommBase4DA
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
 return clsvQxPrjMenus_UpEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxPrjMenus_UpEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjMenus_UpEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxPrjMenus_UpEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxPrjMenus_UpEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strMenuIdUp">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strMenuIdUp)
{
strMenuIdUp = strMenuIdUp.Replace("'", "''");
if (strMenuIdUp.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vQxPrjMenus_Up中,检查关键字,长度不正确!(clsvQxPrjMenus_UpDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMenuIdUp)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxPrjMenus_Up中,关键字不能为空 或 null!(clsvQxPrjMenus_UpDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuIdUp);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxPrjMenus_UpDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strMenuIdUp">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strMenuIdUp)
{
strMenuIdUp = strMenuIdUp.Replace("'", "''");
if (strMenuIdUp.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:vQxPrjMenus_Up中,检查关键字,长度不正确!(简化版)(clsvQxPrjMenus_UpDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMenuIdUp)  ==  true)
{
throw new Exception("(errid:Data000005)在表:vQxPrjMenus_Up中,关键字不能为空 或 null!(clsvQxPrjMenus_UpDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuIdUp);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsvQxPrjMenus_UpDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
 strSQL = "Select * from vQxPrjMenus_Up where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus_Up");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxPrjMenus_Up_SelectByCond",values, "vQxPrjMenus_Up");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Up where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus_Up");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Up a where {0} And a.MenuIdUp not in (Select Top {2} MenuIdUp From vQxPrjMenus_Up Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus_Up");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Up a where {0} And a.MenuIdUp not in (Select Top {2} MenuIdUp From vQxPrjMenus_Up Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus_Up");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Up a where {0} And a.MenuIdUp not in (Select Top {2} MenuIdUp From vQxPrjMenus_Up Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus_Up");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Up where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxPrjMenus_Up(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTable_vQxPrjMenus_Up)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Up where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Up where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Up where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Up where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Up where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Up where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Up where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjMenus_Up.* from vQxPrjMenus_Up Left Join {1} on {2} where {3} and vQxPrjMenus_Up.MenuIdUp not in (Select top {5} vQxPrjMenus_Up.MenuIdUp from vQxPrjMenus_Up Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Up where {1} and MenuIdUp not in (Select top {2} MenuIdUp from vQxPrjMenus_Up where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Up where {1} and MenuIdUp not in (Select top {3} MenuIdUp from vQxPrjMenus_Up where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjMenus_Up.* from vQxPrjMenus_Up Left Join {1} on {2} where {3} and vQxPrjMenus_Up.MenuIdUp not in (Select top {5} vQxPrjMenus_Up.MenuIdUp from vQxPrjMenus_Up Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Up where {1} and MenuIdUp not in (Select top {2} MenuIdUp from vQxPrjMenus_Up where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Up where {1} and MenuIdUp not in (Select top {3} MenuIdUp from vQxPrjMenus_Up where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjMenus_Up.* from vQxPrjMenus_Up Left Join {1} on {2} where {3} and vQxPrjMenus_Up.MenuIdUp not in (Select top {5} vQxPrjMenus_Up.MenuIdUp from vQxPrjMenus_Up Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Up where {1} and MenuIdUp not in (Select top {2} MenuIdUp from vQxPrjMenus_Up where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Up where {1} and MenuIdUp not in (Select top {3} MenuIdUp from vQxPrjMenus_Up where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Up a where {0} And a.MenuIdUp not in (Select Top {2} MenuIdUp From vQxPrjMenus_Up Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Up a where {0} And a.MenuIdUp not in (Select Top {2} MenuIdUp From vQxPrjMenus_Up Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Up a where {0} And a.MenuIdUp not in (Select Top {2} MenuIdUp From vQxPrjMenus_Up Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Up a where {0} And a.MenuIdUp not in (Select Top {2} MenuIdUp From vQxPrjMenus_Up Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_UpByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Up where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_Up_SelectByCond",values);
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
public List<clsvQxPrjMenus_UpEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA:GetObjLst)", objException.Message));
}
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Up where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = TransNullToBool(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjMenus_UpDA: GetObjLst)", objException.Message));
}
objvQxPrjMenus_UpEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjMenus_UpEN);
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
public List<clsvQxPrjMenus_UpEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = TransNullToBool(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjMenus_UpDA: GetObjLst)", objException.Message));
}
objvQxPrjMenus_UpEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjMenus_UpEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxPrjMenus_UpEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_Up_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = TransNullToBool(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjMenus_UpDA: GetObjLstBySP)", objException.Message));
}
objvQxPrjMenus_UpEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjMenus_UpEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjMenus_Up(ref clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Up where MenuIdUp = " + "'"+ objvQxPrjMenus_UpEN.MenuIdUp+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxPrjMenus_UpEN.MenuIdUp = objDT.Rows[0][convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenus_UpEN.MenuName = objDT.Rows[0][convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenus_UpEN.QxPrjId = objDT.Rows[0][convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_UpEN.PrjName = objDT.Rows[0][convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenus_UpEN.UpMenuId = objDT.Rows[0][convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenus_UpEN.LinkFile = objDT.Rows[0][convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxPrjMenus_UpEN.qsParameters = objDT.Rows[0][convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjMenus_UpEN.ImgFile = objDT.Rows[0][convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxPrjMenus_UpEN.OrderNum = TransNullToInt(objDT.Rows[0][convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenus_UpEN.IsLeafNode = TransNullToBool(objDT.Rows[0][convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_UpEN.MenuSetId = objDT.Rows[0][convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_UpEN.MenuSetName = objDT.Rows[0][convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_UpEN.MenuTitle = objDT.Rows[0][convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_UpEN.PageDispModeId = objDT.Rows[0][convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxPrjMenus_UpEN.PageDispModeName = objDT.Rows[0][convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_UpEN.InUse = TransNullToBool(objDT.Rows[0][convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_UpEN.UpdDate = objDT.Rows[0][convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_UpEN.UpdUserId = objDT.Rows[0][convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_UpEN.Memo = objDT.Rows[0][convQxPrjMenus_Up.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjMenus_UpEN.MenuControlName = objDT.Rows[0][convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxPrjMenus_UpDA: GetvQxPrjMenus_Up)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuIdUp">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxPrjMenus_UpEN GetObjByMenuIdUp(string strMenuIdUp)
{
CheckPrimaryKey(strMenuIdUp);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Up where MenuIdUp = " + "'"+ strMenuIdUp+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
 objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxPrjMenus_UpDA: GetObjByMenuIdUp)", objException.Message));
}
return objvQxPrjMenus_UpEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxPrjMenus_Up_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjMenus_UpOneBySP(clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxPrjMenus_UpEN.MenuIdUp
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_Up_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxPrjMenus_UpEN.MenuIdUp = objDT.Rows[0][convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenus_UpEN.MenuName = objDT.Rows[0][convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenus_UpEN.QxPrjId = objDT.Rows[0][convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_UpEN.PrjName = objDT.Rows[0][convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenus_UpEN.UpMenuId = objDT.Rows[0][convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenus_UpEN.LinkFile = objDT.Rows[0][convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxPrjMenus_UpEN.qsParameters = objDT.Rows[0][convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjMenus_UpEN.ImgFile = objDT.Rows[0][convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxPrjMenus_UpEN.OrderNum = TransNullToInt(objDT.Rows[0][convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenus_UpEN.IsLeafNode = TransNullToBool(objDT.Rows[0][convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_UpEN.MenuSetId = objDT.Rows[0][convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_UpEN.MenuSetName = objDT.Rows[0][convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_UpEN.MenuTitle = objDT.Rows[0][convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_UpEN.PageDispModeId = objDT.Rows[0][convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxPrjMenus_UpEN.PageDispModeName = objDT.Rows[0][convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_UpEN.InUse = TransNullToBool(objDT.Rows[0][convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_UpEN.UpdDate = objDT.Rows[0][convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_UpEN.UpdUserId = objDT.Rows[0][convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_UpEN.Memo = objDT.Rows[0][convQxPrjMenus_Up.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjMenus_UpEN.MenuControlName = objDT.Rows[0][convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjMenus_UpEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Up where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN()
{
MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(), //MenuId_Up
MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(), //菜单名
QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(), //工程名
UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(), //qs参数
ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(), //图像文件
OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(), //菜单集Id
MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(), //菜单集名称
MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(), //页面显示模式Id
PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(), //页面显示模式名称
InUse = TransNullToBool(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(), //备注
MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim() //MenuControlName
};
objvQxPrjMenus_UpEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenus_UpEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxPrjMenus_UpDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjMenus_UpEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_Up_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN()
{
MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(), //MenuId_Up
MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(), //菜单名
QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(), //工程名
UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(), //qs参数
ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(), //图像文件
OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(), //菜单集Id
MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(), //菜单集名称
MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(), //页面显示模式Id
PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(), //页面显示模式名称
InUse = TransNullToBool(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(), //备注
MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim() //MenuControlName
};
objvQxPrjMenus_UpEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenus_UpEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxPrjMenus_UpEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = TransNullToBool(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxPrjMenus_UpDA: GetObjByDataRowvQxPrjMenus_Up)", objException.Message));
}
objvQxPrjMenus_UpEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenus_UpEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxPrjMenus_UpEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = TransNullToBool(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxPrjMenus_UpDA: GetObjByDataRow)", objException.Message));
}
objvQxPrjMenus_UpEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenus_UpEN;
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
objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjMenus_UpEN._CurrTabName, convQxPrjMenus_Up.MenuIdUp, 8, "");
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
objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjMenus_UpEN._CurrTabName, convQxPrjMenus_Up.MenuIdUp, 8, strPrefix);
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
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MenuIdUp from vQxPrjMenus_Up where " + strCondition;
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
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MenuIdUp from vQxPrjMenus_Up where " + strCondition;
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
 /// <param name = "strMenuIdUp">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strMenuIdUp)
{
CheckPrimaryKey(strMenuIdUp);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjMenus_Up", "MenuIdUp = " + "'"+ strMenuIdUp+"'"))
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
 /// <param name = "strMenuIdUp">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strMenuIdUp)
{
CheckPrimaryKey(strMenuIdUp);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strMenuIdUp,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxPrjMenus_Up_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjMenus_Up", strCondition))
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
objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxPrjMenus_Up");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpENS">源对象</param>
 /// <param name = "objvQxPrjMenus_UpENT">目标对象</param>
public void CopyTo(clsvQxPrjMenus_UpEN objvQxPrjMenus_UpENS, clsvQxPrjMenus_UpEN objvQxPrjMenus_UpENT)
{
objvQxPrjMenus_UpENT.MenuIdUp = objvQxPrjMenus_UpENS.MenuIdUp; //MenuId_Up
objvQxPrjMenus_UpENT.MenuName = objvQxPrjMenus_UpENS.MenuName; //菜单名
objvQxPrjMenus_UpENT.QxPrjId = objvQxPrjMenus_UpENS.QxPrjId; //项目Id
objvQxPrjMenus_UpENT.PrjName = objvQxPrjMenus_UpENS.PrjName; //工程名
objvQxPrjMenus_UpENT.UpMenuId = objvQxPrjMenus_UpENS.UpMenuId; //上级菜单Id
objvQxPrjMenus_UpENT.LinkFile = objvQxPrjMenus_UpENS.LinkFile; //链接文件
objvQxPrjMenus_UpENT.qsParameters = objvQxPrjMenus_UpENS.qsParameters; //qs参数
objvQxPrjMenus_UpENT.ImgFile = objvQxPrjMenus_UpENS.ImgFile; //图像文件
objvQxPrjMenus_UpENT.OrderNum = objvQxPrjMenus_UpENS.OrderNum; //排序号
objvQxPrjMenus_UpENT.IsLeafNode = objvQxPrjMenus_UpENS.IsLeafNode; //是否叶子
objvQxPrjMenus_UpENT.MenuSetId = objvQxPrjMenus_UpENS.MenuSetId; //菜单集Id
objvQxPrjMenus_UpENT.MenuSetName = objvQxPrjMenus_UpENS.MenuSetName; //菜单集名称
objvQxPrjMenus_UpENT.MenuTitle = objvQxPrjMenus_UpENS.MenuTitle; //菜单标题
objvQxPrjMenus_UpENT.PageDispModeId = objvQxPrjMenus_UpENS.PageDispModeId; //页面显示模式Id
objvQxPrjMenus_UpENT.PageDispModeName = objvQxPrjMenus_UpENS.PageDispModeName; //页面显示模式名称
objvQxPrjMenus_UpENT.InUse = objvQxPrjMenus_UpENS.InUse; //是否在用
objvQxPrjMenus_UpENT.UpdDate = objvQxPrjMenus_UpENS.UpdDate; //修改日期
objvQxPrjMenus_UpENT.UpdUserId = objvQxPrjMenus_UpENS.UpdUserId; //修改用户Id
objvQxPrjMenus_UpENT.Memo = objvQxPrjMenus_UpENS.Memo; //备注
objvQxPrjMenus_UpENT.MenuControlName = objvQxPrjMenus_UpENS.MenuControlName; //MenuControlName
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.MenuIdUp, 8, convQxPrjMenus_Up.MenuIdUp);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.MenuName, 50, convQxPrjMenus_Up.MenuName);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.QxPrjId, 4, convQxPrjMenus_Up.QxPrjId);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.PrjName, 30, convQxPrjMenus_Up.PrjName);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.UpMenuId, 8, convQxPrjMenus_Up.UpMenuId);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.LinkFile, 500, convQxPrjMenus_Up.LinkFile);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.qsParameters, 200, convQxPrjMenus_Up.qsParameters);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.ImgFile, 300, convQxPrjMenus_Up.ImgFile);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.MenuSetId, 4, convQxPrjMenus_Up.MenuSetId);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.MenuSetName, 50, convQxPrjMenus_Up.MenuSetName);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.MenuTitle, 50, convQxPrjMenus_Up.MenuTitle);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.PageDispModeId, 2, convQxPrjMenus_Up.PageDispModeId);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.PageDispModeName, 50, convQxPrjMenus_Up.PageDispModeName);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.UpdDate, 20, convQxPrjMenus_Up.UpdDate);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.UpdUserId, 20, convQxPrjMenus_Up.UpdUserId);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.Memo, 1000, convQxPrjMenus_Up.Memo);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_UpEN.MenuControlName, 100, convQxPrjMenus_Up.MenuControlName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.MenuIdUp, convQxPrjMenus_Up.MenuIdUp);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.MenuName, convQxPrjMenus_Up.MenuName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.QxPrjId, convQxPrjMenus_Up.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.PrjName, convQxPrjMenus_Up.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.UpMenuId, convQxPrjMenus_Up.UpMenuId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.LinkFile, convQxPrjMenus_Up.LinkFile);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.qsParameters, convQxPrjMenus_Up.qsParameters);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.ImgFile, convQxPrjMenus_Up.ImgFile);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.MenuSetId, convQxPrjMenus_Up.MenuSetId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.MenuSetName, convQxPrjMenus_Up.MenuSetName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.MenuTitle, convQxPrjMenus_Up.MenuTitle);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.PageDispModeId, convQxPrjMenus_Up.PageDispModeId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.PageDispModeName, convQxPrjMenus_Up.PageDispModeName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.UpdDate, convQxPrjMenus_Up.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.UpdUserId, convQxPrjMenus_Up.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.Memo, convQxPrjMenus_Up.Memo);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_UpEN.MenuControlName, convQxPrjMenus_Up.MenuControlName);
//检查外键字段长度
 objvQxPrjMenus_UpEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetMenuIdUp()
{
//获取某学院所有专业信息
string strSQL = "select MenuIdUp, MenuName from vQxPrjMenus_Up ";
 clsSpecSQLforSql mySql = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjMenus_UpEN._CurrTabName);
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
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjMenus_UpEN._CurrTabName, strCondition);
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
 objSQL = clsvQxPrjMenus_UpDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}