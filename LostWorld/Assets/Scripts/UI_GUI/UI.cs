using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static UI instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    [SerializeField] public Image staminaImg;
    [SerializeField] public Image lifeImg;
    [SerializeField] public Image manaImg;

    public float life;
    public float stamina;
    public float mana;
   
    void Start()
    {
        life = 100;
        stamina = 100;
        mana = 100;
    }

  
    void Update()
    {
         staminaImg.fillAmount = stamina / 100;
         lifeImg.fillAmount = life / 100;
    }
}

