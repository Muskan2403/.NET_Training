namespace Day2DemoConsole
{
    
    public class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student1(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        List<Student1> studentList = new List<Student1>()
        {
            new Student1(1, "John", 20),
            new Student1(2, "Jane", 22),
            new Student1(3, "Mike", 21)
        };
    }
}