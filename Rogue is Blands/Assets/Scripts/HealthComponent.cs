using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{

    private PrimaryStats primaryStats;

    public double HP;
    public double HPRegen;

    public bool isAlive()
    {
        return 0 < HP;
    }

    void calculate()
    {
        HP = primaryStats.Vitality * 2 + 3;
        HPRegen = primaryStats.Faith / 10.0;
    }

    void Start()
    {
        primaryStats = GetComponent<PrimaryStats>();
    }

    void Update()
    {
        HP += HPRegen * Time.deltaTime;
    }
}
