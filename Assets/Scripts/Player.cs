using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    private bool isJumping;
    private Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rig.Velocity = new Vector(Speed = Time.delTime, rig.velocity.y);

        if(Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            rig.AddForce(Vector2.up * JumpForce, FaceMode2D.Impulse);
            isJumping == true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(Collision.gameObject.layer == 8){
            isJumping = true;
        }
    }
}
