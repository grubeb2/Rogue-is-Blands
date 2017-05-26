using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryStatComponent : MonoBehaviour
{
    public const int STAT_COUNT = 6;

    public enum Stats : uint
    {
        Vitality = 0,
        Strength = 1,
        Dexterity = 2,
        Intellect = 3,
        Faith = 4,
        Tech = 5
    }

    private uint Vitality = 1;
    private uint Strength = 1;
    private uint Dexterity = 1;
    private uint Intellect = 1;
    private uint Faith = 1;
    private uint Tech = 1;

}
