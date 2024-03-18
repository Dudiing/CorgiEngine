using UnityEngine;
using MoreMountains.CorgiEngine;

public class CoinsToNextScene : MonoBehaviour
{
    public GameObject portal;
    private int collectedCoins = 0;
    private int totalCoins = 10;

    private void Start()
    {
        portal.SetActive(false); 
        // Nos suscribimos al evento estático de la clase Coin
        Coin.OnCoinCollectedStatic.AddListener(AddCoin);
    }

    private void OnDestroy()
    {
        // Nos aseguramos de cancelar la suscripción al evento al destruir el objeto
        Coin.OnCoinCollectedStatic.RemoveListener(AddCoin);
    }

    private void AddCoin()
    {
        collectedCoins++;
        CheckCollectedCoins();
    }

    private void CheckCollectedCoins()
    {
        if (collectedCoins >= totalCoins)
        {
            portal.SetActive(true);
        }
    }
}
