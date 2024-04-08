Console.WriteLine("1: copiar cabecera de la tabla en excel o cualquier programa de vision de datos");
Console.WriteLine("2: Accede a http://www.unit-conversion.info/texttools/replace-text/");
Console.WriteLine("3: Find text: separacion de tablas");
Console.WriteLine("4: Replace with: |");
Console.WriteLine("5: pegar texto en input y pegar debajo de 'tabla' en la consola el resultado de la pagina web");
Console.WriteLine("---------------------------------------------------");
while (true)
{
    Console.WriteLine();
    Console.WriteLine("tablas");
    string tablasStr = Console.ReadLine();

    var tablas = tablasStr.Split("|");

    Console.WriteLine();
    foreach (var a in tablas)
    {
        var texto = a.Replace("% ", "porciento")
            .Replace(".", "_")
            .Replace(" ", "_");
        if (int.TryParse(texto.Substring(0, 1), out int temp))
        {
            string numbers = texto.StartsWith("\\d+") ? texto.Substring(0, texto.IndexOfAny(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' })) : "";
            texto = texto.Replace("\\d+", "").Replace("(", "").Replace(")", "").Replace("\"", "").Replace("'", "");
            texto += numbers;
        }
        Console.WriteLine($"[Column(\"{a.Replace(" ", "_")}\")]");
        Console.WriteLine("public string? " + texto + " {get;set;} = string.Empty;");
        Console.WriteLine("");
    }
}