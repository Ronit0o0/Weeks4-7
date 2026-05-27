using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelPointer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;

        Vector3 directionToTarget = worldMousePosition - transform.position;
        transform.right = directionToTarget;
    }
}
