
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxDepartmentInfoDA
 表名:QxDepartmentInfo(00140030)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:26:52
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
 /// 部门(QxDepartmentInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxDepartmentInfoDA : clsCommBase4DA
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
 return clsQxDepartmentInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxDepartmentInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxDepartmentInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxDepartmentInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxDepartmentInfoEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDepartmentId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDepartmentId)
{
strDepartmentId = strDepartmentId.Replace("'", "''");
if (strDepartmentId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:QxDepartmentInfo中,检查关键字,长度不正确!(clsQxDepartmentInfoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDepartmentId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxDepartmentInfo中,关键字不能为空 或 null!(clsQxDepartmentInfoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDepartmentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxDepartmentInfoDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strDepartmentId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strDepartmentId)
{
strDepartmentId = strDepartmentId.Replace("'", "''");
if (strDepartmentId.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:QxDepartmentInfo中,检查关键字,长度不正确!(简化版)(clsQxDepartmentInfoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDepartmentId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxDepartmentInfo中,关键字不能为空 或 null!(clsQxDepartmentInfoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDepartmentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxDepartmentInfoDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
 strSQL = "Select * from QxDepartmentInfo where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxDepartmentInfo");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxDepartmentInfo_SelectByCond",values, "QxDepartmentInfo");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfo where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxDepartmentInfo");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxDepartmentInfo a where {0} And a.DepartmentId not in (Select Top {2} DepartmentId From QxDepartmentInfo Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxDepartmentInfo");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxDepartmentInfo a where {0} And a.DepartmentId not in (Select Top {2} DepartmentId From QxDepartmentInfo Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxDepartmentInfo");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxDepartmentInfo a where {0} And a.DepartmentId not in (Select Top {2} DepartmentId From QxDepartmentInfo Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxDepartmentInfo");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxDepartmentInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTable_QxDepartmentInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxDepartmentInfo.* from QxDepartmentInfo Left Join {1} on {2} where {3} and QxDepartmentInfo.DepartmentId not in (Select top {5} QxDepartmentInfo.DepartmentId from QxDepartmentInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfo where {1} and DepartmentId not in (Select top {2} DepartmentId from QxDepartmentInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfo where {1} and DepartmentId not in (Select top {3} DepartmentId from QxDepartmentInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxDepartmentInfo.* from QxDepartmentInfo Left Join {1} on {2} where {3} and QxDepartmentInfo.DepartmentId not in (Select top {5} QxDepartmentInfo.DepartmentId from QxDepartmentInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfo where {1} and DepartmentId not in (Select top {2} DepartmentId from QxDepartmentInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfo where {1} and DepartmentId not in (Select top {3} DepartmentId from QxDepartmentInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxDepartmentInfo.* from QxDepartmentInfo Left Join {1} on {2} where {3} and QxDepartmentInfo.DepartmentId not in (Select top {5} QxDepartmentInfo.DepartmentId from QxDepartmentInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfo where {1} and DepartmentId not in (Select top {2} DepartmentId from QxDepartmentInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfo where {1} and DepartmentId not in (Select top {3} DepartmentId from QxDepartmentInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxDepartmentInfo a where {0} And a.DepartmentId not in (Select Top {2} DepartmentId From QxDepartmentInfo Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxDepartmentInfo a where {0} And a.DepartmentId not in (Select Top {2} DepartmentId From QxDepartmentInfo Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxDepartmentInfo a where {0} And a.DepartmentId not in (Select Top {2} DepartmentId From QxDepartmentInfo Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxDepartmentInfo a where {0} And a.DepartmentId not in (Select Top {2} DepartmentId From QxDepartmentInfo Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfoByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxDepartmentInfo_SelectByCond",values);
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
public List<clsQxDepartmentInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA:GetObjLst)", objException.Message));
}
List<clsQxDepartmentInfoEN> arrObjLst = new List<clsQxDepartmentInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoEN objQxDepartmentInfoEN = new clsQxDepartmentInfoEN();
try
{
objQxDepartmentInfoEN.DepartmentId = objRow[conQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objQxDepartmentInfoEN.DepartmentName = objRow[conQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoEN.DepartmentAbbrName = objRow[conQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoEN.DepartmentTypeId = objRow[conQxDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoEN.UpDepartmentId = objRow[conQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objQxDepartmentInfoEN.OrderNum = objRow[conQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoEN.InUse = TransNullToBool(objRow[conQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoEN.Memo = objRow[conQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxDepartmentInfoDA: GetObjLst)", objException.Message));
}
objQxDepartmentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxDepartmentInfoEN);
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
public List<clsQxDepartmentInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxDepartmentInfoEN> arrObjLst = new List<clsQxDepartmentInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoEN objQxDepartmentInfoEN = new clsQxDepartmentInfoEN();
try
{
objQxDepartmentInfoEN.DepartmentId = objRow[conQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objQxDepartmentInfoEN.DepartmentName = objRow[conQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoEN.DepartmentAbbrName = objRow[conQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoEN.DepartmentTypeId = objRow[conQxDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoEN.UpDepartmentId = objRow[conQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objQxDepartmentInfoEN.OrderNum = objRow[conQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoEN.InUse = TransNullToBool(objRow[conQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoEN.Memo = objRow[conQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxDepartmentInfoDA: GetObjLst)", objException.Message));
}
objQxDepartmentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxDepartmentInfoEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA:GetObjLstBySP)", objException.Message));
}
List<clsQxDepartmentInfoEN> arrObjLst = new List<clsQxDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxDepartmentInfo_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoEN objQxDepartmentInfoEN = new clsQxDepartmentInfoEN();
try
{
objQxDepartmentInfoEN.DepartmentId = objRow[conQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objQxDepartmentInfoEN.DepartmentName = objRow[conQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoEN.DepartmentAbbrName = objRow[conQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoEN.DepartmentTypeId = objRow[conQxDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoEN.UpDepartmentId = objRow[conQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objQxDepartmentInfoEN.OrderNum = objRow[conQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoEN.InUse = TransNullToBool(objRow[conQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoEN.Memo = objRow[conQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxDepartmentInfoDA: GetObjLstBySP)", objException.Message));
}
objQxDepartmentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxDepartmentInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxDepartmentInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxDepartmentInfo(ref clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where DepartmentId = " + "'"+ objQxDepartmentInfoEN.DepartmentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxDepartmentInfoEN.DepartmentId = objDT.Rows[0][conQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objQxDepartmentInfoEN.DepartmentName = objDT.Rows[0][conQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objQxDepartmentInfoEN.DepartmentAbbrName = objDT.Rows[0][conQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objQxDepartmentInfoEN.DepartmentTypeId = objDT.Rows[0][conQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objQxDepartmentInfoEN.UpDepartmentId = objDT.Rows[0][conQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objQxDepartmentInfoEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxDepartmentInfoEN.InUse = TransNullToBool(objDT.Rows[0][conQxDepartmentInfo.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxDepartmentInfoEN.Memo = objDT.Rows[0][conQxDepartmentInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxDepartmentInfoDA: GetQxDepartmentInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxDepartmentInfoEN GetObjByDepartmentId(string strDepartmentId)
{
CheckPrimaryKey(strDepartmentId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where DepartmentId = " + "'"+ strDepartmentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxDepartmentInfoEN objQxDepartmentInfoEN = new clsQxDepartmentInfoEN();
try
{
 objQxDepartmentInfoEN.DepartmentId = objRow[conQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objQxDepartmentInfoEN.DepartmentName = objRow[conQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objQxDepartmentInfoEN.DepartmentAbbrName = objRow[conQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objQxDepartmentInfoEN.DepartmentTypeId = objRow[conQxDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objQxDepartmentInfoEN.UpDepartmentId = objRow[conQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objQxDepartmentInfoEN.OrderNum = objRow[conQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfo.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxDepartmentInfoEN.Memo = objRow[conQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxDepartmentInfoDA: GetObjByDepartmentId)", objException.Message));
}
return objQxDepartmentInfoEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxDepartmentInfo_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxDepartmentInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxDepartmentInfoOneBySP(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxDepartmentInfoEN.DepartmentId
};
 objDT = objSQL.ExecSpReturnDT("QxDepartmentInfo_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxDepartmentInfoEN.DepartmentId = objDT.Rows[0][conQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objQxDepartmentInfoEN.DepartmentName = objDT.Rows[0][conQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objQxDepartmentInfoEN.DepartmentAbbrName = objDT.Rows[0][conQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objQxDepartmentInfoEN.DepartmentTypeId = objDT.Rows[0][conQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objQxDepartmentInfoEN.UpDepartmentId = objDT.Rows[0][conQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号(字段类型:varchar,字段长度:6,是否可空:True)
 objQxDepartmentInfoEN.OrderNum = TransNullToInt(objDT.Rows[0][conQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxDepartmentInfoEN.InUse = TransNullToBool(objDT.Rows[0][conQxDepartmentInfo.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxDepartmentInfoEN.Memo = objDT.Rows[0][conQxDepartmentInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxDepartmentInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxDepartmentInfoEN objQxDepartmentInfoEN = new clsQxDepartmentInfoEN()
{
DepartmentId = objRow[conQxDepartmentInfo.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[conQxDepartmentInfo.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[conQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(), //名称缩写
DepartmentTypeId = objRow[conQxDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentTypeId].ToString().Trim(), //部门类型ID
UpDepartmentId = objRow[conQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.UpDepartmentId].ToString().Trim(), //所属部门号
OrderNum = objRow[conQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfo.OrderNum].ToString().Trim()), //排序号
InUse = TransNullToBool(objRow[conQxDepartmentInfo.InUse].ToString().Trim()), //是否在用
Memo = objRow[conQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfo.Memo].ToString().Trim() //备注
};
objQxDepartmentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxDepartmentInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxDepartmentInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxDepartmentInfoEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxDepartmentInfo_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxDepartmentInfoEN objQxDepartmentInfoEN = new clsQxDepartmentInfoEN()
{
DepartmentId = objRow[conQxDepartmentInfo.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[conQxDepartmentInfo.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[conQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(), //名称缩写
DepartmentTypeId = objRow[conQxDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentTypeId].ToString().Trim(), //部门类型ID
UpDepartmentId = objRow[conQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.UpDepartmentId].ToString().Trim(), //所属部门号
OrderNum = objRow[conQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfo.OrderNum].ToString().Trim()), //排序号
InUse = TransNullToBool(objRow[conQxDepartmentInfo.InUse].ToString().Trim()), //是否在用
Memo = objRow[conQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfo.Memo].ToString().Trim() //备注
};
objQxDepartmentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxDepartmentInfoEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxDepartmentInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxDepartmentInfoEN objQxDepartmentInfoEN = new clsQxDepartmentInfoEN();
try
{
objQxDepartmentInfoEN.DepartmentId = objRow[conQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objQxDepartmentInfoEN.DepartmentName = objRow[conQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoEN.DepartmentAbbrName = objRow[conQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoEN.DepartmentTypeId = objRow[conQxDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoEN.UpDepartmentId = objRow[conQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objQxDepartmentInfoEN.OrderNum = objRow[conQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoEN.InUse = TransNullToBool(objRow[conQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoEN.Memo = objRow[conQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxDepartmentInfoDA: GetObjByDataRowQxDepartmentInfo)", objException.Message));
}
objQxDepartmentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxDepartmentInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxDepartmentInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxDepartmentInfoEN objQxDepartmentInfoEN = new clsQxDepartmentInfoEN();
try
{
objQxDepartmentInfoEN.DepartmentId = objRow[conQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objQxDepartmentInfoEN.DepartmentName = objRow[conQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoEN.DepartmentAbbrName = objRow[conQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoEN.DepartmentTypeId = objRow[conQxDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoEN.UpDepartmentId = objRow[conQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objQxDepartmentInfoEN.OrderNum = objRow[conQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoEN.InUse = TransNullToBool(objRow[conQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoEN.Memo = objRow[conQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxDepartmentInfoDA: GetObjByDataRow)", objException.Message));
}
objQxDepartmentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxDepartmentInfoEN;
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
objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxDepartmentInfoEN._CurrTabName, conQxDepartmentInfo.DepartmentId, 8, "");
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
objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxDepartmentInfoEN._CurrTabName, conQxDepartmentInfo.DepartmentId, 8, strPrefix);
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
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DepartmentId from QxDepartmentInfo where " + strCondition;
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
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DepartmentId from QxDepartmentInfo where " + strCondition;
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
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDepartmentId)
{
CheckPrimaryKey(strDepartmentId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxDepartmentInfo", "DepartmentId = " + "'"+ strDepartmentId+"'"))
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
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strDepartmentId)
{
CheckPrimaryKey(strDepartmentId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strDepartmentId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxDepartmentInfo_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxDepartmentInfo", strCondition))
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
objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxDepartmentInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
 {
 if (objQxDepartmentInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxDepartmentInfoEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxDepartmentInfo");
objRow = objDS.Tables["QxDepartmentInfo"].NewRow();
objRow[conQxDepartmentInfo.DepartmentId] = objQxDepartmentInfoEN.DepartmentId; //部门Id
objRow[conQxDepartmentInfo.DepartmentName] = objQxDepartmentInfoEN.DepartmentName; //部门名
 if (objQxDepartmentInfoEN.DepartmentAbbrName !=  "")
 {
objRow[conQxDepartmentInfo.DepartmentAbbrName] = objQxDepartmentInfoEN.DepartmentAbbrName; //名称缩写
 }
 if (objQxDepartmentInfoEN.DepartmentTypeId !=  "")
 {
objRow[conQxDepartmentInfo.DepartmentTypeId] = objQxDepartmentInfoEN.DepartmentTypeId; //部门类型ID
 }
 if (objQxDepartmentInfoEN.UpDepartmentId !=  "")
 {
objRow[conQxDepartmentInfo.UpDepartmentId] = objQxDepartmentInfoEN.UpDepartmentId; //所属部门号
 }
objRow[conQxDepartmentInfo.OrderNum] = objQxDepartmentInfoEN.OrderNum; //排序号
objRow[conQxDepartmentInfo.InUse] = objQxDepartmentInfoEN.InUse; //是否在用
 if (objQxDepartmentInfoEN.Memo !=  "")
 {
objRow[conQxDepartmentInfo.Memo] = objQxDepartmentInfoEN.Memo; //备注
 }
objDS.Tables[clsQxDepartmentInfoEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxDepartmentInfoEN._CurrTabName);
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
 /// <param name = "objQxDepartmentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
 if (objQxDepartmentInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxDepartmentInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxDepartmentInfoEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentId);
 var strDepartmentId = objQxDepartmentInfoEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentName);
 var strDepartmentName = objQxDepartmentInfoEN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentName + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentAbbrName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentAbbrName);
 var strDepartmentAbbrName = objQxDepartmentInfoEN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentAbbrName + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoEN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoEN.DepartmentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentTypeId);
 var strDepartmentTypeId = objQxDepartmentInfoEN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentTypeId + "'");
 }
 
 if (objQxDepartmentInfoEN.UpDepartmentId  ==  "")
 {
 objQxDepartmentInfoEN.UpDepartmentId = null;
 }
 if (objQxDepartmentInfoEN.UpDepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.UpDepartmentId);
 var strUpDepartmentId = objQxDepartmentInfoEN.UpDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpDepartmentId + "'");
 }
 
 if (objQxDepartmentInfoEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.OrderNum);
 arrValueListForInsert.Add(objQxDepartmentInfoEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQxDepartmentInfo.InUse);
 arrValueListForInsert.Add("'" + (objQxDepartmentInfoEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxDepartmentInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.Memo);
 var strMemo = objQxDepartmentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxDepartmentInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxDepartmentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
 if (objQxDepartmentInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxDepartmentInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxDepartmentInfoEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentId);
 var strDepartmentId = objQxDepartmentInfoEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentName);
 var strDepartmentName = objQxDepartmentInfoEN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentName + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentAbbrName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentAbbrName);
 var strDepartmentAbbrName = objQxDepartmentInfoEN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentAbbrName + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoEN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoEN.DepartmentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentTypeId);
 var strDepartmentTypeId = objQxDepartmentInfoEN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentTypeId + "'");
 }
 
 if (objQxDepartmentInfoEN.UpDepartmentId  ==  "")
 {
 objQxDepartmentInfoEN.UpDepartmentId = null;
 }
 if (objQxDepartmentInfoEN.UpDepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.UpDepartmentId);
 var strUpDepartmentId = objQxDepartmentInfoEN.UpDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpDepartmentId + "'");
 }
 
 if (objQxDepartmentInfoEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.OrderNum);
 arrValueListForInsert.Add(objQxDepartmentInfoEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQxDepartmentInfo.InUse);
 arrValueListForInsert.Add("'" + (objQxDepartmentInfoEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxDepartmentInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.Memo);
 var strMemo = objQxDepartmentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxDepartmentInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxDepartmentInfoEN.DepartmentId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxDepartmentInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxDepartmentInfoEN objQxDepartmentInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxDepartmentInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxDepartmentInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxDepartmentInfoEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentId);
 var strDepartmentId = objQxDepartmentInfoEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentName);
 var strDepartmentName = objQxDepartmentInfoEN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentName + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentAbbrName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentAbbrName);
 var strDepartmentAbbrName = objQxDepartmentInfoEN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentAbbrName + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoEN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoEN.DepartmentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentTypeId);
 var strDepartmentTypeId = objQxDepartmentInfoEN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentTypeId + "'");
 }
 
 if (objQxDepartmentInfoEN.UpDepartmentId  ==  "")
 {
 objQxDepartmentInfoEN.UpDepartmentId = null;
 }
 if (objQxDepartmentInfoEN.UpDepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.UpDepartmentId);
 var strUpDepartmentId = objQxDepartmentInfoEN.UpDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpDepartmentId + "'");
 }
 
 if (objQxDepartmentInfoEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.OrderNum);
 arrValueListForInsert.Add(objQxDepartmentInfoEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQxDepartmentInfo.InUse);
 arrValueListForInsert.Add("'" + (objQxDepartmentInfoEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxDepartmentInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.Memo);
 var strMemo = objQxDepartmentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxDepartmentInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objQxDepartmentInfoEN.DepartmentId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxDepartmentInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxDepartmentInfoEN objQxDepartmentInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQxDepartmentInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxDepartmentInfoEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxDepartmentInfoEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentId);
 var strDepartmentId = objQxDepartmentInfoEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentName);
 var strDepartmentName = objQxDepartmentInfoEN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentName + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentAbbrName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentAbbrName);
 var strDepartmentAbbrName = objQxDepartmentInfoEN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentAbbrName + "'");
 }
 
 if (objQxDepartmentInfoEN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoEN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoEN.DepartmentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.DepartmentTypeId);
 var strDepartmentTypeId = objQxDepartmentInfoEN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentTypeId + "'");
 }
 
 if (objQxDepartmentInfoEN.UpDepartmentId  ==  "")
 {
 objQxDepartmentInfoEN.UpDepartmentId = null;
 }
 if (objQxDepartmentInfoEN.UpDepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.UpDepartmentId);
 var strUpDepartmentId = objQxDepartmentInfoEN.UpDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpDepartmentId + "'");
 }
 
 if (objQxDepartmentInfoEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.OrderNum);
 arrValueListForInsert.Add(objQxDepartmentInfoEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQxDepartmentInfo.InUse);
 arrValueListForInsert.Add("'" + (objQxDepartmentInfoEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxDepartmentInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfo.Memo);
 var strMemo = objQxDepartmentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxDepartmentInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxDepartmentInfoEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxDepartmentInfoBySP(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxDepartmentInfoEN.DepartmentId,
 objQxDepartmentInfoEN.DepartmentName,
 objQxDepartmentInfoEN.DepartmentAbbrName,
 objQxDepartmentInfoEN.DepartmentTypeId,
 objQxDepartmentInfoEN.UpDepartmentId,
 objQxDepartmentInfoEN.OrderNum,
 objQxDepartmentInfoEN.InUse,
objQxDepartmentInfoEN.Memo
};
 objSQL.ExecSP("QxDepartmentInfo_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxDepartmentInfos(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where DepartmentId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxDepartmentInfo");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDepartmentId = oRow[conQxDepartmentInfo.DepartmentId].ToString().Trim();
if (IsExist(strDepartmentId))
{
 string strResult = "关键字变量值为:" + string.Format("DepartmentId = {0}", strDepartmentId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxDepartmentInfoEN._CurrTabName ].NewRow();
objRow[conQxDepartmentInfo.DepartmentId] = oRow[conQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objRow[conQxDepartmentInfo.DepartmentName] = oRow[conQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objRow[conQxDepartmentInfo.DepartmentAbbrName] = oRow[conQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objRow[conQxDepartmentInfo.DepartmentTypeId] = oRow[conQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objRow[conQxDepartmentInfo.UpDepartmentId] = oRow[conQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objRow[conQxDepartmentInfo.OrderNum] = oRow[conQxDepartmentInfo.OrderNum].ToString().Trim(); //排序号
objRow[conQxDepartmentInfo.InUse] = oRow[conQxDepartmentInfo.InUse].ToString().Trim(); //是否在用
objRow[conQxDepartmentInfo.Memo] = oRow[conQxDepartmentInfo.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxDepartmentInfoEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxDepartmentInfoEN._CurrTabName);
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
 /// <param name = "objQxDepartmentInfoEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
 if (objQxDepartmentInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfo where DepartmentId = " + "'"+ objQxDepartmentInfoEN.DepartmentId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxDepartmentInfoEN._CurrTabName);
if (objDS.Tables[clsQxDepartmentInfoEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DepartmentId = " + "'"+ objQxDepartmentInfoEN.DepartmentId+"'");
return false;
}
objRow = objDS.Tables[clsQxDepartmentInfoEN._CurrTabName].Rows[0];
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentId))
 {
objRow[conQxDepartmentInfo.DepartmentId] = objQxDepartmentInfoEN.DepartmentId; //部门Id
 }
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentName))
 {
objRow[conQxDepartmentInfo.DepartmentName] = objQxDepartmentInfoEN.DepartmentName; //部门名
 }
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentAbbrName))
 {
objRow[conQxDepartmentInfo.DepartmentAbbrName] = objQxDepartmentInfoEN.DepartmentAbbrName; //名称缩写
 }
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentTypeId))
 {
objRow[conQxDepartmentInfo.DepartmentTypeId] = objQxDepartmentInfoEN.DepartmentTypeId; //部门类型ID
 }
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.UpDepartmentId))
 {
objRow[conQxDepartmentInfo.UpDepartmentId] = objQxDepartmentInfoEN.UpDepartmentId; //所属部门号
 }
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.OrderNum))
 {
objRow[conQxDepartmentInfo.OrderNum] = objQxDepartmentInfoEN.OrderNum; //排序号
 }
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.InUse))
 {
objRow[conQxDepartmentInfo.InUse] = objQxDepartmentInfoEN.InUse; //是否在用
 }
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.Memo))
 {
objRow[conQxDepartmentInfo.Memo] = objQxDepartmentInfoEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxDepartmentInfoEN._CurrTabName);
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
public bool UpdateBySP(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
 if (objQxDepartmentInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxDepartmentInfoEN.DepartmentId,
 objQxDepartmentInfoEN.DepartmentName,
 objQxDepartmentInfoEN.DepartmentAbbrName,
 objQxDepartmentInfoEN.DepartmentTypeId,
 objQxDepartmentInfoEN.UpDepartmentId,
 objQxDepartmentInfoEN.OrderNum,
 objQxDepartmentInfoEN.InUse,
 objQxDepartmentInfoEN.Memo
};
 objSQL.ExecSP("QxDepartmentInfo_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxDepartmentInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
 if (objQxDepartmentInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxDepartmentInfo Set ");
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentName))
 {
 if (objQxDepartmentInfoEN.DepartmentName !=  null)
 {
 var strDepartmentName = objQxDepartmentInfoEN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentName, conQxDepartmentInfo.DepartmentName); //部门名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.DepartmentName); //部门名
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentAbbrName))
 {
 if (objQxDepartmentInfoEN.DepartmentAbbrName !=  null)
 {
 var strDepartmentAbbrName = objQxDepartmentInfoEN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentAbbrName, conQxDepartmentInfo.DepartmentAbbrName); //名称缩写
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.DepartmentAbbrName); //名称缩写
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentTypeId))
 {
 if (objQxDepartmentInfoEN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoEN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoEN.DepartmentTypeId !=  null)
 {
 var strDepartmentTypeId = objQxDepartmentInfoEN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentTypeId, conQxDepartmentInfo.DepartmentTypeId); //部门类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.DepartmentTypeId); //部门类型ID
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.UpDepartmentId))
 {
 if (objQxDepartmentInfoEN.UpDepartmentId  ==  "")
 {
 objQxDepartmentInfoEN.UpDepartmentId = null;
 }
 if (objQxDepartmentInfoEN.UpDepartmentId !=  null)
 {
 var strUpDepartmentId = objQxDepartmentInfoEN.UpDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpDepartmentId, conQxDepartmentInfo.UpDepartmentId); //所属部门号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.UpDepartmentId); //所属部门号
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.OrderNum))
 {
 if (objQxDepartmentInfoEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxDepartmentInfoEN.OrderNum, conQxDepartmentInfo.OrderNum); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.OrderNum); //排序号
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxDepartmentInfoEN.InUse == true?"1":"0", conQxDepartmentInfo.InUse); //是否在用
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.Memo))
 {
 if (objQxDepartmentInfoEN.Memo !=  null)
 {
 var strMemo = objQxDepartmentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxDepartmentInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DepartmentId = '{0}'", objQxDepartmentInfoEN.DepartmentId); 
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
 /// <param name = "objQxDepartmentInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxDepartmentInfoEN objQxDepartmentInfoEN, string strCondition)
{
 if (objQxDepartmentInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxDepartmentInfo Set ");
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentName))
 {
 if (objQxDepartmentInfoEN.DepartmentName !=  null)
 {
 var strDepartmentName = objQxDepartmentInfoEN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentName = '{0}',", strDepartmentName); //部门名
 }
 else
 {
 sbSQL.Append(" DepartmentName = null,"); //部门名
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentAbbrName))
 {
 if (objQxDepartmentInfoEN.DepartmentAbbrName !=  null)
 {
 var strDepartmentAbbrName = objQxDepartmentInfoEN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentAbbrName = '{0}',", strDepartmentAbbrName); //名称缩写
 }
 else
 {
 sbSQL.Append(" DepartmentAbbrName = null,"); //名称缩写
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentTypeId))
 {
 if (objQxDepartmentInfoEN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoEN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoEN.DepartmentTypeId !=  null)
 {
 var strDepartmentTypeId = objQxDepartmentInfoEN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentTypeId = '{0}',", strDepartmentTypeId); //部门类型ID
 }
 else
 {
 sbSQL.Append(" DepartmentTypeId = null,"); //部门类型ID
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.UpDepartmentId))
 {
 if (objQxDepartmentInfoEN.UpDepartmentId  ==  "")
 {
 objQxDepartmentInfoEN.UpDepartmentId = null;
 }
 if (objQxDepartmentInfoEN.UpDepartmentId !=  null)
 {
 var strUpDepartmentId = objQxDepartmentInfoEN.UpDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpDepartmentId = '{0}',", strUpDepartmentId); //所属部门号
 }
 else
 {
 sbSQL.Append(" UpDepartmentId = null,"); //所属部门号
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxDepartmentInfoEN.OrderNum); //排序号
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxDepartmentInfoEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.Memo))
 {
 if (objQxDepartmentInfoEN.Memo !=  null)
 {
 var strMemo = objQxDepartmentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxDepartmentInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxDepartmentInfoEN objQxDepartmentInfoEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxDepartmentInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxDepartmentInfo Set ");
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentName))
 {
 if (objQxDepartmentInfoEN.DepartmentName !=  null)
 {
 var strDepartmentName = objQxDepartmentInfoEN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentName = '{0}',", strDepartmentName); //部门名
 }
 else
 {
 sbSQL.Append(" DepartmentName = null,"); //部门名
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentAbbrName))
 {
 if (objQxDepartmentInfoEN.DepartmentAbbrName !=  null)
 {
 var strDepartmentAbbrName = objQxDepartmentInfoEN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentAbbrName = '{0}',", strDepartmentAbbrName); //名称缩写
 }
 else
 {
 sbSQL.Append(" DepartmentAbbrName = null,"); //名称缩写
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentTypeId))
 {
 if (objQxDepartmentInfoEN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoEN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoEN.DepartmentTypeId !=  null)
 {
 var strDepartmentTypeId = objQxDepartmentInfoEN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentTypeId = '{0}',", strDepartmentTypeId); //部门类型ID
 }
 else
 {
 sbSQL.Append(" DepartmentTypeId = null,"); //部门类型ID
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.UpDepartmentId))
 {
 if (objQxDepartmentInfoEN.UpDepartmentId  ==  "")
 {
 objQxDepartmentInfoEN.UpDepartmentId = null;
 }
 if (objQxDepartmentInfoEN.UpDepartmentId !=  null)
 {
 var strUpDepartmentId = objQxDepartmentInfoEN.UpDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpDepartmentId = '{0}',", strUpDepartmentId); //所属部门号
 }
 else
 {
 sbSQL.Append(" UpDepartmentId = null,"); //所属部门号
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxDepartmentInfoEN.OrderNum); //排序号
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxDepartmentInfoEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.Memo))
 {
 if (objQxDepartmentInfoEN.Memo !=  null)
 {
 var strMemo = objQxDepartmentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxDepartmentInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxDepartmentInfoEN objQxDepartmentInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQxDepartmentInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxDepartmentInfo Set ");
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentName))
 {
 if (objQxDepartmentInfoEN.DepartmentName !=  null)
 {
 var strDepartmentName = objQxDepartmentInfoEN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentName, conQxDepartmentInfo.DepartmentName); //部门名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.DepartmentName); //部门名
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentAbbrName))
 {
 if (objQxDepartmentInfoEN.DepartmentAbbrName !=  null)
 {
 var strDepartmentAbbrName = objQxDepartmentInfoEN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentAbbrName, conQxDepartmentInfo.DepartmentAbbrName); //名称缩写
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.DepartmentAbbrName); //名称缩写
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.DepartmentTypeId))
 {
 if (objQxDepartmentInfoEN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoEN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoEN.DepartmentTypeId !=  null)
 {
 var strDepartmentTypeId = objQxDepartmentInfoEN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentTypeId, conQxDepartmentInfo.DepartmentTypeId); //部门类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.DepartmentTypeId); //部门类型ID
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.UpDepartmentId))
 {
 if (objQxDepartmentInfoEN.UpDepartmentId  ==  "")
 {
 objQxDepartmentInfoEN.UpDepartmentId = null;
 }
 if (objQxDepartmentInfoEN.UpDepartmentId !=  null)
 {
 var strUpDepartmentId = objQxDepartmentInfoEN.UpDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpDepartmentId, conQxDepartmentInfo.UpDepartmentId); //所属部门号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.UpDepartmentId); //所属部门号
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.OrderNum))
 {
 if (objQxDepartmentInfoEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxDepartmentInfoEN.OrderNum, conQxDepartmentInfo.OrderNum); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.OrderNum); //排序号
 }
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxDepartmentInfoEN.InUse == true?"1":"0", conQxDepartmentInfo.InUse); //是否在用
 }
 
 if (objQxDepartmentInfoEN.IsUpdated(conQxDepartmentInfo.Memo))
 {
 if (objQxDepartmentInfoEN.Memo !=  null)
 {
 var strMemo = objQxDepartmentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxDepartmentInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DepartmentId = '{0}'", objQxDepartmentInfoEN.DepartmentId); 
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
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDepartmentId) 
{
CheckPrimaryKey(strDepartmentId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDepartmentId,
};
 objSQL.ExecSP("QxDepartmentInfo_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDepartmentId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDepartmentId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
//删除QxDepartmentInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxDepartmentInfo where DepartmentId = " + "'"+ strDepartmentId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxDepartmentInfo(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
//删除QxDepartmentInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxDepartmentInfo where DepartmentId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDepartmentId) 
{
CheckPrimaryKey(strDepartmentId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
//删除QxDepartmentInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxDepartmentInfo where DepartmentId = " + "'"+ strDepartmentId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxDepartmentInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: DelQxDepartmentInfo)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxDepartmentInfo where " + strCondition ;
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
public bool DelQxDepartmentInfoWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxDepartmentInfoDA: DelQxDepartmentInfoWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxDepartmentInfo where " + strCondition ;
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
 /// <param name = "objQxDepartmentInfoENS">源对象</param>
 /// <param name = "objQxDepartmentInfoENT">目标对象</param>
public void CopyTo(clsQxDepartmentInfoEN objQxDepartmentInfoENS, clsQxDepartmentInfoEN objQxDepartmentInfoENT)
{
objQxDepartmentInfoENT.DepartmentId = objQxDepartmentInfoENS.DepartmentId; //部门Id
objQxDepartmentInfoENT.DepartmentName = objQxDepartmentInfoENS.DepartmentName; //部门名
objQxDepartmentInfoENT.DepartmentAbbrName = objQxDepartmentInfoENS.DepartmentAbbrName; //名称缩写
objQxDepartmentInfoENT.DepartmentTypeId = objQxDepartmentInfoENS.DepartmentTypeId; //部门类型ID
objQxDepartmentInfoENT.UpDepartmentId = objQxDepartmentInfoENS.UpDepartmentId; //所属部门号
objQxDepartmentInfoENT.OrderNum = objQxDepartmentInfoENS.OrderNum; //排序号
objQxDepartmentInfoENT.InUse = objQxDepartmentInfoENS.InUse; //是否在用
objQxDepartmentInfoENT.Memo = objQxDepartmentInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxDepartmentInfoEN.DepartmentName, conQxDepartmentInfo.DepartmentName);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.DepartmentId, 8, conQxDepartmentInfo.DepartmentId);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.DepartmentName, 100, conQxDepartmentInfo.DepartmentName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.DepartmentAbbrName, 8, conQxDepartmentInfo.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.DepartmentTypeId, 2, conQxDepartmentInfo.DepartmentTypeId);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.UpDepartmentId, 6, conQxDepartmentInfo.UpDepartmentId);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.Memo, 1000, conQxDepartmentInfo.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxDepartmentInfoEN.DepartmentTypeId, 2, conQxDepartmentInfo.DepartmentTypeId);
 objQxDepartmentInfoEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.DepartmentName, 100, conQxDepartmentInfo.DepartmentName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.DepartmentAbbrName, 8, conQxDepartmentInfo.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.DepartmentTypeId, 2, conQxDepartmentInfo.DepartmentTypeId);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.UpDepartmentId, 6, conQxDepartmentInfo.UpDepartmentId);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.Memo, 1000, conQxDepartmentInfo.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxDepartmentInfoEN.DepartmentTypeId, 2, conQxDepartmentInfo.DepartmentTypeId);
 objQxDepartmentInfoEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.DepartmentId, 8, conQxDepartmentInfo.DepartmentId);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.DepartmentName, 100, conQxDepartmentInfo.DepartmentName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.DepartmentAbbrName, 8, conQxDepartmentInfo.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.DepartmentTypeId, 2, conQxDepartmentInfo.DepartmentTypeId);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.UpDepartmentId, 6, conQxDepartmentInfo.UpDepartmentId);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoEN.Memo, 1000, conQxDepartmentInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoEN.DepartmentId, conQxDepartmentInfo.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoEN.DepartmentName, conQxDepartmentInfo.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoEN.DepartmentAbbrName, conQxDepartmentInfo.DepartmentAbbrName);
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoEN.DepartmentTypeId, conQxDepartmentInfo.DepartmentTypeId);
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoEN.UpDepartmentId, conQxDepartmentInfo.UpDepartmentId);
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoEN.Memo, conQxDepartmentInfo.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxDepartmentInfoEN.DepartmentTypeId, 2, conQxDepartmentInfo.DepartmentTypeId);
 objQxDepartmentInfoEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetDepartmentId()
{
//获取某学院所有专业信息
string strSQL = "select DepartmentId, DepartmentName from QxDepartmentInfo ";
 clsSpecSQLforSql mySql = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxDepartmentInfoEN._CurrTabName);
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
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxDepartmentInfoEN._CurrTabName, strCondition);
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
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
 objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}