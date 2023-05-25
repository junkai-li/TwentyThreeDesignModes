using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 设计模式实战1_工厂模式.普通简单工厂;

namespace 设计模式实战1_工厂模式.静态方法简单工厂
{
    public static class SendFactory
    {
        public static ISender produceSms()
        {
            return new SmsSender();
        }

        public static ISender produceEmail()
        {
            return new EmailSender();
        }

        public static ISender produceExpress()
        {
            return new ExpressSender();
        }
    }
}
