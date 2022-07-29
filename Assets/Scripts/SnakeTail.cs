using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    public Transform SnakeHead;
    public List<Rigidbody2D> snakeCircles = new List<Rigidbody2D>();
    public bool move;

    private void Awake()
    {
        move = true;
    }

    private void Update()
    {
        
        if (move == true)
        {
            move = false;
            OnMove();
        }
    }
    void OnMove() 
    {
   
        snakeCircles[0].velocity = new Vector2(SnakeHead.position.x-snakeCircles[0].transform.position.x, snakeCircles[0].position.y) * Time.deltaTime * 1000;
        for (int i = 1; i < snakeCircles.Count; i++)
        {
            snakeCircles[i].velocity = new Vector2(snakeCircles[i-1].transform.position.x - snakeCircles[i].transform.position.x, snakeCircles[i].position.y)*Time.deltaTime*1000;
          
        }
        move = true;
    }

}