# Year-1_Module-2_KDZ-2_Csharp

  Общее задание

В одном решении разместить проект библиотеки классов и проект консольного
приложения. Подробные описание библиотеки и приложения см. в индивидуальном
варианте.

  Требования к библиотеке классов
1. Реализации классов не должны нарушать инкапсуляцию данных и принцип
единственной ответственности (Single Responsibility Principle).
2. Реализации классов должны содержать регламентированный доступ к данным.
3. Классы библиотеки должны быть доступны за пределами сборки.
4. Каждый нестатический класс обязательно должен содержать, в числе прочих,
конструктор без параметров или эквивалентные описания, допускающие его
прямой вызов или неявный вызов.
5. Запрещено изменять набор данных (удалять / дополнять), хранящихся в классах
или не использовать указанные в задании открытые варианты поведения.
6. Допускается расширение открытого поведения или добавление закрытых
функциональных членов класса.
7. Допускается использование абстрактных типов данных, таких как List, ArrayList,
Set, Stack, их обобщённых реализаций и проч., но не в качестве замены
определённых вариантом структур данных.
2
8. Поскольку в описаниях классов присутствует «простор» для принятия решений, то
каждое такое решение должно быть описано в комментариях к коду программы.
Например, если выбран тип исключения, то должно быть письменно обоснованно,
почему вы считаете его наиболее подходящим в рамках данной задачи.

  Требования к консольному приложению
1. Предусмотреть проверку корректности для каждого ввода данных, обработку
исключений, в т.ч. порождаемых классами библиотеки, организацию повторения
решения.
2. Допускается использование абстрактных типов данных, таких как List, ArrayList,
Set, Stack, их обобщённых реализаций и проч., но не в качестве замены
определённых вариантом структур данных.
3. Все данные приложения читают из текстовых файлов, результат работы и
выводится на экран, и сохраняется в другом текстовом файле. Файлы размещаются
обязательно рядом с исполняемым файлом консольного приложения (.EXE). Имена
входного и выходного файлов вводятся пользователем с клавиатуры.

  Общие требования к работе
1. Цикл повторения решения и проверки корректности получаемых данных
обязательны.
2. Соблюдение определённых программой учебной дисциплины требований к
программной реализации работ – обязательно.
3. Соблюдение соглашений о качестве кода – обязательно
(https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/codingconventions).
4. Весь программный код должен быть написан на языке программирования C# с
учётом использования .net 6.0;
5. исходный код должен содержать комментарии, объясняющие неочевидные
фрагменты и решения, резюме кода, описание целей кода (см. материалы лекции 1,
модуль 1);
6. при перемещении папки проекта библиотеки (копировании / переносе на другое
устройство) файлы должны открываться программой также успешно, как и на
компьютере создателя, т.е. по относительному пути;
7. текстовые данные, включая данные на русском языке, успешно декодируются при
представлении пользователю и человекочитаемы;
8. программа не допускает пользователя до решения задач, пока с клавиатуры не
будут введены корректные данные;
9. консольное приложение обрабатывает исключительные ситуации, связанные (1) со
вводом и преобразованием / приведением данных как с клавиатуры, так и из
файлов; (2) с созданием, инициализацией, обращением к элементам массивов и
строк; (3) вызовом методов библиотеки.
10. представленная к проверке библиотека классов должна решать все поставленные
задачи, успешно компилироваться.

  Что сдаём?

Архив с папкой решения (Solution), содержащий проекты консольного приложения и
библиотеки классов, определённых индивидуальным вариантом


  Вариант 12

В библиотеке классов разместить класс NumbJagged

• Поле int[][] jagArr - ступенчатый массив.

• Конструктор с целочисленным неотрицательным параметром N – число строк зубчатого массива. Конструктор инициализирует поле jagArr. Каждая строка jagArr – одномерный массив из заранее неизвестного количества случайно выбираемых из диапазона [0,5] элементов. 
Каждая строка последовательно «растет», пока не появится случайное нулевое значение, которое становится значением последнего элемента.

• Метод StringOut() для представления значений элементов строк-массивов из
ступенчатого массива в виде массива символьных строк (в символьной строке все
значения одной строки).

• Метод MinSquareNumb() возвращающий значения тех трех элементов заданной
параметром строки массива jagArr, треугольник с длинами сторон которых имеет
максимальную площадь.

В основной программе, получать из файла значения N и определить объекты класса
NumbJagged из N строк разной длины. В выходной файл вывести значения элементов из
NumbJagged, для формирования строковых представлений использовать AsString(), и
количество стороны треугольника с максимальной площадью.