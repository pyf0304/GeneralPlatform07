
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserDownLoadLogDA
 表名:QxUserDownLoadLog(00140058)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:19:06
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程文件下载(PrjFileDownLoad)
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
 /// 用户下载日志(QxUserDownLoadLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxUserDownLoadLogDA : clsCommBase4DA
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
 return clsQxUserDownLoadLogEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxUserDownLoadLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUserDownLoadLogEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxUserDownLoadLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxUserDownLoadLogEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strUserDownLoadLogId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strUserDownLoadLogId)
{
strUserDownLoadLogId = strUserDownLoadLogId.Replace("'", "''");
if (strUserDownLoadLogId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:QxUserDownLoadLog中,检查关键字,长度不正确!(clsQxUserDownLoadLogDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserDownLoadLogId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxUserDownLoadLog中,关键字不能为空 或 null!(clsQxUserDownLoadLogDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserDownLoadLogId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxUserDownLoadLogDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strUserDownLoadLogId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strUserDownLoadLogId)
{
strUserDownLoadLogId = strUserDownLoadLogId.Replace("'", "''");
if (strUserDownLoadLogId.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:QxUserDownLoadLog中,检查关键字,长度不正确!(简化版)(clsQxUserDownLoadLogDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserDownLoadLogId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxUserDownLoadLog中,关键字不能为空 或 null!(clsQxUserDownLoadLogDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserDownLoadLogId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxUserDownLoadLogDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
 strSQL = "Select * from QxUserDownLoadLog where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxUserDownLoadLog");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxUserDownLoadLog_SelectByCond",values, "QxUserDownLoadLog");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUserDownLoadLog where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxUserDownLoadLog");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUserDownLoadLog a where {0} And a.UserDownLoadLogId not in (Select Top {2} UserDownLoadLogId From QxUserDownLoadLog Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUserDownLoadLog");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUserDownLoadLog a where {0} And a.UserDownLoadLogId not in (Select Top {2} UserDownLoadLogId From QxUserDownLoadLog Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUserDownLoadLog");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUserDownLoadLog a where {0} And a.UserDownLoadLogId not in (Select Top {2} UserDownLoadLogId From QxUserDownLoadLog Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUserDownLoadLog");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxUserDownLoadLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTable_QxUserDownLoadLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserDownLoadLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserDownLoadLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUserDownLoadLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUserDownLoadLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUserDownLoadLog.* from QxUserDownLoadLog Left Join {1} on {2} where {3} and QxUserDownLoadLog.UserDownLoadLogId not in (Select top {5} QxUserDownLoadLog.UserDownLoadLogId from QxUserDownLoadLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserDownLoadLog where {1} and UserDownLoadLogId not in (Select top {2} UserDownLoadLogId from QxUserDownLoadLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserDownLoadLog where {1} and UserDownLoadLogId not in (Select top {3} UserDownLoadLogId from QxUserDownLoadLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUserDownLoadLog.* from QxUserDownLoadLog Left Join {1} on {2} where {3} and QxUserDownLoadLog.UserDownLoadLogId not in (Select top {5} QxUserDownLoadLog.UserDownLoadLogId from QxUserDownLoadLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserDownLoadLog where {1} and UserDownLoadLogId not in (Select top {2} UserDownLoadLogId from QxUserDownLoadLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserDownLoadLog where {1} and UserDownLoadLogId not in (Select top {3} UserDownLoadLogId from QxUserDownLoadLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUserDownLoadLog.* from QxUserDownLoadLog Left Join {1} on {2} where {3} and QxUserDownLoadLog.UserDownLoadLogId not in (Select top {5} QxUserDownLoadLog.UserDownLoadLogId from QxUserDownLoadLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserDownLoadLog where {1} and UserDownLoadLogId not in (Select top {2} UserDownLoadLogId from QxUserDownLoadLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserDownLoadLog where {1} and UserDownLoadLogId not in (Select top {3} UserDownLoadLogId from QxUserDownLoadLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUserDownLoadLog a where {0} And a.UserDownLoadLogId not in (Select Top {2} UserDownLoadLogId From QxUserDownLoadLog Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUserDownLoadLog a where {0} And a.UserDownLoadLogId not in (Select Top {2} UserDownLoadLogId From QxUserDownLoadLog Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUserDownLoadLog a where {0} And a.UserDownLoadLogId not in (Select Top {2} UserDownLoadLogId From QxUserDownLoadLog Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUserDownLoadLog a where {0} And a.UserDownLoadLogId not in (Select Top {2} UserDownLoadLogId From QxUserDownLoadLog Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLogByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUserDownLoadLog_SelectByCond",values);
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
public List<clsQxUserDownLoadLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA:GetObjLst)", objException.Message));
}
List<clsQxUserDownLoadLogEN> arrObjLst = new List<clsQxUserDownLoadLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = new clsQxUserDownLoadLogEN();
try
{
objQxUserDownLoadLogEN.UserDownLoadLogId = objRow[conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objQxUserDownLoadLogEN.UserId = objRow[conQxUserDownLoadLog.UserId].ToString().Trim(); //用户ID
objQxUserDownLoadLogEN.PrjSiteId = objRow[conQxUserDownLoadLog.PrjSiteId].ToString().Trim(); //工程站点Id
objQxUserDownLoadLogEN.DownLownDate = objRow[conQxUserDownLoadLog.DownLownDate].ToString().Trim(); //下载日期
objQxUserDownLoadLogEN.IsSuccess = TransNullToBool(objRow[conQxUserDownLoadLog.IsSuccess].ToString().Trim()); //是否成功
objQxUserDownLoadLogEN.LogInfo = objRow[conQxUserDownLoadLog.LogInfo].ToString().Trim(); //日志信息
objQxUserDownLoadLogEN.Memo = objRow[conQxUserDownLoadLog.Memo] == DBNull.Value ? null : objRow[conQxUserDownLoadLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUserDownLoadLogDA: GetObjLst)", objException.Message));
}
objQxUserDownLoadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUserDownLoadLogEN);
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
public List<clsQxUserDownLoadLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxUserDownLoadLogEN> arrObjLst = new List<clsQxUserDownLoadLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = new clsQxUserDownLoadLogEN();
try
{
objQxUserDownLoadLogEN.UserDownLoadLogId = objRow[conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objQxUserDownLoadLogEN.UserId = objRow[conQxUserDownLoadLog.UserId].ToString().Trim(); //用户ID
objQxUserDownLoadLogEN.PrjSiteId = objRow[conQxUserDownLoadLog.PrjSiteId].ToString().Trim(); //工程站点Id
objQxUserDownLoadLogEN.DownLownDate = objRow[conQxUserDownLoadLog.DownLownDate].ToString().Trim(); //下载日期
objQxUserDownLoadLogEN.IsSuccess = TransNullToBool(objRow[conQxUserDownLoadLog.IsSuccess].ToString().Trim()); //是否成功
objQxUserDownLoadLogEN.LogInfo = objRow[conQxUserDownLoadLog.LogInfo].ToString().Trim(); //日志信息
objQxUserDownLoadLogEN.Memo = objRow[conQxUserDownLoadLog.Memo] == DBNull.Value ? null : objRow[conQxUserDownLoadLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUserDownLoadLogDA: GetObjLst)", objException.Message));
}
objQxUserDownLoadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUserDownLoadLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxUserDownLoadLogEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA:GetObjLstBySP)", objException.Message));
}
List<clsQxUserDownLoadLogEN> arrObjLst = new List<clsQxUserDownLoadLogEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUserDownLoadLog_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = new clsQxUserDownLoadLogEN();
try
{
objQxUserDownLoadLogEN.UserDownLoadLogId = objRow[conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objQxUserDownLoadLogEN.UserId = objRow[conQxUserDownLoadLog.UserId].ToString().Trim(); //用户ID
objQxUserDownLoadLogEN.PrjSiteId = objRow[conQxUserDownLoadLog.PrjSiteId].ToString().Trim(); //工程站点Id
objQxUserDownLoadLogEN.DownLownDate = objRow[conQxUserDownLoadLog.DownLownDate].ToString().Trim(); //下载日期
objQxUserDownLoadLogEN.IsSuccess = TransNullToBool(objRow[conQxUserDownLoadLog.IsSuccess].ToString().Trim()); //是否成功
objQxUserDownLoadLogEN.LogInfo = objRow[conQxUserDownLoadLog.LogInfo].ToString().Trim(); //日志信息
objQxUserDownLoadLogEN.Memo = objRow[conQxUserDownLoadLog.Memo] == DBNull.Value ? null : objRow[conQxUserDownLoadLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxUserDownLoadLogDA: GetObjLstBySP)", objException.Message));
}
objQxUserDownLoadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUserDownLoadLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUserDownLoadLog(ref clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where UserDownLoadLogId = " + "'"+ objQxUserDownLoadLogEN.UserDownLoadLogId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxUserDownLoadLogEN.UserDownLoadLogId = objDT.Rows[0][conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id(字段类型:char,字段长度:8,是否可空:False)
 objQxUserDownLoadLogEN.UserId = objDT.Rows[0][conQxUserDownLoadLog.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserDownLoadLogEN.PrjSiteId = objDT.Rows[0][conQxUserDownLoadLog.PrjSiteId].ToString().Trim(); //工程站点Id(字段类型:char,字段长度:6,是否可空:False)
 objQxUserDownLoadLogEN.DownLownDate = objDT.Rows[0][conQxUserDownLoadLog.DownLownDate].ToString().Trim(); //下载日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUserDownLoadLogEN.IsSuccess = TransNullToBool(objDT.Rows[0][conQxUserDownLoadLog.IsSuccess].ToString().Trim()); //是否成功(字段类型:bit,字段长度:1,是否可空:False)
 objQxUserDownLoadLogEN.LogInfo = objDT.Rows[0][conQxUserDownLoadLog.LogInfo].ToString().Trim(); //日志信息(字段类型:varchar,字段长度:500,是否可空:False)
 objQxUserDownLoadLogEN.Memo = objDT.Rows[0][conQxUserDownLoadLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxUserDownLoadLogDA: GetQxUserDownLoadLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserDownLoadLogId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxUserDownLoadLogEN GetObjByUserDownLoadLogId(string strUserDownLoadLogId)
{
CheckPrimaryKey(strUserDownLoadLogId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where UserDownLoadLogId = " + "'"+ strUserDownLoadLogId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = new clsQxUserDownLoadLogEN();
try
{
 objQxUserDownLoadLogEN.UserDownLoadLogId = objRow[conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id(字段类型:char,字段长度:8,是否可空:False)
 objQxUserDownLoadLogEN.UserId = objRow[conQxUserDownLoadLog.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserDownLoadLogEN.PrjSiteId = objRow[conQxUserDownLoadLog.PrjSiteId].ToString().Trim(); //工程站点Id(字段类型:char,字段长度:6,是否可空:False)
 objQxUserDownLoadLogEN.DownLownDate = objRow[conQxUserDownLoadLog.DownLownDate].ToString().Trim(); //下载日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUserDownLoadLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[conQxUserDownLoadLog.IsSuccess].ToString().Trim()); //是否成功(字段类型:bit,字段长度:1,是否可空:False)
 objQxUserDownLoadLogEN.LogInfo = objRow[conQxUserDownLoadLog.LogInfo].ToString().Trim(); //日志信息(字段类型:varchar,字段长度:500,是否可空:False)
 objQxUserDownLoadLogEN.Memo = objRow[conQxUserDownLoadLog.Memo] == DBNull.Value ? null : objRow[conQxUserDownLoadLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxUserDownLoadLogDA: GetObjByUserDownLoadLogId)", objException.Message));
}
return objQxUserDownLoadLogEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxUserDownLoadLog_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUserDownLoadLogOneBySP(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxUserDownLoadLogEN.UserDownLoadLogId
};
 objDT = objSQL.ExecSpReturnDT("QxUserDownLoadLog_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxUserDownLoadLogEN.UserDownLoadLogId = objDT.Rows[0][conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id(字段类型:char,字段长度:8,是否可空:False)
 objQxUserDownLoadLogEN.UserId = objDT.Rows[0][conQxUserDownLoadLog.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserDownLoadLogEN.PrjSiteId = objDT.Rows[0][conQxUserDownLoadLog.PrjSiteId].ToString().Trim(); //工程站点Id(字段类型:char,字段长度:6,是否可空:False)
 objQxUserDownLoadLogEN.DownLownDate = objDT.Rows[0][conQxUserDownLoadLog.DownLownDate].ToString().Trim(); //下载日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUserDownLoadLogEN.IsSuccess = TransNullToBool(objDT.Rows[0][conQxUserDownLoadLog.IsSuccess].ToString().Trim()); //是否成功(字段类型:bit,字段长度:1,是否可空:False)
 objQxUserDownLoadLogEN.LogInfo = objDT.Rows[0][conQxUserDownLoadLog.LogInfo].ToString().Trim(); //日志信息(字段类型:varchar,字段长度:500,是否可空:False)
 objQxUserDownLoadLogEN.Memo = objDT.Rows[0][conQxUserDownLoadLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUserDownLoadLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = new clsQxUserDownLoadLogEN()
{
UserDownLoadLogId = objRow[conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim(), //用户下载日志Id
UserId = objRow[conQxUserDownLoadLog.UserId].ToString().Trim(), //用户ID
PrjSiteId = objRow[conQxUserDownLoadLog.PrjSiteId].ToString().Trim(), //工程站点Id
DownLownDate = objRow[conQxUserDownLoadLog.DownLownDate].ToString().Trim(), //下载日期
IsSuccess = TransNullToBool(objRow[conQxUserDownLoadLog.IsSuccess].ToString().Trim()), //是否成功
LogInfo = objRow[conQxUserDownLoadLog.LogInfo].ToString().Trim(), //日志信息
Memo = objRow[conQxUserDownLoadLog.Memo] == DBNull.Value ? null : objRow[conQxUserDownLoadLog.Memo].ToString().Trim() //备注
};
objQxUserDownLoadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserDownLoadLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxUserDownLoadLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUserDownLoadLogEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUserDownLoadLog_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = new clsQxUserDownLoadLogEN()
{
UserDownLoadLogId = objRow[conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim(), //用户下载日志Id
UserId = objRow[conQxUserDownLoadLog.UserId].ToString().Trim(), //用户ID
PrjSiteId = objRow[conQxUserDownLoadLog.PrjSiteId].ToString().Trim(), //工程站点Id
DownLownDate = objRow[conQxUserDownLoadLog.DownLownDate].ToString().Trim(), //下载日期
IsSuccess = TransNullToBool(objRow[conQxUserDownLoadLog.IsSuccess].ToString().Trim()), //是否成功
LogInfo = objRow[conQxUserDownLoadLog.LogInfo].ToString().Trim(), //日志信息
Memo = objRow[conQxUserDownLoadLog.Memo] == DBNull.Value ? null : objRow[conQxUserDownLoadLog.Memo].ToString().Trim() //备注
};
objQxUserDownLoadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserDownLoadLogEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxUserDownLoadLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = new clsQxUserDownLoadLogEN();
try
{
objQxUserDownLoadLogEN.UserDownLoadLogId = objRow[conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objQxUserDownLoadLogEN.UserId = objRow[conQxUserDownLoadLog.UserId].ToString().Trim(); //用户ID
objQxUserDownLoadLogEN.PrjSiteId = objRow[conQxUserDownLoadLog.PrjSiteId].ToString().Trim(); //工程站点Id
objQxUserDownLoadLogEN.DownLownDate = objRow[conQxUserDownLoadLog.DownLownDate].ToString().Trim(); //下载日期
objQxUserDownLoadLogEN.IsSuccess = TransNullToBool(objRow[conQxUserDownLoadLog.IsSuccess].ToString().Trim()); //是否成功
objQxUserDownLoadLogEN.LogInfo = objRow[conQxUserDownLoadLog.LogInfo].ToString().Trim(); //日志信息
objQxUserDownLoadLogEN.Memo = objRow[conQxUserDownLoadLog.Memo] == DBNull.Value ? null : objRow[conQxUserDownLoadLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxUserDownLoadLogDA: GetObjByDataRowQxUserDownLoadLog)", objException.Message));
}
objQxUserDownLoadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserDownLoadLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxUserDownLoadLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = new clsQxUserDownLoadLogEN();
try
{
objQxUserDownLoadLogEN.UserDownLoadLogId = objRow[conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objQxUserDownLoadLogEN.UserId = objRow[conQxUserDownLoadLog.UserId].ToString().Trim(); //用户ID
objQxUserDownLoadLogEN.PrjSiteId = objRow[conQxUserDownLoadLog.PrjSiteId].ToString().Trim(); //工程站点Id
objQxUserDownLoadLogEN.DownLownDate = objRow[conQxUserDownLoadLog.DownLownDate].ToString().Trim(); //下载日期
objQxUserDownLoadLogEN.IsSuccess = TransNullToBool(objRow[conQxUserDownLoadLog.IsSuccess].ToString().Trim()); //是否成功
objQxUserDownLoadLogEN.LogInfo = objRow[conQxUserDownLoadLog.LogInfo].ToString().Trim(); //日志信息
objQxUserDownLoadLogEN.Memo = objRow[conQxUserDownLoadLog.Memo] == DBNull.Value ? null : objRow[conQxUserDownLoadLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxUserDownLoadLogDA: GetObjByDataRow)", objException.Message));
}
objQxUserDownLoadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserDownLoadLogEN;
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
objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUserDownLoadLogEN._CurrTabName, conQxUserDownLoadLog.UserDownLoadLogId, 8, "");
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
objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUserDownLoadLogEN._CurrTabName, conQxUserDownLoadLog.UserDownLoadLogId, 8, strPrefix);
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
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserDownLoadLogId from QxUserDownLoadLog where " + strCondition;
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
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserDownLoadLogId from QxUserDownLoadLog where " + strCondition;
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
 /// <param name = "strUserDownLoadLogId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strUserDownLoadLogId)
{
CheckPrimaryKey(strUserDownLoadLogId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUserDownLoadLog", "UserDownLoadLogId = " + "'"+ strUserDownLoadLogId+"'"))
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
 /// <param name = "strUserDownLoadLogId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strUserDownLoadLogId)
{
CheckPrimaryKey(strUserDownLoadLogId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strUserDownLoadLogId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxUserDownLoadLog_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUserDownLoadLog", strCondition))
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
objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxUserDownLoadLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
 {
 if (objQxUserDownLoadLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserDownLoadLogEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUserDownLoadLog");
objRow = objDS.Tables["QxUserDownLoadLog"].NewRow();
objRow[conQxUserDownLoadLog.UserDownLoadLogId] = objQxUserDownLoadLogEN.UserDownLoadLogId; //用户下载日志Id
objRow[conQxUserDownLoadLog.UserId] = objQxUserDownLoadLogEN.UserId; //用户ID
objRow[conQxUserDownLoadLog.PrjSiteId] = objQxUserDownLoadLogEN.PrjSiteId; //工程站点Id
objRow[conQxUserDownLoadLog.DownLownDate] = objQxUserDownLoadLogEN.DownLownDate; //下载日期
objRow[conQxUserDownLoadLog.IsSuccess] = objQxUserDownLoadLogEN.IsSuccess; //是否成功
objRow[conQxUserDownLoadLog.LogInfo] = objQxUserDownLoadLogEN.LogInfo; //日志信息
 if (objQxUserDownLoadLogEN.Memo !=  "")
 {
objRow[conQxUserDownLoadLog.Memo] = objQxUserDownLoadLogEN.Memo; //备注
 }
objDS.Tables[clsQxUserDownLoadLogEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxUserDownLoadLogEN._CurrTabName);
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
 /// <param name = "objQxUserDownLoadLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
 if (objQxUserDownLoadLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserDownLoadLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUserDownLoadLogEN.UserDownLoadLogId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.UserDownLoadLogId);
 var strUserDownLoadLogId = objQxUserDownLoadLogEN.UserDownLoadLogId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserDownLoadLogId + "'");
 }
 
 if (objQxUserDownLoadLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.UserId);
 var strUserId = objQxUserDownLoadLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserDownLoadLogEN.PrjSiteId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.PrjSiteId);
 var strPrjSiteId = objQxUserDownLoadLogEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteId + "'");
 }
 
 if (objQxUserDownLoadLogEN.DownLownDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.DownLownDate);
 var strDownLownDate = objQxUserDownLoadLogEN.DownLownDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDownLownDate + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserDownLoadLog.IsSuccess);
 arrValueListForInsert.Add("'" + (objQxUserDownLoadLogEN.IsSuccess  ==  false ? "0" : "1") + "'");
 
 if (objQxUserDownLoadLogEN.LogInfo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.LogInfo);
 var strLogInfo = objQxUserDownLoadLogEN.LogInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogInfo + "'");
 }
 
 if (objQxUserDownLoadLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.Memo);
 var strMemo = objQxUserDownLoadLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserDownLoadLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
 if (objQxUserDownLoadLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserDownLoadLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUserDownLoadLogEN.UserDownLoadLogId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.UserDownLoadLogId);
 var strUserDownLoadLogId = objQxUserDownLoadLogEN.UserDownLoadLogId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserDownLoadLogId + "'");
 }
 
 if (objQxUserDownLoadLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.UserId);
 var strUserId = objQxUserDownLoadLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserDownLoadLogEN.PrjSiteId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.PrjSiteId);
 var strPrjSiteId = objQxUserDownLoadLogEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteId + "'");
 }
 
 if (objQxUserDownLoadLogEN.DownLownDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.DownLownDate);
 var strDownLownDate = objQxUserDownLoadLogEN.DownLownDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDownLownDate + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserDownLoadLog.IsSuccess);
 arrValueListForInsert.Add("'" + (objQxUserDownLoadLogEN.IsSuccess  ==  false ? "0" : "1") + "'");
 
 if (objQxUserDownLoadLogEN.LogInfo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.LogInfo);
 var strLogInfo = objQxUserDownLoadLogEN.LogInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogInfo + "'");
 }
 
 if (objQxUserDownLoadLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.Memo);
 var strMemo = objQxUserDownLoadLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserDownLoadLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxUserDownLoadLogEN.UserDownLoadLogId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserDownLoadLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserDownLoadLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUserDownLoadLogEN.UserDownLoadLogId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.UserDownLoadLogId);
 var strUserDownLoadLogId = objQxUserDownLoadLogEN.UserDownLoadLogId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserDownLoadLogId + "'");
 }
 
 if (objQxUserDownLoadLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.UserId);
 var strUserId = objQxUserDownLoadLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserDownLoadLogEN.PrjSiteId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.PrjSiteId);
 var strPrjSiteId = objQxUserDownLoadLogEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteId + "'");
 }
 
 if (objQxUserDownLoadLogEN.DownLownDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.DownLownDate);
 var strDownLownDate = objQxUserDownLoadLogEN.DownLownDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDownLownDate + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserDownLoadLog.IsSuccess);
 arrValueListForInsert.Add("'" + (objQxUserDownLoadLogEN.IsSuccess  ==  false ? "0" : "1") + "'");
 
 if (objQxUserDownLoadLogEN.LogInfo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.LogInfo);
 var strLogInfo = objQxUserDownLoadLogEN.LogInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogInfo + "'");
 }
 
 if (objQxUserDownLoadLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.Memo);
 var strMemo = objQxUserDownLoadLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserDownLoadLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objQxUserDownLoadLogEN.UserDownLoadLogId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQxUserDownLoadLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserDownLoadLogEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUserDownLoadLogEN.UserDownLoadLogId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.UserDownLoadLogId);
 var strUserDownLoadLogId = objQxUserDownLoadLogEN.UserDownLoadLogId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserDownLoadLogId + "'");
 }
 
 if (objQxUserDownLoadLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.UserId);
 var strUserId = objQxUserDownLoadLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserDownLoadLogEN.PrjSiteId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.PrjSiteId);
 var strPrjSiteId = objQxUserDownLoadLogEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteId + "'");
 }
 
 if (objQxUserDownLoadLogEN.DownLownDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.DownLownDate);
 var strDownLownDate = objQxUserDownLoadLogEN.DownLownDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDownLownDate + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserDownLoadLog.IsSuccess);
 arrValueListForInsert.Add("'" + (objQxUserDownLoadLogEN.IsSuccess  ==  false ? "0" : "1") + "'");
 
 if (objQxUserDownLoadLogEN.LogInfo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.LogInfo);
 var strLogInfo = objQxUserDownLoadLogEN.LogInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogInfo + "'");
 }
 
 if (objQxUserDownLoadLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserDownLoadLog.Memo);
 var strMemo = objQxUserDownLoadLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserDownLoadLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxUserDownLoadLogBySP(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUserDownLoadLogEN.UserDownLoadLogId,
 objQxUserDownLoadLogEN.UserId,
 objQxUserDownLoadLogEN.PrjSiteId,
 objQxUserDownLoadLogEN.DownLownDate,
 objQxUserDownLoadLogEN.IsSuccess,
 objQxUserDownLoadLogEN.LogInfo,
objQxUserDownLoadLogEN.Memo
};
 objSQL.ExecSP("QxUserDownLoadLog_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxUserDownLoadLogs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where UserDownLoadLogId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUserDownLoadLog");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strUserDownLoadLogId = oRow[conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim();
if (IsExist(strUserDownLoadLogId))
{
 string strResult = "关键字变量值为:" + string.Format("UserDownLoadLogId = {0}", strUserDownLoadLogId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxUserDownLoadLogEN._CurrTabName ].NewRow();
objRow[conQxUserDownLoadLog.UserDownLoadLogId] = oRow[conQxUserDownLoadLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objRow[conQxUserDownLoadLog.UserId] = oRow[conQxUserDownLoadLog.UserId].ToString().Trim(); //用户ID
objRow[conQxUserDownLoadLog.PrjSiteId] = oRow[conQxUserDownLoadLog.PrjSiteId].ToString().Trim(); //工程站点Id
objRow[conQxUserDownLoadLog.DownLownDate] = oRow[conQxUserDownLoadLog.DownLownDate].ToString().Trim(); //下载日期
objRow[conQxUserDownLoadLog.IsSuccess] = oRow[conQxUserDownLoadLog.IsSuccess].ToString().Trim(); //是否成功
objRow[conQxUserDownLoadLog.LogInfo] = oRow[conQxUserDownLoadLog.LogInfo].ToString().Trim(); //日志信息
objRow[conQxUserDownLoadLog.Memo] = oRow[conQxUserDownLoadLog.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxUserDownLoadLogEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxUserDownLoadLogEN._CurrTabName);
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
 /// <param name = "objQxUserDownLoadLogEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
 if (objQxUserDownLoadLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserDownLoadLogEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
strSQL = "Select * from QxUserDownLoadLog where UserDownLoadLogId = " + "'"+ objQxUserDownLoadLogEN.UserDownLoadLogId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxUserDownLoadLogEN._CurrTabName);
if (objDS.Tables[clsQxUserDownLoadLogEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:UserDownLoadLogId = " + "'"+ objQxUserDownLoadLogEN.UserDownLoadLogId+"'");
return false;
}
objRow = objDS.Tables[clsQxUserDownLoadLogEN._CurrTabName].Rows[0];
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.UserDownLoadLogId))
 {
objRow[conQxUserDownLoadLog.UserDownLoadLogId] = objQxUserDownLoadLogEN.UserDownLoadLogId; //用户下载日志Id
 }
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.UserId))
 {
objRow[conQxUserDownLoadLog.UserId] = objQxUserDownLoadLogEN.UserId; //用户ID
 }
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.PrjSiteId))
 {
objRow[conQxUserDownLoadLog.PrjSiteId] = objQxUserDownLoadLogEN.PrjSiteId; //工程站点Id
 }
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.DownLownDate))
 {
objRow[conQxUserDownLoadLog.DownLownDate] = objQxUserDownLoadLogEN.DownLownDate; //下载日期
 }
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.IsSuccess))
 {
objRow[conQxUserDownLoadLog.IsSuccess] = objQxUserDownLoadLogEN.IsSuccess; //是否成功
 }
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.LogInfo))
 {
objRow[conQxUserDownLoadLog.LogInfo] = objQxUserDownLoadLogEN.LogInfo; //日志信息
 }
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.Memo))
 {
objRow[conQxUserDownLoadLog.Memo] = objQxUserDownLoadLogEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxUserDownLoadLogEN._CurrTabName);
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
public bool UpdateBySP(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
 if (objQxUserDownLoadLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserDownLoadLogEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUserDownLoadLogEN.UserDownLoadLogId,
 objQxUserDownLoadLogEN.UserId,
 objQxUserDownLoadLogEN.PrjSiteId,
 objQxUserDownLoadLogEN.DownLownDate,
 objQxUserDownLoadLogEN.IsSuccess,
 objQxUserDownLoadLogEN.LogInfo,
 objQxUserDownLoadLogEN.Memo
};
 objSQL.ExecSP("QxUserDownLoadLog_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
 if (objQxUserDownLoadLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserDownLoadLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxUserDownLoadLog Set ");
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.UserId))
 {
 if (objQxUserDownLoadLogEN.UserId !=  null)
 {
 var strUserId = objQxUserDownLoadLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUserDownLoadLog.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserDownLoadLog.UserId); //用户ID
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.PrjSiteId))
 {
 if (objQxUserDownLoadLogEN.PrjSiteId !=  null)
 {
 var strPrjSiteId = objQxUserDownLoadLogEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjSiteId, conQxUserDownLoadLog.PrjSiteId); //工程站点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserDownLoadLog.PrjSiteId); //工程站点Id
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.DownLownDate))
 {
 if (objQxUserDownLoadLogEN.DownLownDate !=  null)
 {
 var strDownLownDate = objQxUserDownLoadLogEN.DownLownDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDownLownDate, conQxUserDownLoadLog.DownLownDate); //下载日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserDownLoadLog.DownLownDate); //下载日期
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.IsSuccess))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUserDownLoadLogEN.IsSuccess == true?"1":"0", conQxUserDownLoadLog.IsSuccess); //是否成功
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.LogInfo))
 {
 if (objQxUserDownLoadLogEN.LogInfo !=  null)
 {
 var strLogInfo = objQxUserDownLoadLogEN.LogInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogInfo, conQxUserDownLoadLog.LogInfo); //日志信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserDownLoadLog.LogInfo); //日志信息
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.Memo))
 {
 if (objQxUserDownLoadLogEN.Memo !=  null)
 {
 var strMemo = objQxUserDownLoadLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUserDownLoadLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserDownLoadLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserDownLoadLogId = '{0}'", objQxUserDownLoadLogEN.UserDownLoadLogId); 
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
 /// <param name = "objQxUserDownLoadLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, string strCondition)
{
 if (objQxUserDownLoadLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserDownLoadLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserDownLoadLog Set ");
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.UserId))
 {
 if (objQxUserDownLoadLogEN.UserId !=  null)
 {
 var strUserId = objQxUserDownLoadLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.PrjSiteId))
 {
 if (objQxUserDownLoadLogEN.PrjSiteId !=  null)
 {
 var strPrjSiteId = objQxUserDownLoadLogEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjSiteId = '{0}',", strPrjSiteId); //工程站点Id
 }
 else
 {
 sbSQL.Append(" PrjSiteId = null,"); //工程站点Id
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.DownLownDate))
 {
 if (objQxUserDownLoadLogEN.DownLownDate !=  null)
 {
 var strDownLownDate = objQxUserDownLoadLogEN.DownLownDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DownLownDate = '{0}',", strDownLownDate); //下载日期
 }
 else
 {
 sbSQL.Append(" DownLownDate = null,"); //下载日期
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.IsSuccess))
 {
 sbSQL.AppendFormat(" IsSuccess = '{0}',", objQxUserDownLoadLogEN.IsSuccess == true?"1":"0"); //是否成功
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.LogInfo))
 {
 if (objQxUserDownLoadLogEN.LogInfo !=  null)
 {
 var strLogInfo = objQxUserDownLoadLogEN.LogInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogInfo = '{0}',", strLogInfo); //日志信息
 }
 else
 {
 sbSQL.Append(" LogInfo = null,"); //日志信息
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.Memo))
 {
 if (objQxUserDownLoadLogEN.Memo !=  null)
 {
 var strMemo = objQxUserDownLoadLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxUserDownLoadLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserDownLoadLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserDownLoadLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserDownLoadLog Set ");
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.UserId))
 {
 if (objQxUserDownLoadLogEN.UserId !=  null)
 {
 var strUserId = objQxUserDownLoadLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.PrjSiteId))
 {
 if (objQxUserDownLoadLogEN.PrjSiteId !=  null)
 {
 var strPrjSiteId = objQxUserDownLoadLogEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjSiteId = '{0}',", strPrjSiteId); //工程站点Id
 }
 else
 {
 sbSQL.Append(" PrjSiteId = null,"); //工程站点Id
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.DownLownDate))
 {
 if (objQxUserDownLoadLogEN.DownLownDate !=  null)
 {
 var strDownLownDate = objQxUserDownLoadLogEN.DownLownDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DownLownDate = '{0}',", strDownLownDate); //下载日期
 }
 else
 {
 sbSQL.Append(" DownLownDate = null,"); //下载日期
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.IsSuccess))
 {
 sbSQL.AppendFormat(" IsSuccess = '{0}',", objQxUserDownLoadLogEN.IsSuccess == true?"1":"0"); //是否成功
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.LogInfo))
 {
 if (objQxUserDownLoadLogEN.LogInfo !=  null)
 {
 var strLogInfo = objQxUserDownLoadLogEN.LogInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogInfo = '{0}',", strLogInfo); //日志信息
 }
 else
 {
 sbSQL.Append(" LogInfo = null,"); //日志信息
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.Memo))
 {
 if (objQxUserDownLoadLogEN.Memo !=  null)
 {
 var strMemo = objQxUserDownLoadLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxUserDownLoadLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQxUserDownLoadLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserDownLoadLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserDownLoadLog Set ");
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.UserId))
 {
 if (objQxUserDownLoadLogEN.UserId !=  null)
 {
 var strUserId = objQxUserDownLoadLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUserDownLoadLog.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserDownLoadLog.UserId); //用户ID
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.PrjSiteId))
 {
 if (objQxUserDownLoadLogEN.PrjSiteId !=  null)
 {
 var strPrjSiteId = objQxUserDownLoadLogEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjSiteId, conQxUserDownLoadLog.PrjSiteId); //工程站点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserDownLoadLog.PrjSiteId); //工程站点Id
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.DownLownDate))
 {
 if (objQxUserDownLoadLogEN.DownLownDate !=  null)
 {
 var strDownLownDate = objQxUserDownLoadLogEN.DownLownDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDownLownDate, conQxUserDownLoadLog.DownLownDate); //下载日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserDownLoadLog.DownLownDate); //下载日期
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.IsSuccess))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUserDownLoadLogEN.IsSuccess == true?"1":"0", conQxUserDownLoadLog.IsSuccess); //是否成功
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.LogInfo))
 {
 if (objQxUserDownLoadLogEN.LogInfo !=  null)
 {
 var strLogInfo = objQxUserDownLoadLogEN.LogInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogInfo, conQxUserDownLoadLog.LogInfo); //日志信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserDownLoadLog.LogInfo); //日志信息
 }
 }
 
 if (objQxUserDownLoadLogEN.IsUpdated(conQxUserDownLoadLog.Memo))
 {
 if (objQxUserDownLoadLogEN.Memo !=  null)
 {
 var strMemo = objQxUserDownLoadLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUserDownLoadLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserDownLoadLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserDownLoadLogId = '{0}'", objQxUserDownLoadLogEN.UserDownLoadLogId); 
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
 /// <param name = "strUserDownLoadLogId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strUserDownLoadLogId) 
{
CheckPrimaryKey(strUserDownLoadLogId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strUserDownLoadLogId,
};
 objSQL.ExecSP("QxUserDownLoadLog_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strUserDownLoadLogId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strUserDownLoadLogId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strUserDownLoadLogId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
//删除QxUserDownLoadLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserDownLoadLog where UserDownLoadLogId = " + "'"+ strUserDownLoadLogId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxUserDownLoadLog(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
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
//删除QxUserDownLoadLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserDownLoadLog where UserDownLoadLogId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strUserDownLoadLogId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strUserDownLoadLogId) 
{
CheckPrimaryKey(strUserDownLoadLogId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
//删除QxUserDownLoadLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserDownLoadLog where UserDownLoadLogId = " + "'"+ strUserDownLoadLogId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxUserDownLoadLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: DelQxUserDownLoadLog)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUserDownLoadLog where " + strCondition ;
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
public bool DelQxUserDownLoadLogWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxUserDownLoadLogDA: DelQxUserDownLoadLogWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUserDownLoadLog where " + strCondition ;
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
 /// <param name = "objQxUserDownLoadLogENS">源对象</param>
 /// <param name = "objQxUserDownLoadLogENT">目标对象</param>
public void CopyTo(clsQxUserDownLoadLogEN objQxUserDownLoadLogENS, clsQxUserDownLoadLogEN objQxUserDownLoadLogENT)
{
objQxUserDownLoadLogENT.UserDownLoadLogId = objQxUserDownLoadLogENS.UserDownLoadLogId; //用户下载日志Id
objQxUserDownLoadLogENT.UserId = objQxUserDownLoadLogENS.UserId; //用户ID
objQxUserDownLoadLogENT.PrjSiteId = objQxUserDownLoadLogENS.PrjSiteId; //工程站点Id
objQxUserDownLoadLogENT.DownLownDate = objQxUserDownLoadLogENS.DownLownDate; //下载日期
objQxUserDownLoadLogENT.IsSuccess = objQxUserDownLoadLogENS.IsSuccess; //是否成功
objQxUserDownLoadLogENT.LogInfo = objQxUserDownLoadLogENS.LogInfo; //日志信息
objQxUserDownLoadLogENT.Memo = objQxUserDownLoadLogENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxUserDownLoadLogEN.UserId, conQxUserDownLoadLog.UserId);
clsCheckSql.CheckFieldNotNull(objQxUserDownLoadLogEN.PrjSiteId, conQxUserDownLoadLog.PrjSiteId);
clsCheckSql.CheckFieldNotNull(objQxUserDownLoadLogEN.DownLownDate, conQxUserDownLoadLog.DownLownDate);
clsCheckSql.CheckFieldNotNull(objQxUserDownLoadLogEN.IsSuccess, conQxUserDownLoadLog.IsSuccess);
clsCheckSql.CheckFieldNotNull(objQxUserDownLoadLogEN.LogInfo, conQxUserDownLoadLog.LogInfo);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.UserDownLoadLogId, 8, conQxUserDownLoadLog.UserDownLoadLogId);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.UserId, 18, conQxUserDownLoadLog.UserId);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.PrjSiteId, 6, conQxUserDownLoadLog.PrjSiteId);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.DownLownDate, 20, conQxUserDownLoadLog.DownLownDate);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.LogInfo, 500, conQxUserDownLoadLog.LogInfo);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.Memo, 1000, conQxUserDownLoadLog.Memo);
//检查字段外键固定长度
 objQxUserDownLoadLogEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.UserId, 18, conQxUserDownLoadLog.UserId);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.PrjSiteId, 6, conQxUserDownLoadLog.PrjSiteId);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.DownLownDate, 20, conQxUserDownLoadLog.DownLownDate);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.LogInfo, 500, conQxUserDownLoadLog.LogInfo);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.Memo, 1000, conQxUserDownLoadLog.Memo);
