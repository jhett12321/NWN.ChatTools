using Anvil.API;

namespace Jorteck.ChatTools
{
  internal static class PlayerExtensions
  {
    public static void SendErrorMessage(this NwPlayer player, string message)
    {
      player.SendServerMessage(message, ColorConstants.Red);
    }
  }
}
