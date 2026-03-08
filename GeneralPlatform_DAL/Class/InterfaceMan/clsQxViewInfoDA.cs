
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxViewInfoDA
 表名:QxViewInfo(00140017)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:23:26
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:界面管理(InterfaceMan)
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
 /// 界面(QxViewInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxViewInfoDA : clsCommBase4DA
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
 return clsQxViewInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxViewInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxViewInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxViewInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxViewInfoEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strViewId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strViewId)
{
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:QxViewInfo中,检查关键字,长度不正确!(clsQxViewInfoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QxViewInfo中,关键字不能为空 或 null!(clsQxViewInfoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQxViewInfoDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strViewId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strViewId)
{
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:QxViewInfo中,检查关键字,长度不正确!(简化版)(clsQxViewInfoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:QxViewInfo中,关键字不能为空 或 null!(clsQxViewInfoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsQxViewInfoDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
 strSQL = "Select * from QxViewInfo where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "QxViewInfo");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("QxViewInfo_SelectByCond",values, "QxViewInfo");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxViewInfo where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "QxViewInfo");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxViewInfo a where {0} And a.ViewId not in (Select Top {2} ViewId From QxViewInfo Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxViewInfo");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxViewInfo a where {0} And a.ViewId not in (Select Top {2} ViewId From QxViewInfo Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxViewInfo");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from QxViewInfo a where {0} And a.ViewId not in (Select Top {2} ViewId From QxViewInfo Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "QxViewInfo");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxViewInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTable_QxViewInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxViewInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxViewInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxViewInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxViewInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxViewInfo.* from QxViewInfo Left Join {1} on {2} where {3} and QxViewInfo.ViewId not in (Select top {5} QxViewInfo.ViewId from QxViewInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxViewInfo where {1} and ViewId not in (Select top {2} ViewId from QxViewInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxViewInfo where {1} and ViewId not in (Select top {3} ViewId from QxViewInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxViewInfo.* from QxViewInfo Left Join {1} on {2} where {3} and QxViewInfo.ViewId not in (Select top {5} QxViewInfo.ViewId from QxViewInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxViewInfo where {1} and ViewId not in (Select top {2} ViewId from QxViewInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxViewInfo where {1} and ViewId not in (Select top {3} ViewId from QxViewInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxViewInfo.* from QxViewInfo Left Join {1} on {2} where {3} and QxViewInfo.ViewId not in (Select top {5} QxViewInfo.ViewId from QxViewInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxViewInfo where {1} and ViewId not in (Select top {2} ViewId from QxViewInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxViewInfo where {1} and ViewId not in (Select top {3} ViewId from QxViewInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxViewInfo a where {0} And a.ViewId not in (Select Top {2} ViewId From QxViewInfo Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxViewInfo a where {0} And a.ViewId not in (Select Top {2} ViewId From QxViewInfo Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from QxViewInfo a where {0} And a.ViewId not in (Select Top {2} ViewId From QxViewInfo Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from QxViewInfo a where {0} And a.ViewId not in (Select Top {2} ViewId From QxViewInfo Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsQxViewInfoDA: GetQxViewInfoByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxViewInfo_SelectByCond",values);
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
public List<clsQxViewInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxViewInfoDA:GetObjLst)", objException.Message));
}
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxViewInfoDA: GetObjLst)", objException.Message));
}
objQxViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxViewInfoEN);
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
public List<clsQxViewInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxViewInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxViewInfoDA: GetObjLst)", objException.Message));
}
objQxViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsQxViewInfoEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsQxViewInfoDA:GetObjLstBySP)", objException.Message));
}
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxViewInfo_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsQxViewInfoDA: GetObjLstBySP)", objException.Message));
}
objQxViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxViewInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxViewInfo(ref clsQxViewInfoEN objQxViewInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where ViewId = " + "'"+ objQxViewInfoEN.ViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxViewInfoEN.ViewId = objDT.Rows[0][conQxViewInfo.ViewId].ToString().Trim(); //界面编号(字段类型:char,字段长度:8,是否可空:True)
 objQxViewInfoEN.ViewName = objDT.Rows[0][conQxViewInfo.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objQxViewInfoEN.ViewCnName = objDT.Rows[0][conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称(字段类型:varchar,字段长度:50,是否可空:False)
 objQxViewInfoEN.FileName = objDT.Rows[0][conQxViewInfo.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:500,是否可空:False)
 objQxViewInfoEN.FilePath = objDT.Rows[0][conQxViewInfo.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objQxViewInfoEN.DefaMenuName = objDT.Rows[0][conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxViewInfoEN.ViewTypeCode = objDT.Rows[0][conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码(字段类型:char,字段长度:4,是否可空:False)
 objQxViewInfoEN.DataBaseName = objDT.Rows[0][conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称(字段类型:varchar,字段长度:30,是否可空:True)
 objQxViewInfoEN.QxPrjId = objDT.Rows[0][conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxViewInfoEN.ViewFunction = objDT.Rows[0][conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objQxViewInfoEN.ViewDetail = objDT.Rows[0][conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxViewInfoEN.ModuleId = objDT.Rows[0][conQxViewInfo.ModuleId].ToString().Trim(); //模块号(字段类型:char,字段长度:6,是否可空:False)
 objQxViewInfoEN.UpdDate = objDT.Rows[0][conQxViewInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxViewInfoEN.UpdUserId = objDT.Rows[0][conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxViewInfoEN.Memo = objDT.Rows[0][conQxViewInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxViewInfoDA: GetQxViewInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxViewInfoEN GetObjByViewId(string strViewId)
{
CheckPrimaryKey(strViewId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where ViewId = " + "'"+ strViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
 objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号(字段类型:char,字段长度:8,是否可空:True)
 objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称(字段类型:varchar,字段长度:50,是否可空:False)
 objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:500,是否可空:False)
 objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码(字段类型:char,字段长度:4,是否可空:False)
 objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称(字段类型:varchar,字段长度:30,是否可空:True)
 objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号(字段类型:char,字段长度:6,是否可空:False)
 objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxViewInfoDA: GetObjByViewId)", objException.Message));
}
return objQxViewInfoEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程QxViewInfo_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxViewInfoOneBySP(clsQxViewInfoEN objQxViewInfoEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objQxViewInfoEN.ViewId
};
 objDT = objSQL.ExecSpReturnDT("QxViewInfo_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objQxViewInfoEN.ViewId = objDT.Rows[0][conQxViewInfo.ViewId].ToString().Trim(); //界面编号(字段类型:char,字段长度:8,是否可空:True)
 objQxViewInfoEN.ViewName = objDT.Rows[0][conQxViewInfo.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objQxViewInfoEN.ViewCnName = objDT.Rows[0][conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称(字段类型:varchar,字段长度:50,是否可空:False)
 objQxViewInfoEN.FileName = objDT.Rows[0][conQxViewInfo.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:500,是否可空:False)
 objQxViewInfoEN.FilePath = objDT.Rows[0][conQxViewInfo.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objQxViewInfoEN.DefaMenuName = objDT.Rows[0][conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名(字段类型:varchar,字段长度:50,是否可空:False)
 objQxViewInfoEN.ViewTypeCode = objDT.Rows[0][conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码(字段类型:char,字段长度:4,是否可空:False)
 objQxViewInfoEN.DataBaseName = objDT.Rows[0][conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称(字段类型:varchar,字段长度:30,是否可空:True)
 objQxViewInfoEN.QxPrjId = objDT.Rows[0][conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id(字段类型:char,字段长度:4,是否可空:False)
 objQxViewInfoEN.ViewFunction = objDT.Rows[0][conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objQxViewInfoEN.ViewDetail = objDT.Rows[0][conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息(字段类型:varchar,字段长度:1000,是否可空:True)
 objQxViewInfoEN.ModuleId = objDT.Rows[0][conQxViewInfo.ModuleId].ToString().Trim(); //模块号(字段类型:char,字段长度:6,是否可空:False)
 objQxViewInfoEN.UpdDate = objDT.Rows[0][conQxViewInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:False)
 objQxViewInfoEN.UpdUserId = objDT.Rows[0][conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:False)
 objQxViewInfoEN.Memo = objDT.Rows[0][conQxViewInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxViewInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxViewInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN()
{
ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(), //界面编号
ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(), //界面名称
ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(), //界面中文名称
FileName = objRow[conQxViewInfo.FileName].ToString().Trim(), //文件名
FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(), //文件路径
DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(), //缺省菜单名
ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(), //界面类型码
DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(), //数据库名称
QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(), //项目Id
ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(), //界面功能
ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(), //界面详细信息
ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(), //模块号
UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim() //备注
};
objQxViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxViewInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxViewInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxViewInfoEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsQxViewInfoDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("QxViewInfo_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN()
{
ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(), //界面编号
ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(), //界面名称
ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(), //界面中文名称
FileName = objRow[conQxViewInfo.FileName].ToString().Trim(), //文件名
FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(), //文件路径
DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(), //缺省菜单名
ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(), //界面类型码
DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(), //数据库名称
QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(), //项目Id
ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(), //界面功能
ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(), //界面详细信息
ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(), //模块号
UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim() //备注
};
objQxViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxViewInfoEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxViewInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxViewInfoDA: GetObjByDataRowQxViewInfo)", objException.Message));
}
objQxViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxViewInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxViewInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxViewInfoDA: GetObjByDataRow)", objException.Message));
}
objQxViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxViewInfoEN;
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
objSQL = clsQxViewInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxViewInfoEN._CurrTabName, conQxViewInfo.ViewId, 8, "");
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
objSQL = clsQxViewInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxViewInfoEN._CurrTabName, conQxViewInfo.ViewId, 8, strPrefix);
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
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewId from QxViewInfo where " + strCondition;
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
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewId from QxViewInfo where " + strCondition;
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strViewId)
{
CheckPrimaryKey(strViewId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxViewInfo", "ViewId = " + "'"+ strViewId+"'"))
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strViewId)
{
CheckPrimaryKey(strViewId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strViewId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("QxViewInfo_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxViewInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxViewInfo", strCondition))
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
objSQL = clsQxViewInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxViewInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxViewInfoEN objQxViewInfoEN)
 {
 objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxViewInfoEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxViewInfo");
objRow = objDS.Tables["QxViewInfo"].NewRow();
objRow[conQxViewInfo.ViewId] = objQxViewInfoEN.ViewId; //界面编号
objRow[conQxViewInfo.ViewName] = objQxViewInfoEN.ViewName; //界面名称
objRow[conQxViewInfo.ViewCnName] = objQxViewInfoEN.ViewCnName; //界面中文名称
objRow[conQxViewInfo.FileName] = objQxViewInfoEN.FileName; //文件名
objRow[conQxViewInfo.FilePath] = objQxViewInfoEN.FilePath; //文件路径
objRow[conQxViewInfo.DefaMenuName] = objQxViewInfoEN.DefaMenuName; //缺省菜单名
objRow[conQxViewInfo.ViewTypeCode] = objQxViewInfoEN.ViewTypeCode; //界面类型码
 if (objQxViewInfoEN.DataBaseName !=  "")
 {
objRow[conQxViewInfo.DataBaseName] = objQxViewInfoEN.DataBaseName; //数据库名称
 }
objRow[conQxViewInfo.QxPrjId] = objQxViewInfoEN.QxPrjId; //项目Id
 if (objQxViewInfoEN.ViewFunction !=  "")
 {
objRow[conQxViewInfo.ViewFunction] = objQxViewInfoEN.ViewFunction; //界面功能
 }
 if (objQxViewInfoEN.ViewDetail !=  "")
 {
objRow[conQxViewInfo.ViewDetail] = objQxViewInfoEN.ViewDetail; //界面详细信息
 }
 if (objQxViewInfoEN.ModuleId !=  "")
 {
objRow[conQxViewInfo.ModuleId] = objQxViewInfoEN.ModuleId; //模块号
 }
 if (objQxViewInfoEN.UpdDate !=  "")
 {
objRow[conQxViewInfo.UpdDate] = objQxViewInfoEN.UpdDate; //修改日期
 }
 if (objQxViewInfoEN.UpdUserId !=  "")
 {
objRow[conQxViewInfo.UpdUserId] = objQxViewInfoEN.UpdUserId; //修改用户Id
 }
 if (objQxViewInfoEN.Memo !=  "")
 {
objRow[conQxViewInfo.Memo] = objQxViewInfoEN.Memo; //备注
 }
objDS.Tables[clsQxViewInfoEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxViewInfoEN._CurrTabName);
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
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxViewInfoEN objQxViewInfoEN)
{
 objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxViewInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxViewInfoEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewId);
 var strViewId = objQxViewInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objQxViewInfoEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewName);
 var strViewName = objQxViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objQxViewInfoEN.ViewCnName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewCnName);
 var strViewCnName = objQxViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewCnName + "'");
 }
 
 if (objQxViewInfoEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.FileName);
 var strFileName = objQxViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objQxViewInfoEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.FilePath);
 var strFilePath = objQxViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objQxViewInfoEN.DefaMenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.DefaMenuName);
 var strDefaMenuName = objQxViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaMenuName + "'");
 }
 
 if (objQxViewInfoEN.ViewTypeCode  ==  "")
 {
 objQxViewInfoEN.ViewTypeCode = null;
 }
 if (objQxViewInfoEN.ViewTypeCode !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewTypeCode);
 var strViewTypeCode = objQxViewInfoEN.ViewTypeCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTypeCode + "'");
 }
 
 if (objQxViewInfoEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.DataBaseName);
 var strDataBaseName = objQxViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objQxViewInfoEN.QxPrjId  ==  "")
 {
 objQxViewInfoEN.QxPrjId = null;
 }
 if (objQxViewInfoEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.QxPrjId);
 var strQxPrjId = objQxViewInfoEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxViewInfoEN.ViewFunction !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewFunction);
 var strViewFunction = objQxViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFunction + "'");
 }
 
 if (objQxViewInfoEN.ViewDetail !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewDetail);
 var strViewDetail = objQxViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDetail + "'");
 }
 
 if (objQxViewInfoEN.ModuleId  ==  "")
 {
 objQxViewInfoEN.ModuleId = null;
 }
 if (objQxViewInfoEN.ModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ModuleId);
 var strModuleId = objQxViewInfoEN.ModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModuleId + "'");
 }
 
 if (objQxViewInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.UpdDate);
 var strUpdDate = objQxViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxViewInfoEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.UpdUserId);
 var strUpdUserId = objQxViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxViewInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.Memo);
 var strMemo = objQxViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxViewInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxViewInfoEN objQxViewInfoEN)
{
 objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxViewInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxViewInfoEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewId);
 var strViewId = objQxViewInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objQxViewInfoEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewName);
 var strViewName = objQxViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objQxViewInfoEN.ViewCnName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewCnName);
 var strViewCnName = objQxViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewCnName + "'");
 }
 
 if (objQxViewInfoEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.FileName);
 var strFileName = objQxViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objQxViewInfoEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.FilePath);
 var strFilePath = objQxViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objQxViewInfoEN.DefaMenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.DefaMenuName);
 var strDefaMenuName = objQxViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaMenuName + "'");
 }
 
 if (objQxViewInfoEN.ViewTypeCode  ==  "")
 {
 objQxViewInfoEN.ViewTypeCode = null;
 }
 if (objQxViewInfoEN.ViewTypeCode !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewTypeCode);
 var strViewTypeCode = objQxViewInfoEN.ViewTypeCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTypeCode + "'");
 }
 
 if (objQxViewInfoEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.DataBaseName);
 var strDataBaseName = objQxViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objQxViewInfoEN.QxPrjId  ==  "")
 {
 objQxViewInfoEN.QxPrjId = null;
 }
 if (objQxViewInfoEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.QxPrjId);
 var strQxPrjId = objQxViewInfoEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxViewInfoEN.ViewFunction !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewFunction);
 var strViewFunction = objQxViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFunction + "'");
 }
 
 if (objQxViewInfoEN.ViewDetail !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewDetail);
 var strViewDetail = objQxViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDetail + "'");
 }
 
 if (objQxViewInfoEN.ModuleId  ==  "")
 {
 objQxViewInfoEN.ModuleId = null;
 }
 if (objQxViewInfoEN.ModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ModuleId);
 var strModuleId = objQxViewInfoEN.ModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModuleId + "'");
 }
 
 if (objQxViewInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.UpdDate);
 var strUpdDate = objQxViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxViewInfoEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.UpdUserId);
 var strUpdUserId = objQxViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxViewInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.Memo);
 var strMemo = objQxViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxViewInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQxViewInfoEN.ViewId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxViewInfoEN objQxViewInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxViewInfoEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQxViewInfoEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewId);
 var strViewId = objQxViewInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objQxViewInfoEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewName);
 var strViewName = objQxViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objQxViewInfoEN.ViewCnName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewCnName);
 var strViewCnName = objQxViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewCnName + "'");
 }
 
 if (objQxViewInfoEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.FileName);
 var strFileName = objQxViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objQxViewInfoEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.FilePath);
 var strFilePath = objQxViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objQxViewInfoEN.DefaMenuName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.DefaMenuName);
 var strDefaMenuName = objQxViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaMenuName + "'");
 }
 
 if (objQxViewInfoEN.ViewTypeCode  ==  "")
 {
 objQxViewInfoEN.ViewTypeCode = null;
 }
 if (objQxViewInfoEN.ViewTypeCode !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewTypeCode);
 var strViewTypeCode = objQxViewInfoEN.ViewTypeCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTypeCode + "'");
 }
 
 if (objQxViewInfoEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.DataBaseName);
 var strDataBaseName = objQxViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objQxViewInfoEN.QxPrjId  ==  "")
 {
 objQxViewInfoEN.QxPrjId = null;
 }
 if (objQxViewInfoEN.QxPrjId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.QxPrjId);
 var strQxPrjId = objQxViewInfoEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQxPrjId + "'");
 }
 
 if (objQxViewInfoEN.ViewFunction !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewFunction);
 var strViewFunction = objQxViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFunction + "'");
 }
 
 if (objQxViewInfoEN.ViewDetail !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ViewDetail);
 var strViewDetail = objQxViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDetail + "'");
 }
 
 if (objQxViewInfoEN.ModuleId  ==  "")
 {
 objQxViewInfoEN.ModuleId = null;
 }
 if (objQxViewInfoEN.ModuleId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.ModuleId);
 var strModuleId = objQxViewInfoEN.ModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModuleId + "'");
 }
 
 if (objQxViewInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.UpdDate);
 var strUpdDate = objQxViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxViewInfoEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.UpdUserId);
 var strUpdUserId = objQxViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objQxViewInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxViewInfo.Memo);
 var strMemo = objQxViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxViewInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewQxViewInfoBySP(clsQxViewInfoEN objQxViewInfoEN)
{
//通过存储过程来
//直接使用
 objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxViewInfoEN.ViewId,
 objQxViewInfoEN.ViewName,
 objQxViewInfoEN.ViewCnName,
 objQxViewInfoEN.FileName,
 objQxViewInfoEN.FilePath,
 objQxViewInfoEN.DefaMenuName,
 objQxViewInfoEN.ViewTypeCode,
 objQxViewInfoEN.DataBaseName,
 objQxViewInfoEN.QxPrjId,
 objQxViewInfoEN.ViewFunction,
 objQxViewInfoEN.ViewDetail,
 objQxViewInfoEN.ModuleId,
 objQxViewInfoEN.UpdDate,
 objQxViewInfoEN.UpdUserId,
objQxViewInfoEN.Memo
};
 objSQL.ExecSP("QxViewInfo_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxViewInfos(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where ViewId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxViewInfo");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strViewId = oRow[conQxViewInfo.ViewId].ToString().Trim();
