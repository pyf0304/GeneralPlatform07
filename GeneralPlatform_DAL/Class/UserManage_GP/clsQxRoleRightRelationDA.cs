
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRoleRightRelationDA
 表名:QxRoleRightRelation(00140118)
 * 版本:2024.02.03.1(服务器:WIN-SRV103-116)
 日期:2024/02/18 15:41:36
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
 /// 角色赋权关系(QxRoleRightRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxRoleRightRelationDA : clsCommBase4DA
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
 return clsQxRoleRightRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxRoleRightRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxRoleRightRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxRoleRightRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxRoleRightRelationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
 strSQL = "Select * from QxRoleRightRelation where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxRoleRightRelation");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxRoleRightRelation_SelectByCond",values, "QxRoleRightRelation");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRoleRightRelation where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxRoleRightRelation");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRoleRightRelation a where {0} And a.mId not in (Select Top {2} mId From QxRoleRightRelation Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRoleRightRelation");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRoleRightRelation a where {0} And a.mId not in (Select Top {2} mId From QxRoleRightRelation Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRoleRightRelation");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxRoleRightRelation a where {0} And a.mId not in (Select Top {2} mId From QxRoleRightRelation Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxRoleRightRelation");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxRoleRightRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTable_QxRoleRightRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoleRightRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoleRightRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRoleRightRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxRoleRightRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRoleRightRelation.* from QxRoleRightRelation Left Join {1} on {2} where {3} and QxRoleRightRelation.mId not in (Select top {5} QxRoleRightRelation.mId from QxRoleRightRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoleRightRelation where {1} and mId not in (Select top {2} mId from QxRoleRightRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoleRightRelation where {1} and mId not in (Select top {3} mId from QxRoleRightRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRoleRightRelation.* from QxRoleRightRelation Left Join {1} on {2} where {3} and QxRoleRightRelation.mId not in (Select top {5} QxRoleRightRelation.mId from QxRoleRightRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoleRightRelation where {1} and mId not in (Select top {2} mId from QxRoleRightRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoleRightRelation where {1} and mId not in (Select top {3} mId from QxRoleRightRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxRoleRightRelation.* from QxRoleRightRelation Left Join {1} on {2} where {3} and QxRoleRightRelation.mId not in (Select top {5} QxRoleRightRelation.mId from QxRoleRightRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxRoleRightRelation where {1} and mId not in (Select top {2} mId from QxRoleRightRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxRoleRightRelation where {1} and mId not in (Select top {3} mId from QxRoleRightRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxRoleRightRelation a where {0} And a.mId not in (Select Top {2} mId From QxRoleRightRelation Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxRoleRightRelation a where {0} And a.mId not in (Select Top {2} mId From QxRoleRightRelation Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxRoleRightRelation a where {0} And a.mId not in (Select Top {2} mId From QxRoleRightRelation Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxRoleRightRelation a where {0} And a.mId not in (Select Top {2} mId From QxRoleRightRelation Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelationByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRoleRightRelation_SelectByCond",values);
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
public List<clsQxRoleRightRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA:GetObjLst)", objException.Message));
}
List<clsQxRoleRightRelationEN> arrObjLst = new List<clsQxRoleRightRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleRightRelationEN objQxRoleRightRelationEN = new clsQxRoleRightRelationEN();
try
{
objQxRoleRightRelationEN.mId = TransNullToInt(objRow[conQxRoleRightRelation.mId].ToString().Trim()); //流水号
objQxRoleRightRelationEN.MyRoleId = objRow[conQxRoleRightRelation.MyRoleId].ToString().Trim(); //主角色Id
objQxRoleRightRelationEN.RoleId = objRow[conQxRoleRightRelation.RoleId].ToString().Trim(); //角色Id
objQxRoleRightRelationEN.QxPrjId = objRow[conQxRoleRightRelation.QxPrjId].ToString().Trim(); //项目Id
objQxRoleRightRelationEN.UpdDate = objRow[conQxRoleRightRelation.UpdDate].ToString().Trim(); //修改日期
objQxRoleRightRelationEN.UpdUser = objRow[conQxRoleRightRelation.UpdUser].ToString().Trim(); //修改用户
objQxRoleRightRelationEN.Memo = objRow[conQxRoleRightRelation.Memo] == DBNull.Value ? null : objRow[conQxRoleRightRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxRoleRightRelationDA: GetObjLst)", objException.Message));
}
objQxRoleRightRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRoleRightRelationEN);
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
public List<clsQxRoleRightRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxRoleRightRelationEN> arrObjLst = new List<clsQxRoleRightRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleRightRelationEN objQxRoleRightRelationEN = new clsQxRoleRightRelationEN();
try
{
objQxRoleRightRelationEN.mId = TransNullToInt(objRow[conQxRoleRightRelation.mId].ToString().Trim()); //流水号
objQxRoleRightRelationEN.MyRoleId = objRow[conQxRoleRightRelation.MyRoleId].ToString().Trim(); //主角色Id
objQxRoleRightRelationEN.RoleId = objRow[conQxRoleRightRelation.RoleId].ToString().Trim(); //角色Id
objQxRoleRightRelationEN.QxPrjId = objRow[conQxRoleRightRelation.QxPrjId].ToString().Trim(); //项目Id
objQxRoleRightRelationEN.UpdDate = objRow[conQxRoleRightRelation.UpdDate].ToString().Trim(); //修改日期
objQxRoleRightRelationEN.UpdUser = objRow[conQxRoleRightRelation.UpdUser].ToString().Trim(); //修改用户
objQxRoleRightRelationEN.Memo = objRow[conQxRoleRightRelation.Memo] == DBNull.Value ? null : objRow[conQxRoleRightRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxRoleRightRelationDA: GetObjLst)", objException.Message));
}
objQxRoleRightRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRoleRightRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxRoleRightRelationEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA:GetObjLstBySP)", objException.Message));
}
List<clsQxRoleRightRelationEN> arrObjLst = new List<clsQxRoleRightRelationEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRoleRightRelation_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleRightRelationEN objQxRoleRightRelationEN = new clsQxRoleRightRelationEN();
try
{
objQxRoleRightRelationEN.mId = TransNullToInt(objRow[conQxRoleRightRelation.mId].ToString().Trim()); //流水号
objQxRoleRightRelationEN.MyRoleId = objRow[conQxRoleRightRelation.MyRoleId].ToString().Trim(); //主角色Id
objQxRoleRightRelationEN.RoleId = objRow[conQxRoleRightRelation.RoleId].ToString().Trim(); //角色Id
objQxRoleRightRelationEN.QxPrjId = objRow[conQxRoleRightRelation.QxPrjId].ToString().Trim(); //项目Id
objQxRoleRightRelationEN.UpdDate = objRow[conQxRoleRightRelation.UpdDate].ToString().Trim(); //修改日期
objQxRoleRightRelationEN.UpdUser = objRow[conQxRoleRightRelation.UpdUser].ToString().Trim(); //修改用户
objQxRoleRightRelationEN.Memo = objRow[conQxRoleRightRelation.Memo] == DBNull.Value ? null : objRow[conQxRoleRightRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxRoleRightRelationDA: GetObjLstBySP)", objException.Message));
}
objQxRoleRightRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxRoleRightRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxRoleRightRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxRoleRightRelation(ref clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where mId = " + ""+ objQxRoleRightRelationEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxRoleRightRelationEN.mId = TransNullToInt(objDT.Rows[0][conQxRoleRightRelation.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxRoleRightRelationEN.MyRoleId = objDT.Rows[0][conQxRoleRightRelation.MyRoleId].ToString().Trim(); //主角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRoleRightRelationEN.RoleId = objDT.Rows[0][conQxRoleRightRelation.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRoleRightRelationEN.QxPrjId = objDT.Rows[0][conQxRoleRightRelation.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRoleRightRelationEN.UpdDate = objDT.Rows[0][conQxRoleRightRelation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRoleRightRelationEN.UpdUser = objDT.Rows[0][conQxRoleRightRelation.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxRoleRightRelationEN.Memo = objDT.Rows[0][conQxRoleRightRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxRoleRightRelationDA: GetQxRoleRightRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxRoleRightRelationEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxRoleRightRelationEN objQxRoleRightRelationEN = new clsQxRoleRightRelationEN();
try
{
 objQxRoleRightRelationEN.mId = Int32.Parse(objRow[conQxRoleRightRelation.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxRoleRightRelationEN.MyRoleId = objRow[conQxRoleRightRelation.MyRoleId].ToString().Trim(); //主角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRoleRightRelationEN.RoleId = objRow[conQxRoleRightRelation.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRoleRightRelationEN.QxPrjId = objRow[conQxRoleRightRelation.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRoleRightRelationEN.UpdDate = objRow[conQxRoleRightRelation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRoleRightRelationEN.UpdUser = objRow[conQxRoleRightRelation.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxRoleRightRelationEN.Memo = objRow[conQxRoleRightRelation.Memo] == DBNull.Value ? null : objRow[conQxRoleRightRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxRoleRightRelationDA: GetObjBymId)", objException.Message));
}
return objQxRoleRightRelationEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxRoleRightRelation_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxRoleRightRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxRoleRightRelationOneBySP(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxRoleRightRelationEN.mId
};
 objDT = objSQL.ExecSpReturnDT("QxRoleRightRelation_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxRoleRightRelationEN.mId = TransNullToInt(objDT.Rows[0][conQxRoleRightRelation.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxRoleRightRelationEN.MyRoleId = objDT.Rows[0][conQxRoleRightRelation.MyRoleId].ToString().Trim(); //主角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRoleRightRelationEN.RoleId = objDT.Rows[0][conQxRoleRightRelation.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQxRoleRightRelationEN.QxPrjId = objDT.Rows[0][conQxRoleRightRelation.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxRoleRightRelationEN.UpdDate = objDT.Rows[0][conQxRoleRightRelation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxRoleRightRelationEN.UpdUser = objDT.Rows[0][conQxRoleRightRelation.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objQxRoleRightRelationEN.Memo = objDT.Rows[0][conQxRoleRightRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxRoleRightRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxRoleRightRelationEN objQxRoleRightRelationEN = new clsQxRoleRightRelationEN()
{
mId = TransNullToInt(objRow[conQxRoleRightRelation.mId].ToString().Trim()), //流水号
MyRoleId = objRow[conQxRoleRightRelation.MyRoleId].ToString().Trim(), //主角色Id
RoleId = objRow[conQxRoleRightRelation.RoleId].ToString().Trim(), //角色Id
QxPrjId = objRow[conQxRoleRightRelation.QxPrjId].ToString().Trim(), //项目Id
UpdDate = objRow[conQxRoleRightRelation.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQxRoleRightRelation.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[conQxRoleRightRelation.Memo] == DBNull.Value ? null : objRow[conQxRoleRightRelation.Memo].ToString().Trim() //备注
};
objQxRoleRightRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRoleRightRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxRoleRightRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxRoleRightRelationEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxRoleRightRelation_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxRoleRightRelationEN objQxRoleRightRelationEN = new clsQxRoleRightRelationEN()
{
mId = TransNullToInt(objRow[conQxRoleRightRelation.mId].ToString().Trim()), //流水号
MyRoleId = objRow[conQxRoleRightRelation.MyRoleId].ToString().Trim(), //主角色Id
RoleId = objRow[conQxRoleRightRelation.RoleId].ToString().Trim(), //角色Id
QxPrjId = objRow[conQxRoleRightRelation.QxPrjId].ToString().Trim(), //项目Id
UpdDate = objRow[conQxRoleRightRelation.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQxRoleRightRelation.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[conQxRoleRightRelation.Memo] == DBNull.Value ? null : objRow[conQxRoleRightRelation.Memo].ToString().Trim() //备注
};
objQxRoleRightRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRoleRightRelationEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxRoleRightRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxRoleRightRelationEN objQxRoleRightRelationEN = new clsQxRoleRightRelationEN();
try
{
objQxRoleRightRelationEN.mId = TransNullToInt(objRow[conQxRoleRightRelation.mId].ToString().Trim()); //流水号
objQxRoleRightRelationEN.MyRoleId = objRow[conQxRoleRightRelation.MyRoleId].ToString().Trim(); //主角色Id
objQxRoleRightRelationEN.RoleId = objRow[conQxRoleRightRelation.RoleId].ToString().Trim(); //角色Id
objQxRoleRightRelationEN.QxPrjId = objRow[conQxRoleRightRelation.QxPrjId].ToString().Trim(); //项目Id
objQxRoleRightRelationEN.UpdDate = objRow[conQxRoleRightRelation.UpdDate].ToString().Trim(); //修改日期
objQxRoleRightRelationEN.UpdUser = objRow[conQxRoleRightRelation.UpdUser].ToString().Trim(); //修改用户
objQxRoleRightRelationEN.Memo = objRow[conQxRoleRightRelation.Memo] == DBNull.Value ? null : objRow[conQxRoleRightRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxRoleRightRelationDA: GetObjByDataRowQxRoleRightRelation)", objException.Message));
}
objQxRoleRightRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRoleRightRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxRoleRightRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxRoleRightRelationEN objQxRoleRightRelationEN = new clsQxRoleRightRelationEN();
try
{
objQxRoleRightRelationEN.mId = TransNullToInt(objRow[conQxRoleRightRelation.mId].ToString().Trim()); //流水号
objQxRoleRightRelationEN.MyRoleId = objRow[conQxRoleRightRelation.MyRoleId].ToString().Trim(); //主角色Id
objQxRoleRightRelationEN.RoleId = objRow[conQxRoleRightRelation.RoleId].ToString().Trim(); //角色Id
objQxRoleRightRelationEN.QxPrjId = objRow[conQxRoleRightRelation.QxPrjId].ToString().Trim(); //项目Id
objQxRoleRightRelationEN.UpdDate = objRow[conQxRoleRightRelation.UpdDate].ToString().Trim(); //修改日期
objQxRoleRightRelationEN.UpdUser = objRow[conQxRoleRightRelation.UpdUser].ToString().Trim(); //修改用户
objQxRoleRightRelationEN.Memo = objRow[conQxRoleRightRelation.Memo] == DBNull.Value ? null : objRow[conQxRoleRightRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxRoleRightRelationDA: GetObjByDataRow)", objException.Message));
}
objQxRoleRightRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxRoleRightRelationEN;
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
objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxRoleRightRelationEN._CurrTabName, conQxRoleRightRelation.mId, 8, "");
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
objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxRoleRightRelationEN._CurrTabName, conQxRoleRightRelation.mId, 8, strPrefix);
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from QxRoleRightRelation where " + strCondition;
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from QxRoleRightRelation where " + strCondition;
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxRoleRightRelation", "mId = " + ""+ lngmId+""))
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxRoleRightRelation_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxRoleRightRelation", strCondition))
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
objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxRoleRightRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
 {
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleRightRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRoleRightRelationEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxRoleRightRelation");
objRow = objDS.Tables["QxRoleRightRelation"].NewRow();
objRow[conQxRoleRightRelation.MyRoleId] = objQxRoleRightRelationEN.MyRoleId; //主角色Id
objRow[conQxRoleRightRelation.RoleId] = objQxRoleRightRelationEN.RoleId; //角色Id
objRow[conQxRoleRightRelation.QxPrjId] = objQxRoleRightRelationEN.QxPrjId; //项目Id
objRow[conQxRoleRightRelation.UpdDate] = objQxRoleRightRelationEN.UpdDate; //修改日期
objRow[conQxRoleRightRelation.UpdUser] = objQxRoleRightRelationEN.UpdUser; //修改用户
 if (objQxRoleRightRelationEN.Memo !=  "")
 {
objRow[conQxRoleRightRelation.Memo] = objQxRoleRightRelationEN.Memo; //备注
 }
objDS.Tables[clsQxRoleRightRelationEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxRoleRightRelationEN._CurrTabName);
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
 /// <param name = "objQxRoleRightRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleRightRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRoleRightRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRoleRightRelationEN.MyRoleId  ==  "")
 {
 objQxRoleRightRelationEN.MyRoleId = null;
 }
 if (objQxRoleRightRelationEN.MyRoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.MyRoleId);
 var strMyRoleId = objQxRoleRightRelationEN.MyRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMyRoleId + "'");
 }
 
 if (objQxRoleRightRelationEN.RoleId  ==  "")
 {
 objQxRoleRightRelationEN.RoleId = null;
 }
 if (objQxRoleRightRelationEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.RoleId);
 var strRoleId = objQxRoleRightRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQxRoleRightRelationEN.QxPrjId  ==  "")
 {
 objQxRoleRightRelationEN.QxPrjId = null;
 }
 if (objQxRoleRightRelationEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.QxPrjId);
 var strQxPrjId = objQxRoleRightRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRoleRightRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.UpdDate);
 var strUpdDate = objQxRoleRightRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRoleRightRelationEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.UpdUser);
 var strUpdUser = objQxRoleRightRelationEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxRoleRightRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.Memo);
 var strMemo = objQxRoleRightRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRoleRightRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxRoleRightRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleRightRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRoleRightRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRoleRightRelationEN.MyRoleId  ==  "")
 {
 objQxRoleRightRelationEN.MyRoleId = null;
 }
 if (objQxRoleRightRelationEN.MyRoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.MyRoleId);
 var strMyRoleId = objQxRoleRightRelationEN.MyRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMyRoleId + "'");
 }
 
 if (objQxRoleRightRelationEN.RoleId  ==  "")
 {
 objQxRoleRightRelationEN.RoleId = null;
 }
 if (objQxRoleRightRelationEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.RoleId);
 var strRoleId = objQxRoleRightRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQxRoleRightRelationEN.QxPrjId  ==  "")
 {
 objQxRoleRightRelationEN.QxPrjId = null;
 }
 if (objQxRoleRightRelationEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.QxPrjId);
 var strQxPrjId = objQxRoleRightRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRoleRightRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.UpdDate);
 var strUpdDate = objQxRoleRightRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRoleRightRelationEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.UpdUser);
 var strUpdUser = objQxRoleRightRelationEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxRoleRightRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.Memo);
 var strMemo = objQxRoleRightRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRoleRightRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxRoleRightRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxRoleRightRelationEN objQxRoleRightRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleRightRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRoleRightRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRoleRightRelationEN.MyRoleId  ==  "")
 {
 objQxRoleRightRelationEN.MyRoleId = null;
 }
 if (objQxRoleRightRelationEN.MyRoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.MyRoleId);
 var strMyRoleId = objQxRoleRightRelationEN.MyRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMyRoleId + "'");
 }
 
 if (objQxRoleRightRelationEN.RoleId  ==  "")
 {
 objQxRoleRightRelationEN.RoleId = null;
 }
 if (objQxRoleRightRelationEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.RoleId);
 var strRoleId = objQxRoleRightRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQxRoleRightRelationEN.QxPrjId  ==  "")
 {
 objQxRoleRightRelationEN.QxPrjId = null;
 }
 if (objQxRoleRightRelationEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.QxPrjId);
 var strQxPrjId = objQxRoleRightRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRoleRightRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.UpdDate);
 var strUpdDate = objQxRoleRightRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRoleRightRelationEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.UpdUser);
 var strUpdUser = objQxRoleRightRelationEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxRoleRightRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.Memo);
 var strMemo = objQxRoleRightRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRoleRightRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxRoleRightRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxRoleRightRelationEN objQxRoleRightRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleRightRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxRoleRightRelationEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxRoleRightRelationEN.MyRoleId  ==  "")
 {
 objQxRoleRightRelationEN.MyRoleId = null;
 }
 if (objQxRoleRightRelationEN.MyRoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.MyRoleId);
 var strMyRoleId = objQxRoleRightRelationEN.MyRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMyRoleId + "'");
 }
 
 if (objQxRoleRightRelationEN.RoleId  ==  "")
 {
 objQxRoleRightRelationEN.RoleId = null;
 }
 if (objQxRoleRightRelationEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.RoleId);
 var strRoleId = objQxRoleRightRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQxRoleRightRelationEN.QxPrjId  ==  "")
 {
 objQxRoleRightRelationEN.QxPrjId = null;
 }
 if (objQxRoleRightRelationEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.QxPrjId);
 var strQxPrjId = objQxRoleRightRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxRoleRightRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.UpdDate);
 var strUpdDate = objQxRoleRightRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxRoleRightRelationEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.UpdUser);
 var strUpdUser = objQxRoleRightRelationEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxRoleRightRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxRoleRightRelation.Memo);
 var strMemo = objQxRoleRightRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxRoleRightRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxRoleRightRelationEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxRoleRightRelationBySP(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
//通过存储过程来
//直接使用
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxRoleRightRelationEN.MyRoleId,
 objQxRoleRightRelationEN.RoleId,
 objQxRoleRightRelationEN.QxPrjId,
 objQxRoleRightRelationEN.UpdDate,
 objQxRoleRightRelationEN.UpdUser,
objQxRoleRightRelationEN.Memo
};
 objSQL.ExecSP("QxRoleRightRelation_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxRoleRightRelations(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxRoleRightRelation");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxRoleRightRelationEN._CurrTabName ].NewRow();
