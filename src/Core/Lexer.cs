namespace Assembler.Core;

using Assembler.Operands;
using Assembler.Exceptions;

public static class Lexer
{

    public static bool ValidateOperand(Operand operand, string operandType, int operandLength)
    {
        if(operand.type != operandType || operand.length != operandLength)
            return false;

        return true;
    }

    public static Operand GetOperand(string operand)
    {
        int length = 1;

        if(operand.StartsWith('r'))
            return new Register(operand);

        if(operand.StartsWith('#'))
            return new Immediate(operand, length);

        if(operand.StartsWith('[') && operand.EndsWith(']'))
            return new Address(operand, length);

        if(operand.StartsWith('\'') && operand.EndsWith('\''))
            return new Character(operand);


        throw new ParserException("Operand '" + operand + "' is unimplemented.");
    }
}
