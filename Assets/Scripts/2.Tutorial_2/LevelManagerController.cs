using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerController : MonoBehaviour {


    public static LevelManagerController instance;

    private string nextSceneName = "3.ForestScene";
    public GameObject[] levels;
    int currentLevel = 0;

    void Awake()
    {
        // check that it exists
        if (instance == null)
        {
            //assign it to the current object
            instance = this;
        }

        // make sure that it is equal to the current object
        else if (instance != this)
        {
            // destroy the current game object - we only need 1 and we already have it!
            Destroy(gameObject);
        }
    }

    //Will change the gui to display messages for next level
    public void IncreaseLevel()
    {
        Debug.Log("Increasing level");
        if (currentLevel == levels.Length-1) ChangeToForestScene();
        else if(levels.Length>1)
        {
            levels[currentLevel].SetActive(false);
            levels[currentLevel+1].SetActive(true);
            currentLevel++;
        }
    }

    void ResetLevel()
    {

    }


    //Game scene will change to forest scene
    void ChangeToForestScene() 
    {
        SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
    }

}
