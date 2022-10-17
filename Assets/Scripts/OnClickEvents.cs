using TMPro;
using UnityEngine;

public class OnClickEvents : MonoBehaviour
{
    public TextMeshProUGUI soundText;
    void Start()
    {
        if (GameManager.mute)
            soundText.text = "/";
        else
            soundText.text = "";

    }
    public void ToggleMute()
    {
        if (GameManager.mute)
        {
            GameManager.mute = false;
            soundText.text = "";
        }
        else
        {
            GameManager.mute = true;
            soundText.text = "/";
        }
    }

    public void QuiteGame()
    {
        Debug.Log("Quite Game");
    }
}
