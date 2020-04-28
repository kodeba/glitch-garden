using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashSceneController : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<Navigator>().SplashScreen();
    }
}
