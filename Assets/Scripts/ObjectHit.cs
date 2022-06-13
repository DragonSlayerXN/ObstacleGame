using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   //variables
   MeshRenderer mrenderer;
   
   private void OnCollisionEnter(Collision other)
   {

      mrenderer = GetComponent<MeshRenderer>();
      // Debug.Log("Wall Touched");
      if (other.gameObject.tag == "Player")
      {
       mrenderer.enabled = true;
       mrenderer.material.color = Color.grey;
       gameObject.tag = "Hit";
      }
   }
}
