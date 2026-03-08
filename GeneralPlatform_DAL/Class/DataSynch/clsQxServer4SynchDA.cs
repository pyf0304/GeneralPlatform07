
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxServer4SynchDA
 表名:QxServer4Synch(00140091)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:08:49
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:数据同步(DataSynch)
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
 /// 同步服务器(QxServer4Synch)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxServer4SynchDA : clsCommBase4DA
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
 return clsQxServer4SynchEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxServer4SynchEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxServer4SynchEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxServer4SynchEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxServer4SynchEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strServerId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strServerId)
{
strServerId = strServerId.Replace("'", "''");
if (strServerId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:QxServer4Synch中,检查关键字,长度不正确!(clsQxServer4SynchDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strServerId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxServer4Synch中,关键字不能为空 或 null!(clsQxServer4SynchDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strServerId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxServer4SynchDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strServerId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strServerId)
{
strServerId = strServerId.Replace("'", "''");
if (strServerId.Length > 4 + 4)
{
throw new Exception("(errid:Data000004)在表:QxServer4Synch中,检查关键字,长度不正确!(简化版)(clsQxServer4SynchDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strServerId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxServer4Synch中,关键字不能为空 或 null!(clsQxServer4SynchDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strServerId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxServer4SynchDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
 strSQL = "Select * from QxServer4Synch where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxServer4Synch");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxServer4Synch_SelectByCond",values, "QxServer4Synch");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxServer4Synch where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxServer4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxServer4Synch a where {0} And a.ServerId not in (Select Top {2} ServerId From QxServer4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxServer4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxServer4Synch a where {0} And a.ServerId not in (Select Top {2} ServerId From QxServer4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxServer4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxServer4Synch a where {0} And a.ServerId not in (Select Top {2} ServerId From QxServer4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxServer4Synch");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxServer4Synch(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTable_QxServer4Synch)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxServer4Synch where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxServer4Synch where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxServer4Synch where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxServer4Synch where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxServer4Synch.* from QxServer4Synch Left Join {1} on {2} where {3} and QxServer4Synch.ServerId not in (Select top {5} QxServer4Synch.ServerId from QxServer4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxServer4Synch where {1} and ServerId not in (Select top {2} ServerId from QxServer4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxServer4Synch where {1} and ServerId not in (Select top {3} ServerId from QxServer4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxServer4Synch.* from QxServer4Synch Left Join {1} on {2} where {3} and QxServer4Synch.ServerId not in (Select top {5} QxServer4Synch.ServerId from QxServer4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxServer4Synch where {1} and ServerId not in (Select top {2} ServerId from QxServer4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxServer4Synch where {1} and ServerId not in (Select top {3} ServerId from QxServer4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxServer4Synch.* from QxServer4Synch Left Join {1} on {2} where {3} and QxServer4Synch.ServerId not in (Select top {5} QxServer4Synch.ServerId from QxServer4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxServer4Synch where {1} and ServerId not in (Select top {2} ServerId from QxServer4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxServer4Synch where {1} and ServerId not in (Select top {3} ServerId from QxServer4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxServer4Synch a where {0} And a.ServerId not in (Select Top {2} ServerId From QxServer4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxServer4Synch a where {0} And a.ServerId not in (Select Top {2} ServerId From QxServer4Synch Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxServer4Synch a where {0} And a.ServerId not in (Select Top {2} ServerId From QxServer4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxServer4Synch a where {0} And a.ServerId not in (Select Top {2} ServerId From QxServer4Synch Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxServer4SynchDA: GetQxServer4SynchByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxServer4Synch_SelectByCond",values);
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
public List<clsQxServer4SynchEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxServer4SynchDA:GetObjLst)", objException.Message));
}
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = TransNullToBool(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = TransNullToBool(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxServer4SynchDA: GetObjLst)", objException.Message));
}
objQxServer4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxServer4SynchEN);
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
public List<clsQxServer4SynchEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxServer4SynchDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = TransNullToBool(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = TransNullToBool(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxServer4SynchDA: GetObjLst)", objException.Message));
}
objQxServer4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxServer4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxServer4SynchEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxServer4SynchDA:GetObjLstBySP)", objException.Message));
}
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxServer4Synch_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = TransNullToBool(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = TransNullToBool(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxServer4SynchDA: GetObjLstBySP)", objException.Message));
}
objQxServer4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxServer4SynchEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxServer4Synch(ref clsQxServer4SynchEN objQxServer4SynchEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where ServerId = " + "'"+ objQxServer4SynchEN.ServerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxServer4SynchEN.ServerId = objDT.Rows[0][conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id(字段类型:char,字段长度:4,是否可空:True)
 objQxServer4SynchEN.ServerName = objDT.Rows[0][conQxServer4Synch.ServerName].ToString().Trim(); //服务器名(字段类型:varchar,字段长度:50,是否可空:True)
 objQxServer4SynchEN.IpAddress = objDT.Rows[0][conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objQxServer4SynchEN.WebApiAddress = objDT.Rows[0][conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址(字段类型:varchar,字段长度:50,是否可空:True)
 objQxServer4SynchEN.IsSelf = TransNullToBool(objDT.Rows[0][conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器(字段类型:bit,字段长度:1,是否可空:True)
 objQxServer4SynchEN.InUse = TransNullToBool(objDT.Rows[0][conQxServer4Synch.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxServer4SynchEN.UpdDate = objDT.Rows[0][conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxServer4SynchEN.UpdUser = objDT.Rows[0][conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:18,是否可空:True)
 objQxServer4SynchEN.Memo = objDT.Rows[0][conQxServer4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxServer4SynchDA: GetQxServer4Synch)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strServerId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxServer4SynchEN GetObjByServerId(string strServerId)
{
CheckPrimaryKey(strServerId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where ServerId = " + "'"+ strServerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
 objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id(字段类型:char,字段长度:4,是否可空:True)
 objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名(字段类型:varchar,字段长度:50,是否可空:True)
 objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址(字段类型:varchar,字段长度:50,是否可空:True)
 objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器(字段类型:bit,字段长度:1,是否可空:True)
 objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:18,是否可空:True)
 objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxServer4SynchDA: GetObjByServerId)", objException.Message));
}
return objQxServer4SynchEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxServer4Synch_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxServer4SynchOneBySP(clsQxServer4SynchEN objQxServer4SynchEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxServer4SynchEN.ServerId
};
 objDT = objSQL.ExecSpReturnDT("QxServer4Synch_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxServer4SynchEN.ServerId = objDT.Rows[0][conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id(字段类型:char,字段长度:4,是否可空:True)
 objQxServer4SynchEN.ServerName = objDT.Rows[0][conQxServer4Synch.ServerName].ToString().Trim(); //服务器名(字段类型:varchar,字段长度:50,是否可空:True)
 objQxServer4SynchEN.IpAddress = objDT.Rows[0][conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objQxServer4SynchEN.WebApiAddress = objDT.Rows[0][conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址(字段类型:varchar,字段长度:50,是否可空:True)
 objQxServer4SynchEN.IsSelf = TransNullToBool(objDT.Rows[0][conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器(字段类型:bit,字段长度:1,是否可空:True)
 objQxServer4SynchEN.InUse = TransNullToBool(objDT.Rows[0][conQxServer4Synch.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxServer4SynchEN.UpdDate = objDT.Rows[0][conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxServer4SynchEN.UpdUser = objDT.Rows[0][conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:18,是否可空:True)
 objQxServer4SynchEN.Memo = objDT.Rows[0][conQxServer4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxServer4SynchEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN()
{
ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(), //服务器Id
ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(), //服务器名
IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(), //IP地址
WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(), //WApi地址
IsSelf = TransNullToBool(objRow[conQxServer4Synch.IsSelf].ToString().Trim()), //是否当前服务器
InUse = TransNullToBool(objRow[conQxServer4Synch.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim() //备注
};
objQxServer4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxServer4SynchEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxServer4SynchDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxServer4SynchEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxServer4SynchDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxServer4Synch_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN()
{
ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(), //服务器Id
ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(), //服务器名
IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(), //IP地址
WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(), //WApi地址
IsSelf = TransNullToBool(objRow[conQxServer4Synch.IsSelf].ToString().Trim()), //是否当前服务器
InUse = TransNullToBool(objRow[conQxServer4Synch.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim() //备注
};
objQxServer4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxServer4SynchEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxServer4SynchEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = TransNullToBool(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = TransNullToBool(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxServer4SynchDA: GetObjByDataRowQxServer4Synch)", objException.Message));
}
objQxServer4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxServer4SynchEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxServer4SynchEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = TransNullToBool(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = TransNullToBool(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxServer4SynchDA: GetObjByDataRow)", objException.Message));
}
objQxServer4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxServer4SynchEN;
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
objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxServer4SynchEN._CurrTabName, conQxServer4Synch.ServerId, 4, "");
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
objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxServer4SynchEN._CurrTabName, conQxServer4Synch.ServerId, 4, strPrefix);
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
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ServerId from QxServer4Synch where " + strCondition;
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
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ServerId from QxServer4Synch where " + strCondition;
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
 /// <param name = "strServerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strServerId)
{
CheckPrimaryKey(strServerId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxServer4Synch", "ServerId = " + "'"+ strServerId+"'"))
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
 /// <param name = "strServerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strServerId)
{
CheckPrimaryKey(strServerId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strServerId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxServer4Synch_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxServer4SynchDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxServer4Synch", strCondition))
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
objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxServer4Synch");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxServer4SynchEN objQxServer4SynchEN)
 {
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxServer4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxServer4SynchEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxServer4Synch");
objRow = objDS.Tables["QxServer4Synch"].NewRow();
objRow[conQxServer4Synch.ServerId] = objQxServer4SynchEN.ServerId; //服务器Id
 if (objQxServer4SynchEN.ServerName !=  "")
 {
objRow[conQxServer4Synch.ServerName] = objQxServer4SynchEN.ServerName; //服务器名
 }
objRow[conQxServer4Synch.IpAddress] = objQxServer4SynchEN.IpAddress; //IP地址
objRow[conQxServer4Synch.WebApiAddress] = objQxServer4SynchEN.WebApiAddress; //WApi地址
objRow[conQxServer4Synch.IsSelf] = objQxServer4SynchEN.IsSelf; //是否当前服务器
objRow[conQxServer4Synch.InUse] = objQxServer4SynchEN.InUse; //是否在用
 if (objQxServer4SynchEN.UpdDate !=  "")
 {
objRow[conQxServer4Synch.UpdDate] = objQxServer4SynchEN.UpdDate; //修改日期
 }
 if (objQxServer4SynchEN.UpdUser !=  "")
 {
objRow[conQxServer4Synch.UpdUser] = objQxServer4SynchEN.UpdUser; //修改用户
 }
 if (objQxServer4SynchEN.Memo !=  "")
 {
objRow[conQxServer4Synch.Memo] = objQxServer4SynchEN.Memo; //备注
 }
objDS.Tables[clsQxServer4SynchEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxServer4SynchEN._CurrTabName);
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
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxServer4SynchEN objQxServer4SynchEN)
{
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxServer4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxServer4SynchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxServer4SynchEN.ServerId !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.ServerId);
 var strServerId = objQxServer4SynchEN.ServerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strServerId + "'");
 }
 
 if (objQxServer4SynchEN.ServerName !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.ServerName);
 var strServerName = objQxServer4SynchEN.ServerName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strServerName + "'");
 }
 
 if (objQxServer4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.IpAddress);
 var strIpAddress = objQxServer4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objQxServer4SynchEN.WebApiAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.WebApiAddress);
 var strWebApiAddress = objQxServer4SynchEN.WebApiAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiAddress + "'");
 }
 
 arrFieldListForInsert.Add(conQxServer4Synch.IsSelf);
 arrValueListForInsert.Add("'" + (objQxServer4SynchEN.IsSelf  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxServer4Synch.InUse);
 arrValueListForInsert.Add("'" + (objQxServer4SynchEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxServer4SynchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.UpdDate);
 var strUpdDate = objQxServer4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxServer4SynchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.UpdUser);
 var strUpdUser = objQxServer4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxServer4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.Memo);
 var strMemo = objQxServer4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxServer4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxServer4SynchEN objQxServer4SynchEN)
{
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxServer4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxServer4SynchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxServer4SynchEN.ServerId !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.ServerId);
 var strServerId = objQxServer4SynchEN.ServerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strServerId + "'");
 }
 
 if (objQxServer4SynchEN.ServerName !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.ServerName);
 var strServerName = objQxServer4SynchEN.ServerName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strServerName + "'");
 }
 
 if (objQxServer4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.IpAddress);
 var strIpAddress = objQxServer4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objQxServer4SynchEN.WebApiAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.WebApiAddress);
 var strWebApiAddress = objQxServer4SynchEN.WebApiAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiAddress + "'");
 }
 
 arrFieldListForInsert.Add(conQxServer4Synch.IsSelf);
 arrValueListForInsert.Add("'" + (objQxServer4SynchEN.IsSelf  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxServer4Synch.InUse);
 arrValueListForInsert.Add("'" + (objQxServer4SynchEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxServer4SynchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.UpdDate);
 var strUpdDate = objQxServer4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxServer4SynchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.UpdUser);
 var strUpdUser = objQxServer4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxServer4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.Memo);
 var strMemo = objQxServer4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxServer4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxServer4SynchEN.ServerId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxServer4SynchEN objQxServer4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxServer4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxServer4SynchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxServer4SynchEN.ServerId !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.ServerId);
 var strServerId = objQxServer4SynchEN.ServerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strServerId + "'");
 }
 
 if (objQxServer4SynchEN.ServerName !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.ServerName);
 var strServerName = objQxServer4SynchEN.ServerName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strServerName + "'");
 }
 
 if (objQxServer4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.IpAddress);
 var strIpAddress = objQxServer4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objQxServer4SynchEN.WebApiAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.WebApiAddress);
 var strWebApiAddress = objQxServer4SynchEN.WebApiAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiAddress + "'");
 }
 
 arrFieldListForInsert.Add(conQxServer4Synch.IsSelf);
 arrValueListForInsert.Add("'" + (objQxServer4SynchEN.IsSelf  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxServer4Synch.InUse);
 arrValueListForInsert.Add("'" + (objQxServer4SynchEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxServer4SynchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.UpdDate);
 var strUpdDate = objQxServer4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxServer4SynchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.UpdUser);
 var strUpdUser = objQxServer4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxServer4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.Memo);
 var strMemo = objQxServer4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxServer4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objQxServer4SynchEN.ServerId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxServer4SynchEN objQxServer4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxServer4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxServer4SynchEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxServer4SynchEN.ServerId !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.ServerId);
 var strServerId = objQxServer4SynchEN.ServerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strServerId + "'");
 }
 
 if (objQxServer4SynchEN.ServerName !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.ServerName);
 var strServerName = objQxServer4SynchEN.ServerName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strServerName + "'");
 }
 
 if (objQxServer4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.IpAddress);
 var strIpAddress = objQxServer4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objQxServer4SynchEN.WebApiAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.WebApiAddress);
 var strWebApiAddress = objQxServer4SynchEN.WebApiAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiAddress + "'");
 }
 
 arrFieldListForInsert.Add(conQxServer4Synch.IsSelf);
 arrValueListForInsert.Add("'" + (objQxServer4SynchEN.IsSelf  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxServer4Synch.InUse);
 arrValueListForInsert.Add("'" + (objQxServer4SynchEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxServer4SynchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.UpdDate);
 var strUpdDate = objQxServer4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxServer4SynchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.UpdUser);
 var strUpdUser = objQxServer4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxServer4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxServer4Synch.Memo);
 var strMemo = objQxServer4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxServer4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxServer4SynchBySP(clsQxServer4SynchEN objQxServer4SynchEN)
{
//通过存储过程来
//直接使用
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxServer4SynchEN.ServerId,
 objQxServer4SynchEN.ServerName,
 objQxServer4SynchEN.IpAddress,
 objQxServer4SynchEN.WebApiAddress,
 objQxServer4SynchEN.IsSelf,
 objQxServer4SynchEN.InUse,
 objQxServer4SynchEN.UpdDate,
 objQxServer4SynchEN.UpdUser,
objQxServer4SynchEN.Memo
};
 objSQL.ExecSP("QxServer4Synch_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxServer4Synchs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where ServerId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxServer4Synch");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strServerId = oRow[conQxServer4Synch.ServerId].ToString().Trim();
if (IsExist(strServerId))
{
 string strResult = "关键字变量值为:" + string.Format("ServerId = {0}", strServerId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxServer4SynchEN._CurrTabName ].NewRow();
objRow[conQxServer4Synch.ServerId] = oRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objRow[conQxServer4Synch.ServerName] = oRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objRow[conQxServer4Synch.IpAddress] = oRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objRow[conQxServer4Synch.WebApiAddress] = oRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objRow[conQxServer4Synch.IsSelf] = oRow[conQxServer4Synch.IsSelf].ToString().Trim(); //是否当前服务器
objRow[conQxServer4Synch.InUse] = oRow[conQxServer4Synch.InUse].ToString().Trim(); //是否在用
objRow[conQxServer4Synch.UpdDate] = oRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objRow[conQxServer4Synch.UpdUser] = oRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objRow[conQxServer4Synch.Memo] = oRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxServer4SynchEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxServer4SynchEN._CurrTabName);
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
 /// <param name = "objQxServer4SynchEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxServer4SynchEN objQxServer4SynchEN)
{
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxServer4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxServer4SynchEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxServer4Synch where ServerId = " + "'"+ objQxServer4SynchEN.ServerId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxServer4SynchEN._CurrTabName);
if (objDS.Tables[clsQxServer4SynchEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ServerId = " + "'"+ objQxServer4SynchEN.ServerId+"'");
return false;
}
objRow = objDS.Tables[clsQxServer4SynchEN._CurrTabName].Rows[0];
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.ServerId))
 {
objRow[conQxServer4Synch.ServerId] = objQxServer4SynchEN.ServerId; //服务器Id
 }
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.ServerName))
 {
objRow[conQxServer4Synch.ServerName] = objQxServer4SynchEN.ServerName; //服务器名
 }
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.IpAddress))
 {
objRow[conQxServer4Synch.IpAddress] = objQxServer4SynchEN.IpAddress; //IP地址
 }
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.WebApiAddress))
 {
objRow[conQxServer4Synch.WebApiAddress] = objQxServer4SynchEN.WebApiAddress; //WApi地址
 }
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.IsSelf))
 {
objRow[conQxServer4Synch.IsSelf] = objQxServer4SynchEN.IsSelf; //是否当前服务器
 }
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.InUse))
 {
objRow[conQxServer4Synch.InUse] = objQxServer4SynchEN.InUse; //是否在用
 }
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.UpdDate))
 {
objRow[conQxServer4Synch.UpdDate] = objQxServer4SynchEN.UpdDate; //修改日期
 }
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.UpdUser))
 {
objRow[conQxServer4Synch.UpdUser] = objQxServer4SynchEN.UpdUser; //修改用户
 }
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.Memo))
 {
objRow[conQxServer4Synch.Memo] = objQxServer4SynchEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxServer4SynchEN._CurrTabName);
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
public bool UpdateBySP(clsQxServer4SynchEN objQxServer4SynchEN)
{
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxServer4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxServer4SynchEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxServer4SynchEN.ServerId,
 objQxServer4SynchEN.ServerName,
 objQxServer4SynchEN.IpAddress,
 objQxServer4SynchEN.WebApiAddress,
 objQxServer4SynchEN.IsSelf,
 objQxServer4SynchEN.InUse,
 objQxServer4SynchEN.UpdDate,
 objQxServer4SynchEN.UpdUser,
 objQxServer4SynchEN.Memo
};
 objSQL.ExecSP("QxServer4Synch_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxServer4SynchEN objQxServer4SynchEN)
{
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxServer4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxServer4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxServer4Synch Set ");
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.ServerName))
 {
 if (objQxServer4SynchEN.ServerName !=  null)
 {
 var strServerName = objQxServer4SynchEN.ServerName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strServerName, conQxServer4Synch.ServerName); //服务器名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.ServerName); //服务器名
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.IpAddress))
 {
 if (objQxServer4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objQxServer4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conQxServer4Synch.IpAddress); //IP地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.IpAddress); //IP地址
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.WebApiAddress))
 {
 if (objQxServer4SynchEN.WebApiAddress !=  null)
 {
 var strWebApiAddress = objQxServer4SynchEN.WebApiAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebApiAddress, conQxServer4Synch.WebApiAddress); //WApi地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.WebApiAddress); //WApi地址
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.IsSelf))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxServer4SynchEN.IsSelf == true?"1":"0", conQxServer4Synch.IsSelf); //是否当前服务器
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxServer4SynchEN.InUse == true?"1":"0", conQxServer4Synch.InUse); //是否在用
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.UpdDate))
 {
 if (objQxServer4SynchEN.UpdDate !=  null)
 {
 var strUpdDate = objQxServer4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxServer4Synch.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.UpdDate); //修改日期
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.UpdUser))
 {
 if (objQxServer4SynchEN.UpdUser !=  null)
 {
 var strUpdUser = objQxServer4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxServer4Synch.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.UpdUser); //修改用户
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.Memo))
 {
 if (objQxServer4SynchEN.Memo !=  null)
 {
 var strMemo = objQxServer4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxServer4Synch.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ServerId = '{0}'", objQxServer4SynchEN.ServerId); 
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
 /// <param name = "objQxServer4SynchEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxServer4SynchEN objQxServer4SynchEN, string strCondition)
{
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxServer4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxServer4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxServer4Synch Set ");
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.ServerName))
 {
 if (objQxServer4SynchEN.ServerName !=  null)
 {
 var strServerName = objQxServer4SynchEN.ServerName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ServerName = '{0}',", strServerName); //服务器名
 }
 else
 {
 sbSQL.Append(" ServerName = null,"); //服务器名
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.IpAddress))
 {
 if (objQxServer4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objQxServer4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //IP地址
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //IP地址
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.WebApiAddress))
 {
 if (objQxServer4SynchEN.WebApiAddress !=  null)
 {
 var strWebApiAddress = objQxServer4SynchEN.WebApiAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebApiAddress = '{0}',", strWebApiAddress); //WApi地址
 }
 else
 {
 sbSQL.Append(" WebApiAddress = null,"); //WApi地址
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.IsSelf))
 {
 sbSQL.AppendFormat(" IsSelf = '{0}',", objQxServer4SynchEN.IsSelf == true?"1":"0"); //是否当前服务器
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxServer4SynchEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.UpdDate))
 {
 if (objQxServer4SynchEN.UpdDate !=  null)
 {
 var strUpdDate = objQxServer4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.UpdUser))
 {
 if (objQxServer4SynchEN.UpdUser !=  null)
 {
 var strUpdUser = objQxServer4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.Memo))
 {
 if (objQxServer4SynchEN.Memo !=  null)
 {
 var strMemo = objQxServer4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxServer4SynchEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxServer4SynchEN objQxServer4SynchEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxServer4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxServer4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxServer4Synch Set ");
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.ServerName))
 {
 if (objQxServer4SynchEN.ServerName !=  null)
 {
 var strServerName = objQxServer4SynchEN.ServerName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ServerName = '{0}',", strServerName); //服务器名
 }
 else
 {
 sbSQL.Append(" ServerName = null,"); //服务器名
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.IpAddress))
 {
 if (objQxServer4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objQxServer4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //IP地址
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //IP地址
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.WebApiAddress))
 {
 if (objQxServer4SynchEN.WebApiAddress !=  null)
 {
 var strWebApiAddress = objQxServer4SynchEN.WebApiAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebApiAddress = '{0}',", strWebApiAddress); //WApi地址
 }
 else
 {
 sbSQL.Append(" WebApiAddress = null,"); //WApi地址
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.IsSelf))
 {
 sbSQL.AppendFormat(" IsSelf = '{0}',", objQxServer4SynchEN.IsSelf == true?"1":"0"); //是否当前服务器
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxServer4SynchEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.UpdDate))
 {
 if (objQxServer4SynchEN.UpdDate !=  null)
 {
 var strUpdDate = objQxServer4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.UpdUser))
 {
 if (objQxServer4SynchEN.UpdUser !=  null)
 {
 var strUpdUser = objQxServer4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.Memo))
 {
 if (objQxServer4SynchEN.Memo !=  null)
 {
 var strMemo = objQxServer4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxServer4SynchEN objQxServer4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxServer4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxServer4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxServer4Synch Set ");
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.ServerName))
 {
 if (objQxServer4SynchEN.ServerName !=  null)
 {
 var strServerName = objQxServer4SynchEN.ServerName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strServerName, conQxServer4Synch.ServerName); //服务器名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.ServerName); //服务器名
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.IpAddress))
 {
 if (objQxServer4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objQxServer4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conQxServer4Synch.IpAddress); //IP地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.IpAddress); //IP地址
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.WebApiAddress))
 {
 if (objQxServer4SynchEN.WebApiAddress !=  null)
 {
 var strWebApiAddress = objQxServer4SynchEN.WebApiAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebApiAddress, conQxServer4Synch.WebApiAddress); //WApi地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.WebApiAddress); //WApi地址
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.IsSelf))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxServer4SynchEN.IsSelf == true?"1":"0", conQxServer4Synch.IsSelf); //是否当前服务器
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxServer4SynchEN.InUse == true?"1":"0", conQxServer4Synch.InUse); //是否在用
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.UpdDate))
 {
 if (objQxServer4SynchEN.UpdDate !=  null)
 {
 var strUpdDate = objQxServer4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxServer4Synch.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.UpdDate); //修改日期
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.UpdUser))
 {
 if (objQxServer4SynchEN.UpdUser !=  null)
 {
 var strUpdUser = objQxServer4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxServer4Synch.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.UpdUser); //修改用户
 }
 }
 
 if (objQxServer4SynchEN.IsUpdated(conQxServer4Synch.Memo))
 {
 if (objQxServer4SynchEN.Memo !=  null)
 {
 var strMemo = objQxServer4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxServer4Synch.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxServer4Synch.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ServerId = '{0}'", objQxServer4SynchEN.ServerId); 
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
 /// <param name = "strServerId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strServerId) 
{
CheckPrimaryKey(strServerId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strServerId,
};
 objSQL.ExecSP("QxServer4Synch_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strServerId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strServerId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strServerId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
//删除QxServer4Synch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxServer4Synch where ServerId = " + "'"+ strServerId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxServer4Synch(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
//删除QxServer4Synch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxServer4Synch where ServerId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strServerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strServerId) 
{
CheckPrimaryKey(strServerId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
//删除QxServer4Synch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxServer4Synch where ServerId = " + "'"+ strServerId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxServer4Synch(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: DelQxServer4Synch)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxServer4Synch where " + strCondition ;
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
public bool DelQxServer4SynchWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxServer4SynchDA: DelQxServer4SynchWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxServer4Synch where " + strCondition ;
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
 /// <param name = "objQxServer4SynchENS">源对象</param>
 /// <param name = "objQxServer4SynchENT">目标对象</param>
public void CopyTo(clsQxServer4SynchEN objQxServer4SynchENS, clsQxServer4SynchEN objQxServer4SynchENT)
{
objQxServer4SynchENT.ServerId = objQxServer4SynchENS.ServerId; //服务器Id
objQxServer4SynchENT.ServerName = objQxServer4SynchENS.ServerName; //服务器名
objQxServer4SynchENT.IpAddress = objQxServer4SynchENS.IpAddress; //IP地址
objQxServer4SynchENT.WebApiAddress = objQxServer4SynchENS.WebApiAddress; //WApi地址
objQxServer4SynchENT.IsSelf = objQxServer4SynchENS.IsSelf; //是否当前服务器
objQxServer4SynchENT.InUse = objQxServer4SynchENS.InUse; //是否在用
objQxServer4SynchENT.UpdDate = objQxServer4SynchENS.UpdDate; //修改日期
objQxServer4SynchENT.UpdUser = objQxServer4SynchENS.UpdUser; //修改用户
objQxServer4SynchENT.Memo = objQxServer4SynchENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxServer4SynchEN objQxServer4SynchEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxServer4SynchEN.IpAddress, conQxServer4Synch.IpAddress);
clsCheckSql.CheckFieldNotNull(objQxServer4SynchEN.WebApiAddress, conQxServer4Synch.WebApiAddress);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.ServerId, 4, conQxServer4Synch.ServerId);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.ServerName, 50, conQxServer4Synch.ServerName);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.IpAddress, 23, conQxServer4Synch.IpAddress);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.WebApiAddress, 50, conQxServer4Synch.WebApiAddress);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.UpdDate, 20, conQxServer4Synch.UpdDate);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.UpdUser, 18, conQxServer4Synch.UpdUser);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.Memo, 1000, conQxServer4Synch.Memo);
//检查字段外键固定长度
 objQxServer4SynchEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxServer4SynchEN objQxServer4SynchEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.ServerName, 50, conQxServer4Synch.ServerName);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.IpAddress, 23, conQxServer4Synch.IpAddress);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.WebApiAddress, 50, conQxServer4Synch.WebApiAddress);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.UpdDate, 20, conQxServer4Synch.UpdDate);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.UpdUser, 18, conQxServer4Synch.UpdUser);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.Memo, 1000, conQxServer4Synch.Memo);
