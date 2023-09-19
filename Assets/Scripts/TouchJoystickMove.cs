using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TouchJoystickMove : MonoBehaviour
{
    // using https://developer.oculus.com/documentation/unity/unity-ovrinput

    public float movementSpeed = 1.0f;
    public float rotationSpeed = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check to make sure button works
        if (OVRInput.GetDown(OVRInput.RawTouch.X))
        {
            Debug.Log("Pressed X!");
        }

        // Joystick movement
        Vector2 movement = new Vector2(movementSpeed, movementSpeed);
        movement *= OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
        movement *= Time.deltaTime;
        transform.Translate(new Vector3(movement.x, 0.0f, movement.y));

        // Joystick rotation
        float rotation = rotationSpeed * Time.deltaTime * OVRInput.Get(OVRInput.RawAxis2D.LThumbstick).x;
        transform.Rotate(Vector3.up, rotation, Space.World);



    }
}
