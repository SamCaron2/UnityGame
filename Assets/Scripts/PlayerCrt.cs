using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrt : MonoBehaviour
{
    public float movSpeed;
    float speedx, speedy;
    Rigidbody2D rb; 







    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        speedx = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedy = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.velocity = new Vector2(speedx, speedy);
    }
}
