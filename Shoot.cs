using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public AudioSource shoot;
    private float betweenTimeAttack;
    public float maxTimeAttack = 1.2f;
    

    void Update()
    {
        if(Input.GetMouseButton(0)){
            this.GetComponent<Animation>().Play("TriggerAnim");
            if(betweenTimeAttack > maxTimeAttack){
                
                shoot.Play();
                betweenTimeAttack = 0;
            }
            betweenTimeAttack += Time.deltaTime;
            
        }
    
    }
}
