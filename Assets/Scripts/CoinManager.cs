using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _numberCoinsInLevel;
    [SerializeField] private TextMeshProUGUI _text;
    public void AddOne() { 
        _numberCoinsInLevel ++;
        _text.text = _numberCoinsInLevel.ToString();
    }
}
