using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipableItem : Item
{
    public EquipmentSlot Slot;

    public int Vitality;
    public int Strength;
    public int Dexterity;
    public int Intellect;
    public int Faith;
    public int Tech;

    public double HP;
    public double HPRegen;
    public double Mana;
    public double ManaRegen;

    public int AttackPower;
    public int SpellPower;
    public int TechPower;

    public double CritChance;
    public double CritDamage;

    public int Armor;

    public int PoisonResist;
    public int ArcaneResist;
    public int FrostResist;
    public int FireResist;
    public int UnholyResist;

    public double getStat(Stat stat)
    {
        switch (stat)
        {
            case Stat.Vitality:
                return Vitality;
            case Stat.Strength:
                return Strength;
            case Stat.Dexterity:
                return Dexterity;
            case Stat.Intellect:
                return Intellect;
            case Stat.Faith:
                return Faith;
            case Stat.Tech:
                return Tech;

            case Stat.HP:
                return HP;
            case Stat.HPRegen:
                return HPRegen;
            case Stat.Mana:
                return Mana;
            case Stat.ManaRegen:
                return ManaRegen;

            case Stat.AttackPower:
                return AttackPower;
            case Stat.SpellPower:
                return SpellPower;
            case Stat.TechPower:
                return TechPower;

            case Stat.CritChance:
                return CritChance;
            case Stat.CritDamage:
                return CritDamage;

            case Stat.Armor:
                return Armor;

            case Stat.PoisonResist:
                return PoisonResist;
            case Stat.ArcaneResist:
                return ArcaneResist;
            case Stat.FrostResist:
                return FrostResist;
            case Stat.FireResist:
                return FireResist;
            case Stat.UnholyResist:
                return UnholyResist;
        }
        return -1;
    }
}
