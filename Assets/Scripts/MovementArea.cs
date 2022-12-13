using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

[RequireComponent(typeof(VRInteractiveItem))]
public class MovementArea : MonoBehaviour {

    VREyeRaycaster vrEyeRaycaster;
    VRInteractiveItem interactiveItem;
    PlayerMovementController playerController;

    void Awake()
    {
        // get interactive vr item component
        interactiveItem = GetComponent<VRInteractiveItem>();

        // get vr eye rascaster
        vrEyeRaycaster = FindObjectOfType<VREyeRaycaster>();

        if(vrEyeRaycaster == null)
        {
            Debug.LogError("There needs to be a VR Eye Raycaster in the scene");
        }

        // get player free teleport controller
        playerController = FindObjectOfType<PlayerMovementController>();

        if (playerController == null)
        {
            Debug.LogError("There needs to be a PlayerMovementController in the scene");
        }
    }

    void OnEnable()
    {
        // subscribe to events
        vrEyeRaycaster.OnRaycasthit += HandleShowTarget;
        interactiveItem.OnOut += HandleOut;
        interactiveItem.OnClick += HandleClick;
    }

    void OnDisable()
    {
        // unsubscribe to events
        vrEyeRaycaster.OnRaycasthit -= HandleShowTarget;
        interactiveItem.OnOut -= HandleOut;
        interactiveItem.OnClick -= HandleClick;
    }

    void HandleClick()
    {
        Debug.Log("Clicked");
        playerController.Teleport();
    }

    void HandleOut()
    {
        playerController.HideTarget();
    }

    void HandleShowTarget(RaycastHit hit)
    {
        Debug.Log("Ray hit");
        playerController.ShowTarget(hit.point);
    }

    
}
