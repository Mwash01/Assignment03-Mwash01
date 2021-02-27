using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void StartNewGame() {
        SceneManager.LoadScene("MainScene");
    }

    public void RestartGame() {
        Data.playerLives = 1;
        Data.scoreNum = 0;
        SceneManager.LoadScene("IntroScene");
    }

    public void Quit() {
        Application.Quit();
        UnityEditor.EditorApplication.ExitPlaymode();
    }

    public void Credits() {
        SceneManager.LoadScene("Credits");
    }
}
