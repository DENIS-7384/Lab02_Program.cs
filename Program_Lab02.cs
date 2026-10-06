Console.WriteLine("Границы целочисленных типов");
Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");
Console.WriteLine();
Console.WriteLine("Границы дробных типов");
Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");


Console.WriteLine();
Console.WriteLine("Переполнение byte");
byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");


Console.WriteLine();
Console.WriteLine("char");
char firstLetter = 'A';
char separator = ';'; 
int charAsNumber = firstLetter; 
Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
Console.WriteLine($"Табуляция:\tпосле таба");
Console.WriteLine($"Перенос:\nпосле переноса");

Console.WriteLine();
Console.WriteLine("decimal против double");
double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;
Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");



Console.WriteLine();
Console.WriteLine("var");
var studentAge = 20;       
var gpa = 4.75;            
var fullName = "Смирнова А.С."; 
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
Console.WriteLine($"int.Parse: {birthYearParse}");
Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

Console.WriteLine();
Console.WriteLine("Ввод чисел: TryParse");
Console.Write("Введите количество прочитанных книг за семестр: ");
string booksInput = Console.ReadLine();
bool wasSuccessful = int.TryParse(booksInput, out int booksCount);
Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
Console.WriteLine($"Значение переменной booksCount: {booksCount}");



Console.WriteLine();
Console.WriteLine("=== Мини-анкета ===");
Console.Write("Введите имя и фамилию: ");
string anketaName = Console.ReadLine();
Console.Write("Введите группу: ");
string anketaGroup = Console.ReadLine();
Console.Write("Введите год рождения: ");
int birthYear = int.Parse(Console.ReadLine());
Console.Write("Введите средний балл: ");
double avgGrade = double.Parse(Console.ReadLine());
Console.Write("Введите любимую букву: ");
char favLetter = Console.ReadLine()[0];

int ageIn2030 = 2030 - birthYear;
bool isGoodGrade = avgGrade >= 4.0;

Console.WriteLine();
Console.WriteLine("Анкета");
Console.WriteLine($"{anketaName}, группа {anketaGroup}");
Console.WriteLine($"Год рождения: {birthYear} (в 2030 будет {ageIn2030} лет)");
Console.WriteLine($"Средний балл: {avgGrade}");
Console.WriteLine($"Балл >= 4.0: {isGoodGrade}");
Console.WriteLine($"Любимая буква: {favLetter}");


Console.WriteLine();
Console.WriteLine("=== Калькулятор ИМТ ===");
Console.Write("Введите рост в метрах (например 1.75): ");
double height = double.Parse(Console.ReadLine());
Console.Write("Введите вес в килограммах (например 68.5): ");
double weight = double.Parse(Console.ReadLine());
double bmi = weight / (height * height);
Console.WriteLine($"ИМТ: {bmi:F2}");


Console.WriteLine();
Console.WriteLine("=== Инициалы ===");
Console.Write("Введите фамилию: ");
string surname = Console.ReadLine();
Console.Write("Введите имя: ");
string name = Console.ReadLine();
char initial = name[0];
Console.WriteLine($"{surname} {initial}.");


Console.WriteLine();
Console.WriteLine("=== TryParse: int, double, DateTime ===");

Console.Write("Введите целое число: ");
string intInput = Console.ReadLine();
bool intOk = int.TryParse(intInput, out int intValue);
Console.WriteLine($"int: успешно = {intOk}, значение = {intValue}");

Console.Write("Введите дробное число: ");
string doubleInput = Console.ReadLine();
bool doubleOk = double.TryParse(doubleInput, out double doubleValue);
Console.WriteLine($"double: успешно = {doubleOk}, значение = {doubleValue}");

Console.Write("Введите дату (дд.мм.гггг, например 15.03.2006): ");
string dateInput = Console.ReadLine();
bool dateOk = DateTime.TryParse(dateInput, out DateTime dateValue);
Console.WriteLine($"DateTime: успешно = {dateOk}, значение = {dateValue}");
