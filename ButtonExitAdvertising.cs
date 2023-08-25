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
        delegate Task<bool> myDelegate();
        public CancellationTokenSource CancelTokenSource;
        public CancellationToken Token;
        public ButtonExitAdvertising()
        {
            CancelTokenSource = new CancellationTokenSource();
            Token = CancelTokenSource.Token;
        }


        public void Click()
        {
           SetAction(ExitAdvettisingAsync);
        }

        private void SetAction(myDelegate myDelegate)
        {
            myDelegate.Invoke();
        }

        public async Task<bool> ExitAdvettisingAsync()
        {
            var result = await Task.Run(() => ExitAdvettising(), Token);
            return result;
            
        }

        private bool ExitAdvettising()
        {
            
            Console.WriteLine("Введите 0 если не хотите смотреть рекламу");
           
            int input = Convert.ToInt32(Console.ReadLine());
            if (Token.IsCancellationRequested)  // проверяем наличие сигнала отмены задачи
            {
                Console.WriteLine("Операция прервана");
                input = 1;
                //  выходим из метода и тем самым завершаем задачу
            }
            if (input == 0)
            {
                Console.WriteLine("Вы не получили вознаграждение");
            }
            return true;
        }
    }
}
