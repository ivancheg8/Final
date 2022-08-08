**Задача:**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Описание алгоритма:**

1. Перебором по порядку, в заданном массиве проверяется длинна элементов.
2. Если длинна элемента <= 3, то он добавляется в дополнительный, пустой массив, последовательно. Дополнительный массив имеет длинну, равную проверяемому массиву.
3. После заполнения дополнительного массива, его размер изменяется на количество записанных согласно условию элементов.

![](https://github.com/ivancheg8/Final/blob/master/block%20diagram.png)