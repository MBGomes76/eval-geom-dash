using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (ContactPoint2D point in collision.contacts)
        {
            if (point.normal.x != 0 && point.normal.y >= 0)
            {
                GameManager.Instance.Restart();
            }
        }
    }
}
