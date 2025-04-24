using UnityEngine;

public class InfoPopup : MonoBehaviour
{
    public GameObject infoPanel;

    void OnMouseDown()
    {
        if (infoPanel != null)
        {
            infoPanel.SetActive(true);
        }
    }
}
