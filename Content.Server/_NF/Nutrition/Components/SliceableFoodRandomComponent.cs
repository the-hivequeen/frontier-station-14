using Content.Server._NF.Nutrition.EntitySystems;
using Content.Shared.Storage;
using Robust.Shared.Audio;

namespace Content.Server._NF.Nutrition.Components;

[RegisterComponent, Access(typeof(SliceableFoodRandomSystem))]
public sealed partial class SliceableFoodRandomComponent : Component
{
    /// <summary>
    /// The list of entities to spawn, with amounts and/or Groups.
    /// </summary>
    [DataField("possibleSlices", required: true)]
    public List<EntitySpawnEntry> PossibleSlices = new();

    [DataField]
    public SoundSpecifier Sound = new SoundPathSpecifier("/Audio/Items/Culinary/chop.ogg");

    /// <summary>
    /// Number of slices the food starts with.
    /// </summary>
    [DataField("count")]
    public ushort TotalCount = 5;

    /// <summary>
    /// how long it takes for this food to be sliced
    /// </summary>
    [DataField]
    public float SliceTime = 1f;

    /// <summary>
    /// all the pieces will be shifted in random directions.
    /// </summary>
    [DataField]
    public float SpawnOffset = 0.5f;
}