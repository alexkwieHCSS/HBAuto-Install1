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
    ///The RestoreEstimate recording.
    /// </summary>
    [TestModule("e34b67dc-64ab-4eb2-b3d4-2c0d3e0dd094", ModuleType.Recording, 1)]
    public partial class RestoreEstimate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static RestoreEstimate instance = new RestoreEstimate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RestoreEstimate()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RestoreEstimate Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.FileTab' at Center.", repo.HeavyBidApp.Tabs.FileTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.FileTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.File.RestoreEstimateButton' at Center.", repo.HeavyBidApp.Buttons.File.RestoreEstimateButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.File.RestoreEstimateButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBDropDownOptions.Estimate' at Center.", repo.HBDropDownOptions.EstimateInfo, new RecordItemIndex(2));
            repo.HBDropDownOptions.Estimate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimates.NextButton' at Center.", repo.HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimates.NextButtonInfo, new RecordItemIndex(3));
            repo.HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimates.NextButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimates.EllipsisButton' at Center.", repo.HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimates.EllipsisButtonInfo, new RecordItemIndex(4));
            repo.HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimates.EllipsisButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.GridViewOfEstimatesPopup.ListOfEstimatesPopup.OKButton' at Center.", repo.HBPopUpScreens.GridViewOfEstimatesPopup.ListOfEstimatesPopup.OKButtonInfo, new RecordItemIndex(5));
            repo.HBPopUpScreens.GridViewOfEstimatesPopup.ListOfEstimatesPopup.OKButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimates.FinishButton' at Center.", repo.HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimates.FinishButtonInfo, new RecordItemIndex(6));
            repo.HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimates.FinishButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimatesPopup.OKButton' at Center.", repo.HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimatesPopup.OKButtonInfo, new RecordItemIndex(7));
            repo.HBPopUpScreens.FromFileButtons.RestoreEstimateRelated.RestoreEstimatesPopup.OKButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
