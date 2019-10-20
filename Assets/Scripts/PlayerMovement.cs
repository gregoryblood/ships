using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotation;
    public float deadzone = 0.25f;
    public int gamepadNum;

    PlayerControls controls;
    Vector2 move;
    Quaternion targetRotation;
    private float maxSpeed;
    private Rigidbody rb;
    //private PlayerShooting shooting;
    // Start is called before the first frame update
    void Awake()
    {
        //controls = new PlayerControls();

        //shooting = GetComponent<PlayerShooting>();

        //controls.Moving.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        maxSpeed = speed;
    }
    

    // Update is called once per frame
    void Update()
    {
        move = Gamepad.all[gamepadNum - 1].leftStick.ReadValue();
        transform.position += transform.forward * speed * Time.deltaTime;
        
        var input = new Vector3(move.x, 0, move.y);
        if (input.magnitude < deadzone)
            input = Vector2.zero;

        if (input != Vector3.zero)
        {
            targetRotation = Quaternion.LookRotation(input);
        }
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotation * Time.deltaTime);
        /*
        if (move.x > 0.4f)
        {
            transform.Rotate(Vector3.up * rotation * Time.deltaTime);
        }
        else if (move.x < -0.4f)
        {
            transform.Rotate(Vector3.up * -rotation * Time.deltaTime);
        }
        */

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Land") || collision.gameObject.CompareTag("Boat"))
        {
            speed = 0;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        speed = maxSpeed;
    }

    private void OnEnable()
    {
        //controls.Moving.Enable();
    }
    private void OnDisable()
    {
        //controls.Moving.Disable();
    }
    
}
