
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzGradeBaseDA
 表名:XzGradeBase(00140043)
 * 版本:2024.02.03.1(服务器:WIN-SRV103-116)
 日期:2024/02/18 11:39:53
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
 /// 年级(XzGradeBase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsXzGradeBaseDA : clsCommBase4DA
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
 return clsXzGradeBaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsXzGradeBaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzGradeBaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsXzGradeBaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsXzGradeBaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdGradeBase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdGradeBase)
{
strIdGradeBase = strIdGradeBase.Replace("'", "''");
if (strIdGradeBase.Length > 4)
{
throw new Exception("(errid:Data000001)在表:XzGradeBase中,检查关键字,长度不正确!(clsXzGradeBaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdGradeBase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:XzGradeBase中,关键字不能为空 或 null!(clsXzGradeBaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdGradeBase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsXzGradeBaseDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strIdGradeBase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strIdGradeBase)
{
strIdGradeBase = strIdGradeBase.Replace("'", "''");
if (strIdGradeBase.Length > 4 + 4)
{
throw new Exception("(errid:Data000004)在表:XzGradeBase中,检查关键字,长度不正确!(简化版)(clsXzGradeBaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdGradeBase)  ==  true)
{
throw new Exception("(errid:Data000005)在表:XzGradeBase中,关键字不能为空 或 null!(clsXzGradeBaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdGradeBase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsXzGradeBaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
 strSQL = "Select * from XzGradeBase where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "XzGradeBase");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("XzGradeBase_SelectByCond",values, "XzGradeBase");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzGradeBase where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "XzGradeBase");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from XzGradeBase a where {0} And a.IdGradeBase not in (Select Top {2} IdGradeBase From XzGradeBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "XzGradeBase");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from XzGradeBase a where {0} And a.IdGradeBase not in (Select Top {2} IdGradeBase From XzGradeBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "XzGradeBase");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from XzGradeBase a where {0} And a.IdGradeBase not in (Select Top {2} IdGradeBase From XzGradeBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "XzGradeBase");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_XzGradeBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTable_XzGradeBase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzGradeBase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzGradeBase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzGradeBase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzGradeBase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzGradeBase.* from XzGradeBase Left Join {1} on {2} where {3} and XzGradeBase.IdGradeBase not in (Select top {5} XzGradeBase.IdGradeBase from XzGradeBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzGradeBase where {1} and IdGradeBase not in (Select top {2} IdGradeBase from XzGradeBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzGradeBase where {1} and IdGradeBase not in (Select top {3} IdGradeBase from XzGradeBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzGradeBase.* from XzGradeBase Left Join {1} on {2} where {3} and XzGradeBase.IdGradeBase not in (Select top {5} XzGradeBase.IdGradeBase from XzGradeBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzGradeBase where {1} and IdGradeBase not in (Select top {2} IdGradeBase from XzGradeBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzGradeBase where {1} and IdGradeBase not in (Select top {3} IdGradeBase from XzGradeBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzGradeBase.* from XzGradeBase Left Join {1} on {2} where {3} and XzGradeBase.IdGradeBase not in (Select top {5} XzGradeBase.IdGradeBase from XzGradeBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzGradeBase where {1} and IdGradeBase not in (Select top {2} IdGradeBase from XzGradeBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzGradeBase where {1} and IdGradeBase not in (Select top {3} IdGradeBase from XzGradeBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from XzGradeBase a where {0} And a.IdGradeBase not in (Select Top {2} IdGradeBase From XzGradeBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from XzGradeBase a where {0} And a.IdGradeBase not in (Select Top {2} IdGradeBase From XzGradeBase Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from XzGradeBase a where {0} And a.IdGradeBase not in (Select Top {2} IdGradeBase From XzGradeBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from XzGradeBase a where {0} And a.IdGradeBase not in (Select Top {2} IdGradeBase From XzGradeBase Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzGradeBaseDA: GetXzGradeBaseByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("XzGradeBase_SelectByCond",values);
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
public List<clsXzGradeBaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsXzGradeBaseDA:GetObjLst)", objException.Message));
}
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = TransNullToBool(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = TransNullToBool(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzGradeBaseDA: GetObjLst)", objException.Message));
}
objXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzGradeBaseEN);
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
public List<clsXzGradeBaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsXzGradeBaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = TransNullToBool(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = TransNullToBool(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzGradeBaseDA: GetObjLst)", objException.Message));
}
objXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzGradeBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsXzGradeBaseEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsXzGradeBaseDA:GetObjLstBySP)", objException.Message));
}
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("XzGradeBase_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = TransNullToBool(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = TransNullToBool(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsXzGradeBaseDA: GetObjLstBySP)", objException.Message));
}
objXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzGradeBaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetXzGradeBase(ref clsXzGradeBaseEN objXzGradeBaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where IdGradeBase = " + "'"+ objXzGradeBaseEN.IdGradeBase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objXzGradeBaseEN.IdGradeBase = objDT.Rows[0][conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzGradeBaseEN.GradeBaseId = objDT.Rows[0][conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objXzGradeBaseEN.GradeBaseName = objDT.Rows[0][conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:20,是否可空:False)
 objXzGradeBaseEN.SchoolYear = objDT.Rows[0][conXzGradeBase.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objXzGradeBaseEN.SchoolTerm = objDT.Rows[0][conXzGradeBase.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objXzGradeBaseEN.EnterSchoolDate = objDT.Rows[0][conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objXzGradeBaseEN.CurrentTermSeq = TransNullToInt(objDT.Rows[0][conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期(字段类型:int,字段长度:4,是否可空:False)
 objXzGradeBaseEN.ExecPlanTermIndex = TransNullToInt(objDT.Rows[0][conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期(字段类型:int,字段长度:4,是否可空:True)
 objXzGradeBaseEN.SetEPTermIndexDate = objDT.Rows[0][conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期(字段类型:char,字段长度:8,是否可空:True)
 objXzGradeBaseEN.IsOffed = TransNullToBool(objDT.Rows[0][conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业(字段类型:bit,字段长度:1,是否可空:True)
 objXzGradeBaseEN.ModifyDate = objDT.Rows[0][conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzGradeBaseEN.ModifyUserId = objDT.Rows[0][conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objXzGradeBaseEN.GradeIndex = TransNullToInt(objDT.Rows[0][conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号(字段类型:int,字段长度:4,是否可空:True)
 objXzGradeBaseEN.BeginYearMonth = objDT.Rows[0][conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月(字段类型:varchar,字段长度:8,是否可空:True)
 objXzGradeBaseEN.EndYearMonth = objDT.Rows[0][conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月(字段类型:varchar,字段长度:8,是否可空:True)
 objXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objDT.Rows[0][conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息(字段类型:bit,字段长度:1,是否可空:True)
 objXzGradeBaseEN.GradeBaseNameA = objDT.Rows[0][conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA(字段类型:varchar,字段长度:10,是否可空:False)
 objXzGradeBaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conXzGradeBase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objXzGradeBaseEN.IdStudyLevel = objDT.Rows[0][conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objXzGradeBaseEN.PointCalcVersionId = objDT.Rows[0][conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId(字段类型:char,字段长度:2,是否可空:True)
 objXzGradeBaseEN.Prefix = objDT.Rows[0][conXzGradeBase.Prefix].ToString().Trim(); //Prefix(字段类型:char,字段长度:3,是否可空:True)
 objXzGradeBaseEN.Memo = objDT.Rows[0][conXzGradeBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsXzGradeBaseDA: GetXzGradeBase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdGradeBase">表关键字</param>
 /// <returns>表对象</returns>
public clsXzGradeBaseEN GetObjByIdGradeBase(string strIdGradeBase)
{
CheckPrimaryKey(strIdGradeBase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where IdGradeBase = " + "'"+ strIdGradeBase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
 objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:20,是否可空:False)
 objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期(字段类型:int,字段长度:4,是否可空:False)
 objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期(字段类型:int,字段长度:4,是否可空:True)
 objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期(字段类型:char,字段长度:8,是否可空:True)
 objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业(字段类型:bit,字段长度:1,是否可空:True)
 objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号(字段类型:int,字段长度:4,是否可空:True)
 objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月(字段类型:varchar,字段长度:8,是否可空:True)
 objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月(字段类型:varchar,字段长度:8,是否可空:True)
 objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息(字段类型:bit,字段长度:1,是否可空:True)
 objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA(字段类型:varchar,字段长度:10,是否可空:False)
 objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId(字段类型:char,字段长度:2,是否可空:True)
 objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix(字段类型:char,字段长度:3,是否可空:True)
 objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsXzGradeBaseDA: GetObjByIdGradeBase)", objException.Message));
}
return objXzGradeBaseEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程XzGradeBase_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetXzGradeBaseOneBySP(clsXzGradeBaseEN objXzGradeBaseEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objXzGradeBaseEN.IdGradeBase
};
 objDT = objSQL.ExecSpReturnDT("XzGradeBase_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objXzGradeBaseEN.IdGradeBase = objDT.Rows[0][conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzGradeBaseEN.GradeBaseId = objDT.Rows[0][conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objXzGradeBaseEN.GradeBaseName = objDT.Rows[0][conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:20,是否可空:False)
 objXzGradeBaseEN.SchoolYear = objDT.Rows[0][conXzGradeBase.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objXzGradeBaseEN.SchoolTerm = objDT.Rows[0][conXzGradeBase.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objXzGradeBaseEN.EnterSchoolDate = objDT.Rows[0][conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objXzGradeBaseEN.CurrentTermSeq = TransNullToInt(objDT.Rows[0][conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期(字段类型:int,字段长度:4,是否可空:False)
 objXzGradeBaseEN.ExecPlanTermIndex = TransNullToInt(objDT.Rows[0][conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期(字段类型:int,字段长度:4,是否可空:True)
 objXzGradeBaseEN.SetEPTermIndexDate = objDT.Rows[0][conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期(字段类型:char,字段长度:8,是否可空:True)
 objXzGradeBaseEN.IsOffed = TransNullToBool(objDT.Rows[0][conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业(字段类型:bit,字段长度:1,是否可空:True)
 objXzGradeBaseEN.ModifyDate = objDT.Rows[0][conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzGradeBaseEN.ModifyUserId = objDT.Rows[0][conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objXzGradeBaseEN.GradeIndex = TransNullToInt(objDT.Rows[0][conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号(字段类型:int,字段长度:4,是否可空:True)
 objXzGradeBaseEN.BeginYearMonth = objDT.Rows[0][conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月(字段类型:varchar,字段长度:8,是否可空:True)
 objXzGradeBaseEN.EndYearMonth = objDT.Rows[0][conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月(字段类型:varchar,字段长度:8,是否可空:True)
 objXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objDT.Rows[0][conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息(字段类型:bit,字段长度:1,是否可空:True)
 objXzGradeBaseEN.GradeBaseNameA = objDT.Rows[0][conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA(字段类型:varchar,字段长度:10,是否可空:False)
 objXzGradeBaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conXzGradeBase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objXzGradeBaseEN.IdStudyLevel = objDT.Rows[0][conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objXzGradeBaseEN.PointCalcVersionId = objDT.Rows[0][conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId(字段类型:char,字段长度:2,是否可空:True)
 objXzGradeBaseEN.Prefix = objDT.Rows[0][conXzGradeBase.Prefix].ToString().Trim(); //Prefix(字段类型:char,字段长度:3,是否可空:True)
 objXzGradeBaseEN.Memo = objDT.Rows[0][conXzGradeBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsXzGradeBaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN()
{
IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(), //年级代号
GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(), //年级名称
SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(), //学期
EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(), //进校日期
CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()), //当前学期
ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()), //生成执行计划学期
SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(), //设定执行计划学期日期
IsOffed = TransNullToBool(objRow[conXzGradeBase.IsOffed].ToString().Trim()), //是否毕业
ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(), //修改人
GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.GradeIndex].ToString().Trim()), //年级序号
BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(), //开始年月
EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(), //结束年月
AllowUpBaseInfo = TransNullToBool(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()), //允许修改基本信息
GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(), //GradeBaseNameA
IsVisible = TransNullToBool(objRow[conXzGradeBase.IsVisible].ToString().Trim()), //是否显示
IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(), //IdStudyLevel
PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(), //PointCalcVersionId
Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(), //Prefix
Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim() //备注
};
objXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzGradeBaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsXzGradeBaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsXzGradeBaseEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsXzGradeBaseDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("XzGradeBase_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN()
{
IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(), //年级代号
GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(), //年级名称
SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(), //学期
EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(), //进校日期
CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()), //当前学期
ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()), //生成执行计划学期
SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(), //设定执行计划学期日期
IsOffed = TransNullToBool(objRow[conXzGradeBase.IsOffed].ToString().Trim()), //是否毕业
ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(), //修改人
GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.GradeIndex].ToString().Trim()), //年级序号
BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(), //开始年月
EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(), //结束年月
AllowUpBaseInfo = TransNullToBool(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()), //允许修改基本信息
GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(), //GradeBaseNameA
IsVisible = TransNullToBool(objRow[conXzGradeBase.IsVisible].ToString().Trim()), //是否显示
IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(), //IdStudyLevel
PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(), //PointCalcVersionId
Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(), //Prefix
Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim() //备注
};
objXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzGradeBaseEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsXzGradeBaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = TransNullToBool(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = TransNullToBool(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsXzGradeBaseDA: GetObjByDataRowXzGradeBase)", objException.Message));
}
objXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzGradeBaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsXzGradeBaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = TransNullToBool(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = TransNullToBool(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsXzGradeBaseDA: GetObjByDataRow)", objException.Message));
}
objXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzGradeBaseEN;
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
objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzGradeBaseEN._CurrTabName, conXzGradeBase.IdGradeBase, 4, "");
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
objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzGradeBaseEN._CurrTabName, conXzGradeBase.IdGradeBase, 4, strPrefix);
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
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdGradeBase from XzGradeBase where " + strCondition;
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
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdGradeBase from XzGradeBase where " + strCondition;
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
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdGradeBase)
{
CheckPrimaryKey(strIdGradeBase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzGradeBase", "IdGradeBase = " + "'"+ strIdGradeBase+"'"))
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
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strIdGradeBase)
{
CheckPrimaryKey(strIdGradeBase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strIdGradeBase,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("XzGradeBase_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsXzGradeBaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzGradeBase", strCondition))
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
objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("XzGradeBase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsXzGradeBaseEN objXzGradeBaseEN)
 {
 if (objXzGradeBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzGradeBaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzGradeBase");
objRow = objDS.Tables["XzGradeBase"].NewRow();
objRow[conXzGradeBase.IdGradeBase] = objXzGradeBaseEN.IdGradeBase; //年级流水号
objRow[conXzGradeBase.GradeBaseId] = objXzGradeBaseEN.GradeBaseId; //年级代号
objRow[conXzGradeBase.GradeBaseName] = objXzGradeBaseEN.GradeBaseName; //年级名称
objRow[conXzGradeBase.SchoolYear] = objXzGradeBaseEN.SchoolYear; //学年
objRow[conXzGradeBase.SchoolTerm] = objXzGradeBaseEN.SchoolTerm; //学期
 if (objXzGradeBaseEN.EnterSchoolDate !=  "")
 {
objRow[conXzGradeBase.EnterSchoolDate] = objXzGradeBaseEN.EnterSchoolDate; //进校日期
 }
objRow[conXzGradeBase.CurrentTermSeq] = objXzGradeBaseEN.CurrentTermSeq; //当前学期
objRow[conXzGradeBase.ExecPlanTermIndex] = objXzGradeBaseEN.ExecPlanTermIndex; //生成执行计划学期
 if (objXzGradeBaseEN.SetEPTermIndexDate !=  "")
 {
objRow[conXzGradeBase.SetEPTermIndexDate] = objXzGradeBaseEN.SetEPTermIndexDate; //设定执行计划学期日期
 }
objRow[conXzGradeBase.IsOffed] = objXzGradeBaseEN.IsOffed; //是否毕业
 if (objXzGradeBaseEN.ModifyDate !=  "")
 {
objRow[conXzGradeBase.ModifyDate] = objXzGradeBaseEN.ModifyDate; //修改日期
 }
 if (objXzGradeBaseEN.ModifyUserId !=  "")
 {
objRow[conXzGradeBase.ModifyUserId] = objXzGradeBaseEN.ModifyUserId; //修改人
 }
objRow[conXzGradeBase.GradeIndex] = objXzGradeBaseEN.GradeIndex; //年级序号
 if (objXzGradeBaseEN.BeginYearMonth !=  "")
 {
objRow[conXzGradeBase.BeginYearMonth] = objXzGradeBaseEN.BeginYearMonth; //开始年月
 }
 if (objXzGradeBaseEN.EndYearMonth !=  "")
 {
objRow[conXzGradeBase.EndYearMonth] = objXzGradeBaseEN.EndYearMonth; //结束年月
 }
objRow[conXzGradeBase.AllowUpBaseInfo] = objXzGradeBaseEN.AllowUpBaseInfo; //允许修改基本信息
 if (objXzGradeBaseEN.GradeBaseNameA !=  "")
 {
objRow[conXzGradeBase.GradeBaseNameA] = objXzGradeBaseEN.GradeBaseNameA; //GradeBaseNameA
 }
objRow[conXzGradeBase.IsVisible] = objXzGradeBaseEN.IsVisible; //是否显示
 if (objXzGradeBaseEN.IdStudyLevel !=  "")
 {
objRow[conXzGradeBase.IdStudyLevel] = objXzGradeBaseEN.IdStudyLevel; //IdStudyLevel
 }
 if (objXzGradeBaseEN.PointCalcVersionId !=  "")
 {
objRow[conXzGradeBase.PointCalcVersionId] = objXzGradeBaseEN.PointCalcVersionId; //PointCalcVersionId
 }
 if (objXzGradeBaseEN.Prefix !=  "")
 {
objRow[conXzGradeBase.Prefix] = objXzGradeBaseEN.Prefix; //Prefix
 }
 if (objXzGradeBaseEN.Memo !=  "")
 {
objRow[conXzGradeBase.Memo] = objXzGradeBaseEN.Memo; //备注
 }
objDS.Tables[clsXzGradeBaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsXzGradeBaseEN._CurrTabName);
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
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (objXzGradeBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzGradeBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzGradeBaseEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.IdGradeBase);
 var strIdGradeBase = objXzGradeBaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objXzGradeBaseEN.GradeBaseId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseId);
 var strGradeBaseId = objXzGradeBaseEN.GradeBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseId + "'");
 }
 
 if (objXzGradeBaseEN.GradeBaseName !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseName);
 var strGradeBaseName = objXzGradeBaseEN.GradeBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseName + "'");
 }
 
 if (objXzGradeBaseEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SchoolYear);
 var strSchoolYear = objXzGradeBaseEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objXzGradeBaseEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SchoolTerm);
 var strSchoolTerm = objXzGradeBaseEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objXzGradeBaseEN.EnterSchoolDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.EnterSchoolDate);
 var strEnterSchoolDate = objXzGradeBaseEN.EnterSchoolDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEnterSchoolDate + "'");
 }
 
 if (objXzGradeBaseEN.CurrentTermSeq !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.CurrentTermSeq);
 arrValueListForInsert.Add(objXzGradeBaseEN.CurrentTermSeq.ToString());
 }
 
 if (objXzGradeBaseEN.ExecPlanTermIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ExecPlanTermIndex);
 arrValueListForInsert.Add(objXzGradeBaseEN.ExecPlanTermIndex.ToString());
 }
 
 if (objXzGradeBaseEN.SetEPTermIndexDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SetEPTermIndexDate);
 var strSetEPTermIndexDate = objXzGradeBaseEN.SetEPTermIndexDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSetEPTermIndexDate + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.IsOffed);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.IsOffed  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ModifyDate);
 var strModifyDate = objXzGradeBaseEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objXzGradeBaseEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ModifyUserId);
 var strModifyUserId = objXzGradeBaseEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzGradeBaseEN.GradeIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeIndex);
 arrValueListForInsert.Add(objXzGradeBaseEN.GradeIndex.ToString());
 }
 
 if (objXzGradeBaseEN.BeginYearMonth !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.BeginYearMonth);
 var strBeginYearMonth = objXzGradeBaseEN.BeginYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBeginYearMonth + "'");
 }
 
 if (objXzGradeBaseEN.EndYearMonth !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.EndYearMonth);
 var strEndYearMonth = objXzGradeBaseEN.EndYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndYearMonth + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.AllowUpBaseInfo);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.AllowUpBaseInfo  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.GradeBaseNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseNameA);
 var strGradeBaseNameA = objXzGradeBaseEN.GradeBaseNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseNameA + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.IsVisible);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.IdStudyLevel);
 var strIdStudyLevel = objXzGradeBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objXzGradeBaseEN.PointCalcVersionId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.PointCalcVersionId);
 var strPointCalcVersionId = objXzGradeBaseEN.PointCalcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPointCalcVersionId + "'");
 }
 
 if (objXzGradeBaseEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.Prefix);
 var strPrefix = objXzGradeBaseEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefix + "'");
 }
 
 if (objXzGradeBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.Memo);
 var strMemo = objXzGradeBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzGradeBase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (objXzGradeBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzGradeBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzGradeBaseEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.IdGradeBase);
 var strIdGradeBase = objXzGradeBaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objXzGradeBaseEN.GradeBaseId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseId);
 var strGradeBaseId = objXzGradeBaseEN.GradeBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseId + "'");
 }
 
 if (objXzGradeBaseEN.GradeBaseName !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseName);
 var strGradeBaseName = objXzGradeBaseEN.GradeBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseName + "'");
 }
 
 if (objXzGradeBaseEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SchoolYear);
 var strSchoolYear = objXzGradeBaseEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objXzGradeBaseEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SchoolTerm);
 var strSchoolTerm = objXzGradeBaseEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objXzGradeBaseEN.EnterSchoolDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.EnterSchoolDate);
 var strEnterSchoolDate = objXzGradeBaseEN.EnterSchoolDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEnterSchoolDate + "'");
 }
 
 if (objXzGradeBaseEN.CurrentTermSeq !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.CurrentTermSeq);
 arrValueListForInsert.Add(objXzGradeBaseEN.CurrentTermSeq.ToString());
 }
 
 if (objXzGradeBaseEN.ExecPlanTermIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ExecPlanTermIndex);
 arrValueListForInsert.Add(objXzGradeBaseEN.ExecPlanTermIndex.ToString());
 }
 
 if (objXzGradeBaseEN.SetEPTermIndexDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SetEPTermIndexDate);
 var strSetEPTermIndexDate = objXzGradeBaseEN.SetEPTermIndexDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSetEPTermIndexDate + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.IsOffed);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.IsOffed  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ModifyDate);
 var strModifyDate = objXzGradeBaseEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objXzGradeBaseEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ModifyUserId);
 var strModifyUserId = objXzGradeBaseEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzGradeBaseEN.GradeIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeIndex);
 arrValueListForInsert.Add(objXzGradeBaseEN.GradeIndex.ToString());
 }
 
 if (objXzGradeBaseEN.BeginYearMonth !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.BeginYearMonth);
 var strBeginYearMonth = objXzGradeBaseEN.BeginYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBeginYearMonth + "'");
 }
 
 if (objXzGradeBaseEN.EndYearMonth !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.EndYearMonth);
 var strEndYearMonth = objXzGradeBaseEN.EndYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndYearMonth + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.AllowUpBaseInfo);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.AllowUpBaseInfo  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.GradeBaseNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseNameA);
 var strGradeBaseNameA = objXzGradeBaseEN.GradeBaseNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseNameA + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.IsVisible);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.IdStudyLevel);
 var strIdStudyLevel = objXzGradeBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objXzGradeBaseEN.PointCalcVersionId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.PointCalcVersionId);
 var strPointCalcVersionId = objXzGradeBaseEN.PointCalcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPointCalcVersionId + "'");
 }
 
 if (objXzGradeBaseEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.Prefix);
 var strPrefix = objXzGradeBaseEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefix + "'");
 }
 
 if (objXzGradeBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.Memo);
 var strMemo = objXzGradeBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzGradeBase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objXzGradeBaseEN.IdGradeBase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzGradeBaseEN objXzGradeBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzGradeBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzGradeBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzGradeBaseEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.IdGradeBase);
 var strIdGradeBase = objXzGradeBaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objXzGradeBaseEN.GradeBaseId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseId);
 var strGradeBaseId = objXzGradeBaseEN.GradeBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseId + "'");
 }
 
 if (objXzGradeBaseEN.GradeBaseName !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseName);
 var strGradeBaseName = objXzGradeBaseEN.GradeBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseName + "'");
 }
 
 if (objXzGradeBaseEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SchoolYear);
 var strSchoolYear = objXzGradeBaseEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objXzGradeBaseEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SchoolTerm);
 var strSchoolTerm = objXzGradeBaseEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objXzGradeBaseEN.EnterSchoolDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.EnterSchoolDate);
 var strEnterSchoolDate = objXzGradeBaseEN.EnterSchoolDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEnterSchoolDate + "'");
 }
 
 if (objXzGradeBaseEN.CurrentTermSeq !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.CurrentTermSeq);
 arrValueListForInsert.Add(objXzGradeBaseEN.CurrentTermSeq.ToString());
 }
 
 if (objXzGradeBaseEN.ExecPlanTermIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ExecPlanTermIndex);
 arrValueListForInsert.Add(objXzGradeBaseEN.ExecPlanTermIndex.ToString());
 }
 
 if (objXzGradeBaseEN.SetEPTermIndexDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SetEPTermIndexDate);
 var strSetEPTermIndexDate = objXzGradeBaseEN.SetEPTermIndexDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSetEPTermIndexDate + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.IsOffed);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.IsOffed  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ModifyDate);
 var strModifyDate = objXzGradeBaseEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objXzGradeBaseEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ModifyUserId);
 var strModifyUserId = objXzGradeBaseEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzGradeBaseEN.GradeIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeIndex);
 arrValueListForInsert.Add(objXzGradeBaseEN.GradeIndex.ToString());
 }
 
 if (objXzGradeBaseEN.BeginYearMonth !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.BeginYearMonth);
 var strBeginYearMonth = objXzGradeBaseEN.BeginYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBeginYearMonth + "'");
 }
 
 if (objXzGradeBaseEN.EndYearMonth !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.EndYearMonth);
 var strEndYearMonth = objXzGradeBaseEN.EndYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndYearMonth + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.AllowUpBaseInfo);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.AllowUpBaseInfo  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.GradeBaseNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseNameA);
 var strGradeBaseNameA = objXzGradeBaseEN.GradeBaseNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseNameA + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.IsVisible);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.IdStudyLevel);
 var strIdStudyLevel = objXzGradeBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objXzGradeBaseEN.PointCalcVersionId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.PointCalcVersionId);
 var strPointCalcVersionId = objXzGradeBaseEN.PointCalcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPointCalcVersionId + "'");
 }
 
 if (objXzGradeBaseEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.Prefix);
 var strPrefix = objXzGradeBaseEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefix + "'");
 }
 
 if (objXzGradeBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.Memo);
 var strMemo = objXzGradeBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzGradeBase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objXzGradeBaseEN.IdGradeBase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzGradeBaseEN objXzGradeBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzGradeBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzGradeBaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzGradeBaseEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.IdGradeBase);
 var strIdGradeBase = objXzGradeBaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objXzGradeBaseEN.GradeBaseId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseId);
 var strGradeBaseId = objXzGradeBaseEN.GradeBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseId + "'");
 }
 
 if (objXzGradeBaseEN.GradeBaseName !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseName);
 var strGradeBaseName = objXzGradeBaseEN.GradeBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseName + "'");
 }
 
 if (objXzGradeBaseEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SchoolYear);
 var strSchoolYear = objXzGradeBaseEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objXzGradeBaseEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SchoolTerm);
 var strSchoolTerm = objXzGradeBaseEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objXzGradeBaseEN.EnterSchoolDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.EnterSchoolDate);
 var strEnterSchoolDate = objXzGradeBaseEN.EnterSchoolDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEnterSchoolDate + "'");
 }
 
 if (objXzGradeBaseEN.CurrentTermSeq !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.CurrentTermSeq);
 arrValueListForInsert.Add(objXzGradeBaseEN.CurrentTermSeq.ToString());
 }
 
 if (objXzGradeBaseEN.ExecPlanTermIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ExecPlanTermIndex);
 arrValueListForInsert.Add(objXzGradeBaseEN.ExecPlanTermIndex.ToString());
 }
 
 if (objXzGradeBaseEN.SetEPTermIndexDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.SetEPTermIndexDate);
 var strSetEPTermIndexDate = objXzGradeBaseEN.SetEPTermIndexDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSetEPTermIndexDate + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.IsOffed);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.IsOffed  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ModifyDate);
 var strModifyDate = objXzGradeBaseEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objXzGradeBaseEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.ModifyUserId);
 var strModifyUserId = objXzGradeBaseEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzGradeBaseEN.GradeIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeIndex);
 arrValueListForInsert.Add(objXzGradeBaseEN.GradeIndex.ToString());
 }
 
 if (objXzGradeBaseEN.BeginYearMonth !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.BeginYearMonth);
 var strBeginYearMonth = objXzGradeBaseEN.BeginYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBeginYearMonth + "'");
 }
 
 if (objXzGradeBaseEN.EndYearMonth !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.EndYearMonth);
 var strEndYearMonth = objXzGradeBaseEN.EndYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndYearMonth + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.AllowUpBaseInfo);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.AllowUpBaseInfo  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.GradeBaseNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.GradeBaseNameA);
 var strGradeBaseNameA = objXzGradeBaseEN.GradeBaseNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeBaseNameA + "'");
 }
 
 arrFieldListForInsert.Add(conXzGradeBase.IsVisible);
 arrValueListForInsert.Add("'" + (objXzGradeBaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objXzGradeBaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.IdStudyLevel);
 var strIdStudyLevel = objXzGradeBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objXzGradeBaseEN.PointCalcVersionId !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.PointCalcVersionId);
 var strPointCalcVersionId = objXzGradeBaseEN.PointCalcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPointCalcVersionId + "'");
 }
 
 if (objXzGradeBaseEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.Prefix);
 var strPrefix = objXzGradeBaseEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefix + "'");
 }
 
 if (objXzGradeBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzGradeBase.Memo);
 var strMemo = objXzGradeBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzGradeBase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewXzGradeBaseBySP(clsXzGradeBaseEN objXzGradeBaseEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objXzGradeBaseEN.IdGradeBase,
 objXzGradeBaseEN.GradeBaseId,
 objXzGradeBaseEN.GradeBaseName,
 objXzGradeBaseEN.SchoolYear,
 objXzGradeBaseEN.SchoolTerm,
 objXzGradeBaseEN.EnterSchoolDate,
 objXzGradeBaseEN.CurrentTermSeq,
 objXzGradeBaseEN.ExecPlanTermIndex,
 objXzGradeBaseEN.SetEPTermIndexDate,
 objXzGradeBaseEN.IsOffed,
 objXzGradeBaseEN.ModifyDate,
 objXzGradeBaseEN.ModifyUserId,
 objXzGradeBaseEN.GradeIndex,
 objXzGradeBaseEN.BeginYearMonth,
 objXzGradeBaseEN.EndYearMonth,
 objXzGradeBaseEN.AllowUpBaseInfo,
 objXzGradeBaseEN.GradeBaseNameA,
 objXzGradeBaseEN.IsVisible,
 objXzGradeBaseEN.IdStudyLevel,
 objXzGradeBaseEN.PointCalcVersionId,
 objXzGradeBaseEN.Prefix,
objXzGradeBaseEN.Memo
};
 objSQL.ExecSP("XzGradeBase_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewXzGradeBases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where IdGradeBase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzGradeBase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdGradeBase = oRow[conXzGradeBase.IdGradeBase].ToString().Trim();
if (IsExist(strIdGradeBase))
{
 string strResult = "关键字变量值为:" + string.Format("IdGradeBase = {0}", strIdGradeBase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsXzGradeBaseEN._CurrTabName ].NewRow();
objRow[conXzGradeBase.IdGradeBase] = oRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objRow[conXzGradeBase.GradeBaseId] = oRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objRow[conXzGradeBase.GradeBaseName] = oRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objRow[conXzGradeBase.SchoolYear] = oRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objRow[conXzGradeBase.SchoolTerm] = oRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objRow[conXzGradeBase.EnterSchoolDate] = oRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objRow[conXzGradeBase.CurrentTermSeq] = oRow[conXzGradeBase.CurrentTermSeq].ToString().Trim(); //当前学期
objRow[conXzGradeBase.ExecPlanTermIndex] = oRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim(); //生成执行计划学期
objRow[conXzGradeBase.SetEPTermIndexDate] = oRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objRow[conXzGradeBase.IsOffed] = oRow[conXzGradeBase.IsOffed].ToString().Trim(); //是否毕业
objRow[conXzGradeBase.ModifyDate] = oRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objRow[conXzGradeBase.ModifyUserId] = oRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objRow[conXzGradeBase.GradeIndex] = oRow[conXzGradeBase.GradeIndex].ToString().Trim(); //年级序号
objRow[conXzGradeBase.BeginYearMonth] = oRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objRow[conXzGradeBase.EndYearMonth] = oRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objRow[conXzGradeBase.AllowUpBaseInfo] = oRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim(); //允许修改基本信息
objRow[conXzGradeBase.GradeBaseNameA] = oRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objRow[conXzGradeBase.IsVisible] = oRow[conXzGradeBase.IsVisible].ToString().Trim(); //是否显示
objRow[conXzGradeBase.IdStudyLevel] = oRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objRow[conXzGradeBase.PointCalcVersionId] = oRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objRow[conXzGradeBase.Prefix] = oRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objRow[conXzGradeBase.Memo] = oRow[conXzGradeBase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsXzGradeBaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsXzGradeBaseEN._CurrTabName);
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
 /// <param name = "objXzGradeBaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (objXzGradeBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzGradeBaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from XzGradeBase where IdGradeBase = " + "'"+ objXzGradeBaseEN.IdGradeBase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsXzGradeBaseEN._CurrTabName);
if (objDS.Tables[clsXzGradeBaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdGradeBase = " + "'"+ objXzGradeBaseEN.IdGradeBase+"'");
return false;
}
objRow = objDS.Tables[clsXzGradeBaseEN._CurrTabName].Rows[0];
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IdGradeBase))
 {
objRow[conXzGradeBase.IdGradeBase] = objXzGradeBaseEN.IdGradeBase; //年级流水号
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseId))
 {
objRow[conXzGradeBase.GradeBaseId] = objXzGradeBaseEN.GradeBaseId; //年级代号
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseName))
 {
objRow[conXzGradeBase.GradeBaseName] = objXzGradeBaseEN.GradeBaseName; //年级名称
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SchoolYear))
 {
objRow[conXzGradeBase.SchoolYear] = objXzGradeBaseEN.SchoolYear; //学年
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SchoolTerm))
 {
objRow[conXzGradeBase.SchoolTerm] = objXzGradeBaseEN.SchoolTerm; //学期
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.EnterSchoolDate))
 {
objRow[conXzGradeBase.EnterSchoolDate] = objXzGradeBaseEN.EnterSchoolDate; //进校日期
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.CurrentTermSeq))
 {
objRow[conXzGradeBase.CurrentTermSeq] = objXzGradeBaseEN.CurrentTermSeq; //当前学期
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ExecPlanTermIndex))
 {
objRow[conXzGradeBase.ExecPlanTermIndex] = objXzGradeBaseEN.ExecPlanTermIndex; //生成执行计划学期
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SetEPTermIndexDate))
 {
objRow[conXzGradeBase.SetEPTermIndexDate] = objXzGradeBaseEN.SetEPTermIndexDate; //设定执行计划学期日期
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IsOffed))
 {
objRow[conXzGradeBase.IsOffed] = objXzGradeBaseEN.IsOffed; //是否毕业
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ModifyDate))
 {
objRow[conXzGradeBase.ModifyDate] = objXzGradeBaseEN.ModifyDate; //修改日期
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ModifyUserId))
 {
objRow[conXzGradeBase.ModifyUserId] = objXzGradeBaseEN.ModifyUserId; //修改人
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeIndex))
 {
objRow[conXzGradeBase.GradeIndex] = objXzGradeBaseEN.GradeIndex; //年级序号
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.BeginYearMonth))
 {
objRow[conXzGradeBase.BeginYearMonth] = objXzGradeBaseEN.BeginYearMonth; //开始年月
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.EndYearMonth))
 {
objRow[conXzGradeBase.EndYearMonth] = objXzGradeBaseEN.EndYearMonth; //结束年月
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.AllowUpBaseInfo))
 {
objRow[conXzGradeBase.AllowUpBaseInfo] = objXzGradeBaseEN.AllowUpBaseInfo; //允许修改基本信息
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseNameA))
 {
objRow[conXzGradeBase.GradeBaseNameA] = objXzGradeBaseEN.GradeBaseNameA; //GradeBaseNameA
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IsVisible))
 {
objRow[conXzGradeBase.IsVisible] = objXzGradeBaseEN.IsVisible; //是否显示
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IdStudyLevel))
 {
objRow[conXzGradeBase.IdStudyLevel] = objXzGradeBaseEN.IdStudyLevel; //IdStudyLevel
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.PointCalcVersionId))
 {
objRow[conXzGradeBase.PointCalcVersionId] = objXzGradeBaseEN.PointCalcVersionId; //PointCalcVersionId
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.Prefix))
 {
objRow[conXzGradeBase.Prefix] = objXzGradeBaseEN.Prefix; //Prefix
 }
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.Memo))
 {
objRow[conXzGradeBase.Memo] = objXzGradeBaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsXzGradeBaseEN._CurrTabName);
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
public bool UpdateBySP(clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (objXzGradeBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzGradeBaseEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objXzGradeBaseEN.IdGradeBase,
 objXzGradeBaseEN.GradeBaseId,
 objXzGradeBaseEN.GradeBaseName,
 objXzGradeBaseEN.SchoolYear,
 objXzGradeBaseEN.SchoolTerm,
 objXzGradeBaseEN.EnterSchoolDate,
 objXzGradeBaseEN.CurrentTermSeq,
 objXzGradeBaseEN.ExecPlanTermIndex,
 objXzGradeBaseEN.SetEPTermIndexDate,
 objXzGradeBaseEN.IsOffed,
 objXzGradeBaseEN.ModifyDate,
 objXzGradeBaseEN.ModifyUserId,
 objXzGradeBaseEN.GradeIndex,
 objXzGradeBaseEN.BeginYearMonth,
 objXzGradeBaseEN.EndYearMonth,
 objXzGradeBaseEN.AllowUpBaseInfo,
 objXzGradeBaseEN.GradeBaseNameA,
 objXzGradeBaseEN.IsVisible,
 objXzGradeBaseEN.IdStudyLevel,
 objXzGradeBaseEN.PointCalcVersionId,
 objXzGradeBaseEN.Prefix,
 objXzGradeBaseEN.Memo
};
 objSQL.ExecSP("XzGradeBase_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (objXzGradeBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzGradeBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update XzGradeBase Set ");
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseId))
 {
 if (objXzGradeBaseEN.GradeBaseId !=  null)
 {
 var strGradeBaseId = objXzGradeBaseEN.GradeBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGradeBaseId, conXzGradeBase.GradeBaseId); //年级代号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.GradeBaseId); //年级代号
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseName))
 {
 if (objXzGradeBaseEN.GradeBaseName !=  null)
 {
 var strGradeBaseName = objXzGradeBaseEN.GradeBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGradeBaseName, conXzGradeBase.GradeBaseName); //年级名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.GradeBaseName); //年级名称
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SchoolYear))
 {
 if (objXzGradeBaseEN.SchoolYear !=  null)
 {
 var strSchoolYear = objXzGradeBaseEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conXzGradeBase.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.SchoolYear); //学年
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SchoolTerm))
 {
 if (objXzGradeBaseEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objXzGradeBaseEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conXzGradeBase.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.SchoolTerm); //学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.EnterSchoolDate))
 {
 if (objXzGradeBaseEN.EnterSchoolDate !=  null)
 {
 var strEnterSchoolDate = objXzGradeBaseEN.EnterSchoolDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEnterSchoolDate, conXzGradeBase.EnterSchoolDate); //进校日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.EnterSchoolDate); //进校日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.CurrentTermSeq))
 {
 if (objXzGradeBaseEN.CurrentTermSeq !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.CurrentTermSeq, conXzGradeBase.CurrentTermSeq); //当前学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.CurrentTermSeq); //当前学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ExecPlanTermIndex))
 {
 if (objXzGradeBaseEN.ExecPlanTermIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.ExecPlanTermIndex, conXzGradeBase.ExecPlanTermIndex); //生成执行计划学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.ExecPlanTermIndex); //生成执行计划学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SetEPTermIndexDate))
 {
 if (objXzGradeBaseEN.SetEPTermIndexDate !=  null)
 {
 var strSetEPTermIndexDate = objXzGradeBaseEN.SetEPTermIndexDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSetEPTermIndexDate, conXzGradeBase.SetEPTermIndexDate); //设定执行计划学期日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.SetEPTermIndexDate); //设定执行计划学期日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IsOffed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzGradeBaseEN.IsOffed == true?"1":"0", conXzGradeBase.IsOffed); //是否毕业
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ModifyDate))
 {
 if (objXzGradeBaseEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzGradeBaseEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conXzGradeBase.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.ModifyDate); //修改日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ModifyUserId))
 {
 if (objXzGradeBaseEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzGradeBaseEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conXzGradeBase.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.ModifyUserId); //修改人
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeIndex))
 {
 if (objXzGradeBaseEN.GradeIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.GradeIndex, conXzGradeBase.GradeIndex); //年级序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.GradeIndex); //年级序号
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.BeginYearMonth))
 {
 if (objXzGradeBaseEN.BeginYearMonth !=  null)
 {
 var strBeginYearMonth = objXzGradeBaseEN.BeginYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBeginYearMonth, conXzGradeBase.BeginYearMonth); //开始年月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.BeginYearMonth); //开始年月
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.EndYearMonth))
 {
 if (objXzGradeBaseEN.EndYearMonth !=  null)
 {
 var strEndYearMonth = objXzGradeBaseEN.EndYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEndYearMonth, conXzGradeBase.EndYearMonth); //结束年月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.EndYearMonth); //结束年月
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.AllowUpBaseInfo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzGradeBaseEN.AllowUpBaseInfo == true?"1":"0", conXzGradeBase.AllowUpBaseInfo); //允许修改基本信息
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseNameA))
 {
 if (objXzGradeBaseEN.GradeBaseNameA !=  null)
 {
 var strGradeBaseNameA = objXzGradeBaseEN.GradeBaseNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGradeBaseNameA, conXzGradeBase.GradeBaseNameA); //GradeBaseNameA
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.GradeBaseNameA); //GradeBaseNameA
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzGradeBaseEN.IsVisible == true?"1":"0", conXzGradeBase.IsVisible); //是否显示
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IdStudyLevel))
 {
 if (objXzGradeBaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objXzGradeBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conXzGradeBase.IdStudyLevel); //IdStudyLevel
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.IdStudyLevel); //IdStudyLevel
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.PointCalcVersionId))
 {
 if (objXzGradeBaseEN.PointCalcVersionId !=  null)
 {
 var strPointCalcVersionId = objXzGradeBaseEN.PointCalcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPointCalcVersionId, conXzGradeBase.PointCalcVersionId); //PointCalcVersionId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.PointCalcVersionId); //PointCalcVersionId
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.Prefix))
 {
 if (objXzGradeBaseEN.Prefix !=  null)
 {
 var strPrefix = objXzGradeBaseEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrefix, conXzGradeBase.Prefix); //Prefix
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.Prefix); //Prefix
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.Memo))
 {
 if (objXzGradeBaseEN.Memo !=  null)
 {
 var strMemo = objXzGradeBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzGradeBase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdGradeBase = '{0}'", objXzGradeBaseEN.IdGradeBase); 
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
 /// <param name = "objXzGradeBaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsXzGradeBaseEN objXzGradeBaseEN, string strCondition)
{
 if (objXzGradeBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzGradeBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzGradeBase Set ");
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseId))
 {
 if (objXzGradeBaseEN.GradeBaseId !=  null)
 {
 var strGradeBaseId = objXzGradeBaseEN.GradeBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GradeBaseId = '{0}',", strGradeBaseId); //年级代号
 }
 else
 {
 sbSQL.Append(" GradeBaseId = null,"); //年级代号
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseName))
 {
 if (objXzGradeBaseEN.GradeBaseName !=  null)
 {
 var strGradeBaseName = objXzGradeBaseEN.GradeBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GradeBaseName = '{0}',", strGradeBaseName); //年级名称
 }
 else
 {
 sbSQL.Append(" GradeBaseName = null,"); //年级名称
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SchoolYear))
 {
 if (objXzGradeBaseEN.SchoolYear !=  null)
 {
 var strSchoolYear = objXzGradeBaseEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SchoolTerm))
 {
 if (objXzGradeBaseEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objXzGradeBaseEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.EnterSchoolDate))
 {
 if (objXzGradeBaseEN.EnterSchoolDate !=  null)
 {
 var strEnterSchoolDate = objXzGradeBaseEN.EnterSchoolDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EnterSchoolDate = '{0}',", strEnterSchoolDate); //进校日期
 }
 else
 {
 sbSQL.Append(" EnterSchoolDate = null,"); //进校日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.CurrentTermSeq))
 {
 if (objXzGradeBaseEN.CurrentTermSeq !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.CurrentTermSeq, conXzGradeBase.CurrentTermSeq); //当前学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.CurrentTermSeq); //当前学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ExecPlanTermIndex))
 {
 if (objXzGradeBaseEN.ExecPlanTermIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.ExecPlanTermIndex, conXzGradeBase.ExecPlanTermIndex); //生成执行计划学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.ExecPlanTermIndex); //生成执行计划学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SetEPTermIndexDate))
 {
 if (objXzGradeBaseEN.SetEPTermIndexDate !=  null)
 {
 var strSetEPTermIndexDate = objXzGradeBaseEN.SetEPTermIndexDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SetEPTermIndexDate = '{0}',", strSetEPTermIndexDate); //设定执行计划学期日期
 }
 else
 {
 sbSQL.Append(" SetEPTermIndexDate = null,"); //设定执行计划学期日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IsOffed))
 {
 sbSQL.AppendFormat(" IsOffed = '{0}',", objXzGradeBaseEN.IsOffed == true?"1":"0"); //是否毕业
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ModifyDate))
 {
 if (objXzGradeBaseEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzGradeBaseEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ModifyUserId))
 {
 if (objXzGradeBaseEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzGradeBaseEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeIndex))
 {
 if (objXzGradeBaseEN.GradeIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.GradeIndex, conXzGradeBase.GradeIndex); //年级序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.GradeIndex); //年级序号
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.BeginYearMonth))
 {
 if (objXzGradeBaseEN.BeginYearMonth !=  null)
 {
 var strBeginYearMonth = objXzGradeBaseEN.BeginYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BeginYearMonth = '{0}',", strBeginYearMonth); //开始年月
 }
 else
 {
 sbSQL.Append(" BeginYearMonth = null,"); //开始年月
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.EndYearMonth))
 {
 if (objXzGradeBaseEN.EndYearMonth !=  null)
 {
 var strEndYearMonth = objXzGradeBaseEN.EndYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EndYearMonth = '{0}',", strEndYearMonth); //结束年月
 }
 else
 {
 sbSQL.Append(" EndYearMonth = null,"); //结束年月
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.AllowUpBaseInfo))
 {
 sbSQL.AppendFormat(" AllowUpBaseInfo = '{0}',", objXzGradeBaseEN.AllowUpBaseInfo == true?"1":"0"); //允许修改基本信息
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseNameA))
 {
 if (objXzGradeBaseEN.GradeBaseNameA !=  null)
 {
 var strGradeBaseNameA = objXzGradeBaseEN.GradeBaseNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GradeBaseNameA = '{0}',", strGradeBaseNameA); //GradeBaseNameA
 }
 else
 {
 sbSQL.Append(" GradeBaseNameA = null,"); //GradeBaseNameA
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objXzGradeBaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IdStudyLevel))
 {
 if (objXzGradeBaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objXzGradeBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //IdStudyLevel
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //IdStudyLevel
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.PointCalcVersionId))
 {
 if (objXzGradeBaseEN.PointCalcVersionId !=  null)
 {
 var strPointCalcVersionId = objXzGradeBaseEN.PointCalcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PointCalcVersionId = '{0}',", strPointCalcVersionId); //PointCalcVersionId
 }
 else
 {
 sbSQL.Append(" PointCalcVersionId = null,"); //PointCalcVersionId
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.Prefix))
 {
 if (objXzGradeBaseEN.Prefix !=  null)
 {
 var strPrefix = objXzGradeBaseEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Prefix = '{0}',", strPrefix); //Prefix
 }
 else
 {
 sbSQL.Append(" Prefix = null,"); //Prefix
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.Memo))
 {
 if (objXzGradeBaseEN.Memo !=  null)
 {
 var strMemo = objXzGradeBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzGradeBaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsXzGradeBaseEN objXzGradeBaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzGradeBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzGradeBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzGradeBase Set ");
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseId))
 {
 if (objXzGradeBaseEN.GradeBaseId !=  null)
 {
 var strGradeBaseId = objXzGradeBaseEN.GradeBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GradeBaseId = '{0}',", strGradeBaseId); //年级代号
 }
 else
 {
 sbSQL.Append(" GradeBaseId = null,"); //年级代号
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseName))
 {
 if (objXzGradeBaseEN.GradeBaseName !=  null)
 {
 var strGradeBaseName = objXzGradeBaseEN.GradeBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GradeBaseName = '{0}',", strGradeBaseName); //年级名称
 }
 else
 {
 sbSQL.Append(" GradeBaseName = null,"); //年级名称
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SchoolYear))
 {
 if (objXzGradeBaseEN.SchoolYear !=  null)
 {
 var strSchoolYear = objXzGradeBaseEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SchoolTerm))
 {
 if (objXzGradeBaseEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objXzGradeBaseEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.EnterSchoolDate))
 {
 if (objXzGradeBaseEN.EnterSchoolDate !=  null)
 {
 var strEnterSchoolDate = objXzGradeBaseEN.EnterSchoolDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EnterSchoolDate = '{0}',", strEnterSchoolDate); //进校日期
 }
 else
 {
 sbSQL.Append(" EnterSchoolDate = null,"); //进校日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.CurrentTermSeq))
 {
 if (objXzGradeBaseEN.CurrentTermSeq !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.CurrentTermSeq, conXzGradeBase.CurrentTermSeq); //当前学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.CurrentTermSeq); //当前学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ExecPlanTermIndex))
 {
 if (objXzGradeBaseEN.ExecPlanTermIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.ExecPlanTermIndex, conXzGradeBase.ExecPlanTermIndex); //生成执行计划学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.ExecPlanTermIndex); //生成执行计划学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SetEPTermIndexDate))
 {
 if (objXzGradeBaseEN.SetEPTermIndexDate !=  null)
 {
 var strSetEPTermIndexDate = objXzGradeBaseEN.SetEPTermIndexDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SetEPTermIndexDate = '{0}',", strSetEPTermIndexDate); //设定执行计划学期日期
 }
 else
 {
 sbSQL.Append(" SetEPTermIndexDate = null,"); //设定执行计划学期日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IsOffed))
 {
 sbSQL.AppendFormat(" IsOffed = '{0}',", objXzGradeBaseEN.IsOffed == true?"1":"0"); //是否毕业
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ModifyDate))
 {
 if (objXzGradeBaseEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzGradeBaseEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ModifyUserId))
 {
 if (objXzGradeBaseEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzGradeBaseEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeIndex))
 {
 if (objXzGradeBaseEN.GradeIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.GradeIndex, conXzGradeBase.GradeIndex); //年级序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.GradeIndex); //年级序号
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.BeginYearMonth))
 {
 if (objXzGradeBaseEN.BeginYearMonth !=  null)
 {
 var strBeginYearMonth = objXzGradeBaseEN.BeginYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BeginYearMonth = '{0}',", strBeginYearMonth); //开始年月
 }
 else
 {
 sbSQL.Append(" BeginYearMonth = null,"); //开始年月
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.EndYearMonth))
 {
 if (objXzGradeBaseEN.EndYearMonth !=  null)
 {
 var strEndYearMonth = objXzGradeBaseEN.EndYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EndYearMonth = '{0}',", strEndYearMonth); //结束年月
 }
 else
 {
 sbSQL.Append(" EndYearMonth = null,"); //结束年月
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.AllowUpBaseInfo))
 {
 sbSQL.AppendFormat(" AllowUpBaseInfo = '{0}',", objXzGradeBaseEN.AllowUpBaseInfo == true?"1":"0"); //允许修改基本信息
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseNameA))
 {
 if (objXzGradeBaseEN.GradeBaseNameA !=  null)
 {
 var strGradeBaseNameA = objXzGradeBaseEN.GradeBaseNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GradeBaseNameA = '{0}',", strGradeBaseNameA); //GradeBaseNameA
 }
 else
 {
 sbSQL.Append(" GradeBaseNameA = null,"); //GradeBaseNameA
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objXzGradeBaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IdStudyLevel))
 {
 if (objXzGradeBaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objXzGradeBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //IdStudyLevel
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //IdStudyLevel
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.PointCalcVersionId))
 {
 if (objXzGradeBaseEN.PointCalcVersionId !=  null)
 {
 var strPointCalcVersionId = objXzGradeBaseEN.PointCalcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PointCalcVersionId = '{0}',", strPointCalcVersionId); //PointCalcVersionId
 }
 else
 {
 sbSQL.Append(" PointCalcVersionId = null,"); //PointCalcVersionId
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.Prefix))
 {
 if (objXzGradeBaseEN.Prefix !=  null)
 {
 var strPrefix = objXzGradeBaseEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Prefix = '{0}',", strPrefix); //Prefix
 }
 else
 {
 sbSQL.Append(" Prefix = null,"); //Prefix
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.Memo))
 {
 if (objXzGradeBaseEN.Memo !=  null)
 {
 var strMemo = objXzGradeBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzGradeBaseEN objXzGradeBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzGradeBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzGradeBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzGradeBase Set ");
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseId))
 {
 if (objXzGradeBaseEN.GradeBaseId !=  null)
 {
 var strGradeBaseId = objXzGradeBaseEN.GradeBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGradeBaseId, conXzGradeBase.GradeBaseId); //年级代号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.GradeBaseId); //年级代号
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseName))
 {
 if (objXzGradeBaseEN.GradeBaseName !=  null)
 {
 var strGradeBaseName = objXzGradeBaseEN.GradeBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGradeBaseName, conXzGradeBase.GradeBaseName); //年级名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.GradeBaseName); //年级名称
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SchoolYear))
 {
 if (objXzGradeBaseEN.SchoolYear !=  null)
 {
 var strSchoolYear = objXzGradeBaseEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conXzGradeBase.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.SchoolYear); //学年
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SchoolTerm))
 {
 if (objXzGradeBaseEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objXzGradeBaseEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conXzGradeBase.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.SchoolTerm); //学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.EnterSchoolDate))
 {
 if (objXzGradeBaseEN.EnterSchoolDate !=  null)
 {
 var strEnterSchoolDate = objXzGradeBaseEN.EnterSchoolDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEnterSchoolDate, conXzGradeBase.EnterSchoolDate); //进校日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.EnterSchoolDate); //进校日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.CurrentTermSeq))
 {
 if (objXzGradeBaseEN.CurrentTermSeq !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.CurrentTermSeq, conXzGradeBase.CurrentTermSeq); //当前学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.CurrentTermSeq); //当前学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ExecPlanTermIndex))
 {
 if (objXzGradeBaseEN.ExecPlanTermIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.ExecPlanTermIndex, conXzGradeBase.ExecPlanTermIndex); //生成执行计划学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.ExecPlanTermIndex); //生成执行计划学期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.SetEPTermIndexDate))
 {
 if (objXzGradeBaseEN.SetEPTermIndexDate !=  null)
 {
 var strSetEPTermIndexDate = objXzGradeBaseEN.SetEPTermIndexDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSetEPTermIndexDate, conXzGradeBase.SetEPTermIndexDate); //设定执行计划学期日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.SetEPTermIndexDate); //设定执行计划学期日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IsOffed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzGradeBaseEN.IsOffed == true?"1":"0", conXzGradeBase.IsOffed); //是否毕业
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ModifyDate))
 {
 if (objXzGradeBaseEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzGradeBaseEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conXzGradeBase.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.ModifyDate); //修改日期
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.ModifyUserId))
 {
 if (objXzGradeBaseEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzGradeBaseEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conXzGradeBase.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.ModifyUserId); //修改人
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeIndex))
 {
 if (objXzGradeBaseEN.GradeIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzGradeBaseEN.GradeIndex, conXzGradeBase.GradeIndex); //年级序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.GradeIndex); //年级序号
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.BeginYearMonth))
 {
 if (objXzGradeBaseEN.BeginYearMonth !=  null)
 {
 var strBeginYearMonth = objXzGradeBaseEN.BeginYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBeginYearMonth, conXzGradeBase.BeginYearMonth); //开始年月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.BeginYearMonth); //开始年月
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.EndYearMonth))
 {
 if (objXzGradeBaseEN.EndYearMonth !=  null)
 {
 var strEndYearMonth = objXzGradeBaseEN.EndYearMonth.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEndYearMonth, conXzGradeBase.EndYearMonth); //结束年月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.EndYearMonth); //结束年月
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.AllowUpBaseInfo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzGradeBaseEN.AllowUpBaseInfo == true?"1":"0", conXzGradeBase.AllowUpBaseInfo); //允许修改基本信息
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.GradeBaseNameA))
 {
 if (objXzGradeBaseEN.GradeBaseNameA !=  null)
 {
 var strGradeBaseNameA = objXzGradeBaseEN.GradeBaseNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGradeBaseNameA, conXzGradeBase.GradeBaseNameA); //GradeBaseNameA
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.GradeBaseNameA); //GradeBaseNameA
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzGradeBaseEN.IsVisible == true?"1":"0", conXzGradeBase.IsVisible); //是否显示
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.IdStudyLevel))
 {
 if (objXzGradeBaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objXzGradeBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conXzGradeBase.IdStudyLevel); //IdStudyLevel
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.IdStudyLevel); //IdStudyLevel
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.PointCalcVersionId))
 {
 if (objXzGradeBaseEN.PointCalcVersionId !=  null)
 {
 var strPointCalcVersionId = objXzGradeBaseEN.PointCalcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPointCalcVersionId, conXzGradeBase.PointCalcVersionId); //PointCalcVersionId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.PointCalcVersionId); //PointCalcVersionId
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.Prefix))
 {
 if (objXzGradeBaseEN.Prefix !=  null)
 {
 var strPrefix = objXzGradeBaseEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrefix, conXzGradeBase.Prefix); //Prefix
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.Prefix); //Prefix
 }
 }
 
 if (objXzGradeBaseEN.IsUpdated(conXzGradeBase.Memo))
 {
 if (objXzGradeBaseEN.Memo !=  null)
 {
 var strMemo = objXzGradeBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzGradeBase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzGradeBase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdGradeBase = '{0}'", objXzGradeBaseEN.IdGradeBase); 
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
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdGradeBase) 
{
CheckPrimaryKey(strIdGradeBase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdGradeBase,
};
 objSQL.ExecSP("XzGradeBase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdGradeBase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdGradeBase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
//删除XzGradeBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzGradeBase where IdGradeBase = " + "'"+ strIdGradeBase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelXzGradeBase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
//删除XzGradeBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzGradeBase where IdGradeBase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdGradeBase) 
{
CheckPrimaryKey(strIdGradeBase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
//删除XzGradeBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzGradeBase where IdGradeBase = " + "'"+ strIdGradeBase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelXzGradeBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: DelXzGradeBase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzGradeBase where " + strCondition ;
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
public bool DelXzGradeBaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsXzGradeBaseDA: DelXzGradeBaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzGradeBase where " + strCondition ;
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
 /// <param name = "objXzGradeBaseENS">源对象</param>
 /// <param name = "objXzGradeBaseENT">目标对象</param>
public void CopyTo(clsXzGradeBaseEN objXzGradeBaseENS, clsXzGradeBaseEN objXzGradeBaseENT)
{
objXzGradeBaseENT.IdGradeBase = objXzGradeBaseENS.IdGradeBase; //年级流水号
objXzGradeBaseENT.GradeBaseId = objXzGradeBaseENS.GradeBaseId; //年级代号
objXzGradeBaseENT.GradeBaseName = objXzGradeBaseENS.GradeBaseName; //年级名称
objXzGradeBaseENT.SchoolYear = objXzGradeBaseENS.SchoolYear; //学年
objXzGradeBaseENT.SchoolTerm = objXzGradeBaseENS.SchoolTerm; //学期
objXzGradeBaseENT.EnterSchoolDate = objXzGradeBaseENS.EnterSchoolDate; //进校日期
objXzGradeBaseENT.CurrentTermSeq = objXzGradeBaseENS.CurrentTermSeq; //当前学期
objXzGradeBaseENT.ExecPlanTermIndex = objXzGradeBaseENS.ExecPlanTermIndex; //生成执行计划学期
objXzGradeBaseENT.SetEPTermIndexDate = objXzGradeBaseENS.SetEPTermIndexDate; //设定执行计划学期日期
objXzGradeBaseENT.IsOffed = objXzGradeBaseENS.IsOffed; //是否毕业
objXzGradeBaseENT.ModifyDate = objXzGradeBaseENS.ModifyDate; //修改日期
objXzGradeBaseENT.ModifyUserId = objXzGradeBaseENS.ModifyUserId; //修改人
objXzGradeBaseENT.GradeIndex = objXzGradeBaseENS.GradeIndex; //年级序号
objXzGradeBaseENT.BeginYearMonth = objXzGradeBaseENS.BeginYearMonth; //开始年月
objXzGradeBaseENT.EndYearMonth = objXzGradeBaseENS.EndYearMonth; //结束年月
objXzGradeBaseENT.AllowUpBaseInfo = objXzGradeBaseENS.AllowUpBaseInfo; //允许修改基本信息
objXzGradeBaseENT.GradeBaseNameA = objXzGradeBaseENS.GradeBaseNameA; //GradeBaseNameA
objXzGradeBaseENT.IsVisible = objXzGradeBaseENS.IsVisible; //是否显示
objXzGradeBaseENT.IdStudyLevel = objXzGradeBaseENS.IdStudyLevel; //IdStudyLevel
objXzGradeBaseENT.PointCalcVersionId = objXzGradeBaseENS.PointCalcVersionId; //PointCalcVersionId
objXzGradeBaseENT.Prefix = objXzGradeBaseENS.Prefix; //Prefix
objXzGradeBaseENT.Memo = objXzGradeBaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsXzGradeBaseEN objXzGradeBaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objXzGradeBaseEN.GradeBaseId, conXzGradeBase.GradeBaseId);
clsCheckSql.CheckFieldNotNull(objXzGradeBaseEN.GradeBaseName, conXzGradeBase.GradeBaseName);
clsCheckSql.CheckFieldNotNull(objXzGradeBaseEN.SchoolYear, conXzGradeBase.SchoolYear);
clsCheckSql.CheckFieldNotNull(objXzGradeBaseEN.SchoolTerm, conXzGradeBase.SchoolTerm);
clsCheckSql.CheckFieldNotNull(objXzGradeBaseEN.IsOffed, conXzGradeBase.IsOffed);
//检查字段长度
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.IdGradeBase, 4, conXzGradeBase.IdGradeBase);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.GradeBaseId, 4, conXzGradeBase.GradeBaseId);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.GradeBaseName, 20, conXzGradeBase.GradeBaseName);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.SchoolYear, 10, conXzGradeBase.SchoolYear);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.SchoolTerm, 1, conXzGradeBase.SchoolTerm);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.EnterSchoolDate, 8, conXzGradeBase.EnterSchoolDate);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.SetEPTermIndexDate, 8, conXzGradeBase.SetEPTermIndexDate);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.ModifyDate, 20, conXzGradeBase.ModifyDate);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.ModifyUserId, 18, conXzGradeBase.ModifyUserId);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.BeginYearMonth, 8, conXzGradeBase.BeginYearMonth);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.EndYearMonth, 8, conXzGradeBase.EndYearMonth);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.GradeBaseNameA, 10, conXzGradeBase.GradeBaseNameA);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.IdStudyLevel, 4, conXzGradeBase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.PointCalcVersionId, 2, conXzGradeBase.PointCalcVersionId);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.Prefix, 3, conXzGradeBase.Prefix);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.Memo, 1000, conXzGradeBase.Memo);
//检查字段外键固定长度
 objXzGradeBaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsXzGradeBaseEN objXzGradeBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.GradeBaseId, 4, conXzGradeBase.GradeBaseId);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.GradeBaseName, 20, conXzGradeBase.GradeBaseName);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.SchoolYear, 10, conXzGradeBase.SchoolYear);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.SchoolTerm, 1, conXzGradeBase.SchoolTerm);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.EnterSchoolDate, 8, conXzGradeBase.EnterSchoolDate);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.SetEPTermIndexDate, 8, conXzGradeBase.SetEPTermIndexDate);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.ModifyDate, 20, conXzGradeBase.ModifyDate);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.ModifyUserId, 18, conXzGradeBase.ModifyUserId);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.BeginYearMonth, 8, conXzGradeBase.BeginYearMonth);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.EndYearMonth, 8, conXzGradeBase.EndYearMonth);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.GradeBaseNameA, 10, conXzGradeBase.GradeBaseNameA);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.IdStudyLevel, 4, conXzGradeBase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.PointCalcVersionId, 2, conXzGradeBase.PointCalcVersionId);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.Prefix, 3, conXzGradeBase.Prefix);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.Memo, 1000, conXzGradeBase.Memo);
