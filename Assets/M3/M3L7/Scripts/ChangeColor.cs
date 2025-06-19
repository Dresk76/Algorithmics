using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color normalColor;
    public Color specialColor;
    private MeshRenderer meshRenderer;

    void Start()
    {
        // Capturar el componente del MeshRenderer
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = normalColor;
    }

    void Update()
    {
        // Cambia al color especial
        ChangeSpecialColor();

        // Cambia al color normal
        ChangeNormalColor();
    }

    private void ChangeSpecialColor()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            meshRenderer.material.color = specialColor;
        }
    }

    private void ChangeNormalColor()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            meshRenderer.material.color = normalColor;
        }
    }
}
