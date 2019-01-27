using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotor : MonoBehaviour {

    public bool invertMouse = false;

    [SerializeField]
    private Camera cam;

    private Vector2 velocity = Vector2.zero;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Get a Movement Vector
    public void Move(Vector2 _velocity)
    {
        velocity = _velocity;
    }
	
    // Run every physics iteration
    void FixedUpdate ()
    {
        PerformMovement();
    }

    // Perform movement based on velocity variable
    void PerformMovement()
    {
        if(velocity != Vector2.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }
}
