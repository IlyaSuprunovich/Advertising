﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertising
{
    public class ButtonRandomAdd : IButton
    {
        private Random _random = new Random();
        private Person _person;

        public ButtonRandomAdd(Person person)
        {
            this._person = person;
        }

        public void Click()
        {
           int choose = _random.Next(1, 4);

            switch (choose)
            {
                case 1:
                    _person.Health += 1;
                    break;

                case 2:
                    _person.Attack += 1;
                    break;

                case 3:
                    _person.Armor += 1;
                    break;
            }

            Console.WriteLine($"Здоровье: {_person.Health} Атака: {_person.Attack} Броня: {_person.Armor}");
        }
    }
}
