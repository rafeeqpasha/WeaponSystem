using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class WeaponManager : MonoBehaviour
{
    private Weapon currentWeapon;
  
    public TextMeshProUGUI weaponNameText;
    public Button fireButton;
    public Button iceButton;
    public Button electricityButton;
    public List<Button> comingSoonButtons;

    [Header("Weapon Models")]
    public GameObject fireWeaponModel;
    public GameObject iceWeaponModel;
    public GameObject electricityWeaponModel;
    public GameObject commingsoonWeaponModel;

    void Start()
    {      
        SwitchWeapon(new FireWeapon(), fireWeaponModel);
        
        fireButton.onClick.AddListener(() => SwitchWeapon(new FireWeapon(), fireWeaponModel));
        iceButton.onClick.AddListener(() => SwitchWeapon(new IceWeapon(), iceWeaponModel));
        electricityButton.onClick.AddListener(() => SwitchWeapon(new ElectricityWeapon(), electricityWeaponModel));        

        foreach (Button button in comingSoonButtons)
        {
            button.onClick.AddListener(() => SwitchWeapon(new NewWeapon(), commingsoonWeaponModel));
        }

    }
   
    public void SwitchWeapon(Weapon newWeapon, GameObject activeModel)
    {
        currentWeapon = newWeapon;
        weaponNameText.text = "Selected Weapon: " + currentWeapon.weaponName;

        DeactivateWeaponModel(fireWeaponModel);
        DeactivateWeaponModel(iceWeaponModel);
        DeactivateWeaponModel(electricityWeaponModel);
        DeactivateWeaponModel(commingsoonWeaponModel);

        ActivateWeaponModel(activeModel);       

    }
    private void ActivateWeaponModel(GameObject weaponModel)
    {
        weaponModel.SetActive(true);
        var rotationController = weaponModel.GetComponent<WeaponRotationController>();
        if (rotationController != null)
        {          
            rotationController.enabled = true;
        }
    }
  
    private void DeactivateWeaponModel(GameObject weaponModel)
    {
        weaponModel.SetActive(false);
        var rotationController = weaponModel.GetComponent<WeaponRotationController>();
        if (rotationController != null)
        {          
            rotationController.enabled = false;
        }
    }
  
}
