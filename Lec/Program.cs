//ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ... ])
// {
//  Тело Метода
//  return ЗначениеСоответствующееВозвращаемомуТипуДанных;
// }

// // Вид 1
// void Method1()
// {
//     Console.WriteLine("Author");
// }

// //Скобки обязательны
// Method1();

// // Вид 2 - ничего не возвращает, но принимает 
// 222
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg: "TEXT");

// void Method21(string msg, int count)
// {
//     int i = 0 ;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i ++;
//     }
// }
// // Method21(msg: "TEXT",count: 4);
// 333

// int Method3()
// {
//     return DateTime.Now.Year;

// }
// int year = Method3();
// Console.WriteLine(year);
// 44444
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;

//     }
//     return result ; 

// }
// string res = Method4(10, "qwer  ");
// Console.WriteLine(res);


// ЦИКЛ ФОР

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for ( int i = 0; i < count; i++)
//     {
//         result = result + text;      

//     }
//     return result ; 

// }
// string res = Method4(10, "qwer  ");
// Console.WriteLine(res);


// ЦИКЛ ВНУТРИ ЦИКЛА
// пример с таблицей умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    { 
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
