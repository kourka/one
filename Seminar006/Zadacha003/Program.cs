 // Задача 3: * Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//  Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.

// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 28
 
 
 
 int J;
            Console.Write("Введите размерность массива");
            J = int.Parse(Console.ReadLine());
            double[] chisla = new double[J];
            double[] resultat = new double[J-1];
            for (int i = 0; i < J; i++)
            {
                Console.Write("Введите " + (i + 1) + " элемент массива ");
                chisla[i] = double.Parse(Console.ReadLine());
            }
            double k = 0;
            for (int i = 0, j = 0; i < J; j++, i++)
            {
                k = (chisla[i] * chisla[i + 1]);
                resultat[j] = k;
                Console.WriteLine(resultat[j]);
 
            }