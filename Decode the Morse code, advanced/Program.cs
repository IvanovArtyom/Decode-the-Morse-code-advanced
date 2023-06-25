using System;
using System.Text;
using MorseCodeTable;

public class MorseCodeDecoder
{
    public static void Main()
    {
        // Tests
        var t1 = DecodeBits("1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011");
        // ...should return "···· · −·−−   ·−−− ··− −·· ·"
        var t2 = DecodeMorse(t1);
        // ...should return "HEY JUDE"
    }

    public static string DecodeBits(string bits)
    {
        bits = bits.Trim('0');
        int step = DefineTimeUnit(bits);
        StringBuilder result = new();

        for (int i = 0; i < bits.Length; i ++)
        {
            int j = i;

            while (j < bits.Length && bits[j] == bits[i])
                j++;

            int length = (j - i) / step;

            if (bits[i] == '1' && length == 1)
                result.Append('.');

            else if (bits[i] == '1' && length == 3)
                result.Append('-');

            else if (bits[i] == '0' && length == 3)
                result.Append(' ');

            else if (bits[i] == '0' && length == 7)
                result.Append("   ");

            i = j - 1;
        }

        return result.ToString();
    }

    public static string DecodeMorse(string morseCode)
    {
        StringBuilder result = new();
        string[] words = morseCode.Split("   ");

        foreach (string word in words)
        {
            string[] letters = word.Split();

            foreach (string letter in letters)
            {
                result.Append(MorseCode.Get(letter));
            }

            result.Append(' ');
        }

        return result.ToString().TrimEnd();
    }

    public static int DefineTimeUnit(string bits)
    {
        int minLength = bits.Length;
        int maxLength = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            int j = i;

            while (j < bits.Length && bits[j] == bits[i])
                j++;

            minLength = Math.Min(minLength, j - i);
            maxLength = Math.Max(maxLength, j - i);
            i = j - 1;
        }

        return (maxLength / minLength == 7 / 3) ? minLength / 3 : minLength;
    }
}