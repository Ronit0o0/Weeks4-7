using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject runnerPrefab;
    public GameObject existingRunner;
    public Vector3 spawnPosition;
    public float spawnSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Destroy(existingRunner, 3f);
        }


        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            
        }
    }

        public void OnSpawnPressed()
    {
        //Spawn a runner!
        //Instantiate(runnerPrefab);

        //Spawn a runner that is a child of this object
        //Instantiate(runnerPrefab, transform);

        //Spawn a runner at a specific position with no rotation:
        GameObject spawnedObject = Instantiate(runnerPrefab, transform.position, Quaternion.identity);
        Destroy(spawnedObject, 2f);
        //POSITION OF ZERO:
        //Vector3 zeroVector = Vector3.zero;


        SpriteRenderer spawnedSpriteRenderer = spawnedObject.GetComponent<SpriteRenderer>();
        if (spawnedSpriteRenderer != null)
        {
            spawnedSpriteRenderer.color = Color.red;
        }
        //MAKE THE SPANWED OBJECT MOVE AT SPAWNEDSPEED;
        Runner spawnedRunner = spawnedObject.GetComponent<Runner>();
        //YOU SHOULD CHECK TO SEE IF THE COMPONENT EXISTS BEFORE USING IT
        if (spawnedRunner != null)
        {
            //DOES SPAWNED RUNNER HAVEA A VALUE
            spawnedRunner.speed = spawnSpeed;
        }


        //ROTATION OF ZERO:
        //Quaternion zeroRotation = Quaternion.identity;
    }
}
