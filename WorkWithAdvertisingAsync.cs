using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertising
{
    public class WorkWithAdvertisingAsync
    {
        private ButtonWhithAdvertising _buttonWhithAdvertising;
        private ButtonExitAdvertising _buttonExitAdvertising;
        private Person _person;
        public WorkWithAdvertisingAsync(ButtonWhithAdvertising buttonWhithAdvertising, ButtonExitAdvertising buttonExitAdvertising, Person person)
        {
            this._buttonWhithAdvertising = buttonWhithAdvertising;
            this._buttonExitAdvertising = buttonExitAdvertising;
            this._person = person;
        }


        public async Task AdvertisingAsync()
        {
            Task advertisingTimer = _buttonWhithAdvertising.ButtonClickAsync();
            Task advertisingExit = _buttonExitAdvertising.ExitAdvettisingAsync();

            await Task.WhenAny(advertisingExit, advertisingTimer);

            if (advertisingExit.IsCanceled)
            {
                Console.WriteLine("В следующий раз смотри рекламу");
            }
            else if (advertisingTimer.IsCanceled)
            {

                _person.Health += 5;
                _person.Attack += 5;
                _person.Armor += 5;
                Console.WriteLine($"Здоровье: {_person.Health} Атака: {_person.Attack} Броня: {_person.Armor}");
            }
            //Не понимаю как зыкрывать потоки. т.е. Если у меня выход сработал, то надо прекратить выполнение таймера.
            //И если таймер досчитал до конца, то не надо вводить число для прекращения работы рекламы.
        }
    }
}
