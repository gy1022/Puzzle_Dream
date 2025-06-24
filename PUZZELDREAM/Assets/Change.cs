using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("MainScene2");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("MainScene");
    }
}
