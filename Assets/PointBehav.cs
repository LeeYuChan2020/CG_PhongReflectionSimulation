using UnityEngine;

public class PointBehav : MonoBehaviour
{
    public LightSourceBehav LightSource { set; private get; }

    // point의 z 축은 항상 0
    private Vector3 _position { get => transform.position; }
    private Vector3 _normal { get => new Vector3(0, 0, 1); }

    // Material
    private float _ambientConstant = 0.2f;
    private float _diffuseConstant = 0.8f;
    private float _specularConstant = 0.5f;
    private float _specularShininessConstant = 32;

    void Update()
    {
        float intensity = GetIntensity();
        SetScale(intensity);
    }

    private void SetScale(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }

    private Vector3 GetCameraPosition()
    {
        Camera camera = Camera.main;
        Vector3 pos = camera.gameObject.transform.position;
        return pos;
    }
    private float GetIntensity()
    {
        // vector L 은 표면에서 광원까지의 단위벡터
        Vector3 L = (LightSource.Position - _position).normalized;

        // vector N 은 표면의 법선 단위벡터
        // 법선벡터 변경될 수 있으니 normalized 수행
        Vector3 N = _normal.normalized;

        // vector R 은 정반사 단위벡터
        // R + L = 2 * (L∙N) * N
        // R = 2 *(L∙N) * N - L
        Vector3 R = 2 * Vector3.Dot(L, N) * N - L;

        // vector V 는 표면에서 카메라로의 단위벡터
        Vector3 V = (GetCameraPosition() - _position).normalized;

        float ambient = _ambientConstant * LightSource.Ambient;
        float diffuse = _diffuseConstant * LightSource.Diffuse * Vector3.Dot(L, N);
        float specular = _specularConstant * LightSource.Specular * Mathf.Pow(Vector3.Dot(R, V), _specularShininessConstant);

        float intenstiy = ambient + diffuse + specular;
        return intenstiy;
    }
}
