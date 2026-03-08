
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsers4SynchDA
 表名:QxUsers4Synch(00140089)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:01:03
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
 /// 用户4同步(QxUsers4Synch)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxUsers4SynchDA : clsCommBase4DA
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
 return clsQxUsers4SynchEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxUsers4SynchEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUsers4SynchEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxUsers4SynchEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxUsers4SynchEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = "Select * from QxUsers4Synch where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxUsers4Synch");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxUsers4Synch_SelectByCond",values, "QxUsers4Synch");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUsers4Synch where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxUsers4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From QxUsers4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUsers4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From QxUsers4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUsers4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From QxUsers4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUsers4Synch");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxUsers4Synch(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTable_QxUsers4Synch)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsers4Synch where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsers4Synch where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUsers4Synch where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUsers4Synch where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUsers4Synch.* from QxUsers4Synch Left Join {1} on {2} where {3} and QxUsers4Synch.mId not in (Select top {5} QxUsers4Synch.mId from QxUsers4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsers4Synch where {1} and mId not in (Select top {2} mId from QxUsers4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsers4Synch where {1} and mId not in (Select top {3} mId from QxUsers4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUsers4Synch.* from QxUsers4Synch Left Join {1} on {2} where {3} and QxUsers4Synch.mId not in (Select top {5} QxUsers4Synch.mId from QxUsers4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsers4Synch where {1} and mId not in (Select top {2} mId from QxUsers4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsers4Synch where {1} and mId not in (Select top {3} mId from QxUsers4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUsers4Synch.* from QxUsers4Synch Left Join {1} on {2} where {3} and QxUsers4Synch.mId not in (Select top {5} QxUsers4Synch.mId from QxUsers4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsers4Synch where {1} and mId not in (Select top {2} mId from QxUsers4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsers4Synch where {1} and mId not in (Select top {3} mId from QxUsers4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From QxUsers4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From QxUsers4Synch Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From QxUsers4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUsers4Synch a where {0} And a.mId not in (Select Top {2} mId From QxUsers4Synch Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsers4SynchDA: GetQxUsers4SynchByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUsers4Synch_SelectByCond",values);
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
public List<clsQxUsers4SynchEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA:GetObjLst)", objException.Message));
}
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = TransNullToInt(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = TransNullToBool(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = TransNullToBool(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUsers4SynchDA: GetObjLst)", objException.Message));
}
objQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUsers4SynchEN);
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
public List<clsQxUsers4SynchEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = TransNullToInt(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = TransNullToBool(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = TransNullToBool(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUsers4SynchDA: GetObjLst)", objException.Message));
}
objQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUsers4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxUsers4SynchEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA:GetObjLstBySP)", objException.Message));
}
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUsers4Synch_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = TransNullToInt(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = TransNullToBool(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = TransNullToBool(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxUsers4SynchDA: GetObjLstBySP)", objException.Message));
}
objQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUsers4SynchEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUsers4Synch(ref clsQxUsers4SynchEN objQxUsers4SynchEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where mId = " + ""+ objQxUsers4SynchEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxUsers4SynchEN.mId = TransNullToInt(objDT.Rows[0][conQxUsers4Synch.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxUsers4SynchEN.IpAddress = objDT.Rows[0][conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objQxUsers4SynchEN.UserId = objDT.Rows[0][conQxUsers4Synch.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUsers4SynchEN.UserName = objDT.Rows[0][conQxUsers4Synch.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsers4SynchEN.UserStateId = objDT.Rows[0][conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objQxUsers4SynchEN.OpenId = objDT.Rows[0][conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objQxUsers4SynchEN.IdentityId = objDT.Rows[0][conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objQxUsers4SynchEN.StuTeacherId = objDT.Rows[0][conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsers4SynchEN.Password = objDT.Rows[0][conQxUsers4Synch.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsers4SynchEN.PhoneNumber = objDT.Rows[0][conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objQxUsers4SynchEN.DepartmentId = objDT.Rows[0][conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objQxUsers4SynchEN.IdXzCollege = objDT.Rows[0][conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege(字段类型:char,字段长度:4,是否可空:True)
 objQxUsers4SynchEN.EffitiveBeginDate = objDT.Rows[0][conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsers4SynchEN.EffitiveEndDate = objDT.Rows[0][conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsers4SynchEN.Email = objDT.Rows[0][conQxUsers4Synch.Email].ToString().Trim(); //邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsers4SynchEN.IsArchive = TransNullToBool(objDT.Rows[0][conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objDT.Rows[0][conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.AccessSynchDate = objDT.Rows[0][conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objDT.Rows[0][conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.IsSamePwd = TransNullToBool(objDT.Rows[0][conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.UpdDate = objDT.Rows[0][conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsers4SynchEN.UpdUser = objDT.Rows[0][conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsers4SynchEN.Memo = objDT.Rows[0][conQxUsers4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxUsers4SynchDA: GetQxUsers4Synch)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxUsers4SynchEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
 objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege(字段类型:char,字段长度:4,是否可空:True)
 objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxUsers4SynchDA: GetObjBymId)", objException.Message));
}
return objQxUsers4SynchEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxUsers4Synch_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUsers4SynchOneBySP(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxUsers4SynchEN.mId
};
 objDT = objSQL.ExecSpReturnDT("QxUsers4Synch_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxUsers4SynchEN.mId = TransNullToInt(objDT.Rows[0][conQxUsers4Synch.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxUsers4SynchEN.IpAddress = objDT.Rows[0][conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objQxUsers4SynchEN.UserId = objDT.Rows[0][conQxUsers4Synch.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUsers4SynchEN.UserName = objDT.Rows[0][conQxUsers4Synch.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsers4SynchEN.UserStateId = objDT.Rows[0][conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objQxUsers4SynchEN.OpenId = objDT.Rows[0][conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objQxUsers4SynchEN.IdentityId = objDT.Rows[0][conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objQxUsers4SynchEN.StuTeacherId = objDT.Rows[0][conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsers4SynchEN.Password = objDT.Rows[0][conQxUsers4Synch.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsers4SynchEN.PhoneNumber = objDT.Rows[0][conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objQxUsers4SynchEN.DepartmentId = objDT.Rows[0][conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objQxUsers4SynchEN.IdXzCollege = objDT.Rows[0][conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege(字段类型:char,字段长度:4,是否可空:True)
 objQxUsers4SynchEN.EffitiveBeginDate = objDT.Rows[0][conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsers4SynchEN.EffitiveEndDate = objDT.Rows[0][conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsers4SynchEN.Email = objDT.Rows[0][conQxUsers4Synch.Email].ToString().Trim(); //邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsers4SynchEN.IsArchive = TransNullToBool(objDT.Rows[0][conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objDT.Rows[0][conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.AccessSynchDate = objDT.Rows[0][conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objDT.Rows[0][conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.IsSamePwd = TransNullToBool(objDT.Rows[0][conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsers4SynchEN.UpdDate = objDT.Rows[0][conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsers4SynchEN.UpdUser = objDT.Rows[0][conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsers4SynchEN.Memo = objDT.Rows[0][conQxUsers4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUsers4SynchEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN()
{
mId = TransNullToInt(objRow[conQxUsers4Synch.mId].ToString().Trim()), //流水号
IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(), //IP地址
UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(), //用户ID
UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(), //用户名
UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(), //用户状态Id
OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(), //微信openid
IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(), //身份编号
StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(), //学工号
Password = objRow[conQxUsers4Synch.Password].ToString().Trim(), //口令
PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(), //电话号码
DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(), //部门Id
IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(), //IdXzCollege
EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(), //有效结束日期
Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(), //邮箱
IsArchive = TransNullToBool(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()), //是否存档
IsAccessSynch = TransNullToBool(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()), //是否处理同步
AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(), //处理同步日期
IsExistUserInCurr = TransNullToBool(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()), //当前是否存在用户
IsSamePwd = TransNullToBool(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()), //是否相同密码
UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim() //备注
};
objQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsers4SynchEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxUsers4SynchDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUsers4SynchEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUsers4Synch_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN()
{
mId = TransNullToInt(objRow[conQxUsers4Synch.mId].ToString().Trim()), //流水号
IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(), //IP地址
UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(), //用户ID
UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(), //用户名
UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(), //用户状态Id
OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(), //微信openid
IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(), //身份编号
StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(), //学工号
Password = objRow[conQxUsers4Synch.Password].ToString().Trim(), //口令
PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(), //电话号码
DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(), //部门Id
IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(), //IdXzCollege
EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(), //有效结束日期
Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(), //邮箱
IsArchive = TransNullToBool(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()), //是否存档
IsAccessSynch = TransNullToBool(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()), //是否处理同步
AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(), //处理同步日期
IsExistUserInCurr = TransNullToBool(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()), //当前是否存在用户
IsSamePwd = TransNullToBool(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()), //是否相同密码
UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim() //备注
};
objQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsers4SynchEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxUsers4SynchEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = TransNullToInt(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = TransNullToBool(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = TransNullToBool(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxUsers4SynchDA: GetObjByDataRowQxUsers4Synch)", objException.Message));
}
objQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsers4SynchEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxUsers4SynchEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = TransNullToInt(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = TransNullToBool(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = TransNullToBool(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = TransNullToBool(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = TransNullToBool(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxUsers4SynchDA: GetObjByDataRow)", objException.Message));
}
objQxUsers4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsers4SynchEN;
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
objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUsers4SynchEN._CurrTabName, conQxUsers4Synch.mId, 8, "");
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
objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUsers4SynchEN._CurrTabName, conQxUsers4Synch.mId, 8, strPrefix);
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
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from QxUsers4Synch where " + strCondition;
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
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from QxUsers4Synch where " + strCondition;
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
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUsers4Synch", "mId = " + ""+ lngmId+""))
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
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxUsers4Synch_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUsers4Synch", strCondition))
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
objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxUsers4Synch");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxUsers4SynchEN objQxUsers4SynchEN)
 {
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsers4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsers4SynchEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUsers4Synch");
objRow = objDS.Tables["QxUsers4Synch"].NewRow();
 if (objQxUsers4SynchEN.IpAddress !=  "")
 {
objRow[conQxUsers4Synch.IpAddress] = objQxUsers4SynchEN.IpAddress; //IP地址
 }
objRow[conQxUsers4Synch.UserId] = objQxUsers4SynchEN.UserId; //用户ID
objRow[conQxUsers4Synch.UserName] = objQxUsers4SynchEN.UserName; //用户名
objRow[conQxUsers4Synch.UserStateId] = objQxUsers4SynchEN.UserStateId; //用户状态Id
 if (objQxUsers4SynchEN.OpenId !=  "")
 {
objRow[conQxUsers4Synch.OpenId] = objQxUsers4SynchEN.OpenId; //微信openid
 }
 if (objQxUsers4SynchEN.IdentityId !=  "")
 {
objRow[conQxUsers4Synch.IdentityId] = objQxUsers4SynchEN.IdentityId; //身份编号
 }
 if (objQxUsers4SynchEN.StuTeacherId !=  "")
 {
objRow[conQxUsers4Synch.StuTeacherId] = objQxUsers4SynchEN.StuTeacherId; //学工号
 }
objRow[conQxUsers4Synch.Password] = objQxUsers4SynchEN.Password; //口令
 if (objQxUsers4SynchEN.PhoneNumber !=  "")
 {
objRow[conQxUsers4Synch.PhoneNumber] = objQxUsers4SynchEN.PhoneNumber; //电话号码
 }
 if (objQxUsers4SynchEN.DepartmentId !=  "")
 {
objRow[conQxUsers4Synch.DepartmentId] = objQxUsers4SynchEN.DepartmentId; //部门Id
 }
 if (objQxUsers4SynchEN.IdXzCollege !=  "")
 {
objRow[conQxUsers4Synch.IdXzCollege] = objQxUsers4SynchEN.IdXzCollege; //IdXzCollege
 }
 if (objQxUsers4SynchEN.EffitiveBeginDate !=  "")
 {
objRow[conQxUsers4Synch.EffitiveBeginDate] = objQxUsers4SynchEN.EffitiveBeginDate; //有效开始日期
 }
 if (objQxUsers4SynchEN.EffitiveEndDate !=  "")
 {
objRow[conQxUsers4Synch.EffitiveEndDate] = objQxUsers4SynchEN.EffitiveEndDate; //有效结束日期
 }
 if (objQxUsers4SynchEN.Email !=  "")
 {
objRow[conQxUsers4Synch.Email] = objQxUsers4SynchEN.Email; //邮箱
 }
objRow[conQxUsers4Synch.IsArchive] = objQxUsers4SynchEN.IsArchive; //是否存档
objRow[conQxUsers4Synch.IsAccessSynch] = objQxUsers4SynchEN.IsAccessSynch; //是否处理同步
 if (objQxUsers4SynchEN.AccessSynchDate !=  "")
 {
objRow[conQxUsers4Synch.AccessSynchDate] = objQxUsers4SynchEN.AccessSynchDate; //处理同步日期
 }
objRow[conQxUsers4Synch.IsExistUserInCurr] = objQxUsers4SynchEN.IsExistUserInCurr; //当前是否存在用户
objRow[conQxUsers4Synch.IsSamePwd] = objQxUsers4SynchEN.IsSamePwd; //是否相同密码
 if (objQxUsers4SynchEN.UpdDate !=  "")
 {
objRow[conQxUsers4Synch.UpdDate] = objQxUsers4SynchEN.UpdDate; //修改日期
 }
 if (objQxUsers4SynchEN.UpdUser !=  "")
 {
objRow[conQxUsers4Synch.UpdUser] = objQxUsers4SynchEN.UpdUser; //修改用户
 }
 if (objQxUsers4SynchEN.Memo !=  "")
 {
objRow[conQxUsers4Synch.Memo] = objQxUsers4SynchEN.Memo; //备注
 }
objDS.Tables[clsQxUsers4SynchEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxUsers4SynchEN._CurrTabName);
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
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsers4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsers4SynchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUsers4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IpAddress);
 var strIpAddress = objQxUsers4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objQxUsers4SynchEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserId);
 var strUserId = objQxUsers4SynchEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsers4SynchEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserName);
 var strUserName = objQxUsers4SynchEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsers4SynchEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserStateId);
 var strUserStateId = objQxUsers4SynchEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objQxUsers4SynchEN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.OpenId);
 var strOpenId = objQxUsers4SynchEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsers4SynchEN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IdentityId);
 var strIdentityId = objQxUsers4SynchEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 if (objQxUsers4SynchEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.StuTeacherId);
 var strStuTeacherId = objQxUsers4SynchEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsers4SynchEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Password);
 var strPassword = objQxUsers4SynchEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsers4SynchEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.PhoneNumber);
 var strPhoneNumber = objQxUsers4SynchEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objQxUsers4SynchEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.DepartmentId);
 var strDepartmentId = objQxUsers4SynchEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxUsers4SynchEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IdXzCollege);
 var strIdXzCollege = objQxUsers4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objQxUsers4SynchEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsers4SynchEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsers4SynchEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsers4SynchEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsers4SynchEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Email);
 var strEmail = objQxUsers4SynchEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsArchive  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsAccessSynch);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsAccessSynch  ==  false ? "0" : "1") + "'");
 
 if (objQxUsers4SynchEN.AccessSynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.AccessSynchDate);
 var strAccessSynchDate = objQxUsers4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessSynchDate + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsExistUserInCurr);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsExistUserInCurr  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsSamePwd);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsSamePwd  ==  false ? "0" : "1") + "'");
 
 if (objQxUsers4SynchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UpdDate);
 var strUpdDate = objQxUsers4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUsers4SynchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UpdUser);
 var strUpdUser = objQxUsers4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUsers4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Memo);
 var strMemo = objQxUsers4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsers4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsers4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsers4SynchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUsers4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IpAddress);
 var strIpAddress = objQxUsers4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objQxUsers4SynchEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserId);
 var strUserId = objQxUsers4SynchEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsers4SynchEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserName);
 var strUserName = objQxUsers4SynchEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsers4SynchEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserStateId);
 var strUserStateId = objQxUsers4SynchEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objQxUsers4SynchEN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.OpenId);
 var strOpenId = objQxUsers4SynchEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsers4SynchEN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IdentityId);
 var strIdentityId = objQxUsers4SynchEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 if (objQxUsers4SynchEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.StuTeacherId);
 var strStuTeacherId = objQxUsers4SynchEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsers4SynchEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Password);
 var strPassword = objQxUsers4SynchEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsers4SynchEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.PhoneNumber);
 var strPhoneNumber = objQxUsers4SynchEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objQxUsers4SynchEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.DepartmentId);
 var strDepartmentId = objQxUsers4SynchEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxUsers4SynchEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IdXzCollege);
 var strIdXzCollege = objQxUsers4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objQxUsers4SynchEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsers4SynchEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsers4SynchEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsers4SynchEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsers4SynchEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Email);
 var strEmail = objQxUsers4SynchEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsArchive  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsAccessSynch);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsAccessSynch  ==  false ? "0" : "1") + "'");
 
 if (objQxUsers4SynchEN.AccessSynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.AccessSynchDate);
 var strAccessSynchDate = objQxUsers4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessSynchDate + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsExistUserInCurr);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsExistUserInCurr  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsSamePwd);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsSamePwd  ==  false ? "0" : "1") + "'");
 
 if (objQxUsers4SynchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UpdDate);
 var strUpdDate = objQxUsers4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUsers4SynchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UpdUser);
 var strUpdUser = objQxUsers4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUsers4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Memo);
 var strMemo = objQxUsers4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsers4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUsers4SynchEN objQxUsers4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsers4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsers4SynchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUsers4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IpAddress);
 var strIpAddress = objQxUsers4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objQxUsers4SynchEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserId);
 var strUserId = objQxUsers4SynchEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsers4SynchEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserName);
 var strUserName = objQxUsers4SynchEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsers4SynchEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserStateId);
 var strUserStateId = objQxUsers4SynchEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objQxUsers4SynchEN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.OpenId);
 var strOpenId = objQxUsers4SynchEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsers4SynchEN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IdentityId);
 var strIdentityId = objQxUsers4SynchEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 if (objQxUsers4SynchEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.StuTeacherId);
 var strStuTeacherId = objQxUsers4SynchEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsers4SynchEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Password);
 var strPassword = objQxUsers4SynchEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsers4SynchEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.PhoneNumber);
 var strPhoneNumber = objQxUsers4SynchEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objQxUsers4SynchEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.DepartmentId);
 var strDepartmentId = objQxUsers4SynchEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxUsers4SynchEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IdXzCollege);
 var strIdXzCollege = objQxUsers4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objQxUsers4SynchEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsers4SynchEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsers4SynchEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsers4SynchEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsers4SynchEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Email);
 var strEmail = objQxUsers4SynchEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsArchive  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsAccessSynch);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsAccessSynch  ==  false ? "0" : "1") + "'");
 
 if (objQxUsers4SynchEN.AccessSynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.AccessSynchDate);
 var strAccessSynchDate = objQxUsers4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessSynchDate + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsExistUserInCurr);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsExistUserInCurr  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsSamePwd);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsSamePwd  ==  false ? "0" : "1") + "'");
 
 if (objQxUsers4SynchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UpdDate);
 var strUpdDate = objQxUsers4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUsers4SynchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UpdUser);
 var strUpdUser = objQxUsers4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUsers4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Memo);
 var strMemo = objQxUsers4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsers4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUsers4SynchEN objQxUsers4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsers4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsers4SynchEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUsers4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IpAddress);
 var strIpAddress = objQxUsers4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objQxUsers4SynchEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserId);
 var strUserId = objQxUsers4SynchEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsers4SynchEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserName);
 var strUserName = objQxUsers4SynchEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsers4SynchEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UserStateId);
 var strUserStateId = objQxUsers4SynchEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objQxUsers4SynchEN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.OpenId);
 var strOpenId = objQxUsers4SynchEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsers4SynchEN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IdentityId);
 var strIdentityId = objQxUsers4SynchEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 if (objQxUsers4SynchEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.StuTeacherId);
 var strStuTeacherId = objQxUsers4SynchEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsers4SynchEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Password);
 var strPassword = objQxUsers4SynchEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsers4SynchEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.PhoneNumber);
 var strPhoneNumber = objQxUsers4SynchEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objQxUsers4SynchEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.DepartmentId);
 var strDepartmentId = objQxUsers4SynchEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxUsers4SynchEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.IdXzCollege);
 var strIdXzCollege = objQxUsers4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objQxUsers4SynchEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsers4SynchEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsers4SynchEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsers4SynchEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsers4SynchEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Email);
 var strEmail = objQxUsers4SynchEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsArchive  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsAccessSynch);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsAccessSynch  ==  false ? "0" : "1") + "'");
 
 if (objQxUsers4SynchEN.AccessSynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.AccessSynchDate);
 var strAccessSynchDate = objQxUsers4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessSynchDate + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsExistUserInCurr);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsExistUserInCurr  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxUsers4Synch.IsSamePwd);
 arrValueListForInsert.Add("'" + (objQxUsers4SynchEN.IsSamePwd  ==  false ? "0" : "1") + "'");
 
 if (objQxUsers4SynchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UpdDate);
 var strUpdDate = objQxUsers4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUsers4SynchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.UpdUser);
 var strUpdUser = objQxUsers4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUsers4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers4Synch.Memo);
 var strMemo = objQxUsers4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsers4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxUsers4SynchBySP(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
//通过存储过程来
//直接使用
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUsers4SynchEN.IpAddress,
 objQxUsers4SynchEN.UserId,
 objQxUsers4SynchEN.UserName,
 objQxUsers4SynchEN.UserStateId,
 objQxUsers4SynchEN.OpenId,
 objQxUsers4SynchEN.IdentityId,
 objQxUsers4SynchEN.StuTeacherId,
 objQxUsers4SynchEN.Password,
 objQxUsers4SynchEN.PhoneNumber,
 objQxUsers4SynchEN.DepartmentId,
 objQxUsers4SynchEN.IdXzCollege,
 objQxUsers4SynchEN.EffitiveBeginDate,
 objQxUsers4SynchEN.EffitiveEndDate,
 objQxUsers4SynchEN.Email,
 objQxUsers4SynchEN.IsArchive,
 objQxUsers4SynchEN.IsAccessSynch,
 objQxUsers4SynchEN.AccessSynchDate,
 objQxUsers4SynchEN.IsExistUserInCurr,
 objQxUsers4SynchEN.IsSamePwd,
 objQxUsers4SynchEN.UpdDate,
 objQxUsers4SynchEN.UpdUser,
objQxUsers4SynchEN.Memo
};
 objSQL.ExecSP("QxUsers4Synch_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxUsers4Synchs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUsers4Synch");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxUsers4SynchEN._CurrTabName ].NewRow();
