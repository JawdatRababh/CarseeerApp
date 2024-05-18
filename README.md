Carseer App.
This application retrieves all models for a specific car by calling a REST API. It is developed using C#, .NET Core 8, and follows the Onion architecture.
1.	Set Up the Startup Project:
•	Ensure that the API project is set as the startup project.
•	Verify that the project is configured to run in IIS Express.
2.	 
3.	Run the Project:
•	Start the project. Once running, Swagger UI should open in your browser, providing an interface to interact with the API.
4.	Ways to Run the API:
•	Using Swagger Directly:
•	Interact with the API endpoints directly through the Swagger UI.
 
•	 
•	 
•	
•	Using Postman:
•	Open Postman and use the IP address displayed in the 'View Sites' section at the bottom right of the IIS Express window. (You can use any of the IPs shown.)  
•	Construct the API request using the IP address along with the API name and controller. For example:
•	Use this URL in Postman to send requests to the API. https://localhost:44337/api/CarModels/GetModels?modelyear=2015&make=Lincoln
•	 
By following these steps, you can start the Carseer App locally and test the API to retrieve car models.

