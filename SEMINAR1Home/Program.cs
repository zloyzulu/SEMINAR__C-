/*//Программа, на вход принимающая два числа,
 //а на выходе показывает какое число большее, а какое меньшее.

int num;
int num2;                                                                                                                                                        //Ввод данных

 // Ввод данных
  Console.Write("Введите число первое: ");
  num = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите число второе: ");
  num2= Convert.ToInt32(Console.ReadLine());


 // Вычисление большего числа из двух

if(num > num2 )
    {
    Console.WriteLine("Число первое больше чем второе = " + num );
}
else if(num2 > num){
    Console.WriteLine("Число первое меньше чем второе = " + num2);
}


*/


/*//Программа на вход принимает три числа 
//и выдает максимальное из этих чисел

int num1;
int num2;
int num3;

// Ввод данных
Console.Write("a= ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b= ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("c= ");
num3 = Convert.ToInt32(Console.ReadLine());

// Вычисление максчисла и вывод данных

if(num1 > num2 ){
    if(num1 > num3){
    Console.WriteLine("max = " + num1 );
}
else{Console.WriteLine("max = " + num3 );}
}

else if(num2 > num3){
    Console.WriteLine("max = " + num2 );
}
else{
   Console.WriteLine("max = " + num3 ); 
}


*/


/*
//программа, которая на вход принимает число и выдаёт,
 //является ли число чётным (делится ли оно на два без остатка)
       
       
Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.Read());
                
if (a % 2 == 0) 
{
    Console.WriteLine("Четное");
} else 
{
     Console.WriteLine("Нечетное");
}
   
*/


/*
//Программа, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

int num;

Console.Write("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

int current = 1 ;

while (current <= num){

    if (current %2 == 0)
    Console.Write(current + " ");
current++;
}

*/





