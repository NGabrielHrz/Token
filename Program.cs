
// See https://aka.ms/new-console-template for more information
string TD = "TD",OA = "OA",OR = "OR",IR = "IR",IC = "IC",DEL = "DEL",SEP = "SEP",AS = "AS", PS = "PS", CNE = "CNE";
Console.WriteLine("Introdusca un fragmento de código (favor de separar bien cada palabra o caracter)");
string str = Console.ReadLine();
string[] palabras = str.Split(' ');
string[] Tokens = str.Split(' ');

for (int i = 0; i < palabras.Length; i++)
{
    //Console.WriteLine($"Se escribio: {palabras[i]}");
    string template = ""; template = palabras[i];
    if (template.Equals("int"))
    {
        Tokens[i] = TD+"1";
    }
    if (template.Equals("char"))
    {
        Tokens[i] = TD+"2";
    }
    if (template.Equals("bool"))
    {
        Tokens[i] = TD+"3";
    }
    if (template.Equals("+"))
    {
        Tokens[i] = OA+"1";
    }
    if (template.Equals("-"))
    {
        Tokens[i] = OA+"2";
    }
    if (template.Equals("*"))
    {
        Tokens[i] = OA+"3";
    }
    if (template.Equals("/"))
    {
        Tokens[i] = OA+"4";
    }
    if (template.Equals("%"))
    {
        Tokens[i] = OA+"5";
    }
    if (template.Equals("++"))
    {
        Tokens[i] = OA+"6";
    }
    if (template.Equals("--"))
    {
        Tokens[i] = OA+"7";
    }
    if (template.Equals("<"))
    {
        Tokens[i] = OR+"1";
    }
    if (template.Equals("<="))
    {
        Tokens[i] = OR+"2";
    }
    if (template.Equals(">"))
    {
        Tokens[i] = OR+"3";
    }
    if (template.Equals(">="))
    {
        Tokens[i] = OR+"4";
    }
    if (template.Equals("!="))
    {
        Tokens[i] = OR+"5";
    }
    if (template.Equals("=="))
    {
        Tokens[i] = OR+"6";
    }
    if (template.Equals("while"))
    {
        Tokens[i] = IR+"1";
    }
    if (template.Equals("for"))
    {
        Tokens[i] = IR+"2";
    }
    if (template.Equals("do"))
    {
        Tokens[i] = IR+"3";
    }
    if (template.Equals("if"))
    {
        Tokens[i] = IC+"1";
    }
    if (template.Equals("else"))
    {
        Tokens[i] = IC+"2";
    }
    if (template.Equals("switch"))
    {
        Tokens[i] = IC+"3";
    }
    if (template.Equals("case"))
    {
        Tokens[i] = IC+"4";
    }
    if (template.Equals("default"))
    {
        Tokens[i] = IC+"5";
    }
    if (template.Equals("{"))
    {
        Tokens[i] = DEL+"1";
    }
    if (template.Equals("}"))
    {
        Tokens[i] = DEL+"2";
    }
    if (template.Equals("("))
    {
        Tokens[i] = DEL+"3";
    }
    if (template.Equals(")"))
    {
        Tokens[i] = DEL+"4";
    }
    if (template.Equals("["))
    {
        Tokens[i] = DEL+"5";
    }
    if (template.Equals("]"))
    {
        Tokens[i] = DEL+"6";
    }
    if (template.Equals("."))
    {
        Tokens[i] = SEP+"3";
    }
    if (template.Equals(","))
    {
        Tokens[i] = SEP+"3";
    }
    if (template.Equals(";"))
    {
        Tokens[i] = SEP+"3";
    }
    if (template.Equals(":"))
    {
        Tokens[i] = SEP+"3";
    }
    if (template.Equals("="))
    {
        Tokens[i] = AS+"1";
    }
    if (template.Equals("Console"))
    {
        Tokens[i] = PS+"1";
    }
    if (template.Equals("Write"))
    {
        Tokens[i] = PS+"2";
    }
    if (template.Equals("WriteLine"))
    {
        Tokens[i] = PS+"3";
    }
    if (template.Equals("ReadLine"))
    {
        Tokens[i] = PS+"4";
    }
    if (template.Equals("default"))
    {
        Tokens[i] = PS+"5";
    }
    if (template.Equals("System"))
    {
        Tokens[i] = PS+"6";
    }
    if (template.Equals("0") || template.Equals("1") || template.Equals("2") || template.Equals("3") || template.Equals("4") || template.Equals("5") || template.Equals("6") || template.Equals("7") || template.Equals("8") || template.Equals("9") || template.Equals("10"))
    {
        Tokens[i] = CNE;
    }
    // else
    // {
    //     Tokens[i] = ID;
    // }
}
Console.WriteLine("The Tokens file was as follows:");
for (int j = 0; j < Tokens.Length; j++)
{
    Console.Write(Tokens[j] + " ");
}