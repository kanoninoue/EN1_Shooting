using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    //“G‚Ì”‚ğ”‚¦‚é—p‚Ì•Ï”
    private GameObject[] enemy;

    //ƒpƒlƒ‹‚ğ“o˜^‚·‚é
    public GameObject panel;
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        if(enemy.Length == 0)
        {
            panel.SetActive(true);
        }
    }
}
