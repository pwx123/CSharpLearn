using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    // 发布器类
    class EventTest
    {
        private int value;
        // 在类的内部声明事件，必须先声明事件的委托类型
        public delegate void NumManipulationHandler();
        public event NumManipulationHandler ChangeNum;
        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum(); // 事件被触发
            }
            else
            {
                Console.WriteLine("event not fire");
            }
        }
        public EventTest()
        {
            int n = 5;
            SetValue(n);
        }
        public void SetValue(int n)
        {
            if (value != n)
            {
                OnNumChanged();
            }
        }
    }
    public class SubscribEvent
    {
        public void Printf()
        {
            Console.WriteLine("event file");
        }
    }
    // 例1
    // 烧水
    public class Heater
    {
        private int temperature;
        public delegate void BoilHandler(int param);
        public event BoilHandler BoilEvent;

        public void BoilWater()
        {
            for (int i = 0; i <= 100; i++)
            {
                temperature = i;
                if (temperature > 95)
                {
                    BoilEvent?.Invoke(temperature); // 触发事件
                }
            }
        }
    }
    // 警报器
    public class Alarm
    {
        public void MakeAlert(int param)
        {
            Console.WriteLine("Alarm:水已经{0}度了", param);
        }
    }
    // 显示器
    public class Display
    {
        public static void ShowMsg(int param)
        {
            Console.WriteLine("Display：水快烧开了，当前温度：{0}度。", param);
        }
    }
    public class EventValue
    {
        public void PrintValue()
        {
            EventTest e = new EventTest();
            SubscribEvent s = new SubscribEvent();
            e.ChangeNum += new EventTest.NumManipulationHandler(s.Printf);
            e.SetValue(7);
            e.SetValue(11);
            // 例1
            Heater heater = new Heater();
            Alarm alarm = new Alarm();
            heater.BoilEvent += alarm.MakeAlert; //注册方法
            heater.BoilEvent += (new Alarm()).MakeAlert; //匿名注册
            heater.BoilEvent += Display.ShowMsg;
            heater.BoilWater(); //烧水
        }
    }
}
