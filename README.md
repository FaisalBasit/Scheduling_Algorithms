# Scheduling Algorithms

## Introduction

The Scheduling Algorithms project demonstrates the implementation of two fundamental CPU scheduling techniques: First Come First Serve (FCFS) and Round Robin (RR). Developed using C# Windows Forms for the user interface and SQL Server for data management, this application provides a comprehensive understanding and practical implementation of these algorithms. The user-friendly interface allows seamless interaction with the scheduling algorithms, catering to a wide range of users by offering both free and premium features to enhance their learning experience.

## Project Objective

The primary objective of this project is to create a user-friendly application that demonstrates the functionality of both the FCFS and RR scheduling algorithms. The application allows users to:

- Register and log in with unique credentials.
- Input and manage process data.
- Calculate and display key scheduling metrics such as completion time, turnaround time, and waiting time.
- Provide additional premium features such as Gantt Chart visualization and detailed breakdowns of each calculation step for paid users.
- Collect user feedback for further improvements.

## Features

### User Authentication

- **Login**: Users log in by entering their username and password.
- **Registration**: New users can create an account by providing their name, a unique username, and a password.

### Home Page

- **Poster Display**: A visual representation or poster of the FCFS and RR algorithms is displayed on the home page.

### Process Management

- **Add Process**: Users can add process details (arrival time, burst time, process ID) which are displayed in a DataGridView.
- **Choose Algorithm**: Users can select either FCFS or RR scheduling algorithms.
- **Input Time Quantum**: Users can input the time quantum for the RR scheduling algorithm.
- **Calculate Metrics**: Calculates and displays completion time, turnaround time, and waiting time for each process, along with average turnaround time and average waiting time.
- **Clear Processes**: Allows users to clear the entered process data from the DataGridView.

### Premium Features

- **Upgrade to Pro**: Users can upgrade to the pro version by paying $9 to access additional features.
- **Pro Features**: Includes Gantt Chart visualization and detailed breakdown of calculation steps.
- **Payment Integration**: Users can enter card details (Union, Visa, VisaMaster, Mastercard) to complete the upgrade.

### Feedback

- **User Feedback**: Users can provide feedback about the application.

## Problem Statements

- **User Authentication**: Ensuring secure and unique user registration and login.
- **Data Management**: Efficiently storing and retrieving user and process data using SQL Server.
- **Calculation Accuracy**: Accurately calculating and displaying scheduling metrics for both FCFS and RR algorithms.
- **User Interface**: Designing an intuitive and responsive GUI for a seamless user experience.
- **Payment Processing**: Securely handling payment transactions for upgrading users to the pro version.
- **Feature Access Control**: Differentiating between free and pro users to restrict or grant access to premium features.

## Technologies Used

- **Programming Language**: C#
- **Framework**: .NET Framework for Windows Forms
- **Database**: SQL Server for storing user credentials and process data
- **GUI Design**: Windows Forms for creating the user interface

## Conclusion

The Scheduling Algorithms project successfully demonstrates the implementation of both the FCFS and RR algorithms using a C# Windows Form application with SQL Server integration. The project achieves its objectives by providing essential scheduling functionalities along with a user-friendly interface. The additional premium features offer enhanced visualization and detailed breakdowns, making the application both educational and practical for users. Future enhancements could include adding more scheduling algorithms and further improving the user interface based on feedback.

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/FaisalBasit/Scheduling_Algorithms.git
   ```

2. **Open the solution file**:
   - Navigate to the project directory.
   - Open the solution file (`.sln`) in Visual Studio.

3. **Configure the database**:
   - Ensure SQL Server is installed and running.
   - Update the connection string in the `App.config` file with your SQL Server credentials.

4. **Build and run the application**:
   - Build the solution in Visual Studio.
   - Run the application.

## Usage

- **User Authentication**: Register a new account or log in with existing credentials.
- **Process Management**: Add processes, select scheduling algorithms, input time quantum (for RR), and calculate metrics.
- **Premium Features**: Upgrade to the pro version for Gantt Chart visualization and detailed breakdowns.
- **Feedback**: Provide feedback to help improve the application.

## License

This project is licensed under the MIT License. 

## Contact

For any inquiries or support, please contact:

- **Name**: Faisal Basit
- **Email**: muhammadfaisal159@gmail.com
