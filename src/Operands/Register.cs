namespace Assembler.Operands;
using Assembler.Utilities;

public class Register : Operand
{
    public int index { get; private set; }

    public Register(string name) : base(name)
    {
        type = "Register";
        length = 3;
        index = Convert.ToInt32(name[1..]);
    }

    public override string Parse()
    {
        return BaseConverter.ToBinary(index, length);
    }
}
