namespace Person
{
    internal class Person
    {
        public Person(
            string lastaName,
            string firstName,
            DateTime dateOfBirth,
            Address address) 
        {
            if (string.IsNullOrWhiteSpace(lastaName))
            {
                throw new ArgumentNullException(nameof(lastaName));
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException(nameof(firstName));
            }
            
            if (address is null) 
            {
                throw new ArgumentNullException(nameof(address));
            }
            LastName = lastaName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            Address = address;
        }
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime DateOfBirth { get; set; }
             
        public int age {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }

        public Address Address { get; private set; }

        public void PrintPerson()
        {
            Console.WriteLine($"{LastName} {FirstName}, date of birth: {DateOfBirth:yyyy-MM-dd}");
            Console.WriteLine($"Address: {Address.StreetNumber} {Address.StreetName} {Address.Country} {Address.City}{Address.County})
        }
    }
}
