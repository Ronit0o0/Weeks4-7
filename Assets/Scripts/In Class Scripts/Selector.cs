using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class Selector : MonoBehaviour
{
    public float distanceThreshold;
    public TextMeshProUGUI selectedObject;
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();

        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);

        worldMousePosition.z = 0f;

        float distance = Vector3.Distance(transform.position, worldMousePosition);

        if (distance < distanceThreshold)
        {
            selectedObject.text = gameObject.name;
        }
    }
}
