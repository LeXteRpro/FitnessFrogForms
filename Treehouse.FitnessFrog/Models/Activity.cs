namespace Treehouse.FitnessFrog.Models
{
    /// </summary>
    public class Activity
    {
        /// </summary>
        public enum ActivityType
        {
            Basketball = 1,
            Biking = 2,
            Hiking = 3,
            Kayaking = 4,
            PokemonGo = 5,
            Running = 6,
            Skiing = 7,
            Swimming = 8,
            Walking = 9,
            WeightLifting = 10
        }

      /// Constructors an activity for the provided activity type and name.
        public Activity(ActivityType activityType, string name = null)
        {
            Id = (int)activityType;

            // If we don't have a name argument, 
            // then use the string representation of the activity type for the name.
            Name = name ?? activityType.ToString();
        }

        /// <summary>
        public int Id { get; set; }

        /// <summary>
        public string Name { get; set; }
    }
}