using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D vec1 = new Vector3D(4, 3, 1);
            Vector3D vec2 = new Vector3D(1, 3, 7);
            Console.WriteLine("Длина вектора 1 = {0}", vec1.Length);
            Console.WriteLine("Длина вектора 2 = {0}", vec2.Length);
            Console.WriteLine("Длина вектора 1 {0} длины вектора 2",(vec1.CompareLength(vec2))?"больше":"меньше");
            Console.WriteLine("Скалярное произведение двух векторов = {0}",Vector3D.GetScalar(vec1,vec2));
            Console.ReadKey();
        }
    }
}
