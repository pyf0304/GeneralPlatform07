
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserGroupRelationDA
 表名:QxUserGroupRelation(00140009)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:21:23
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
 /// 用户/组关系(QxUserGroupRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxUserGroupRelationDA : clsCommBase4DA
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
 return clsQxUserGroupRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxUserGroupRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUserGroupRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxUserGroupRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxUserGroupRelationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
 strSQL = "Select * from QxUserGroupRelation where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxUserGroupRelation");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxUserGroupRelation_SelectByCond",values, "QxUserGroupRelation");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUserGroupRelation where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxUserGroupRelation");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUserGroupRelation a where {0} And a.mId not in (Select Top {2} mId From QxUserGroupRelation Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUserGroupRelation");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUserGroupRelation a where {0} And a.mId not in (Select Top {2} mId From QxUserGroupRelation Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUserGroupRelation");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxUserGroupRelation a where {0} And a.mId not in (Select Top {2} mId From QxUserGroupRelation Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxUserGroupRelation");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxUserGroupRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTable_QxUserGroupRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserGroupRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserGroupRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUserGroupRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUserGroupRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUserGroupRelation.* from QxUserGroupRelation Left Join {1} on {2} where {3} and QxUserGroupRelation.mId not in (Select top {5} QxUserGroupRelation.mId from QxUserGroupRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserGroupRelation where {1} and mId not in (Select top {2} mId from QxUserGroupRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserGroupRelation where {1} and mId not in (Select top {3} mId from QxUserGroupRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUserGroupRelation.* from QxUserGroupRelation Left Join {1} on {2} where {3} and QxUserGroupRelation.mId not in (Select top {5} QxUserGroupRelation.mId from QxUserGroupRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserGroupRelation where {1} and mId not in (Select top {2} mId from QxUserGroupRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserGroupRelation where {1} and mId not in (Select top {3} mId from QxUserGroupRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUserGroupRelation.* from QxUserGroupRelation Left Join {1} on {2} where {3} and QxUserGroupRelation.mId not in (Select top {5} QxUserGroupRelation.mId from QxUserGroupRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserGroupRelation where {1} and mId not in (Select top {2} mId from QxUserGroupRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserGroupRelation where {1} and mId not in (Select top {3} mId from QxUserGroupRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUserGroupRelation a where {0} And a.mId not in (Select Top {2} mId From QxUserGroupRelation Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUserGroupRelation a where {0} And a.mId not in (Select Top {2} mId From QxUserGroupRelation Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxUserGroupRelation a where {0} And a.mId not in (Select Top {2} mId From QxUserGroupRelation Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxUserGroupRelation a where {0} And a.mId not in (Select Top {2} mId From QxUserGroupRelation Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelationByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUserGroupRelation_SelectByCond",values);
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
public List<clsQxUserGroupRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA:GetObjLst)", objException.Message));
}
List<clsQxUserGroupRelationEN> arrObjLst = new List<clsQxUserGroupRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupRelationEN objQxUserGroupRelationEN = new clsQxUserGroupRelationEN();
try
{
objQxUserGroupRelationEN.mId = TransNullToInt(objRow[conQxUserGroupRelation.mId].ToString().Trim()); //流水号
objQxUserGroupRelationEN.UserId = objRow[conQxUserGroupRelation.UserId].ToString().Trim(); //用户ID
objQxUserGroupRelationEN.GroupId = objRow[conQxUserGroupRelation.GroupId].ToString().Trim(); //组Id
objQxUserGroupRelationEN.Memo = objRow[conQxUserGroupRelation.Memo] == DBNull.Value ? null : objRow[conQxUserGroupRelation.Memo].ToString().Trim(); //备注
objQxUserGroupRelationEN.QxPrjId = objRow[conQxUserGroupRelation.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupRelationEN.ManageId = objRow[conQxUserGroupRelation.ManageId].ToString().Trim(); //ManageId
objQxUserGroupRelationEN.ManageTypeId = objRow[conQxUserGroupRelation.ManageTypeId].ToString().Trim(); //ManageTypeId
objQxUserGroupRelationEN.IsDefault = TransNullToBool(objRow[conQxUserGroupRelation.IsDefault].ToString().Trim()); //是否默认
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUserGroupRelationDA: GetObjLst)", objException.Message));
}
objQxUserGroupRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUserGroupRelationEN);
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
public List<clsQxUserGroupRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxUserGroupRelationEN> arrObjLst = new List<clsQxUserGroupRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupRelationEN objQxUserGroupRelationEN = new clsQxUserGroupRelationEN();
try
{
objQxUserGroupRelationEN.mId = TransNullToInt(objRow[conQxUserGroupRelation.mId].ToString().Trim()); //流水号
objQxUserGroupRelationEN.UserId = objRow[conQxUserGroupRelation.UserId].ToString().Trim(); //用户ID
objQxUserGroupRelationEN.GroupId = objRow[conQxUserGroupRelation.GroupId].ToString().Trim(); //组Id
objQxUserGroupRelationEN.Memo = objRow[conQxUserGroupRelation.Memo] == DBNull.Value ? null : objRow[conQxUserGroupRelation.Memo].ToString().Trim(); //备注
objQxUserGroupRelationEN.QxPrjId = objRow[conQxUserGroupRelation.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupRelationEN.ManageId = objRow[conQxUserGroupRelation.ManageId].ToString().Trim(); //ManageId
objQxUserGroupRelationEN.ManageTypeId = objRow[conQxUserGroupRelation.ManageTypeId].ToString().Trim(); //ManageTypeId
objQxUserGroupRelationEN.IsDefault = TransNullToBool(objRow[conQxUserGroupRelation.IsDefault].ToString().Trim()); //是否默认
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUserGroupRelationDA: GetObjLst)", objException.Message));
}
objQxUserGroupRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUserGroupRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxUserGroupRelationEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA:GetObjLstBySP)", objException.Message));
}
List<clsQxUserGroupRelationEN> arrObjLst = new List<clsQxUserGroupRelationEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUserGroupRelation_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupRelationEN objQxUserGroupRelationEN = new clsQxUserGroupRelationEN();
try
{
objQxUserGroupRelationEN.mId = TransNullToInt(objRow[conQxUserGroupRelation.mId].ToString().Trim()); //流水号
objQxUserGroupRelationEN.UserId = objRow[conQxUserGroupRelation.UserId].ToString().Trim(); //用户ID
objQxUserGroupRelationEN.GroupId = objRow[conQxUserGroupRelation.GroupId].ToString().Trim(); //组Id
objQxUserGroupRelationEN.Memo = objRow[conQxUserGroupRelation.Memo] == DBNull.Value ? null : objRow[conQxUserGroupRelation.Memo].ToString().Trim(); //备注
objQxUserGroupRelationEN.QxPrjId = objRow[conQxUserGroupRelation.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupRelationEN.ManageId = objRow[conQxUserGroupRelation.ManageId].ToString().Trim(); //ManageId
objQxUserGroupRelationEN.ManageTypeId = objRow[conQxUserGroupRelation.ManageTypeId].ToString().Trim(); //ManageTypeId
objQxUserGroupRelationEN.IsDefault = TransNullToBool(objRow[conQxUserGroupRelation.IsDefault].ToString().Trim()); //是否默认
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxUserGroupRelationDA: GetObjLstBySP)", objException.Message));
}
objQxUserGroupRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUserGroupRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxUserGroupRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUserGroupRelation(ref clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where mId = " + ""+ objQxUserGroupRelationEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxUserGroupRelationEN.mId = TransNullToInt(objDT.Rows[0][conQxUserGroupRelation.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxUserGroupRelationEN.UserId = objDT.Rows[0][conQxUserGroupRelation.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserGroupRelationEN.GroupId = objDT.Rows[0][conQxUserGroupRelation.GroupId].ToString().Trim(); //组Id(字段类型:char,字段长度:8,是否可空:True)
 objQxUserGroupRelationEN.Memo = objDT.Rows[0][conQxUserGroupRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxUserGroupRelationEN.QxPrjId = objDT.Rows[0][conQxUserGroupRelation.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxUserGroupRelationEN.ManageId = objDT.Rows[0][conQxUserGroupRelation.ManageId].ToString().Trim(); //ManageId(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserGroupRelationEN.ManageTypeId = objDT.Rows[0][conQxUserGroupRelation.ManageTypeId].ToString().Trim(); //ManageTypeId(字段类型:char,字段长度:4,是否可空:False)
 objQxUserGroupRelationEN.IsDefault = TransNullToBool(objDT.Rows[0][conQxUserGroupRelation.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxUserGroupRelationDA: GetQxUserGroupRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxUserGroupRelationEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxUserGroupRelationEN objQxUserGroupRelationEN = new clsQxUserGroupRelationEN();
try
{
 objQxUserGroupRelationEN.mId = Int32.Parse(objRow[conQxUserGroupRelation.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxUserGroupRelationEN.UserId = objRow[conQxUserGroupRelation.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserGroupRelationEN.GroupId = objRow[conQxUserGroupRelation.GroupId].ToString().Trim(); //组Id(字段类型:char,字段长度:8,是否可空:True)
 objQxUserGroupRelationEN.Memo = objRow[conQxUserGroupRelation.Memo] == DBNull.Value ? null : objRow[conQxUserGroupRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxUserGroupRelationEN.QxPrjId = objRow[conQxUserGroupRelation.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxUserGroupRelationEN.ManageId = objRow[conQxUserGroupRelation.ManageId].ToString().Trim(); //ManageId(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserGroupRelationEN.ManageTypeId = objRow[conQxUserGroupRelation.ManageTypeId].ToString().Trim(); //ManageTypeId(字段类型:char,字段长度:4,是否可空:False)
 objQxUserGroupRelationEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxUserGroupRelation.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxUserGroupRelationDA: GetObjBymId)", objException.Message));
}
return objQxUserGroupRelationEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxUserGroupRelation_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxUserGroupRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUserGroupRelationOneBySP(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxUserGroupRelationEN.mId
};
 objDT = objSQL.ExecSpReturnDT("QxUserGroupRelation_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxUserGroupRelationEN.mId = TransNullToInt(objDT.Rows[0][conQxUserGroupRelation.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objQxUserGroupRelationEN.UserId = objDT.Rows[0][conQxUserGroupRelation.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserGroupRelationEN.GroupId = objDT.Rows[0][conQxUserGroupRelation.GroupId].ToString().Trim(); //组Id(字段类型:char,字段长度:8,是否可空:True)
 objQxUserGroupRelationEN.Memo = objDT.Rows[0][conQxUserGroupRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxUserGroupRelationEN.QxPrjId = objDT.Rows[0][conQxUserGroupRelation.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxUserGroupRelationEN.ManageId = objDT.Rows[0][conQxUserGroupRelation.ManageId].ToString().Trim(); //ManageId(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserGroupRelationEN.ManageTypeId = objDT.Rows[0][conQxUserGroupRelation.ManageTypeId].ToString().Trim(); //ManageTypeId(字段类型:char,字段长度:4,是否可空:False)
 objQxUserGroupRelationEN.IsDefault = TransNullToBool(objDT.Rows[0][conQxUserGroupRelation.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:False)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUserGroupRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxUserGroupRelationEN objQxUserGroupRelationEN = new clsQxUserGroupRelationEN()
{
mId = TransNullToInt(objRow[conQxUserGroupRelation.mId].ToString().Trim()), //流水号
UserId = objRow[conQxUserGroupRelation.UserId].ToString().Trim(), //用户ID
GroupId = objRow[conQxUserGroupRelation.GroupId].ToString().Trim(), //组Id
Memo = objRow[conQxUserGroupRelation.Memo] == DBNull.Value ? null : objRow[conQxUserGroupRelation.Memo].ToString().Trim(), //备注
QxPrjId = objRow[conQxUserGroupRelation.QxPrjId].ToString().Trim(), //项目Id
ManageId = objRow[conQxUserGroupRelation.ManageId].ToString().Trim(), //ManageId
ManageTypeId = objRow[conQxUserGroupRelation.ManageTypeId].ToString().Trim(), //ManageTypeId
IsDefault = TransNullToBool(objRow[conQxUserGroupRelation.IsDefault].ToString().Trim()) //是否默认
};
objQxUserGroupRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserGroupRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxUserGroupRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUserGroupRelationEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxUserGroupRelation_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxUserGroupRelationEN objQxUserGroupRelationEN = new clsQxUserGroupRelationEN()
{
mId = TransNullToInt(objRow[conQxUserGroupRelation.mId].ToString().Trim()), //流水号
UserId = objRow[conQxUserGroupRelation.UserId].ToString().Trim(), //用户ID
GroupId = objRow[conQxUserGroupRelation.GroupId].ToString().Trim(), //组Id
Memo = objRow[conQxUserGroupRelation.Memo] == DBNull.Value ? null : objRow[conQxUserGroupRelation.Memo].ToString().Trim(), //备注
QxPrjId = objRow[conQxUserGroupRelation.QxPrjId].ToString().Trim(), //项目Id
ManageId = objRow[conQxUserGroupRelation.ManageId].ToString().Trim(), //ManageId
ManageTypeId = objRow[conQxUserGroupRelation.ManageTypeId].ToString().Trim(), //ManageTypeId
IsDefault = TransNullToBool(objRow[conQxUserGroupRelation.IsDefault].ToString().Trim()) //是否默认
};
objQxUserGroupRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserGroupRelationEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxUserGroupRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUserGroupRelationEN objQxUserGroupRelationEN = new clsQxUserGroupRelationEN();
try
{
objQxUserGroupRelationEN.mId = TransNullToInt(objRow[conQxUserGroupRelation.mId].ToString().Trim()); //流水号
objQxUserGroupRelationEN.UserId = objRow[conQxUserGroupRelation.UserId].ToString().Trim(); //用户ID
objQxUserGroupRelationEN.GroupId = objRow[conQxUserGroupRelation.GroupId].ToString().Trim(); //组Id
objQxUserGroupRelationEN.Memo = objRow[conQxUserGroupRelation.Memo] == DBNull.Value ? null : objRow[conQxUserGroupRelation.Memo].ToString().Trim(); //备注
objQxUserGroupRelationEN.QxPrjId = objRow[conQxUserGroupRelation.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupRelationEN.ManageId = objRow[conQxUserGroupRelation.ManageId].ToString().Trim(); //ManageId
objQxUserGroupRelationEN.ManageTypeId = objRow[conQxUserGroupRelation.ManageTypeId].ToString().Trim(); //ManageTypeId
objQxUserGroupRelationEN.IsDefault = TransNullToBool(objRow[conQxUserGroupRelation.IsDefault].ToString().Trim()); //是否默认
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxUserGroupRelationDA: GetObjByDataRowQxUserGroupRelation)", objException.Message));
}
objQxUserGroupRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserGroupRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxUserGroupRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUserGroupRelationEN objQxUserGroupRelationEN = new clsQxUserGroupRelationEN();
try
{
objQxUserGroupRelationEN.mId = TransNullToInt(objRow[conQxUserGroupRelation.mId].ToString().Trim()); //流水号
objQxUserGroupRelationEN.UserId = objRow[conQxUserGroupRelation.UserId].ToString().Trim(); //用户ID
objQxUserGroupRelationEN.GroupId = objRow[conQxUserGroupRelation.GroupId].ToString().Trim(); //组Id
objQxUserGroupRelationEN.Memo = objRow[conQxUserGroupRelation.Memo] == DBNull.Value ? null : objRow[conQxUserGroupRelation.Memo].ToString().Trim(); //备注
objQxUserGroupRelationEN.QxPrjId = objRow[conQxUserGroupRelation.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupRelationEN.ManageId = objRow[conQxUserGroupRelation.ManageId].ToString().Trim(); //ManageId
objQxUserGroupRelationEN.ManageTypeId = objRow[conQxUserGroupRelation.ManageTypeId].ToString().Trim(); //ManageTypeId
objQxUserGroupRelationEN.IsDefault = TransNullToBool(objRow[conQxUserGroupRelation.IsDefault].ToString().Trim()); //是否默认
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxUserGroupRelationDA: GetObjByDataRow)", objException.Message));
}
objQxUserGroupRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserGroupRelationEN;
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
objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUserGroupRelationEN._CurrTabName, conQxUserGroupRelation.mId, 8, "");
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
objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUserGroupRelationEN._CurrTabName, conQxUserGroupRelation.mId, 8, strPrefix);
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from QxUserGroupRelation where " + strCondition;
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from QxUserGroupRelation where " + strCondition;
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUserGroupRelation", "mId = " + ""+ lngmId+""))
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxUserGroupRelation_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUserGroupRelation", strCondition))
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
objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxUserGroupRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
 {
 if (objQxUserGroupRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserGroupRelationEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUserGroupRelation");
objRow = objDS.Tables["QxUserGroupRelation"].NewRow();
objRow[conQxUserGroupRelation.UserId] = objQxUserGroupRelationEN.UserId; //用户ID
objRow[conQxUserGroupRelation.GroupId] = objQxUserGroupRelationEN.GroupId; //组Id
 if (objQxUserGroupRelationEN.Memo !=  "")
 {
objRow[conQxUserGroupRelation.Memo] = objQxUserGroupRelationEN.Memo; //备注
 }
objRow[conQxUserGroupRelation.QxPrjId] = objQxUserGroupRelationEN.QxPrjId; //项目Id
objRow[conQxUserGroupRelation.ManageId] = objQxUserGroupRelationEN.ManageId; //ManageId
objRow[conQxUserGroupRelation.ManageTypeId] = objQxUserGroupRelationEN.ManageTypeId; //ManageTypeId
objRow[conQxUserGroupRelation.IsDefault] = objQxUserGroupRelationEN.IsDefault; //是否默认
objDS.Tables[clsQxUserGroupRelationEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxUserGroupRelationEN._CurrTabName);
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
 /// <param name = "objQxUserGroupRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
 if (objQxUserGroupRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserGroupRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserGroupRelationEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.UserId);
 var strUserId = objQxUserGroupRelationEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserGroupRelationEN.GroupId  ==  "")
 {
 objQxUserGroupRelationEN.GroupId = null;
 }
 if (objQxUserGroupRelationEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.GroupId);
 var strGroupId = objQxUserGroupRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objQxUserGroupRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.Memo);
 var strMemo = objQxUserGroupRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxUserGroupRelationEN.QxPrjId  ==  "")
 {
 objQxUserGroupRelationEN.QxPrjId = null;
 }
 if (objQxUserGroupRelationEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.QxPrjId);
 var strQxPrjId = objQxUserGroupRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxUserGroupRelationEN.ManageId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.ManageId);
 var strManageId = objQxUserGroupRelationEN.ManageId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManageId + "'");
 }
 
 if (objQxUserGroupRelationEN.ManageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.ManageTypeId);
 var strManageTypeId = objQxUserGroupRelationEN.ManageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManageTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserGroupRelation.IsDefault);
 arrValueListForInsert.Add("'" + (objQxUserGroupRelationEN.IsDefault  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserGroupRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUserGroupRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
 if (objQxUserGroupRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserGroupRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserGroupRelationEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.UserId);
 var strUserId = objQxUserGroupRelationEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserGroupRelationEN.GroupId  ==  "")
 {
 objQxUserGroupRelationEN.GroupId = null;
 }
 if (objQxUserGroupRelationEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.GroupId);
 var strGroupId = objQxUserGroupRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objQxUserGroupRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.Memo);
 var strMemo = objQxUserGroupRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxUserGroupRelationEN.QxPrjId  ==  "")
 {
 objQxUserGroupRelationEN.QxPrjId = null;
 }
 if (objQxUserGroupRelationEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.QxPrjId);
 var strQxPrjId = objQxUserGroupRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxUserGroupRelationEN.ManageId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.ManageId);
 var strManageId = objQxUserGroupRelationEN.ManageId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManageId + "'");
 }
 
 if (objQxUserGroupRelationEN.ManageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.ManageTypeId);
 var strManageTypeId = objQxUserGroupRelationEN.ManageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManageTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserGroupRelation.IsDefault);
 arrValueListForInsert.Add("'" + (objQxUserGroupRelationEN.IsDefault  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserGroupRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxUserGroupRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUserGroupRelationEN objQxUserGroupRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserGroupRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserGroupRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserGroupRelationEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.UserId);
 var strUserId = objQxUserGroupRelationEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserGroupRelationEN.GroupId  ==  "")
 {
 objQxUserGroupRelationEN.GroupId = null;
 }
 if (objQxUserGroupRelationEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.GroupId);
 var strGroupId = objQxUserGroupRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objQxUserGroupRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.Memo);
 var strMemo = objQxUserGroupRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxUserGroupRelationEN.QxPrjId  ==  "")
 {
 objQxUserGroupRelationEN.QxPrjId = null;
 }
 if (objQxUserGroupRelationEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.QxPrjId);
 var strQxPrjId = objQxUserGroupRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxUserGroupRelationEN.ManageId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.ManageId);
 var strManageId = objQxUserGroupRelationEN.ManageId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManageId + "'");
 }
 
 if (objQxUserGroupRelationEN.ManageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.ManageTypeId);
 var strManageTypeId = objQxUserGroupRelationEN.ManageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManageTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserGroupRelation.IsDefault);
 arrValueListForInsert.Add("'" + (objQxUserGroupRelationEN.IsDefault  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserGroupRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxUserGroupRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUserGroupRelationEN objQxUserGroupRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQxUserGroupRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserGroupRelationEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserGroupRelationEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.UserId);
 var strUserId = objQxUserGroupRelationEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserGroupRelationEN.GroupId  ==  "")
 {
 objQxUserGroupRelationEN.GroupId = null;
 }
 if (objQxUserGroupRelationEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.GroupId);
 var strGroupId = objQxUserGroupRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objQxUserGroupRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.Memo);
 var strMemo = objQxUserGroupRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQxUserGroupRelationEN.QxPrjId  ==  "")
 {
 objQxUserGroupRelationEN.QxPrjId = null;
 }
 if (objQxUserGroupRelationEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.QxPrjId);
 var strQxPrjId = objQxUserGroupRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxUserGroupRelationEN.ManageId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.ManageId);
 var strManageId = objQxUserGroupRelationEN.ManageId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManageId + "'");
 }
 
 if (objQxUserGroupRelationEN.ManageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserGroupRelation.ManageTypeId);
 var strManageTypeId = objQxUserGroupRelationEN.ManageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManageTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conQxUserGroupRelation.IsDefault);
 arrValueListForInsert.Add("'" + (objQxUserGroupRelationEN.IsDefault  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserGroupRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxUserGroupRelationEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxUserGroupRelationBySP(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUserGroupRelationEN.UserId,
 objQxUserGroupRelationEN.GroupId,
 objQxUserGroupRelationEN.Memo,
 objQxUserGroupRelationEN.QxPrjId,
 objQxUserGroupRelationEN.ManageId,
 objQxUserGroupRelationEN.ManageTypeId,
objQxUserGroupRelationEN.IsDefault
};
 objSQL.ExecSP("QxUserGroupRelation_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxUserGroupRelations(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUserGroupRelation");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxUserGroupRelationEN._CurrTabName ].NewRow();
objRow[conQxUserGroupRelation.UserId] = oRow[conQxUserGroupRelation.UserId].ToString().Trim(); //用户ID
objRow[conQxUserGroupRelation.GroupId] = oRow[conQxUserGroupRelation.GroupId].ToString().Trim(); //组Id
objRow[conQxUserGroupRelation.Memo] = oRow[conQxUserGroupRelation.Memo].ToString().Trim(); //备注
objRow[conQxUserGroupRelation.QxPrjId] = oRow[conQxUserGroupRelation.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxUserGroupRelation.ManageId] = oRow[conQxUserGroupRelation.ManageId].ToString().Trim(); //ManageId
objRow[conQxUserGroupRelation.ManageTypeId] = oRow[conQxUserGroupRelation.ManageTypeId].ToString().Trim(); //ManageTypeId
objRow[conQxUserGroupRelation.IsDefault] = oRow[conQxUserGroupRelation.IsDefault].ToString().Trim(); //是否默认
 objDS.Tables[clsQxUserGroupRelationEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxUserGroupRelationEN._CurrTabName);
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
 /// <param name = "objQxUserGroupRelationEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
 if (objQxUserGroupRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserGroupRelationEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
strSQL = "Select * from QxUserGroupRelation where mId = " + ""+ objQxUserGroupRelationEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxUserGroupRelationEN._CurrTabName);
if (objDS.Tables[clsQxUserGroupRelationEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objQxUserGroupRelationEN.mId+"");
return false;
}
objRow = objDS.Tables[clsQxUserGroupRelationEN._CurrTabName].Rows[0];
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.UserId))
 {
objRow[conQxUserGroupRelation.UserId] = objQxUserGroupRelationEN.UserId; //用户ID
 }
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.GroupId))
 {
objRow[conQxUserGroupRelation.GroupId] = objQxUserGroupRelationEN.GroupId; //组Id
 }
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.Memo))
 {
objRow[conQxUserGroupRelation.Memo] = objQxUserGroupRelationEN.Memo; //备注
 }
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.QxPrjId))
 {
objRow[conQxUserGroupRelation.QxPrjId] = objQxUserGroupRelationEN.QxPrjId; //项目Id
 }
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.ManageId))
 {
objRow[conQxUserGroupRelation.ManageId] = objQxUserGroupRelationEN.ManageId; //ManageId
 }
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.ManageTypeId))
 {
objRow[conQxUserGroupRelation.ManageTypeId] = objQxUserGroupRelationEN.ManageTypeId; //ManageTypeId
 }
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.IsDefault))
 {
objRow[conQxUserGroupRelation.IsDefault] = objQxUserGroupRelationEN.IsDefault; //是否默认
 }
