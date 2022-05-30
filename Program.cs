// Task 73. Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной 
//группе все числа были взаимно просты (все числа в группе друг на друга не делятся)? 
//Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰. Можно использовать рекурсию.
//Например, для N = 50, M получается 6
Console.Clear();
Console.WriteLine("");
Console.WriteLine();
int numberN = EnterUserData("Enter the end number N:");
int[] numbersArray = new int[numberN];
FillArray(numbersArray);
PrintArray(numbersArray);
string[] result = new string[numberN];
int index=0;
for (int i = 0; i < result.Length; i++)
{
    result[i] = string.Empty;
}
int counter = 0;
for (int i = 0; i < numbersArray.Length; i++)
{
    if (i == 0)//the first group is 1 
    {
        result[counter] = numbersArray[i] + " ";
        numbersArray[i] = 0;
    }
    int flag = 0;
    if (numbersArray[i] == 0)
    {
        continue;
    }
    else
    {
        counter++;
        result[counter] = numbersArray[i] + " ";
        Console.WriteLine($"Current i = {i}");
        numbersArray[index] = 0;
        for (int j = 0; j < numbersArray.Length; j++)
        {
            Console.Write($"Current j = {j} flag = {numbersArray[j]} % {numbersArray[i]} = ");
            flag = numbersArray[j] % numbersArray[i];
            index=i;
            Console.WriteLine(flag);
            if (flag != 0 && numbersArray[j] != 0)
            {
                result[counter] = result[counter] + numbersArray[j] + " ";
                numbersArray[j] = 0;
            }
            else
            {
                continue;
            }

        }
    }

}
PrintStringArray(result);

int[] FillArray(int[] array)
{
    for (int i = 1; i < array.Length + 1; i++)
    {
        array[i - 1] = i;
    }
    return array;
}

int EnterUserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
}

void PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != string.Empty)
        {
            Console.WriteLine($"Group {i}: {array[i]} ");
        }
    }

}


//int nod = Evklid(numbersArray[0], numbersArray[1]);

/*for (int i = 1; i < numbersArray.Length; i++)
{
    for (int j = 1; j < numbersArray.Length; j++)
    {
        OstatokDelenie(numbersArray[i], numbersArray[j]);
        //int nod2 = Evklid(numbersArray[i], numbersArray[j]);
        //if (nod2 == 1)
        //  {
        //     result = result + Convert.ToString(numbersArray[i]) +" "+ Convert.ToString(numbersArray[j]) + " ";
        //  }
        //  else
        //  {
        //      ostatok = ostatok + Convert.ToString(numbersArray[i]) +" "+ Convert.ToString(numbersArray[j]) + " ";
        //   }
    }
    Console.WriteLine();
    Console.WriteLine($"Group # {i}");
}
//Console.WriteLine("Result= " + result);
//Console.WriteLine("Ostatok= " + ostatok);

/*bool OstatokDelenie(int numberA, int numberB)
{
    if (numberB % numberA == 0)
    {
        Console.WriteLine($"OstDel:{numberB} % {numberA} = " + numberB % numberA);
        return false;
    }
    else
    {
        Console.WriteLine($"OstDel:{numberB} % {numberA} = " + numberB % numberA);
        return true;
    }
}*/


/*int Evklid(int numberA, int numberB)
{
    int nod = 0;
    int A = numberA;
    int B = numberB;
    while (numberA != 0 && numberB != 0)
    {
        if (numberA > numberB)
        {
            numberA = numberA % numberB;
        }
        else
        {
            numberB = numberB % numberA;
        }
    }
    nod = numberA + numberB;
    // if (nod==1)
    //{
    Console.WriteLine($"НОД:{A} and {B} = " + nod);
    // }
    return nod;
}*/