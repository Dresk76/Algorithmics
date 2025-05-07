using UnityEngine;

public class ComparisonOperators : MonoBehaviour
{
    private void Start()
    {
        EqualExample();
        print("--------------------------------------------------\n\n");

        NotEqualExample();
        print("--------------------------------------------------\n\n");

        GreaterThanExample();
        print("--------------------------------------------------\n\n");

        LessThanExample();
        print("--------------------------------------------------\n\n");

        GreaterOrEqualExample();
        print("--------------------------------------------------\n\n");

        LessOrEqualExample();
        print("--------------------------------------------------\n\n");
    }

    #region 1. Igual a (==)

    private void EqualExample()
    {
        int score = 100;
        if (score == 100)
        {
            print("¡Lograste el puntaje perfecto! 💯");
        }
    }

    #endregion

    #region 2. Diferente (!=)

    private void NotEqualExample()
    {
        string equippedWeapon = "Pistola";
        if (equippedWeapon != "RPG")
        {
            print("Aviso: No llevas el arma más poderosa. 🔫");
        }
    }

    #endregion

    #region 3. Mayor que (>)

    private void GreaterThanExample()
    {
        float speed = 8.2f;
        if (speed > 7.5f)
        {
            print("¡Superaste la velocidad límite! 🚀");
        }
    }

    #endregion

    #region 4. Menor que (<)

    private void LessThanExample()
    {
        int enemiesAlive = 3;
        if (enemiesAlive < 5)
        {
            print("Quedan pocos enemigos. ¡Tú puedes! 👊");
        }
    }

    #endregion

    #region 5. Mayor o igual que (>=)

    private void GreaterOrEqualExample()
    {
        int level = 10;
        if (level >= 10)
        {
            print("¡Felicidades, llegaste al nivel máximo! 🌟");
        }
    }

    #endregion

    #region 6. Menor o igual que (<=)

    private void LessOrEqualExample()
    {
        float energy = 15.0f;
        if (energy <= 20.0f)
        {
            print("Energía baja, recarga pronto. ⚡");
        }
    }

    #endregion
}
