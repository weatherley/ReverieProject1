using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class CharacterControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Anim;

    private void Awake()
    {
        Anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Turn();
        //Movement();
        Move();
        Jump();
    }

    void Turn()
    {
        Anim.SetFloat("Turning", Input.GetAxis("Horizontal"));
        //Debug.Log(Input.GetAxis("Horizontal"));
    }
    void Movement()
    {
        
        Anim.SetFloat("Forward", Input.GetAxis("Vertical"));

    }

    void Move()
    {
        if (Anim.GetBool("Walk")){
            Anim.SetFloat("MoveZ", Mathf.Clamp(Input.GetAxis("MoveZ"), -0.25f, 0.25f));
            Anim.SetFloat("Movex", Mathf.Clamp(Input.GetAxis("MoveX"), -0.25f, 0.25f));
        }
        else
        {
            Anim.SetFloat("MoveZ",(Input.GetAxis("MoveZ")));
            Anim.SetFloat("MoveX", (Input.GetAxis("MoveX")));
        }

    }
    void Jump()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Anim.SetTrigger("Jump");
        }

    }
}
