using UnityEngine;

public class ToxicArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("<color=yellow>¡Cuidado! Entraste en la zona tóxica.</color>");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("<color=red>Pierdes 1 de vida por cada segundo en la zona toxica...</color>");
    }
    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("<color=green>¡Bien heho! Saliste de la zona tóxica.</color>");
    }
}
