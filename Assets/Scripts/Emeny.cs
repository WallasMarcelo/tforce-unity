using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny : MonoBehaviour
{
    public float Speed;
    private Transform backPoint;
    private Animator animator;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        backPoint = GameObject.Find("backpoint").GetComponent<Transform>();
        animator = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2dD>();
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(Vector3.lef + Speed * Time.deltaTime());
        rig.velocity = new Vector2(-Speed rig.velocity.y);
        if(transform.position.x < backPoint.position.x){
            Destroy(gameObject);
        }
    }

   void OnTriggerEnter2D(Collider2D collision) {

      if(collision.gameObject.tag == "bullet"){
        
        animator.SetTrigger("destroy");
        Destroy(gameObject, 1f);
      }

    }
}
