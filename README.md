이 시뮬레이션은 Computer Graphics에서 배운 **Phong Reflection Model**을 기반으로 한 광원 반사 계산을 Unity 엔진 내에서 구현 및 확장한 것입니다.


각 **Sphere 객체(Point)** 는 고유의 월드 공간 상의 위치(Position)와 법선 벡터(Normal Vector)를 가진 vertex 역할을 하고,

이 정보를 바탕으로, 광원 역할을 하는 빨간색 **Sphere 객체(Light Source)**의 위치, 그리고 **카메라(Camera)**의 위치를 입력값으로 사용하여

**Ambient, Diffuse, Specular** 세 가지 성분으로 구성된 Phong Reflection Model을 실시간으로 시뮬레이션합니다.
