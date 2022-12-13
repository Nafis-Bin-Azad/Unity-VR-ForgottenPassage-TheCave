using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

    public Material fused_bulb_color;
    public Renderer lightOne;
    public Renderer lightTwo;
    private Light lightSource;
    private AudioSource lightAudio;
    private bool dimLights;

    void Awake () {
        lightSource = gameObject.GetComponent<Light>();
        lightAudio = gameObject.GetComponent<AudioSource>();
        dimLights = false;
    }
    void Update()
    {
        if(dimLights)
        if (lightSource.intensity >= 0)
            lightSource.intensity -= 0.1f;
    }

    public void TurnOffLights()
    {
        Debug.Log("Turning lights off");
        lightAudio.Play();
        lightAudio.PlayDelayed(1);
        //lightSource.enabled = false;
        lightOne.material = fused_bulb_color;
        lightTwo.material = fused_bulb_color;
        dimLights = true;
    }
}
