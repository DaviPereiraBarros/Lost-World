using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePersonagem : MonoBehaviour
{
    public float velocidade;
    public float velocidadeRun;
    public float velocidadeWalk;
    public static Vector2 direcao;
    public Animator anim; 
    private Rigidbody2D heroiRB;


    void Start()
    {
        heroiRB = GetComponent<Rigidbody2D>();
        direcao = Vector2.zero;
    }   
        
    
    void Update()
    {
        InputPersonagem();
    
        if (direcao.x != 0 || direcao.y != 0 )
        {
            Animacao(direcao);
        }
        else
        {
            anim.SetLayerWeight(1, 0);
        }
    }
    
    private void FixedUpdate()
    {
        heroiRB.MovePosition(heroiRB.position + direcao * velocidade * Time.deltaTime);
    }
    private void LateUpdate()
    {
          
    }

    void InputPersonagem()
    {
        direcao = Vector2.zero;
        
        if (Input.GetKey(KeyCode.UpArrow) ||  Input.GetKey(KeyCode.W))
        {
            direcao += Vector2.up;
           
        }
        if (Input.GetKey(KeyCode.DownArrow) ||  Input.GetKey(KeyCode.S))
        {
            direcao += Vector2.down;
            
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            direcao += Vector2.right;
            
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            direcao += Vector2.left;
        }
        

        if(Input.GetKey(KeyCode.LeftShift) && UI.instance.stamina >= 0.2f)
          {
             velocidade = velocidadeRun;

             for(int i = 0; i <= 2000; i++)
             {
                UI.instance.stamina -= 0.0001f;
                
             }
          }
          else 
          {
            velocidade = velocidadeWalk;
          }
        
    }

    void Animacao(Vector2 dir)
    {
        anim.SetLayerWeight(1, 1);
        //anim.SetFloat("x", dir.x);
        //anim.SetFloat("y", dir.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Inimigo")){
            UI.instance.life -= 5;
        }
        
    }

}
