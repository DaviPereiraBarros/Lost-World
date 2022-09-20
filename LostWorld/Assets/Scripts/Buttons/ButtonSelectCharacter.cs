using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonSelectCharacter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    List<DataPersona> data = new List<DataPersona>();

    public Image bgImage;
    public Text nameCharacter;
    //public Text data;
    private int idChracter;

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
}
