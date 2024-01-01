using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int startingLives = 3;
    private int currentLives;
    private bool canMove = true;

    public TextMeshProUGUI livesText;
    public Timer timer;

    public WinMsgPopUp winPopup;
    public LoserMsgPopUp losePopup;
    public MainMsgPopUp mainPopup;

    public bool CanMove()
    {
        return canMove;
    }

    public void SetCanMove(bool value)
    {
        canMove = value;
    }

    void Start()
    {
        currentLives = startingLives;
        UpdateLivesText();
        SetCanMove(true);
        timer.RestartTimer();
        losePopup.HidePopup();
        winPopup.HidePopup();
        mainPopup.ShowPopup();
    }

    public void LoseLife()
    {
        currentLives--;
        UpdateLivesText();

        if (currentLives <= 0)
        {
            GameOver();
        }
    }

    void UpdateLivesText()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + currentLives;
        }
    }

    public void GameOver()
    {
        timer.StopTimer();
        mainPopup.HidePopup();
        losePopup.ShowPopup();
        canMove = false;
    }

    public void WinGame(float time)
    {
        timer.StopTimer();
        mainPopup.HidePopup();
        winPopup.ShowPopup(time);
        canMove = false;
    }
}

