using DAL;

namespace App_WinForms
{
    public class TournamentChoice(TournamentType value, string displayText)
    {
        public TournamentType Value { get; } = value;
        public string DisplayText { get; } = displayText;
    }
}