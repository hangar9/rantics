using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterMotor))]
public class CharacterController : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float sensitivity = 3f;

    private CharacterMotor motor;

	// Use this for initialization
	void Start () {
        motor = GetComponent<CharacterMotor>();
	}
	    
	// Update is called once per frame
	void Update () {
        // Calculate Movement Velocity as a 2d Vector
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _yMov = Input.GetAxisRaw("Vertical");

        Vector2 _movHorizontal = transform.right * _xMov;
        Vector2 _movLateral = transform.up * _yMov;

        // Final Movement Vector
        Vector2 _velocity = (_movHorizontal + _movLateral).normalized * speed;

        // Apply Movement
        motor.Move(_velocity);

	}
}
