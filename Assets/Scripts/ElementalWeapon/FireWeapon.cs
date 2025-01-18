using UnityEngine;

public class FireWeapon : Weapon
{
    public FireWeapon()
    {
        weaponName = "Greatsword of Fire";
    }

    public override void SpecialEffect()
    {       
        Debug.Log("Burning with Fire!");
    }
}
