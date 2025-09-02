namespace Assembler.Core;

using Assembler.Operands;
using Assembler.Exceptions;
using Assembler.Formats;

public static class Lexer
{

    public static bool OperandMatchesFormat(Operand operand, string format)
    {
        if(format.StartsWith(operand.type))
            return true;

        return false;
    }

    public static Operand GetImplicitOperand(string name, string mnemonic)
    {
        
        if(name.Equals("InstType"))
            outputOperand = new InstType(mnemonic)
        else if(name.StartsWith("0b"))
            outputOperand = new Fixed(mnemonic, name)


        Operand outputOperand = null;
        int length = GetExpectedLength(format); 
        
        if(name.StartsWith('r'))
                
        if (outputOperand == null)
            throw new ParserException($"Invalid implicit operand '{name}' for '{mnemonic}'");
        
        if (OperandMatchesFormat(outputOperand, format))
            return outputOperand;
        
        throw new ParserException($"Implicit operand '{name}' not found.");

    }

    public static bool IsImplicitOperand(string format)
    {
        if(format.Equals("InstType") || format.StartsWith("0b"))
            return true;

        return false;
    }

    public static int GetExpectedLength(string format)
    {
        if(format.Equals("Register"))
            return 3;

        if(format.Equals("Character"))
            return 8;

        if(format.StartsWith("Immediate_"))
            return Convert.ToInt32(format.Split("_")[1]);

        throw new ParserException($"Invalid format '{format}'");
    }

    public static Operand GetOperand(string name, string format, string instruction)
    {
        Operand outputOperand = null;
        int length = GetExpectedLength(format); 
        
        if(name.StartsWith('r'))
            outputOperand = new Register(name, length, instruction);
        else if(name.StartsWith('#'))
            outputOperand = new Immediate(name, length, instruction);
        else if(name.StartsWith('[') && name.EndsWith(']'))
            outputOperand = new Address(name, length, instruction);
        else if(name.StartsWith('\'') && name.EndsWith('\''))
            outputOperand = new Character(name, length, instruction);
        
        if (outputOperand == null)
            throw new ParserException($"Unrecognized operand for '{name}'.");
        
        if (OperandMatchesFormat(outputOperand, format))
            return outputOperand;
        
        throw new ParserException($"Operand '{name}' is invalid.");
    } 




}
