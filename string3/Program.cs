//Задача
//string3. С клавиатуры вводится строка разделенная точкой. 
//Подсчитать количество символов до точки

Console.Write("Введите текст: ");
string text = Console.ReadLine();
int position = text.IndexOf('.');
 
Console.WriteLine($"До точки {position} символов");

