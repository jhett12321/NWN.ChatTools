using System.Collections.Generic;
using Anvil.API;
using Anvil.Services;

namespace Jorteck.ChatTools
{
  [ServiceBinding(typeof(ICommandListProvider))]
  [ServiceBindingOptions(BindingPriority = BindingPriority.Lowest)]
  public class CommandListProvider : ICommandListProvider
  {
    [Inject]
    public IReadOnlyList<IChatCommand> Commands { get; init; }

    public virtual bool CanUseCommand(NwPlayer player, IChatCommand command)
    {
      if (command.UserData?.TryGetValue(ChatCommandConstants.Keys.DMOnly, out object dmOnly) == true)
      {
        return (bool)dmOnly == false || player.IsDM;
      }

      return true;
    }
  }
}
