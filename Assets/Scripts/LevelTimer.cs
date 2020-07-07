using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{

    [Tooltip("leve time in second")]
    [SerializeField] int levelTime = 10;

    bool triggeredLevelFinished = false;


    void Update()
    {
        if (triggeredLevelFinished)
        {
            return;
        }

        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        if(Time.timeSinceLevelLoad >= levelTime)
        {
            FindObjectOfType<LevelControl>().LevelTimerFinised();
            triggeredLevelFinished = true;
        }
    }
}
