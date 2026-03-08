///----------------------
///生成代码版本：2011.05.08.1
///生成日期：2011/05/25
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
using System;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;

namespace GeneralPlatform.Entity
{
    /// <summary>
    /// Person_Q(Person_Q)
    /// </summary>
    [Serializable]
    public class clsPersonEN : clsEntityBase2
    {
        public const string CurrTabName_S = "Person_Q"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "ACCOUNT"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 39;
        public static string[] AttributeName = new string[] { "ACCOUNT", "SCH_ID", "BANK_ACC", "CARD_NO", "TEMP_CARD_NO", "TEMP_USING", "TEMP_DEPOSIT", "Password", "MONEY", "CARD_KIND", "CARD_STATE", "LAST_TIME", "USEFUL_LIMIT", "RECYCLE_LIMIT", "NAME", "Sex", "IDEN_NO", "NATION_NO", "POLITICS", "Duty", "BIRTH", "PERSON_ID", "STUDENT_ID", "SCHOOL_NO", "ACADEMY_NO", "DEP_NO", "CLASS_NO", "IN_TIME", "WALLANCE", "ADDRESS", "Phone", "POST_NO", "POST_ADDRESS", "MAIL", "DESCR", "USER_ID", "OP_DATE", "ANNEX", "Grade" };
        //以下是属性变量


        /// <summary> 
        /// 明卡号
        /// </summary>
        protected string mstrACCOUNT;

        /// <summary> 
        /// 学校统一编号
        /// </summary>
        protected string mstrSCH_ID;

        /// <summary> 
        /// 银行帐号
        /// </summary>
        protected string mstrBANK_ACC;

        /// <summary> 
        /// 卡号
        /// </summary>
        protected string mstrCARD_NO;

        /// <summary> 
        /// 临时卡卡号
        /// </summary>
        protected string mstrTEMP_CARD_NO;

        /// <summary> 
        /// 临时卡使用标志
        /// </summary>
        protected double mdblTEMP_USING;

        /// <summary> 
        /// 临时卡押金
        /// </summary>
        protected double mdblTEMP_DEPOSIT;

        /// <summary> 
        /// 口令
        /// </summary>
        protected string mstrPassword;

        /// <summary> 
        /// 余额
        /// </summary>
        protected double mdblMONEY;

        /// <summary> 
        /// 卡种类
        /// </summary>
        protected double mdblCARD_KIND;

        /// <summary> 
        /// 卡状态
        /// </summary>
        protected double mdblCARD_STATE;

        /// <summary> 
        /// 最近使用时间
        /// </summary>
        protected DateTime mdteLAST_TIME;

        /// <summary> 
        /// 有效期
        /// </summary>
        protected DateTime mdteUSEFUL_LIMIT;

        /// <summary> 
        /// 退役期
        /// </summary>
        protected DateTime mdteRECYCLE_LIMIT;

        /// <summary> 
        /// 姓名
        /// </summary>
        protected string mstrNAME;

        /// <summary> 
        /// 性别
        /// </summary>
        protected string mstrSex;

        /// <summary> 
        /// 身份标识
        /// </summary>
        protected double mdblIDEN_NO;

        /// <summary> 
        /// 民族
        /// </summary>
        protected double mdblNATION_NO;

        /// <summary> 
        /// 政治面貌
        /// </summary>
        protected string mstrPOLITICS;

        /// <summary> 
        /// 职务
        /// </summary>
        protected string mstrDuty;

        /// <summary> 
        /// 出生年月
        /// </summary>
        protected DateTime mdteBIRTH;

        /// <summary> 
        /// 身份证号
        /// </summary>
        protected string mstrPERSON_ID;

        /// <summary> 
        /// 学生证号
        /// </summary>
        protected string mstrSTUDENT_ID;

        /// <summary> 
        /// 学校编号
        /// </summary>
        protected string mstrSCHOOL_NO;

        /// <summary> 
        /// 学院编号
        /// </summary>
        protected string mstrACADEMY_NO;

        /// <summary> 
        /// 系别编号
        /// </summary>
        protected string mstrDEP_NO;

        /// <summary> 
        /// 班级编号
        /// </summary>
        protected string mstrCLASS_NO;

        /// <summary> 
        /// 入学年月
        /// </summary>
        protected DateTime mdteIN_TIME;

