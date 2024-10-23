using System.Linq.Expressions;

namespace Learn
{
    class Stu
    {
        public string name;
        public int age;
        public char grade;
        public static string school = "XPU";
        public Stu(string InputName,int InputAge,char InputGrade)
        {
            name = InputName;
            age = InputAge;
            grade = InputGrade;
        }
        public bool PrintAll() 
        {
            try
            {
                Console.WriteLine("姓名:{0},年龄:{1},等级:{2}", name, age, grade);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public bool GetSchool()
        {
            Console.WriteLine(school);
            return true;
        }
        public string School
        {
            get
            {
                return school;
            }
            set
            {
                school = value;
            }
        }
    }
}