if (IsExist(strViewId))
{
 string strResult = "关键字变量值为:" + string.Format("ViewId = {0}", strViewId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxViewInfoEN._CurrTabName ].NewRow();
objRow[conQxViewInfo.ViewId] = oRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objRow[conQxViewInfo.ViewName] = oRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objRow[conQxViewInfo.ViewCnName] = oRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objRow[conQxViewInfo.FileName] = oRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objRow[conQxViewInfo.FilePath] = oRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objRow[conQxViewInfo.DefaMenuName] = oRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objRow[conQxViewInfo.ViewTypeCode] = oRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objRow[conQxViewInfo.DataBaseName] = oRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objRow[conQxViewInfo.QxPrjId] = oRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objRow[conQxViewInfo.ViewFunction] = oRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objRow[conQxViewInfo.ViewDetail] = oRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objRow[conQxViewInfo.ModuleId] = oRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objRow[conQxViewInfo.UpdDate] = oRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objRow[conQxViewInfo.UpdUserId] = oRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conQxViewInfo.Memo] = oRow[conQxViewInfo.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxViewInfoEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxViewInfoEN._CurrTabName);
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
 /// <param name = "objQxViewInfoEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxViewInfoEN objQxViewInfoEN)
{
 objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxViewInfoEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from QxViewInfo where ViewId = " + "'"+ objQxViewInfoEN.ViewId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxViewInfoEN._CurrTabName);
if (objDS.Tables[clsQxViewInfoEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ViewId = " + "'"+ objQxViewInfoEN.ViewId+"'");
return false;
}
objRow = objDS.Tables[clsQxViewInfoEN._CurrTabName].Rows[0];
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewId))
 {
objRow[conQxViewInfo.ViewId] = objQxViewInfoEN.ViewId; //界面编号
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewName))
 {
objRow[conQxViewInfo.ViewName] = objQxViewInfoEN.ViewName; //界面名称
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewCnName))
 {
objRow[conQxViewInfo.ViewCnName] = objQxViewInfoEN.ViewCnName; //界面中文名称
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.FileName))
 {
objRow[conQxViewInfo.FileName] = objQxViewInfoEN.FileName; //文件名
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.FilePath))
 {
objRow[conQxViewInfo.FilePath] = objQxViewInfoEN.FilePath; //文件路径
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.DefaMenuName))
 {
objRow[conQxViewInfo.DefaMenuName] = objQxViewInfoEN.DefaMenuName; //缺省菜单名
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewTypeCode))
 {
objRow[conQxViewInfo.ViewTypeCode] = objQxViewInfoEN.ViewTypeCode; //界面类型码
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.DataBaseName))
 {
objRow[conQxViewInfo.DataBaseName] = objQxViewInfoEN.DataBaseName; //数据库名称
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.QxPrjId))
 {
objRow[conQxViewInfo.QxPrjId] = objQxViewInfoEN.QxPrjId; //项目Id
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewFunction))
 {
objRow[conQxViewInfo.ViewFunction] = objQxViewInfoEN.ViewFunction; //界面功能
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewDetail))
 {
objRow[conQxViewInfo.ViewDetail] = objQxViewInfoEN.ViewDetail; //界面详细信息
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ModuleId))
 {
objRow[conQxViewInfo.ModuleId] = objQxViewInfoEN.ModuleId; //模块号
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.UpdDate))
 {
objRow[conQxViewInfo.UpdDate] = objQxViewInfoEN.UpdDate; //修改日期
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.UpdUserId))
 {
objRow[conQxViewInfo.UpdUserId] = objQxViewInfoEN.UpdUserId; //修改用户Id
 }
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.Memo))
 {
objRow[conQxViewInfo.Memo] = objQxViewInfoEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxViewInfoEN._CurrTabName);
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
public bool UpdateBySP(clsQxViewInfoEN objQxViewInfoEN)
{
 objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxViewInfoEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objQxViewInfoEN.ViewId,
 objQxViewInfoEN.ViewName,
 objQxViewInfoEN.ViewCnName,
 objQxViewInfoEN.FileName,
 objQxViewInfoEN.FilePath,
 objQxViewInfoEN.DefaMenuName,
 objQxViewInfoEN.ViewTypeCode,
 objQxViewInfoEN.DataBaseName,
 objQxViewInfoEN.QxPrjId,
 objQxViewInfoEN.ViewFunction,
 objQxViewInfoEN.ViewDetail,
 objQxViewInfoEN.ModuleId,
 objQxViewInfoEN.UpdDate,
 objQxViewInfoEN.UpdUserId,
 objQxViewInfoEN.Memo
};
 objSQL.ExecSP("QxViewInfo_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxViewInfoEN objQxViewInfoEN)
{
 objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxViewInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxViewInfo Set ");
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewName))
 {
 if (objQxViewInfoEN.ViewName !=  null)
 {
 var strViewName = objQxViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewName, conQxViewInfo.ViewName); //界面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ViewName); //界面名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewCnName))
 {
 if (objQxViewInfoEN.ViewCnName !=  null)
 {
 var strViewCnName = objQxViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewCnName, conQxViewInfo.ViewCnName); //界面中文名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ViewCnName); //界面中文名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.FileName))
 {
 if (objQxViewInfoEN.FileName !=  null)
 {
 var strFileName = objQxViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conQxViewInfo.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.FileName); //文件名
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.FilePath))
 {
 if (objQxViewInfoEN.FilePath !=  null)
 {
 var strFilePath = objQxViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conQxViewInfo.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.FilePath); //文件路径
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.DefaMenuName))
 {
 if (objQxViewInfoEN.DefaMenuName !=  null)
 {
 var strDefaMenuName = objQxViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaMenuName, conQxViewInfo.DefaMenuName); //缺省菜单名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.DefaMenuName); //缺省菜单名
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewTypeCode))
 {
 if (objQxViewInfoEN.ViewTypeCode  ==  "")
 {
 objQxViewInfoEN.ViewTypeCode = null;
 }
 if (objQxViewInfoEN.ViewTypeCode !=  null)
 {
 var strViewTypeCode = objQxViewInfoEN.ViewTypeCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewTypeCode, conQxViewInfo.ViewTypeCode); //界面类型码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ViewTypeCode); //界面类型码
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.DataBaseName))
 {
 if (objQxViewInfoEN.DataBaseName !=  null)
 {
 var strDataBaseName = objQxViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseName, conQxViewInfo.DataBaseName); //数据库名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.DataBaseName); //数据库名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.QxPrjId))
 {
 if (objQxViewInfoEN.QxPrjId  ==  "")
 {
 objQxViewInfoEN.QxPrjId = null;
 }
 if (objQxViewInfoEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxViewInfoEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxViewInfo.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.QxPrjId); //项目Id
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewFunction))
 {
 if (objQxViewInfoEN.ViewFunction !=  null)
 {
 var strViewFunction = objQxViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewFunction, conQxViewInfo.ViewFunction); //界面功能
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ViewFunction); //界面功能
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewDetail))
 {
 if (objQxViewInfoEN.ViewDetail !=  null)
 {
 var strViewDetail = objQxViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewDetail, conQxViewInfo.ViewDetail); //界面详细信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ViewDetail); //界面详细信息
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ModuleId))
 {
 if (objQxViewInfoEN.ModuleId  ==  "")
 {
 objQxViewInfoEN.ModuleId = null;
 }
 if (objQxViewInfoEN.ModuleId !=  null)
 {
 var strModuleId = objQxViewInfoEN.ModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModuleId, conQxViewInfo.ModuleId); //模块号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ModuleId); //模块号
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.UpdDate))
 {
 if (objQxViewInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objQxViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxViewInfo.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.UpdDate); //修改日期
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.UpdUserId))
 {
 if (objQxViewInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxViewInfo.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.Memo))
 {
 if (objQxViewInfoEN.Memo !=  null)
 {
 var strMemo = objQxViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxViewInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewId = '{0}'", objQxViewInfoEN.ViewId); 
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
 /// <param name = "objQxViewInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxViewInfoEN objQxViewInfoEN, string strCondition)
{
 objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxViewInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxViewInfo Set ");
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewName))
 {
 if (objQxViewInfoEN.ViewName !=  null)
 {
 var strViewName = objQxViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewName = '{0}',", strViewName); //界面名称
 }
 else
 {
 sbSQL.Append(" ViewName = null,"); //界面名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewCnName))
 {
 if (objQxViewInfoEN.ViewCnName !=  null)
 {
 var strViewCnName = objQxViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewCnName = '{0}',", strViewCnName); //界面中文名称
 }
 else
 {
 sbSQL.Append(" ViewCnName = null,"); //界面中文名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.FileName))
 {
 if (objQxViewInfoEN.FileName !=  null)
 {
 var strFileName = objQxViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.FilePath))
 {
 if (objQxViewInfoEN.FilePath !=  null)
 {
 var strFilePath = objQxViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.DefaMenuName))
 {
 if (objQxViewInfoEN.DefaMenuName !=  null)
 {
 var strDefaMenuName = objQxViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaMenuName = '{0}',", strDefaMenuName); //缺省菜单名
 }
 else
 {
 sbSQL.Append(" DefaMenuName = null,"); //缺省菜单名
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewTypeCode))
 {
 if (objQxViewInfoEN.ViewTypeCode  ==  "")
 {
 objQxViewInfoEN.ViewTypeCode = null;
 }
 if (objQxViewInfoEN.ViewTypeCode !=  null)
 {
 var strViewTypeCode = objQxViewInfoEN.ViewTypeCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewTypeCode = '{0}',", strViewTypeCode); //界面类型码
 }
 else
 {
 sbSQL.Append(" ViewTypeCode = null,"); //界面类型码
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.DataBaseName))
 {
 if (objQxViewInfoEN.DataBaseName !=  null)
 {
 var strDataBaseName = objQxViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseName = '{0}',", strDataBaseName); //数据库名称
 }
 else
 {
 sbSQL.Append(" DataBaseName = null,"); //数据库名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.QxPrjId))
 {
 if (objQxViewInfoEN.QxPrjId  ==  "")
 {
 objQxViewInfoEN.QxPrjId = null;
 }
 if (objQxViewInfoEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxViewInfoEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewFunction))
 {
 if (objQxViewInfoEN.ViewFunction !=  null)
 {
 var strViewFunction = objQxViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewFunction = '{0}',", strViewFunction); //界面功能
 }
 else
 {
 sbSQL.Append(" ViewFunction = null,"); //界面功能
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewDetail))
 {
 if (objQxViewInfoEN.ViewDetail !=  null)
 {
 var strViewDetail = objQxViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewDetail = '{0}',", strViewDetail); //界面详细信息
 }
 else
 {
 sbSQL.Append(" ViewDetail = null,"); //界面详细信息
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ModuleId))
 {
 if (objQxViewInfoEN.ModuleId  ==  "")
 {
 objQxViewInfoEN.ModuleId = null;
 }
 if (objQxViewInfoEN.ModuleId !=  null)
 {
 var strModuleId = objQxViewInfoEN.ModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModuleId = '{0}',", strModuleId); //模块号
 }
 else
 {
 sbSQL.Append(" ModuleId = null,"); //模块号
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.UpdDate))
 {
 if (objQxViewInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objQxViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.UpdUserId))
 {
 if (objQxViewInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.Memo))
 {
 if (objQxViewInfoEN.Memo !=  null)
 {
 var strMemo = objQxViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxViewInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxViewInfoEN objQxViewInfoEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxViewInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxViewInfo Set ");
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewName))
 {
 if (objQxViewInfoEN.ViewName !=  null)
 {
 var strViewName = objQxViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewName = '{0}',", strViewName); //界面名称
 }
 else
 {
 sbSQL.Append(" ViewName = null,"); //界面名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewCnName))
 {
 if (objQxViewInfoEN.ViewCnName !=  null)
 {
 var strViewCnName = objQxViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewCnName = '{0}',", strViewCnName); //界面中文名称
 }
 else
 {
 sbSQL.Append(" ViewCnName = null,"); //界面中文名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.FileName))
 {
 if (objQxViewInfoEN.FileName !=  null)
 {
 var strFileName = objQxViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.FilePath))
 {
 if (objQxViewInfoEN.FilePath !=  null)
 {
 var strFilePath = objQxViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.DefaMenuName))
 {
 if (objQxViewInfoEN.DefaMenuName !=  null)
 {
 var strDefaMenuName = objQxViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaMenuName = '{0}',", strDefaMenuName); //缺省菜单名
 }
 else
 {
 sbSQL.Append(" DefaMenuName = null,"); //缺省菜单名
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewTypeCode))
 {
 if (objQxViewInfoEN.ViewTypeCode  ==  "")
 {
 objQxViewInfoEN.ViewTypeCode = null;
 }
 if (objQxViewInfoEN.ViewTypeCode !=  null)
 {
 var strViewTypeCode = objQxViewInfoEN.ViewTypeCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewTypeCode = '{0}',", strViewTypeCode); //界面类型码
 }
 else
 {
 sbSQL.Append(" ViewTypeCode = null,"); //界面类型码
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.DataBaseName))
 {
 if (objQxViewInfoEN.DataBaseName !=  null)
 {
 var strDataBaseName = objQxViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseName = '{0}',", strDataBaseName); //数据库名称
 }
 else
 {
 sbSQL.Append(" DataBaseName = null,"); //数据库名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.QxPrjId))
 {
 if (objQxViewInfoEN.QxPrjId  ==  "")
 {
 objQxViewInfoEN.QxPrjId = null;
 }
 if (objQxViewInfoEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxViewInfoEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QxPrjId = '{0}',", strQxPrjId); //项目Id
 }
 else
 {
 sbSQL.Append(" QxPrjId = null,"); //项目Id
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewFunction))
 {
 if (objQxViewInfoEN.ViewFunction !=  null)
 {
 var strViewFunction = objQxViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewFunction = '{0}',", strViewFunction); //界面功能
 }
 else
 {
 sbSQL.Append(" ViewFunction = null,"); //界面功能
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewDetail))
 {
 if (objQxViewInfoEN.ViewDetail !=  null)
 {
 var strViewDetail = objQxViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewDetail = '{0}',", strViewDetail); //界面详细信息
 }
 else
 {
 sbSQL.Append(" ViewDetail = null,"); //界面详细信息
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ModuleId))
 {
 if (objQxViewInfoEN.ModuleId  ==  "")
 {
 objQxViewInfoEN.ModuleId = null;
 }
 if (objQxViewInfoEN.ModuleId !=  null)
 {
 var strModuleId = objQxViewInfoEN.ModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModuleId = '{0}',", strModuleId); //模块号
 }
 else
 {
 sbSQL.Append(" ModuleId = null,"); //模块号
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.UpdDate))
 {
 if (objQxViewInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objQxViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.UpdUserId))
 {
 if (objQxViewInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.Memo))
 {
 if (objQxViewInfoEN.Memo !=  null)
 {
 var strMemo = objQxViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxViewInfoEN objQxViewInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxViewInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxViewInfo Set ");
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewName))
 {
 if (objQxViewInfoEN.ViewName !=  null)
 {
 var strViewName = objQxViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewName, conQxViewInfo.ViewName); //界面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ViewName); //界面名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewCnName))
 {
 if (objQxViewInfoEN.ViewCnName !=  null)
 {
 var strViewCnName = objQxViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewCnName, conQxViewInfo.ViewCnName); //界面中文名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ViewCnName); //界面中文名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.FileName))
 {
 if (objQxViewInfoEN.FileName !=  null)
 {
 var strFileName = objQxViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conQxViewInfo.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.FileName); //文件名
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.FilePath))
 {
 if (objQxViewInfoEN.FilePath !=  null)
 {
 var strFilePath = objQxViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conQxViewInfo.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.FilePath); //文件路径
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.DefaMenuName))
 {
 if (objQxViewInfoEN.DefaMenuName !=  null)
 {
 var strDefaMenuName = objQxViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaMenuName, conQxViewInfo.DefaMenuName); //缺省菜单名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.DefaMenuName); //缺省菜单名
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewTypeCode))
 {
 if (objQxViewInfoEN.ViewTypeCode  ==  "")
 {
 objQxViewInfoEN.ViewTypeCode = null;
 }
 if (objQxViewInfoEN.ViewTypeCode !=  null)
 {
 var strViewTypeCode = objQxViewInfoEN.ViewTypeCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewTypeCode, conQxViewInfo.ViewTypeCode); //界面类型码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ViewTypeCode); //界面类型码
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.DataBaseName))
 {
 if (objQxViewInfoEN.DataBaseName !=  null)
 {
 var strDataBaseName = objQxViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseName, conQxViewInfo.DataBaseName); //数据库名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.DataBaseName); //数据库名称
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.QxPrjId))
 {
 if (objQxViewInfoEN.QxPrjId  ==  "")
 {
 objQxViewInfoEN.QxPrjId = null;
 }
 if (objQxViewInfoEN.QxPrjId !=  null)
 {
 var strQxPrjId = objQxViewInfoEN.QxPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQxPrjId, conQxViewInfo.QxPrjId); //项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.QxPrjId); //项目Id
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewFunction))
 {
 if (objQxViewInfoEN.ViewFunction !=  null)
 {
 var strViewFunction = objQxViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewFunction, conQxViewInfo.ViewFunction); //界面功能
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ViewFunction); //界面功能
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ViewDetail))
 {
 if (objQxViewInfoEN.ViewDetail !=  null)
 {
 var strViewDetail = objQxViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewDetail, conQxViewInfo.ViewDetail); //界面详细信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ViewDetail); //界面详细信息
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.ModuleId))
 {
 if (objQxViewInfoEN.ModuleId  ==  "")
 {
 objQxViewInfoEN.ModuleId = null;
 }
 if (objQxViewInfoEN.ModuleId !=  null)
 {
 var strModuleId = objQxViewInfoEN.ModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModuleId, conQxViewInfo.ModuleId); //模块号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.ModuleId); //模块号
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.UpdDate))
 {
 if (objQxViewInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objQxViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxViewInfo.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.UpdDate); //修改日期
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.UpdUserId))
 {
 if (objQxViewInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objQxViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conQxViewInfo.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.UpdUserId); //修改用户Id
 }
 }
 
 if (objQxViewInfoEN.IsUpdated(conQxViewInfo.Memo))
 {
 if (objQxViewInfoEN.Memo !=  null)
 {
 var strMemo = objQxViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxViewInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxViewInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewId = '{0}'", objQxViewInfoEN.ViewId); 
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strViewId) 
{
CheckPrimaryKey(strViewId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strViewId,
};
 objSQL.ExecSP("QxViewInfo_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strViewId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strViewId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strViewId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
//删除QxViewInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxViewInfo where ViewId = " + "'"+ strViewId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxViewInfo(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
//删除QxViewInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxViewInfo where ViewId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strViewId) 
{
CheckPrimaryKey(strViewId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
//删除QxViewInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxViewInfo where ViewId = " + "'"+ strViewId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxViewInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxViewInfoDA: DelQxViewInfo)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxViewInfo where " + strCondition ;
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
public bool DelQxViewInfoWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxViewInfoDA: DelQxViewInfoWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxViewInfo where " + strCondition ;
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
 /// <param name = "objQxViewInfoENS">源对象</param>
 /// <param name = "objQxViewInfoENT">目标对象</param>
public void CopyTo(clsQxViewInfoEN objQxViewInfoENS, clsQxViewInfoEN objQxViewInfoENT)
{
objQxViewInfoENT.ViewId = objQxViewInfoENS.ViewId; //界面编号
objQxViewInfoENT.ViewName = objQxViewInfoENS.ViewName; //界面名称
objQxViewInfoENT.ViewCnName = objQxViewInfoENS.ViewCnName; //界面中文名称
objQxViewInfoENT.FileName = objQxViewInfoENS.FileName; //文件名
objQxViewInfoENT.FilePath = objQxViewInfoENS.FilePath; //文件路径
objQxViewInfoENT.DefaMenuName = objQxViewInfoENS.DefaMenuName; //缺省菜单名
objQxViewInfoENT.ViewTypeCode = objQxViewInfoENS.ViewTypeCode; //界面类型码
objQxViewInfoENT.DataBaseName = objQxViewInfoENS.DataBaseName; //数据库名称
objQxViewInfoENT.QxPrjId = objQxViewInfoENS.QxPrjId; //项目Id
objQxViewInfoENT.ViewFunction = objQxViewInfoENS.ViewFunction; //界面功能
objQxViewInfoENT.ViewDetail = objQxViewInfoENS.ViewDetail; //界面详细信息
objQxViewInfoENT.ModuleId = objQxViewInfoENS.ModuleId; //模块号
objQxViewInfoENT.UpdDate = objQxViewInfoENS.UpdDate; //修改日期
objQxViewInfoENT.UpdUserId = objQxViewInfoENS.UpdUserId; //修改用户Id
objQxViewInfoENT.Memo = objQxViewInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxViewInfoEN objQxViewInfoEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxViewInfoEN.ViewName, conQxViewInfo.ViewName);
clsCheckSql.CheckFieldNotNull(objQxViewInfoEN.ViewCnName, conQxViewInfo.ViewCnName);
clsCheckSql.CheckFieldNotNull(objQxViewInfoEN.FileName, conQxViewInfo.FileName);
clsCheckSql.CheckFieldNotNull(objQxViewInfoEN.FilePath, conQxViewInfo.FilePath);
clsCheckSql.CheckFieldNotNull(objQxViewInfoEN.DefaMenuName, conQxViewInfo.DefaMenuName);
clsCheckSql.CheckFieldNotNull(objQxViewInfoEN.ViewTypeCode, conQxViewInfo.ViewTypeCode);
clsCheckSql.CheckFieldNotNull(objQxViewInfoEN.QxPrjId, conQxViewInfo.QxPrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewId, 8, conQxViewInfo.ViewId);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewName, 100, conQxViewInfo.ViewName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewCnName, 50, conQxViewInfo.ViewCnName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.FileName, 500, conQxViewInfo.FileName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.FilePath, 500, conQxViewInfo.FilePath);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.DefaMenuName, 50, conQxViewInfo.DefaMenuName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewTypeCode, 4, conQxViewInfo.ViewTypeCode);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.DataBaseName, 30, conQxViewInfo.DataBaseName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.QxPrjId, 4, conQxViewInfo.QxPrjId);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewFunction, 100, conQxViewInfo.ViewFunction);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewDetail, 1000, conQxViewInfo.ViewDetail);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ModuleId, 6, conQxViewInfo.ModuleId);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.UpdDate, 20, conQxViewInfo.UpdDate);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.UpdUserId, 20, conQxViewInfo.UpdUserId);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.Memo, 1000, conQxViewInfo.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxViewInfoEN.ViewTypeCode, 4, conQxViewInfo.ViewTypeCode);
clsCheckSql.CheckFieldForeignKey(objQxViewInfoEN.QxPrjId, 4, conQxViewInfo.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxViewInfoEN.ModuleId, 6, conQxViewInfo.ModuleId);
 objQxViewInfoEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxViewInfoEN objQxViewInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewName, 100, conQxViewInfo.ViewName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewCnName, 50, conQxViewInfo.ViewCnName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.FileName, 500, conQxViewInfo.FileName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.FilePath, 500, conQxViewInfo.FilePath);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.DefaMenuName, 50, conQxViewInfo.DefaMenuName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewTypeCode, 4, conQxViewInfo.ViewTypeCode);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.DataBaseName, 30, conQxViewInfo.DataBaseName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.QxPrjId, 4, conQxViewInfo.QxPrjId);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewFunction, 100, conQxViewInfo.ViewFunction);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewDetail, 1000, conQxViewInfo.ViewDetail);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ModuleId, 6, conQxViewInfo.ModuleId);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.UpdDate, 20, conQxViewInfo.UpdDate);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.UpdUserId, 20, conQxViewInfo.UpdUserId);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.Memo, 1000, conQxViewInfo.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxViewInfoEN.ViewTypeCode, 4, conQxViewInfo.ViewTypeCode);
