# Library App

## Description

Library App is a modular C# application designed to manage library operations such as tracking books, authors, patrons, and loans. It demonstrates clean architecture principles, separation of concerns, and extensibility using .NET 8.0, with a focus on maintainability and testability.

## Project Structure

- AccelerateDevGitHubCopilot/
  - src/
    - Library.ApplicationCore/
      - Entities/
        - Author.cs
        - Book.cs
        - BookItem.cs
        - Loan.cs
        - Patron.cs
      - Enums/
        - EnumHelper.cs
        - LoanExtensionStatus.cs
        - LoanReturnStatus.cs
        - MembershipRenewalStatus.cs
      - Interfaces/
        - ILoanRepository.cs
        - ILoanService.cs
        - IPatronRepository.cs
        - IPatronService.cs
      - Services/
        - LoanService.cs
        - PatronService.cs
      - Library.ApplicationCore.csproj
    - Library.Console/
      - appSettings.json
      - CommonActions.cs
      - ConsoleApp.cs
      - ConsoleState.cs
      - Library.Console.csproj
      - Program.cs
      - Json/
        - Authors.json
        - BookItems.json
        - Books.json
        - Loans.json
        - Patrons.json
    - Library.Infrastructure/
      - Data/
        - JsonData.cs
        - JsonLoanRepository.cs
        - JsonPatronRepository.cs
      - Library.Infrastructure.csproj
  - tests/
    - UnitTests/
      - LoanFactory.cs
      - PatronFactory.cs
      - UnitTests.csproj
      - ApplicationCore/
        - LoanService/
          - ExtendLoan.cs
          - ReturnLoan.cs
        - PatronService/
          - ...

## Key Classes and Interfaces

- **Entities**: Represent core domain objects (e.g., `Book`, `Author`, `Patron`, `Loan`).
- **Enums**: Define status and helper enumerations for domain logic.
- **Interfaces**: Abstractions for repositories and services (e.g., `ILoanRepository`, `IPatronService`).
- **Services**: Business logic implementations (e.g., `LoanService`, `PatronService`).
- **Infrastructure**: Data access and repository implementations (e.g., `JsonLoanRepository`).
- **Console App**: Entry point and user interaction logic (`Program.cs`, `ConsoleApp.cs`).
- **Tests**: Unit tests for core business logic and services.

## Usage

1. **Build the Solution**
   - Open the solution in Visual Studio or use the .NET CLI:
     ```sh
     dotnet build
     ```
2. **Run the Console Application**
   - Navigate to the `Library.Console` directory and run:
     ```sh
     dotnet run --project src/Library.Console/Library.Console.csproj
     ```
3. **Configuration**
   - Update `appSettings.json` and JSON data files in `src/Library.Console/Json/` as needed.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
