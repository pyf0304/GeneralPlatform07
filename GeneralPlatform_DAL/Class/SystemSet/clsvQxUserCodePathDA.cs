
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserCodePathDA
 表名:vQxUserCodePath(00140064)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:47:26
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统设置(SystemSet)
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
 /// v用户生成路径(vQxUserCodePath)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxUserCodePathDA : clsCommBase4DA
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
 return clsvQxUserCodePathEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxUserCodePathEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserCodePathEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxUserCodePathEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxUserCodePathEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
 strSQL = "Select * from vQxUserCodePath where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vQxUserCodePath");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vQxUserCodePath_SelectByCond",values, "vQxUserCodePath");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUserCodePath where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserCodePath");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUserCodePath a where {0} And a.mId not in (Select Top {2} mId From vQxUserCodePath Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserCodePath");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUserCodePath a where {0} And a.mId not in (Select Top {2} mId From vQxUserCodePath Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserCodePath");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vQxUserCodePath a where {0} And a.mId not in (Select Top {2} mId From vQxUserCodePath Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vQxUserCodePath");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserCodePath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxUserCodePath(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTable_vQxUserCodePath)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserCodePath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserCodePath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserCodePath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserCodePath where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserCodePath where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUserCodePath where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUserCodePath where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserCodePath.* from vQxUserCodePath Left Join {1} on {2} where {3} and vQxUserCodePath.mId not in (Select top {5} vQxUserCodePath.mId from vQxUserCodePath Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserCodePath where {1} and mId not in (Select top {2} mId from vQxUserCodePath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserCodePath where {1} and mId not in (Select top {3} mId from vQxUserCodePath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserCodePath.* from vQxUserCodePath Left Join {1} on {2} where {3} and vQxUserCodePath.mId not in (Select top {5} vQxUserCodePath.mId from vQxUserCodePath Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserCodePath where {1} and mId not in (Select top {2} mId from vQxUserCodePath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserCodePath where {1} and mId not in (Select top {3} mId from vQxUserCodePath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserCodePath.* from vQxUserCodePath Left Join {1} on {2} where {3} and vQxUserCodePath.mId not in (Select top {5} vQxUserCodePath.mId from vQxUserCodePath Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserCodePath where {1} and mId not in (Select top {2} mId from vQxUserCodePath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserCodePath where {1} and mId not in (Select top {3} mId from vQxUserCodePath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUserCodePath a where {0} And a.mId not in (Select Top {2} mId From vQxUserCodePath Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUserCodePath a where {0} And a.mId not in (Select Top {2} mId From vQxUserCodePath Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vQxUserCodePath a where {0} And a.mId not in (Select Top {2} mId From vQxUserCodePath Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vQxUserCodePath a where {0} And a.mId not in (Select Top {2} mId From vQxUserCodePath Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvQxUserCodePathDA: GetvQxUserCodePathByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserCodePath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUserCodePath_SelectByCond",values);
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
public List<clsvQxUserCodePathEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA:GetObjLst)", objException.Message));
}
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserCodePath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = TransNullToInt(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = TransNullToBool(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserCodePathDA: GetObjLst)", objException.Message));
}
objvQxUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserCodePathEN);
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
public List<clsvQxUserCodePathEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = TransNullToInt(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = TransNullToBool(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserCodePathDA: GetObjLst)", objException.Message));
}
objvQxUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvQxUserCodePathEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA:GetObjLstBySP)", objException.Message));
}
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUserCodePath_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = TransNullToInt(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = TransNullToBool(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserCodePathDA: GetObjLstBySP)", objException.Message));
}
objvQxUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserCodePathEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUserCodePath(ref clsvQxUserCodePathEN objvQxUserCodePathEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserCodePath where mId = " + ""+ objvQxUserCodePathEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxUserCodePathEN.mId = TransNullToInt(objDT.Rows[0][convQxUserCodePath.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxUserCodePathEN.QxPrjId = objDT.Rows[0][convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserCodePathEN.PrjName = objDT.Rows[0][convQxUserCodePath.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserCodePathEN.UserId = objDT.Rows[0][convQxUserCodePath.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUserCodePathEN.UserName = objDT.Rows[0][convQxUserCodePath.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserCodePathEN.CodePath = objDT.Rows[0][convQxUserCodePath.CodePath].ToString().Trim(); //代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxUserCodePathEN.CodePathBackup = objDT.Rows[0][convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxUserCodePathEN.DepartmentId = objDT.Rows[0][convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUserCodePathEN.DepartmentName = objDT.Rows[0][convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserCodePathEN.QxCodeTypeId = objDT.Rows[0][convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserCodePathEN.CodeTypeName = objDT.Rows[0][convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserCodePathEN.IsTemplate = TransNullToBool(objDT.Rows[0][convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvQxUserCodePathEN.UpdUserId = objDT.Rows[0][convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserCodePathEN.UpdDate = objDT.Rows[0][convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserCodePathEN.UserStateName = objDT.Rows[0][convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserCodePathEN.UserStateId = objDT.Rows[0][convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserCodePathEN.Memo = objDT.Rows[0][convQxUserCodePath.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxUserCodePathDA: GetvQxUserCodePath)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxUserCodePathEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserCodePath where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
 objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxUserCodePathDA: GetObjBymId)", objException.Message));
}
return objvQxUserCodePathEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vQxUserCodePath_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUserCodePathOneBySP(clsvQxUserCodePathEN objvQxUserCodePathEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvQxUserCodePathEN.mId
};
 objDT = objSQL.ExecSpReturnDT("vQxUserCodePath_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvQxUserCodePathEN.mId = TransNullToInt(objDT.Rows[0][convQxUserCodePath.mId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvQxUserCodePathEN.QxPrjId = objDT.Rows[0][convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserCodePathEN.PrjName = objDT.Rows[0][convQxUserCodePath.PrjName].ToString().Trim(); //工程名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserCodePathEN.UserId = objDT.Rows[0][convQxUserCodePath.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUserCodePathEN.UserName = objDT.Rows[0][convQxUserCodePath.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserCodePathEN.CodePath = objDT.Rows[0][convQxUserCodePath.CodePath].ToString().Trim(); //代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxUserCodePathEN.CodePathBackup = objDT.Rows[0][convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxUserCodePathEN.DepartmentId = objDT.Rows[0][convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxUserCodePathEN.DepartmentName = objDT.Rows[0][convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserCodePathEN.QxCodeTypeId = objDT.Rows[0][convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserCodePathEN.CodeTypeName = objDT.Rows[0][convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserCodePathEN.IsTemplate = TransNullToBool(objDT.Rows[0][convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvQxUserCodePathEN.UpdUserId = objDT.Rows[0][convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserCodePathEN.UpdDate = objDT.Rows[0][convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserCodePathEN.UserStateName = objDT.Rows[0][convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserCodePathEN.UserStateId = objDT.Rows[0][convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserCodePathEN.Memo = objDT.Rows[0][convQxUserCodePath.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUserCodePathEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserCodePath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN()
{
mId = TransNullToInt(objRow[convQxUserCodePath.mId].ToString().Trim()), //流水号
QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(), //工程名
UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(), //用户名
CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(), //代码路径
CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(), //备份代码路径
DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(), //部门名
QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(), //代码类型名
IsTemplate = TransNullToBool(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()), //是否模板
UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(), //修改日期
UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(), //用户状态名
UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(), //用户状态Id
Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim() //备注
};
objvQxUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserCodePathEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxUserCodePathDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUserCodePathEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vQxUserCodePath_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN()
{
mId = TransNullToInt(objRow[convQxUserCodePath.mId].ToString().Trim()), //流水号
QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(), //项目Id
PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(), //工程名
UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(), //用户名
CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(), //代码路径
CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(), //备份代码路径
DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(), //部门Id
DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(), //部门名
QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(), //代码类型名
IsTemplate = TransNullToBool(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()), //是否模板
UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(), //修改日期
UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(), //用户状态名
UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(), //用户状态Id
Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim() //备注
};
objvQxUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserCodePathEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxUserCodePathEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = TransNullToInt(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = TransNullToBool(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxUserCodePathDA: GetObjByDataRowvQxUserCodePath)", objException.Message));
}
objvQxUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserCodePathEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxUserCodePathEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = TransNullToInt(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = TransNullToBool(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxUserCodePathDA: GetObjByDataRow)", objException.Message));
}
objvQxUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserCodePathEN;
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
objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUserCodePathEN._CurrTabName, convQxUserCodePath.mId, 8, "");
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
objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUserCodePathEN._CurrTabName, convQxUserCodePath.mId, 8, strPrefix);
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
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vQxUserCodePath where " + strCondition;
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
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vQxUserCodePath where " + strCondition;
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
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUserCodePath", "mId = " + ""+ lngmId+""))
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
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vQxUserCodePath_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxUserCodePathDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUserCodePath", strCondition))
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
objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxUserCodePath");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxUserCodePathENS">源对象</param>
 /// <param name = "objvQxUserCodePathENT">目标对象</param>
