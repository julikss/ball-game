using UnityEngine;
using TMPro;

public class LoserMsgPopUp : MonoBehaviour
{
    public TextMeshProUGUI loseText;

    public void ShowPopup()
    {
        gameObject.SetActive(true);
        loseText.text = "OOPS...GAME OVER!";
    }

    public void HidePopup()
    {
        gameObject.SetActive(false);
    }
}
