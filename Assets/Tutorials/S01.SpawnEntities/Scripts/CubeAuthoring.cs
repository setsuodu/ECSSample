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
        //AddComponent<Cube>(); //远古写法

        var entity = GetEntity(TransformUsageFlags.Dynamic);
        AddComponent(entity, new Cube { speed = authoring.speed }); //ComponentData中所有属性，都要添加
    }
}