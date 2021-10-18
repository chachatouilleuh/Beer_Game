using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    // Start is called before the first frame update
    float r_speed;

    public void Start()
    {
        r_speed = Random.Range(-2f, 2f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 1f*r_speed));
    }
}
