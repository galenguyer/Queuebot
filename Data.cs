﻿using Discord.Commands;

namespace QueueBot
{
    public class UserData
    {
        private ulong userId;
        private string userName;
        private bool isBlacklisted;

        public UserData(CommandEventArgs e)
        {
            userId = e.Message.User.Id;

            if (e.Message.User.Nickname.Length >= 1) userName = e.Message.User.Nickname;
            else userName = e.Message.User.Name;

            if (userBlacklist.blacklist.Contains(userId.ToString())) isBlacklisted = true;
            else isBlacklisted = false;
        }
    }

    public class ServerData
    {
        private ulong serverId;
        private string serverName;

        public ServerData(CommandEventArgs e)
        {
            serverId = e.Message.Server.Id;
            serverName = e.Message.Server.Name;
        }
    }
}
