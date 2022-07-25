using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemus : MonoBehaviour
{
    public Transform snack;

    void Update()
    {
        if (transform.position.y < snack.position.y)
        {
            Move();
        }

    }

    public void Move()
    {
        float rnd = Random.Range(-148, -140);
        transform.localPosition = new Vector2(rnd, snack.localPosition.y + 10);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
