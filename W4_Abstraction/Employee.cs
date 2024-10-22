namespace W4_Abstraction
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        // one abstract method to rule them all :))
        public abstract void PrintPosition();
    }

    public class ProjectManager : Employee
    {
        public override void PrintPosition()
        {
            Console.WriteLine($"I am {FirstName} {LastName}, and work as Project Manager in {Department} department.");
        }
    }

    public class Designer : Employee
    {
        public override void PrintPosition()
        {
            Console.WriteLine($"I am {FirstName} {LastName}, and work as Designer in {Department} department.");
        }
    }


}