objRow[conQxUsers4Synch.IpAddress] = oRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objRow[conQxUsers4Synch.UserId] = oRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objRow[conQxUsers4Synch.UserName] = oRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objRow[conQxUsers4Synch.UserStateId] = oRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objRow[conQxUsers4Synch.OpenId] = oRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objRow[conQxUsers4Synch.IdentityId] = oRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objRow[conQxUsers4Synch.StuTeacherId] = oRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objRow[conQxUsers4Synch.Password] = oRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objRow[conQxUsers4Synch.PhoneNumber] = oRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objRow[conQxUsers4Synch.DepartmentId] = oRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objRow[conQxUsers4Synch.IdXzCollege] = oRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objRow[conQxUsers4Synch.EffitiveBeginDate] = oRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objRow[conQxUsers4Synch.EffitiveEndDate] = oRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objRow[conQxUsers4Synch.Email] = oRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objRow[conQxUsers4Synch.IsArchive] = oRow[conQxUsers4Synch.IsArchive].ToString().Trim(); //是否存档
objRow[conQxUsers4Synch.IsAccessSynch] = oRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim(); //是否处理同步
objRow[conQxUsers4Synch.AccessSynchDate] = oRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objRow[conQxUsers4Synch.IsExistUserInCurr] = oRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim(); //当前是否存在用户
objRow[conQxUsers4Synch.IsSamePwd] = oRow[conQxUsers4Synch.IsSamePwd].ToString().Trim(); //是否相同密码
objRow[conQxUsers4Synch.UpdDate] = oRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objRow[conQxUsers4Synch.UpdUser] = oRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objRow[conQxUsers4Synch.Memo] = oRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxUsers4SynchEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxUsers4SynchEN._CurrTabName);
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
 /// <param name = "objQxUsers4SynchEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsers4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsers4SynchEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers4Synch where mId = " + ""+ objQxUsers4SynchEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxUsers4SynchEN._CurrTabName);
