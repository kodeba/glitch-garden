using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControl : MonoBehaviour
{
    [SerializeField]
    private int numberOfAttacker = 0;

    bool levelTimerFinished = false;

    public void AttackerSpawned()
    {
        numberOfAttacker++;
    }

    public void AttackerKilled()
    {
        numberOfAttacker--;
        if(numberOfAttacker <= 0 && levelTimerFinished)
        {
            var navigator = FindObjectOfType<Navigator>();
            if (navigator)
            {
                navigator.WinScene();
            }
        }
    }

    public void LevelTimerFinised()
    {
        levelTimerFinished = true;
    }

    public bool IsLevelTimerFinised()
    {
        return levelTimerFinished;
    }

}
