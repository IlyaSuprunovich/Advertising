using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertising
{
    public class App
    {
        Person Person;
        ButtonRandomAdd ButtonRandomAdd;
        ButtonWhithAdvertising ButtonWhithAdvertising;
        ButtonExitAdvertising ButtonExitAdvertising;

        public App()
        {
            Person = new Person();
            ButtonRandomAdd = new ButtonRandomAdd(Person);
            ButtonWhithAdvertising = new ButtonWhithAdvertising(Person);
            ButtonExitAdvertising = new ButtonExitAdvertising();
        }

        public void StartApp()
        {
            while (true)
            {
                Console.WriteLine("Нажмите 1 чтобы увеличить одну из статов рандомно на 1\nНажмите 2 чтобы посмотреть рекламу и увеличить все статы на 5");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        ButtonRandomAdd.Click();
                        break;
                    case 2:
                        ButtonWhithAdvertising.Click();
                        break;
                    default:
                        Console.WriteLine("Такой кнопки не существует");
                        break;

                }
            }
        }
    }

    
}
