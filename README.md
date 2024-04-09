# CodeCoverage
Sample project to demonstrate usage of DotCover CLI tool.

## To install DotCover CLI tool:

If dotnet cli is not installed on your computer, install it first.

Once dotnet cli is installed on your computer, open Command Prompt and enter the below command:
dotnet tool install --global JetBrains.dotCover.CommandLineTools --version 2023.3.0

Enter the below command in Command Prompt to configure the report:

dotnet-dotCover.exe dotnet --output=<path on computer where you would like to output the report>\AppCoverageReport.xml --ReportType=XML -- test "<path to test project on your computer>\Test.csproj"

Code coverage will be output to --output path specified in above command.

### Sample report output:

```xml
<?xml version="1.0" encoding="utf-8"?>
<Root CoveredStatements="48" TotalStatements="54" CoveragePercent="89" ReportType="Xml" DotCoverVersion="2023.3">
  <Assembly Name="CodeCoverage" CoveredStatements="14" TotalStatements="20" CoveragePercent="70">
    <Namespace Name="CodeCoverage" CoveredStatements="14" TotalStatements="14" CoveragePercent="100">
      <Type Name="MathHelperService" CoveredStatements="14" TotalStatements="14" CoveragePercent="100">
        <Method Name="Add(int,int):int" CoveredStatements="3" TotalStatements="3" CoveragePercent="100" />
        <Method Name="Divide(int,int):Decimal" CoveredStatements="5" TotalStatements="5" CoveragePercent="100" />
        <Method Name="Multiply(int,int):int" CoveredStatements="3" TotalStatements="3" CoveragePercent="100" />
        <Method Name="Subtract(int,int):int" CoveredStatements="3" TotalStatements="3" CoveragePercent="100" />
      </Type>
    </Namespace>
    <Type Name="Program" CoveredStatements="0" TotalStatements="6" CoveragePercent="0">
      <Method Name="&lt;Main&gt;$(string[]):void" CoveredStatements="0" TotalStatements="6" CoveragePercent="0">
        <OwnCoverage CoveredStatements="0" TotalStatements="3" CoveragePercent="0" />
        <AnonymousMethod Name="(HostBuilderContext,IServiceCollection):void" CoveredStatements="0" TotalStatements="3" CoveragePercent="0" />
      </Method>
    </Type>
  </Assembly>
  <Assembly Name="Test" CoveredStatements="34" TotalStatements="34" CoveragePercent="100">
    <Namespace Name="CodeCoverage.Tests" CoveredStatements="34" TotalStatements="34" CoveragePercent="100">
      <Type Name="MathHelperTests" CoveredStatements="34" TotalStatements="34" CoveragePercent="100">
        <Constructor Name="MathHelperTests()" CoveredStatements="4" TotalStatements="4" CoveragePercent="100" />
        <Method Name="TestAdd():void" CoveredStatements="6" TotalStatements="6" CoveragePercent="100" />
        <Method Name="TestDivide():void" CoveredStatements="6" TotalStatements="6" CoveragePercent="100" />
        <Method Name="TestDivideByZero():void" CoveredStatements="6" TotalStatements="6" CoveragePercent="100">
          <OwnCoverage CoveredStatements="5" TotalStatements="5" CoveragePercent="100" />
          <AnonymousMethod Name="():object" CoveredStatements="1" TotalStatements="1" CoveragePercent="100" />
        </Method>
        <Method Name="TestMultiply():void" CoveredStatements="6" TotalStatements="6" CoveragePercent="100" />
        <Method Name="TestSubtract():void" CoveredStatements="6" TotalStatements="6" CoveragePercent="100" />
      </Type>
    </Namespace>
  </Assembly>
</Root>
```

To test the DotCover CLI tool's analysis, comment out some of the tests in CodeCoverage.Tests.MathHelperTests.cs file and re-run the below command. (The CoveragePercent value in output report will be lower):

dotnet-dotCover.exe dotnet --output=<path on computer where you would like to output the report>\AppCoverageReport.xml --ReportType=XML -- test "<path to test project on your computer>\Test.csproj"

These steps demonstrate the most basic usage of the tool. See DotCover docs for more features and install guide:

https://www.jetbrains.com/help/dotcover/Running_Coverage_Analysis_from_the_Command_LIne.html#install-dotcover-command-line-tool
