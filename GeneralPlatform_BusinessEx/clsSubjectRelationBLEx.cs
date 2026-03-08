using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using GeneralPlatform.DAL;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.BusinessLogicEx
{
    public class clsSubjectRelationBLEx : clsSubjectRelationBL
    {
        public static List<string> GetUserIdLstByLeader(string strLeaderId)
        {
            List<string> arrUserIdLst = clsSubjectRelationDAEx.GetUserIdLstByLeader(strLeaderId);
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
            //检测记录是否存在
            bool bolIsUniqueness = clsSubjectRelationDAEx.CheckUniqueness(lngmId, strUserId, strLeaderId);
            return bolIsUniqueness;

        }

        /// <summary>
        /// 检查唯一性（Uniqueness）
        /// </summary>
        /// <param name="strUserId">用户ID（要求唯一的字段）</param>
        /// <param name="strLeaderId">领导Id（要求唯一的字段）</param>
        /// <returns></returns>
        public static bool CheckUniqueness(string strUserId, string strLeaderId)
        {
            //检测记录是否存在
            bool bolIsUniqueness = clsSubjectRelationDAEx.CheckUniqueness(strUserId, strLeaderId);
            return bolIsUniqueness;
        }

        /// <summary>
        /// 检查唯一性（Uniqueness）
        /// </summary>
        /// <param name="strUserId">用户ID（要求唯一的字段）</param>
        /// <param name="strLeaderId">领导Id（要求唯一的字段）</param>
        /// <returns></returns>
        public static bool CheckUniqueness(clsSubjectRelationEN objSubjectRelation)
        {
            //检测记录是否存在
            bool bolIsUniqueness;
            if (objSubjectRelation == null) return true;
            if (objSubjectRelation.mId == 0)
            {
                bolIsUniqueness = clsSubjectRelationDAEx.CheckUniqueness(
                    objSubjectRelation.UserId, objSubjectRelation.LeaderId);
            }
            else
            {
                bolIsUniqueness = clsSubjectRelationDAEx.CheckUniqueness(
                    objSubjectRelation.mId, objSubjectRelation.UserId, objSubjectRelation.LeaderId);
            }
            return bolIsUniqueness;
        }
    }
}
