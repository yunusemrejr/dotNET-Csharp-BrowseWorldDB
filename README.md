# World Cities Explorer - Professional Edition

A modern, professional Windows Forms application for browsing world cities data with an integrated advanced calculator. This application connects to a MySQL database containing comprehensive information about cities worldwide.

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-blue)
![MySQL](https://img.shields.io/badge/MySQL-8.0-orange)
![C#](https://img.shields.io/badge/C%23-Windows%20Forms-green)

## 🌟 Features

### 📊 World Cities Database Browser
- **Interactive Data Grid**: Browse through thousands of cities with a clean, modern interface
- **Advanced Search & Filter**: Real-time search by city name, country code, or district
- **Navigation Controls**: First, Previous, Next, Last buttons for easy data navigation
- **Live Statistics**: View total cities, countries, population statistics (total, average, min, max)
- **CSV Export**: Export filtered data to CSV format for external analysis
- **Formatted Display**: Population numbers with thousand separators for better readability

### 🧮 Advanced Calculator
- **Multiple Operations**:
  - Addition (+)
  - Subtraction (-)
  - Multiplication (×)
  - Division (÷)
  - Power (^)
  - Modulo (%)
  - Square Root (√)
  - Pi Multiplication (π)
- **Smart Validation**: Input validation with helpful error messages
- **Real-time Results**: Instant calculation with formatted output
- **User-Friendly**: Clear operation labels and intuitive interface

### 🔍 City ID & Name Lookup
- **Quick Lookup**: Select a city ID to instantly view its name
- **Dropdown Selection**: Easy-to-use combo box with all cities
- **Bidirectional Display**: Shows both ID and corresponding city name

## 🛠️ Technology Stack

- **Framework**: .NET Framework 4.7.2
- **Language**: C# 
- **UI**: Windows Forms
- **Database**: MySQL 8.0
- **MySQL Connector**: MySQL.Data (version 8.0.23+)

## 📋 Prerequisites

Before running this application, ensure you have:

1. **Windows Operating System** (Windows 7 or later)
2. **.NET Framework 4.7.2** or higher
3. **MySQL Server 8.0** or higher
4. **Visual Studio 2019** or later (for development)
5. **MySQL Connector/NET 8.0.23** or higher

## 🚀 Installation & Setup

### Step 1: Install MySQL Server

1. Download MySQL Server from [MySQL Official Website](https://dev.mysql.com/downloads/mysql/)
2. Install MySQL Server with default settings
3. Remember your root password (or leave it empty for local development)
4. Ensure MySQL service is running

### Step 2: Import World Database

1. Locate the `worldDB.sql` file in the project directory:
   ```
   dotNET(C#)-BrowseWorldCitiesWithSimpleCalculator/worldDB.sql
   ```

2. Import the database using MySQL Workbench or command line:

   **Using MySQL Workbench:**
   - Open MySQL Workbench
   - Connect to your local MySQL server
   - Go to Server → Data Import
   - Select "Import from Self-Contained File"
   - Browse and select `worldDB.sql`
   - Click "Start Import"

   **Using Command Line:**
   ```bash
   mysql -u root -p < worldDB.sql
   ```

3. Verify the database was created:
   ```sql
   SHOW DATABASES;
   USE world;
   SHOW TABLES;
   ```

   You should see three tables: `city`, `country`, and `countrylanguage`

### Step 3: Configure Database Connection

1. Open the project in Visual Studio
2. Navigate to `Form1.cs`
3. Locate the connection string (line ~16):
   ```csharp
   private const string ConnectionString = "user=root; password=; port=3306; server=localhost; database=world";
   ```

4. Update the connection string with your MySQL credentials:
   ```csharp
   private const string ConnectionString = "user=YOUR_USERNAME; password=YOUR_PASSWORD; port=3306; server=localhost; database=world";
   ```

### Step 4: Install MySQL Connector/NET

1. In Visual Studio, right-click on the project
2. Select "Manage NuGet Packages"
3. Search for "MySql.Data"
4. Install version 8.0.23 or higher

   **OR** use Package Manager Console:
   ```powershell
   Install-Package MySql.Data -Version 8.0.23
   ```

### Step 5: Build and Run

1. Build the solution: `Build → Build Solution` (or press `Ctrl+Shift+B`)
2. Run the application: `Debug → Start Debugging` (or press `F5`)

## 📖 Usage Guide

### World Cities Database Tab

1. **Browsing Data**:
   - Use navigation buttons (First, Previous, Next, Last) to browse through cities
   - Current position is displayed at the bottom

2. **Searching**:
   - Type in the search box to filter cities by name, country code, or district
   - Results update in real-time as you type
   - Click "Clear" to reset the search

3. **Exporting Data**:
   - Click "Export CSV" to save the current filtered data
   - Choose a location and filename
   - Open the CSV file in Excel or any spreadsheet application

4. **Statistics**:
   - View live statistics at the bottom of the screen
   - Shows total cities, countries, and population data

### Advanced Calculator Tab

1. **Select Operation**: Choose from the dropdown menu
2. **Enter Numbers**: 
   - Enter Number 1 (required for all operations)
   - Enter Number 2 (required for most operations, except Square Root)
3. **Calculate**: Click the "Calculate" button
4. **View Result**: Result appears below with the full equation

**Note**: Square Root operation only requires Number 1

### City ID & Name Lookup Tab

1. Select a City ID from the dropdown
2. The corresponding city name appears automatically
3. Useful for quick ID-to-name lookups

## 🎨 Modern UI Improvements

This professional edition includes:

- **Modern Color Scheme**: Professional blue and white theme
- **Segoe UI Font**: Clean, modern typography throughout
- **Flat Design**: Modern flat buttons with hover effects
- **Responsive Layout**: Optimized spacing and alignment
- **Visual Feedback**: Color-coded results (green for success, red for errors)
- **Professional Icons**: Unicode symbols for navigation (⏮, ◀, ▶, ⏭)
- **Improved Readability**: Better contrast and font sizes

## 🔧 Technical Improvements

### Code Quality
- **Async/Await Pattern**: Non-blocking database operations
- **Error Handling**: Comprehensive try-catch blocks with user-friendly messages
- **Resource Management**: Proper disposal of database connections
- **Input Validation**: Robust validation for all user inputs
- **LINQ Queries**: Efficient data filtering and statistics calculation

### Architecture
- **Separation of Concerns**: Clear separation between UI and data logic
- **Reusable Methods**: Modular code structure
- **Constants**: Centralized configuration (connection string)
- **Event-Driven**: Proper event handling throughout

### Performance
- **DataTable Caching**: Reduced database queries
- **Filtered Views**: Efficient search without reloading data
- **Formatted Display**: Client-side formatting for better performance

## 📊 Database Schema

### City Table
- `ID` (int): Primary key
- `Name` (char): City name
- `CountryCode` (char): ISO country code
- `District` (char): District/state name
- `Population` (int): City population

### Country Table
- `Code` (char): Primary key, ISO country code
- `Name` (char): Country name
- `Continent` (enum): Continent name
- `Region` (char): Geographic region
- `SurfaceArea` (float): Area in km²
- `Population` (int): Country population
- And more...

### CountryLanguage Table
- `CountryCode` (char): Foreign key to Country
- `Language` (char): Language name
- `IsOfficial` (enum): T/F for official status
- `Percentage` (float): Percentage of speakers

## 🐛 Troubleshooting

### "Unable to connect to any of the specified MySQL hosts"
- Ensure MySQL Server is running
- Check if the port (3306) is correct
- Verify your username and password in the connection string

### "Unknown database 'world'"
- Import the `worldDB.sql` file using the instructions above
- Verify the database exists: `SHOW DATABASES;`

### "Could not load file or assembly 'MySql.Data'"
- Install MySQL Connector/NET via NuGet
- Ensure the version matches (8.0.23 or higher)

### Application crashes on startup
- Check the database connection string
- Ensure MySQL Server is running
- Verify the 'world' database is imported correctly

## 📝 Future Enhancements

Potential features for future versions:
- [ ] Charts and graphs for population visualization
- [ ] Country details view with flags
- [ ] Language statistics and analysis
- [ ] Map integration for geographic visualization
- [ ] Advanced filtering (by continent, population range, etc.)
- [ ] Data editing capabilities (CRUD operations)
- [ ] Multi-language support
- [ ] Dark mode theme
- [ ] Export to multiple formats (Excel, PDF, JSON)

## 👨‍💻 Developer

**Yunus Emre Vurgun**
- Website: [www.yevjr.cyou](http://www.yevjr.cyou)

## 📄 License

This project is open source and available under the MIT License.

## 🙏 Acknowledgments

- World database sample data from MySQL official samples
- MySQL Connector/NET by Oracle
- .NET Framework by Microsoft

---

**Version**: 2.0 Professional Edition  
**Last Updated**: 2026  
**Status**: Production Ready

For issues, questions, or contributions, please visit the project repository or contact the developer.
