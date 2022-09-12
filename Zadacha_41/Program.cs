Console.Write("Введите количесто чисел");
int num = Convert.ToInt32(Console.ReadLine());

int [] array = new int[num];

 int PositiveNumber(int count)
 {
    int countOfPositive=0;
    for(int i=0;i<count;i++)
    {
        array[i]=Convert.ToInt32(Console.ReadLine());
        if(array[i]>0)
        {
            countOfPositive+=1;
        }
        Console.WriteLine("[{0}]",string.Join(",", array));
    }
    return countOfPositive;
 }
 int posCount = PositiveNumber(num);

 Console.WriteLine($"Количество положительных чисел ={posCount}");
