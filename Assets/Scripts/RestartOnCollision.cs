using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    public GameManager gameManager;
    private Vector3 playerInitPosition;

    void Start()
    {
        playerInitPosition = GameObject.FindGameObjectWithTag(strTag).transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag && gameManager != null)
        {
            gameManager.LoseLife();
            GameObject.FindGameObjectWithTag(strTag).transform.position = playerInitPosition;
        }    
    }
}
