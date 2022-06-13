using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer mrenderer;
    Rigidbody rbody;

    
    [SerializeField]float timeToWait = 3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        mrenderer = GetComponent<MeshRenderer>();
        rbody = GetComponent<Rigidbody>();


        if (Time.time > timeToWait)
        {
            mrenderer.enabled = true;
            rbody.useGravity = true; 
        }
    }
}
