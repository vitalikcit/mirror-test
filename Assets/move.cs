using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class move : NetworkBehaviour
{
    public int power;
    public int power1;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isLocalPlayer == true)
            rb.AddForce(transform.right * power * Time.deltaTime * CustomInput.GetAxis(Axes.Horizontal));
    } 
    void OnCollisionStay2D(Collision2D collision)
    {
		if (isLocalPlayer == true)
            if(CustomInput.GetAxis(Axes.Vertical) > 0)
                if(collision.contacts.Select((a)=>a.normal).Contains(Vector2.up))
    	           rb.AddForce(transform.up * power1 * Time.deltaTime * CustomInput.GetAxis(Axes.Vertical));
    }
}