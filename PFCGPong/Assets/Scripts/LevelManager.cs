using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    //sets the level loading scenario//
    public void LoadLvl(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

    //this will allow the next level to be loaded//
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //StartGame function that will load the level//
    public void StartGame()
    {
        LoadNextLevel();
    }

    //QuitGame will stop the game but not exit unity//
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
