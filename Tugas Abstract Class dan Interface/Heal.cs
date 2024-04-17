using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Abstract_Class_dan_Interface
{
    class Heal : Skill
    {
        private int healAmount;

        public Heal(int healAmount)
        {
            this.healAmount = healAmount;
        }

        public void GunakanSkill(Karakter target)
        {
            Console.WriteLine($"{target.nama} Menggunakan skill Heal");
            target.HP += healAmount;
            target.CetakInformasi();
        }
    }
}