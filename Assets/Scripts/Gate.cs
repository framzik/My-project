using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] private int _value;
    [SerializeField] private DefomationType _defomationType;
    [SerializeField] private GateApperance _gateApperance;

    private void OnValidate()
    {
        _gateApperance.UpdateVisual(_defomationType, _value);
    }

}
