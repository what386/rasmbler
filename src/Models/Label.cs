namespace Assembler.Models;

public class Label{
    public string value { get; private set; }
    public int line { get; private set; }

    public Label(string value, int lineNumber)
    {
        this.value = value;
        this.line = lineNumber;
    }
}
