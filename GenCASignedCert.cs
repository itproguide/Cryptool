using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cryptool
{
    class GenCASignedCert
    {

        public string[] saveCAtoStore(string storeLocation, string pathCertificate, string password)
        {
            string[] certDetails = new string[4];
           // X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            if (storeLocation== "Trusted Root Certification Authorities")
            {
                X509Store storeRoot = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
                storeRoot.Open(OpenFlags.ReadWrite);
                X509Certificate2 certificate = new X509Certificate2(pathCertificate, password);
                certDetails[3] = certificate.FriendlyName;
                certDetails[1] = certificate.Thumbprint;
                certDetails[2] = certificate.NotAfter.ToString();
                certDetails[0] = certificate.SubjectName.Name;
                storeRoot.Add(certificate);
                storeRoot.Close();
                return certDetails;
            }
            else
            {
                X509Store storePersonal = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                storePersonal.Open(OpenFlags.ReadWrite);
                X509Certificate2 certificate = new X509Certificate2(pathCertificate, password);
                certDetails[3] = certificate.FriendlyName;
                certDetails[1] = certificate.Thumbprint;
                certDetails[2] = certificate.NotAfter.ToString();
                certDetails[0] = certificate.SubjectName.Name;
                storePersonal.Add(certificate);
                storePersonal.Close();
                return certDetails;
            }

        }

        public void readCertificate(string storeLocation, string thumbprint)
        {
            if (storeLocation == "Trusted Root Certification Authorities")
            {
                X509Store store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);

                // Place all certificates in an X509Certificate2Collection object.
                X509Certificate2Collection certCollection = store.Certificates;
                X509Certificate2Collection currentCerts = certCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
                X509Certificate2Collection matchCert = currentCerts.Find(X509FindType.FindByThumbprint, thumbprint, false);
                if (matchCert.Count == 0)
                {
                    Console.WriteLine("Null");

                }

                else
                {
                    X509Certificate2 myCert = matchCert[0];
                    byte[] rawdata = myCert.RawData;
                    Console.WriteLine("Content Type: {0}{1}", X509Certificate2.GetCertContentType(rawdata), Environment.NewLine);
                    Console.WriteLine("Friendly Name: {0}{1}", myCert.Thumbprint, Environment.NewLine);
                }

            }
            else
            {
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);

                // Place all certificates in an X509Certificate2Collection object.
                X509Certificate2Collection certCollection = store.Certificates;
                X509Certificate2Collection currentCerts = certCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
                X509Certificate2Collection matchCert = currentCerts.Find(X509FindType.FindByThumbprint, thumbprint, false);
                if (matchCert.Count == 0)
                {
                    Console.WriteLine("Null");

                }

                else
                {
                    X509Certificate2 myCert = matchCert[0];
                    byte[] rawdata = myCert.RawData;
                    Console.WriteLine("Content Type: {0}{1}", X509Certificate2.GetCertContentType(rawdata), Environment.NewLine);
                    Console.WriteLine("Friendly Name: {0}{1}", myCert.Thumbprint, Environment.NewLine);
                }


            }


        }

        private X509Certificate2 readCAcertificate(string storeLocation, string thumpbprint)
        {
            StoreName stLocation;
            if (storeLocation == "Trusted Root Certification Authorities")
            {
                stLocation = StoreName.Root;
            }
            else
            {
                stLocation = StoreName.My;

            }

                X509Store store = new X509Store(stLocation,StoreLocation.CurrentUser);
            try
            {
                store.Open(OpenFlags.ReadOnly);

                // Place all certificates in an X509Certificate2Collection object.
                X509Certificate2Collection certCollection = store.Certificates;
                // If using a certificate with a trusted root you do not need to FindByTimeValid, instead:
                // currentCerts.Find(X509FindType.FindBySubjectDistinguishedName, certName, true);
                X509Certificate2Collection currentCerts = certCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
                X509Certificate2Collection matchCert = currentCerts.Find(X509FindType.FindByThumbprint, thumpbprint, false);
                if (matchCert.Count == 0)
                    return null;
                X509Certificate2 myCert = matchCert[0];
                byte[] rawdata = myCert.RawData;
                Console.WriteLine("Content Type: {0}{1}", X509Certificate2.GetCertContentType(rawdata), Environment.NewLine);
                Console.WriteLine("Friendly Name: {0}{1}", myCert.FriendlyName, Environment.NewLine);
                Console.WriteLine("Certificate Verified?: {0}{1}", myCert.Verify(), Environment.NewLine);
                Console.WriteLine("Simple Name: {0}{1}", myCert.GetNameInfo(X509NameType.SimpleName, true), Environment.NewLine);
                Console.WriteLine("Signature Algorithm: {0}{1}", myCert.SignatureAlgorithm.FriendlyName, Environment.NewLine);
                Console.WriteLine("Public Key: {0}{1}", myCert.PublicKey.Key.ToXmlString(false), Environment.NewLine);
                Console.WriteLine("Certificate Archived?: {0}{1}", myCert.Archived, Environment.NewLine);
                Console.WriteLine("Length of Raw Data: {0}{1}", myCert.RawData.Length, Environment.NewLine);

                //RSA rsaPublicKey = (RSA)myCert.PublicKey.Key;
                //RSA rsaPrivateKey = myCert.GetRSAPrivateKey();
                //myCert.Reset();
                // Return the first certificate in the collection, has the right name and is current.
                //Console.WriteLine(signingCert[0]);
                return myCert;
            }
            finally
            {
                store.Close();
            }
        }

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

            foreach (string usage in keyUsages)
            {
                switch (usage)
                {
                    case "crlsign":
                        keyUsageFlags |= X509KeyUsageFlags.CrlSign;
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





        public X509Certificate2 CreateSignedCertificate(int keySize, string subjectDN, string hashAlg, List<string> keyUsages, int numberofYears, string thumbprint , string certSerialNumber, string StoreName)
        {
            //get CA Certificate to Sign
            X509Certificate2 cert = readCAcertificate(StoreName, thumbprint);
            var rsaCAPrivateKey = cert.GetRSAPrivateKey();
            RSA rsaCAPublicKey = (RSA)cert.PublicKey.Key;


            X509SignatureGenerator generator = X509SignatureGenerator.CreateForRSA(rsaCAPrivateKey, RSASignaturePadding.Pkcs1);
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
         //   request.CertificateExtensions.Add(new X509BasicConstraintsExtension(false, true, 0, true));

            //Enhanced Key usage
            if (isEnchancedKeySrvClientAuth)
            {
                request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(new OidCollection { new Oid("1.3.6.1.5.5.7.3.1"), new Oid("1.3.6.1.5.5.7.3.8") }, false));
            }
            //

            // Add Subject Key identifier extension
         //   request.CertificateExtensions.Add(new X509SubjectKeyIdentifierExtension(request.PublicKey, false));

            // Serial Number
            byte[] serialNumber = Encoding.Default.GetBytes(certSerialNumber);

            // Create Certificate return 
            X509Certificate certificateGenerated = request.Create(cert.SubjectName, generator, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddYears(2), serialNumber);

            X509Certificate2 certificateGen= new X509Certificate2(certificateGenerated);
            // return the certificate
            return certificateGen;
        }

    }


}
