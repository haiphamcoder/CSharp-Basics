namespace Money
{
    public static class Utils
    {
        public static string NumberToText(decimal inputNumber, bool suffix = true)
        {
            string result = " ";
            string[] unitNumbers = {"không", "một", "hai", "ba", "bốn", "năm", "sáu",
                                    "bảy", "tám", "chín"};
            string[] placeValues = { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // 
            string inputNumberString = inputNumber.ToString("#");
            decimal number = Convert.ToDecimal(inputNumberString);
            if (number < 0)
            {
                number = -number;
                inputNumberString = number.ToString();
                isNegative = true;
            }

            int ones, tens, hundreds;
            int positionDigit = inputNumberString.Length;
            if (positionDigit == 0)
            {
                result = unitNumbers[0] + result;
            }
            else
            {
                int placeValueIndex = 0;
                while (positionDigit > 0)
                {
                    // Get 3 digits from right to left
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(inputNumberString.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(inputNumberString.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(inputNumberString.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValueIndex == 3))
                    {
                        result = placeValues[placeValueIndex] + result;
                    }

                    placeValueIndex++;

                    if (placeValueIndex > 3)
                    {
                        placeValueIndex = 1;
                    }

                    if ((ones == 1) && (tens > 1))
                    {
                        result = "mốt " + result;
                    }
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                        {
                            result = "lăm " + result;
                        }
                        else if (ones > 0)
                        {
                            result = unitNumbers[ones] + " " + result;
                        }
                    }

                    if (tens < 0)
                    {
                        break;
                    }
                    else
                    {
                        if ((tens == 0) && (ones > 0))
                        {
                            result = "lẻ " + result;
                        }
                        else if (tens == 1)
                        {
                            result = "mười " + result;
                        }
                        else if (tens > 1)
                        {
                            result = unitNumbers[tens] + " mươi " + result;
                        }
                    }

                    if (hundreds < 0)
                    {
                        break;
                    }
                    else if ((hundreds > 0) || (tens > 0) || (ones > 0))
                    {
                        result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative)
            {
                result = "âm " + result;
            }

            return result + (suffix ? " đồng chẵn" : "");
        }

    }
}