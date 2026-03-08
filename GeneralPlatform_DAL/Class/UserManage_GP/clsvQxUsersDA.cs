
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsersDA
 表名:vQxUsers(00140024)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:00:51
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
 /// v用户(vQxUsers)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxUsersDA : clsCommBase4DA
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
 return clsvQxUsersEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxUsersEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUsersEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxUsersEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxUsersEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vQxUsers中,检查关键字,长度不正确!(clsvQxUsersDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxUsers中,关键字不能为空 或 null!(clsvQxUsersDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxUsersDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception("(errid:Data000004)在表:vQxUsers中,检查关键字,长度不正确!(简化版)(clsvQxUsersDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:vQxUsers中,关键字不能为空 或 null!(clsvQxUsersDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsvQxUsersDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 strSQL = "Select * from vQxUsers where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxUsers_SelectByCond",values, "vQxUsers");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUsers a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUsers a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUsers a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxUsers(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable_vQxUsers)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUsers.* from vQxUsers Left Join {1} on {2} where {3} and vQxUsers.UserId not in (Select top {5} vQxUsers.UserId from vQxUsers Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} and UserId not in (Select top {2} UserId from vQxUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} and UserId not in (Select top {3} UserId from vQxUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUsers.* from vQxUsers Left Join {1} on {2} where {3} and vQxUsers.UserId not in (Select top {5} vQxUsers.UserId from vQxUsers Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} and UserId not in (Select top {2} UserId from vQxUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} and UserId not in (Select top {3} UserId from vQxUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUsers.* from vQxUsers Left Join {1} on {2} where {3} and vQxUsers.UserId not in (Select top {5} vQxUsers.UserId from vQxUsers Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} and UserId not in (Select top {2} UserId from vQxUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} and UserId not in (Select top {3} UserId from vQxUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUsers a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUsers a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUsers a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUsers a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsersDA: GetvQxUsersByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers_SelectByCond",values);
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
public List<clsvQxUsersEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxUsersDA:GetObjLst)", objException.Message));
}
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUsersDA: GetObjLst)", objException.Message));
}
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUsersEN);
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
public List<clsvQxUsersEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxUsersDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUsersDA: GetObjLst)", objException.Message));
}
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxUsersEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxUsersDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxUsersDA: GetObjLstBySP)", objException.Message));
}
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUsers(ref clsvQxUsersEN objvQxUsersEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where UserId = " + "'"+ objvQxUsersEN.UserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxUsersEN.UserId = objDT.Rows[0][convQxUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUsersEN.UserName = objDT.Rows[0][convQxUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUsersEN.DepartmentId = objDT.Rows[0][convQxUsers.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUsersEN.DepartmentName = objDT.Rows[0][convQxUsers.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUsersEN.DepartmentAbbrName = objDT.Rows[0][convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsersEN.DepartmentTypeId = objDT.Rows[0][convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsersEN.DepartmentTypeName = objDT.Rows[0][convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUsersEN.UpDepartmentId = objDT.Rows[0][convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objvQxUsersEN.UpDepartmentName = objDT.Rows[0][convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsersEN.UserStateId = objDT.Rows[0][convQxUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsersEN.UserStateName = objDT.Rows[0][convQxUsers.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.Password = objDT.Rows[0][convQxUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.EffitiveBeginDate = objDT.Rows[0][convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsersEN.EffitiveEndDate = objDT.Rows[0][convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsersEN.StuTeacherId = objDT.Rows[0][convQxUsers.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.IdentityId = objDT.Rows[0][convQxUsers.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsersEN.IdentityDesc = objDT.Rows[0][convQxUsers.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.OpenId = objDT.Rows[0][convQxUsers.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxUsersEN.IsSynch = TransNullToBool(objDT.Rows[0][convQxUsers.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsersEN.SynchDate = objDT.Rows[0][convQxUsers.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvQxUsersEN.UpdDate = objDT.Rows[0][convQxUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.UpdUser = objDT.Rows[0][convQxUsers.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.IdXzCollege = objDT.Rows[0][convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege(字段类型:char,字段长度:4,是否可空:True)
 objvQxUsersEN.Memo = objDT.Rows[0][convQxUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxUsersDA: GetvQxUsers)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxUsersEN GetObjByUserId(string strUserId)
{
CheckPrimaryKey(strUserId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where UserId = " + "'"+ strUserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
 objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege(字段类型:char,字段长度:4,是否可空:True)
 objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxUsersDA: GetObjByUserId)", objException.Message));
}
return objvQxUsersEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxUsers_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUsersOneBySP(clsvQxUsersEN objvQxUsersEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxUsersEN.UserId
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxUsersEN.UserId = objDT.Rows[0][convQxUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUsersEN.UserName = objDT.Rows[0][convQxUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUsersEN.DepartmentId = objDT.Rows[0][convQxUsers.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUsersEN.DepartmentName = objDT.Rows[0][convQxUsers.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUsersEN.DepartmentAbbrName = objDT.Rows[0][convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsersEN.DepartmentTypeId = objDT.Rows[0][convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsersEN.DepartmentTypeName = objDT.Rows[0][convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUsersEN.UpDepartmentId = objDT.Rows[0][convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objvQxUsersEN.UpDepartmentName = objDT.Rows[0][convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsersEN.UserStateId = objDT.Rows[0][convQxUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsersEN.UserStateName = objDT.Rows[0][convQxUsers.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.Password = objDT.Rows[0][convQxUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.EffitiveBeginDate = objDT.Rows[0][convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsersEN.EffitiveEndDate = objDT.Rows[0][convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsersEN.StuTeacherId = objDT.Rows[0][convQxUsers.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.IdentityId = objDT.Rows[0][convQxUsers.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsersEN.IdentityDesc = objDT.Rows[0][convQxUsers.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.OpenId = objDT.Rows[0][convQxUsers.OpenId].ToString().Trim(); //微信openid(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxUsersEN.IsSynch = TransNullToBool(objDT.Rows[0][convQxUsers.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsersEN.SynchDate = objDT.Rows[0][convQxUsers.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvQxUsersEN.UpdDate = objDT.Rows[0][convQxUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.UpdUser = objDT.Rows[0][convQxUsers.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.IdXzCollege = objDT.Rows[0][convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege(字段类型:char,字段长度:4,是否可空:True)
 objvQxUsersEN.Memo = objDT.Rows[0][convQxUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUsersEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN()
{
UserId = objRow[convQxUsers.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUsers.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(), //名称缩写
DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(), //部门类型ID
DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(), //部门类型名
UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(), //所属部门号
UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(), //上级部门
UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(), //用户状态名
Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(), //口令
EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(), //有效结束日期
StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(), //学工号
IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(), //身份编号
IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(), //身份描述
OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(), //微信openid
IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()), //是否同步
SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(), //同步日期
UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(), //修改用户
IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(), //IdXzCollege
Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim() //备注
};
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsersEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxUsersDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUsersEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxUsersDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN()
{
UserId = objRow[convQxUsers.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUsers.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(), //名称缩写
DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(), //部门类型ID
DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(), //部门类型名
UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(), //所属部门号
UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(), //上级部门
UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(), //用户状态名
Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(), //口令
EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(), //有效结束日期
StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(), //学工号
IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(), //身份编号
IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(), //身份描述
OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(), //微信openid
IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()), //是否同步
SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(), //同步日期
UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(), //修改用户
IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(), //IdXzCollege
Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim() //备注
};
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsersEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxUsersEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxUsersDA: GetObjByDataRowvQxUsers)", objException.Message));
}
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsersEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxUsersEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxUsersDA: GetObjByDataRow)", objException.Message));
}
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsersEN;
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
objSQL = clsvQxUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUsersEN._CurrTabName, convQxUsers.UserId, 18, "");
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
objSQL = clsvQxUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUsersEN._CurrTabName, convQxUsers.UserId, 18, strPrefix);
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserId from vQxUsers where " + strCondition;
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserId from vQxUsers where " + strCondition;
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUsers", "UserId = " + "'"+ strUserId+"'"))
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strUserId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxUsers_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxUsersDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUsers", strCondition))
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
objSQL = clsvQxUsersDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxUsers");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxUsersENS">源对象</param>
 /// <param name = "objvQxUsersENT">目标对象</param>
public void CopyTo(clsvQxUsersEN objvQxUsersENS, clsvQxUsersEN objvQxUsersENT)
{
objvQxUsersENT.UserId = objvQxUsersENS.UserId; //用户ID
objvQxUsersENT.UserName = objvQxUsersENS.UserName; //用户名
objvQxUsersENT.DepartmentId = objvQxUsersENS.DepartmentId; //部门Id
objvQxUsersENT.DepartmentName = objvQxUsersENS.DepartmentName; //部门名
objvQxUsersENT.DepartmentAbbrName = objvQxUsersENS.DepartmentAbbrName; //名称缩写
objvQxUsersENT.DepartmentTypeId = objvQxUsersENS.DepartmentTypeId; //部门类型ID
objvQxUsersENT.DepartmentTypeName = objvQxUsersENS.DepartmentTypeName; //部门类型名
objvQxUsersENT.UpDepartmentId = objvQxUsersENS.UpDepartmentId; //所属部门号
objvQxUsersENT.UpDepartmentName = objvQxUsersENS.UpDepartmentName; //上级部门
objvQxUsersENT.UserStateId = objvQxUsersENS.UserStateId; //用户状态Id
objvQxUsersENT.UserStateName = objvQxUsersENS.UserStateName; //用户状态名
objvQxUsersENT.Password = objvQxUsersENS.Password; //口令
objvQxUsersENT.EffitiveBeginDate = objvQxUsersENS.EffitiveBeginDate; //有效开始日期
objvQxUsersENT.EffitiveEndDate = objvQxUsersENS.EffitiveEndDate; //有效结束日期
objvQxUsersENT.StuTeacherId = objvQxUsersENS.StuTeacherId; //学工号
objvQxUsersENT.IdentityId = objvQxUsersENS.IdentityId; //身份编号
objvQxUsersENT.IdentityDesc = objvQxUsersENS.IdentityDesc; //身份描述
objvQxUsersENT.OpenId = objvQxUsersENS.OpenId; //微信openid
objvQxUsersENT.IsSynch = objvQxUsersENS.IsSynch; //是否同步
objvQxUsersENT.SynchDate = objvQxUsersENS.SynchDate; //同步日期
objvQxUsersENT.UpdDate = objvQxUsersENS.UpdDate; //修改日期
objvQxUsersENT.UpdUser = objvQxUsersENS.UpdUser; //修改用户
objvQxUsersENT.IdXzCollege = objvQxUsersENS.IdXzCollege; //IdXzCollege
objvQxUsersENT.Memo = objvQxUsersENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxUsersEN objvQxUsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxUsersEN.UserId, 18, convQxUsers.UserId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UserName, 30, convQxUsers.UserName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.DepartmentId, 8, convQxUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.DepartmentName, 100, convQxUsers.DepartmentName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.DepartmentAbbrName, 8, convQxUsers.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.DepartmentTypeId, 2, convQxUsers.DepartmentTypeId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.DepartmentTypeName, 50, convQxUsers.DepartmentTypeName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UpDepartmentId, 6, convQxUsers.UpDepartmentId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UpDepartmentName, 100, convQxUsers.UpDepartmentName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UserStateId, 2, convQxUsers.UserStateId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UserStateName, 20, convQxUsers.UserStateName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.Password, 20, convQxUsers.Password);
clsCheckSql.CheckFieldLen(objvQxUsersEN.EffitiveBeginDate, 14, convQxUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objvQxUsersEN.EffitiveEndDate, 14, convQxUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objvQxUsersEN.StuTeacherId, 20, convQxUsers.StuTeacherId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.IdentityId, 2, convQxUsers.IdentityId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.IdentityDesc, 20, convQxUsers.IdentityDesc);
clsCheckSql.CheckFieldLen(objvQxUsersEN.OpenId, 50, convQxUsers.OpenId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.SynchDate, 14, convQxUsers.SynchDate);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UpdDate, 20, convQxUsers.UpdDate);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UpdUser, 20, convQxUsers.UpdUser);
clsCheckSql.CheckFieldLen(objvQxUsersEN.IdXzCollege, 4, convQxUsers.IdXzCollege);
clsCheckSql.CheckFieldLen(objvQxUsersEN.Memo, 1000, convQxUsers.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UserId, convQxUsers.UserId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UserName, convQxUsers.UserName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.DepartmentId, convQxUsers.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.DepartmentName, convQxUsers.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.DepartmentAbbrName, convQxUsers.DepartmentAbbrName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.DepartmentTypeId, convQxUsers.DepartmentTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.DepartmentTypeName, convQxUsers.DepartmentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UpDepartmentId, convQxUsers.UpDepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UpDepartmentName, convQxUsers.UpDepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UserStateId, convQxUsers.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UserStateName, convQxUsers.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.Password, convQxUsers.Password);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.EffitiveBeginDate, convQxUsers.EffitiveBeginDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.EffitiveEndDate, convQxUsers.EffitiveEndDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.StuTeacherId, convQxUsers.StuTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.IdentityId, convQxUsers.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.IdentityDesc, convQxUsers.IdentityDesc);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.OpenId, convQxUsers.OpenId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.SynchDate, convQxUsers.SynchDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UpdDate, convQxUsers.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UpdUser, convQxUsers.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.IdXzCollege, convQxUsers.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.Memo, convQxUsers.Memo);
//检查外键字段长度
 objvQxUsersEN._IsCheckProperty = true;
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUsersEN._CurrTabName);
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUsersEN._CurrTabName, strCondition);
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}