objRow[conQxRoleRightRelation.MyRoleId] = oRow[conQxRoleRightRelation.MyRoleId].ToString().Trim(); //主角色Id
objRow[conQxRoleRightRelation.RoleId] = oRow[conQxRoleRightRelation.RoleId].ToString().Trim(); //角色Id
objRow[conQxRoleRightRelation.QxPrjId] = oRow[conQxRoleRightRelation.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxRoleRightRelation.UpdDate] = oRow[conQxRoleRightRelation.UpdDate].ToString().Trim(); //修改日期
objRow[conQxRoleRightRelation.UpdUser] = oRow[conQxRoleRightRelation.UpdUser].ToString().Trim(); //修改用户
objRow[conQxRoleRightRelation.Memo] = oRow[conQxRoleRightRelation.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxRoleRightRelationEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxRoleRightRelationEN._CurrTabName);
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
 /// <param name = "objQxRoleRightRelationEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleRightRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleRightRelationEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxRoleRightRelation where mId = " + ""+ objQxRoleRightRelationEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxRoleRightRelationEN._CurrTabName);
if (objDS.Tables[clsQxRoleRightRelationEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objQxRoleRightRelationEN.mId+"");
return false;
}
objRow = objDS.Tables[clsQxRoleRightRelationEN._CurrTabName].Rows[0];
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.MyRoleId))
 {
objRow[conQxRoleRightRelation.MyRoleId] = objQxRoleRightRelationEN.MyRoleId; //主角色Id
 }
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.RoleId))
 {
objRow[conQxRoleRightRelation.RoleId] = objQxRoleRightRelationEN.RoleId; //角色Id
 }
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.QxPrjId))
 {
objRow[conQxRoleRightRelation.QxPrjId] = objQxRoleRightRelationEN.QxPrjId; //项目Id
 }
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.UpdDate))
 {
objRow[conQxRoleRightRelation.UpdDate] = objQxRoleRightRelationEN.UpdDate; //修改日期
 }
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.UpdUser))
 {
objRow[conQxRoleRightRelation.UpdUser] = objQxRoleRightRelationEN.UpdUser; //修改用户
 }
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.Memo))
 {
objRow[conQxRoleRightRelation.Memo] = objQxRoleRightRelationEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxRoleRightRelationEN._CurrTabName);
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
public bool UpdateBySP(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleRightRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleRightRelationEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxRoleRightRelationEN.mId,
 objQxRoleRightRelationEN.MyRoleId,
 objQxRoleRightRelationEN.RoleId,
 objQxRoleRightRelationEN.QxPrjId,
 objQxRoleRightRelationEN.UpdDate,
 objQxRoleRightRelationEN.UpdUser,
 objQxRoleRightRelationEN.Memo
};
 objSQL.ExecSP("QxRoleRightRelation_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxRoleRightRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleRightRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleRightRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxRoleRightRelation Set ");
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.MyRoleId))
 {
 if (objQxRoleRightRelationEN.MyRoleId  ==  "")
 {
 objQxRoleRightRelationEN.MyRoleId = null;
 }
 if (objQxRoleRightRelationEN.MyRoleId !=  null)
 {
 var strMyRoleId = objQxRoleRightRelationEN.MyRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMyRoleId, conQxRoleRightRelation.MyRoleId); //主角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.MyRoleId); //主角色Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.RoleId))
 {
 if (objQxRoleRightRelationEN.RoleId  ==  "")
 {
 objQxRoleRightRelationEN.RoleId = null;
 }
 if (objQxRoleRightRelationEN.RoleId !=  null)
 {
 var strRoleId = objQxRoleRightRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQxRoleRightRelation.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.RoleId); //角色Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.QxPrjId))
 {
 if (objQxRoleRightRelationEN.QxPrjId  ==  "")
 {
 objQxRoleRightRelationEN.QxPrjId = null;
 }
 if (objQxRoleRightRelationEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRoleRightRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxRoleRightRelation.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.QxPrjId); //项目Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.UpdDate))
 {
 if (objQxRoleRightRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRoleRightRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxRoleRightRelation.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.UpdDate); //修改日期
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.UpdUser))
 {
 if (objQxRoleRightRelationEN.UpdUser !=  null)
 {
 var strUpdUser = objQxRoleRightRelationEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxRoleRightRelation.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.UpdUser); //修改用户
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.Memo))
 {
 if (objQxRoleRightRelationEN.Memo !=  null)
 {
 var strMemo = objQxRoleRightRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxRoleRightRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxRoleRightRelationEN.mId); 
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
 /// <param name = "objQxRoleRightRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxRoleRightRelationEN objQxRoleRightRelationEN, string strCondition)
{
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleRightRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleRightRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRoleRightRelation Set ");
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.MyRoleId))
 {
 if (objQxRoleRightRelationEN.MyRoleId  ==  "")
 {
 objQxRoleRightRelationEN.MyRoleId = null;
 }
 if (objQxRoleRightRelationEN.MyRoleId !=  null)
 {
 var strMyRoleId = objQxRoleRightRelationEN.MyRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MyRoleId = '{0}',", strMyRoleId); //主角色Id
 }
 else
 {
 sbSQL.Append(" MyRoleId = null,"); //主角色Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.RoleId))
 {
 if (objQxRoleRightRelationEN.RoleId  ==  "")
 {
 objQxRoleRightRelationEN.RoleId = null;
 }
 if (objQxRoleRightRelationEN.RoleId !=  null)
 {
 var strRoleId = objQxRoleRightRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.QxPrjId))
 {
 if (objQxRoleRightRelationEN.QxPrjId  ==  "")
 {
 objQxRoleRightRelationEN.QxPrjId = null;
 }
 if (objQxRoleRightRelationEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRoleRightRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.UpdDate))
 {
 if (objQxRoleRightRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRoleRightRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.UpdUser))
 {
 if (objQxRoleRightRelationEN.UpdUser !=  null)
 {
 var strUpdUser = objQxRoleRightRelationEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.Memo))
 {
 if (objQxRoleRightRelationEN.Memo !=  null)
 {
 var strMemo = objQxRoleRightRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxRoleRightRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxRoleRightRelationEN objQxRoleRightRelationEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleRightRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleRightRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRoleRightRelation Set ");
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.MyRoleId))
 {
 if (objQxRoleRightRelationEN.MyRoleId  ==  "")
 {
 objQxRoleRightRelationEN.MyRoleId = null;
 }
 if (objQxRoleRightRelationEN.MyRoleId !=  null)
 {
 var strMyRoleId = objQxRoleRightRelationEN.MyRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MyRoleId = '{0}',", strMyRoleId); //主角色Id
 }
 else
 {
 sbSQL.Append(" MyRoleId = null,"); //主角色Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.RoleId))
 {
 if (objQxRoleRightRelationEN.RoleId  ==  "")
 {
 objQxRoleRightRelationEN.RoleId = null;
 }
 if (objQxRoleRightRelationEN.RoleId !=  null)
 {
 var strRoleId = objQxRoleRightRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.QxPrjId))
 {
 if (objQxRoleRightRelationEN.QxPrjId  ==  "")
 {
 objQxRoleRightRelationEN.QxPrjId = null;
 }
 if (objQxRoleRightRelationEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRoleRightRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.UpdDate))
 {
 if (objQxRoleRightRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRoleRightRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.UpdUser))
 {
 if (objQxRoleRightRelationEN.UpdUser !=  null)
 {
 var strUpdUser = objQxRoleRightRelationEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.Memo))
 {
 if (objQxRoleRightRelationEN.Memo !=  null)
 {
 var strMemo = objQxRoleRightRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxRoleRightRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxRoleRightRelationEN objQxRoleRightRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxRoleRightRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxRoleRightRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxRoleRightRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxRoleRightRelation Set ");
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.MyRoleId))
 {
 if (objQxRoleRightRelationEN.MyRoleId  ==  "")
 {
 objQxRoleRightRelationEN.MyRoleId = null;
 }
 if (objQxRoleRightRelationEN.MyRoleId !=  null)
 {
 var strMyRoleId = objQxRoleRightRelationEN.MyRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMyRoleId, conQxRoleRightRelation.MyRoleId); //主角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.MyRoleId); //主角色Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.RoleId))
 {
 if (objQxRoleRightRelationEN.RoleId  ==  "")
 {
 objQxRoleRightRelationEN.RoleId = null;
 }
 if (objQxRoleRightRelationEN.RoleId !=  null)
 {
 var strRoleId = objQxRoleRightRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQxRoleRightRelation.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.RoleId); //角色Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.QxPrjId))
 {
 if (objQxRoleRightRelationEN.QxPrjId  ==  "")
 {
 objQxRoleRightRelationEN.QxPrjId = null;
 }
 if (objQxRoleRightRelationEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxRoleRightRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxRoleRightRelation.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.QxPrjId); //项目Id
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.UpdDate))
 {
 if (objQxRoleRightRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objQxRoleRightRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxRoleRightRelation.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.UpdDate); //修改日期
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.UpdUser))
 {
 if (objQxRoleRightRelationEN.UpdUser !=  null)
 {
 var strUpdUser = objQxRoleRightRelationEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxRoleRightRelation.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.UpdUser); //修改用户
 }
 }
 
 if (objQxRoleRightRelationEN.IsUpdated(conQxRoleRightRelation.Memo))
 {
 if (objQxRoleRightRelationEN.Memo !=  null)
 {
 var strMemo = objQxRoleRightRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxRoleRightRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxRoleRightRelation.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxRoleRightRelationEN.mId); 
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("QxRoleRightRelation_Delete", values);
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
//删除QxRoleRightRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRoleRightRelation where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxRoleRightRelation(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
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
//删除QxRoleRightRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRoleRightRelation where mId in (" + strKeyList + ")";
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
//删除QxRoleRightRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxRoleRightRelation where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxRoleRightRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: DelQxRoleRightRelation)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxRoleRightRelation where " + strCondition ;
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
public bool DelQxRoleRightRelationWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxRoleRightRelationDA: DelQxRoleRightRelationWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxRoleRightRelation where " + strCondition ;
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
 /// <param name = "objQxRoleRightRelationENS">源对象</param>
 /// <param name = "objQxRoleRightRelationENT">目标对象</param>
public void CopyTo(clsQxRoleRightRelationEN objQxRoleRightRelationENS, clsQxRoleRightRelationEN objQxRoleRightRelationENT)
{
objQxRoleRightRelationENT.mId = objQxRoleRightRelationENS.mId; //流水号
objQxRoleRightRelationENT.MyRoleId = objQxRoleRightRelationENS.MyRoleId; //主角色Id
objQxRoleRightRelationENT.RoleId = objQxRoleRightRelationENS.RoleId; //角色Id
objQxRoleRightRelationENT.QxPrjId = objQxRoleRightRelationENS.QxPrjId; //项目Id
objQxRoleRightRelationENT.UpdDate = objQxRoleRightRelationENS.UpdDate; //修改日期
objQxRoleRightRelationENT.UpdUser = objQxRoleRightRelationENS.UpdUser; //修改用户
objQxRoleRightRelationENT.Memo = objQxRoleRightRelationENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxRoleRightRelationEN.MyRoleId, conQxRoleRightRelation.MyRoleId);
clsCheckSql.CheckFieldNotNull(objQxRoleRightRelationEN.RoleId, conQxRoleRightRelation.RoleId);
clsCheckSql.CheckFieldNotNull(objQxRoleRightRelationEN.QxPrjId, conQxRoleRightRelation.QxPrjId);
clsCheckSql.CheckFieldNotNull(objQxRoleRightRelationEN.UpdDate, conQxRoleRightRelation.UpdDate);
clsCheckSql.CheckFieldNotNull(objQxRoleRightRelationEN.UpdUser, conQxRoleRightRelation.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.MyRoleId, 8, conQxRoleRightRelation.MyRoleId);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.RoleId, 8, conQxRoleRightRelation.RoleId);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.QxPrjId, 4, conQxRoleRightRelation.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.UpdDate, 20, conQxRoleRightRelation.UpdDate);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.UpdUser, 20, conQxRoleRightRelation.UpdUser);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.Memo, 1000, conQxRoleRightRelation.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxRoleRightRelationEN.MyRoleId, 8, conQxRoleRightRelation.MyRoleId);
clsCheckSql.CheckFieldForeignKey(objQxRoleRightRelationEN.RoleId, 8, conQxRoleRightRelation.RoleId);
clsCheckSql.CheckFieldForeignKey(objQxRoleRightRelationEN.QxPrjId, 4, conQxRoleRightRelation.QxPrjId);
 objQxRoleRightRelationEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.MyRoleId, 8, conQxRoleRightRelation.MyRoleId);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.RoleId, 8, conQxRoleRightRelation.RoleId);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.QxPrjId, 4, conQxRoleRightRelation.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.UpdDate, 20, conQxRoleRightRelation.UpdDate);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.UpdUser, 20, conQxRoleRightRelation.UpdUser);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.Memo, 1000, conQxRoleRightRelation.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxRoleRightRelationEN.MyRoleId, 8, conQxRoleRightRelation.MyRoleId);
