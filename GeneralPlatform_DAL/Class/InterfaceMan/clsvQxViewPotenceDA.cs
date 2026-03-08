
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxViewPotenceDA
 表名:vQxViewPotence(00140028)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:43:53
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:界面管理(InterfaceMan)
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
 /// v界面权限(vQxViewPotence)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxViewPotenceDA : clsCommBase4DA
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
 return clsvQxViewPotenceEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxViewPotenceEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxViewPotenceEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxViewPotenceEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxViewPotenceEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
 strSQL = "Select * from vQxViewPotence where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxViewPotence");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxViewPotence_SelectByCond",values, "vQxViewPotence");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxViewPotence where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxViewPotence");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxViewPotence a where {0} And a.mId not in (Select Top {2} mId From vQxViewPotence Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxViewPotence");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxViewPotence a where {0} And a.mId not in (Select Top {2} mId From vQxViewPotence Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxViewPotence");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxViewPotence a where {0} And a.mId not in (Select Top {2} mId From vQxViewPotence Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxViewPotence");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
strSQL = "Select * from vQxViewPotence where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxViewPotence(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTable_vQxViewPotence)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
strSQL = "Select * from vQxViewPotence where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
strSQL = "Select * from vQxViewPotence where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
strSQL = "Select * from vQxViewPotence where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxViewPotence where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxViewPotence where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxViewPotence where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxViewPotence where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxViewPotence.* from vQxViewPotence Left Join {1} on {2} where {3} and vQxViewPotence.mId not in (Select top {5} vQxViewPotence.mId from vQxViewPotence Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxViewPotence where {1} and mId not in (Select top {2} mId from vQxViewPotence where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxViewPotence where {1} and mId not in (Select top {3} mId from vQxViewPotence where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxViewPotence.* from vQxViewPotence Left Join {1} on {2} where {3} and vQxViewPotence.mId not in (Select top {5} vQxViewPotence.mId from vQxViewPotence Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxViewPotence where {1} and mId not in (Select top {2} mId from vQxViewPotence where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxViewPotence where {1} and mId not in (Select top {3} mId from vQxViewPotence where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxViewPotence.* from vQxViewPotence Left Join {1} on {2} where {3} and vQxViewPotence.mId not in (Select top {5} vQxViewPotence.mId from vQxViewPotence Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxViewPotence where {1} and mId not in (Select top {2} mId from vQxViewPotence where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxViewPotence where {1} and mId not in (Select top {3} mId from vQxViewPotence where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxViewPotence a where {0} And a.mId not in (Select Top {2} mId From vQxViewPotence Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxViewPotence a where {0} And a.mId not in (Select Top {2} mId From vQxViewPotence Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxViewPotence a where {0} And a.mId not in (Select Top {2} mId From vQxViewPotence Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxViewPotence a where {0} And a.mId not in (Select Top {2} mId From vQxViewPotence Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxViewPotenceDA: GetvQxViewPotenceByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
strSQL = "Select * from vQxViewPotence where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxViewPotence_SelectByCond",values);
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
public List<clsvQxViewPotenceEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA:GetObjLst)", objException.Message));
}
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
strSQL = "Select * from vQxViewPotence where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = TransNullToInt(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = TransNullToInt(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxViewPotenceDA: GetObjLst)", objException.Message));
}
objvQxViewPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxViewPotenceEN);
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
public List<clsvQxViewPotenceEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = TransNullToInt(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = TransNullToInt(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxViewPotenceDA: GetObjLst)", objException.Message));
}
objvQxViewPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxViewPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxViewPotenceEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxViewPotence_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = TransNullToInt(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = TransNullToInt(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxViewPotenceDA: GetObjLstBySP)", objException.Message));
}
objvQxViewPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxViewPotenceEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxViewPotence(ref clsvQxViewPotenceEN objvQxViewPotenceEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
strSQL = "Select * from vQxViewPotence where mId = " + ""+ objvQxViewPotenceEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxViewPotenceEN.mId = TransNullToInt(objDT.Rows[0][convQxViewPotence.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxViewPotenceEN.QxPrjId = objDT.Rows[0][convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxViewPotenceEN.PotenceId = objDT.Rows[0][convQxViewPotence.PotenceId].ToString().Trim(); //权限ID(字段类型:char,字段长度:8,是否可空:False)
 objvQxViewPotenceEN.PotenceName = objDT.Rows[0][convQxViewPotence.PotenceName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxViewPotenceEN.PrjName = objDT.Rows[0][convQxViewPotence.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxViewPotenceEN.ViewId = objDT.Rows[0][convQxViewPotence.ViewId].ToString().Trim(); //界面编号(字段类型:char,字段长度:8,是否可空:True)
 objvQxViewPotenceEN.ViewName = objDT.Rows[0][convQxViewPotence.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxViewPotenceEN.Level = TransNullToInt(objDT.Rows[0][convQxViewPotence.Level].ToString().Trim()); //等级(字段类型:int,字段长度:4,是否可空:False)
 objvQxViewPotenceEN.ModuleId = objDT.Rows[0][convQxViewPotence.ModuleId].ToString().Trim(); //模块号(字段类型:char,字段长度:6,是否可空:False)
 objvQxViewPotenceEN.ModuleName = objDT.Rows[0][convQxViewPotence.ModuleName].ToString().Trim(); //模块名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxViewPotenceEN.Memo = objDT.Rows[0][convQxViewPotence.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxViewPotenceDA: GetvQxViewPotence)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxViewPotenceEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
strSQL = "Select * from vQxViewPotence where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
 objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID(字段类型:char,字段长度:8,是否可空:False)
 objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号(字段类型:char,字段长度:8,是否可空:True)
 objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级(字段类型:int,字段长度:4,是否可空:False)
 objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号(字段类型:char,字段长度:6,是否可空:False)
 objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxViewPotenceDA: GetObjBymId)", objException.Message));
}
return objvQxViewPotenceEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxViewPotence_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxViewPotenceOneBySP(clsvQxViewPotenceEN objvQxViewPotenceEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxViewPotenceEN.mId
};
 objDT = objSQL.ExecSpReturnDT("vQxViewPotence_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxViewPotenceEN.mId = TransNullToInt(objDT.Rows[0][convQxViewPotence.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxViewPotenceEN.QxPrjId = objDT.Rows[0][convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxViewPotenceEN.PotenceId = objDT.Rows[0][convQxViewPotence.PotenceId].ToString().Trim(); //权限ID(字段类型:char,字段长度:8,是否可空:False)
 objvQxViewPotenceEN.PotenceName = objDT.Rows[0][convQxViewPotence.PotenceName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxViewPotenceEN.PrjName = objDT.Rows[0][convQxViewPotence.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxViewPotenceEN.ViewId = objDT.Rows[0][convQxViewPotence.ViewId].ToString().Trim(); //界面编号(字段类型:char,字段长度:8,是否可空:True)
 objvQxViewPotenceEN.ViewName = objDT.Rows[0][convQxViewPotence.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxViewPotenceEN.Level = TransNullToInt(objDT.Rows[0][convQxViewPotence.Level].ToString().Trim()); //等级(字段类型:int,字段长度:4,是否可空:False)
 objvQxViewPotenceEN.ModuleId = objDT.Rows[0][convQxViewPotence.ModuleId].ToString().Trim(); //模块号(字段类型:char,字段长度:6,是否可空:False)
 objvQxViewPotenceEN.ModuleName = objDT.Rows[0][convQxViewPotence.ModuleName].ToString().Trim(); //模块名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxViewPotenceEN.Memo = objDT.Rows[0][convQxViewPotence.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxViewPotenceEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
strSQL = "Select * from vQxViewPotence where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN()
{
mId = TransNullToInt(objRow[convQxViewPotence.mId].ToString().Trim()), //流水号
QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(), //项目Id
PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(), //权限ID
PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(), //权限名称
PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(), //工程名
ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(), //界面编号
ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(), //界面名称
Level = TransNullToInt(objRow[convQxViewPotence.Level].ToString().Trim()), //等级
ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(), //模块号
ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(), //模块名称
Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim() //备注
};
objvQxViewPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxViewPotenceEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxViewPotenceDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxViewPotenceEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxViewPotence_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN()
{
mId = TransNullToInt(objRow[convQxViewPotence.mId].ToString().Trim()), //流水号
QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(), //项目Id
PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(), //权限ID
PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(), //权限名称
PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(), //工程名
ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(), //界面编号
ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(), //界面名称
Level = TransNullToInt(objRow[convQxViewPotence.Level].ToString().Trim()), //等级
ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(), //模块号
ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(), //模块名称
Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim() //备注
};
objvQxViewPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxViewPotenceEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxViewPotenceEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = TransNullToInt(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = TransNullToInt(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxViewPotenceDA: GetObjByDataRowvQxViewPotence)", objException.Message));
}
objvQxViewPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxViewPotenceEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxViewPotenceEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = TransNullToInt(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = TransNullToInt(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxViewPotenceDA: GetObjByDataRow)", objException.Message));
}
objvQxViewPotenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxViewPotenceEN;
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
objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxViewPotenceEN._CurrTabName, convQxViewPotence.mId, 8, "");
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
objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxViewPotenceEN._CurrTabName, convQxViewPotence.mId, 8, strPrefix);
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
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vQxViewPotence where " + strCondition;
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
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vQxViewPotence where " + strCondition;
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
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxViewPotence", "mId = " + ""+ lngmId+""))
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
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxViewPotence_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxViewPotenceDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxViewPotence", strCondition))
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
objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxViewPotence");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxViewPotenceENS">源对象</param>
 /// <param name = "objvQxViewPotenceENT">目标对象</param>
public void CopyTo(clsvQxViewPotenceEN objvQxViewPotenceENS, clsvQxViewPotenceEN objvQxViewPotenceENT)
{
objvQxViewPotenceENT.mId = objvQxViewPotenceENS.mId; //流水号
objvQxViewPotenceENT.QxPrjId = objvQxViewPotenceENS.QxPrjId; //项目Id
objvQxViewPotenceENT.PotenceId = objvQxViewPotenceENS.PotenceId; //权限ID
objvQxViewPotenceENT.PotenceName = objvQxViewPotenceENS.PotenceName; //权限名称
objvQxViewPotenceENT.PrjName = objvQxViewPotenceENS.PrjName; //工程名
objvQxViewPotenceENT.ViewId = objvQxViewPotenceENS.ViewId; //界面编号
objvQxViewPotenceENT.ViewName = objvQxViewPotenceENS.ViewName; //界面名称
objvQxViewPotenceENT.Level = objvQxViewPotenceENS.Level; //等级
objvQxViewPotenceENT.ModuleId = objvQxViewPotenceENS.ModuleId; //模块号
objvQxViewPotenceENT.ModuleName = objvQxViewPotenceENS.ModuleName; //模块名称
objvQxViewPotenceENT.Memo = objvQxViewPotenceENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxViewPotenceEN objvQxViewPotenceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxViewPotenceEN.QxPrjId, 4, convQxViewPotence.QxPrjId);
clsCheckSql.CheckFieldLen(objvQxViewPotenceEN.PotenceId, 8, convQxViewPotence.PotenceId);
clsCheckSql.CheckFieldLen(objvQxViewPotenceEN.PotenceName, 200, convQxViewPotence.PotenceName);
clsCheckSql.CheckFieldLen(objvQxViewPotenceEN.PrjName, 30, convQxViewPotence.PrjName);
clsCheckSql.CheckFieldLen(objvQxViewPotenceEN.ViewId, 8, convQxViewPotence.ViewId);
clsCheckSql.CheckFieldLen(objvQxViewPotenceEN.ViewName, 100, convQxViewPotence.ViewName);
clsCheckSql.CheckFieldLen(objvQxViewPotenceEN.ModuleId, 6, convQxViewPotence.ModuleId);
clsCheckSql.CheckFieldLen(objvQxViewPotenceEN.ModuleName, 100, convQxViewPotence.ModuleName);
clsCheckSql.CheckFieldLen(objvQxViewPotenceEN.Memo, 1000, convQxViewPotence.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxViewPotenceEN.QxPrjId, convQxViewPotence.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objvQxViewPotenceEN.PotenceId, convQxViewPotence.PotenceId);
clsCheckSql.CheckSqlInjection4Field(objvQxViewPotenceEN.PotenceName, convQxViewPotence.PotenceName);
clsCheckSql.CheckSqlInjection4Field(objvQxViewPotenceEN.PrjName, convQxViewPotence.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvQxViewPotenceEN.ViewId, convQxViewPotence.ViewId);
clsCheckSql.CheckSqlInjection4Field(objvQxViewPotenceEN.ViewName, convQxViewPotence.ViewName);
clsCheckSql.CheckSqlInjection4Field(objvQxViewPotenceEN.ModuleId, convQxViewPotence.ModuleId);
clsCheckSql.CheckSqlInjection4Field(objvQxViewPotenceEN.ModuleName, convQxViewPotence.ModuleName);
clsCheckSql.CheckSqlInjection4Field(objvQxViewPotenceEN.Memo, convQxViewPotence.Memo);
//检查外键字段长度
 objvQxViewPotenceEN._IsCheckProperty = true;
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
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
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
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
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
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxViewPotenceEN._CurrTabName);
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
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxViewPotenceEN._CurrTabName, strCondition);
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
 objSQL = clsvQxViewPotenceDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}