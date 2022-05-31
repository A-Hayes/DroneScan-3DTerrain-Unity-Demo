// Author - Asa Hayes
// Modified/converted from pre-existing Unity-JavaScript
// Credit for original code - Jimmy Vegas (https://www.youtube.com/watch?v=HZRWJ7_17Mc)

using System.Collections;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine;
using System;
public class ExitCar : MonoBehaviour
{
    public GameObject CarCam;
    public GameObject ThePlayer;
    public GameObject ExitTrigger;
    public GameObject TheCar;
    public GameObject ExitPlace;
    
    
    
    void Update(){
        if( Input.GetButtonDown("Action") ){
          CarCam.SetActive(false);
          ThePlayer.SetActive(true);
          ThePlayer.transform.position = ExitPlace.transform.position;
          TheCar.GetComponent<CarController>().enabled = false;
          TheCar.GetComponent<CarUserControl>().enabled = false;
          ExitTrigger.SetActive(false);
        }
    }
}