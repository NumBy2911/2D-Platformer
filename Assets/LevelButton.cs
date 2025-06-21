using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{

    public string levelName;
    public TextMeshProUGUI text;

    public void Setup(string levelName)
    {
        this.levelName = levelName;
        text.text = levelName;
    }


    public void OnClick()
    {
        SceneManager.LoadScene(levelName);
    }
}
