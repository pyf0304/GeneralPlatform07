
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzClgDA
 表名:XzClg(00140122)
 * 版本:2024.02.03.1(服务器:WIN-SRV103-116)
 日期:2024/02/18 11:34:57
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
 /// XzClg(XzClg)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsXzClgDA : clsCommBase4DA
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
 return clsXzClgEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsXzClgEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzClgEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsXzClgEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsXzClgEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdXzCollege">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdXzCollege)
{
strIdXzCollege = strIdXzCollege.Replace("'", "''");
if (strIdXzCollege.Length > 4)
{
throw new Exception("(errid:Data000001)在表:XzClg中,检查关键字,长度不正确!(clsXzClgDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdXzCollege)  ==  true)
{
throw new Exception("(errid:Data000002)在表:XzClg中,关键字不能为空 或 null!(clsXzClgDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdXzCollege);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsXzClgDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strIdXzCollege">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strIdXzCollege)
{
strIdXzCollege = strIdXzCollege.Replace("'", "''");
if (strIdXzCollege.Length > 4 + 4)
{
throw new Exception("(errid:Data000004)在表:XzClg中,检查关键字,长度不正确!(简化版)(clsXzClgDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdXzCollege)  ==  true)
{
throw new Exception("(errid:Data000005)在表:XzClg中,关键字不能为空 或 null!(clsXzClgDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdXzCollege);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsXzClgDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
 strSQL = "Select * from XzClg where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "XzClg");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("XzClg_SelectByCond",values, "XzClg");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzClg where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "XzClg");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzClgDA: GetXzClgByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from XzClg a where {0} And a.IdXzCollege not in (Select Top {2} IdXzCollege From XzClg Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "XzClg");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzClgDA: GetXzClgByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from XzClg a where {0} And a.IdXzCollege not in (Select Top {2} IdXzCollege From XzClg Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "XzClg");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzClgDA: GetXzClgByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from XzClg a where {0} And a.IdXzCollege not in (Select Top {2} IdXzCollege From XzClg Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "XzClg");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_XzClg(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTable_XzClg)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzClg where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzClg where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzClg where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzClg where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsXzClgDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzClg.* from XzClg Left Join {1} on {2} where {3} and XzClg.IdXzCollege not in (Select top {5} XzClg.IdXzCollege from XzClg Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzClg where {1} and IdXzCollege not in (Select top {2} IdXzCollege from XzClg where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzClg where {1} and IdXzCollege not in (Select top {3} IdXzCollege from XzClg where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsXzClgDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzClg.* from XzClg Left Join {1} on {2} where {3} and XzClg.IdXzCollege not in (Select top {5} XzClg.IdXzCollege from XzClg Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzClg where {1} and IdXzCollege not in (Select top {2} IdXzCollege from XzClg where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzClg where {1} and IdXzCollege not in (Select top {3} IdXzCollege from XzClg where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsXzClgDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzClg.* from XzClg Left Join {1} on {2} where {3} and XzClg.IdXzCollege not in (Select top {5} XzClg.IdXzCollege from XzClg Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzClg where {1} and IdXzCollege not in (Select top {2} IdXzCollege from XzClg where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzClg where {1} and IdXzCollege not in (Select top {3} IdXzCollege from XzClg where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzClgDA: GetXzClgByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from XzClg a where {0} And a.IdXzCollege not in (Select Top {2} IdXzCollege From XzClg Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from XzClg a where {0} And a.IdXzCollege not in (Select Top {2} IdXzCollege From XzClg Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzClgDA: GetXzClgByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from XzClg a where {0} And a.IdXzCollege not in (Select Top {2} IdXzCollege From XzClg Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from XzClg a where {0} And a.IdXzCollege not in (Select Top {2} IdXzCollege From XzClg Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzClgDA: GetXzClgByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzClgDA: GetXzClgByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsXzClgDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("XzClg_SelectByCond",values);
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
public List<clsXzClgEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsXzClgDA:GetObjLst)", objException.Message));
}
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院Id
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //CollegeId
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //CollegeNameA
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //IdUni
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话号码
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //WebSite
objXzClgEN.IsVisible = TransNullToBool(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.IsVisible4Tea = TransNullToBool(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzClg.OrderNum].ToString().Trim()); //排序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzClgDA: GetObjLst)", objException.Message));
}
objXzClgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzClgEN);
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
public List<clsXzClgEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsXzClgDA:GetObjLstByTabName)", objException.Message));
}
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院Id
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //CollegeId
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //CollegeNameA
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //IdUni
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话号码
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //WebSite
objXzClgEN.IsVisible = TransNullToBool(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.IsVisible4Tea = TransNullToBool(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzClg.OrderNum].ToString().Trim()); //排序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzClgDA: GetObjLst)", objException.Message));
}
objXzClgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzClgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsXzClgEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsXzClgDA:GetObjLstBySP)", objException.Message));
}
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("XzClg_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院Id
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //CollegeId
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //CollegeNameA
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //IdUni
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话号码
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //WebSite
objXzClgEN.IsVisible = TransNullToBool(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.IsVisible4Tea = TransNullToBool(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzClg.OrderNum].ToString().Trim()); //排序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsXzClgDA: GetObjLstBySP)", objException.Message));
}
objXzClgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzClgEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objXzClgEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetXzClg(ref clsXzClgEN objXzClgEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where IdXzCollege = " + "'"+ objXzClgEN.IdXzCollege+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objXzClgEN.IdXzCollege = objDT.Rows[0][conXzClg.IdXzCollege].ToString().Trim(); //学院Id(字段类型:char,字段长度:4,是否可空:True)
 objXzClgEN.CollegeId = objDT.Rows[0][conXzClg.CollegeId].ToString().Trim(); //CollegeId(字段类型:varchar,字段长度:4,是否可空:False)
 objXzClgEN.CollegeName = objDT.Rows[0][conXzClg.CollegeName].ToString().Trim(); //学院名(字段类型:varchar,字段长度:100,是否可空:True)
 objXzClgEN.CollegeNameA = objDT.Rows[0][conXzClg.CollegeNameA].ToString().Trim(); //CollegeNameA(字段类型:varchar,字段长度:12,是否可空:False)
 objXzClgEN.ClgEnglishName = objDT.Rows[0][conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName(字段类型:varchar,字段长度:60,是否可空:True)
 objXzClgEN.UserType = objDT.Rows[0][conXzClg.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objXzClgEN.CollegeIdInGP = objDT.Rows[0][conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP(字段类型:varchar,字段长度:6,是否可空:True)
 objXzClgEN.IdSchool = objDT.Rows[0][conXzClg.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzClgEN.IdUni = objDT.Rows[0][conXzClg.IdUni].ToString().Trim(); //IdUni(字段类型:char,字段长度:4,是否可空:True)
 objXzClgEN.PhoneNumber = objDT.Rows[0][conXzClg.PhoneNumber].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objXzClgEN.WebSite = objDT.Rows[0][conXzClg.WebSite].ToString().Trim(); //WebSite(字段类型:varchar,字段长度:60,是否可空:True)
 objXzClgEN.IsVisible = TransNullToBool(objDT.Rows[0][conXzClg.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objXzClgEN.IsVisible4Tea = TransNullToBool(objDT.Rows[0][conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea(字段类型:bit,字段长度:1,是否可空:True)
 objXzClgEN.OrderNum = TransNullToInt(objDT.Rows[0][conXzClg.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objXzClgEN.ModifyDate = objDT.Rows[0][conXzClg.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzClgEN.ModifyUserId = objDT.Rows[0][conXzClg.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objXzClgEN.Memo = objDT.Rows[0][conXzClg.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsXzClgDA: GetXzClg)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdXzCollege">表关键字</param>
 /// <returns>表对象</returns>
public clsXzClgEN GetObjByIdXzCollege(string strIdXzCollege)
{
CheckPrimaryKey(strIdXzCollege);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where IdXzCollege = " + "'"+ strIdXzCollege+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
 objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院Id(字段类型:char,字段长度:4,是否可空:True)
 objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //CollegeId(字段类型:varchar,字段长度:4,是否可空:False)
 objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名(字段类型:varchar,字段长度:100,是否可空:True)
 objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //CollegeNameA(字段类型:varchar,字段长度:12,是否可空:False)
 objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName(字段类型:varchar,字段长度:60,是否可空:True)
 objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP(字段类型:varchar,字段长度:6,是否可空:True)
 objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //IdUni(字段类型:char,字段长度:4,是否可空:True)
 objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //WebSite(字段类型:varchar,字段长度:60,是否可空:True)
 objXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objXzClgEN.IsVisible4Tea = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea(字段类型:bit,字段长度:1,是否可空:True)
 objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzClg.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsXzClgDA: GetObjByIdXzCollege)", objException.Message));
}
return objXzClgEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程XzClg_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objXzClgEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetXzClgOneBySP(clsXzClgEN objXzClgEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objXzClgEN.IdXzCollege
};
 objDT = objSQL.ExecSpReturnDT("XzClg_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objXzClgEN.IdXzCollege = objDT.Rows[0][conXzClg.IdXzCollege].ToString().Trim(); //学院Id(字段类型:char,字段长度:4,是否可空:True)
 objXzClgEN.CollegeId = objDT.Rows[0][conXzClg.CollegeId].ToString().Trim(); //CollegeId(字段类型:varchar,字段长度:4,是否可空:False)
 objXzClgEN.CollegeName = objDT.Rows[0][conXzClg.CollegeName].ToString().Trim(); //学院名(字段类型:varchar,字段长度:100,是否可空:True)
 objXzClgEN.CollegeNameA = objDT.Rows[0][conXzClg.CollegeNameA].ToString().Trim(); //CollegeNameA(字段类型:varchar,字段长度:12,是否可空:False)
 objXzClgEN.ClgEnglishName = objDT.Rows[0][conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName(字段类型:varchar,字段长度:60,是否可空:True)
 objXzClgEN.UserType = objDT.Rows[0][conXzClg.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objXzClgEN.CollegeIdInGP = objDT.Rows[0][conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP(字段类型:varchar,字段长度:6,是否可空:True)
 objXzClgEN.IdSchool = objDT.Rows[0][conXzClg.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzClgEN.IdUni = objDT.Rows[0][conXzClg.IdUni].ToString().Trim(); //IdUni(字段类型:char,字段长度:4,是否可空:True)
 objXzClgEN.PhoneNumber = objDT.Rows[0][conXzClg.PhoneNumber].ToString().Trim(); //电话号码(字段类型:varchar,字段长度:15,是否可空:True)
 objXzClgEN.WebSite = objDT.Rows[0][conXzClg.WebSite].ToString().Trim(); //WebSite(字段类型:varchar,字段长度:60,是否可空:True)
 objXzClgEN.IsVisible = TransNullToBool(objDT.Rows[0][conXzClg.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objXzClgEN.IsVisible4Tea = TransNullToBool(objDT.Rows[0][conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea(字段类型:bit,字段长度:1,是否可空:True)
 objXzClgEN.OrderNum = TransNullToInt(objDT.Rows[0][conXzClg.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objXzClgEN.ModifyDate = objDT.Rows[0][conXzClg.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzClgEN.ModifyUserId = objDT.Rows[0][conXzClg.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objXzClgEN.Memo = objDT.Rows[0][conXzClg.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsXzClgEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsXzClgDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsXzClgEN objXzClgEN = new clsXzClgEN()
{
IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(), //学院Id
CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(), //CollegeId
CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(), //学院名
CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(), //CollegeNameA
ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(), //ClgEnglishName
UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(), //用户类型
CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(), //CollegeIdInGP
IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(), //学校流水号
IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(), //IdUni
PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(), //电话号码
WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(), //WebSite
IsVisible = TransNullToBool(objRow[conXzClg.IsVisible].ToString().Trim()), //是否显示
IsVisible4Tea = TransNullToBool(objRow[conXzClg.IsVisible4Tea].ToString().Trim()), //IsVisible4Tea
OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzClg.OrderNum].ToString().Trim()), //排序号
ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(), //修改人
Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim() //备注
};
objXzClgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzClgEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsXzClgDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsXzClgEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsXzClgDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("XzClg_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsXzClgEN objXzClgEN = new clsXzClgEN()
{
IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(), //学院Id
CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(), //CollegeId
CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(), //学院名
CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(), //CollegeNameA
ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(), //ClgEnglishName
UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(), //用户类型
CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(), //CollegeIdInGP
IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(), //学校流水号
IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(), //IdUni
PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(), //电话号码
WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(), //WebSite
IsVisible = TransNullToBool(objRow[conXzClg.IsVisible].ToString().Trim()), //是否显示
IsVisible4Tea = TransNullToBool(objRow[conXzClg.IsVisible4Tea].ToString().Trim()), //IsVisible4Tea
OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzClg.OrderNum].ToString().Trim()), //排序号
ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(), //修改人
Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim() //备注
};
objXzClgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzClgEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsXzClgEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院Id
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //CollegeId
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //CollegeNameA
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //IdUni
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话号码
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //WebSite
objXzClgEN.IsVisible = TransNullToBool(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.IsVisible4Tea = TransNullToBool(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzClg.OrderNum].ToString().Trim()); //排序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsXzClgDA: GetObjByDataRowXzClg)", objException.Message));
}
objXzClgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzClgEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsXzClgEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院Id
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //CollegeId
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //CollegeNameA
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //IdUni
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话号码
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //WebSite
objXzClgEN.IsVisible = TransNullToBool(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.IsVisible4Tea = TransNullToBool(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzClg.OrderNum].ToString().Trim()); //排序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsXzClgDA: GetObjByDataRow)", objException.Message));
}
objXzClgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzClgEN;
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
objSQL = clsXzClgDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzClgEN._CurrTabName, conXzClg.IdXzCollege, 4, "");
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
objSQL = clsXzClgDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzClgEN._CurrTabName, conXzClg.IdXzCollege, 4, strPrefix);
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
 objSQL = clsXzClgDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdXzCollege from XzClg where " + strCondition;
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
 objSQL = clsXzClgDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdXzCollege from XzClg where " + strCondition;
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
 /// <param name = "strIdXzCollege">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdXzCollege)
{
CheckPrimaryKey(strIdXzCollege);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzClg", "IdXzCollege = " + "'"+ strIdXzCollege+"'"))
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
 /// <param name = "strIdXzCollege">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strIdXzCollege)
{
CheckPrimaryKey(strIdXzCollege);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strIdXzCollege,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("XzClg_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsXzClgDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzClg", strCondition))
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
objSQL = clsXzClgDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("XzClg");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsXzClgEN objXzClgEN)
 {
 if (objXzClgEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzClgEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzClg");
objRow = objDS.Tables["XzClg"].NewRow();
objRow[conXzClg.IdXzCollege] = objXzClgEN.IdXzCollege; //学院Id
objRow[conXzClg.CollegeId] = objXzClgEN.CollegeId; //CollegeId
objRow[conXzClg.CollegeName] = objXzClgEN.CollegeName; //学院名
objRow[conXzClg.CollegeNameA] = objXzClgEN.CollegeNameA; //CollegeNameA
 if (objXzClgEN.ClgEnglishName !=  "")
 {
objRow[conXzClg.ClgEnglishName] = objXzClgEN.ClgEnglishName; //ClgEnglishName
 }
 if (objXzClgEN.UserType !=  "")
 {
objRow[conXzClg.UserType] = objXzClgEN.UserType; //用户类型
 }
 if (objXzClgEN.CollegeIdInGP !=  "")
 {
objRow[conXzClg.CollegeIdInGP] = objXzClgEN.CollegeIdInGP; //CollegeIdInGP
 }
 if (objXzClgEN.IdSchool !=  "")
 {
objRow[conXzClg.IdSchool] = objXzClgEN.IdSchool; //学校流水号
 }
 if (objXzClgEN.IdUni !=  "")
 {
objRow[conXzClg.IdUni] = objXzClgEN.IdUni; //IdUni
 }
 if (objXzClgEN.PhoneNumber !=  "")
 {
objRow[conXzClg.PhoneNumber] = objXzClgEN.PhoneNumber; //电话号码
 }
 if (objXzClgEN.WebSite !=  "")
 {
objRow[conXzClg.WebSite] = objXzClgEN.WebSite; //WebSite
 }
objRow[conXzClg.IsVisible] = objXzClgEN.IsVisible; //是否显示
objRow[conXzClg.IsVisible4Tea] = objXzClgEN.IsVisible4Tea; //IsVisible4Tea
objRow[conXzClg.OrderNum] = objXzClgEN.OrderNum; //排序号
 if (objXzClgEN.ModifyDate !=  "")
 {
objRow[conXzClg.ModifyDate] = objXzClgEN.ModifyDate; //修改日期
 }
 if (objXzClgEN.ModifyUserId !=  "")
 {
objRow[conXzClg.ModifyUserId] = objXzClgEN.ModifyUserId; //修改人
 }
 if (objXzClgEN.Memo !=  "")
 {
objRow[conXzClg.Memo] = objXzClgEN.Memo; //备注
 }
objDS.Tables[clsXzClgEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsXzClgEN._CurrTabName);
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
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzClgEN objXzClgEN)
{
 if (objXzClgEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzClgEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzClgEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdXzCollege);
 var strIdXzCollege = objXzClgEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objXzClgEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeId);
 var strCollegeId = objXzClgEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeId + "'");
 }
 
 if (objXzClgEN.CollegeName !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeName);
 var strCollegeName = objXzClgEN.CollegeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeName + "'");
 }
 
 if (objXzClgEN.CollegeNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeNameA);
 var strCollegeNameA = objXzClgEN.CollegeNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeNameA + "'");
 }
 
 if (objXzClgEN.ClgEnglishName !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ClgEnglishName);
 var strClgEnglishName = objXzClgEN.ClgEnglishName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgEnglishName + "'");
 }
 
 if (objXzClgEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.UserType);
 var strUserType = objXzClgEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objXzClgEN.CollegeIdInGP !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeIdInGP);
 var strCollegeIdInGP = objXzClgEN.CollegeIdInGP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeIdInGP + "'");
 }
 
 if (objXzClgEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdSchool);
 var strIdSchool = objXzClgEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objXzClgEN.IdUni !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdUni);
 var strIdUni = objXzClgEN.IdUni.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUni + "'");
 }
 
 if (objXzClgEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.PhoneNumber);
 var strPhoneNumber = objXzClgEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objXzClgEN.WebSite !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.WebSite);
 var strWebSite = objXzClgEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSite + "'");
 }
 
 arrFieldListForInsert.Add(conXzClg.IsVisible);
 arrValueListForInsert.Add("'" + (objXzClgEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conXzClg.IsVisible4Tea);
 arrValueListForInsert.Add("'" + (objXzClgEN.IsVisible4Tea  ==  false ? "0" : "1") + "'");
 
 if (objXzClgEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.OrderNum);
 arrValueListForInsert.Add(objXzClgEN.OrderNum.ToString());
 }
 
 if (objXzClgEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ModifyDate);
 var strModifyDate = objXzClgEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objXzClgEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ModifyUserId);
 var strModifyUserId = objXzClgEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzClgEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.Memo);
 var strMemo = objXzClgEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzClg");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzClgEN objXzClgEN)
{
 if (objXzClgEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzClgEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzClgEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdXzCollege);
 var strIdXzCollege = objXzClgEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objXzClgEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeId);
 var strCollegeId = objXzClgEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeId + "'");
 }
 
 if (objXzClgEN.CollegeName !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeName);
 var strCollegeName = objXzClgEN.CollegeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeName + "'");
 }
 
 if (objXzClgEN.CollegeNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeNameA);
 var strCollegeNameA = objXzClgEN.CollegeNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeNameA + "'");
 }
 
 if (objXzClgEN.ClgEnglishName !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ClgEnglishName);
 var strClgEnglishName = objXzClgEN.ClgEnglishName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgEnglishName + "'");
 }
 
 if (objXzClgEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.UserType);
 var strUserType = objXzClgEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objXzClgEN.CollegeIdInGP !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeIdInGP);
 var strCollegeIdInGP = objXzClgEN.CollegeIdInGP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeIdInGP + "'");
 }
 
 if (objXzClgEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdSchool);
 var strIdSchool = objXzClgEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objXzClgEN.IdUni !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdUni);
 var strIdUni = objXzClgEN.IdUni.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUni + "'");
 }
 
 if (objXzClgEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.PhoneNumber);
 var strPhoneNumber = objXzClgEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objXzClgEN.WebSite !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.WebSite);
 var strWebSite = objXzClgEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSite + "'");
 }
 
 arrFieldListForInsert.Add(conXzClg.IsVisible);
 arrValueListForInsert.Add("'" + (objXzClgEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conXzClg.IsVisible4Tea);
 arrValueListForInsert.Add("'" + (objXzClgEN.IsVisible4Tea  ==  false ? "0" : "1") + "'");
 
 if (objXzClgEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.OrderNum);
 arrValueListForInsert.Add(objXzClgEN.OrderNum.ToString());
 }
 
 if (objXzClgEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ModifyDate);
 var strModifyDate = objXzClgEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objXzClgEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ModifyUserId);
 var strModifyUserId = objXzClgEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzClgEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.Memo);
 var strMemo = objXzClgEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzClg");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objXzClgEN.IdXzCollege;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzClgEN objXzClgEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzClgEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzClgEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzClgEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdXzCollege);
 var strIdXzCollege = objXzClgEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objXzClgEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeId);
 var strCollegeId = objXzClgEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeId + "'");
 }
 
 if (objXzClgEN.CollegeName !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeName);
 var strCollegeName = objXzClgEN.CollegeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeName + "'");
 }
 
 if (objXzClgEN.CollegeNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeNameA);
 var strCollegeNameA = objXzClgEN.CollegeNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeNameA + "'");
 }
 
 if (objXzClgEN.ClgEnglishName !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ClgEnglishName);
 var strClgEnglishName = objXzClgEN.ClgEnglishName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgEnglishName + "'");
 }
 
 if (objXzClgEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.UserType);
 var strUserType = objXzClgEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objXzClgEN.CollegeIdInGP !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeIdInGP);
 var strCollegeIdInGP = objXzClgEN.CollegeIdInGP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeIdInGP + "'");
 }
 
 if (objXzClgEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdSchool);
 var strIdSchool = objXzClgEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objXzClgEN.IdUni !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdUni);
 var strIdUni = objXzClgEN.IdUni.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUni + "'");
 }
 
 if (objXzClgEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.PhoneNumber);
 var strPhoneNumber = objXzClgEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objXzClgEN.WebSite !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.WebSite);
 var strWebSite = objXzClgEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSite + "'");
 }
 
 arrFieldListForInsert.Add(conXzClg.IsVisible);
 arrValueListForInsert.Add("'" + (objXzClgEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conXzClg.IsVisible4Tea);
 arrValueListForInsert.Add("'" + (objXzClgEN.IsVisible4Tea  ==  false ? "0" : "1") + "'");
 
 if (objXzClgEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.OrderNum);
 arrValueListForInsert.Add(objXzClgEN.OrderNum.ToString());
 }
 
 if (objXzClgEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ModifyDate);
 var strModifyDate = objXzClgEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objXzClgEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ModifyUserId);
 var strModifyUserId = objXzClgEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzClgEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.Memo);
 var strMemo = objXzClgEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzClg");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objXzClgEN.IdXzCollege;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzClgEN objXzClgEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzClgEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzClgEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzClgEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdXzCollege);
 var strIdXzCollege = objXzClgEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objXzClgEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeId);
 var strCollegeId = objXzClgEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeId + "'");
 }
 
 if (objXzClgEN.CollegeName !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeName);
 var strCollegeName = objXzClgEN.CollegeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeName + "'");
 }
 
 if (objXzClgEN.CollegeNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeNameA);
 var strCollegeNameA = objXzClgEN.CollegeNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeNameA + "'");
 }
 
 if (objXzClgEN.ClgEnglishName !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ClgEnglishName);
 var strClgEnglishName = objXzClgEN.ClgEnglishName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgEnglishName + "'");
 }
 
 if (objXzClgEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.UserType);
 var strUserType = objXzClgEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objXzClgEN.CollegeIdInGP !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.CollegeIdInGP);
 var strCollegeIdInGP = objXzClgEN.CollegeIdInGP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeIdInGP + "'");
 }
 
 if (objXzClgEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdSchool);
 var strIdSchool = objXzClgEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objXzClgEN.IdUni !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.IdUni);
 var strIdUni = objXzClgEN.IdUni.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUni + "'");
 }
 
 if (objXzClgEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.PhoneNumber);
 var strPhoneNumber = objXzClgEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objXzClgEN.WebSite !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.WebSite);
 var strWebSite = objXzClgEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSite + "'");
 }
 
 arrFieldListForInsert.Add(conXzClg.IsVisible);
 arrValueListForInsert.Add("'" + (objXzClgEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conXzClg.IsVisible4Tea);
 arrValueListForInsert.Add("'" + (objXzClgEN.IsVisible4Tea  ==  false ? "0" : "1") + "'");
 
 if (objXzClgEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.OrderNum);
 arrValueListForInsert.Add(objXzClgEN.OrderNum.ToString());
 }
 
 if (objXzClgEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ModifyDate);
 var strModifyDate = objXzClgEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objXzClgEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.ModifyUserId);
 var strModifyUserId = objXzClgEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzClgEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzClg.Memo);
 var strMemo = objXzClgEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzClg");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objXzClgEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewXzClgBySP(clsXzClgEN objXzClgEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objXzClgEN.IdXzCollege,
 objXzClgEN.CollegeId,
 objXzClgEN.CollegeName,
 objXzClgEN.CollegeNameA,
 objXzClgEN.ClgEnglishName,
 objXzClgEN.UserType,
 objXzClgEN.CollegeIdInGP,
 objXzClgEN.IdSchool,
 objXzClgEN.IdUni,
 objXzClgEN.PhoneNumber,
 objXzClgEN.WebSite,
 objXzClgEN.IsVisible,
 objXzClgEN.IsVisible4Tea,
 objXzClgEN.OrderNum,
 objXzClgEN.ModifyDate,
 objXzClgEN.ModifyUserId,
