using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour {

    //Animator anim; /*Add special appear and dissapear effects later*/

    public float timer;
    float curTime;

    public PlayerMovement player;

	void Start ()
    {
        curTime = timer;
        gameObject.GetComponent<Image>().enabled = false;
        player.canMove = true;
        DisableIcons();
    }
	
	void Update ()
    {
        if (curTime <= 0)
        {
            EnableIcons();
            gameObject.GetComponent<Image>().enabled = true;
            player.canMove = false;
            //Put something here to disable enemy spawning
            //Put something here to destroy all enemies on screen (Preferably in an explosion)
        }
        else if (curTime >= 0)
        {
            curTime -= Time.deltaTime;
        }
	}

    public void ExitShop()
    {
        gameObject.GetComponent<Image>().enabled = false;
        player.canMove = true;
        DisableIcons();
        curTime = timer;
    }

    void DisableIcons()
    {
        foreach (RectTransform go in this.transform)
        {
            if (go.gameObject != gameObject)
            {
                go.gameObject.SetActive(false);
            }
        }
    }

    void EnableIcons()
    {
        foreach (RectTransform go in this.transform)
        {
            if (go.gameObject != gameObject)
            {
                go.gameObject.SetActive(true);
            }
        }
    }
}
