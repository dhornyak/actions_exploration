namespace UselessPackage
{
    public class UselessClass
    {
        public int UselessMethod(IUselessInterface dependency, int input)
        {
            return dependency.Call(input);
        }
    }
}
