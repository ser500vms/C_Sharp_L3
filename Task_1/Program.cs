// Методы: если залип цикл, то можно нажать cntrl + c.
// Вид №1. Метод не принимающий занченийи не возвращающий значений.

void Method1() // void - значит мы ничего не возвращаем в конце метода.
{
    Console.WriteLine("Some text..."); // данный метод просто выводит текст.
}
Method1();

// Вид №2. Метод не возвращающий, но принимающий значения.

void Method2(string msg) 
{
    Console.WriteLine(msg); // данный метод выводит заданный текст.
}
Method2("Some text...");

void Method21(string msg, int count) 
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg); // данный метод выводит заданный текст, заданное кол-во раз.
        i++;
    }
}
Method21("Some text...", 4);
//Method21(count: 4, msg: "Some text..."); - таким образом мы конкретно указываем 
//                                           какой элемент мы записываем и куда.

// Вид №3. Метод который ничего не принимает, но что-то возвращает

int Method3()
{
    return Data.Time.Now.Year; // записываем текущий год
}
int year = Method3();
Console.WriteLine(year);

// Вид №4. Метод который принимает и записывает значение

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; //String.Empty - пустая строка
//     while (i < count) 
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text) // сделали через цикл for
{
    string result = String.Empty; //String.Empty - пустая строка
    for (int i = 0; i < count; i++) 
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "text");
Console.WriteLine(res);