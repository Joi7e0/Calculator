# Calculator
![CalculatorLogo-50%](https://github.com/user-attachments/assets/6e0401fa-7185-4b78-9494-08e2f298588f)

## Overview

The Calculator is a simple yet functional WPF-based application designed to perform basic arithmetic operations. It supports addition, subtraction, multiplication, division, and percentage calculations. The application ensures user-friendly interaction and handles common edge cases such as division by zero and invalid input formats.

## Features

- Basic arithmetic operations: addition, subtraction, multiplication, and division.
- Percentage calculations.
- Clear (AC) and Delete (DEL) functions.
- Handles both integer and floating-point numbers.
- Input length limitation to prevent overflow errors.
- Error handling for invalid expressions.

## Usage

Clone the repository and open the project in Visual Studio. Build and run the application to start using the calculator.

![Sample application](https://github.com/user-attachments/assets/6fb8e480-403f-46df-9d27-a55cee75b99c)

## Code Structure

- **MainWindow.xaml**: Defines the UI layout using XAML.
- **MainWindow.xaml.cs**: Contains the logic for handling button clicks and performing calculations.

### MainWindow.xaml

Defines the layout of the calculator, including the display and buttons for digits and operations.

### MainWindow.xaml.cs

Handles the logic for each button click, including:
- Adding digits to the display.
- Performing calculations when the "=" button is clicked.
- Clearing the display with "AC" and deleting the last digit with "DEL".
- Handling percentages by converting values appropriately.
- Ensuring the input does not exceed a set maximum length.

## Future Enhancements

- Add support for advanced mathematical functions (e.g., square root, exponentiation).
- Implement memory functions (M+, M-, MR).
- Improve UI design for better user experience.

## Contributing

Contributions are welcome! Please fork the repository and submit pull requests for any enhancements or bug fixes.

## License

This project is licensed under the MIT License.
