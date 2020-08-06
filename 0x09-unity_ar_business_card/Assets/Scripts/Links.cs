using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links : MonoBehaviour
{
    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/javiguti11");
    }
    public void GitHub()
    {
        Application.OpenURL("https://github.com/JavierGutierrezC");
    }
    public void Mail()
    {
        Application.OpenURL("mailto:955@holbertonschool.com");
    }
    public void Linkdin()
    {
        Application.OpenURL("https://www.linkedin.com/in/javier-gutierrez-59a492161/");
    }
}

