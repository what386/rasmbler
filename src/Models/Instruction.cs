namespace Assembler.Models;

using Assembler.Operands;

public struct Instruction
{
    public string mnemonic { get; private set; }
    public string opcode { get; private set; }
    public List<Operand> operands { get; private set; }
    public string typeBits { get; private set; }

    public Instruction(string mnemonic, List<Operand> operands)
    {
        this.mnemonic = mnemonic;
        this.operands = operands;

        opcode = mnemonic;
        typeBits = mnemonic;
    }
}
