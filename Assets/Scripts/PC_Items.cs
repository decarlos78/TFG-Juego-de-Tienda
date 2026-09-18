using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "PC_Item", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]


public class PC_Items : ScriptableObject
{
    public float Item_Cost;
    public TextMeshProUGUI Item_Cost_Text;

    public int Item_ID;
    public string Item_Name;
    public Texture Item_Image;

    public bool Item_is_Available = true; 
}
