using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Items : ScriptableObject
{
    public string itemName;
    public Sprite imageIcon;
    [TextArea]
    public string itemDescription;
    public bool hasItem = false;



}

