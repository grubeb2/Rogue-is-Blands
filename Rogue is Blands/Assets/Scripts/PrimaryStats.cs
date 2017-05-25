using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryStats : MonoBehaviour
{

    public enum PrimaryStatTypes
    {
        Vitality,
        Strength,
        Dexterity,
        Intellect,
        Faith,
        Tech
    }

    public uint Vitality = 1;
    public uint Strength = 1;
    public uint Dexterity = 1;
    public uint Intellect = 1;
    public uint Faith = 1;
    public uint Tech = 1;

    void Update()
    {
        gameObject.SendMessage("calculate");
    }

}
