using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ColourChanger : MonoBehaviour
{
    public SpriteRenderer changingColour;
    public Slider rotator;
    public AudioSource musicplayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColour()
    {
        musicplayer.Play();
        changingColour.color = Random.ColorHSV(); 
    }

    public void Rotator()
    {
        musicplayer.Play();
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z = rotator.value;
        transform.eulerAngles = currentRotation;
    }
}