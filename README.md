# Umbraco With uSync (BG.Umbraco)

This is a simple Umbraco 15 project built using **ASP.NET Core MVC** and integrated with **uSync** for environment synchronization. It includes:

- ✅ Umbraco CMS
- ✅ uSync for content sync
- ✅ Custom MVC Controller (`BasePageController`)
- ✅ SQLite (or use SQL Server)

---

## 🧱 Project Structure

```
/BG.Umbraco
├── Controllers/
│   └── BasePageController.cs
├── Extensions/
│   └── PublishedContentExtensions.cs
├── Models/
│   └── Generated/
├── umbraco/
│   └── Data/
│   └── Logs/
├── uSync/
│   ├── v15/
│   │   ├── Contents/
│   │   ├── DocumentType/
│   │   ├── DataTypes/
│   │   ├── Languages/
│   │   ├── Media/
│   │   ├── MediaTypes/
│   │   ├── Templates/
├── Views/
│   └── Partials/
│   └── _ViewImports.cshtml
│   └── contactUsPage.cshtml
│   └── GeneralContentPage.cshtml
│   └── Layout.cshtml
├── Program.cs
├── appsettings.cs
├── appsettings.Development.cs
└── BG.Umbraco.csproj
```

---

## 🚀 Getting Started

### 1. Clone the Repo & Restore

```bash
git clone https://github.com/zngreg/BlueGrass.git
cd BG.Umbraco
dotnet restore
```

### 2. Run the App

```bash
dotnet run
```

- Navigate to: `https://localhost:44330` → Shows the custom MVC view.
- Navigate to: `https://localhost:44330/umbraco` → Log in to Umbraco backoffice.

### 3. Create Umbraco Account

On installation first screen you will be required to fill in the following information:

- **Name**: `Joe Doe`
- **Email**: `joedoe@example.com`
- **Password**: `1234567890`

![image info](/Media/Screenshot%202025-04-06%20at%203.31.47 PM.png)

On installation second screen, you can set the amount of telementry you like to share on the site:

![image info](/Media/Screenshot%202025-04-06%20at%203.32.06 PM.png)

On installation third screen, you can select the database you would like to connect to, for the purpose of this example. I recommend SQL Lite:

![image info](/Media/Screenshot%202025-04-06%20at%203.32.23 PM.png)

On successful installation, you'll be required to login with your crdentails created on step one to access Umbraco back office:

![image info](/Media/Screenshot%202025-04-06%20at%203.33.05 PM.png)

Note: Upon installation uSync will automatically run and import the configurations. You can browse around to view configs or navigate to site `https://localhost:44330` to access the application.

---

## 🧩 uSync Usage

### 🔼 Export Content Types

- Go to **Umbraco → Settings → uSync**
- Click **Export All** to serialize document types, templates, data types, etc.
- Files are saved to `/uSync/v15/`

### 🔽 Import on Another Environment

- Commit `/uSync` folder to your repo.
- Pull into another environment.
- Run app and import via Umbraco backoffice or auto-import.

### Optional: Auto Import on Startup

This application is configured with uSync Import on Startup for all Config Types, to change this config edit `appsettings.Development.json`:

```json
{
  "uSync": {
    "Settings": {
      "ImportAtStartup": "None"
    }
  }
}
```

This application is configured with uSync Export on Save for all Config Types, to change this config edit `appsettings.Development.json`:

```json
{
  "uSync": {
    "Settings": {
      "ExportOnSave": "None"
    }
  }
}
```

## 🔐 Notes

- This project uses **SQLite** for ease of setup. Swap with SQL Server as needed.
- Ensure `uSync` folder is committed to version control for syncing environments.

---

## 📦 Packages Used

- [Umbraco CMS](https://www.nuget.org/packages/Umbraco.Cms)
- [uSync](https://www.nuget.org/packages/uSync)

---

## 📄 License

MIT for uSync.

---

## 🙌 Credits

Built by Sanele Ngidi. Based on Umbraco CMS and uSync by [Kevin Jump](https://github.com/KevinJump).
