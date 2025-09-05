# Mini-Notion

A lightweight, personal knowledge management and productivity application inspired by Notion. This project provides a simplified yet powerful alternative for note-taking, task management, and personal organization.

## Project Overview

Mini-Notion is built with modern web technologies, featuring:
- **Frontend**: Vue 3 with TypeScript
- **Backend**: .NET 9 Web API
- **Database**: SQL Server with Entity Framework Core

## Features (Planned)

- 📝 Rich Text Editing
- 📁 Hierarchical Document Organization
- ✅ Task Management
- 🔍 Quick Search
- 📱 Responsive Design
- 🔒 User Authentication

## Project Structure

```
Mini-Notion/
├── MiniNotion/           # Frontend (Vue.js)
│   ├── src/             
│   │   ├── components/   # Vue components
│   │   ├── views/        # Page components
│   │   ├── router/       # Vue Router configuration
│   │   └── stores/       # State management
│   └── public/           # Static assets
│
└── PkpHub.Api/           # Backend (.NET API)
    ├── Controllers/      # API endpoints
    ├── Models/          # Data models
    ├── Data/            # Database context
    └── Migrations/      # EF Core migrations
```

## Getting Started

### Prerequisites

- Node.js (Latest LTS version)
- .NET 9 SDK
- SQL Server

### Frontend Setup

1. Navigate to the MiniNotion directory:
   ```bash
   cd MiniNotion
   ```

2. Install dependencies:
   ```bash
   npm install
   ```

3. Run development server:
   ```bash
   npm run dev
   ```

### Backend Setup

1. Navigate to the API directory:
   ```bash
   cd PkpHub.Api
   ```

2. Update database connection string in `appsettings.Development.json`

3. Run the API:
   ```bash
   dotnet run
   ```

## Development

- Frontend runs on: `http://localhost:5173`
- API runs on: `https://localhost:7073`

## Technology Stack

### Frontend
- Vue 3
- TypeScript
- Vite
- Vue Router
- Pinia (State Management)

### Backend
- .NET 9
- Entity Framework Core
- SQL Server
- ASP.NET Core Web API

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

- Inspired by Notion
- Built with modern web technologies
- Focused on simplicity and usability