if (objDS.Tables[clsQxUsers4SynchEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objQxUsers4SynchEN.mId+"");
return false;
}
objRow = objDS.Tables[clsQxUsers4SynchEN._CurrTabName].Rows[0];
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IpAddress))
 {
objRow[conQxUsers4Synch.IpAddress] = objQxUsers4SynchEN.IpAddress; //IP地址
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserId))
 {
objRow[conQxUsers4Synch.UserId] = objQxUsers4SynchEN.UserId; //用户ID
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserName))
 {
objRow[conQxUsers4Synch.UserName] = objQxUsers4SynchEN.UserName; //用户名
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserStateId))
 {
objRow[conQxUsers4Synch.UserStateId] = objQxUsers4SynchEN.UserStateId; //用户状态Id
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.OpenId))
 {
objRow[conQxUsers4Synch.OpenId] = objQxUsers4SynchEN.OpenId; //微信openid
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IdentityId))
 {
objRow[conQxUsers4Synch.IdentityId] = objQxUsers4SynchEN.IdentityId; //身份编号
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.StuTeacherId))
 {
objRow[conQxUsers4Synch.StuTeacherId] = objQxUsers4SynchEN.StuTeacherId; //学工号
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Password))
 {
objRow[conQxUsers4Synch.Password] = objQxUsers4SynchEN.Password; //口令
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.PhoneNumber))
 {
objRow[conQxUsers4Synch.PhoneNumber] = objQxUsers4SynchEN.PhoneNumber; //电话号码
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.DepartmentId))
 {
objRow[conQxUsers4Synch.DepartmentId] = objQxUsers4SynchEN.DepartmentId; //部门Id
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IdXzCollege))
 {
objRow[conQxUsers4Synch.IdXzCollege] = objQxUsers4SynchEN.IdXzCollege; //IdXzCollege
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.EffitiveBeginDate))
 {
objRow[conQxUsers4Synch.EffitiveBeginDate] = objQxUsers4SynchEN.EffitiveBeginDate; //有效开始日期
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.EffitiveEndDate))
 {
objRow[conQxUsers4Synch.EffitiveEndDate] = objQxUsers4SynchEN.EffitiveEndDate; //有效结束日期
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Email))
 {
objRow[conQxUsers4Synch.Email] = objQxUsers4SynchEN.Email; //邮箱
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsArchive))
 {
objRow[conQxUsers4Synch.IsArchive] = objQxUsers4SynchEN.IsArchive; //是否存档
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsAccessSynch))
 {
objRow[conQxUsers4Synch.IsAccessSynch] = objQxUsers4SynchEN.IsAccessSynch; //是否处理同步
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.AccessSynchDate))
 {
objRow[conQxUsers4Synch.AccessSynchDate] = objQxUsers4SynchEN.AccessSynchDate; //处理同步日期
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsExistUserInCurr))
 {
objRow[conQxUsers4Synch.IsExistUserInCurr] = objQxUsers4SynchEN.IsExistUserInCurr; //当前是否存在用户
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsSamePwd))
 {
objRow[conQxUsers4Synch.IsSamePwd] = objQxUsers4SynchEN.IsSamePwd; //是否相同密码
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UpdDate))
 {
objRow[conQxUsers4Synch.UpdDate] = objQxUsers4SynchEN.UpdDate; //修改日期
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UpdUser))
 {
objRow[conQxUsers4Synch.UpdUser] = objQxUsers4SynchEN.UpdUser; //修改用户
 }
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Memo))
 {
objRow[conQxUsers4Synch.Memo] = objQxUsers4SynchEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxUsers4SynchEN._CurrTabName);
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
public bool UpdateBySP(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsers4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsers4SynchEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUsers4SynchEN.mId,
 objQxUsers4SynchEN.IpAddress,
 objQxUsers4SynchEN.UserId,
 objQxUsers4SynchEN.UserName,
 objQxUsers4SynchEN.UserStateId,
 objQxUsers4SynchEN.OpenId,
 objQxUsers4SynchEN.IdentityId,
 objQxUsers4SynchEN.StuTeacherId,
 objQxUsers4SynchEN.Password,
 objQxUsers4SynchEN.PhoneNumber,
 objQxUsers4SynchEN.DepartmentId,
 objQxUsers4SynchEN.IdXzCollege,
 objQxUsers4SynchEN.EffitiveBeginDate,
 objQxUsers4SynchEN.EffitiveEndDate,
 objQxUsers4SynchEN.Email,
 objQxUsers4SynchEN.IsArchive,
 objQxUsers4SynchEN.IsAccessSynch,
 objQxUsers4SynchEN.AccessSynchDate,
 objQxUsers4SynchEN.IsExistUserInCurr,
 objQxUsers4SynchEN.IsSamePwd,
 objQxUsers4SynchEN.UpdDate,
 objQxUsers4SynchEN.UpdUser,
 objQxUsers4SynchEN.Memo
};
 objSQL.ExecSP("QxUsers4Synch_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsers4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsers4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxUsers4Synch Set ");
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IpAddress))
 {
 if (objQxUsers4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objQxUsers4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conQxUsers4Synch.IpAddress); //IP地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.IpAddress); //IP地址
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserId))
 {
 if (objQxUsers4SynchEN.UserId !=  null)
 {
 var strUserId = objQxUsers4SynchEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUsers4Synch.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.UserId); //用户ID
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserName))
 {
 if (objQxUsers4SynchEN.UserName !=  null)
 {
 var strUserName = objQxUsers4SynchEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conQxUsers4Synch.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.UserName); //用户名
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserStateId))
 {
 if (objQxUsers4SynchEN.UserStateId !=  null)
 {
 var strUserStateId = objQxUsers4SynchEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserStateId, conQxUsers4Synch.UserStateId); //用户状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.UserStateId); //用户状态Id
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.OpenId))
 {
 if (objQxUsers4SynchEN.OpenId !=  null)
 {
 var strOpenId = objQxUsers4SynchEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpenId, conQxUsers4Synch.OpenId); //微信openid
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.OpenId); //微信openid
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IdentityId))
 {
 if (objQxUsers4SynchEN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsers4SynchEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdentityId, conQxUsers4Synch.IdentityId); //身份编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.IdentityId); //身份编号
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.StuTeacherId))
 {
 if (objQxUsers4SynchEN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsers4SynchEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuTeacherId, conQxUsers4Synch.StuTeacherId); //学工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.StuTeacherId); //学工号
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Password))
 {
 if (objQxUsers4SynchEN.Password !=  null)
 {
 var strPassword = objQxUsers4SynchEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPassword, conQxUsers4Synch.Password); //口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.Password); //口令
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.PhoneNumber))
 {
 if (objQxUsers4SynchEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objQxUsers4SynchEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhoneNumber, conQxUsers4Synch.PhoneNumber); //电话号码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.PhoneNumber); //电话号码
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.DepartmentId))
 {
 if (objQxUsers4SynchEN.DepartmentId !=  null)
 {
 var strDepartmentId = objQxUsers4SynchEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentId, conQxUsers4Synch.DepartmentId); //部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.DepartmentId); //部门Id
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IdXzCollege))
 {
 if (objQxUsers4SynchEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objQxUsers4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conQxUsers4Synch.IdXzCollege); //IdXzCollege
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.IdXzCollege); //IdXzCollege
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.EffitiveBeginDate))
 {
 if (objQxUsers4SynchEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsers4SynchEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveBeginDate, conQxUsers4Synch.EffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.EffitiveBeginDate); //有效开始日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.EffitiveEndDate))
 {
 if (objQxUsers4SynchEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsers4SynchEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveEndDate, conQxUsers4Synch.EffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.EffitiveEndDate); //有效结束日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Email))
 {
 if (objQxUsers4SynchEN.Email !=  null)
 {
 var strEmail = objQxUsers4SynchEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conQxUsers4Synch.Email); //邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.Email); //邮箱
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsArchive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsers4SynchEN.IsArchive == true?"1":"0", conQxUsers4Synch.IsArchive); //是否存档
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsAccessSynch))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsers4SynchEN.IsAccessSynch == true?"1":"0", conQxUsers4Synch.IsAccessSynch); //是否处理同步
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.AccessSynchDate))
 {
 if (objQxUsers4SynchEN.AccessSynchDate !=  null)
 {
 var strAccessSynchDate = objQxUsers4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAccessSynchDate, conQxUsers4Synch.AccessSynchDate); //处理同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.AccessSynchDate); //处理同步日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsExistUserInCurr))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsers4SynchEN.IsExistUserInCurr == true?"1":"0", conQxUsers4Synch.IsExistUserInCurr); //当前是否存在用户
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsSamePwd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsers4SynchEN.IsSamePwd == true?"1":"0", conQxUsers4Synch.IsSamePwd); //是否相同密码
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UpdDate))
 {
 if (objQxUsers4SynchEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUsers4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxUsers4Synch.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.UpdDate); //修改日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UpdUser))
 {
 if (objQxUsers4SynchEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsers4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxUsers4Synch.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.UpdUser); //修改用户
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Memo))
 {
 if (objQxUsers4SynchEN.Memo !=  null)
 {
 var strMemo = objQxUsers4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUsers4Synch.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxUsers4SynchEN.mId); 
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
 /// <param name = "objQxUsers4SynchEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxUsers4SynchEN objQxUsers4SynchEN, string strCondition)
{
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsers4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsers4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUsers4Synch Set ");
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IpAddress))
 {
 if (objQxUsers4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objQxUsers4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //IP地址
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //IP地址
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserId))
 {
 if (objQxUsers4SynchEN.UserId !=  null)
 {
 var strUserId = objQxUsers4SynchEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserName))
 {
 if (objQxUsers4SynchEN.UserName !=  null)
 {
 var strUserName = objQxUsers4SynchEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserStateId))
 {
 if (objQxUsers4SynchEN.UserStateId !=  null)
 {
 var strUserStateId = objQxUsers4SynchEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserStateId = '{0}',", strUserStateId); //用户状态Id
 }
 else
 {
 sbSQL.Append(" UserStateId = null,"); //用户状态Id
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.OpenId))
 {
 if (objQxUsers4SynchEN.OpenId !=  null)
 {
 var strOpenId = objQxUsers4SynchEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpenId = '{0}',", strOpenId); //微信openid
 }
 else
 {
 sbSQL.Append(" OpenId = null,"); //微信openid
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IdentityId))
 {
 if (objQxUsers4SynchEN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsers4SynchEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdentityId = '{0}',", strIdentityId); //身份编号
 }
 else
 {
 sbSQL.Append(" IdentityId = null,"); //身份编号
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.StuTeacherId))
 {
 if (objQxUsers4SynchEN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsers4SynchEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuTeacherId = '{0}',", strStuTeacherId); //学工号
 }
 else
 {
 sbSQL.Append(" StuTeacherId = null,"); //学工号
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Password))
 {
 if (objQxUsers4SynchEN.Password !=  null)
 {
 var strPassword = objQxUsers4SynchEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", strPassword); //口令
 }
 else
 {
 sbSQL.Append(" Password = null,"); //口令
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.PhoneNumber))
 {
 if (objQxUsers4SynchEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objQxUsers4SynchEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", strPhoneNumber); //电话号码
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //电话号码
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.DepartmentId))
 {
 if (objQxUsers4SynchEN.DepartmentId !=  null)
 {
 var strDepartmentId = objQxUsers4SynchEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentId = '{0}',", strDepartmentId); //部门Id
 }
 else
 {
 sbSQL.Append(" DepartmentId = null,"); //部门Id
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IdXzCollege))
 {
 if (objQxUsers4SynchEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objQxUsers4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //IdXzCollege
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //IdXzCollege
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.EffitiveBeginDate))
 {
 if (objQxUsers4SynchEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsers4SynchEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveBeginDate = '{0}',", strEffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.Append(" EffitiveBeginDate = null,"); //有效开始日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.EffitiveEndDate))
 {
 if (objQxUsers4SynchEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsers4SynchEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveEndDate = '{0}',", strEffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.Append(" EffitiveEndDate = null,"); //有效结束日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Email))
 {
 if (objQxUsers4SynchEN.Email !=  null)
 {
 var strEmail = objQxUsers4SynchEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //邮箱
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsArchive))
 {
 sbSQL.AppendFormat(" IsArchive = '{0}',", objQxUsers4SynchEN.IsArchive == true?"1":"0"); //是否存档
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsAccessSynch))
 {
 sbSQL.AppendFormat(" IsAccessSynch = '{0}',", objQxUsers4SynchEN.IsAccessSynch == true?"1":"0"); //是否处理同步
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.AccessSynchDate))
 {
 if (objQxUsers4SynchEN.AccessSynchDate !=  null)
 {
 var strAccessSynchDate = objQxUsers4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AccessSynchDate = '{0}',", strAccessSynchDate); //处理同步日期
 }
 else
 {
 sbSQL.Append(" AccessSynchDate = null,"); //处理同步日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsExistUserInCurr))
 {
 sbSQL.AppendFormat(" IsExistUserInCurr = '{0}',", objQxUsers4SynchEN.IsExistUserInCurr == true?"1":"0"); //当前是否存在用户
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsSamePwd))
 {
 sbSQL.AppendFormat(" IsSamePwd = '{0}',", objQxUsers4SynchEN.IsSamePwd == true?"1":"0"); //是否相同密码
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UpdDate))
 {
 if (objQxUsers4SynchEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUsers4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UpdUser))
 {
 if (objQxUsers4SynchEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsers4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Memo))
 {
 if (objQxUsers4SynchEN.Memo !=  null)
 {
 var strMemo = objQxUsers4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxUsers4SynchEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxUsers4SynchEN objQxUsers4SynchEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsers4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsers4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUsers4Synch Set ");
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IpAddress))
 {
 if (objQxUsers4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objQxUsers4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //IP地址
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //IP地址
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserId))
 {
 if (objQxUsers4SynchEN.UserId !=  null)
 {
 var strUserId = objQxUsers4SynchEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserName))
 {
 if (objQxUsers4SynchEN.UserName !=  null)
 {
 var strUserName = objQxUsers4SynchEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserStateId))
 {
 if (objQxUsers4SynchEN.UserStateId !=  null)
 {
 var strUserStateId = objQxUsers4SynchEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserStateId = '{0}',", strUserStateId); //用户状态Id
 }
 else
 {
 sbSQL.Append(" UserStateId = null,"); //用户状态Id
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.OpenId))
 {
 if (objQxUsers4SynchEN.OpenId !=  null)
 {
 var strOpenId = objQxUsers4SynchEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpenId = '{0}',", strOpenId); //微信openid
 }
 else
 {
 sbSQL.Append(" OpenId = null,"); //微信openid
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IdentityId))
 {
 if (objQxUsers4SynchEN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsers4SynchEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdentityId = '{0}',", strIdentityId); //身份编号
 }
 else
 {
 sbSQL.Append(" IdentityId = null,"); //身份编号
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.StuTeacherId))
 {
 if (objQxUsers4SynchEN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsers4SynchEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuTeacherId = '{0}',", strStuTeacherId); //学工号
 }
 else
 {
 sbSQL.Append(" StuTeacherId = null,"); //学工号
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Password))
 {
 if (objQxUsers4SynchEN.Password !=  null)
 {
 var strPassword = objQxUsers4SynchEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", strPassword); //口令
 }
 else
 {
 sbSQL.Append(" Password = null,"); //口令
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.PhoneNumber))
 {
 if (objQxUsers4SynchEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objQxUsers4SynchEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", strPhoneNumber); //电话号码
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //电话号码
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.DepartmentId))
 {
 if (objQxUsers4SynchEN.DepartmentId !=  null)
 {
 var strDepartmentId = objQxUsers4SynchEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentId = '{0}',", strDepartmentId); //部门Id
 }
 else
 {
 sbSQL.Append(" DepartmentId = null,"); //部门Id
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IdXzCollege))
 {
 if (objQxUsers4SynchEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objQxUsers4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //IdXzCollege
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //IdXzCollege
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.EffitiveBeginDate))
 {
 if (objQxUsers4SynchEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsers4SynchEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveBeginDate = '{0}',", strEffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.Append(" EffitiveBeginDate = null,"); //有效开始日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.EffitiveEndDate))
 {
 if (objQxUsers4SynchEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsers4SynchEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveEndDate = '{0}',", strEffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.Append(" EffitiveEndDate = null,"); //有效结束日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Email))
 {
 if (objQxUsers4SynchEN.Email !=  null)
 {
 var strEmail = objQxUsers4SynchEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //邮箱
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsArchive))
 {
 sbSQL.AppendFormat(" IsArchive = '{0}',", objQxUsers4SynchEN.IsArchive == true?"1":"0"); //是否存档
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsAccessSynch))
 {
 sbSQL.AppendFormat(" IsAccessSynch = '{0}',", objQxUsers4SynchEN.IsAccessSynch == true?"1":"0"); //是否处理同步
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.AccessSynchDate))
 {
 if (objQxUsers4SynchEN.AccessSynchDate !=  null)
 {
 var strAccessSynchDate = objQxUsers4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AccessSynchDate = '{0}',", strAccessSynchDate); //处理同步日期
 }
 else
 {
 sbSQL.Append(" AccessSynchDate = null,"); //处理同步日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsExistUserInCurr))
 {
 sbSQL.AppendFormat(" IsExistUserInCurr = '{0}',", objQxUsers4SynchEN.IsExistUserInCurr == true?"1":"0"); //当前是否存在用户
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsSamePwd))
 {
 sbSQL.AppendFormat(" IsSamePwd = '{0}',", objQxUsers4SynchEN.IsSamePwd == true?"1":"0"); //是否相同密码
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UpdDate))
 {
 if (objQxUsers4SynchEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUsers4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UpdUser))
 {
 if (objQxUsers4SynchEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsers4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Memo))
 {
 if (objQxUsers4SynchEN.Memo !=  null)
 {
 var strMemo = objQxUsers4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUsers4SynchEN objQxUsers4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsers4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsers4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUsers4Synch Set ");
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IpAddress))
 {
 if (objQxUsers4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objQxUsers4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conQxUsers4Synch.IpAddress); //IP地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.IpAddress); //IP地址
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserId))
 {
 if (objQxUsers4SynchEN.UserId !=  null)
 {
 var strUserId = objQxUsers4SynchEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUsers4Synch.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.UserId); //用户ID
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserName))
 {
 if (objQxUsers4SynchEN.UserName !=  null)
 {
 var strUserName = objQxUsers4SynchEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conQxUsers4Synch.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.UserName); //用户名
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UserStateId))
 {
 if (objQxUsers4SynchEN.UserStateId !=  null)
 {
 var strUserStateId = objQxUsers4SynchEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserStateId, conQxUsers4Synch.UserStateId); //用户状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.UserStateId); //用户状态Id
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.OpenId))
 {
 if (objQxUsers4SynchEN.OpenId !=  null)
 {
 var strOpenId = objQxUsers4SynchEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpenId, conQxUsers4Synch.OpenId); //微信openid
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.OpenId); //微信openid
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IdentityId))
 {
 if (objQxUsers4SynchEN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsers4SynchEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdentityId, conQxUsers4Synch.IdentityId); //身份编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.IdentityId); //身份编号
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.StuTeacherId))
 {
 if (objQxUsers4SynchEN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsers4SynchEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuTeacherId, conQxUsers4Synch.StuTeacherId); //学工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.StuTeacherId); //学工号
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Password))
 {
 if (objQxUsers4SynchEN.Password !=  null)
 {
 var strPassword = objQxUsers4SynchEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPassword, conQxUsers4Synch.Password); //口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.Password); //口令
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.PhoneNumber))
 {
 if (objQxUsers4SynchEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objQxUsers4SynchEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhoneNumber, conQxUsers4Synch.PhoneNumber); //电话号码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.PhoneNumber); //电话号码
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.DepartmentId))
 {
 if (objQxUsers4SynchEN.DepartmentId !=  null)
 {
 var strDepartmentId = objQxUsers4SynchEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentId, conQxUsers4Synch.DepartmentId); //部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.DepartmentId); //部门Id
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IdXzCollege))
 {
 if (objQxUsers4SynchEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objQxUsers4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conQxUsers4Synch.IdXzCollege); //IdXzCollege
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.IdXzCollege); //IdXzCollege
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.EffitiveBeginDate))
 {
 if (objQxUsers4SynchEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsers4SynchEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveBeginDate, conQxUsers4Synch.EffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.EffitiveBeginDate); //有效开始日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.EffitiveEndDate))
 {
 if (objQxUsers4SynchEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsers4SynchEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveEndDate, conQxUsers4Synch.EffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.EffitiveEndDate); //有效结束日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Email))
 {
 if (objQxUsers4SynchEN.Email !=  null)
 {
 var strEmail = objQxUsers4SynchEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conQxUsers4Synch.Email); //邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.Email); //邮箱
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsArchive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsers4SynchEN.IsArchive == true?"1":"0", conQxUsers4Synch.IsArchive); //是否存档
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsAccessSynch))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsers4SynchEN.IsAccessSynch == true?"1":"0", conQxUsers4Synch.IsAccessSynch); //是否处理同步
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.AccessSynchDate))
 {
 if (objQxUsers4SynchEN.AccessSynchDate !=  null)
 {
 var strAccessSynchDate = objQxUsers4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAccessSynchDate, conQxUsers4Synch.AccessSynchDate); //处理同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.AccessSynchDate); //处理同步日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsExistUserInCurr))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsers4SynchEN.IsExistUserInCurr == true?"1":"0", conQxUsers4Synch.IsExistUserInCurr); //当前是否存在用户
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.IsSamePwd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsers4SynchEN.IsSamePwd == true?"1":"0", conQxUsers4Synch.IsSamePwd); //是否相同密码
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UpdDate))
 {
 if (objQxUsers4SynchEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUsers4SynchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxUsers4Synch.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.UpdDate); //修改日期
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.UpdUser))
 {
 if (objQxUsers4SynchEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsers4SynchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxUsers4Synch.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.UpdUser); //修改用户
 }
 }
 
 if (objQxUsers4SynchEN.IsUpdated(conQxUsers4Synch.Memo))
 {
 if (objQxUsers4SynchEN.Memo !=  null)
 {
 var strMemo = objQxUsers4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUsers4Synch.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers4Synch.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxUsers4SynchEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("QxUsers4Synch_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
//删除QxUsers4Synch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUsers4Synch where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxUsers4Synch(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除QxUsers4Synch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUsers4Synch where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
//删除QxUsers4Synch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUsers4Synch where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxUsers4Synch(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: DelQxUsers4Synch)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUsers4Synch where " + strCondition ;
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
public bool DelQxUsers4SynchWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxUsers4SynchDA: DelQxUsers4SynchWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUsers4Synch where " + strCondition ;
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
 /// <param name = "objQxUsers4SynchENS">源对象</param>
 /// <param name = "objQxUsers4SynchENT">目标对象</param>
public void CopyTo(clsQxUsers4SynchEN objQxUsers4SynchENS, clsQxUsers4SynchEN objQxUsers4SynchENT)
{
objQxUsers4SynchENT.mId = objQxUsers4SynchENS.mId; //流水号
objQxUsers4SynchENT.IpAddress = objQxUsers4SynchENS.IpAddress; //IP地址
objQxUsers4SynchENT.UserId = objQxUsers4SynchENS.UserId; //用户ID
objQxUsers4SynchENT.UserName = objQxUsers4SynchENS.UserName; //用户名
objQxUsers4SynchENT.UserStateId = objQxUsers4SynchENS.UserStateId; //用户状态Id
objQxUsers4SynchENT.OpenId = objQxUsers4SynchENS.OpenId; //微信openid
objQxUsers4SynchENT.IdentityId = objQxUsers4SynchENS.IdentityId; //身份编号
objQxUsers4SynchENT.StuTeacherId = objQxUsers4SynchENS.StuTeacherId; //学工号
objQxUsers4SynchENT.Password = objQxUsers4SynchENS.Password; //口令
objQxUsers4SynchENT.PhoneNumber = objQxUsers4SynchENS.PhoneNumber; //电话号码
objQxUsers4SynchENT.DepartmentId = objQxUsers4SynchENS.DepartmentId; //部门Id
objQxUsers4SynchENT.IdXzCollege = objQxUsers4SynchENS.IdXzCollege; //IdXzCollege
objQxUsers4SynchENT.EffitiveBeginDate = objQxUsers4SynchENS.EffitiveBeginDate; //有效开始日期
objQxUsers4SynchENT.EffitiveEndDate = objQxUsers4SynchENS.EffitiveEndDate; //有效结束日期
objQxUsers4SynchENT.Email = objQxUsers4SynchENS.Email; //邮箱
objQxUsers4SynchENT.IsArchive = objQxUsers4SynchENS.IsArchive; //是否存档
objQxUsers4SynchENT.IsAccessSynch = objQxUsers4SynchENS.IsAccessSynch; //是否处理同步
objQxUsers4SynchENT.AccessSynchDate = objQxUsers4SynchENS.AccessSynchDate; //处理同步日期
objQxUsers4SynchENT.IsExistUserInCurr = objQxUsers4SynchENS.IsExistUserInCurr; //当前是否存在用户
objQxUsers4SynchENT.IsSamePwd = objQxUsers4SynchENS.IsSamePwd; //是否相同密码
objQxUsers4SynchENT.UpdDate = objQxUsers4SynchENS.UpdDate; //修改日期
objQxUsers4SynchENT.UpdUser = objQxUsers4SynchENS.UpdUser; //修改用户
objQxUsers4SynchENT.Memo = objQxUsers4SynchENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxUsers4SynchEN.UserId, conQxUsers4Synch.UserId);
clsCheckSql.CheckFieldNotNull(objQxUsers4SynchEN.UserName, conQxUsers4Synch.UserName);
clsCheckSql.CheckFieldNotNull(objQxUsers4SynchEN.UserStateId, conQxUsers4Synch.UserStateId);
clsCheckSql.CheckFieldNotNull(objQxUsers4SynchEN.Password, conQxUsers4Synch.Password);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.IpAddress, 23, conQxUsers4Synch.IpAddress);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UserId, 18, conQxUsers4Synch.UserId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UserName, 30, conQxUsers4Synch.UserName);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UserStateId, 2, conQxUsers4Synch.UserStateId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.OpenId, 50, conQxUsers4Synch.OpenId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.IdentityId, 2, conQxUsers4Synch.IdentityId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.StuTeacherId, 20, conQxUsers4Synch.StuTeacherId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.Password, 20, conQxUsers4Synch.Password);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.PhoneNumber, 15, conQxUsers4Synch.PhoneNumber);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.DepartmentId, 8, conQxUsers4Synch.DepartmentId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.IdXzCollege, 4, conQxUsers4Synch.IdXzCollege);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.EffitiveBeginDate, 14, conQxUsers4Synch.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.EffitiveEndDate, 14, conQxUsers4Synch.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.Email, 100, conQxUsers4Synch.Email);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.AccessSynchDate, 14, conQxUsers4Synch.AccessSynchDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UpdDate, 20, conQxUsers4Synch.UpdDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UpdUser, 20, conQxUsers4Synch.UpdUser);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.Memo, 1000, conQxUsers4Synch.Memo);
//检查字段外键固定长度
 objQxUsers4SynchEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.IpAddress, 23, conQxUsers4Synch.IpAddress);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UserId, 18, conQxUsers4Synch.UserId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UserName, 30, conQxUsers4Synch.UserName);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UserStateId, 2, conQxUsers4Synch.UserStateId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.OpenId, 50, conQxUsers4Synch.OpenId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.IdentityId, 2, conQxUsers4Synch.IdentityId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.StuTeacherId, 20, conQxUsers4Synch.StuTeacherId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.Password, 20, conQxUsers4Synch.Password);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.PhoneNumber, 15, conQxUsers4Synch.PhoneNumber);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.DepartmentId, 8, conQxUsers4Synch.DepartmentId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.IdXzCollege, 4, conQxUsers4Synch.IdXzCollege);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.EffitiveBeginDate, 14, conQxUsers4Synch.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.EffitiveEndDate, 14, conQxUsers4Synch.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.Email, 100, conQxUsers4Synch.Email);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.AccessSynchDate, 14, conQxUsers4Synch.AccessSynchDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UpdDate, 20, conQxUsers4Synch.UpdDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UpdUser, 20, conQxUsers4Synch.UpdUser);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.Memo, 1000, conQxUsers4Synch.Memo);
