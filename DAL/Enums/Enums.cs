using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public enum TournamentType { Men, Women }
    public enum Position { Defender, Forward, Goalie, Midfield };
    public enum Tactics { The3421, The343, The352, The4231, The4321, The433, The442, The451, The532, The541 };
    public enum StageName { Final, FirstStage, PlayOffForThirdPlace, QuarterFinals, RoundOf16, SemiFinals };
    public enum Status { Completed };
    public enum Time { FullTime };
    public enum Description { ClearNight, Cloudy, PartlyCloudy, PartlyCloudyNight, Sunny };
    public enum TypeOfEvent { Goal, GoalOwn, GoalPenalty, RedCard, SubstitutionIn, SubstitutionOut, YellowCard, YellowCardSecond };
}
