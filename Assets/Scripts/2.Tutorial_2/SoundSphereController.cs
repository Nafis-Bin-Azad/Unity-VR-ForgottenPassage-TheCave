using UnityEngine;
using VRStandardAssets.Utils;

public class SoundSphereController : MonoBehaviour {

    private bool doubleClicked = false;
    private bool isSelected = false;
    private bool isChosenOne = false;

    private VRInteractiveItem itrItem;
    private Renderer rendererObj;
    public Canvas canvas;

    public Tutorial1Manager manager;

    public Material red_material;
    public Material green_material;
    public Material white_material;

    public int speed = 10;
    private int resumeSpeed;

    private AudioSource sphereAudio;

    private void Awake()
    {
        sphereAudio = gameObject.GetComponent<AudioSource>();
        itrItem = gameObject.GetComponent<VRInteractiveItem>();
        rendererObj = gameObject.GetComponent<Renderer>();
        //init canvas and start deactivated
        canvas = gameObject.GetComponentInChildren<Canvas>();
        manager = gameObject.GetComponentInParent<Tutorial1Manager>();
        canvas.enabled = false;
        rendererObj.material = white_material;
    }

    // Update is called once per frame
    void Update()
    {
        OrbitAroundObject();
    }

    public void PlayAudio()
    {
        sphereAudio.Play();
    }
    public void StopAudio()
    {
        sphereAudio.Stop();
    }

    private void OnEnable()
    {
        itrItem.OnClick += HandleDoubleClick;
    }


    private void OnDisable()
    {
        itrItem.OnClick -= HandleDoubleClick;
    }

    //Handle the DoubleClick event
    private void HandleDoubleClick()
    {
        if (isChosenOne)
        {
            manager.AdvanceToNextTutorial();
            rendererObj.material = green_material;
        }
        else
        {
            rendererObj.material = red_material;
            DisplayCanvas(true);
            manager.GetComponent<Tutorial1Manager>().StopMovingSpheres();
        }

    }

    //Checks if its the winning sphere and has been double clicked
    public bool IsDoubleClicked()
    {
        Debug.Log("Sphere-HasBeenClicked");
        return doubleClicked;
    }

    public void SetChoosenOne(bool value) 
    {
        Debug.Log("Sphere-SetChoosenOne");
        isChosenOne = value;
    }

    public void DisplayCanvas(bool value)
    {
        Debug.Log("Sphere-DisplayCanvas");
        canvas = gameObject.GetComponentInChildren<Canvas>();
        canvas.enabled = value;
    }

    void OrbitAroundObject()
    {
        transform.RotateAround(manager.transform.position, Vector3.down, speed * Time.deltaTime);
    }

    public void PauseOrbit()
    {
        Debug.Log("Sphere-PauseOrbit");
        resumeSpeed = speed;
        speed = 0;
    }

    public void ResumeOrbit()
    {
        Debug.Log("Sphere-ResumeOrbit");
        speed = resumeSpeed;
        rendererObj.material = white_material;
    }


    public void ResetSphere()
    {
        Debug.Log("Sphere-ResetSphere");
        doubleClicked = false;
        isSelected = false;
        isChosenOne = false;

    }

}
