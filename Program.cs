using System;

class RomanToArabicConverter
{
    static void Main()
    {
        Console.WriteLine("Enter Roman numerals to convert to Arabic (press Enter with an empty line to exit):");

        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine().ToUpper();

            if (string.IsNullOrWhiteSpace(input))
            {
                break; // Exit the program if an empty line is entered
            }

            int arabicEquivalent = ConvertRomanToArabic(input);

            if (arabicEquivalent != -1)
            {
                Console.WriteLine($"Arabic equivalent: {arabicEquivalent}");
            }
        }
    }

    static int ConvertRomanToArabic(string romanNumeral)
    {
        int result = 0;
        int prevValue = 0;
        bool previousWasSubtraction = false;

        for (int i = romanNumeral.Length - 1; i >= 0; i--)
        {
            char currentSymbol = romanNumeral[i];
            int currentValue = RomanToArabicValue(currentSymbol);

            if (currentValue == -1)
            {
                Console.WriteLine("Invalid character in input. Valid characters are I, V, X, L, C, D, M.");
                return -1;
            }

            if (currentValue < prevValue)
            {
                if (previousWasSubtraction)
                {
                    Console.WriteLine("Invalid numeral: two consecutive subtractions.");
                    return -1;
                }

                if (IsSubtractionValid(currentSymbol, prevValue))
                {
                    result -= currentValue;
                    previousWasSubtraction = true;
                }
                else
                {
                    Console.WriteLine("Invalid numeral: can't subtract auxiliary symbol.");
                    return -1;
                }
            }
            else
            {
                if (currentValue > prevValue && prevValue != 0)
                {
                    Console.WriteLine("Invalid numeral: additions don't decrease.");
                    return -1;
                }

                result += currentValue;
                previousWasSubtraction = false;
            }

            prevValue = previousWasSubtraction ? 0 : currentValue;
        }

        return result;
    }


    static int RomanToArabicValue(char romanSymbol)
    {
        switch (romanSymbol)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return -1;
        }
    }

    static bool IsSubtractionValid(char currentSymbol, int prevValue)
    {
        if (currentSymbol == 'I')
        {
            return prevValue - RomanToArabicValue(currentSymbol) >= 0;
        }
        else if (currentSymbol == 'X')
        {
            return prevValue - RomanToArabicValue(currentSymbol) >= 0;
        }
        else if (currentSymbol == 'C')
        {
            return prevValue - RomanToArabicValue(currentSymbol) >= 0;
        }
        else if (currentSymbol == 'M')
        {
            return prevValue - RomanToArabicValue(currentSymbol) >= 0;
        }
        else if (currentSymbol == 'V' || currentSymbol == 'L' || currentSymbol == 'D')
        {
            return true; // Allow subtraction for auxiliary symbols (V, L, D)
        }

        return false;
    }
}
