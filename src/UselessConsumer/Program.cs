namespace UselessConsumer
{
    using System;

    using UselessPackage;

    public static class Program
    {
        public static void Main()
        {
            var uselessDependency = new UselessImplementation();
            var uselessObject = new UselessClass();
            var uselessResult = uselessObject.UselessMethod(uselessDependency, 0);

            Console.WriteLine("Hello World!");
            Console.WriteLine($"Result of this useless computation: {uselessResult}");
        }

        private class UselessImplementation : IUselessInterface
        {
            public int Call(int input)
            {
                return input;
            }
        }
    }
}
