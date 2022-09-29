using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateArrow : MonoBehaviour
{
   public static CreateArrow instanceArrow;

    private void Awake()
    {
       instanceArrow = this;
    }

    public Rigidbody2D arrow;

    public Transform arrowTransform;
    
    void Start()
    {
       
    }

    
    void Update()
    {
        RotateArrow();   
    }

    public void Arrow()
    {
       Rigidbody2D arrowInst = Instantiate(arrow, arrowTransform.position, arrowTransform.rotation);
       arrowInst.AddForce(arrowTransform.forward * 2);
        
    }

    public void RotateArrow()
    {
       /* var dir = AttkCharacter.direction - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0,0,angle);*/
    }
}
