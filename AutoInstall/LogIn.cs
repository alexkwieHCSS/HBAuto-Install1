﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace AutoInstall
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LogIn recording.
    /// </summary>
    [TestModule("dbe4b720-03e7-4547-9e2b-1b80426b7c5c", ModuleType.Recording, 1)]
    public partial class LogIn : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static LogIn instance = new LogIn();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LogIn()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LogIn Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'HBPopUpScreens.LogInHB.UserLogin.UserNumberEntry'", repo.HBPopUpScreens.LogInHB.UserLogin.UserNumberEntryInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.HBPopUpScreens.LogInHB.UserLogin.UserNumberEntryInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'HBPopUpScreens.LogInHB.UserLogin.UserNumberEntry'.", repo.HBPopUpScreens.LogInHB.UserLogin.UserNumberEntryInfo, new RecordItemIndex(1));
            repo.HBPopUpScreens.LogInHB.UserLogin.UserNumberEntry.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'HBPopUpScreens.LogInHB.UserLogin.UserNumberEntry' at Center.", repo.HBPopUpScreens.LogInHB.UserLogin.UserNumberEntryInfo, new RecordItemIndex(2));
            repo.HBPopUpScreens.LogInHB.UserLogin.UserNumberEntry.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '13' with focus on 'HBPopUpScreens.LogInHB.UserLogin.UserNumberEntry'.", repo.HBPopUpScreens.LogInHB.UserLogin.UserNumberEntryInfo, new RecordItemIndex(3));
            repo.HBPopUpScreens.LogInHB.UserLogin.UserNumberEntry.PressKeys("13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.LogInHB.UserLogin.ButtonOK' at Center.", repo.HBPopUpScreens.LogInHB.UserLogin.ButtonOKInfo, new RecordItemIndex(4));
            repo.HBPopUpScreens.LogInHB.UserLogin.ButtonOK.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
