using System;

namespace CharToAsciiToChar
{
    class CharToAsciiToChar
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            int asciiFromLetter = CharToAscii(letter);
            Console.WriteLine($"ASCII code of letter {letter} is {asciiFromLetter}");

            int ascii = 99;
            char charFromAscii = AsciiToChar(ascii);
            Console.WriteLine($"The char from the input ASCII code {ascii} is '{charFromAscii}'");
        }

        static int CharToAscii(char theChar)
        {
            int theAsciiCode = theChar;
            return theAsciiCode;
        }

        static char AsciiToChar(int theAscii)
        {
            char asciiToChar = (char)theAscii;
            return asciiToChar;
        }
    }
}
