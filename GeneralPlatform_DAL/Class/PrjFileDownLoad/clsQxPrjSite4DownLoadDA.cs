
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjSite4DownLoadDA
 表名:QxPrjSite4DownLoad(00140055)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:44:27
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
 /// 文件下载站点(QxPrjSite4DownLoad)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxPrjSite4DownLoadDA : clsCommBase4DA
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
 return clsQxPrjSite4DownLoadEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxPrjSite4DownLoadEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjSite4DownLoadEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxPrjSite4DownLoadEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxPrjSite4DownLoadEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPrjSiteId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPrjSiteId)
{
strPrjSiteId = strPrjSiteId.Replace("'", "''");
if (strPrjSiteId.Length > 6)
{
throw new Exception("(errid:Data000001)在表:QxPrjSite4DownLoad中,检查关键字,长度不正确!(clsQxPrjSite4DownLoadDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrjSiteId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxPrjSite4DownLoad中,关键字不能为空 或 null!(clsQxPrjSite4DownLoadDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjSiteId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxPrjSite4DownLoadDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strPrjSiteId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strPrjSiteId)
{
strPrjSiteId = strPrjSiteId.Replace("'", "''");
if (strPrjSiteId.Length > 6 + 4)
{
throw new Exception("(errid:Data000004)在表:QxPrjSite4DownLoad中,检查关键字,长度不正确!(简化版)(clsQxPrjSite4DownLoadDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrjSiteId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxPrjSite4DownLoad中,关键字不能为空 或 null!(clsQxPrjSite4DownLoadDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjSiteId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxPrjSite4DownLoadDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = "Select * from QxPrjSite4DownLoad where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxPrjSite4DownLoad");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxPrjSite4DownLoad_SelectByCond",values, "QxPrjSite4DownLoad");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjSite4DownLoad where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjSite4DownLoad");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From QxPrjSite4DownLoad Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjSite4DownLoad");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From QxPrjSite4DownLoad Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjSite4DownLoad");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From QxPrjSite4DownLoad Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjSite4DownLoad");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxPrjSite4DownLoad(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTable_QxPrjSite4DownLoad)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjSite4DownLoad where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjSite4DownLoad where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjSite4DownLoad where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjSite4DownLoad where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjSite4DownLoad.* from QxPrjSite4DownLoad Left Join {1} on {2} where {3} and QxPrjSite4DownLoad.PrjSiteId not in (Select top {5} QxPrjSite4DownLoad.PrjSiteId from QxPrjSite4DownLoad Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {2} PrjSiteId from QxPrjSite4DownLoad where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {3} PrjSiteId from QxPrjSite4DownLoad where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjSite4DownLoad.* from QxPrjSite4DownLoad Left Join {1} on {2} where {3} and QxPrjSite4DownLoad.PrjSiteId not in (Select top {5} QxPrjSite4DownLoad.PrjSiteId from QxPrjSite4DownLoad Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {2} PrjSiteId from QxPrjSite4DownLoad where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {3} PrjSiteId from QxPrjSite4DownLoad where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjSite4DownLoad.* from QxPrjSite4DownLoad Left Join {1} on {2} where {3} and QxPrjSite4DownLoad.PrjSiteId not in (Select top {5} QxPrjSite4DownLoad.PrjSiteId from QxPrjSite4DownLoad Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {2} PrjSiteId from QxPrjSite4DownLoad where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {3} PrjSiteId from QxPrjSite4DownLoad where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From QxPrjSite4DownLoad Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From QxPrjSite4DownLoad Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From QxPrjSite4DownLoad Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From QxPrjSite4DownLoad Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjSite4DownLoad_SelectByCond",values);
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
public List<clsQxPrjSite4DownLoadEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA:GetObjLst)", objException.Message));
}
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjSite4DownLoadDA: GetObjLst)", objException.Message));
}
objQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
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
public List<clsQxPrjSite4DownLoadEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjSite4DownLoadDA: GetObjLst)", objException.Message));
}
objQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxPrjSite4DownLoadEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA:GetObjLstBySP)", objException.Message));
}
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjSite4DownLoad_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjSite4DownLoadDA: GetObjLstBySP)", objException.Message));
}
objQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjSite4DownLoad(ref clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where PrjSiteId = " + "'"+ objQxPrjSite4DownLoadEN.PrjSiteId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxPrjSite4DownLoadEN.PrjSiteId = objDT.Rows[0][conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPrjSite4DownLoadEN.PrjSiteName = objDT.Rows[0][conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjSite4DownLoadEN.QxPrjId = objDT.Rows[0][conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjSite4DownLoadEN.FtpServer = objDT.Rows[0][conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjSite4DownLoadEN.FtpUserId = objDT.Rows[0][conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjSite4DownLoadEN.FtpUserPassword = objDT.Rows[0][conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjSite4DownLoadEN.UpdDate = objDT.Rows[0][conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjSite4DownLoadEN.UpdUserId = objDT.Rows[0][conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjSite4DownLoadEN.Memo = objDT.Rows[0][conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxPrjSite4DownLoadDA: GetQxPrjSite4DownLoad)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjSiteId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxPrjSite4DownLoadEN GetObjByPrjSiteId(string strPrjSiteId)
{
CheckPrimaryKey(strPrjSiteId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where PrjSiteId = " + "'"+ strPrjSiteId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
 objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxPrjSite4DownLoadDA: GetObjByPrjSiteId)", objException.Message));
}
return objQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxPrjSite4DownLoad_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjSite4DownLoadOneBySP(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxPrjSite4DownLoadEN.PrjSiteId
};
 objDT = objSQL.ExecSpReturnDT("QxPrjSite4DownLoad_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxPrjSite4DownLoadEN.PrjSiteId = objDT.Rows[0][conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id(字段类型:char,字段长度:6,是否可空:False)
 objQxPrjSite4DownLoadEN.PrjSiteName = objDT.Rows[0][conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjSite4DownLoadEN.QxPrjId = objDT.Rows[0][conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjSite4DownLoadEN.FtpServer = objDT.Rows[0][conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjSite4DownLoadEN.FtpUserId = objDT.Rows[0][conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjSite4DownLoadEN.FtpUserPassword = objDT.Rows[0][conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjSite4DownLoadEN.UpdDate = objDT.Rows[0][conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjSite4DownLoadEN.UpdUserId = objDT.Rows[0][conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjSite4DownLoadEN.Memo = objDT.Rows[0][conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjSite4DownLoadEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN()
{
PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(), //工程站点Id
PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(), //工程站点名
QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(), //项目Id
FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(), //Ftp服务器
FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(), //Ftp用户Id
FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(), //Ftp用户口令
UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim() //备注
};
objQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjSite4DownLoadEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxPrjSite4DownLoadDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjSite4DownLoadEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjSite4DownLoad_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN()
{
PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(), //工程站点Id
PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(), //工程站点名
QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(), //项目Id
FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(), //Ftp服务器
FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(), //Ftp用户Id
FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(), //Ftp用户口令
UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim() //备注
};
objQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxPrjSite4DownLoadEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxPrjSite4DownLoadDA: GetObjByDataRowQxPrjSite4DownLoad)", objException.Message));
}
objQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjSite4DownLoadEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxPrjSite4DownLoadEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxPrjSite4DownLoadDA: GetObjByDataRow)", objException.Message));
}
objQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjSite4DownLoadEN;
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
objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjSite4DownLoadEN._CurrTabName, conQxPrjSite4DownLoad.PrjSiteId, 6, "");
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
objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjSite4DownLoadEN._CurrTabName, conQxPrjSite4DownLoad.PrjSiteId, 6, strPrefix);
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
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PrjSiteId from QxPrjSite4DownLoad where " + strCondition;
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
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PrjSiteId from QxPrjSite4DownLoad where " + strCondition;
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
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPrjSiteId)
{
CheckPrimaryKey(strPrjSiteId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjSite4DownLoad", "PrjSiteId = " + "'"+ strPrjSiteId+"'"))
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
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strPrjSiteId)
{
CheckPrimaryKey(strPrjSiteId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strPrjSiteId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxPrjSite4DownLoad_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjSite4DownLoad", strCondition))
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
objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxPrjSite4DownLoad");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
 {
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjSite4DownLoadEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjSite4DownLoadEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjSite4DownLoad");
objRow = objDS.Tables["QxPrjSite4DownLoad"].NewRow();
objRow[conQxPrjSite4DownLoad.PrjSiteId] = objQxPrjSite4DownLoadEN.PrjSiteId; //工程站点Id
objRow[conQxPrjSite4DownLoad.PrjSiteName] = objQxPrjSite4DownLoadEN.PrjSiteName; //工程站点名
objRow[conQxPrjSite4DownLoad.QxPrjId] = objQxPrjSite4DownLoadEN.QxPrjId; //项目Id
objRow[conQxPrjSite4DownLoad.FtpServer] = objQxPrjSite4DownLoadEN.FtpServer; //Ftp服务器
objRow[conQxPrjSite4DownLoad.FtpUserId] = objQxPrjSite4DownLoadEN.FtpUserId; //Ftp用户Id
objRow[conQxPrjSite4DownLoad.FtpUserPassword] = objQxPrjSite4DownLoadEN.FtpUserPassword; //Ftp用户口令
objRow[conQxPrjSite4DownLoad.UpdDate] = objQxPrjSite4DownLoadEN.UpdDate; //修改日期
objRow[conQxPrjSite4DownLoad.UpdUserId] = objQxPrjSite4DownLoadEN.UpdUserId; //修改用户Id
 if (objQxPrjSite4DownLoadEN.Memo !=  "")
 {
objRow[conQxPrjSite4DownLoad.Memo] = objQxPrjSite4DownLoadEN.Memo; //备注
 }
objDS.Tables[clsQxPrjSite4DownLoadEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxPrjSite4DownLoadEN._CurrTabName);
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjSite4DownLoadEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjSite4DownLoadEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjSite4DownLoadEN.PrjSiteId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.PrjSiteId);
 var strPrjSiteId = objQxPrjSite4DownLoadEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.PrjSiteName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.PrjSiteName);
 var strPrjSiteName = objQxPrjSite4DownLoadEN.PrjSiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteName + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.QxPrjId);
 var strQxPrjId = objQxPrjSite4DownLoadEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpServer !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpServer);
 var strFtpServer = objQxPrjSite4DownLoadEN.FtpServer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpServer + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpUserId);
 var strFtpUserId = objQxPrjSite4DownLoadEN.FtpUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpUserId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpUserPassword !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpUserPassword);
 var strFtpUserPassword = objQxPrjSite4DownLoadEN.FtpUserPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpUserPassword + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.UpdDate);
 var strUpdDate = objQxPrjSite4DownLoadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.UpdUserId);
 var strUpdUserId = objQxPrjSite4DownLoadEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.Memo);
 var strMemo = objQxPrjSite4DownLoadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjSite4DownLoad");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjSite4DownLoadEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjSite4DownLoadEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjSite4DownLoadEN.PrjSiteId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.PrjSiteId);
 var strPrjSiteId = objQxPrjSite4DownLoadEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.PrjSiteName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.PrjSiteName);
 var strPrjSiteName = objQxPrjSite4DownLoadEN.PrjSiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteName + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.QxPrjId);
 var strQxPrjId = objQxPrjSite4DownLoadEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpServer !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpServer);
 var strFtpServer = objQxPrjSite4DownLoadEN.FtpServer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpServer + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpUserId);
 var strFtpUserId = objQxPrjSite4DownLoadEN.FtpUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpUserId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpUserPassword !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpUserPassword);
 var strFtpUserPassword = objQxPrjSite4DownLoadEN.FtpUserPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpUserPassword + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.UpdDate);
 var strUpdDate = objQxPrjSite4DownLoadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.UpdUserId);
 var strUpdUserId = objQxPrjSite4DownLoadEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.Memo);
 var strMemo = objQxPrjSite4DownLoadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjSite4DownLoad");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxPrjSite4DownLoadEN.PrjSiteId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjSite4DownLoadEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjSite4DownLoadEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjSite4DownLoadEN.PrjSiteId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.PrjSiteId);
 var strPrjSiteId = objQxPrjSite4DownLoadEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.PrjSiteName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.PrjSiteName);
 var strPrjSiteName = objQxPrjSite4DownLoadEN.PrjSiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteName + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.QxPrjId);
 var strQxPrjId = objQxPrjSite4DownLoadEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpServer !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpServer);
 var strFtpServer = objQxPrjSite4DownLoadEN.FtpServer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpServer + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpUserId);
 var strFtpUserId = objQxPrjSite4DownLoadEN.FtpUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpUserId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpUserPassword !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpUserPassword);
 var strFtpUserPassword = objQxPrjSite4DownLoadEN.FtpUserPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpUserPassword + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.UpdDate);
 var strUpdDate = objQxPrjSite4DownLoadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.UpdUserId);
 var strUpdUserId = objQxPrjSite4DownLoadEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.Memo);
 var strMemo = objQxPrjSite4DownLoadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjSite4DownLoad");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objQxPrjSite4DownLoadEN.PrjSiteId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjSite4DownLoadEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjSite4DownLoadEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjSite4DownLoadEN.PrjSiteId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.PrjSiteId);
 var strPrjSiteId = objQxPrjSite4DownLoadEN.PrjSiteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.PrjSiteName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.PrjSiteName);
 var strPrjSiteName = objQxPrjSite4DownLoadEN.PrjSiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjSiteName + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.QxPrjId);
 var strQxPrjId = objQxPrjSite4DownLoadEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpServer !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpServer);
 var strFtpServer = objQxPrjSite4DownLoadEN.FtpServer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpServer + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpUserId);
 var strFtpUserId = objQxPrjSite4DownLoadEN.FtpUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpUserId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.FtpUserPassword !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.FtpUserPassword);
 var strFtpUserPassword = objQxPrjSite4DownLoadEN.FtpUserPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFtpUserPassword + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.UpdDate);
 var strUpdDate = objQxPrjSite4DownLoadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.UpdUserId);
 var strUpdUserId = objQxPrjSite4DownLoadEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjSite4DownLoadEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjSite4DownLoad.Memo);
 var strMemo = objQxPrjSite4DownLoadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjSite4DownLoad");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxPrjSite4DownLoadBySP(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
