using Unity.Entities;

class TankAuthoring : UnityEngine.MonoBehaviour
{
}

class TankBaker : Baker<TankAuthoring>
{
    public override void Bake(TankAuthoring authoring)
    {
        //AddComponent<Tank>();

        var entity = GetEntity(TransformUsageFlags.Dynamic);
        AddComponent(entity, new Tank());
    }
}