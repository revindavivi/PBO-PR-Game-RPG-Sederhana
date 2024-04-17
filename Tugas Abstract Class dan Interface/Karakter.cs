using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Abstract_Class_dan_Interface;

namespace Tugas_Abstract_Class_dan_Interface;

abstract class Karakter
{
    public string nama;
    public int HP;
    public int MP;
    public int strength;

    public Karakter(string name, int HP, int MP, int strength)
    {
        this.nama = name;
        this.HP = HP;
        this.MP = MP;
        this.strength = strength;
    }
    public abstract void GunakanSkill(Karakter target);

    public abstract void CetakInformasi();
}