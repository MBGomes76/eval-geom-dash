using UnityEngine;

public class EndGame : MonoBehaviour
{
    private Animator Animator;

    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Animator.SetTrigger("FlagOut");
        GameManager.Instance.EndGame();
    }

    public void setIsFlagOut()
    {
        Animator.SetBool("IsFlagOut", true);
    }
}
