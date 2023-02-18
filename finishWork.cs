// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/* ЗАКЛЮЧИТЕЛЬНАЯ РАБОТА:
ЗАДАЧА: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задавать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["2"]
*/

Console.Clear();
string text = "hello, 2, world, :-), 1234, лук, 1567, -2, computer science, >:0";
var elementLimit = 3; // условие по количетсву символов в элементе для печати на экран


string[] checkArray(string text) // вводим введенный текст в массив
{
    string[] array = text.Split(',');  //Разбиваем массив на элементы по разделителю ","
    string[] newArray = new string[] { }; //Задаем пустой массив без длины для записи нового итогового

    for (int i = 0; i < array.Length; i++) //перебором элементов массива проверяем их длину, соответствует она заявленной по условию
    {
        //var elementLimit = amountSymboles;

        var element = CheckSumbolOne(array[i]);  //добавляем функцию для проверки и удаления пробелов, чтобы не учитывать в длине
        if (element.Length <= elementLimit)
        {
            newArray = newArray.Append(element).ToArray(); //добовляем в newArray елемент на новый индекс. создаем массив для вывода на экран
        }
    }
    return newArray;
}

/*---Так как используем split, прогрмамма добавляет пробел, делаем проверку каждого элемента
 массива на наличие пробела в начале и в конце, и удаляем его если есть*/
string CheckSumbolOne(string element) //каждый разбитый элемент воспринимаем как отдельный массив
{
    if (element[0] == ' ') // обращаемся к первому индексу в выделенном(после split) элементе массива
    {
        element = element.Remove(0, 1); // 0 - индекс, 1 - кол-во символов
    }
    if (element[element.Length - 1] == ' ') // тоже делаем с концом массива, если введен по ошибке пробел, его удаляем
    {
        element = element.Remove(element.Length - 1, 1);
    }
    return element;
};

Console.WriteLine($"Ваш масив:[{String.Join(",", checkArray(text))}]");


