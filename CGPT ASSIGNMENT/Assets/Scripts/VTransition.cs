using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VTransition : MonoBehaviour
{
    public GameObject ButtonToShow;
    private float totalTime = 166f;
    private float currentTime;

    void Start()
    {
        currentTime = totalTime;
        ButtonToShow.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime < 151f )
        {
            ButtonToShow.SetActive(true);
        }

        if (currentTime <= 0f)
        {
            SceneManager.LoadScene("LoadScene");
        }
    }

    public void Return()
    {
        SceneManager.LoadScene("LoadScene");
    }
}
