using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBack : MonoBehaviour
{
    public GameObject canvasTela;
    public GameObject canvasMenu;
    public void Back()
    {
        canvasMenu.SetActive(false);
        canvasTela.SetActive(true);
    }

    public void Back2(string cena)
    {
       SceneManager.LoadSceneAsync(cena);
    }
}

