using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EscMenuController : MonoBehaviour
{
    public GameObject escMenu;
    public GameObject settingsMenu;
    public AudioSource audioSource;
    void Start()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escMenu.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;
        }
    }
    public void ResumeButton()
    {
        Cursor.visible = false;
        audioSource.Play();
        Time.timeScale = 1f;
        escMenu.SetActive(false);
    }
    public void SettingsButton()
    {
        audioSource.Play();
        settingsMenu.SetActive(true);
        Cursor.visible = true;
    }
    public void QuitButton()
    {
        audioSource.Play();
        SceneManager.LoadScene("MenuScene");
    }
    public void BackButton()
    {
        audioSource.Play();
        settingsMenu.SetActive(false);
    }
}
