namespace Assembler.Core;

using Assembler.Operands;
using Assembler.Formats;
using Assembler.Exceptions;

public class Assembler
{

    public void ParseInstruction(string instruction)
    {
        string binary;

        var mnemonic, operandList = ParseLine(instruction);
        var instructionFormat, typeBits = GetInstructionInformation(mnemonic);

        binary = instructionFormat.opcode;

        for (int i = 0; i < operandList.Count; i++)
        {
            Operand operand = operandList[i]

            if(operand.type != instructionFormat.operandTypes[i])
            binary += operand.Parse();
        }
    }

    public (string, List<Operand>) ParseLine(string line)
    {
        List<Operand> operandList = new List<Operand>();

        int index = line.IndexOf(' ');
        string mnemonic = line.Substring(0, index);
        string operandString = line.Substring(index + 1);

        string[] operandNames = operandString.Split(',');

        foreach (var operandName in operandNames)
            operandList.Add(Lexer.GetOperand(operandName));



        return (mnemonic, operandList);
    }

    public (InstructionFormat, string) GetInstructionInformation(string mnemonic)
    {
        string baseMnemonic = Formats.MnemonicAliases.GetValueOrDefault(mnemonic, mnemonic); 

        if (Formats.InstructionFormats.TryGetValue(baseMnemonic, out InstructionFormat format))
        {
            string typeBits = Formats.InstTypes.GetValueOrDefault(mnemonic, "");
            return (format, typeBits);
        }

        throw new ParserException($"Mnemonic '{mnemonic}' not found in instruction formats");
    }
}
