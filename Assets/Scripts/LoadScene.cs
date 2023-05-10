using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public float delayTime = 10.0f; // The time to wait before loading the scene
    private void Start()
    {
        StartCoroutine(LoadNextSceneAfterDelay());
    }
    private IEnumerator LoadNextSceneAfterDelay()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(1);
    }
}
