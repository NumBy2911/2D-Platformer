using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelsScreen : MonoBehaviour
{

    public LevelButton levelButton;
    public RectTransform parent;

    void Start()
    {
        LoadLevels();

    }

    void LoadLevels()
    {
        if (Directory.Exists("./Assets/Scenes/Levels/"))
        {

            DirectoryInfo d = new DirectoryInfo("./Assets/Scenes/Levels/");
            foreach (var file in d.GetFiles("*.unity"))
            {
                LevelButton l = Instantiate(levelButton, parent);
                l.Setup(file.Name.Split(".")[0]);
            }
        }
    }
}
