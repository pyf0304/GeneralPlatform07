
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjTabDA
 表名:QxPrjTab(00140096)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:44:44
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
 /// 工程表(QxPrjTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxPrjTabDA : clsCommBase4DA
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
 return clsQxPrjTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxPrjTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxPrjTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxPrjTabEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:QxPrjTab中,检查关键字,长度不正确!(clsQxPrjTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxPrjTab中,关键字不能为空 或 null!(clsQxPrjTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxPrjTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception("(errid:Data000004)在表:QxPrjTab中,检查关键字,长度不正确!(简化版)(clsQxPrjTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxPrjTab中,关键字不能为空 或 null!(clsQxPrjTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxPrjTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
 strSQL = "Select * from QxPrjTab where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxPrjTab");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxPrjTab_SelectByCond",values, "QxPrjTab");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjTab where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjTab");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From QxPrjTab Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjTab");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From QxPrjTab Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjTab");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From QxPrjTab Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjTab");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxPrjTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTable_QxPrjTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjTab.* from QxPrjTab Left Join {1} on {2} where {3} and QxPrjTab.TabId not in (Select top {5} QxPrjTab.TabId from QxPrjTab Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjTab where {1} and TabId not in (Select top {2} TabId from QxPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjTab where {1} and TabId not in (Select top {3} TabId from QxPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjTab.* from QxPrjTab Left Join {1} on {2} where {3} and QxPrjTab.TabId not in (Select top {5} QxPrjTab.TabId from QxPrjTab Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjTab where {1} and TabId not in (Select top {2} TabId from QxPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjTab where {1} and TabId not in (Select top {3} TabId from QxPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjTab.* from QxPrjTab Left Join {1} on {2} where {3} and QxPrjTab.TabId not in (Select top {5} QxPrjTab.TabId from QxPrjTab Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjTab where {1} and TabId not in (Select top {2} TabId from QxPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjTab where {1} and TabId not in (Select top {3} TabId from QxPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From QxPrjTab Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From QxPrjTab Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From QxPrjTab Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjTab a where {0} And a.TabId not in (Select Top {2} TabId From QxPrjTab Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjTabDA: GetQxPrjTabByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjTab_SelectByCond",values);
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
public List<clsQxPrjTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxPrjTabDA:GetObjLst)", objException.Message));
}
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = TransNullToBool(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjTabDA: GetObjLst)", objException.Message));
}
objQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjTabEN);
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
public List<clsQxPrjTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxPrjTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = TransNullToBool(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjTabDA: GetObjLst)", objException.Message));
}
objQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxPrjTabEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxPrjTabDA:GetObjLstBySP)", objException.Message));
}
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjTab_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = TransNullToBool(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjTabDA: GetObjLstBySP)", objException.Message));
}
objQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjTab(ref clsQxPrjTabEN objQxPrjTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where TabId = " + "'"+ objQxPrjTabEN.TabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxPrjTabEN.TabId = objDT.Rows[0][conQxPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjTabEN.TabName = objDT.Rows[0][conQxPrjTab.TabName].ToString().Trim(); //TabName(字段类型:varchar,字段长度:100,是否可空:False)
 objQxPrjTabEN.TabCnName = objDT.Rows[0][conQxPrjTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objQxPrjTabEN.QxPrjId = objDT.Rows[0][conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjTabEN.SQLDSTypeId = objDT.Rows[0][conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型(字段类型:char,字段长度:2,是否可空:False)
 objQxPrjTabEN.TabStateId = objDT.Rows[0][conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objQxPrjTabEN.IsParaTab = TransNullToBool(objDT.Rows[0][conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjTabEN.FuncModuleAgcId = objDT.Rows[0][conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjTabEN.Owner = objDT.Rows[0][conQxPrjTab.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjTabEN.Keyword = objDT.Rows[0][conQxPrjTab.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjTabEN.TabTypeId = objDT.Rows[0][conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjTabEN.RelaViewId = objDT.Rows[0][conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjTabEN.PrimaryTypeId = objDT.Rows[0][conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objQxPrjTabEN.PrimaryTypeName = objDT.Rows[0][conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxPrjTabEN.KeyFldId = objDT.Rows[0][conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id(字段类型:varchar,字段长度:8,是否可空:True)
 objQxPrjTabEN.KeyFldName = objDT.Rows[0][conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjTabEN.UpdUserId = objDT.Rows[0][conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjTabEN.UpdDate = objDT.Rows[0][conQxPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjTabEN.Memo = objDT.Rows[0][conQxPrjTab.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxPrjTabEN.SynchDate = objDT.Rows[0][conQxPrjTab.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:14,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxPrjTabDA: GetQxPrjTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxPrjTabEN GetObjByTabId(string strTabId)
{
CheckPrimaryKey(strTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where TabId = " + "'"+ strTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
 objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName(字段类型:varchar,字段长度:100,是否可空:False)
 objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型(字段类型:char,字段长度:2,是否可空:False)
 objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id(字段类型:varchar,字段长度:8,是否可空:True)
 objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:14,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxPrjTabDA: GetObjByTabId)", objException.Message));
}
return objQxPrjTabEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxPrjTab_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjTabOneBySP(clsQxPrjTabEN objQxPrjTabEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxPrjTabEN.TabId
};
 objDT = objSQL.ExecSpReturnDT("QxPrjTab_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxPrjTabEN.TabId = objDT.Rows[0][conQxPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjTabEN.TabName = objDT.Rows[0][conQxPrjTab.TabName].ToString().Trim(); //TabName(字段类型:varchar,字段长度:100,是否可空:False)
 objQxPrjTabEN.TabCnName = objDT.Rows[0][conQxPrjTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objQxPrjTabEN.QxPrjId = objDT.Rows[0][conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjTabEN.SQLDSTypeId = objDT.Rows[0][conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型(字段类型:char,字段长度:2,是否可空:False)
 objQxPrjTabEN.TabStateId = objDT.Rows[0][conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objQxPrjTabEN.IsParaTab = TransNullToBool(objDT.Rows[0][conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjTabEN.FuncModuleAgcId = objDT.Rows[0][conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjTabEN.Owner = objDT.Rows[0][conQxPrjTab.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjTabEN.Keyword = objDT.Rows[0][conQxPrjTab.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjTabEN.TabTypeId = objDT.Rows[0][conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjTabEN.RelaViewId = objDT.Rows[0][conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjTabEN.PrimaryTypeId = objDT.Rows[0][conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objQxPrjTabEN.PrimaryTypeName = objDT.Rows[0][conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxPrjTabEN.KeyFldId = objDT.Rows[0][conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id(字段类型:varchar,字段长度:8,是否可空:True)
 objQxPrjTabEN.KeyFldName = objDT.Rows[0][conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjTabEN.UpdUserId = objDT.Rows[0][conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjTabEN.UpdDate = objDT.Rows[0][conQxPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjTabEN.Memo = objDT.Rows[0][conQxPrjTab.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxPrjTabEN.SynchDate = objDT.Rows[0][conQxPrjTab.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:14,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxPrjTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN()
{
TabId = objRow[conQxPrjTab.TabId].ToString().Trim(), //表ID
TabName = objRow[conQxPrjTab.TabName].ToString().Trim(), //TabName
TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(), //表中文名
QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(), //项目Id
SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(), //数据源类型
TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(), //表状态ID
IsParaTab = TransNullToBool(objRow[conQxPrjTab.IsParaTab].ToString().Trim()), //是否参数表
FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(), //功能模块Id
Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(), //拥有者
Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(), //关键字
TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(), //表类型Id
RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(), //RelaViewId
PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(), //主键类型ID
PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(), //主键类型名
KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(), //关键字段Id
KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(), //关键字段名
UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(), //备注
SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim() //同步日期
};
objQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxPrjTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjTabEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxPrjTabDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjTab_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN()
{
TabId = objRow[conQxPrjTab.TabId].ToString().Trim(), //表ID
TabName = objRow[conQxPrjTab.TabName].ToString().Trim(), //TabName
TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(), //表中文名
QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(), //项目Id
SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(), //数据源类型
TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(), //表状态ID
IsParaTab = TransNullToBool(objRow[conQxPrjTab.IsParaTab].ToString().Trim()), //是否参数表
FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(), //功能模块Id
Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(), //拥有者
Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(), //关键字
TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(), //表类型Id
RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(), //RelaViewId
PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(), //主键类型ID
PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(), //主键类型名
KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(), //关键字段Id
KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(), //关键字段名
UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(), //备注
SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim() //同步日期
};
objQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjTabEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxPrjTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = TransNullToBool(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxPrjTabDA: GetObjByDataRowQxPrjTab)", objException.Message));
}
objQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxPrjTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = TransNullToBool(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxPrjTabDA: GetObjByDataRow)", objException.Message));
}
objQxPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjTabEN;
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
objSQL = clsQxPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjTabEN._CurrTabName, conQxPrjTab.TabId, 8, "");
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
objSQL = clsQxPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjTabEN._CurrTabName, conQxPrjTab.TabId, 8, strPrefix);
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
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabId from QxPrjTab where " + strCondition;
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
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabId from QxPrjTab where " + strCondition;
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
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjTab", "TabId = " + "'"+ strTabId+"'"))
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
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strTabId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxPrjTab_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxPrjTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjTab", strCondition))
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
objSQL = clsQxPrjTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxPrjTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxPrjTabEN objQxPrjTabEN)
 {
 objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjTab");
objRow = objDS.Tables["QxPrjTab"].NewRow();
objRow[conQxPrjTab.TabId] = objQxPrjTabEN.TabId; //表ID
objRow[conQxPrjTab.TabName] = objQxPrjTabEN.TabName; //TabName
 if (objQxPrjTabEN.TabCnName !=  "")
 {
objRow[conQxPrjTab.TabCnName] = objQxPrjTabEN.TabCnName; //表中文名
 }
objRow[conQxPrjTab.QxPrjId] = objQxPrjTabEN.QxPrjId; //项目Id
 if (objQxPrjTabEN.SQLDSTypeId !=  "")
 {
objRow[conQxPrjTab.SQLDSTypeId] = objQxPrjTabEN.SQLDSTypeId; //数据源类型
 }
objRow[conQxPrjTab.TabStateId] = objQxPrjTabEN.TabStateId; //表状态ID
objRow[conQxPrjTab.IsParaTab] = objQxPrjTabEN.IsParaTab; //是否参数表
 if (objQxPrjTabEN.FuncModuleAgcId !=  "")
 {
objRow[conQxPrjTab.FuncModuleAgcId] = objQxPrjTabEN.FuncModuleAgcId; //功能模块Id
 }
 if (objQxPrjTabEN.Owner !=  "")
 {
objRow[conQxPrjTab.Owner] = objQxPrjTabEN.Owner; //拥有者
 }
 if (objQxPrjTabEN.Keyword !=  "")
 {
objRow[conQxPrjTab.Keyword] = objQxPrjTabEN.Keyword; //关键字
 }
objRow[conQxPrjTab.TabTypeId] = objQxPrjTabEN.TabTypeId; //表类型Id
 if (objQxPrjTabEN.RelaViewId !=  "")
 {
objRow[conQxPrjTab.RelaViewId] = objQxPrjTabEN.RelaViewId; //RelaViewId
 }
 if (objQxPrjTabEN.PrimaryTypeId !=  "")
 {
objRow[conQxPrjTab.PrimaryTypeId] = objQxPrjTabEN.PrimaryTypeId; //主键类型ID
 }
 if (objQxPrjTabEN.PrimaryTypeName !=  "")
 {
objRow[conQxPrjTab.PrimaryTypeName] = objQxPrjTabEN.PrimaryTypeName; //主键类型名
 }
 if (objQxPrjTabEN.KeyFldId !=  "")
 {
objRow[conQxPrjTab.KeyFldId] = objQxPrjTabEN.KeyFldId; //关键字段Id
 }
 if (objQxPrjTabEN.KeyFldName !=  "")
 {
objRow[conQxPrjTab.KeyFldName] = objQxPrjTabEN.KeyFldName; //关键字段名
 }
 if (objQxPrjTabEN.UpdUserId !=  "")
 {
objRow[conQxPrjTab.UpdUserId] = objQxPrjTabEN.UpdUserId; //修改用户Id
 }
 if (objQxPrjTabEN.UpdDate !=  "")
 {
objRow[conQxPrjTab.UpdDate] = objQxPrjTabEN.UpdDate; //修改日期
 }
 if (objQxPrjTabEN.Memo !=  "")
 {
objRow[conQxPrjTab.Memo] = objQxPrjTabEN.Memo; //备注
 }
 if (objQxPrjTabEN.SynchDate !=  "")
 {
objRow[conQxPrjTab.SynchDate] = objQxPrjTabEN.SynchDate; //同步日期
 }
objDS.Tables[clsQxPrjTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxPrjTabEN._CurrTabName);
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
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjTabEN objQxPrjTabEN)
{
 objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabId);
 var strTabId = objQxPrjTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objQxPrjTabEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabName);
 var strTabName = objQxPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objQxPrjTabEN.TabCnName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabCnName);
 var strTabCnName = objQxPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCnName + "'");
 }
 
 if (objQxPrjTabEN.QxPrjId  ==  "")
 {
 objQxPrjTabEN.QxPrjId = null;
 }
 if (objQxPrjTabEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.QxPrjId);
 var strQxPrjId = objQxPrjTabEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjTabEN.SQLDSTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.SQLDSTypeId);
 var strSQLDSTypeId = objQxPrjTabEN.SQLDSTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSQLDSTypeId + "'");
 }
 
 if (objQxPrjTabEN.TabStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabStateId);
 var strTabStateId = objQxPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabStateId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjTab.IsParaTab);
 arrValueListForInsert.Add("'" + (objQxPrjTabEN.IsParaTab  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjTabEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.FuncModuleAgcId);
 var strFuncModuleAgcId = objQxPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objQxPrjTabEN.Owner !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.Owner);
 var strOwner = objQxPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwner + "'");
 }
 
 if (objQxPrjTabEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.Keyword);
 var strKeyword = objQxPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objQxPrjTabEN.TabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabTypeId);
 var strTabTypeId = objQxPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabTypeId + "'");
 }
 
 if (objQxPrjTabEN.RelaViewId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.RelaViewId);
 var strRelaViewId = objQxPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaViewId + "'");
 }
 
 if (objQxPrjTabEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.PrimaryTypeId);
 var strPrimaryTypeId = objQxPrjTabEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objQxPrjTabEN.PrimaryTypeName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.PrimaryTypeName);
 var strPrimaryTypeName = objQxPrjTabEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeName + "'");
 }
 
 if (objQxPrjTabEN.KeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.KeyFldId);
 var strKeyFldId = objQxPrjTabEN.KeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyFldId + "'");
 }
 
 if (objQxPrjTabEN.KeyFldName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.KeyFldName);
 var strKeyFldName = objQxPrjTabEN.KeyFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyFldName + "'");
 }
 
 if (objQxPrjTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.UpdUserId);
 var strUpdUserId = objQxPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.UpdDate);
 var strUpdDate = objQxPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.Memo);
 var strMemo = objQxPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxPrjTabEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.SynchDate);
 var strSynchDate = objQxPrjTabEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxPrjTabEN objQxPrjTabEN)
{
 objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabId);
 var strTabId = objQxPrjTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objQxPrjTabEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabName);
 var strTabName = objQxPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objQxPrjTabEN.TabCnName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabCnName);
 var strTabCnName = objQxPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCnName + "'");
 }
 
 if (objQxPrjTabEN.QxPrjId  ==  "")
 {
 objQxPrjTabEN.QxPrjId = null;
 }
 if (objQxPrjTabEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.QxPrjId);
 var strQxPrjId = objQxPrjTabEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjTabEN.SQLDSTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.SQLDSTypeId);
 var strSQLDSTypeId = objQxPrjTabEN.SQLDSTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSQLDSTypeId + "'");
 }
 
 if (objQxPrjTabEN.TabStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabStateId);
 var strTabStateId = objQxPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabStateId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjTab.IsParaTab);
 arrValueListForInsert.Add("'" + (objQxPrjTabEN.IsParaTab  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjTabEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.FuncModuleAgcId);
 var strFuncModuleAgcId = objQxPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objQxPrjTabEN.Owner !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.Owner);
 var strOwner = objQxPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwner + "'");
 }
 
 if (objQxPrjTabEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.Keyword);
 var strKeyword = objQxPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objQxPrjTabEN.TabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabTypeId);
 var strTabTypeId = objQxPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabTypeId + "'");
 }
 
 if (objQxPrjTabEN.RelaViewId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.RelaViewId);
 var strRelaViewId = objQxPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaViewId + "'");
 }
 
 if (objQxPrjTabEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.PrimaryTypeId);
 var strPrimaryTypeId = objQxPrjTabEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objQxPrjTabEN.PrimaryTypeName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.PrimaryTypeName);
 var strPrimaryTypeName = objQxPrjTabEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeName + "'");
 }
 
 if (objQxPrjTabEN.KeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.KeyFldId);
 var strKeyFldId = objQxPrjTabEN.KeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyFldId + "'");
 }
 
 if (objQxPrjTabEN.KeyFldName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.KeyFldName);
 var strKeyFldName = objQxPrjTabEN.KeyFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyFldName + "'");
 }
 
 if (objQxPrjTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.UpdUserId);
 var strUpdUserId = objQxPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.UpdDate);
 var strUpdDate = objQxPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.Memo);
 var strMemo = objQxPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxPrjTabEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.SynchDate);
 var strSynchDate = objQxPrjTabEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxPrjTabEN.TabId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjTabEN objQxPrjTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabId);
 var strTabId = objQxPrjTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objQxPrjTabEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabName);
 var strTabName = objQxPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objQxPrjTabEN.TabCnName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabCnName);
 var strTabCnName = objQxPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCnName + "'");
 }
 
 if (objQxPrjTabEN.QxPrjId  ==  "")
 {
 objQxPrjTabEN.QxPrjId = null;
 }
 if (objQxPrjTabEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.QxPrjId);
 var strQxPrjId = objQxPrjTabEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjTabEN.SQLDSTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.SQLDSTypeId);
 var strSQLDSTypeId = objQxPrjTabEN.SQLDSTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSQLDSTypeId + "'");
 }
 
 if (objQxPrjTabEN.TabStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabStateId);
 var strTabStateId = objQxPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabStateId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjTab.IsParaTab);
 arrValueListForInsert.Add("'" + (objQxPrjTabEN.IsParaTab  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjTabEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.FuncModuleAgcId);
 var strFuncModuleAgcId = objQxPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objQxPrjTabEN.Owner !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.Owner);
 var strOwner = objQxPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwner + "'");
 }
 
 if (objQxPrjTabEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.Keyword);
 var strKeyword = objQxPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objQxPrjTabEN.TabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.TabTypeId);
 var strTabTypeId = objQxPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabTypeId + "'");
 }
 
 if (objQxPrjTabEN.RelaViewId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.RelaViewId);
 var strRelaViewId = objQxPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaViewId + "'");
 }
 
 if (objQxPrjTabEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.PrimaryTypeId);
 var strPrimaryTypeId = objQxPrjTabEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objQxPrjTabEN.PrimaryTypeName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.PrimaryTypeName);
 var strPrimaryTypeName = objQxPrjTabEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeName + "'");
 }
 
 if (objQxPrjTabEN.KeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.KeyFldId);
 var strKeyFldId = objQxPrjTabEN.KeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyFldId + "'");
 }
 
 if (objQxPrjTabEN.KeyFldName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.KeyFldName);
 var strKeyFldName = objQxPrjTabEN.KeyFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyFldName + "'");
 }
 
 if (objQxPrjTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.UpdUserId);
 var strUpdUserId = objQxPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.UpdDate);
 var strUpdDate = objQxPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.Memo);
 var strMemo = objQxPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxPrjTabEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjTab.SynchDate);
 var strSynchDate = objQxPrjTabEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxPrjTabBySP(clsQxPrjTabEN objQxPrjTabEN)
{
//通过存储过程来
//直接使用
 objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjTabEN.TabId,
 objQxPrjTabEN.TabName,
 objQxPrjTabEN.TabCnName,
 objQxPrjTabEN.QxPrjId,
 objQxPrjTabEN.SQLDSTypeId,
 objQxPrjTabEN.TabStateId,
 objQxPrjTabEN.IsParaTab,
 objQxPrjTabEN.FuncModuleAgcId,
 objQxPrjTabEN.Owner,
 objQxPrjTabEN.Keyword,
 objQxPrjTabEN.TabTypeId,
 objQxPrjTabEN.RelaViewId,
 objQxPrjTabEN.PrimaryTypeId,
 objQxPrjTabEN.PrimaryTypeName,
 objQxPrjTabEN.KeyFldId,
 objQxPrjTabEN.KeyFldName,
 objQxPrjTabEN.UpdUserId,
 objQxPrjTabEN.UpdDate,
 objQxPrjTabEN.Memo,
objQxPrjTabEN.SynchDate
};
 objSQL.ExecSP("QxPrjTab_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxPrjTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where TabId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTabId = oRow[conQxPrjTab.TabId].ToString().Trim();
if (IsExist(strTabId))
{
 string strResult = "关键字变量值为:" + string.Format("TabId = {0}", strTabId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxPrjTabEN._CurrTabName ].NewRow();
objRow[conQxPrjTab.TabId] = oRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objRow[conQxPrjTab.TabName] = oRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objRow[conQxPrjTab.TabCnName] = oRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objRow[conQxPrjTab.QxPrjId] = oRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxPrjTab.SQLDSTypeId] = oRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objRow[conQxPrjTab.TabStateId] = oRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objRow[conQxPrjTab.IsParaTab] = oRow[conQxPrjTab.IsParaTab].ToString().Trim(); //是否参数表
objRow[conQxPrjTab.FuncModuleAgcId] = oRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objRow[conQxPrjTab.Owner] = oRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objRow[conQxPrjTab.Keyword] = oRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objRow[conQxPrjTab.TabTypeId] = oRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objRow[conQxPrjTab.RelaViewId] = oRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objRow[conQxPrjTab.PrimaryTypeId] = oRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objRow[conQxPrjTab.PrimaryTypeName] = oRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objRow[conQxPrjTab.KeyFldId] = oRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objRow[conQxPrjTab.KeyFldName] = oRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objRow[conQxPrjTab.UpdUserId] = oRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conQxPrjTab.UpdDate] = oRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objRow[conQxPrjTab.Memo] = oRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objRow[conQxPrjTab.SynchDate] = oRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
 objDS.Tables[clsQxPrjTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxPrjTabEN._CurrTabName);
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
 /// <param name = "objQxPrjTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxPrjTabEN objQxPrjTabEN)
{
 objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjTab where TabId = " + "'"+ objQxPrjTabEN.TabId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxPrjTabEN._CurrTabName);
if (objDS.Tables[clsQxPrjTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TabId = " + "'"+ objQxPrjTabEN.TabId+"'");
return false;
}
objRow = objDS.Tables[clsQxPrjTabEN._CurrTabName].Rows[0];
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabId))
 {
objRow[conQxPrjTab.TabId] = objQxPrjTabEN.TabId; //表ID
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabName))
 {
objRow[conQxPrjTab.TabName] = objQxPrjTabEN.TabName; //TabName
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabCnName))
 {
objRow[conQxPrjTab.TabCnName] = objQxPrjTabEN.TabCnName; //表中文名
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.QxPrjId))
 {
objRow[conQxPrjTab.QxPrjId] = objQxPrjTabEN.QxPrjId; //项目Id
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.SQLDSTypeId))
 {
objRow[conQxPrjTab.SQLDSTypeId] = objQxPrjTabEN.SQLDSTypeId; //数据源类型
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabStateId))
 {
objRow[conQxPrjTab.TabStateId] = objQxPrjTabEN.TabStateId; //表状态ID
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.IsParaTab))
 {
objRow[conQxPrjTab.IsParaTab] = objQxPrjTabEN.IsParaTab; //是否参数表
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.FuncModuleAgcId))
 {
objRow[conQxPrjTab.FuncModuleAgcId] = objQxPrjTabEN.FuncModuleAgcId; //功能模块Id
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Owner))
 {
objRow[conQxPrjTab.Owner] = objQxPrjTabEN.Owner; //拥有者
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Keyword))
 {
objRow[conQxPrjTab.Keyword] = objQxPrjTabEN.Keyword; //关键字
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabTypeId))
 {
objRow[conQxPrjTab.TabTypeId] = objQxPrjTabEN.TabTypeId; //表类型Id
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.RelaViewId))
 {
objRow[conQxPrjTab.RelaViewId] = objQxPrjTabEN.RelaViewId; //RelaViewId
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.PrimaryTypeId))
 {
objRow[conQxPrjTab.PrimaryTypeId] = objQxPrjTabEN.PrimaryTypeId; //主键类型ID
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.PrimaryTypeName))
 {
objRow[conQxPrjTab.PrimaryTypeName] = objQxPrjTabEN.PrimaryTypeName; //主键类型名
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.KeyFldId))
 {
objRow[conQxPrjTab.KeyFldId] = objQxPrjTabEN.KeyFldId; //关键字段Id
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.KeyFldName))
 {
objRow[conQxPrjTab.KeyFldName] = objQxPrjTabEN.KeyFldName; //关键字段名
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.UpdUserId))
 {
objRow[conQxPrjTab.UpdUserId] = objQxPrjTabEN.UpdUserId; //修改用户Id
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.UpdDate))
 {
objRow[conQxPrjTab.UpdDate] = objQxPrjTabEN.UpdDate; //修改日期
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Memo))
 {
objRow[conQxPrjTab.Memo] = objQxPrjTabEN.Memo; //备注
 }
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.SynchDate))
 {
objRow[conQxPrjTab.SynchDate] = objQxPrjTabEN.SynchDate; //同步日期
 }
