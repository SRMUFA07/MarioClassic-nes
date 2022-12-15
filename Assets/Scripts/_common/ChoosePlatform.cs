using UnityEngine;

public class ChoosePlatform : MonoBehaviour
{
    public static bool _pcDevice = true;

    public AudioSource changeSound;

    public void ChangePc()
    {
        _pcDevice = true;
        changeSound.Play();
    }

    public void ChangePhone()
    {
        _pcDevice = false;
        changeSound.Play();
    }
}
