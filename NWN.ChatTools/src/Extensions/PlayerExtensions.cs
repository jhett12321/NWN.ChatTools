using Anvil.API;

namespace Jorteck.ChatTools
{
  public static class PlayerExtensions
  {
    public static void SendErrorMessage(this NwPlayer player, string message)
    {
      player.SendServerMessage(message, ColorConstants.Red);
    }
  }
}
