using System;

namespace StarterKit
{
    public class OAuthSettings
    {
        public string PublicToken
        {
            get;
            set;
        }

        public string SecretToken
        {
            get;
            set;
        }

        public string Scopes
        {
            get;
            set;
        }

        public string AuthorizeUrl
        {
            get;
            set;
        }

        public string RedirectUrl
        {
            get;
            set;
        }
    }
}