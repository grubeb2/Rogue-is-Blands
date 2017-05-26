using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public double MaxHP;
    public double HPRegen;

    public double HP;

    public bool isAlive()
    {
        return 0 < HP;
    }

    void Update()
    {
        if (HP < MaxHP)
        {
            HP += HPRegen * Time.deltaTime;
        }
        else if (HP > MaxHP)
        {
            HP = MaxHP;
        }
    }
}
