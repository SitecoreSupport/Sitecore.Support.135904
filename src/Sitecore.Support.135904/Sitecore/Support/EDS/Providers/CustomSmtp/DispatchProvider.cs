namespace Sitecore.Support.EDS.Providers.CustomSmtp
{
    using Sitecore.EDS.Core.Dispatch;
    using Sitecore.EDS.Core.Net.Smtp;
    using Sitecore.EDS.Core.Reporting;
    using Sitecore.EDS.Providers.CustomSmtp;
    using System;

    public class DispatchProvider : Sitecore.EDS.Providers.CustomSmtp.DispatchProvider
    {
        public DispatchProvider(IChilkatConnectionPool connectionPool, IEnvironmentId environmentIdentifier) : base(connectionPool, environmentIdentifier)
        {
        }

        protected override void SetMessageHeaders(EmailMessage message)
        {
            message.Headers.Set("Reply-To", message.ReplyTo);
        }
    }
}
