
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersDA
 表名:QxUsers(00140015)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:14:04
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
 /// 用户(QxUsers)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxUsersDA : clsCommBase4DA
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
 return clsQxUsersEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxUsersEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUsersEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxUsersEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxUsersEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strUserId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strUserId)
{
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("(errid:Data000001)在表:QxUsers中,检查关键字,长度不正确!(clsQxUsersDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxUsers中,关键字不能为空 或 null!(clsQxUsersDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxUsersDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strUserId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strUserId)
{
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18 + 4)
{
throw new Exception("(errid:Data000004)在表:QxUsers中,检查关键字,长度不正确!(简化版)(clsQxUsersDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxUsers中,关键字不能为空 或 null!(clsQxUsersDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxUsersDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
 strSQL = "Select * from QxUsers where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxUsers");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxUsers_SelectByCond",values, "QxUsers");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUsers where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxUsers");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUsers a where {0} And a.UserId not in (Select Top {2} UserId From QxUsers Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUsers");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUsers a where {0} And a.UserId not in (Select Top {2} UserId From QxUsers Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUsers");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUsers a where {0} And a.UserId not in (Select Top {2} UserId From QxUsers Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUsers");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxUsers(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTable_QxUsers)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsers where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsers where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUsers where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUsers where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUsers.* from QxUsers Left Join {1} on {2} where {3} and QxUsers.UserId not in (Select top {5} QxUsers.UserId from QxUsers Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsers where {1} and UserId not in (Select top {2} UserId from QxUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsers where {1} and UserId not in (Select top {3} UserId from QxUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUsers.* from QxUsers Left Join {1} on {2} where {3} and QxUsers.UserId not in (Select top {5} QxUsers.UserId from QxUsers Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsers where {1} and UserId not in (Select top {2} UserId from QxUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsers where {1} and UserId not in (Select top {3} UserId from QxUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUsers.* from QxUsers Left Join {1} on {2} where {3} and QxUsers.UserId not in (Select top {5} QxUsers.UserId from QxUsers Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUsers where {1} and UserId not in (Select top {2} UserId from QxUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUsers where {1} and UserId not in (Select top {3} UserId from QxUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUsers a where {0} And a.UserId not in (Select Top {2} UserId From QxUsers Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUsers a where {0} And a.UserId not in (Select Top {2} UserId From QxUsers Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUsers a where {0} And a.UserId not in (Select Top {2} UserId From QxUsers Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUsers a where {0} And a.UserId not in (Select Top {2} UserId From QxUsers Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUsersDA: GetQxUsersByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxUsersDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUsers_SelectByCond",values);
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
public List<clsQxUsersEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxUsersDA:GetObjLst)", objException.Message));
}
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = TransNullToBool(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = TransNullToBool(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUsersDA: GetObjLst)", objException.Message));
}
objQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUsersEN);
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
public List<clsQxUsersEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxUsersDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = TransNullToBool(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = TransNullToBool(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUsersDA: GetObjLst)", objException.Message));
}
objQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxUsersEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxUsersDA:GetObjLstBySP)", objException.Message));
}
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUsers_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = TransNullToBool(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = TransNullToBool(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxUsersDA: GetObjLstBySP)", objException.Message));
}
objQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUsersEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUsers(ref clsQxUsersEN objQxUsersEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where UserId = " + "'"+ objQxUsersEN.UserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxUsersEN.UserId = objDT.Rows[0][conQxUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUsersEN.UserName = objDT.Rows[0][conQxUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsersEN.DepartmentId = objDT.Rows[0][conQxUsers.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objQxUsersEN.UserStateId = objDT.Rows[0][conQxUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objQxUsersEN.Password = objDT.Rows[0][conQxUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersEN.EffitiveBeginDate = objDT.Rows[0][conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersEN.EffitiveEndDate = objDT.Rows[0][conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersEN.StuTeacherId = objDT.Rows[0][conQxUsers.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersEN.IdentityId = objDT.Rows[0][conQxUsers.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objQxUsersEN.IsArchive = TransNullToBool(objDT.Rows[0][conQxUsers.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsersEN.OpenId = objDT.Rows[0][conQxUsers.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objQxUsersEN.Email = objDT.Rows[0][conQxUsers.Email].ToString().Trim(); //邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersEN.PhoneNumber = objDT.Rows[0][conQxUsers.PhoneNumber].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objQxUsersEN.IsSynch = TransNullToBool(objDT.Rows[0][conQxUsers.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsersEN.SynchDate = objDT.Rows[0][conQxUsers.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:True)
 objQxUsersEN.DetailInfoTab = objDT.Rows[0][conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表(字段类型:varchar,字段长度:30,是否可空:True)
 objQxUsersEN.IdGradeBase = objDT.Rows[0][conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objQxUsersEN.IdSchool = objDT.Rows[0][conQxUsers.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objQxUsersEN.IdXzCollege = objDT.Rows[0][conQxUsers.IdXzCollege].ToString().Trim(); //学院Id(字段类型:char,字段长度:4,是否可空:True)
 objQxUsersEN.UpdDate = objDT.Rows[0][conQxUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersEN.UpdUser = objDT.Rows[0][conQxUsers.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersEN.Memo = objDT.Rows[0][conQxUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxUsersDA: GetQxUsers)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxUsersEN GetObjByUserId(string strUserId)
{
CheckPrimaryKey(strUserId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where UserId = " + "'"+ strUserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
 objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:True)
 objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表(字段类型:varchar,字段长度:30,是否可空:True)
 objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id(字段类型:char,字段长度:4,是否可空:True)
 objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxUsersDA: GetObjByUserId)", objException.Message));
}
return objQxUsersEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxUsers_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUsersOneBySP(clsQxUsersEN objQxUsersEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxUsersEN.UserId
};
 objDT = objSQL.ExecSpReturnDT("QxUsers_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxUsersEN.UserId = objDT.Rows[0][conQxUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUsersEN.UserName = objDT.Rows[0][conQxUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objQxUsersEN.DepartmentId = objDT.Rows[0][conQxUsers.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objQxUsersEN.UserStateId = objDT.Rows[0][conQxUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objQxUsersEN.Password = objDT.Rows[0][conQxUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersEN.EffitiveBeginDate = objDT.Rows[0][conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersEN.EffitiveEndDate = objDT.Rows[0][conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objQxUsersEN.StuTeacherId = objDT.Rows[0][conQxUsers.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersEN.IdentityId = objDT.Rows[0][conQxUsers.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objQxUsersEN.IsArchive = TransNullToBool(objDT.Rows[0][conQxUsers.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsersEN.OpenId = objDT.Rows[0][conQxUsers.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objQxUsersEN.Email = objDT.Rows[0][conQxUsers.Email].ToString().Trim(); //邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objQxUsersEN.PhoneNumber = objDT.Rows[0][conQxUsers.PhoneNumber].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objQxUsersEN.IsSynch = TransNullToBool(objDT.Rows[0][conQxUsers.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:True)
 objQxUsersEN.SynchDate = objDT.Rows[0][conQxUsers.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:True)
 objQxUsersEN.DetailInfoTab = objDT.Rows[0][conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表(字段类型:varchar,字段长度:30,是否可空:True)
 objQxUsersEN.IdGradeBase = objDT.Rows[0][conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objQxUsersEN.IdSchool = objDT.Rows[0][conQxUsers.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objQxUsersEN.IdXzCollege = objDT.Rows[0][conQxUsers.IdXzCollege].ToString().Trim(); //学院Id(字段类型:char,字段长度:4,是否可空:True)
 objQxUsersEN.UpdDate = objDT.Rows[0][conQxUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxUsersEN.UpdUser = objDT.Rows[0][conQxUsers.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUsersEN.Memo = objDT.Rows[0][conQxUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUsersEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxUsersDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN()
{
UserId = objRow[conQxUsers.UserId].ToString().Trim(), //用户ID
UserName = objRow[conQxUsers.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(), //部门Id
UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(), //用户状态Id
Password = objRow[conQxUsers.Password].ToString().Trim(), //口令
EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(), //有效结束日期
StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(), //学工号
IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(), //身份编号
IsArchive = TransNullToBool(objRow[conQxUsers.IsArchive].ToString().Trim()), //是否存档
OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(), //微信openid
Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(), //邮箱
PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(), //电话号码
IsSynch = TransNullToBool(objRow[conQxUsers.IsSynch].ToString().Trim()), //是否同步
SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(), //同步日期
DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(), //详细信息表
IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(), //年级流水号
IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(), //学校流水号
IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(), //学院Id
UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim() //备注
};
objQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsersEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxUsersDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUsersEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxUsersDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUsers_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN()
{
UserId = objRow[conQxUsers.UserId].ToString().Trim(), //用户ID
UserName = objRow[conQxUsers.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(), //部门Id
UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(), //用户状态Id
Password = objRow[conQxUsers.Password].ToString().Trim(), //口令
EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(), //有效结束日期
StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(), //学工号
IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(), //身份编号
IsArchive = TransNullToBool(objRow[conQxUsers.IsArchive].ToString().Trim()), //是否存档
OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(), //微信openid
Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(), //邮箱
PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(), //电话号码
IsSynch = TransNullToBool(objRow[conQxUsers.IsSynch].ToString().Trim()), //是否同步
SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(), //同步日期
DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(), //详细信息表
IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(), //年级流水号
IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(), //学校流水号
IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(), //学院Id
UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim() //备注
};
objQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsersEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxUsersEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = TransNullToBool(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = TransNullToBool(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxUsersDA: GetObjByDataRowQxUsers)", objException.Message));
}
objQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsersEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxUsersEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = TransNullToBool(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = TransNullToBool(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxUsersDA: GetObjByDataRow)", objException.Message));
}
objQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUsersEN;
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
objSQL = clsQxUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUsersEN._CurrTabName, conQxUsers.UserId, 18, "");
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
objSQL = clsQxUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUsersEN._CurrTabName, conQxUsers.UserId, 18, strPrefix);
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
 objSQL = clsQxUsersDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserId from QxUsers where " + strCondition;
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
 objSQL = clsQxUsersDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserId from QxUsers where " + strCondition;
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strUserId)
{
CheckPrimaryKey(strUserId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUsers", "UserId = " + "'"+ strUserId+"'"))
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strUserId)
{
CheckPrimaryKey(strUserId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strUserId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxUsers_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxUsersDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUsers", strCondition))
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
objSQL = clsQxUsersDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxUsers");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxUsersEN objQxUsersEN)
 {
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsersEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUsers");
objRow = objDS.Tables["QxUsers"].NewRow();
objRow[conQxUsers.UserId] = objQxUsersEN.UserId; //用户ID
objRow[conQxUsers.UserName] = objQxUsersEN.UserName; //用户名
 if (objQxUsersEN.DepartmentId !=  "")
 {
objRow[conQxUsers.DepartmentId] = objQxUsersEN.DepartmentId; //部门Id
 }
objRow[conQxUsers.UserStateId] = objQxUsersEN.UserStateId; //用户状态Id
objRow[conQxUsers.Password] = objQxUsersEN.Password; //口令
 if (objQxUsersEN.EffitiveBeginDate !=  "")
 {
objRow[conQxUsers.EffitiveBeginDate] = objQxUsersEN.EffitiveBeginDate; //有效开始日期
 }
 if (objQxUsersEN.EffitiveEndDate !=  "")
 {
objRow[conQxUsers.EffitiveEndDate] = objQxUsersEN.EffitiveEndDate; //有效结束日期
 }
 if (objQxUsersEN.StuTeacherId !=  "")
 {
objRow[conQxUsers.StuTeacherId] = objQxUsersEN.StuTeacherId; //学工号
 }
 if (objQxUsersEN.IdentityId !=  "")
 {
objRow[conQxUsers.IdentityId] = objQxUsersEN.IdentityId; //身份编号
 }
objRow[conQxUsers.IsArchive] = objQxUsersEN.IsArchive; //是否存档
 if (objQxUsersEN.OpenId !=  "")
 {
objRow[conQxUsers.OpenId] = objQxUsersEN.OpenId; //微信openid
 }
 if (objQxUsersEN.Email !=  "")
 {
objRow[conQxUsers.Email] = objQxUsersEN.Email; //邮箱
 }
 if (objQxUsersEN.PhoneNumber !=  "")
 {
objRow[conQxUsers.PhoneNumber] = objQxUsersEN.PhoneNumber; //电话号码
 }
objRow[conQxUsers.IsSynch] = objQxUsersEN.IsSynch; //是否同步
 if (objQxUsersEN.SynchDate !=  "")
 {
objRow[conQxUsers.SynchDate] = objQxUsersEN.SynchDate; //同步日期
 }
 if (objQxUsersEN.DetailInfoTab !=  "")
 {
objRow[conQxUsers.DetailInfoTab] = objQxUsersEN.DetailInfoTab; //详细信息表
 }
 if (objQxUsersEN.IdGradeBase !=  "")
 {
objRow[conQxUsers.IdGradeBase] = objQxUsersEN.IdGradeBase; //年级流水号
 }
 if (objQxUsersEN.IdSchool !=  "")
 {
objRow[conQxUsers.IdSchool] = objQxUsersEN.IdSchool; //学校流水号
 }
 if (objQxUsersEN.IdXzCollege !=  "")
 {
objRow[conQxUsers.IdXzCollege] = objQxUsersEN.IdXzCollege; //学院Id
 }
 if (objQxUsersEN.UpdDate !=  "")
 {
objRow[conQxUsers.UpdDate] = objQxUsersEN.UpdDate; //修改日期
 }
 if (objQxUsersEN.UpdUser !=  "")
 {
objRow[conQxUsers.UpdUser] = objQxUsersEN.UpdUser; //修改用户
 }
 if (objQxUsersEN.Memo !=  "")
 {
objRow[conQxUsers.Memo] = objQxUsersEN.Memo; //备注
 }
objDS.Tables[clsQxUsersEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxUsersEN._CurrTabName);
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
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUsersEN objQxUsersEN)
{
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserId);
 var strUserId = objQxUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserName);
 var strUserName = objQxUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.DepartmentId);
 var strDepartmentId = objQxUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxUsersEN.UserStateId  ==  "")
 {
 objQxUsersEN.UserStateId = null;
 }
 if (objQxUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserStateId);
 var strUserStateId = objQxUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objQxUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Password);
 var strPassword = objQxUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsersEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsersEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsersEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.StuTeacherId);
 var strStuTeacherId = objQxUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsersEN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdentityId);
 var strIdentityId = objQxUsersEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsersEN.IsArchive  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersEN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.OpenId);
 var strOpenId = objQxUsersEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Email);
 var strEmail = objQxUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objQxUsersEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.PhoneNumber);
 var strPhoneNumber = objQxUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers.IsSynch);
 arrValueListForInsert.Add("'" + (objQxUsersEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.SynchDate);
 var strSynchDate = objQxUsersEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 
 if (objQxUsersEN.DetailInfoTab !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.DetailInfoTab);
 var strDetailInfoTab = objQxUsersEN.DetailInfoTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailInfoTab + "'");
 }
 
 if (objQxUsersEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdGradeBase);
 var strIdGradeBase = objQxUsersEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objQxUsersEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdSchool);
 var strIdSchool = objQxUsersEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objQxUsersEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdXzCollege);
 var strIdXzCollege = objQxUsersEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objQxUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UpdDate);
 var strUpdDate = objQxUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UpdUser);
 var strUpdUser = objQxUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Memo);
 var strMemo = objQxUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsers");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUsersEN objQxUsersEN)
{
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserId);
 var strUserId = objQxUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserName);
 var strUserName = objQxUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.DepartmentId);
 var strDepartmentId = objQxUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxUsersEN.UserStateId  ==  "")
 {
 objQxUsersEN.UserStateId = null;
 }
 if (objQxUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserStateId);
 var strUserStateId = objQxUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objQxUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Password);
 var strPassword = objQxUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsersEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsersEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsersEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.StuTeacherId);
 var strStuTeacherId = objQxUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsersEN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdentityId);
 var strIdentityId = objQxUsersEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsersEN.IsArchive  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersEN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.OpenId);
 var strOpenId = objQxUsersEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Email);
 var strEmail = objQxUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objQxUsersEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.PhoneNumber);
 var strPhoneNumber = objQxUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers.IsSynch);
 arrValueListForInsert.Add("'" + (objQxUsersEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.SynchDate);
 var strSynchDate = objQxUsersEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 
 if (objQxUsersEN.DetailInfoTab !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.DetailInfoTab);
 var strDetailInfoTab = objQxUsersEN.DetailInfoTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailInfoTab + "'");
 }
 
 if (objQxUsersEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdGradeBase);
 var strIdGradeBase = objQxUsersEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objQxUsersEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdSchool);
 var strIdSchool = objQxUsersEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objQxUsersEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdXzCollege);
 var strIdXzCollege = objQxUsersEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objQxUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UpdDate);
 var strUpdDate = objQxUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UpdUser);
 var strUpdUser = objQxUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Memo);
 var strMemo = objQxUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsers");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxUsersEN.UserId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUsersEN objQxUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserId);
 var strUserId = objQxUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserName);
 var strUserName = objQxUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.DepartmentId);
 var strDepartmentId = objQxUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxUsersEN.UserStateId  ==  "")
 {
 objQxUsersEN.UserStateId = null;
 }
 if (objQxUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserStateId);
 var strUserStateId = objQxUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objQxUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Password);
 var strPassword = objQxUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsersEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsersEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsersEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.StuTeacherId);
 var strStuTeacherId = objQxUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsersEN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdentityId);
 var strIdentityId = objQxUsersEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsersEN.IsArchive  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersEN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.OpenId);
 var strOpenId = objQxUsersEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Email);
 var strEmail = objQxUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objQxUsersEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.PhoneNumber);
 var strPhoneNumber = objQxUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers.IsSynch);
 arrValueListForInsert.Add("'" + (objQxUsersEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.SynchDate);
 var strSynchDate = objQxUsersEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 
 if (objQxUsersEN.DetailInfoTab !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.DetailInfoTab);
 var strDetailInfoTab = objQxUsersEN.DetailInfoTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailInfoTab + "'");
 }
 
 if (objQxUsersEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdGradeBase);
 var strIdGradeBase = objQxUsersEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objQxUsersEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdSchool);
 var strIdSchool = objQxUsersEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objQxUsersEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdXzCollege);
 var strIdXzCollege = objQxUsersEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objQxUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UpdDate);
 var strUpdDate = objQxUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UpdUser);
 var strUpdUser = objQxUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Memo);
 var strMemo = objQxUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsers");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objQxUsersEN.UserId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUsersEN objQxUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUsersEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserId);
 var strUserId = objQxUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserName);
 var strUserName = objQxUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objQxUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.DepartmentId);
 var strDepartmentId = objQxUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxUsersEN.UserStateId  ==  "")
 {
 objQxUsersEN.UserStateId = null;
 }
 if (objQxUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UserStateId);
 var strUserStateId = objQxUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objQxUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Password);
 var strPassword = objQxUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objQxUsersEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.EffitiveBeginDate);
 var strEffitiveBeginDate = objQxUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objQxUsersEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.EffitiveEndDate);
 var strEffitiveEndDate = objQxUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objQxUsersEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.StuTeacherId);
 var strStuTeacherId = objQxUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuTeacherId + "'");
 }
 
 if (objQxUsersEN.IdentityId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdentityId);
 var strIdentityId = objQxUsersEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers.IsArchive);
 arrValueListForInsert.Add("'" + (objQxUsersEN.IsArchive  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersEN.OpenId !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.OpenId);
 var strOpenId = objQxUsersEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenId + "'");
 }
 
 if (objQxUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Email);
 var strEmail = objQxUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objQxUsersEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.PhoneNumber);
 var strPhoneNumber = objQxUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 arrFieldListForInsert.Add(conQxUsers.IsSynch);
 arrValueListForInsert.Add("'" + (objQxUsersEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objQxUsersEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.SynchDate);
 var strSynchDate = objQxUsersEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 
 if (objQxUsersEN.DetailInfoTab !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.DetailInfoTab);
 var strDetailInfoTab = objQxUsersEN.DetailInfoTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailInfoTab + "'");
 }
 
 if (objQxUsersEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdGradeBase);
 var strIdGradeBase = objQxUsersEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objQxUsersEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdSchool);
 var strIdSchool = objQxUsersEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objQxUsersEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.IdXzCollege);
 var strIdXzCollege = objQxUsersEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objQxUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UpdDate);
 var strUpdDate = objQxUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.UpdUser);
 var strUpdUser = objQxUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUsers.Memo);
 var strMemo = objQxUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUsers");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxUsersBySP(clsQxUsersEN objQxUsersEN)
{
//通过存储过程来
//直接使用
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUsersEN.UserId,
 objQxUsersEN.UserName,
 objQxUsersEN.DepartmentId,
 objQxUsersEN.UserStateId,
 objQxUsersEN.Password,
 objQxUsersEN.EffitiveBeginDate,
 objQxUsersEN.EffitiveEndDate,
 objQxUsersEN.StuTeacherId,
 objQxUsersEN.IdentityId,
 objQxUsersEN.IsArchive,
 objQxUsersEN.OpenId,
 objQxUsersEN.Email,
 objQxUsersEN.PhoneNumber,
 objQxUsersEN.IsSynch,
 objQxUsersEN.SynchDate,
 objQxUsersEN.DetailInfoTab,
 objQxUsersEN.IdGradeBase,
 objQxUsersEN.IdSchool,
 objQxUsersEN.IdXzCollege,
 objQxUsersEN.UpdDate,
 objQxUsersEN.UpdUser,
objQxUsersEN.Memo
};
 objSQL.ExecSP("QxUsers_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxUserss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where UserId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUsers");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strUserId = oRow[conQxUsers.UserId].ToString().Trim();
