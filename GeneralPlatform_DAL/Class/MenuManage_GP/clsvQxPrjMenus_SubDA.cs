
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_SubDA
 表名:vQxPrjMenus_Sub(00140079)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:33:39
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
 /// v子层菜单(vQxPrjMenus_Sub)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxPrjMenus_SubDA : clsCommBase4DA
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
 return clsvQxPrjMenus_SubEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxPrjMenus_SubEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjMenus_SubEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxPrjMenus_SubEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxPrjMenus_SubEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strMenuIdSub">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strMenuIdSub)
{
strMenuIdSub = strMenuIdSub.Replace("'", "''");
if (strMenuIdSub.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vQxPrjMenus_Sub中,检查关键字,长度不正确!(clsvQxPrjMenus_SubDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMenuIdSub)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxPrjMenus_Sub中,关键字不能为空 或 null!(clsvQxPrjMenus_SubDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuIdSub);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxPrjMenus_SubDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strMenuIdSub">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strMenuIdSub)
{
strMenuIdSub = strMenuIdSub.Replace("'", "''");
if (strMenuIdSub.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:vQxPrjMenus_Sub中,检查关键字,长度不正确!(简化版)(clsvQxPrjMenus_SubDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMenuIdSub)  ==  true)
{
throw new Exception("(errid:Data000005)在表:vQxPrjMenus_Sub中,关键字不能为空 或 null!(clsvQxPrjMenus_SubDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuIdSub);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsvQxPrjMenus_SubDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
 strSQL = "Select * from vQxPrjMenus_Sub where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus_Sub");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxPrjMenus_Sub_SelectByCond",values, "vQxPrjMenus_Sub");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Sub where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus_Sub");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Sub a where {0} And a.MenuIdSub not in (Select Top {2} MenuIdSub From vQxPrjMenus_Sub Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus_Sub");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Sub a where {0} And a.MenuIdSub not in (Select Top {2} MenuIdSub From vQxPrjMenus_Sub Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus_Sub");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Sub a where {0} And a.MenuIdSub not in (Select Top {2} MenuIdSub From vQxPrjMenus_Sub Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjMenus_Sub");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Sub where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxPrjMenus_Sub(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTable_vQxPrjMenus_Sub)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Sub where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Sub where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Sub where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Sub where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Sub where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Sub where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Sub where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjMenus_Sub.* from vQxPrjMenus_Sub Left Join {1} on {2} where {3} and vQxPrjMenus_Sub.MenuIdSub not in (Select top {5} vQxPrjMenus_Sub.MenuIdSub from vQxPrjMenus_Sub Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Sub where {1} and MenuIdSub not in (Select top {2} MenuIdSub from vQxPrjMenus_Sub where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Sub where {1} and MenuIdSub not in (Select top {3} MenuIdSub from vQxPrjMenus_Sub where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjMenus_Sub.* from vQxPrjMenus_Sub Left Join {1} on {2} where {3} and vQxPrjMenus_Sub.MenuIdSub not in (Select top {5} vQxPrjMenus_Sub.MenuIdSub from vQxPrjMenus_Sub Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Sub where {1} and MenuIdSub not in (Select top {2} MenuIdSub from vQxPrjMenus_Sub where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Sub where {1} and MenuIdSub not in (Select top {3} MenuIdSub from vQxPrjMenus_Sub where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjMenus_Sub.* from vQxPrjMenus_Sub Left Join {1} on {2} where {3} and vQxPrjMenus_Sub.MenuIdSub not in (Select top {5} vQxPrjMenus_Sub.MenuIdSub from vQxPrjMenus_Sub Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Sub where {1} and MenuIdSub not in (Select top {2} MenuIdSub from vQxPrjMenus_Sub where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjMenus_Sub where {1} and MenuIdSub not in (Select top {3} MenuIdSub from vQxPrjMenus_Sub where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Sub a where {0} And a.MenuIdSub not in (Select Top {2} MenuIdSub From vQxPrjMenus_Sub Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Sub a where {0} And a.MenuIdSub not in (Select Top {2} MenuIdSub From vQxPrjMenus_Sub Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Sub a where {0} And a.MenuIdSub not in (Select Top {2} MenuIdSub From vQxPrjMenus_Sub Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjMenus_Sub a where {0} And a.MenuIdSub not in (Select Top {2} MenuIdSub From vQxPrjMenus_Sub Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_SubByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Sub where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_Sub_SelectByCond",values);
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
public List<clsvQxPrjMenus_SubEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA:GetObjLst)", objException.Message));
}
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Sub where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = TransNullToBool(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjMenus_SubDA: GetObjLst)", objException.Message));
}
objvQxPrjMenus_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjMenus_SubEN);
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
public List<clsvQxPrjMenus_SubEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = TransNullToBool(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjMenus_SubDA: GetObjLst)", objException.Message));
}
objvQxPrjMenus_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjMenus_SubEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxPrjMenus_SubEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_Sub_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = TransNullToBool(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjMenus_SubDA: GetObjLstBySP)", objException.Message));
}
objvQxPrjMenus_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjMenus_SubEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjMenus_Sub(ref clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Sub where MenuIdSub = " + "'"+ objvQxPrjMenus_SubEN.MenuIdSub+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxPrjMenus_SubEN.MenuIdSub = objDT.Rows[0][convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenus_SubEN.MenuName = objDT.Rows[0][convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenus_SubEN.QxPrjId = objDT.Rows[0][convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_SubEN.PrjName = objDT.Rows[0][convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenus_SubEN.UpMenuId = objDT.Rows[0][convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenus_SubEN.LinkFile = objDT.Rows[0][convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxPrjMenus_SubEN.qsParameters = objDT.Rows[0][convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjMenus_SubEN.ImgFile = objDT.Rows[0][convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxPrjMenus_SubEN.OrderNum = TransNullToInt(objDT.Rows[0][convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenus_SubEN.IsLeafNode = TransNullToBool(objDT.Rows[0][convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_SubEN.MenuSetId = objDT.Rows[0][convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_SubEN.MenuSetName = objDT.Rows[0][convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_SubEN.MenuTitle = objDT.Rows[0][convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_SubEN.PageDispModeId = objDT.Rows[0][convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxPrjMenus_SubEN.PageDispModeName = objDT.Rows[0][convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_SubEN.InUse = TransNullToBool(objDT.Rows[0][convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_SubEN.UpdDate = objDT.Rows[0][convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_SubEN.UpdUserId = objDT.Rows[0][convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_SubEN.Memo = objDT.Rows[0][convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjMenus_SubEN.MenuControlName = objDT.Rows[0][convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxPrjMenus_SubDA: GetvQxPrjMenus_Sub)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuIdSub">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxPrjMenus_SubEN GetObjByMenuIdSub(string strMenuIdSub)
{
CheckPrimaryKey(strMenuIdSub);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Sub where MenuIdSub = " + "'"+ strMenuIdSub+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
 objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxPrjMenus_SubDA: GetObjByMenuIdSub)", objException.Message));
}
return objvQxPrjMenus_SubEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxPrjMenus_Sub_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjMenus_SubOneBySP(clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxPrjMenus_SubEN.MenuIdSub
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_Sub_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxPrjMenus_SubEN.MenuIdSub = objDT.Rows[0][convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjMenus_SubEN.MenuName = objDT.Rows[0][convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjMenus_SubEN.QxPrjId = objDT.Rows[0][convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_SubEN.PrjName = objDT.Rows[0][convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjMenus_SubEN.UpMenuId = objDT.Rows[0][convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxPrjMenus_SubEN.LinkFile = objDT.Rows[0][convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objvQxPrjMenus_SubEN.qsParameters = objDT.Rows[0][convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjMenus_SubEN.ImgFile = objDT.Rows[0][convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objvQxPrjMenus_SubEN.OrderNum = TransNullToInt(objDT.Rows[0][convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxPrjMenus_SubEN.IsLeafNode = TransNullToBool(objDT.Rows[0][convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_SubEN.MenuSetId = objDT.Rows[0][convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjMenus_SubEN.MenuSetName = objDT.Rows[0][convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_SubEN.MenuTitle = objDT.Rows[0][convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_SubEN.PageDispModeId = objDT.Rows[0][convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxPrjMenus_SubEN.PageDispModeName = objDT.Rows[0][convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjMenus_SubEN.InUse = TransNullToBool(objDT.Rows[0][convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjMenus_SubEN.UpdDate = objDT.Rows[0][convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_SubEN.UpdUserId = objDT.Rows[0][convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjMenus_SubEN.Memo = objDT.Rows[0][convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjMenus_SubEN.MenuControlName = objDT.Rows[0][convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjMenus_SubEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjMenus_Sub where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN()
{
MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(), //MenuId_Sub
MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(), //菜单名
QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(), //工程名
UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(), //qs参数
ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(), //图像文件
OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(), //菜单集Id
MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(), //菜单集名称
MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(), //页面显示模式Id
PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(), //页面显示模式名称
InUse = TransNullToBool(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(), //备注
MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim() //MenuControlName
};
objvQxPrjMenus_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenus_SubEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxPrjMenus_SubDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjMenus_SubEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjMenus_Sub_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN()
{
MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(), //MenuId_Sub
MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(), //菜单名
QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(), //工程名
UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(), //链接文件
qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(), //qs参数
ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(), //图像文件
OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()), //排序号
IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(), //菜单集Id
MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(), //菜单集名称
MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(), //页面显示模式Id
PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(), //页面显示模式名称
InUse = TransNullToBool(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(), //备注
MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim() //MenuControlName
};
objvQxPrjMenus_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenus_SubEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxPrjMenus_SubEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = TransNullToBool(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxPrjMenus_SubDA: GetObjByDataRowvQxPrjMenus_Sub)", objException.Message));
}
objvQxPrjMenus_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenus_SubEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxPrjMenus_SubEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = TransNullToBool(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = TransNullToBool(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxPrjMenus_SubDA: GetObjByDataRow)", objException.Message));
}
objvQxPrjMenus_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjMenus_SubEN;
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
objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjMenus_SubEN._CurrTabName, convQxPrjMenus_Sub.MenuIdSub, 8, "");
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
objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjMenus_SubEN._CurrTabName, convQxPrjMenus_Sub.MenuIdSub, 8, strPrefix);
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
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MenuIdSub from vQxPrjMenus_Sub where " + strCondition;
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
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MenuIdSub from vQxPrjMenus_Sub where " + strCondition;
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
 /// <param name = "strMenuIdSub">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strMenuIdSub)
{
CheckPrimaryKey(strMenuIdSub);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjMenus_Sub", "MenuIdSub = " + "'"+ strMenuIdSub+"'"))
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
 /// <param name = "strMenuIdSub">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strMenuIdSub)
{
CheckPrimaryKey(strMenuIdSub);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strMenuIdSub,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxPrjMenus_Sub_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjMenus_Sub", strCondition))
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
objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxPrjMenus_Sub");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubENS">源对象</param>
 /// <param name = "objvQxPrjMenus_SubENT">目标对象</param>
public void CopyTo(clsvQxPrjMenus_SubEN objvQxPrjMenus_SubENS, clsvQxPrjMenus_SubEN objvQxPrjMenus_SubENT)
{
objvQxPrjMenus_SubENT.MenuIdSub = objvQxPrjMenus_SubENS.MenuIdSub; //MenuId_Sub
objvQxPrjMenus_SubENT.MenuName = objvQxPrjMenus_SubENS.MenuName; //菜单名
objvQxPrjMenus_SubENT.QxPrjId = objvQxPrjMenus_SubENS.QxPrjId; //项目Id
objvQxPrjMenus_SubENT.PrjName = objvQxPrjMenus_SubENS.PrjName; //工程名
objvQxPrjMenus_SubENT.UpMenuId = objvQxPrjMenus_SubENS.UpMenuId; //上级菜单Id
objvQxPrjMenus_SubENT.LinkFile = objvQxPrjMenus_SubENS.LinkFile; //链接文件
objvQxPrjMenus_SubENT.qsParameters = objvQxPrjMenus_SubENS.qsParameters; //qs参数
objvQxPrjMenus_SubENT.ImgFile = objvQxPrjMenus_SubENS.ImgFile; //图像文件
objvQxPrjMenus_SubENT.OrderNum = objvQxPrjMenus_SubENS.OrderNum; //排序号
objvQxPrjMenus_SubENT.IsLeafNode = objvQxPrjMenus_SubENS.IsLeafNode; //是否叶子
objvQxPrjMenus_SubENT.MenuSetId = objvQxPrjMenus_SubENS.MenuSetId; //菜单集Id
objvQxPrjMenus_SubENT.MenuSetName = objvQxPrjMenus_SubENS.MenuSetName; //菜单集名称
objvQxPrjMenus_SubENT.MenuTitle = objvQxPrjMenus_SubENS.MenuTitle; //菜单标题
objvQxPrjMenus_SubENT.PageDispModeId = objvQxPrjMenus_SubENS.PageDispModeId; //页面显示模式Id
objvQxPrjMenus_SubENT.PageDispModeName = objvQxPrjMenus_SubENS.PageDispModeName; //页面显示模式名称
objvQxPrjMenus_SubENT.InUse = objvQxPrjMenus_SubENS.InUse; //是否在用
objvQxPrjMenus_SubENT.UpdDate = objvQxPrjMenus_SubENS.UpdDate; //修改日期
objvQxPrjMenus_SubENT.UpdUserId = objvQxPrjMenus_SubENS.UpdUserId; //修改用户Id
objvQxPrjMenus_SubENT.Memo = objvQxPrjMenus_SubENS.Memo; //备注
objvQxPrjMenus_SubENT.MenuControlName = objvQxPrjMenus_SubENS.MenuControlName; //MenuControlName
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.MenuIdSub, 8, convQxPrjMenus_Sub.MenuIdSub);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.MenuName, 50, convQxPrjMenus_Sub.MenuName);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.QxPrjId, 4, convQxPrjMenus_Sub.QxPrjId);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.PrjName, 30, convQxPrjMenus_Sub.PrjName);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.UpMenuId, 8, convQxPrjMenus_Sub.UpMenuId);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.LinkFile, 500, convQxPrjMenus_Sub.LinkFile);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.qsParameters, 200, convQxPrjMenus_Sub.qsParameters);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.ImgFile, 300, convQxPrjMenus_Sub.ImgFile);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.MenuSetId, 4, convQxPrjMenus_Sub.MenuSetId);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.MenuSetName, 50, convQxPrjMenus_Sub.MenuSetName);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.MenuTitle, 50, convQxPrjMenus_Sub.MenuTitle);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.PageDispModeId, 2, convQxPrjMenus_Sub.PageDispModeId);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.PageDispModeName, 50, convQxPrjMenus_Sub.PageDispModeName);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.UpdDate, 20, convQxPrjMenus_Sub.UpdDate);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.UpdUserId, 20, convQxPrjMenus_Sub.UpdUserId);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.Memo, 1000, convQxPrjMenus_Sub.Memo);
clsCheckSql.CheckFieldLen(objvQxPrjMenus_SubEN.MenuControlName, 100, convQxPrjMenus_Sub.MenuControlName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.MenuIdSub, convQxPrjMenus_Sub.MenuIdSub);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.MenuName, convQxPrjMenus_Sub.MenuName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.QxPrjId, convQxPrjMenus_Sub.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.PrjName, convQxPrjMenus_Sub.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.UpMenuId, convQxPrjMenus_Sub.UpMenuId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.LinkFile, convQxPrjMenus_Sub.LinkFile);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.qsParameters, convQxPrjMenus_Sub.qsParameters);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.ImgFile, convQxPrjMenus_Sub.ImgFile);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.MenuSetId, convQxPrjMenus_Sub.MenuSetId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.MenuSetName, convQxPrjMenus_Sub.MenuSetName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.MenuTitle, convQxPrjMenus_Sub.MenuTitle);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.PageDispModeId, convQxPrjMenus_Sub.PageDispModeId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.PageDispModeName, convQxPrjMenus_Sub.PageDispModeName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.UpdDate, convQxPrjMenus_Sub.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.UpdUserId, convQxPrjMenus_Sub.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.Memo, convQxPrjMenus_Sub.Memo);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjMenus_SubEN.MenuControlName, convQxPrjMenus_Sub.MenuControlName);
//检查外键字段长度
 objvQxPrjMenus_SubEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetMenuIdSub()
{
//获取某学院所有专业信息
string strSQL = "select MenuIdSub, MenuName from vQxPrjMenus_Sub ";
 clsSpecSQLforSql mySql = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjMenus_SubEN._CurrTabName);
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
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjMenus_SubEN._CurrTabName, strCondition);
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
 objSQL = clsvQxPrjMenus_SubDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}