// See https://aka.ms/new-console-template for more information
using 抽象工厂模式;

Console.WriteLine("Hello, World!");
IFactory factory = new TCLFactory();
ITelevision television = factory.newTelevision();
IRefrigerator refrigerator = factory.newRefrigerator();

television.dosomething(); // 我是TCL电视机，我可以看电视
refrigerator.dosomething(); // 我是TCL冰箱，我可以洗衣服

factory = new MeiDFactory();
television = factory.newTelevision();
refrigerator = factory.newRefrigerator();

television.dosomething(); // 我是美的电视机，我可以看电视
refrigerator.dosomething(); // 我是美的冰箱，我可以洗衣服