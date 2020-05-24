using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private float vel = 1f;
    private Transform alvo;
    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        perseguir();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            alvo = collision.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            alvo = null;
        }
    }
    void perseguir(){
        if(alvo != null){
            transform.position = Vector2.MoveTowards(transform.position, alvo.position, vel * Time.deltaTime);
            float dist = Vector2.Distance(transform.position, alvo.position);
            if(dist <= 0.8f){
                vel = 0;
            }else{
                vel = 1.5f;
            }
        }else{
            transform.position = Vector2.MoveTowards(transform.position, startPos, vel * Time.deltaTime);
        }


    }
}
