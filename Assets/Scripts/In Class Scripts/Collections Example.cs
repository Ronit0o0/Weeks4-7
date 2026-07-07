using UnityEngine;
using System.Collections.Generic;

public class CollectionsExample : MonoBehaviour
{
    private List<string> animals;
    public SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1;
        float decimalNumber = 1.5f;
        string word = "Cow";

        Vector3 position = new Vector3(1f, 0f, 0f);
        Color greyColor = new Color(0.3f, 0.3f, 0.3f, 1f);
        spriteRenderer.color = greyColor;

       
        animals = new List<string>();
        animals.Add("Raccoon");
        //animals.Remove("Dog");

        for (int i = 0; i < animals.Count; i++)
        {
            Debug.Log(animals[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
