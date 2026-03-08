
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserMenuDetailDA
 表名:QxUserMenuDetail(00140011)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:22:07
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
 /// 用户菜单(QxUserMenuDetail)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxUserMenuDetailDA : clsCommBase4DA
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
 return clsQxUserMenuDetailEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxUserMenuDetailEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUserMenuDetailEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxUserMenuDetailEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxUserMenuDetailEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
 strSQL = "Select * from QxUserMenuDetail where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxUserMenuDetail");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxUserMenuDetail_SelectByCond",values, "QxUserMenuDetail");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUserMenuDetail where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxUserMenuDetail");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUserMenuDetail a where {0} And a.mId not in (Select Top {2} mId From QxUserMenuDetail Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUserMenuDetail");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUserMenuDetail a where {0} And a.mId not in (Select Top {2} mId From QxUserMenuDetail Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUserMenuDetail");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUserMenuDetail a where {0} And a.mId not in (Select Top {2} mId From QxUserMenuDetail Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUserMenuDetail");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxUserMenuDetail(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTable_QxUserMenuDetail)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserMenuDetail where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserMenuDetail where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUserMenuDetail where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUserMenuDetail where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUserMenuDetail.* from QxUserMenuDetail Left Join {1} on {2} where {3} and QxUserMenuDetail.mId not in (Select top {5} QxUserMenuDetail.mId from QxUserMenuDetail Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserMenuDetail where {1} and mId not in (Select top {2} mId from QxUserMenuDetail where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserMenuDetail where {1} and mId not in (Select top {3} mId from QxUserMenuDetail where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUserMenuDetail.* from QxUserMenuDetail Left Join {1} on {2} where {3} and QxUserMenuDetail.mId not in (Select top {5} QxUserMenuDetail.mId from QxUserMenuDetail Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserMenuDetail where {1} and mId not in (Select top {2} mId from QxUserMenuDetail where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserMenuDetail where {1} and mId not in (Select top {3} mId from QxUserMenuDetail where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUserMenuDetail.* from QxUserMenuDetail Left Join {1} on {2} where {3} and QxUserMenuDetail.mId not in (Select top {5} QxUserMenuDetail.mId from QxUserMenuDetail Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserMenuDetail where {1} and mId not in (Select top {2} mId from QxUserMenuDetail where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserMenuDetail where {1} and mId not in (Select top {3} mId from QxUserMenuDetail where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUserMenuDetail a where {0} And a.mId not in (Select Top {2} mId From QxUserMenuDetail Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUserMenuDetail a where {0} And a.mId not in (Select Top {2} mId From QxUserMenuDetail Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUserMenuDetail a where {0} And a.mId not in (Select Top {2} mId From QxUserMenuDetail Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUserMenuDetail a where {0} And a.mId not in (Select Top {2} mId From QxUserMenuDetail Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetailByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUserMenuDetail_SelectByCond",values);
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
public List<clsQxUserMenuDetailEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA:GetObjLst)", objException.Message));
}
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = TransNullToInt(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = TransNullToBool(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = TransNullToBool(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = TransNullToInt(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUserMenuDetailDA: GetObjLst)", objException.Message));
}
objQxUserMenuDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUserMenuDetailEN);
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
public List<clsQxUserMenuDetailEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = TransNullToInt(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = TransNullToBool(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = TransNullToBool(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = TransNullToInt(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUserMenuDetailDA: GetObjLst)", objException.Message));
}
objQxUserMenuDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUserMenuDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxUserMenuDetailEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA:GetObjLstBySP)", objException.Message));
}
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUserMenuDetail_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = TransNullToInt(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = TransNullToBool(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = TransNullToBool(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = TransNullToInt(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxUserMenuDetailDA: GetObjLstBySP)", objException.Message));
}
objQxUserMenuDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUserMenuDetailEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUserMenuDetail(ref clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where mId = " + ""+ objQxUserMenuDetailEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxUserMenuDetailEN.mId = TransNullToInt(objDT.Rows[0][conQxUserMenuDetail.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxUserMenuDetailEN.MenuId = objDT.Rows[0][conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxUserMenuDetailEN.MenuName = objDT.Rows[0][conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxUserMenuDetailEN.IsDisp = TransNullToBool(objDT.Rows[0][conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objQxUserMenuDetailEN.UpMenuId = objDT.Rows[0][conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objQxUserMenuDetailEN.LinkFile = objDT.Rows[0][conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxUserMenuDetailEN.ImgFile = objDT.Rows[0][conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxUserMenuDetailEN.IsCustomMenu = TransNullToBool(objDT.Rows[0][conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单(字段类型:bit,字段长度:1,是否可空:False)
 objQxUserMenuDetailEN.UserId = objDT.Rows[0][conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserMenuDetailEN.QxPrjId = objDT.Rows[0][conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxUserMenuDetailEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxUserMenuDetailEN.Memo = objDT.Rows[0][conQxUserMenuDetail.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxUserMenuDetailDA: GetQxUserMenuDetail)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxUserMenuDetailEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
 objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单(字段类型:bit,字段长度:1,是否可空:False)
 objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxUserMenuDetailDA: GetObjBymId)", objException.Message));
}
return objQxUserMenuDetailEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxUserMenuDetail_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUserMenuDetailOneBySP(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxUserMenuDetailEN.mId
};
 objDT = objSQL.ExecSpReturnDT("QxUserMenuDetail_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxUserMenuDetailEN.mId = TransNullToInt(objDT.Rows[0][conQxUserMenuDetail.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxUserMenuDetailEN.MenuId = objDT.Rows[0][conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id(字段类型:char,字段长度:8,是否可空:False)
 objQxUserMenuDetailEN.MenuName = objDT.Rows[0][conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxUserMenuDetailEN.IsDisp = TransNullToBool(objDT.Rows[0][conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objQxUserMenuDetailEN.UpMenuId = objDT.Rows[0][conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id(字段类型:char,字段长度:8,是否可空:True)
 objQxUserMenuDetailEN.LinkFile = objDT.Rows[0][conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxUserMenuDetailEN.ImgFile = objDT.Rows[0][conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxUserMenuDetailEN.IsCustomMenu = TransNullToBool(objDT.Rows[0][conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单(字段类型:bit,字段长度:1,是否可空:False)
 objQxUserMenuDetailEN.UserId = objDT.Rows[0][conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserMenuDetailEN.QxPrjId = objDT.Rows[0][conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxUserMenuDetailEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxUserMenuDetailEN.Memo = objDT.Rows[0][conQxUserMenuDetail.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUserMenuDetailEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN()
{
mId = TransNullToInt(objRow[conQxUserMenuDetail.mId].ToString().Trim()), //流水号
MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(), //菜单Id
MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(), //菜单名
IsDisp = TransNullToBool(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()), //是否显示
UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(), //链接文件
ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(), //图像文件
IsCustomMenu = TransNullToBool(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()), //是否定制菜单
UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(), //用户ID
QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(), //项目Id
OrderNum = TransNullToInt(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()), //排序号
Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim() //备注
};
objQxUserMenuDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserMenuDetailEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxUserMenuDetailDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUserMenuDetailEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUserMenuDetail_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN()
{
mId = TransNullToInt(objRow[conQxUserMenuDetail.mId].ToString().Trim()), //流水号
MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(), //菜单Id
MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(), //菜单名
IsDisp = TransNullToBool(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()), //是否显示
UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(), //上级菜单Id
LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(), //链接文件
ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(), //图像文件
IsCustomMenu = TransNullToBool(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()), //是否定制菜单
UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(), //用户ID
QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(), //项目Id
OrderNum = TransNullToInt(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()), //排序号
Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim() //备注
};
objQxUserMenuDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserMenuDetailEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxUserMenuDetailEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = TransNullToInt(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = TransNullToBool(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = TransNullToBool(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = TransNullToInt(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxUserMenuDetailDA: GetObjByDataRowQxUserMenuDetail)", objException.Message));
}
objQxUserMenuDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserMenuDetailEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxUserMenuDetailEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = TransNullToInt(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = TransNullToBool(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = TransNullToBool(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = TransNullToInt(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxUserMenuDetailDA: GetObjByDataRow)", objException.Message));
}
objQxUserMenuDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserMenuDetailEN;
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
objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUserMenuDetailEN._CurrTabName, conQxUserMenuDetail.mId, 8, "");
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
objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUserMenuDetailEN._CurrTabName, conQxUserMenuDetail.mId, 8, strPrefix);
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from QxUserMenuDetail where " + strCondition;
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from QxUserMenuDetail where " + strCondition;
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUserMenuDetail", "mId = " + ""+ lngmId+""))
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxUserMenuDetail_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUserMenuDetail", strCondition))
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
objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxUserMenuDetail");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
 {
 if (objQxUserMenuDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserMenuDetailEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUserMenuDetail");
objRow = objDS.Tables["QxUserMenuDetail"].NewRow();
objRow[conQxUserMenuDetail.MenuId] = objQxUserMenuDetailEN.MenuId; //菜单Id
objRow[conQxUserMenuDetail.MenuName] = objQxUserMenuDetailEN.MenuName; //菜单名
objRow[conQxUserMenuDetail.IsDisp] = objQxUserMenuDetailEN.IsDisp; //是否显示
 if (objQxUserMenuDetailEN.UpMenuId !=  "")
 {
objRow[conQxUserMenuDetail.UpMenuId] = objQxUserMenuDetailEN.UpMenuId; //上级菜单Id
 }
 if (objQxUserMenuDetailEN.LinkFile !=  "")
 {
objRow[conQxUserMenuDetail.LinkFile] = objQxUserMenuDetailEN.LinkFile; //链接文件
 }
 if (objQxUserMenuDetailEN.ImgFile !=  "")
 {
objRow[conQxUserMenuDetail.ImgFile] = objQxUserMenuDetailEN.ImgFile; //图像文件
 }
objRow[conQxUserMenuDetail.IsCustomMenu] = objQxUserMenuDetailEN.IsCustomMenu; //是否定制菜单
objRow[conQxUserMenuDetail.UserId] = objQxUserMenuDetailEN.UserId; //用户ID
objRow[conQxUserMenuDetail.QxPrjId] = objQxUserMenuDetailEN.QxPrjId; //项目Id
objRow[conQxUserMenuDetail.OrderNum] = objQxUserMenuDetailEN.OrderNum; //排序号
 if (objQxUserMenuDetailEN.Memo !=  "")
 {
objRow[conQxUserMenuDetail.Memo] = objQxUserMenuDetailEN.Memo; //备注
 }
objDS.Tables[clsQxUserMenuDetailEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxUserMenuDetailEN._CurrTabName);
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
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 if (objQxUserMenuDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserMenuDetailEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserMenuDetailEN.MenuId  ==  "")
 {
 objQxUserMenuDetailEN.MenuId = null;
 }
 if (objQxUserMenuDetailEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.MenuId);
 var strMenuId = objQxUserMenuDetailEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxUserMenuDetailEN.MenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.MenuName);
 var strMenuName = objQxUserMenuDetailEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuName + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.IsDisp);
 arrValueListForInsert.Add("'" + (objQxUserMenuDetailEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objQxUserMenuDetailEN.UpMenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.UpMenuId);
 var strUpMenuId = objQxUserMenuDetailEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpMenuId + "'");
 }
 
 if (objQxUserMenuDetailEN.LinkFile !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.LinkFile);
 var strLinkFile = objQxUserMenuDetailEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkFile + "'");
 }
 
 if (objQxUserMenuDetailEN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.ImgFile);
 var strImgFile = objQxUserMenuDetailEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.IsCustomMenu);
 arrValueListForInsert.Add("'" + (objQxUserMenuDetailEN.IsCustomMenu  ==  false ? "0" : "1") + "'");
 
 if (objQxUserMenuDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.UserId);
 var strUserId = objQxUserMenuDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserMenuDetailEN.QxPrjId  ==  "")
 {
 objQxUserMenuDetailEN.QxPrjId = null;
 }
 if (objQxUserMenuDetailEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.QxPrjId);
 var strQxPrjId = objQxUserMenuDetailEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.OrderNum);
 arrValueListForInsert.Add(objQxUserMenuDetailEN.OrderNum.ToString());
 
 if (objQxUserMenuDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.Memo);
 var strMemo = objQxUserMenuDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserMenuDetail");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 if (objQxUserMenuDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserMenuDetailEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserMenuDetailEN.MenuId  ==  "")
 {
 objQxUserMenuDetailEN.MenuId = null;
 }
 if (objQxUserMenuDetailEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.MenuId);
 var strMenuId = objQxUserMenuDetailEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxUserMenuDetailEN.MenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.MenuName);
 var strMenuName = objQxUserMenuDetailEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuName + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.IsDisp);
 arrValueListForInsert.Add("'" + (objQxUserMenuDetailEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objQxUserMenuDetailEN.UpMenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.UpMenuId);
 var strUpMenuId = objQxUserMenuDetailEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpMenuId + "'");
 }
 
 if (objQxUserMenuDetailEN.LinkFile !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.LinkFile);
 var strLinkFile = objQxUserMenuDetailEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkFile + "'");
 }
 
 if (objQxUserMenuDetailEN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.ImgFile);
 var strImgFile = objQxUserMenuDetailEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.IsCustomMenu);
 arrValueListForInsert.Add("'" + (objQxUserMenuDetailEN.IsCustomMenu  ==  false ? "0" : "1") + "'");
 
 if (objQxUserMenuDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.UserId);
 var strUserId = objQxUserMenuDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserMenuDetailEN.QxPrjId  ==  "")
 {
 objQxUserMenuDetailEN.QxPrjId = null;
 }
 if (objQxUserMenuDetailEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.QxPrjId);
 var strQxPrjId = objQxUserMenuDetailEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.OrderNum);
 arrValueListForInsert.Add(objQxUserMenuDetailEN.OrderNum.ToString());
 
 if (objQxUserMenuDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.Memo);
 var strMemo = objQxUserMenuDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserMenuDetail");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUserMenuDetailEN objQxUserMenuDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserMenuDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserMenuDetailEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserMenuDetailEN.MenuId  ==  "")
 {
 objQxUserMenuDetailEN.MenuId = null;
 }
 if (objQxUserMenuDetailEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.MenuId);
 var strMenuId = objQxUserMenuDetailEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxUserMenuDetailEN.MenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.MenuName);
 var strMenuName = objQxUserMenuDetailEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuName + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.IsDisp);
 arrValueListForInsert.Add("'" + (objQxUserMenuDetailEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objQxUserMenuDetailEN.UpMenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.UpMenuId);
 var strUpMenuId = objQxUserMenuDetailEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpMenuId + "'");
 }
 
 if (objQxUserMenuDetailEN.LinkFile !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.LinkFile);
 var strLinkFile = objQxUserMenuDetailEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkFile + "'");
 }
 
 if (objQxUserMenuDetailEN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.ImgFile);
 var strImgFile = objQxUserMenuDetailEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.IsCustomMenu);
 arrValueListForInsert.Add("'" + (objQxUserMenuDetailEN.IsCustomMenu  ==  false ? "0" : "1") + "'");
 
 if (objQxUserMenuDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.UserId);
 var strUserId = objQxUserMenuDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserMenuDetailEN.QxPrjId  ==  "")
 {
 objQxUserMenuDetailEN.QxPrjId = null;
 }
 if (objQxUserMenuDetailEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.QxPrjId);
 var strQxPrjId = objQxUserMenuDetailEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.OrderNum);
 arrValueListForInsert.Add(objQxUserMenuDetailEN.OrderNum.ToString());
 
 if (objQxUserMenuDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.Memo);
 var strMemo = objQxUserMenuDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserMenuDetail");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUserMenuDetailEN objQxUserMenuDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQxUserMenuDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserMenuDetailEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserMenuDetailEN.MenuId  ==  "")
 {
 objQxUserMenuDetailEN.MenuId = null;
 }
 if (objQxUserMenuDetailEN.MenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.MenuId);
 var strMenuId = objQxUserMenuDetailEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuId + "'");
 }
 
 if (objQxUserMenuDetailEN.MenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.MenuName);
 var strMenuName = objQxUserMenuDetailEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuName + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.IsDisp);
 arrValueListForInsert.Add("'" + (objQxUserMenuDetailEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objQxUserMenuDetailEN.UpMenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.UpMenuId);
 var strUpMenuId = objQxUserMenuDetailEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpMenuId + "'");
 }
 
 if (objQxUserMenuDetailEN.LinkFile !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.LinkFile);
 var strLinkFile = objQxUserMenuDetailEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkFile + "'");
 }
 
 if (objQxUserMenuDetailEN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.ImgFile);
 var strImgFile = objQxUserMenuDetailEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.IsCustomMenu);
 arrValueListForInsert.Add("'" + (objQxUserMenuDetailEN.IsCustomMenu  ==  false ? "0" : "1") + "'");
 
 if (objQxUserMenuDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.UserId);
 var strUserId = objQxUserMenuDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserMenuDetailEN.QxPrjId  ==  "")
 {
 objQxUserMenuDetailEN.QxPrjId = null;
 }
 if (objQxUserMenuDetailEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.QxPrjId);
 var strQxPrjId = objQxUserMenuDetailEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserMenuDetail.OrderNum);
 arrValueListForInsert.Add(objQxUserMenuDetailEN.OrderNum.ToString());
 
 if (objQxUserMenuDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserMenuDetail.Memo);
 var strMemo = objQxUserMenuDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserMenuDetail");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxUserMenuDetailBySP(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUserMenuDetailEN.MenuId,
 objQxUserMenuDetailEN.MenuName,
 objQxUserMenuDetailEN.IsDisp,
 objQxUserMenuDetailEN.UpMenuId,
 objQxUserMenuDetailEN.LinkFile,
 objQxUserMenuDetailEN.ImgFile,
 objQxUserMenuDetailEN.IsCustomMenu,
 objQxUserMenuDetailEN.UserId,
 objQxUserMenuDetailEN.QxPrjId,
 objQxUserMenuDetailEN.OrderNum,
