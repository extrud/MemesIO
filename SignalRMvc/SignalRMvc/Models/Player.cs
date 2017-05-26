using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRMvc.Models
{
    public class Player
    {
        [JsonProperty("id")]
        public string ConnectionId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("positionX")]
        public int PositionX { get; set; }
        [JsonProperty("positionY")]
        public int PositionY { get; set; }
        [JsonProperty("moveX")]
        public int MoveX { get; set; }
        [JsonProperty("moveY")]
        public int MoveY { get; set; }
        [JsonProperty("isDead")]
        public bool IsDead { get; set; }


    }
}