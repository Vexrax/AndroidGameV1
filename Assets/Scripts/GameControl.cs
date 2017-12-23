using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public static GameControl control;
    public float health;
    public int points;
    public bool isStarted = false;
    public bool setup = false;
    public enum scripts { upwardSwing, SwidewardSwing };
    public scripts currentScript;

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
    }

    void OnGUI ()
    {
        //GUI.Label(new Rect(10, 10, 100, 30), "Health:" + health);
        GUI.Label(new Rect(23, 50, 100, 30), "Points:" + points);

    }

    private void FixedUpdate()
    {
        if (checkIfWon())
            Application.LoadLevel("End Screen");
        if (!control.isStarted)
        {
            selectScript();
        }
        if(!checkIfWon())
            control.points += 1;
    }

    public void selectScript()
    {
        currentScript = (scripts)(new System.Random().Next(0, 2));
        isStarted = true;

    }
    public bool checkIfWon()
    {
        if (health < 0)
            return true;
        return false;
    }
}
