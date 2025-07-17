using UnityEngine;

public class PlayerModyfire : MonoBehaviour
{
    [SerializeField] private int _widht;
    [SerializeField] private int _height;

    float _widthMultiplier = 0.0005f;
    float _heightMultiplier = 0.01f;

    [SerializeField] private Renderer _renderer;
    [SerializeField] private Transform _topSpine;
    [SerializeField] private Transform _bottomSpine;
    [SerializeField] private Transform _colliderTransform;

    // Update is called once per frame
    void Update()
    {
        float offsetY = _height * _heightMultiplier +0.17f;
        _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);
        _colliderTransform.localScale = new Vector3(1, 1.84f + _height * _heightMultiplier, 1);

        if (Input.GetKeyDown(KeyCode.W))
        {
            AddWidht(20);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            AddHeight(20);
           
        }
    }

    public void AddWidht(int value)
    {
        _widht += value;
        _renderer.material.SetFloat("_PushValue", _widht * _widthMultiplier);
    }

    public void AddHeight(int value)
    {
        _height += value;
    }
}
