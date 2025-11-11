using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject mainMenuPanel;
    public GameObject settingsPanel;
    public GameObject pauseMenuPanel;

    private GameObject currentPanel;

    private void Start()
    {
        // Start with the main menu visible
        ShowPanel(mainMenuPanel);
    }

    /// <summary>
    /// Show a specific panel and hide the previous one.
    /// </summary>
    /// <param name="panelToShow">The panel you want to display.</param>
    public void ShowPanel(GameObject panelToShow)
    {
        if (currentPanel != null)
            currentPanel.SetActive(false);

        if (panelToShow != null)
        {
            panelToShow.SetActive(true);
            currentPanel = panelToShow;
        }
    }

    public void BackToMainMenu()
{
    ShowPanel(mainMenuPanel);
}


    /// <summary>
    /// Toggles the pause menu visibility.
    /// </summary>
    public void TogglePauseMenu()
    {
        bool isActive = pauseMenuPanel.activeSelf;
        pauseMenuPanel.SetActive(!isActive);

        // Pause or unpause game time
        Time.timeScale = isActive ? 1f : 0f;
    }

    /// <summary>
    /// Quit the game (works in both Editor and build).
    /// </summary>
    public void QuitGame()
    {
        Debug.Log("Quitting game...");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
