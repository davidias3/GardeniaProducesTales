using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void PauseGame(){
        Time.timeScale--;
    }
    
    public void ResumeGame(){
        Time.timeScale++;
    }

    public void BackToMenu() {
        SceneManager.LoadScene(0);
    }
}
