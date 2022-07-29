using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemus : MonoBehaviour
{
    public Transform snack;
    public List<Sprite> _sprite;
    private int score=0;
    [SerializeField]
    private Text text;
    private int number;
    [SerializeField]
    private Image image;
    [SerializeField]
    private Rigidbody2D _rigidbody2D;
    public bool move;

    void Update()
    {
        text.text = "" + score;
        if (move == false)
        {
            if (snack.GetComponent<SnakeMovement>().Click == true)
            {
                move = true;
                StartCoroutine(Move());
            }
        }

        if (transform.localPosition.y < -408)
         {
                Restart();
         }
        
    }

    public void Restart()
    {
        float rnd = Random.Range(-140, 140);
        score++;
        number = Random.Range(0,5);

        image.sprite = _sprite[number];
        transform.localPosition = new Vector2(rnd,400);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(0.0001f/1000000000000);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - 2);
        move = false;
    }
}
