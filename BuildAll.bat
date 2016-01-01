set "PATH=c:\Windows\Microsoft.NET\Framework\v4.0.30319\"

csc /unsafe /platform:x86 /target:library /out:Bin\GameSharp.dll^
    Source\GameSharp\*.cs^
    Source\GameSharp\Subsystems\*.cs^
    Source\GameSharp\Subsystems\Input\*.cs^
    Source\ThirdParty\SDL2-CS\src\*.cs^
    Source\ThirdParty\opengl4csharp\OpenGL\Constructs\*.cs^
    Source\ThirdParty\opengl4csharp\OpenGL\Core\*.cs^
    Source\ThirdParty\opengl4csharp\OpenGL\Math\*.cs

csc /platform:x86 /target:winexe /out:Bin\HelloWorld.exe /reference:Bin\GameSharp.dll Source\Samples\01_HelloWorld\*.cs

pause
