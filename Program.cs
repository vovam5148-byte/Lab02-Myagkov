using System.Globalization;

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

Console.WriteLine();
Console.WriteLine("char");

char firstLetter = 'A';
char separator = '-';
int charAsNumber = firstLetter; // char можно неявно преобразовать в int - это код символа в таблице Unicode
Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
Console.WriteLine($"Код символа {firstLetter} в Unicode: {charAsNumber}");
Console.WriteLine($"Табуляция: \tпосле таба");
Console.WriteLine($"Перенос: \nпосле переноса");

Console.WriteLine();
Console.WriteLine("decimal против double");

double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;

Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
Console.WriteLine($"decimal: 0.1m + 0.2m = {priceDecimal}");

Console.WriteLine();
Console.WriteLine("var");

var studentAge = 20;      //компилятор вывел int
var gpa = 4.75;            //компилятор вывел double
var fullName = "Смирнова А.С"; //компилятор вывел string

Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

Console.WriteLine();
Console.WriteLine("Ввод текста");

Console.Write("Введите ваше имя: ");
string enteredName = Console.ReadLine();

Console.Write("Введите название вашей группы: ");
string enteredGroup = Console.ReadLine();

Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

Console.WriteLine();
Console.WriteLine("Ввод чисел: Convert и Parse");

Console.Write("Введите ваш год рождения: ");
string birthYearInput = Console.ReadLine();

int birthYearConvert = Convert.ToInt32(birthYearInput);
int birthYearParse = int.Parse(birthYearInput);

Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
Console.WriteLine($"int.Parse:       {birthYearParse}");
Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

Console.WriteLine();
Console.WriteLine("Ввод чисел: TryParse");

Console.Write("Введите количество прочитанных книг за семестр: ");
string booksInput = Console.ReadLine();

bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
Console.WriteLine($"Значение переменной booksCount: {booksCount}");


Console.WriteLine();
Console.WriteLine("Введите ваши Имя и Фамилию: ");
string FullNAME = Console.ReadLine();

Console.WriteLine("Введите название группы: ");
string group = Console.ReadLine();

Console.WriteLine("Введите ваш год рождения: ");
int birthYear = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ваш средний балл за прошлый семестр: ");
double GPA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите вашу любимую букву алфавита: ");
char favoriteLetter = Console.ReadLine()[0];
//Вычисление возраста
int age2030 = 2030 - birthYear;
bool isgpa = GPA >= 4.0;

//Вывод информации
Console.WriteLine();
Console.WriteLine("================================");
Console.WriteLine($"Имя и Фамилия: {FullNAME}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Год рождения: {birthYear}");
Console.WriteLine($"Возраст в 2030 году: {age2030}");
Console.WriteLine($"Средний балл за прошлый семестр: {GPA}");
Console.WriteLine($"Любимая буква алфавита: {favoriteLetter}");
Console.WriteLine("================================");

//Задание 1. Калькулятор ИМТ ★

Console.WriteLine();
Console.WriteLine("Какой у вас рост (в м): ");
double rost = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture); 
Console.WriteLine("Какой у вас вес (в кг): ");
double ves = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture); 

double bmi = ves / (rost * rost);      // Формула для расчета
Console.WriteLine($"ИМТ: {bmi:F2}");   // Выводим результат

//Задание 2. РазборФИО через char ★★
Console.WriteLine();
Console.WriteLine("Введите свою Фамилию:");
string surname = Console.ReadLine();
Console.WriteLine("Введите своё Имя:");
string firstName = Console.ReadLine();

char initial = firstName[0]; 
Console.WriteLine($"{surname} {initial}.");

