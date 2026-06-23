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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(flyPrefab, new Vector3(Random.Range(-4.9f, 4.9f), transform.position.y, transform.position.z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //This will make it so the slider will control the swatters position on the x axis 
        transform.position = new Vector3(mover.value, transform.position.y, transform.position.z);

        //this is to decrease the timer from the starting time
        timeLeft -= Time.deltaTime;

        //This shows the timer up to 2 decimal places in the TMPro UI
        timerText.text = "Time Left: " + timeLeft.ToString("F1");

        //This will show the score text with the current score
        score.text = "Score: " + currentScore.ToString();

        //keypress for the swatter to kill the fly
        bool hasSwatted = Keyboard.current.spaceKey.wasPressedThisFrame;

        //This will track how far the reticle is from the fly and if its close enough to have the if statement below work.
        float recticlePosition = Vector3.Distance(transform.position, flyPrefab.transform.position);

        //the reticle is in range of the fly and the spacebar is pressed then add 1 to the score
        if (hasSwatted && recticlePosition < 1f)
        {
            Debug.Log("You swatted the fly!");
            currentScore += 1;
            // Destroy(flyPrefab.gameObject);
            // Instantiate(flyPrefab, new Vector3(Random.Range(-4.9f, 4.9f), transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
