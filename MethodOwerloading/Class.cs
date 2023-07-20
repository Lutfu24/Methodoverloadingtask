using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOwerloading;

internal class Student
{
    public void GetResult(double num)
    {
        Console.WriteLine(Math.Pow(num, num));
    }

    public void GetResult(double num, double num1)
    {
        Console.WriteLine(Math.Pow(num, num1));
    }
}
