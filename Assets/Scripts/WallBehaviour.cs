using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Class EnemyCubebehavoiur
 * Behaviour class for enemy boxes: 
 * Needs:
 * runScripts();
 * [object]Setup();
 * 
 */
public class WallBehaviour : MonoBehaviour {

    public Color color;
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
    }
}
