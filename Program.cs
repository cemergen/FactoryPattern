using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();

            IceCream strawBerry = creator.IceCreamFactory(IceCreamTypes.Strawberry);
            IceCream vanilla = creator.IceCreamFactory(IceCreamTypes.Vanilla);
            IceCream[] iceCreamArry = { vanilla, strawBerry };
            foreach (var item in iceCreamArry)
            {
                item.Type();
            }

        }

        public enum IceCreamTypes
        {
            Strawberry,
            Chocolate,
            Vanilla
        }

        public abstract class IceCream
        {
            public abstract void Type();
        }

        public class Strawberry : IceCream
        {
            public override void Type()
            {
                Console.WriteLine("Strawberry");
            }
        }
        public class Chocolate : IceCream
        {
            public override void Type()
            {
                Console.WriteLine("Chocolate");
            }
        }

        public class Vanilla : IceCream
        {
            public override void Type()
            {
                Console.WriteLine("Vanilla");
            }
        }

        public class Creator
        {
            public IceCream IceCreamFactory(IceCreamTypes iceCreamTypes)
            {
                IceCream iceCream = null;
                switch (iceCreamTypes)
                {
                    case IceCreamTypes.Strawberry:
                        iceCream = new Strawberry();
                        break;
                    case IceCreamTypes.Chocolate:
                        iceCream = new Chocolate();
                        break;
                    case IceCreamTypes.Vanilla:
                        iceCream = new Vanilla();
                        break;
                }
                return iceCream;
            }
        }
    }
}
