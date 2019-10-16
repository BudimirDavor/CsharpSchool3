/*
Generic is a concept that allows us to define classes and methods with placeholder. 
C# compiler replaces these placeholders with specified type at compile time. 
The concept of generics is used to create general purpose classes and methods. 
To define generic class, we must use angle <> brackets. 
The angle brackets are used to declare a class or method as generic type. 
In the following example, we are creating generic class that can be used to deal with any type of data.
*/
using System;  
namespace CSharpProgram  
{  
	class GenericClass  
	{  
		public void Show(T msg)  
		{  
			Console.WriteLine(msg);  
		}  
	}  
	
	class Program  
	{  
		static void Main(string[] args)  
		{  
			GenericClass genC = new GenericClass();  
			genC.Show("This is generic method");  
			genC.Show(101);  
			genC.Show('I');  
		}  
	}  
}