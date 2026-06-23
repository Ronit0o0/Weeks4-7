using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Mover : MonoBehaviour
{
    public float speed = 5;
    public GameObject Player2;
    public float distanceThreshold;
    public Image chatBox;
    public Sprite customSprite;
    public Canvas canvas;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isMovingRight = Keyboard.current.rightArrowKey.isPressed;

        bool isMovingLeft = Keyboard.current.leftArrowKey.isPressed;

        if (isMovingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (isMovingLeft)
        {
            transform.position += Vector3.right *  -speed * Time.deltaTime;
        }

        float distance = Vector3.Distance(transform.position, Player2.transform.position);

        if (distance < distanceThreshold)
        {
            chatBox.sprite = customSprite;
            chatBox.transform.position = new Vector3(canvas.transform.position.x, canvas.transform.position.y, 0);
        }

        if (distance > distanceThreshold)
        {
            chatBox.transform.position = new Vector3(1000, 1000, 0);
        }
    }
}
