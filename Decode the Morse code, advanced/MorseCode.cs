﻿using System.Collections.Generic;

namespace MorseCodeTable
{
    internal static class MorseCode
    {
        static readonly Dictionary<string, char> morseTable = new() { { ".-", 'A' }, { "-...", 'B' }, { "-.-.", 'C' }, { "-..", 'D' }, { ".", 'E' },
            { "..-.", 'F' }, { "--.", 'G' }, { "....", 'H' }, { "..", 'I' }, { ".---", 'J' }, { "-.-", 'K' }, { ".-..", 'L' },
            { "--", 'M' }, { "-.", 'N' }, { "---", 'O' }, { ".--.", 'P' }, { "--.-", 'Q' }, { ".-.", 'R' }, { "...", 'S' }, { "-", 'T' },
            { "..-", 'U' }, { "...-", 'V' }, { ".--", 'W' }, { "-..-", 'X' }, { "-.--", 'Y' }, { "--..", 'Z' }, { "---.", 'Ö' },
            { "----", 'Ĥ' }, { "--.--", 'Ñ' }, { "..-..", 'É' }, { "..--", 'Ü' }, { ".-.-", 'Ä' }, { "-----", '0' }, { ".----", '1' },
            { "..---", '2' }, { "...--", '3' }, { "....-", '4' }, { ".....", '5' }, { "-....", '6' }, { "--...", '7' }, { "---..", '8' },
            { "----.", '9' }, { ".-.-.-", '.' }, { "--..--", ',' }, { "..--..", '?' }, { ".----.", '\'' }, { "-.-.--", '!' },
            { "-..-.", '/' }, { "-.--.", '(' }, { "-.--.-", ')' }, { ".-...", '&' }, { "---...", ':' }, { "-.-.-.", ';' },
            { "-...-", '=' }, { ".-.-.", '+' }, { "-....-", '-' }, { "..--.-", '_' }, { ".-..-.", '"' }, { "...-..-", '$' },
            { ".--.-.", '@' }, { "..-.-", '¿' }, { "--...-", '¡' } };

        public static char Get(string code)
        {
            return morseTable.ContainsKey(code) ? morseTable[code] : '\0';
        }
    }
}