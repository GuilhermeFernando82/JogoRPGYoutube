using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 direcao;
    public float speed;
    public Animator anim;
    
    void Start()
    {
        direcao = Vector2.zero;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(direcao.x != 0 || direcao.y != 0){
            animations(direcao);
        }else{
            anim.SetLayerWeight(1,0);
        }
        inputplayer();
        
        transform.Translate(direcao * speed * Time.deltaTime);
        
    }
    void inputplayer()
    {
        direcao = Vector2.zero;
        if(Input.GetKey(KeyCode.UpArrow)){
            direcao += Vector2.up;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            direcao += Vector2.down;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            direcao += Vector2.left;
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            direcao += Vector2.right;
        }
    }
    void animations(Vector2 dir){
        anim.SetLayerWeight(1,1);
        anim.SetFloat("x", dir.x); 
        anim.SetFloat("y", dir.y);
    }
}
