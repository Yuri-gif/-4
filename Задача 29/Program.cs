Console.WriteLine("Введите количество элементов в массиве");
int a=Convert.ToInt32(Console.ReadLine());

do 
{
    Console.WriteLine("Ошибка!!! Количество элементов должно быть 8.: ");
    Int32.TryParse(Console.ReadLine(), out a);
} while(a!=8);

int [] numbers = new int[a];

 void Massiv(int[] n,int A) //Функция заполнения массива рандомными числами 
 {
    Random rand=new Random();
    for(int x=0;x<A;x++)
    {
        n[x]=rand.Next(1,20);
        Console.WriteLine("Значение элемента массива " + x + " = " + n[x]); // Вывод массива на экран
    }
 }

 Massiv(numbers,a);