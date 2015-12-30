set "PATH=c:\Windows\Microsoft.NET\Framework\v3.5\"
csc /unsafe /platform:x86 /target:library /out:Bin\GameSharp.dll Source\GameSharp\*.cs Source\GameSharp\ThirdParty\SDL2-CS\src\*.cs
csc /platform:x86 /target:exe /out:Bin\HelloWorld.exe /reference:Bin\GameSharp.dll Source\Samples\01_HelloWorld\*.cs
pause
