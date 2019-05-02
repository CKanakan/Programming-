using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kanakan_Write_A_Number
{
    class WriteANumber
    {
        private String ones;
        private String tens;
        private String hundreds;
        private String thousands;


        public WriteANumber()// constructor
        {
            String userNumber;
            userNumber = showUserInput();
            showNumberInput(userNumber);
        }

        public String getUserInputOfSixDigits()
        {
            String userInput;

         
            userInput = JOptionPane.showInputDialog("input a six digit number");

            return userInput;
        }

        public String addDecimalPoint(String userInput)
        {
            // This adds a decimal point the UserInput
            // this adds a decimal point
            char[] arrayOfChar;
            arrayOfChar = null;

            String decimalPoint = ".";

            arrayOfChar = userInput.ToCharArray();

            for (int z = 0; z < arrayOfChar.Length; z++)
            {
                if (userInput.Contains(decimalPoint))
                {
                    decimalPoint = "Point";
                }
            }
            return arrayOfChar.ToString();
        }

        public String AddZerosToTheLeft(String userInput, char[] arrayOfChar)
        {
            // Adds Zeros to the left of the number inputted
            // to get it to six digits
            for (int z = 0; z < arrayOfChar.Length; z++)
            {
                if (userInput.Contains(null))
                {
                    userInput = "0";
                }
            }
            return userInput;
        }

        public double convertUserInputIntoADouble(String userInput)
        {
            // This converts the user input to an int

            double userInputConvertedToADouble;

            userInputConvertedToADouble = Double.Parse(userInput);

            return userInputConvertedToADouble;
        }

        public bool thereIsADecimalInTheUserInput(String userInput, String decimalPoint)
        {
            // This checks to see if the input has a decimal point
            bool thereIsADecimal = false;

            if (userInput.Contains(decimalPoint))
            {
                decimalPoint = "Point";

                return thereIsADecimal = true;
            }

            return thereIsADecimal;
        }

        public bool theUserInputHasSixDigits(char[] arrayOfChar)
        {
            // This checks to see if there is six digits
            bool inputHasSixDigits = false;

            if (arrayOfChar.Length == 6)
            {
                inputHasSixDigits = true;
            }

            return inputHasSixDigits;
        }

        public String checksTheThousands(char[] arrayOfChar)
        {
            // it takes the left three number
            // gives values based on the number in each place

            int[] thousands = null;

            switch (thousands[0])

            {
                case '0':
                    break;
                case '1':
                    return "one hundred";
                case '2':
                    return "two hundred";
                case '3':
                    return "three hundred";
                case '4':
                    return "four hundred";
                case '5':
                    return "five hundred";
                case '6':
                    return "six hundred";
                case '7':
                    return "seven hundred";
                case '8':
                    return " eight hundred";
                case '9':
                    return "nine hundred";
            }

            switch (thousands[1])
            {
                case '0':
                    break;
                case '1':
                    return "ten";
                case '2':
                    return "twenty";
                case '3':
                    return "thrity";
                case '4':
                    return "Fourty";
                case '5':
                    return "Fifty ";
                case '6':
                    return "Sixty ";
                case '7':
                    return "Seventy ";
                case '8':
                    return " Eight";
                case '9':
                    return "Ninety ";
            }

            switch (thousands[2])
            {
                case '0':
                    break;
                case '1':
                    return "one thousand";
                case '2':
                    return "two thousand";
                case '3':
                    return "three thousand";
                case '4':
                    return "Four thousand";
                case '5':
                    return "Five thousand";
                case '6':
                    return "Six thousand";
                case '7':
                    return "Seven thousand";
                case '8':
                    return "Eight thousand";
                case '9':
                    return "Nine thousand";
            }
            return null;
        }

        public String checksTheHundreds(char[] arrayOfChar, int[] ones)
        {
            // it takes the right three number
            // gives values based on the number in each place

            int[] hundreds = null;

            switch (hundreds[3])

            {
                case '0':
                    break;
                case '1':
                    return "one hundred";
                case '2':
                    return "two hundred";
                case '3':
                    return "three hundred";
                case '4':
                    return "Four hundred";
                case '5':
                    return "Five hundred";
                case '6':
                    return "Six hundred";
                case '7':
                    return "Seven hundred";
                case '8':
                    return "Eight hundred";
                case '9':
                    return "Nine hundred";
            }

            switch (hundreds[4])
            {
                case '0':
                    break;
                case '1':
                    return "ten";
                case '2':
                    return "twenty";
                case '3':
                    return "thrity";
                case '4':
                    return "Fourty";
                case '5':
                    return "Fifty";
                case '6':
                    return "Sixty";
                case '7':
                    return "Seventy";
                case '8':
                    return "Eighty";
                case '9':
                    return "Ninety";
            }

            switch (hundreds[5])
            {
                case '0':
                    break;
                case '1':
                    return "one ";
                case '2':
                    return "two ";
                case '3':
                    return "three";
                case '4':
                    return "Four";
                case '5':
                    return "Five ";
                case '6':
                    return "Six";
                case '7':
                    return "Seven";
                case '8':
                    return "Eight";
                case '9':
                    return "Nine";
            }
            return null;
        }

        public String checksTheTens(char[] arrayOfChar, int[] hundreds, int[] thousands)
        {
            int[] tens = null;

            if (thousands[1] == 1)
            {
                arrayOfChar[1] == tens[1];
            }

            switch (tens[1])
            {
                case '0':
                    break;
                case '1':
                    return "eleven";
                case '2':
                    return "twelve";
                case '3':
                    return "thriteen";
                case '4':
                    return "fourteen";
                case '5':
                    return "fifteen";
                case '6':
                    return "sixteen";
                case '7':
                    return "Seventeen";
                case '8':
                    return "Eighteen";
                case '9':
                    return "Nineteen";
            }

            if (thousands[1] == 1)
            {
               arrayOfChar[1] == tens[4];
            }

            switch (ones[4])

            {
                case '0':
                    break;
                case '1':
                    return "one ";
                case '2':
                    return "two ";
                case '3':
                    return "three";
                case '4':
                    return "Four";
                case '5':
                    return "Five ";
                case '6':
                    return "Six";
                case '7':
                    return "Seven";
                case '8':
                    return "Eight";
                case '9':
                    return "Nine";

            }
            return null;
        }

        public String showUserInput(char[] arrayOfChar)
        {
            return arrayOfChar.ToString();
        }
    }
}

