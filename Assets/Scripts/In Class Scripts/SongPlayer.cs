using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class SongPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.maxValue = audioSource.clip.length;
        slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SongDuration();
    }

    public void PlaySong()
    {
        
        audioSource.Play();
    }

    public void StopSong()
    {
        audioSource.Stop();
        slider.value = 0;
    }

    public void SongDuration()
    {
        slider.value = audioSource.time;
    }   
}
