using Microsoft.AspNetCore.Components.WebAssembly.Http;

namespace HubAuth.Client
{
    public class IncludeRequestCredentialsMessageHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);
            return base.SendAsync(request, cancellationToken);
        }
    }
}
