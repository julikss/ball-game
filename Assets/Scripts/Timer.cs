using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float timer = 0f;
    bool isTimerRunning = true;

    public TextMeshProUGUI timerText;

    void Update()
    {
        if (isTimerRunning)
        {
            timer += Time.deltaTime;
            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        if (timerText != null)
        {
            timerText.text = "Time: " + timer.ToString("F2");
        }
    }

    public void RestartTimer()
    {
        timer = 0;
        isTimerRunning = true;
    }

    public void StopTimer()
    {
        isTimerRunning = false;
        PlayerPrefs.SetFloat("SavedTime", timer);
        PlayerPrefs.Save();
        Debug.Log("Time saved: " + timer.ToString("F2"));
    }
}
