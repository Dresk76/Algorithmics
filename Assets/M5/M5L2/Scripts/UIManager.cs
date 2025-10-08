using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace M5L2
{
    public class UIManager : MonoBehaviour
    {
        public GameObject mainMenu;
        public GameObject scorePanel;
        public GameObject gameWorld;
        public TextMeshProUGUI scoreText;

        public void PlayGame()
        {
            mainMenu.SetActive(false);
            scorePanel.SetActive(true);
            gameWorld.SetActive(true);
        }

        public void ExitGame()
        {
            print("Saliendo del juego...");
            Application.Quit();
        }

        public void Score(int score)
        {
            scoreText.text = score.ToString();
        }

        public void Restart()
        {
            gameWorld.SetActive(false);
            scorePanel.SetActive(false);
            mainMenu.SetActive(true);
            scoreText.text = 0.ToString();
        }
    }
}
