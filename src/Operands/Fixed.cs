namespace Assembler.Operands;
using Assembler.Formats;

public class Fixed : Operand 
{
    public string binary{ get; private set; }

    public Fixed(string mnemonic, name) :base(name, "Fixed", 0, mnemonic)
    {
    }

    public override string Parse()
    {
        return binary;
    }
}
