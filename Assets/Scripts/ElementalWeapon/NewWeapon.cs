using UnityEngine;

public class NewWeapon : Weapon
{
    public NewWeapon()
    {
        weaponName = "New Weapon";
    }

    public override void SpecialEffect()
    {
        Debug.Log("New Weapon Ability!");
    }
}
