namespace Assembler.Models;

using Assembler.Operands;

public class Instruction
{
    public string Opcode { get; private set; }
    public string BaseOpcode { get; private set; }
    public List<Operand> Operands { get; private set; }
    public string TypeBits { get; private set; }

    public Instruction()
    {
    }
}
