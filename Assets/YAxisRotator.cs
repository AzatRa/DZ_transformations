using UnityEngine;

public class YAxisRotator : MonoBehaviour
{
    [SerializeField] private float _yAxisRotationSpeed;

    void Update()
    {
        transform.Rotate(0, _yAxisRotationSpeed * Time.deltaTime, 0);
    }
}