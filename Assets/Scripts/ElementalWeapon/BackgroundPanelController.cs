using UnityEngine;
using UnityEngine.UI;

public class BackgroundPanelController : MonoBehaviour
{
    public Image backgroundPanel;
    public Sprite fireBackground; 
    public Sprite iceBackground;
    public Sprite electricBackground;
  
    public void SetFireBackground()
    {
        backgroundPanel.sprite = fireBackground;
    }

    public void SetIceBackground()
    {
        backgroundPanel.sprite = iceBackground;
    }
   
    public void SetElectricBackground()
    {
        backgroundPanel.sprite = electricBackground;
    }
}
