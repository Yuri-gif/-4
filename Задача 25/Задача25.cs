Console.WriteLine("Введите число A:");
int A=Convert.ToInt32(Console.ReadLine());//Ввод числа A
Console.WriteLine("Введите число B:");
int B=Convert.ToInt32(Console.ReadLine());//ввод числа B

//Функция возведения числа A в степень B
void Result(int a,int b) 
{
    int n=a;
    for(int i=1;i<b; i++)
    {
        n=n*a;
    }
    Console.WriteLine(n);
}

Result(A,B);