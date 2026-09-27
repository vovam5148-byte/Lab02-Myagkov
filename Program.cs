Console.WriteLine("Границы целочисленных типов");
Console.WriteLine($"byte:   {byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short:  {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int:    {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long:   {long.MinValue} .. {long.MaxValue}");

Console.WriteLine();
Console.WriteLine("Границы дробных типов");
Console.WriteLine($"float:   {float.MinValue} .. {float.MaxValue}");
Console.WriteLine($"double:  {double.MinValue} .. {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

Console.WriteLine();
Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 byte = {overflowed}");