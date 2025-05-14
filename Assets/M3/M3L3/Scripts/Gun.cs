namespace M3L3
{
    public class Gun : Weapon
    {
        void Start()
        {
            print("Tipo de arma: " + weaponType + 
            ", con nombre: " + weaponName +
            ", peso de: " + weight +
            " kg y un daño de: " + damage);
        }
    }
}
