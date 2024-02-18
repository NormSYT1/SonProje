using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject settingsPanel;
    public AudioSource audioSource;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
        audioSource.Play();
    }
    public void SettingsButton()
    {
        settingsPanel.SetActive(true);
        audioSource.Play();
    }
    public void BackButton()
    {
        settingsPanel.SetActive(false);
        audioSource.Play();
    }
    public void QuitGame()
    {
        Application.Quit();
        audioSource.Play();
    }
}
