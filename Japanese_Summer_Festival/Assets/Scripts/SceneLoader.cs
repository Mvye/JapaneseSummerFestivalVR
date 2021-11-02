using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
    public void startGame() {
        StartCoroutine(LoadSummerFestivalAsync());
    }
    IEnumerator LoadSummerFestivalAsync() {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1);
        while (!asyncLoad.isDone) {
            yield return null;
        }
    }
}
