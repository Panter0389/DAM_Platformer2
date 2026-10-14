using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    int playerCoins = 0;

    public TextMeshProUGUI coinsText;


    public void AddCoin(int value)
    {
        playerCoins += value;

        coinsText.text = playerCoins.ToString();
    }


}
