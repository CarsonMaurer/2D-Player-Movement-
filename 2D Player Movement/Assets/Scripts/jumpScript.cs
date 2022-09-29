using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float jumpForce = 10;

    private Rigidbody2D _myRB;
    // Start is called before the first frame update
    void Start()
    {
        _myRB = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        _myRB.velocity = new Vector2(horizontalInput * moveSpeed, _myRB.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            _myRB.velocity = new Vector2(_myRB.velocity.x, jumpForce);
        }
    }
}
