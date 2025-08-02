using Assembler.Exceptions;

namespace Assembler.Utilities
{
    public static class BaseConverter 
    {
        public static int ToDecimal(string number)
        {
            if (number.StartsWith("0b")) return Convert.ToInt32(number[2..], 2);
            if (number.StartsWith("0x")) return Convert.ToInt32(number[2..], 16);
            if (number.StartsWith("0o")) return Convert.ToInt32(number[2..], 8);
            if (number.StartsWith("0d")) return Convert.ToInt32(number[2..], 10);
            return Convert.ToInt32(number); // base case- assume num is decimal
        }

        public static string ToBinary(int number, int length)
        {
            if (number < 0) number = (int)(Math.Pow(2, length) + number);
            string result = Convert.ToString(number, 2);
            if (result.Length > length)
                throw new AssemblyException($"Number too large for {length} bits: {number}");
            return result.PadLeft(length, '0');
        }
    }
}
