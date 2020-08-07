using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links : MonoBehaviour
{
    public AudioSource buttonSound;
    public void Twitter()
    {
        SoundFX();
        Invoke("twitlink", 1);
    }
    public void GitHub()
    {
        SoundFX();
        Invoke("gitlink", 1);
    }
    public void Mail()
    {
        SoundFX();
        Invoke("maillink", 1);
    }
    public void Linkdin()
    {
        SoundFX();
        Invoke("idnlink", 1);
    }
    public void SoundFX()
    {
        buttonSound.Play();
    }
    public void twitlink()
    {
        Application.OpenURL("https://twitter.com/javiguti11");
    }
    public void gitlink()
    {
        Application.OpenURL("https://github.com/JavierGutierrezC");
    }
    public void maillink()
    {
        Application.OpenURL("mailto:955@holbertonschool.com");
    }
    public void idnlink()
    {
        Application.OpenURL("https://www.linkedin.com/in/javier-gutierrez-59a492161/");
    }
}

