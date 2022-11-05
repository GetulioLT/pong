using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rig;
    Transform retorno;

    public float speed;
    bool cond = true;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        retorno = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Lancamento();
    }

    private void Lancamento()
    {
        if (Input.GetKeyUp(KeyCode.Space) && cond)
        {
            float x = Random.Range(-1, 1) == 0 ? -1 : 1;
            float y = Random.Range(-1, 1) == 0 ? -1 : 1;

            rig.velocity = new Vector2(x * speed, y * speed);

            cond = false;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gol1" || collision.gameObject.tag == "Gol2")
        {
            retorno.position = new Vector2(0, 0);

            rig.velocity = new Vector2(0, 0);

            cond = true;
        }
    }
}