objQxUserMenuDetailEN.Memo
};
 objSQL.ExecSP("QxUserMenuDetail_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxUserMenuDetails(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUserMenuDetail");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxUserMenuDetailEN._CurrTabName ].NewRow();
objRow[conQxUserMenuDetail.MenuId] = oRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objRow[conQxUserMenuDetail.MenuName] = oRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objRow[conQxUserMenuDetail.IsDisp] = oRow[conQxUserMenuDetail.IsDisp].ToString().Trim(); //是否显示
objRow[conQxUserMenuDetail.UpMenuId] = oRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objRow[conQxUserMenuDetail.LinkFile] = oRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objRow[conQxUserMenuDetail.ImgFile] = oRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objRow[conQxUserMenuDetail.IsCustomMenu] = oRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim(); //是否定制菜单
objRow[conQxUserMenuDetail.UserId] = oRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objRow[conQxUserMenuDetail.QxPrjId] = oRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxUserMenuDetail.OrderNum] = oRow[conQxUserMenuDetail.OrderNum].ToString().Trim(); //排序号
objRow[conQxUserMenuDetail.Memo] = oRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxUserMenuDetailEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxUserMenuDetailEN._CurrTabName);
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
 /// <param name = "objQxUserMenuDetailEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 if (objQxUserMenuDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserMenuDetailEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserMenuDetail where mId = " + ""+ objQxUserMenuDetailEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxUserMenuDetailEN._CurrTabName);
