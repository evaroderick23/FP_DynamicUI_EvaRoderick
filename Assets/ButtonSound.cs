using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    // Drag your AudioClip in the Inspector
    public AudioClip clickSound;

    private AudioSource audioSource;

    void Start()
    {
        // Add an AudioSource component dynamically if it doesn't exist
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;

        // Get the Button component and add the OnClick listener
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(PlayClickSound);
        }
        else
        {
            Debug.LogWarning("No Button component found on this GameObject!");
        }
    }

    void PlayClickSound()
    {
        if (clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
        else
        {
            Debug.LogWarning("No AudioClip assigned!");
        }
    }
}
