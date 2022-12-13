using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitAround : MonoBehaviour {

    public GameObject obj;
    public int speed = 10;
    private int resumeSpeed;

	// Update is called once per frame
	void Update () {
        OrbitAroundObject();
    }

    void OrbitAroundObject()
    {
        transform.RotateAround(obj.transform.position, Vector3.down, speed * Time.deltaTime);
    }

    public void pauseOrbit() 
    {
        resumeSpeed = speed;
        speed = 0;
    }

    public void resumeOrbit() {
        speed = resumeSpeed;
    }

}
