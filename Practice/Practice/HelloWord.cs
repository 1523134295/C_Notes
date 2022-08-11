using System;
using System.Collections.Generic;
using System.Reflection;

namespace Practice
{
    class HelloWord
    {
        private double salary;
        public HelloWord()
        {
            salary = 5300;
            Console.WriteLine(salary);
        }
       /* static void Main(string[] args)
        {
            new HelloWord();
            *//*int[] array = {5,3,2,4,1};*//*
            int[] array = new int[5] { 4, 1, 3, 5, 2 };
            foreach(var i in array)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            array = ArraySort(array);
            foreach(var i in array)
            {
                Console.Write(i+" ");
            }
            Spell();
            Intercept();
            Splicing();
            (new Stu()).Create();
        }*/
        public static int[] ArraySort(int[] arrays)
        {
            /*双循环*/
            /*int i = 0, j = 0;
            for (; i < arrays.Length; i++)
            {
                for (j = i; j < arrays.Length; j++)
                {
                    if (arrays[i] > arrays[j])
                    {
                        arrays[i] = arrays[i] + arrays[j];
                        arrays[j] = arrays[i] - arrays[j];
                        arrays[i] = arrays[i] - arrays[j];
                    }
                }
            }*/
            /*单循环*/
            int count = 0;
            for(int j = 1; j < arrays.Length; j++)
            {
                if (arrays[count] > arrays[j])
                {
                    arrays[count] = arrays[count] + arrays[j];
                    arrays[j] = arrays[count] - arrays[j];
                    arrays[count] = arrays[count] - arrays[j];
                }
                /*比较完一遍后将标记点加一*/
                if (j == arrays.Length - 1)
                {
                    count++;
                    j = count;
                }
            }
            return arrays;
        }
        public static void Spell()
        {
            String name = "LuoJiajing";
            String emailType = "qq.com";
            String info = "姓名是：{0},邮箱是：{1}";
            info = String.Format(info,name,emailType );
            Console.WriteLine("\n"+info);
        }
        public static void Intercept()
        {
            String email = "LuoJiajing@qq.com";
            String name = email.Substring(0, email.IndexOf("@"));
            String emailType = email.Substring(email.IndexOf("@")+1);
            Console.WriteLine("\n"+name+"\n"+emailType);
        }
        public static void Splicing()
        {
            String a = "我是";
            String b = "No.";
            String c = "1";
            String result = a + b + c;
            Console.WriteLine("\n"+result);
            Console.WriteLine("==========================================");
        }
    }
    class Stu
    {
        public void Son()
        {
            Console.WriteLine("This is Son()");
            new Stu().Name();
        }
        private void Name()
        {
            int i;
            x(out i);
            Console.WriteLine("My name is LuoJiajing.");
            Console.WriteLine(i);
        }
        public static void x(out int i)
        {
            i=7;
        }
        public void Create()
        {
            /*创建实例*/
            Student s1 = new Student(201801420740, "骆家靓");
            Student s2 = new Student(201801420741, "骆家");
            Student s3 = new Student(201801420742, "骆");
            /*创建集合*/
            List<Student> CreateWay = new List<Student>();
            /*添加数据*/
            /*CreateStu.Add(student);*/
            CreateWay.Add(s1);
            CreateWay.Add(s2);
            CreateWay.Add(s3);
            Type type = typeof(Student);
            FieldInfo fieldInfo = type.GetField("id",BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo fieldInfo1 = type.GetField("name", BindingFlags.Instance | BindingFlags.NonPublic);
            /*Console.WriteLine("学号为："+fieldInfo.GetValue(s1)+"姓名是："+fieldInfo1.GetValue(s1));*/
            foreach(Student list in CreateWay)
            {
                Console.WriteLine("学号：" + fieldInfo.GetValue(list) + "  姓名：" + fieldInfo1.GetValue(list));
            }
            Console.WriteLine("=========================================");

            List<Student> CreateStu = new List<Student>();
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();
            student1.Id = 201801420740;
            student1.Name = "骆家靓";
            student2.Id = 201801420741;
            student2.Name = "放散阀";
            student3.Id = 201801420730;
            student3.Name = "高富帅";
            student4.Id = 201801420720;
            student4.Name = "好地方";
            CreateStu.Add(student1);
            CreateStu.Add(student2);
            CreateStu.Add(student3);
            CreateStu.Add(student4);
            foreach(Student i in CreateStu)
            {
                Console.WriteLine("学号："+i.Id+"  姓名："+i.Name);
            }
            Console.WriteLine("=========================================");
        }
    }
    class Student
    {
        private String name;
        private long id;
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public long Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public Student(long id,String name)
        {
            this.name = name;
            this.id = id;
        }
        public Student() { }
    }
}