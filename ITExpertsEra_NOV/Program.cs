// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Welcome to ITexpertsEra");

//Console.WriteLine("I am Tanushree");
//Console.WriteLine("I am a Bca student");

////int firstNumber = 100;
//int SecondNumber = 200;
//int result = firstNumber + SecondNumber;
//Console.WriteLine("The sum of two numbers is " + result);

//Console.WriteLine("---------------------------------");

//Console.WriteLine("Please enter your First number");
//int first = Convert.ToInt32(Console.ReadLine());//"123",123

//Console.WriteLine("Please enter your second number");
//int second = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter the operation you want to perform");

//string operation = Console.ReadLine();
//int result = 0;

//// Conditional Statement
//if (operation=="Sum")
//{
//    result = first + second;

//}

//else if (operation=="Subtract")

//{
//    result = first - second;

//}


//else if(operation=="Multiply")
//{
//    result = first * second;
//}
//else if (operation=="Divide")
//{
//    result = first / second;
//}

//else
//{
//    Console.WriteLine("You have entered wrong operation");
//}
//Console.WriteLine("The" + operation + "of two numbers is " + result);



//Console.WriteLine("Please enter your number");

//int number = Convert.ToInt32(Console.ReadLine());

//if (number%2==0 && number>100)
//{
//    Console.WriteLine(number + "is an even number and greater than 100");

//}

//else
//{
//    Console.WriteLine(number +  " is either not even or less than 100");
//}


//if (number % 2 == 0 || number > 100)
//{
//    Console.WriteLine(number + "is an even number or greater than 100");

//}

//else
//{
//    Console.WriteLine(number + " is either not even or less than 100");
//}



//Console.WriteLine(" Please enter your first student name?");
//string student1 = Console.ReadLine();

//Console.WriteLine("please enter your maths number");
//int student1mathsno = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("please enter your hindi number");
//int student1hindino = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("please enter your english number");
//int student1englishno = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("please enter your sst number");
//int student1sstno= Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("please enter your science number");
//int student1scienceno = Convert.ToInt32(Console.ReadLine());

//// result of student1

//int student1totalmarks = student1mathsno + student1hindino + student1englishno + student1sstno + student1scienceno;

//int totalmarks = 500;


//int student1percentage = (student1totalmarks * 100) / totalmarks;

//// to check pass
//string student1result = "";

//if (student1percentage < 33)
//{
//    student1result = "fail";

//}
//else if (student1percentage > 33 && student1percentage <= 40)
//{
//    student1result = "third";

//}
//else if (student1percentage > 40 && student1percentage <= 60)
//{
//    student1result = "second";

//}
//else
//{
//    student1result = "first";

//}

//Console.WriteLine("name of the first student is " + student1);

//Console.WriteLine(student1 + "got the total marks of" + student1totalmarks + "out of" + totalmarks);

//Console.WriteLine(student1 + "got the total percentage of " + student1percentage);
//Console.WriteLine(student1+ " is " + student1result);


/////////////////////////////////////////////////////////////////////////////////


// Collections... Array
// IN THIS STORE MORE THSN 1 VALUE


// IT IS A DATATYPE


//int[] arrayint = new int[5];// Array Declaration

//// DATA INSERT INTO ARRAY
//arrayint[0] = 10;
//arrayint[1] = 20;
//arrayint[2] = 30;
//arrayint[3] = 40;
//arrayint[4] = 50;


////// update value into array

//arrayint[2] = 100;

////Console.WriteLine(arrayint[0]);

//// LOOPS

// for loop.

//for (int i = 0; i <arrayint.Length;i++)
//{
//    Console.WriteLine(arrayint[i]);
//}


//for(int i=4;i>=0;i--)
//{
//    Console.WriteLine(arrayint[i]);       
//}

////print table in console

//int j = 1;
//for (int i=10;i<=100;i=i+10)
//{
//    Console.WriteLine("10*" + j + "=" + i);
//    j++;
//}

//for(int k=1;k<=10;k++)
//{
//    Console.WriteLine(k);
//}


//int sum = 0;
//for(int i=0;i<=10;i++)
//{
//    sum = sum + i;//1,2
//   // Console.WriteLine(sum);
//}

//Console.WriteLine("the sum of first 10 natural number is " + sum);

// foreach loop

//string[] arraystring=new string[5] { "Tanu", "tanushree", "shivani", "anjali", "ankit" };
//foreach (string value in arraystring)
//{
//    Console.WriteLine(value);
//}

//// while loop

//while(condition)
//{
//// perform
//}

//using System.Diagnostics;
/////
//int i = 0;
//while(i<10)
//{
//    Console.WriteLine(i);
//    i++;
//}

//// do while loop



//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (i < 10);


//Console.WriteLine("please enter your number to perform sum operations");
//int number = Convert.ToInt32(Console.ReadLine());
//int result = 0;
//for(int i=1;i<number;i++)
//{
//    result = result + i;

//}

//Console.WriteLine(result);



//Console.WriteLine("please enter your number");
//int number = Convert.ToInt32(Console.ReadLine());


//switch (number)
//{
//    case 1:
//        {
//            Console.WriteLine("Monday");
//            break;
//        }

//    case 2:
//        {
//            Console.WriteLine("Tuesday");
//            break;
//        }

//    case 3:
//        {
//            /*Console.WriteLine("Wednesday");*/
//        break;
//    }

//case 4:
//    {
//        /*Console.WriteLine*/("Thursday");
//        break;
//    }

//case 5:
//    {
//        Console.WriteLine("Friday");
//        break;
//    }

//case 6:
//    {
//            Console.WriteLine("Saturday");
//            break;
//        }
//    case 7:
//        {
//            Console.WriteLine("Sunday");
//            break;
//        }

//    default:
//        {
//            Console.WriteLine("Number is not correct");
//            break;
//        }

//}



using ITExpertsEra_NOV;
// object creation

//MathsOperation objMaths = new MathsOperation();
//objMaths.sum(20, 40);
//objMaths.MyProperty = 20;
//objMaths.var1 = 10;


MethodExample objmethodEx = new MethodExample();
objmethodEx.TestMethod();
objmethodEx.Sum(20, 40);
 int result =objmethodEx.Sum2(50, 50);
string concatData = objmethodEx.Add("Tanushree", "Aggarwal");

int[] arrayInt2 = new int[] { 10, 20, 30, 40, 50 };

int resultArray = objmethodEx.SumArray(arrayInt2);
Console.ReadLine();