clsCheckSql.CheckFieldForeignKey(objQxRoleRightRelationEN.RoleId, 8, conQxRoleRightRelation.RoleId);
clsCheckSql.CheckFieldForeignKey(objQxRoleRightRelationEN.QxPrjId, 4, conQxRoleRightRelation.QxPrjId);
 objQxRoleRightRelationEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.MyRoleId, 8, conQxRoleRightRelation.MyRoleId);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.RoleId, 8, conQxRoleRightRelation.RoleId);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.QxPrjId, 4, conQxRoleRightRelation.QxPrjId);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.UpdDate, 20, conQxRoleRightRelation.UpdDate);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.UpdUser, 20, conQxRoleRightRelation.UpdUser);
clsCheckSql.CheckFieldLen(objQxRoleRightRelationEN.Memo, 1000, conQxRoleRightRelation.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxRoleRightRelationEN.MyRoleId, conQxRoleRightRelation.MyRoleId);
clsCheckSql.CheckSqlInjection4Field(objQxRoleRightRelationEN.RoleId, conQxRoleRightRelation.RoleId);
clsCheckSql.CheckSqlInjection4Field(objQxRoleRightRelationEN.QxPrjId, conQxRoleRightRelation.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxRoleRightRelationEN.UpdDate, conQxRoleRightRelation.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxRoleRightRelationEN.UpdUser, conQxRoleRightRelation.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQxRoleRightRelationEN.Memo, conQxRoleRightRelation.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxRoleRightRelationEN.MyRoleId, 8, conQxRoleRightRelation.MyRoleId);
clsCheckSql.CheckFieldForeignKey(objQxRoleRightRelationEN.RoleId, 8, conQxRoleRightRelation.RoleId);
clsCheckSql.CheckFieldForeignKey(objQxRoleRightRelationEN.QxPrjId, 4, conQxRoleRightRelation.QxPrjId);
 objQxRoleRightRelationEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxRoleRightRelation(角色赋权关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxRoleRightRelationEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxRoleRightRelationEN objQxRoleRightRelationEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MyRoleId = '{0}'", objQxRoleRightRelationEN.MyRoleId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxRoleRightRelationEN.RoleId);
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxRoleRightRelationEN._CurrTabName);
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxRoleRightRelationEN._CurrTabName, strCondition);
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
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
 objSQL = clsQxRoleRightRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}