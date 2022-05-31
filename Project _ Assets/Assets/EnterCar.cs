// Author - Asa Hayes
// Modified/converted from pre-existing Unity-JavaScript
// Credit for original code - Jimmy Vegas (https://www.youtube.com/watch?v=HZRWJ7_17Mc)

using System.Collections;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine;
using System;
public class EnterCar : MonoBehaviour
{
    public GameObject CarCam;
    public GameObject ThePlayer;
    public GameObject ExitTrigger;
    public GameObject TheCar;
    public int TriggerCheck;
    
    void OnTriggerEnter(Collider col){
      TriggerCheck = 1;
    }
    
    void OnTriggerExit(Collider col){
      TriggerCheck = 0;
    }
    
    void Update(){
      if(TriggerCheck == 1){
        if( Input.GetButtonDown("Action") ){
          CarCam.SetActive(true);
          ThePlayer.SetActive(false);
          TheCar.GetComponent<CarController>().enabled = true;
          TheCar.GetComponent<CarUserControl>().enabled = true;
          ExitTrigger.SetActive(true);
        }
      }
    }
}