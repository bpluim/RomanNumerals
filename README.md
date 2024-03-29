# Roman to Arabic Converter

This C# program converts Roman numerals to their Arabic equivalent. Simply enter Roman numerals when prompted, and the program will display the corresponding Arabic values.

## How to Use

1. Clone the repository to your local machine:

```
git clone https://github.com/bpluim/RomanNumerals.git
```

2. Open the project in your preferred C# development environment (e.g., Visual Studio, Visual Studio Code).

3. Run the program, and enter Roman numerals when prompted. Press Enter with an empty line to exit.

# Valid Input

The program accepts Roman numerals as input. Valid Roman numerals include:

I (1)
V (5)
X (10)
L (50)
C (100)
D (500)
M (1000)

# Error Handling
The program includes error handling to ensure valid input. If an error occurs, an error message will be displayed.

1. Invalid Character in Input:

Message: "Invalid character in input. Valid characters are I, V, X, L, C, D, M."

2. Two Consecutive Subtractions:

Message: "Invalid numeral: two consecutive subtractions."

3. Can't Subtract Auxiliary Symbol:

Message: "Invalid numeral: can't subtract auxiliary symbol."

4. Additions Don't Decrease:

Message: "Invalid numeral: additions don't decrease."

Feel free to contribute or report issues if you encounter any problems!