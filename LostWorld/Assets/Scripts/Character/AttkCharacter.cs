using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttkCharacter : MonoBehaviour
{
    public static AttkCharacter instance;
    
    private void Awake()
    {
        instance = this;
    }


    [SerializeField] private Texture2D cursor, cursorTarget;
    public Animator anim; 
    public CursorMode cursorMode = CursorMode.Auto;
    private Vector2 direcaoAttk = MovePersonagem.direcao;
    public Vector2 posCursor;
    private Vector2 character;
    public static Vector3 direction;
   
    void Start()
    {
       Cursor.SetCursor(cursor, posCursor, cursorMode); 

       character = new Vector2(8.8f, 4.8f);
       
    }
   
    void Update()
    {
        LeituraTeclado();
        Mira();

        if (direcaoAttk.x != 0 || direcaoAttk.y != 0 )
        {
            Animacao(direcaoAttk);
        }
        else
        {
            if(Input.GetButton("Fire1"))
            {
            anim.SetBool("Attk_Parado", true);
            CreateArrow.instanceArrow.Arrow();
            }
            else
            {
            anim.SetBool("Attk_Parado", false);
            }
        }
        
    }

    void LeituraTeclado()
    {
          if(Input.GetButton("Fire1"))
        {
            anim.SetBool("Attk", true);
        }
        else
        {
            anim.SetBool("Attk", false);
        }
    }

    void Animacao(Vector2 dir)
    {
        anim.SetLayerWeight(1, 1);
        anim.SetFloat("x", dir.x);
        anim.SetFloat("y", dir.y);
    }

    void Mira()
    {
        posCursor = Input.mousePosition /100;

        direction = character - posCursor; // Coloco o ponto inicial do player como zero, já que a coordenada zero estava no canto inferior esquerdo

        if(direction.x != 0 && direction.y != 0)
        {
            direction.x = Mathf.Floor(direction.x) * -1;
            direction.y = Mathf.Floor(direction.y) * -1;
        }

        if(direction.x >= 0)
        {
           anim.SetFloat("x", direction.x);
        }
        if(direction.x <= 0)
        {
            anim.SetFloat("x", direction.x);
        }
        if(direction.y >= 0)
        {
            anim.SetFloat("y", direction.y);
        }
        if(direction.y <= 0)
        {
            anim.SetFloat("y", direction.y);
        }
        
        //Debug.Log(direction);
    }
    public void Target()
    {
        Cursor.SetCursor(cursorTarget, posCursor, cursorMode); 
    }

    public void OutOfSight()
    {
        Cursor.SetCursor(cursor, posCursor, cursorMode); 
    }
}
