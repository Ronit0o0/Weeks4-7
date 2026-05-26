using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public List<Sprite> sprites;
    private int i = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        bool goNext = Mouse.current.leftButton.wasPressedThisFrame;

        if (goNext)
        {
            if(i < sprites.Count)
            {
                spriteRenderer.sprite = sprites[i];
               // spriteRenderer = sprites[i];
                i++;
            } else
            {
                i = 0;
            }
        

        }
    }
}