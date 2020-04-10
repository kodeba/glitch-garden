using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigator : MonoBehaviour
{
    void Awake()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SplashScreen()
    {
        StartCoroutine(GameStartCoroutine());
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene("GameStart");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadGameOver()
    {
        StartCoroutine(GameOverCoroutine());
    }

    public void Quit()
    {
        Application.Quit();
    }

    private IEnumerator GameOverCoroutine()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("GameOver");
    }

    private IEnumerator GameStartCoroutine()
    {
        yield return new WaitForSeconds(2);
        LoadStartMenu();
    }

}
