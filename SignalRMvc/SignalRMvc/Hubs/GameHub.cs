using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using SignalRMvc.Models;


namespace SignalRMvc.Hubs
{
    public class GameHub : Hub
    {
        List<Player> Players = new List<Player>();

        public void Connect(string username, int skinId, int color)
        {
            var id = Context.ConnectionId;

            if (!Players.Any(p => p.ConnectionId == id))
            {
                if (Players.Any(p => p.Name == username))
                {
                    // Such username exists
                }
                else
                {
                    Players.Add(new Player()
                    {
                        ConnectionId = id,
                        Name = username
                    });

                    // Посылаем сообщение текущему пользователю
                    Clients.Caller.onConnected(id, username, Players);

                    // Посылаем сообщение всем пользователям, кроме текущего
                    // Clients.AllExcept(id).onNewUserConnected(id, userName);
                }
            }
        }

        public void ChangeDir(int dir)
        {
            return;
        }
    }
}