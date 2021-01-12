using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject trailObject;
    // Start is called before the first frame update
    void Start()
    {
        trailObject.SetActive (false); //the trail does not happen
    }
    void Update (){
      if (Input.GetKeyDown(KeyCode.R)){
        GetComponent<Renderer>().material.color = Color.blue; 
      }
       if (Input.GetKeyDown(KeyCode.T)){
        GetComponent<Renderer>().material.color = Color.black; 
      }
       if (Input.GetKeyDown(KeyCode.Y)){
        GetComponent<Renderer>().material.color = Color.green; 
      }
       if (Input.GetKeyDown(KeyCode.U)){
        GetComponent<Renderer>().material.color = Color.yellow; 
      }
    }

  public void ActivateTrail(){
  trailObject.SetActive (true); //the trail appears
  }
}
