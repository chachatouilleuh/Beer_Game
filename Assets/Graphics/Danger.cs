using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Player>() != null)
            
        {
            other.gameObject.SetActive(false); 
        }
    }
}
