void Task01(){
    System.Console.WriteLine("Введите трёхзначное число");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num < 100 | num > 999)
    {
        System.Console.WriteLine("Число не трёхзначное");
    }
    else
    {
        int res = (num / 10) % 10;
        System.Console.WriteLine(res);
    }
}

void Task02()
{
    System.Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num < 100)
    {
        System.Console.WriteLine("У числа нет третьей цифры");
    }
    else
    {
        while (num > 999)
        {
            num = num / 10;
        }
        System.Console.WriteLine(num % 10);
    }
}

void Task03()
{
    System.Console.WriteLine("Введите день недели (числом от 1 до 7)");
    int day = Convert.ToInt32(Console.ReadLine());

    if (day < 1 | day > 7)
    {
        System.Console.WriteLine("Ошибка, не является днём недели");
    }
    else if (day >= 1 & day < 6)
    {
        System.Console.WriteLine("Рабочий день");
    }
    else
    {
        System.Console.WriteLine("Выходной день");
    }
}

System.Console.WriteLine("Введите номер задачи, где: \n 1 - показать вторую цифру трёхзначного числа \n 2 - показать третью цифру любого числа \n 3 - показать по номеру дня недели, выходной ли он");
int task = Convert.ToInt32(Console.ReadLine());
switch(task)
{
    case 1:
        Task01();
        break;
    case 2:
        Task02();
        break;
    case 3:
        Task03();
        break;
    default:
        System.Console.WriteLine("Такой задачи нет");
        break;
}