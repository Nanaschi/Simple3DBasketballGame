using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Radio : MonoBehaviour
 {
   
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("The radio touches the " + collision.gameObject.name);

        if (collision.gameObject.name == "Ball")
        {
            GameObject.Find("Music").GetComponent<AudioSource>().Pause();
        } 

    }
    

}

