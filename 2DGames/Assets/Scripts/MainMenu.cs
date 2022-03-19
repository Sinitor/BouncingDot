using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TMP_Text highScore;

    private void Update()
    {
        highScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
