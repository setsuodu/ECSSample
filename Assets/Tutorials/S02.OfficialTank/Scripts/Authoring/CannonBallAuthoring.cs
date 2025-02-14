using Unity.Entities;
using Unity.Rendering;

class CannonBallAuthoring : UnityEngine.MonoBehaviour
{
}

class CannonBallBaker : Baker<CannonBallAuthoring>
{
    public override void Bake(CannonBallAuthoring authoring)
    {
        // By default, components are zero-initialized.
        // So in this case, the Speed field in CannonBall will be float3.zero.
        //AddComponent<CannonBall>();

        var entity = GetEntity(TransformUsageFlags.Dynamic);
        AddComponent(entity, new CannonBall());
    }
}