using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data", order = 1)]
[System.Serializable]
public class DataItem : ScriptableObject
{
    public Sprite imgItem;
    public int quantityItem  = 1;
}
