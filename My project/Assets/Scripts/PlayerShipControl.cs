using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShipControl : MonoBehaviour
{
    // How "strong" the movement is
    public float steeringForce = 0.5f;
    public Vector3 velocity = Vector3.zero;  // or this:  = Vector3(0.0f, 0.0f, 0.0f);
    public Vector3 maxVelocity = new Vector3(1.0f, 1.0f, 1.0f);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);

        float deltaSteeringForce = Time.deltaTime * steeringForce;

        if ( Input.GetKey(KeyCode.A) )
        {
            //CurrentPosition.x += 0.1f;
            velocity += new Vector3( +deltaSteeringForce, 0.0f, 0.0f);   // Changing the velocity
        }
        if ( Input.GetKey(KeyCode.D) )
        {
            //CurrentPosition.x -= 0.1f;
            velocity += new Vector3( -deltaSteeringForce, 0.0f, 0.0f);   // Changing the velocity
        }

        // TODO: Add an if statement to limit the max velocity
        if ( velocity.x > maxVelocity.x )
        {
            velocity.x = maxVelocity.x;
        }
        if ( velocity.x < -maxVelocity.x )
        {
            velocity.x = -maxVelocity.x;
        }
      

        // Adjusting the position by a velocity, 
        //   instead of just setting the position
        Vector3 CurrentPosition = transform.position;

        CurrentPosition += velocity;

        transform.position = CurrentPosition;
    }
}
