using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式实战1_工厂模式.普通简单工厂
{
    public class SendFactory
    {
        public ISender produce(String type)
        {
            if (type == null)
            {
                return null;
            }
            else if ("email" == type)
            {
                return new EmailSender();
            }
            else if ("sms" == type)
            {
                return new SmsSender();
            }
            else if ("express" == type)
            {
                return new ExpressSender();
            }
            else
            {
                return null;
            }
        }
    }
}
