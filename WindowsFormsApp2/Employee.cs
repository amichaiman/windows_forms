namespace WindowsFormsApp2
{
    internal class Employee
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }


        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}