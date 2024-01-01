using UnityEngine;

public class WinWhenCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;
    float savedTime;

    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag && gameManager != null)
        {
            savedTime = PlayerPrefs.GetFloat("SavedTime", 0f);
            gameManager.WinGame(savedTime);
        }
    }
}
