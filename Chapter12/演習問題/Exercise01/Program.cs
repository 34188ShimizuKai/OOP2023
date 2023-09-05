using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            var emp = new Employee {
                Id = 00001,
                Name = "開發光",
                HireDate = new DateTime(2023,9,5)    
            };
            //シリアル化
            using(var writer = XmlWriter.Create(v))
            {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }
            //逆シリアル化
            using (var reader = XmlReader.Create(v))
            {
                var serializer = new XmlSerializer(typeof(Employee));
                var employee = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(employee);
            }

        }

        private static void Exercise1_2(string v) {
            var emps = new Employee[] {
                new Employee {
                    Id = 00002,
                    Name = "食蜂操祈",
                    HireDate = new DateTime(2004, 12, 1)
                },
                new Employee
                {
                    Id = 00003,
                    Name = "藍花悦",
                    HireDate = new DateTime(2006, 1, 2)
                },
            };
            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " "
            };
            using (var writter = XmlWriter.Create(v, settings))
            {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(writter, emps);
            }

        }

        private static void Exercise1_3(string v) {
            using(XmlReader reader = XmlReader.Create(v))
            {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach (var emp in emps)
                {
                    Console.WriteLine("{0} {1} {2}", emp.Id, emp.Name, emp.HireDate);
                }
            }
        }

        private static void Exercise1_4(string v) {
            var emps = new Employee[]
            {
                new Employee
                {
                    Id = 00004,
                    Name = "削板軍覇",
                    HireDate = new DateTime(2021,9,9)
                },
                new Employee
                {
                    Id = 00005,
                    Name = "御坂美琴",
                    HireDate = new DateTime(2023,1,12)
                },
            };
            using(var stream = new FileStream(v, FileMode.Create, FileAccess.Write)){
                var serializer = new DataContractJsonSerializer(emps.GetType());
                serializer.WriteObject(stream, emps);
            }
        }
    }
}
