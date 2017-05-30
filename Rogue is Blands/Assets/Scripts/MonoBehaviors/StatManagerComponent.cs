using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Stat : uint
{
    Vitality,
    Strength,
    Dexterity,
    Intellect,
    Faith,
    Tech,
    HP,
    HPRegen,
    Mana,
    ManaRegen,
    AttackPower,
    SpellPower,
    TechPower,

    CritChance,
    CritDamage,

    Armor,

    PoisonResist,
    ArcaneResist,
    FrostResist,
    FireResist,
    UnholyResist
}

public class StatManagerComponent : MonoBehaviour
{
    public EquipmentComponent EquipmentComponent;

    public double get(Stat stat)
    {
        switch (stat)
        {
            case Stat.Vitality:
                return ;
            case Stat.Strength:
                break;
            case Stat.Dexterity:
                break;
            case Stat.Intellect:
                break;
            case Stat.Faith:
                break;
            case Stat.Tech:
                break;
            case Stat.HP:
                break;
            case Stat.HPRegen:
                break;
            case Stat.Mana:
                break;
            case Stat.ManaRegen:
                break;
            case Stat.AttackPower:
                break;
            case Stat.SpellPower:
                break;
            case Stat.TechPower:
                break;
            case Stat.CritChance:
                break;
            case Stat.CritDamage:
                break;
            case Stat.Armor:
                break;
            case Stat.PoisonResist:
                break;
            case Stat.ArcaneResist:
                break;
            case Stat.FrostResist:
                break;
            case Stat.FireResist:
                break;
            case Stat.UnholyResist:
                break;
            default:
                break;
        }
        return -1;
    }
}
