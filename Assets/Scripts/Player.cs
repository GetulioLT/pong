using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rig;

    public bool isPlayerOne;

    float mov;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }

    private void Movimento()
    {
        if (isPlayerOne)
        {
            mov = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            mov = Input.GetAxisRaw("Vertical2");
        }

        rig.velocity = new Vector2(rig.velocity.x, mov * speed);
    }
}
