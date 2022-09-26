using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float speed = 5;
    public float turnSpeed = 1000;
        
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //transform.Translate(Vector2.up * Time.deltaTime * verticalInput * speed);
        transform.Translate(Vector2.right * Time.deltaTime * horizontalInput * speed);

        transform.Rotate(Vector3.forward, verticalInput * turnSpeed * Time.deltaTime);
    }
}
