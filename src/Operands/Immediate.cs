namespace Assembler.Operands;
using Assembler.Utilities;

public class Immediate : Operand
{
    public int value { get; private set; }

    public Immediate(string name, int length) : base(name)
    {
        type = "Immdiate";
        this.length = length;
        value = BaseConverter.ToDecimal(name);
    }

    public override string Parse()
    {
        return BaseConverter.ToBinary(value, length);
    }
}
