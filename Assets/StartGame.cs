using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{

    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