//通过存储过程来
//直接使用
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjSite4DownLoadEN.PrjSiteId,
 objQxPrjSite4DownLoadEN.PrjSiteName,
 objQxPrjSite4DownLoadEN.QxPrjId,
 objQxPrjSite4DownLoadEN.FtpServer,
 objQxPrjSite4DownLoadEN.FtpUserId,
 objQxPrjSite4DownLoadEN.FtpUserPassword,
 objQxPrjSite4DownLoadEN.UpdDate,
 objQxPrjSite4DownLoadEN.UpdUserId,
objQxPrjSite4DownLoadEN.Memo
};
 objSQL.ExecSP("QxPrjSite4DownLoad_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxPrjSite4DownLoads(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where PrjSiteId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjSite4DownLoad");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPrjSiteId = oRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim();
if (IsExist(strPrjSiteId))
{
 string strResult = "关键字变量值为:" + string.Format("PrjSiteId = {0}", strPrjSiteId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxPrjSite4DownLoadEN._CurrTabName ].NewRow();
objRow[conQxPrjSite4DownLoad.PrjSiteId] = oRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objRow[conQxPrjSite4DownLoad.PrjSiteName] = oRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objRow[conQxPrjSite4DownLoad.QxPrjId] = oRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxPrjSite4DownLoad.FtpServer] = oRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objRow[conQxPrjSite4DownLoad.FtpUserId] = oRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objRow[conQxPrjSite4DownLoad.FtpUserPassword] = oRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objRow[conQxPrjSite4DownLoad.UpdDate] = oRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objRow[conQxPrjSite4DownLoad.UpdUserId] = oRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conQxPrjSite4DownLoad.Memo] = oRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxPrjSite4DownLoadEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxPrjSite4DownLoadEN._CurrTabName);
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjSite4DownLoadEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjSite4DownLoadEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from QxPrjSite4DownLoad where PrjSiteId = " + "'"+ objQxPrjSite4DownLoadEN.PrjSiteId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxPrjSite4DownLoadEN._CurrTabName);
if (objDS.Tables[clsQxPrjSite4DownLoadEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PrjSiteId = " + "'"+ objQxPrjSite4DownLoadEN.PrjSiteId+"'");
return false;
}
objRow = objDS.Tables[clsQxPrjSite4DownLoadEN._CurrTabName].Rows[0];
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.PrjSiteId))
 {
objRow[conQxPrjSite4DownLoad.PrjSiteId] = objQxPrjSite4DownLoadEN.PrjSiteId; //工程站点Id
 }
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.PrjSiteName))
 {
objRow[conQxPrjSite4DownLoad.PrjSiteName] = objQxPrjSite4DownLoadEN.PrjSiteName; //工程站点名
 }
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.QxPrjId))
 {
objRow[conQxPrjSite4DownLoad.QxPrjId] = objQxPrjSite4DownLoadEN.QxPrjId; //项目Id
 }
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpServer))
 {
objRow[conQxPrjSite4DownLoad.FtpServer] = objQxPrjSite4DownLoadEN.FtpServer; //Ftp服务器
 }
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpUserId))
 {
objRow[conQxPrjSite4DownLoad.FtpUserId] = objQxPrjSite4DownLoadEN.FtpUserId; //Ftp用户Id
 }
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpUserPassword))
 {
objRow[conQxPrjSite4DownLoad.FtpUserPassword] = objQxPrjSite4DownLoadEN.FtpUserPassword; //Ftp用户口令
 }
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.UpdDate))
 {
objRow[conQxPrjSite4DownLoad.UpdDate] = objQxPrjSite4DownLoadEN.UpdDate; //修改日期
 }
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.UpdUserId))
 {
objRow[conQxPrjSite4DownLoad.UpdUserId] = objQxPrjSite4DownLoadEN.UpdUserId; //修改用户Id
 }
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.Memo))
 {
objRow[conQxPrjSite4DownLoad.Memo] = objQxPrjSite4DownLoadEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxPrjSite4DownLoadEN._CurrTabName);
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
public bool UpdateBySP(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjSite4DownLoadEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjSite4DownLoadEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjSite4DownLoadEN.PrjSiteId,
 objQxPrjSite4DownLoadEN.PrjSiteName,
 objQxPrjSite4DownLoadEN.QxPrjId,
 objQxPrjSite4DownLoadEN.FtpServer,
 objQxPrjSite4DownLoadEN.FtpUserId,
 objQxPrjSite4DownLoadEN.FtpUserPassword,
 objQxPrjSite4DownLoadEN.UpdDate,
 objQxPrjSite4DownLoadEN.UpdUserId,
 objQxPrjSite4DownLoadEN.Memo
};
 objSQL.ExecSP("QxPrjSite4DownLoad_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjSite4DownLoadEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjSite4DownLoadEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxPrjSite4DownLoad Set ");
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.PrjSiteName))
 {
 if (objQxPrjSite4DownLoadEN.PrjSiteName !=  null)
 {
 var strPrjSiteName = objQxPrjSite4DownLoadEN.PrjSiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjSiteName, conQxPrjSite4DownLoad.PrjSiteName); //工程站点名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.PrjSiteName); //工程站点名
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.QxPrjId))
 {
 if (objQxPrjSite4DownLoadEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjSite4DownLoadEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjSite4DownLoad.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpServer))
 {
 if (objQxPrjSite4DownLoadEN.FtpServer !=  null)
 {
 var strFtpServer = objQxPrjSite4DownLoadEN.FtpServer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFtpServer, conQxPrjSite4DownLoad.FtpServer); //Ftp服务器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.FtpServer); //Ftp服务器
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpUserId))
 {
 if (objQxPrjSite4DownLoadEN.FtpUserId !=  null)
 {
 var strFtpUserId = objQxPrjSite4DownLoadEN.FtpUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFtpUserId, conQxPrjSite4DownLoad.FtpUserId); //Ftp用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.FtpUserId); //Ftp用户Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpUserPassword))
 {
 if (objQxPrjSite4DownLoadEN.FtpUserPassword !=  null)
 {
 var strFtpUserPassword = objQxPrjSite4DownLoadEN.FtpUserPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFtpUserPassword, conQxPrjSite4DownLoad.FtpUserPassword); //Ftp用户口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.FtpUserPassword); //Ftp用户口令
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.UpdDate))
 {
 if (objQxPrjSite4DownLoadEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjSite4DownLoadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjSite4DownLoad.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.UpdUserId))
 {
 if (objQxPrjSite4DownLoadEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjSite4DownLoadEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjSite4DownLoad.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.Memo))
 {
 if (objQxPrjSite4DownLoadEN.Memo !=  null)
 {
 var strMemo = objQxPrjSite4DownLoadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjSite4DownLoad.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrjSiteId = '{0}'", objQxPrjSite4DownLoadEN.PrjSiteId); 
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strCondition)
{
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjSite4DownLoadEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjSite4DownLoadEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjSite4DownLoad Set ");
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.PrjSiteName))
 {
 if (objQxPrjSite4DownLoadEN.PrjSiteName !=  null)
 {
 var strPrjSiteName = objQxPrjSite4DownLoadEN.PrjSiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjSiteName = '{0}',", strPrjSiteName); //工程站点名
 }
 else
 {
 sbSQL.Append(" PrjSiteName = null,"); //工程站点名
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.QxPrjId))
 {
 if (objQxPrjSite4DownLoadEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjSite4DownLoadEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpServer))
 {
 if (objQxPrjSite4DownLoadEN.FtpServer !=  null)
 {
 var strFtpServer = objQxPrjSite4DownLoadEN.FtpServer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FtpServer = '{0}',", strFtpServer); //Ftp服务器
 }
 else
 {
 sbSQL.Append(" FtpServer = null,"); //Ftp服务器
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpUserId))
 {
 if (objQxPrjSite4DownLoadEN.FtpUserId !=  null)
 {
 var strFtpUserId = objQxPrjSite4DownLoadEN.FtpUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FtpUserId = '{0}',", strFtpUserId); //Ftp用户Id
 }
 else
 {
 sbSQL.Append(" FtpUserId = null,"); //Ftp用户Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpUserPassword))
 {
 if (objQxPrjSite4DownLoadEN.FtpUserPassword !=  null)
 {
 var strFtpUserPassword = objQxPrjSite4DownLoadEN.FtpUserPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FtpUserPassword = '{0}',", strFtpUserPassword); //Ftp用户口令
 }
 else
 {
 sbSQL.Append(" FtpUserPassword = null,"); //Ftp用户口令
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.UpdDate))
 {
 if (objQxPrjSite4DownLoadEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjSite4DownLoadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.UpdUserId))
 {
 if (objQxPrjSite4DownLoadEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjSite4DownLoadEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.Memo))
 {
 if (objQxPrjSite4DownLoadEN.Memo !=  null)
 {
 var strMemo = objQxPrjSite4DownLoadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjSite4DownLoadEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjSite4DownLoadEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjSite4DownLoad Set ");
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.PrjSiteName))
 {
 if (objQxPrjSite4DownLoadEN.PrjSiteName !=  null)
 {
 var strPrjSiteName = objQxPrjSite4DownLoadEN.PrjSiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjSiteName = '{0}',", strPrjSiteName); //工程站点名
 }
 else
 {
 sbSQL.Append(" PrjSiteName = null,"); //工程站点名
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.QxPrjId))
 {
 if (objQxPrjSite4DownLoadEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjSite4DownLoadEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpServer))
 {
 if (objQxPrjSite4DownLoadEN.FtpServer !=  null)
 {
 var strFtpServer = objQxPrjSite4DownLoadEN.FtpServer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FtpServer = '{0}',", strFtpServer); //Ftp服务器
 }
 else
 {
 sbSQL.Append(" FtpServer = null,"); //Ftp服务器
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpUserId))
 {
 if (objQxPrjSite4DownLoadEN.FtpUserId !=  null)
 {
 var strFtpUserId = objQxPrjSite4DownLoadEN.FtpUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FtpUserId = '{0}',", strFtpUserId); //Ftp用户Id
 }
 else
 {
 sbSQL.Append(" FtpUserId = null,"); //Ftp用户Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpUserPassword))
 {
 if (objQxPrjSite4DownLoadEN.FtpUserPassword !=  null)
 {
 var strFtpUserPassword = objQxPrjSite4DownLoadEN.FtpUserPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FtpUserPassword = '{0}',", strFtpUserPassword); //Ftp用户口令
 }
 else
 {
 sbSQL.Append(" FtpUserPassword = null,"); //Ftp用户口令
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.UpdDate))
 {
 if (objQxPrjSite4DownLoadEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjSite4DownLoadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.UpdUserId))
 {
 if (objQxPrjSite4DownLoadEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjSite4DownLoadEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.Memo))
 {
 if (objQxPrjSite4DownLoadEN.Memo !=  null)
 {
 var strMemo = objQxPrjSite4DownLoadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjSite4DownLoadEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjSite4DownLoadEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjSite4DownLoad Set ");
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.PrjSiteName))
 {
 if (objQxPrjSite4DownLoadEN.PrjSiteName !=  null)
 {
 var strPrjSiteName = objQxPrjSite4DownLoadEN.PrjSiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjSiteName, conQxPrjSite4DownLoad.PrjSiteName); //工程站点名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.PrjSiteName); //工程站点名
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.QxPrjId))
 {
 if (objQxPrjSite4DownLoadEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjSite4DownLoadEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjSite4DownLoad.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpServer))
 {
 if (objQxPrjSite4DownLoadEN.FtpServer !=  null)
 {
 var strFtpServer = objQxPrjSite4DownLoadEN.FtpServer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFtpServer, conQxPrjSite4DownLoad.FtpServer); //Ftp服务器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.FtpServer); //Ftp服务器
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpUserId))
 {
 if (objQxPrjSite4DownLoadEN.FtpUserId !=  null)
 {
 var strFtpUserId = objQxPrjSite4DownLoadEN.FtpUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFtpUserId, conQxPrjSite4DownLoad.FtpUserId); //Ftp用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.FtpUserId); //Ftp用户Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.FtpUserPassword))
 {
 if (objQxPrjSite4DownLoadEN.FtpUserPassword !=  null)
 {
 var strFtpUserPassword = objQxPrjSite4DownLoadEN.FtpUserPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFtpUserPassword, conQxPrjSite4DownLoad.FtpUserPassword); //Ftp用户口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.FtpUserPassword); //Ftp用户口令
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.UpdDate))
 {
 if (objQxPrjSite4DownLoadEN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjSite4DownLoadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjSite4DownLoad.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.UpdUserId))
 {
 if (objQxPrjSite4DownLoadEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjSite4DownLoadEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjSite4DownLoad.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjSite4DownLoadEN.IsUpdated(conQxPrjSite4DownLoad.Memo))
 {
 if (objQxPrjSite4DownLoadEN.Memo !=  null)
 {
 var strMemo = objQxPrjSite4DownLoadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjSite4DownLoad.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjSite4DownLoad.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrjSiteId = '{0}'", objQxPrjSite4DownLoadEN.PrjSiteId); 
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
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPrjSiteId) 
{
CheckPrimaryKey(strPrjSiteId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPrjSiteId,
};
 objSQL.ExecSP("QxPrjSite4DownLoad_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPrjSiteId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPrjSiteId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
//删除QxPrjSite4DownLoad本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjSite4DownLoad where PrjSiteId = " + "'"+ strPrjSiteId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxPrjSite4DownLoad(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
//删除QxPrjSite4DownLoad本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjSite4DownLoad where PrjSiteId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPrjSiteId) 
{
CheckPrimaryKey(strPrjSiteId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
//删除QxPrjSite4DownLoad本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjSite4DownLoad where PrjSiteId = " + "'"+ strPrjSiteId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxPrjSite4DownLoad(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: DelQxPrjSite4DownLoad)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjSite4DownLoad where " + strCondition ;
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
public bool DelQxPrjSite4DownLoadWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadDA: DelQxPrjSite4DownLoadWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjSite4DownLoad where " + strCondition ;
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
 /// <param name = "objQxPrjSite4DownLoadENS">源对象</param>
 /// <param name = "objQxPrjSite4DownLoadENT">目标对象</param>
public void CopyTo(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadENS, clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadENT)
{
objQxPrjSite4DownLoadENT.PrjSiteId = objQxPrjSite4DownLoadENS.PrjSiteId; //工程站点Id
objQxPrjSite4DownLoadENT.PrjSiteName = objQxPrjSite4DownLoadENS.PrjSiteName; //工程站点名
objQxPrjSite4DownLoadENT.QxPrjId = objQxPrjSite4DownLoadENS.QxPrjId; //项目Id
objQxPrjSite4DownLoadENT.FtpServer = objQxPrjSite4DownLoadENS.FtpServer; //Ftp服务器
objQxPrjSite4DownLoadENT.FtpUserId = objQxPrjSite4DownLoadENS.FtpUserId; //Ftp用户Id
objQxPrjSite4DownLoadENT.FtpUserPassword = objQxPrjSite4DownLoadENS.FtpUserPassword; //Ftp用户口令
objQxPrjSite4DownLoadENT.UpdDate = objQxPrjSite4DownLoadENS.UpdDate; //修改日期
objQxPrjSite4DownLoadENT.UpdUserId = objQxPrjSite4DownLoadENS.UpdUserId; //修改用户Id
objQxPrjSite4DownLoadENT.Memo = objQxPrjSite4DownLoadENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxPrjSite4DownLoadEN.PrjSiteName, conQxPrjSite4DownLoad.PrjSiteName);
clsCheckSql.CheckFieldNotNull(objQxPrjSite4DownLoadEN.QxPrjId, conQxPrjSite4DownLoad.QxPrjId);
clsCheckSql.CheckFieldNotNull(objQxPrjSite4DownLoadEN.FtpServer, conQxPrjSite4DownLoad.FtpServer);
clsCheckSql.CheckFieldNotNull(objQxPrjSite4DownLoadEN.FtpUserId, conQxPrjSite4DownLoad.FtpUserId);
clsCheckSql.CheckFieldNotNull(objQxPrjSite4DownLoadEN.FtpUserPassword, conQxPrjSite4DownLoad.FtpUserPassword);
clsCheckSql.CheckFieldNotNull(objQxPrjSite4DownLoadEN.UpdDate, conQxPrjSite4DownLoad.UpdDate);
clsCheckSql.CheckFieldNotNull(objQxPrjSite4DownLoadEN.UpdUserId, conQxPrjSite4DownLoad.UpdUserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.PrjSiteId, 6, conQxPrjSite4DownLoad.PrjSiteId);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.PrjSiteName, 50, conQxPrjSite4DownLoad.PrjSiteName);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.QxPrjId, 4, conQxPrjSite4DownLoad.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.FtpServer, 50, conQxPrjSite4DownLoad.FtpServer);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.FtpUserId, 20, conQxPrjSite4DownLoad.FtpUserId);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.FtpUserPassword, 50, conQxPrjSite4DownLoad.FtpUserPassword);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.UpdDate, 20, conQxPrjSite4DownLoad.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.UpdUserId, 20, conQxPrjSite4DownLoad.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.Memo, 1000, conQxPrjSite4DownLoad.Memo);
//检查字段外键固定长度
 objQxPrjSite4DownLoadEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.PrjSiteName, 50, conQxPrjSite4DownLoad.PrjSiteName);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.QxPrjId, 4, conQxPrjSite4DownLoad.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.FtpServer, 50, conQxPrjSite4DownLoad.FtpServer);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.FtpUserId, 20, conQxPrjSite4DownLoad.FtpUserId);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.FtpUserPassword, 50, conQxPrjSite4DownLoad.FtpUserPassword);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.UpdDate, 20, conQxPrjSite4DownLoad.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.UpdUserId, 20, conQxPrjSite4DownLoad.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.Memo, 1000, conQxPrjSite4DownLoad.Memo);
