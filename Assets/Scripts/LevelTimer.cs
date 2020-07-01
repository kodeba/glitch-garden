using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{

    [Tooltip("leve time in second")]
    [SerializeField] int levelTime = 10;

    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        if(Time.timeSinceLevelLoad >= levelTime)
        {
            Debug.Log("Time up");
        }
    }
}
