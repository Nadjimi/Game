using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hit : MonoBehaviour
{
    GameHelper gameHelper;
    HeroHelper heroHelper;
    // Start is called before the first frame update
    void Start()
    {
        gameHelper = GameObject.FindObjectOfType<GameHelper>();
        heroHelper = GameObject.FindObjectOfType<HeroHelper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GetComponent<Animator>().SetTrigger("Hit");

        GetComponent<HealthHelper>().GetHit(gameHelper.PlayerDamage);
        heroHelper.RunAttack();
    }
}
