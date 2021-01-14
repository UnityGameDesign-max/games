using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCollect : MonoBehaviour{

    public GameObject SciGun;


    void Start(){
      
    }

    void OnTriggerEnter(Collider other) {
        
        SciGun.SetActive(true);
        SciGun.GetComponent<Animation>().Play("GunTriggerAnim");
        this.gameObject.SetActive(false);
    }
}
