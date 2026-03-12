using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private int coins = 0;

    private void Start()
    {
        UpdateUI();
    }
    public void AddCoins(int amount)
    {
        coins += amount;
        UpdateUI();
    }

    public void UpdateUI()
    {
        coinsText.text = "Coins: " + coins;
    }
}
