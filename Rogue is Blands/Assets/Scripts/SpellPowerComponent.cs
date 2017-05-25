using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellPowerComponent : MonoBehaviour
{

    private PrimaryStats primaryStats;

    public double SpellPower;

    void calculate()
    {
        SpellPower = primaryStats.Intellect;
    }

    void Start()
    {
        primaryStats = GetComponent<PrimaryStats>();
    }

}
