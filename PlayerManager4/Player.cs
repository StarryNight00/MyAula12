using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerManager4
{
    /// <summary>
    /// A player.
    /// </summary>
    public class Player : IComparable<Player>
    {
        /// <summary>
        /// The name of the player.
        /// </summary>
        /// <value>A string representing the name of the player.</value>
        public string Name { get; }

        /// <summary>
        /// The score.
        /// </summary>
        /// <value>An integer representing the score of the player.</value>
        public int Score { get; set; }

        /// <summary>
        /// Creates a new player.
        /// </summary>
        /// <param name="name">The player name.</param>
        /// <param name="score">The initial player score.</param>
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        /// <summary>
        /// Compares two players' scores.
        /// </summary>
        /// <param name="other">The player that is being compared to the current player.</param>
        /// <returns></returns>
        public int CompareTo(Player other)
        {
            if (other == null) return -1;
            return other.Score - this.Score;
        }
    }
}
