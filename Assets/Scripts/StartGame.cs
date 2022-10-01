using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartGame : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider loadingBar;

    public void LoadScene(int index)
    {
        StartCoroutine(LoadSceneAsyncronously(index));
    }

    IEnumerator LoadSceneAsyncronously(int levelIndex)
    {
        loadingScreen.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        while(!operation.isDone)
        {
            loadingBar.value = operation.progress;
            yield return null;
        }
    }
}
