Console.WriteLine("Введите число:");
int i = Convert.ToInt32(Console.ReadLine());

void Summ(int I)
{
    
    int sum=0;
    while(I!=0)
    {
        sum=sum+I%10;
        I/=10;
    }
    Console.WriteLine("сумма всех цифр в числе равна: " + sum);
}

Summ(i);