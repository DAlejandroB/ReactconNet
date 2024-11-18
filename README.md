# ReactconNet

## Project Overview

“ReactconNet” is a personal project designed to highlight technical skills and serve as a learning platform in several key areas of web development. This includes database management, backend and frontend development, deployment, testing, UI design, and the application of security best practices. The project aims to be a foundational piece of a developer portfolio.

## Tech Stack

- **Programming Languages**: C# (for backend) and JavaScript/TypeScript (for frontend)
- **Frameworks**: .Net Core, React
- **Database**: SQLite (chosen for its simplicity, lightweight nature, and ease of setup)
- **Tools**:
  - Docker (for containerization and local environment consistency)
  - GitHub (for version control)
  - JWT (for authentication and secure user management)
  - Swagger (for API documentation)
  - Postman (for API testing)
  - Entity Framework (for database management and migrations)

## Features

### User Management
- Users can register, log in, update, and delete their accounts.
- Authentication is managed via ASP.NET Core Identity with JWT tokens for secure login and access management.
- Passwords are stored securely using hashing algorithms.

### Social Media Posts
- Users can create, read, update, and delete posts.
- Posts include a text field and can have images (future consideration for multimedia posts).
- Posts are associated with a user and can include comments and reactions.
- Stored in a relational database (SQLite).

### User Connectivity/Networking
- Users can follow others and interact with posts through reactions (like, dislike).
- A following feature allows users to see posts from followed users in their feed.
- Direct messaging is not available in the initial version but may be added in future iterations.

## Future Feature Considerations

- **Direct Messaging**: Real-time chat functionality.
- **Multimedia Posts**: Support for video and audio, in addition to images and text.
- **Search Functionality**: Search for posts and users using specific keywords, hashtags, etc.
- **Database Scaling**: Potential to switch from SQLite to PostgreSQL or MySQL as the app grows.

## App Architecture

### Frontend
- Developed using React.
- Handles UI components and interactions with component-based architecture.
- Data management and validation handled via TypeScript.
- Communicates with the backend through RESTful API calls, using JSON data for actions like posting content and managing user interactions.

### Backend
- Developed using ASP.NET Core and follows the Model-View-Controller (MVC) pattern.
- **Models**: Represent data structures (e.g., User, Post, Comment, Reaction) and interact with the database.
- **Controllers**: Handle HTTP requests, call corresponding service methods, and return responses.
- **Services**: Intermediate layer implementing business logic and keeping controllers lightweight.
- Exposes RESTful APIs for the frontend to interact with.

### Database
- SQLite as the relational database engine.
- Stores data for users, posts, comments, and reactions.
- Uses Entity Framework Core for database management and migrations.

## Data Models

- **User**: Represents a system user.
  - Fields: username, email, password hash, creation date, etc.
- **Post**: Represents a social media post.
  - Fields: post content, image URL (if applicable), timestamp, and a reference to the user (poster).
- **Comment**: Represents a comment on a post.
  - Fields: comment text, timestamp, and references to the user (author) and the post.
- **Reaction**: Represents a reaction to a post or comment.
  - Fields: reaction type (like, dislike), timestamp, and references to the user and the post/comment.

