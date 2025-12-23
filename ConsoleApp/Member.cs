using system;
namespace ConsoleApp
{
    public class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Member(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
