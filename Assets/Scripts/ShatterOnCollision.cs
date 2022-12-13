using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class ShatterOnCollision : MonoBehaviour {

    private VRInteractiveItem interactiveItem;
    public GameObject replacement;

    void OnCollisionEnter() {

    }
    private void Awake()
    {
        interactiveItem = gameObject.GetComponent<VRInteractiveItem>();
    }

    private void OnEnable()
    {
        interactiveItem.OnDoubleClick += HandleDoubleClick;
    }


    private void OnDisable()
    {
        interactiveItem.OnDoubleClick -= HandleDoubleClick;
    }

    //Handle the DoubleClick event
    private void HandleDoubleClick()
    {
        Instantiate(replacement, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    //Handle the DoubleClick event
    private void BreakFloor()
    {
        Instantiate(replacement, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
