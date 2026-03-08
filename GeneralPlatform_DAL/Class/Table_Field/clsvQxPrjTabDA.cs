
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjTabDA
 表名:vQxPrjTab(00140097)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:46:50
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:字段、表维护(Table_Field)
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
 /// v工程表(vQxPrjTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxPrjTabDA : clsCommBase4DA
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
 return clsvQxPrjTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxPrjTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxPrjTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxPrjTabEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTabId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTabId)
{
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vQxPrjTab中,检查关键字,长度不正确!(clsvQxPrjTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxPrjTab中,关键字不能为空 或 null!(clsvQxPrjTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxPrjTabDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strTabId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strTabId)
{
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:vQxPrjTab中,检查关键字,长度不正确!(简化版)(clsvQxPrjTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:vQxPrjTab中,关键字不能为空 或 null!(clsvQxPrjTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsvQxPrjTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
 strSQL = "Select * from vQxPrjTab where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjTab");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxPrjTab_SelectByCond",values, "vQxPrjTab");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjTab where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjTab");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From vQxPrjTab Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjTab");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From vQxPrjTab Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjTab");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From vQxPrjTab Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjTab");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxPrjTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTable_vQxPrjTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjTab.* from vQxPrjTab Left Join {1} on {2} where {3} and vQxPrjTab.TabId not in (Select top {5} vQxPrjTab.TabId from vQxPrjTab Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjTab where {1} and TabId not in (Select top {2} TabId from vQxPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjTab where {1} and TabId not in (Select top {3} TabId from vQxPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjTab.* from vQxPrjTab Left Join {1} on {2} where {3} and vQxPrjTab.TabId not in (Select top {5} vQxPrjTab.TabId from vQxPrjTab Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjTab where {1} and TabId not in (Select top {2} TabId from vQxPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjTab where {1} and TabId not in (Select top {3} TabId from vQxPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjTab.* from vQxPrjTab Left Join {1} on {2} where {3} and vQxPrjTab.TabId not in (Select top {5} vQxPrjTab.TabId from vQxPrjTab Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjTab where {1} and TabId not in (Select top {2} TabId from vQxPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjTab where {1} and TabId not in (Select top {3} TabId from vQxPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From vQxPrjTab Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From vQxPrjTab Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From vQxPrjTab Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From vQxPrjTab Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjTabDA: GetvQxPrjTabByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjTab_SelectByCond",values);
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
public List<clsvQxPrjTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxPrjTabDA:GetObjLst)", objException.Message));
}
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = TransNullToBool(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjTabDA: GetObjLst)", objException.Message));
}
objvQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjTabEN);
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
public List<clsvQxPrjTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxPrjTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = TransNullToBool(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjTabDA: GetObjLst)", objException.Message));
}
objvQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxPrjTabEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxPrjTabDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjTab_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = TransNullToBool(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjTabDA: GetObjLstBySP)", objException.Message));
}
objvQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjTab(ref clsvQxPrjTabEN objvQxPrjTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjTab where TabId = " + "'"+ objvQxPrjTabEN.TabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxPrjTabEN.TabId = objDT.Rows[0][convQxPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjTabEN.TabName = objDT.Rows[0][convQxPrjTab.TabName].ToString().Trim(); //TabName(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxPrjTabEN.TabCnName = objDT.Rows[0][convQxPrjTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjTabEN.QxPrjId = objDT.Rows[0][convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjTabEN.PrjName = objDT.Rows[0][convQxPrjTab.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.SQLDSTypeId = objDT.Rows[0][convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjTabEN.SqlDsTypeName = objDT.Rows[0][convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjTabEN.TabStateId = objDT.Rows[0][convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjTabEN.TabStateName = objDT.Rows[0][convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.IsParaTab = TransNullToBool(objDT.Rows[0][convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjTabEN.FuncModuleAgcId = objDT.Rows[0][convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjTabEN.FuncModuleName = objDT.Rows[0][convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjTabEN.FuncModuleEnName = objDT.Rows[0][convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjTabEN.Owner = objDT.Rows[0][convQxPrjTab.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjTabEN.Keyword = objDT.Rows[0][convQxPrjTab.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjTabEN.TabTypeId = objDT.Rows[0][convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjTabEN.TabTypeName = objDT.Rows[0][convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.PrimaryTypeId = objDT.Rows[0][convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjTabEN.PrimaryTypeName = objDT.Rows[0][convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.KeyFldId = objDT.Rows[0][convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxPrjTabEN.KeyFldName = objDT.Rows[0][convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjTabEN.UpdUserId = objDT.Rows[0][convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjTabEN.UpdDate = objDT.Rows[0][convQxPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjTabEN.Memo = objDT.Rows[0][convQxPrjTab.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjTabEN.UpdDate2 = objDT.Rows[0][convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2(字段类型:varchar,字段长度:14,是否可空:True)
 objvQxPrjTabEN.RelaViewId = objDT.Rows[0][convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxPrjTabDA: GetvQxPrjTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxPrjTabEN GetObjByTabId(string strTabId)
{
CheckPrimaryKey(strTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjTab where TabId = " + "'"+ strTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
 objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2(字段类型:varchar,字段长度:14,是否可空:True)
 objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxPrjTabDA: GetObjByTabId)", objException.Message));
}
return objvQxPrjTabEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxPrjTab_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjTabOneBySP(clsvQxPrjTabEN objvQxPrjTabEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxPrjTabEN.TabId
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjTab_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxPrjTabEN.TabId = objDT.Rows[0][convQxPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjTabEN.TabName = objDT.Rows[0][convQxPrjTab.TabName].ToString().Trim(); //TabName(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxPrjTabEN.TabCnName = objDT.Rows[0][convQxPrjTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvQxPrjTabEN.QxPrjId = objDT.Rows[0][convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjTabEN.PrjName = objDT.Rows[0][convQxPrjTab.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.SQLDSTypeId = objDT.Rows[0][convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjTabEN.SqlDsTypeName = objDT.Rows[0][convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjTabEN.TabStateId = objDT.Rows[0][convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjTabEN.TabStateName = objDT.Rows[0][convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.IsParaTab = TransNullToBool(objDT.Rows[0][convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objvQxPrjTabEN.FuncModuleAgcId = objDT.Rows[0][convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvQxPrjTabEN.FuncModuleName = objDT.Rows[0][convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjTabEN.FuncModuleEnName = objDT.Rows[0][convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjTabEN.Owner = objDT.Rows[0][convQxPrjTab.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjTabEN.Keyword = objDT.Rows[0][convQxPrjTab.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjTabEN.TabTypeId = objDT.Rows[0][convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjTabEN.TabTypeName = objDT.Rows[0][convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.PrimaryTypeId = objDT.Rows[0][convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjTabEN.PrimaryTypeName = objDT.Rows[0][convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjTabEN.KeyFldId = objDT.Rows[0][convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxPrjTabEN.KeyFldName = objDT.Rows[0][convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjTabEN.UpdUserId = objDT.Rows[0][convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjTabEN.UpdDate = objDT.Rows[0][convQxPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjTabEN.Memo = objDT.Rows[0][convQxPrjTab.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxPrjTabEN.UpdDate2 = objDT.Rows[0][convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2(字段类型:varchar,字段长度:14,是否可空:True)
 objvQxPrjTabEN.RelaViewId = objDT.Rows[0][convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId(字段类型:char,字段长度:8,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxPrjTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN()
{
TabId = objRow[convQxPrjTab.TabId].ToString().Trim(), //表ID
TabName = objRow[convQxPrjTab.TabName].ToString().Trim(), //TabName
TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(), //表中文名
QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(), //工程名
SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(), //数据源类型
SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(), //Sql数据源名
TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(), //表状态ID
TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(), //表状态名称
IsParaTab = TransNullToBool(objRow[convQxPrjTab.IsParaTab].ToString().Trim()), //是否参数表
FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(), //模块名
FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(), //模块英文名
Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(), //拥有者
Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(), //关键字
TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(), //表类型Id
TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(), //表类型名
PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(), //主键类型ID
PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(), //主键类型名
KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(), //关键字段Id
KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(), //关键字段名
UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(), //备注
UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(), //UpdDate2
RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim() //RelaViewId
};
objvQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxPrjTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjTabEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxPrjTabDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjTab_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN()
{
TabId = objRow[convQxPrjTab.TabId].ToString().Trim(), //表ID
TabName = objRow[convQxPrjTab.TabName].ToString().Trim(), //TabName
TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(), //表中文名
QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(), //工程名
SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(), //数据源类型
SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(), //Sql数据源名
TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(), //表状态ID
TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(), //表状态名称
IsParaTab = TransNullToBool(objRow[convQxPrjTab.IsParaTab].ToString().Trim()), //是否参数表
FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(), //模块名
FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(), //模块英文名
Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(), //拥有者
Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(), //关键字
TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(), //表类型Id
TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(), //表类型名
PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(), //主键类型ID
PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(), //主键类型名
KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(), //关键字段Id
KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(), //关键字段名
UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(), //备注
UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(), //UpdDate2
RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim() //RelaViewId
};
objvQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjTabEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxPrjTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = TransNullToBool(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxPrjTabDA: GetObjByDataRowvQxPrjTab)", objException.Message));
}
objvQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxPrjTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = TransNullToBool(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxPrjTabDA: GetObjByDataRow)", objException.Message));
}
objvQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjTabEN;
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
objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjTabEN._CurrTabName, convQxPrjTab.TabId, 8, "");
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
objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjTabEN._CurrTabName, convQxPrjTab.TabId, 8, strPrefix);
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
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabId from vQxPrjTab where " + strCondition;
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
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabId from vQxPrjTab where " + strCondition;
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTabId)
{
CheckPrimaryKey(strTabId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjTab", "TabId = " + "'"+ strTabId+"'"))
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strTabId)
{
CheckPrimaryKey(strTabId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strTabId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxPrjTab_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxPrjTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjTab", strCondition))
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
objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxPrjTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxPrjTabENS">源对象</param>
 /// <param name = "objvQxPrjTabENT">目标对象</param>
public void CopyTo(clsvQxPrjTabEN objvQxPrjTabENS, clsvQxPrjTabEN objvQxPrjTabENT)
{
objvQxPrjTabENT.TabId = objvQxPrjTabENS.TabId; //表ID
objvQxPrjTabENT.TabName = objvQxPrjTabENS.TabName; //TabName
objvQxPrjTabENT.TabCnName = objvQxPrjTabENS.TabCnName; //表中文名
objvQxPrjTabENT.QxPrjId = objvQxPrjTabENS.QxPrjId; //项目Id
objvQxPrjTabENT.PrjName = objvQxPrjTabENS.PrjName; //工程名
objvQxPrjTabENT.SQLDSTypeId = objvQxPrjTabENS.SQLDSTypeId; //数据源类型
objvQxPrjTabENT.SqlDsTypeName = objvQxPrjTabENS.SqlDsTypeName; //Sql数据源名
objvQxPrjTabENT.TabStateId = objvQxPrjTabENS.TabStateId; //表状态ID
objvQxPrjTabENT.TabStateName = objvQxPrjTabENS.TabStateName; //表状态名称
objvQxPrjTabENT.IsParaTab = objvQxPrjTabENS.IsParaTab; //是否参数表
objvQxPrjTabENT.FuncModuleAgcId = objvQxPrjTabENS.FuncModuleAgcId; //功能模块Id
objvQxPrjTabENT.FuncModuleName = objvQxPrjTabENS.FuncModuleName; //模块名
objvQxPrjTabENT.FuncModuleEnName = objvQxPrjTabENS.FuncModuleEnName; //模块英文名
objvQxPrjTabENT.Owner = objvQxPrjTabENS.Owner; //拥有者
objvQxPrjTabENT.Keyword = objvQxPrjTabENS.Keyword; //关键字
objvQxPrjTabENT.TabTypeId = objvQxPrjTabENS.TabTypeId; //表类型Id
objvQxPrjTabENT.TabTypeName = objvQxPrjTabENS.TabTypeName; //表类型名
objvQxPrjTabENT.PrimaryTypeId = objvQxPrjTabENS.PrimaryTypeId; //主键类型ID
objvQxPrjTabENT.PrimaryTypeName = objvQxPrjTabENS.PrimaryTypeName; //主键类型名
objvQxPrjTabENT.KeyFldId = objvQxPrjTabENS.KeyFldId; //关键字段Id
objvQxPrjTabENT.KeyFldName = objvQxPrjTabENS.KeyFldName; //关键字段名
objvQxPrjTabENT.UpdUserId = objvQxPrjTabENS.UpdUserId; //修改用户Id
objvQxPrjTabENT.UpdDate = objvQxPrjTabENS.UpdDate; //修改日期
objvQxPrjTabENT.Memo = objvQxPrjTabENS.Memo; //备注
objvQxPrjTabENT.UpdDate2 = objvQxPrjTabENS.UpdDate2; //UpdDate2
objvQxPrjTabENT.RelaViewId = objvQxPrjTabENS.RelaViewId; //RelaViewId
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxPrjTabEN objvQxPrjTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.TabId, 8, convQxPrjTab.TabId);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.TabName, 100, convQxPrjTab.TabName);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.TabCnName, 200, convQxPrjTab.TabCnName);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.QxPrjId, 4, convQxPrjTab.QxPrjId);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.PrjName, 30, convQxPrjTab.PrjName);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.SQLDSTypeId, 2, convQxPrjTab.SQLDSTypeId);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.SqlDsTypeName, 20, convQxPrjTab.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.TabStateId, 2, convQxPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.TabStateName, 30, convQxPrjTab.TabStateName);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.FuncModuleAgcId, 8, convQxPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.FuncModuleName, 30, convQxPrjTab.FuncModuleName);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.FuncModuleEnName, 30, convQxPrjTab.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.Owner, 50, convQxPrjTab.Owner);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.Keyword, 50, convQxPrjTab.Keyword);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.TabTypeId, 4, convQxPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.TabTypeName, 30, convQxPrjTab.TabTypeName);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.PrimaryTypeId, 2, convQxPrjTab.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.PrimaryTypeName, 30, convQxPrjTab.PrimaryTypeName);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.KeyFldId, 8, convQxPrjTab.KeyFldId);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.KeyFldName, 50, convQxPrjTab.KeyFldName);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.UpdUserId, 20, convQxPrjTab.UpdUserId);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.UpdDate, 20, convQxPrjTab.UpdDate);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.Memo, 1000, convQxPrjTab.Memo);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.UpdDate2, 14, convQxPrjTab.UpdDate2);
clsCheckSql.CheckFieldLen(objvQxPrjTabEN.RelaViewId, 8, convQxPrjTab.RelaViewId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.TabId, convQxPrjTab.TabId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.TabName, convQxPrjTab.TabName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.TabCnName, convQxPrjTab.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.QxPrjId, convQxPrjTab.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.PrjName, convQxPrjTab.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.SQLDSTypeId, convQxPrjTab.SQLDSTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.SqlDsTypeName, convQxPrjTab.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.TabStateId, convQxPrjTab.TabStateId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.TabStateName, convQxPrjTab.TabStateName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.FuncModuleAgcId, convQxPrjTab.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.FuncModuleName, convQxPrjTab.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.FuncModuleEnName, convQxPrjTab.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.Owner, convQxPrjTab.Owner);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.Keyword, convQxPrjTab.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.TabTypeId, convQxPrjTab.TabTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.TabTypeName, convQxPrjTab.TabTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.PrimaryTypeId, convQxPrjTab.PrimaryTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.PrimaryTypeName, convQxPrjTab.PrimaryTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.KeyFldId, convQxPrjTab.KeyFldId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.KeyFldName, convQxPrjTab.KeyFldName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.UpdUserId, convQxPrjTab.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.UpdDate, convQxPrjTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.Memo, convQxPrjTab.Memo);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.UpdDate2, convQxPrjTab.UpdDate2);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjTabEN.RelaViewId, convQxPrjTab.RelaViewId);
//检查外键字段长度
 objvQxPrjTabEN._IsCheckProperty = true;
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
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjTabEN._CurrTabName);
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
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjTabEN._CurrTabName, strCondition);
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
 objSQL = clsvQxPrjTabDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}