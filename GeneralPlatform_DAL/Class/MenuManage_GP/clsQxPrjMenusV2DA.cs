
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjMenusV2DA
 表名:QxPrjMenusV2(00140112)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:29:12
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
 /// 工程菜单V2(QxPrjMenusV2)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxPrjMenusV2DA : clsCommBase4DA
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
 return clsQxPrjMenusV2EN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxPrjMenusV2EN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjMenusV2EN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxPrjMenusV2EN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxPrjMenusV2EN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
 strSQL = "Select * from QxPrjMenusV2 where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxPrjMenusV2");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxPrjMenusV2_SelectByCond",values, "QxPrjMenusV2");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjMenusV2 where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjMenusV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjMenusV2 a where {0} And a.id not in (Select Top {2} id From QxPrjMenusV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjMenusV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjMenusV2 a where {0} And a.id not in (Select Top {2} id From QxPrjMenusV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjMenusV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxPrjMenusV2 a where {0} And a.id not in (Select Top {2} id From QxPrjMenusV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxPrjMenusV2");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxPrjMenusV2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTable_QxPrjMenusV2)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenusV2 where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenusV2 where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjMenusV2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxPrjMenusV2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjMenusV2.* from QxPrjMenusV2 Left Join {1} on {2} where {3} and QxPrjMenusV2.id not in (Select top {5} QxPrjMenusV2.id from QxPrjMenusV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenusV2 where {1} and id not in (Select top {2} id from QxPrjMenusV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenusV2 where {1} and id not in (Select top {3} id from QxPrjMenusV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjMenusV2.* from QxPrjMenusV2 Left Join {1} on {2} where {3} and QxPrjMenusV2.id not in (Select top {5} QxPrjMenusV2.id from QxPrjMenusV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenusV2 where {1} and id not in (Select top {2} id from QxPrjMenusV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenusV2 where {1} and id not in (Select top {3} id from QxPrjMenusV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxPrjMenusV2.* from QxPrjMenusV2 Left Join {1} on {2} where {3} and QxPrjMenusV2.id not in (Select top {5} QxPrjMenusV2.id from QxPrjMenusV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenusV2 where {1} and id not in (Select top {2} id from QxPrjMenusV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxPrjMenusV2 where {1} and id not in (Select top {3} id from QxPrjMenusV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjMenusV2 a where {0} And a.id not in (Select Top {2} id From QxPrjMenusV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjMenusV2 a where {0} And a.id not in (Select Top {2} id From QxPrjMenusV2 Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxPrjMenusV2 a where {0} And a.id not in (Select Top {2} id From QxPrjMenusV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxPrjMenusV2 a where {0} And a.id not in (Select Top {2} id From QxPrjMenusV2 Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2ByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjMenusV2_SelectByCond",values);
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
public List<clsQxPrjMenusV2EN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA:GetObjLst)", objException.Message));
}
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = TransNullToInt(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = TransNullToInt(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = TransNullToInt(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = TransNullToBool(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = TransNullToBool(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = TransNullToBool(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = TransNullToInt(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = TransNullToBool(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = TransNullToBool(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjMenusV2DA: GetObjLst)", objException.Message));
}
objQxPrjMenusV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjMenusV2EN);
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
public List<clsQxPrjMenusV2EN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA:GetObjLstByTabName)", objException.Message));
}
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = TransNullToInt(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = TransNullToInt(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = TransNullToInt(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = TransNullToBool(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = TransNullToBool(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = TransNullToBool(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = TransNullToInt(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = TransNullToBool(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = TransNullToBool(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjMenusV2DA: GetObjLst)", objException.Message));
}
objQxPrjMenusV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjMenusV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxPrjMenusV2EN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA:GetObjLstBySP)", objException.Message));
}
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjMenusV2_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = TransNullToInt(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = TransNullToInt(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = TransNullToInt(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = TransNullToBool(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = TransNullToBool(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = TransNullToBool(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = TransNullToInt(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = TransNullToBool(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = TransNullToBool(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxPrjMenusV2DA: GetObjLstBySP)", objException.Message));
}
objQxPrjMenusV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxPrjMenusV2EN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjMenusV2(ref clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where id = " + ""+ objQxPrjMenusV2EN.id+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxPrjMenusV2EN.createdAt = objDT.Rows[0][conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxPrjMenusV2EN.updatedAt = objDT.Rows[0][conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxPrjMenusV2EN.id = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.id].ToString().Trim()); //id(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.parentMenuId = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusV2EN.MenuName = objDT.Rows[0][conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjMenusV2EN.router = objDT.Rows[0][conQxPrjMenusV2.router].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.perms = objDT.Rows[0][conQxPrjMenusV2.perms].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.type = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.type].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusV2EN.icon = objDT.Rows[0][conQxPrjMenusV2.icon].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.OrderNum = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusV2EN.viewPath = objDT.Rows[0][conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxPrjMenusV2EN.keepalive = TransNullToBool(objDT.Rows[0][conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.isShow = TransNullToBool(objDT.Rows[0][conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.isExt = TransNullToBool(objDT.Rows[0][conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.openMode = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.QxPrjId = objDT.Rows[0][conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.UpdUserId = objDT.Rows[0][conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusV2EN.Memo = objDT.Rows[0][conQxPrjMenusV2.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxPrjMenusV2EN.LinkFile = objDT.Rows[0][conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.UpdDate = objDT.Rows[0][conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusV2EN.MenuControlName = objDT.Rows[0][conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
 objQxPrjMenusV2EN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.MenuTitle = objDT.Rows[0][conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjMenusV2EN.PageDispModeId = objDT.Rows[0][conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objQxPrjMenusV2EN.InUse = TransNullToBool(objDT.Rows[0][conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.qsParameters = objDT.Rows[0][conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objQxPrjMenusV2EN.ImgFile = objDT.Rows[0][conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxPrjMenusV2EN.TabId = objDT.Rows[0][conQxPrjMenusV2.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjMenusV2EN.RoleId = objDT.Rows[0][conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjMenusV2EN.IsLeafNode = TransNullToBool(objDT.Rows[0][conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.MenuSetId = objDT.Rows[0][conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.MenuIdOld = objDT.Rows[0][conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxPrjMenusV2DA: GetQxPrjMenusV2)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intid">表关键字</param>
 /// <returns>表对象</returns>
public clsQxPrjMenusV2EN GetObjByid(int intid)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where id = " + ""+ intid+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
 objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
 objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxPrjMenusV2DA: GetObjByid)", objException.Message));
}
return objQxPrjMenusV2EN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxPrjMenusV2_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxPrjMenusV2OneBySP(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxPrjMenusV2EN.id
};
 objDT = objSQL.ExecSpReturnDT("QxPrjMenusV2_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxPrjMenusV2EN.createdAt = objDT.Rows[0][conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxPrjMenusV2EN.updatedAt = objDT.Rows[0][conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxPrjMenusV2EN.id = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.id].ToString().Trim()); //id(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.parentMenuId = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusV2EN.MenuName = objDT.Rows[0][conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxPrjMenusV2EN.router = objDT.Rows[0][conQxPrjMenusV2.router].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.perms = objDT.Rows[0][conQxPrjMenusV2.perms].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.type = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.type].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusV2EN.icon = objDT.Rows[0][conQxPrjMenusV2.icon].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.OrderNum = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxPrjMenusV2EN.viewPath = objDT.Rows[0][conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxPrjMenusV2EN.keepalive = TransNullToBool(objDT.Rows[0][conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.isShow = TransNullToBool(objDT.Rows[0][conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.isExt = TransNullToBool(objDT.Rows[0][conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.openMode = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.QxPrjId = objDT.Rows[0][conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.UpdUserId = objDT.Rows[0][conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusV2EN.Memo = objDT.Rows[0][conQxPrjMenusV2.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxPrjMenusV2EN.LinkFile = objDT.Rows[0][conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件(字段类型:varchar,字段长度:500,是否可空:True)
 objQxPrjMenusV2EN.UpdDate = objDT.Rows[0][conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxPrjMenusV2EN.MenuControlName = objDT.Rows[0][conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName(字段类型:varchar,字段长度:100,是否可空:True)
 objQxPrjMenusV2EN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.MenuTitle = objDT.Rows[0][conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题(字段类型:varchar,字段长度:50,是否可空:True)
 objQxPrjMenusV2EN.PageDispModeId = objDT.Rows[0][conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objQxPrjMenusV2EN.InUse = TransNullToBool(objDT.Rows[0][conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.qsParameters = objDT.Rows[0][conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数(字段类型:varchar,字段长度:200,是否可空:True)
 objQxPrjMenusV2EN.ImgFile = objDT.Rows[0][conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:300,是否可空:True)
 objQxPrjMenusV2EN.TabId = objDT.Rows[0][conQxPrjMenusV2.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objQxPrjMenusV2EN.RoleId = objDT.Rows[0][conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxPrjMenusV2EN.IsLeafNode = TransNullToBool(objDT.Rows[0][conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子(字段类型:bit,字段长度:1,是否可空:True)
 objQxPrjMenusV2EN.MenuSetId = objDT.Rows[0][conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id(字段类型:char,字段长度:4,是否可空:False)
 objQxPrjMenusV2EN.MenuIdOld = objDT.Rows[0][conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld(字段类型:char,字段长度:8,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjMenusV2EN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN()
{
createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(), //建立时间
updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(), //修改时间
id = TransNullToInt(objRow[conQxPrjMenusV2.id].ToString().Trim()), //id
parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()), //上级菜单Id
MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(), //菜单名
router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(), //链接文件
perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(), //链接文件
type = TransNullToInt(objRow[conQxPrjMenusV2.type].ToString().Trim()), //排序号
icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(), //链接文件
OrderNum = TransNullToInt(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()), //排序号
viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(), //图像文件
keepalive = TransNullToBool(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()), //是否在用
isShow = TransNullToBool(objRow[conQxPrjMenusV2.isShow].ToString().Trim()), //是否在用
isExt = TransNullToBool(objRow[conQxPrjMenusV2.isExt].ToString().Trim()), //是否在用
openMode = TransNullToInt(objRow[conQxPrjMenusV2.openMode].ToString().Trim()), //应用程序类型ID
QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(), //项目Id
UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(), //备注
LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(), //链接文件
UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(), //修改日期
MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(), //MenuControlName
ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(), //页面显示模式Id
InUse = TransNullToBool(objRow[conQxPrjMenusV2.InUse].ToString().Trim()), //是否在用
qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(), //qs参数
ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(), //图像文件
TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(), //表ID
RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(), //角色Id
IsLeafNode = TransNullToBool(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(), //菜单集Id
MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim() //MenuIdOld
};
objQxPrjMenusV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjMenusV2EN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxPrjMenusV2DA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxPrjMenusV2EN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxPrjMenusV2_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN()
{
createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(), //建立时间
updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(), //修改时间
id = TransNullToInt(objRow[conQxPrjMenusV2.id].ToString().Trim()), //id
parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()), //上级菜单Id
MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(), //菜单名
router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(), //链接文件
perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(), //链接文件
type = TransNullToInt(objRow[conQxPrjMenusV2.type].ToString().Trim()), //排序号
icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(), //链接文件
OrderNum = TransNullToInt(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()), //排序号
viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(), //图像文件
keepalive = TransNullToBool(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()), //是否在用
isShow = TransNullToBool(objRow[conQxPrjMenusV2.isShow].ToString().Trim()), //是否在用
isExt = TransNullToBool(objRow[conQxPrjMenusV2.isExt].ToString().Trim()), //是否在用
openMode = TransNullToInt(objRow[conQxPrjMenusV2.openMode].ToString().Trim()), //应用程序类型ID
QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(), //项目Id
UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(), //备注
LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(), //链接文件
UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(), //修改日期
MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(), //MenuControlName
ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(), //菜单标题
PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(), //页面显示模式Id
InUse = TransNullToBool(objRow[conQxPrjMenusV2.InUse].ToString().Trim()), //是否在用
qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(), //qs参数
ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(), //图像文件
TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(), //表ID
RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(), //角色Id
IsLeafNode = TransNullToBool(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()), //是否叶子
MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(), //菜单集Id
MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim() //MenuIdOld
};
objQxPrjMenusV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjMenusV2EN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxPrjMenusV2EN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = TransNullToInt(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = TransNullToInt(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = TransNullToInt(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = TransNullToBool(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = TransNullToBool(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = TransNullToBool(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = TransNullToInt(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = TransNullToBool(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = TransNullToBool(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxPrjMenusV2DA: GetObjByDataRowQxPrjMenusV2)", objException.Message));
}
objQxPrjMenusV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjMenusV2EN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxPrjMenusV2EN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = TransNullToInt(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = TransNullToInt(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = TransNullToInt(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = TransNullToBool(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = TransNullToBool(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = TransNullToBool(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = TransNullToInt(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = TransNullToBool(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = TransNullToBool(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxPrjMenusV2DA: GetObjByDataRow)", objException.Message));
}
objQxPrjMenusV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxPrjMenusV2EN;
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
objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjMenusV2EN._CurrTabName, conQxPrjMenusV2.id, 4, "");
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
objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxPrjMenusV2EN._CurrTabName, conQxPrjMenusV2.id, 4, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public int GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select id from QxPrjMenusV2 where " + strCondition;
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
return int.Parse(strKeyValue);
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
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select id from QxPrjMenusV2 where " + strCondition;
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
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(int intid)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjMenusV2", "id = " + ""+ intid+""))
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
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(int intid)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
intid,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxPrjMenusV2_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxPrjMenusV2", strCondition))
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
objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxPrjMenusV2");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
 {
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjMenusV2EN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjMenusV2");
objRow = objDS.Tables["QxPrjMenusV2"].NewRow();
 if (objQxPrjMenusV2EN.createdAt !=  "")
 {
objRow[conQxPrjMenusV2.createdAt] = objQxPrjMenusV2EN.createdAt; //建立时间
 }
 if (objQxPrjMenusV2EN.updatedAt !=  "")
 {
objRow[conQxPrjMenusV2.updatedAt] = objQxPrjMenusV2EN.updatedAt; //修改时间
 }
objRow[conQxPrjMenusV2.parentMenuId] = objQxPrjMenusV2EN.parentMenuId; //上级菜单Id
objRow[conQxPrjMenusV2.MenuName] = objQxPrjMenusV2EN.MenuName; //菜单名
 if (objQxPrjMenusV2EN.router !=  "")
 {
objRow[conQxPrjMenusV2.router] = objQxPrjMenusV2EN.router; //链接文件
 }
 if (objQxPrjMenusV2EN.perms !=  "")
 {
objRow[conQxPrjMenusV2.perms] = objQxPrjMenusV2EN.perms; //链接文件
 }
objRow[conQxPrjMenusV2.type] = objQxPrjMenusV2EN.type; //排序号
 if (objQxPrjMenusV2EN.icon !=  "")
 {
objRow[conQxPrjMenusV2.icon] = objQxPrjMenusV2EN.icon; //链接文件
 }
objRow[conQxPrjMenusV2.OrderNum] = objQxPrjMenusV2EN.OrderNum; //排序号
 if (objQxPrjMenusV2EN.viewPath !=  "")
 {
objRow[conQxPrjMenusV2.viewPath] = objQxPrjMenusV2EN.viewPath; //图像文件
 }
objRow[conQxPrjMenusV2.keepalive] = objQxPrjMenusV2EN.keepalive; //是否在用
objRow[conQxPrjMenusV2.isShow] = objQxPrjMenusV2EN.isShow; //是否在用
objRow[conQxPrjMenusV2.isExt] = objQxPrjMenusV2EN.isExt; //是否在用
objRow[conQxPrjMenusV2.openMode] = objQxPrjMenusV2EN.openMode; //应用程序类型ID
 if (objQxPrjMenusV2EN.QxPrjId !=  "")
 {
objRow[conQxPrjMenusV2.QxPrjId] = objQxPrjMenusV2EN.QxPrjId; //项目Id
 }
 if (objQxPrjMenusV2EN.UpdUserId !=  "")
 {
objRow[conQxPrjMenusV2.UpdUserId] = objQxPrjMenusV2EN.UpdUserId; //修改用户Id
 }
 if (objQxPrjMenusV2EN.Memo !=  "")
 {
objRow[conQxPrjMenusV2.Memo] = objQxPrjMenusV2EN.Memo; //备注
 }
 if (objQxPrjMenusV2EN.LinkFile !=  "")
 {
objRow[conQxPrjMenusV2.LinkFile] = objQxPrjMenusV2EN.LinkFile; //链接文件
 }
 if (objQxPrjMenusV2EN.UpdDate !=  "")
 {
objRow[conQxPrjMenusV2.UpdDate] = objQxPrjMenusV2EN.UpdDate; //修改日期
 }
 if (objQxPrjMenusV2EN.MenuControlName !=  "")
 {
objRow[conQxPrjMenusV2.MenuControlName] = objQxPrjMenusV2EN.MenuControlName; //MenuControlName
 }
objRow[conQxPrjMenusV2.ApplicationTypeId] = objQxPrjMenusV2EN.ApplicationTypeId; //应用程序类型ID
 if (objQxPrjMenusV2EN.MenuTitle !=  "")
 {
objRow[conQxPrjMenusV2.MenuTitle] = objQxPrjMenusV2EN.MenuTitle; //菜单标题
 }
 if (objQxPrjMenusV2EN.PageDispModeId !=  "")
 {
objRow[conQxPrjMenusV2.PageDispModeId] = objQxPrjMenusV2EN.PageDispModeId; //页面显示模式Id
 }
objRow[conQxPrjMenusV2.InUse] = objQxPrjMenusV2EN.InUse; //是否在用
 if (objQxPrjMenusV2EN.qsParameters !=  "")
 {
objRow[conQxPrjMenusV2.qsParameters] = objQxPrjMenusV2EN.qsParameters; //qs参数
 }
 if (objQxPrjMenusV2EN.ImgFile !=  "")
 {
objRow[conQxPrjMenusV2.ImgFile] = objQxPrjMenusV2EN.ImgFile; //图像文件
 }
 if (objQxPrjMenusV2EN.TabId !=  "")
 {
objRow[conQxPrjMenusV2.TabId] = objQxPrjMenusV2EN.TabId; //表ID
 }
 if (objQxPrjMenusV2EN.RoleId !=  "")
 {
objRow[conQxPrjMenusV2.RoleId] = objQxPrjMenusV2EN.RoleId; //角色Id
 }
objRow[conQxPrjMenusV2.IsLeafNode] = objQxPrjMenusV2EN.IsLeafNode; //是否叶子
 if (objQxPrjMenusV2EN.MenuSetId !=  "")
 {
objRow[conQxPrjMenusV2.MenuSetId] = objQxPrjMenusV2EN.MenuSetId; //菜单集Id
 }
 if (objQxPrjMenusV2EN.MenuIdOld !=  "")
 {
objRow[conQxPrjMenusV2.MenuIdOld] = objQxPrjMenusV2EN.MenuIdOld; //MenuIdOld
 }
objDS.Tables[clsQxPrjMenusV2EN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxPrjMenusV2EN._CurrTabName);
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
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjMenusV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjMenusV2EN.createdAt !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.createdAt);
 var strcreatedAt = objQxPrjMenusV2EN.createdAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreatedAt + "'");
 }
 
 if (objQxPrjMenusV2EN.updatedAt !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.updatedAt);
 var strupdatedAt = objQxPrjMenusV2EN.updatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdatedAt + "'");
 }
 
 
 if (objQxPrjMenusV2EN.parentMenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.parentMenuId);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.parentMenuId.ToString());
 }
 
 if (objQxPrjMenusV2EN.MenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuName);
 var strMenuName = objQxPrjMenusV2EN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuName + "'");
 }
 
 if (objQxPrjMenusV2EN.router !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.router);
 var strrouter = objQxPrjMenusV2EN.router.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strrouter + "'");
 }
 
 if (objQxPrjMenusV2EN.perms !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.perms);
 var strperms = objQxPrjMenusV2EN.perms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strperms + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.type);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.type.ToString());
 
 if (objQxPrjMenusV2EN.icon !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.icon);
 var stricon = objQxPrjMenusV2EN.icon.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + stricon + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.OrderNum);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.OrderNum.ToString());
 
 if (objQxPrjMenusV2EN.viewPath !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.viewPath);
 var strviewPath = objQxPrjMenusV2EN.viewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strviewPath + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.keepalive);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.keepalive  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.isShow);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.isShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.isExt);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.isExt  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.openMode);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.openMode.ToString());
 
 if (objQxPrjMenusV2EN.QxPrjId  ==  "")
 {
 objQxPrjMenusV2EN.QxPrjId = null;
 }
 if (objQxPrjMenusV2EN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.QxPrjId);
 var strQxPrjId = objQxPrjMenusV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjMenusV2EN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.UpdUserId);
 var strUpdUserId = objQxPrjMenusV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjMenusV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.Memo);
 var strMemo = objQxPrjMenusV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxPrjMenusV2EN.LinkFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.LinkFile);
 var strLinkFile = objQxPrjMenusV2EN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkFile + "'");
 }
 
 if (objQxPrjMenusV2EN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.UpdDate);
 var strUpdDate = objQxPrjMenusV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjMenusV2EN.MenuControlName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuControlName);
 var strMenuControlName = objQxPrjMenusV2EN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuControlName + "'");
 }
 
 if (objQxPrjMenusV2EN.ApplicationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.ApplicationTypeId);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.ApplicationTypeId.ToString());
 }
 
 if (objQxPrjMenusV2EN.MenuTitle !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuTitle);
 var strMenuTitle = objQxPrjMenusV2EN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuTitle + "'");
 }
 
 if (objQxPrjMenusV2EN.PageDispModeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.PageDispModeId);
 var strPageDispModeId = objQxPrjMenusV2EN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageDispModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.InUse);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusV2EN.qsParameters !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.qsParameters);
 var strqsParameters = objQxPrjMenusV2EN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strqsParameters + "'");
 }
 
 if (objQxPrjMenusV2EN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.ImgFile);
 var strImgFile = objQxPrjMenusV2EN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 if (objQxPrjMenusV2EN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.TabId);
 var strTabId = objQxPrjMenusV2EN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objQxPrjMenusV2EN.RoleId  ==  "")
 {
 objQxPrjMenusV2EN.RoleId = null;
 }
 if (objQxPrjMenusV2EN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.RoleId);
 var strRoleId = objQxPrjMenusV2EN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.IsLeafNode);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.IsLeafNode  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusV2EN.MenuSetId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuSetId);
 var strMenuSetId = objQxPrjMenusV2EN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuSetId + "'");
 }
 
 if (objQxPrjMenusV2EN.MenuIdOld !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuIdOld);
 var strMenuIdOld = objQxPrjMenusV2EN.MenuIdOld.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuIdOld + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjMenusV2");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjMenusV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjMenusV2EN.createdAt !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.createdAt);
 var strcreatedAt = objQxPrjMenusV2EN.createdAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreatedAt + "'");
 }
 
 if (objQxPrjMenusV2EN.updatedAt !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.updatedAt);
 var strupdatedAt = objQxPrjMenusV2EN.updatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdatedAt + "'");
 }
 
 
 if (objQxPrjMenusV2EN.parentMenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.parentMenuId);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.parentMenuId.ToString());
 }
 
 if (objQxPrjMenusV2EN.MenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuName);
 var strMenuName = objQxPrjMenusV2EN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuName + "'");
 }
 
 if (objQxPrjMenusV2EN.router !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.router);
 var strrouter = objQxPrjMenusV2EN.router.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strrouter + "'");
 }
 
 if (objQxPrjMenusV2EN.perms !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.perms);
 var strperms = objQxPrjMenusV2EN.perms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strperms + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.type);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.type.ToString());
 
 if (objQxPrjMenusV2EN.icon !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.icon);
 var stricon = objQxPrjMenusV2EN.icon.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + stricon + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.OrderNum);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.OrderNum.ToString());
 
 if (objQxPrjMenusV2EN.viewPath !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.viewPath);
 var strviewPath = objQxPrjMenusV2EN.viewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strviewPath + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.keepalive);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.keepalive  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.isShow);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.isShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.isExt);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.isExt  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.openMode);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.openMode.ToString());
 
 if (objQxPrjMenusV2EN.QxPrjId  ==  "")
 {
 objQxPrjMenusV2EN.QxPrjId = null;
 }
 if (objQxPrjMenusV2EN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.QxPrjId);
 var strQxPrjId = objQxPrjMenusV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjMenusV2EN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.UpdUserId);
 var strUpdUserId = objQxPrjMenusV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjMenusV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.Memo);
 var strMemo = objQxPrjMenusV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxPrjMenusV2EN.LinkFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.LinkFile);
 var strLinkFile = objQxPrjMenusV2EN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkFile + "'");
 }
 
 if (objQxPrjMenusV2EN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.UpdDate);
 var strUpdDate = objQxPrjMenusV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjMenusV2EN.MenuControlName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuControlName);
 var strMenuControlName = objQxPrjMenusV2EN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuControlName + "'");
 }
 
 if (objQxPrjMenusV2EN.ApplicationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.ApplicationTypeId);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.ApplicationTypeId.ToString());
 }
 
 if (objQxPrjMenusV2EN.MenuTitle !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuTitle);
 var strMenuTitle = objQxPrjMenusV2EN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuTitle + "'");
 }
 
 if (objQxPrjMenusV2EN.PageDispModeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.PageDispModeId);
 var strPageDispModeId = objQxPrjMenusV2EN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageDispModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.InUse);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusV2EN.qsParameters !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.qsParameters);
 var strqsParameters = objQxPrjMenusV2EN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strqsParameters + "'");
 }
 
 if (objQxPrjMenusV2EN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.ImgFile);
 var strImgFile = objQxPrjMenusV2EN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 if (objQxPrjMenusV2EN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.TabId);
 var strTabId = objQxPrjMenusV2EN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objQxPrjMenusV2EN.RoleId  ==  "")
 {
 objQxPrjMenusV2EN.RoleId = null;
 }
 if (objQxPrjMenusV2EN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.RoleId);
 var strRoleId = objQxPrjMenusV2EN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.IsLeafNode);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.IsLeafNode  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusV2EN.MenuSetId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuSetId);
 var strMenuSetId = objQxPrjMenusV2EN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuSetId + "'");
 }
 
 if (objQxPrjMenusV2EN.MenuIdOld !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuIdOld);
 var strMenuIdOld = objQxPrjMenusV2EN.MenuIdOld.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuIdOld + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjMenusV2");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxPrjMenusV2EN objQxPrjMenusV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjMenusV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjMenusV2EN.createdAt !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.createdAt);
 var strcreatedAt = objQxPrjMenusV2EN.createdAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreatedAt + "'");
 }
 
 if (objQxPrjMenusV2EN.updatedAt !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.updatedAt);
 var strupdatedAt = objQxPrjMenusV2EN.updatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdatedAt + "'");
 }
 
 
 if (objQxPrjMenusV2EN.parentMenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.parentMenuId);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.parentMenuId.ToString());
 }
 
 if (objQxPrjMenusV2EN.MenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuName);
 var strMenuName = objQxPrjMenusV2EN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuName + "'");
 }
 
 if (objQxPrjMenusV2EN.router !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.router);
 var strrouter = objQxPrjMenusV2EN.router.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strrouter + "'");
 }
 
 if (objQxPrjMenusV2EN.perms !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.perms);
 var strperms = objQxPrjMenusV2EN.perms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strperms + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.type);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.type.ToString());
 
 if (objQxPrjMenusV2EN.icon !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.icon);
 var stricon = objQxPrjMenusV2EN.icon.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + stricon + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.OrderNum);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.OrderNum.ToString());
 
 if (objQxPrjMenusV2EN.viewPath !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.viewPath);
 var strviewPath = objQxPrjMenusV2EN.viewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strviewPath + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.keepalive);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.keepalive  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.isShow);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.isShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.isExt);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.isExt  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.openMode);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.openMode.ToString());
 
 if (objQxPrjMenusV2EN.QxPrjId  ==  "")
 {
 objQxPrjMenusV2EN.QxPrjId = null;
 }
 if (objQxPrjMenusV2EN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.QxPrjId);
 var strQxPrjId = objQxPrjMenusV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjMenusV2EN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.UpdUserId);
 var strUpdUserId = objQxPrjMenusV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjMenusV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.Memo);
 var strMemo = objQxPrjMenusV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxPrjMenusV2EN.LinkFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.LinkFile);
 var strLinkFile = objQxPrjMenusV2EN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkFile + "'");
 }
 
 if (objQxPrjMenusV2EN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.UpdDate);
 var strUpdDate = objQxPrjMenusV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjMenusV2EN.MenuControlName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuControlName);
 var strMenuControlName = objQxPrjMenusV2EN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuControlName + "'");
 }
 
 if (objQxPrjMenusV2EN.ApplicationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.ApplicationTypeId);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.ApplicationTypeId.ToString());
 }
 
 if (objQxPrjMenusV2EN.MenuTitle !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuTitle);
 var strMenuTitle = objQxPrjMenusV2EN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuTitle + "'");
 }
 
 if (objQxPrjMenusV2EN.PageDispModeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.PageDispModeId);
 var strPageDispModeId = objQxPrjMenusV2EN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageDispModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.InUse);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusV2EN.qsParameters !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.qsParameters);
 var strqsParameters = objQxPrjMenusV2EN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strqsParameters + "'");
 }
 
 if (objQxPrjMenusV2EN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.ImgFile);
 var strImgFile = objQxPrjMenusV2EN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 if (objQxPrjMenusV2EN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.TabId);
 var strTabId = objQxPrjMenusV2EN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objQxPrjMenusV2EN.RoleId  ==  "")
 {
 objQxPrjMenusV2EN.RoleId = null;
 }
 if (objQxPrjMenusV2EN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.RoleId);
 var strRoleId = objQxPrjMenusV2EN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.IsLeafNode);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.IsLeafNode  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusV2EN.MenuSetId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuSetId);
 var strMenuSetId = objQxPrjMenusV2EN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuSetId + "'");
 }
 
 if (objQxPrjMenusV2EN.MenuIdOld !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuIdOld);
 var strMenuIdOld = objQxPrjMenusV2EN.MenuIdOld.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuIdOld + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjMenusV2");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxPrjMenusV2EN objQxPrjMenusV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxPrjMenusV2EN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxPrjMenusV2EN.createdAt !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.createdAt);
 var strcreatedAt = objQxPrjMenusV2EN.createdAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreatedAt + "'");
 }
 
 if (objQxPrjMenusV2EN.updatedAt !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.updatedAt);
 var strupdatedAt = objQxPrjMenusV2EN.updatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdatedAt + "'");
 }
 
 
 if (objQxPrjMenusV2EN.parentMenuId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.parentMenuId);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.parentMenuId.ToString());
 }
 
 if (objQxPrjMenusV2EN.MenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuName);
 var strMenuName = objQxPrjMenusV2EN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuName + "'");
 }
 
 if (objQxPrjMenusV2EN.router !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.router);
 var strrouter = objQxPrjMenusV2EN.router.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strrouter + "'");
 }
 
 if (objQxPrjMenusV2EN.perms !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.perms);
 var strperms = objQxPrjMenusV2EN.perms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strperms + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.type);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.type.ToString());
 
 if (objQxPrjMenusV2EN.icon !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.icon);
 var stricon = objQxPrjMenusV2EN.icon.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + stricon + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.OrderNum);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.OrderNum.ToString());
 
 if (objQxPrjMenusV2EN.viewPath !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.viewPath);
 var strviewPath = objQxPrjMenusV2EN.viewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strviewPath + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.keepalive);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.keepalive  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.isShow);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.isShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.isExt);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.isExt  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.openMode);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.openMode.ToString());
 
 if (objQxPrjMenusV2EN.QxPrjId  ==  "")
 {
 objQxPrjMenusV2EN.QxPrjId = null;
 }
 if (objQxPrjMenusV2EN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.QxPrjId);
 var strQxPrjId = objQxPrjMenusV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxPrjMenusV2EN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.UpdUserId);
 var strUpdUserId = objQxPrjMenusV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxPrjMenusV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.Memo);
 var strMemo = objQxPrjMenusV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxPrjMenusV2EN.LinkFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.LinkFile);
 var strLinkFile = objQxPrjMenusV2EN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkFile + "'");
 }
 
 if (objQxPrjMenusV2EN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.UpdDate);
 var strUpdDate = objQxPrjMenusV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxPrjMenusV2EN.MenuControlName !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuControlName);
 var strMenuControlName = objQxPrjMenusV2EN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuControlName + "'");
 }
 
 if (objQxPrjMenusV2EN.ApplicationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.ApplicationTypeId);
 arrValueListForInsert.Add(objQxPrjMenusV2EN.ApplicationTypeId.ToString());
 }
 
 if (objQxPrjMenusV2EN.MenuTitle !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuTitle);
 var strMenuTitle = objQxPrjMenusV2EN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuTitle + "'");
 }
 
 if (objQxPrjMenusV2EN.PageDispModeId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.PageDispModeId);
 var strPageDispModeId = objQxPrjMenusV2EN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageDispModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.InUse);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusV2EN.qsParameters !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.qsParameters);
 var strqsParameters = objQxPrjMenusV2EN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strqsParameters + "'");
 }
 
 if (objQxPrjMenusV2EN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.ImgFile);
 var strImgFile = objQxPrjMenusV2EN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 if (objQxPrjMenusV2EN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.TabId);
 var strTabId = objQxPrjMenusV2EN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objQxPrjMenusV2EN.RoleId  ==  "")
 {
 objQxPrjMenusV2EN.RoleId = null;
 }
 if (objQxPrjMenusV2EN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.RoleId);
 var strRoleId = objQxPrjMenusV2EN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 arrFieldListForInsert.Add(conQxPrjMenusV2.IsLeafNode);
 arrValueListForInsert.Add("'" + (objQxPrjMenusV2EN.IsLeafNode  ==  false ? "0" : "1") + "'");
 
 if (objQxPrjMenusV2EN.MenuSetId !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuSetId);
 var strMenuSetId = objQxPrjMenusV2EN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuSetId + "'");
 }
 
 if (objQxPrjMenusV2EN.MenuIdOld !=  null)
 {
 arrFieldListForInsert.Add(conQxPrjMenusV2.MenuIdOld);
 var strMenuIdOld = objQxPrjMenusV2EN.MenuIdOld.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMenuIdOld + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxPrjMenusV2");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxPrjMenusV2BySP(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
//通过存储过程来
//直接使用
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjMenusV2EN.createdAt,
 objQxPrjMenusV2EN.updatedAt,
 objQxPrjMenusV2EN.parentMenuId,
 objQxPrjMenusV2EN.MenuName,
 objQxPrjMenusV2EN.router,
 objQxPrjMenusV2EN.perms,
 objQxPrjMenusV2EN.type,
 objQxPrjMenusV2EN.icon,
 objQxPrjMenusV2EN.OrderNum,
 objQxPrjMenusV2EN.viewPath,
 objQxPrjMenusV2EN.keepalive,
 objQxPrjMenusV2EN.isShow,
 objQxPrjMenusV2EN.isExt,
 objQxPrjMenusV2EN.openMode,
 objQxPrjMenusV2EN.QxPrjId,
 objQxPrjMenusV2EN.UpdUserId,
 objQxPrjMenusV2EN.Memo,
 objQxPrjMenusV2EN.LinkFile,
 objQxPrjMenusV2EN.UpdDate,
 objQxPrjMenusV2EN.MenuControlName,
 objQxPrjMenusV2EN.ApplicationTypeId,
 objQxPrjMenusV2EN.MenuTitle,
 objQxPrjMenusV2EN.PageDispModeId,
 objQxPrjMenusV2EN.InUse,
 objQxPrjMenusV2EN.qsParameters,
 objQxPrjMenusV2EN.ImgFile,
 objQxPrjMenusV2EN.TabId,
 objQxPrjMenusV2EN.RoleId,
 objQxPrjMenusV2EN.IsLeafNode,
 objQxPrjMenusV2EN.MenuSetId,
objQxPrjMenusV2EN.MenuIdOld
};
 objSQL.ExecSP("QxPrjMenusV2_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxPrjMenusV2s(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where id = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxPrjMenusV2");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
