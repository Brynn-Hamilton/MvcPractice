namespace ModelDemo.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int BirthYear { get; set; }

        public Person(string firstName, string lastName, string email, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthYear = birthYear;
        }

        public Person()
        {
            
        }
    }
}
