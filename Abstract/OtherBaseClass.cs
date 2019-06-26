namespace practice.Abstract
{
    public class OtherBaseClass
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public void GetAge() 
        {
            System.Console.WriteLine(Age);
        }
        public void GetName()
        {
            System.Console.WriteLine(Name);
        }
    }
}