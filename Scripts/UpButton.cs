using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class UpButton : MonoBehaviour
{

    public Text DamageText;
    public Text PriceText;

    public int Damage = 20;
    public int Price = 1000;
    GameHelper gameHelper;

    // Start is called before the first frame update
    void Start()
    {
        gameHelper = GameObject.FindObjectOfType<GameHelper>();
        DamageText.text = "+" + Damage.ToString();
        PriceText.text = Price.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UppClick()
    {
        if (gameHelper.PlayerGold >= Price)
        {
            gameHelper.PlayerGold -= Price;
            gameHelper.PlayerDamage += Damage;

            Destroy(gameObject);
        }
    }
}
