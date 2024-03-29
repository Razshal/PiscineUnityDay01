﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex00 : MonoBehaviour
{
    public bool isSelected = false;
    public bool isGrounded = true;
    public float speed = 0.05f;
    public float jumpSpeed = 200;
    new private Rigidbody2D rigidbody2D;
    public GameObject mainCamera;
    public string key;

    // Use this for initialization
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            isGrounded = true;
    }

    void SelectCharacter()
    {
        if (Input.GetKeyDown(key))
        {
            isSelected = true;
            mainCamera.GetComponent<cameraScript>().selectedPlayer = gameObject;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1)
                 || Input.GetKeyDown(KeyCode.Alpha2)
                 || Input.GetKeyDown(KeyCode.Alpha3))
            isSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        SelectCharacter();
        if (isSelected)
        {
            rigidbody2D.velocity *= 0.99f;
            if (Input.GetKey(KeyCode.RightArrow))
                gameObject.transform.Translate(speed, 0, 0);
            if (Input.GetKey(KeyCode.LeftArrow))
                gameObject.transform.Translate(-speed, 0, 0);
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                rigidbody2D.AddForce(new Vector2(0, 1) * jumpSpeed, ForceMode2D.Force);
                isGrounded = false;
            }
        }
    }
}
