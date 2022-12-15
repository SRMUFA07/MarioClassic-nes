using UnityEngine;

public class FullscreenSet : MonoBehaviour
{
    public void SetFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
