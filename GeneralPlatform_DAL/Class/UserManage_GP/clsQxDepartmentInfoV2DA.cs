
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxDepartmentInfoV2DA
 表名:QxDepartmentInfoV2(00140111)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:27:04
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
 /// 部门V2(QxDepartmentInfoV2)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxDepartmentInfoV2DA : clsCommBase4DA
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
 return clsQxDepartmentInfoV2EN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxDepartmentInfoV2EN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxDepartmentInfoV2EN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxDepartmentInfoV2EN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxDepartmentInfoV2EN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
 strSQL = "Select * from QxDepartmentInfoV2 where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxDepartmentInfoV2");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxDepartmentInfoV2_SelectByCond",values, "QxDepartmentInfoV2");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfoV2 where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxDepartmentInfoV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxDepartmentInfoV2 a where {0} And a.DepartmentIdInt not in (Select Top {2} DepartmentIdInt From QxDepartmentInfoV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxDepartmentInfoV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxDepartmentInfoV2 a where {0} And a.DepartmentIdInt not in (Select Top {2} DepartmentIdInt From QxDepartmentInfoV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxDepartmentInfoV2");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxDepartmentInfoV2 a where {0} And a.DepartmentIdInt not in (Select Top {2} DepartmentIdInt From QxDepartmentInfoV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxDepartmentInfoV2");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxDepartmentInfoV2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTable_QxDepartmentInfoV2)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfoV2 where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfoV2 where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfoV2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfoV2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxDepartmentInfoV2.* from QxDepartmentInfoV2 Left Join {1} on {2} where {3} and QxDepartmentInfoV2.DepartmentIdInt not in (Select top {5} QxDepartmentInfoV2.DepartmentIdInt from QxDepartmentInfoV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfoV2 where {1} and DepartmentIdInt not in (Select top {2} DepartmentIdInt from QxDepartmentInfoV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfoV2 where {1} and DepartmentIdInt not in (Select top {3} DepartmentIdInt from QxDepartmentInfoV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxDepartmentInfoV2.* from QxDepartmentInfoV2 Left Join {1} on {2} where {3} and QxDepartmentInfoV2.DepartmentIdInt not in (Select top {5} QxDepartmentInfoV2.DepartmentIdInt from QxDepartmentInfoV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfoV2 where {1} and DepartmentIdInt not in (Select top {2} DepartmentIdInt from QxDepartmentInfoV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfoV2 where {1} and DepartmentIdInt not in (Select top {3} DepartmentIdInt from QxDepartmentInfoV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxDepartmentInfoV2.* from QxDepartmentInfoV2 Left Join {1} on {2} where {3} and QxDepartmentInfoV2.DepartmentIdInt not in (Select top {5} QxDepartmentInfoV2.DepartmentIdInt from QxDepartmentInfoV2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfoV2 where {1} and DepartmentIdInt not in (Select top {2} DepartmentIdInt from QxDepartmentInfoV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxDepartmentInfoV2 where {1} and DepartmentIdInt not in (Select top {3} DepartmentIdInt from QxDepartmentInfoV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxDepartmentInfoV2 a where {0} And a.DepartmentIdInt not in (Select Top {2} DepartmentIdInt From QxDepartmentInfoV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxDepartmentInfoV2 a where {0} And a.DepartmentIdInt not in (Select Top {2} DepartmentIdInt From QxDepartmentInfoV2 Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxDepartmentInfoV2 a where {0} And a.DepartmentIdInt not in (Select Top {2} DepartmentIdInt From QxDepartmentInfoV2 Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxDepartmentInfoV2 a where {0} And a.DepartmentIdInt not in (Select Top {2} DepartmentIdInt From QxDepartmentInfoV2 Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2ByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxDepartmentInfoV2_SelectByCond",values);
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
public List<clsQxDepartmentInfoV2EN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA:GetObjLst)", objException.Message));
}
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = TransNullToInt(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = TransNullToBool(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxDepartmentInfoV2DA: GetObjLst)", objException.Message));
}
objQxDepartmentInfoV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxDepartmentInfoV2EN);
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
public List<clsQxDepartmentInfoV2EN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA:GetObjLstByTabName)", objException.Message));
}
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = TransNullToInt(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = TransNullToBool(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxDepartmentInfoV2DA: GetObjLst)", objException.Message));
}
objQxDepartmentInfoV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxDepartmentInfoV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxDepartmentInfoV2EN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA:GetObjLstBySP)", objException.Message));
}
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxDepartmentInfoV2_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = TransNullToInt(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = TransNullToBool(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxDepartmentInfoV2DA: GetObjLstBySP)", objException.Message));
}
objQxDepartmentInfoV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxDepartmentInfoV2EN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxDepartmentInfoV2(ref clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where DepartmentIdInt = " + ""+ objQxDepartmentInfoV2EN.DepartmentIdInt+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxDepartmentInfoV2EN.DepartmentIdInt = TransNullToInt(objDT.Rows[0][conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id(字段类型:int,字段长度:4,是否可空:False)
 objQxDepartmentInfoV2EN.DepartmentName = objDT.Rows[0][conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objQxDepartmentInfoV2EN.DepartmentAbbrName = objDT.Rows[0][conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objQxDepartmentInfoV2EN.DepartmentTypeId = objDT.Rows[0][conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objQxDepartmentInfoV2EN.parentDepId = TransNullToInt(objDT.Rows[0][conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号(字段类型:int,字段长度:4,是否可空:True)
 objQxDepartmentInfoV2EN.OrderNum = TransNullToInt(objDT.Rows[0][conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxDepartmentInfoV2EN.InUse = TransNullToBool(objDT.Rows[0][conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxDepartmentInfoV2EN.Memo = objDT.Rows[0][conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxDepartmentInfoV2EN.CreateTime = objDT.Rows[0][conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxDepartmentInfoV2EN.updateTime = objDT.Rows[0][conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxDepartmentInfoV2DA: GetQxDepartmentInfoV2)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intDepartmentIdInt">表关键字</param>
 /// <returns>表对象</returns>
public clsQxDepartmentInfoV2EN GetObjByDepartmentIdInt(int intDepartmentIdInt)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where DepartmentIdInt = " + ""+ intDepartmentIdInt+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
 objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id(字段类型:int,字段长度:4,是否可空:False)
 objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号(字段类型:int,字段长度:4,是否可空:True)
 objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxDepartmentInfoV2DA: GetObjByDepartmentIdInt)", objException.Message));
}
return objQxDepartmentInfoV2EN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxDepartmentInfoV2_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxDepartmentInfoV2OneBySP(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxDepartmentInfoV2EN.DepartmentIdInt
};
 objDT = objSQL.ExecSpReturnDT("QxDepartmentInfoV2_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxDepartmentInfoV2EN.DepartmentIdInt = TransNullToInt(objDT.Rows[0][conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id(字段类型:int,字段长度:4,是否可空:False)
 objQxDepartmentInfoV2EN.DepartmentName = objDT.Rows[0][conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objQxDepartmentInfoV2EN.DepartmentAbbrName = objDT.Rows[0][conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写(字段类型:varchar,字段长度:8,是否可空:True)
 objQxDepartmentInfoV2EN.DepartmentTypeId = objDT.Rows[0][conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID(字段类型:char,字段长度:2,是否可空:False)
 objQxDepartmentInfoV2EN.parentDepId = TransNullToInt(objDT.Rows[0][conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号(字段类型:int,字段长度:4,是否可空:True)
 objQxDepartmentInfoV2EN.OrderNum = TransNullToInt(objDT.Rows[0][conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号(字段类型:int,字段长度:4,是否可空:True)
 objQxDepartmentInfoV2EN.InUse = TransNullToBool(objDT.Rows[0][conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQxDepartmentInfoV2EN.Memo = objDT.Rows[0][conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxDepartmentInfoV2EN.CreateTime = objDT.Rows[0][conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objQxDepartmentInfoV2EN.updateTime = objDT.Rows[0][conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:20,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxDepartmentInfoV2EN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN()
{
DepartmentIdInt = TransNullToInt(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()), //部门Id
DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(), //名称缩写
DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(), //部门类型ID
parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()), //所属部门号
OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()), //排序号
InUse = TransNullToBool(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()), //是否在用
Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(), //备注
CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(), //建立时间
updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim() //修改时间
};
objQxDepartmentInfoV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxDepartmentInfoV2EN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxDepartmentInfoV2DA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxDepartmentInfoV2EN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxDepartmentInfoV2_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN()
{
DepartmentIdInt = TransNullToInt(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()), //部门Id
DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(), //部门名
DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(), //名称缩写
DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(), //部门类型ID
parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()), //所属部门号
OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()), //排序号
InUse = TransNullToBool(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()), //是否在用
Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(), //备注
CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(), //建立时间
updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim() //修改时间
};
objQxDepartmentInfoV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxDepartmentInfoV2EN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxDepartmentInfoV2EN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = TransNullToInt(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = TransNullToBool(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxDepartmentInfoV2DA: GetObjByDataRowQxDepartmentInfoV2)", objException.Message));
}
objQxDepartmentInfoV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxDepartmentInfoV2EN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxDepartmentInfoV2EN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = TransNullToInt(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = TransNullToBool(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxDepartmentInfoV2DA: GetObjByDataRow)", objException.Message));
}
objQxDepartmentInfoV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxDepartmentInfoV2EN;
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
objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxDepartmentInfoV2EN._CurrTabName, conQxDepartmentInfoV2.DepartmentIdInt, 4, "");
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
objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxDepartmentInfoV2EN._CurrTabName, conQxDepartmentInfoV2.DepartmentIdInt, 4, strPrefix);
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
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DepartmentIdInt from QxDepartmentInfoV2 where " + strCondition;
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
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DepartmentIdInt from QxDepartmentInfoV2 where " + strCondition;
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
 /// <param name = "intDepartmentIdInt">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(int intDepartmentIdInt)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxDepartmentInfoV2", "DepartmentIdInt = " + ""+ intDepartmentIdInt+""))
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
 /// <param name = "intDepartmentIdInt">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(int intDepartmentIdInt)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
intDepartmentIdInt,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxDepartmentInfoV2_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxDepartmentInfoV2", strCondition))
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
objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxDepartmentInfoV2");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
 {
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxDepartmentInfoV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxDepartmentInfoV2EN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxDepartmentInfoV2");
objRow = objDS.Tables["QxDepartmentInfoV2"].NewRow();
objRow[conQxDepartmentInfoV2.DepartmentName] = objQxDepartmentInfoV2EN.DepartmentName; //部门名
 if (objQxDepartmentInfoV2EN.DepartmentAbbrName !=  "")
 {
objRow[conQxDepartmentInfoV2.DepartmentAbbrName] = objQxDepartmentInfoV2EN.DepartmentAbbrName; //名称缩写
 }
 if (objQxDepartmentInfoV2EN.DepartmentTypeId !=  "")
 {
objRow[conQxDepartmentInfoV2.DepartmentTypeId] = objQxDepartmentInfoV2EN.DepartmentTypeId; //部门类型ID
 }
objRow[conQxDepartmentInfoV2.parentDepId] = objQxDepartmentInfoV2EN.parentDepId; //所属部门号
objRow[conQxDepartmentInfoV2.OrderNum] = objQxDepartmentInfoV2EN.OrderNum; //排序号
objRow[conQxDepartmentInfoV2.InUse] = objQxDepartmentInfoV2EN.InUse; //是否在用
 if (objQxDepartmentInfoV2EN.Memo !=  "")
 {
objRow[conQxDepartmentInfoV2.Memo] = objQxDepartmentInfoV2EN.Memo; //备注
 }
 if (objQxDepartmentInfoV2EN.CreateTime !=  "")
 {
objRow[conQxDepartmentInfoV2.CreateTime] = objQxDepartmentInfoV2EN.CreateTime; //建立时间
 }
 if (objQxDepartmentInfoV2EN.updateTime !=  "")
 {
objRow[conQxDepartmentInfoV2.updateTime] = objQxDepartmentInfoV2EN.updateTime; //修改时间
 }
objDS.Tables[clsQxDepartmentInfoV2EN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxDepartmentInfoV2EN._CurrTabName);
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
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxDepartmentInfoV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxDepartmentInfoV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxDepartmentInfoV2EN.DepartmentName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentName);
 var strDepartmentName = objQxDepartmentInfoV2EN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentName + "'");
 }
 
 if (objQxDepartmentInfoV2EN.DepartmentAbbrName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentAbbrName);
 var strDepartmentAbbrName = objQxDepartmentInfoV2EN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentAbbrName + "'");
 }
 
 if (objQxDepartmentInfoV2EN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoV2EN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoV2EN.DepartmentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentTypeId);
 var strDepartmentTypeId = objQxDepartmentInfoV2EN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentTypeId + "'");
 }
 
 if (objQxDepartmentInfoV2EN.parentDepId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.parentDepId);
 arrValueListForInsert.Add(objQxDepartmentInfoV2EN.parentDepId.ToString());
 }
 
 if (objQxDepartmentInfoV2EN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.OrderNum);
 arrValueListForInsert.Add(objQxDepartmentInfoV2EN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.InUse);
 arrValueListForInsert.Add("'" + (objQxDepartmentInfoV2EN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxDepartmentInfoV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.Memo);
 var strMemo = objQxDepartmentInfoV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxDepartmentInfoV2EN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.CreateTime);
 var strCreateTime = objQxDepartmentInfoV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objQxDepartmentInfoV2EN.updateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.updateTime);
 var strupdateTime = objQxDepartmentInfoV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdateTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxDepartmentInfoV2");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxDepartmentInfoV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxDepartmentInfoV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxDepartmentInfoV2EN.DepartmentName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentName);
 var strDepartmentName = objQxDepartmentInfoV2EN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentName + "'");
 }
 
 if (objQxDepartmentInfoV2EN.DepartmentAbbrName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentAbbrName);
 var strDepartmentAbbrName = objQxDepartmentInfoV2EN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentAbbrName + "'");
 }
 
 if (objQxDepartmentInfoV2EN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoV2EN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoV2EN.DepartmentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentTypeId);
 var strDepartmentTypeId = objQxDepartmentInfoV2EN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentTypeId + "'");
 }
 
 if (objQxDepartmentInfoV2EN.parentDepId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.parentDepId);
 arrValueListForInsert.Add(objQxDepartmentInfoV2EN.parentDepId.ToString());
 }
 
 if (objQxDepartmentInfoV2EN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.OrderNum);
 arrValueListForInsert.Add(objQxDepartmentInfoV2EN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.InUse);
 arrValueListForInsert.Add("'" + (objQxDepartmentInfoV2EN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxDepartmentInfoV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.Memo);
 var strMemo = objQxDepartmentInfoV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxDepartmentInfoV2EN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.CreateTime);
 var strCreateTime = objQxDepartmentInfoV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objQxDepartmentInfoV2EN.updateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.updateTime);
 var strupdateTime = objQxDepartmentInfoV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdateTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxDepartmentInfoV2");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxDepartmentInfoV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxDepartmentInfoV2EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxDepartmentInfoV2EN.DepartmentName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentName);
 var strDepartmentName = objQxDepartmentInfoV2EN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentName + "'");
 }
 
 if (objQxDepartmentInfoV2EN.DepartmentAbbrName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentAbbrName);
 var strDepartmentAbbrName = objQxDepartmentInfoV2EN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentAbbrName + "'");
 }
 
 if (objQxDepartmentInfoV2EN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoV2EN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoV2EN.DepartmentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentTypeId);
 var strDepartmentTypeId = objQxDepartmentInfoV2EN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentTypeId + "'");
 }
 
 if (objQxDepartmentInfoV2EN.parentDepId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.parentDepId);
 arrValueListForInsert.Add(objQxDepartmentInfoV2EN.parentDepId.ToString());
 }
 
 if (objQxDepartmentInfoV2EN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.OrderNum);
 arrValueListForInsert.Add(objQxDepartmentInfoV2EN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.InUse);
 arrValueListForInsert.Add("'" + (objQxDepartmentInfoV2EN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxDepartmentInfoV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.Memo);
 var strMemo = objQxDepartmentInfoV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxDepartmentInfoV2EN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.CreateTime);
 var strCreateTime = objQxDepartmentInfoV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objQxDepartmentInfoV2EN.updateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.updateTime);
 var strupdateTime = objQxDepartmentInfoV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdateTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxDepartmentInfoV2");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxDepartmentInfoV2EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxDepartmentInfoV2EN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxDepartmentInfoV2EN.DepartmentName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentName);
 var strDepartmentName = objQxDepartmentInfoV2EN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentName + "'");
 }
 
 if (objQxDepartmentInfoV2EN.DepartmentAbbrName !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentAbbrName);
 var strDepartmentAbbrName = objQxDepartmentInfoV2EN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentAbbrName + "'");
 }
 
 if (objQxDepartmentInfoV2EN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoV2EN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoV2EN.DepartmentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.DepartmentTypeId);
 var strDepartmentTypeId = objQxDepartmentInfoV2EN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentTypeId + "'");
 }
 
 if (objQxDepartmentInfoV2EN.parentDepId !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.parentDepId);
 arrValueListForInsert.Add(objQxDepartmentInfoV2EN.parentDepId.ToString());
 }
 
 if (objQxDepartmentInfoV2EN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.OrderNum);
 arrValueListForInsert.Add(objQxDepartmentInfoV2EN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.InUse);
 arrValueListForInsert.Add("'" + (objQxDepartmentInfoV2EN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQxDepartmentInfoV2EN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.Memo);
 var strMemo = objQxDepartmentInfoV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxDepartmentInfoV2EN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.CreateTime);
 var strCreateTime = objQxDepartmentInfoV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objQxDepartmentInfoV2EN.updateTime !=  null)
 {
 arrFieldListForInsert.Add(conQxDepartmentInfoV2.updateTime);
 var strupdateTime = objQxDepartmentInfoV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdateTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxDepartmentInfoV2");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxDepartmentInfoV2BySP(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
//通过存储过程来
//直接使用
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxDepartmentInfoV2EN.DepartmentName,
 objQxDepartmentInfoV2EN.DepartmentAbbrName,
 objQxDepartmentInfoV2EN.DepartmentTypeId,
 objQxDepartmentInfoV2EN.parentDepId,
 objQxDepartmentInfoV2EN.OrderNum,
 objQxDepartmentInfoV2EN.InUse,
 objQxDepartmentInfoV2EN.Memo,
 objQxDepartmentInfoV2EN.CreateTime,
objQxDepartmentInfoV2EN.updateTime
};
 objSQL.ExecSP("QxDepartmentInfoV2_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxDepartmentInfoV2s(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where DepartmentIdInt = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxDepartmentInfoV2");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
