using DAL;

namespace App_WinForms
{
    public class PlayerImageChangedEventArgs : EventArgs
    {
        public Player Player { get; set; }
        public Image Image { get; set; }

        public PlayerImageChangedEventArgs(Player player, Image image)
        {
            Player = player;
            Image = image;
        }
    }
}