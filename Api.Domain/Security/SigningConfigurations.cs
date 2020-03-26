using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;

namespace Api.Domain.Security
{
    public class SigningConfigurations
    {
        // The property Key, is an instance of the class SecurityKey (namespace Microsoft.IdentityModel.Tokens) 
        // and will get the crypted key used in the tokens creation
        public SecurityKey Key { get; }

        // Receive an object based on class SigningCredentials, this reference will get the crypto key and the
        // security algorithm, used in digital signatures for Tokens
        public SigningCredentials SigningCredentials { get; }


        // The constructor it will initialize the properties Key and SigningCredentials, 
        // using types RSACryptoServiceProvider
        public SigningConfigurations()
        {
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                Key = new RsaSecurityKey(provider.ExportParameters(true));
            }

            SigningCredentials = new SigningCredentials( Key, SecurityAlgorithms.RsaSha256Signature);
        }
    }
}
