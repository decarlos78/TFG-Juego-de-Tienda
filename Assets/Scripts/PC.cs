using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    [SerializeField] private BoxCollider Collider_Interactuable;

    public float Cost;
    void Start()
    {

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
