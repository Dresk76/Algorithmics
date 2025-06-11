using TMPro;
using UnityEngine;

public class HealthState : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI healthStateText;

    private int currentHealth = 0;

    public void AddHealth()
    {
        currentHealth += 10;
        healthText.text = $"Vida: {currentHealth}";
        //print("Vida: " + currentHealth);
        healthStateText.text = "Has recibido 10 puntos de vida!";
    }

    public void ReduceHealth()
    {
        // No reducir la vida si ya esta muerto
        if (currentHealth <= 0)
        {
            return;
        }

        currentHealth -= 10;
        healthText.text = "Vida: " + currentHealth.ToString();

        if (currentHealth < 10)
        {
            healthStateText.text = "¡Estás muerto!";
        }
        else
        {
            healthStateText.text = "Oh no! Te han atacado, pierdes 10 puntos de vida!";
        }
    }
}
