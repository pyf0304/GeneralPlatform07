
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjDataBaseDA
 表名:vQxPrjDataBase(00140040)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:32:53
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程管理(PrjManage_GP)
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
 /// v数据库对象(vQxPrjDataBase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxPrjDataBaseDA : clsCommBase4DA
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
 return clsvQxPrjDataBaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxPrjDataBaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjDataBaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxPrjDataBaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxPrjDataBaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strQxPrjDataBaseId)
{
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace("'", "''");
if (strQxPrjDataBaseId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vQxPrjDataBase中,检查关键字,长度不正确!(clsvQxPrjDataBaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strQxPrjDataBaseId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxPrjDataBase中,关键字不能为空 或 null!(clsvQxPrjDataBaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQxPrjDataBaseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxPrjDataBaseDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strQxPrjDataBaseId)
{
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace("'", "''");
if (strQxPrjDataBaseId.Length > 4 + 4)
{
throw new Exception("(errid:Data000004)在表:vQxPrjDataBase中,检查关键字,长度不正确!(简化版)(clsvQxPrjDataBaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strQxPrjDataBaseId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:vQxPrjDataBase中,关键字不能为空 或 null!(clsvQxPrjDataBaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQxPrjDataBaseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsvQxPrjDataBaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
 strSQL = "Select * from vQxPrjDataBase where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjDataBase");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxPrjDataBase_SelectByCond",values, "vQxPrjDataBase");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjDataBase where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjDataBase");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjDataBase a where {0} And a.QxPrjDataBaseId not in (Select Top {2} QxPrjDataBaseId From vQxPrjDataBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjDataBase");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjDataBase a where {0} And a.QxPrjDataBaseId not in (Select Top {2} QxPrjDataBaseId From vQxPrjDataBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjDataBase");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxPrjDataBase a where {0} And a.QxPrjDataBaseId not in (Select Top {2} QxPrjDataBaseId From vQxPrjDataBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxPrjDataBase");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjDataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxPrjDataBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTable_vQxPrjDataBase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjDataBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjDataBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjDataBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjDataBase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjDataBase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjDataBase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxPrjDataBase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjDataBase.* from vQxPrjDataBase Left Join {1} on {2} where {3} and vQxPrjDataBase.QxPrjDataBaseId not in (Select top {5} vQxPrjDataBase.QxPrjDataBaseId from vQxPrjDataBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjDataBase where {1} and QxPrjDataBaseId not in (Select top {2} QxPrjDataBaseId from vQxPrjDataBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjDataBase where {1} and QxPrjDataBaseId not in (Select top {3} QxPrjDataBaseId from vQxPrjDataBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjDataBase.* from vQxPrjDataBase Left Join {1} on {2} where {3} and vQxPrjDataBase.QxPrjDataBaseId not in (Select top {5} vQxPrjDataBase.QxPrjDataBaseId from vQxPrjDataBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjDataBase where {1} and QxPrjDataBaseId not in (Select top {2} QxPrjDataBaseId from vQxPrjDataBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjDataBase where {1} and QxPrjDataBaseId not in (Select top {3} QxPrjDataBaseId from vQxPrjDataBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxPrjDataBase.* from vQxPrjDataBase Left Join {1} on {2} where {3} and vQxPrjDataBase.QxPrjDataBaseId not in (Select top {5} vQxPrjDataBase.QxPrjDataBaseId from vQxPrjDataBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjDataBase where {1} and QxPrjDataBaseId not in (Select top {2} QxPrjDataBaseId from vQxPrjDataBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxPrjDataBase where {1} and QxPrjDataBaseId not in (Select top {3} QxPrjDataBaseId from vQxPrjDataBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjDataBase a where {0} And a.QxPrjDataBaseId not in (Select Top {2} QxPrjDataBaseId From vQxPrjDataBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjDataBase a where {0} And a.QxPrjDataBaseId not in (Select Top {2} QxPrjDataBaseId From vQxPrjDataBase Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxPrjDataBase a where {0} And a.QxPrjDataBaseId not in (Select Top {2} QxPrjDataBaseId From vQxPrjDataBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxPrjDataBase a where {0} And a.QxPrjDataBaseId not in (Select Top {2} QxPrjDataBaseId From vQxPrjDataBase Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBaseByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjDataBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjDataBase_SelectByCond",values);
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
public List<clsvQxPrjDataBaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA:GetObjLst)", objException.Message));
}
List<clsvQxPrjDataBaseEN> arrObjLst = new List<clsvQxPrjDataBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjDataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN();
try
{
objvQxPrjDataBaseEN.QxPrjDataBaseId = objRow[convQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objvQxPrjDataBaseEN.PrjDataBaseName = objRow[convQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvQxPrjDataBaseEN.IpAddress = objRow[convQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objvQxPrjDataBaseEN.DataBaseUserId = objRow[convQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objvQxPrjDataBaseEN.DataBasePwd = objRow[convQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objvQxPrjDataBaseEN.DataBaseName = objRow[convQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objvQxPrjDataBaseEN.DataBaseTypeName = objRow[convQxPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvQxPrjDataBaseEN.DataBaseTypeId = objRow[convQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvQxPrjDataBaseEN.DatabaseOwner = objRow[convQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvQxPrjDataBaseEN.TableSpace = objRow[convQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvQxPrjDataBaseEN.UpdDate = objRow[convQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvQxPrjDataBaseEN.SID = objRow[convQxPrjDataBase.SID] == DBNull.Value ? null : objRow[convQxPrjDataBase.SID].ToString().Trim(); //SID
objvQxPrjDataBaseEN.UserId = objRow[convQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objvQxPrjDataBaseEN.Memo = objRow[convQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[convQxPrjDataBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjDataBaseDA: GetObjLst)", objException.Message));
}
objvQxPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjDataBaseEN);
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
public List<clsvQxPrjDataBaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxPrjDataBaseEN> arrObjLst = new List<clsvQxPrjDataBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN();
try
{
objvQxPrjDataBaseEN.QxPrjDataBaseId = objRow[convQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objvQxPrjDataBaseEN.PrjDataBaseName = objRow[convQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvQxPrjDataBaseEN.IpAddress = objRow[convQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objvQxPrjDataBaseEN.DataBaseUserId = objRow[convQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objvQxPrjDataBaseEN.DataBasePwd = objRow[convQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objvQxPrjDataBaseEN.DataBaseName = objRow[convQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objvQxPrjDataBaseEN.DataBaseTypeName = objRow[convQxPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvQxPrjDataBaseEN.DataBaseTypeId = objRow[convQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvQxPrjDataBaseEN.DatabaseOwner = objRow[convQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvQxPrjDataBaseEN.TableSpace = objRow[convQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvQxPrjDataBaseEN.UpdDate = objRow[convQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvQxPrjDataBaseEN.SID = objRow[convQxPrjDataBase.SID] == DBNull.Value ? null : objRow[convQxPrjDataBase.SID].ToString().Trim(); //SID
objvQxPrjDataBaseEN.UserId = objRow[convQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objvQxPrjDataBaseEN.Memo = objRow[convQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[convQxPrjDataBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjDataBaseDA: GetObjLst)", objException.Message));
}
objvQxPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxPrjDataBaseEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxPrjDataBaseEN> arrObjLst = new List<clsvQxPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjDataBase_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN();
try
{
objvQxPrjDataBaseEN.QxPrjDataBaseId = objRow[convQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objvQxPrjDataBaseEN.PrjDataBaseName = objRow[convQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvQxPrjDataBaseEN.IpAddress = objRow[convQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objvQxPrjDataBaseEN.DataBaseUserId = objRow[convQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objvQxPrjDataBaseEN.DataBasePwd = objRow[convQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objvQxPrjDataBaseEN.DataBaseName = objRow[convQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objvQxPrjDataBaseEN.DataBaseTypeName = objRow[convQxPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvQxPrjDataBaseEN.DataBaseTypeId = objRow[convQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvQxPrjDataBaseEN.DatabaseOwner = objRow[convQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvQxPrjDataBaseEN.TableSpace = objRow[convQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvQxPrjDataBaseEN.UpdDate = objRow[convQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvQxPrjDataBaseEN.SID = objRow[convQxPrjDataBase.SID] == DBNull.Value ? null : objRow[convQxPrjDataBase.SID].ToString().Trim(); //SID
objvQxPrjDataBaseEN.UserId = objRow[convQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objvQxPrjDataBaseEN.Memo = objRow[convQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[convQxPrjDataBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxPrjDataBaseDA: GetObjLstBySP)", objException.Message));
}
objvQxPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxPrjDataBaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjDataBase(ref clsvQxPrjDataBaseEN objvQxPrjDataBaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjDataBase where QxPrjDataBaseId = " + "'"+ objvQxPrjDataBaseEN.QxPrjDataBaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxPrjDataBaseEN.QxPrjDataBaseId = objDT.Rows[0][convQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjDataBaseEN.PrjDataBaseName = objDT.Rows[0][convQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjDataBaseEN.IpAddress = objDT.Rows[0][convQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objvQxPrjDataBaseEN.DataBaseUserId = objDT.Rows[0][convQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvQxPrjDataBaseEN.DataBasePwd = objDT.Rows[0][convQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxPrjDataBaseEN.DataBaseName = objDT.Rows[0][convQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.DataBaseTypeName = objDT.Rows[0][convQxPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjDataBaseEN.DataBaseTypeId = objDT.Rows[0][convQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjDataBaseEN.DatabaseOwner = objDT.Rows[0][convQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.TableSpace = objDT.Rows[0][convQxPrjDataBase.TableSpace].ToString().Trim(); //表空间(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.UpdDate = objDT.Rows[0][convQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjDataBaseEN.SID = objDT.Rows[0][convQxPrjDataBase.SID].ToString().Trim(); //SID(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.UserId = objDT.Rows[0][convQxPrjDataBase.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxPrjDataBaseEN.Memo = objDT.Rows[0][convQxPrjDataBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxPrjDataBaseDA: GetvQxPrjDataBase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxPrjDataBaseEN GetObjByQxPrjDataBaseId(string strQxPrjDataBaseId)
{
CheckPrimaryKey(strQxPrjDataBaseId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjDataBase where QxPrjDataBaseId = " + "'"+ strQxPrjDataBaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN();
try
{
 objvQxPrjDataBaseEN.QxPrjDataBaseId = objRow[convQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjDataBaseEN.PrjDataBaseName = objRow[convQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjDataBaseEN.IpAddress = objRow[convQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objvQxPrjDataBaseEN.DataBaseUserId = objRow[convQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvQxPrjDataBaseEN.DataBasePwd = objRow[convQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxPrjDataBaseEN.DataBaseName = objRow[convQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.DataBaseTypeName = objRow[convQxPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjDataBaseEN.DataBaseTypeId = objRow[convQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjDataBaseEN.DatabaseOwner = objRow[convQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.TableSpace = objRow[convQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convQxPrjDataBase.TableSpace].ToString().Trim(); //表空间(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.UpdDate = objRow[convQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjDataBaseEN.SID = objRow[convQxPrjDataBase.SID] == DBNull.Value ? null : objRow[convQxPrjDataBase.SID].ToString().Trim(); //SID(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.UserId = objRow[convQxPrjDataBase.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxPrjDataBaseEN.Memo = objRow[convQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[convQxPrjDataBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxPrjDataBaseDA: GetObjByQxPrjDataBaseId)", objException.Message));
}
return objvQxPrjDataBaseEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxPrjDataBase_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxPrjDataBaseOneBySP(clsvQxPrjDataBaseEN objvQxPrjDataBaseEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxPrjDataBaseEN.QxPrjDataBaseId
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjDataBase_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxPrjDataBaseEN.QxPrjDataBaseId = objDT.Rows[0][convQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxPrjDataBaseEN.PrjDataBaseName = objDT.Rows[0][convQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxPrjDataBaseEN.IpAddress = objDT.Rows[0][convQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址(字段类型:varchar,字段长度:23,是否可空:True)
 objvQxPrjDataBaseEN.DataBaseUserId = objDT.Rows[0][convQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvQxPrjDataBaseEN.DataBasePwd = objDT.Rows[0][convQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxPrjDataBaseEN.DataBaseName = objDT.Rows[0][convQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.DataBaseTypeName = objDT.Rows[0][convQxPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxPrjDataBaseEN.DataBaseTypeId = objDT.Rows[0][convQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvQxPrjDataBaseEN.DatabaseOwner = objDT.Rows[0][convQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.TableSpace = objDT.Rows[0][convQxPrjDataBase.TableSpace].ToString().Trim(); //表空间(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.UpdDate = objDT.Rows[0][convQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxPrjDataBaseEN.SID = objDT.Rows[0][convQxPrjDataBase.SID].ToString().Trim(); //SID(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxPrjDataBaseEN.UserId = objDT.Rows[0][convQxPrjDataBase.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxPrjDataBaseEN.Memo = objDT.Rows[0][convQxPrjDataBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjDataBaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vQxPrjDataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN()
{
QxPrjDataBaseId = objRow[convQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(), //项目数据库Id
PrjDataBaseName = objRow[convQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.PrjDataBaseName].ToString().Trim(), //项目数据库名
IpAddress = objRow[convQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convQxPrjDataBase.IpAddress].ToString().Trim(), //IP地址
DataBaseUserId = objRow[convQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseUserId].ToString().Trim(), //数据库用户Id
DataBasePwd = objRow[convQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBasePwd].ToString().Trim(), //数据库用户口令
DataBaseName = objRow[convQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseName].ToString().Trim(), //数据库名称
DataBaseTypeName = objRow[convQxPrjDataBase.DataBaseTypeName].ToString().Trim(), //数据库类型名
DataBaseTypeId = objRow[convQxPrjDataBase.DataBaseTypeId].ToString().Trim(), //数据库类型ID
DatabaseOwner = objRow[convQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convQxPrjDataBase.DatabaseOwner].ToString().Trim(), //数据库拥有者
TableSpace = objRow[convQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convQxPrjDataBase.TableSpace].ToString().Trim(), //表空间
UpdDate = objRow[convQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convQxPrjDataBase.UpdDate].ToString().Trim(), //修改日期
SID = objRow[convQxPrjDataBase.SID] == DBNull.Value ? null : objRow[convQxPrjDataBase.SID].ToString().Trim(), //SID
UserId = objRow[convQxPrjDataBase.UserId].ToString().Trim(), //用户ID
Memo = objRow[convQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[convQxPrjDataBase.Memo].ToString().Trim() //备注
};
objvQxPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjDataBaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxPrjDataBaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxPrjDataBaseEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxPrjDataBase_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN()
{
QxPrjDataBaseId = objRow[convQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(), //项目数据库Id
PrjDataBaseName = objRow[convQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.PrjDataBaseName].ToString().Trim(), //项目数据库名
IpAddress = objRow[convQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convQxPrjDataBase.IpAddress].ToString().Trim(), //IP地址
DataBaseUserId = objRow[convQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseUserId].ToString().Trim(), //数据库用户Id
DataBasePwd = objRow[convQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBasePwd].ToString().Trim(), //数据库用户口令
DataBaseName = objRow[convQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseName].ToString().Trim(), //数据库名称
DataBaseTypeName = objRow[convQxPrjDataBase.DataBaseTypeName].ToString().Trim(), //数据库类型名
DataBaseTypeId = objRow[convQxPrjDataBase.DataBaseTypeId].ToString().Trim(), //数据库类型ID
DatabaseOwner = objRow[convQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convQxPrjDataBase.DatabaseOwner].ToString().Trim(), //数据库拥有者
TableSpace = objRow[convQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convQxPrjDataBase.TableSpace].ToString().Trim(), //表空间
UpdDate = objRow[convQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convQxPrjDataBase.UpdDate].ToString().Trim(), //修改日期
SID = objRow[convQxPrjDataBase.SID] == DBNull.Value ? null : objRow[convQxPrjDataBase.SID].ToString().Trim(), //SID
UserId = objRow[convQxPrjDataBase.UserId].ToString().Trim(), //用户ID
Memo = objRow[convQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[convQxPrjDataBase.Memo].ToString().Trim() //备注
};
objvQxPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjDataBaseEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxPrjDataBaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN();
try
{
objvQxPrjDataBaseEN.QxPrjDataBaseId = objRow[convQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objvQxPrjDataBaseEN.PrjDataBaseName = objRow[convQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvQxPrjDataBaseEN.IpAddress = objRow[convQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objvQxPrjDataBaseEN.DataBaseUserId = objRow[convQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objvQxPrjDataBaseEN.DataBasePwd = objRow[convQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objvQxPrjDataBaseEN.DataBaseName = objRow[convQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objvQxPrjDataBaseEN.DataBaseTypeName = objRow[convQxPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvQxPrjDataBaseEN.DataBaseTypeId = objRow[convQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvQxPrjDataBaseEN.DatabaseOwner = objRow[convQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvQxPrjDataBaseEN.TableSpace = objRow[convQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvQxPrjDataBaseEN.UpdDate = objRow[convQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvQxPrjDataBaseEN.SID = objRow[convQxPrjDataBase.SID] == DBNull.Value ? null : objRow[convQxPrjDataBase.SID].ToString().Trim(); //SID
objvQxPrjDataBaseEN.UserId = objRow[convQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objvQxPrjDataBaseEN.Memo = objRow[convQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[convQxPrjDataBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxPrjDataBaseDA: GetObjByDataRowvQxPrjDataBase)", objException.Message));
}
objvQxPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjDataBaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxPrjDataBaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN();
try
{
objvQxPrjDataBaseEN.QxPrjDataBaseId = objRow[convQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objvQxPrjDataBaseEN.PrjDataBaseName = objRow[convQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvQxPrjDataBaseEN.IpAddress = objRow[convQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objvQxPrjDataBaseEN.DataBaseUserId = objRow[convQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objvQxPrjDataBaseEN.DataBasePwd = objRow[convQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objvQxPrjDataBaseEN.DataBaseName = objRow[convQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objvQxPrjDataBaseEN.DataBaseTypeName = objRow[convQxPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvQxPrjDataBaseEN.DataBaseTypeId = objRow[convQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvQxPrjDataBaseEN.DatabaseOwner = objRow[convQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvQxPrjDataBaseEN.TableSpace = objRow[convQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvQxPrjDataBaseEN.UpdDate = objRow[convQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvQxPrjDataBaseEN.SID = objRow[convQxPrjDataBase.SID] == DBNull.Value ? null : objRow[convQxPrjDataBase.SID].ToString().Trim(); //SID
objvQxPrjDataBaseEN.UserId = objRow[convQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objvQxPrjDataBaseEN.Memo = objRow[convQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[convQxPrjDataBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxPrjDataBaseDA: GetObjByDataRow)", objException.Message));
}
objvQxPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxPrjDataBaseEN;
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
objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjDataBaseEN._CurrTabName, convQxPrjDataBase.QxPrjDataBaseId, 4, "");
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
objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxPrjDataBaseEN._CurrTabName, convQxPrjDataBase.QxPrjDataBaseId, 4, strPrefix);
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
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QxPrjDataBaseId from vQxPrjDataBase where " + strCondition;
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
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QxPrjDataBaseId from vQxPrjDataBase where " + strCondition;
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
 /// <param name = "strQxPrjDataBaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strQxPrjDataBaseId)
{
CheckPrimaryKey(strQxPrjDataBaseId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjDataBase", "QxPrjDataBaseId = " + "'"+ strQxPrjDataBaseId+"'"))
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
 /// <param name = "strQxPrjDataBaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strQxPrjDataBaseId)
{
CheckPrimaryKey(strQxPrjDataBaseId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strQxPrjDataBaseId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxPrjDataBase_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxPrjDataBaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxPrjDataBase", strCondition))
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
objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxPrjDataBase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseENS">源对象</param>
 /// <param name = "objvQxPrjDataBaseENT">目标对象</param>
public void CopyTo(clsvQxPrjDataBaseEN objvQxPrjDataBaseENS, clsvQxPrjDataBaseEN objvQxPrjDataBaseENT)
{
objvQxPrjDataBaseENT.QxPrjDataBaseId = objvQxPrjDataBaseENS.QxPrjDataBaseId; //项目数据库Id
objvQxPrjDataBaseENT.PrjDataBaseName = objvQxPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objvQxPrjDataBaseENT.IpAddress = objvQxPrjDataBaseENS.IpAddress; //IP地址
objvQxPrjDataBaseENT.DataBaseUserId = objvQxPrjDataBaseENS.DataBaseUserId; //数据库用户Id
objvQxPrjDataBaseENT.DataBasePwd = objvQxPrjDataBaseENS.DataBasePwd; //数据库用户口令
objvQxPrjDataBaseENT.DataBaseName = objvQxPrjDataBaseENS.DataBaseName; //数据库名称
objvQxPrjDataBaseENT.DataBaseTypeName = objvQxPrjDataBaseENS.DataBaseTypeName; //数据库类型名
objvQxPrjDataBaseENT.DataBaseTypeId = objvQxPrjDataBaseENS.DataBaseTypeId; //数据库类型ID
objvQxPrjDataBaseENT.DatabaseOwner = objvQxPrjDataBaseENS.DatabaseOwner; //数据库拥有者
objvQxPrjDataBaseENT.TableSpace = objvQxPrjDataBaseENS.TableSpace; //表空间
objvQxPrjDataBaseENT.UpdDate = objvQxPrjDataBaseENS.UpdDate; //修改日期
objvQxPrjDataBaseENT.SID = objvQxPrjDataBaseENS.SID; //SID
objvQxPrjDataBaseENT.UserId = objvQxPrjDataBaseENS.UserId; //用户ID
objvQxPrjDataBaseENT.Memo = objvQxPrjDataBaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxPrjDataBaseEN objvQxPrjDataBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.QxPrjDataBaseId, 4, convQxPrjDataBase.QxPrjDataBaseId);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.PrjDataBaseName, 50, convQxPrjDataBase.PrjDataBaseName);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.IpAddress, 23, convQxPrjDataBase.IpAddress);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.DataBaseUserId, 18, convQxPrjDataBase.DataBaseUserId);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.DataBasePwd, 20, convQxPrjDataBase.DataBasePwd);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.DataBaseName, 30, convQxPrjDataBase.DataBaseName);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.DataBaseTypeName, 30, convQxPrjDataBase.DataBaseTypeName);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.DataBaseTypeId, 2, convQxPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.DatabaseOwner, 30, convQxPrjDataBase.DatabaseOwner);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.TableSpace, 30, convQxPrjDataBase.TableSpace);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.UpdDate, 20, convQxPrjDataBase.UpdDate);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.SID, 30, convQxPrjDataBase.SID);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.UserId, 18, convQxPrjDataBase.UserId);
clsCheckSql.CheckFieldLen(objvQxPrjDataBaseEN.Memo, 1000, convQxPrjDataBase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.QxPrjDataBaseId, convQxPrjDataBase.QxPrjDataBaseId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.PrjDataBaseName, convQxPrjDataBase.PrjDataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.IpAddress, convQxPrjDataBase.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.DataBaseUserId, convQxPrjDataBase.DataBaseUserId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.DataBasePwd, convQxPrjDataBase.DataBasePwd);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.DataBaseName, convQxPrjDataBase.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.DataBaseTypeName, convQxPrjDataBase.DataBaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.DataBaseTypeId, convQxPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.DatabaseOwner, convQxPrjDataBase.DatabaseOwner);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.TableSpace, convQxPrjDataBase.TableSpace);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.UpdDate, convQxPrjDataBase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.SID, convQxPrjDataBase.SID);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.UserId, convQxPrjDataBase.UserId);
clsCheckSql.CheckSqlInjection4Field(objvQxPrjDataBaseEN.Memo, convQxPrjDataBase.Memo);
//检查外键字段长度
 objvQxPrjDataBaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetQxPrjDataBaseId()
{
//获取某学院所有专业信息
string strSQL = "select QxPrjDataBaseId, PrjDataBaseName from vQxPrjDataBase ";
 clsSpecSQLforSql mySql = clsvQxPrjDataBaseDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
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
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjDataBaseEN._CurrTabName);
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
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxPrjDataBaseEN._CurrTabName, strCondition);
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
 objSQL = clsvQxPrjDataBaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}