using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonSelectCharacter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image bgImage;
    public Text nameCharacter;
    public static int idChracter;

    public void OnPointerEnter(PointerEventData eventData)
    {
        bgImage.color = Color.green;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        bgImage.color = Color.black;
    }

    public void SelectCharacter(string name){
        nameCharacter.text = name;
        idChracter = 1;
    }

    public void SelectCharacter2(string name2) {
        nameCharacter.text = name2;
        idChracter = 2;
    }
     public void SelectCharacter3(string name3) {
        nameCharacter.text = name3;
        idChracter = 3;
    }
     public void SelectCharacter4(string name4) {
        nameCharacter.text = name4;
        idChracter = 4;
    }
}
