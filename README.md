# 💳 Credit Card Validator Project

## 📝 Overview

The **Credit Card Validator** project is a modern application designed to validate credit card numbers and detect card types using the Luhn Algorithm. The system combines a robust backend API, developed in **ASP.NET Core**, with a user-friendly frontend interface built using **HTML**, **CSS**, and **JavaScript**. This project aims to ensure secure and reliable credit card validation while providing a seamless user experience.

---

## ✨ Features

- ✅ **Credit Card Validation**: Accurate validation of credit card numbers using the industry-standard **Luhn Algorithm**.
- 💳 **Card Type Detection**: Identification of card types (e.g., Visa, MasterCard, AmEx) based on card number prefixes.
- 🔒 **Secure Communication**: Full HTTPS support for secure data transmission.
- 💻 **User-Friendly Interface**: Clean and responsive frontend for entering and validating credit card numbers.
- 🧪 **Comprehensive Testing**: Unit tests to ensure the accuracy and reliability of the validation process.

---

## 📁 Project Structure

```
.vs/
Backend/
    _Program.cs
    appsettings.json
    bin/
    Controllers/
        CardValidatorController.cs
    CreditCardValidator.csproj
    Models/
        CardValidationRequest.cs
        ValidationResult.cs
    obj/
    Services/
        CardValidationService.cs
    Utils/
        LuhnAlgorithm.cs
    wwwroot/
credit-card-validator.sln
Frontend/
    .env
    index.html
    package.json
    script.js
    server.js
    styles.css
Tests/
    CardValidatorTests.cs
```

### Backend

- ⚙️ **Controllers**: Handles API requests and routes (e.g., `CardValidatorController.cs`).
- 📚 **Services**: Business logic, including the implementation of the Luhn Algorithm (`CardValidationService.cs`).
- 🛠️ **Models**: Data structures for API requests and responses.
- 🧰 **Utils**: Utility functions for validation logic.
- ⚙️ **Configuration**: `appsettings.json` for environment configurations and HTTPS setup.

### Frontend

- 🌐 **HTML**: Main structure of the application (`index.html`).
- 🎨 **CSS**: Styles and animations for the user interface (`styles.css`).
- ✨ **JavaScript**: Dynamic interaction and API integration (`script.js`).
- 🖥️ **Server**: HTTPS-enabled Node.js server (`server.js`).

### Tests

- 🧪 Unit tests for backend services (`CardValidatorTests.cs`).

---

## 🔧 Prerequisites

### 🛠️ Tools and Technologies

- **Backend**: ASP.NET Core
- **Frontend**: HTML, CSS, JavaScript
- **Node.js**: For serving the frontend
- **Testing Framework**: NUnit

### 🖥️ System Requirements

- .NET SDK
- Node.js (latest LTS version)
- Modern web browser

---

## 🚀 Installation

### Backend

1. Clone the repository:
   ```bash
   git clone 
   cd credit-card-validator/Backend
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Run the backend server:
   ```bash
   dotnet run
   ```

### Frontend

1. Navigate to the frontend directory:
   ```bash
   cd ../Frontend
   ```

2. Install dependencies:
   ```bash
   npm install
   ```

3. Start the HTTPS server:
   ```bash
   node server.js
   ```

---

## 🖱️ Usage

1. Open the frontend interface in a browser:
   ```
   https://localhost:3000
   ```

2. Enter a credit card number in the input field and click **Validate**.

3. View validation results, including whether the card number is valid and its type (e.g., Visa, MasterCard).

---

## 🧪 Testing

Run the unit tests for the backend:

```bash
cd Backend
dotnet test
```

---

## 🛤️ Roadmap

- 🚀 **Enhancements**
  - 📊 Database Integration: Store validated card numbers for analytics.
  - 🌍 Internationalization: Support for multiple languages.
  - 🔐 Advanced Validation: Additional checks for expiration dates and CVV.

- 🌟 **Future Ideas**
  - 🤖 Machine Learning Integration: Predict fraudulent transactions.
  - 📱 Mobile Application: A companion app for mobile users.

---

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add your feature"
   ```
4. Push to your branch:
   ```bash
   git push origin feature/your-feature-name
   ```
5. Create a pull request.

---



---

## 🙏 Acknowledgements

- 🧮 Luhn Algorithm: Core logic for credit card validation.
- 🔧 ASP.NET Core: For building a secure and efficient backend API.
- 💻 Node.js: For serving a fast and responsive frontend.



