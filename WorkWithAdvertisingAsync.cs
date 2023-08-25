using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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
            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            Task advertisingTimer = _buttonWhithAdvertising.ButtonClickAsync(cancellationToken.Token);
            Task advertisingExit = _buttonExitAdvertising.ExitAdvettisingAsync(cancellationToken.Token);
            Task[] tasks = new Task[2] {advertisingTimer, advertisingExit}; 
            Task.WaitAny(tasks);
            if (advertisingExit.IsCompleted)
            {
                Console.WriteLine("В следующий раз смотри рекламу");
                cancellationToken.Cancel();
               
            }
            else if (advertisingTimer.IsCompleted )
            {
                _person.Health += 5;
                _person.Attack += 5;
                _person.Armor += 5;
                Console.WriteLine($"Здоровье: {_person.Health} Атака: {_person.Attack} Броня: {_person.Armor}");
                cancellationToken.Cancel();
                
            }
            
            
        }
    }
}
