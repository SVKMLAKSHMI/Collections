using System;
using System.Collections.Generic;
namespace Stack1{
    public class Student{
        public int Id{get; set;}
        public string Name{get; set;}
    }
    public class Stack1{
        public static void Main(String[] args){
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Print all elements in the stack");
            foreach(var item in stack){
                Console.Write(item+" ");
            }

            Console.WriteLine();

            Console.WriteLine("Pop all elements one after another");
            while(stack.Count > 0){
                Console.Write(stack.Pop() +" ");
            }

            Console.WriteLine();
            
            Console.WriteLine("Class passed as a argument");
            Stack<Student> studentStack = new Stack<Student>();
            studentStack.Push(new Student{
                Id = 234,
                Name = "Maha"
            });
            studentStack.Push(new Student{
                Id = 65,
                Name = "Swarna"
            });

            foreach(var item in studentStack){
                Console.WriteLine(item.Id + " " + item.Name);
            }

            while(studentStack.Count > 0){
                Student student = studentStack.Pop();
                Console.WriteLine(student.Id +" " + student.Name);
            }


            //using generic stack<T>
            Console.WriteLine("Using generic stack<T>");
            StackGeneric<int> intStack = new StackGeneric<int>();
            intStack.Push(10);
            intStack.Push(20);
            
            intStack.DisplayStack();

            StackGeneric<string> stringStack = new StackGeneric<string>();
            stringStack.Push("Maha");
            stringStack.Push("Swarna");

            stringStack.DisplayStack();
                     
        }
    }

    // Generic class stackExample that works with any type T
    public class StackGeneric<T>{

        public Stack<T> stackT = new Stack<T>();

        // method to push items onto the stack;
        public void Push(T item){
            stackT.Push(item);
        }

        // method to display items in the stack
        public void DisplayStack(){
            foreach(var item in stackT){
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
