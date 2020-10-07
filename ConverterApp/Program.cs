using ConverterApp.Models;
using System;
using System.Linq;

namespace ConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter Text
            string text = Console.ReadLine();

            //Binary Value
            string binaryValue = Converter.StringToBinary(text);
            Console.WriteLine($"String entered is: {text}\nConverted to Binary: {binaryValue}");

            string textFromBinary = Converter.BinaryToString(binaryValue);
            Console.WriteLine($"Taking binary Value as input and converted Text: {textFromBinary}");

            //HexaDecimal Value
            string hexaValue = Converter.StringToHex2(text);
            Console.WriteLine($"String entered is: {text}\nConverted to HexaDecimal: {hexaValue}");

            string textFromHexa = Converter.HexToString(hexaValue);
            Console.WriteLine($"Taking HexaDecimal Value as input and converted Text: {textFromHexa}");

            //Base64 Value
            string baseValue = Converter.StringToBase64(text);
            Console.WriteLine($"String entered is: {text}\nConverted to Base64 Value: {baseValue}");

            string textFromBase = Converter.Base64ToString(baseValue);
            Console.WriteLine($"Taking BASE64 Value as input and converted Text: {textFromBase}");

            //Deep Encrytion

            int[] cipher = new[] { 1, 1, 2, 3, 5, 8, 13 }; //Fibonacci Sequence
            string cipherasString = String.Join(",", cipher.Select(x => x.ToString())); //FOr display

            int encryptionDepth = 20;

            string nameDeepEncryptWithCipher = Converter.DeepEncryptWithCipher(text, cipher, encryptionDepth);
            Console.WriteLine($"Deep Encrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepEncryptWithCipher}");

            string nameDeepDecryptWithCipher = Converter.DeepDecryptWithCipher(nameDeepEncryptWithCipher, cipher, encryptionDepth);
            Console.WriteLine($"Deep Decrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepDecryptWithCipher}");
        }
    }
}
