using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative;

    public GameManager gameManager;

    void FixedUpdate()
    {
        if (gameManager != null && gameManager.CanMove())
        {
            if (Input.GetKey(keyPositive))
                GetComponent<Rigidbody>().velocity += v3Force;

            if (Input.GetKey(keyNegative))
                GetComponent<Rigidbody>().velocity -= v3Force;

        } else if (!gameManager.CanMove())
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}