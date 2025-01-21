
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

public class RoomHubs:Hub{

    public RoomService _roomService;
    public RoomHubs(RoomService roomService){
        _roomService = roomService;
    }

    public override async Task OnConnectedAsync()
    {
        await base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception exception)
    {
        return base.OnDisconnectedAsync(exception);
    }
}