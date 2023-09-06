using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advertising
{
    public class ButtonExitAdvertising : IButton
    {
        delegate void myDelegate();
        ButtonWhithAdvertising _buttonWhithAdvertising;

        public ButtonExitAdvertising(ButtonWhithAdvertising buttonWhithAdvertising)
        {
            this._buttonWhithAdvertising = buttonWhithAdvertising;
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
                    _buttonWhithAdvertising.Click();
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
