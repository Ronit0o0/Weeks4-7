using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;
public class Swatter : MonoBehaviour
{
public TMP_Text score;

public TMP_Text timerText;

private float timeLeft = 30;

private int currentScore = 0;

public GameObject flyPrefab;

public Slider mover;

public float deathTimer = 3f;

public GameObject flyPrefabSpawned;

private Fly flyRotation;

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{
    //This will spawn the fly that at a random x position at the start of the game
    flyPrefabSpawned = Instantiate(flyPrefab, new Vector3(Random.Range(-4.9f, 4.9f), transform.position.y, transform.position.z), Quaternion.identity);

    


}

// Update is called once per frame
void Update()
{
    // This will make it so the slider will control the swatters position on the x axis
    transform.position = new Vector3(mover.value, transform.position.y, transform.position.z);

    // this is to decrease the timer from the starting time
    timeLeft -= Time.deltaTime;

    // This shows the timer up to 2 decimal places in the TMPro UI
    timerText.text = "Time Left: " + timeLeft.ToString("F1");

    // This will show the score text with the current score
    score.text = "Score: " + currentScore.ToString();

    // keypress for the swatter to kill the fly
    bool hasSwatted = Keyboard.current.spaceKey.wasPressedThisFrame;

    // This will track how far the reticle is from the fly and if its close enough to have the if statement below work.
    float reticlePosition = Vector3.Distance(transform.position, flyPrefabSpawned.transform.position);

    // the reticle is in range of the fly and the spacebar is pressed then add 1 to the score
    if (hasSwatted && reticlePosition < 1f)
    {
        //This is to grab the rotation script from the fly prefab
        flyRotation = flyPrefabSpawned.GetComponent<Fly>();

        //This will check if the if statement it working
        Debug.Log("You swatted the fly!");

        //This will increase the counter for the score when the conditions are met
        currentScore += 1;

        //This will rotate the fly when hit
        flyRotation.rotationSpeed = 90f;

        //This will check if the flyrotation get component is working
        Debug.Log("The fly is rotating");

        //This is to destroy the fly after some time 
        Destroy(flyPrefabSpawned, deathTimer);

        //This will spawn a new fly at a random x position after the fly is destroyed
        flyPrefabSpawned = Instantiate(flyPrefab, new Vector3(Random.Range(-4.9f, 4.9f), transform.position.y, transform.position.z), Quaternion.identity);
    }
}
}

