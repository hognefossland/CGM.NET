# Introduction
Alpha version of uploader for the 600-series pump.

## Projects
CGM.Communication: The core communication between pump and CNL. Coded in c# .NET standard 1.4. 

CGM.Uwp: The client. Coded for UWP. 

All tested on a laptop with windows 10 and a raspberry pi 3 with windows iot. (still some issues)

### If you want to use it
1. Download [visual studio community 2017 ](https://www.visualstudio.com/downloads/).
2. Build and deploy uwp-project and then debug it

In order to run the uploader you need to go the settings page and configure your nightscout url/api-key.
It also on the settings page that you can see the registred CNL and their parameters.
You can delete the CNL from here.

I have used Microsoft.Extensions.Logging for the logs. You can see the placement of the logs in the setting page.
I did not want to make too many external reference. So there is no reference to Microsoft Azure Services ex. insight, iot hub, power bi and so on..

But I plan to make use of those services in the near future.


# Standing on the shoulders of giants....
A big thanks goes out to the Nightscout community who without this project would not have been possible.
Not sure if it is good manners to single out persons.... but here goes:

Thanks goes out to Lennart Goedhart (https://github.com/pazaan) for the uploader and decoding work.
Thanks to the 600Series team https://github.com/pazaan/600SeriesAndroidUploader  
Figuring out and using the protocol would not have been possible without the work of these guys/girls.


### Disclaimer And Warning
All information, thought, and code described here is intended for informational and educational purposes only. 
Nightscout currently makes no attempt at HIPAA privacy compliance. 
Use Nightscout at your own risk, and do not use the information or code to make medical decisions.

Use of code from github.com is without warranty or formal support of any kind. Please review this repository's LICENSE for details.

All product and company names, trademarks, servicemarks, registered trademarks, and registered servicemarks are the property of their respective holders. Their use is for information purposes and does not imply any affiliation with or endorsement by them.

Please note - this project has no association with and is not endorsed by:

Medtronic

Ascensia Diabetes Care (formerly Bayer Diabetes Care)
