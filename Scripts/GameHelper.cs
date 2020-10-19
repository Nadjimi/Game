using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Security.Cryptography;
using System.Globalization;
using System;

public class GameHelper : MonoBehaviour
{
    public int PlayerDamage = 10;
    public Slider HealthSlider;
    public Transform StartPosition;
    public GameObject GoldPrefab;
    public Text PlayerGoldUI;
    public int PlayerGold;
    public GameObject [] MonstersPrefabs;
    public Text Damage;

    int _count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerGoldUI.text = PlayerGold.ToString();
        Damage.text = PlayerDamage.ToString();
    }

    public void TakeGold(int gold)
    {
        PlayerGold += gold;
        GameObject goldObj = Instantiate(GoldPrefab) as GameObject;
        Destroy(goldObj, 2);

        
    }

    public void SpawnMonster()
    {
        _count++;

        int randomMaxValue = _count / 2 + 1; ;

        if (randomMaxValue >= MonstersPrefabs.Length)
            randomMaxValue = MonstersPrefabs.Length;
        int index = UnityEngine.Random.Range (0, randomMaxValue);
        GameObject monstObj = Instantiate(MonstersPrefabs[index])
            as GameObject;
        monstObj.transform.position = StartPosition.position;

       
    }
}

