using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{

    public Image black;
    public Animator anim;

    [SerializeField] int layerToDisable = 0;
    public GameObject[] parentObjects;

    private void Update()
    {
        CollectibleCount();
    }

    private bool CollectibleCount()
    {
        foreach (Transform child in transform)
        {
            if (!child.gameObject.activeInHierarchy) continue;
            return false;
        }
        CheckStage();
        
        return true;
    }

    private void CheckStage()
    {
        if(gameObject.name == "OnArrival")
        {
            //StartCoroutine(Fade());
            SceneManager.LoadScene("Credits");
        }
        else
        {
            DisableLayer(layerToDisable); 
        }
    }

    void DisableLayer(int layer)
    {
        this.transform.parent.gameObject.SetActive(false);


        /*
            // Disable the current active parent
            if (layer < parentObjects.Length)
                parentObjects[layer].SetActive(false);
        */
            // Move to the next parent index
            layerToDisable = (layerToDisable + 1) % parentObjects.Length;

            // Activate the next parent
            parentObjects[layerToDisable].SetActive(true);
        

    }

    IEnumerator Fade()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
//        yield return new WaitForSeconds(3f);
//        SceneManager.LoadScene("Credits");
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Credits");
    }

}
