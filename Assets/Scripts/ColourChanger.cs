using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColourChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private float progress = 0f;
    public float targetTime;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            progress += Time.deltaTime;

            if (progress > targetTime)
            {
                spriteRenderer.color = Random.ColorHSV();
                progress = 0f;
            }
        }
    }

