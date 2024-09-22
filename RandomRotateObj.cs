using UnityEngine;

public class RandomRotateObj : MonoBehaviour
{
    public GameObject[] objs;
    [Space(10)]
    public float _minRotX = 0f;
    public float _maxRotX = 360f;
    [Space(10)]
    public float _minRotY = 0f;
    public float _maxRotY = 360f;
    [Space(10)]
    public float _minRotZ = 0f;
    public float _maxRotZ = 360f;

    public void RotateRandom()
    {
        for (int i = 0; i < objs.Length; i++)
        {
            objs[i].transform.Rotate(Random.Range(_minRotX, _maxRotX), Random.Range(_minRotY, _maxRotY), Random.Range(_minRotZ, _maxRotZ));
        }
    }
}
