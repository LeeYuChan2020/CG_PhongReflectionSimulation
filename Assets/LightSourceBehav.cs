using UnityEngine;

public class LightSourceBehav : MonoBehaviour
{
    // 광원의 z 축은 항상 양수
    public Vector3 Position { get => transform.position; }

    public float Ambient = 1;
    public float Diffuse = 1;
    public float Specular = 1;

    private float _radius = 32;
    private float _height = 32;

    // Update is called once per frame
    void Update()
    {
        float theta = Time.time;

        Vector3 position = new Vector3(_radius * Mathf.Cos(2 * theta), 0, _height);
        transform.position = position;
    }
}
