using System;

namespace AccessSpecifierDemo
{
    public class BaseClass
    {
        // Public: Accessible from anywhere
        public string PublicProperty = "I am Public";

        // Private: Accessible only within this class
        private string PrivateProperty = "I am Private";

        // Protected: Accessible within this class and derived classes
        protected string ProtectedProperty = "I am Protected";

        // Internal: Accessible within the same assembly
        internal string InternalProperty = "I am Internal";

        // Protected Internal: Accessible within the same assembly or derived classes
        protected internal string ProtectedInternalProperty = "I am Protected Internal";

        public void ShowProperties()
        {
            Console.WriteLine(PublicProperty);
            Console.WriteLine(PrivateProperty);
            Console.WriteLine(ProtectedProperty);
            Console.WriteLine(InternalProperty);
            Console.WriteLine(ProtectedInternalProperty);
        }
    }

    public class DerivedClass : BaseClass
    {
        public void ShowInheritedProperties()
        {
            Console.WriteLine("\nAccessing properties from DerivedClass:");
            Console.WriteLine(PublicProperty); // Accessible
            // Console.WriteLine(PrivateProperty); // Not accessible
            Console.WriteLine(ProtectedProperty); // Accessible
            Console.WriteLine(InternalProperty); // Accessible (same assembly)
            Console.WriteLine(ProtectedInternalProperty); // Accessible
        }
    }

    internal class InternalClass
    {
        public void ShowInternalAccess()
        {
            Console.WriteLine("\nAccessing properties from InternalClass:");
            BaseClass baseClass = new BaseClass();
            Console.WriteLine(baseClass.PublicProperty); // Accessible
            // Console.WriteLine(baseClass.PrivateProperty); // Not accessible
            // Console.WriteLine(baseClass.ProtectedProperty); // Not accessible
            Console.WriteLine(baseClass.InternalProperty); // Accessible
            Console.WriteLine(baseClass.ProtectedInternalProperty); // Accessible
        }
    }

    class Program
    {
        static void Main()
        {
            BaseClass baseObject = new BaseClass();
            Console.WriteLine("Accessing properties from BaseClass instance:");
            Console.WriteLine(baseObject.PublicProperty); // Accessible
            // Console.WriteLine(baseObject.PrivateProperty); // Not accessible
            // Console.WriteLine(baseObject.ProtectedProperty); // Not accessible
            Console.WriteLine(baseObject.InternalProperty); // Accessible
            Console.WriteLine(baseObject.ProtectedInternalProperty); // Accessible

            DerivedClass derivedObject = new DerivedClass();
            derivedObject.ShowInheritedProperties();

            InternalClass internalObject = new InternalClass();
            internalObject.ShowInternalAccess();
        }
    }
}
