
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserLoginNameDA
 表名:vQxUserLoginName(00140077)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:51:35
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
 /// vUserLoginName(vQxUserLoginName)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxUserLoginNameDA : clsCommBase4DA
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
 return clsvQxUserLoginNameEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxUserLoginNameEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserLoginNameEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxUserLoginNameEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxUserLoginNameEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strUserLoginName">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strUserLoginName)
{
strUserLoginName = strUserLoginName.Replace("'", "''");
if (strUserLoginName.Length > 30)
{
throw new Exception("(errid:Data000001)在表:vQxUserLoginName中,检查关键字,长度不正确!(clsvQxUserLoginNameDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserLoginName)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxUserLoginName中,关键字不能为空 或 null!(clsvQxUserLoginNameDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserLoginName);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxUserLoginNameDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strUserLoginName">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strUserLoginName)
{
strUserLoginName = strUserLoginName.Replace("'", "''");
if (strUserLoginName.Length > 30 + 4)
{
throw new Exception("(errid:Data000004)在表:vQxUserLoginName中,检查关键字,长度不正确!(简化版)(clsvQxUserLoginNameDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserLoginName)  ==  true)
{
throw new Exception("(errid:Data000005)在表:vQxUserLoginName中,关键字不能为空 或 null!(clsvQxUserLoginNameDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserLoginName);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsvQxUserLoginNameDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
 strSQL = "Select * from vQxUserLoginName where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxUserLoginName");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxUserLoginName_SelectByCond",values, "vQxUserLoginName");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUserLoginName where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserLoginName");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUserLoginName a where {0} And a.UserLoginName not in (Select Top {2} UserLoginName From vQxUserLoginName Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserLoginName");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUserLoginName a where {0} And a.UserLoginName not in (Select Top {2} UserLoginName From vQxUserLoginName Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserLoginName");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUserLoginName a where {0} And a.UserLoginName not in (Select Top {2} UserLoginName From vQxUserLoginName Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserLoginName");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserLoginName where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxUserLoginName(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTable_vQxUserLoginName)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserLoginName where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserLoginName where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserLoginName where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserLoginName where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserLoginName where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUserLoginName where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUserLoginName where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserLoginName.* from vQxUserLoginName Left Join {1} on {2} where {3} and vQxUserLoginName.UserLoginName not in (Select top {5} vQxUserLoginName.UserLoginName from vQxUserLoginName Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserLoginName where {1} and UserLoginName not in (Select top {2} UserLoginName from vQxUserLoginName where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserLoginName where {1} and UserLoginName not in (Select top {3} UserLoginName from vQxUserLoginName where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserLoginName.* from vQxUserLoginName Left Join {1} on {2} where {3} and vQxUserLoginName.UserLoginName not in (Select top {5} vQxUserLoginName.UserLoginName from vQxUserLoginName Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserLoginName where {1} and UserLoginName not in (Select top {2} UserLoginName from vQxUserLoginName where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserLoginName where {1} and UserLoginName not in (Select top {3} UserLoginName from vQxUserLoginName where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserLoginName.* from vQxUserLoginName Left Join {1} on {2} where {3} and vQxUserLoginName.UserLoginName not in (Select top {5} vQxUserLoginName.UserLoginName from vQxUserLoginName Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserLoginName where {1} and UserLoginName not in (Select top {2} UserLoginName from vQxUserLoginName where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserLoginName where {1} and UserLoginName not in (Select top {3} UserLoginName from vQxUserLoginName where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUserLoginName a where {0} And a.UserLoginName not in (Select Top {2} UserLoginName From vQxUserLoginName Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUserLoginName a where {0} And a.UserLoginName not in (Select Top {2} UserLoginName From vQxUserLoginName Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUserLoginName a where {0} And a.UserLoginName not in (Select Top {2} UserLoginName From vQxUserLoginName Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUserLoginName a where {0} And a.UserLoginName not in (Select Top {2} UserLoginName From vQxUserLoginName Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginNameByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserLoginName where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUserLoginName_SelectByCond",values);
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
public List<clsvQxUserLoginNameEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA:GetObjLst)", objException.Message));
}
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserLoginName where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserLoginNameDA: GetObjLst)", objException.Message));
}
objvQxUserLoginNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserLoginNameEN);
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
public List<clsvQxUserLoginNameEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserLoginNameDA: GetObjLst)", objException.Message));
}
objvQxUserLoginNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserLoginNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxUserLoginNameEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUserLoginName_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserLoginNameDA: GetObjLstBySP)", objException.Message));
}
objvQxUserLoginNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserLoginNameEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUserLoginName(ref clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserLoginName where UserLoginName = " + "'"+ objvQxUserLoginNameEN.UserLoginName+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxUserLoginNameEN.UserLoginName = objDT.Rows[0][convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserLoginNameEN.UserId = objDT.Rows[0][convQxUserLoginName.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUserLoginNameEN.UserName = objDT.Rows[0][convQxUserLoginName.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserLoginNameEN.DepartmentId = objDT.Rows[0][convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUserLoginNameEN.DepartmentName = objDT.Rows[0][convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserLoginNameEN.DepartmentAbbrName = objDT.Rows[0][convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUserLoginNameEN.UserStateId = objDT.Rows[0][convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserLoginNameEN.UserStateName = objDT.Rows[0][convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.Password = objDT.Rows[0][convQxUserLoginName.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.EffitiveBeginDate = objDT.Rows[0][convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUserLoginNameEN.EffitiveEndDate = objDT.Rows[0][convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUserLoginNameEN.StuTeacherId = objDT.Rows[0][convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.IdentityId = objDT.Rows[0][convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserLoginNameEN.IdentityDesc = objDT.Rows[0][convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.Memo = objDT.Rows[0][convQxUserLoginName.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxUserLoginNameDA: GetvQxUserLoginName)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserLoginName">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxUserLoginNameEN GetObjByUserLoginName(string strUserLoginName)
{
CheckPrimaryKey(strUserLoginName);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserLoginName where UserLoginName = " + "'"+ strUserLoginName+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
 objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxUserLoginNameDA: GetObjByUserLoginName)", objException.Message));
}
return objvQxUserLoginNameEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxUserLoginName_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUserLoginNameOneBySP(clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxUserLoginNameEN.UserLoginName
};
 objDT = objSQL.ExecSpReturnDT("vQxUserLoginName_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxUserLoginNameEN.UserLoginName = objDT.Rows[0][convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserLoginNameEN.UserId = objDT.Rows[0][convQxUserLoginName.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUserLoginNameEN.UserName = objDT.Rows[0][convQxUserLoginName.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserLoginNameEN.DepartmentId = objDT.Rows[0][convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUserLoginNameEN.DepartmentName = objDT.Rows[0][convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserLoginNameEN.DepartmentAbbrName = objDT.Rows[0][convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUserLoginNameEN.UserStateId = objDT.Rows[0][convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserLoginNameEN.UserStateName = objDT.Rows[0][convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.Password = objDT.Rows[0][convQxUserLoginName.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.EffitiveBeginDate = objDT.Rows[0][convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUserLoginNameEN.EffitiveEndDate = objDT.Rows[0][convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUserLoginNameEN.StuTeacherId = objDT.Rows[0][convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.IdentityId = objDT.Rows[0][convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserLoginNameEN.IdentityDesc = objDT.Rows[0][convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserLoginNameEN.Memo = objDT.Rows[0][convQxUserLoginName.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUserLoginNameEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserLoginName where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN()
{
UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(), //用户登录名
UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(), //名称缩写
UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(), //用户状态名
Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(), //口令
EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(), //有效结束日期
StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(), //学工号
IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(), //身份编号
IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(), //身份描述
Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim() //备注
};
objvQxUserLoginNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserLoginNameEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxUserLoginNameDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUserLoginNameEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUserLoginName_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN()
{
UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(), //用户登录名
UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(), //名称缩写
UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(), //用户状态名
Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(), //口令
EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(), //有效结束日期
StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(), //学工号
IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(), //身份编号
IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(), //身份描述
Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim() //备注
};
objvQxUserLoginNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserLoginNameEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxUserLoginNameEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxUserLoginNameDA: GetObjByDataRowvQxUserLoginName)", objException.Message));
}
objvQxUserLoginNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserLoginNameEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxUserLoginNameEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxUserLoginNameDA: GetObjByDataRow)", objException.Message));
}
objvQxUserLoginNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserLoginNameEN;
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
objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUserLoginNameEN._CurrTabName, convQxUserLoginName.UserLoginName, 30, "");
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
objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUserLoginNameEN._CurrTabName, convQxUserLoginName.UserLoginName, 30, strPrefix);
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
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserLoginName from vQxUserLoginName where " + strCondition;
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
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserLoginName from vQxUserLoginName where " + strCondition;
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
 /// <param name = "strUserLoginName">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strUserLoginName)
{
CheckPrimaryKey(strUserLoginName);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUserLoginName", "UserLoginName = " + "'"+ strUserLoginName+"'"))
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
 /// <param name = "strUserLoginName">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strUserLoginName)
{
CheckPrimaryKey(strUserLoginName);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strUserLoginName,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxUserLoginName_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxUserLoginNameDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUserLoginName", strCondition))
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
objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxUserLoginName");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxUserLoginNameENS">源对象</param>
 /// <param name = "objvQxUserLoginNameENT">目标对象</param>
public void CopyTo(clsvQxUserLoginNameEN objvQxUserLoginNameENS, clsvQxUserLoginNameEN objvQxUserLoginNameENT)
{
objvQxUserLoginNameENT.UserLoginName = objvQxUserLoginNameENS.UserLoginName; //用户登录名
objvQxUserLoginNameENT.UserId = objvQxUserLoginNameENS.UserId; //用户ID
objvQxUserLoginNameENT.UserName = objvQxUserLoginNameENS.UserName; //用户名
objvQxUserLoginNameENT.DepartmentId = objvQxUserLoginNameENS.DepartmentId; //部门Id
objvQxUserLoginNameENT.DepartmentName = objvQxUserLoginNameENS.DepartmentName; //部门名
objvQxUserLoginNameENT.DepartmentAbbrName = objvQxUserLoginNameENS.DepartmentAbbrName; //名称缩写
objvQxUserLoginNameENT.UserStateId = objvQxUserLoginNameENS.UserStateId; //用户状态Id
objvQxUserLoginNameENT.UserStateName = objvQxUserLoginNameENS.UserStateName; //用户状态名
objvQxUserLoginNameENT.Password = objvQxUserLoginNameENS.Password; //口令
objvQxUserLoginNameENT.EffitiveBeginDate = objvQxUserLoginNameENS.EffitiveBeginDate; //有效开始日期
objvQxUserLoginNameENT.EffitiveEndDate = objvQxUserLoginNameENS.EffitiveEndDate; //有效结束日期
objvQxUserLoginNameENT.StuTeacherId = objvQxUserLoginNameENS.StuTeacherId; //学工号
objvQxUserLoginNameENT.IdentityId = objvQxUserLoginNameENS.IdentityId; //身份编号
objvQxUserLoginNameENT.IdentityDesc = objvQxUserLoginNameENS.IdentityDesc; //身份描述
objvQxUserLoginNameENT.Memo = objvQxUserLoginNameENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.UserLoginName, 30, convQxUserLoginName.UserLoginName);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.UserId, 18, convQxUserLoginName.UserId);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.UserName, 30, convQxUserLoginName.UserName);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.DepartmentId, 8, convQxUserLoginName.DepartmentId);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.DepartmentName, 100, convQxUserLoginName.DepartmentName);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.DepartmentAbbrName, 8, convQxUserLoginName.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.UserStateId, 2, convQxUserLoginName.UserStateId);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.UserStateName, 20, convQxUserLoginName.UserStateName);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.Password, 20, convQxUserLoginName.Password);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.EffitiveBeginDate, 14, convQxUserLoginName.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.EffitiveEndDate, 14, convQxUserLoginName.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.StuTeacherId, 20, convQxUserLoginName.StuTeacherId);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.IdentityId, 2, convQxUserLoginName.IdentityId);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.IdentityDesc, 20, convQxUserLoginName.IdentityDesc);
clsCheckSql.CheckFieldLen(objvQxUserLoginNameEN.Memo, 1000, convQxUserLoginName.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.UserLoginName, convQxUserLoginName.UserLoginName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.UserId, convQxUserLoginName.UserId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.UserName, convQxUserLoginName.UserName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.DepartmentId, convQxUserLoginName.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.DepartmentName, convQxUserLoginName.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.DepartmentAbbrName, convQxUserLoginName.DepartmentAbbrName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.UserStateId, convQxUserLoginName.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.UserStateName, convQxUserLoginName.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.Password, convQxUserLoginName.Password);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.EffitiveBeginDate, convQxUserLoginName.EffitiveBeginDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.EffitiveEndDate, convQxUserLoginName.EffitiveEndDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.StuTeacherId, convQxUserLoginName.StuTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.IdentityId, convQxUserLoginName.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.IdentityDesc, convQxUserLoginName.IdentityDesc);
clsCheckSql.CheckSqlInjection4Field(objvQxUserLoginNameEN.Memo, convQxUserLoginName.Memo);
//检查外键字段长度
 objvQxUserLoginNameEN._IsCheckProperty = true;
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
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
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
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
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
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUserLoginNameEN._CurrTabName);
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
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUserLoginNameEN._CurrTabName, strCondition);
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
 objSQL = clsvQxUserLoginNameDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}