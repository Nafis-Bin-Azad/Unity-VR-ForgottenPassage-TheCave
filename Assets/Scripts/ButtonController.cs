using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;
using UnityEngine.UI;

[RequireComponent(typeof(VRInteractiveItem))]
public class ButtonController : MonoBehaviour {

        VRInteractiveItem vrInteractive;
        Button button;

        void Awake()
        {
            vrInteractive = GetComponent<VRInteractiveItem>();
            button = GetComponentInChildren<Button>();
        }

        void OnEnable()
        {
            vrInteractive.OnClick += button.onClick.Invoke;
        }

        void OnDisable()
        {
            vrInteractive.OnClick -= button.onClick.Invoke;
        }

    }
