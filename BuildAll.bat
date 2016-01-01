set "PATH=c:\Windows\Microsoft.NET\Framework\v4.0.30319\"

csc /unsafe /platform:x86 /target:library /out:Bin\GameSharp.dll^
    Source\GameSharp\*.cs^
    Source\GameSharp\Input\*.cs^
    Source\ThirdParty\SDL2-CS\src\*.cs^
    Source\ThirdParty\opengl4csharp\OpenGL\*.cs

csc /platform:x86 /target:winexe /out:Bin\HelloWorld.exe /reference:Bin\GameSharp.dll Source\Samples\01_HelloWorld\*.cs

pause
