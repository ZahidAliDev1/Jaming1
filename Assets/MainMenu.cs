using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadGameplayScene()
    {
        SceneManager.LoadScene("Level Demo");
    }
}