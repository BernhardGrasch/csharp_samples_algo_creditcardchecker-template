using System;

namespace CreditCardChecker
{
    public class CreditCardChecker
    {
        /// <summary>
        /// Diese Methode überprüft eine Kreditkartenummer, ob diese gültig ist.
        /// Regeln entsprechend der Angabe.
        /// </summary>
        public static bool IsCreditCardValid(string creditCardNumber)
        {
            bool isValid = false;
            int numberEven = 0, sumEven = 0;
            int numberOdd = 0, sumOdd = 0;
            int helper = 0;

            if (creditCardNumber.Length == 15)
            {
                for (int i = 0; i < creditCardNumber.Length; i++)
                {
                    if(i == 0 || i % 2 == 0)
                    {
                        helper = Convert.ToInt32(creditCardNumber[i]);
                        numberEven = helper * 2;
                        sumEven++;
                    }
                    else
                    {
                        helper = Convert.ToInt32(creditCardNumber[i]);
                        numberOdd += helper;
                        sumOdd++;
                    }
                }
            }
            //if(sumOdd >= CalculateCheckDigit(sumOdd, sumEven) &&
            //    sumOdd >= CalculateCheckDigit(sumOdd, sumEven))
            return isValid;
        }

        /// <summary>
        /// Berechnet aus der Summe der geraden Stellen (bereits verdoppelt) und
        /// der Summe der ungeraden Stellen die Checkziffer.
        /// </summary>
        private static int CalculateCheckDigit(int oddSum, int evenSum)
        {
            int checkNumber = 0;

            checkNumber = evenSum + CalculateDigitSum(oddSum);

            for (int i = 0; i <= 9; i++)
            {
                if (checkNumber % 10 == 0)
                {
                    checkNumber = 0;
                }
                else
                {
                    checkNumber += i;
                }
            }

            return checkNumber;
        }

        /// <summary>
        /// Berechnet die Ziffernsumme einer Zahl.
        /// </summary>
        private static int CalculateDigitSum(int number)
        {
            int numberSum = 0;
            int newNumber = 0;

            if (number >= 10)
            {
                while (number >= 10)
                {
                    newNumber = number % 10;
                    numberSum += newNumber;
                    number = number / 10;
                }
            }
            else
            {
                numberSum = number;
            }


            return numberSum;
        }

        private static int ConvertToInt(char ch)
        {
            throw new NotImplementedException();
        }
    }
}