int intid = TransNullToInt(oRow[conQxPrjMenusV2.id].ToString().Trim());
if (IsExist(intid))
{
 string strResult = "关键字变量值为:" + string.Format("id = {0}", intid) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxPrjMenusV2EN._CurrTabName ].NewRow();
objRow[conQxPrjMenusV2.createdAt] = oRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objRow[conQxPrjMenusV2.updatedAt] = oRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objRow[conQxPrjMenusV2.parentMenuId] = oRow[conQxPrjMenusV2.parentMenuId].ToString().Trim(); //上级菜单Id
objRow[conQxPrjMenusV2.MenuName] = oRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objRow[conQxPrjMenusV2.router] = oRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objRow[conQxPrjMenusV2.perms] = oRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objRow[conQxPrjMenusV2.type] = oRow[conQxPrjMenusV2.type].ToString().Trim(); //排序号
objRow[conQxPrjMenusV2.icon] = oRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objRow[conQxPrjMenusV2.OrderNum] = oRow[conQxPrjMenusV2.OrderNum].ToString().Trim(); //排序号
objRow[conQxPrjMenusV2.viewPath] = oRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objRow[conQxPrjMenusV2.keepalive] = oRow[conQxPrjMenusV2.keepalive].ToString().Trim(); //是否在用
objRow[conQxPrjMenusV2.isShow] = oRow[conQxPrjMenusV2.isShow].ToString().Trim(); //是否在用
objRow[conQxPrjMenusV2.isExt] = oRow[conQxPrjMenusV2.isExt].ToString().Trim(); //是否在用
objRow[conQxPrjMenusV2.openMode] = oRow[conQxPrjMenusV2.openMode].ToString().Trim(); //应用程序类型ID
objRow[conQxPrjMenusV2.QxPrjId] = oRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxPrjMenusV2.UpdUserId] = oRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conQxPrjMenusV2.Memo] = oRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objRow[conQxPrjMenusV2.LinkFile] = oRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objRow[conQxPrjMenusV2.UpdDate] = oRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objRow[conQxPrjMenusV2.MenuControlName] = oRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objRow[conQxPrjMenusV2.ApplicationTypeId] = oRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim(); //应用程序类型ID
objRow[conQxPrjMenusV2.MenuTitle] = oRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objRow[conQxPrjMenusV2.PageDispModeId] = oRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objRow[conQxPrjMenusV2.InUse] = oRow[conQxPrjMenusV2.InUse].ToString().Trim(); //是否在用
objRow[conQxPrjMenusV2.qsParameters] = oRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objRow[conQxPrjMenusV2.ImgFile] = oRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objRow[conQxPrjMenusV2.TabId] = oRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objRow[conQxPrjMenusV2.RoleId] = oRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objRow[conQxPrjMenusV2.IsLeafNode] = oRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim(); //是否叶子
objRow[conQxPrjMenusV2.MenuSetId] = oRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objRow[conQxPrjMenusV2.MenuIdOld] = oRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
 objDS.Tables[clsQxPrjMenusV2EN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxPrjMenusV2EN._CurrTabName);
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
 /// <param name = "objQxPrjMenusV2EN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusV2EN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
