using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartWithButton : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    void Update()
    {
        if (Input.GetKey(keyRestart))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