try
{
objDA.Update(objDS, clsQxPrjTabEN._CurrTabName);
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
public bool UpdateBySP(clsQxPrjTabEN objQxPrjTabEN)
{
 objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjTabEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjTabEN.TabId,
 objQxPrjTabEN.TabName,
 objQxPrjTabEN.TabCnName,
 objQxPrjTabEN.QxPrjId,
 objQxPrjTabEN.SQLDSTypeId,
 objQxPrjTabEN.TabStateId,
 objQxPrjTabEN.IsParaTab,
 objQxPrjTabEN.FuncModuleAgcId,
 objQxPrjTabEN.Owner,
 objQxPrjTabEN.Keyword,
 objQxPrjTabEN.TabTypeId,
 objQxPrjTabEN.RelaViewId,
 objQxPrjTabEN.PrimaryTypeId,
 objQxPrjTabEN.PrimaryTypeName,
 objQxPrjTabEN.KeyFldId,
 objQxPrjTabEN.KeyFldName,
 objQxPrjTabEN.UpdUserId,
 objQxPrjTabEN.UpdDate,
 objQxPrjTabEN.Memo,
 objQxPrjTabEN.SynchDate
};
 objSQL.ExecSP("QxPrjTab_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjTabEN objQxPrjTabEN)
{
 objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxPrjTab Set ");
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabName))
 {
 if (objQxPrjTabEN.TabName !=  null)
 {
 var strTabName = objQxPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conQxPrjTab.TabName); //TabName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.TabName); //TabName
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabCnName))
 {
 if (objQxPrjTabEN.TabCnName !=  null)
 {
 var strTabCnName = objQxPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabCnName, conQxPrjTab.TabCnName); //表中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.TabCnName); //表中文名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.QxPrjId))
 {
 if (objQxPrjTabEN.QxPrjId  ==  "")
 {
 objQxPrjTabEN.QxPrjId = null;
 }
 if (objQxPrjTabEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjTabEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjTab.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.SQLDSTypeId))
 {
 if (objQxPrjTabEN.SQLDSTypeId !=  null)
 {
 var strSQLDSTypeId = objQxPrjTabEN.SQLDSTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSQLDSTypeId, conQxPrjTab.SQLDSTypeId); //数据源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.SQLDSTypeId); //数据源类型
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabStateId))
 {
 if (objQxPrjTabEN.TabStateId !=  null)
 {
 var strTabStateId = objQxPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabStateId, conQxPrjTab.TabStateId); //表状态ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.TabStateId); //表状态ID
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.IsParaTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjTabEN.IsParaTab == true?"1":"0", conQxPrjTab.IsParaTab); //是否参数表
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.FuncModuleAgcId))
 {
 if (objQxPrjTabEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objQxPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conQxPrjTab.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Owner))
 {
 if (objQxPrjTabEN.Owner !=  null)
 {
 var strOwner = objQxPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwner, conQxPrjTab.Owner); //拥有者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.Owner); //拥有者
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Keyword))
 {
 if (objQxPrjTabEN.Keyword !=  null)
 {
 var strKeyword = objQxPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conQxPrjTab.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.Keyword); //关键字
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabTypeId))
 {
 if (objQxPrjTabEN.TabTypeId !=  null)
 {
 var strTabTypeId = objQxPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabTypeId, conQxPrjTab.TabTypeId); //表类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.TabTypeId); //表类型Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.RelaViewId))
 {
 if (objQxPrjTabEN.RelaViewId !=  null)
 {
 var strRelaViewId = objQxPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaViewId, conQxPrjTab.RelaViewId); //RelaViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.RelaViewId); //RelaViewId
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.PrimaryTypeId))
 {
 if (objQxPrjTabEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objQxPrjTabEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeId, conQxPrjTab.PrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.PrimaryTypeId); //主键类型ID
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.PrimaryTypeName))
 {
 if (objQxPrjTabEN.PrimaryTypeName !=  null)
 {
 var strPrimaryTypeName = objQxPrjTabEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeName, conQxPrjTab.PrimaryTypeName); //主键类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.PrimaryTypeName); //主键类型名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.KeyFldId))
 {
 if (objQxPrjTabEN.KeyFldId !=  null)
 {
 var strKeyFldId = objQxPrjTabEN.KeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyFldId, conQxPrjTab.KeyFldId); //关键字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.KeyFldId); //关键字段Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.KeyFldName))
 {
 if (objQxPrjTabEN.KeyFldName !=  null)
 {
 var strKeyFldName = objQxPrjTabEN.KeyFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyFldName, conQxPrjTab.KeyFldName); //关键字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.KeyFldName); //关键字段名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.UpdUserId))
 {
 if (objQxPrjTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjTab.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.UpdDate))
 {
 if (objQxPrjTabEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Memo))
 {
 if (objQxPrjTabEN.Memo !=  null)
 {
 var strMemo = objQxPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjTab.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.Memo); //备注
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.SynchDate))
 {
 if (objQxPrjTabEN.SynchDate !=  null)
 {
 var strSynchDate = objQxPrjTabEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchDate, conQxPrjTab.SynchDate); //同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.SynchDate); //同步日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TabId = '{0}'", objQxPrjTabEN.TabId); 
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
 /// <param name = "objQxPrjTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxPrjTabEN objQxPrjTabEN, string strCondition)
{
 objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjTab Set ");
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabName))
 {
 if (objQxPrjTabEN.TabName !=  null)
 {
 var strTabName = objQxPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //TabName
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //TabName
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabCnName))
 {
 if (objQxPrjTabEN.TabCnName !=  null)
 {
 var strTabCnName = objQxPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabCnName = '{0}',", strTabCnName); //表中文名
 }
 else
 {
 sbSQL.Append(" TabCnName = null,"); //表中文名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.QxPrjId))
 {
 if (objQxPrjTabEN.QxPrjId  ==  "")
 {
 objQxPrjTabEN.QxPrjId = null;
 }
 if (objQxPrjTabEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjTabEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.SQLDSTypeId))
 {
 if (objQxPrjTabEN.SQLDSTypeId !=  null)
 {
 var strSQLDSTypeId = objQxPrjTabEN.SQLDSTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SQLDSTypeId = '{0}',", strSQLDSTypeId); //数据源类型
 }
 else
 {
 sbSQL.Append(" SQLDSTypeId = null,"); //数据源类型
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabStateId))
 {
 if (objQxPrjTabEN.TabStateId !=  null)
 {
 var strTabStateId = objQxPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabStateId = '{0}',", strTabStateId); //表状态ID
 }
 else
 {
 sbSQL.Append(" TabStateId = null,"); //表状态ID
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.IsParaTab))
 {
 sbSQL.AppendFormat(" IsParaTab = '{0}',", objQxPrjTabEN.IsParaTab == true?"1":"0"); //是否参数表
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.FuncModuleAgcId))
 {
 if (objQxPrjTabEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objQxPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Owner))
 {
 if (objQxPrjTabEN.Owner !=  null)
 {
 var strOwner = objQxPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Owner = '{0}',", strOwner); //拥有者
 }
 else
 {
 sbSQL.Append(" Owner = null,"); //拥有者
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Keyword))
 {
 if (objQxPrjTabEN.Keyword !=  null)
 {
 var strKeyword = objQxPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabTypeId))
 {
 if (objQxPrjTabEN.TabTypeId !=  null)
 {
 var strTabTypeId = objQxPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabTypeId = '{0}',", strTabTypeId); //表类型Id
 }
 else
 {
 sbSQL.Append(" TabTypeId = null,"); //表类型Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.RelaViewId))
 {
 if (objQxPrjTabEN.RelaViewId !=  null)
 {
 var strRelaViewId = objQxPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaViewId = '{0}',", strRelaViewId); //RelaViewId
 }
 else
 {
 sbSQL.Append(" RelaViewId = null,"); //RelaViewId
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.PrimaryTypeId))
 {
 if (objQxPrjTabEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objQxPrjTabEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeId = '{0}',", strPrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.Append(" PrimaryTypeId = null,"); //主键类型ID
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.PrimaryTypeName))
 {
 if (objQxPrjTabEN.PrimaryTypeName !=  null)
 {
 var strPrimaryTypeName = objQxPrjTabEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeName = '{0}',", strPrimaryTypeName); //主键类型名
 }
 else
 {
 sbSQL.Append(" PrimaryTypeName = null,"); //主键类型名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.KeyFldId))
 {
 if (objQxPrjTabEN.KeyFldId !=  null)
 {
 var strKeyFldId = objQxPrjTabEN.KeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyFldId = '{0}',", strKeyFldId); //关键字段Id
 }
 else
 {
 sbSQL.Append(" KeyFldId = null,"); //关键字段Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.KeyFldName))
 {
 if (objQxPrjTabEN.KeyFldName !=  null)
 {
 var strKeyFldName = objQxPrjTabEN.KeyFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyFldName = '{0}',", strKeyFldName); //关键字段名
 }
 else
 {
 sbSQL.Append(" KeyFldName = null,"); //关键字段名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.UpdUserId))
 {
 if (objQxPrjTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.UpdDate))
 {
 if (objQxPrjTabEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Memo))
 {
 if (objQxPrjTabEN.Memo !=  null)
 {
 var strMemo = objQxPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.SynchDate))
 {
 if (objQxPrjTabEN.SynchDate !=  null)
 {
 var strSynchDate = objQxPrjTabEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchDate = '{0}',", strSynchDate); //同步日期
 }
 else
 {
 sbSQL.Append(" SynchDate = null,"); //同步日期
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
 /// <param name = "objQxPrjTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxPrjTabEN objQxPrjTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjTab Set ");
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabName))
 {
 if (objQxPrjTabEN.TabName !=  null)
 {
 var strTabName = objQxPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //TabName
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //TabName
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabCnName))
 {
 if (objQxPrjTabEN.TabCnName !=  null)
 {
 var strTabCnName = objQxPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabCnName = '{0}',", strTabCnName); //表中文名
 }
 else
 {
 sbSQL.Append(" TabCnName = null,"); //表中文名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.QxPrjId))
 {
 if (objQxPrjTabEN.QxPrjId  ==  "")
 {
 objQxPrjTabEN.QxPrjId = null;
 }
 if (objQxPrjTabEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjTabEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.SQLDSTypeId))
 {
 if (objQxPrjTabEN.SQLDSTypeId !=  null)
 {
 var strSQLDSTypeId = objQxPrjTabEN.SQLDSTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SQLDSTypeId = '{0}',", strSQLDSTypeId); //数据源类型
 }
 else
 {
 sbSQL.Append(" SQLDSTypeId = null,"); //数据源类型
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabStateId))
 {
 if (objQxPrjTabEN.TabStateId !=  null)
 {
 var strTabStateId = objQxPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabStateId = '{0}',", strTabStateId); //表状态ID
 }
 else
 {
 sbSQL.Append(" TabStateId = null,"); //表状态ID
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.IsParaTab))
 {
 sbSQL.AppendFormat(" IsParaTab = '{0}',", objQxPrjTabEN.IsParaTab == true?"1":"0"); //是否参数表
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.FuncModuleAgcId))
 {
 if (objQxPrjTabEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objQxPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Owner))
 {
 if (objQxPrjTabEN.Owner !=  null)
 {
 var strOwner = objQxPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Owner = '{0}',", strOwner); //拥有者
 }
 else
 {
 sbSQL.Append(" Owner = null,"); //拥有者
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Keyword))
 {
 if (objQxPrjTabEN.Keyword !=  null)
 {
 var strKeyword = objQxPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabTypeId))
 {
 if (objQxPrjTabEN.TabTypeId !=  null)
 {
 var strTabTypeId = objQxPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabTypeId = '{0}',", strTabTypeId); //表类型Id
 }
 else
 {
 sbSQL.Append(" TabTypeId = null,"); //表类型Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.RelaViewId))
 {
 if (objQxPrjTabEN.RelaViewId !=  null)
 {
 var strRelaViewId = objQxPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaViewId = '{0}',", strRelaViewId); //RelaViewId
 }
 else
 {
 sbSQL.Append(" RelaViewId = null,"); //RelaViewId
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.PrimaryTypeId))
 {
 if (objQxPrjTabEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objQxPrjTabEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeId = '{0}',", strPrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.Append(" PrimaryTypeId = null,"); //主键类型ID
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.PrimaryTypeName))
 {
 if (objQxPrjTabEN.PrimaryTypeName !=  null)
 {
 var strPrimaryTypeName = objQxPrjTabEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeName = '{0}',", strPrimaryTypeName); //主键类型名
 }
 else
 {
 sbSQL.Append(" PrimaryTypeName = null,"); //主键类型名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.KeyFldId))
 {
 if (objQxPrjTabEN.KeyFldId !=  null)
 {
 var strKeyFldId = objQxPrjTabEN.KeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyFldId = '{0}',", strKeyFldId); //关键字段Id
 }
 else
 {
 sbSQL.Append(" KeyFldId = null,"); //关键字段Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.KeyFldName))
 {
 if (objQxPrjTabEN.KeyFldName !=  null)
 {
 var strKeyFldName = objQxPrjTabEN.KeyFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyFldName = '{0}',", strKeyFldName); //关键字段名
 }
 else
 {
 sbSQL.Append(" KeyFldName = null,"); //关键字段名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.UpdUserId))
 {
 if (objQxPrjTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.UpdDate))
 {
 if (objQxPrjTabEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Memo))
 {
 if (objQxPrjTabEN.Memo !=  null)
 {
 var strMemo = objQxPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.SynchDate))
 {
 if (objQxPrjTabEN.SynchDate !=  null)
 {
 var strSynchDate = objQxPrjTabEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchDate = '{0}',", strSynchDate); //同步日期
 }
 else
 {
 sbSQL.Append(" SynchDate = null,"); //同步日期
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
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjTabEN objQxPrjTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjTab Set ");
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabName))
 {
 if (objQxPrjTabEN.TabName !=  null)
 {
 var strTabName = objQxPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conQxPrjTab.TabName); //TabName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.TabName); //TabName
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabCnName))
 {
 if (objQxPrjTabEN.TabCnName !=  null)
 {
 var strTabCnName = objQxPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabCnName, conQxPrjTab.TabCnName); //表中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.TabCnName); //表中文名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.QxPrjId))
 {
 if (objQxPrjTabEN.QxPrjId  ==  "")
 {
 objQxPrjTabEN.QxPrjId = null;
 }
 if (objQxPrjTabEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjTabEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjTab.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.SQLDSTypeId))
 {
 if (objQxPrjTabEN.SQLDSTypeId !=  null)
 {
 var strSQLDSTypeId = objQxPrjTabEN.SQLDSTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSQLDSTypeId, conQxPrjTab.SQLDSTypeId); //数据源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.SQLDSTypeId); //数据源类型
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabStateId))
 {
 if (objQxPrjTabEN.TabStateId !=  null)
 {
 var strTabStateId = objQxPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabStateId, conQxPrjTab.TabStateId); //表状态ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.TabStateId); //表状态ID
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.IsParaTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjTabEN.IsParaTab == true?"1":"0", conQxPrjTab.IsParaTab); //是否参数表
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.FuncModuleAgcId))
 {
 if (objQxPrjTabEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objQxPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conQxPrjTab.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Owner))
 {
 if (objQxPrjTabEN.Owner !=  null)
 {
 var strOwner = objQxPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwner, conQxPrjTab.Owner); //拥有者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.Owner); //拥有者
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Keyword))
 {
 if (objQxPrjTabEN.Keyword !=  null)
 {
 var strKeyword = objQxPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conQxPrjTab.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.Keyword); //关键字
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.TabTypeId))
 {
 if (objQxPrjTabEN.TabTypeId !=  null)
 {
 var strTabTypeId = objQxPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabTypeId, conQxPrjTab.TabTypeId); //表类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.TabTypeId); //表类型Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.RelaViewId))
 {
 if (objQxPrjTabEN.RelaViewId !=  null)
 {
 var strRelaViewId = objQxPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaViewId, conQxPrjTab.RelaViewId); //RelaViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.RelaViewId); //RelaViewId
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.PrimaryTypeId))
 {
 if (objQxPrjTabEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objQxPrjTabEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeId, conQxPrjTab.PrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.PrimaryTypeId); //主键类型ID
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.PrimaryTypeName))
 {
 if (objQxPrjTabEN.PrimaryTypeName !=  null)
 {
 var strPrimaryTypeName = objQxPrjTabEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeName, conQxPrjTab.PrimaryTypeName); //主键类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.PrimaryTypeName); //主键类型名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.KeyFldId))
 {
 if (objQxPrjTabEN.KeyFldId !=  null)
 {
 var strKeyFldId = objQxPrjTabEN.KeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyFldId, conQxPrjTab.KeyFldId); //关键字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.KeyFldId); //关键字段Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.KeyFldName))
 {
 if (objQxPrjTabEN.KeyFldName !=  null)
 {
 var strKeyFldName = objQxPrjTabEN.KeyFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyFldName, conQxPrjTab.KeyFldName); //关键字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.KeyFldName); //关键字段名
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.UpdUserId))
 {
 if (objQxPrjTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjTab.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.UpdDate))
 {
 if (objQxPrjTabEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.Memo))
 {
 if (objQxPrjTabEN.Memo !=  null)
 {
 var strMemo = objQxPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjTab.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.Memo); //备注
 }
 }
 
 if (objQxPrjTabEN.IsUpdated(conQxPrjTab.SynchDate))
 {
 if (objQxPrjTabEN.SynchDate !=  null)
 {
 var strSynchDate = objQxPrjTabEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchDate, conQxPrjTab.SynchDate); //同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjTab.SynchDate); //同步日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TabId = '{0}'", objQxPrjTabEN.TabId); 
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTabId) 
{
CheckPrimaryKey(strTabId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTabId,
};
 objSQL.ExecSP("QxPrjTab_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTabId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTabId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
//删除QxPrjTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjTab where TabId = " + "'"+ strTabId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxPrjTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
//删除QxPrjTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjTab where TabId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTabId) 
{
CheckPrimaryKey(strTabId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
//删除QxPrjTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjTab where TabId = " + "'"+ strTabId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxPrjTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxPrjTabDA: DelQxPrjTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjTab where " + strCondition ;
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
public bool DelQxPrjTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxPrjTabDA: DelQxPrjTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjTab where " + strCondition ;
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
 /// <param name = "objQxPrjTabENS">源对象</param>
 /// <param name = "objQxPrjTabENT">目标对象</param>
public void CopyTo(clsQxPrjTabEN objQxPrjTabENS, clsQxPrjTabEN objQxPrjTabENT)
{
objQxPrjTabENT.TabId = objQxPrjTabENS.TabId; //表ID
objQxPrjTabENT.TabName = objQxPrjTabENS.TabName; //TabName
objQxPrjTabENT.TabCnName = objQxPrjTabENS.TabCnName; //表中文名
objQxPrjTabENT.QxPrjId = objQxPrjTabENS.QxPrjId; //项目Id
objQxPrjTabENT.SQLDSTypeId = objQxPrjTabENS.SQLDSTypeId; //数据源类型
objQxPrjTabENT.TabStateId = objQxPrjTabENS.TabStateId; //表状态ID
objQxPrjTabENT.IsParaTab = objQxPrjTabENS.IsParaTab; //是否参数表
objQxPrjTabENT.FuncModuleAgcId = objQxPrjTabENS.FuncModuleAgcId; //功能模块Id
objQxPrjTabENT.Owner = objQxPrjTabENS.Owner; //拥有者
objQxPrjTabENT.Keyword = objQxPrjTabENS.Keyword; //关键字
objQxPrjTabENT.TabTypeId = objQxPrjTabENS.TabTypeId; //表类型Id
objQxPrjTabENT.RelaViewId = objQxPrjTabENS.RelaViewId; //RelaViewId
objQxPrjTabENT.PrimaryTypeId = objQxPrjTabENS.PrimaryTypeId; //主键类型ID
objQxPrjTabENT.PrimaryTypeName = objQxPrjTabENS.PrimaryTypeName; //主键类型名
objQxPrjTabENT.KeyFldId = objQxPrjTabENS.KeyFldId; //关键字段Id
objQxPrjTabENT.KeyFldName = objQxPrjTabENS.KeyFldName; //关键字段名
objQxPrjTabENT.UpdUserId = objQxPrjTabENS.UpdUserId; //修改用户Id
objQxPrjTabENT.UpdDate = objQxPrjTabENS.UpdDate; //修改日期
objQxPrjTabENT.Memo = objQxPrjTabENS.Memo; //备注
objQxPrjTabENT.SynchDate = objQxPrjTabENS.SynchDate; //同步日期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjTabEN objQxPrjTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxPrjTabEN.TabName, conQxPrjTab.TabName);
clsCheckSql.CheckFieldNotNull(objQxPrjTabEN.QxPrjId, conQxPrjTab.QxPrjId);
clsCheckSql.CheckFieldNotNull(objQxPrjTabEN.TabStateId, conQxPrjTab.TabStateId);
clsCheckSql.CheckFieldNotNull(objQxPrjTabEN.TabTypeId, conQxPrjTab.TabTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabId, 8, conQxPrjTab.TabId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabName, 100, conQxPrjTab.TabName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabCnName, 200, conQxPrjTab.TabCnName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.QxPrjId, 4, conQxPrjTab.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.SQLDSTypeId, 2, conQxPrjTab.SQLDSTypeId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabStateId, 2, conQxPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.FuncModuleAgcId, 8, conQxPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.Owner, 50, conQxPrjTab.Owner);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.Keyword, 50, conQxPrjTab.Keyword);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabTypeId, 4, conQxPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.RelaViewId, 8, conQxPrjTab.RelaViewId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.PrimaryTypeId, 2, conQxPrjTab.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.PrimaryTypeName, 30, conQxPrjTab.PrimaryTypeName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.KeyFldId, 8, conQxPrjTab.KeyFldId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.KeyFldName, 50, conQxPrjTab.KeyFldName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.UpdUserId, 20, conQxPrjTab.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.UpdDate, 20, conQxPrjTab.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.Memo, 1000, conQxPrjTab.Memo);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.SynchDate, 14, conQxPrjTab.SynchDate);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxPrjTabEN.QxPrjId, 4, conQxPrjTab.QxPrjId);
 objQxPrjTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxPrjTabEN objQxPrjTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabName, 100, conQxPrjTab.TabName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabCnName, 200, conQxPrjTab.TabCnName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.QxPrjId, 4, conQxPrjTab.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.SQLDSTypeId, 2, conQxPrjTab.SQLDSTypeId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabStateId, 2, conQxPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.FuncModuleAgcId, 8, conQxPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.Owner, 50, conQxPrjTab.Owner);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.Keyword, 50, conQxPrjTab.Keyword);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabTypeId, 4, conQxPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.RelaViewId, 8, conQxPrjTab.RelaViewId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.PrimaryTypeId, 2, conQxPrjTab.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.PrimaryTypeName, 30, conQxPrjTab.PrimaryTypeName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.KeyFldId, 8, conQxPrjTab.KeyFldId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.KeyFldName, 50, conQxPrjTab.KeyFldName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.UpdUserId, 20, conQxPrjTab.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.UpdDate, 20, conQxPrjTab.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.Memo, 1000, conQxPrjTab.Memo);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.SynchDate, 14, conQxPrjTab.SynchDate);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPrjTabEN.QxPrjId, 4, conQxPrjTab.QxPrjId);
 objQxPrjTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxPrjTabEN objQxPrjTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabId, 8, conQxPrjTab.TabId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabName, 100, conQxPrjTab.TabName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabCnName, 200, conQxPrjTab.TabCnName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.QxPrjId, 4, conQxPrjTab.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.SQLDSTypeId, 2, conQxPrjTab.SQLDSTypeId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabStateId, 2, conQxPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.FuncModuleAgcId, 8, conQxPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.Owner, 50, conQxPrjTab.Owner);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.Keyword, 50, conQxPrjTab.Keyword);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.TabTypeId, 4, conQxPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.RelaViewId, 8, conQxPrjTab.RelaViewId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.PrimaryTypeId, 2, conQxPrjTab.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.PrimaryTypeName, 30, conQxPrjTab.PrimaryTypeName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.KeyFldId, 8, conQxPrjTab.KeyFldId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.KeyFldName, 50, conQxPrjTab.KeyFldName);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.UpdUserId, 20, conQxPrjTab.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.UpdDate, 20, conQxPrjTab.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.Memo, 1000, conQxPrjTab.Memo);
clsCheckSql.CheckFieldLen(objQxPrjTabEN.SynchDate, 14, conQxPrjTab.SynchDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.TabId, conQxPrjTab.TabId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.TabName, conQxPrjTab.TabName);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.TabCnName, conQxPrjTab.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.QxPrjId, conQxPrjTab.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.SQLDSTypeId, conQxPrjTab.SQLDSTypeId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.TabStateId, conQxPrjTab.TabStateId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.FuncModuleAgcId, conQxPrjTab.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.Owner, conQxPrjTab.Owner);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.Keyword, conQxPrjTab.Keyword);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.TabTypeId, conQxPrjTab.TabTypeId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.RelaViewId, conQxPrjTab.RelaViewId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.PrimaryTypeId, conQxPrjTab.PrimaryTypeId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.PrimaryTypeName, conQxPrjTab.PrimaryTypeName);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.KeyFldId, conQxPrjTab.KeyFldId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.KeyFldName, conQxPrjTab.KeyFldName);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.UpdUserId, conQxPrjTab.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.UpdDate, conQxPrjTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.Memo, conQxPrjTab.Memo);
clsCheckSql.CheckSqlInjection4Field(objQxPrjTabEN.SynchDate, conQxPrjTab.SynchDate);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPrjTabEN.QxPrjId, 4, conQxPrjTab.QxPrjId);
 objQxPrjTabEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTabId()
{
//获取某学院所有专业信息
string strSQL = "select TabId, TabName from QxPrjTab ";
 clsSpecSQLforSql mySql = clsQxPrjTabDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxPrjTab(工程表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjTabEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxPrjTabEN objQxPrjTabEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objQxPrjTabEN.TabName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjTabEN.QxPrjId);
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
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjTabEN._CurrTabName);
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
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjTabEN._CurrTabName, strCondition);
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
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}