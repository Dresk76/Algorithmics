using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public bool stopTraffic;

    [Header("Colors")]
    public Color grayColor;
    public Color redColor;
    public Color greenColor;

    [Header("Lights")]
    public MeshRenderer redLight;
    public MeshRenderer greenLight;


    void Update()
    {
        TrafficLightStatus();
    }

    private void TrafficLightStatus()
    {
        if (stopTraffic == true)
        {
            greenLight.material.color = grayColor;
            redLight.material.color = redColor;
        }
        else
        {
            redLight.material.color = grayColor;
            greenLight.material.color = greenColor;
        }
    }
}