//检查外键字段长度
 objQxServer4SynchEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxServer4SynchEN objQxServer4SynchEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.ServerId, 4, conQxServer4Synch.ServerId);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.ServerName, 50, conQxServer4Synch.ServerName);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.IpAddress, 23, conQxServer4Synch.IpAddress);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.WebApiAddress, 50, conQxServer4Synch.WebApiAddress);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.UpdDate, 20, conQxServer4Synch.UpdDate);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.UpdUser, 18, conQxServer4Synch.UpdUser);
clsCheckSql.CheckFieldLen(objQxServer4SynchEN.Memo, 1000, conQxServer4Synch.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxServer4SynchEN.ServerId, conQxServer4Synch.ServerId);
clsCheckSql.CheckSqlInjection4Field(objQxServer4SynchEN.ServerName, conQxServer4Synch.ServerName);
clsCheckSql.CheckSqlInjection4Field(objQxServer4SynchEN.IpAddress, conQxServer4Synch.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objQxServer4SynchEN.WebApiAddress, conQxServer4Synch.WebApiAddress);
clsCheckSql.CheckSqlInjection4Field(objQxServer4SynchEN.UpdDate, conQxServer4Synch.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxServer4SynchEN.UpdUser, conQxServer4Synch.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQxServer4SynchEN.Memo, conQxServer4Synch.Memo);
//检查外键字段长度
 objQxServer4SynchEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetServerId()
{
//获取某学院所有专业信息
string strSQL = "select ServerId, ServerName from QxServer4Synch ";
 clsSpecSQLforSql mySql = clsQxServer4SynchDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxServer4Synch(同步服务器),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxServer4SynchEN objQxServer4SynchEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objQxServer4SynchEN.ServerName == null)
{
 sbCondition.AppendFormat(" and ServerName is null");
}
else
{
 sbCondition.AppendFormat(" and ServerName = '{0}'", objQxServer4SynchEN.ServerName);
}
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
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxServer4SynchEN._CurrTabName);
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
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxServer4SynchEN._CurrTabName, strCondition);
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
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
 objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}