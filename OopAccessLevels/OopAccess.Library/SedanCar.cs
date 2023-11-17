

namespace OopAccessLevels.Library
{
    public class SedanCar : Car
    {

        void sedanPrintManufacturer()
        {
            //car private fiel not accessible in child class
            //from whitin the same project
            // Console.WriteLine(manufacturer);

            //car protected field is accessible in child class
            //fromm within the same project
            Console.WriteLine(model);
        }

        protected class SedanWheel : Wheel
        { 
        
            public void SpinWheel()
            {
                Console.WriteLine(diameter);
            }
        
        }
    }
}
