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
            var levelControl = FindObjectOfType<LevelControl>();
            if (!levelControl.IsLevelTimerFinised())
            {
                levelControl.LevelTimerFinised();
            }
        }
    }
}
