set "PATH=c:\Windows\Microsoft.NET\Framework\v4.0.30319\"

csc /unsafe /platform:x86 /target:winexe /optimize /out:Bin\01_HelloWorld.exe^
    Source\Engine\*.cs^
    Source\Engine\Subsystems\*.cs^
    Source\Engine\Subsystems\Input\*.cs^
    Source\ThirdParty\SDL2-CS\src\*.cs^
    Source\ThirdParty\opengl4csharp\OpenGL\Constructs\*.cs^
    Source\ThirdParty\opengl4csharp\OpenGL\Core\*.cs^
    Source\ThirdParty\opengl4csharp\OpenGL\Math\*.cs^
    Source\Samples\01_HelloWorld\*.cs

pause
