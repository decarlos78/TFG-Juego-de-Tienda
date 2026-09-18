using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    [SerializeField] private PlayerController PlayerScript;
    [SerializeField] private PC PC_Script;

    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void BuyButton(float ItemCost)
    {
        //Cost luego sumará todos los items que añadas al carro en el pc

        ItemCost = PC_Script.Cost;
        PlayerScript.Cash -= ItemCost;
    }
}
