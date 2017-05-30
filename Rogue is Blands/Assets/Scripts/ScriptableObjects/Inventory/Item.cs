using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Item : ScriptableObject
{
    public uint ItemID;
    public string ItemName;

    public Sprite sprite;
}
