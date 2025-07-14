using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _numberCoinsInLevel;
    public void AddOne() { 
        _numberCoinsInLevel ++;
    }
}