//检查外键字段长度
 objQxPrjSite4DownLoadEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.PrjSiteId, 6, conQxPrjSite4DownLoad.PrjSiteId);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.PrjSiteName, 50, conQxPrjSite4DownLoad.PrjSiteName);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.QxPrjId, 4, conQxPrjSite4DownLoad.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.FtpServer, 50, conQxPrjSite4DownLoad.FtpServer);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.FtpUserId, 20, conQxPrjSite4DownLoad.FtpUserId);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.FtpUserPassword, 50, conQxPrjSite4DownLoad.FtpUserPassword);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.UpdDate, 20, conQxPrjSite4DownLoad.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.UpdUserId, 20, conQxPrjSite4DownLoad.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjSite4DownLoadEN.Memo, 1000, conQxPrjSite4DownLoad.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxPrjSite4DownLoadEN.PrjSiteId, conQxPrjSite4DownLoad.PrjSiteId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjSite4DownLoadEN.PrjSiteName, conQxPrjSite4DownLoad.PrjSiteName);
clsCheckSql.CheckSqlInjection4Field(objQxPrjSite4DownLoadEN.QxPrjId, conQxPrjSite4DownLoad.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjSite4DownLoadEN.FtpServer, conQxPrjSite4DownLoad.FtpServer);
clsCheckSql.CheckSqlInjection4Field(objQxPrjSite4DownLoadEN.FtpUserId, conQxPrjSite4DownLoad.FtpUserId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjSite4DownLoadEN.FtpUserPassword, conQxPrjSite4DownLoad.FtpUserPassword);
clsCheckSql.CheckSqlInjection4Field(objQxPrjSite4DownLoadEN.UpdDate, conQxPrjSite4DownLoad.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxPrjSite4DownLoadEN.UpdUserId, conQxPrjSite4DownLoad.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjSite4DownLoadEN.Memo, conQxPrjSite4DownLoad.Memo);
//检查外键字段长度
 objQxPrjSite4DownLoadEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPrjSiteId()
{
//获取某学院所有专业信息
string strSQL = "select PrjSiteId, PrjSiteName from QxPrjSite4DownLoad ";
 clsSpecSQLforSql mySql = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxPrjSite4DownLoad(文件下载站点),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjSiteName = '{0}'", objQxPrjSite4DownLoadEN.PrjSiteName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjSite4DownLoadEN.QxPrjId);
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
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjSite4DownLoadEN._CurrTabName);
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
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjSite4DownLoadEN._CurrTabName, strCondition);
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
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
 objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}