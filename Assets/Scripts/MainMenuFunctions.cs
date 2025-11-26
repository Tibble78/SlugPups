using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunctions : MonoBehaviour
{
    [Header("Menu Panels")]
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private GameObject confirmationQuitPanel;

    // Loads the main gameplay scene
    public void PlayGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Opens the settings menu
    public void OpenSettings()
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(false);
    }

    // Opens the credits
    public void OpenCredits()
    {
        if (creditsPanel != null)
            creditsPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        if (creditsPanel != null)
            creditsPanel.SetActive(false);
    }

    // Opens the quit confirmation prompt
    public void ConfirmQuit()
    {
        if (confirmationQuitPanel != null)
            confirmationQuitPanel.SetActive(true);
    }

    public void CancelQuit()
    {
        if (confirmationQuitPanel != null)
            confirmationQuitPanel.SetActive(false);
    }

    // Quits the game (works in build only)
    public void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
