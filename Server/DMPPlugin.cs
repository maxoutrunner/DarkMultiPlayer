using System;
using DarkMultiPlayerCommon;


namespace DarkMultiPlayerServer
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DMPPluginAttribute : System.Attribute
    {
        //DMP will look for this attribute to load classes.
    }

    //Call your methods in your [DMPPlugin] class any of the following, minus the 'DMP' part. So DMPUpdate events require a method named Update.
    public delegate void DMPUpdate();
    public delegate void DMPOnServerStart();
    public delegate void DMPOnServerStop();
    public delegate void DMPOnClientConnect(ClientObject client);
    public delegate void DMPOnClientAuthenticated(ClientObject client);
    public delegate void DMPOnClientDisconnect(ClientObject client);
    public delegate void DMPOnMessageReceived(ClientObject client, ClientMessage messageData);
    public delegate void DMPOnMessageReceivedRaw(ClientObject client, ref ClientMessage messageData);
}
