using System;
using System.Text;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using com.taishsoft.common;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// clsGeneMenu 的摘要说明。
    /// </summary>
    public class clsGeneMenuBLEx
    {
        public static string GetUserMenuHTML2(string strCurrPrjId, string strMenuSetId, string strCurrUserRoleId,
            string strUserId)
        {


            //System.Data.DataTable objDTUpMenu = null, objDTSubMenu = null;
            //List<clsvRoleMenusEN> arrUpMenu = null, arrSubMenu = null;
            //操作步骤：
            //1、从SESSION取出当前的用户ID(在每个界面上添加一个用户ID的属性，免除每次都必须操作SESSION)。
            //2、从用户表得出当前用户的角色ID。	
            //3、从Web.Config取出当前的工程ID			
            //4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            //   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            //       并且按OrderNum排序；
            //   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            //   获取的表作为DATATABLE(objDT)返回。					
            //5、根据获取的用户菜单列表，组织成HTML菜单串。						
            //6、把菜单HTML菜单串显示到界面上。						
            //7、结束。

            List<string> arrRoleId = clsArray.GetListByString(strCurrUserRoleId.Split(','));
            List<string> arrList = new List<string>();
            //clsPrjMenusBLEx objPrjMenuEx = new clsPrjMenusBLEx();
            StringBuilder strCondition = new StringBuilder();
            StringBuilder strHtml = new StringBuilder();		//需要插入的HTML代码
            StringBuilder strMenuSubItem = new StringBuilder();
            //int intMainMenuRow;
            //bool bolIsUseRoleMenu;		//判断当前用户是否用角色菜单。

            //操作步骤CODE实现：

            //4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            //   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            //       并且按OrderNum排序；
            //   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            //   获取的表作为DATATABLE(objDT)返回。	
            //   

            //string strTemp = "true";


            IEnumerable<clsvQxRoleMenusEN> arrPrjUpMenu = null;
            IEnumerable<clsvQxRoleMenusEN>  arrPrjSubMenu = null;


            //获取顶层菜单

            IEnumerable<clsvQxRoleMenusEN> arrPrjUpMenu4Role = clsvQxRoleMenusBLEx.GetUpMenuObjListByRoleIds(arrRoleId, strCurrPrjId, strMenuSetId);
            ///获取子菜单
            IEnumerable<clsvQxRoleMenusEN> arrPrjSubMenu4Role = clsvQxRoleMenusBLEx.GetSubMenuObjListByRoleIds(arrRoleId,
                strCurrPrjId, strMenuSetId);

            //获取顶层菜单
            arrPrjUpMenu = clsvQxRoleMenusBLEx.GetUpMenuObjListByRoleIds(arrRoleId, strCurrPrjId, strMenuSetId);
            //获取子菜单
            arrPrjSubMenu = clsvQxRoleMenusBLEx.GetSubMenuObjListByRoleIds(arrRoleId, strCurrPrjId, strMenuSetId);

            //strCondition = new StringBuilder();
            //    strCondition.AppendFormat("RoleId = '{0}'", strCurrUserRoleId);
            //    strCondition.AppendFormat(" and PrjId = '{0}'", strCurrPrjId);
            //    strCondition.Append(" AND UpMenuId = '00000000'");
            //    strCondition.Append(" order by OrderNum");
            //    arrUpMenu = clsvRoleMenusBL.GetvRoleMenusObjList(strCondition.ToString());
            /////获取子菜单
            //strCondition = new StringBuilder();
            //strCondition.AppendFormat("RoleId = '{0}'", strCurrUserRoleId);
            //strCondition.AppendFormat(" and PrjId = '{0}'", strCurrPrjId);
            //strCondition.Append(" AND UpMenuId <> '00000000'");
            //strCondition.Append(" order by OrderNum");

            //arrSubMenu = clsQxRoleMenusWS.GetvRoleMenusObjList(strCondition.ToString());
            //}
            //else
            //{
            //    return "";
            //}
            ///5、根据获取的用户菜单列表，组织成HTML菜单串。						
            //intMainMenuRow = 101;
            //int MainRow = 0;
            strHtml.AppendFormat("\n<li class=\"menu-header menu-item\">主菜单</li>\n");
            List<string> arrUpMenuId = new List<string>();
            foreach (clsvQxRoleMenusEN objMainMenuRow in arrPrjUpMenu)
            {

                if (objMainMenuRow.InUse == false) continue;
                if (arrUpMenuId.Contains(objMainMenuRow.MenuId) == true) continue;
                arrUpMenuId.Add(objMainMenuRow.MenuId);
                strHtml.AppendFormat("\n<li class=\"menu-item\">\n");
                strHtml.AppendFormat("<a href=\"\"><i class=\"icon-font\"></i><span>{0}</span><i class=\"icon-font icon-right\"></i></a>\n", objMainMenuRow.MenuName);

                strHtml.AppendFormat("<ul  class=\"menu-item-child\" style=\"display: none\">\n");



                BindSubMenu(arrPrjSubMenu, objMainMenuRow.MenuId, ref strHtml);
                strHtml.Append("</ul>\n");

                strHtml.Append("</li>\n");



            }

            ///6、把菜单HTML菜单串显示到界面上。						
            return strHtml.ToString();
        }
        private static void BindSubMenu(IEnumerable<clsvQxRoleMenusEN> arrSubMenu, string strUpMenuId, ref StringBuilder strHtml)
        {
            int intSubMenuRow = 0;
            List<string> arrSubMenuId = new List<string>();
            foreach (clsvQxRoleMenusEN objSubMenuRow in arrSubMenu)
            {
                if (objSubMenuRow.InUse == false) continue;
                if (strUpMenuId != objSubMenuRow.UpMenuId) continue;
                if (arrSubMenuId.Contains(objSubMenuRow.MenuId) == true) continue;
                arrSubMenuId.Add(objSubMenuRow.MenuId);
                intSubMenuRow++;
                if (objSubMenuRow.IsLeafNode == true) //叶子结点
                {
                    strHtml.Append("<li>\n");
                    if (string.IsNullOrEmpty(objSubMenuRow.qsParameters) == false)
                    {
                        strHtml.AppendFormat("<a href=\"../{0}?{2}\"><i class=\"icon-font\"></i><span>{1}</span></a>\n",
                       objSubMenuRow.LinkFile, objSubMenuRow.MenuName,
                       objSubMenuRow.qsParameters);

                    }
                    else
                    {
                        strHtml.AppendFormat("<a href=\"../{0}\"><i class=\"icon-font\"></i><span>{1}</span></a>\n",
                          objSubMenuRow.LinkFile, objSubMenuRow.MenuName);
                    }
                    strHtml.Append("</li>\n");

                }
            }
        }

        public string GetQxUserMenuHTML(string strCurrPrjId, string strCurrUserRoleId, string strUserId)
        {

            System.Data.DataTable objDTUpMenu = null, objDTSubMenu = null;

            ///操作步骤：
            ///1、从SESSION取出当前的用户ID(在每个界面上添加一个用户ID的属性，免除每次都必须操作SESSION)。
            ///2、从用户表得出当前用户的角色ID。	
            ///3、从Web.Config取出当前的工程ID			
            ///4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            ///   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            ///       并且按OrderNum排序；
            ///   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            ///   获取的表作为DATATABLE(objDT)返回。					
            ///5、根据获取的用户菜单列表，组织成HTML菜单串。						
            ///6、把菜单HTML菜单串显示到界面上。						
            ///7、结束。


            List<string> arrList = new List<string>();
            clsQxPrjMenusBLEx objPrjMenuEx = new clsQxPrjMenusBLEx();
            StringBuilder strCondition = new StringBuilder();
            StringBuilder strHtml = new StringBuilder();		//需要插入的HTML代码
            StringBuilder strMenuSubItem = new StringBuilder();
            string strMenuId, strUpMenuId;
            int intMainMenuRow, intSubMenuRow;
            string strMainMenuName, strSubMenuName, strLinkFile, strMainImgFile, strSubImgFile;
            bool bolIsUseRoleMenu;		//判断当前用户是否用角色菜单。

            ///操作步骤CODE实现：

            ///4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            ///   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            ///       并且按OrderNum排序；
            ///   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            ///   获取的表作为DATATABLE(objDT)返回。	
            ///   

            string strTemp = "true";

            arrList = clsQxUserMenusBL.GetFldValue("IsUseRoleMenu", "UserId = '" + strUserId + "'");

            if (arrList.Count != 0)
            {
                strTemp = arrList[0].ToString();
            }

            bolIsUseRoleMenu = bool.Parse(strTemp);

            if (bolIsUseRoleMenu == true)		//如果使用角色菜单，即用户本身没有自定义菜单。
            {
                ///获取顶层菜单
                objDTUpMenu = clsQxRoleMenusBLEx.GetUpMenuTable(strCurrUserRoleId, strCurrPrjId);
                ///获取子菜单
                objDTSubMenu = clsQxRoleMenusBLEx.GetSubMenuTable(strCurrUserRoleId, strCurrPrjId);
            }
            else
            {
                return "";
            }
            ///5、根据获取的用户菜单列表，组织成HTML菜单串。						
            intMainMenuRow = 1;
            foreach (DataRow MainMenuRow in objDTUpMenu.Rows)
            {
                strMenuId = MainMenuRow["MenuId"].ToString();	//获取主菜单项ID
                strMainMenuName = MainMenuRow["MenuName"].ToString(); //获取主菜单项NAME
                strMainImgFile = MainMenuRow["ImgFile"].ToString();
                strHtml.Append("<DIV align=\"left\" class=\"mnuLevel_H23\">");
                strHtml.AppendFormat("<TABLE width='94%' border='0' cellPadding='0' cellSpacing='0' borderColor='#2953c0' ID='Table{0}' class=\"mnuLevel_H23\" >\n",
                    intMainMenuRow);
                strHtml.Append("<TBODY>\n");
                strHtml.Append("<TR>\n");
                strHtml.Append("<TD width='100%' align='left'>\n");
                strHtml.AppendFormat("<A title='单击展开！' onclick='showthis(\"menu{0}\");'>\n",
                    intMainMenuRow);
                strHtml.AppendFormat("&nbsp;<img src='{1}' width='12' height='12'>{0}\n",
                    strMainMenuName, strMainImgFile);
                strHtml.Append("</A>\n");
                strHtml.Append("</TD>\n");
                strHtml.Append("</TR>\n");
                strHtml.Append("</TBODY>\n");
                //				div1.Attributes.Add("class","mnuLevel_H23");
                strHtml.Append("</TABLE>\n");
                strHtml.Append("</DIV>");
                strHtml.AppendFormat("<table width=\"100%\" border=\"0\" id=\"menu{0}\" class=\"style2\" style=\"DISPLAY:none\">\n",
                    intMainMenuRow);
                intSubMenuRow = 1;
                foreach (DataRow SubMenuRow in objDTSubMenu.Rows)
                {
                    strUpMenuId = SubMenuRow["UpMenuId"].ToString();

                    if (strMenuId == strUpMenuId)
                    {
                        strSubMenuName = SubMenuRow["MenuName"].ToString(); //获取主菜单项NAME
                        strSubImgFile = SubMenuRow["ImgFile"].ToString();
                        strLinkFile = SubMenuRow["LinkFile"].ToString();

                        strHtml.Append("<tr>\n");
                        strHtml.Append("	<td align=\"left\">\n");
                        strHtml.AppendFormat("	&nbsp;&nbsp;<img src=\"{0}\" width=\"12\" height=\"12\" border=\"0\">\n",
                            strSubImgFile);
                        strHtml.AppendFormat("<A href=\"{0}\" target=\"mainform\">{1}</A>\n",
                            strLinkFile, strSubMenuName);
                        strHtml.Append("</td>\n");
                        strHtml.Append("</tr>\n");
                    }

                    intSubMenuRow++;
                }
                strHtml.Append("</table>\n");
                intMainMenuRow++;
            }

            ///6、把菜单HTML菜单串显示到界面上。						
            return strHtml.ToString();
        }

        public static string GetQxUserMenuHTML2(string strCurrPrjId, string strMenuSetId, string strCurrUserRoleId, string strUserId)
        {

            //System.Data.DataTable objDTUpMenu = null, objDTSubMenu = null;
            IEnumerable<clsvQxRoleMenusEN> arrUpMenu = null;
            IEnumerable<clsvQxRoleMenusEN> arrSubMenu = null;
            ///操作步骤：
            ///1、从SESSION取出当前的用户ID(在每个界面上添加一个用户ID的属性，免除每次都必须操作SESSION)。
            ///2、从用户表得出当前用户的角色ID。	
            ///3、从Web.Config取出当前的工程ID			
            ///4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            ///   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            ///       并且按OrderNum排序；
            ///   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            ///   获取的表作为DATATABLE(objDT)返回。					
            ///5、根据获取的用户菜单列表，组织成HTML菜单串。						
            ///6、把菜单HTML菜单串显示到界面上。						
            ///7、结束。


            List<string> arrList = new List<string>();
            clsQxPrjMenusBLEx objPrjMenuEx = new clsQxPrjMenusBLEx();
            StringBuilder strCondition = new StringBuilder();
            StringBuilder strHtml = new StringBuilder();		//需要插入的HTML代码
            StringBuilder strMenuSubItem = new StringBuilder();
            int intMainMenuRow;
            bool bolIsUseRoleMenu;		//判断当前用户是否用角色菜单。

            ///操作步骤CODE实现：

            ///4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            ///   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            ///       并且按OrderNum排序；
            ///   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            ///   获取的表作为DATATABLE(objDT)返回。	
            ///   

            string strTemp = "true";

            arrList = clsQxUserMenusBL.GetFldValue("IsUseRoleMenu", "UserId = '" + strUserId + "'");

            if (arrList.Count != 0)
            {
                strTemp = arrList[0].ToString();
            }

            bolIsUseRoleMenu = bool.Parse(strTemp);

            if (bolIsUseRoleMenu == true)		//如果使用角色菜单，即用户本身没有自定义菜单。
            {
                ///获取顶层菜单
                List<string> arrRoleId = clsArray.GetListByString(strCurrUserRoleId.Split(','));
              
                //strCondition = new StringBuilder();
                //strCondition.AppendFormat("RoleId = '{0}'", strCurrUserRoleId);
                //strCondition.AppendFormat(" and QxPrjId = '{0}'", strCurrPrjId);
                //strCondition.Append(" AND UpMenuId = '00000000'");
                //strCondition.Append(" order by OrderNum");
                //arrUpMenu = clsvQxRoleMenusBL.GetObjLst(strCondition.ToString());
                arrUpMenu = clsvQxRoleMenusBLEx.GetUpMenuObjListByRoleIds(arrRoleId, strCurrPrjId, strMenuSetId);
          
                /////获取子菜单
                //strCondition = new StringBuilder();
                //strCondition.AppendFormat("RoleId = '{0}'", strCurrUserRoleId);
                //strCondition.AppendFormat(" and QxPrjId = '{0}'", strCurrPrjId);
                //strCondition.Append(" AND UpMenuId <> '00000000'");
                //strCondition.Append(" order by OrderNum");

                //arrSubMenu = clsvQxRoleMenusBL.GetObjLst(strCondition.ToString());
                arrSubMenu = clsvQxRoleMenusBLEx.GetSubMenuObjListByRoleIds(arrRoleId,
                       strCurrPrjId, strMenuSetId);
            }
            else
            {
                return "";
            }
            ///5、根据获取的用户菜单列表，组织成HTML菜单串。						
            intMainMenuRow = 101;
            foreach (clsvQxRoleMenusEN objMainMenuRow in arrUpMenu)
            {
                if (objMainMenuRow.InUse == false) continue;
                strHtml.Append("<DIV align=\"left\" class=\"mnuLevel_H23\">");
                strHtml.AppendFormat("<TABLE width='94%' border='0' cellPadding='0' cellSpacing='0' borderColor='#2953c0' ID='Table{0}' class=\"mnuLevel_H23\" >\n",
                    intMainMenuRow);
                strHtml.Append("<TBODY>\n");
                strHtml.Append("<TR>\n");
                strHtml.Append("<TD width='100%' align='left'>\n");
                strHtml.AppendFormat("<A title='单击展开！' onclick='showthis(\"menu{0}\");'>\n",
                    intMainMenuRow);
                strHtml.AppendFormat("&nbsp;<img src='{1}' width='12' height='12'>{0}\n",
                    objMainMenuRow.MenuName, objMainMenuRow.ImgFile);
                strHtml.Append("</A>\n");
                strHtml.Append("</TD>\n");
                strHtml.Append("</TR>\n");
                strHtml.Append("</TBODY>\n");
                //				div1.Attributes.Add("class","mnuLevel_H23");
                strHtml.Append("</TABLE>\n");
                strHtml.Append("</DIV>");
                strHtml.AppendFormat("<table width=\"100%\" border=\"0\" id=\"menu{0}\" class=\"mnuLevel_Content\" style=\"DISPLAY:none\">\n",
                        intMainMenuRow);

                BindSubMenu(arrSubMenu, objMainMenuRow.MenuId, ref strHtml, intMainMenuRow);

                strHtml.Append("</table>\n");


                intMainMenuRow++;
            }

            ///6、把菜单HTML菜单串显示到界面上。						
            return strHtml.ToString();
        }
        private static void BindSubMenu(IEnumerable<clsvQxRoleMenusEN> arrSubMenu, string strUpMenuId, ref StringBuilder strHtml, int intMainMenuRow)
        {
            int intSubMenuRow = 0;
            foreach (clsvQxRoleMenusEN objSubMenuRow in arrSubMenu)
            {
                if (objSubMenuRow.InUse == false) continue;
                if (strUpMenuId != objSubMenuRow.UpMenuId) continue;
                intSubMenuRow++;
                if (objSubMenuRow.IsLeafNode == true) //叶子结点
                {
                    strHtml.Append("<tr>\n");
                    strHtml.Append("	<td align=\"left\">\n");
                    strHtml.AppendFormat("	&nbsp;&nbsp;<img src=\"{0}\" width=\"12\" height=\"12\" border=\"0\">\n",
                        objSubMenuRow.ImgFile);
                    if (string.IsNullOrEmpty(objSubMenuRow.qsParameters) == true)
                    {
                        strHtml.AppendFormat("<A href=\"{0}\" target=\"mainform\">{1}</A>\n",
                           objSubMenuRow.LinkFile, objSubMenuRow.MenuName);
                    }
                    else
                    {
                        strHtml.AppendFormat("<A href=\"{0}?{2}\" target=\"mainform\">{1}</A>\n",
                       objSubMenuRow.LinkFile, 
                       objSubMenuRow.MenuName,
                       objSubMenuRow.qsParameters);

                    }
                    strHtml.Append("</td>\n");
                    strHtml.Append("</tr>\n");
                }
                else//非叶子结点
                {
                    strHtml.Append("<tr>\n");
                    strHtml.Append("	<td align=\"left\">\n");
                    strHtml.AppendFormat("<a title='单击展开！' onclick='showthis(\"menu{0}{1}\");'>&nbsp;",
                        intMainMenuRow.ToString("00"), intSubMenuRow.ToString("00"));
                    strHtml.AppendFormat("	&nbsp;&nbsp;<img src=\"{0}\" width=\"12\" height=\"12\" border=\"0\">\n",
                        objSubMenuRow.ImgFile);
                    strHtml.AppendFormat("{0}</A>\n",
                       objSubMenuRow.MenuName);
                    strHtml.Append("</td>\n");
                    strHtml.Append("</tr>\n");

                    strHtml.Append("<tr>");
                    strHtml.Append("<td align=\"left\">");
                    strHtml.AppendFormat("<table width=\"100%\" border=\"0\" id=\"menu{0}{1}\" class=\"mnuLevel_Content\" style=\"DISPLAY:none\">\n",
                intMainMenuRow.ToString("00"), intSubMenuRow.ToString("00"));

                    int intLeafMenuRow = 0;
                    foreach (clsvQxRoleMenusEN objLeafMenuRow in arrSubMenu)
                    {
                        if (objLeafMenuRow.UpMenuId != objSubMenuRow.MenuId) continue;
                        if (objLeafMenuRow.IsLeafNode == false) continue; //叶子结点

                        intLeafMenuRow++;

                        strHtml.Append("<tr>\n");
                        strHtml.Append("	<td align=\"left\">\n");
                        strHtml.AppendFormat("&nbsp;&nbsp;	&nbsp;&nbsp;<img src=\"{0}\" width=\"12\" height=\"12\" border=\"0\">\n",
                            objLeafMenuRow.ImgFile);
                        if (string.IsNullOrEmpty(objLeafMenuRow.qsParameters) == true)
                        {
                            strHtml.AppendFormat("<A href=\"{0}\" target=\"mainform\">{1}</A>\n",
                               objLeafMenuRow.LinkFile, objLeafMenuRow.MenuName);
                        }
                        else
                        {
                            strHtml.AppendFormat("<A href=\"{0}?{2}\" target=\"mainform\">{1}</A>\n",
                           objLeafMenuRow.LinkFile, 
                           objLeafMenuRow.MenuName,
                           objLeafMenuRow.qsParameters);

                        }
                        strHtml.Append("</td>\n");
                        strHtml.Append("</tr>\n");

                    } // foreach (clsvQxRoleMenusEN objLeafMenuRow in arrSubMenu)
                    strHtml.Append("</table>\n");
                    strHtml.Append("</td>");
                    strHtml.Append("</tr>");

                }//非叶子结点
            } //foreach (clsvQxRoleMenusEN objSubMenuRow in arrSubMenu)
        }
    }
}



