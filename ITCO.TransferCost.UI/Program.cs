﻿using System;
using System.Collections.Generic;
using SAPbouiCOM.Framework;
using ITCO.TransferCost.Main;

namespace ITCO.TransferCost.UI
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {                
                Application oApp = null;
                if (args.Length < 1)
                    oApp = new Application();
                else
                    oApp = new Application(args[0]);
                AddonInfoInfo.InstallUDOs();
                Menu MyMenu = new Menu();
                AddonInfoInfo.SetFormFilter();
                MyMenu.AddMenuItems();
                var bListeners = new ApplicationHandlers();
                Application.SBO_Application.StatusBar.SetSystemMessage("Items Transfer Add-on installed successfully.", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success);
                oApp.Run();
            }
            catch (Exception ex)
            {
                Utilities.LogException(ex);
            }
            
        }
    }
}
