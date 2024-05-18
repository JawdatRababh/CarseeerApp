Carseer App.
This application retrieves all models for a specific car by calling a REST API. It is developed using C#, .NET Core 8, and follows the Onion architecture.
1.	Set Up the Startup Project:
•	Ensure that the API project is set as the startup project.
•	Verify that the project is configured to run in IIS Express.
2.	 ![1](https://github.com/JawdatRababh/CarseeerApp/assets/170190224/d3d4b258-a021-4567-a14d-010943d48d87)

3.	Run the Project:
•	Start the project. Once running, Swagger UI should open in your browser, providing an interface to interact with the API.
4.	Ways to Run the API:
•	Using Swagger Directly:
•	Interact with the API endpoints directly through the Swagger UI.
 
•	 ![5](https://github.com/JawdatRababh/CarseeerApp/assets/170190224/d2c6c982-c4ab-47fe-8343-a093bad37c75)
![3](https://github.com/JawdatRababh/CarseeerApp/assets/170190224/22b1261e-2b3f-4bc0-811e-e813b5fef883)

•	 
•	
•	Using Postman:
•	Open Postman and use the IP address displayed in the 'View Sites' section at the bottom right of the IIS Express window. (You can use any of the IPs shown.)  
•![4](https://github.com/JawdatRababh/CarseeerApp/assets/170190224/ad9f9f32-bb58-4d0f-ad23-644ce6152cdd)


Construct the API request using the IP address along with the API name and controller. For example:
•	Use this URL in Postman to send requests to the API. https://localhost:44337/api/CarModels/GetModels?modelyear=2015&make=Lincoln
•	 ![Screenshot 2024-05-18 195236](https://github.com/JawdatRababh/CarseeerApp/assets/170190224/5bc9de7e-f333-4bdb-b23c-955bb7542cd2)

By following these steps, you can start the Carseer App locally and test the API to retrieve car models.

