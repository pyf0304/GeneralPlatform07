
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsers_SchoolDA
 表名:vQxUsers_School(00140075)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:00:47
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
 /// vUsers_School(vQxUsers_School)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxUsers_SchoolDA : clsCommBase4DA
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
 return clsvQxUsers_SchoolEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxUsers_SchoolEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUsers_SchoolEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxUsers_SchoolEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxUsers_SchoolEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vQxUsers_School中,检查关键字,长度不正确!(clsvQxUsers_SchoolDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxUsers_School中,关键字不能为空 或 null!(clsvQxUsers_SchoolDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxUsers_SchoolDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception("(errid:Data000004)在表:vQxUsers_School中,检查关键字,长度不正确!(简化版)(clsvQxUsers_SchoolDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:vQxUsers_School中,关键字不能为空 或 null!(clsvQxUsers_SchoolDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsvQxUsers_SchoolDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
 strSQL = "Select * from vQxUsers_School where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers_School");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxUsers_School_SelectByCond",values, "vQxUsers_School");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUsers_School where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers_School");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUsers_School a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers_School Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers_School");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUsers_School a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers_School Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers_School");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUsers_School a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers_School Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUsers_School");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers_School where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxUsers_School(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTable_vQxUsers_School)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers_School where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers_School where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers_School where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers_School where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers_School where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUsers_School where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUsers_School where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUsers_School.* from vQxUsers_School Left Join {1} on {2} where {3} and vQxUsers_School.UserId not in (Select top {5} vQxUsers_School.UserId from vQxUsers_School Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers_School where {1} and UserId not in (Select top {2} UserId from vQxUsers_School where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers_School where {1} and UserId not in (Select top {3} UserId from vQxUsers_School where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUsers_School.* from vQxUsers_School Left Join {1} on {2} where {3} and vQxUsers_School.UserId not in (Select top {5} vQxUsers_School.UserId from vQxUsers_School Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers_School where {1} and UserId not in (Select top {2} UserId from vQxUsers_School where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers_School where {1} and UserId not in (Select top {3} UserId from vQxUsers_School where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUsers_School.* from vQxUsers_School Left Join {1} on {2} where {3} and vQxUsers_School.UserId not in (Select top {5} vQxUsers_School.UserId from vQxUsers_School Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers_School where {1} and UserId not in (Select top {2} UserId from vQxUsers_School where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers_School where {1} and UserId not in (Select top {3} UserId from vQxUsers_School where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUsers_School a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers_School Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUsers_School a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers_School Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUsers_School a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers_School Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUsers_School a where {0} And a.UserId not in (Select Top {2} UserId From vQxUsers_School Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_SchoolByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers_School where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers_School_SelectByCond",values);
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
public List<clsvQxUsers_SchoolEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA:GetObjLst)", objException.Message));
}
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers_School where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = TransNullToBool(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = TransNullToBool(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUsers_SchoolDA: GetObjLst)", objException.Message));
}
objvQxUsers_SchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUsers_SchoolEN);
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
public List<clsvQxUsers_SchoolEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = TransNullToBool(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = TransNullToBool(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUsers_SchoolDA: GetObjLst)", objException.Message));
}
objvQxUsers_SchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUsers_SchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxUsers_SchoolEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers_School_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = TransNullToBool(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = TransNullToBool(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxUsers_SchoolDA: GetObjLstBySP)", objException.Message));
}
objvQxUsers_SchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUsers_SchoolEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUsers_School(ref clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers_School where UserId = " + "'"+ objvQxUsers_SchoolEN.UserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxUsers_SchoolEN.UserId = objDT.Rows[0][convQxUsers_School.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUsers_SchoolEN.UserName = objDT.Rows[0][convQxUsers_School.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentId = objDT.Rows[0][convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentName = objDT.Rows[0][convQxUsers_School.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentAbbrName = objDT.Rows[0][convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.DepartmentTypeId = objDT.Rows[0][convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentTypeName = objDT.Rows[0][convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUsers_SchoolEN.UpDepartmentId = objDT.Rows[0][convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objvQxUsers_SchoolEN.UpDepartmentName = objDT.Rows[0][convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsers_SchoolEN.UserStateId = objDT.Rows[0][convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers_SchoolEN.UserStateName = objDT.Rows[0][convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.IdentityId = objDT.Rows[0][convQxUsers_School.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers_SchoolEN.IdentityDesc = objDT.Rows[0][convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.CardNo = objDT.Rows[0][convQxUsers_School.CardNo].ToString().Trim(); //卡号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQxUsers_SchoolEN.StuTeacherId = objDT.Rows[0][convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.IdGradeBase = objDT.Rows[0][convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvQxUsers_SchoolEN.GradeBaseName = objDT.Rows[0][convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.EnterSchoolDate = objDT.Rows[0][convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.IsOffed = TransNullToBool(objDT.Rows[0][convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers_SchoolEN.BeginYearMonth = objDT.Rows[0][convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.EndYearMonth = objDT.Rows[0][convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.CardState = objDT.Rows[0][convQxUsers_School.CardState].ToString().Trim(); //卡状态(字段类型:varchar,字段长度:10,是否可空:True)
 objvQxUsers_SchoolEN.IsLeaved = TransNullToBool(objDT.Rows[0][convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers_SchoolEN.UpdDate = objDT.Rows[0][convQxUsers_School.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.UpdUser = objDT.Rows[0][convQxUsers_School.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsers_SchoolEN.Memo = objDT.Rows[0][convQxUsers_School.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxUsers_SchoolDA: GetvQxUsers_School)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxUsers_SchoolEN GetObjByUserId(string strUserId)
{
CheckPrimaryKey(strUserId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers_School where UserId = " + "'"+ strUserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
 objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态(字段类型:varchar,字段长度:10,是否可空:True)
 objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxUsers_SchoolDA: GetObjByUserId)", objException.Message));
}
return objvQxUsers_SchoolEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxUsers_School_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUsers_SchoolOneBySP(clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxUsers_SchoolEN.UserId
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers_School_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxUsers_SchoolEN.UserId = objDT.Rows[0][convQxUsers_School.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUsers_SchoolEN.UserName = objDT.Rows[0][convQxUsers_School.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentId = objDT.Rows[0][convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentName = objDT.Rows[0][convQxUsers_School.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentAbbrName = objDT.Rows[0][convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.DepartmentTypeId = objDT.Rows[0][convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers_SchoolEN.DepartmentTypeName = objDT.Rows[0][convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUsers_SchoolEN.UpDepartmentId = objDT.Rows[0][convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objvQxUsers_SchoolEN.UpDepartmentName = objDT.Rows[0][convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsers_SchoolEN.UserStateId = objDT.Rows[0][convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers_SchoolEN.UserStateName = objDT.Rows[0][convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.IdentityId = objDT.Rows[0][convQxUsers_School.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsers_SchoolEN.IdentityDesc = objDT.Rows[0][convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.CardNo = objDT.Rows[0][convQxUsers_School.CardNo].ToString().Trim(); //卡号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQxUsers_SchoolEN.StuTeacherId = objDT.Rows[0][convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.IdGradeBase = objDT.Rows[0][convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvQxUsers_SchoolEN.GradeBaseName = objDT.Rows[0][convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.EnterSchoolDate = objDT.Rows[0][convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.IsOffed = TransNullToBool(objDT.Rows[0][convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers_SchoolEN.BeginYearMonth = objDT.Rows[0][convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.EndYearMonth = objDT.Rows[0][convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsers_SchoolEN.CardState = objDT.Rows[0][convQxUsers_School.CardState].ToString().Trim(); //卡状态(字段类型:varchar,字段长度:10,是否可空:True)
 objvQxUsers_SchoolEN.IsLeaved = TransNullToBool(objDT.Rows[0][convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvQxUsers_SchoolEN.UpdDate = objDT.Rows[0][convQxUsers_School.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsers_SchoolEN.UpdUser = objDT.Rows[0][convQxUsers_School.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsers_SchoolEN.Memo = objDT.Rows[0][convQxUsers_School.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUsers_SchoolEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers_School where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN()
{
UserId = objRow[convQxUsers_School.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUsers_School.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(), //名称缩写
DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(), //部门类型ID
DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(), //部门类型名
UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(), //所属部门号
UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(), //上级部门
UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(), //用户状态名
IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(), //身份编号
IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(), //身份描述
CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(), //卡号
StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(), //学工号
IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(), //年级名称
EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(), //进校日期
IsOffed = TransNullToBool(objRow[convQxUsers_School.IsOffed].ToString().Trim()), //是否毕业
BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(), //开始年月
EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(), //结束年月
CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(), //卡状态
IsLeaved = TransNullToBool(objRow[convQxUsers_School.IsLeaved].ToString().Trim()), //IsLeaved
UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim() //备注
};
objvQxUsers_SchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsers_SchoolEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxUsers_SchoolDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUsers_SchoolEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUsers_School_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN()
{
UserId = objRow[convQxUsers_School.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUsers_School.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(), //名称缩写
DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(), //部门类型ID
DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(), //部门类型名
UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(), //所属部门号
UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(), //上级部门
UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(), //用户状态名
IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(), //身份编号
IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(), //身份描述
CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(), //卡号
StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(), //学工号
IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(), //年级名称
EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(), //进校日期
IsOffed = TransNullToBool(objRow[convQxUsers_School.IsOffed].ToString().Trim()), //是否毕业
BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(), //开始年月
EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(), //结束年月
CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(), //卡状态
IsLeaved = TransNullToBool(objRow[convQxUsers_School.IsLeaved].ToString().Trim()), //IsLeaved
UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim() //备注
};
objvQxUsers_SchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsers_SchoolEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxUsers_SchoolEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = TransNullToBool(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = TransNullToBool(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxUsers_SchoolDA: GetObjByDataRowvQxUsers_School)", objException.Message));
}
objvQxUsers_SchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsers_SchoolEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxUsers_SchoolEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = TransNullToBool(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = TransNullToBool(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxUsers_SchoolDA: GetObjByDataRow)", objException.Message));
}
objvQxUsers_SchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsers_SchoolEN;
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
objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUsers_SchoolEN._CurrTabName, convQxUsers_School.UserId, 18, "");
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
objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUsers_SchoolEN._CurrTabName, convQxUsers_School.UserId, 18, strPrefix);
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
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserId from vQxUsers_School where " + strCondition;
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
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserId from vQxUsers_School where " + strCondition;
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
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUsers_School", "UserId = " + "'"+ strUserId+"'"))
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
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strUserId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxUsers_School_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUsers_School", strCondition))
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
objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxUsers_School");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolENS">源对象</param>
 /// <param name = "objvQxUsers_SchoolENT">目标对象</param>
public void CopyTo(clsvQxUsers_SchoolEN objvQxUsers_SchoolENS, clsvQxUsers_SchoolEN objvQxUsers_SchoolENT)
{
objvQxUsers_SchoolENT.UserId = objvQxUsers_SchoolENS.UserId; //用户ID
objvQxUsers_SchoolENT.UserName = objvQxUsers_SchoolENS.UserName; //用户名
objvQxUsers_SchoolENT.DepartmentId = objvQxUsers_SchoolENS.DepartmentId; //部门Id
objvQxUsers_SchoolENT.DepartmentName = objvQxUsers_SchoolENS.DepartmentName; //部门名
objvQxUsers_SchoolENT.DepartmentAbbrName = objvQxUsers_SchoolENS.DepartmentAbbrName; //名称缩写
objvQxUsers_SchoolENT.DepartmentTypeId = objvQxUsers_SchoolENS.DepartmentTypeId; //部门类型ID
objvQxUsers_SchoolENT.DepartmentTypeName = objvQxUsers_SchoolENS.DepartmentTypeName; //部门类型名
objvQxUsers_SchoolENT.UpDepartmentId = objvQxUsers_SchoolENS.UpDepartmentId; //所属部门号
objvQxUsers_SchoolENT.UpDepartmentName = objvQxUsers_SchoolENS.UpDepartmentName; //上级部门
objvQxUsers_SchoolENT.UserStateId = objvQxUsers_SchoolENS.UserStateId; //用户状态Id
objvQxUsers_SchoolENT.UserStateName = objvQxUsers_SchoolENS.UserStateName; //用户状态名
objvQxUsers_SchoolENT.IdentityId = objvQxUsers_SchoolENS.IdentityId; //身份编号
objvQxUsers_SchoolENT.IdentityDesc = objvQxUsers_SchoolENS.IdentityDesc; //身份描述
objvQxUsers_SchoolENT.CardNo = objvQxUsers_SchoolENS.CardNo; //卡号
objvQxUsers_SchoolENT.StuTeacherId = objvQxUsers_SchoolENS.StuTeacherId; //学工号
objvQxUsers_SchoolENT.IdGradeBase = objvQxUsers_SchoolENS.IdGradeBase; //年级流水号
objvQxUsers_SchoolENT.GradeBaseName = objvQxUsers_SchoolENS.GradeBaseName; //年级名称
objvQxUsers_SchoolENT.EnterSchoolDate = objvQxUsers_SchoolENS.EnterSchoolDate; //进校日期
objvQxUsers_SchoolENT.IsOffed = objvQxUsers_SchoolENS.IsOffed; //是否毕业
objvQxUsers_SchoolENT.BeginYearMonth = objvQxUsers_SchoolENS.BeginYearMonth; //开始年月
objvQxUsers_SchoolENT.EndYearMonth = objvQxUsers_SchoolENS.EndYearMonth; //结束年月
objvQxUsers_SchoolENT.CardState = objvQxUsers_SchoolENS.CardState; //卡状态
objvQxUsers_SchoolENT.IsLeaved = objvQxUsers_SchoolENS.IsLeaved; //IsLeaved
objvQxUsers_SchoolENT.UpdDate = objvQxUsers_SchoolENS.UpdDate; //修改日期
objvQxUsers_SchoolENT.UpdUser = objvQxUsers_SchoolENS.UpdUser; //修改用户
objvQxUsers_SchoolENT.Memo = objvQxUsers_SchoolENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.UserId, 18, convQxUsers_School.UserId);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.UserName, 30, convQxUsers_School.UserName);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.DepartmentId, 8, convQxUsers_School.DepartmentId);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.DepartmentName, 100, convQxUsers_School.DepartmentName);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.DepartmentAbbrName, 8, convQxUsers_School.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.DepartmentTypeId, 2, convQxUsers_School.DepartmentTypeId);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.DepartmentTypeName, 50, convQxUsers_School.DepartmentTypeName);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.UpDepartmentId, 6, convQxUsers_School.UpDepartmentId);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.UpDepartmentName, 100, convQxUsers_School.UpDepartmentName);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.UserStateId, 2, convQxUsers_School.UserStateId);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.UserStateName, 20, convQxUsers_School.UserStateName);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.IdentityId, 2, convQxUsers_School.IdentityId);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.IdentityDesc, 20, convQxUsers_School.IdentityDesc);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.CardNo, 10, convQxUsers_School.CardNo);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.StuTeacherId, 20, convQxUsers_School.StuTeacherId);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.IdGradeBase, 4, convQxUsers_School.IdGradeBase);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.GradeBaseName, 20, convQxUsers_School.GradeBaseName);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.EnterSchoolDate, 8, convQxUsers_School.EnterSchoolDate);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.BeginYearMonth, 8, convQxUsers_School.BeginYearMonth);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.EndYearMonth, 8, convQxUsers_School.EndYearMonth);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.CardState, 10, convQxUsers_School.CardState);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.UpdDate, 20, convQxUsers_School.UpdDate);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.UpdUser, 20, convQxUsers_School.UpdUser);
clsCheckSql.CheckFieldLen(objvQxUsers_SchoolEN.Memo, 1000, convQxUsers_School.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.UserId, convQxUsers_School.UserId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.UserName, convQxUsers_School.UserName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.DepartmentId, convQxUsers_School.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.DepartmentName, convQxUsers_School.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.DepartmentAbbrName, convQxUsers_School.DepartmentAbbrName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.DepartmentTypeId, convQxUsers_School.DepartmentTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.DepartmentTypeName, convQxUsers_School.DepartmentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.UpDepartmentId, convQxUsers_School.UpDepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.UpDepartmentName, convQxUsers_School.UpDepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.UserStateId, convQxUsers_School.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.UserStateName, convQxUsers_School.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.IdentityId, convQxUsers_School.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.IdentityDesc, convQxUsers_School.IdentityDesc);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.CardNo, convQxUsers_School.CardNo);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.StuTeacherId, convQxUsers_School.StuTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.IdGradeBase, convQxUsers_School.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.GradeBaseName, convQxUsers_School.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.EnterSchoolDate, convQxUsers_School.EnterSchoolDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.BeginYearMonth, convQxUsers_School.BeginYearMonth);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.EndYearMonth, convQxUsers_School.EndYearMonth);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.CardState, convQxUsers_School.CardState);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.UpdDate, convQxUsers_School.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.UpdUser, convQxUsers_School.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQxUsers_SchoolEN.Memo, convQxUsers_School.Memo);
//检查外键字段长度
 objvQxUsers_SchoolEN._IsCheckProperty = true;
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
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
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
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
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
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUsers_SchoolEN._CurrTabName);
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
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUsers_SchoolEN._CurrTabName, strCondition);
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
 objSQL = clsvQxUsers_SchoolDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}