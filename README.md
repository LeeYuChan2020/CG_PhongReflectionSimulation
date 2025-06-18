# Phong Reflection Simulation

이 시뮬레이션은 Computer Graphics에서 배운 **Phong Reflection Model**을 기반으로 한 광원 반사 계산을 Unity 엔진 내에서 구현 및 확장한 것입니다.


각 **Sphere 객체(Point)** 는 고유의 월드 공간 상의 위치(Position)와 법선 벡터(Normal Vector)를 가진 vertex 역할을 하고,

이 정보를 바탕으로, 광원 역할을 하는 빨간색 **Sphere 객체(Light Source)** 의 위치, 그리고 **카메라(Camera)** 의 위치를 입력값으로 사용하여

**Ambient, Diffuse, Specular** 세 가지 성분으로 구성된 Phong Reflection Model을 실시간으로 시뮬레이션합니다

---
## Ambient

[Movie_Ambient.webm](https://github.com/user-attachments/assets/5572d8eb-d998-4527-87cc-91458847fb4b)

## Diffuse

[Movie_Diffuse.webm](https://github.com/user-attachments/assets/4a22bc83-8acb-4e65-a399-d6d38ac85e01)

## Specular

[Movie_Specular.webm](https://github.com/user-attachments/assets/44863f93-0b5b-41f7-886d-22ea8c3f9840)

## 최종 결과 : Phong Reflection Model

[Movie_PhongReflection.webm](https://github.com/user-attachments/assets/ccf214a0-e01f-46be-b0a3-f96d1fa1d134)


