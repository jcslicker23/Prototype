using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
  public void Quit()
    {
        Application.Quit();
    }
    public void StartMenu()
    {
      Time.timeScale = 1f;
SceneManager.LoadScene("Start Screen 1");
    }
}
