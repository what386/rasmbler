namespace Assembler.Operands;
using Assembler.Utilities;

public class Address : Operand
{
    public int value { get; private set; }

    public Address(string name, int length) :base(name, "Address", length) 
    {
        value = BaseConverter.ToDecimal(ExtractBracketValue(name));
    }

    public override string Parse()
    {
        return BaseConverter.ToBinary(value, length);
    }

    public static string ExtractBracketValue(string operand)
    {
        return operand.Substring(1, operand.Length - 2);
    }
}
