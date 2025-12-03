using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundShort : MonoBehaviour
{
    public AudioClip clickSound;

    void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(() =>
            {
                if (clickSound != null)
                    AudioSource.PlayClipAtPoint(clickSound, Camera.main.transform.position);
            });
        }
        else
        {
            Debug.LogWarning("No Button component found!");
        }
    }
}
