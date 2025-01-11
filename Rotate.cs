using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _xAxisRotationSpeed;
    [SerializeField] private float _yAxisRotationSpeed;
    [SerializeField] private float _zAxisRotationSpeed;

    void Update()
    {
        transform.Rotate(_xAxisRotationSpeed, _yAxisRotationSpeed, _zAxisRotationSpeed);
    }
}