if (objDS.Tables[clsQxUserMenuDetailEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objQxUserMenuDetailEN.mId+"");
return false;
}
objRow = objDS.Tables[clsQxUserMenuDetailEN._CurrTabName].Rows[0];
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.MenuId))
 {
objRow[conQxUserMenuDetail.MenuId] = objQxUserMenuDetailEN.MenuId; //菜单Id
 }
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.MenuName))
 {
objRow[conQxUserMenuDetail.MenuName] = objQxUserMenuDetailEN.MenuName; //菜单名
 }
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.IsDisp))
 {
objRow[conQxUserMenuDetail.IsDisp] = objQxUserMenuDetailEN.IsDisp; //是否显示
 }
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.UpMenuId))
 {
objRow[conQxUserMenuDetail.UpMenuId] = objQxUserMenuDetailEN.UpMenuId; //上级菜单Id
 }
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.LinkFile))
 {
objRow[conQxUserMenuDetail.LinkFile] = objQxUserMenuDetailEN.LinkFile; //链接文件
 }
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.ImgFile))
 {
objRow[conQxUserMenuDetail.ImgFile] = objQxUserMenuDetailEN.ImgFile; //图像文件
 }
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.IsCustomMenu))
 {
objRow[conQxUserMenuDetail.IsCustomMenu] = objQxUserMenuDetailEN.IsCustomMenu; //是否定制菜单
 }
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.UserId))
 {
objRow[conQxUserMenuDetail.UserId] = objQxUserMenuDetailEN.UserId; //用户ID
 }
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.QxPrjId))
 {
objRow[conQxUserMenuDetail.QxPrjId] = objQxUserMenuDetailEN.QxPrjId; //项目Id
 }
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.OrderNum))
 {
objRow[conQxUserMenuDetail.OrderNum] = objQxUserMenuDetailEN.OrderNum; //排序号
 }
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.Memo))
 {
objRow[conQxUserMenuDetail.Memo] = objQxUserMenuDetailEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxUserMenuDetailEN._CurrTabName);
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
public bool UpdateBySP(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 if (objQxUserMenuDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserMenuDetailEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUserMenuDetailEN.mId,
 objQxUserMenuDetailEN.MenuId,
 objQxUserMenuDetailEN.MenuName,
 objQxUserMenuDetailEN.IsDisp,
 objQxUserMenuDetailEN.UpMenuId,
 objQxUserMenuDetailEN.LinkFile,
 objQxUserMenuDetailEN.ImgFile,
 objQxUserMenuDetailEN.IsCustomMenu,
 objQxUserMenuDetailEN.UserId,
 objQxUserMenuDetailEN.QxPrjId,
 objQxUserMenuDetailEN.OrderNum,
 objQxUserMenuDetailEN.Memo
};
 objSQL.ExecSP("QxUserMenuDetail_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 if (objQxUserMenuDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserMenuDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxUserMenuDetail Set ");
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.MenuId))
 {
 if (objQxUserMenuDetailEN.MenuId  ==  "")
 {
 objQxUserMenuDetailEN.MenuId = null;
 }
 if (objQxUserMenuDetailEN.MenuId !=  null)
 {
 var strMenuId = objQxUserMenuDetailEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId, conQxUserMenuDetail.MenuId); //菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.MenuId); //菜单Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.MenuName))
 {
 if (objQxUserMenuDetailEN.MenuName !=  null)
 {
 var strMenuName = objQxUserMenuDetailEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuName, conQxUserMenuDetail.MenuName); //菜单名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.MenuName); //菜单名
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.IsDisp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUserMenuDetailEN.IsDisp == true?"1":"0", conQxUserMenuDetail.IsDisp); //是否显示
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.UpMenuId))
 {
 if (objQxUserMenuDetailEN.UpMenuId !=  null)
 {
 var strUpMenuId = objQxUserMenuDetailEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpMenuId, conQxUserMenuDetail.UpMenuId); //上级菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.UpMenuId); //上级菜单Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.LinkFile))
 {
 if (objQxUserMenuDetailEN.LinkFile !=  null)
 {
 var strLinkFile = objQxUserMenuDetailEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkFile, conQxUserMenuDetail.LinkFile); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.LinkFile); //链接文件
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.ImgFile))
 {
 if (objQxUserMenuDetailEN.ImgFile !=  null)
 {
 var strImgFile = objQxUserMenuDetailEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImgFile, conQxUserMenuDetail.ImgFile); //图像文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.ImgFile); //图像文件
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.IsCustomMenu))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUserMenuDetailEN.IsCustomMenu == true?"1":"0", conQxUserMenuDetail.IsCustomMenu); //是否定制菜单
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.UserId))
 {
 if (objQxUserMenuDetailEN.UserId !=  null)
 {
 var strUserId = objQxUserMenuDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUserMenuDetail.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.UserId); //用户ID
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.QxPrjId))
 {
 if (objQxUserMenuDetailEN.QxPrjId  ==  "")
 {
 objQxUserMenuDetailEN.QxPrjId = null;
 }
 if (objQxUserMenuDetailEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxUserMenuDetailEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxUserMenuDetail.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.QxPrjId); //项目Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxUserMenuDetailEN.OrderNum, conQxUserMenuDetail.OrderNum); //排序号
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.Memo))
 {
 if (objQxUserMenuDetailEN.Memo !=  null)
 {
 var strMemo = objQxUserMenuDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUserMenuDetail.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxUserMenuDetailEN.mId); 
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
 /// <param name = "objQxUserMenuDetailEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strCondition)
{
 if (objQxUserMenuDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserMenuDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserMenuDetail Set ");
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.MenuId))
 {
 if (objQxUserMenuDetailEN.MenuId  ==  "")
 {
 objQxUserMenuDetailEN.MenuId = null;
 }
 if (objQxUserMenuDetailEN.MenuId !=  null)
 {
 var strMenuId = objQxUserMenuDetailEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId = '{0}',", strMenuId); //菜单Id
 }
 else
 {
 sbSQL.Append(" MenuId = null,"); //菜单Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.MenuName))
 {
 if (objQxUserMenuDetailEN.MenuName !=  null)
 {
 var strMenuName = objQxUserMenuDetailEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuName = '{0}',", strMenuName); //菜单名
 }
 else
 {
 sbSQL.Append(" MenuName = null,"); //菜单名
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.IsDisp))
 {
 sbSQL.AppendFormat(" IsDisp = '{0}',", objQxUserMenuDetailEN.IsDisp == true?"1":"0"); //是否显示
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.UpMenuId))
 {
 if (objQxUserMenuDetailEN.UpMenuId !=  null)
 {
 var strUpMenuId = objQxUserMenuDetailEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpMenuId = '{0}',", strUpMenuId); //上级菜单Id
 }
 else
 {
 sbSQL.Append(" UpMenuId = null,"); //上级菜单Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.LinkFile))
 {
 if (objQxUserMenuDetailEN.LinkFile !=  null)
 {
 var strLinkFile = objQxUserMenuDetailEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkFile = '{0}',", strLinkFile); //链接文件
 }
 else
 {
 sbSQL.Append(" LinkFile = null,"); //链接文件
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.ImgFile))
 {
 if (objQxUserMenuDetailEN.ImgFile !=  null)
 {
 var strImgFile = objQxUserMenuDetailEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImgFile = '{0}',", strImgFile); //图像文件
 }
 else
 {
 sbSQL.Append(" ImgFile = null,"); //图像文件
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.IsCustomMenu))
 {
 sbSQL.AppendFormat(" IsCustomMenu = '{0}',", objQxUserMenuDetailEN.IsCustomMenu == true?"1":"0"); //是否定制菜单
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.UserId))
 {
 if (objQxUserMenuDetailEN.UserId !=  null)
 {
 var strUserId = objQxUserMenuDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.QxPrjId))
 {
 if (objQxUserMenuDetailEN.QxPrjId  ==  "")
 {
 objQxUserMenuDetailEN.QxPrjId = null;
 }
 if (objQxUserMenuDetailEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxUserMenuDetailEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxUserMenuDetailEN.OrderNum); //排序号
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.Memo))
 {
 if (objQxUserMenuDetailEN.Memo !=  null)
 {
 var strMemo = objQxUserMenuDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxUserMenuDetailEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserMenuDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserMenuDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserMenuDetail Set ");
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.MenuId))
 {
 if (objQxUserMenuDetailEN.MenuId  ==  "")
 {
 objQxUserMenuDetailEN.MenuId = null;
 }
 if (objQxUserMenuDetailEN.MenuId !=  null)
 {
 var strMenuId = objQxUserMenuDetailEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuId = '{0}',", strMenuId); //菜单Id
 }
 else
 {
 sbSQL.Append(" MenuId = null,"); //菜单Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.MenuName))
 {
 if (objQxUserMenuDetailEN.MenuName !=  null)
 {
 var strMenuName = objQxUserMenuDetailEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuName = '{0}',", strMenuName); //菜单名
 }
 else
 {
 sbSQL.Append(" MenuName = null,"); //菜单名
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.IsDisp))
 {
 sbSQL.AppendFormat(" IsDisp = '{0}',", objQxUserMenuDetailEN.IsDisp == true?"1":"0"); //是否显示
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.UpMenuId))
 {
 if (objQxUserMenuDetailEN.UpMenuId !=  null)
 {
 var strUpMenuId = objQxUserMenuDetailEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpMenuId = '{0}',", strUpMenuId); //上级菜单Id
 }
 else
 {
 sbSQL.Append(" UpMenuId = null,"); //上级菜单Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.LinkFile))
 {
 if (objQxUserMenuDetailEN.LinkFile !=  null)
 {
 var strLinkFile = objQxUserMenuDetailEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkFile = '{0}',", strLinkFile); //链接文件
 }
 else
 {
 sbSQL.Append(" LinkFile = null,"); //链接文件
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.ImgFile))
 {
 if (objQxUserMenuDetailEN.ImgFile !=  null)
 {
 var strImgFile = objQxUserMenuDetailEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImgFile = '{0}',", strImgFile); //图像文件
 }
 else
 {
 sbSQL.Append(" ImgFile = null,"); //图像文件
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.IsCustomMenu))
 {
 sbSQL.AppendFormat(" IsCustomMenu = '{0}',", objQxUserMenuDetailEN.IsCustomMenu == true?"1":"0"); //是否定制菜单
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.UserId))
 {
 if (objQxUserMenuDetailEN.UserId !=  null)
 {
 var strUserId = objQxUserMenuDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.QxPrjId))
 {
 if (objQxUserMenuDetailEN.QxPrjId  ==  "")
 {
 objQxUserMenuDetailEN.QxPrjId = null;
 }
 if (objQxUserMenuDetailEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxUserMenuDetailEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxUserMenuDetailEN.OrderNum); //排序号
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.Memo))
 {
 if (objQxUserMenuDetailEN.Memo !=  null)
 {
 var strMemo = objQxUserMenuDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUserMenuDetailEN objQxUserMenuDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQxUserMenuDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserMenuDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserMenuDetail Set ");
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.MenuId))
 {
 if (objQxUserMenuDetailEN.MenuId  ==  "")
 {
 objQxUserMenuDetailEN.MenuId = null;
 }
 if (objQxUserMenuDetailEN.MenuId !=  null)
 {
 var strMenuId = objQxUserMenuDetailEN.MenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuId, conQxUserMenuDetail.MenuId); //菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.MenuId); //菜单Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.MenuName))
 {
 if (objQxUserMenuDetailEN.MenuName !=  null)
 {
 var strMenuName = objQxUserMenuDetailEN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuName, conQxUserMenuDetail.MenuName); //菜单名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.MenuName); //菜单名
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.IsDisp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUserMenuDetailEN.IsDisp == true?"1":"0", conQxUserMenuDetail.IsDisp); //是否显示
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.UpMenuId))
 {
 if (objQxUserMenuDetailEN.UpMenuId !=  null)
 {
 var strUpMenuId = objQxUserMenuDetailEN.UpMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpMenuId, conQxUserMenuDetail.UpMenuId); //上级菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.UpMenuId); //上级菜单Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.LinkFile))
 {
 if (objQxUserMenuDetailEN.LinkFile !=  null)
 {
 var strLinkFile = objQxUserMenuDetailEN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkFile, conQxUserMenuDetail.LinkFile); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.LinkFile); //链接文件
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.ImgFile))
 {
 if (objQxUserMenuDetailEN.ImgFile !=  null)
 {
 var strImgFile = objQxUserMenuDetailEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImgFile, conQxUserMenuDetail.ImgFile); //图像文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.ImgFile); //图像文件
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.IsCustomMenu))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUserMenuDetailEN.IsCustomMenu == true?"1":"0", conQxUserMenuDetail.IsCustomMenu); //是否定制菜单
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.UserId))
 {
 if (objQxUserMenuDetailEN.UserId !=  null)
 {
 var strUserId = objQxUserMenuDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUserMenuDetail.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.UserId); //用户ID
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.QxPrjId))
 {
 if (objQxUserMenuDetailEN.QxPrjId  ==  "")
 {
 objQxUserMenuDetailEN.QxPrjId = null;
 }
 if (objQxUserMenuDetailEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxUserMenuDetailEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxUserMenuDetail.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.QxPrjId); //项目Id
 }
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxUserMenuDetailEN.OrderNum, conQxUserMenuDetail.OrderNum); //排序号
 }
 
 if (objQxUserMenuDetailEN.IsUpdated(conQxUserMenuDetail.Memo))
 {
 if (objQxUserMenuDetailEN.Memo !=  null)
 {
 var strMemo = objQxUserMenuDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUserMenuDetail.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserMenuDetail.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxUserMenuDetailEN.mId); 
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("QxUserMenuDetail_Delete", values);
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
//删除QxUserMenuDetail本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserMenuDetail where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxUserMenuDetail(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
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
//删除QxUserMenuDetail本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserMenuDetail where mId in (" + strKeyList + ")";
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
//删除QxUserMenuDetail本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserMenuDetail where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxUserMenuDetail(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: DelQxUserMenuDetail)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUserMenuDetail where " + strCondition ;
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
public bool DelQxUserMenuDetailWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxUserMenuDetailDA: DelQxUserMenuDetailWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUserMenuDetail where " + strCondition ;
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
 /// <param name = "objQxUserMenuDetailENS">源对象</param>
 /// <param name = "objQxUserMenuDetailENT">目标对象</param>
public void CopyTo(clsQxUserMenuDetailEN objQxUserMenuDetailENS, clsQxUserMenuDetailEN objQxUserMenuDetailENT)
{
objQxUserMenuDetailENT.mId = objQxUserMenuDetailENS.mId; //流水号
objQxUserMenuDetailENT.MenuId = objQxUserMenuDetailENS.MenuId; //菜单Id
objQxUserMenuDetailENT.MenuName = objQxUserMenuDetailENS.MenuName; //菜单名
objQxUserMenuDetailENT.IsDisp = objQxUserMenuDetailENS.IsDisp; //是否显示
objQxUserMenuDetailENT.UpMenuId = objQxUserMenuDetailENS.UpMenuId; //上级菜单Id
objQxUserMenuDetailENT.LinkFile = objQxUserMenuDetailENS.LinkFile; //链接文件
objQxUserMenuDetailENT.ImgFile = objQxUserMenuDetailENS.ImgFile; //图像文件
objQxUserMenuDetailENT.IsCustomMenu = objQxUserMenuDetailENS.IsCustomMenu; //是否定制菜单
objQxUserMenuDetailENT.UserId = objQxUserMenuDetailENS.UserId; //用户ID
objQxUserMenuDetailENT.QxPrjId = objQxUserMenuDetailENS.QxPrjId; //项目Id
objQxUserMenuDetailENT.OrderNum = objQxUserMenuDetailENS.OrderNum; //排序号
objQxUserMenuDetailENT.Memo = objQxUserMenuDetailENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxUserMenuDetailEN.MenuId, conQxUserMenuDetail.MenuId);
clsCheckSql.CheckFieldNotNull(objQxUserMenuDetailEN.MenuName, conQxUserMenuDetail.MenuName);
clsCheckSql.CheckFieldNotNull(objQxUserMenuDetailEN.IsDisp, conQxUserMenuDetail.IsDisp);
clsCheckSql.CheckFieldNotNull(objQxUserMenuDetailEN.IsCustomMenu, conQxUserMenuDetail.IsCustomMenu);
clsCheckSql.CheckFieldNotNull(objQxUserMenuDetailEN.UserId, conQxUserMenuDetail.UserId);
clsCheckSql.CheckFieldNotNull(objQxUserMenuDetailEN.QxPrjId, conQxUserMenuDetail.QxPrjId);
clsCheckSql.CheckFieldNotNull(objQxUserMenuDetailEN.OrderNum, conQxUserMenuDetail.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.MenuId, 8, conQxUserMenuDetail.MenuId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.MenuName, 50, conQxUserMenuDetail.MenuName);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.UpMenuId, 8, conQxUserMenuDetail.UpMenuId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.LinkFile, 500, conQxUserMenuDetail.LinkFile);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.ImgFile, 300, conQxUserMenuDetail.ImgFile);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.UserId, 18, conQxUserMenuDetail.UserId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.QxPrjId, 4, conQxUserMenuDetail.QxPrjId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.Memo, 1000, conQxUserMenuDetail.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxUserMenuDetailEN.MenuId, 8, conQxUserMenuDetail.MenuId);
clsCheckSql.CheckFieldForeignKey(objQxUserMenuDetailEN.QxPrjId, 4, conQxUserMenuDetail.QxPrjId);
 objQxUserMenuDetailEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.MenuId, 8, conQxUserMenuDetail.MenuId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.MenuName, 50, conQxUserMenuDetail.MenuName);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.UpMenuId, 8, conQxUserMenuDetail.UpMenuId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.LinkFile, 500, conQxUserMenuDetail.LinkFile);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.ImgFile, 300, conQxUserMenuDetail.ImgFile);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.UserId, 18, conQxUserMenuDetail.UserId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.QxPrjId, 4, conQxUserMenuDetail.QxPrjId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.Memo, 1000, conQxUserMenuDetail.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxUserMenuDetailEN.MenuId, 8, conQxUserMenuDetail.MenuId);
