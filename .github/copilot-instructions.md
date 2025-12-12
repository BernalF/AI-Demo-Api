# Copilot Instructions for AI-Demo-Api

## Project Overview
- **Type:** ASP.NET Core Web API (.NET 8)
- **Key Components:**
  - `Controllers/WeatherController.cs`: Main API controller, follows REST conventions.
  - `Models/WeatherForecast.cs`: Data model for weather forecasts.
  - `Tests/WeatherTests.cs`: xUnit-based unit tests for API endpoints.
- **Build/Test:**
  - Build: `dotnet build`
  - Test: `dotnet test`
  - Debug: Use Visual Studio/VS Code launch profiles in `Properties/launchSettings.json`.

## Coding Patterns & Conventions
- **Controllers:**
  - Use RESTful routes and HTTP verbs.
  - Return `ActionResult<T>` for endpoints.
  - Avoid inventing endpoints; follow existing patterns in `WeatherController.cs`.
  - Apply input validation and clear error handling.
- **Models:**
  - Place all data models in `Models/`.
  - Use C# records or classes for DTOs.
- **Testing:**
  - Use xUnit for all tests in `Tests/`.
  - Follow AAA (Arrange/Act/Assert) pattern.
  - Tests should be deterministic and cover edge cases.
  - Use Moq for mocking dependencies if needed.

## Developer Workflows
- **Add new endpoints:**
  - Place in `Controllers/`, follow REST conventions.
  - Reference `WeatherController.cs` for structure and style.
- **Run tests:** `dotnet test`
- **Debug:** Use launch profiles in `Properties/launchSettings.json`.

## Integration & External Dependencies
- No external service dependencies by default.
- Add new dependencies via NuGet and document in the README if critical.

## Examples
- See `Controllers/WeatherController.cs` for endpoint patterns.
- See `Tests/WeatherTests.cs` for test structure.

---
**For AI agents:**
- Always follow the conventions above.
- When in doubt, reference the README and existing code for patterns.
- Use explicit, RESTful, and testable code.
