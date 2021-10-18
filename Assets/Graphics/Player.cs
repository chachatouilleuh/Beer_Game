using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public float c_speed = 0f;
    public float c_maxSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("coucou");
        //GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(0.01f, 0f, 0f);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            c_speed *= 1.01f;
            transform.position = transform.position + new Vector3(0.01f * c_speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            c_speed *= 1.01f;
            transform.position = transform.position + new Vector3(-0.01f * c_speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            c_speed *= 1.01f;
            transform.position = transform.position + new Vector3(0f, -0.01f * c_speed, 0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            c_speed *= 1.01f;
            transform.position = transform.position + new Vector3(0f, 0.01f * c_speed, 0f) ;
        }


        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            c_speed = 1f;
        }

        if (c_speed > c_maxSpeed)
        {
            c_speed = c_maxSpeed;
        }
        //transform.position = new Vector3(0f, 0f, 1f);
    }
}
