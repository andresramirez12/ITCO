﻿using System;
using System.Collections.Generic;
using System.Text;
using SAPbouiCOM.Framework;
using ITCO.TransferCost.Main;

namespace ITCO.TransferCost.UI
{
    public class Menu
    {
        public void AddMenuItems()
        {
            try
            {
                SAPbouiCOM.Menus oMenus = null;
                SAPbouiCOM.MenuItem oMenuItem = null;

                oMenus = Application.SBO_Application.Menus;

                SAPbouiCOM.MenuCreationParams oCreationPackage = null;
                oCreationPackage = ((SAPbouiCOM.MenuCreationParams)(Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)));
                oMenuItem = Application.SBO_Application.Menus.Item("43520"); // moudles'

                oMenuItem = Application.SBO_Application.Menus.Item("43540"); 
                oMenus = oMenuItem.SubMenus;
                oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                oCreationPackage.UniqueID = "frm_TransferItems";
                oCreationPackage.String = "Transfer Items";
                if (oMenus.Exists("frm_TransferItems"))
                    oMenus.RemoveEx("frm_TransferItems");
                oMenus.AddEx(oCreationPackage);

                oMenuItem = Application.SBO_Application.Menus.Item("11520"); // moudles'
                oMenus = oMenuItem.SubMenus;
                oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                oCreationPackage.UniqueID = "frm_TransferSetup";
                oCreationPackage.String = "Transfer Items Setup";
                if (oMenus.Exists("frm_TransferSetup"))
                    oMenus.RemoveEx("frm_TransferSetup");
                oMenus.AddEx(oCreationPackage);
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage("Menu Already Exists", SAPbouiCOM.BoMessageTime.bmt_Short, true);
            }
        }

        private void AddMenu()
        {
            SAPbouiCOM.MenuItem oMenuItem = null;
            SAPbouiCOM.Menus oMenus = null;

            try
            {
                //  CREATE MENU POPUP MYUSERMENU01 AND ADD IT TO TOOLS MENU
                SAPbouiCOM.MenuCreationParams oCreationPackage = null;
                oCreationPackage = ((SAPbouiCOM.MenuCreationParams)(Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)));

                oMenuItem = Application.SBO_Application.Menus.Item("1280"); // Data'

                if (!oMenuItem.SubMenus.Exists("DeleteLine"))
                {
                    oMenus = oMenuItem.SubMenus;
                    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                    oCreationPackage.UniqueID = "DeleteLine";
                    oCreationPackage.String = "Delete Line";
                    oCreationPackage.Enabled = false;
                    oMenus.AddEx(oCreationPackage);
                }

            }
            catch (Exception ex)
            {

            }

        } 

    }
}
