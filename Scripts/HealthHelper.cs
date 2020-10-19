using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class HealthHelper : MonoBehaviour
{
    public Transform StartPosition;
    public int MaxHealth = 100;
    public int Health = 100;
    public int Gold = 50;
    public GameObject[] MonstersPrefabs;

    GameHelper gameHelper;

    // Start is called before the first frame update
    void Start()
    {
        gameHelper = GameObject.FindObjectOfType<GameHelper>();
        gameHelper.HealthSlider.maxValue = MaxHealth;
        gameHelper.HealthSlider.value = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetHit(int damage)
    {
        int health = Health - damage;

        if (health <= 0)
        {
            gameHelper.PlayerGold += Gold;
            Destroy(gameObject);
            gameHelper.SpawnMonster();

                    }

        Health = health;
        gameHelper.HealthSlider.value = Health;
          }

    

}