try
{
objDA.Update(objDS, clsQxUserGroupRelationEN._CurrTabName);
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
public bool UpdateBySP(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
 if (objQxUserGroupRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserGroupRelationEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxUserGroupRelationEN.mId,
 objQxUserGroupRelationEN.UserId,
 objQxUserGroupRelationEN.GroupId,
 objQxUserGroupRelationEN.Memo,
 objQxUserGroupRelationEN.QxPrjId,
 objQxUserGroupRelationEN.ManageId,
 objQxUserGroupRelationEN.ManageTypeId,
 objQxUserGroupRelationEN.IsDefault
};
 objSQL.ExecSP("QxUserGroupRelation_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxUserGroupRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
 if (objQxUserGroupRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserGroupRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxUserGroupRelation Set ");
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.UserId))
 {
 if (objQxUserGroupRelationEN.UserId !=  null)
 {
 var strUserId = objQxUserGroupRelationEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUserGroupRelation.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.UserId); //用户ID
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.GroupId))
 {
 if (objQxUserGroupRelationEN.GroupId  ==  "")
 {
 objQxUserGroupRelationEN.GroupId = null;
 }
 if (objQxUserGroupRelationEN.GroupId !=  null)
 {
 var strGroupId = objQxUserGroupRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupId, conQxUserGroupRelation.GroupId); //组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.GroupId); //组Id
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.Memo))
 {
 if (objQxUserGroupRelationEN.Memo !=  null)
 {
 var strMemo = objQxUserGroupRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUserGroupRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.Memo); //备注
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.QxPrjId))
 {
 if (objQxUserGroupRelationEN.QxPrjId  ==  "")
 {
 objQxUserGroupRelationEN.QxPrjId = null;
 }
 if (objQxUserGroupRelationEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxUserGroupRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxUserGroupRelation.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.QxPrjId); //项目Id
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.ManageId))
 {
 if (objQxUserGroupRelationEN.ManageId !=  null)
 {
 var strManageId = objQxUserGroupRelationEN.ManageId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strManageId, conQxUserGroupRelation.ManageId); //ManageId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.ManageId); //ManageId
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.ManageTypeId))
 {
 if (objQxUserGroupRelationEN.ManageTypeId !=  null)
 {
 var strManageTypeId = objQxUserGroupRelationEN.ManageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strManageTypeId, conQxUserGroupRelation.ManageTypeId); //ManageTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.ManageTypeId); //ManageTypeId
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUserGroupRelationEN.IsDefault == true?"1":"0", conQxUserGroupRelation.IsDefault); //是否默认
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxUserGroupRelationEN.mId); 
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
 /// <param name = "objQxUserGroupRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxUserGroupRelationEN objQxUserGroupRelationEN, string strCondition)
{
 if (objQxUserGroupRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserGroupRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserGroupRelation Set ");
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.UserId))
 {
 if (objQxUserGroupRelationEN.UserId !=  null)
 {
 var strUserId = objQxUserGroupRelationEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.GroupId))
 {
 if (objQxUserGroupRelationEN.GroupId  ==  "")
 {
 objQxUserGroupRelationEN.GroupId = null;
 }
 if (objQxUserGroupRelationEN.GroupId !=  null)
 {
 var strGroupId = objQxUserGroupRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupId = '{0}',", strGroupId); //组Id
 }
 else
 {
 sbSQL.Append(" GroupId = null,"); //组Id
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.Memo))
 {
 if (objQxUserGroupRelationEN.Memo !=  null)
 {
 var strMemo = objQxUserGroupRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.QxPrjId))
 {
 if (objQxUserGroupRelationEN.QxPrjId  ==  "")
 {
 objQxUserGroupRelationEN.QxPrjId = null;
 }
 if (objQxUserGroupRelationEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxUserGroupRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.ManageId))
 {
 if (objQxUserGroupRelationEN.ManageId !=  null)
 {
 var strManageId = objQxUserGroupRelationEN.ManageId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ManageId = '{0}',", strManageId); //ManageId
 }
 else
 {
 sbSQL.Append(" ManageId = null,"); //ManageId
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.ManageTypeId))
 {
 if (objQxUserGroupRelationEN.ManageTypeId !=  null)
 {
 var strManageTypeId = objQxUserGroupRelationEN.ManageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ManageTypeId = '{0}',", strManageTypeId); //ManageTypeId
 }
 else
 {
 sbSQL.Append(" ManageTypeId = null,"); //ManageTypeId
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objQxUserGroupRelationEN.IsDefault == true?"1":"0"); //是否默认
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
 /// <param name = "objQxUserGroupRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxUserGroupRelationEN objQxUserGroupRelationEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserGroupRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserGroupRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserGroupRelation Set ");
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.UserId))
 {
 if (objQxUserGroupRelationEN.UserId !=  null)
 {
 var strUserId = objQxUserGroupRelationEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.GroupId))
 {
 if (objQxUserGroupRelationEN.GroupId  ==  "")
 {
 objQxUserGroupRelationEN.GroupId = null;
 }
 if (objQxUserGroupRelationEN.GroupId !=  null)
 {
 var strGroupId = objQxUserGroupRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupId = '{0}',", strGroupId); //组Id
 }
 else
 {
 sbSQL.Append(" GroupId = null,"); //组Id
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.Memo))
 {
 if (objQxUserGroupRelationEN.Memo !=  null)
 {
 var strMemo = objQxUserGroupRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.QxPrjId))
 {
 if (objQxUserGroupRelationEN.QxPrjId  ==  "")
 {
 objQxUserGroupRelationEN.QxPrjId = null;
 }
 if (objQxUserGroupRelationEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxUserGroupRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.ManageId))
 {
 if (objQxUserGroupRelationEN.ManageId !=  null)
 {
 var strManageId = objQxUserGroupRelationEN.ManageId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ManageId = '{0}',", strManageId); //ManageId
 }
 else
 {
 sbSQL.Append(" ManageId = null,"); //ManageId
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.ManageTypeId))
 {
 if (objQxUserGroupRelationEN.ManageTypeId !=  null)
 {
 var strManageTypeId = objQxUserGroupRelationEN.ManageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ManageTypeId = '{0}',", strManageTypeId); //ManageTypeId
 }
 else
 {
 sbSQL.Append(" ManageTypeId = null,"); //ManageTypeId
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objQxUserGroupRelationEN.IsDefault == true?"1":"0"); //是否默认
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
 /// <param name = "objQxUserGroupRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUserGroupRelationEN objQxUserGroupRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQxUserGroupRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserGroupRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserGroupRelation Set ");
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.UserId))
 {
 if (objQxUserGroupRelationEN.UserId !=  null)
 {
 var strUserId = objQxUserGroupRelationEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUserGroupRelation.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.UserId); //用户ID
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.GroupId))
 {
 if (objQxUserGroupRelationEN.GroupId  ==  "")
 {
 objQxUserGroupRelationEN.GroupId = null;
 }
 if (objQxUserGroupRelationEN.GroupId !=  null)
 {
 var strGroupId = objQxUserGroupRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupId, conQxUserGroupRelation.GroupId); //组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.GroupId); //组Id
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.Memo))
 {
 if (objQxUserGroupRelationEN.Memo !=  null)
 {
 var strMemo = objQxUserGroupRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUserGroupRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.Memo); //备注
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.QxPrjId))
 {
 if (objQxUserGroupRelationEN.QxPrjId  ==  "")
 {
 objQxUserGroupRelationEN.QxPrjId = null;
 }
 if (objQxUserGroupRelationEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxUserGroupRelationEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxUserGroupRelation.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.QxPrjId); //项目Id
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.ManageId))
 {
 if (objQxUserGroupRelationEN.ManageId !=  null)
 {
 var strManageId = objQxUserGroupRelationEN.ManageId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strManageId, conQxUserGroupRelation.ManageId); //ManageId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.ManageId); //ManageId
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.ManageTypeId))
 {
 if (objQxUserGroupRelationEN.ManageTypeId !=  null)
 {
 var strManageTypeId = objQxUserGroupRelationEN.ManageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strManageTypeId, conQxUserGroupRelation.ManageTypeId); //ManageTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserGroupRelation.ManageTypeId); //ManageTypeId
 }
 }
 
 if (objQxUserGroupRelationEN.IsUpdated(conQxUserGroupRelation.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQxUserGroupRelationEN.IsDefault == true?"1":"0", conQxUserGroupRelation.IsDefault); //是否默认
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxUserGroupRelationEN.mId); 
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("QxUserGroupRelation_Delete", values);
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
//删除QxUserGroupRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserGroupRelation where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxUserGroupRelation(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
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
//删除QxUserGroupRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserGroupRelation where mId in (" + strKeyList + ")";
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
//删除QxUserGroupRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserGroupRelation where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxUserGroupRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: DelQxUserGroupRelation)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUserGroupRelation where " + strCondition ;
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
public bool DelQxUserGroupRelationWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxUserGroupRelationDA: DelQxUserGroupRelationWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUserGroupRelation where " + strCondition ;
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
 /// <param name = "objQxUserGroupRelationENS">源对象</param>
 /// <param name = "objQxUserGroupRelationENT">目标对象</param>
