using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Abstract_Class_dan_Interface;

namespace Tugas_Abstract_Class_dan_Interface
{
    class Pemain : Karakter
    {
        public Pemain(string name, int HP, int MP, int strength) : base(name, HP, MP, strength)
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

            }
            else
            {
                target.CetakInformasi();
            }
        }

        public override void CetakInformasi()
        {
            Console.WriteLine($"Karakter: {this.nama} | HP: {this.HP} | MP: {this.MP}");
        }
    }
}
