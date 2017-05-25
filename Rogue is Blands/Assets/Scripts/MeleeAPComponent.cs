using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAPComponent : MonoBehaviour
{

    private PrimaryStats primaryStats;

    public double MeleeAttackPower;

    void calculate()
    {
        MeleeAttackPower = primaryStats.Strength;
    }

    void Start()
    {
        primaryStats = GetComponent<PrimaryStats>();
    }
}
