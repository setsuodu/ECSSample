using Unity.Burst;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

// System + Aspect
//[BurstCompile]
public partial struct CubeSystem : ISystem
{
    //[BurstCompile]
    public void OnCreate(ref SystemState state)
    {

    }

    //[BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        var dt = SystemAPI.Time.DeltaTime;

        foreach (var localTransform in SystemAPI.Query<RefRW<LocalTransform>>())
        {
            // ÒÆ¶¯
            //localTransform.ValueRW.Position = localTransform.ValueRO.Position + new float3(1,0,0)* SystemAPI.Time.DeltaTime;

            // Ðý×ª
            var rot = quaternion.RotateY(15 * dt);
            float3 fwd = math.mul(rot, localTransform.ValueRO.Forward());
            localTransform.ValueRW.Rotation = quaternion.LookRotation(fwd, localTransform.ValueRO.Up());
        }
    }
}