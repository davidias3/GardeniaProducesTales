using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public void PauseResume() {
        if (Time.timeScale == 1) {
            PauseGame();
        } else {
            ResumeGame();
        }
    }

    void PauseGame(){
        Time.timeScale = 0;
    }
    void ResumeGame(){
        Time.timeScale = 1;
    }
}