int intDepartmentIdInt = TransNullToInt(oRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim());
if (IsExist(intDepartmentIdInt))
{
 string strResult = "关键字变量值为:" + string.Format("DepartmentIdInt = {0}", intDepartmentIdInt) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxDepartmentInfoV2EN._CurrTabName ].NewRow();
objRow[conQxDepartmentInfoV2.DepartmentName] = oRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objRow[conQxDepartmentInfoV2.DepartmentAbbrName] = oRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objRow[conQxDepartmentInfoV2.DepartmentTypeId] = oRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objRow[conQxDepartmentInfoV2.parentDepId] = oRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim(); //所属部门号
objRow[conQxDepartmentInfoV2.OrderNum] = oRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim(); //排序号
objRow[conQxDepartmentInfoV2.InUse] = oRow[conQxDepartmentInfoV2.InUse].ToString().Trim(); //是否在用
objRow[conQxDepartmentInfoV2.Memo] = oRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objRow[conQxDepartmentInfoV2.CreateTime] = oRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objRow[conQxDepartmentInfoV2.updateTime] = oRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
 objDS.Tables[clsQxDepartmentInfoV2EN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxDepartmentInfoV2EN._CurrTabName);
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
 /// <param name = "objQxDepartmentInfoV2EN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxDepartmentInfoV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoV2EN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
