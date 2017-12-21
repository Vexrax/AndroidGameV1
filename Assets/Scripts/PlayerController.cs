using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    //Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));


    private void Start()
    {
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "EnemyCube")
        {
            GameControl.control.health -= 1;
        }
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector3(speed * Input.GetAxis("Horizontal")*Time.deltaTime,speed *Input.GetAxis("Vertical")*Time.deltaTime));
        //Debug.Log(transform.position.x);
        
        if (transform.position.x > 3.5)
        {
            Vector3 wrapper = new Vector3(-3.5f, 0, 0);
            transform.position = wrapper;
        }
        if (transform.position.x < -3.5)
        {
            Vector3 wrapper = new Vector3(3.5f, 0, 0);
            transform.position = wrapper;
        }
        if (transform.position.y > 5.5)
        {
            Vector3 wrapper = new Vector3(0, -5.5f, 0);
            transform.position = wrapper;
        }
        if (transform.position.y < -5.5)
        {
            Vector3 wrapper = new Vector3(0, 5.5f, 0);
            transform.position = wrapper;
        }
    }
}
