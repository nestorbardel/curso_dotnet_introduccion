namespace Herencia;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        Doctor doctor1 = new Doctor("Juan", 40, "Cardiologo");;
        Console.WriteLine(doctor1.GetInfo());
        Console.WriteLine(doctor1.GetData());
        Dev dev1 = new Dev("Nestor", 38, "C#");
        Console.WriteLine(dev1.GetInfo());
        Console.WriteLine(dev1.GetData());
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

    class Doctor : People
    {
        private string _speciality;
        public Doctor(string name, int age, string speciality) : base(name, age)
        {
            this._speciality = speciality;
        }

        public string GetData()
        {
            return GetInfo() + " " + this._speciality;
        }
    }

    class Dev : People
    {
        private string _languaje;
        public Dev(string name, int age, string languaje) : base(name, age)
        {
            this._languaje = languaje;
        }

        public string GetData()
        {
            return GetInfo() + " " + this._languaje;
        }
    }
}