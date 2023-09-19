

System.Console.WriteLine("Input number: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
int index = - number; 
while(index < number + 1)
 {
 System.Console.WriteLine($" {index}, "); 
	index++; 
} 

System.Console.WriteLine("Введите число 3-х значное число: "); 
int number1 = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine($"{number1} -> {number1 %10}"); 


 System.Console.WriteLine("Введите число 3-х значное число: ");
  int number2 = Convert.ToInt32(Console.ReadLine()); 
 if(number2>=100 && number2 <=999)
  { 
 System.Console.Write($"{number2} -> {number2 %10}"); 
 }
  else
  { 
System.Console.WriteLine("Вы ввели не коректное число");
  } 

