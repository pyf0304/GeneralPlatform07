
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjSite4DownLoadDA
 表名:vQxPrjSite4DownLoad(00140061)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:46:31
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
 /// v文件下载站点(vQxPrjSite4DownLoad)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxPrjSite4DownLoadDA : clsCommBase4DA
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
 return clsvQxPrjSite4DownLoadEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxPrjSite4DownLoadEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjSite4DownLoadEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxPrjSite4DownLoadEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxPrjSite4DownLoadEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vQxPrjSite4DownLoad中,检查关键字,长度不正确!(clsvQxPrjSite4DownLoadDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrjSiteId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxPrjSite4DownLoad中,关键字不能为空 或 null!(clsvQxPrjSite4DownLoadDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjSiteId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxPrjSite4DownLoadDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception("(errid:Data000004)在表:vQxPrjSite4DownLoad中,检查关键字,长度不正确!(简化版)(clsvQxPrjSite4DownLoadDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrjSiteId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:vQxPrjSite4DownLoad中,关键字不能为空 或 null!(clsvQxPrjSite4DownLoadDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjSiteId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsvQxPrjSite4DownLoadDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = "Select * from vQxPrjSite4DownLoad where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjSite4DownLoad");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxPrjSite4DownLoad_SelectByCond",values, "vQxPrjSite4DownLoad");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjSite4DownLoad where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjSite4DownLoad");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From vQxPrjSite4DownLoad Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjSite4DownLoad");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From vQxPrjSite4DownLoad Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjSite4DownLoad");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From vQxPrjSite4DownLoad Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjSite4DownLoad");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjSite4DownLoad where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxPrjSite4DownLoad(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTable_vQxPrjSite4DownLoad)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjSite4DownLoad where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjSite4DownLoad where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjSite4DownLoad where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjSite4DownLoad where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjSite4DownLoad where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjSite4DownLoad where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjSite4DownLoad where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjSite4DownLoad.* from vQxPrjSite4DownLoad Left Join {1} on {2} where {3} and vQxPrjSite4DownLoad.PrjSiteId not in (Select top {5} vQxPrjSite4DownLoad.PrjSiteId from vQxPrjSite4DownLoad Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {2} PrjSiteId from vQxPrjSite4DownLoad where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {3} PrjSiteId from vQxPrjSite4DownLoad where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjSite4DownLoad.* from vQxPrjSite4DownLoad Left Join {1} on {2} where {3} and vQxPrjSite4DownLoad.PrjSiteId not in (Select top {5} vQxPrjSite4DownLoad.PrjSiteId from vQxPrjSite4DownLoad Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {2} PrjSiteId from vQxPrjSite4DownLoad where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {3} PrjSiteId from vQxPrjSite4DownLoad where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjSite4DownLoad.* from vQxPrjSite4DownLoad Left Join {1} on {2} where {3} and vQxPrjSite4DownLoad.PrjSiteId not in (Select top {5} vQxPrjSite4DownLoad.PrjSiteId from vQxPrjSite4DownLoad Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {2} PrjSiteId from vQxPrjSite4DownLoad where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjSite4DownLoad where {1} and PrjSiteId not in (Select top {3} PrjSiteId from vQxPrjSite4DownLoad where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From vQxPrjSite4DownLoad Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From vQxPrjSite4DownLoad Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From vQxPrjSite4DownLoad Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjSite4DownLoad a where {0} And a.PrjSiteId not in (Select Top {2} PrjSiteId From vQxPrjSite4DownLoad Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoadByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjSite4DownLoad where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjSite4DownLoad_SelectByCond",values);
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
public List<clsvQxPrjSite4DownLoadEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA:GetObjLst)", objException.Message));
}
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjSite4DownLoad where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjSite4DownLoadDA: GetObjLst)", objException.Message));
}
objvQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
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
public List<clsvQxPrjSite4DownLoadEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjSite4DownLoadDA: GetObjLst)", objException.Message));
}
objvQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxPrjSite4DownLoadEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjSite4DownLoad_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjSite4DownLoadDA: GetObjLstBySP)", objException.Message));
}
objvQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjSite4DownLoad(ref clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjSite4DownLoad where PrjSiteId = " + "'"+ objvQxPrjSite4DownLoadEN.PrjSiteId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxPrjSite4DownLoadEN.PrjSiteId = objDT.Rows[0][convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id(字段类型:char,字段长度:6,是否可空:False)
 objvQxPrjSite4DownLoadEN.PrjSiteName = objDT.Rows[0][convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjSite4DownLoadEN.QxPrjId = objDT.Rows[0][convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjSite4DownLoadEN.PrjName = objDT.Rows[0][convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjSite4DownLoadEN.FtpServer = objDT.Rows[0][convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjSite4DownLoadEN.FtpUserId = objDT.Rows[0][convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjSite4DownLoadEN.FtpUserPassword = objDT.Rows[0][convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjSite4DownLoadEN.UpdUserId = objDT.Rows[0][convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjSite4DownLoadEN.UpdDate = objDT.Rows[0][convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjSite4DownLoadEN.Memo = objDT.Rows[0][convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxPrjSite4DownLoadDA: GetvQxPrjSite4DownLoad)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjSiteId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxPrjSite4DownLoadEN GetObjByPrjSiteId(string strPrjSiteId)
{
CheckPrimaryKey(strPrjSiteId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjSite4DownLoad where PrjSiteId = " + "'"+ strPrjSiteId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
 objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id(字段类型:char,字段长度:6,是否可空:False)
 objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxPrjSite4DownLoadDA: GetObjByPrjSiteId)", objException.Message));
}
return objvQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxPrjSite4DownLoad_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjSite4DownLoadOneBySP(clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxPrjSite4DownLoadEN.PrjSiteId
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjSite4DownLoad_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxPrjSite4DownLoadEN.PrjSiteId = objDT.Rows[0][convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id(字段类型:char,字段长度:6,是否可空:False)
 objvQxPrjSite4DownLoadEN.PrjSiteName = objDT.Rows[0][convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjSite4DownLoadEN.QxPrjId = objDT.Rows[0][convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjSite4DownLoadEN.PrjName = objDT.Rows[0][convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjSite4DownLoadEN.FtpServer = objDT.Rows[0][convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjSite4DownLoadEN.FtpUserId = objDT.Rows[0][convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjSite4DownLoadEN.FtpUserPassword = objDT.Rows[0][convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxPrjSite4DownLoadEN.UpdUserId = objDT.Rows[0][convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjSite4DownLoadEN.UpdDate = objDT.Rows[0][convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjSite4DownLoadEN.Memo = objDT.Rows[0][convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjSite4DownLoadEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjSite4DownLoad where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN()
{
PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(), //工程站点Id
PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(), //工程站点名
QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(), //工程名
FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(), //Ftp服务器
FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(), //Ftp用户Id
FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(), //Ftp用户口令
UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim() //备注
};
objvQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjSite4DownLoadEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxPrjSite4DownLoadDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjSite4DownLoadEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjSite4DownLoad_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN()
{
PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(), //工程站点Id
PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(), //工程站点名
QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(), //工程名
FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(), //Ftp服务器
FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(), //Ftp用户Id
FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(), //Ftp用户口令
UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim() //备注
};
objvQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxPrjSite4DownLoadEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxPrjSite4DownLoadDA: GetObjByDataRowvQxPrjSite4DownLoad)", objException.Message));
}
objvQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjSite4DownLoadEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxPrjSite4DownLoadEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxPrjSite4DownLoadDA: GetObjByDataRow)", objException.Message));
}
objvQxPrjSite4DownLoadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjSite4DownLoadEN;
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
objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjSite4DownLoadEN._CurrTabName, convQxPrjSite4DownLoad.PrjSiteId, 6, "");
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
objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjSite4DownLoadEN._CurrTabName, convQxPrjSite4DownLoad.PrjSiteId, 6, strPrefix);
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
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PrjSiteId from vQxPrjSite4DownLoad where " + strCondition;
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
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PrjSiteId from vQxPrjSite4DownLoad where " + strCondition;
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
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjSite4DownLoad", "PrjSiteId = " + "'"+ strPrjSiteId+"'"))
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
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strPrjSiteId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxPrjSite4DownLoad_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjSite4DownLoad", strCondition))
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
objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxPrjSite4DownLoad");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadENS">源对象</param>
 /// <param name = "objvQxPrjSite4DownLoadENT">目标对象</param>
public void CopyTo(clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadENS, clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadENT)
{
objvQxPrjSite4DownLoadENT.PrjSiteId = objvQxPrjSite4DownLoadENS.PrjSiteId; //工程站点Id
objvQxPrjSite4DownLoadENT.PrjSiteName = objvQxPrjSite4DownLoadENS.PrjSiteName; //工程站点名
objvQxPrjSite4DownLoadENT.QxPrjId = objvQxPrjSite4DownLoadENS.QxPrjId; //项目Id
objvQxPrjSite4DownLoadENT.PrjName = objvQxPrjSite4DownLoadENS.PrjName; //工程名
objvQxPrjSite4DownLoadENT.FtpServer = objvQxPrjSite4DownLoadENS.FtpServer; //Ftp服务器
objvQxPrjSite4DownLoadENT.FtpUserId = objvQxPrjSite4DownLoadENS.FtpUserId; //Ftp用户Id
objvQxPrjSite4DownLoadENT.FtpUserPassword = objvQxPrjSite4DownLoadENS.FtpUserPassword; //Ftp用户口令
objvQxPrjSite4DownLoadENT.UpdUserId = objvQxPrjSite4DownLoadENS.UpdUserId; //修改用户Id
objvQxPrjSite4DownLoadENT.UpdDate = objvQxPrjSite4DownLoadENS.UpdDate; //修改日期
objvQxPrjSite4DownLoadENT.Memo = objvQxPrjSite4DownLoadENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxPrjSite4DownLoadEN.PrjSiteId, 6, convQxPrjSite4DownLoad.PrjSiteId);
clsCheckSql.CheckFieldLen(objvQxPrjSite4DownLoadEN.PrjSiteName, 50, convQxPrjSite4DownLoad.PrjSiteName);
clsCheckSql.CheckFieldLen(objvQxPrjSite4DownLoadEN.QxPrjId, 4, convQxPrjSite4DownLoad.QxPrjId);
clsCheckSql.CheckFieldLen(objvQxPrjSite4DownLoadEN.PrjName, 30, convQxPrjSite4DownLoad.PrjName);
clsCheckSql.CheckFieldLen(objvQxPrjSite4DownLoadEN.FtpServer, 50, convQxPrjSite4DownLoad.FtpServer);
clsCheckSql.CheckFieldLen(objvQxPrjSite4DownLoadEN.FtpUserId, 20, convQxPrjSite4DownLoad.FtpUserId);
clsCheckSql.CheckFieldLen(objvQxPrjSite4DownLoadEN.FtpUserPassword, 50, convQxPrjSite4DownLoad.FtpUserPassword);
clsCheckSql.CheckFieldLen(objvQxPrjSite4DownLoadEN.UpdUserId, 20, convQxPrjSite4DownLoad.UpdUserId);
clsCheckSql.CheckFieldLen(objvQxPrjSite4DownLoadEN.UpdDate, 20, convQxPrjSite4DownLoad.UpdDate);
clsCheckSql.CheckFieldLen(objvQxPrjSite4DownLoadEN.Memo, 1000, convQxPrjSite4DownLoad.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxPrjSite4DownLoadEN.PrjSiteId, convQxPrjSite4DownLoad.PrjSiteId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjSite4DownLoadEN.PrjSiteName, convQxPrjSite4DownLoad.PrjSiteName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjSite4DownLoadEN.QxPrjId, convQxPrjSite4DownLoad.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjSite4DownLoadEN.PrjName, convQxPrjSite4DownLoad.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjSite4DownLoadEN.FtpServer, convQxPrjSite4DownLoad.FtpServer);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjSite4DownLoadEN.FtpUserId, convQxPrjSite4DownLoad.FtpUserId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjSite4DownLoadEN.FtpUserPassword, convQxPrjSite4DownLoad.FtpUserPassword);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjSite4DownLoadEN.UpdUserId, convQxPrjSite4DownLoad.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjSite4DownLoadEN.UpdDate, convQxPrjSite4DownLoad.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjSite4DownLoadEN.Memo, convQxPrjSite4DownLoad.Memo);
//检查外键字段长度
 objvQxPrjSite4DownLoadEN._IsCheckProperty = true;
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
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjSite4DownLoadEN._CurrTabName);
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
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjSite4DownLoadEN._CurrTabName, strCondition);
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
 objSQL = clsvQxPrjSite4DownLoadDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}