namespace Assembler.Operands;
using Assembler.Formats;

public class InstType : Operand 
{
    public string binary{ get; private set; }

    public InstType(string mnemonic) :base("InstType", "InstType", 0, mnemonic)
    {
        binary = Formats.InstructionTypes[mnemonic];
    }

    public override string Parse()
    {
        return binary;
    }
}
