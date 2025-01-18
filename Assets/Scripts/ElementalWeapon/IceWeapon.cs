using UnityEngine;

public class IceWeapon : Weapon
{
    public IceWeapon()
    {
        weaponName = "Freezy Gladius";
    }

    public override void SpecialEffect()
    {        
        Debug.Log("Freezing with Ice!");
    }
}

