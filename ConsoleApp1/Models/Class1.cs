using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Class1
    { 
        public string Name { get; set; }
        public int age { get; set; }
        public int  orszag { get; set; }
        public int  szak { get; set; }
        public int hobbi { get; set; }

        public Class1(string csvRow)
        {
            var data = csvRow.Split(',');
            if (data.Length == 0)
            {
                Name = data[1];
                age = int.Parse(data[2]);
                orszag = int.Parse(data[3]);
                szak = int.Parse(data[4]);
                hobbi = int.Parse(data[5]);
            }
             
        }

        public override string ToString()
        {

            return $"name:{Name}, age: {age}, orszag:{orszag}, szak:{szak}, hobbi: {hobbi}"; ;
        }
    }

}
