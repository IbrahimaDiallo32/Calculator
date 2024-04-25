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

## Environment

This is a cross-platform application and should work in Windows 10+, Mac OS, and Linux environments. Note this Application has only been tested on Windows 10+ and MacOs.

### Steps to prepare your environment to execute this application: 

1. Install the latest JetBrains [Rider](https://www.jetbrains.com/rider/download/#section=windows)
2. Install **[Git](#https://git-scm.com/downloads)**on your computer
3. Open Your Terminal Line Interface
   - Open the terminal on your machine. This will be Terminal on macOS or Command prompt on Windows.
4. Clone the Repository by using this git clone command as shown below:
      ```
   git clone https://github.com/IbrahimaDiallo32/Calculator.git
      ```
6. Navigate to the Project Directory by using the 'cd' command and folder path as shown below:
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
1. Install **[Playwright](#https://playwright.dev/dotnet/docs/intro)**on your solution Folder
   

## Executing the Web Application 
To execute the Web Application:
1. Make sure to follow the steps in the [Environment](#environment) instructions
2. Open your command Line interface and Navigate to the project Directory of this project using the 'cd' command:
      ```
    cd calculator
      ```
3. Once in this Directory, Restore Dependencies necessary for this application by following these commands:
      ```
   dotnet restore
      ```
4. build the project by following these commands:
   ```
   dotnet build
   ```
5. Launch the Web Application by following these commands:
    ```
    dotnet run
    ``` 
   

## Executing Unit Tests

To execute the Unit Test:

1. Make sure to follow the steps in the [Environment](#environment) instructions
2.  Open your command line interface and Navigate to the project Directory of this project using the 'cd' command:
      ```
    cd calculator
      ```
3. Once in this Directory, Restore Dependencies necessary for this application by following these commands:
      ```
   dotnet restore
      ```
4. build the project by following these commands:
   ```
   dotnet build
   ```
5. Execute the Unit Tests by following these commands:
   ```
   dotnet test
   ```


## Reviewing Unit Test Coverage
1.  Make sure to follow the steps in the [Environment](#environment) instructions

## Executing End-to-End Tests
1.  Make sure to follow the steps in the [Environment](#environment) instructions
2.  Install Playwright following these instructions: https://playwright.dev/dotnet/docs/intro
## Final Video Presentation
-asdfahjkldfag
