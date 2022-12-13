using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesMovement : MonoBehaviour {

    AudioSource m_MyAudioSource;

    void Start () {
        m_MyAudioSource = gameObject.GetComponent<AudioSource>();
    }

    public void ActivateSpike(){
        GetComponent<Animation>().Play();
        if(m_MyAudioSource) m_MyAudioSource.Play();
    }

    public void DeactivateSpike()
    {
        GetComponent<Animation>().Stop();
        if (m_MyAudioSource) m_MyAudioSource.Stop();
    }
}
