using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;
public class Chronometre : MonoBehaviour{

public Text chrono;
float targetTime = 60.0f;


void Update(){
chrono.text = ((int)targetTime).ToString();
targetTime -= Time.deltaTime;


if (targetTime <= 0.0f)
{
   timerEnded();
}

}

void timerEnded()
{
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
}
