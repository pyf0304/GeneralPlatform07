
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRoleRelation4SynchDA
 表名:vQxUserRoleRelation4Synch(00140095)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:46:18
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:数据同步(DataSynch)
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
 /// v用户角色关系4同步(vQxUserRoleRelation4Synch)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxUserRoleRelation4SynchDA : clsCommBase4DA
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
 return clsvQxUserRoleRelation4SynchEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxUserRoleRelation4SynchEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserRoleRelation4SynchEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxUserRoleRelation4SynchEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxUserRoleRelation4SynchEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
 strSQL = "Select * from vQxUserRoleRelation4Synch where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxUserRoleRelation4Synch");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxUserRoleRelation4Synch_SelectByCond",values, "vQxUserRoleRelation4Synch");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation4Synch where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserRoleRelation4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUserRoleRelation4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUserRoleRelation4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserRoleRelation4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUserRoleRelation4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUserRoleRelation4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserRoleRelation4Synch");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUserRoleRelation4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUserRoleRelation4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserRoleRelation4Synch");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxUserRoleRelation4Synch(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTable_vQxUserRoleRelation4Synch)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation4Synch where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation4Synch where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation4Synch where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation4Synch where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserRoleRelation4Synch.* from vQxUserRoleRelation4Synch Left Join {1} on {2} where {3} and vQxUserRoleRelation4Synch.mId not in (Select top {5} vQxUserRoleRelation4Synch.mId from vQxUserRoleRelation4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation4Synch where {1} and mId not in (Select top {2} mId from vQxUserRoleRelation4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation4Synch where {1} and mId not in (Select top {3} mId from vQxUserRoleRelation4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserRoleRelation4Synch.* from vQxUserRoleRelation4Synch Left Join {1} on {2} where {3} and vQxUserRoleRelation4Synch.mId not in (Select top {5} vQxUserRoleRelation4Synch.mId from vQxUserRoleRelation4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation4Synch where {1} and mId not in (Select top {2} mId from vQxUserRoleRelation4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation4Synch where {1} and mId not in (Select top {3} mId from vQxUserRoleRelation4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserRoleRelation4Synch.* from vQxUserRoleRelation4Synch Left Join {1} on {2} where {3} and vQxUserRoleRelation4Synch.mId not in (Select top {5} vQxUserRoleRelation4Synch.mId from vQxUserRoleRelation4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation4Synch where {1} and mId not in (Select top {2} mId from vQxUserRoleRelation4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation4Synch where {1} and mId not in (Select top {3} mId from vQxUserRoleRelation4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUserRoleRelation4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUserRoleRelation4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUserRoleRelation4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUserRoleRelation4Synch Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUserRoleRelation4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUserRoleRelation4Synch Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUserRoleRelation4Synch a where {0} And a.mId not in (Select Top {2} mId From vQxUserRoleRelation4Synch Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4SynchByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUserRoleRelation4Synch_SelectByCond",values);
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
public List<clsvQxUserRoleRelation4SynchEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA:GetObjLst)", objException.Message));
}
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = TransNullToInt(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetObjLst)", objException.Message));
}
objvQxUserRoleRelation4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
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
public List<clsvQxUserRoleRelation4SynchEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = TransNullToInt(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetObjLst)", objException.Message));
}
objvQxUserRoleRelation4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxUserRoleRelation4SynchEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUserRoleRelation4Synch_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = TransNullToInt(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetObjLstBySP)", objException.Message));
}
objvQxUserRoleRelation4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUserRoleRelation4Synch(ref clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation4Synch where mId = " + ""+ objvQxUserRoleRelation4SynchEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxUserRoleRelation4SynchEN.mId = TransNullToInt(objDT.Rows[0][convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxUserRoleRelation4SynchEN.IpAddress = objDT.Rows[0][convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objvQxUserRoleRelation4SynchEN.UserId = objDT.Rows[0][convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UserName = objDT.Rows[0][convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserRoleRelation4SynchEN.DepartmentId = objDT.Rows[0][convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUserRoleRelation4SynchEN.DepartmentName = objDT.Rows[0][convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UserStateId = objDT.Rows[0][convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UserStateName = objDT.Rows[0][convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.StuTeacherId = objDT.Rows[0][convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.IdentityId = objDT.Rows[0][convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRoleRelation4SynchEN.IdentityDesc = objDT.Rows[0][convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.RoleId = objDT.Rows[0][convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxUserRoleRelation4SynchEN.RoleName = objDT.Rows[0][convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUserRoleRelation4SynchEN.QxPrjId = objDT.Rows[0][convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserRoleRelation4SynchEN.PrjName = objDT.Rows[0][convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UpdDate = objDT.Rows[0][convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UpdUserId = objDT.Rows[0][convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.Memo = objDT.Rows[0][convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetvQxUserRoleRelation4Synch)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxUserRoleRelation4SynchEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation4Synch where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
 objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetObjBymId)", objException.Message));
}
return objvQxUserRoleRelation4SynchEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxUserRoleRelation4Synch_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUserRoleRelation4SynchOneBySP(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxUserRoleRelation4SynchEN.mId
};
 objDT = objSQL.ExecSpReturnDT("vQxUserRoleRelation4Synch_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxUserRoleRelation4SynchEN.mId = TransNullToInt(objDT.Rows[0][convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxUserRoleRelation4SynchEN.IpAddress = objDT.Rows[0][convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objvQxUserRoleRelation4SynchEN.UserId = objDT.Rows[0][convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UserName = objDT.Rows[0][convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserRoleRelation4SynchEN.DepartmentId = objDT.Rows[0][convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUserRoleRelation4SynchEN.DepartmentName = objDT.Rows[0][convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UserStateId = objDT.Rows[0][convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UserStateName = objDT.Rows[0][convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.StuTeacherId = objDT.Rows[0][convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.IdentityId = objDT.Rows[0][convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRoleRelation4SynchEN.IdentityDesc = objDT.Rows[0][convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.RoleId = objDT.Rows[0][convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxUserRoleRelation4SynchEN.RoleName = objDT.Rows[0][convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUserRoleRelation4SynchEN.QxPrjId = objDT.Rows[0][convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserRoleRelation4SynchEN.PrjName = objDT.Rows[0][convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UpdDate = objDT.Rows[0][convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.UpdUserId = objDT.Rows[0][convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelation4SynchEN.Memo = objDT.Rows[0][convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUserRoleRelation4SynchEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN()
{
mId = TransNullToInt(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()), //流水号
IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(), //IP地址
UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(), //部门名
UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(), //用户状态名
StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(), //学工号
IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(), //身份编号
IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(), //身份描述
RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(), //角色Id
RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(), //角色名称
QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(), //工程名
UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim() //备注
};
objvQxUserRoleRelation4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserRoleRelation4SynchEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUserRoleRelation4SynchEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUserRoleRelation4Synch_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN()
{
mId = TransNullToInt(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()), //流水号
IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(), //IP地址
UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(), //部门名
UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(), //用户状态名
StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(), //学工号
IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(), //身份编号
IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(), //身份描述
RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(), //角色Id
RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(), //角色名称
QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(), //工程名
UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim() //备注
};
objvQxUserRoleRelation4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserRoleRelation4SynchEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxUserRoleRelation4SynchEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = TransNullToInt(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetObjByDataRowvQxUserRoleRelation4Synch)", objException.Message));
}
objvQxUserRoleRelation4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserRoleRelation4SynchEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxUserRoleRelation4SynchEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = TransNullToInt(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxUserRoleRelation4SynchDA: GetObjByDataRow)", objException.Message));
}
objvQxUserRoleRelation4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserRoleRelation4SynchEN;
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
objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUserRoleRelation4SynchEN._CurrTabName, convQxUserRoleRelation4Synch.mId, 8, "");
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
objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUserRoleRelation4SynchEN._CurrTabName, convQxUserRoleRelation4Synch.mId, 8, strPrefix);
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
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vQxUserRoleRelation4Synch where " + strCondition;
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
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vQxUserRoleRelation4Synch where " + strCondition;
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
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUserRoleRelation4Synch", "mId = " + ""+ lngmId+""))
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
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxUserRoleRelation4Synch_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUserRoleRelation4Synch", strCondition))
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
objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxUserRoleRelation4Synch");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchENS">源对象</param>
 /// <param name = "objvQxUserRoleRelation4SynchENT">目标对象</param>
