using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void foodMenu()
    {
        SceneManager.LoadScene("FoodMenuScene");
    }

    public void settings()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void about()
    {
        SceneManager.LoadScene("AboutScene");
    }

    public void exit()
    {
        SceneManager.LoadScene("FoodMenuScene");
    }
}
