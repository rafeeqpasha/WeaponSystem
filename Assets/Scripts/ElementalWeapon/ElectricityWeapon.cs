using UnityEngine;

public class ElectricityWeapon : Weapon
{
    public ElectricityWeapon()
    {
        weaponName = "Falchion Electricity";
    }

    public override void SpecialEffect()
    {       
        Debug.Log("Shocking with Electricity!");
    }
}
