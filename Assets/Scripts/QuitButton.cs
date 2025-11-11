using UnityEngine;

public class QuitButton : MonoBehaviour
{
    // Call this method when the Quit button is clicked
    public void QuitGame()
    {
        Debug.Log("Quit button pressed. Exiting game...");

        // If running in the Unity Editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // If running as a built application
        Application.Quit();
#endif
    }
}
