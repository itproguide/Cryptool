# Cryptool
<h3>For documentation <h3> 
<h5> Youtube: upload soon </h5>
<h5>Website: pkiblog.com </h5>

Generate Certificates
Cryptool is a simple tool that makes your life easier when you require to generate a self-signed certificate or your own CA-signed certificate. So here's a Graphical User interface based tool use .Net Framework to generate Self-Signed X.509 certificates and Signed certificates. A complete source code of this program is available in GitHub for use and further development. 


First Look: Interface for generating the self-signed certificate. 


<h3>What is a self-signed certificate? </h3>

A self-signed certificate is an SSL certificate that Individual issues, So with Cryptool, you can generate your certificate for testing and development purposes without much effort.


Cryptool, a self-signed certificate interface, allows users to enter the certificate details, including DN Name, Algorithm, RSA key Size, path constrain, and validity. Basic and Extended key usage add the capability or usage of certificate. For Root CA, enable Certificate signer so the generated certificates can be used to issue other certificates. 

<h3>Signed certificate:</h3>
What is a signed certificate?
A signed certificate is usually signed by globally trusted CA's like Digicert and Comodo etc. Organizations also use internal CA using Microsoft ADCS for issuing the internal certificate. 
With Cryptool, You can upload or save your root CA to your computer store and generate a new signed certificate for your purpose. 

<h6>Step 1: Upload your root certificate in pfx format.</h6> 

a. Select your Store from the dropdown list, and then click and locate the root certificate (pfx format). Enter the password and submit it to save to the store. 

A little information is displayed once you successfully store your certificate. 
	
<h6>Step 2: Generate a signed certificate</h6>
Cryptool automatically popup the certificate details of CA stored using step 1. If you would prefer to use an already stored root certificate to generate a signed certificate. 

You are free to use any stored certificate from the system, Enter the right thumbprint and store name to use the existing root certificate. 

Important Note: Use run as admin if you want to use a stored certificate from the Trusted root certificate store. 

Finally, enter the certificate details required and save in pfx format. 

