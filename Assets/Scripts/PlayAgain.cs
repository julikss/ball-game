using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayAgain : MonoBehaviour
{
    void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(Play);
        }
    }

    void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
