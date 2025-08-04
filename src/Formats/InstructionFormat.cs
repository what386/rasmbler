namespace Assembler.Formats;

public struct InstructionFormat 
{
    public string opcode { get; private set; }
    public string[] operandTypes { get; private set; }
    

    public InstructionFormat(string opcode, string[] operandTypes)
    {
        this.opcode = opcode;
        this.operandTypes = operandTypes;
    }
}
