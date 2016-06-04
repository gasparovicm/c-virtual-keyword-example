using System.Diagnostics;

namespace VirtualAndNewExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseClass = new BaseClass();
            var derivedVirtual = new DerivedVirtual();
            var derivedNew = new DerivedNew();
            var derivedHidden = new DerivedHidden();

            Trace.WriteLine("Not casted versions");
            baseClass.Name();
            derivedVirtual.Name();
            derivedNew.Name();
            derivedHidden.Name();
            Trace.WriteLine("Casted to base versions");
            baseClass.Name();
            ((BaseClass)derivedVirtual).Name();
            ((BaseClass)derivedNew).Name();
            ((BaseClass)derivedHidden).Name();
        }
    }

    public class BaseClass
    {
        public virtual void Name()
        {
            Trace.WriteLine("Base");
        }
    }

    public class DerivedVirtual : BaseClass
        {
            public override void Name()
            {
                Trace.WriteLine("DerivedVirtual");
            }
        }

    public class DerivedNew : BaseClass
    {
        public new void Name()
        {
            Trace.WriteLine("DerivedNew");
        }
    }

    public class DerivedHidden : BaseClass
    {
        public void Name()
        {
            Trace.WriteLine("DerivedHidden");
        }
    }

}
