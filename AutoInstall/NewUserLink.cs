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
    ///The NewUserLink recording.
    /// </summary>
    [TestModule("4a8614c1-5018-4048-b323-4ace8f176b90", ModuleType.Recording, 1)]
    public partial class NewUserLink : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static NewUserLink instance = new NewUserLink();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NewUserLink()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NewUserLink Instance
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

            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.LinkNewUserWelcomeScreen'.", repo.HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.LinkNewUserWelcomeScreenInfo, new RecordItemIndex(0));
                Validate.Exists(repo.HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.LinkNewUserWelcomeScreenInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.LinkNewUserWelcomeScreen' at Center.", repo.HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.LinkNewUserWelcomeScreenInfo, new RecordItemIndex(1));
            repo.HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.LinkNewUserWelcomeScreen.Click();
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Text' to contain the specified value 'hcss.com'. Associated repository item: 'GoogleChrome.AddressBar'", repo.GoogleChrome.AddressBarInfo, new RecordItemIndex(2));
            //repo.GoogleChrome.AddressBarInfo.WaitForAttributeContains(5000, "Text", "hcss.com");
            
            // E.6
            //Report.Log(ReportLevel.Info, "Validation", "E.6\r\nValidating AttributeContains (Text>'help.hcss.com') on item 'GoogleChrome.AddressBar'.", repo.GoogleChrome.AddressBarInfo, new RecordItemIndex(3));
            //Validate.AttributeContains(repo.GoogleChrome.AddressBarInfo, "Text", "help.hcss.com");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Title' to contain the specified value '(Article List|HCSS)'. Associated repository item: 'GoogleChrome.Tab'", repo.GoogleChrome.TabInfo, new RecordItemIndex(4));
            //repo.GoogleChrome.TabInfo.WaitForAttributeContains(5000, "Title", "(Article List|HCSS)");
            
            // E.6
            //Report.Log(ReportLevel.Info, "Validation", "E.6\r\nValidating AttributeRegex (Title~'(Article List|HCSS)') on item 'GoogleChrome.Tab'.", repo.GoogleChrome.TabInfo, new RecordItemIndex(5));
            //Validate.AttributeRegex(repo.GoogleChrome.TabInfo, "Title", new Regex("(Article List|HCSS)"));
            //Delay.Milliseconds(0);
            
            // E.6
            //Report.Log(ReportLevel.Info, "Application", "E.6\r\nClosing application containing item 'GoogleChrome'.", repo.GoogleChrome.SelfInfo, new RecordItemIndex(6));
            //Host.Current.CloseApplication(repo.GoogleChrome.Self, 10000);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}