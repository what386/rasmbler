namespace Assembler.Operands;
using Assembler.Utilities;

public class AliasedOperand : Operand
{
    public string binary { get; private set; }

    public AliasedOperand(string name, int length) : base(name)
    {
        type = "Alias";
        this.length = length;
        // get value from table
    }

    public override string Parse()
    {
        return binary;
    }
}
