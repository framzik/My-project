using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    public void Play() { 
        _startMenu.SetActive(false);
    }
}