clsCheckSql.CheckFieldForeignKey(objQxUserMenuDetailEN.QxPrjId, 4, conQxUserMenuDetail.QxPrjId);
 objQxUserMenuDetailEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.MenuId, 8, conQxUserMenuDetail.MenuId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.MenuName, 50, conQxUserMenuDetail.MenuName);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.UpMenuId, 8, conQxUserMenuDetail.UpMenuId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.LinkFile, 500, conQxUserMenuDetail.LinkFile);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.ImgFile, 300, conQxUserMenuDetail.ImgFile);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.UserId, 18, conQxUserMenuDetail.UserId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.QxPrjId, 4, conQxUserMenuDetail.QxPrjId);
clsCheckSql.CheckFieldLen(objQxUserMenuDetailEN.Memo, 1000, conQxUserMenuDetail.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxUserMenuDetailEN.MenuId, conQxUserMenuDetail.MenuId);
clsCheckSql.CheckSqlInjection4Field(objQxUserMenuDetailEN.MenuName, conQxUserMenuDetail.MenuName);
clsCheckSql.CheckSqlInjection4Field(objQxUserMenuDetailEN.UpMenuId, conQxUserMenuDetail.UpMenuId);
clsCheckSql.CheckSqlInjection4Field(objQxUserMenuDetailEN.LinkFile, conQxUserMenuDetail.LinkFile);
clsCheckSql.CheckSqlInjection4Field(objQxUserMenuDetailEN.ImgFile, conQxUserMenuDetail.ImgFile);
clsCheckSql.CheckSqlInjection4Field(objQxUserMenuDetailEN.UserId, conQxUserMenuDetail.UserId);
clsCheckSql.CheckSqlInjection4Field(objQxUserMenuDetailEN.QxPrjId, conQxUserMenuDetail.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxUserMenuDetailEN.Memo, conQxUserMenuDetail.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxUserMenuDetailEN.MenuId, 8, conQxUserMenuDetail.MenuId);
clsCheckSql.CheckFieldForeignKey(objQxUserMenuDetailEN.QxPrjId, 4, conQxUserMenuDetail.QxPrjId);
 objQxUserMenuDetailEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxUserMenuDetail(用户菜单),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserMenuDetailEN.UserId);
 sbCondition.AppendFormat(" and MenuId = '{0}'", objQxUserMenuDetailEN.MenuId);
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUserMenuDetailEN._CurrTabName);
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUserMenuDetailEN._CurrTabName, strCondition);
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
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
 objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}