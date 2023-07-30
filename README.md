# CovidTrackingApp.Solution
## By Eliot Gronstal 7.27.23
## A COVID Tracking App utilizing the Covid Tracking Project API.

### Technologies Used
* ASP.NET Core 6.0 MVC
* Covid Tracking Project [https://covidtracking.com/data/api](API)
* Kendo UI
* Deployed via Azure

### Project Overview
This web application:
* Displays a Grid / Table of Cases of Covid by State using the [https://covidtracking.com/data/api](COVID Tracking Project API).
* Displays the Date, State, Total, Positive, Negative, and Hospitalization Rates as columns.
* Provides a Date Filter to be able to change the Date of the Data displayed.
* Provides a State Filter to be able to filter on specific States.
* By Default, Orders the States by the States that have the highest Positive Covid Rates
in Descending Order.

## Setup/Installation Requirements

* _This project was built using Visual Studio 2022 on Windows 11 using Parallels Desktop. Any changes to environment cannot gurantee a compatible run time and your mileage may vary._
* _Install Visual Studio. If not already installed, you can download it from the official Microsoft website._
* _Install .NET Core SDK. Ensure you have the correct version that matches the version the application is using. Download it from the official .NET website._
* _Clone this repo down from this following [https://github.com/elgrons/CovidTrackingApp.Solution](link)_
* _Once the project is open, build it by going to the "Build" menu at the top of Visual Studio, then click on "Build Solution". You should see a "Build succeeded" message in the "Output" window at the bottom of Visual Studio._
* _Run the application by pressing the "IIS Express" button located on the toolbar at the top of Visual Studio, or by going to the "Debug" menu and clicking on "Start Debugging".A new browser window should open with your running application. By default, .NET Core applications run on [http://localhost:5000]([http://localhost:5000) or [https://localhost:5001](https://localhost:5001)_
* _Visit the site directly [https://covidtrackingapp.azurewebsites.net/](here)._

## Known Bugs

* _Choosing to filter and display data by date shows only an accumulation of total US data and not individual state data._

* _The last available date for COVID-19 data by date is March 7, 2021 (2021-03-07)._

* _Reach out with any questions or concerns to [eliot.lauren@gmail.com](eliot.lauren@gmail.com)_

## License

_MIT_

Copyright (c) 2023 _Eliot Gronstal_