//检查外键字段长度
 objQxUserDownLoadLogEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.UserDownLoadLogId, 8, conQxUserDownLoadLog.UserDownLoadLogId);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.UserId, 18, conQxUserDownLoadLog.UserId);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.PrjSiteId, 6, conQxUserDownLoadLog.PrjSiteId);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.DownLownDate, 20, conQxUserDownLoadLog.DownLownDate);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.LogInfo, 500, conQxUserDownLoadLog.LogInfo);
clsCheckSql.CheckFieldLen(objQxUserDownLoadLogEN.Memo, 1000, conQxUserDownLoadLog.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxUserDownLoadLogEN.UserDownLoadLogId, conQxUserDownLoadLog.UserDownLoadLogId);
clsCheckSql.CheckSqlInjection4Field(objQxUserDownLoadLogEN.UserId, conQxUserDownLoadLog.UserId);
clsCheckSql.CheckSqlInjection4Field(objQxUserDownLoadLogEN.PrjSiteId, conQxUserDownLoadLog.PrjSiteId);
clsCheckSql.CheckSqlInjection4Field(objQxUserDownLoadLogEN.DownLownDate, conQxUserDownLoadLog.DownLownDate);
clsCheckSql.CheckSqlInjection4Field(objQxUserDownLoadLogEN.LogInfo, conQxUserDownLoadLog.LogInfo);
clsCheckSql.CheckSqlInjection4Field(objQxUserDownLoadLogEN.Memo, conQxUserDownLoadLog.Memo);
//检查外键字段长度
 objQxUserDownLoadLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxUserDownLoadLog(用户下载日志),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserDownLoadLogEN.UserId);
 sbCondition.AppendFormat(" and PrjSiteId = '{0}'", objQxUserDownLoadLogEN.PrjSiteId);
 sbCondition.AppendFormat(" and DownLownDate = '{0}'", objQxUserDownLoadLogEN.DownLownDate);
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
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
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
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
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
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUserDownLoadLogEN._CurrTabName);
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
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUserDownLoadLogEN._CurrTabName, strCondition);
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
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
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
 objSQL = clsQxUserDownLoadLogDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}