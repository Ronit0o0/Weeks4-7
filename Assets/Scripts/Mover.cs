using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    public float speed = 5;
    public GameObject Player2;

    public SpriteRenderer spriteRenderer;
    public float distanceThreshold;
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
            spriteRenderer.color = Color.red;
            Debug.Log("Player 1 is close to Player 2!");
            
        }




    }
}
