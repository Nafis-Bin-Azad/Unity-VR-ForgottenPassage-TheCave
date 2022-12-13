using UnityEngine;
using System.Collections;

public class BasicMovement : MonoBehaviour
{
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
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(movementX * speed * Time.deltaTime, 0.0f, movementY * speed * Time.deltaTime);
        Vector3 newPos = transform.position + movementDirection;
        rigidBody.MovePosition(newPos);
    }
}
