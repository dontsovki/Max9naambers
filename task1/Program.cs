//Поищем максимум из 9 чисел

int Max(int arq1, int arq2, int arq3)
{
    int result = arq1;
    if (arq2 > result) result = arq2;
    if (arq3 > result) result = arq3;
    return result;

}

//              0.1.2.3.4.5.6.7.8.9
int[] array = {2,26,85,45,69,20,45,62,48};

int max = Max(
    Max (array [0],array[1],array[2]),
    Max (array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])
);
Console.WriteLine(max);

//int max1 = Max(a1,c1,b1);
//int max2 = Max(a2,c2,b2);
//int max3 = Max(a3,c3,b3);
//int max = Max(max1,max2,max3);
//Console.WriteLine(max);