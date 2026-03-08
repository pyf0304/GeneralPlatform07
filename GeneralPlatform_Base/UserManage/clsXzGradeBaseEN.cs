
//----------------------
//生成代码版本:2016.05.09.1
//生成日期:2016/05/11
//生成者:潘以锋
//工程名称:统一平台
//工程ID:0014
//模块中文名:用户管理
//模块英文名:UserManage
//注意:1、需要数据底层(PubDataBase.dll)的版本:2016.05.10.01
//       2、需要公共函数层(TzPubFunction.dll)的版本:2016.05.10.01
//========================
using System;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace GeneralPlatform.Entity
{
    /// <summary>
    /// 年级基本信息(XzGradeBase)
    /// </summary>
    [Serializable]
    public class clsXzGradeBaseEN : clsEntityBase2
    {
        public const string _CurrTabName_S = "XzGradeBase"; //当前表名,与该类相关的表名
        public const string _CurrTabKeyFldName_S = "id_GradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
        protected const int mintAttributeCount = 16;
        public static string[] AttributeName = new string[] { "id_GradeBase", "GradeBaseID", "GradeBaseName", "SchoolYear", "SchoolTerm", "EnterSchoolDate", "CurrentTermSeq", "ExecPlanTermIndex", "SetEPTermIndexDate", "IsOffed", "ModifyDate", "ModifyUserID", "GradeIndex", "BeginYearMonth", "EndYearMonth", "AllowUpBaseInfo" };
        //以下是属性变量

        protected string mstrid_GradeBase;    //年级流水号
        protected string mstrGradeBaseID;    //年级代号
        protected string mstrGradeBaseName;    //年级名称
        protected string mstrSchoolYear;    //学年
        protected string mstrSchoolTerm;    //学期
        protected string mstrEnterSchoolDate;    //进校日期
        protected int mintCurrentTermSeq;    //当前学期
        protected int mintExecPlanTermIndex;    //生成执行计划学期
        protected string mstrSetEPTermIndexDate;    //设定执行计划学期日期
        protected bool mbolIsOffed;    //是否毕业
        protected string mstrModifyDate;    //修改日期
        protected string mstrModifyUserID;    //修改人
        protected int mintGradeIndex;    //年级序号
        protected string mstrBeginYearMonth;    //开始年月
        protected string mstrEndYearMonth;    //结束年月
        protected bool mbolAllowUpBaseInfo;    //允许修改基本信息



        /// <summary>
        /// 常量:"id_GradeBase"
        /// </summary>
        public const string con_id_GradeBase = "id_GradeBase";    //年级流水号

        /// <summary>
        /// 常量:"GradeBaseID"
        /// </summary>
        public const string con_GradeBaseID = "GradeBaseID";    //年级代号

        /// <summary>
        /// 常量:"GradeBaseName"
        /// </summary>
        public const string con_GradeBaseName = "GradeBaseName";    //年级名称

        /// <summary>
        /// 常量:"SchoolYear"
        /// </summary>
        public const string con_SchoolYear = "SchoolYear";    //学年

        /// <summary>
        /// 常量:"SchoolTerm"
        /// </summary>
        public const string con_SchoolTerm = "SchoolTerm";    //学期

        /// <summary>
        /// 常量:"EnterSchoolDate"
        /// </summary>
        public const string con_EnterSchoolDate = "EnterSchoolDate";    //进校日期

        /// <summary>
        /// 常量:"CurrentTermSeq"
        /// </summary>
        public const string con_CurrentTermSeq = "CurrentTermSeq";    //当前学期

        /// <summary>
        /// 常量:"ExecPlanTermIndex"
        /// </summary>
        public const string con_ExecPlanTermIndex = "ExecPlanTermIndex";    //生成执行计划学期

        /// <summary>
        /// 常量:"SetEPTermIndexDate"
        /// </summary>
        public const string con_SetEPTermIndexDate = "SetEPTermIndexDate";    //设定执行计划学期日期

        /// <summary>
        /// 常量:"IsOffed"
        /// </summary>
        public const string con_IsOffed = "IsOffed";    //是否毕业

        /// <summary>
        /// 常量:"ModifyDate"
        /// </summary>
        public const string con_ModifyDate = "ModifyDate";    //修改日期

        /// <summary>
        /// 常量:"ModifyUserID"
        /// </summary>
        public const string con_ModifyUserID = "ModifyUserID";    //修改人

        /// <summary>
        /// 常量:"GradeIndex"
        /// </summary>
        public const string con_GradeIndex = "GradeIndex";    //年级序号

        /// <summary>
        /// 常量:"BeginYearMonth"
        /// </summary>
        public const string con_BeginYearMonth = "BeginYearMonth";    //开始年月

        /// <summary>
        /// 常量:"EndYearMonth"
        /// </summary>
        public const string con_EndYearMonth = "EndYearMonth";    //结束年月

        /// <summary>
        /// 常量:"AllowUpBaseInfo"
        /// </summary>
        public const string con_AllowUpBaseInfo = "AllowUpBaseInfo";    //允许修改基本信息

        /// <summary>
        /// 常量:"IntTag"
        /// </summary>
        public const string con_IntTag = "IntTag";    //整型Tag

        /// <summary>
        /// 常量:"StrTag"
        /// </summary>
        public const string con_StrTag = "StrTag";    //字符型标签

        /// <summary>
        /// 常量:"IsCheckProperty"
        /// </summary>
        public const string con_IsCheckProperty = "IsCheckProperty";    //是否检查属性

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        /// <summary>
        /// 当前所使用的连接串内容
        /// </summary>
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsXzGradeBaseEN()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "XzGradeBase";
            lstKeyFldNames.Add("id_GradeBase");
        }

        public clsXzGradeBaseEN(string strid_GradeBase)
        {
            strid_GradeBase = strid_GradeBase.Replace("'", "''");
            if (strid_GradeBase.Length > 4)
            {
                throw new Exception("在表:XzGradeBase中,关键字长度不正确!");
            }
            if (string.IsNullOrEmpty(strid_GradeBase) == true)
            {
                throw new Exception("在表:XzGradeBase中,关键字不能为空 或 null!");
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strid_GradeBase);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
            }

            mstrid_GradeBase = strid_GradeBase;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "XzGradeBase";
            lstKeyFldNames.Add("id_GradeBase");
        }

        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == con_id_GradeBase)
                {
                    return mstrid_GradeBase;
                }
                else if (strAttributeName == con_GradeBaseID)
                {
                    return mstrGradeBaseID;
                }
                else if (strAttributeName == con_GradeBaseName)
                {
                    return mstrGradeBaseName;
                }
                else if (strAttributeName == con_SchoolYear)
                {
                    return mstrSchoolYear;
                }
                else if (strAttributeName == con_SchoolTerm)
                {
                    return mstrSchoolTerm;
                }
                else if (strAttributeName == con_EnterSchoolDate)
                {
                    return mstrEnterSchoolDate;
                }
                else if (strAttributeName == con_CurrentTermSeq)
                {
                    return mintCurrentTermSeq;
                }
                else if (strAttributeName == con_ExecPlanTermIndex)
                {
                    return mintExecPlanTermIndex;
                }
                else if (strAttributeName == con_SetEPTermIndexDate)
                {
                    return mstrSetEPTermIndexDate;
                }
                else if (strAttributeName == con_IsOffed)
                {
                    return mbolIsOffed;
                }
                else if (strAttributeName == con_ModifyDate)
                {
                    return mstrModifyDate;
                }
                else if (strAttributeName == con_ModifyUserID)
                {
                    return mstrModifyUserID;
                }
                else if (strAttributeName == con_GradeIndex)
                {
                    return mintGradeIndex;
                }
                else if (strAttributeName == con_BeginYearMonth)
                {
                    return mstrBeginYearMonth;
                }
                else if (strAttributeName == con_EndYearMonth)
                {
                    return mstrEndYearMonth;
                }
                else if (strAttributeName == con_AllowUpBaseInfo)
                {
                    return mbolAllowUpBaseInfo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == con_id_GradeBase)
                {
                    mstrid_GradeBase = value.ToString();
                    AddUpdatedFld(con_id_GradeBase);
                }
                else if (strAttributeName == con_GradeBaseID)
                {
                    mstrGradeBaseID = value.ToString();
                    AddUpdatedFld(con_GradeBaseID);
                }
                else if (strAttributeName == con_GradeBaseName)
                {
                    mstrGradeBaseName = value.ToString();
                    AddUpdatedFld(con_GradeBaseName);
                }
                else if (strAttributeName == con_SchoolYear)
                {
                    mstrSchoolYear = value.ToString();
                    AddUpdatedFld(con_SchoolYear);
                }
                else if (strAttributeName == con_SchoolTerm)
                {
                    mstrSchoolTerm = value.ToString();
                    AddUpdatedFld(con_SchoolTerm);
                }
                else if (strAttributeName == con_EnterSchoolDate)
                {
                    mstrEnterSchoolDate = value.ToString();
                    AddUpdatedFld(con_EnterSchoolDate);
                }
                else if (strAttributeName == con_CurrentTermSeq)
                {
                    mintCurrentTermSeq = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_CurrentTermSeq);
                }
                else if (strAttributeName == con_ExecPlanTermIndex)
                {
                    mintExecPlanTermIndex = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_ExecPlanTermIndex);
                }
                else if (strAttributeName == con_SetEPTermIndexDate)
                {
                    mstrSetEPTermIndexDate = value.ToString();
                    AddUpdatedFld(con_SetEPTermIndexDate);
                }
                else if (strAttributeName == con_IsOffed)
                {
                    mbolIsOffed = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsOffed);
                }
                else if (strAttributeName == con_ModifyDate)
                {
                    mstrModifyDate = value.ToString();
                    AddUpdatedFld(con_ModifyDate);
                }
                else if (strAttributeName == con_ModifyUserID)
                {
                    mstrModifyUserID = value.ToString();
                    AddUpdatedFld(con_ModifyUserID);
                }
                else if (strAttributeName == con_GradeIndex)
                {
                    mintGradeIndex = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_GradeIndex);
                }
                else if (strAttributeName == con_BeginYearMonth)
                {
                    mstrBeginYearMonth = value.ToString();
                    AddUpdatedFld(con_BeginYearMonth);
                }
                else if (strAttributeName == con_EndYearMonth)
                {
                    mstrEndYearMonth = value.ToString();
                    AddUpdatedFld(con_EndYearMonth);
                }
                else if (strAttributeName == con_AllowUpBaseInfo)
                {
                    mbolAllowUpBaseInfo = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_AllowUpBaseInfo);
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if (con_id_GradeBase == AttributeName[intIndex])
                {
                    return mstrid_GradeBase;
                }
                else if (con_GradeBaseID == AttributeName[intIndex])
                {
                    return mstrGradeBaseID;
                }
                else if (con_GradeBaseName == AttributeName[intIndex])
                {
                    return mstrGradeBaseName;
                }
                else if (con_SchoolYear == AttributeName[intIndex])
                {
                    return mstrSchoolYear;
                }
                else if (con_SchoolTerm == AttributeName[intIndex])
                {
                    return mstrSchoolTerm;
                }
                else if (con_EnterSchoolDate == AttributeName[intIndex])
                {
                    return mstrEnterSchoolDate;
                }
                else if (con_CurrentTermSeq == AttributeName[intIndex])
                {
                    return mintCurrentTermSeq;
                }
                else if (con_ExecPlanTermIndex == AttributeName[intIndex])
                {
                    return mintExecPlanTermIndex;
                }
                else if (con_SetEPTermIndexDate == AttributeName[intIndex])
                {
                    return mstrSetEPTermIndexDate;
                }
                else if (con_IsOffed == AttributeName[intIndex])
                {
                    return mbolIsOffed;
                }
                else if (con_ModifyDate == AttributeName[intIndex])
                {
                    return mstrModifyDate;
                }
                else if (con_ModifyUserID == AttributeName[intIndex])
                {
                    return mstrModifyUserID;
                }
                else if (con_GradeIndex == AttributeName[intIndex])
                {
                    return mintGradeIndex;
                }
                else if (con_BeginYearMonth == AttributeName[intIndex])
                {
                    return mstrBeginYearMonth;
                }
                else if (con_EndYearMonth == AttributeName[intIndex])
                {
                    return mstrEndYearMonth;
                }
                else if (con_AllowUpBaseInfo == AttributeName[intIndex])
                {
                    return mbolAllowUpBaseInfo;
                }
                return null;
            }
            set
            {
                if (con_id_GradeBase == AttributeName[intIndex])
                {
                    mstrid_GradeBase = value.ToString();
                    AddUpdatedFld(con_id_GradeBase);
                }
                else if (con_GradeBaseID == AttributeName[intIndex])
                {
                    mstrGradeBaseID = value.ToString();
                    AddUpdatedFld(con_GradeBaseID);
                }
                else if (con_GradeBaseName == AttributeName[intIndex])
                {
                    mstrGradeBaseName = value.ToString();
                    AddUpdatedFld(con_GradeBaseName);
                }
                else if (con_SchoolYear == AttributeName[intIndex])
                {
                    mstrSchoolYear = value.ToString();
                    AddUpdatedFld(con_SchoolYear);
                }
                else if (con_SchoolTerm == AttributeName[intIndex])
                {
                    mstrSchoolTerm = value.ToString();
                    AddUpdatedFld(con_SchoolTerm);
                }
                else if (con_EnterSchoolDate == AttributeName[intIndex])
                {
                    mstrEnterSchoolDate = value.ToString();
                    AddUpdatedFld(con_EnterSchoolDate);
                }
                else if (con_CurrentTermSeq == AttributeName[intIndex])
                {
                    mintCurrentTermSeq = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_CurrentTermSeq);
                }
                else if (con_ExecPlanTermIndex == AttributeName[intIndex])
                {
                    mintExecPlanTermIndex = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_ExecPlanTermIndex);
                }
                else if (con_SetEPTermIndexDate == AttributeName[intIndex])
                {
                    mstrSetEPTermIndexDate = value.ToString();
                    AddUpdatedFld(con_SetEPTermIndexDate);
                }
                else if (con_IsOffed == AttributeName[intIndex])
                {
                    mbolIsOffed = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsOffed);
                }
                else if (con_ModifyDate == AttributeName[intIndex])
                {
                    mstrModifyDate = value.ToString();
                    AddUpdatedFld(con_ModifyDate);
                }
                else if (con_ModifyUserID == AttributeName[intIndex])
                {
                    mstrModifyUserID = value.ToString();
                    AddUpdatedFld(con_ModifyUserID);
                }
                else if (con_GradeIndex == AttributeName[intIndex])
                {
                    mintGradeIndex = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_GradeIndex);
                }
                else if (con_BeginYearMonth == AttributeName[intIndex])
                {
                    mstrBeginYearMonth = value.ToString();
                    AddUpdatedFld(con_BeginYearMonth);
                }
                else if (con_EndYearMonth == AttributeName[intIndex])
                {
                    mstrEndYearMonth = value.ToString();
                    AddUpdatedFld(con_EndYearMonth);
                }
                else if (con_AllowUpBaseInfo == AttributeName[intIndex])
                {
                    mbolAllowUpBaseInfo = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_AllowUpBaseInfo);
                }
            }
        }

        /// <summary>
        /// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
        /// </summary>
        public string id_GradeBase
        {
            get
            {
                return mstrid_GradeBase;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrid_GradeBase = value;
                }
                else
                {
                    mstrid_GradeBase = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_id_GradeBase);
            }
        }
        /// <summary>
        /// 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
        /// </summary>
        public string GradeBaseID
        {
            get
            {
                return mstrGradeBaseID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrGradeBaseID = value;
                }
                else
                {
                    mstrGradeBaseID = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_GradeBaseID);
            }
        }
        /// <summary>
        /// 年级名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
        /// </summary>
        public string GradeBaseName
        {
            get
            {
                return mstrGradeBaseName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrGradeBaseName = value;
                }
                else
                {
                    mstrGradeBaseName = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_GradeBaseName);
            }
        }
        /// <summary>
        /// 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
        /// </summary>
        public string SchoolYear
        {
            get
            {
                return mstrSchoolYear;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSchoolYear = value;
                }
                else
                {
                    mstrSchoolYear = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_SchoolYear);
            }
        }
        /// <summary>
        /// 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
        /// </summary>
        public string SchoolTerm
        {
            get
            {
                return mstrSchoolTerm;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSchoolTerm = value;
                }
                else
                {
                    mstrSchoolTerm = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_SchoolTerm);
            }
        }
        /// <summary>
        /// 进校日期(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// </summary>
        public string EnterSchoolDate
        {
            get
            {
                return mstrEnterSchoolDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrEnterSchoolDate = value;
                }
                else
                {
                    mstrEnterSchoolDate = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_EnterSchoolDate);
            }
        }
        /// <summary>
        /// 当前学期(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int CurrentTermSeq
        {
            get
            {
                return mintCurrentTermSeq;
            }
            set
            {
                mintCurrentTermSeq = value;
                //记录修改过的字段
                AddUpdatedFld(con_CurrentTermSeq);
            }
        }
        /// <summary>
        /// 生成执行计划学期(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// </summary>
        public int ExecPlanTermIndex
        {
            get
            {
                return mintExecPlanTermIndex;
            }
            set
            {
                mintExecPlanTermIndex = value;
                //记录修改过的字段
                AddUpdatedFld(con_ExecPlanTermIndex);
            }
        }
        /// <summary>
        /// 设定执行计划学期日期(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// </summary>
        public string SetEPTermIndexDate
        {
            get
            {
                return mstrSetEPTermIndexDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSetEPTermIndexDate = value;
                }
                else
                {
                    mstrSetEPTermIndexDate = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_SetEPTermIndexDate);
            }
        }
        /// <summary>
        /// 是否毕业(说明:;字段类型:bit;字段长度:1;是否可空:True)
        /// </summary>
        public bool IsOffed
        {
            get
            {
                return mbolIsOffed;
            }
            set
            {
                mbolIsOffed = value;
                //记录修改过的字段
                AddUpdatedFld(con_IsOffed);
            }
        }
        /// <summary>
        /// 修改日期(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// </summary>
        public string ModifyDate
        {
            get
            {
                return mstrModifyDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrModifyDate = value;
                }
                else
                {
                    mstrModifyDate = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_ModifyDate);
            }
        }
        /// <summary>
        /// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
        /// </summary>
        public string ModifyUserID
        {
            get
            {
                return mstrModifyUserID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrModifyUserID = value;
                }
                else
                {
                    mstrModifyUserID = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_ModifyUserID);
            }
        }
        /// <summary>
        /// 年级序号(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// </summary>
        public int GradeIndex
        {
            get
            {
                return mintGradeIndex;
            }
            set
            {
                mintGradeIndex = value;
                //记录修改过的字段
                AddUpdatedFld(con_GradeIndex);
            }
        }
        /// <summary>
        /// 开始年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
        /// </summary>
        public string BeginYearMonth
        {
            get
            {
                return mstrBeginYearMonth;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrBeginYearMonth = value;
                }
                else
                {
                    mstrBeginYearMonth = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_BeginYearMonth);
            }
        }
        /// <summary>
        /// 结束年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
        /// </summary>
        public string EndYearMonth
        {
            get
            {
                return mstrEndYearMonth;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrEndYearMonth = value;
                }
                else
                {
                    mstrEndYearMonth = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_EndYearMonth);
            }
        }
        /// <summary>
        /// 允许修改基本信息(说明:;字段类型:bit;字段长度:1;是否可空:True)
        /// </summary>
        public bool AllowUpBaseInfo
        {
            get
            {
                return mbolAllowUpBaseInfo;
            }
            set
            {
                mbolAllowUpBaseInfo = value;
                //记录修改过的字段
                AddUpdatedFld(con_AllowUpBaseInfo);
            }
        }
        /// <summary>
        /// 是否检查属性(说明:;字段类型:bool;字段长度:1;是否可空:False)
        /// </summary>
        public bool IsCheckProperty
        {
            get
            {
                return mbolIsCheckProperty;
            }
            set
            {
                mbolIsCheckProperty = value;
                //记录修改过的字段
                AddUpdatedFld(con_IsCheckProperty);
            }
        }
    }
}