using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using EmployeeLibrary;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Assembly t = Assembly.GetAssembly(typeof(Employee));
            Type tt = typeof(Employee);
            ConstructorInfo[] ci = tt.GetConstructors();
            foreach (var c in ci)
            {
                Console.WriteLine("Constructor Name" + c.Name);
                Console.WriteLine("Is Public" + c.IsPublic);
                ParameterInfo[] pi = c.GetParameters();

                foreach (var p in pi)
                {
                    Console.WriteLine("Parameter type" + p.ParameterType);
                    Console.WriteLine("Parameter position" + p.Position);
                    Console.WriteLine("Default value for Parameter" + p.DefaultValue);

                }


            }
            MethodInfo[] mi = tt.GetMethods();
            foreach(var m in mi)

            {
                Console.WriteLine("Method Name:" + m.Name);
                Console.WriteLine("Module Name:" + m.Module);
                Console.WriteLine("Return Type:" + m.ReturnType);
                Console.WriteLine("is public:" + m.IsPublic);


            }
            MemberInfo[] fi = tt.GetMembers();
            foreach(var f in fi)
            {
                Console.WriteLine(f.Name);
                Console.WriteLine(f.Module);

                Console.WriteLine(f.MemberType);
                Console.WriteLine(f.DeclaringType);


            }
            Console.WriteLine("*************");
        }
    }
}
