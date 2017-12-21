using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCubEBehaviour : MonoBehaviour {

    public Color color;
    public float speed;
    private bool isStarted;
    private bool setup;
    private enum scripts { upwardSwing, SwidewardSwing };
    private scripts currentScript;

    void Start ()
    {
        GetComponent<Renderer>().material.SetColor("_Color", color);
        isStarted = false;
        setup = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(isStarted);
        Debug.Log("pos y: " + transform.position.y);
        Debug.Log("pos x: " + transform.position.x);
        Debug.Log("Current State: " + currentScript);

        if (!isStarted)
        {
            selectScript();
            isStarted = true;
            runScripts();
        }
        else
        {
            runScripts();
        }
    }
    public void selectScript()
    {
        this.currentScript = (scripts)(new System.Random().Next(0, 2));
    }
    public void runScripts()
    {
        switch(currentScript)
        {
            case scripts.upwardSwing:
                upwardSwingBox();
                break;
            case scripts.SwidewardSwing:
                sidewardsSwingBox();
                break;
        }

    }
    public void boxSetup()
    {
        switch (currentScript)
        {
            case scripts.upwardSwing:
                transform.SetPositionAndRotation(new Vector3(0, -9f, 0), new Quaternion());
                setup = true;
                break;
            case scripts.SwidewardSwing:
                transform.SetPositionAndRotation(new Vector3(4f, 0, 0), new Quaternion());
                setup = true;
                break;
        }
    }
    public void upwardSwingBox()
    {
        if (!setup)
            boxSetup();
        transform.localScale = new Vector3(6f, 7f, 1f);
        transform.Translate(new Vector3(0, 1 * speed));
        if (transform.position.y >= 10f)
        {
            isStarted = false;
            setup = false;
        }
    }
    public void sidewardsSwingBox()
    {
        if (!setup)
            boxSetup();
        transform.localScale = new Vector3(1f, 10f, 1f);
        transform.Translate(new Vector3(-1 * speed, 0));
        if (transform.position.x <= -4f)
        {
            isStarted = false;
            setup = false;
        }
    }
}
