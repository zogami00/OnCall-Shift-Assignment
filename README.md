# OnCall Shift Assignment

A powerful tool for creating a balanced on-call schedule, specifically designed for hospital environments. This application automates shift allocation based on the availability of staff, their leave dates, and predefined rules to ensure a fair workload distribution.

## Features

- **Automated Shift Assignment**: Automatically generates shifts based on staff availability and leave schedules.
- **Balanced Shift Distribution**: Ensures even workload distribution across weekdays, weekends, and public holidays.
- **Custom Rules**: Customize shift assignments to avoid consecutive shifts, balance weekend work, and ensure fairness.
- **Public Holiday Management**: Treats public holidays as weekend shifts and integrates them seamlessly into the schedule.
- **Monthly Shift Balance**: Distributes shifts across months, ensuring no one is overloaded in a single period.

## Installation

## Installation

### Prerequisites

- [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)
- No other dependencies required.

### Steps to Install

1. Clone the repository:

    ```bash
    git clone https://github.com/Beseri-Tech/OnCall-Shift-Assignment.git
    ```

2. Navigate to the project directory:

    ```bash
    cd OnCall-Shift-Assignment
    ```

3. Build the project in your IDE (e.g., Visual Studio) or using the .NET CLI:

    ```bash
    dotnet build
    ```

4. Run the program:

    ```bash
    dotnet run
    ```


### Steps to Install

1. Clone the repository:

    ```bash
    git clone https://github.com/Beseri-Tech/OnCall-Shift-Assignment.git
    ```

2. Navigate to the project directory:

    ```bash
    cd OnCall-Shift-Assignment
    ```

3. Build the project in your IDE (e.g., Visual Studio) or via the .NET CLI:

    ```bash
    dotnet build
    ```

4. Run the program:

    ```bash
    dotnet run
    ```

## Usage

1. Launch the application.
2. Select the dates or import staff and scheduling data from a JSON file.
3. Continue to the next page to:
   - Enter person details, leave dates, preferred work dates, and extra shifts.
   - Add public holidays.
4. Use the **Assign Shift** or **Reset Shift** functions to generate or adjust the schedule.
5. Download the timetable in Excel format.
6. Export data to JSON for future use.
7. You can also update the dates and reassign shifts as needed.


## Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature:

    ```bash
    git checkout -b feature/your-feature
    ```

3. Make your changes and commit them:

    ```bash
    git commit -m "Add feature description"
    ```

4. Push to your branch:

    ```bash
    git push origin feature/your-feature
    ```

5. Open a pull request for your changes.

## License

This project is licensed under the [AGPL-3.0 License](LICENSE.txt).

---
