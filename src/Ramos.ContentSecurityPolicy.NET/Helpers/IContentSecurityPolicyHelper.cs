namespace Ramos.ContentSecurityPolicy.NET.Helpers
{
    internal interface IContentSecurityPolicyHelper
    {
        ContentSecurityPolicyHeader GetContentSecurityPolicy(string nonce);
    }
}
