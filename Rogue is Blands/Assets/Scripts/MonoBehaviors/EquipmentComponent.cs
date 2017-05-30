using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentSlot
{
    Head,
    Chest,
    Legs,
    Boots,
    Ring1,
    Ring2,
    Hand1,
    Hand2,
    TwoHand,
    Shield
}

public class EquipmentComponent : MonoBehaviour {

    private EquipableItem[] equipment;

    public EquipableItem Equip(EquipableItem e)
    {
        EquipableItem _e = equipment[(uint)e.Slot];
        equipment[(uint)e.Slot] = e;
        return _e;
    }

    public EquipableItem get(EquipmentSlot slot)
    {
        return equipment[(uint)slot];
    }

    public double getStat(Stat stat)
    {
        double _stat = 0;
        foreach (EquipableItem e in equipment)
        {
            if (e != null)
            {
                _stat += e.getStat(stat);
            }
        }
        return _stat;
    }
}
