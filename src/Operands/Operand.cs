namespace Assembler.Operands;

public abstract class Operand
{
    public string name { get; private set; }
    public string type { get; protected set; }
    public int length { get; protected set; }
    
    public Operand(string name, string type, int length)
    {
        this.name = name;
        this.type = type;
        this.length = length;
    }
    
    public abstract string Parse();
}
