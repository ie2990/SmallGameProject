using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Controller controller;
    public float speed = 40f;
    float LRmove = 0f;
    bool jump = false;

    void Update()
    {
        LRmove = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(LRmove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
