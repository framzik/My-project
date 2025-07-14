using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void UpdateLate()
    {
        transform.position = _target.position;
    }

}
