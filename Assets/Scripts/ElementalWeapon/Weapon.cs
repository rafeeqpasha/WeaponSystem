using UnityEngine;

public abstract class Weapon:MonoBehaviour
{
    public string weaponName;
    public virtual void SpecialEffect()
    {       
        Debug.Log("Default Weapon Effect.");
    }
}

