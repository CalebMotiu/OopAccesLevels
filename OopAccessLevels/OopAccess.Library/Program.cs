namespace OopAccessLevels.Library
{
  public class Car
    {
        private string manufacturer = "Renaul";
        protected string model = "Clio";
        new Wheel wheel;

        void carPrintManufacturer()
        {
            //private field accessible from within the class
            Console.WriteLine(manufacturer);

            //protected field accessible from within the class
            Console.WriteLine(model);
        }
        public enum BodyType
        {

        }

        protected class Wheel
        {
            public int diameter;
        }
    }
}