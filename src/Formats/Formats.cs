namespace Assembler.Formats;

public class Formats
{
    public static readonly Dictionary<string, InstructionFormat> InstructionFormats = new()
    {
        {"nop", new InstructionFormat("00000", new[] {"0b00000000000"})},
        {"hlt", new InstructionFormat("00001", new[] {"0b00", "InstType", "0b00000000"})},
        {"sys", new InstructionFormat("00010", new[] {"Operand", "Immediate_8"})},
        {"cli", new InstructionFormat("00011", new[] {"Register", "Operand", "Immediate_5"})},
        {"jmp", new InstructionFormat("00100", new[] {"Immediate_11"})},
        {"bra", new InstructionFormat("00101", new[] {"Operand", "InstType", "Immediate_6"})},
        {"cal", new InstructionFormat("00110", new[] {"Immediate_11"})},
        {"ret", new InstructionFormat("00111", new[] {"0b00", "InstType", "0b00000000"})},
        {"inp", new InstructionFormat("01000", new[] {"Register", "Immediate_8"})},
        {"out", new InstructionFormat("01001", new[] {"Register", "Immediate_8"})},
        {"sld", new InstructionFormat("01010", new[] {"Register", "0b00000", "Operand"})},
        {"sst", new InstructionFormat("01011", new[] {"Register", "0b00000", "Operand"})},
        {"pop", new InstructionFormat("01100", new[] {"Register", "InstType", "Immediate_6"})},
        {"psh", new InstructionFormat("01101", new[] {"Register", "InstType", "Immediate_6"})},
        {"mld", new InstructionFormat("01110", new[] {"Register", "Immediate_8"})},
        {"mst", new InstructionFormat("01111", new[] {"Register", "Immediate_8"})},
        {"ldi", new InstructionFormat("10000", new[] {"Register", "Immediate_8"})},
        {"mov", new InstructionFormat("10001", new[] {"Register", "Register", "0b00000"})},
        {"adi", new InstructionFormat("10010", new[] {"Register", "Register", "Immediate_5"})},
        {"ani", new InstructionFormat("10011", new[] {"Register", "Immediate_8"})},
        {"cpi", new InstructionFormat("10100", new[] {"Register", "Immediate_8"})},
        {"cai", new InstructionFormat("10101", new[] {"Register", "Immediate_8"})},
        {"add", new InstructionFormat("10110", new[] {"Register", "Register", "InstType", "Register"})},
        {"sub", new InstructionFormat("10111", new[] {"Register", "Register", "InstType", "Register"})},
        {"bit", new InstructionFormat("11000", new[] {"Register", "Register", "InstType", "Register"})},
        {"bnt", new InstructionFormat("11001", new[] {"Register", "Register", "InstType", "Register"})},
        {"bsh", new InstructionFormat("11010", new[] {"Register", "Register", "InstType", "Register"})},
        {"bsi", new InstructionFormat("11011", new[] {"Register", "Register", "InstType", "Register"})},
        {"mul", new InstructionFormat("11100", new[] {"Register", "Register", "InstType", "Register"})},
        {"btc", new InstructionFormat("11101", new[] {"Register", "Register", "InstType", "Immediate_3"})},
        {"opi", new InstructionFormat("11110", new[] {"Immediate_3", "Immediate_8"})},
        {"cpc", new InstructionFormat("11111", new[] {"InstType", "Immediate_10"})}
    };

    public static readonly Dictionary<string, string> MnemonicAliases = new()
    {
        {"brn", "bra"}, {"brt", "bra"},
        {"poi", "sst"}, {"epoi", "sst"},
        {"peek", "pop"}, {"popf", "pop"}, {"dsp", "pop"},
        {"poke", "psh"}, {"pshf", "psh"}, {"isp", "psh"},
        {"addc", "add"}, {"addv", "add"}, {"addvc", "add"},
        {"subc", "sub"}, {"subv", "sub"}, {"subvc", "sub"},
        {"or", "bit"}, {"and", "bit"}, {"xor", "bit"}, {"imp", "bit"},
        {"nor", "bnt"}, {"nand", "bnt"}, {"xnor", "bnt"}, {"nimp", "bnt"},
        {"bsl", "bsh"}, {"bsr", "bsh"}, {"ror", "bsh"}, {"bsxr", "bsh"},
        {"bsli", "bsi"}, {"bsri", "bsi"}, {"rori", "bsi"}, {"bsxri", "bsi"},
        {"mulu", "mul"}, {"div", "mul"}, {"mod", "mul"},
        {"sqrt", "btc"}, {"lzr", "btc"}, {"tzr", "btc"},
        {"scp", "cpc"}, {"gcp", "cpc"}
    };


    public static readonly Dictionary<string, string> InstructionTypes = new()
    {
        {"bra", "00"}, {"brn", "01"}, {"brt", "10"}, {"brp", "11"},
        {"psh", "00"}, {"poke", "01"}, {"pshf", "10"}, {"isp", "11"},
        {"pop", "00"}, {"peek", "01"}, {"popf", "10"}, {"dsp", "11"},
        {"poi", "00"}, {"epoi", "01"},
        {"add", "00"}, {"addc", "01"}, {"addv", "10"}, {"addvc", "11"},
        {"sub", "00"}, {"subc", "01"}, {"subv", "10"}, {"subvc", "11"},
        {"imp", "00"}, {"xor", "01"}, {"and", "10"}, {"or", "11"},
        {"nimp", "00"}, {"xnor", "01"}, {"nand", "10"}, {"nor", "11"},
        {"bsl", "00"}, {"bsr", "01"}, {"ror", "10"}, {"bsxr", "11"},
        {"bsli", "00"}, {"bsri", "01"}, {"rori", "10"}, {"bsxri", "11"},
        {"mul", "00"}, {"mulu", "01"}, {"div", "10"}, {"mod", "11"},
        {"sqrt", "00"}, {"clz", "01"}, {"ctz", "10"}, {"cto", "11"}, {"popcnt", "11"},
        {"scp", "0"}, {"gcp", "1"}
    };
}
