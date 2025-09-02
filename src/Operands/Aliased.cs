namespace Assembler.Operands;

public class Aliased : Operand
{
    public string binary { get; private set; }

    public Aliased(string name, int length, string mnemonic) :base(name, "Alias", length, mnemonic) 
    {
        this.mnemonic = mnemonic;
        binary = "00000000";
        // get value from table that doesnt exist yet
    }

    public override string Parse()
    {
        return binary;
    }
}
