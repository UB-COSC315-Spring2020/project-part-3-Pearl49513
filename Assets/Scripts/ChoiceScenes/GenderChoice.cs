using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GenderChoice : MonoBehaviour
{
    //Setting up loading screen
    public GameObject loadingScreen;
    public Slider loadingSlider;
    public Text progressText;

    //Player Chooses female goes to female choice scene
    public void GenderF(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Player Chooses male goes to male choice scene
    public void GenderM(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Load Screen appears
    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            loadingSlider.value = progress;

            progressText.text = progress * 100f + "%";

            yield return null;
        }
    }
}
