The application provides a simple interface for users to input a subtotal and discount percentage, calculates the discount amount and total price, and displays the results. It includes form validation to ensure the inputs are within acceptable ranges.

To run the ASP.NET Core application after cloning it from GitHub, follow these steps:
1. Clone the Repository
2. Navigate to the Project Directory
  cd PriceQuotationApp
3.Open the Project in Visual Studio
Open Visual Studio and select File > Open > Project/Solution, then navigate to the project directory and open the .sln file.
4. Restore NuGet Packages
Visual Studio should automatically restore the NuGet packages. If not, you can restore them manually:
•	In Visual Studio, go to Tools > NuGet Package Manager > Package Manager Console.
•	Run the following command:
  dotnet restore
5. Build the project to ensure all dependencies are correctly installed and there are no build errors:
•	In Visual Studio, go to Build > Build Solution or press Ctrl+Shift+B.
6. Run the Application
•	In Visual Studio, press F5 or click the "Start" button in the toolbar.
7. Access the Application
Once the application is running, it should open a browser window pointing to the localhost URL specified in your launchSettings.json. For example:
•	http://localhost:5145 for HTTP
•	https://localhost:7029 for HTTPS
   


