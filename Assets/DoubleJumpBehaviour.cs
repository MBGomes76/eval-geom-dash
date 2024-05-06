using UnityEngine;

public class DoubleJumpBehaviour : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") && Input.GetKey(KeyCode.Space))
        {
            GameManager.Instance.GetPlayer().GetComponent<PlayerBehaviour>().DoubleJump();
        }
    }
}
