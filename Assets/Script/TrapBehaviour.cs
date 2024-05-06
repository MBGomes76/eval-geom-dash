using UnityEngine;

public class TrapBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameManager.Instance.Restart();
    }
}
