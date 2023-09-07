using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advertising
{
    public class ButtonAdvertising : IButton
    {
        delegate void myDelegate();
        Person _person;

        public ButtonAdvertising(Person person)
        {
            this._person = person;   
        }


        public void Click()
        {
           SetAction(ExitAdvettising);
        }

        private void SetAction(myDelegate myDelegate)
        {
            myDelegate.Invoke();
        }

        private void ExitAdvettising()
        {
            Console.WriteLine("Вы точно хотите смотреть рекламу?\n1. Да\n2. Нет");
           
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Реклама просмотрена!");
                    _person.Health += 5;
                    _person.Attack += 5;
                    _person.Armor += 5;
                    Console.WriteLine($"Здоровье: {_person.Health} Атака: {_person.Attack} Броня: {_person.Armor}");
                    break;
                case 2:
                    Console.WriteLine("В следующий раз смотрите рекламу");
                    break;
                default:
                    Console.WriteLine("Такой кнопки не существует");
                    break;
            }
        }
    }
}
