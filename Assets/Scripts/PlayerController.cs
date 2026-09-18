using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //poner en fixed update el movimiento y mejorarlo

    private Rigidbody rb;

    [SerializeField] private float MovementSpeed = 6.0f;
    private float StopMoveCounter = 0f;
    [SerializeField] private float StopMoveMargin = 1.5f;
    private bool KeyReleased = false;

    [SerializeField] private float JumpForce = 6f;


    [SerializeField] private TextMeshProUGUI MoneyText;
    public float Cash;

    [SerializeField] private GameObject PC_Interface;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void Start()
    {
        MoneyText.text = "Dinero: " + Cash + "$";
    }
    void Update()
    {
        MoneyText.text = "Dinero: " + Cash + "$";

        Inputs();
        if (KeyReleased) StopMoveCounter += Time.deltaTime;
        if (StopMoveCounter >= StopMoveMargin)
        {
            KeyReleased = false;
            rb.velocity = Vector3.Lerp(Vector3.zero, rb.velocity, StopMoveMargin);
            StopMoveCounter = 0f;
        }

    }
    private void FixedUpdate()
    {
        Movement();
    }
    private void Inputs()
    {
        //a lo mejor se cambia al nuevo input system luego si luisja nos enseña
        #region

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, MovementSpeed);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            KeyReleased = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-MovementSpeed, rb.velocity.y, rb.velocity.z);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            KeyReleased = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -MovementSpeed);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            KeyReleased = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(MovementSpeed, rb.velocity.y, rb.velocity.z);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            KeyReleased = true;
        }

        #endregion

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y + JumpForce, rb.velocity.z);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) //desactivar interfaz y cerrar menús
        {
            PC_Interface.SetActive(false);
        }
    }
    private void Movement()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer != 6) return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            PC_Interface.SetActive(true);
        }
    }
}