public void CopyTo(clsvQxUserCodePathEN objvQxUserCodePathENS, clsvQxUserCodePathEN objvQxUserCodePathENT)
{
objvQxUserCodePathENT.mId = objvQxUserCodePathENS.mId; //流水号
objvQxUserCodePathENT.QxPrjId = objvQxUserCodePathENS.QxPrjId; //项目Id
objvQxUserCodePathENT.PrjName = objvQxUserCodePathENS.PrjName; //工程名
objvQxUserCodePathENT.UserId = objvQxUserCodePathENS.UserId; //用户ID
objvQxUserCodePathENT.UserName = objvQxUserCodePathENS.UserName; //用户名
objvQxUserCodePathENT.CodePath = objvQxUserCodePathENS.CodePath; //代码路径
objvQxUserCodePathENT.CodePathBackup = objvQxUserCodePathENS.CodePathBackup; //备份代码路径
objvQxUserCodePathENT.DepartmentId = objvQxUserCodePathENS.DepartmentId; //部门Id
objvQxUserCodePathENT.DepartmentName = objvQxUserCodePathENS.DepartmentName; //部门名
objvQxUserCodePathENT.QxCodeTypeId = objvQxUserCodePathENS.QxCodeTypeId; //代码类型Id
objvQxUserCodePathENT.CodeTypeName = objvQxUserCodePathENS.CodeTypeName; //代码类型名
objvQxUserCodePathENT.IsTemplate = objvQxUserCodePathENS.IsTemplate; //是否模板
objvQxUserCodePathENT.UpdUserId = objvQxUserCodePathENS.UpdUserId; //修改用户Id
objvQxUserCodePathENT.UpdDate = objvQxUserCodePathENS.UpdDate; //修改日期
objvQxUserCodePathENT.UserStateName = objvQxUserCodePathENS.UserStateName; //用户状态名
objvQxUserCodePathENT.UserStateId = objvQxUserCodePathENS.UserStateId; //用户状态Id
objvQxUserCodePathENT.Memo = objvQxUserCodePathENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxUserCodePathEN objvQxUserCodePathEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.QxPrjId, 4, convQxUserCodePath.QxPrjId);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.PrjName, 30, convQxUserCodePath.PrjName);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.UserId, 18, convQxUserCodePath.UserId);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.UserName, 30, convQxUserCodePath.UserName);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.CodePath, 200, convQxUserCodePath.CodePath);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.CodePathBackup, 200, convQxUserCodePath.CodePathBackup);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.DepartmentId, 8, convQxUserCodePath.DepartmentId);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.DepartmentName, 100, convQxUserCodePath.DepartmentName);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.QxCodeTypeId, 4, convQxUserCodePath.QxCodeTypeId);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.CodeTypeName, 30, convQxUserCodePath.CodeTypeName);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.UpdUserId, 20, convQxUserCodePath.UpdUserId);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.UpdDate, 20, convQxUserCodePath.UpdDate);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.UserStateName, 20, convQxUserCodePath.UserStateName);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.UserStateId, 2, convQxUserCodePath.UserStateId);
clsCheckSql.CheckFieldLen(objvQxUserCodePathEN.Memo, 1000, convQxUserCodePath.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.QxPrjId, convQxUserCodePath.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.PrjName, convQxUserCodePath.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.UserId, convQxUserCodePath.UserId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.UserName, convQxUserCodePath.UserName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.CodePath, convQxUserCodePath.CodePath);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.CodePathBackup, convQxUserCodePath.CodePathBackup);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.DepartmentId, convQxUserCodePath.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.DepartmentName, convQxUserCodePath.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.QxCodeTypeId, convQxUserCodePath.QxCodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.CodeTypeName, convQxUserCodePath.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.UpdUserId, convQxUserCodePath.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.UpdDate, convQxUserCodePath.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.UserStateName, convQxUserCodePath.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.UserStateId, convQxUserCodePath.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserCodePathEN.Memo, convQxUserCodePath.Memo);
//检查外键字段长度
 objvQxUserCodePathEN._IsCheckProperty = true;
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
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
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
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
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
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUserCodePathEN._CurrTabName);
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
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUserCodePathEN._CurrTabName, strCondition);
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
 objSQL = clsvQxUserCodePathDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}