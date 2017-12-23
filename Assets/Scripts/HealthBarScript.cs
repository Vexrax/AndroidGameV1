﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

    [SerializeField]
    private Image Bar;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        updateBar();

    }
    private void updateBar()
    {
        Bar.fillAmount = (GameControl.control.health / 100);
    }
}