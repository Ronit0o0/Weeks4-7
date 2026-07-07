using UnityEngine;

public class Strategies : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
            float spawnHeight = i / 10f;
            Debug.Log(i);
            Vector3 spawningPosition = new Vector3(0, i / 10f, 0);
            Instantiate(prefab, spawningPosition, Quaternion.identity);
            Debug.Log(spawningPosition);
        }
    }
    
}
