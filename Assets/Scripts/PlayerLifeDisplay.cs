using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeDisplay : MonoBehaviour
{
    [SerializeField] int life = 5;
    private Text lifeText;

    void Start()
    {
        lifeText = GetComponent<Text>();
        UpdateLifeText();
    }

    private void UpdateLifeText()
    {
        if (life >= 0)
        {
            lifeText.text = life.ToString();
        }
    }

    public void GetHit() {
        life--;
        UpdateLifeText();
        if(life <= 0)
        {
            FindObjectOfType<Navigator>().LoadStartMenu();
        }
    }

}
