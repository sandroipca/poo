using System;
using MyLibrary;

class Program{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();
        aluno.SetName("sandro");

        Console.WriteLine("hello world!");
        Console.Write("I am the student: ");
        if(aluno.GetOld() == null) aluno.SeOld("28");
        Console.WriteLine(String.Format("{0} i am {1} years old", aluno.GetName(), aluno.GetOld()));

    }

}