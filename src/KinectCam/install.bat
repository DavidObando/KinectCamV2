@c:
@cd c:\KinectCamV21\

@c:\Windows\Microsoft.NET\Framework\v4.0.30319\ngen.exe install BaseClassesNET.dll
@c:\Windows\Microsoft.NET\Framework\v4.0.30319\ngen.exe install KinectCam.dll

@c:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe /nologo BaseClassesNET.dll
@c:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe KinectCam.dll /nologo /codebase /tlb: KinectCam.tlb
