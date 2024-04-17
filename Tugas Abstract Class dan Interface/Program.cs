using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Tugas_Abstract_Class_dan_Interface;

namespace Tugas_Abstract_Class_dan_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi karakter pemain
            Pemain player = new Pemain("Player", 105, 65, 25);

            // Inisialisasi musuh
            Enemy enemy = new Enemy("Enemy", 75, 10);

            // Inisialisasi skill
            Skill healSkill = new Heal(35);
            Skill fireballSkill = new Fireball(20);
            Skill iceBlastSkill = new IceBlast(30, 3);

            // Pemain menyerang musuh
            player.GunakanSkill(enemy);

            // Musuh menyerang pemain
            enemy.GunakanSkill(player);

            // Pemain menggunakan skill Heal pada dirinya sendiri
            healSkill.GunakanSkill(player);

            // Pemain menggunakan skill Fireball pada musuh
            fireballSkill.GunakanSkill(enemy);

            // Musuh menggunakan skill Ice Blast pada pemain
            iceBlastSkill.GunakanSkill(player);
        }
    }
}
