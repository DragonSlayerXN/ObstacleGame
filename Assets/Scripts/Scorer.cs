using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    //collision variables
  int hits = 0;
  
  // collision detection method
  private void OnCollisionEnter(Collision other) 
  {

    if (other.gameObject.tag != "Hit")
    {

      hits++;

      Debug.Log("You Hit it: " + hits);
    }
    /*else
    {
        Debug.Log("You Hit it: " + hits);
    }*/
     
  }
}
