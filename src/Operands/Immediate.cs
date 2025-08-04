namespace Assembler.Operands;
using Assembler.Utilities;

public class Immediate : Operand
{
    public int value { get; private set; }

    public Immediate(string name, int length) :base(name, "Immediate", length) 
    {
        value = BaseConverter.ToDecimal(name.Split('#')[1]);
    }

    public override string Parse()
    {
        return BaseConverter.ToBinary(value, length);
    }
}
