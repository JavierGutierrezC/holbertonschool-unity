using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider SFX;
    public Slider BMG;
    private float Savedbgm;
    private float Savedsfx;
    private float bgm;
    private float sfx;
    void Awake()
    {
  
        bgm = PlayerPrefs.GetFloat("bgm", 1f);
        Debug.Log("bgm" + bgm);
        Savedbgm = bgm;
        Debug.Log("bgmsaved" + Savedbgm);
        sfx = PlayerPrefs.GetFloat("sfx", 1f);
        Savedsfx = sfx;
        BMG.value = bgm;
        SFX.value = sfx;
        
    }
    public void Back()
    {
        //mixer.SetFloat("AmbVol", Mathf.Log10(Savedsfx) * 20);
        //mixer.SetFloat("BgmVol", Mathf.Log10(Savedbgm) * 20);
        PlayerPrefs.SetFloat("bgm", Savedbgm);
        PlayerPrefs.SetFloat("sfx", Savedsfx);
        SceneManager.LoadSceneAsync(PlayerPrefs.GetString("Prev", "MainMenu"), LoadSceneMode.Single);
        
    }
    public void Apply()
    {
      
        PlayerPrefs.SetFloat("bgm", bgm);
        PlayerPrefs.SetFloat("sfx", sfx);
        SceneManager.LoadSceneAsync(PlayerPrefs.GetString("Prev", "MainMenu"), LoadSceneMode.Single);
      
    }
    public void BMGSlider()
    {
        bgm = BMG.value;
        Debug.Log("bgmmet" + bgm);
        mixer.SetFloat("BgmVol", Mathf.Log10(BMG.value) * 20);
    }
    public void SFXSlider()
    {
        sfx = SFX.value;
        mixer.SetFloat("AmbVol", Mathf.Log10(SFX.value) * 20);
    }
}