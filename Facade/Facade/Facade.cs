using Facade.Libreris;

namespace Facade
{
    public class Facade
    {
        public void Operation(int number)
        {
            SubSystem1.Operation(number);
            SubSystem2.Operation(number);
        }
    }
}