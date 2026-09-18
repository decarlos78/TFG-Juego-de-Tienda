using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    [SerializeField] private BoxCollider Collider_Interactuable;

    public float Cost;


    public List<PC_Items> PC_Items; 


    void Start()
    {
        PC_Items = new List<PC_Items>();
    }

    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.matrix = Collider_Interactuable.transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Collider_Interactuable.center, Collider_Interactuable.size);
        Gizmos.matrix = Matrix4x4.identity;
    }
}
