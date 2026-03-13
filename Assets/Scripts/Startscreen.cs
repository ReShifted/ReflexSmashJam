using UnityEngine;
using UnityEngine.SceneManagement;

public class Startscreen : MonoBehaviour
{
    public GameObject shopUI;
    public GameObject settingsUI;

    
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Shop()
    {
        shopUI.SetActive(true);
    }
    public void ShopClose()
    {
        shopUI.SetActive(false);
    }

    public void Settings()
    {
        settingsUI.SetActive(true);
    }
    public void SettingsClose()
    {
        settingsUI.SetActive(false);
    }

}
