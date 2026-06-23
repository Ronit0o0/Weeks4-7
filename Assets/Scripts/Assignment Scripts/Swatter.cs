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
    public Transform flyPosition;
    public Slider mover;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is to decrease the timer from the starting time
        timeLeft -= Time.deltaTime;

        //This shows the timer up to 2 decimal places in the TMPro UI
        timerText.text = "Time Left: " + timeLeft.ToString("F2");

        //keypress for the swatter to kill the fly
        bool hasSwatted = Keyboard.current.spaceKey.wasPressedThisFrame;

        //This will track how far the reticle is from the fly and if its close enough to have the if statement below work.
        float recticlePosition = Vector3.Distance(transform.position, flyPosition.position);

        //the reticle is in range of the fly and the spacebar is pressed then add 1 to the score
        if (hasSwatted && recticlePosition < 1f)
        {
            currentScore += 1;
        }
    }
}
