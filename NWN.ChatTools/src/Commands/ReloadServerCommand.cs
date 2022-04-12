using System.Collections.Generic;
using Anvil;
using Anvil.API;
using Anvil.Internal;
using Anvil.Services;

namespace Jorteck.ChatTools
{
  [ServiceBinding(typeof(IChatCommand))]
  public class ReloadServerCommand : IChatCommand
  {
    public string Command => "reload";
    public string[] Aliases => null;
    public int? ArgCount => 0;

    public string Description => "Reload anvil plugins and services";

    public bool IsAvailable => EnvironmentConfig.ReloadEnabled;

    public CommandUsage[] Usages { get; } =
    {
      new CommandUsage("Triggers a reload of all anvil plugins and services. Requires hot reload to be enabled."),
    };

    public Dictionary<string, object> UserData { get; } = new Dictionary<string, object>
    {
      [ChatCommandConstants.Keys.DMOnly] = true,
    };

    public void ProcessCommand(NwPlayer caller, IReadOnlyList<string> args)
    {
      AnvilCore.Reload();
    }
  }
}

