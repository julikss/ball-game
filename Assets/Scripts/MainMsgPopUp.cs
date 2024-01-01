using UnityEngine;
using TMPro;

public class MainMsgPopUp : MonoBehaviour
{
    public void ShowPopup()
    {
        gameObject.SetActive(true);
    }

    public void HidePopup()
    {
        gameObject.SetActive(false);
    }
}