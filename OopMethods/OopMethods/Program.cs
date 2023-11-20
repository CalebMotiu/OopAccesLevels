namespace OopMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            ConsoleHelper.Print("test");

            ConsoleHelper.Print("label","test");

            ConsoleHelper.Print("test",3);

            MathHelper.Factorial(5);

            int[] array = {1, 2, 3, 4, 5};
            ArrayHelper.IterateAndPrint(array);
            
            ConsoltHelper_WithDefaultArgs.Print("messaage1");

            ConsoltHelper_WithDefaultArgs.Print("messaage2","label");

            ConsoltHelper_WithDefaultArgs.Print("messaage3","label",3);

            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(unitPrice: 10));
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(unitPrice: 15, quantity: 3));
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(unitPrice: 20, quantity: 5 , vatPercent: 19));
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(unitPrice: 20, vatPercent: 19));
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(vatPercent: 14, quantity: 5, unitPrice: 20));
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(14, vatPercent: 20));
            
            int a = 10;
            Console.WriteLine($"Befor increment: {a}");
            Increment(a);
            Console.WriteLine($"After increment: {a}");
            

            Person p = new Person
            {
                FirstName = "Ioane",
                LastName = "florintu"
            };

            Console.WriteLine($"Befor say hello change name: {p.FirstName} {p.LastName}");
            SayHello(p);
            Console.WriteLine($"Befor say hello change name: {p.FirstName} {p.LastName}");

        }


        private static void  Increment(int i)
        {
            Console.WriteLine($"Befor increment: {i}");
                i++;
            Console.WriteLine($"After increment: {i}");
        }

        private static void SayHello(Person p)
        {
            Console.WriteLine($"Befor say hello change name: {p.FirstName} {p.LastName}");
            p.LastName = "Changed";
            Console.WriteLine($"Befor say hello change name: {p.FirstName} {p.LastName}");
        }

        private static void SayHello2(Person p)
        {
            Console.WriteLine($"Befor say hello change name: {p.FirstName} {p.LastName}");
            
            p = new Person
            {
                FirstName = "Ioane",
                LastName = "Changed"
            };
            Console.WriteLine($"Befor say hello change name: {p.FirstName} {p.LastName}");
        }
    }

}