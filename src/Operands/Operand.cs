namespace Assembler.Operands;

public abstract class Operand
{
    public string name { get; private set; }
    public string type { get; protected set; }
    public int length { get; protected set; }
    public string mnemonic { get; protected set; }
    
    public Operand(string name, string type, int length, string mnemonic)
    {
        this.name = name;
        this.type = type;
        this.length = length;
        this.mnemonic = mnemonic;
    }
    
    public abstract string Parse();
}
