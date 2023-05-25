using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 设计模式实战1_工厂模式.普通简单工厂;

namespace 设计模式实战1_工厂模式.简单工厂的延申___工厂方法模式
{
    public class ExpressSendFactory : IProvider
    {
        public ISender produce()
        {
            return new ExpressSender();
        }
    }
    public class EmailSendFactory : IProvider
    {
        public ISender produce()
        {
            return new EmailSender();
        }
    }
    public class SmsSendFactory : IProvider
    {
        public ISender produce()
        {
            return new SmsSender();
        }
    }
}
