﻿using System.Data.Objects;
using System.Management.Automation;

namespace Cognifide.PowerShell.PowerShellIntegrations.Commandlets.Analytics
{
    [Cmdlet("Get", "AnalyticsBrowser")]
    public class GetAnalyticsBrowserCommand : AnalyticsBaseCommand
    {
        protected override void ProcessRecord()
        {
            ObjectQuery<Browsers> browsers = Context.Browsers;

            PipeQuery(browsers);
        }
    }
}