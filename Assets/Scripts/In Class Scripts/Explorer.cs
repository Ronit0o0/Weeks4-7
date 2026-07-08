using UnityEngine;
using UnityEngine.InputSystem;

public class Explorer : MonoBehaviour
{
    public float health;
    public float speed;
    bool inLava = false;
    
    bool onIce = false;
    float timer = 0f;
    float timerGoalLava = 3f;
    
    float timerGoalIce = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 directionToMove = Vector3.zero;

        //This is the constructor for Vector3
        directionToMove = new Vector3(0, 0, 0);

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            directionToMove.x -= 1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            directionToMove.x += 1f;
        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            directionToMove.y += 1f;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            directionToMove.y -= 1f;
        }

        if(onIce)
        {
            timer += Time.deltaTime;

            if (timer < timerGoalIce)
            {
                speed = 0f;
            } else if (timer > timerGoalIce)
            {
                speed = 3f;
            }
            Debug.Log(timer);
        }


        if (inLava)
        {
            timer += Time.deltaTime;

            if (timer < timerGoalLava)
            {
                health -= 10 * Time.deltaTime;
            }
        }

            transform.position += directionToMove * speed * Time.deltaTime;
    }

    public void TakeDamage()
    {
        health -= 10;
    }

    public void SlowDown()
    {
        speed -= 1.5f;
    }

    public void SpeedUp()
    {
        speed += 1.5f;
    }

    public void InLava()
    {
        inLava = true;
        health -= 10;
    }

    public void OutOfLava()
    {
        inLava = false;
    }

    public void OnIce()
    {
        onIce = true;
        
    }


}
