using System;
using System.Security.Cryptography;
using System.Text;


namespace webapi.Helpers
{
    public class SignatureVerifier
    {
       
        public static bool VerifySignature(string payload, string signatureHeader)
        {
            var generatedSignature = GenerateSignature(payload);

            return generatedSignature == signatureHeader;
        }

        public static string GenerateSignature(string dataToHash)
        {
              String app_key = "r/uei2KPB6wmkt2ynTDVCkTjEBHavVoBw64O7dIWEByzWH93t+A+oSI3dDYED9g6qZPA1Gh7Poy+1j69BgZB/w==";
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(app_key)))
            {
                var messageBytes = Encoding.UTF8.GetBytes(dataToHash);
                var hash = hmac.ComputeHash(messageBytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
