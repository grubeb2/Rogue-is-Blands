﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaComponent : MonoBehaviour
{
    public double MaxMana;
    public double ManaRegen;

    public bool Regen;

    public double Mana;

    void Update()
    {
        if (Regen)
        {
            if (Mana < MaxMana)
            {
                Mana += ManaRegen * Time.deltaTime;
            }
            else if (Mana > MaxMana)
            {
                Mana = MaxMana;
            }
        }
    }
}
