namespace CoreObjects
{
    /// <summary>
    /// Игровой объект (Одушевленные и неодушевленные)
    /// </summary>
    public class GameObject : CoreObject
    {
        /// <summary>
        /// Состояние обьекта (Испорченность или работоспособность)
        /// </summary>
        public int ConditionPoint { get; set; }

    }
}
