
# KinectCamV2
Original code is from Piotr Sowa:
  * http://codingbytodesign.net/2014/07/20/kinectcamv2-for-kinect-v2/
  * http://codingbytodesign.net/2015/02/08/coding-by-to-design-of-kinectcamv2/

The code is functional with Kinect for Xbox One and the v2 SDK, but it hasn't been sanitized as of this commit. However, the project has been cleaned to not mess with your file system.

Also, make sure you enable Windows Hello with your Kinect. It works perfectly! https://channel9.msdn.com/coding4fun/kinect/Windows-Hello-with-the-Kinect-v2

## Skype for Business
Also from http://codingbytodesign.net/2014/07/20/kinectcamv2-for-kinect-v2/:
Many people want to use this solution for Skype for Business 2016 or older. The solution is very simple, because Skype for Business 2016 and older uses .NET Framework 2.0 runtime and KinectCamV2 driver is written in .NET Framework 4.0, so to force Skype for Business 2016 or older to use .NET Framework 4.0 all you have to do is very simple thing. You have to create lync.exe.config file with following content.
```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/>
    </startup>
</configuration>
```
And copy it to the place where you have lync.exe installed, for example inside folder: “C:\Program Files (x86)\Microsoft Office\Root\Office16”. This solution can be used for other solutions that uses .NET Framework and you need force to use higer version of .NET Framework. 
