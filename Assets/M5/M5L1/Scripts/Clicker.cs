using TMPro;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int money;


    public void UpdateMoney()
    {
        money++;
        text.text = "Money: $" + money;
    }
}
