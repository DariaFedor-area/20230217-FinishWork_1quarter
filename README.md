# 20230217-FinishWork_1quarter

## __ЗАКЛЮЧИТЕЛЬНОЕ ЗАДАНИЕ__ 
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы вылеляете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (создаем коммиты, как миниму этапы 2,3,4 д.б. расположены в разных коммитах)

## __*ЗАДАЧА:*__ 
Написать программу, котороая из имеющегося массива строк формирует массив из строк, длина которых меньше
 либо равна 3 символам.
Первоначальный массив можно ввести с клаиватуры, либо задавть на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["2"]

## **РЕШЕНИЕ**
1. создала репозиторий, загрузила первые коммиты
2. Проанлизировала возможные подходы. Составила по одному из них алгоритм
3. в программе draw.io составила схему. Прикрепила в формате картинки в общую папку завершающего задания
4. составила программу: введенный текст преобразовываем в массив. Делим массив на элементы. Проверяем каждый элемент на заданную длину (от 0 до 3 включительно). При этом на этапе проверки длины удалаем пробелы, если имеются, чтобы в типе string не учитывались как символ. Получившийся результат вносим в массив, который выводим на экран
