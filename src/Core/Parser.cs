namespace Assembler.Core;

using Assembler.Operands;
using Assembler.Formats;
using Assembler.Exceptions;

public class Parser 
{

    public void ParseLine(string line)
    {
        var (mnemonic, operands) = GetInstruction(line);

        string binary = Formats.InstructionFormats[mnemonic].opcode;
        
        foreach(Operand operand in operands)
        {
            binary += operand.Parse();
        }
    }

    
    public (string, List<Operand>) GetInstruction(string line)
    {
        List<Operand> operandList = new List<Operand>();

        int index = line.IndexOf(' ');
        string mnemonic = line.Substring(0, index);
        string operandString = line.Substring(index + 1);

        InstructionFormat expectedFormat = Formats.InstructionFormats[mnemonic];

        Stack<string> operandFormats = new Stack<string>(expectedFormat.operandTypes.Reverse());
        Stack<string> operandNames = new Stack<string>(operandString.Split(',').Reverse());

        string machineCode = expectedFormat.opcode;

        for (int i = 0; i < operandFormats.Count; i++)
        {
            string operandFormat = operandFormats.Pop();
            
            if(Lexer.IsImplicitOperand(operandFormat))
            {
                operandList.Add(Lexer.GetImplicitOperand(operandFormat, mnemonic));
            }
            else
            {
                string operandName = operandNames.Pop();
                operandList.Add(Lexer.GetOperand(operandName, operandFormat, mnemonic));
            }
        }

        return (mnemonic, operandList);
    }

    public (InstructionFormat, string) GetInstructionInformation(string mnemonic)
    {
        string baseMnemonic = Formats.MnemonicAliases.GetValueOrDefault(mnemonic, mnemonic); 

        if (Formats.InstructionFormats.TryGetValue(baseMnemonic, out InstructionFormat format))
        {
            string typeBits = Formats.InstructionTypes.GetValueOrDefault(mnemonic, "");
            return (format, typeBits);
        }

        throw new ParserException($"Mnemonic '{mnemonic}' not found in instruction formats");
    }
}
