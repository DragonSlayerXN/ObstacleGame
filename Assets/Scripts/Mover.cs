using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        
        MovePlayer();
    }

    // new method creation 
    void PrintInstructions()
    {

        Debug.Log("WELCOME.... Lets Play");
        Debug.Log("YOSHAAAAAAAA");
        Debug.Log("Move with WASD..");
    }

    //player movement method with speed

    void MovePlayer()
    {

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;


        transform.Translate(xValue,0,zValue);

    }
}
