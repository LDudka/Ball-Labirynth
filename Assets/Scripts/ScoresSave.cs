using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Save", menuName = "Save", order = 1)]
public class ScoresSave : ScriptableObject
{
    [System.Serializable]
    public class Score
    {
        public string nick;
        public int pointsQuantity;

        public Score(string nick, int pointsQuantity)
        {
            this.nick = nick;
            this.pointsQuantity = pointsQuantity;
        }
    }

    public List<Score> scoreList = new List<Score>();
}
