// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Singleton
{

    // 使用类变量来缓存创建过的实例
    [ThreadStatic]
    private static volatile Singleton instance = null; // 保证instance线程同步

    private Singleton() { }
    //lock只能锁定一个引用类型变量
    private static object _lock = new object();

    // 使用synchronized关键字修饰，确保线程安全

    public static Singleton getInstance()
    {
        lock (_lock)
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

    }

}
/// <summary>
/// Singleton1懒汉式的特点是，类加载时没有创建实例，而是在调用 getInstance 方法时才去创建单例，所以就会存在线程安全性问题。但是每次访问都有同步问题，消耗资源，影响性能，所以建议使用如下饿汉式。
/// </summary>

public class Singleton1
{

    // 使用类变量来缓存创建过的实例
    private static Singleton1 instance = new Singleton1();

    private Singleton1() { }

    public static Singleton1 getInstance()
    {
        return instance;
    }
}
