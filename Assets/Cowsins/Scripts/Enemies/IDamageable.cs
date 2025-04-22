
namespace cowsins
{
    /// <summary>
    /// Basically used for Player and enemies, which can be hit
    /// </summary>
    public interface IDamageable { void Damage(float damage, bool isHeadshot); }
}
