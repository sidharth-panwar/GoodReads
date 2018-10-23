GoodReads

Introduction
The purpose of this project is to build a web app similar to the Goodreads website, which would be much simpler in approach and is used only for understanding key concepts of a web app development lifecycle. This would include identifying the technology stack, the tools and frameworks, the design patterns and choices etc. 

Technology Stack
The GR web app will use the following technologies:
1. C# with .Net Framework 4.7.1
2. SignalR for ?
3. IoC Container ?
4. Entity Framework 6 Code First
5. SQL Server Express
6. MS Tests
7. AngularJS v1.5.8
8. OWIN
9. Web API
10. HTTPS with x.509 Certificates
11. Chat Bots
12. Webpack
13. TypeScript
14. NodeJS
15. Bootstrap 3.0

Design Principles
The app should follow common design patterns in key areas of application. Some of them are as follows:
1. SOLID Principles
2. Repository and Unit of Work for EF
3. Web APIs that are not bound to the UI and could in future be exposed separately to be consumed by apps.
4. Abstraction - It is highly desirable to keep proper abstractions so that in future if a particular component of the app needs to be replaced, we're able to do it seamlessly (such as changing DB from SQL Server to Mongo or AngularJS to Angular 6.0 etc.).
5. Tests should be one of the core components of the application and as much as possible reliance on manual testing should be removed.
6. Continuous Integration should be in place right from the start.
7. Performance Monitoring should be one of the central processes.
