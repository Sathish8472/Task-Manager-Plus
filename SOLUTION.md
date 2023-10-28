# TaskManagerPlus Solution

## Project Overview
TaskManagerPlus is a task management application that allows users to create, delete, and edit tasks. The application provides features to list today's and upcoming tasks, grouped by date and time. 

Each task contains the following data:

	Task Name
	Description
	User
	Date
	Start and end time

The solution consists of two main components: the BackEnd API developed using C# ASP.NET Core and the UI developed using Angular. Redis has been implemented for faster data retrieval, and an InMemory database has been used for storing the task data.

## Instructions for Setting Up and Running the Project

	BackEnd API (C# ASP.NET Core)
		Clone the TaskManagerPlus repository to your local machine.
		Open the BackEnd solution in Visual Studio or any C# IDE.
		Build the solution to restore NuGet packages.
		Run the BackEnd API project to start the web server.
	
	UI (Angular)
		Make sure you have Node.js and Angular CLI installed on your machine.
		Navigate to the "task-manager-ui" folder in the cloned repository.
		Run npm install to install the required dependencies.
		After the installation is complete, run ng serve to start the Angular development server.
		Open your browser and navigate to http://localhost:4200/ to access the TaskManagerPlus UI.
		
## Solution Structure

The TaskManagerPlus solution is organized into the following projects:
	
	BackEnd
		TaskManager.API: ASP.NET Core Web API project that serves as the backend for the application.
		TaskManager.DataAccess: Data access layer project that handles interactions with the in-memory database.
		TaskManager.Services: Business logic layer project that contains services for managing tasks.
		TaskManager.Models: Shared models and entities used in the solution.
		TaskManager.Tasks: Unit testing project for testing the functionality of TaskManager.Services using xUnit.

	UI
		task-manager-ui: The main Angular application folder.
		Components: Contains Angular components for task management and task display.
		Services: Includes Angular services to communicate with the BackEnd API.
		Models: Contains TypeScript models used in the UI.
	
	
## Solution Highlights

1. **Robust Backend Architecture**

	- The TaskManagerPlus backend is built on the foundation of solid software engineering principles. It leverages C# .NET Web API to ensure a scalable, modular, and maintainable architecture. 
	- Key features include:
		- Clear separation of concerns between routing, business logic, and data access layers.
		- Adherence to SOLID principles for enhanced code organization and extensibility.

2. **User-Centered Angular UI**

	- The frontend of TaskManagerPlus is developed using Angular, delivering a user-friendly and responsive interface. 
	- Notable frontend features include:
		- Intuitive and engaging user experience with a focus on user-centered design principles.
		- Implementation of Angular best practices to ensure code reusability and maintainability.
		- Seamless navigation and user flows to enhance user engagement.

3. **Efficient Data Retrieval with Redis Caching**

	- To optimize data retrieval and enhance system performance, TaskManagerPlus employs Redis caching:
		- Integration of Redis as an in-memory data store for frequently accessed information.
		- Reduced database load and improved application responsiveness.

4. **Object-Oriented Programming (OOP) Excellence**

	- The TaskManagerPlus solution showcases strong proficiency in OOP principles:
		- Carefully designed classes and objects mirroring real-world entities.
		- Effective use of inheritance, encapsulation, and polymorphism for a well-structured codebase.

5. **Scalability and Future Expansion**

	- The architecture of TaskManagerPlus is designed for scalability and future enhancements:
		- Scalable design that can handle increased system load and seamlessly integrate new features.
		- Usage of dependency injection and modular design patterns to facilitate extensibility.

6. **Documentation, Testing, and Usability**

	- TaskManagerPlus adheres to documentation and testing best practices:
		- Thorough documentation for backend APIs, aiding development and collaboration.
		- Implementation of unit tests to ensure application reliability.
		- User research and usability testing for refining the UI based on user feedback.


## Setting up and running the project:

1. **Clone the repository:**
	```
	git clone https://sathish28042@bitbucket.org/mycodingcorner/backend-challenge.git
	```
	```
	cd TaskManagerPlus
	````

2. **Frontend (Angular UI) setup:**

	- Navigate to the `TaskManagerPlus.UI` folder.
	- Install the required dependencies using npm:
	  ```
	  npm install
	  ```
	- Start the Angular development server:
	  ```
	  ng serve
	  ```
	The Angular UI should now be accessible at [http://localhost:4200/](http://localhost:4200/).
	

3. **Backend (ASP.NET Core Web API) setup:**

	- Open the `TaskManagerPlus.sln` solution file in Visual Studio or any compatible IDE present in roolt folder.
	- Set the `TaskManagerPlus.API` project as the startup project.
	- Build and run the API project.
	- Configure the Web API's base URL in the Angular UI: You can find the API base URL in the `/src/app/config/api.config.ts` file of the `task-manager-ui` project. Make sure the API base URL matches the address where your ASP.NET Core Web API is running.
	

4. **Redis Cache Setup:**

	To optimize data retrieval efficiency, TaskManagerPlus integrates Redis caching in the `TaskManager.API` project. 
	Follow these steps to set up Redis:

	1. **Download Redis:**

	   - Visit: https://github.com/microsoftarchive/redis/releases
	   - Download the latest MSI package, e.g., `Redis-x64-3.0.504.msi`.

	2. **Install and Start Redis:**

	   - Run the MSI package and follow the installation prompts.
	   - After installation, open a command prompt with admin privileges.
	   - Navigate to the Redis installation directory, e.g., `C:\Program Files\Redis`.
	   - Start the Redis server: `redis-server.exe`.

	3. **Access Redis CLI:**

	   - Open a new command prompt.
	   - Navigate to the Redis installation directory.
	   - Access the Redis CLI: `redis-cli.exe`.

	4. **Testing and Stopping Redis:**

	   - Try commands like `SET` and `GET` in the CLI.
	   - To stop Redis, go to the server prompt and press `Ctrl+C`.

5. **Access the application:**

	- Once both the Angular UI and ASP.NET Core Web API are running, you can access the TaskManagerPlus application by navigating to [http://localhost:4200/](http://localhost:4200/) in your web browser.
	
	
## Interaction Flow Diagrams

The following sequence diagrams provide visual representations of the interaction processes within the TaskManagerPlus application. These diagrams are stored in the "Diagrams" folder located in the root directory of the project. 

	- Each diagram is available in PNG format and illustrates the various functionalities:
		- TaskManagerPlus - Get Tasks API Sequence with Redis Cache
		- TaskManagerPlus - Create Task API Sequence with Redis Cache
		- TaskManagerPlus - Update Task API Sequence with Redis Cache
		- TaskManagerPlus - Delete Task API Sequence with Redis Cache
		- TaskManagerPlus - Get List of Tasks API Sequence with Redis Cache


## Possible Improvements (with more time or as a real application):

	Implement user authentication and authorization to secure tasks based on users.
	Add sorting and filtering options for task lists.
	Implement real-time updates using WebSockets for task changes.
	
The TaskManagerPlus solution is a well-structured and functional application that effectively meets the requirements of task management.

		
## Final Notes

	The TaskManagerPlus solution demonstrates effective task management functionality. 
	Key features such as task creation, deletion, and editing have been implemented using best practices. 
	The UI provides a user-friendly interface to manage tasks efficiently.

