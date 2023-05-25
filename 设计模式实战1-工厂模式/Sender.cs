using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式实战1_工厂模式.普通简单工厂
{
    public class Sender : ISender
    {
        public void Send()
        {
            Console.WriteLine("发送");
        }
    }

    public class SmsSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("发送短信");
        }
    }


    public class EmailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("发送邮件");
        }
    }

    public class ExpressSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("发送快递");
        }
    }
}
