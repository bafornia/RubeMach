using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    //class variables
    [Tooltip("The speed the camera will move.")]
    public float Speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make an empty vector
        Vector3 direction = Vector3.zero;
        //grab the input from x & y to move
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        //move postion of camera
        transform.position += direction * Speed * Time.deltaTime;
    }
}
