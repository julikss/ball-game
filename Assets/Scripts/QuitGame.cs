using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    void Update()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(Exit);
        }
    }

    void Exit()
    {
        Application.Quit();
    }
}
