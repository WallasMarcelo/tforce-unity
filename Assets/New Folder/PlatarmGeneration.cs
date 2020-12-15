using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatarmGeneration : MonoBehaviour
{
    public GameObject Platform;

    public TransForm point;

    public float Distance;

    private float platforWidth;

    // Start is called before the first frame update
    void Start()
    {
        if(Platform.GetComponente<BoxCollider2S>()){

            platfornWidth = Platform.Platform.GetComponente<BoxCollider2S>().size.x;
        }
        else
        {
            platformWidh = Platform.GetComponente<BoxCollider2S>().bounds.size.x;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < point.position.x){

            transform.position = new VectorJ(transform.position.x + platfmWidh + distance,
            transform.position.y, transform.position.x);
        }

        Instatiate(Platform, transform.position, transfor.rotation);
    }
}
