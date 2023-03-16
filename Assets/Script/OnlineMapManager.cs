using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlineMapManager : MonoBehaviour
{
    public void ChangeScene(string name)
    {
        Time.timeScale = 1;
        SceneController.instance.LoadToScene(name);
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
}
