using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI startText;

    private float timeElapsed;
    private bool isCounting = false;


    private void Update()
    {
        // Actualizar el temporizador cada Frame
        if (isCounting)
        {
            timeElapsed += Time.deltaTime;

            // Llamar el metodo que actualiza el texto del timer
            UpdateTimerDisplay();
        }

        // Llamar el metodo que actualiza el texto para Iniciar o Reaunudar el temporizador
        UpdateButtonText();
    }

    // Iniciar el temporizador
    public void StartTimer()
    {
        isCounting = true;
    }

    // Pausar el temporizador
    public void PauseTimer()
    {
        isCounting = false;
    }

    // Detener el temporizador
    public void StopTimer()
    {
        isCounting = false;
        timeElapsed = 0f;

        UpdateTimerDisplay();
    }

    // Actualizar el texto del timer con un formato de solo 1 decimal
    private void UpdateTimerDisplay()
    {
        timerText.text = timeElapsed.ToString("F1");
    }

    // Actualizar el texto para Iniciar o Reaunudar el temporizador
    private void UpdateButtonText()
    {
        if (!isCounting && timeElapsed > 0)
        {
            startText.text = "Reaunudar";
        }
        else
        {
            startText.text = "Iniciar";
        }
    }
}
