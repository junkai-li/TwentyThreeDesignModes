using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    public interface  IFactory
    {
        ITelevision newTelevision();
        IRefrigerator newRefrigerator();
    }

    public interface ITelevision
    {
        void dosomething();
    }
    public interface IRefrigerator
    {
        void dosomething();
    }

    public class TCLFactory : IFactory
    {

        public ITelevision newTelevision()
        {
            return new TCLTelevision();
        }
        public IRefrigerator newRefrigerator()
        {
            return new TCLRefrigerator();
        }
    }
    public class MeiDFactory : IFactory
    {

        public ITelevision newTelevision()
        {
            return new MeiDTelevision();
        }
        public IRefrigerator newRefrigerator()
        {
            return new MeiDRefrigerator();
        }
    }

    public class TCLTelevision : ITelevision
    {
        public void dosomething()
        {
            Console.WriteLine("我是TCL电视机，我可以看电视");
        }
    }
    public class MeiDTelevision : ITelevision
    {

        public void dosomething()
        {
            Console.WriteLine("我是美的电视机，我可以看电视");
        }
    }
    public class TCLRefrigerator : IRefrigerator
    {
        public void dosomething()
        {
            Console.WriteLine("我是TCL冰箱，我可以洗衣服");
        }
    }
    public class MeiDRefrigerator : IRefrigerator
    {

        public void dosomething()
        {
            Console.WriteLine("我是美的冰箱，我可以洗衣服");
        }
    }
}