objXzClgEN.Memo
};
 objSQL.ExecSP("XzClg_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewXzClgs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where IdXzCollege = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzClg");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdXzCollege = oRow[conXzClg.IdXzCollege].ToString().Trim();
if (IsExist(strIdXzCollege))
{
 string strResult = "关键字变量值为:" + string.Format("IdXzCollege = {0}", strIdXzCollege) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsXzClgEN._CurrTabName ].NewRow();
objRow[conXzClg.IdXzCollege] = oRow[conXzClg.IdXzCollege].ToString().Trim(); //学院Id
objRow[conXzClg.CollegeId] = oRow[conXzClg.CollegeId].ToString().Trim(); //CollegeId
objRow[conXzClg.CollegeName] = oRow[conXzClg.CollegeName].ToString().Trim(); //学院名
objRow[conXzClg.CollegeNameA] = oRow[conXzClg.CollegeNameA].ToString().Trim(); //CollegeNameA
objRow[conXzClg.ClgEnglishName] = oRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objRow[conXzClg.UserType] = oRow[conXzClg.UserType].ToString().Trim(); //用户类型
objRow[conXzClg.CollegeIdInGP] = oRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objRow[conXzClg.IdSchool] = oRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objRow[conXzClg.IdUni] = oRow[conXzClg.IdUni].ToString().Trim(); //IdUni
objRow[conXzClg.PhoneNumber] = oRow[conXzClg.PhoneNumber].ToString().Trim(); //电话号码
objRow[conXzClg.WebSite] = oRow[conXzClg.WebSite].ToString().Trim(); //WebSite
objRow[conXzClg.IsVisible] = oRow[conXzClg.IsVisible].ToString().Trim(); //是否显示
objRow[conXzClg.IsVisible4Tea] = oRow[conXzClg.IsVisible4Tea].ToString().Trim(); //IsVisible4Tea
objRow[conXzClg.OrderNum] = oRow[conXzClg.OrderNum].ToString().Trim(); //排序号
objRow[conXzClg.ModifyDate] = oRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objRow[conXzClg.ModifyUserId] = oRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objRow[conXzClg.Memo] = oRow[conXzClg.Memo].ToString().Trim(); //备注
 objDS.Tables[clsXzClgEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsXzClgEN._CurrTabName);
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
 /// <param name = "objXzClgEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsXzClgEN objXzClgEN)
{
 if (objXzClgEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzClgEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
strSQL = "Select * from XzClg where IdXzCollege = " + "'"+ objXzClgEN.IdXzCollege+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsXzClgEN._CurrTabName);
if (objDS.Tables[clsXzClgEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdXzCollege = " + "'"+ objXzClgEN.IdXzCollege+"'");
return false;
}
objRow = objDS.Tables[clsXzClgEN._CurrTabName].Rows[0];
 if (objXzClgEN.IsUpdated(conXzClg.IdXzCollege))
 {
objRow[conXzClg.IdXzCollege] = objXzClgEN.IdXzCollege; //学院Id
 }
 if (objXzClgEN.IsUpdated(conXzClg.CollegeId))
 {
objRow[conXzClg.CollegeId] = objXzClgEN.CollegeId; //CollegeId
 }
 if (objXzClgEN.IsUpdated(conXzClg.CollegeName))
 {
objRow[conXzClg.CollegeName] = objXzClgEN.CollegeName; //学院名
 }
 if (objXzClgEN.IsUpdated(conXzClg.CollegeNameA))
 {
objRow[conXzClg.CollegeNameA] = objXzClgEN.CollegeNameA; //CollegeNameA
 }
 if (objXzClgEN.IsUpdated(conXzClg.ClgEnglishName))
 {
objRow[conXzClg.ClgEnglishName] = objXzClgEN.ClgEnglishName; //ClgEnglishName
 }
 if (objXzClgEN.IsUpdated(conXzClg.UserType))
 {
objRow[conXzClg.UserType] = objXzClgEN.UserType; //用户类型
 }
 if (objXzClgEN.IsUpdated(conXzClg.CollegeIdInGP))
 {
objRow[conXzClg.CollegeIdInGP] = objXzClgEN.CollegeIdInGP; //CollegeIdInGP
 }
 if (objXzClgEN.IsUpdated(conXzClg.IdSchool))
 {
objRow[conXzClg.IdSchool] = objXzClgEN.IdSchool; //学校流水号
 }
 if (objXzClgEN.IsUpdated(conXzClg.IdUni))
 {
objRow[conXzClg.IdUni] = objXzClgEN.IdUni; //IdUni
 }
 if (objXzClgEN.IsUpdated(conXzClg.PhoneNumber))
 {
objRow[conXzClg.PhoneNumber] = objXzClgEN.PhoneNumber; //电话号码
 }
 if (objXzClgEN.IsUpdated(conXzClg.WebSite))
 {
objRow[conXzClg.WebSite] = objXzClgEN.WebSite; //WebSite
 }
 if (objXzClgEN.IsUpdated(conXzClg.IsVisible))
 {
objRow[conXzClg.IsVisible] = objXzClgEN.IsVisible; //是否显示
 }
 if (objXzClgEN.IsUpdated(conXzClg.IsVisible4Tea))
 {
objRow[conXzClg.IsVisible4Tea] = objXzClgEN.IsVisible4Tea; //IsVisible4Tea
 }
 if (objXzClgEN.IsUpdated(conXzClg.OrderNum))
 {
objRow[conXzClg.OrderNum] = objXzClgEN.OrderNum; //排序号
 }
 if (objXzClgEN.IsUpdated(conXzClg.ModifyDate))
 {
objRow[conXzClg.ModifyDate] = objXzClgEN.ModifyDate; //修改日期
 }
 if (objXzClgEN.IsUpdated(conXzClg.ModifyUserId))
 {
objRow[conXzClg.ModifyUserId] = objXzClgEN.ModifyUserId; //修改人
 }
 if (objXzClgEN.IsUpdated(conXzClg.Memo))
 {
objRow[conXzClg.Memo] = objXzClgEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsXzClgEN._CurrTabName);
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
public bool UpdateBySP(clsXzClgEN objXzClgEN)
{
 if (objXzClgEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzClgEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objXzClgEN.IdXzCollege,
 objXzClgEN.CollegeId,
 objXzClgEN.CollegeName,
 objXzClgEN.CollegeNameA,
 objXzClgEN.ClgEnglishName,
 objXzClgEN.UserType,
 objXzClgEN.CollegeIdInGP,
 objXzClgEN.IdSchool,
 objXzClgEN.IdUni,
 objXzClgEN.PhoneNumber,
 objXzClgEN.WebSite,
 objXzClgEN.IsVisible,
 objXzClgEN.IsVisible4Tea,
 objXzClgEN.OrderNum,
 objXzClgEN.ModifyDate,
 objXzClgEN.ModifyUserId,
 objXzClgEN.Memo
};
 objSQL.ExecSP("XzClg_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzClgEN objXzClgEN)
{
 if (objXzClgEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzClgEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update XzClg Set ");
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeId))
 {
 if (objXzClgEN.CollegeId !=  null)
 {
 var strCollegeId = objXzClgEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCollegeId, conXzClg.CollegeId); //CollegeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.CollegeId); //CollegeId
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeName))
 {
 if (objXzClgEN.CollegeName !=  null)
 {
 var strCollegeName = objXzClgEN.CollegeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCollegeName, conXzClg.CollegeName); //学院名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.CollegeName); //学院名
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeNameA))
 {
 if (objXzClgEN.CollegeNameA !=  null)
 {
 var strCollegeNameA = objXzClgEN.CollegeNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCollegeNameA, conXzClg.CollegeNameA); //CollegeNameA
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.CollegeNameA); //CollegeNameA
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ClgEnglishName))
 {
 if (objXzClgEN.ClgEnglishName !=  null)
 {
 var strClgEnglishName = objXzClgEN.ClgEnglishName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgEnglishName, conXzClg.ClgEnglishName); //ClgEnglishName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.ClgEnglishName); //ClgEnglishName
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.UserType))
 {
 if (objXzClgEN.UserType !=  null)
 {
 var strUserType = objXzClgEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserType, conXzClg.UserType); //用户类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.UserType); //用户类型
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeIdInGP))
 {
 if (objXzClgEN.CollegeIdInGP !=  null)
 {
 var strCollegeIdInGP = objXzClgEN.CollegeIdInGP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCollegeIdInGP, conXzClg.CollegeIdInGP); //CollegeIdInGP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.CollegeIdInGP); //CollegeIdInGP
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IdSchool))
 {
 if (objXzClgEN.IdSchool !=  null)
 {
 var strIdSchool = objXzClgEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conXzClg.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.IdSchool); //学校流水号
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IdUni))
 {
 if (objXzClgEN.IdUni !=  null)
 {
 var strIdUni = objXzClgEN.IdUni.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUni, conXzClg.IdUni); //IdUni
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.IdUni); //IdUni
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.PhoneNumber))
 {
 if (objXzClgEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objXzClgEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhoneNumber, conXzClg.PhoneNumber); //电话号码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.PhoneNumber); //电话号码
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.WebSite))
 {
 if (objXzClgEN.WebSite !=  null)
 {
 var strWebSite = objXzClgEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebSite, conXzClg.WebSite); //WebSite
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.WebSite); //WebSite
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzClgEN.IsVisible == true?"1":"0", conXzClg.IsVisible); //是否显示
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IsVisible4Tea))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzClgEN.IsVisible4Tea == true?"1":"0", conXzClg.IsVisible4Tea); //IsVisible4Tea
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.OrderNum))
 {
 if (objXzClgEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzClgEN.OrderNum, conXzClg.OrderNum); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.OrderNum); //排序号
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ModifyDate))
 {
 if (objXzClgEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzClgEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conXzClg.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.ModifyDate); //修改日期
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ModifyUserId))
 {
 if (objXzClgEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzClgEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conXzClg.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.ModifyUserId); //修改人
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.Memo))
 {
 if (objXzClgEN.Memo !=  null)
 {
 var strMemo = objXzClgEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzClg.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdXzCollege = '{0}'", objXzClgEN.IdXzCollege); 
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
 /// <param name = "objXzClgEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsXzClgEN objXzClgEN, string strCondition)
{
 if (objXzClgEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzClgEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzClg Set ");
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeId))
 {
 if (objXzClgEN.CollegeId !=  null)
 {
 var strCollegeId = objXzClgEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeId = '{0}',", strCollegeId); //CollegeId
 }
 else
 {
 sbSQL.Append(" CollegeId = null,"); //CollegeId
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeName))
 {
 if (objXzClgEN.CollegeName !=  null)
 {
 var strCollegeName = objXzClgEN.CollegeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeName = '{0}',", strCollegeName); //学院名
 }
 else
 {
 sbSQL.Append(" CollegeName = null,"); //学院名
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeNameA))
 {
 if (objXzClgEN.CollegeNameA !=  null)
 {
 var strCollegeNameA = objXzClgEN.CollegeNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeNameA = '{0}',", strCollegeNameA); //CollegeNameA
 }
 else
 {
 sbSQL.Append(" CollegeNameA = null,"); //CollegeNameA
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ClgEnglishName))
 {
 if (objXzClgEN.ClgEnglishName !=  null)
 {
 var strClgEnglishName = objXzClgEN.ClgEnglishName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgEnglishName = '{0}',", strClgEnglishName); //ClgEnglishName
 }
 else
 {
 sbSQL.Append(" ClgEnglishName = null,"); //ClgEnglishName
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.UserType))
 {
 if (objXzClgEN.UserType !=  null)
 {
 var strUserType = objXzClgEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserType = '{0}',", strUserType); //用户类型
 }
 else
 {
 sbSQL.Append(" UserType = null,"); //用户类型
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeIdInGP))
 {
 if (objXzClgEN.CollegeIdInGP !=  null)
 {
 var strCollegeIdInGP = objXzClgEN.CollegeIdInGP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeIdInGP = '{0}',", strCollegeIdInGP); //CollegeIdInGP
 }
 else
 {
 sbSQL.Append(" CollegeIdInGP = null,"); //CollegeIdInGP
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IdSchool))
 {
 if (objXzClgEN.IdSchool !=  null)
 {
 var strIdSchool = objXzClgEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IdUni))
 {
 if (objXzClgEN.IdUni !=  null)
 {
 var strIdUni = objXzClgEN.IdUni.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUni = '{0}',", strIdUni); //IdUni
 }
 else
 {
 sbSQL.Append(" IdUni = null,"); //IdUni
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.PhoneNumber))
 {
 if (objXzClgEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objXzClgEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", strPhoneNumber); //电话号码
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //电话号码
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.WebSite))
 {
 if (objXzClgEN.WebSite !=  null)
 {
 var strWebSite = objXzClgEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebSite = '{0}',", strWebSite); //WebSite
 }
 else
 {
 sbSQL.Append(" WebSite = null,"); //WebSite
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objXzClgEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IsVisible4Tea))
 {
 sbSQL.AppendFormat(" IsVisible4Tea = '{0}',", objXzClgEN.IsVisible4Tea == true?"1":"0"); //IsVisible4Tea
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.OrderNum))
 {
 if (objXzClgEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzClgEN.OrderNum, conXzClg.OrderNum); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.OrderNum); //排序号
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ModifyDate))
 {
 if (objXzClgEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzClgEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ModifyUserId))
 {
 if (objXzClgEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzClgEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.Memo))
 {
 if (objXzClgEN.Memo !=  null)
 {
 var strMemo = objXzClgEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzClgEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsXzClgEN objXzClgEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzClgEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzClgEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzClg Set ");
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeId))
 {
 if (objXzClgEN.CollegeId !=  null)
 {
 var strCollegeId = objXzClgEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeId = '{0}',", strCollegeId); //CollegeId
 }
 else
 {
 sbSQL.Append(" CollegeId = null,"); //CollegeId
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeName))
 {
 if (objXzClgEN.CollegeName !=  null)
 {
 var strCollegeName = objXzClgEN.CollegeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeName = '{0}',", strCollegeName); //学院名
 }
 else
 {
 sbSQL.Append(" CollegeName = null,"); //学院名
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeNameA))
 {
 if (objXzClgEN.CollegeNameA !=  null)
 {
 var strCollegeNameA = objXzClgEN.CollegeNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeNameA = '{0}',", strCollegeNameA); //CollegeNameA
 }
 else
 {
 sbSQL.Append(" CollegeNameA = null,"); //CollegeNameA
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ClgEnglishName))
 {
 if (objXzClgEN.ClgEnglishName !=  null)
 {
 var strClgEnglishName = objXzClgEN.ClgEnglishName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgEnglishName = '{0}',", strClgEnglishName); //ClgEnglishName
 }
 else
 {
 sbSQL.Append(" ClgEnglishName = null,"); //ClgEnglishName
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.UserType))
 {
 if (objXzClgEN.UserType !=  null)
 {
 var strUserType = objXzClgEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserType = '{0}',", strUserType); //用户类型
 }
 else
 {
 sbSQL.Append(" UserType = null,"); //用户类型
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeIdInGP))
 {
 if (objXzClgEN.CollegeIdInGP !=  null)
 {
 var strCollegeIdInGP = objXzClgEN.CollegeIdInGP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeIdInGP = '{0}',", strCollegeIdInGP); //CollegeIdInGP
 }
 else
 {
 sbSQL.Append(" CollegeIdInGP = null,"); //CollegeIdInGP
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IdSchool))
 {
 if (objXzClgEN.IdSchool !=  null)
 {
 var strIdSchool = objXzClgEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IdUni))
 {
 if (objXzClgEN.IdUni !=  null)
 {
 var strIdUni = objXzClgEN.IdUni.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUni = '{0}',", strIdUni); //IdUni
 }
 else
 {
 sbSQL.Append(" IdUni = null,"); //IdUni
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.PhoneNumber))
 {
 if (objXzClgEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objXzClgEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", strPhoneNumber); //电话号码
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //电话号码
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.WebSite))
 {
 if (objXzClgEN.WebSite !=  null)
 {
 var strWebSite = objXzClgEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebSite = '{0}',", strWebSite); //WebSite
 }
 else
 {
 sbSQL.Append(" WebSite = null,"); //WebSite
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objXzClgEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IsVisible4Tea))
 {
 sbSQL.AppendFormat(" IsVisible4Tea = '{0}',", objXzClgEN.IsVisible4Tea == true?"1":"0"); //IsVisible4Tea
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.OrderNum))
 {
 if (objXzClgEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzClgEN.OrderNum, conXzClg.OrderNum); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.OrderNum); //排序号
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ModifyDate))
 {
 if (objXzClgEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzClgEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ModifyUserId))
 {
 if (objXzClgEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzClgEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.Memo))
 {
 if (objXzClgEN.Memo !=  null)
 {
 var strMemo = objXzClgEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzClgEN objXzClgEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzClgEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzClgEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzClg Set ");
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeId))
 {
 if (objXzClgEN.CollegeId !=  null)
 {
 var strCollegeId = objXzClgEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCollegeId, conXzClg.CollegeId); //CollegeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.CollegeId); //CollegeId
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeName))
 {
 if (objXzClgEN.CollegeName !=  null)
 {
 var strCollegeName = objXzClgEN.CollegeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCollegeName, conXzClg.CollegeName); //学院名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.CollegeName); //学院名
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeNameA))
 {
 if (objXzClgEN.CollegeNameA !=  null)
 {
 var strCollegeNameA = objXzClgEN.CollegeNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCollegeNameA, conXzClg.CollegeNameA); //CollegeNameA
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.CollegeNameA); //CollegeNameA
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ClgEnglishName))
 {
 if (objXzClgEN.ClgEnglishName !=  null)
 {
 var strClgEnglishName = objXzClgEN.ClgEnglishName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgEnglishName, conXzClg.ClgEnglishName); //ClgEnglishName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.ClgEnglishName); //ClgEnglishName
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.UserType))
 {
 if (objXzClgEN.UserType !=  null)
 {
 var strUserType = objXzClgEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserType, conXzClg.UserType); //用户类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.UserType); //用户类型
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.CollegeIdInGP))
 {
 if (objXzClgEN.CollegeIdInGP !=  null)
 {
 var strCollegeIdInGP = objXzClgEN.CollegeIdInGP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCollegeIdInGP, conXzClg.CollegeIdInGP); //CollegeIdInGP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.CollegeIdInGP); //CollegeIdInGP
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IdSchool))
 {
 if (objXzClgEN.IdSchool !=  null)
 {
 var strIdSchool = objXzClgEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conXzClg.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.IdSchool); //学校流水号
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IdUni))
 {
 if (objXzClgEN.IdUni !=  null)
 {
 var strIdUni = objXzClgEN.IdUni.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUni, conXzClg.IdUni); //IdUni
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.IdUni); //IdUni
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.PhoneNumber))
 {
 if (objXzClgEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objXzClgEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhoneNumber, conXzClg.PhoneNumber); //电话号码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.PhoneNumber); //电话号码
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.WebSite))
 {
 if (objXzClgEN.WebSite !=  null)
 {
 var strWebSite = objXzClgEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebSite, conXzClg.WebSite); //WebSite
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.WebSite); //WebSite
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzClgEN.IsVisible == true?"1":"0", conXzClg.IsVisible); //是否显示
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.IsVisible4Tea))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzClgEN.IsVisible4Tea == true?"1":"0", conXzClg.IsVisible4Tea); //IsVisible4Tea
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.OrderNum))
 {
 if (objXzClgEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzClgEN.OrderNum, conXzClg.OrderNum); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.OrderNum); //排序号
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ModifyDate))
 {
 if (objXzClgEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzClgEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conXzClg.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.ModifyDate); //修改日期
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.ModifyUserId))
 {
 if (objXzClgEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzClgEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conXzClg.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.ModifyUserId); //修改人
 }
 }
 
 if (objXzClgEN.IsUpdated(conXzClg.Memo))
 {
 if (objXzClgEN.Memo !=  null)
 {
 var strMemo = objXzClgEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzClg.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzClg.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdXzCollege = '{0}'", objXzClgEN.IdXzCollege); 
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
 /// <param name = "strIdXzCollege">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdXzCollege) 
{
CheckPrimaryKey(strIdXzCollege);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdXzCollege,
};
 objSQL.ExecSP("XzClg_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdXzCollege">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdXzCollege, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdXzCollege);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
//删除XzClg本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzClg where IdXzCollege = " + "'"+ strIdXzCollege+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelXzClg(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
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
//删除XzClg本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzClg where IdXzCollege in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdXzCollege">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdXzCollege) 
{
CheckPrimaryKey(strIdXzCollege);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
//删除XzClg本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzClg where IdXzCollege = " + "'"+ strIdXzCollege+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelXzClg(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsXzClgDA: DelXzClg)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzClg where " + strCondition ;
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
public bool DelXzClgWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsXzClgDA: DelXzClgWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzClgDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzClg where " + strCondition ;
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
 /// <param name = "objXzClgENS">源对象</param>
 /// <param name = "objXzClgENT">目标对象</param>
public void CopyTo(clsXzClgEN objXzClgENS, clsXzClgEN objXzClgENT)
{
objXzClgENT.IdXzCollege = objXzClgENS.IdXzCollege; //学院Id
objXzClgENT.CollegeId = objXzClgENS.CollegeId; //CollegeId
objXzClgENT.CollegeName = objXzClgENS.CollegeName; //学院名
objXzClgENT.CollegeNameA = objXzClgENS.CollegeNameA; //CollegeNameA
objXzClgENT.ClgEnglishName = objXzClgENS.ClgEnglishName; //ClgEnglishName
objXzClgENT.UserType = objXzClgENS.UserType; //用户类型
objXzClgENT.CollegeIdInGP = objXzClgENS.CollegeIdInGP; //CollegeIdInGP
objXzClgENT.IdSchool = objXzClgENS.IdSchool; //学校流水号
objXzClgENT.IdUni = objXzClgENS.IdUni; //IdUni
objXzClgENT.PhoneNumber = objXzClgENS.PhoneNumber; //电话号码
objXzClgENT.WebSite = objXzClgENS.WebSite; //WebSite
objXzClgENT.IsVisible = objXzClgENS.IsVisible; //是否显示
objXzClgENT.IsVisible4Tea = objXzClgENS.IsVisible4Tea; //IsVisible4Tea
objXzClgENT.OrderNum = objXzClgENS.OrderNum; //排序号
objXzClgENT.ModifyDate = objXzClgENS.ModifyDate; //修改日期
objXzClgENT.ModifyUserId = objXzClgENS.ModifyUserId; //修改人
objXzClgENT.Memo = objXzClgENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsXzClgEN objXzClgEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objXzClgEN.CollegeId, conXzClg.CollegeId);
clsCheckSql.CheckFieldNotNull(objXzClgEN.CollegeName, conXzClg.CollegeName);
clsCheckSql.CheckFieldNotNull(objXzClgEN.CollegeNameA, conXzClg.CollegeNameA);
//检查字段长度
clsCheckSql.CheckFieldLen(objXzClgEN.IdXzCollege, 4, conXzClg.IdXzCollege);
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeId, 4, conXzClg.CollegeId);
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeName, 100, conXzClg.CollegeName);
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeNameA, 12, conXzClg.CollegeNameA);
clsCheckSql.CheckFieldLen(objXzClgEN.ClgEnglishName, 60, conXzClg.ClgEnglishName);
clsCheckSql.CheckFieldLen(objXzClgEN.UserType, 50, conXzClg.UserType);
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeIdInGP, 6, conXzClg.CollegeIdInGP);
clsCheckSql.CheckFieldLen(objXzClgEN.IdSchool, 4, conXzClg.IdSchool);
clsCheckSql.CheckFieldLen(objXzClgEN.IdUni, 4, conXzClg.IdUni);
clsCheckSql.CheckFieldLen(objXzClgEN.PhoneNumber, 15, conXzClg.PhoneNumber);
clsCheckSql.CheckFieldLen(objXzClgEN.WebSite, 60, conXzClg.WebSite);
clsCheckSql.CheckFieldLen(objXzClgEN.ModifyDate, 20, conXzClg.ModifyDate);
clsCheckSql.CheckFieldLen(objXzClgEN.ModifyUserId, 18, conXzClg.ModifyUserId);
clsCheckSql.CheckFieldLen(objXzClgEN.Memo, 1000, conXzClg.Memo);
//检查字段外键固定长度
 objXzClgEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsXzClgEN objXzClgEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeId, 4, conXzClg.CollegeId);
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeName, 100, conXzClg.CollegeName);
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeNameA, 12, conXzClg.CollegeNameA);
clsCheckSql.CheckFieldLen(objXzClgEN.ClgEnglishName, 60, conXzClg.ClgEnglishName);
clsCheckSql.CheckFieldLen(objXzClgEN.UserType, 50, conXzClg.UserType);
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeIdInGP, 6, conXzClg.CollegeIdInGP);
clsCheckSql.CheckFieldLen(objXzClgEN.IdSchool, 4, conXzClg.IdSchool);
clsCheckSql.CheckFieldLen(objXzClgEN.IdUni, 4, conXzClg.IdUni);
clsCheckSql.CheckFieldLen(objXzClgEN.PhoneNumber, 15, conXzClg.PhoneNumber);
clsCheckSql.CheckFieldLen(objXzClgEN.WebSite, 60, conXzClg.WebSite);
clsCheckSql.CheckFieldLen(objXzClgEN.ModifyDate, 20, conXzClg.ModifyDate);
clsCheckSql.CheckFieldLen(objXzClgEN.ModifyUserId, 18, conXzClg.ModifyUserId);
clsCheckSql.CheckFieldLen(objXzClgEN.Memo, 1000, conXzClg.Memo);
//检查外键字段长度
 objXzClgEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsXzClgEN objXzClgEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzClgEN.IdXzCollege, 4, conXzClg.IdXzCollege);
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeId, 4, conXzClg.CollegeId);
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeName, 100, conXzClg.CollegeName);
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeNameA, 12, conXzClg.CollegeNameA);
clsCheckSql.CheckFieldLen(objXzClgEN.ClgEnglishName, 60, conXzClg.ClgEnglishName);
clsCheckSql.CheckFieldLen(objXzClgEN.UserType, 50, conXzClg.UserType);
clsCheckSql.CheckFieldLen(objXzClgEN.CollegeIdInGP, 6, conXzClg.CollegeIdInGP);
clsCheckSql.CheckFieldLen(objXzClgEN.IdSchool, 4, conXzClg.IdSchool);
clsCheckSql.CheckFieldLen(objXzClgEN.IdUni, 4, conXzClg.IdUni);
clsCheckSql.CheckFieldLen(objXzClgEN.PhoneNumber, 15, conXzClg.PhoneNumber);
clsCheckSql.CheckFieldLen(objXzClgEN.WebSite, 60, conXzClg.WebSite);
clsCheckSql.CheckFieldLen(objXzClgEN.ModifyDate, 20, conXzClg.ModifyDate);
clsCheckSql.CheckFieldLen(objXzClgEN.ModifyUserId, 18, conXzClg.ModifyUserId);
clsCheckSql.CheckFieldLen(objXzClgEN.Memo, 1000, conXzClg.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.IdXzCollege, conXzClg.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.CollegeId, conXzClg.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.CollegeName, conXzClg.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.CollegeNameA, conXzClg.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.ClgEnglishName, conXzClg.ClgEnglishName);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.UserType, conXzClg.UserType);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.CollegeIdInGP, conXzClg.CollegeIdInGP);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.IdSchool, conXzClg.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.IdUni, conXzClg.IdUni);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.PhoneNumber, conXzClg.PhoneNumber);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.WebSite, conXzClg.WebSite);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.ModifyDate, conXzClg.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.ModifyUserId, conXzClg.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objXzClgEN.Memo, conXzClg.Memo);
//检查外键字段长度
 objXzClgEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdXzCollege()
{
//获取某学院所有专业信息
string strSQL = "select IdXzCollege, CollegeName from XzClg ";
 clsSpecSQLforSql mySql = clsXzClgDA.GetSpecSQLObj();
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
 objSQL = clsXzClgDA.GetSpecSQLObj();
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
 objSQL = clsXzClgDA.GetSpecSQLObj();
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
 objSQL = clsXzClgDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzClgEN._CurrTabName);
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
 objSQL = clsXzClgDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzClgEN._CurrTabName, strCondition);
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
 objSQL = clsXzClgDA.GetSpecSQLObj();
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
 objSQL = clsXzClgDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}