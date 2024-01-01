using UnityEngine;
using TMPro;

public class WinMsgPopUp : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI winText;

    public void ShowPopup(float time)
    {
        gameObject.SetActive(true);
        int roundedTime = Mathf.RoundToInt(time);
        winText.text = "YOU HAVE WON!!!";
        timeText.text = "Your Score: " + roundedTime;
    }

    public void HidePopup()
    {
        gameObject.SetActive(false);
    }
}
