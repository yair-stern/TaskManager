# TaskManager

A simple console application for managing a to-do list, written in C# (.NET 8).

This is a learning project, built to practice C# fundamentals: classes, collections, input validation and control flow.

## Features

- Add a task
- Toggle a task's status (Completed / Not Completed)
- Display the task list
- Delete a task

## Getting started

Requirements: [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

```bash
git clone https://github.com/yair-stern/TaskManager.git
cd TaskManager
dotnet run
```

Or open `TaskManager.sln` in Visual Studio and press F5.

<!-- TODO: add a screenshot of the console, e.g. ![Screenshot](docs/screenshot.png) -->

## Project structure

| File | Description |
|------|-------------|
| `Program.cs` | Entry point, main menu and user input handling |
| `TaskList.cs` | Manages the collection of tasks |
| `TaskItem.cs` | A single task (title, id, completion status) |

## Status

Work in progress. See [TODO.md](TODO.md) for known issues and planned features.
