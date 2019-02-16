using System;
using System.ComponentModel.DataAnnotations;

namespace Treehouse.FitnessFrog.Models
{
    /// </summary>
    public class Entry
    {
        /// </summary>
        public enum IntensityLevel
        {
            Low,
            Medium,
            High
        }

        /// </summary>
        public Entry()
        {
        }

        public Entry(int id, int year, int month, int day, Activity.ActivityType activityType, 
            double duration, IntensityLevel intensity = IntensityLevel.Medium,
            bool exclude = false, string notes = null)
        {
            Id = id;
            Date = new DateTime(year, month, day);
            ActivityId = (int)activityType;
            Duration = duration;
            Intensity = intensity;
            Exclude = exclude;
            Notes = notes;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Activity")]
        public int ActivityId { get; set; }

        public Activity Activity { get; set; }

        /// The duration for the entry (in minutes).
        public double Duration { get; set; }

        /// The level of intensity for the entry.
        public IntensityLevel Intensity { get; set; }

        /// Whether or not this entry should be excluded when calculating the total fitness activity.
        public bool Exclude { get; set; }

        /// The notes for the entry.
        // [Required]
        [MaxLength(200, ErrorMessage = "The Notes field cannot be longer than 200 characters.")]
        public string Notes { get; set; }

    } // Close public class Entry
} // Close namespace Treehouse.FitnessFrog.Models