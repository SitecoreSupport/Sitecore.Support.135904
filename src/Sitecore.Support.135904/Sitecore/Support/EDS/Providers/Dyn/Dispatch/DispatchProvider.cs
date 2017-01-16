namespace Sitecore.Support.EDS.Providers.Dyn.Dispatch
{
    using Sitecore.EDS.Core.Dispatch;
    using Sitecore.EDS.Core.Reporting;
    using Sitecore.EDS.Providers.Dyn.Dispatch;
    using System;

    public class DispatchProvider : Sitecore.EDS.Providers.Dyn.Dispatch.DispatchProvider
    {
        public DispatchProvider(ConnectionPoolManager poolManager, IEnvironmentId environmentIdentifier) : base(poolManager, environmentIdentifier)
        {
        }

        protected override void SetMessageHeaders(EmailMessage message)
        {
            message.Headers.Set("Reply-To", message.ReplyTo);
        }
    }
}
