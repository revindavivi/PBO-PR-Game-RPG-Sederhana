using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Abstract_Class_dan_Interface;

namespace Tugas_Abstract_Class_dan_Interface
{
    class Enemy : Karakter
    {
        public Enemy(string name, int HP, int strength) : base(name, HP, 0, strength)
        {
        }

        public override void GunakanSkill(Karakter target)
        {
            Console.WriteLine($"{this.nama} menyerang {target.nama}");
            target.HP -= this.strength;
            if (target.HP <= 0)
            {
                target.HP = 0;
                target.CetakInformasi();
                this.CetakInformasi();
                Die();
            }
            else
            {
                target.CetakInformasi();
            }
        }

        public override void CetakInformasi()
        {
            Console.WriteLine($"Musuh: {this.nama} | HP: {this.HP}");
        }

        public void Die()
        {
            Console.WriteLine($"{this.nama} telah mati.");
        }
    }
}