//检查外键字段长度
 objQxUsers4SynchEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.IpAddress, 23, conQxUsers4Synch.IpAddress);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UserId, 18, conQxUsers4Synch.UserId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UserName, 30, conQxUsers4Synch.UserName);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UserStateId, 2, conQxUsers4Synch.UserStateId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.OpenId, 50, conQxUsers4Synch.OpenId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.IdentityId, 2, conQxUsers4Synch.IdentityId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.StuTeacherId, 20, conQxUsers4Synch.StuTeacherId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.Password, 20, conQxUsers4Synch.Password);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.PhoneNumber, 15, conQxUsers4Synch.PhoneNumber);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.DepartmentId, 8, conQxUsers4Synch.DepartmentId);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.IdXzCollege, 4, conQxUsers4Synch.IdXzCollege);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.EffitiveBeginDate, 14, conQxUsers4Synch.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.EffitiveEndDate, 14, conQxUsers4Synch.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.Email, 100, conQxUsers4Synch.Email);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.AccessSynchDate, 14, conQxUsers4Synch.AccessSynchDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UpdDate, 20, conQxUsers4Synch.UpdDate);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.UpdUser, 20, conQxUsers4Synch.UpdUser);
clsCheckSql.CheckFieldLen(objQxUsers4SynchEN.Memo, 1000, conQxUsers4Synch.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.IpAddress, conQxUsers4Synch.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.UserId, conQxUsers4Synch.UserId);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.UserName, conQxUsers4Synch.UserName);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.UserStateId, conQxUsers4Synch.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.OpenId, conQxUsers4Synch.OpenId);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.IdentityId, conQxUsers4Synch.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.StuTeacherId, conQxUsers4Synch.StuTeacherId);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.Password, conQxUsers4Synch.Password);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.PhoneNumber, conQxUsers4Synch.PhoneNumber);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.DepartmentId, conQxUsers4Synch.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.IdXzCollege, conQxUsers4Synch.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.EffitiveBeginDate, conQxUsers4Synch.EffitiveBeginDate);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.EffitiveEndDate, conQxUsers4Synch.EffitiveEndDate);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.Email, conQxUsers4Synch.Email);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.AccessSynchDate, conQxUsers4Synch.AccessSynchDate);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.UpdDate, conQxUsers4Synch.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.UpdUser, conQxUsers4Synch.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQxUsers4SynchEN.Memo, conQxUsers4Synch.Memo);
//检查外键字段长度
 objQxUsers4SynchEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxUsers4Synch(用户4同步),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objQxUsers4SynchEN.IpAddress == null)
{
 sbCondition.AppendFormat(" and IpAddress is null");
}
else
{
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUsers4SynchEN.IpAddress);
}
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUsers4SynchEN.UserId);
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
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUsers4SynchEN._CurrTabName);
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
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUsers4SynchEN._CurrTabName, strCondition);
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
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
 objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}