using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial1Manager : MonoBehaviour {

    public SoundSphereController[] spheres;
    SoundSphereController choosenSphere;
    int randomSphere;

    // Use this for initialization
    void Awake () {
        spheres = GetComponentsInChildren<SoundSphereController>();
        SelectRandomSphere();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void SelectRandomSphere()
    {
        randomSphere = Random.Range(0, spheres.Length);
        choosenSphere = spheres[randomSphere];
        choosenSphere.SetChoosenOne(true);
        choosenSphere.PlayAudio();
    }

    public void AdvanceToNextTutorial()
    {
        Debug.Log("Increasing level Lower");
        LevelManagerController.instance.IncreaseLevel();
    }

    public void StopMovingSpheres()
    {
        foreach (SoundSphereController sphere in spheres)
        {
            sphere.ResetSphere();
            sphere.PauseOrbit();
            sphere.StopAudio();
        }
    }

    public void ResumeOrbit()
    {
        foreach (SoundSphereController sphere in spheres)
        {
            sphere.DisplayCanvas(false);
            sphere.ResumeOrbit();
        }
        SelectRandomSphere();
    }


}
