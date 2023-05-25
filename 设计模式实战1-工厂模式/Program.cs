// See https://aka.ms/new-console-template for more information
using 设计模式实战1_工厂模式.多方法简单工厂;
using 设计模式实战1_工厂模式.普通简单工厂;

Console.WriteLine("Hello, World!");
sendFactory1();
sendFactory2();
#region 简单工厂 
void sendFactory1()
{
    Console.WriteLine("设计模式实战1_工厂模式.普通简单工厂");
    设计模式实战1_工厂模式.普通简单工厂.SendFactory sendFactory = new();
    ISender senderSms = sendFactory.produce("sms");
    senderSms.Send(); // 发送短信

    ISender senderEmail = sendFactory.produce("email");
    senderEmail.Send(); // 发送邮件

    ISender senderExpress = sendFactory.produce("express");
    senderExpress.Send(); // 发送快递 
}
#endregion

#region 多方法简单工厂 
void sendFactory2()
{
    Console.WriteLine("设计模式实战1_工厂模式.多方法简单工厂");
    设计模式实战1_工厂模式.多方法简单工厂.SendFactory sendFactory1 = new();
    ISender senderSms1 = sendFactory1.produceSms();
    senderSms1.Send(); // 发送短信

    ISender senderEmail1 = sendFactory1.produceEmail();
    senderEmail1.Send(); // 发送邮件

    ISender senderExpress1 = sendFactory1.produceExpress();
    senderExpress1.Send(); // 发送快递 
}

#endregion

#region 静态方法简单工厂 
void sendFactory3()
{
    Console.WriteLine("设计模式实战1_工厂模式.静态方法简单工厂");
    ISender senderSms1 = 设计模式实战1_工厂模式.静态方法简单工厂.SendFactory.produceSms();
    senderSms1.Send(); // 发送短信

    ISender senderEmail1 = 设计模式实战1_工厂模式.静态方法简单工厂.SendFactory.produceEmail();
    senderEmail1.Send(); // 发送邮件

    ISender senderExpress1 = 设计模式实战1_工厂模式.静态方法简单工厂.SendFactory.produceExpress();
    senderExpress1.Send(); // 发送快递 
}

#endregion