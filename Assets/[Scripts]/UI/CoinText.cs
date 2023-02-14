using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    // Start is called before the first frame update
    static int coinCount = 0;
    private Text cointText;

    void Start()
    {
        cointText = GetComponent<Text>();
    }
    private void OnEnable()
    {
        Coin.OnCoinCollected += IncreamentCoinCount;
    }

    private void OnDisable()
    {
        
        Coin.OnCoinCollected -= IncreamentCoinCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreamentCoinCount()
    {
        coinCount++;
        cointText.text = $"Coins: {coinCount}";
        //cointText.SetText($"Coins: {coinCount}");
    }
}