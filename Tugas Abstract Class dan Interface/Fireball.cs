using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Abstract_Class_dan_Interface
{
    class Fireball : Skill
    {
        private int damage;

        public Fireball(int damage)
        {
            this.damage = damage;
        }

        public void GunakanSkill(Karakter target)
        {
            Console.WriteLine($"{target.nama} Menggunakan skill Fireball");
            target.HP -= damage;
            if (target.HP <= 0)
            {
                target.HP = 0;
                target.CetakInformasi();
                Console.WriteLine($"{target.nama} telah mati.");
            }
            else
            {
                target.CetakInformasi();
            }
        }
    }
}
