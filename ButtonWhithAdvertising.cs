using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Advertising
{
    public class ButtonWhithAdvertising : IButton
    {
        delegate void myDelegate();
        private Person _person;

        public ButtonWhithAdvertising(Person person)
        {
            this._person = person;      
        }

        public void Click()
        {
            SetAction(ButtonClick);           
        }

        private void SetAction(myDelegate myDelegate)
        {
            myDelegate.Invoke();
        }

        private void ButtonClick()
        {
            DateTime tenSecond = DateTime.Now;
            DateTime temp = tenSecond.AddSeconds(10.0);
            for (int i = 10; i >= 0; i--)
            {
                
                Console.WriteLine(i);
                DateTime dateTime = DateTime.Now;
                Thread.Sleep(1000);
                if (dateTime.Second == temp.Second)
                {
                    Console.WriteLine("Реклама просмотрена!");
                    _person.Health += 5;
                    _person.Attack += 5;
                    _person.Armor += 5;
                    Console.WriteLine($"Здоровье: {_person.Health} Атака: {_person.Attack} Броня: {_person.Armor}");
                }  
            }
        }
    }
}
