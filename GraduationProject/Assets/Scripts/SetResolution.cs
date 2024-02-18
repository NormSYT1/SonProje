using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolution : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Res1(bool option)
    {
        if (option)
        {
            Screen.SetResolution(1920, 1080, Screen.fullScreen);
        }
    }
    public void Res2(bool option)
    {
        if (option)
        {
            Screen.SetResolution(1440, 900, Screen.fullScreen);
        }
    }
    public void Res3(bool option)
    {
        if (option)
        {
            Screen.SetResolution(1024, 768, Screen.fullScreen);
        }
    }
}
