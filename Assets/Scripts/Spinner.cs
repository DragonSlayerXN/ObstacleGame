using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xspin = 0;
    [SerializeField] float yspin = 1f;
    [SerializeField] float zspin = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(xspin,yspin,zspin); 
    }
}
