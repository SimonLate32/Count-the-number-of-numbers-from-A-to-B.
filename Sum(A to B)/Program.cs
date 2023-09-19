using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите значение B: ");
        int B = int.Parse(Console.ReadLine());

        int totalSum = 0;  // Переменная для хранения суммы

        for (int num = A; num <= B; num++) //Перебираем числа от A до B
        {
            if (IsMatchingNumber(num))  //Проверяем, удов. число условиям задачи
            {
                totalSum += num;  //Если да, добавляем число к сумме
            }
        }

        Console.WriteLine($"Сумма чисел от {A} до {B}, удовлетворяющих условиям задачи: {totalSum}"); //Вывод суммы чисел, которые удов. условию
    }

    static bool IsMatchingNumber(int num) //Функция для проверки числа на соответствие условиям задачи
    {
        int evenCount = 0; //Счетчик четных цифр
        int oddCount = 0; //Счетчик нечетных цифр

        if (num == 0) //Отдельная проверка для числа 0
        {
            return true;
        }

        
        while (num > 0) //Перебираем цифры числа
        {
            int digit = num % 10; //Получаем последнюю цифру числа
            if (digit % 2 == 0)
            {
                evenCount++; //Если цифра четная, увеличиваем счетчик четных цифр
            }
            else
            {
                oddCount++; //Иначе увеличиваем счетчик нечетных цифр
            }
            num /= 10; //Удаляем последнюю цифру числа
        }

        return evenCount == oddCount; //Если количество четных и нечетных цифр совпадает, число удовлетворяет условиям задачи
    }
}