strSQL = "Select * from QxPrjMenusV2 where id = " + ""+ objQxPrjMenusV2EN.id+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxPrjMenusV2EN._CurrTabName);
if (objDS.Tables[clsQxPrjMenusV2EN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:id = " + ""+ objQxPrjMenusV2EN.id+"");
return false;
}
objRow = objDS.Tables[clsQxPrjMenusV2EN._CurrTabName].Rows[0];
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.createdAt))
 {
objRow[conQxPrjMenusV2.createdAt] = objQxPrjMenusV2EN.createdAt; //建立时间
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.updatedAt))
 {
objRow[conQxPrjMenusV2.updatedAt] = objQxPrjMenusV2EN.updatedAt; //修改时间
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.parentMenuId))
 {
objRow[conQxPrjMenusV2.parentMenuId] = objQxPrjMenusV2EN.parentMenuId; //上级菜单Id
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuName))
 {
objRow[conQxPrjMenusV2.MenuName] = objQxPrjMenusV2EN.MenuName; //菜单名
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.router))
 {
objRow[conQxPrjMenusV2.router] = objQxPrjMenusV2EN.router; //链接文件
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.perms))
 {
objRow[conQxPrjMenusV2.perms] = objQxPrjMenusV2EN.perms; //链接文件
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.type))
 {
objRow[conQxPrjMenusV2.type] = objQxPrjMenusV2EN.type; //排序号
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.icon))
 {
objRow[conQxPrjMenusV2.icon] = objQxPrjMenusV2EN.icon; //链接文件
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.OrderNum))
 {
objRow[conQxPrjMenusV2.OrderNum] = objQxPrjMenusV2EN.OrderNum; //排序号
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.viewPath))
 {
objRow[conQxPrjMenusV2.viewPath] = objQxPrjMenusV2EN.viewPath; //图像文件
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.keepalive))
 {
objRow[conQxPrjMenusV2.keepalive] = objQxPrjMenusV2EN.keepalive; //是否在用
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.isShow))
 {
objRow[conQxPrjMenusV2.isShow] = objQxPrjMenusV2EN.isShow; //是否在用
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.isExt))
 {
objRow[conQxPrjMenusV2.isExt] = objQxPrjMenusV2EN.isExt; //是否在用
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.openMode))
 {
objRow[conQxPrjMenusV2.openMode] = objQxPrjMenusV2EN.openMode; //应用程序类型ID
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.QxPrjId))
 {
objRow[conQxPrjMenusV2.QxPrjId] = objQxPrjMenusV2EN.QxPrjId; //项目Id
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.UpdUserId))
 {
objRow[conQxPrjMenusV2.UpdUserId] = objQxPrjMenusV2EN.UpdUserId; //修改用户Id
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.Memo))
 {
objRow[conQxPrjMenusV2.Memo] = objQxPrjMenusV2EN.Memo; //备注
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.LinkFile))
 {
objRow[conQxPrjMenusV2.LinkFile] = objQxPrjMenusV2EN.LinkFile; //链接文件
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.UpdDate))
 {
objRow[conQxPrjMenusV2.UpdDate] = objQxPrjMenusV2EN.UpdDate; //修改日期
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuControlName))
 {
objRow[conQxPrjMenusV2.MenuControlName] = objQxPrjMenusV2EN.MenuControlName; //MenuControlName
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.ApplicationTypeId))
 {
objRow[conQxPrjMenusV2.ApplicationTypeId] = objQxPrjMenusV2EN.ApplicationTypeId; //应用程序类型ID
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuTitle))
 {
objRow[conQxPrjMenusV2.MenuTitle] = objQxPrjMenusV2EN.MenuTitle; //菜单标题
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.PageDispModeId))
 {
objRow[conQxPrjMenusV2.PageDispModeId] = objQxPrjMenusV2EN.PageDispModeId; //页面显示模式Id
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.InUse))
 {
objRow[conQxPrjMenusV2.InUse] = objQxPrjMenusV2EN.InUse; //是否在用
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.qsParameters))
 {
objRow[conQxPrjMenusV2.qsParameters] = objQxPrjMenusV2EN.qsParameters; //qs参数
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.ImgFile))
 {
objRow[conQxPrjMenusV2.ImgFile] = objQxPrjMenusV2EN.ImgFile; //图像文件
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.TabId))
 {
objRow[conQxPrjMenusV2.TabId] = objQxPrjMenusV2EN.TabId; //表ID
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.RoleId))
 {
objRow[conQxPrjMenusV2.RoleId] = objQxPrjMenusV2EN.RoleId; //角色Id
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.IsLeafNode))
 {
objRow[conQxPrjMenusV2.IsLeafNode] = objQxPrjMenusV2EN.IsLeafNode; //是否叶子
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuSetId))
 {
objRow[conQxPrjMenusV2.MenuSetId] = objQxPrjMenusV2EN.MenuSetId; //菜单集Id
 }
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuIdOld))
 {
objRow[conQxPrjMenusV2.MenuIdOld] = objQxPrjMenusV2EN.MenuIdOld; //MenuIdOld
 }
