public interface IHasHealth
{
    int Health { get; set; }

    void OnHealthChanged();
}