IF EXIST VisualStudio.coverage DEL VisualStudio.coverage
IF EXIST VisualStudio.coveragexml DEL VisualStudio.coveragexml
IF EXIST TestResults RMDIR TestResults /S /Q

SET VS_PATH=C:\Program Files (x86)\Microsoft Visual Studio 12.0
"%VS_PATH%\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" "StringCalculatorKata\UnitTests\bin\Release\UnitTests.dll" /logger:trx
"%VS_PATH%\Team Tools\Dynamic Code Coverage Tools\CodeCoverage.exe" collect /output:VisualStudio.coverage "%VS_PATH%\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" "StringCalculatorKata\UnitTests\bin\Release\UnitTests.dll"
"%VS_PATH%\Team Tools\Dynamic Code Coverage Tools\CodeCoverage.exe" analyze /output:VisualStudio.coveragexml VisualStudio.coverage
sonar-runner.bat