try
{
objDA.Update(objDS, clsQxPrjMenusV2EN._CurrTabName);
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
public bool UpdateBySP(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusV2EN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxPrjMenusV2EN.createdAt,
 objQxPrjMenusV2EN.updatedAt,
 objQxPrjMenusV2EN.id,
 objQxPrjMenusV2EN.parentMenuId,
 objQxPrjMenusV2EN.MenuName,
 objQxPrjMenusV2EN.router,
 objQxPrjMenusV2EN.perms,
 objQxPrjMenusV2EN.type,
 objQxPrjMenusV2EN.icon,
 objQxPrjMenusV2EN.OrderNum,
 objQxPrjMenusV2EN.viewPath,
 objQxPrjMenusV2EN.keepalive,
 objQxPrjMenusV2EN.isShow,
 objQxPrjMenusV2EN.isExt,
 objQxPrjMenusV2EN.openMode,
 objQxPrjMenusV2EN.QxPrjId,
 objQxPrjMenusV2EN.UpdUserId,
 objQxPrjMenusV2EN.Memo,
 objQxPrjMenusV2EN.LinkFile,
 objQxPrjMenusV2EN.UpdDate,
 objQxPrjMenusV2EN.MenuControlName,
 objQxPrjMenusV2EN.ApplicationTypeId,
 objQxPrjMenusV2EN.MenuTitle,
 objQxPrjMenusV2EN.PageDispModeId,
 objQxPrjMenusV2EN.InUse,
 objQxPrjMenusV2EN.qsParameters,
 objQxPrjMenusV2EN.ImgFile,
 objQxPrjMenusV2EN.TabId,
 objQxPrjMenusV2EN.RoleId,
 objQxPrjMenusV2EN.IsLeafNode,
 objQxPrjMenusV2EN.MenuSetId,
 objQxPrjMenusV2EN.MenuIdOld
};
 objSQL.ExecSP("QxPrjMenusV2_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxPrjMenusV2 Set ");
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.createdAt))
 {
 if (objQxPrjMenusV2EN.createdAt !=  null)
 {
 var strcreatedAt = objQxPrjMenusV2EN.createdAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcreatedAt, conQxPrjMenusV2.createdAt); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.createdAt); //建立时间
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.updatedAt))
 {
 if (objQxPrjMenusV2EN.updatedAt !=  null)
 {
 var strupdatedAt = objQxPrjMenusV2EN.updatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strupdatedAt, conQxPrjMenusV2.updatedAt); //修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.updatedAt); //修改时间
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.parentMenuId))
 {
 if (objQxPrjMenusV2EN.parentMenuId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusV2EN.parentMenuId, conQxPrjMenusV2.parentMenuId); //上级菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.parentMenuId); //上级菜单Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuName))
 {
 if (objQxPrjMenusV2EN.MenuName !=  null)
 {
 var strMenuName = objQxPrjMenusV2EN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuName, conQxPrjMenusV2.MenuName); //菜单名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.MenuName); //菜单名
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.router))
 {
 if (objQxPrjMenusV2EN.router !=  null)
 {
 var strrouter = objQxPrjMenusV2EN.router.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strrouter, conQxPrjMenusV2.router); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.router); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.perms))
 {
 if (objQxPrjMenusV2EN.perms !=  null)
 {
 var strperms = objQxPrjMenusV2EN.perms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strperms, conQxPrjMenusV2.perms); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.perms); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.type))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusV2EN.type, conQxPrjMenusV2.type); //排序号
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.icon))
 {
 if (objQxPrjMenusV2EN.icon !=  null)
 {
 var stricon = objQxPrjMenusV2EN.icon.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", stricon, conQxPrjMenusV2.icon); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.icon); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusV2EN.OrderNum, conQxPrjMenusV2.OrderNum); //排序号
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.viewPath))
 {
 if (objQxPrjMenusV2EN.viewPath !=  null)
 {
 var strviewPath = objQxPrjMenusV2EN.viewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strviewPath, conQxPrjMenusV2.viewPath); //图像文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.viewPath); //图像文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.keepalive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusV2EN.keepalive == true?"1":"0", conQxPrjMenusV2.keepalive); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.isShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusV2EN.isShow == true?"1":"0", conQxPrjMenusV2.isShow); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.isExt))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusV2EN.isExt == true?"1":"0", conQxPrjMenusV2.isExt); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.openMode))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusV2EN.openMode, conQxPrjMenusV2.openMode); //应用程序类型ID
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.QxPrjId))
 {
 if (objQxPrjMenusV2EN.QxPrjId  ==  "")
 {
 objQxPrjMenusV2EN.QxPrjId = null;
 }
 if (objQxPrjMenusV2EN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjMenusV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjMenusV2.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.UpdUserId))
 {
 if (objQxPrjMenusV2EN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjMenusV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjMenusV2.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.Memo))
 {
 if (objQxPrjMenusV2EN.Memo !=  null)
 {
 var strMemo = objQxPrjMenusV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjMenusV2.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.Memo); //备注
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.LinkFile))
 {
 if (objQxPrjMenusV2EN.LinkFile !=  null)
 {
 var strLinkFile = objQxPrjMenusV2EN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkFile, conQxPrjMenusV2.LinkFile); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.LinkFile); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.UpdDate))
 {
 if (objQxPrjMenusV2EN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjMenusV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjMenusV2.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuControlName))
 {
 if (objQxPrjMenusV2EN.MenuControlName !=  null)
 {
 var strMenuControlName = objQxPrjMenusV2EN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuControlName, conQxPrjMenusV2.MenuControlName); //MenuControlName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.MenuControlName); //MenuControlName
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.ApplicationTypeId))
 {
 if (objQxPrjMenusV2EN.ApplicationTypeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusV2EN.ApplicationTypeId, conQxPrjMenusV2.ApplicationTypeId); //应用程序类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.ApplicationTypeId); //应用程序类型ID
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuTitle))
 {
 if (objQxPrjMenusV2EN.MenuTitle !=  null)
 {
 var strMenuTitle = objQxPrjMenusV2EN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuTitle, conQxPrjMenusV2.MenuTitle); //菜单标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.MenuTitle); //菜单标题
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.PageDispModeId))
 {
 if (objQxPrjMenusV2EN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objQxPrjMenusV2EN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageDispModeId, conQxPrjMenusV2.PageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.PageDispModeId); //页面显示模式Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusV2EN.InUse == true?"1":"0", conQxPrjMenusV2.InUse); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.qsParameters))
 {
 if (objQxPrjMenusV2EN.qsParameters !=  null)
 {
 var strqsParameters = objQxPrjMenusV2EN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strqsParameters, conQxPrjMenusV2.qsParameters); //qs参数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.qsParameters); //qs参数
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.ImgFile))
 {
 if (objQxPrjMenusV2EN.ImgFile !=  null)
 {
 var strImgFile = objQxPrjMenusV2EN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImgFile, conQxPrjMenusV2.ImgFile); //图像文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.ImgFile); //图像文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.TabId))
 {
 if (objQxPrjMenusV2EN.TabId !=  null)
 {
 var strTabId = objQxPrjMenusV2EN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conQxPrjMenusV2.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.TabId); //表ID
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.RoleId))
 {
 if (objQxPrjMenusV2EN.RoleId  ==  "")
 {
 objQxPrjMenusV2EN.RoleId = null;
 }
 if (objQxPrjMenusV2EN.RoleId !=  null)
 {
 var strRoleId = objQxPrjMenusV2EN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQxPrjMenusV2.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.RoleId); //角色Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.IsLeafNode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusV2EN.IsLeafNode == true?"1":"0", conQxPrjMenusV2.IsLeafNode); //是否叶子
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuSetId))
 {
 if (objQxPrjMenusV2EN.MenuSetId !=  null)
 {
 var strMenuSetId = objQxPrjMenusV2EN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuSetId, conQxPrjMenusV2.MenuSetId); //菜单集Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.MenuSetId); //菜单集Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuIdOld))
 {
 if (objQxPrjMenusV2EN.MenuIdOld !=  null)
 {
 var strMenuIdOld = objQxPrjMenusV2EN.MenuIdOld.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuIdOld, conQxPrjMenusV2.MenuIdOld); //MenuIdOld
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.MenuIdOld); //MenuIdOld
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where id = {0}", objQxPrjMenusV2EN.id); 
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
 /// <param name = "objQxPrjMenusV2EN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strCondition)
{
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjMenusV2 Set ");
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.createdAt))
 {
 if (objQxPrjMenusV2EN.createdAt !=  null)
 {
 var strcreatedAt = objQxPrjMenusV2EN.createdAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" createdAt = '{0}',", strcreatedAt); //建立时间
 }
 else
 {
 sbSQL.Append(" createdAt = null,"); //建立时间
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.updatedAt))
 {
 if (objQxPrjMenusV2EN.updatedAt !=  null)
 {
 var strupdatedAt = objQxPrjMenusV2EN.updatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" updatedAt = '{0}',", strupdatedAt); //修改时间
 }
 else
 {
 sbSQL.Append(" updatedAt = null,"); //修改时间
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.parentMenuId))
 {
 sbSQL.AppendFormat(" parentMenuId = {0},", objQxPrjMenusV2EN.parentMenuId); //上级菜单Id
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuName))
 {
 if (objQxPrjMenusV2EN.MenuName !=  null)
 {
 var strMenuName = objQxPrjMenusV2EN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuName = '{0}',", strMenuName); //菜单名
 }
 else
 {
 sbSQL.Append(" MenuName = null,"); //菜单名
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.router))
 {
 if (objQxPrjMenusV2EN.router !=  null)
 {
 var strrouter = objQxPrjMenusV2EN.router.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" router = '{0}',", strrouter); //链接文件
 }
 else
 {
 sbSQL.Append(" router = null,"); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.perms))
 {
 if (objQxPrjMenusV2EN.perms !=  null)
 {
 var strperms = objQxPrjMenusV2EN.perms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" perms = '{0}',", strperms); //链接文件
 }
 else
 {
 sbSQL.Append(" perms = null,"); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.type))
 {
 sbSQL.AppendFormat(" type = {0},", objQxPrjMenusV2EN.type); //排序号
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.icon))
 {
 if (objQxPrjMenusV2EN.icon !=  null)
 {
 var stricon = objQxPrjMenusV2EN.icon.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" icon = '{0}',", stricon); //链接文件
 }
 else
 {
 sbSQL.Append(" icon = null,"); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxPrjMenusV2EN.OrderNum); //排序号
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.viewPath))
 {
 if (objQxPrjMenusV2EN.viewPath !=  null)
 {
 var strviewPath = objQxPrjMenusV2EN.viewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" viewPath = '{0}',", strviewPath); //图像文件
 }
 else
 {
 sbSQL.Append(" viewPath = null,"); //图像文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.keepalive))
 {
 sbSQL.AppendFormat(" keepalive = '{0}',", objQxPrjMenusV2EN.keepalive == true?"1":"0"); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.isShow))
 {
 sbSQL.AppendFormat(" isShow = '{0}',", objQxPrjMenusV2EN.isShow == true?"1":"0"); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.isExt))
 {
 sbSQL.AppendFormat(" isExt = '{0}',", objQxPrjMenusV2EN.isExt == true?"1":"0"); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.openMode))
 {
 sbSQL.AppendFormat(" openMode = {0},", objQxPrjMenusV2EN.openMode); //应用程序类型ID
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.QxPrjId))
 {
 if (objQxPrjMenusV2EN.QxPrjId  ==  "")
 {
 objQxPrjMenusV2EN.QxPrjId = null;
 }
 if (objQxPrjMenusV2EN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjMenusV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.UpdUserId))
 {
 if (objQxPrjMenusV2EN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjMenusV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.Memo))
 {
 if (objQxPrjMenusV2EN.Memo !=  null)
 {
 var strMemo = objQxPrjMenusV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.LinkFile))
 {
 if (objQxPrjMenusV2EN.LinkFile !=  null)
 {
 var strLinkFile = objQxPrjMenusV2EN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkFile = '{0}',", strLinkFile); //链接文件
 }
 else
 {
 sbSQL.Append(" LinkFile = null,"); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.UpdDate))
 {
 if (objQxPrjMenusV2EN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjMenusV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuControlName))
 {
 if (objQxPrjMenusV2EN.MenuControlName !=  null)
 {
 var strMenuControlName = objQxPrjMenusV2EN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuControlName = '{0}',", strMenuControlName); //MenuControlName
 }
 else
 {
 sbSQL.Append(" MenuControlName = null,"); //MenuControlName
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objQxPrjMenusV2EN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuTitle))
 {
 if (objQxPrjMenusV2EN.MenuTitle !=  null)
 {
 var strMenuTitle = objQxPrjMenusV2EN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuTitle = '{0}',", strMenuTitle); //菜单标题
 }
 else
 {
 sbSQL.Append(" MenuTitle = null,"); //菜单标题
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.PageDispModeId))
 {
 if (objQxPrjMenusV2EN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objQxPrjMenusV2EN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageDispModeId = '{0}',", strPageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.Append(" PageDispModeId = null,"); //页面显示模式Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxPrjMenusV2EN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.qsParameters))
 {
 if (objQxPrjMenusV2EN.qsParameters !=  null)
 {
 var strqsParameters = objQxPrjMenusV2EN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" qsParameters = '{0}',", strqsParameters); //qs参数
 }
 else
 {
 sbSQL.Append(" qsParameters = null,"); //qs参数
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.ImgFile))
 {
 if (objQxPrjMenusV2EN.ImgFile !=  null)
 {
 var strImgFile = objQxPrjMenusV2EN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImgFile = '{0}',", strImgFile); //图像文件
 }
 else
 {
 sbSQL.Append(" ImgFile = null,"); //图像文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.TabId))
 {
 if (objQxPrjMenusV2EN.TabId !=  null)
 {
 var strTabId = objQxPrjMenusV2EN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.RoleId))
 {
 if (objQxPrjMenusV2EN.RoleId  ==  "")
 {
 objQxPrjMenusV2EN.RoleId = null;
 }
 if (objQxPrjMenusV2EN.RoleId !=  null)
 {
 var strRoleId = objQxPrjMenusV2EN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.IsLeafNode))
 {
 sbSQL.AppendFormat(" IsLeafNode = '{0}',", objQxPrjMenusV2EN.IsLeafNode == true?"1":"0"); //是否叶子
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuSetId))
 {
 if (objQxPrjMenusV2EN.MenuSetId !=  null)
 {
 var strMenuSetId = objQxPrjMenusV2EN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuSetId = '{0}',", strMenuSetId); //菜单集Id
 }
 else
 {
 sbSQL.Append(" MenuSetId = null,"); //菜单集Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuIdOld))
 {
 if (objQxPrjMenusV2EN.MenuIdOld !=  null)
 {
 var strMenuIdOld = objQxPrjMenusV2EN.MenuIdOld.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuIdOld = '{0}',", strMenuIdOld); //MenuIdOld
 }
 else
 {
 sbSQL.Append(" MenuIdOld = null,"); //MenuIdOld
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
 /// <param name = "objQxPrjMenusV2EN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjMenusV2 Set ");
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.createdAt))
 {
 if (objQxPrjMenusV2EN.createdAt !=  null)
 {
 var strcreatedAt = objQxPrjMenusV2EN.createdAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" createdAt = '{0}',", strcreatedAt); //建立时间
 }
 else
 {
 sbSQL.Append(" createdAt = null,"); //建立时间
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.updatedAt))
 {
 if (objQxPrjMenusV2EN.updatedAt !=  null)
 {
 var strupdatedAt = objQxPrjMenusV2EN.updatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" updatedAt = '{0}',", strupdatedAt); //修改时间
 }
 else
 {
 sbSQL.Append(" updatedAt = null,"); //修改时间
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.parentMenuId))
 {
 sbSQL.AppendFormat(" parentMenuId = {0},", objQxPrjMenusV2EN.parentMenuId); //上级菜单Id
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuName))
 {
 if (objQxPrjMenusV2EN.MenuName !=  null)
 {
 var strMenuName = objQxPrjMenusV2EN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuName = '{0}',", strMenuName); //菜单名
 }
 else
 {
 sbSQL.Append(" MenuName = null,"); //菜单名
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.router))
 {
 if (objQxPrjMenusV2EN.router !=  null)
 {
 var strrouter = objQxPrjMenusV2EN.router.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" router = '{0}',", strrouter); //链接文件
 }
 else
 {
 sbSQL.Append(" router = null,"); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.perms))
 {
 if (objQxPrjMenusV2EN.perms !=  null)
 {
 var strperms = objQxPrjMenusV2EN.perms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" perms = '{0}',", strperms); //链接文件
 }
 else
 {
 sbSQL.Append(" perms = null,"); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.type))
 {
 sbSQL.AppendFormat(" type = {0},", objQxPrjMenusV2EN.type); //排序号
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.icon))
 {
 if (objQxPrjMenusV2EN.icon !=  null)
 {
 var stricon = objQxPrjMenusV2EN.icon.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" icon = '{0}',", stricon); //链接文件
 }
 else
 {
 sbSQL.Append(" icon = null,"); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxPrjMenusV2EN.OrderNum); //排序号
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.viewPath))
 {
 if (objQxPrjMenusV2EN.viewPath !=  null)
 {
 var strviewPath = objQxPrjMenusV2EN.viewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" viewPath = '{0}',", strviewPath); //图像文件
 }
 else
 {
 sbSQL.Append(" viewPath = null,"); //图像文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.keepalive))
 {
 sbSQL.AppendFormat(" keepalive = '{0}',", objQxPrjMenusV2EN.keepalive == true?"1":"0"); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.isShow))
 {
 sbSQL.AppendFormat(" isShow = '{0}',", objQxPrjMenusV2EN.isShow == true?"1":"0"); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.isExt))
 {
 sbSQL.AppendFormat(" isExt = '{0}',", objQxPrjMenusV2EN.isExt == true?"1":"0"); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.openMode))
 {
 sbSQL.AppendFormat(" openMode = {0},", objQxPrjMenusV2EN.openMode); //应用程序类型ID
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.QxPrjId))
 {
 if (objQxPrjMenusV2EN.QxPrjId  ==  "")
 {
 objQxPrjMenusV2EN.QxPrjId = null;
 }
 if (objQxPrjMenusV2EN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjMenusV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.UpdUserId))
 {
 if (objQxPrjMenusV2EN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjMenusV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.Memo))
 {
 if (objQxPrjMenusV2EN.Memo !=  null)
 {
 var strMemo = objQxPrjMenusV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.LinkFile))
 {
 if (objQxPrjMenusV2EN.LinkFile !=  null)
 {
 var strLinkFile = objQxPrjMenusV2EN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkFile = '{0}',", strLinkFile); //链接文件
 }
 else
 {
 sbSQL.Append(" LinkFile = null,"); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.UpdDate))
 {
 if (objQxPrjMenusV2EN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjMenusV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuControlName))
 {
 if (objQxPrjMenusV2EN.MenuControlName !=  null)
 {
 var strMenuControlName = objQxPrjMenusV2EN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuControlName = '{0}',", strMenuControlName); //MenuControlName
 }
 else
 {
 sbSQL.Append(" MenuControlName = null,"); //MenuControlName
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objQxPrjMenusV2EN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuTitle))
 {
 if (objQxPrjMenusV2EN.MenuTitle !=  null)
 {
 var strMenuTitle = objQxPrjMenusV2EN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuTitle = '{0}',", strMenuTitle); //菜单标题
 }
 else
 {
 sbSQL.Append(" MenuTitle = null,"); //菜单标题
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.PageDispModeId))
 {
 if (objQxPrjMenusV2EN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objQxPrjMenusV2EN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageDispModeId = '{0}',", strPageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.Append(" PageDispModeId = null,"); //页面显示模式Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxPrjMenusV2EN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.qsParameters))
 {
 if (objQxPrjMenusV2EN.qsParameters !=  null)
 {
 var strqsParameters = objQxPrjMenusV2EN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" qsParameters = '{0}',", strqsParameters); //qs参数
 }
 else
 {
 sbSQL.Append(" qsParameters = null,"); //qs参数
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.ImgFile))
 {
 if (objQxPrjMenusV2EN.ImgFile !=  null)
 {
 var strImgFile = objQxPrjMenusV2EN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImgFile = '{0}',", strImgFile); //图像文件
 }
 else
 {
 sbSQL.Append(" ImgFile = null,"); //图像文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.TabId))
 {
 if (objQxPrjMenusV2EN.TabId !=  null)
 {
 var strTabId = objQxPrjMenusV2EN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.RoleId))
 {
 if (objQxPrjMenusV2EN.RoleId  ==  "")
 {
 objQxPrjMenusV2EN.RoleId = null;
 }
 if (objQxPrjMenusV2EN.RoleId !=  null)
 {
 var strRoleId = objQxPrjMenusV2EN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.IsLeafNode))
 {
 sbSQL.AppendFormat(" IsLeafNode = '{0}',", objQxPrjMenusV2EN.IsLeafNode == true?"1":"0"); //是否叶子
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuSetId))
 {
 if (objQxPrjMenusV2EN.MenuSetId !=  null)
 {
 var strMenuSetId = objQxPrjMenusV2EN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuSetId = '{0}',", strMenuSetId); //菜单集Id
 }
 else
 {
 sbSQL.Append(" MenuSetId = null,"); //菜单集Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuIdOld))
 {
 if (objQxPrjMenusV2EN.MenuIdOld !=  null)
 {
 var strMenuIdOld = objQxPrjMenusV2EN.MenuIdOld.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MenuIdOld = '{0}',", strMenuIdOld); //MenuIdOld
 }
 else
 {
 sbSQL.Append(" MenuIdOld = null,"); //MenuIdOld
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
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxPrjMenusV2EN objQxPrjMenusV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxPrjMenusV2EN.updatedAt = clsDateTime.getTodayDateTimeStr(1);
 objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxPrjMenusV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxPrjMenusV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxPrjMenusV2 Set ");
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.createdAt))
 {
 if (objQxPrjMenusV2EN.createdAt !=  null)
 {
 var strcreatedAt = objQxPrjMenusV2EN.createdAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcreatedAt, conQxPrjMenusV2.createdAt); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.createdAt); //建立时间
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.updatedAt))
 {
 if (objQxPrjMenusV2EN.updatedAt !=  null)
 {
 var strupdatedAt = objQxPrjMenusV2EN.updatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strupdatedAt, conQxPrjMenusV2.updatedAt); //修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.updatedAt); //修改时间
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.parentMenuId))
 {
 if (objQxPrjMenusV2EN.parentMenuId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusV2EN.parentMenuId, conQxPrjMenusV2.parentMenuId); //上级菜单Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.parentMenuId); //上级菜单Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuName))
 {
 if (objQxPrjMenusV2EN.MenuName !=  null)
 {
 var strMenuName = objQxPrjMenusV2EN.MenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuName, conQxPrjMenusV2.MenuName); //菜单名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.MenuName); //菜单名
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.router))
 {
 if (objQxPrjMenusV2EN.router !=  null)
 {
 var strrouter = objQxPrjMenusV2EN.router.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strrouter, conQxPrjMenusV2.router); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.router); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.perms))
 {
 if (objQxPrjMenusV2EN.perms !=  null)
 {
 var strperms = objQxPrjMenusV2EN.perms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strperms, conQxPrjMenusV2.perms); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.perms); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.type))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusV2EN.type, conQxPrjMenusV2.type); //排序号
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.icon))
 {
 if (objQxPrjMenusV2EN.icon !=  null)
 {
 var stricon = objQxPrjMenusV2EN.icon.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", stricon, conQxPrjMenusV2.icon); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.icon); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusV2EN.OrderNum, conQxPrjMenusV2.OrderNum); //排序号
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.viewPath))
 {
 if (objQxPrjMenusV2EN.viewPath !=  null)
 {
 var strviewPath = objQxPrjMenusV2EN.viewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strviewPath, conQxPrjMenusV2.viewPath); //图像文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.viewPath); //图像文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.keepalive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusV2EN.keepalive == true?"1":"0", conQxPrjMenusV2.keepalive); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.isShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusV2EN.isShow == true?"1":"0", conQxPrjMenusV2.isShow); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.isExt))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusV2EN.isExt == true?"1":"0", conQxPrjMenusV2.isExt); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.openMode))
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusV2EN.openMode, conQxPrjMenusV2.openMode); //应用程序类型ID
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.QxPrjId))
 {
 if (objQxPrjMenusV2EN.QxPrjId  ==  "")
 {
 objQxPrjMenusV2EN.QxPrjId = null;
 }
 if (objQxPrjMenusV2EN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxPrjMenusV2EN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxPrjMenusV2.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.QxPrjId); //项目Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.UpdUserId))
 {
 if (objQxPrjMenusV2EN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxPrjMenusV2EN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxPrjMenusV2.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.Memo))
 {
 if (objQxPrjMenusV2EN.Memo !=  null)
 {
 var strMemo = objQxPrjMenusV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxPrjMenusV2.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.Memo); //备注
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.LinkFile))
 {
 if (objQxPrjMenusV2EN.LinkFile !=  null)
 {
 var strLinkFile = objQxPrjMenusV2EN.LinkFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkFile, conQxPrjMenusV2.LinkFile); //链接文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.LinkFile); //链接文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.UpdDate))
 {
 if (objQxPrjMenusV2EN.UpdDate !=  null)
 {
 var strUpdDate = objQxPrjMenusV2EN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxPrjMenusV2.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.UpdDate); //修改日期
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuControlName))
 {
 if (objQxPrjMenusV2EN.MenuControlName !=  null)
 {
 var strMenuControlName = objQxPrjMenusV2EN.MenuControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuControlName, conQxPrjMenusV2.MenuControlName); //MenuControlName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.MenuControlName); //MenuControlName
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.ApplicationTypeId))
 {
 if (objQxPrjMenusV2EN.ApplicationTypeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxPrjMenusV2EN.ApplicationTypeId, conQxPrjMenusV2.ApplicationTypeId); //应用程序类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.ApplicationTypeId); //应用程序类型ID
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuTitle))
 {
 if (objQxPrjMenusV2EN.MenuTitle !=  null)
 {
 var strMenuTitle = objQxPrjMenusV2EN.MenuTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuTitle, conQxPrjMenusV2.MenuTitle); //菜单标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.MenuTitle); //菜单标题
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.PageDispModeId))
 {
 if (objQxPrjMenusV2EN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objQxPrjMenusV2EN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageDispModeId, conQxPrjMenusV2.PageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.PageDispModeId); //页面显示模式Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusV2EN.InUse == true?"1":"0", conQxPrjMenusV2.InUse); //是否在用
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.qsParameters))
 {
 if (objQxPrjMenusV2EN.qsParameters !=  null)
 {
 var strqsParameters = objQxPrjMenusV2EN.qsParameters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strqsParameters, conQxPrjMenusV2.qsParameters); //qs参数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.qsParameters); //qs参数
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.ImgFile))
 {
 if (objQxPrjMenusV2EN.ImgFile !=  null)
 {
 var strImgFile = objQxPrjMenusV2EN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImgFile, conQxPrjMenusV2.ImgFile); //图像文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.ImgFile); //图像文件
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.TabId))
 {
 if (objQxPrjMenusV2EN.TabId !=  null)
 {
 var strTabId = objQxPrjMenusV2EN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conQxPrjMenusV2.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.TabId); //表ID
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.RoleId))
 {
 if (objQxPrjMenusV2EN.RoleId  ==  "")
 {
 objQxPrjMenusV2EN.RoleId = null;
 }
 if (objQxPrjMenusV2EN.RoleId !=  null)
 {
 var strRoleId = objQxPrjMenusV2EN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQxPrjMenusV2.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.RoleId); //角色Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.IsLeafNode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxPrjMenusV2EN.IsLeafNode == true?"1":"0", conQxPrjMenusV2.IsLeafNode); //是否叶子
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuSetId))
 {
 if (objQxPrjMenusV2EN.MenuSetId !=  null)
 {
 var strMenuSetId = objQxPrjMenusV2EN.MenuSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuSetId, conQxPrjMenusV2.MenuSetId); //菜单集Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.MenuSetId); //菜单集Id
 }
 }
 
 if (objQxPrjMenusV2EN.IsUpdated(conQxPrjMenusV2.MenuIdOld))
 {
 if (objQxPrjMenusV2EN.MenuIdOld !=  null)
 {
 var strMenuIdOld = objQxPrjMenusV2EN.MenuIdOld.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMenuIdOld, conQxPrjMenusV2.MenuIdOld); //MenuIdOld
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxPrjMenusV2.MenuIdOld); //MenuIdOld
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where id = {0}", objQxPrjMenusV2EN.id); 
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
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intid) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 intid,
};
 objSQL.ExecSP("QxPrjMenusV2_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "intid">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(int intid, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
//删除QxPrjMenusV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjMenusV2 where id = " + ""+ intid+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxPrjMenusV2(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
//删除QxPrjMenusV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjMenusV2 where id in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(int intid) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
//删除QxPrjMenusV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxPrjMenusV2 where id = " + ""+ intid+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxPrjMenusV2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: DelQxPrjMenusV2)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjMenusV2 where " + strCondition ;
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
public bool DelQxPrjMenusV2WithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxPrjMenusV2DA: DelQxPrjMenusV2WithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxPrjMenusV2 where " + strCondition ;
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
 /// <param name = "objQxPrjMenusV2ENS">源对象</param>
 /// <param name = "objQxPrjMenusV2ENT">目标对象</param>
public void CopyTo(clsQxPrjMenusV2EN objQxPrjMenusV2ENS, clsQxPrjMenusV2EN objQxPrjMenusV2ENT)
{
objQxPrjMenusV2ENT.createdAt = objQxPrjMenusV2ENS.createdAt; //建立时间
objQxPrjMenusV2ENT.updatedAt = objQxPrjMenusV2ENS.updatedAt; //修改时间
objQxPrjMenusV2ENT.id = objQxPrjMenusV2ENS.id; //id
objQxPrjMenusV2ENT.parentMenuId = objQxPrjMenusV2ENS.parentMenuId; //上级菜单Id
objQxPrjMenusV2ENT.MenuName = objQxPrjMenusV2ENS.MenuName; //菜单名
objQxPrjMenusV2ENT.router = objQxPrjMenusV2ENS.router; //链接文件
objQxPrjMenusV2ENT.perms = objQxPrjMenusV2ENS.perms; //链接文件
objQxPrjMenusV2ENT.type = objQxPrjMenusV2ENS.type; //排序号
objQxPrjMenusV2ENT.icon = objQxPrjMenusV2ENS.icon; //链接文件
objQxPrjMenusV2ENT.OrderNum = objQxPrjMenusV2ENS.OrderNum; //排序号
objQxPrjMenusV2ENT.viewPath = objQxPrjMenusV2ENS.viewPath; //图像文件
objQxPrjMenusV2ENT.keepalive = objQxPrjMenusV2ENS.keepalive; //是否在用
objQxPrjMenusV2ENT.isShow = objQxPrjMenusV2ENS.isShow; //是否在用
objQxPrjMenusV2ENT.isExt = objQxPrjMenusV2ENS.isExt; //是否在用
objQxPrjMenusV2ENT.openMode = objQxPrjMenusV2ENS.openMode; //应用程序类型ID
objQxPrjMenusV2ENT.QxPrjId = objQxPrjMenusV2ENS.QxPrjId; //项目Id
objQxPrjMenusV2ENT.UpdUserId = objQxPrjMenusV2ENS.UpdUserId; //修改用户Id
objQxPrjMenusV2ENT.Memo = objQxPrjMenusV2ENS.Memo; //备注
objQxPrjMenusV2ENT.LinkFile = objQxPrjMenusV2ENS.LinkFile; //链接文件
objQxPrjMenusV2ENT.UpdDate = objQxPrjMenusV2ENS.UpdDate; //修改日期
objQxPrjMenusV2ENT.MenuControlName = objQxPrjMenusV2ENS.MenuControlName; //MenuControlName
objQxPrjMenusV2ENT.ApplicationTypeId = objQxPrjMenusV2ENS.ApplicationTypeId; //应用程序类型ID
objQxPrjMenusV2ENT.MenuTitle = objQxPrjMenusV2ENS.MenuTitle; //菜单标题
objQxPrjMenusV2ENT.PageDispModeId = objQxPrjMenusV2ENS.PageDispModeId; //页面显示模式Id
objQxPrjMenusV2ENT.InUse = objQxPrjMenusV2ENS.InUse; //是否在用
objQxPrjMenusV2ENT.qsParameters = objQxPrjMenusV2ENS.qsParameters; //qs参数
objQxPrjMenusV2ENT.ImgFile = objQxPrjMenusV2ENS.ImgFile; //图像文件
objQxPrjMenusV2ENT.TabId = objQxPrjMenusV2ENS.TabId; //表ID
objQxPrjMenusV2ENT.RoleId = objQxPrjMenusV2ENS.RoleId; //角色Id
objQxPrjMenusV2ENT.IsLeafNode = objQxPrjMenusV2ENS.IsLeafNode; //是否叶子
objQxPrjMenusV2ENT.MenuSetId = objQxPrjMenusV2ENS.MenuSetId; //菜单集Id
objQxPrjMenusV2ENT.MenuIdOld = objQxPrjMenusV2ENS.MenuIdOld; //MenuIdOld
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxPrjMenusV2EN.MenuName, conQxPrjMenusV2.MenuName);
clsCheckSql.CheckFieldNotNull(objQxPrjMenusV2EN.type, conQxPrjMenusV2.type);
clsCheckSql.CheckFieldNotNull(objQxPrjMenusV2EN.OrderNum, conQxPrjMenusV2.OrderNum);
clsCheckSql.CheckFieldNotNull(objQxPrjMenusV2EN.openMode, conQxPrjMenusV2.openMode);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.createdAt, 20, conQxPrjMenusV2.createdAt);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.updatedAt, 20, conQxPrjMenusV2.updatedAt);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuName, 50, conQxPrjMenusV2.MenuName);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.router, 500, conQxPrjMenusV2.router);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.perms, 500, conQxPrjMenusV2.perms);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.icon, 500, conQxPrjMenusV2.icon);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.viewPath, 300, conQxPrjMenusV2.viewPath);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.QxPrjId, 4, conQxPrjMenusV2.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.UpdUserId, 20, conQxPrjMenusV2.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.Memo, 1000, conQxPrjMenusV2.Memo);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.LinkFile, 500, conQxPrjMenusV2.LinkFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.UpdDate, 20, conQxPrjMenusV2.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuControlName, 100, conQxPrjMenusV2.MenuControlName);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuTitle, 50, conQxPrjMenusV2.MenuTitle);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.PageDispModeId, 2, conQxPrjMenusV2.PageDispModeId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.qsParameters, 200, conQxPrjMenusV2.qsParameters);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.ImgFile, 300, conQxPrjMenusV2.ImgFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.TabId, 8, conQxPrjMenusV2.TabId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.RoleId, 8, conQxPrjMenusV2.RoleId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuSetId, 4, conQxPrjMenusV2.MenuSetId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuIdOld, 8, conQxPrjMenusV2.MenuIdOld);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusV2EN.QxPrjId, 4, conQxPrjMenusV2.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusV2EN.RoleId, 8, conQxPrjMenusV2.RoleId);
 objQxPrjMenusV2EN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.createdAt, 20, conQxPrjMenusV2.createdAt);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.updatedAt, 20, conQxPrjMenusV2.updatedAt);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuName, 50, conQxPrjMenusV2.MenuName);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.router, 500, conQxPrjMenusV2.router);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.perms, 500, conQxPrjMenusV2.perms);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.icon, 500, conQxPrjMenusV2.icon);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.viewPath, 300, conQxPrjMenusV2.viewPath);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.QxPrjId, 4, conQxPrjMenusV2.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.UpdUserId, 20, conQxPrjMenusV2.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.Memo, 1000, conQxPrjMenusV2.Memo);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.LinkFile, 500, conQxPrjMenusV2.LinkFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.UpdDate, 20, conQxPrjMenusV2.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuControlName, 100, conQxPrjMenusV2.MenuControlName);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuTitle, 50, conQxPrjMenusV2.MenuTitle);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.PageDispModeId, 2, conQxPrjMenusV2.PageDispModeId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.qsParameters, 200, conQxPrjMenusV2.qsParameters);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.ImgFile, 300, conQxPrjMenusV2.ImgFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.TabId, 8, conQxPrjMenusV2.TabId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.RoleId, 8, conQxPrjMenusV2.RoleId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuSetId, 4, conQxPrjMenusV2.MenuSetId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuIdOld, 8, conQxPrjMenusV2.MenuIdOld);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusV2EN.QxPrjId, 4, conQxPrjMenusV2.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusV2EN.RoleId, 8, conQxPrjMenusV2.RoleId);
 objQxPrjMenusV2EN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.createdAt, 20, conQxPrjMenusV2.createdAt);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.updatedAt, 20, conQxPrjMenusV2.updatedAt);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuName, 50, conQxPrjMenusV2.MenuName);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.router, 500, conQxPrjMenusV2.router);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.perms, 500, conQxPrjMenusV2.perms);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.icon, 500, conQxPrjMenusV2.icon);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.viewPath, 300, conQxPrjMenusV2.viewPath);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.QxPrjId, 4, conQxPrjMenusV2.QxPrjId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.UpdUserId, 20, conQxPrjMenusV2.UpdUserId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.Memo, 1000, conQxPrjMenusV2.Memo);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.LinkFile, 500, conQxPrjMenusV2.LinkFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.UpdDate, 20, conQxPrjMenusV2.UpdDate);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuControlName, 100, conQxPrjMenusV2.MenuControlName);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuTitle, 50, conQxPrjMenusV2.MenuTitle);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.PageDispModeId, 2, conQxPrjMenusV2.PageDispModeId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.qsParameters, 200, conQxPrjMenusV2.qsParameters);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.ImgFile, 300, conQxPrjMenusV2.ImgFile);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.TabId, 8, conQxPrjMenusV2.TabId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.RoleId, 8, conQxPrjMenusV2.RoleId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuSetId, 4, conQxPrjMenusV2.MenuSetId);
