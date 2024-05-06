using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomePage : MonoBehaviour
{
    public Button ButtonStart;

    // Start is called before the first frame update
    void Start()
    {
        ButtonStart.onClick.AddListener(startGame);
    }

    private void startGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
