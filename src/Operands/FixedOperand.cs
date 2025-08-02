namespace Assembler.Operands;
using Assembler.Utilities;

public class FixedOperand : Operand
{
    public string binary { get; private set; }

    public FixedOperand(string name, int length) : base(name)
    {
        type = "Fixed";
        this.length = name.Length;
        binary = name; 
    }

    public override string Parse()
    {
        return binary;
    }
}
