using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cryptool
{
    class GenerateSelfSigned
    {
        private int _keySize = 2048;
        private bool _isCA = false;
        private bool isEnchancedKeySrvClientAuth = false;

        //
        private RSA createRSA(int keySize)
        {
            if (keySize != null | keySize != 0)
            {
                _keySize = keySize;
            }
            RSA rsaParameter = RSA.Create(_keySize);
            return rsaParameter;
        }

        // Hash Algorithm for certifacate
        private HashAlgorithmName choiceHashAlgorithm(string hashAlg)
        {
            HashAlgorithmName algorithm;

            switch (hashAlg)
            {
                case "MD5":
                    algorithm = HashAlgorithmName.MD5;
                    break;
                case "SHA1":
                    algorithm = HashAlgorithmName.SHA1;
                    break;
                case "SHA256":
                    algorithm = HashAlgorithmName.SHA256;
                    break;
                case "SHA384":
                    algorithm = HashAlgorithmName.SHA384;
                    break;
                case "SHA512":
                    algorithm = HashAlgorithmName.SHA512;
                    break;
            }
            return algorithm;
        }

        // pass the list of selection as a list string and return KeyUsageflags
        private X509KeyUsageFlags keyUsageSelection(List<string> keyUsages)
        {

            var keyUsageFlags = X509KeyUsageFlags.KeyCertSign;

            foreach (string usage in keyUsages) {
                switch (usage)
                {
                    case "crlsign":
                        keyUsageFlags |=  X509KeyUsageFlags.CrlSign;
                        break;
                    case "DigitalSignature":
                        keyUsageFlags |= X509KeyUsageFlags.DigitalSignature;
                        break;
                    case "DataEncipher":
                        keyUsageFlags |= X509KeyUsageFlags.DataEncipherment;
                        break;
                    case "keyEncipher":
                        keyUsageFlags |= X509KeyUsageFlags.KeyEncipherment;
                        break;
                    case "certSigner":
                        keyUsageFlags |= X509KeyUsageFlags.KeyCertSign;
                        break;
                    case "serverClientAuth":
                        isEnchancedKeySrvClientAuth = true;
                        break;

                }
            }
            return keyUsageFlags;

        }
            
           



        public X509Certificate2 CreateCertificate(int keySize, string subjectDN, string hashAlg, List<string> keyUsages, int pathLenght, int numberofYears, bool isCA)
        {
            // Create a Key Pair
            var certificateKey = createRSA(keySize);
            // Add DN 
            var _subjectDN = new X500DistinguishedName(subjectDN);
            // Hashing Algorithm
            var algorithm = choiceHashAlgorithm(hashAlg);
            // create instance of certificate request
            var request = new CertificateRequest(_subjectDN, certificateKey, algorithm, RSASignaturePadding.Pkcs1);
            
            
            // Load Key Usage selection to keyUsageFlags 
            X509KeyUsageFlags keyUsageFlags = keyUsageSelection(keyUsages);
            request.CertificateExtensions.Add(new X509KeyUsageExtension(keyUsageFlags, true));

           
            //is CA: true for CA certificate
            //basic constrain : Path length Constrain default 1
            //pathContrain : enable and length 
            //Extension critical: true
            request.CertificateExtensions.Add(new X509BasicConstraintsExtension(isCA, true, pathLenght, true));

            //Enhanced Key usage
            if (isEnchancedKeySrvClientAuth)
            {
                request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(new OidCollection { new Oid("1.3.6.1.5.5.7.3.1"), new Oid("1.3.6.1.5.5.7.3.8") }, false));
            }
            //

            // Add Subject Key identifier extension
            request.CertificateExtensions.Add(new X509SubjectKeyIdentifierExtension(request.PublicKey, false));

            // Create Certificate return 
            X509Certificate2 certificateGenerated = request.CreateSelfSigned(DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddYears(numberofYears));

            // return the certificate
            return certificateGenerated;
        }
    }
}
