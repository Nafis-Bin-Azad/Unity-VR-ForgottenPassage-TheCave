using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxController : MonoBehaviour {

    // private Vector3 pos;
    // Rigidbody rigidBody;
    // private bool moving = false;
    // private bool left = false;
    // private bool right = false;
    // private bool center = true;
    // private int rowMax = 18;
    // private int rowIndex = 0;
    // private int textIndex = 0;
    // public LightController lightsControl;
    // public GameObject textPanel;
    // private Text text;
    // private string[] textArray;
    // public SpikesManager[] arraySpikes;

    // // Use this for initialization
    // void Start()
    // {
    //     rowIndex = 0;
    //     rigidBody = GetComponent<Rigidbody>();
    //     textPanel.SetActive(false);
    //     text = textPanel.GetComponentInChildren<Text>();
    //     pos = transform.position;
    //     LoadText();
    // }

    // private void LoadText()
    // {
    //     textArray = new string[] { 
    //     "Is it just me, or are those spikes coming out of the ground?", 
    //     "If I want to get out of here alive, it seems I am going to have to cross this passage without getting skewered.",
    //     "Aaaaaand there goes my hope of getting out of here alive! The lights just had to go out now!",
    //     "Instructions:  Choose which way you would like to move by selecting an arrow. The green arrows move forward, choose wisely.", 
    //     "Instructions:  Red arrows allow you to move from side to side helping you realize where the spikes are",
    //     "Guess today is not my last day after all!","What’s that, something appears to be happening.",
    //     "Finally, I made it outside!",
    //     "Never going back in the mine ever again."};
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     CheckInput();

    //     if (moving)
    //     {
    //         //transform.position = pos;
    //         rigidBody.MovePosition(pos);
    //         moving = false;
    //     }
    // }

    // void CheckInput()
    // {
    //     if (Input.GetDown(Input.Button.DpadUp) || Input.GetKeyDown(KeyCode.RightArrow))
    //     {
    //         if (center)
    //         {
    //             pos += Vector3.right * 2;
    //             right = true;
    //             center = false;
    //             left = false;
    //             moving = true;
    //         }
    //         else if (left)
    //         {
    //             pos += Vector3.right * 2;
    //             right = false;
    //             center = true;
    //             left = false;
    //             moving = true;
    //         }
    //         else if (right)
    //         {
    //             right = true;
    //             center = false;
    //             left = false;
    //             moving = false;
    //         }
    //     }
    //     else if (Input.GetDown(Input.Button.DpadDown) || Input.GetKeyDown(KeyCode.LeftArrow))
    //     {
    //         if (center)
    //         {
    //             pos -= Vector3.right * 2;
    //             right = false;
    //             center = false;
    //             left = true;
    //             moving = true;
    //         }
    //         else if (right)
    //         {
    //             pos -= Vector3.right * 2;
    //             right = false;
    //             center = true;
    //             left = false;
    //             moving = true;
    //         }
    //         else if (left)
    //         {
    //             right = false;
    //             center = false;
    //             left = true;
    //             moving = false;
    //         }
    //     }
    //     else if (Input.GetDown(Input.Button.DpadRight) || Input.GetKeyDown(KeyCode.UpArrow))
    //     {
    //         pos += Vector3.forward * 2;
    //         moving = true;
    //         rowIndex++;

    //             switch (rowIndex)
    //             {
    //                 case 1:
    //                 {
    //                     textPanel.SetActive(true);
    //                     text.text = textArray[0];
    //                 }
    //                 break;
    //                 case 2:
    //                 {
    //                     //lightsControl.TurnOffLights();
    //                     SwitchOffSpikes();
    //                     Invoke("DisplayTextPanel", 2f);
    //                 }
    //                 break;
    //             case 3:
    //             case 5:
    //             case 6:
    //             case 7:
    //             case 8:
    //             case 9:
    //                 {
    //                     textPanel.SetActive(true);
    //                     text.text = textArray[0];
    //                 }
    //                 break;
    //                 case 18:
    //                 {
    //                     text.text = textArray[5];
    //                 }
    //                 break;
    //                 default:
    //                 break;
    //             }
                

    //     }
    //     else if (Input.GetDown(Input.Button.One) || Input.GetKeyDown(KeyCode.Space))
    //     {
    //         if (textPanel.activeInHierarchy)
    //         {
    //             textIndex++;
    //             switch (textIndex)
    //             {
    //                 case 1:
    //                     text.text = textArray[1];
    //                     break;
    //                 case 2:
    //                     textPanel.SetActive(false);
    //                     break;
    //                 case 3:
    //                     text.text = textArray[3];
    //                     break;
    //                 case 4:
    //                     text.text = textArray[4];
    //                     break;
    //                 case 5:
    //                     textPanel.SetActive(false);
    //                     break;
    //                 default:
    //                     break;
    //             }
    //         }

    //     }

    //     //For Testing Purposes
    //     //else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
    //     //{
    //     //    pos -= Vector3.forward * 2;
    //     //    moving = true;
    //     //}
    // }
    // void DisplayTextPanel()
    // {
    //     textPanel.SetActive(true);
    //     text.text = textArray[2];
    // }

    // void SwitchOffSpikes()
    // {
    //     for (int i = 1; i<arraySpikes.Length;i++)
    //     {
    //         arraySpikes[i].StopSpikeMovement();
    //     }
    // }

}
