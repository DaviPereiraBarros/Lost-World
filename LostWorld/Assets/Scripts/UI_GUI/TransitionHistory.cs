using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;


public class TransitionHistory : MonoBehaviour
{
    [SerializeField] public TimelineAsset lastScene;

    public GameObject end;
    
    void Start()
    {
        
    }

    
    void Update()
    {
       endAnimation();
    }

    private void endAnimation(){

       if(end.activeInHierarchy == true)
       {
         SceneManager.LoadSceneAsync("Fase1");
       }
    }
}
