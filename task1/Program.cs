int Max(int arq1, int arq2, int arq3);
{ 
    int result = arq1;
    if (arq2 > result) result = arq2;
    if (arq3 > result) result = arq3;
    return result;
}

int a1 = 5;
int b1 = 6;
int c1 = 22;
int a2 = 66;
int c2 = 26;
int b2 = 56;
int a3 = 56;
int c3 = 48;
int b3 = 68;


int max1 = Max(a1,c1,b1);
int max2 = Max(a2,c2,b2);
int max3 = Max(a3,c3,b3);
int max = Max(max1,max2,max3);
Console.WriteLine(max);