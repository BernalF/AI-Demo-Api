# 🚀 Demo Guide: Using Copilot Instructions & Prompts

This document provides a set of live demos that showcase how GitHub Copilot uses:

- **Repository-level instructions**
- **Path-based instructions**
- **Custom prompts (`/explain-endpoint`, `/generate-tests`)**

Each demo highlights how Copilot adapts its behavior based on context and repository configuration.


## Useful Links

- [ChatGPT Prompt Generator](https://www.feedough.com/chatgpt-prompt-generator/)
- [BeastMode ChatMode](https://gist.github.com/berkay-digital/29e142dc7f6494ef3ecb99b854a6ce73#file-beastmode-chatmode-md)
- [Awesome Copilot (GitHub)](https://github.com/github/awesome-copilot/tree/main)
- [Model Context Protocol Servers](https://github.com/modelcontextprotocol/servers?tab=readme-ov-file)
- [MCP Server Step-by-Step Guide](https://composio.dev/blog/mcp-server-step-by-step-guide-to-building-from-scrtch)
- [Toon: Bye Bye JSON for LLMs (Medium)](https://medium.com/data-science-in-your-pocket/toon-bye-bye-json-for-llms-91e4fe521b14)
- [NotebookLM by Google](https://notebooklm.google.com/)

## 📌 Demo 1 — API Instructions in Controllers

**File:**  
`Controllers/WeatherController.cs`

**Prompt:**
```
Improve this endpoint following the repository instructions.
```

**Expected behavior:**
- Uses proper REST conventions  
- Suggests returning `ActionResult<T>`  
- Avoids inventing endpoints  
- Applies clarity and validation rules  

## 📌 Demo 2 — Test Instructions in the Tests Folder

**File:**  
`Tests/WeatherTests.cs`

**Prompt:**
```
Improve these tests by following the test instructions for this repository.
```

**Expected behavior:**
- Uses xUnit conventions  
- Uses AAA (Arrange / Act / Assert)  
- Produces deterministic test logic  

---

## 📌 Demo 3 — Creating a New Endpoint With API Instructions

**Prompt:**
```
Add a new GET endpoint /api/weather/{days} that returns a customizable number of forecasts.
Follow the API instructions from this repository.
```

**Expected behavior:**
- Creates a REST-friendly route  
- Uses action results  
- Applies consistent coding style  

---

## 📌 Demo 4 — Using a Custom Prompt: `/explain-endpoint`

**File:**  
`Controllers/WeatherController.cs`

**Prompt:**
```
/explain-endpoint
```

**Expected behavior:**
- Explains the selected endpoint  
- Describes inputs, outputs, and behavior  
- Suggests best practices  

---

## 📌 Demo 5 — Using the `/generate-tests` Prompt

**File:**  
`Controllers/WeatherController.cs`

**Prompt:**
```
/generate-tests Generate full unit tests with edge cases.
```

**Expected behavior:**
- Creates xUnit tests  
- Applies AAA structure  
- Includes useful edge cases  
- Uses Moq when needed  

---

## 📌 Demo 6 — Demonstrating Behavior Without Instructions

**Action:**  
Rename the `.github/` folder to:

```
.github_backup
```

**Prompt:**
```
Improve this controller.
```

**Expected behavior:**
- Copilot no longer follows REST conventions  
- May produce inconsistent or generic code  
- Does not apply validation rules  
- Demonstrates the importance of repository instructions  

---
