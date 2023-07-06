using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonWeb : MonoBehaviour
{
    public string url = "https://instagram.com/pawcraftperu?igshid=YzcxN2Q2NzY0OA==";
    public string wp = "https://wa.me/51935560273";

    public void OpenExternalURL()
    {
        Application.OpenURL(url);
    }

    public void OpenWhatsapp()
    {
        Application.OpenURL(wp);
    }
}