public void CopyTo(clsQxUserGroupRelationEN objQxUserGroupRelationENS, clsQxUserGroupRelationEN objQxUserGroupRelationENT)
{
objQxUserGroupRelationENT.mId = objQxUserGroupRelationENS.mId; //流水号
objQxUserGroupRelationENT.UserId = objQxUserGroupRelationENS.UserId; //用户ID
objQxUserGroupRelationENT.GroupId = objQxUserGroupRelationENS.GroupId; //组Id
objQxUserGroupRelationENT.Memo = objQxUserGroupRelationENS.Memo; //备注
objQxUserGroupRelationENT.QxPrjId = objQxUserGroupRelationENS.QxPrjId; //项目Id
objQxUserGroupRelationENT.ManageId = objQxUserGroupRelationENS.ManageId; //ManageId
objQxUserGroupRelationENT.ManageTypeId = objQxUserGroupRelationENS.ManageTypeId; //ManageTypeId
objQxUserGroupRelationENT.IsDefault = objQxUserGroupRelationENS.IsDefault; //是否默认
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxUserGroupRelationEN.UserId, conQxUserGroupRelation.UserId);
clsCheckSql.CheckFieldNotNull(objQxUserGroupRelationEN.GroupId, conQxUserGroupRelation.GroupId);
clsCheckSql.CheckFieldNotNull(objQxUserGroupRelationEN.QxPrjId, conQxUserGroupRelation.QxPrjId);
clsCheckSql.CheckFieldNotNull(objQxUserGroupRelationEN.ManageId, conQxUserGroupRelation.ManageId);
clsCheckSql.CheckFieldNotNull(objQxUserGroupRelationEN.ManageTypeId, conQxUserGroupRelation.ManageTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.UserId, 18, conQxUserGroupRelation.UserId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.GroupId, 8, conQxUserGroupRelation.GroupId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.Memo, 1000, conQxUserGroupRelation.Memo);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.QxPrjId, 4, conQxUserGroupRelation.QxPrjId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.ManageId, 18, conQxUserGroupRelation.ManageId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.ManageTypeId, 4, conQxUserGroupRelation.ManageTypeId);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxUserGroupRelationEN.GroupId, 8, conQxUserGroupRelation.GroupId);
clsCheckSql.CheckFieldForeignKey(objQxUserGroupRelationEN.QxPrjId, 4, conQxUserGroupRelation.QxPrjId);
 objQxUserGroupRelationEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.UserId, 18, conQxUserGroupRelation.UserId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.GroupId, 8, conQxUserGroupRelation.GroupId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.Memo, 1000, conQxUserGroupRelation.Memo);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.QxPrjId, 4, conQxUserGroupRelation.QxPrjId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.ManageId, 18, conQxUserGroupRelation.ManageId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.ManageTypeId, 4, conQxUserGroupRelation.ManageTypeId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxUserGroupRelationEN.GroupId, 8, conQxUserGroupRelation.GroupId);
