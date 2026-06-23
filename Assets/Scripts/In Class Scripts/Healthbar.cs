using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Healthbar : MonoBehaviour
{
    public Image healthBarFillImage;

    public float currentHealth = 100f;
    public float maxHealth = 100f;

    public SpriteRenderer enemyRenderer;

    public float dmgPerHit = 0;

    public AudioSource dmgSounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePos);
        worldMousePosition.z = 0;

        bool isMouseClicked = Mouse.current.leftButton.wasPressedThisFrame;
        bool isMouseOverEnemy = enemyRenderer.bounds.Contains(worldMousePosition);

        bool shouldTakeDamage = isMouseOverEnemy && isMouseClicked;

        Debug.Log("Click["+isMouseClicked+"] OverEnemy["+isMouseOverEnemy+"]");

        if (shouldTakeDamage)
        {
            dmgSounds.Play();
            currentHealth -= dmgPerHit;
            healthBarFillImage.fillAmount = currentHealth / maxHealth;
        }

        if(currentHealth == 0)
        {
            enemyRenderer.gameObject.SetActive(false);
        }
        


    }
}
