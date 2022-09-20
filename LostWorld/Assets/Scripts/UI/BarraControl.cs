using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraControl : MonoBehaviour
{
    private Image barraImg;
    // Start is called before the first frame update
    void Start()
    {
        barraImg = GetComponent<Image>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            barraImg.fillAmount -= 0.1f * Time.deltaTime;
        }
        else if (barraImg.fillAmount < 1)
        {
            barraImg.fillAmount += 0.3f * Time.deltaTime;
        }
    }
}
