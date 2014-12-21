SET VS_PATH=C:\Program Files (x86)\Microsoft Visual Studio 11.0
"%VS_PATH%\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" "StringCalculatorKata\UnitTests\bin\Debug\UnitTests.dll" /logger:trx
"%VS_PATH%\Team Tools\Dynamic Code Coverage Tools\CodeCoverage.exe" collect /output:VisualStudio.coverage "C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" "StringCalculatorKata\UnitTests\bin\Debug\UnitTests.dll"
"%VS_PATH%\Team Tools\Dynamic Code Coverage Tools\CodeCoverage.exe" analyze /output:VisualStudio.coveragexml VisualStudio.coverage
sonar-runner.bat
pause