## Программа по формированию нового массива из строк, длина которых меньше, либо равна 3 символам

Данная программа была написана с целью выполнения Итоговой контрольной работы по основному блоку программы Разработчик.
Программа выполняет следующие условия:
Принимает на вход массив строк и формирует новый массив из строк, длина которых меньше, либо равна 3 символам. По рекомендации в программе используются исключительно массивы.

При запуске программа запрашивает длину первоначального массива и значение его элементов, затем выводит в консоль сначала первоначальный массив, стрелку, для демонстрации преобразований, и новый массив строк, длина которых меньше или ровна 3.

Программа содержит 4 метода, каждый из которых выполняет определенную задачу.
Метод GetArray принимает на вход длину первоначального массива, который пользователь хочет ввести в программу, и запрашивает ввод каждого элемента, после чего возвращает массив элементов типа string[].

Метод LengthOfNewMatrix принимает на вход первоначальный массив и максимальную длину элементов нового массива. После прохождения по первоначальному массиву метод возвращает длину, которую должен иметь новый массив, содержащий элементы длиной меньше или равной значению максимальной длины (в нашем случае 3).

Метод NewMatrix принимает на вход первоначальный массив, значение длины нового массива и  максимальную длину  элементов нового массива, после чего генерирует новый массив элементов и выводит его с помощью метода PrintArray() в консоль.

Метод  PrintArray типа void принимает на вход массив строк и выводит его с определенным оформление в консоль.
 
