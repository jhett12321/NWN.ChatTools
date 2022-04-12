using System.Collections.Generic;
using Anvil.API;

namespace Jorteck.ChatTools
{
  public interface ICommandListProvider
  {
    public IReadOnlyList<IChatCommand> Commands { get; }

    public bool CanUseCommand(NwPlayer player, IChatCommand command);
  }
}