strSQL = "Select * from QxDepartmentInfoV2 where DepartmentIdInt = " + ""+ objQxDepartmentInfoV2EN.DepartmentIdInt+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxDepartmentInfoV2EN._CurrTabName);
if (objDS.Tables[clsQxDepartmentInfoV2EN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DepartmentIdInt = " + ""+ objQxDepartmentInfoV2EN.DepartmentIdInt+"");
return false;
}
objRow = objDS.Tables[clsQxDepartmentInfoV2EN._CurrTabName].Rows[0];
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentName))
 {
objRow[conQxDepartmentInfoV2.DepartmentName] = objQxDepartmentInfoV2EN.DepartmentName; //部门名
 }
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentAbbrName))
 {
objRow[conQxDepartmentInfoV2.DepartmentAbbrName] = objQxDepartmentInfoV2EN.DepartmentAbbrName; //名称缩写
 }
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentTypeId))
 {
objRow[conQxDepartmentInfoV2.DepartmentTypeId] = objQxDepartmentInfoV2EN.DepartmentTypeId; //部门类型ID
 }
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.parentDepId))
 {
objRow[conQxDepartmentInfoV2.parentDepId] = objQxDepartmentInfoV2EN.parentDepId; //所属部门号
 }
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.OrderNum))
 {
objRow[conQxDepartmentInfoV2.OrderNum] = objQxDepartmentInfoV2EN.OrderNum; //排序号
 }
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.InUse))
 {
objRow[conQxDepartmentInfoV2.InUse] = objQxDepartmentInfoV2EN.InUse; //是否在用
 }
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.Memo))
 {
objRow[conQxDepartmentInfoV2.Memo] = objQxDepartmentInfoV2EN.Memo; //备注
 }
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.CreateTime))
 {
objRow[conQxDepartmentInfoV2.CreateTime] = objQxDepartmentInfoV2EN.CreateTime; //建立时间
 }
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.updateTime))
 {
objRow[conQxDepartmentInfoV2.updateTime] = objQxDepartmentInfoV2EN.updateTime; //修改时间
 }