        /// <summary> 
        /// 补贴金额
        /// </summary>
        protected double mdblWALLANCE;

        /// <summary> 
        /// 住址
        /// </summary>
        protected string mstrADDRESS;

        /// <summary> 
        /// 电话
        /// </summary>
        protected string mstrPhone;

        /// <summary> 
        /// 邮政编码
        /// </summary>
        protected string mstrPOST_NO;

        /// <summary> 
        /// 通信地址
        /// </summary>
        protected string mstrPOST_ADDRESS;

        /// <summary> 
        /// 电子邮件
        /// </summary>
        protected string mstrMAIL;

        /// <summary> 
        /// 描述
        /// </summary>
        protected string mstrDESCR;

        /// <summary> 
        /// 操作员代码
        /// </summary>
        protected string mstrUSER_ID;

        /// <summary> 
        /// 操作日期
        /// </summary>
        protected DateTime mdteOP_DATE;

        /// <summary> 
        /// 备注
        /// </summary>
        protected string mstrANNEX;

        /// <summary> 
        /// 年级
        /// </summary>
        protected string mstrGrade;

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsPersonEN()
        {
            SetInit();
            _CurrTabName = "Person_Q";
            lstKeyFldNames.Add("ACCOUNT");
        }

        public clsPersonEN(string strACCOUNT)
        {

            mstrACCOUNT = strACCOUNT;
            SetInit();
            _CurrTabName = "Person_Q";
            lstKeyFldNames.Add("ACCOUNT");
        }

        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        public override object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "ACCOUNT")
                {
                    return mstrACCOUNT;
                }
                else if (strAttributeName == "SCH_ID")
                {
                    return mstrSCH_ID;
                }
                else if (strAttributeName == "BANK_ACC")
                {
                    return mstrBANK_ACC;
                }
                else if (strAttributeName == "CARD_NO")
                {
                    return mstrCARD_NO;
                }
                else if (strAttributeName == "TEMP_CARD_NO")
                {
                    return mstrTEMP_CARD_NO;
                }
                else if (strAttributeName == "TEMP_USING")
                {
                    return mdblTEMP_USING;
                }
                else if (strAttributeName == "TEMP_DEPOSIT")
                {
                    return mdblTEMP_DEPOSIT;
                }
                else if (strAttributeName == "Password")
                {
                    return mstrPassword;
                }
                else if (strAttributeName == "MONEY")
                {
                    return mdblMONEY;
                }
                else if (strAttributeName == "CARD_KIND")
                {
                    return mdblCARD_KIND;
                }
                else if (strAttributeName == "CARD_STATE")
                {
                    return mdblCARD_STATE;
                }
                else if (strAttributeName == "LAST_TIME")
                {
                    return mdteLAST_TIME;
                }
                else if (strAttributeName == "USEFUL_LIMIT")
                {
                    return mdteUSEFUL_LIMIT;
                }
                else if (strAttributeName == "RECYCLE_LIMIT")
                {
                    return mdteRECYCLE_LIMIT;
                }
                else if (strAttributeName == "NAME")
                {
                    return mstrNAME;
                }
                else if (strAttributeName == "Sex")
                {
                    return mstrSex;
                }
                else if (strAttributeName == "IDEN_NO")
                {
                    return mdblIDEN_NO;
                }
                else if (strAttributeName == "NATION_NO")
                {
                    return mdblNATION_NO;
                }
                else if (strAttributeName == "POLITICS")
                {
                    return mstrPOLITICS;
                }
                else if (strAttributeName == "Duty")
                {
                    return mstrDuty;
                }
                else if (strAttributeName == "BIRTH")
                {
                    return mdteBIRTH;
                }
                else if (strAttributeName == "PERSON_ID")
                {
                    return mstrPERSON_ID;
                }
                else if (strAttributeName == "STUDENT_ID")
                {
                    return mstrSTUDENT_ID;
                }
                else if (strAttributeName == "SCHOOL_NO")
                {
                    return mstrSCHOOL_NO;
                }
                else if (strAttributeName == "ACADEMY_NO")
                {
                    return mstrACADEMY_NO;
                }
                else if (strAttributeName == "DEP_NO")
                {
                    return mstrDEP_NO;
                }
                else if (strAttributeName == "CLASS_NO")
                {
                    return mstrCLASS_NO;
                }
                else if (strAttributeName == "IN_TIME")
                {
                    return mdteIN_TIME;
                }
                else if (strAttributeName == "WALLANCE")
                {
                    return mdblWALLANCE;
                }
                else if (strAttributeName == "ADDRESS")
                {
                    return mstrADDRESS;
                }
                else if (strAttributeName == "Phone")
                {
                    return mstrPhone;
                }
                else if (strAttributeName == "POST_NO")
                {
                    return mstrPOST_NO;
                }
                else if (strAttributeName == "POST_ADDRESS")
                {
                    return mstrPOST_ADDRESS;
                }
                else if (strAttributeName == "MAIL")
                {
                    return mstrMAIL;
                }
                else if (strAttributeName == "DESCR")
                {
                    return mstrDESCR;
                }
                else if (strAttributeName == "USER_ID")
                {
                    return mstrUSER_ID;
                }
                else if (strAttributeName == "OP_DATE")
                {
                    return mdteOP_DATE;
                }
                else if (strAttributeName == "ANNEX")
                {
                    return mstrANNEX;
                }
                else if (strAttributeName == "Grade")
                {
                    return mstrGrade;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "ACCOUNT")
                {
                    mstrACCOUNT = value.ToString();
                }
                else if (strAttributeName == "SCH_ID")
                {
                    mstrSCH_ID = value.ToString();
                }
                else if (strAttributeName == "BANK_ACC")
                {
                    mstrBANK_ACC = value.ToString();
                }
                else if (strAttributeName == "CARD_NO")
                {
                    mstrCARD_NO = value.ToString();
                }
                else if (strAttributeName == "TEMP_CARD_NO")
                {
                    mstrTEMP_CARD_NO = value.ToString();
                }
                else if (strAttributeName == "TEMP_USING")
                {
                    mdblTEMP_USING = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "TEMP_DEPOSIT")
                {
                    mdblTEMP_DEPOSIT = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "Password")
                {
                    mstrPassword = value.ToString();
                }
                else if (strAttributeName == "MONEY")
                {
                    mdblMONEY = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "CARD_KIND")
                {
                    mdblCARD_KIND = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "CARD_STATE")
                {
                    mdblCARD_STATE = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "LAST_TIME")
                {
                    mdteLAST_TIME = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "USEFUL_LIMIT")
                {
                    mdteUSEFUL_LIMIT = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "RECYCLE_LIMIT")
                {
                    mdteRECYCLE_LIMIT = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "NAME")
                {
                    mstrNAME = value.ToString();
                }
                else if (strAttributeName == "Sex")
                {
                    mstrSex = value.ToString();
                }
                else if (strAttributeName == "IDEN_NO")
                {
                    mdblIDEN_NO = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "NATION_NO")
                {
                    mdblNATION_NO = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "POLITICS")
                {
                    mstrPOLITICS = value.ToString();
                }
                else if (strAttributeName == "Duty")
                {
                    mstrDuty = value.ToString();
                }
                else if (strAttributeName == "BIRTH")
                {
                    mdteBIRTH = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "PERSON_ID")
                {
                    mstrPERSON_ID = value.ToString();
                }
                else if (strAttributeName == "STUDENT_ID")
                {
                    mstrSTUDENT_ID = value.ToString();
                }
                else if (strAttributeName == "SCHOOL_NO")
                {
                    mstrSCHOOL_NO = value.ToString();
                }
                else if (strAttributeName == "ACADEMY_NO")
                {
                    mstrACADEMY_NO = value.ToString();
                }
                else if (strAttributeName == "DEP_NO")
                {
                    mstrDEP_NO = value.ToString();
                }
                else if (strAttributeName == "CLASS_NO")
                {
                    mstrCLASS_NO = value.ToString();
                }
                else if (strAttributeName == "IN_TIME")
                {
                    mdteIN_TIME = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "WALLANCE")
                {
                    mdblWALLANCE = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "ADDRESS")
                {
                    mstrADDRESS = value.ToString();
                }
                else if (strAttributeName == "Phone")
                {
                    mstrPhone = value.ToString();
                }
                else if (strAttributeName == "POST_NO")
                {
                    mstrPOST_NO = value.ToString();
                }
                else if (strAttributeName == "POST_ADDRESS")
                {
                    mstrPOST_ADDRESS = value.ToString();
                }
                else if (strAttributeName == "MAIL")
                {
                    mstrMAIL = value.ToString();
                }
                else if (strAttributeName == "DESCR")
                {
                    mstrDESCR = value.ToString();
                }
                else if (strAttributeName == "USER_ID")
                {
                    mstrUSER_ID = value.ToString();
                }
                else if (strAttributeName == "OP_DATE")
                {
                    mdteOP_DATE = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "ANNEX")
                {
                    mstrANNEX = value.ToString();
                }
                else if (strAttributeName == "Grade")
                {
                    mstrGrade = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("ACCOUNT" == AttributeName[intIndex])
                {
                    return mstrACCOUNT;
                }
                else if ("SCH_ID" == AttributeName[intIndex])
                {
                    return mstrSCH_ID;
                }
                else if ("BANK_ACC" == AttributeName[intIndex])
                {
                    return mstrBANK_ACC;
                }
                else if ("CARD_NO" == AttributeName[intIndex])
                {
                    return mstrCARD_NO;
                }
                else if ("TEMP_CARD_NO" == AttributeName[intIndex])
                {
                    return mstrTEMP_CARD_NO;
                }
                else if ("TEMP_USING" == AttributeName[intIndex])
                {
                    return mdblTEMP_USING;
                }
                else if ("TEMP_DEPOSIT" == AttributeName[intIndex])
                {
                    return mdblTEMP_DEPOSIT;
                }
                else if ("Password" == AttributeName[intIndex])
                {
                    return mstrPassword;
                }
                else if ("MONEY" == AttributeName[intIndex])
                {
                    return mdblMONEY;
                }
                else if ("CARD_KIND" == AttributeName[intIndex])
                {
                    return mdblCARD_KIND;
                }
                else if ("CARD_STATE" == AttributeName[intIndex])
                {
                    return mdblCARD_STATE;
                }
                else if ("LAST_TIME" == AttributeName[intIndex])
                {
                    return mdteLAST_TIME;
                }
                else if ("USEFUL_LIMIT" == AttributeName[intIndex])
                {
                    return mdteUSEFUL_LIMIT;
                }
                else if ("RECYCLE_LIMIT" == AttributeName[intIndex])
                {
                    return mdteRECYCLE_LIMIT;
                }
                else if ("NAME" == AttributeName[intIndex])
                {
                    return mstrNAME;
                }
                else if ("Sex" == AttributeName[intIndex])
                {
                    return mstrSex;
                }
                else if ("IDEN_NO" == AttributeName[intIndex])
                {
                    return mdblIDEN_NO;
                }
                else if ("NATION_NO" == AttributeName[intIndex])
                {
                    return mdblNATION_NO;
                }
                else if ("POLITICS" == AttributeName[intIndex])
                {
                    return mstrPOLITICS;
                }
                else if ("Duty" == AttributeName[intIndex])
                {
                    return mstrDuty;
                }
                else if ("BIRTH" == AttributeName[intIndex])
                {
                    return mdteBIRTH;
                }
                else if ("PERSON_ID" == AttributeName[intIndex])
                {
                    return mstrPERSON_ID;
                }
                else if ("STUDENT_ID" == AttributeName[intIndex])
                {
                    return mstrSTUDENT_ID;
                }
                else if ("SCHOOL_NO" == AttributeName[intIndex])
                {
                    return mstrSCHOOL_NO;
                }
                else if ("ACADEMY_NO" == AttributeName[intIndex])
                {
                    return mstrACADEMY_NO;
                }
                else if ("DEP_NO" == AttributeName[intIndex])
                {
                    return mstrDEP_NO;
                }
                else if ("CLASS_NO" == AttributeName[intIndex])
                {
                    return mstrCLASS_NO;
                }
                else if ("IN_TIME" == AttributeName[intIndex])
                {
                    return mdteIN_TIME;
                }
                else if ("WALLANCE" == AttributeName[intIndex])
                {
                    return mdblWALLANCE;
                }
                else if ("ADDRESS" == AttributeName[intIndex])
                {
                    return mstrADDRESS;
                }
                else if ("Phone" == AttributeName[intIndex])
                {
                    return mstrPhone;
                }
                else if ("POST_NO" == AttributeName[intIndex])
                {
                    return mstrPOST_NO;
                }
                else if ("POST_ADDRESS" == AttributeName[intIndex])
                {
                    return mstrPOST_ADDRESS;
                }
                else if ("MAIL" == AttributeName[intIndex])
                {
                    return mstrMAIL;
                }
                else if ("DESCR" == AttributeName[intIndex])
                {
                    return mstrDESCR;
                }
                else if ("USER_ID" == AttributeName[intIndex])
                {
                    return mstrUSER_ID;
                }
                else if ("OP_DATE" == AttributeName[intIndex])
                {
                    return mdteOP_DATE;
                }
                else if ("ANNEX" == AttributeName[intIndex])
                {
                    return mstrANNEX;
                }
                else if ("Grade" == AttributeName[intIndex])
                {
                    return mstrGrade;
                }
                return null;
            }
            set
            {
                if ("ACCOUNT" == AttributeName[intIndex])
                {
                    mstrACCOUNT = value.ToString();
                }
                else if ("SCH_ID" == AttributeName[intIndex])
                {
                    mstrSCH_ID = value.ToString();
                }
                else if ("BANK_ACC" == AttributeName[intIndex])
                {
                    mstrBANK_ACC = value.ToString();
                }
                else if ("CARD_NO" == AttributeName[intIndex])
                {
                    mstrCARD_NO = value.ToString();
                }
                else if ("TEMP_CARD_NO" == AttributeName[intIndex])
                {
                    mstrTEMP_CARD_NO = value.ToString();
                }
                else if ("TEMP_USING" == AttributeName[intIndex])
                {
                    mdblTEMP_USING = TransNullToDouble(value.ToString());
                }
                else if ("TEMP_DEPOSIT" == AttributeName[intIndex])
                {
                    mdblTEMP_DEPOSIT = TransNullToDouble(value.ToString());
                }
                else if ("Password" == AttributeName[intIndex])
                {
                    mstrPassword = value.ToString();
                }
                else if ("MONEY" == AttributeName[intIndex])
                {
                    mdblMONEY = TransNullToDouble(value.ToString());
                }
                else if ("CARD_KIND" == AttributeName[intIndex])
                {
                    mdblCARD_KIND = TransNullToDouble(value.ToString());
                }
                else if ("CARD_STATE" == AttributeName[intIndex])
                {
                    mdblCARD_STATE = TransNullToDouble(value.ToString());
                }
                else if ("LAST_TIME" == AttributeName[intIndex])
                {
                    mdteLAST_TIME = TransNullToDate(value.ToString());
                }
                else if ("USEFUL_LIMIT" == AttributeName[intIndex])
                {
                    mdteUSEFUL_LIMIT = TransNullToDate(value.ToString());
                }
                else if ("RECYCLE_LIMIT" == AttributeName[intIndex])
                {
                    mdteRECYCLE_LIMIT = TransNullToDate(value.ToString());
                }
                else if ("NAME" == AttributeName[intIndex])
                {
                    mstrNAME = value.ToString();
                }
                else if ("Sex" == AttributeName[intIndex])
                {
                    mstrSex = value.ToString();
                }
                else if ("IDEN_NO" == AttributeName[intIndex])
                {
                    mdblIDEN_NO = TransNullToDouble(value.ToString());
                }
                else if ("NATION_NO" == AttributeName[intIndex])
                {
                    mdblNATION_NO = TransNullToDouble(value.ToString());
                }
                else if ("POLITICS" == AttributeName[intIndex])
                {
                    mstrPOLITICS = value.ToString();
                }
                else if ("Duty" == AttributeName[intIndex])
                {
                    mstrDuty = value.ToString();
                }
                else if ("BIRTH" == AttributeName[intIndex])
                {
                    mdteBIRTH = TransNullToDate(value.ToString());
                }
                else if ("PERSON_ID" == AttributeName[intIndex])
                {
                    mstrPERSON_ID = value.ToString();
                }
                else if ("STUDENT_ID" == AttributeName[intIndex])
                {
                    mstrSTUDENT_ID = value.ToString();
                }
                else if ("SCHOOL_NO" == AttributeName[intIndex])
                {
                    mstrSCHOOL_NO = value.ToString();
                }
                else if ("ACADEMY_NO" == AttributeName[intIndex])
                {
                    mstrACADEMY_NO = value.ToString();
                }
                else if ("DEP_NO" == AttributeName[intIndex])
                {
                    mstrDEP_NO = value.ToString();
                }
                else if ("CLASS_NO" == AttributeName[intIndex])
                {
                    mstrCLASS_NO = value.ToString();
                }
                else if ("IN_TIME" == AttributeName[intIndex])
                {
                    mdteIN_TIME = TransNullToDate(value.ToString());
                }
                else if ("WALLANCE" == AttributeName[intIndex])
                {
                    mdblWALLANCE = TransNullToDouble(value.ToString());
                }
                else if ("ADDRESS" == AttributeName[intIndex])
                {
                    mstrADDRESS = value.ToString();
                }
                else if ("Phone" == AttributeName[intIndex])
                {
                    mstrPhone = value.ToString();
                }
                else if ("POST_NO" == AttributeName[intIndex])
                {
                    mstrPOST_NO = value.ToString();
                }
                else if ("POST_ADDRESS" == AttributeName[intIndex])
                {
                    mstrPOST_ADDRESS = value.ToString();
                }
                else if ("MAIL" == AttributeName[intIndex])
                {
                    mstrMAIL = value.ToString();
                }
                else if ("DESCR" == AttributeName[intIndex])
                {
                    mstrDESCR = value.ToString();
                }
                else if ("USER_ID" == AttributeName[intIndex])
                {
                    mstrUSER_ID = value.ToString();
                }
                else if ("OP_DATE" == AttributeName[intIndex])
                {
                    mdteOP_DATE = TransNullToDate(value.ToString());
                }
                else if ("ANNEX" == AttributeName[intIndex])
                {
                    mstrANNEX = value.ToString();
                }
                else if ("Grade" == AttributeName[intIndex])
                {
                    mstrGrade = value.ToString();
                }
            }
        }

        /// <summary>
        /// 明卡号
        /// </summary>
        public string ACCOUNT
        {
            get
            {
                return mstrACCOUNT;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrACCOUNT = value;
                }
                else
                {
                    mstrACCOUNT = value;
                }
                //记录修改过的字段
                AddUpdatedFld("ACCOUNT");
            }
        }
        /// <summary>
        /// 学校统一编号
        /// </summary>
        public string SCH_ID
        {
            get
            {
                return mstrSCH_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSCH_ID = value;
                }
                else
                {
                    mstrSCH_ID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("SCH_ID");
            }
        }
        /// <summary>
        /// 银行帐号
        /// </summary>
        public string BANK_ACC
        {
            get
            {
                return mstrBANK_ACC;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrBANK_ACC = value;
                }
                else
                {
                    mstrBANK_ACC = value;
                }
                //记录修改过的字段
                AddUpdatedFld("BANK_ACC");
            }
        }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CARD_NO
        {
            get
            {
                return mstrCARD_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCARD_NO = value;
                }
                else
                {
                    mstrCARD_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("CARD_NO");
            }
        }
        /// <summary>
        /// 临时卡卡号
        /// </summary>
        public string TEMP_CARD_NO
        {
            get
            {
                return mstrTEMP_CARD_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTEMP_CARD_NO = value;
                }
                else
                {
                    mstrTEMP_CARD_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("TEMP_CARD_NO");
            }
        }
        /// <summary>
        /// 临时卡使用标志
        /// </summary>
        public double TEMP_USING
        {
            get
            {
                return mdblTEMP_USING;
            }
            set
            {
                mdblTEMP_USING = value;
                //记录修改过的字段
                AddUpdatedFld("TEMP_USING");
            }
        }
        /// <summary>
        /// 临时卡押金
        /// </summary>
        public double TEMP_DEPOSIT
        {
            get
            {
                return mdblTEMP_DEPOSIT;
            }
            set
            {
                mdblTEMP_DEPOSIT = value;
                //记录修改过的字段
                AddUpdatedFld("TEMP_DEPOSIT");
            }
        }
        /// <summary>
        /// 口令
        /// </summary>
        public string Password
        {
            get
            {
                return mstrPassword;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPassword = value;
                }
                else
                {
                    mstrPassword = value;
                }
                //记录修改过的字段
                AddUpdatedFld("Password");
            }
        }
        /// <summary>
        /// 余额
        /// </summary>
        public double MONEY
        {
            get
            {
                return mdblMONEY;
            }
            set
            {
                mdblMONEY = value;
                //记录修改过的字段
                AddUpdatedFld("MONEY");
            }
        }
        /// <summary>
        /// 卡种类
        /// </summary>
        public double CARD_KIND
        {
            get
            {
                return mdblCARD_KIND;
            }
            set
            {
                mdblCARD_KIND = value;
                //记录修改过的字段
                AddUpdatedFld("CARD_KIND");
            }
        }
        /// <summary>
        /// 卡状态
        /// </summary>
        public double CARD_STATE
        {
            get
            {
                return mdblCARD_STATE;
            }
            set
            {
                mdblCARD_STATE = value;
                //记录修改过的字段
                AddUpdatedFld("CARD_STATE");
            }
        }
        /// <summary>
        /// 最近使用时间
        /// </summary>
        public DateTime LAST_TIME
        {
            get
            {
                return mdteLAST_TIME;
            }
            set
            {
                mdteLAST_TIME = value;
                //记录修改过的字段
                AddUpdatedFld("LAST_TIME");
            }
        }
        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime USEFUL_LIMIT
        {
            get
            {
                return mdteUSEFUL_LIMIT;
            }
            set
            {
                mdteUSEFUL_LIMIT = value;
                //记录修改过的字段
                AddUpdatedFld("USEFUL_LIMIT");
            }
        }
        /// <summary>
        /// 退役期
        /// </summary>
        public DateTime RECYCLE_LIMIT
        {
            get
            {
                return mdteRECYCLE_LIMIT;
            }
            set
            {
                mdteRECYCLE_LIMIT = value;
                //记录修改过的字段
                AddUpdatedFld("RECYCLE_LIMIT");
            }
        }
        /// <summary>
        /// 姓名
        /// </summary>
        public string NAME
        {
            get
            {
                return mstrNAME;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrNAME = value;
                }
                else
                {
                    mstrNAME = value;
                }
                //记录修改过的字段
                AddUpdatedFld("NAME");
            }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get
            {
                return mstrSex;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSex = value;
                }
                else
                {
                    mstrSex = value;
                }
                //记录修改过的字段
                AddUpdatedFld("Sex");
            }
        }
        /// <summary>
        /// 身份标识
        /// </summary>
        public double IDEN_NO
        {
            get
            {
                return mdblIDEN_NO;
            }
            set
            {
                mdblIDEN_NO = value;
                //记录修改过的字段
                AddUpdatedFld("IDEN_NO");
            }
        }
        /// <summary>
        /// 民族
        /// </summary>
        public double NATION_NO
        {
            get
            {
                return mdblNATION_NO;
            }
            set
            {
                mdblNATION_NO = value;
                //记录修改过的字段
                AddUpdatedFld("NATION_NO");
            }
        }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string POLITICS
        {
            get
            {
                return mstrPOLITICS;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPOLITICS = value;
                }
                else
                {
                    mstrPOLITICS = value;
                }
                //记录修改过的字段
                AddUpdatedFld("POLITICS");
            }
        }
        /// <summary>
        /// 职务
        /// </summary>
        public string Duty
        {
            get
            {
                return mstrDuty;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDuty = value;
                }
                else
                {
                    mstrDuty = value;
                }
                //记录修改过的字段
                AddUpdatedFld("Duty");
            }
        }
        /// <summary>
        /// 出生年月
        /// </summary>
        public DateTime BIRTH
        {
            get
            {
                return mdteBIRTH;
            }
            set
            {
                mdteBIRTH = value;
                //记录修改过的字段
                AddUpdatedFld("BIRTH");
            }
        }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string PERSON_ID
        {
            get
            {
                return mstrPERSON_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPERSON_ID = value;
                }
                else
                {
                    mstrPERSON_ID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PERSON_ID");
            }
        }
        /// <summary>
        /// 学生证号
        /// </summary>
        public string STUDENT_ID
        {
            get
            {
                return mstrSTUDENT_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSTUDENT_ID = value;
                }
                else
                {
                    mstrSTUDENT_ID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("STUDENT_ID");
            }
        }
        /// <summary>
        /// 学校编号
        /// </summary>
        public string SCHOOL_NO
        {
            get
            {
                return mstrSCHOOL_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSCHOOL_NO = value;
                }
                else
                {
                    mstrSCHOOL_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("SCHOOL_NO");
            }
        }
        /// <summary>
        /// 学院编号
        /// </summary>
        public string ACADEMY_NO
        {
            get
            {
                return mstrACADEMY_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrACADEMY_NO = value;
                }
                else
                {
                    mstrACADEMY_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("ACADEMY_NO");
            }
        }
        /// <summary>
        /// 系别编号
        /// </summary>
        public string DEP_NO
        {
            get
            {
                return mstrDEP_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDEP_NO = value;
                }
                else
                {
                    mstrDEP_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("DEP_NO");
            }
        }
        /// <summary>
        /// 班级编号
        /// </summary>
        public string CLASS_NO
        {
            get
            {
                return mstrCLASS_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCLASS_NO = value;
                }
                else
                {
                    mstrCLASS_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("CLASS_NO");
            }
        }
        /// <summary>
        /// 入学年月
        /// </summary>
        public DateTime IN_TIME
        {
            get
            {
                return mdteIN_TIME;
            }
            set
            {
                mdteIN_TIME = value;
                //记录修改过的字段
                AddUpdatedFld("IN_TIME");
            }
        }
        /// <summary>
        /// 补贴金额
        /// </summary>
        public double WALLANCE
        {
            get
            {
                return mdblWALLANCE;
            }
            set
            {
                mdblWALLANCE = value;
                //记录修改过的字段
                AddUpdatedFld("WALLANCE");
            }
        }
        /// <summary>
        /// 住址
        /// </summary>
        public string ADDRESS
        {
            get
            {
                return mstrADDRESS;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrADDRESS = value;
                }
                else
                {
                    mstrADDRESS = value;
                }
                //记录修改过的字段
                AddUpdatedFld("ADDRESS");
            }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone
        {
            get
            {
                return mstrPhone;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPhone = value;
                }
                else
                {
                    mstrPhone = value;
                }
                //记录修改过的字段
                AddUpdatedFld("Phone");
            }
        }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string POST_NO
        {
            get
            {
                return mstrPOST_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPOST_NO = value;
                }
                else
                {
                    mstrPOST_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("POST_NO");
            }
        }
        /// <summary>
        /// 通信地址
        /// </summary>
        public string POST_ADDRESS
        {
            get
            {
                return mstrPOST_ADDRESS;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPOST_ADDRESS = value;
                }
                else
                {
                    mstrPOST_ADDRESS = value;
                }
                //记录修改过的字段
                AddUpdatedFld("POST_ADDRESS");
            }
        }
        /// <summary>
        /// 电子邮件
        /// </summary>
        public string MAIL
        {
            get
            {
                return mstrMAIL;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrMAIL = value;
                }
                else
                {
                    mstrMAIL = value;
                }
                //记录修改过的字段
                AddUpdatedFld("MAIL");
            }
        }
        /// <summary>
        /// 描述
        /// </summary>
        public string DESCR
        {
            get
            {
                return mstrDESCR;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDESCR = value;
                }
                else
                {
                    mstrDESCR = value;
                }
                //记录修改过的字段
                AddUpdatedFld("DESCR");
            }
        }
        /// <summary>
        /// 操作员代码
        /// </summary>
        public string USER_ID
        {
            get
            {
                return mstrUSER_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUSER_ID = value;
                }
                else
                {
                    mstrUSER_ID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("USER_ID");
            }
        }
        /// <summary>
        /// 操作日期
        /// </summary>
        public DateTime OP_DATE
        {
            get
            {
                return mdteOP_DATE;
            }
            set
            {
                mdteOP_DATE = value;
                //记录修改过的字段
                AddUpdatedFld("OP_DATE");
            }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string ANNEX
        {
            get
            {
                return mstrANNEX;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrANNEX = value;
                }
                else
                {
                    mstrANNEX = value;
                }
                //记录修改过的字段
                AddUpdatedFld("ANNEX");
            }
        }
        /// <summary>
        /// 年级
        /// </summary>
        public string Grade
        {
            get
            {
                return mstrGrade;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrGrade = value;
                }
                else
                {
                    mstrGrade = value;
                }
                //记录修改过的字段
                AddUpdatedFld("Grade");
            }
        }
    }
}