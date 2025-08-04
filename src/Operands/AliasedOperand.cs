namespace Assembler.Operands;

public class AliasedOperand : Operand
{
    public string binary { get; private set; }

    public AliasedOperand(string name, int length) :base(name, "Alias", length) 
    {
        binary = "00000000";
        // get value from table that doesnt exist yet
    }

    public override string Parse()
    {
        return binary;
    }
}
