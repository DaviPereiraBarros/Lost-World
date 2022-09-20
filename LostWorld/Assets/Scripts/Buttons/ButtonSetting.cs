using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSetting : MonoBehaviour
{
    public GameObject panelSetting;

    public void Setting()
    {
       panelSetting.SetActive(true);
    }
}
