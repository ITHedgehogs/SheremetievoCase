namespace SheremetievoRent.Client.Helpers
{
    public static class CustomClaims
    {
        internal const string ClaimTypeNamespace = "http://schemas.microsoft.com/ws/2008/06/identity/claims";
        public const string INN = ClaimTypeNamespace + "/inn";
        public const string Deals = ClaimTypeNamespace + "/basedeals";
    }
}