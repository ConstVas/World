namespace CoreObjects.LifeObjects
{
    /// <summary>
    /// Одушевленные объекты
    /// </summary>
    public class AnimateObject : GameObject
    {
        /// <summary>
        /// Здоровье 
        /// </summary>
        public int HealthPoint { get; set; }

        /// <summary>
        /// Мертво
        /// </summary>
        public bool IsDead { get { return HealthPoint <= 0; } }

    }
}
