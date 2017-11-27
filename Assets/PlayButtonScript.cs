using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonScript : MonoBehaviour {

    public Color StartColor;
    public Color MouseOverColor;
    bool mouseOver = false;

	void OnMouseDown ()
    {
        mouseOver = true;
        GetComponent<Renderer>().material.SetColor("_Color", MouseOverColor);
        Application.LoadLevel("Level One");

    }

    void OnMouseExit ()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", StartColor);
       
	}
}
