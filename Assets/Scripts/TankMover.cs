using UnityEngine;
using UnityEngine.InputSystem;

public class TankMover : MonoBehaviour
{
    public float speed;
    public float xMax;
    public float xMin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isMovingRight = Keyboard.current.rightArrowKey.wasPressedThisFrame;
        bool isMovingLeft = Keyboard.current.leftArrowKey.wasPressedThisFrame;

        if (isMovingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (isMovingLeft)
        {
            transform.Translate(Vector3.right * -speed * Time.deltaTime);
        }

        if (transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, transform.position.y, transform.position.z);
        }
        if (transform.position.x < xMin)
        {
            transform.position = new Vector3(xMin, transform.position.y, transform.position.z);
        }
    }
}