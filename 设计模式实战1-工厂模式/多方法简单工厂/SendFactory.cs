using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 设计模式实战1_工厂模式.普通简单工厂;

namespace 设计模式实战1_工厂模式.多方法简单工厂
{
    public class SendFactory
    {
        public ISender produceSms()
        {
            return new SmsSender();
        }

        public ISender produceEmail()
        {
            return new EmailSender();
        }

        public ISender produceExpress()
        {
            return new ExpressSender();
        }
    }
}