clsCheckSql.CheckFieldForeignKey(objQxUserGroupRelationEN.QxPrjId, 4, conQxUserGroupRelation.QxPrjId);
 objQxUserGroupRelationEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.UserId, 18, conQxUserGroupRelation.UserId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.GroupId, 8, conQxUserGroupRelation.GroupId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.Memo, 1000, conQxUserGroupRelation.Memo);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.QxPrjId, 4, conQxUserGroupRelation.QxPrjId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.ManageId, 18, conQxUserGroupRelation.ManageId);
clsCheckSql.CheckFieldLen(objQxUserGroupRelationEN.ManageTypeId, 4, conQxUserGroupRelation.ManageTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxUserGroupRelationEN.UserId, conQxUserGroupRelation.UserId);
clsCheckSql.CheckSqlInjection4Field(objQxUserGroupRelationEN.GroupId, conQxUserGroupRelation.GroupId);
clsCheckSql.CheckSqlInjection4Field(objQxUserGroupRelationEN.Memo, conQxUserGroupRelation.Memo);
clsCheckSql.CheckSqlInjection4Field(objQxUserGroupRelationEN.QxPrjId, conQxUserGroupRelation.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxUserGroupRelationEN.ManageId, conQxUserGroupRelation.ManageId);
clsCheckSql.CheckSqlInjection4Field(objQxUserGroupRelationEN.ManageTypeId, conQxUserGroupRelation.ManageTypeId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxUserGroupRelationEN.GroupId, 8, conQxUserGroupRelation.GroupId);
clsCheckSql.CheckFieldForeignKey(objQxUserGroupRelationEN.QxPrjId, 4, conQxUserGroupRelation.QxPrjId);
 objQxUserGroupRelationEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxUserGroupRelation(用户/组关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUserGroupRelationEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserGroupRelationEN.UserId);
 sbCondition.AppendFormat(" and GroupId = '{0}'", objQxUserGroupRelationEN.GroupId);
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUserGroupRelationEN._CurrTabName);
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUserGroupRelationEN._CurrTabName, strCondition);
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
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
 objSQL = clsQxUserGroupRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}