using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private Transform target;
    public float dist;
    public float speed;
    private Vector2 direcao;
    public Animator animEnemy; 
    private Rigidbody2D enemyRB;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Character").GetComponent<Transform>();
        enemyRB = GetComponent<Rigidbody2D>();
        direcao = Vector2.zero;
    } 

    void Update()
    {
        Detect();
        Follow();
        Animacao(direcao);
    }

    private void FixedUpdate()
    {
        enemyRB.MovePosition(enemyRB.position + direcao * speed * Time.deltaTime);
    }

    void Detect()
    {
        direcao = Vector2.zero;
        float diferencaParaJogadorX = transform.position.x - target.transform.position.x; 
        float diferencaParaJogadorY = transform.position.y - target.transform.position.y;

        if(diferencaParaJogadorX > 1)
        {
            direcao += Vector2.left;
        }
        if(diferencaParaJogadorX < -1)
        {
            direcao += Vector2.right;
        }
        if(diferencaParaJogadorY > 1)
        {
            direcao += Vector2.down;
        }
        if(diferencaParaJogadorY < -1)
        {
            direcao += Vector2.up;
        }
        
    }

    void Follow()
    {
        float distancia = Vector2.Distance(transform.position, target.position);

        if(distancia > dist)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            Detect();
        }

        if(distancia < 1.5f)
        {
            animEnemy.SetBool("Attack", true);
        }
        else
        {
            animEnemy.SetBool("Attack", false);
            
        }

    }

    void Animacao(Vector2 dir)
    {
        animEnemy.SetFloat("x", dir.x);
        animEnemy.SetFloat("y", dir.y);
    }
}