using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace M5L2
{
    public class UIManager : MonoBehaviour
    {
        public GameObject uiObj;
        public GameObject scorePanel;
        public GameObject gameMenu;

        public void PlayGame()
        {
            uiObj.SetActive(false);
            scorePanel.SetActive(true);
            gameMenu.SetActive(true);
        }

        public void ExitGame()
        {
            print("Saliendo del juego...");
            Application.Quit();
        }
    }
}
