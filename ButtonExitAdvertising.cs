using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertising
{
    public class ButtonExitAdvertising : IButton
    {
        delegate void myDelegate();
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
            Console.WriteLine("Вы не получили вознаграждение");
        }
    }
}
