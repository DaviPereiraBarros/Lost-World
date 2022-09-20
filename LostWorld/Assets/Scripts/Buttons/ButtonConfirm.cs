using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonConfirm : MonoBehaviour
{
    public void Confirm(string cena){
       SceneManager.LoadSceneAsync(cena);
    }   
}
