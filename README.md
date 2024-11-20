# Price Quotation App  

**Price Quotation App** is an ASP.NET Core application that provides a user-friendly interface for calculating discounts and total prices. Users can input a **subtotal** and **discount percentage**, and the application calculates the discount amount and total price. It also features robust form validation to ensure all inputs are valid and within acceptable ranges.  

---

## Features  

- Input subtotal and discount percentage.  
- Calculate and display the discount amount.  
- Calculate and display the total price after discount.  
- Form validation to ensure valid user inputs.  

---

## Prerequisites  

Before running the application, ensure the following are installed:  

- .NET 8 SDK or later  
- Visual Studio 2022 or later  

---

## Setup  

Follow these steps to set up and run the application:  

1. **Clone the Repository:**  
   Clone the repository from GitHub:  
   ```bash  
   git clone https://github.com/username/PriceQuotationApp.git  
   cd PriceQuotationApp  
   ```  

2. **Open the Project in Visual Studio:**  
   - Open Visual Studio and navigate to **File > Open > Project/Solution**.  
   - Select the `.sln` file in the project directory.  

3. **Restore NuGet Packages:**  
   Visual Studio should restore the required NuGet packages automatically. If not:  
   - Go to **Tools > NuGet Package Manager > Package Manager Console** in Visual Studio.  
   - Run the following command:  
     ```bash  
     dotnet restore  
     ```  

4. **Build the Project:**  
   - Build the project to ensure all dependencies are installed and there are no build errors.  
   - In Visual Studio, go to **Build > Build Solution** or press `Ctrl+Shift+B`.  

5. **Run the Application:**  
   - Press **F5** in Visual Studio or click the **Start** button in the toolbar to launch the application.  

6. **Access the Application:**  
   - Once running, the application will open in your default browser at a local URL specified in `launchSettings.json`:  
     - **HTTP:** `http://localhost:5145`  
     - **HTTPS:** `https://localhost:7029`  

---

## License  

This project is licensed under the [MIT License](LICENSE).  

---

## Contributions  

Contributions are welcome! To contribute:  
1. Open an issue to discuss your ideas or report bugs.  
2. Submit a pull request with your improvements or fixes.  

For questions or feedback, feel free to reach out.  