try
{
objDA.Update(objDS, clsQxDepartmentInfoV2EN._CurrTabName);
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
public bool UpdateBySP(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxDepartmentInfoV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoV2EN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxDepartmentInfoV2EN.DepartmentIdInt,
 objQxDepartmentInfoV2EN.DepartmentName,
 objQxDepartmentInfoV2EN.DepartmentAbbrName,
 objQxDepartmentInfoV2EN.DepartmentTypeId,
 objQxDepartmentInfoV2EN.parentDepId,
 objQxDepartmentInfoV2EN.OrderNum,
 objQxDepartmentInfoV2EN.InUse,
 objQxDepartmentInfoV2EN.Memo,
 objQxDepartmentInfoV2EN.CreateTime,
 objQxDepartmentInfoV2EN.updateTime
};
 objSQL.ExecSP("QxDepartmentInfoV2_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxDepartmentInfoV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxDepartmentInfoV2 Set ");
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentName))
 {
 if (objQxDepartmentInfoV2EN.DepartmentName !=  null)
 {
 var strDepartmentName = objQxDepartmentInfoV2EN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentName, conQxDepartmentInfoV2.DepartmentName); //部门名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.DepartmentName); //部门名
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentAbbrName))
 {
 if (objQxDepartmentInfoV2EN.DepartmentAbbrName !=  null)
 {
 var strDepartmentAbbrName = objQxDepartmentInfoV2EN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentAbbrName, conQxDepartmentInfoV2.DepartmentAbbrName); //名称缩写
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.DepartmentAbbrName); //名称缩写
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentTypeId))
 {
 if (objQxDepartmentInfoV2EN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoV2EN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoV2EN.DepartmentTypeId !=  null)
 {
 var strDepartmentTypeId = objQxDepartmentInfoV2EN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentTypeId, conQxDepartmentInfoV2.DepartmentTypeId); //部门类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.DepartmentTypeId); //部门类型ID
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.parentDepId))
 {
 if (objQxDepartmentInfoV2EN.parentDepId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxDepartmentInfoV2EN.parentDepId, conQxDepartmentInfoV2.parentDepId); //所属部门号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.parentDepId); //所属部门号
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.OrderNum))
 {
 if (objQxDepartmentInfoV2EN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxDepartmentInfoV2EN.OrderNum, conQxDepartmentInfoV2.OrderNum); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.OrderNum); //排序号
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxDepartmentInfoV2EN.InUse == true?"1":"0", conQxDepartmentInfoV2.InUse); //是否在用
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.Memo))
 {
 if (objQxDepartmentInfoV2EN.Memo !=  null)
 {
 var strMemo = objQxDepartmentInfoV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxDepartmentInfoV2.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.Memo); //备注
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.CreateTime))
 {
 if (objQxDepartmentInfoV2EN.CreateTime !=  null)
 {
 var strCreateTime = objQxDepartmentInfoV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateTime, conQxDepartmentInfoV2.CreateTime); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.CreateTime); //建立时间
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.updateTime))
 {
 if (objQxDepartmentInfoV2EN.updateTime !=  null)
 {
 var strupdateTime = objQxDepartmentInfoV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strupdateTime, conQxDepartmentInfoV2.updateTime); //修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.updateTime); //修改时间
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DepartmentIdInt = {0}", objQxDepartmentInfoV2EN.DepartmentIdInt); 
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
 /// <param name = "objQxDepartmentInfoV2EN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, string strCondition)
{
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxDepartmentInfoV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxDepartmentInfoV2 Set ");
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentName))
 {
 if (objQxDepartmentInfoV2EN.DepartmentName !=  null)
 {
 var strDepartmentName = objQxDepartmentInfoV2EN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentName = '{0}',", strDepartmentName); //部门名
 }
 else
 {
 sbSQL.Append(" DepartmentName = null,"); //部门名
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentAbbrName))
 {
 if (objQxDepartmentInfoV2EN.DepartmentAbbrName !=  null)
 {
 var strDepartmentAbbrName = objQxDepartmentInfoV2EN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentAbbrName = '{0}',", strDepartmentAbbrName); //名称缩写
 }
 else
 {
 sbSQL.Append(" DepartmentAbbrName = null,"); //名称缩写
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentTypeId))
 {
 if (objQxDepartmentInfoV2EN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoV2EN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoV2EN.DepartmentTypeId !=  null)
 {
 var strDepartmentTypeId = objQxDepartmentInfoV2EN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentTypeId = '{0}',", strDepartmentTypeId); //部门类型ID
 }
 else
 {
 sbSQL.Append(" DepartmentTypeId = null,"); //部门类型ID
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.parentDepId))
 {
 sbSQL.AppendFormat(" parentDepId = {0},", objQxDepartmentInfoV2EN.parentDepId); //所属部门号
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxDepartmentInfoV2EN.OrderNum); //排序号
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxDepartmentInfoV2EN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.Memo))
 {
 if (objQxDepartmentInfoV2EN.Memo !=  null)
 {
 var strMemo = objQxDepartmentInfoV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.CreateTime))
 {
 if (objQxDepartmentInfoV2EN.CreateTime !=  null)
 {
 var strCreateTime = objQxDepartmentInfoV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateTime = '{0}',", strCreateTime); //建立时间
 }
 else
 {
 sbSQL.Append(" CreateTime = null,"); //建立时间
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.updateTime))
 {
 if (objQxDepartmentInfoV2EN.updateTime !=  null)
 {
 var strupdateTime = objQxDepartmentInfoV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" updateTime = '{0}',", strupdateTime); //修改时间
 }
 else
 {
 sbSQL.Append(" updateTime = null,"); //修改时间
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
 /// <param name = "objQxDepartmentInfoV2EN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxDepartmentInfoV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxDepartmentInfoV2 Set ");
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentName))
 {
 if (objQxDepartmentInfoV2EN.DepartmentName !=  null)
 {
 var strDepartmentName = objQxDepartmentInfoV2EN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentName = '{0}',", strDepartmentName); //部门名
 }
 else
 {
 sbSQL.Append(" DepartmentName = null,"); //部门名
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentAbbrName))
 {
 if (objQxDepartmentInfoV2EN.DepartmentAbbrName !=  null)
 {
 var strDepartmentAbbrName = objQxDepartmentInfoV2EN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentAbbrName = '{0}',", strDepartmentAbbrName); //名称缩写
 }
 else
 {
 sbSQL.Append(" DepartmentAbbrName = null,"); //名称缩写
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentTypeId))
 {
 if (objQxDepartmentInfoV2EN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoV2EN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoV2EN.DepartmentTypeId !=  null)
 {
 var strDepartmentTypeId = objQxDepartmentInfoV2EN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentTypeId = '{0}',", strDepartmentTypeId); //部门类型ID
 }
 else
 {
 sbSQL.Append(" DepartmentTypeId = null,"); //部门类型ID
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.parentDepId))
 {
 sbSQL.AppendFormat(" parentDepId = {0},", objQxDepartmentInfoV2EN.parentDepId); //所属部门号
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objQxDepartmentInfoV2EN.OrderNum); //排序号
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQxDepartmentInfoV2EN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.Memo))
 {
 if (objQxDepartmentInfoV2EN.Memo !=  null)
 {
 var strMemo = objQxDepartmentInfoV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.CreateTime))
 {
 if (objQxDepartmentInfoV2EN.CreateTime !=  null)
 {
 var strCreateTime = objQxDepartmentInfoV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateTime = '{0}',", strCreateTime); //建立时间
 }
 else
 {
 sbSQL.Append(" CreateTime = null,"); //建立时间
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.updateTime))
 {
 if (objQxDepartmentInfoV2EN.updateTime !=  null)
 {
 var strupdateTime = objQxDepartmentInfoV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" updateTime = '{0}',", strupdateTime); //修改时间
 }
 else
 {
 sbSQL.Append(" updateTime = null,"); //修改时间
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
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
 if (objQxDepartmentInfoV2EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxDepartmentInfoV2EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxDepartmentInfoV2 Set ");
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentName))
 {
 if (objQxDepartmentInfoV2EN.DepartmentName !=  null)
 {
 var strDepartmentName = objQxDepartmentInfoV2EN.DepartmentName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentName, conQxDepartmentInfoV2.DepartmentName); //部门名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.DepartmentName); //部门名
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentAbbrName))
 {
 if (objQxDepartmentInfoV2EN.DepartmentAbbrName !=  null)
 {
 var strDepartmentAbbrName = objQxDepartmentInfoV2EN.DepartmentAbbrName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentAbbrName, conQxDepartmentInfoV2.DepartmentAbbrName); //名称缩写
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.DepartmentAbbrName); //名称缩写
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.DepartmentTypeId))
 {
 if (objQxDepartmentInfoV2EN.DepartmentTypeId  ==  "")
 {
 objQxDepartmentInfoV2EN.DepartmentTypeId = null;
 }
 if (objQxDepartmentInfoV2EN.DepartmentTypeId !=  null)
 {
 var strDepartmentTypeId = objQxDepartmentInfoV2EN.DepartmentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentTypeId, conQxDepartmentInfoV2.DepartmentTypeId); //部门类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.DepartmentTypeId); //部门类型ID
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.parentDepId))
 {
 if (objQxDepartmentInfoV2EN.parentDepId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxDepartmentInfoV2EN.parentDepId, conQxDepartmentInfoV2.parentDepId); //所属部门号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.parentDepId); //所属部门号
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.OrderNum))
 {
 if (objQxDepartmentInfoV2EN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQxDepartmentInfoV2EN.OrderNum, conQxDepartmentInfoV2.OrderNum); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.OrderNum); //排序号
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxDepartmentInfoV2EN.InUse == true?"1":"0", conQxDepartmentInfoV2.InUse); //是否在用
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.Memo))
 {
 if (objQxDepartmentInfoV2EN.Memo !=  null)
 {
 var strMemo = objQxDepartmentInfoV2EN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxDepartmentInfoV2.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.Memo); //备注
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.CreateTime))
 {
 if (objQxDepartmentInfoV2EN.CreateTime !=  null)
 {
 var strCreateTime = objQxDepartmentInfoV2EN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateTime, conQxDepartmentInfoV2.CreateTime); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.CreateTime); //建立时间
 }
 }
 
 if (objQxDepartmentInfoV2EN.IsUpdated(conQxDepartmentInfoV2.updateTime))
 {
 if (objQxDepartmentInfoV2EN.updateTime !=  null)
 {
 var strupdateTime = objQxDepartmentInfoV2EN.updateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strupdateTime, conQxDepartmentInfoV2.updateTime); //修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxDepartmentInfoV2.updateTime); //修改时间
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DepartmentIdInt = {0}", objQxDepartmentInfoV2EN.DepartmentIdInt); 
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
 /// <param name = "intDepartmentIdInt">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intDepartmentIdInt) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 intDepartmentIdInt,
};
 objSQL.ExecSP("QxDepartmentInfoV2_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "intDepartmentIdInt">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(int intDepartmentIdInt, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
//删除QxDepartmentInfoV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxDepartmentInfoV2 where DepartmentIdInt = " + ""+ intDepartmentIdInt+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxDepartmentInfoV2(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
//删除QxDepartmentInfoV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxDepartmentInfoV2 where DepartmentIdInt in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "intDepartmentIdInt">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(int intDepartmentIdInt) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
//删除QxDepartmentInfoV2本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxDepartmentInfoV2 where DepartmentIdInt = " + ""+ intDepartmentIdInt+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxDepartmentInfoV2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: DelQxDepartmentInfoV2)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxDepartmentInfoV2 where " + strCondition ;
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
public bool DelQxDepartmentInfoV2WithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2DA: DelQxDepartmentInfoV2WithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxDepartmentInfoV2 where " + strCondition ;
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
 /// <param name = "objQxDepartmentInfoV2ENS">源对象</param>
 /// <param name = "objQxDepartmentInfoV2ENT">目标对象</param>
public void CopyTo(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2ENS, clsQxDepartmentInfoV2EN objQxDepartmentInfoV2ENT)
{
objQxDepartmentInfoV2ENT.DepartmentIdInt = objQxDepartmentInfoV2ENS.DepartmentIdInt; //部门Id
objQxDepartmentInfoV2ENT.DepartmentName = objQxDepartmentInfoV2ENS.DepartmentName; //部门名
objQxDepartmentInfoV2ENT.DepartmentAbbrName = objQxDepartmentInfoV2ENS.DepartmentAbbrName; //名称缩写
objQxDepartmentInfoV2ENT.DepartmentTypeId = objQxDepartmentInfoV2ENS.DepartmentTypeId; //部门类型ID
objQxDepartmentInfoV2ENT.parentDepId = objQxDepartmentInfoV2ENS.parentDepId; //所属部门号
objQxDepartmentInfoV2ENT.OrderNum = objQxDepartmentInfoV2ENS.OrderNum; //排序号
objQxDepartmentInfoV2ENT.InUse = objQxDepartmentInfoV2ENS.InUse; //是否在用
objQxDepartmentInfoV2ENT.Memo = objQxDepartmentInfoV2ENS.Memo; //备注
objQxDepartmentInfoV2ENT.CreateTime = objQxDepartmentInfoV2ENS.CreateTime; //建立时间
objQxDepartmentInfoV2ENT.updateTime = objQxDepartmentInfoV2ENS.updateTime; //修改时间
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxDepartmentInfoV2EN.DepartmentName, conQxDepartmentInfoV2.DepartmentName);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.DepartmentName, 100, conQxDepartmentInfoV2.DepartmentName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.DepartmentAbbrName, 8, conQxDepartmentInfoV2.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.DepartmentTypeId, 2, conQxDepartmentInfoV2.DepartmentTypeId);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.Memo, 1000, conQxDepartmentInfoV2.Memo);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.CreateTime, 20, conQxDepartmentInfoV2.CreateTime);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.updateTime, 20, conQxDepartmentInfoV2.updateTime);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxDepartmentInfoV2EN.DepartmentTypeId, 2, conQxDepartmentInfoV2.DepartmentTypeId);
 objQxDepartmentInfoV2EN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.DepartmentName, 100, conQxDepartmentInfoV2.DepartmentName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.DepartmentAbbrName, 8, conQxDepartmentInfoV2.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.DepartmentTypeId, 2, conQxDepartmentInfoV2.DepartmentTypeId);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.Memo, 1000, conQxDepartmentInfoV2.Memo);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.CreateTime, 20, conQxDepartmentInfoV2.CreateTime);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.updateTime, 20, conQxDepartmentInfoV2.updateTime);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxDepartmentInfoV2EN.DepartmentTypeId, 2, conQxDepartmentInfoV2.DepartmentTypeId);
 objQxDepartmentInfoV2EN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.DepartmentName, 100, conQxDepartmentInfoV2.DepartmentName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.DepartmentAbbrName, 8, conQxDepartmentInfoV2.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.DepartmentTypeId, 2, conQxDepartmentInfoV2.DepartmentTypeId);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.Memo, 1000, conQxDepartmentInfoV2.Memo);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.CreateTime, 20, conQxDepartmentInfoV2.CreateTime);
