# EscapeRoomMVC

A web-based escape room quiz built with **ASP.NET Core MVC**. Answer the questions in the right order to escape the room.

## Tech stack

- **ASP.NET Core MVC** (.NET 10)
- Razor views with Bootstrap
- ViewModels for passing data to views

## Features

- Home page that introduces the game
- Question page that renders questions and validates answers
- Progress through the puzzle sequence to "escape"

## Getting started

```bash
git clone https://github.com/Linaslala/EscapeRoomMVC.git
cd EscapeRoomMVC
dotnet run --project EscapeRoomMVC
```

Open `https://localhost:<port>` in your browser.

## Possible future improvements

- Keep score and add a timer
- Add multiple escape rooms / themes
- Add authentication and save player results
- Add unit tests for the game logic