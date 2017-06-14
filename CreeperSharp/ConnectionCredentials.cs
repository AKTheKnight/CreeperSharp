using System;

namespace CreeperSharp
{
    public class ConnectionCredentials
    {

        public string Key { get; private set; }

        public string Secret { get; }

        public void SetKey(string value)
        {
            Key = ValidateCredential(value);
        }

        public void SetSecret(string value)
        {
            Key = ValidateCredential(value);
        }

        public ConnectionCredentials(string key, string secret)
        {
            this.Key = ValidateCredential(key);
            this.Secret = ValidateCredential(secret);
        }

        private static string ValidateCredential(string credential)
        {
            if (string.IsNullOrEmpty(credential))
                throw new ArgumentException("Credential values cannot be null or empty");

            return credential;
        } 
        
    }
}
