using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour {
    //public string sceneName;
    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
