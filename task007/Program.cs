Console.WriteLine("Введите трехзначное число");

string a = Console.ReadLine();
if (Convert.ToInt32(a) > 999)
{
   Console.WriteLine("Число не трехзначное"); 
}
else 
{
Console.WriteLine("Последний символ: " +a[2]);
}

    

