// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// task 1
// int num = new Random().Next(10,100);

// Console.WriteLine(num);

// int num1= num/10;
// int num2= num %10;

// if(num1>num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }

//task_2
// надо взять трехзначное чило и удалить вторую цифру
int num = new Random().Next(100,1000);

Console.WriteLine(num);

int num1= num/100;
int num2= num %10;

int result = num1*10+num2;

Console.WriteLine(result);