//检查外键字段长度
 objXzGradeBaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsXzGradeBaseEN objXzGradeBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.IdGradeBase, 4, conXzGradeBase.IdGradeBase);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.GradeBaseId, 4, conXzGradeBase.GradeBaseId);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.GradeBaseName, 20, conXzGradeBase.GradeBaseName);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.SchoolYear, 10, conXzGradeBase.SchoolYear);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.SchoolTerm, 1, conXzGradeBase.SchoolTerm);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.EnterSchoolDate, 8, conXzGradeBase.EnterSchoolDate);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.SetEPTermIndexDate, 8, conXzGradeBase.SetEPTermIndexDate);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.ModifyDate, 20, conXzGradeBase.ModifyDate);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.ModifyUserId, 18, conXzGradeBase.ModifyUserId);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.BeginYearMonth, 8, conXzGradeBase.BeginYearMonth);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.EndYearMonth, 8, conXzGradeBase.EndYearMonth);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.GradeBaseNameA, 10, conXzGradeBase.GradeBaseNameA);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.IdStudyLevel, 4, conXzGradeBase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.PointCalcVersionId, 2, conXzGradeBase.PointCalcVersionId);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.Prefix, 3, conXzGradeBase.Prefix);
clsCheckSql.CheckFieldLen(objXzGradeBaseEN.Memo, 1000, conXzGradeBase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.IdGradeBase, conXzGradeBase.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.GradeBaseId, conXzGradeBase.GradeBaseId);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.GradeBaseName, conXzGradeBase.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.SchoolYear, conXzGradeBase.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.SchoolTerm, conXzGradeBase.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.EnterSchoolDate, conXzGradeBase.EnterSchoolDate);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.SetEPTermIndexDate, conXzGradeBase.SetEPTermIndexDate);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.ModifyDate, conXzGradeBase.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.ModifyUserId, conXzGradeBase.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.BeginYearMonth, conXzGradeBase.BeginYearMonth);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.EndYearMonth, conXzGradeBase.EndYearMonth);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.GradeBaseNameA, conXzGradeBase.GradeBaseNameA);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.IdStudyLevel, conXzGradeBase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.PointCalcVersionId, conXzGradeBase.PointCalcVersionId);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.Prefix, conXzGradeBase.Prefix);
clsCheckSql.CheckSqlInjection4Field(objXzGradeBaseEN.Memo, conXzGradeBase.Memo);
//检查外键字段长度
 objXzGradeBaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdGradeBase()
{
//获取某学院所有专业信息
string strSQL = "select IdGradeBase, GradeBaseName from XzGradeBase ";
 clsSpecSQLforSql mySql = clsXzGradeBaseDA.GetSpecSQLObj();
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
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzGradeBaseEN._CurrTabName);
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
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzGradeBaseEN._CurrTabName, strCondition);
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
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
 objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}