if (IsExist(strUserId))
{
 string strResult = "关键字变量值为:" + string.Format("UserId = {0}", strUserId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxUsersEN._CurrTabName ].NewRow();
objRow[conQxUsers.UserId] = oRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objRow[conQxUsers.UserName] = oRow[conQxUsers.UserName].ToString().Trim(); //用户名
objRow[conQxUsers.DepartmentId] = oRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objRow[conQxUsers.UserStateId] = oRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objRow[conQxUsers.Password] = oRow[conQxUsers.Password].ToString().Trim(); //口令
objRow[conQxUsers.EffitiveBeginDate] = oRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objRow[conQxUsers.EffitiveEndDate] = oRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objRow[conQxUsers.StuTeacherId] = oRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objRow[conQxUsers.IdentityId] = oRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objRow[conQxUsers.IsArchive] = oRow[conQxUsers.IsArchive].ToString().Trim(); //是否存档
objRow[conQxUsers.OpenId] = oRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objRow[conQxUsers.Email] = oRow[conQxUsers.Email].ToString().Trim(); //邮箱
objRow[conQxUsers.PhoneNumber] = oRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objRow[conQxUsers.IsSynch] = oRow[conQxUsers.IsSynch].ToString().Trim(); //是否同步
objRow[conQxUsers.SynchDate] = oRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objRow[conQxUsers.DetailInfoTab] = oRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objRow[conQxUsers.IdGradeBase] = oRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objRow[conQxUsers.IdSchool] = oRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objRow[conQxUsers.IdXzCollege] = oRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objRow[conQxUsers.UpdDate] = oRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objRow[conQxUsers.UpdUser] = oRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objRow[conQxUsers.Memo] = oRow[conQxUsers.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxUsersEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxUsersEN._CurrTabName);
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
 /// <param name = "objQxUsersEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxUsersEN objQxUsersEN)
{
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from QxUsers where UserId = " + "'"+ objQxUsersEN.UserId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxUsersEN._CurrTabName);
if (objDS.Tables[clsQxUsersEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:UserId = " + "'"+ objQxUsersEN.UserId+"'");
return false;
}
objRow = objDS.Tables[clsQxUsersEN._CurrTabName].Rows[0];
 if (objQxUsersEN.IsUpdated(conQxUsers.UserId))
 {
objRow[conQxUsers.UserId] = objQxUsersEN.UserId; //用户ID
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.UserName))
 {
objRow[conQxUsers.UserName] = objQxUsersEN.UserName; //用户名
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.DepartmentId))
 {
objRow[conQxUsers.DepartmentId] = objQxUsersEN.DepartmentId; //部门Id
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.UserStateId))
 {
objRow[conQxUsers.UserStateId] = objQxUsersEN.UserStateId; //用户状态Id
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.Password))
 {
objRow[conQxUsers.Password] = objQxUsersEN.Password; //口令
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.EffitiveBeginDate))
 {
objRow[conQxUsers.EffitiveBeginDate] = objQxUsersEN.EffitiveBeginDate; //有效开始日期
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.EffitiveEndDate))
 {
objRow[conQxUsers.EffitiveEndDate] = objQxUsersEN.EffitiveEndDate; //有效结束日期
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.StuTeacherId))
 {
objRow[conQxUsers.StuTeacherId] = objQxUsersEN.StuTeacherId; //学工号
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.IdentityId))
 {
objRow[conQxUsers.IdentityId] = objQxUsersEN.IdentityId; //身份编号
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.IsArchive))
 {
objRow[conQxUsers.IsArchive] = objQxUsersEN.IsArchive; //是否存档
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.OpenId))
 {
objRow[conQxUsers.OpenId] = objQxUsersEN.OpenId; //微信openid
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.Email))
 {
objRow[conQxUsers.Email] = objQxUsersEN.Email; //邮箱
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.PhoneNumber))
 {
objRow[conQxUsers.PhoneNumber] = objQxUsersEN.PhoneNumber; //电话号码
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.IsSynch))
 {
objRow[conQxUsers.IsSynch] = objQxUsersEN.IsSynch; //是否同步
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.SynchDate))
 {
objRow[conQxUsers.SynchDate] = objQxUsersEN.SynchDate; //同步日期
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.DetailInfoTab))
 {
objRow[conQxUsers.DetailInfoTab] = objQxUsersEN.DetailInfoTab; //详细信息表
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.IdGradeBase))
 {
objRow[conQxUsers.IdGradeBase] = objQxUsersEN.IdGradeBase; //年级流水号
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.IdSchool))
 {
objRow[conQxUsers.IdSchool] = objQxUsersEN.IdSchool; //学校流水号
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.IdXzCollege))
 {
objRow[conQxUsers.IdXzCollege] = objQxUsersEN.IdXzCollege; //学院Id
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.UpdDate))
 {
objRow[conQxUsers.UpdDate] = objQxUsersEN.UpdDate; //修改日期
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.UpdUser))
 {
objRow[conQxUsers.UpdUser] = objQxUsersEN.UpdUser; //修改用户
 }
 if (objQxUsersEN.IsUpdated(conQxUsers.Memo))
 {
objRow[conQxUsers.Memo] = objQxUsersEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxUsersEN._CurrTabName);
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
public bool UpdateBySP(clsQxUsersEN objQxUsersEN)
{
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUsersEN.UserId,
 objQxUsersEN.UserName,
 objQxUsersEN.DepartmentId,
 objQxUsersEN.UserStateId,
 objQxUsersEN.Password,
 objQxUsersEN.EffitiveBeginDate,
 objQxUsersEN.EffitiveEndDate,
 objQxUsersEN.StuTeacherId,
 objQxUsersEN.IdentityId,
 objQxUsersEN.IsArchive,
 objQxUsersEN.OpenId,
 objQxUsersEN.Email,
 objQxUsersEN.PhoneNumber,
 objQxUsersEN.IsSynch,
 objQxUsersEN.SynchDate,
 objQxUsersEN.DetailInfoTab,
 objQxUsersEN.IdGradeBase,
 objQxUsersEN.IdSchool,
 objQxUsersEN.IdXzCollege,
 objQxUsersEN.UpdDate,
 objQxUsersEN.UpdUser,
 objQxUsersEN.Memo
};
 objSQL.ExecSP("QxUsers_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUsersEN objQxUsersEN)
{
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxUsers Set ");
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UserName))
 {
 if (objQxUsersEN.UserName !=  null)
 {
 var strUserName = objQxUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conQxUsers.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.UserName); //用户名
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.DepartmentId))
 {
 if (objQxUsersEN.DepartmentId !=  null)
 {
 var strDepartmentId = objQxUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentId, conQxUsers.DepartmentId); //部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.DepartmentId); //部门Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UserStateId))
 {
 if (objQxUsersEN.UserStateId  ==  "")
 {
 objQxUsersEN.UserStateId = null;
 }
 if (objQxUsersEN.UserStateId !=  null)
 {
 var strUserStateId = objQxUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserStateId, conQxUsers.UserStateId); //用户状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.UserStateId); //用户状态Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Password))
 {
 if (objQxUsersEN.Password !=  null)
 {
 var strPassword = objQxUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPassword, conQxUsers.Password); //口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.Password); //口令
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.EffitiveBeginDate))
 {
 if (objQxUsersEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveBeginDate, conQxUsers.EffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.EffitiveBeginDate); //有效开始日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.EffitiveEndDate))
 {
 if (objQxUsersEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveEndDate, conQxUsers.EffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.EffitiveEndDate); //有效结束日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.StuTeacherId))
 {
 if (objQxUsersEN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuTeacherId, conQxUsers.StuTeacherId); //学工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.StuTeacherId); //学工号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdentityId))
 {
 if (objQxUsersEN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsersEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdentityId, conQxUsers.IdentityId); //身份编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.IdentityId); //身份编号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IsArchive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsersEN.IsArchive == true?"1":"0", conQxUsers.IsArchive); //是否存档
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.OpenId))
 {
 if (objQxUsersEN.OpenId !=  null)
 {
 var strOpenId = objQxUsersEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpenId, conQxUsers.OpenId); //微信openid
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.OpenId); //微信openid
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Email))
 {
 if (objQxUsersEN.Email !=  null)
 {
 var strEmail = objQxUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conQxUsers.Email); //邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.Email); //邮箱
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.PhoneNumber))
 {
 if (objQxUsersEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objQxUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhoneNumber, conQxUsers.PhoneNumber); //电话号码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.PhoneNumber); //电话号码
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IsSynch))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsersEN.IsSynch == true?"1":"0", conQxUsers.IsSynch); //是否同步
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.SynchDate))
 {
 if (objQxUsersEN.SynchDate !=  null)
 {
 var strSynchDate = objQxUsersEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchDate, conQxUsers.SynchDate); //同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.SynchDate); //同步日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.DetailInfoTab))
 {
 if (objQxUsersEN.DetailInfoTab !=  null)
 {
 var strDetailInfoTab = objQxUsersEN.DetailInfoTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailInfoTab, conQxUsers.DetailInfoTab); //详细信息表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.DetailInfoTab); //详细信息表
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdGradeBase))
 {
 if (objQxUsersEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objQxUsersEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conQxUsers.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.IdGradeBase); //年级流水号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdSchool))
 {
 if (objQxUsersEN.IdSchool !=  null)
 {
 var strIdSchool = objQxUsersEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conQxUsers.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.IdSchool); //学校流水号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdXzCollege))
 {
 if (objQxUsersEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objQxUsersEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conQxUsers.IdXzCollege); //学院Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.IdXzCollege); //学院Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UpdDate))
 {
 if (objQxUsersEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxUsers.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.UpdDate); //修改日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UpdUser))
 {
 if (objQxUsersEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxUsers.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.UpdUser); //修改用户
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Memo))
 {
 if (objQxUsersEN.Memo !=  null)
 {
 var strMemo = objQxUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUsers.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserId = '{0}'", objQxUsersEN.UserId); 
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
 /// <param name = "objQxUsersEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxUsersEN objQxUsersEN, string strCondition)
{
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUsers Set ");
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UserName))
 {
 if (objQxUsersEN.UserName !=  null)
 {
 var strUserName = objQxUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.DepartmentId))
 {
 if (objQxUsersEN.DepartmentId !=  null)
 {
 var strDepartmentId = objQxUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentId = '{0}',", strDepartmentId); //部门Id
 }
 else
 {
 sbSQL.Append(" DepartmentId = null,"); //部门Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UserStateId))
 {
 if (objQxUsersEN.UserStateId  ==  "")
 {
 objQxUsersEN.UserStateId = null;
 }
 if (objQxUsersEN.UserStateId !=  null)
 {
 var strUserStateId = objQxUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserStateId = '{0}',", strUserStateId); //用户状态Id
 }
 else
 {
 sbSQL.Append(" UserStateId = null,"); //用户状态Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Password))
 {
 if (objQxUsersEN.Password !=  null)
 {
 var strPassword = objQxUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", strPassword); //口令
 }
 else
 {
 sbSQL.Append(" Password = null,"); //口令
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.EffitiveBeginDate))
 {
 if (objQxUsersEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveBeginDate = '{0}',", strEffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.Append(" EffitiveBeginDate = null,"); //有效开始日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.EffitiveEndDate))
 {
 if (objQxUsersEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveEndDate = '{0}',", strEffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.Append(" EffitiveEndDate = null,"); //有效结束日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.StuTeacherId))
 {
 if (objQxUsersEN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuTeacherId = '{0}',", strStuTeacherId); //学工号
 }
 else
 {
 sbSQL.Append(" StuTeacherId = null,"); //学工号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdentityId))
 {
 if (objQxUsersEN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsersEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdentityId = '{0}',", strIdentityId); //身份编号
 }
 else
 {
 sbSQL.Append(" IdentityId = null,"); //身份编号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IsArchive))
 {
 sbSQL.AppendFormat(" IsArchive = '{0}',", objQxUsersEN.IsArchive == true?"1":"0"); //是否存档
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.OpenId))
 {
 if (objQxUsersEN.OpenId !=  null)
 {
 var strOpenId = objQxUsersEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpenId = '{0}',", strOpenId); //微信openid
 }
 else
 {
 sbSQL.Append(" OpenId = null,"); //微信openid
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Email))
 {
 if (objQxUsersEN.Email !=  null)
 {
 var strEmail = objQxUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //邮箱
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.PhoneNumber))
 {
 if (objQxUsersEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objQxUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", strPhoneNumber); //电话号码
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //电话号码
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IsSynch))
 {
 sbSQL.AppendFormat(" IsSynch = '{0}',", objQxUsersEN.IsSynch == true?"1":"0"); //是否同步
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.SynchDate))
 {
 if (objQxUsersEN.SynchDate !=  null)
 {
 var strSynchDate = objQxUsersEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchDate = '{0}',", strSynchDate); //同步日期
 }
 else
 {
 sbSQL.Append(" SynchDate = null,"); //同步日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.DetailInfoTab))
 {
 if (objQxUsersEN.DetailInfoTab !=  null)
 {
 var strDetailInfoTab = objQxUsersEN.DetailInfoTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailInfoTab = '{0}',", strDetailInfoTab); //详细信息表
 }
 else
 {
 sbSQL.Append(" DetailInfoTab = null,"); //详细信息表
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdGradeBase))
 {
 if (objQxUsersEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objQxUsersEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdSchool))
 {
 if (objQxUsersEN.IdSchool !=  null)
 {
 var strIdSchool = objQxUsersEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdXzCollege))
 {
 if (objQxUsersEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objQxUsersEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院Id
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UpdDate))
 {
 if (objQxUsersEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UpdUser))
 {
 if (objQxUsersEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Memo))
 {
 if (objQxUsersEN.Memo !=  null)
 {
 var strMemo = objQxUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxUsersEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxUsersEN objQxUsersEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUsers Set ");
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UserName))
 {
 if (objQxUsersEN.UserName !=  null)
 {
 var strUserName = objQxUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.DepartmentId))
 {
 if (objQxUsersEN.DepartmentId !=  null)
 {
 var strDepartmentId = objQxUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentId = '{0}',", strDepartmentId); //部门Id
 }
 else
 {
 sbSQL.Append(" DepartmentId = null,"); //部门Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UserStateId))
 {
 if (objQxUsersEN.UserStateId  ==  "")
 {
 objQxUsersEN.UserStateId = null;
 }
 if (objQxUsersEN.UserStateId !=  null)
 {
 var strUserStateId = objQxUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserStateId = '{0}',", strUserStateId); //用户状态Id
 }
 else
 {
 sbSQL.Append(" UserStateId = null,"); //用户状态Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Password))
 {
 if (objQxUsersEN.Password !=  null)
 {
 var strPassword = objQxUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", strPassword); //口令
 }
 else
 {
 sbSQL.Append(" Password = null,"); //口令
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.EffitiveBeginDate))
 {
 if (objQxUsersEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveBeginDate = '{0}',", strEffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.Append(" EffitiveBeginDate = null,"); //有效开始日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.EffitiveEndDate))
 {
 if (objQxUsersEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveEndDate = '{0}',", strEffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.Append(" EffitiveEndDate = null,"); //有效结束日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.StuTeacherId))
 {
 if (objQxUsersEN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuTeacherId = '{0}',", strStuTeacherId); //学工号
 }
 else
 {
 sbSQL.Append(" StuTeacherId = null,"); //学工号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdentityId))
 {
 if (objQxUsersEN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsersEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdentityId = '{0}',", strIdentityId); //身份编号
 }
 else
 {
 sbSQL.Append(" IdentityId = null,"); //身份编号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IsArchive))
 {
 sbSQL.AppendFormat(" IsArchive = '{0}',", objQxUsersEN.IsArchive == true?"1":"0"); //是否存档
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.OpenId))
 {
 if (objQxUsersEN.OpenId !=  null)
 {
 var strOpenId = objQxUsersEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpenId = '{0}',", strOpenId); //微信openid
 }
 else
 {
 sbSQL.Append(" OpenId = null,"); //微信openid
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Email))
 {
 if (objQxUsersEN.Email !=  null)
 {
 var strEmail = objQxUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //邮箱
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.PhoneNumber))
 {
 if (objQxUsersEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objQxUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", strPhoneNumber); //电话号码
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //电话号码
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IsSynch))
 {
 sbSQL.AppendFormat(" IsSynch = '{0}',", objQxUsersEN.IsSynch == true?"1":"0"); //是否同步
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.SynchDate))
 {
 if (objQxUsersEN.SynchDate !=  null)
 {
 var strSynchDate = objQxUsersEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchDate = '{0}',", strSynchDate); //同步日期
 }
 else
 {
 sbSQL.Append(" SynchDate = null,"); //同步日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.DetailInfoTab))
 {
 if (objQxUsersEN.DetailInfoTab !=  null)
 {
 var strDetailInfoTab = objQxUsersEN.DetailInfoTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailInfoTab = '{0}',", strDetailInfoTab); //详细信息表
 }
 else
 {
 sbSQL.Append(" DetailInfoTab = null,"); //详细信息表
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdGradeBase))
 {
 if (objQxUsersEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objQxUsersEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdSchool))
 {
 if (objQxUsersEN.IdSchool !=  null)
 {
 var strIdSchool = objQxUsersEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdXzCollege))
 {
 if (objQxUsersEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objQxUsersEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院Id
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UpdDate))
 {
 if (objQxUsersEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UpdUser))
 {
 if (objQxUsersEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Memo))
 {
 if (objQxUsersEN.Memo !=  null)
 {
 var strMemo = objQxUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUsersEN objQxUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUsers Set ");
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UserName))
 {
 if (objQxUsersEN.UserName !=  null)
 {
 var strUserName = objQxUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conQxUsers.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.UserName); //用户名
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.DepartmentId))
 {
 if (objQxUsersEN.DepartmentId !=  null)
 {
 var strDepartmentId = objQxUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentId, conQxUsers.DepartmentId); //部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.DepartmentId); //部门Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UserStateId))
 {
 if (objQxUsersEN.UserStateId  ==  "")
 {
 objQxUsersEN.UserStateId = null;
 }
 if (objQxUsersEN.UserStateId !=  null)
 {
 var strUserStateId = objQxUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserStateId, conQxUsers.UserStateId); //用户状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.UserStateId); //用户状态Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Password))
 {
 if (objQxUsersEN.Password !=  null)
 {
 var strPassword = objQxUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPassword, conQxUsers.Password); //口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.Password); //口令
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.EffitiveBeginDate))
 {
 if (objQxUsersEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objQxUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveBeginDate, conQxUsers.EffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.EffitiveBeginDate); //有效开始日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.EffitiveEndDate))
 {
 if (objQxUsersEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objQxUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveEndDate, conQxUsers.EffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.EffitiveEndDate); //有效结束日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.StuTeacherId))
 {
 if (objQxUsersEN.StuTeacherId !=  null)
 {
 var strStuTeacherId = objQxUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuTeacherId, conQxUsers.StuTeacherId); //学工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.StuTeacherId); //学工号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdentityId))
 {
 if (objQxUsersEN.IdentityId !=  null)
 {
 var strIdentityId = objQxUsersEN.IdentityId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdentityId, conQxUsers.IdentityId); //身份编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.IdentityId); //身份编号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IsArchive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsersEN.IsArchive == true?"1":"0", conQxUsers.IsArchive); //是否存档
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.OpenId))
 {
 if (objQxUsersEN.OpenId !=  null)
 {
 var strOpenId = objQxUsersEN.OpenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpenId, conQxUsers.OpenId); //微信openid
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.OpenId); //微信openid
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Email))
 {
 if (objQxUsersEN.Email !=  null)
 {
 var strEmail = objQxUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conQxUsers.Email); //邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.Email); //邮箱
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.PhoneNumber))
 {
 if (objQxUsersEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objQxUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhoneNumber, conQxUsers.PhoneNumber); //电话号码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.PhoneNumber); //电话号码
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IsSynch))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUsersEN.IsSynch == true?"1":"0", conQxUsers.IsSynch); //是否同步
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.SynchDate))
 {
 if (objQxUsersEN.SynchDate !=  null)
 {
 var strSynchDate = objQxUsersEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchDate, conQxUsers.SynchDate); //同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.SynchDate); //同步日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.DetailInfoTab))
 {
 if (objQxUsersEN.DetailInfoTab !=  null)
 {
 var strDetailInfoTab = objQxUsersEN.DetailInfoTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailInfoTab, conQxUsers.DetailInfoTab); //详细信息表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.DetailInfoTab); //详细信息表
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdGradeBase))
 {
 if (objQxUsersEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objQxUsersEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conQxUsers.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.IdGradeBase); //年级流水号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdSchool))
 {
 if (objQxUsersEN.IdSchool !=  null)
 {
 var strIdSchool = objQxUsersEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conQxUsers.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.IdSchool); //学校流水号
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.IdXzCollege))
 {
 if (objQxUsersEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objQxUsersEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conQxUsers.IdXzCollege); //学院Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.IdXzCollege); //学院Id
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UpdDate))
 {
 if (objQxUsersEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxUsers.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.UpdDate); //修改日期
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.UpdUser))
 {
 if (objQxUsersEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxUsers.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.UpdUser); //修改用户
 }
 }
 
 if (objQxUsersEN.IsUpdated(conQxUsers.Memo))
 {
 if (objQxUsersEN.Memo !=  null)
 {
 var strMemo = objQxUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUsers.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUsers.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserId = '{0}'", objQxUsersEN.UserId); 
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strUserId) 
{
CheckPrimaryKey(strUserId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strUserId,
};
 objSQL.ExecSP("QxUsers_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strUserId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
//删除QxUsers本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUsers where UserId = " + "'"+ strUserId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxUsers(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
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
//删除QxUsers本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUsers where UserId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strUserId) 
{
CheckPrimaryKey(strUserId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
//删除QxUsers本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUsers where UserId = " + "'"+ strUserId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxUsers(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxUsersDA: DelQxUsers)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUsers where " + strCondition ;
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
public bool DelQxUsersWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxUsersDA: DelQxUsersWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUsersDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUsers where " + strCondition ;
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
 /// <param name = "objQxUsersENS">源对象</param>
 /// <param name = "objQxUsersENT">目标对象</param>
public void CopyTo(clsQxUsersEN objQxUsersENS, clsQxUsersEN objQxUsersENT)
{
objQxUsersENT.UserId = objQxUsersENS.UserId; //用户ID
objQxUsersENT.UserName = objQxUsersENS.UserName; //用户名
objQxUsersENT.DepartmentId = objQxUsersENS.DepartmentId; //部门Id
objQxUsersENT.UserStateId = objQxUsersENS.UserStateId; //用户状态Id
objQxUsersENT.Password = objQxUsersENS.Password; //口令
objQxUsersENT.EffitiveBeginDate = objQxUsersENS.EffitiveBeginDate; //有效开始日期
objQxUsersENT.EffitiveEndDate = objQxUsersENS.EffitiveEndDate; //有效结束日期
objQxUsersENT.StuTeacherId = objQxUsersENS.StuTeacherId; //学工号
objQxUsersENT.IdentityId = objQxUsersENS.IdentityId; //身份编号
objQxUsersENT.IsArchive = objQxUsersENS.IsArchive; //是否存档
objQxUsersENT.OpenId = objQxUsersENS.OpenId; //微信openid
objQxUsersENT.Email = objQxUsersENS.Email; //邮箱
objQxUsersENT.PhoneNumber = objQxUsersENS.PhoneNumber; //电话号码
objQxUsersENT.IsSynch = objQxUsersENS.IsSynch; //是否同步
objQxUsersENT.SynchDate = objQxUsersENS.SynchDate; //同步日期
objQxUsersENT.DetailInfoTab = objQxUsersENS.DetailInfoTab; //详细信息表
objQxUsersENT.IdGradeBase = objQxUsersENS.IdGradeBase; //年级流水号
objQxUsersENT.IdSchool = objQxUsersENS.IdSchool; //学校流水号
objQxUsersENT.IdXzCollege = objQxUsersENS.IdXzCollege; //学院Id
objQxUsersENT.UpdDate = objQxUsersENS.UpdDate; //修改日期
objQxUsersENT.UpdUser = objQxUsersENS.UpdUser; //修改用户
objQxUsersENT.Memo = objQxUsersENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUsersEN objQxUsersEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxUsersEN.UserName, conQxUsers.UserName);
clsCheckSql.CheckFieldNotNull(objQxUsersEN.UserStateId, conQxUsers.UserStateId);
clsCheckSql.CheckFieldNotNull(objQxUsersEN.Password, conQxUsers.Password);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUsersEN.UserId, 18, conQxUsers.UserId);
clsCheckSql.CheckFieldLen(objQxUsersEN.UserName, 30, conQxUsers.UserName);
clsCheckSql.CheckFieldLen(objQxUsersEN.DepartmentId, 8, conQxUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objQxUsersEN.UserStateId, 2, conQxUsers.UserStateId);
clsCheckSql.CheckFieldLen(objQxUsersEN.Password, 20, conQxUsers.Password);
clsCheckSql.CheckFieldLen(objQxUsersEN.EffitiveBeginDate, 14, conQxUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.EffitiveEndDate, 14, conQxUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.StuTeacherId, 20, conQxUsers.StuTeacherId);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdentityId, 2, conQxUsers.IdentityId);
clsCheckSql.CheckFieldLen(objQxUsersEN.OpenId, 50, conQxUsers.OpenId);
clsCheckSql.CheckFieldLen(objQxUsersEN.Email, 100, conQxUsers.Email);
clsCheckSql.CheckFieldLen(objQxUsersEN.PhoneNumber, 15, conQxUsers.PhoneNumber);
clsCheckSql.CheckFieldLen(objQxUsersEN.SynchDate, 30, conQxUsers.SynchDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.DetailInfoTab, 30, conQxUsers.DetailInfoTab);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdGradeBase, 4, conQxUsers.IdGradeBase);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdSchool, 4, conQxUsers.IdSchool);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdXzCollege, 4, conQxUsers.IdXzCollege);
clsCheckSql.CheckFieldLen(objQxUsersEN.UpdDate, 20, conQxUsers.UpdDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.UpdUser, 20, conQxUsers.UpdUser);
clsCheckSql.CheckFieldLen(objQxUsersEN.Memo, 1000, conQxUsers.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxUsersEN.UserStateId, 2, conQxUsers.UserStateId);
 objQxUsersEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxUsersEN objQxUsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUsersEN.UserName, 30, conQxUsers.UserName);
clsCheckSql.CheckFieldLen(objQxUsersEN.DepartmentId, 8, conQxUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objQxUsersEN.UserStateId, 2, conQxUsers.UserStateId);
clsCheckSql.CheckFieldLen(objQxUsersEN.Password, 20, conQxUsers.Password);
clsCheckSql.CheckFieldLen(objQxUsersEN.EffitiveBeginDate, 14, conQxUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.EffitiveEndDate, 14, conQxUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.StuTeacherId, 20, conQxUsers.StuTeacherId);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdentityId, 2, conQxUsers.IdentityId);
clsCheckSql.CheckFieldLen(objQxUsersEN.OpenId, 50, conQxUsers.OpenId);
clsCheckSql.CheckFieldLen(objQxUsersEN.Email, 100, conQxUsers.Email);
clsCheckSql.CheckFieldLen(objQxUsersEN.PhoneNumber, 15, conQxUsers.PhoneNumber);
clsCheckSql.CheckFieldLen(objQxUsersEN.SynchDate, 30, conQxUsers.SynchDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.DetailInfoTab, 30, conQxUsers.DetailInfoTab);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdGradeBase, 4, conQxUsers.IdGradeBase);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdSchool, 4, conQxUsers.IdSchool);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdXzCollege, 4, conQxUsers.IdXzCollege);
clsCheckSql.CheckFieldLen(objQxUsersEN.UpdDate, 20, conQxUsers.UpdDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.UpdUser, 20, conQxUsers.UpdUser);
clsCheckSql.CheckFieldLen(objQxUsersEN.Memo, 1000, conQxUsers.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxUsersEN.UserStateId, 2, conQxUsers.UserStateId);
 objQxUsersEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxUsersEN objQxUsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUsersEN.UserId, 18, conQxUsers.UserId);
clsCheckSql.CheckFieldLen(objQxUsersEN.UserName, 30, conQxUsers.UserName);
clsCheckSql.CheckFieldLen(objQxUsersEN.DepartmentId, 8, conQxUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objQxUsersEN.UserStateId, 2, conQxUsers.UserStateId);
clsCheckSql.CheckFieldLen(objQxUsersEN.Password, 20, conQxUsers.Password);
clsCheckSql.CheckFieldLen(objQxUsersEN.EffitiveBeginDate, 14, conQxUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.EffitiveEndDate, 14, conQxUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.StuTeacherId, 20, conQxUsers.StuTeacherId);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdentityId, 2, conQxUsers.IdentityId);
clsCheckSql.CheckFieldLen(objQxUsersEN.OpenId, 50, conQxUsers.OpenId);
clsCheckSql.CheckFieldLen(objQxUsersEN.Email, 100, conQxUsers.Email);
clsCheckSql.CheckFieldLen(objQxUsersEN.PhoneNumber, 15, conQxUsers.PhoneNumber);
clsCheckSql.CheckFieldLen(objQxUsersEN.SynchDate, 30, conQxUsers.SynchDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.DetailInfoTab, 30, conQxUsers.DetailInfoTab);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdGradeBase, 4, conQxUsers.IdGradeBase);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdSchool, 4, conQxUsers.IdSchool);
clsCheckSql.CheckFieldLen(objQxUsersEN.IdXzCollege, 4, conQxUsers.IdXzCollege);
clsCheckSql.CheckFieldLen(objQxUsersEN.UpdDate, 20, conQxUsers.UpdDate);
clsCheckSql.CheckFieldLen(objQxUsersEN.UpdUser, 20, conQxUsers.UpdUser);
clsCheckSql.CheckFieldLen(objQxUsersEN.Memo, 1000, conQxUsers.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.UserId, conQxUsers.UserId);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.UserName, conQxUsers.UserName);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.DepartmentId, conQxUsers.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.UserStateId, conQxUsers.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.Password, conQxUsers.Password);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.EffitiveBeginDate, conQxUsers.EffitiveBeginDate);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.EffitiveEndDate, conQxUsers.EffitiveEndDate);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.StuTeacherId, conQxUsers.StuTeacherId);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.IdentityId, conQxUsers.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.OpenId, conQxUsers.OpenId);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.Email, conQxUsers.Email);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.PhoneNumber, conQxUsers.PhoneNumber);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.SynchDate, conQxUsers.SynchDate);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.DetailInfoTab, conQxUsers.DetailInfoTab);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.IdGradeBase, conQxUsers.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.IdSchool, conQxUsers.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.IdXzCollege, conQxUsers.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.UpdDate, conQxUsers.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.UpdUser, conQxUsers.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQxUsersEN.Memo, conQxUsers.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxUsersEN.UserStateId, 2, conQxUsers.UserStateId);
 objQxUsersEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetUserId()
{
//获取某学院所有专业信息
string strSQL = "select UserId, UserName from QxUsers ";
 clsSpecSQLforSql mySql = clsQxUsersDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsQxUsersDA.GetSpecSQLObj();
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
 objSQL = clsQxUsersDA.GetSpecSQLObj();
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
 objSQL = clsQxUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUsersEN._CurrTabName);
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
 objSQL = clsQxUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUsersEN._CurrTabName, strCondition);
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
 objSQL = clsQxUsersDA.GetSpecSQLObj();
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
 objSQL = clsQxUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}