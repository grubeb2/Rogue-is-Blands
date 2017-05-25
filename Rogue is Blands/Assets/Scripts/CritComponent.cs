using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CritComponent : MonoBehaviour
{

    private PrimaryStats primaryStats;
    
    public double CritChance = 0.05;
    public double CrtDamageMultiplier = 1.5;

    void calculate()
    {

    }

    void Start()
    {
        primaryStats = GetComponent<PrimaryStats>();
    }

}
