using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float speed = 10f;
    public float lowGravity = 0.5f;  // Valor menor para gravidade leve durante o voo
    public float normalGravity = 1f; // Gravidade padrão quando não está voando
    public LogicSc logic;
    public bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicSc>();
        myRigidBody.gravityScale = normalGravity;  // Definir gravidade padrão
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.gravityScale = lowGravity;  // Ajusta gravidade para um voo leve
            myRigidBody.velocity = Vector2.up * speed;  // Aplicar força para cima
        }

        // Quando o jogador solta a tecla, retorna a gravidade ao normal
        if (Input.GetKeyUp(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.gravityScale = normalGravity; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        myRigidBody.gravityScale = normalGravity; // Reseta gravidade no game over
    }
}
