rem IF EXIST VisualStudio.coverage DEL VisualStudio.coverage
rem IF EXIST VisualStudio.coveragexml DEL VisualStudio.coveragexml
rem IF EXIST TestResults RMDIR TestResults /S /Q

rem SET VS_PATH=C:\Program Files (x86)\Microsoft Visual Studio 12.0
rem "%VS_PATH%\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" "StringCalculatorKata\UnitTests\bin\Release\UnitTests.dll" /logger:trx
rem "%VS_PATH%\Team Tools\Dynamic Code Coverage Tools\CodeCoverage.exe" collect /output:VisualStudio.coverage "%VS_PATH%\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" "StringCalculatorKata\UnitTests\bin\Release\UnitTests.dll"
rem "%VS_PATH%\Team Tools\Dynamic Code Coverage Tools\CodeCoverage.exe" analyze /output:VisualStudio.coveragexml VisualStudio.coverage

SET BUILD=Debug
SET NUNIT_PATH=C:\Users\Andrea\Documents\Visual Studio 2013\Projects\Csharp-Test-Katas\packages\NUnit.Runners.2.6.4\tools
SET COVERAGE_PATH=C:\Users\Andrea\Documents\Visual Studio 2013\Projects\Csharp-Test-Katas\packages\OpenCover.4.5.3723
"%COVERAGE_PATH%\OpenCover.Console.exe" -target:"%NUNIT_PATH%\nunit-console.exe" -targetargs:"StringCalculatorKata\UnitTests\bin\%BUILD%\UnitTests.dll /noshadow /xml=TestResult.xml" -register:user -output:coverage.xml - filter:+[StringCalculatorKata]*
sonar-runner.bat
