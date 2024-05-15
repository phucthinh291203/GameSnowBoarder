using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 4f;
    [SerializeField] float boostSpeed = 100f;
    [SerializeField] float baseSpeed = 20f;
    Rigidbody2D rigidbody;
    SurfaceEffector2D surfaceEffector2d;
    bool canMove = true;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        surfaceEffector2d = FindObjectOfType<SurfaceEffector2D>();
    }

    
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            ResponToBoost();
        }
    }

   public void DisableMove()
    {
        canMove = false;
    }
   private void ResponToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2d.speed = boostSpeed;
        }
        else surfaceEffector2d.speed = baseSpeed;
    }

   private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddTorque(torqueAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddTorque(-torqueAmount);
        }
    }
}