clsCheckSql.CheckFieldLen(objQxDepartmentInfoV2EN.updateTime, 20, conQxDepartmentInfoV2.updateTime);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoV2EN.DepartmentName, conQxDepartmentInfoV2.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoV2EN.DepartmentAbbrName, conQxDepartmentInfoV2.DepartmentAbbrName);
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoV2EN.DepartmentTypeId, conQxDepartmentInfoV2.DepartmentTypeId);
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoV2EN.Memo, conQxDepartmentInfoV2.Memo);
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoV2EN.CreateTime, conQxDepartmentInfoV2.CreateTime);
clsCheckSql.CheckSqlInjection4Field(objQxDepartmentInfoV2EN.updateTime, conQxDepartmentInfoV2.updateTime);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxDepartmentInfoV2EN.DepartmentTypeId, 2, conQxDepartmentInfoV2.DepartmentTypeId);
 objQxDepartmentInfoV2EN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetDepartmentIdInt()
{
//获取某学院所有专业信息
string strSQL = "select DepartmentIdInt, DepartmentName from QxDepartmentInfoV2 ";
 clsSpecSQLforSql mySql = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxDepartmentInfoV2(部门V2),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DepartmentName = '{0}'", objQxDepartmentInfoV2EN.DepartmentName);
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
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxDepartmentInfoV2EN._CurrTabName);
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
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxDepartmentInfoV2EN._CurrTabName, strCondition);
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
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
 objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}