set "PATH=c:\Windows\Microsoft.NET\Framework\v3.5\"
csc /target:library /out:Bin\GameSharp.dll Source\GameSharp\*.cs
csc /target:exe /out:Bin\HelloWorld.exe /reference:Bin\GameSharp.dll Source\Samples\01_HelloWorld\*.cs
pause
