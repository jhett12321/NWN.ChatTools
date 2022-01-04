using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Jorteck.ChatTools
{
  [Serializable]
  internal sealed class Config
  {
    public const string ConfigName = "config.yml";

    public int Version { get; set; } = 1;

    [Description("Character prefixes that define if a message is detected as a command.")]
    public List<string> CommandPrefixes { get; set; } = new List<string> { "/" };

    [Description("A list of words/prefixes that are ignored by command processing. E.g. '/' ignores all usages of '//' if the command prefix is /.")]
    public List<string> IgnoreCommands { get; set; } = new List<string> { "/" };
  }
}
