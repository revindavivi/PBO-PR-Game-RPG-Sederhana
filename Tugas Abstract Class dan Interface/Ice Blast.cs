using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tugas_Abstract_Class_dan_Interface
{
    class IceBlast : Skill
    {
        private int damage;
        private int slowDuration;

        public IceBlast(int damage, int slowDuration)
        {
            this.damage = damage;
            this.slowDuration = slowDuration;
        }

        public void GunakanSkill(Karakter target)
        {
            Console.WriteLine($"{target.nama} Menggunakan skill Ice Blast");
            target.HP -= damage;
            Console.WriteLine($"HP {target.nama} berkurang.");
            // Logika perlambatan musuh
            Console.WriteLine($"Enemy dan {target.nama} terkena perlambatan.");
            Console.WriteLine($"Durasi perlambatan: {slowDuration} detik");
            target.CetakInformasi();
        }
    }
}