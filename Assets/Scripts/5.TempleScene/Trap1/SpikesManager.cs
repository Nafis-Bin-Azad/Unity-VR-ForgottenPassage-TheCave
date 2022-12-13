using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesManager : MonoBehaviour {


    public int timeDelay = 3;
    Transform[] spikes;
    SpikesMovement singleSpike;
    int randomSpike;
    private bool spikesActive;

    void Start () {

        SetupSpikes();
        spikesActive = true;
        StartCoroutine(moveSpike());

    }

    void SetupSpikes()
    {
        spikes = GetComponentsInChildren<Transform>();
        //Choose Random Spike
        randomSpike = Random.Range(0, spikes.Length);

        singleSpike = spikes[randomSpike].GetComponentInChildren<SpikesMovement>();
    }

    IEnumerator moveSpike(){
        while(spikesActive)
        {
            if (singleSpike) singleSpike.ActivateSpike();
            else SetupSpikes();
            yield return new WaitForSeconds(timeDelay);
        }
    }

    public void StopSpikeMovement()
    {
        spikesActive = false;
    }
    public void StartSpikeMovement()
    {
        spikesActive = true;
    }


}
