using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaComponent : MonoBehaviour
{

    private PrimaryStats primaryStats;

    public double Mana;
    public double ManaRegen;

    void calculate()
    {
        Mana = primaryStats.Intellect * 2 + 3;
        ManaRegen = 1 + (primaryStats.Faith + Mathf.Sqrt(primaryStats.Intellect)) / 10.0;
    }

    void Start()
    {
        primaryStats = GetComponent<PrimaryStats>();
    }

    void Update()
    {
        Mana += ManaRegen * Time.deltaTime;
    }
}
