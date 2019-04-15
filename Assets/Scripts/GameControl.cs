using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public static GameControl control;
    private SceneManager SceneManager; 

    private void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;

        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    void Start ()
    {
        DontDestroyOnLoad(gameObject);
        LoadNextLevel();
    }

    /*
    Checks for Update Each tick
    */
    private void FixedUpdate()
    {
        //We should call the LoadNextLevel Function from the level game script.
        //if(IsLevelComplete())
        //{
        //    LoadNextLevel();
        //}
        
    }

    public bool IsLevelComplete()
    {
        //TODO check if the level tiles are all complete 
        return false;
    }

    public void LoadNextLevel()
    {
        Debug.Log("Loading Next Level");
        SceneManager.LoadScene("Base Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Additive);   
    }
}
