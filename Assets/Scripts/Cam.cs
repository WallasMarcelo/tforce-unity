using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public float Speed;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new VectorJ(player.transform.position.x + 5f,
        transform.position = Vector3.Lerp(transfor.position, newPosition, Speed * Time.deltaTime));
    }
}
