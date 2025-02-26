using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneAfterSecond : MonoBehaviour
{
    public LoadScene ls;
    public float second;
    public string sceneName;
    void Start()
    {
        Invoke("ChangeAfterSecond", second);
    }
    public void ChangeAfterSecond()
    {
        Debug.Log("Test!");
        ls.ChangeScene(sceneName);
    }
}
