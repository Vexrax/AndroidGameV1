using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    //Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    private bool _actionused = false;

    private void Start()
    {
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains( "Wall") && _actionused)
        {
            Debug.Log("Hit The Wall");
            GetComponent<ConstantForce2D>().force = new Vector3(0, 0);
            _actionused = false;
        }
    }

    void FixedUpdate()
    {
        //Wait for the unit to hit a wall
        if (GetComponent<ConstantForce2D>().force.x != 0 || GetComponent<ConstantForce2D>().force.y != 0)
        {
            return;
        }

        //TODO CLEAN THIS UP
        if (Input.GetAxis("Horizontal") > 0)
        {
            GetComponent<ConstantForce2D>().force = new Vector3(10, 0);
            _actionused = true;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            GetComponent<ConstantForce2D>().force = new Vector3(-10, 0);
            _actionused = true;
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            GetComponent<ConstantForce2D>().force = new Vector3(0, 10);
            _actionused = true;
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            GetComponent<ConstantForce2D>().force = new Vector3(0, -10);
            _actionused = true;

        }

        //Debug.Log(Input.GetAxis("Vertical"));
        //GetComponent<ConstantForce2D>().force = new Vector3(0, -1);
        //GetComponent<ConstantForce2D>().force = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //transform.Translate(new Vector3(speed * Input.GetAxis("Horizontal")*Time.deltaTime,speed *Input.GetAxis("Vertical")*Time.deltaTime));
        //Debug.Log(transform.position.x);

        //if (transform.position.x > 3.5)
        //{
        //    Vector3 wrapper = new Vector3(-3.5f, 0, 0);
        //    transform.position = wrapper;
        //}
        //if (transform.position.x < -3.5)
        //{
        //    Vector3 wrapper = new Vector3(3.5f, 0, 0);
        //    transform.position = wrapper;
        //}
        //if (transform.position.y > 5.5)
        //{
        //    Vector3 wrapper = new Vector3(0, -5.5f, 0);
        //    transform.position = wrapper;
        //}
        //if (transform.position.y < -5.5)
        //{
        //    Vector3 wrapper = new Vector3(0, 5.5f, 0);
        //    transform.position = wrapper;
        //}
    }
}
