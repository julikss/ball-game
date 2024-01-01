using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    Transform transTarget;

    void Update()
    {
        transform.position = transTarget.position;
    }
}
