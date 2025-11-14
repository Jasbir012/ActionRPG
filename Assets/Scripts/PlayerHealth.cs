using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public Animator healthTextAnim;

    public TMP_Text healthText;

    private void Start()
    {
        healthText.text = "HP: " + currentHealth + " / " + maxHealth;

    }

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        healthTextAnim.Play("healthAnim");

        healthText.text = "HP: " + currentHealth + " / " + maxHealth;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
