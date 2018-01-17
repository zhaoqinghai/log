using LogAop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Person
    {
        [Log("hello zhaoqinghai","byebye zhaoqinghai")]
        public void SayHello()
        {
            Console.WriteLine("hello");
        }
    }
}
