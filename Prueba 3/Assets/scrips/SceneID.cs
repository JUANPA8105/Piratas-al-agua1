using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneID : MonoBehaviour
{
    public int sceneID;
    public void ChangeSceneID()
    {
        ChangeScene.tagScene = sceneID;
    }
}
