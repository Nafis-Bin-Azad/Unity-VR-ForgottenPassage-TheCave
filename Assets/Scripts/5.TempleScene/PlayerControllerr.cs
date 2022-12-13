using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerr : MonoBehaviour {

    private Vector3 pos;
    Rigidbody rigidBody;
    private bool moving = false;
    public float speed = 5;
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();

        if (moving)
        {
            //transform.position = pos;
            rigidBody.MovePosition(pos);
            moving = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Wall")
        {
            moving = false;
        }
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        { 
            pos += Vector3.right * 2;
            moving = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pos -= Vector3.right * 2;
            moving = true;
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            pos += Vector3.forward * 2;
            moving = true;
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            pos -= Vector3.forward * 2;
            moving = true;
        }
    }
}