clsCheckSql.CheckFieldLen(objQxPrjMenusV2EN.MenuIdOld, 8, conQxPrjMenusV2.MenuIdOld);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.createdAt, conQxPrjMenusV2.createdAt);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.updatedAt, conQxPrjMenusV2.updatedAt);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.MenuName, conQxPrjMenusV2.MenuName);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.router, conQxPrjMenusV2.router);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.perms, conQxPrjMenusV2.perms);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.icon, conQxPrjMenusV2.icon);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.viewPath, conQxPrjMenusV2.viewPath);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.QxPrjId, conQxPrjMenusV2.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.UpdUserId, conQxPrjMenusV2.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.Memo, conQxPrjMenusV2.Memo);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.LinkFile, conQxPrjMenusV2.LinkFile);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.UpdDate, conQxPrjMenusV2.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.MenuControlName, conQxPrjMenusV2.MenuControlName);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.MenuTitle, conQxPrjMenusV2.MenuTitle);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.PageDispModeId, conQxPrjMenusV2.PageDispModeId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.qsParameters, conQxPrjMenusV2.qsParameters);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.ImgFile, conQxPrjMenusV2.ImgFile);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.TabId, conQxPrjMenusV2.TabId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.RoleId, conQxPrjMenusV2.RoleId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.MenuSetId, conQxPrjMenusV2.MenuSetId);
clsCheckSql.CheckSqlInjection4Field(objQxPrjMenusV2EN.MenuIdOld, conQxPrjMenusV2.MenuIdOld);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusV2EN.QxPrjId, 4, conQxPrjMenusV2.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxPrjMenusV2EN.RoleId, 8, conQxPrjMenusV2.RoleId);
 objQxPrjMenusV2EN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable Getid()
{
//获取某学院所有专业信息
string strSQL = "select id, MenuName from QxPrjMenusV2 ";
 clsSpecSQLforSql mySql = clsQxPrjMenusV2DA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxPrjMenusV2(工程菜单V2),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusV2EN.MenuName);
 if (objQxPrjMenusV2EN.QxPrjId == null)
{
 sbCondition.AppendFormat(" and QxPrjId is null");
}
else
{
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusV2EN.QxPrjId);
}
 if (objQxPrjMenusV2EN.MenuSetId == null)
{
 sbCondition.AppendFormat(" and MenuSetId is null");
}
else
{
 sbCondition.AppendFormat(" and MenuSetId = '{0}'", objQxPrjMenusV2EN.MenuSetId);
}
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
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjMenusV2EN._CurrTabName);
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
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxPrjMenusV2EN._CurrTabName, strCondition);
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
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
 objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}