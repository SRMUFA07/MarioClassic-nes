using UnityEngine;

public class LinksURL : MonoBehaviour
{
    public void OpenLink(string link) =>
        Application.OpenURL(link);
}
