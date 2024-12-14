using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void game()
    {
        SceneManager.LoadScene("Game");
    }
    public void loginscene()
    {
        SceneManager.LoadScene("Login");
    }
}
