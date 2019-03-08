# Arescrypt - (stable) v1.00
#### *Experimental ransomware using Bitcoin/Litecoin/Zcash*
A project by: [Willy Fox, @BlackVikingPro](https://twitter.com/BlackVikingPro)
***

### What is Arescrypt?
Arescrypt is the latest project (as of 12/18/2017) in a malware framework that I call Ares. 
Arescrypt is special in it's own way, packing in an all-in-one (encryption/verification/decryption)
ransomware tool; designed specially for the Windows OS. 

### Unique Abilities
Well, Arescrypt is one of my first large-scale ransomware malware's I've ever hand-crafted. So,
I tried going all out for it, in hopes that it may be developed better in time. However, some of
the abilities this ransomware has are as follows:
 * All-in-one (encryption, verification, and decryption) of files. 
 * Unique API calls to configurable server (standalone PHP script included)
 * Information stored in DAT (configuration) file - obfuscated too ;)
 * Extensive configuration file
 * Sandboxing capabilities

***

### Build Requirements:
Some of these may not be required, but they do help in development
 * [Visual Studio 2017](https://www.visualstudio.com/downloads/)
 * [.NET Framework 4](https://www.microsoft.com/en-us/download/details.aspx?id=17851)
 * [Costura.Fody](https://github.com/Fody/Costura)
	* `PM> Install-Package Costura.Fody`
 * [Json.NET](https://www.newtonsoft.com/json)
	* `PM> Install-Package Newtonsoft.Json`

### Other requirements:
 * Webserver with php7.0 installed
 * MySql database
 * Moderate understanding of C-Sharp (C#) and PHP - I can't guarantee 100% stability as of now

### Build Status
![Travis Build Status](https://travis-ci.org/BlackVikingPro/arescrypt.svg?branch=master "Travis Build Status")

***

### TODO
* Add file hashsums checker
* Clean/straighten-out code to make for easier development
* Find better way to obfuscase DAT file (currently using Binary Reader/Writer)
* Extend testing and platform capabilities

### Disclaimer:
This software/framework was NOT designed for improper use. I do NOT conduct nor condone
illegal/restricted use of this software. I am NOT responsible for actions carried out
by any user of this software/framework. This is available as a free software for
personal/commercial use.
