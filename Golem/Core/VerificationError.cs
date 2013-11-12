﻿using System.Drawing;
using ProtoTest.Golem.WebDriver;

namespace ProtoTest.Golem.Core
{
    public class VerificationError
    {
        public string errorText;
        public Image screenshot;

        public VerificationError(string errorText)
        {
            this.errorText = errorText;
            screenshot = WebDriverTestBase.driver.GetScreenshot();
        }

        public VerificationError(string errorText, Image screenshot)
        {
            this.errorText = errorText;
            this.screenshot = screenshot;
        }
    }
}