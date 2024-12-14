using UnityEngine;
using UnityEngine.SceneManagement;

public class MainLogin : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("Menu");
    }
    public void tapregister()
    {
        SceneManager.LoadScene("Register");
    }
}
