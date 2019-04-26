using System;
using System.Collections.Generic;

namespace NumToWord.Models
{
  public class Number
  {
    private static Dictionary<int, string> numberWords = new Dictionary<int, string>()
    {
    {0, "".Trim()},
    {1, "one"},
    {2, "two"},
    {3, "three"},
    {4, "four"},
    {5, "five"},
    {6, "six"},
    {7, "seven"},
    {8, "eight"},
    {9, "nine"},
    {10, "ten"},
    {11, "eleven"},
    {12, "twelve"},
    {13, "thirteen"},
    {14, "fourteen"},
    {15, "fifteen"},
    {16, "sixteen"},
    {17, "seventeen"},
    {18, "eighteen"},
    {19, "nineteen"},
    {20, "twenty"},
    {30, "thirty"},
    {40, "fourty"},
    {50, "fifty"},
    {60, "sixty"},
    {70, "seventy"},
    {80, "eighty"},
    {90, "ninety"}
  };



  public string ReverseNumber (int number)
  {
    string numberString = number.ToString();
    char[] numberStringArray = numberString.ToCharArray();
    Array.Reverse(numberStringArray);
    return new string(numberStringArray);
  }

  public string ConvertTripleDigit (int number)
  {
    string reversedNumberString = ReverseNumber(number);
    int numberLength = reversedNumberString.Length;
    string finalWords = "";
    if (numberLength == 3) {
      int hundreds = int.Parse(reversedNumberString[2].ToString());
      finalWords += (numberWords[hundreds] + " hundred ");
    }
    if (numberLength >= 2) {
      int tens = int.Parse(reversedNumberString[1].ToString());
      // if (tens == 1) {
      //   string teenNumber = numberString.Substring(1,2);
      //   finalWords += numberWord[teenNumber];
      // } else {
        finalWords += (numberWords[tens*10] + " ");
      // }
    }
    if (numberLength >= 1) {
      int ones = int.Parse(reversedNumberString[0].ToString());
      finalWords += numberWords[ones];
    }
    finalWords = finalWords.Trim();
    return finalWords;
  }


  // public string ConvertDoubleDigit (int number)
  // {
  //   if (numberString[0] == '1') {
  //     return numberWords[number];
  //   }
  //   else
  //   {
  //     (numberString[0]*10)
  //   }
  //   return numberWords[number];
  // }

  // public string NumberToWord (int number)
  // {
  //   string numberString = number.ToString();
  //   int stringLength = numberString.Length;
  //   if (stringLength == 1){
  //     return numberWords[number];
  //   }
  //   else if (stringLength == 2) {
  //     if (numberString[0] == '1') {
  //       return numberWords[number];
  //     }
  //     else
  //     {
  //       string result = numberWords[int.Parse(numberString[0].ToString())*10] + " " + numberWords[int.Parse(numberString[1].ToString())];
  //       return result.Trim();
  //     }
  //   }
  //   else if (stringLength == 3) {
  //     if (numberString[1] == '1') {
  //       string teenNumber = numberString.Substring(1,2);
  //       string result = numberWords[int.Parse(numberString[0].ToString())] + " hundred " + numberWords[int.Parse(teenNumber)];
  //       return result.Trim();
  //     }
  //     else
  //     {
  //       string result = numberWords[int.Parse(numberString[0].ToString())] + " hundred " + numberWords[int.Parse(numberString[1].ToString())*10] + " " + numberWords[int.Parse(numberString[2].ToString())];
  //       return result.Trim();
  //     }
  //   }
  //   else
  //   {
  //     return ("Number is more than 3 digits or less than 1 digit long");
  //   }
  // }
  }
}