clsCheckSql.CheckFieldForeignKey(objQxViewInfoEN.QxPrjId, 4, conQxViewInfo.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxViewInfoEN.ModuleId, 6, conQxViewInfo.ModuleId);
 objQxViewInfoEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxViewInfoEN objQxViewInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewId, 8, conQxViewInfo.ViewId);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewName, 100, conQxViewInfo.ViewName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewCnName, 50, conQxViewInfo.ViewCnName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.FileName, 500, conQxViewInfo.FileName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.FilePath, 500, conQxViewInfo.FilePath);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.DefaMenuName, 50, conQxViewInfo.DefaMenuName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewTypeCode, 4, conQxViewInfo.ViewTypeCode);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.DataBaseName, 30, conQxViewInfo.DataBaseName);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.QxPrjId, 4, conQxViewInfo.QxPrjId);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewFunction, 100, conQxViewInfo.ViewFunction);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ViewDetail, 1000, conQxViewInfo.ViewDetail);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.ModuleId, 6, conQxViewInfo.ModuleId);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.UpdDate, 20, conQxViewInfo.UpdDate);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.UpdUserId, 20, conQxViewInfo.UpdUserId);
clsCheckSql.CheckFieldLen(objQxViewInfoEN.Memo, 1000, conQxViewInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.ViewId, conQxViewInfo.ViewId);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.ViewName, conQxViewInfo.ViewName);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.ViewCnName, conQxViewInfo.ViewCnName);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.FileName, conQxViewInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.FilePath, conQxViewInfo.FilePath);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.DefaMenuName, conQxViewInfo.DefaMenuName);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.ViewTypeCode, conQxViewInfo.ViewTypeCode);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.DataBaseName, conQxViewInfo.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.QxPrjId, conQxViewInfo.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.ViewFunction, conQxViewInfo.ViewFunction);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.ViewDetail, conQxViewInfo.ViewDetail);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.ModuleId, conQxViewInfo.ModuleId);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.UpdDate, conQxViewInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.UpdUserId, conQxViewInfo.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objQxViewInfoEN.Memo, conQxViewInfo.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxViewInfoEN.ViewTypeCode, 4, conQxViewInfo.ViewTypeCode);
clsCheckSql.CheckFieldForeignKey(objQxViewInfoEN.QxPrjId, 4, conQxViewInfo.QxPrjId);
clsCheckSql.CheckFieldForeignKey(objQxViewInfoEN.ModuleId, 6, conQxViewInfo.ModuleId);
 objQxViewInfoEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetViewId()
{
//获取某学院所有专业信息
string strSQL = "select ViewId, ViewName from QxViewInfo ";
 clsSpecSQLforSql mySql = clsQxViewInfoDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxViewInfo(界面),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxViewInfoEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxViewInfoEN objQxViewInfoEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewName = '{0}'", objQxViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxViewInfoEN.QxPrjId);
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
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxViewInfoEN._CurrTabName);
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
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxViewInfoEN._CurrTabName, strCondition);
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
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
 objSQL = clsQxViewInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}