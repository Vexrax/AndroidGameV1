using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public static GameControl control;
    public float health;
    public int points;

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
        GUI.Label(new Rect(10, 10, 100, 30), "Health:" + health);
        GUI.Label(new Rect(10, 40, 100, 30), "Points:" + points);
    }

    private void FixedUpdate()
    {
        //var mainPlayer = GameObject.Find("MainPlayer"); //hook this into a checker to check for coliding boxes. 
        //var enemyCube = GameObject.Find("EnemyCube");
        control.points += 1;
    }


}
