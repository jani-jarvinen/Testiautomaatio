﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAndLoadTestProject1
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;


    public class WebTest1Coded : WebTest
    {

        public WebTest1Coded()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            // Initialize validation rules that apply to all requests in the WebTest
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidateResponseUrl validationRule1 = new ValidateResponseUrl();
                this.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule1.Validate);
            }
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidationRuleResponseTimeGoal validationRule2 = new ValidationRuleResponseTimeGoal();
                validationRule2.Tolerance = 0D;
                this.ValidateResponseOnPageComplete += new EventHandler<ValidationEventArgs>(validationRule2.Validate);
            }

            WebTestRequest request1 = new WebTestRequest("http://localhost:2440/");
            yield return request1;
            request1 = null;

            WebTestRequest request2 = new WebTestRequest("http://localhost:2440/");
            request2.Headers.Add(new WebTestRequestHeader("Referer", "http://localhost:2440/"));
            yield return request2;
            request2 = null;

            WebTestRequest request3 = new WebTestRequest("http://localhost:2440/Home/About");
            request3.Headers.Add(new WebTestRequestHeader("Referer", "http://localhost:2440/"));
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest("http://localhost:2440/Home/Contact");
            request4.Headers.Add(new WebTestRequestHeader("Referer", "http://localhost:2440/Home/About"));
            yield return request4;
            request4 = null;

            WebTestRequest request5 = new WebTestRequest("http://localhost:2440/");
            request5.Headers.Add(new WebTestRequestHeader("Referer", "http://localhost:2440/Home/Contact"));
            yield return request5;
            request5 = null;

            WebTestRequest request6 = new WebTestRequest("http://localhost:2440/");
            request6.Method = "POST";
            request6.Headers.Add(new WebTestRequestHeader("Referer", "http://localhost:2440/"));
            FormPostHttpBody request6Body = new FormPostHttpBody();
            request6Body.FormPostParameters.Add("pvm", "abc");
            request6.Body = request6Body;
            yield return request6;
            request6 = null;
        }
    }
}
