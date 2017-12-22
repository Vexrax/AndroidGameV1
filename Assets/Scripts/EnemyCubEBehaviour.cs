using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCubEBehaviour : MonoBehaviour {

    public Color color;
    public float speed;


    void Start ()
    {
        GetComponent<Renderer>().material.SetColor("_Color", color);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log(isStarted);
        //Debug.Log("pos y: " + transform.position.y);
        //Debug.Log("pos x: " + transform.position.x);
        //Debug.Log("Current State: " + currentScript);

        if (GameControl.control.isStarted)
            runScripts();

    }
    public void runScripts()
    {
        switch(GameControl.control.currentScript)
        {
            case GameControl.scripts.upwardSwing:
                upwardSwingBox();
                break;
            case GameControl.scripts.SwidewardSwing:
                sidewardsSwingBox();
                break;
        }
    }
    public void boxSetup()
    {
        switch (GameControl.control.currentScript)
        {
            case GameControl.scripts.upwardSwing:
                transform.SetPositionAndRotation(new Vector3(0, -9f, 0), new Quaternion());
                GameControl.control.setup = true;
                break;
            case GameControl.scripts.SwidewardSwing:
                transform.SetPositionAndRotation(new Vector3(4f, 0, 0), new Quaternion());
                GameControl.control.setup = true;
                break;
        }
    }

    /**
     * =====================================
     * Script Movement Behaviours Below Here:
     * =====================================
     **/
    public void upwardSwingBox()
    {
        if (!GameControl.control.setup)
            boxSetup();
        transform.localScale = new Vector3(6f, 7f, 1f);
        transform.Translate(new Vector3(0, 1 * speed));
        if (transform.position.y >= 10f)
        {
            GameControl.control.isStarted = false;
            GameControl.control.setup = false;
        }
    }
    public void sidewardsSwingBox()
    {
        if (!GameControl.control.setup)
            boxSetup();
        transform.localScale = new Vector3(1f, 10f, 1f);
        transform.Translate(new Vector3(-1 * speed, 0));
        if (transform.position.x <= -4f)
        {
            GameControl.control.isStarted = false;
            GameControl.control.setup = false;
        }
    }

}
