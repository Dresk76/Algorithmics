using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    // Crear sa Steve de Minecraft con formas primitivas
    private void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 3, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 3, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 4, 0);
    }
}
