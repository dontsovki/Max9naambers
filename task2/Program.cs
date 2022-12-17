int[] array = {1,56,8,9,7,5,2,5,64,1205};
int n = array.Length;
int find = 18;
ind index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        
        Console.WriteLine(index);
        break;
    }
    index ++;
}
    

