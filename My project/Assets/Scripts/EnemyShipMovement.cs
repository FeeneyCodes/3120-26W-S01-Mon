using UnityEngine;

public class EnemyShipMovement : MonoBehaviour
{
    public float Speed = 1.0f;

    // Once past this point, ships respawn in the distance
    public float RespawnThresholdZ = -10.0f;
    // This is the location in the distance where the ship respawns
    public float RespawningLocationZ = 50.0f;
    // The left and right limits of the random respawn location (X axis)
    public float MinRespawnLocationX = -35.0f;
    public float MaxRespawnLocationX = 35.0f;

    public float ScorePointThresholdZ = -22.0f;

    // This is the instance of the class on the game manager object
    public Object PointManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // If we want this to be the same sequence 
        //  every time, then seed it with a specific number.
        // You could also pass the time + some other random stuff
        //  to "randomize" this, too (not deterministic)
        //Random.InitState(454);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CurrentPosition = transform.position;

            
        // Could do it this way...
        // deltaTime is how much time has gone by since the last update
//
//        Vector3 movementThisFrame;
//        movementThisFrame.z = Time.deltaTime * Speed;
//        transform.Translate(movementThisFrame, Space.World );
//
        //transform.Translate(CurrentPosition.z * Time.deltaTime * Speed, );

        CurrentPosition.z += (Time.deltaTime * Speed);
        transform.position = CurrentPosition;

        // Do we respawn? 
        if ( transform.position.z <= RespawnThresholdZ )
        {
            // Yes
            Vector3 NewSpawnLocationXYZ = transform.position;
            // Change the Z
            NewSpawnLocationXYZ.z = RespawningLocationZ;
            // Pick a random X (i.e. left and right) screen location
            NewSpawnLocationXYZ.x 
                = Random.Range(MinRespawnLocationX, MaxRespawnLocationX);

            transform.position = NewSpawnLocationXYZ;
        }

        // did the ship pass the player? 
        if ( transform.position.z <= ScorePointThresholdZ)
        {
            //PointManager.Upda
        }


    }//void Update()
}
