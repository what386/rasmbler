namespace Assembler.Operands;
using Assembler.Utilities;

public class Character : Operand
{
    public int value { get; private set; }

    public Character(string name) :base(name, "Character", 8) 
    {
        value = BaseConverter.ToDecimal(ExtractValue(name));
    }

    public override string Parse()
    {
        return BaseConverter.ToBinary(value, length);
    }

    public static string ExtractValue(string operand)
    {
        // need to implement a character table
        return operand.Substring(1, operand.Length - 2);
    }
}
