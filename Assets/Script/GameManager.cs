using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject Player;
    public TMP_Text NbMortsText;

    private Vector3 startPoint;
    private int nbMorts = 0;
    private bool isFlagOut;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        startPoint = Player.transform.position;
    }

    public void Restart()
    {
        NbMortsText.text = $"Morts : {++nbMorts}";
        Player.transform.position = startPoint;
    }

    public GameObject GetPlayer()
    {
        return Player;
    }

    public void EndGame()
    {
        Player.GetComponent<PlayerBehaviour>().EndGame();
    }
}