public void CopyTo(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchENS, clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchENT)
{
objvQxUserRoleRelation4SynchENT.mId = objvQxUserRoleRelation4SynchENS.mId; //流水号
objvQxUserRoleRelation4SynchENT.IpAddress = objvQxUserRoleRelation4SynchENS.IpAddress; //IP地址
objvQxUserRoleRelation4SynchENT.UserId = objvQxUserRoleRelation4SynchENS.UserId; //用户ID
objvQxUserRoleRelation4SynchENT.UserName = objvQxUserRoleRelation4SynchENS.UserName; //用户名
objvQxUserRoleRelation4SynchENT.DepartmentId = objvQxUserRoleRelation4SynchENS.DepartmentId; //部门Id
objvQxUserRoleRelation4SynchENT.DepartmentName = objvQxUserRoleRelation4SynchENS.DepartmentName; //部门名
objvQxUserRoleRelation4SynchENT.UserStateId = objvQxUserRoleRelation4SynchENS.UserStateId; //用户状态Id
objvQxUserRoleRelation4SynchENT.UserStateName = objvQxUserRoleRelation4SynchENS.UserStateName; //用户状态名
objvQxUserRoleRelation4SynchENT.StuTeacherId = objvQxUserRoleRelation4SynchENS.StuTeacherId; //学工号
objvQxUserRoleRelation4SynchENT.IdentityId = objvQxUserRoleRelation4SynchENS.IdentityId; //身份编号
objvQxUserRoleRelation4SynchENT.IdentityDesc = objvQxUserRoleRelation4SynchENS.IdentityDesc; //身份描述
objvQxUserRoleRelation4SynchENT.RoleId = objvQxUserRoleRelation4SynchENS.RoleId; //角色Id
objvQxUserRoleRelation4SynchENT.RoleName = objvQxUserRoleRelation4SynchENS.RoleName; //角色名称
objvQxUserRoleRelation4SynchENT.QxPrjId = objvQxUserRoleRelation4SynchENS.QxPrjId; //项目Id
objvQxUserRoleRelation4SynchENT.PrjName = objvQxUserRoleRelation4SynchENS.PrjName; //工程名
objvQxUserRoleRelation4SynchENT.UpdDate = objvQxUserRoleRelation4SynchENS.UpdDate; //修改日期
objvQxUserRoleRelation4SynchENT.UpdUserId = objvQxUserRoleRelation4SynchENS.UpdUserId; //修改用户Id
objvQxUserRoleRelation4SynchENT.Memo = objvQxUserRoleRelation4SynchENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.IpAddress, 23, convQxUserRoleRelation4Synch.IpAddress);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.UserId, 18, convQxUserRoleRelation4Synch.UserId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.UserName, 30, convQxUserRoleRelation4Synch.UserName);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.DepartmentId, 8, convQxUserRoleRelation4Synch.DepartmentId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.DepartmentName, 100, convQxUserRoleRelation4Synch.DepartmentName);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.UserStateId, 2, convQxUserRoleRelation4Synch.UserStateId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.UserStateName, 20, convQxUserRoleRelation4Synch.UserStateName);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.StuTeacherId, 20, convQxUserRoleRelation4Synch.StuTeacherId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.IdentityId, 2, convQxUserRoleRelation4Synch.IdentityId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.IdentityDesc, 20, convQxUserRoleRelation4Synch.IdentityDesc);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.RoleId, 8, convQxUserRoleRelation4Synch.RoleId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.RoleName, 50, convQxUserRoleRelation4Synch.RoleName);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.QxPrjId, 4, convQxUserRoleRelation4Synch.QxPrjId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.PrjName, 30, convQxUserRoleRelation4Synch.PrjName);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.UpdDate, 20, convQxUserRoleRelation4Synch.UpdDate);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.UpdUserId, 20, convQxUserRoleRelation4Synch.UpdUserId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelation4SynchEN.Memo, 1000, convQxUserRoleRelation4Synch.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.IpAddress, convQxUserRoleRelation4Synch.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.UserId, convQxUserRoleRelation4Synch.UserId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.UserName, convQxUserRoleRelation4Synch.UserName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.DepartmentId, convQxUserRoleRelation4Synch.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.DepartmentName, convQxUserRoleRelation4Synch.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.UserStateId, convQxUserRoleRelation4Synch.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.UserStateName, convQxUserRoleRelation4Synch.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.StuTeacherId, convQxUserRoleRelation4Synch.StuTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.IdentityId, convQxUserRoleRelation4Synch.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.IdentityDesc, convQxUserRoleRelation4Synch.IdentityDesc);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.RoleId, convQxUserRoleRelation4Synch.RoleId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.RoleName, convQxUserRoleRelation4Synch.RoleName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.QxPrjId, convQxUserRoleRelation4Synch.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.PrjName, convQxUserRoleRelation4Synch.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.UpdDate, convQxUserRoleRelation4Synch.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.UpdUserId, convQxUserRoleRelation4Synch.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelation4SynchEN.Memo, convQxUserRoleRelation4Synch.Memo);
//检查外键字段长度
 objvQxUserRoleRelation4SynchEN._IsCheckProperty = true;
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
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
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
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
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
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUserRoleRelation4SynchEN._CurrTabName);
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
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUserRoleRelation4SynchEN._CurrTabName, strCondition);
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
 objSQL = clsvQxUserRoleRelation4SynchDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}