using UnityEngine;

public class EnemyShipMovement : MonoBehaviour
{
    public float Speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CurrentPosition = transform.position;

        // Could do it this way...
        CurrentPosition.z += (Time.deltaTime * Speed);

        //transform.Translate(CurrentPosition.z * Time.deltaTime * Speed, );

        transform.position = CurrentPosition;

    }
}
