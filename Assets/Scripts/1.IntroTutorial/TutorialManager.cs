using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour {

    int currentTutorial = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    bool VerifyTutorialCompletion()
    {
        switch (currentTutorial)
        {
            case 1:
                checkTutorial1();
                break;
            case 2:
                checkTutorial2();
                break;
            case 3:
                checkTutorial3();
                break;
            case 4:
                checkTutorial4();
                break;
            default:
                break;
        }

        return true;
    }

    private bool checkTutorial1()
    {
        //check if the correct sphere has been selected
        return true;
    }
   
    private bool checkTutorial2()
    {
        return true;
    }
    private bool checkTutorial3()
    {
        return true;
    }

    private bool checkTutorial4()
    {
        return true;
    }
    void nextTutorial()
    {
        if (VerifyTutorialCompletion())
        {
            currentTutorial++;
        }
    }

    void changeScene()
    {

    }
}
