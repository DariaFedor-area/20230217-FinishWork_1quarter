// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/* ЗАКЛЮЧИТЕЛЬНАЯ РАБОТА:
ЗАДАЧА: Написать программу, котороая из имеющегося массива строк формирует массив из строк, длина которых меньше
 либо равна 3 символам.
Первоначальный массив можно ввести с клаиватуры, либо задавть на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["2"]
*/

Console.Clear();

string text = "hello, 2, world, :-), "
+ "1234, 1567, -2, computer science, >:0";

string[] elements = text.Split(',');
foreach (string element in elements)
{
    var elementLimit = 3 + 1; /* учтен момент, что при обработки длины element.Length программа перебирает
                                 массив с 0, поэтому чтобы вошел последний элемент добавлаем 1 */
    if (element.Length <= elementLimit)
    {
        Console.WriteLine($"элемент: {element}");
        // Console.WriteLine($"элемент: 0");
    }
}


