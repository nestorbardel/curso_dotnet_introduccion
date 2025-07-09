namespace Herencia;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
    class People
    {
        private string _name;
        private int _age;

        public People(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string GetInfo()
        {
            return _name + " " + _age;
        }

    }
}