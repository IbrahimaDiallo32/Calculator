# CalculatorSWE3643

# KSU SWE 3643 Software Testing and Quality Assurance Semester Project: Web-Based Calculator
This project is a web-based Calculator app programmed in C# using Blazor Server. The application utilizes Nunit for Unit Testing and Playwrights for End-to-End Testing to ensure quality assurance. 

## Table of Contents
1. [Architecture](#Architecture)
2. [Environment](#environment)
3. [Executing the Web Application](#executing-the-web-application)
4. [Executing Unit Tests](#executing-unit-tests)
5. [Reviewing Unit Test Coverage](#reviewing-unit-test-coverage)
6. [Executing End-To-End Tests](#Executing-End-To-End-Tests)
7. [Static Analysis](#static-analysis)
8. [Final Video Presentation](#Final-Video-Presentation)
   
## Team Members
1. Diwakar Rai
2. Ibrahima Diallo

## Architecture 
This project is split into four different projects within one solution using ASP.NET Blazor Server. The four projects are Calculator_App, CalculatorEngine, CalculatorEngineUnitTest, and CalculatorEndToEndTests.

-   Calculator_App: This project serves as the web server holding the HTML and CSS code.
-   CalculatorEngine: Here resides the mathematical operations, such as addition, factorial, and trigonometry.
-   CalculatorEngineUnitTest: This project contains all the unit tests for the mathematical operations.
-   CalculatorEndToEndTests: This project houses the Playwright end-to-end tests.

CalculatorEngine and CalculatorEnd-To-EndTests are not dependent on any projects, but CalculatorEngineTest and Calculator_App are both dependent on the CalcultorEngine.

![ArchitectureTemplateDiagram](https://github.com/IbrahimaDiallo32/Calculator/assets/111662876/072aefa6-c7d1-4671-b506-1d884da1be67)
![ProjectDependencyDiagram](https://github.com/IbrahimaDiallo32/Calculator/assets/111662876/83b2792b-9ca4-42ed-94f8-63728076b53c)


## Environment

This is a cross-platform application and should work in Windows 10+, Mac OS, and Linux environments. Note this Application has only been tested on Windows 10+ and MacOs.

### Steps to prepare your environment to execute this application: 

1. Install the latest [JetBrains Rider](https://www.jetbrains.com/rider/download/#section=windows)
2. Install [Git](https://git-scm.com/downloads) on your computer
3. Open Your Terminal Line Interface. This will be Terminal on macOS or Command prompt on Windows.
4. Clone the Repository by using this git clone command as shown below:
      ```
   git clone https://github.com/IbrahimaDiallo32/Calculator.git
      ```
5. Navigate to the Project Directory by using the 'cd' command and folder path as shown below:
      ```
   cd Calculator(name of your cloned project folder)
      ```
   
To configure NUnit for Unit Test:
1.  Right-click on CalculatorEngineUnitTest project folder
2.  Click on Manage NuGet Packages
3. Install the following packages in the Manage NuGet Packages:
   1. Nunit 4.1.0
   2. Nuni.Analyzers 4.1.0
   3. NUnit3TestAdapter 4.5.0

To configure PlayWright for end-to-end testing: 
1. Install [Playwright](https://playwright.dev/dotnet/docs/intro) on your solution Folder
   

## Executing the Web Application 

To execute the Web Application:
1. Make sure to follow the steps in the [Environment](#environment) instructions
2. Open your command Line interface and Navigate to the project Directory of this project using the 'cd' command:
      ```
    cd calculator_App
      ```
3. Once in this Directory, restore the Dependencies necessary for this application by following these commands:
      ```
   dotnet restore
      ```
4. Build the project by following these commands:
   ```
   dotnet build
   ```
5. Launch the Web Application by following these commands:
    ```
    dotnet run
    ```
6. After the application starts, launch a browser and connect to HTTP://localhost:5166 (port number)
   
   

## Executing Unit Tests

To execute the Unit Test:
**Note: If the application is running, open a new terminal window and skip steps 3 and 4.** 

1. Make sure to follow the steps in the [Environment](#environment) instructions
2.  Open your command line interface and Navigate to the project Directory of this project using the 'cd' command:
      ```
    cd calculatorEngineUnitTest
      ```
3. Once in this Directory, Restore Dependencies necessary for this application by following these commands:
      ```
   dotnet restore
      ```
4. Build the project by following these commands:
   ```
   dotnet build
   ```
5. Execute the Unit Tests by following these commands:
   ```
   dotnet test
   ```

## Reviewing Unit Test Coverage
1. For our Calculator Web Application, we obtained 100% coverage of all methods on our Calculator Engine Module.
![UnitTestCoverage](https://github.com/IbrahimaDiallo32/Calculator/assets/111923854/a42ecd96-b76b-4055-8be4-d087579e4abc)


## Executing End-to-End Tests

To execute the End-to-End Testing:
**Note: The Web Application should be running on the machine.**
1.  Make sure to follow the steps in the [Environment](#environment) instructions
2.  Open your command line interface and Navigate to the project Directory of this project using the 'cd' command:
      ```
    cd calculatorEnd-To-EndTests
      ```
3. Run the End-To-End Tests by following these commands:
   ```
   dotnet test
   ```
## Final Video Presentation

Watch our Project's Presentation
