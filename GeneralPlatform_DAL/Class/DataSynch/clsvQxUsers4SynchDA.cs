
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsers4SynchDA
 表名:vQxUsers4Synch(00140090)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:00:59
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
 /// v用户4同步(vQxUsers4Synch)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxUsers4SynchDA : clsCommBase4DA
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
 return clsvQxUsers4SynchEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxUsers4SynchEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUsers4SynchEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxUsers4SynchEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxUsers4SynchEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = "Select * from vQxUsers4Synch where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers4Synch");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxUsers4Synch_SelectByCond",values, "vQxUsers4Synch");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUsers4Synch where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUsers4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUsers4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUsers4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers4Synch");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxUsers4Synch(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTable_vQxUsers4Synch)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers4Synch where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers4Synch where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUsers4Synch where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUsers4Synch where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUsers4Synch.* from vQxUsers4Synch Left Join {1} on {2} where {3} and vQxUsers4Synch.mId not in (Select top {5} vQxUsers4Synch.mId from vQxUsers4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers4Synch where {1} and mId not in (Select top {2} mId from vQxUsers4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers4Synch where {1} and mId not in (Select top {3} mId from vQxUsers4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUsers4Synch.* from vQxUsers4Synch Left Join {1} on {2} where {3} and vQxUsers4Synch.mId not in (Select top {5} vQxUsers4Synch.mId from vQxUsers4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers4Synch where {1} and mId not in (Select top {2} mId from vQxUsers4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers4Synch where {1} and mId not in (Select top {3} mId from vQxUsers4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUsers4Synch.* from vQxUsers4Synch Left Join {1} on {2} where {3} and vQxUsers4Synch.mId not in (Select top {5} vQxUsers4Synch.mId from vQxUsers4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers4Synch where {1} and mId not in (Select top {2} mId from vQxUsers4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers4Synch where {1} and mId not in (Select top {3} mId from vQxUsers4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUsers4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUsers4Synch Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUsers4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUsers4Synch Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers4SynchDA: GetvQxUsers4SynchByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers4Synch_SelectByCond",values);
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
public List<clsvQxUsers4SynchEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA:GetObjLst)", objException.Message));
}
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = TransNullToInt(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = TransNullToBool(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUsers4SynchDA: GetObjLst)", objException.Message));
}
objvQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUsers4SynchEN);
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
public List<clsvQxUsers4SynchEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = TransNullToInt(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = TransNullToBool(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUsers4SynchDA: GetObjLst)", objException.Message));
}
objvQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUsers4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxUsers4SynchEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers4Synch_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = TransNullToInt(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = TransNullToBool(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxUsers4SynchDA: GetObjLstBySP)", objException.Message));
}
objvQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUsers4SynchEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUsers4Synch(ref clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers4Synch where mId = " + ""+ objvQxUsers4SynchEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxUsers4SynchEN.mId = TransNullToInt(objDT.Rows[0][convQxUsers4Synch.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxUsers4SynchEN.IpAddress = objDT.Rows[0][convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objvQxUsers4SynchEN.UserId = objDT.Rows[0][convQxUsers4Synch.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUsers4SynchEN.UserName = objDT.Rows[0][convQxUsers4Synch.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUsers4SynchEN.UserStateId = objDT.Rows[0][convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers4SynchEN.UserStateName = objDT.Rows[0][convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.IdentityId = objDT.Rows[0][convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers4SynchEN.IdentityDesc = objDT.Rows[0][convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.StuTeacherId = objDT.Rows[0][convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.Password = objDT.Rows[0][convQxUsers4Synch.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.DepartmentId = objDT.Rows[0][convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUsers4SynchEN.DepartmentName = objDT.Rows[0][convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUsers4SynchEN.DepartmentAbbrName = objDT.Rows[0][convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers4SynchEN.DepartmentTypeId = objDT.Rows[0][convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers4SynchEN.DepartmentTypeName = objDT.Rows[0][convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUsers4SynchEN.UpDepartmentId = objDT.Rows[0][convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objvQxUsers4SynchEN.UpDepartmentName = objDT.Rows[0][convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsers4SynchEN.IdXzCollege = objDT.Rows[0][convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege(字段类型:char,字段长度:4,是否可空:True)
 objvQxUsers4SynchEN.EffitiveBeginDate = objDT.Rows[0][convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsers4SynchEN.EffitiveEndDate = objDT.Rows[0][convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objDT.Rows[0][convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers4SynchEN.AccessSynchDate = objDT.Rows[0][convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objDT.Rows[0][convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers4SynchEN.IsSamePwd = TransNullToBool(objDT.Rows[0][convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers4SynchEN.UpdDate = objDT.Rows[0][convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.UpdUser = objDT.Rows[0][convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsers4SynchEN.Memo = objDT.Rows[0][convQxUsers4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxUsers4SynchDA: GetvQxUsers4Synch)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxUsers4SynchEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers4Synch where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
 objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege(字段类型:char,字段长度:4,是否可空:True)
 objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxUsers4SynchDA: GetObjBymId)", objException.Message));
}
return objvQxUsers4SynchEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxUsers4Synch_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUsers4SynchOneBySP(clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxUsers4SynchEN.mId
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers4Synch_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxUsers4SynchEN.mId = TransNullToInt(objDT.Rows[0][convQxUsers4Synch.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxUsers4SynchEN.IpAddress = objDT.Rows[0][convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objvQxUsers4SynchEN.UserId = objDT.Rows[0][convQxUsers4Synch.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUsers4SynchEN.UserName = objDT.Rows[0][convQxUsers4Synch.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUsers4SynchEN.UserStateId = objDT.Rows[0][convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers4SynchEN.UserStateName = objDT.Rows[0][convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.IdentityId = objDT.Rows[0][convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers4SynchEN.IdentityDesc = objDT.Rows[0][convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.StuTeacherId = objDT.Rows[0][convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.Password = objDT.Rows[0][convQxUsers4Synch.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.DepartmentId = objDT.Rows[0][convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUsers4SynchEN.DepartmentName = objDT.Rows[0][convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUsers4SynchEN.DepartmentAbbrName = objDT.Rows[0][convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers4SynchEN.DepartmentTypeId = objDT.Rows[0][convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers4SynchEN.DepartmentTypeName = objDT.Rows[0][convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUsers4SynchEN.UpDepartmentId = objDT.Rows[0][convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objvQxUsers4SynchEN.UpDepartmentName = objDT.Rows[0][convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsers4SynchEN.IdXzCollege = objDT.Rows[0][convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege(字段类型:char,字段长度:4,是否可空:True)
 objvQxUsers4SynchEN.EffitiveBeginDate = objDT.Rows[0][convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsers4SynchEN.EffitiveEndDate = objDT.Rows[0][convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objDT.Rows[0][convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers4SynchEN.AccessSynchDate = objDT.Rows[0][convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objDT.Rows[0][convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers4SynchEN.IsSamePwd = TransNullToBool(objDT.Rows[0][convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers4SynchEN.UpdDate = objDT.Rows[0][convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers4SynchEN.UpdUser = objDT.Rows[0][convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsers4SynchEN.Memo = objDT.Rows[0][convQxUsers4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUsers4SynchEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN()
{
mId = TransNullToInt(objRow[convQxUsers4Synch.mId].ToString().Trim()), //流水号
IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(), //IP地址
UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(), //用户名
UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(), //用户状态名
IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(), //身份编号
IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(), //身份描述
StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(), //学工号
Password = objRow[convQxUsers4Synch.Password].ToString().Trim(), //口令
DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(), //名称缩写
DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(), //部门类型ID
DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(), //部门类型名
UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(), //所属部门号
UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(), //上级部门
IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(), //IdXzCollege
EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(), //有效结束日期
IsAccessSynch = TransNullToBool(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()), //是否处理同步
AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(), //处理同步日期
IsExistUserInCurr = TransNullToBool(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()), //当前是否存在用户
IsSamePwd = TransNullToBool(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()), //是否相同密码
UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim() //备注
};
objvQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsers4SynchEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxUsers4SynchDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUsers4SynchEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers4Synch_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN()
{
mId = TransNullToInt(objRow[convQxUsers4Synch.mId].ToString().Trim()), //流水号
IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(), //IP地址
UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(), //用户名
UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(), //用户状态名
IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(), //身份编号
IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(), //身份描述
StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(), //学工号
Password = objRow[convQxUsers4Synch.Password].ToString().Trim(), //口令
DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(), //名称缩写
DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(), //部门类型ID
DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(), //部门类型名
UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(), //所属部门号
UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(), //上级部门
IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(), //IdXzCollege
EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(), //有效结束日期
IsAccessSynch = TransNullToBool(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()), //是否处理同步
AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(), //处理同步日期
IsExistUserInCurr = TransNullToBool(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()), //当前是否存在用户
IsSamePwd = TransNullToBool(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()), //是否相同密码
UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim() //备注
};
objvQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsers4SynchEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxUsers4SynchEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = TransNullToInt(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = TransNullToBool(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxUsers4SynchDA: GetObjByDataRowvQxUsers4Synch)", objException.Message));
}
objvQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsers4SynchEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxUsers4SynchEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = TransNullToInt(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = TransNullToBool(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxUsers4SynchDA: GetObjByDataRow)", objException.Message));
}
objvQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsers4SynchEN;
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
objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUsers4SynchEN._CurrTabName, convQxUsers4Synch.mId, 8, "");
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
objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUsers4SynchEN._CurrTabName, convQxUsers4Synch.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vQxUsers4Synch where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vQxUsers4Synch where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUsers4Synch", "mId = " + ""+ lngmId+""))
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxUsers4Synch_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxUsers4SynchDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUsers4Synch", strCondition))
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
objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxUsers4Synch");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxUsers4SynchENS">源对象</param>
 /// <param name = "objvQxUsers4SynchENT">目标对象</param>
public void CopyTo(clsvQxUsers4SynchEN objvQxUsers4SynchENS, clsvQxUsers4SynchEN objvQxUsers4SynchENT)
{
objvQxUsers4SynchENT.mId = objvQxUsers4SynchENS.mId; //流水号
objvQxUsers4SynchENT.IpAddress = objvQxUsers4SynchENS.IpAddress; //IP地址
objvQxUsers4SynchENT.UserId = objvQxUsers4SynchENS.UserId; //用户ID
objvQxUsers4SynchENT.UserName = objvQxUsers4SynchENS.UserName; //用户名
objvQxUsers4SynchENT.UserStateId = objvQxUsers4SynchENS.UserStateId; //用户状态Id
objvQxUsers4SynchENT.UserStateName = objvQxUsers4SynchENS.UserStateName; //用户状态名
objvQxUsers4SynchENT.IdentityId = objvQxUsers4SynchENS.IdentityId; //身份编号
objvQxUsers4SynchENT.IdentityDesc = objvQxUsers4SynchENS.IdentityDesc; //身份描述
objvQxUsers4SynchENT.StuTeacherId = objvQxUsers4SynchENS.StuTeacherId; //学工号
objvQxUsers4SynchENT.Password = objvQxUsers4SynchENS.Password; //口令
objvQxUsers4SynchENT.DepartmentId = objvQxUsers4SynchENS.DepartmentId; //部门Id
objvQxUsers4SynchENT.DepartmentName = objvQxUsers4SynchENS.DepartmentName; //部门名
objvQxUsers4SynchENT.DepartmentAbbrName = objvQxUsers4SynchENS.DepartmentAbbrName; //名称缩写
objvQxUsers4SynchENT.DepartmentTypeId = objvQxUsers4SynchENS.DepartmentTypeId; //部门类型ID
objvQxUsers4SynchENT.DepartmentTypeName = objvQxUsers4SynchENS.DepartmentTypeName; //部门类型名
objvQxUsers4SynchENT.UpDepartmentId = objvQxUsers4SynchENS.UpDepartmentId; //所属部门号
objvQxUsers4SynchENT.UpDepartmentName = objvQxUsers4SynchENS.UpDepartmentName; //上级部门
objvQxUsers4SynchENT.IdXzCollege = objvQxUsers4SynchENS.IdXzCollege; //IdXzCollege
objvQxUsers4SynchENT.EffitiveBeginDate = objvQxUsers4SynchENS.EffitiveBeginDate; //有效开始日期
objvQxUsers4SynchENT.EffitiveEndDate = objvQxUsers4SynchENS.EffitiveEndDate; //有效结束日期
objvQxUsers4SynchENT.IsAccessSynch = objvQxUsers4SynchENS.IsAccessSynch; //是否处理同步
objvQxUsers4SynchENT.AccessSynchDate = objvQxUsers4SynchENS.AccessSynchDate; //处理同步日期
objvQxUsers4SynchENT.IsExistUserInCurr = objvQxUsers4SynchENS.IsExistUserInCurr; //当前是否存在用户
objvQxUsers4SynchENT.IsSamePwd = objvQxUsers4SynchENS.IsSamePwd; //是否相同密码
objvQxUsers4SynchENT.UpdDate = objvQxUsers4SynchENS.UpdDate; //修改日期
objvQxUsers4SynchENT.UpdUser = objvQxUsers4SynchENS.UpdUser; //修改用户
objvQxUsers4SynchENT.Memo = objvQxUsers4SynchENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.IpAddress, 23, convQxUsers4Synch.IpAddress);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.UserId, 18, convQxUsers4Synch.UserId);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.UserName, 30, convQxUsers4Synch.UserName);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.UserStateId, 2, convQxUsers4Synch.UserStateId);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.UserStateName, 20, convQxUsers4Synch.UserStateName);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.IdentityId, 2, convQxUsers4Synch.IdentityId);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.IdentityDesc, 20, convQxUsers4Synch.IdentityDesc);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.StuTeacherId, 20, convQxUsers4Synch.StuTeacherId);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.Password, 20, convQxUsers4Synch.Password);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.DepartmentId, 8, convQxUsers4Synch.DepartmentId);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.DepartmentName, 100, convQxUsers4Synch.DepartmentName);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.DepartmentAbbrName, 8, convQxUsers4Synch.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.DepartmentTypeId, 2, convQxUsers4Synch.DepartmentTypeId);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.DepartmentTypeName, 50, convQxUsers4Synch.DepartmentTypeName);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.UpDepartmentId, 6, convQxUsers4Synch.UpDepartmentId);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.UpDepartmentName, 100, convQxUsers4Synch.UpDepartmentName);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.IdXzCollege, 4, convQxUsers4Synch.IdXzCollege);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.EffitiveBeginDate, 14, convQxUsers4Synch.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.EffitiveEndDate, 14, convQxUsers4Synch.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.AccessSynchDate, 14, convQxUsers4Synch.AccessSynchDate);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.UpdDate, 20, convQxUsers4Synch.UpdDate);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.UpdUser, 20, convQxUsers4Synch.UpdUser);
clsCheckSql.CheckFieldLen(objvQxUsers4SynchEN.Memo, 1000, convQxUsers4Synch.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.IpAddress, convQxUsers4Synch.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.UserId, convQxUsers4Synch.UserId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.UserName, convQxUsers4Synch.UserName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.UserStateId, convQxUsers4Synch.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.UserStateName, convQxUsers4Synch.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.IdentityId, convQxUsers4Synch.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.IdentityDesc, convQxUsers4Synch.IdentityDesc);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.StuTeacherId, convQxUsers4Synch.StuTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.Password, convQxUsers4Synch.Password);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.DepartmentId, convQxUsers4Synch.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.DepartmentName, convQxUsers4Synch.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.DepartmentAbbrName, convQxUsers4Synch.DepartmentAbbrName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.DepartmentTypeId, convQxUsers4Synch.DepartmentTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.DepartmentTypeName, convQxUsers4Synch.DepartmentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.UpDepartmentId, convQxUsers4Synch.UpDepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.UpDepartmentName, convQxUsers4Synch.UpDepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.IdXzCollege, convQxUsers4Synch.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.EffitiveBeginDate, convQxUsers4Synch.EffitiveBeginDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.EffitiveEndDate, convQxUsers4Synch.EffitiveEndDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.AccessSynchDate, convQxUsers4Synch.AccessSynchDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.UpdDate, convQxUsers4Synch.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.UpdUser, convQxUsers4Synch.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers4SynchEN.Memo, convQxUsers4Synch.Memo);
//检查外键字段长度
 objvQxUsers4SynchEN._IsCheckProperty = true;
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
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
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
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
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
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUsers4SynchEN._CurrTabName);
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
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUsers4SynchEN._CurrTabName, strCondition);
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
 objSQL = clsvQxUsers4SynchDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}