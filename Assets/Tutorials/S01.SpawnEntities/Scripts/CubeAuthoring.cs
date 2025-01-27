using Unity.Entities;
using UnityEngine;

// Authoring + Component + Baker
public class CubeAuthoring : MonoBehaviour
{
    public int speed;
}

public struct Cube : IComponentData
{
    public int speed;
}

public class CubeBaker : Baker<CubeAuthoring>
{
    public override void Bake(CubeAuthoring authoring)
    {
        //AddComponent<Cube>(); //Զ��д��

        var entity = GetEntity(TransformUsageFlags.Dynamic);
        AddComponent(entity, new Cube { speed = authoring.speed }); //ComponentData���������ԣ���Ҫ���
    }
}