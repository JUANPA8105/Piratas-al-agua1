using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static int tagScene;
    public int sceneID;
    public void ChangeSceneID()
    {
        tagScene = sceneID;
    }
    public void loadScene()
    {
        SceneManager.LoadScene(tagScene);
    }
}
