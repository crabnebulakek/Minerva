using Discord.Commands;
using System.Threading.Tasks;

namespace BigBrother.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {

        [Command("repeat")]
        public async Task Repeat(string repeat)
        {
            await Context.Channel.SendMessageAsync(repeat);
        }

    }
}
