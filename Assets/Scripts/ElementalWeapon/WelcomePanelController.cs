using UnityEngine;
using UnityEngine.UI;

public class WelcomePanelController : MonoBehaviour
{  
    public GameObject welcomePanel;
    public Button fireButton;

    void Start()
    {

        fireButton.onClick.AddListener(() => HidePanel());
    }

    public void HidePanel()
    {
        welcomePanel.SetActive(false);
    }
}
