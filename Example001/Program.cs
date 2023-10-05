// Вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1(); // вызов метода (функции)

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4); // - аналогичное написание Method21(msg: "Текст", count: 4) или Method21(count: 4, msg: "Текст");

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4

// string method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);

string method4(int count, string c)
{
    string result = String.Empty;

    int text = 0;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = method4(10, "asdf");
Console.WriteLine(res);