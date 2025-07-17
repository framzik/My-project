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

    private void OnTriggerEnter(Collider other)
    {
        PlayerModyfire playerModyfire = other.attachedRigidbody.GetComponent<PlayerModyfire>();
        if (playerModyfire != null)
        {
            if (_defomationType == DefomationType.Widht)
            {
                playerModyfire.AddWidht(_value);
            }
            else if (_defomationType == DefomationType.Height)
            {
                playerModyfire.AddHeight(_value);
            }

        }
    }
}
