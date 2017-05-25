using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAPComponent : MonoBehaviour
{

    private PrimaryStats primaryStats;

    public double RangedAttackPower;

    void calculate()
    {
        RangedAttackPower = primaryStats.Dexterity;
    }

    void Start()
    {
        primaryStats = GetComponent<PrimaryStats>();
    }

}
