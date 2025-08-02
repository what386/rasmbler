namespace Assembler.Operands;

public abstract class Operand
{

    public string name { get; private set; }
    public required string type;
    public required int length;

    public Operand(string name)
    {
        this.name = name;
    }

    public abstract string Parse();
}

