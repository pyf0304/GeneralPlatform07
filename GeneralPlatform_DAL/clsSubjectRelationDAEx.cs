using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;

namespace GeneralPlatform.DAL
{
    /// <summary>
    /// 隶属关系数据处理层扩展
    /// </summary>
    public class clsSubjectRelationDAEx : clsSubjectRelationDA
    {
        /// <summary>
        /// 根据领导（Leader）获取所管理的职工
        /// </summary>
        /// <param name="strLeaderId">领导ID</param>
        /// <returns>职工ID列表</returns>
        public static List<string>  GetUserIdLstByLeader(string strLeaderId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("LeaderId = '{0}'", strLeaderId);

            List<string>  arrUserIdLst = GetFldValue("SubjectRelation", "UserId", sbCondition.ToString());
            return arrUserIdLst;
        }

        /// <summary>
        /// 检查唯一性（Uniqueness）
        /// </summary>
        /// <param name="lngmId">流水号（主键）</param>
        /// <param name="strUserId">用户ID（要求唯一的字段）</param>
        /// <param name="strLeaderId">领导Id（要求唯一的字段）</param>
        /// <returns></returns>
        public static bool CheckUniqueness(long lngmId, string strUserId, string strLeaderId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("mId != '{0}' and UserId = '{1}' and LeaderId = '{2}'", lngmId, strUserId, strLeaderId);
            if (new clsSubjectRelationDA().IsExistCondRec(sbCondition.ToString()) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 检查唯一性（Uniqueness）
        /// </summary>
        /// <param name="strUserId">用户ID（要求唯一的字段）</param>
        /// <param name="strLeaderId">领导Id（要求唯一的字段）</param>
        /// <returns></returns>
        public static bool CheckUniqueness(string strUserId, string strLeaderId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId = '{0}' and LeaderId = '{1}'", strUserId, strLeaderId);
            if (new clsSubjectRelationDA().IsExistCondRec(sbCondition.ToString()) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
