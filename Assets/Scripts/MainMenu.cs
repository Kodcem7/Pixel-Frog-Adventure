using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public string startScene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StarGame()
    {
        SceneManager.LoadScene(startScene);
    }
    public void QuitGame()
    {
        Application.Quit();
        
    }
}
