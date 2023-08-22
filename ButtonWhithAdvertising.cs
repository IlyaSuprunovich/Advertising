using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Advertising
{
    public class ButtonWhithAdvertising :IButton
    {
        delegate void myDelegate();

        private Person _person;
        private ButtonExitAdvertising _buttonExitAdvertising;

        public ButtonWhithAdvertising(Person person)
        {
            this._person = person;
            _buttonExitAdvertising = new ButtonExitAdvertising();
        }

        public void Click()
        {
            //SetAction(ButtonClick);           
        }

        private void SetAction(myDelegate myDelegate)
        {
            myDelegate.Invoke();
        }

        public async Task<bool> ButtonClickAsync()
        {
            var result = await Task.Run(() => ButtonClick());
            return result;

        }

        private bool ButtonClick()
        {
            Console.WriteLine("Вы точно хотите посмотреть рекламу?\n1. Да хочу\n2. Нет не хочу");

            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
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
                       /* _person.Health += 5;
                        _person.Attack += 5;
                        _person.Armor += 5;
                        Console.WriteLine($"Здоровье: {_person.Health} Атака: {_person.Attack} Броня: {_person.Armor}");*/
                    }



                }
            return false;
        }

        /* private void ButtonClick()
         {

             try
             {
                 DateTime tenSecond = DateTime.Now;
                 DateTime temp = tenSecond.AddSeconds(10.0);
                 _buttonExitAdvertising.ExitAdvettisingAsync();
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
                            break;
                     }
                        Console.WriteLine(i);
                    }
                    break;
                case 2:
                    _buttonExitAdvertising.Click();
                    break;
            }


                 }
             }
             catch (BreakException exception)
             {
                 Console.WriteLine(exception.Message);
                 throw;
             }

         }*/
    }
}
